extern alias GameClass;
using GameClass;

namespace PlasmaDevToolkit.Patches
{
    internal class WorldController
    { 
        public static bool Init(GameClass.WorldController __instance)
        {
            __instance.disableGuruMeditation = true;
            __instance.skipLoadingScreen = true;
            return true;
        }
        public static bool ShouldOpenExceptionPopup(ref bool __result)
        {
            __result = false;
            return false;
        }
    }
}
