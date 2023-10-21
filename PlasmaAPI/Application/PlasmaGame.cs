using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Plasma.Application
{
    [PublicAPI]
    public static class PlasmaGame
    {
        /// <summary>
        /// This is called once before the unity has loaded
        /// </summary>
        public static event Action OnApplicationLoad;
        
        /// <summary>
        /// Called to finialize code as the application quits
        /// </summary>
        public static event Action OnApplicationQuit;
        
        // Controllers.Awake
        /// <summary>
        /// Called just before the game initializes
        /// </summary>
        public static event Action OnGameInitialization;
        
        /// <summary>
        /// Called at unity's (x)time interval after the game initializes
        /// </summary>
        public static event Action OnFixedUpdate;
        
        /// <summary>
        /// Called once every frame after the game initializes
        /// </summary>
        public static event Action OnUpdate;

        /// <summary>
        /// <para> Adds your desired method to be patched as a prefix using harmony </para>
        /// <para> Will not add it twice if it has aleady been added </para>
        /// </summary>
        /// <param name="method"></param>
        public static void AddMethodPrefix(object @method)
        {

        }

        /// <summary>
        /// <para> Adds your desired method to be patched as a postfix/suffix using harmony </para>
        /// <para> Will not add it twice if it has aleady been added </para>
        /// </summary>
        /// <param name="method"></param>
        public static void AddMethodSuffix(object @method)
        {

        }

        internal static GameObject UpdateHandle;
        internal static void OnGameInit()
        {
            if (OnGameInitialization != null)
                OnGameInitialization.Invoke();
        }
        internal static void OnGameUpdate()
        {
            if (OnUpdate != null)
                OnUpdate.Invoke();
        }
    }
}
