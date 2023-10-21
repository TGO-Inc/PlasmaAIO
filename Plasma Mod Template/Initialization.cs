
using Plasma.API;
using Plasma.Application;
using Plasma.Mods.MY_FIRST_MOD.Gestalts;
using System.IO;

namespace Plasma.Mods.MY_FIRST_MOD
{
    public class Initialization
    {
        public Initialization()
        {
            /*
             * my vars here
             */
        }


        public void Start()
        {
            /*
            * start hooks here
            */
            PlasmaGame.OnGameInitialization += PlasmaGame_OnGameInitialization;
            ComponentManager.NewComponent(typeof(AirplaneGestalt));
            ComponentManager.NewComponent(typeof(CarGestalt));
            ComponentManager.NewComponent(typeof(DuckGestalt));
        }

        private void PlasmaGame_OnGameInitialization()
        {
            
        }
    }
}
