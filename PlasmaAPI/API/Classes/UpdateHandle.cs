using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace PlasmaAPI.API.Patches
{
    internal class UpdateHandle : MonoBehaviour
    {
        private void Update()
        {
            PlasmaAPI.Application.PlasmaGame.OnGameUpdate();
        }
    }
}
