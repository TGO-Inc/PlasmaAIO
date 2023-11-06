using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PrefabUtil.Extensions;
using PrefabUtil.Internal.Temp;
using System.Collections.Generic;
using System.Linq;

namespace PrefabUtil
{
    public class Prefab
    {
        public string Type;
        public long Id;
        public string Name;
        public string Tag;
        public long ParentId;
        public JObject Root;
        [JsonIgnore]
        public Prefab Parent;
        public List<Prefab> Components;
        public List<Prefab> Children;
        public bool TryGetChild(long id, out Prefab found)
        {
            if (Id.Equals(id))
            {
                found = this;
                return true;
            }

            if (Children != null)
                foreach (var pref in Children)
                    if (pref.TryGetChild(id, out found))
                        return true;

            if (Components != null)
                foreach (var obj in Components)
                    if (obj.TryGetChild(id, out found))
                        return true;

            found = null;
            return false;
        }
        public static List<Prefab> LoadPrefabs(List<object> children)
        {
            Dictionary<long, Prefab> FinalList = new Dictionary<long, Prefab>();
            Dictionary<long, long> map = new Dictionary<long, long>();

            Dictionary<long, PrefabHolder> itter = new Dictionary<long, PrefabHolder>();

            foreach (var c in children)
            {
                JObject child = JObject.FromObject(c);
                long id = long.Parse(child.Properties().Select(j => j.Name).Join().Trim());

                JObject body = (JObject)child.Values().FirstOrDefault();

                string type = body.Properties().FirstOrDefault().Name.Trim();
                JObject data = (JObject)body.Values().FirstOrDefault();
                var list = new List<long>();

                long pid = 0;
                string name = data.GetValueString("m_Name");
                string tag = data.GetValueString("m_TagString");

                if (type.Equals("GameObject"))
                {
                    list.AddRange(data["m_Component"].Select(p => long.Parse(p["component"]["fileID"].ToString())));
                }
                else
                {
                    pid = (long)data["m_GameObject"]["fileID"];
                }
                if (type.Equals("Transform"))
                {
                    long father = (long)data["m_Father"]["fileID"];
                    map.Add(id, pid);
                    if (father == 0)
                    {
                        FinalList.Add(pid, new Prefab()
                        {
                            Id = pid,
                            Name = null,
                            Tag = null,
                            ParentId = 0,
                            Children = new List<Prefab>(),
                            Components = new List<Prefab>(),
                            Root = null,
                            Type = "GameObject"
                        });
                    }
                    list.AddRange(data["m_Children"].Select(p => long.Parse(((JObject)p).Values().FirstOrDefault().ToString())));
                }

                itter.Add(id, new PrefabHolder(id, type, data, body, list, pid, name, tag));
            }

            foreach (var h in FinalList)
            {
                var holder = itter[h.Key];
                h.Value.Root = holder.child.StripGameObject();
                h.Value.Name = holder.name;
                h.Value.Tag = holder.tag;
                holder.LoadChildren(h.Value, itter, map);
            }

            return FinalList.Values.ToList();
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
