extern alias GameClass;
using GameClass;
using PlasmaAPI.API;
using PlasmaAPI.Mods.MY_FIRST_MOD.Nodes.Scripts;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace PlasmaAPI.Mods.MY_FIRST_MOD.Components.Scripts
{
    internal class AirplaneComponent : ComponentDriver
    {
        public MeshRenderer[] meshRenderers;
        private AgentProperty PositionText;
        private AirplaneNode airplaneNode;
        public override void Awake()
        {
            base.Awake();
            File.WriteAllText("IM AWAKE.txt", string.Empty);
        }

        protected override void OnAgentSet()
        {
            //airplaneNode = (AirplaneNode)base.agent;
            //PositionText = base.agent.GetRuntimeProperty(1);
        }
        public override void RunCommand(int commandId)
        {/*
            switch (commandId)
            {
                case 1:
                    PositionText.SetValueString(_component.transform.position.ToString());
                break;
            }*/
        }
    }
}