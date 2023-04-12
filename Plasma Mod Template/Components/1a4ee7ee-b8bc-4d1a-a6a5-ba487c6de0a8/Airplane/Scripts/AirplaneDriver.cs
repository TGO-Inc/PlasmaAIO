extern alias GameClass;
using GameClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PlasmaAPI.Mods.MY_FIRST_MOD.Airplane
{
    internal class AirplaneDriver : ComponentDriver
    {

        private Transform _transform;

        public override void Awake()
        {
            // DO NOT CALL
            // base.Awake();
        }

        protected override void OnAgentSet()
        {
            
        }

        public override void OnReset()
        {
            
        }

        public override void OnMount()
        {
            
        }

        public override void OnUnmount()
        {
            
        }

        public override void UpdateConcreteProperties()
        {
            
        }
        public override void OnScaleChanged()
        {
            base.OnScaleChanged();
        }
    }
}
