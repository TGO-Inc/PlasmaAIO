extern alias GameClass;
using PlasmaAPI.Application;

namespace PlasmaAPI.API.Patches
{
    internal class Holder
    {
        public static void Awake()
        {
            PlasmaGame.OnGameInit();
        }
    }
}