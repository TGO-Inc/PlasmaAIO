
using Doorstop;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Plasma.Application
{
    internal class AssemblyContainer
    {
        private Assembly _assembly = null;
        public Assembly Assembly
        {
            get
            {
                return _assembly;
            }
            set
            {
                if (_assembly != value)
                    if (AssemblyLoaded != null)
                        foreach (var i in AssemblyLoaded.Values)
                            if (value != null && i.Method.GetParameters().Length == 1)
                            {
                                // Entrypoint.Log("Invoked Callback (arg): " + i.Method.Name);
                                i.DynamicInvoke(value);
                            }
                            else if (value != null)
                            {
                                // Entrypoint.Log("Invoked Callback: " + i.Method.Name);
                                i.DynamicInvoke();
                            }

                _assembly = value;
            }
        }
        public AssemblyType Type;
        public ConcurrentDictionary<Guid, Delegate> AssemblyLoaded;
        public bool IsLoaded
        {
            get { return Assembly != null; }
        }
        public AssemblyContainer(Assembly assembly, AssemblyType type)
        {
            AssemblyLoaded = new ConcurrentDictionary<Guid, Delegate>();
            Assembly = assembly;
            Type = type;
        }
        public AssemblyContainer(Assembly assembly)
        {
            AssemblyLoaded = new ConcurrentDictionary<Guid, Delegate>();
            Assembly = assembly;
            Type = assembly.GetName().Name.ToLowerInvariant() switch
            {
                string n when n.Contains("system") => AssemblyType.System,
                string n when n.Contains("unity") => AssemblyType.Unity,
                string n when n.Contains("sirenix") => AssemblyType.Sirenix,
                string n when n.Contains("plasma") => AssemblyType.Game,
                string n when n.Contains("assembly") => AssemblyType.Game,
                _ => AssemblyType.Modded,
            };
        }
    }
}
