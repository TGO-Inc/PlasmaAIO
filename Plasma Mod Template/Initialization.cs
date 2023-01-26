
using PlasmaAPI.API;
using PlasmaAPI.Application;
using PlasmaAPI.Mods.MY_FIRST_MOD.Components.Scripts;
using PlasmaAPI.Mods.MY_FIRST_MOD.Nodes.Scripts;

namespace PlasmaAPI.Mods.MY_FIRST_MOD
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
            ComponentManager.AddNodeDebug(typeof(AirplaneNode), typeof(AirplaneComponent));
            
            PlasmaGame.OnGameInitialization += PlasmaGame_OnGameInitialization;
        }

        private void PlasmaGame_OnGameInitialization()
        {
            //ImportModel
            //ComponentManager.AddNewComponent(typeof(AirplaneNode), "Airplane");
            //ComponentManager.AddNodeDebug(typeof(AirplaneNode));

        }
    }
}
