using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlasmaAPI.API.Application
{
    [PublicAPI]
    public class PlasmaGame
    {
        /// <summary>
        /// This is called once before the unity has loaded
        /// </summary>
        public event EventHandler OnApplicationLoad;
        
        /// <summary>
        /// Called to finialize code as the application quits
        /// </summary>
        public event EventHandler OnApplicationQuit;
        
        // Controllers.Awake
        /// <summary>
        /// Called just before the game initializes
        /// </summary>
        public event EventHandler OnGameInitialization;
        
        /// <summary>
        /// Called at unity's (x)time interval after the game initializes
        /// </summary>
        public event EventHandler OnFixedUpdate;
        
        /// <summary>
        /// Called once every frame after the game initializes
        /// </summary>
        public event EventHandler OnUpdate;

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
    }
}
