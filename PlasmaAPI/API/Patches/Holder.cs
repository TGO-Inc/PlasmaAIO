extern alias GameClass;
using System.Linq;
using MonoMod.Utils;
using PlasmaAPI.Application;
using PlasmaAPI.Application.Game;

namespace PlasmaAPI.API.Patches
{
    internal class Holder
    {
        static int applied = 0;
        public static void Awake()
        {
            PlasmaGame.OnGameInit();
        }
    }
}