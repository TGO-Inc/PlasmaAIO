extern alias GameClass;
using GameClass;
using GameClass::Behavior;

namespace PlasmaAPI.Mods.MY_FIRST_MOD.Nodes.Scripts
{
    internal class AirplaneNode : Agent
    {
        /*
        private AgentProperty PositionText;
        public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
        {
            if (sketchNode.GetPort(1).isConnected)
            {
                RunDriverCommand(1);
                sketchNode.GetPort(1).Commit(PositionText.GetValue());
            }
        }*/
        protected override void OnSetupFinished()
        {
            // This function doesn't have to be here but if you want to do something when the node loads it goes here
        }

        [SketchNodePortOperation(1)]
        public void Called(SketchNode node)
        {
            //WriteOutput("Output Text", GetProperty("Text").GetValue());
        }/*
        public enum Commands
        {
            UpdatePositionText = 1
        }*/
    }
}
