extern alias GameClass;
extern alias PLibrary;
using PLibrary;
using GameClass;
using PlasmaAPI.Application.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HarmonyLib;

namespace PlasmaAPI.API.Patches
{
    internal static class EnumUtil
    {
        public static Dictionary<Type, int> converter_t = new Dictionary<Type, int>()
        {
            { typeof(AgentCategoryEnum), 0},
            { typeof(AgentGestalt.ComponentCategories), 1 },
            { typeof(AgentGestaltEnum), 2 }
        };
    }
    public class EnumPatch
    {
        public static void TryParseEnum<EnumType>(Type enumType, string value, ref EnumType parseResult, ref bool __result)
        {
            if (__result == false && EnumUtil.converter_t.ContainsKey(enumType))
            {
                object target = null;
                switch (EnumUtil.converter_t[enumType])
                {
                    case 0:
                        if (CategoryManager.AgentCategories.TryGetValue(value, out AgentCategoryEnum e))
                            target = e;
                        break;
                    case 1:
                        if (CategoryManager.ComponentCategories.TryGetValue(value, out AgentGestalt.ComponentCategories f))
                            target = f;
                        break;
                    case 2:
                        File.WriteAllText("parse problem here.txt", "");
                        //if (CategoryManager.AgentGestalts.TryGetValue(value., out AgentGestaltEnum g))
                        //    target = g;
                        break;

                }
                if (target != null)
                {
                    Type EnumResult = typeof(Enum).GetNestedType("EnumResult", BindingFlags.NonPublic);
                    MethodInfo Init = EnumResult.GetMethod("Init", BindingFlags.NonPublic | BindingFlags.Instance);
                    FieldInfo parsedEnum = EnumResult.GetField("parsedEnum", BindingFlags.NonPublic | BindingFlags.Instance);
                    var presult = Convert.ChangeType(Activator.CreateInstance(EnumResult), EnumResult);
                    Init.Invoke(presult, new object[] { false });
                    parsedEnum.SetValue(presult, target);
                    parseResult = (EnumType)presult;
                    __result = true;
                }
            }
        }

        public static void GetNames(Type enumType, ref string[] __result)
        {
            if (EnumUtil.converter_t.ContainsKey(enumType))
            {
                string[] target = null;
                switch (EnumUtil.converter_t[enumType])
                {
                    case 0:
                        if (CategoryManager.AgentCategories.Keys.Count > 0)
                            target = CategoryManager.AgentCategories.Keys.ToArray();
                        break;
                    case 1:
                        if (CategoryManager.ComponentCategories.Keys.Count > 0)
                            target = CategoryManager.ComponentCategories.Keys.ToArray();
                        break;
                    case 2:
                        if (CategoryManager.AgentGestaltEnum.Keys.Count > 0)
                            target = CategoryManager.AgentGestaltEnum.Keys.ToArray();
                        break;

                }
                if (target != null)
                {
                    var newt = __result.ToList();
                    newt.AddRange(target);
                    __result = newt.ToArray();
                }
            }
        }
    }
}
