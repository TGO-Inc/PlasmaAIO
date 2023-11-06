using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;

namespace PrefabUtil.Extensions
{
    public static class Extensions
    {
        private static readonly string[] remove_props = new string[]
        {
            //"fileID",
            "serializedVersion",
            //"m_Component",
            //"m_PrefabAsset",
            "m_PrefabInstance",
            "m_CorrespondingSourceObject",
            //"m_ObjectHideFlags",
            //"m_Icon",
            //"m_NavMeshLayer",
            "m_StaticEditorFlags",
            "m_EditorHideFlags",
            "m_Father",
            "m_GameObject",
            "m_Children"
        };
        internal static bool FindStringValue(this JToken source, ref string target)
            => ((JObject)source).FindStringValue(ref target);
        internal static bool FindStringValue(this JObject source, ref string target)
        {
            foreach (var prop in source.Properties())
            {
                if (prop.Name.Equals(target))
                {
                    target = prop.Value.ToString();
                    return true;
                }

                if (prop.Value is JObject)
                    if (prop.Value.FindStringValue(ref target))
                        return true;

                if (prop.Value is JArray)
                    foreach (var item in prop.Value)
                        if (item.FindStringValue(ref target))
                            return true;
            }
            return false;
        }
        internal static string GetValueString(this JObject source, string target)
         => source.FindStringValue(ref target) ? target : string.Empty;
        internal static JObject StripGameObject(this JObject jobj)
        {
            List<JProperty> remove = new List<JProperty>();

            foreach (var prop in jobj.Properties())
            {
                if (prop.Value is JObject)
                    prop.Value = prop.Value.StripGameObject();
                if (prop.Value is JArray)
                {
                    JArray repl = new JArray();
                    foreach (var item in prop.Value)
                        repl.Add(item.StripGameObject());
                    prop.Value = repl;
                }
                if (remove_props.Contains(prop.Name))
                    remove.Add(prop);
            }

            foreach (var prop in remove)
                prop.Remove();

            var @fixed = jobj.Properties().ToArray();
            jobj.RemoveAll();

            foreach (var fix in @fixed)
            {
                string new_name = fix.Name;
                if (new_name.StartsWith("m_"))
                {
                    new_name = new_name.Substring(2);
                    new_name = new_name[0].ToString().ToLower() + new_name.Substring(1);
                }
                var @new = new JProperty(new_name, fix.Value);
                jobj.Add(@new);
            }

            return jobj;
        }
        internal static JObject StripGameObject(this JToken jobj)
            => ((JObject)jobj).StripGameObject();

        public static string[] Split(this string s, string split_param)
            => s.Split(new string[] { split_param }, StringSplitOptions.RemoveEmptyEntries);

        public static string Join(this IEnumerable<string> s, string deltimer = "\n")
            => string.Join(deltimer, s);

        public static IEnumerable<string> MaxLength(this IEnumerable<string> s, int count)
            => s.Count() <= count ? s : s.TakeWhile(i => count-- > 0);

        internal static YamlStream ReadYaml(this string input)
        {
            var yaml_manager = new YamlStream();
            yaml_manager.Load(input);
            return yaml_manager;
        }
        internal static void Load(this YamlStream stream, string input)
            => stream.Load(new StringReader(input));

        internal static object ToObject(this YamlDocument doc)
        {
            var stream = new YamlStream { doc };
            var writer = new StringWriter();
            stream.Save(writer);

            Dictionary<long, object> list = new Dictionary<long, object>();
            string formatted = Regex.Replace(writer.ToString().Trim(), "\n...$", string.Empty);
            formatted = Regex.Replace(formatted, "\r\n", "\n");
            formatted = Regex.Replace(formatted, "(?<=([xyzw]: ))&[+-]?[0-9]+ ", string.Empty);

            int offset = 0;
            foreach (Match match in Regex.Matches(formatted, "((?<=[{,])( *)|(?<=[0-9] ))[a-zA-z][^ ]+ &[+-]?[0-9]+"))
            {
                if (match.Success)
                {
                    int start = match.Value.IndexOf('&');
                    string prefix = match.Value.Substring(0, start).Trim();
                    formatted = formatted.Substring(0, match.Index - offset) + prefix + formatted.Substring(match.Index + match.Length - offset);
                    offset += match.Value.Substring(start).Length + 1;
                }
            }

            foreach (Match match in Regex.Matches(formatted, "^&[+-]?[0-9]+\n"))
            {
                if (match.Success)
                {
                    string id = match.Value.Substring(1);
                    string rep = formatted.Substring(0, match.Index) + formatted.Substring(match.Index + match.Length);
                    var reader = new StringReader(rep);

                    var deserializer = new Deserializer();
                    var yamlObject = deserializer.Deserialize(reader);
                    var serializer = new SerializerBuilder()
                        .JsonCompatible()
                        .Build();
                    string json = serializer.Serialize(yamlObject).Trim();
                    list.Add(long.Parse(id), JsonConvert.DeserializeObject(json));
                }
            }
            return list;
        }
        internal static List<Prefab> ToPrefabList(this YamlStream stream)
        {
            List<object> list = new List<object>();
            foreach (var doc in stream.Documents)
            {
                list.Add(doc.ToObject());
            }

            return Prefab.LoadPrefabs(list);
        }
        internal static Prefab ToPrefeb(this YamlStream stream)
            => stream.ToPrefabList().FirstOrDefault();
    }
}
