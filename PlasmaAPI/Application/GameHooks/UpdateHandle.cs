using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PlasmaAPI.API.GameHooks
{
    internal class UpdateHandle : MonoBehaviour
    {
        private void Update()
        {
            Application.PlasmaGame.OnGameUpdate();
        }
    }
}
