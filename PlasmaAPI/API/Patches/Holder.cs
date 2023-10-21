extern alias GameClass;
using Plasma.Application;

namespace Plasma.API.Patches
{
    internal class Holder
    {
        public static void Awake()
        {
            PlasmaGame.OnGameInit();
        }
    }
}