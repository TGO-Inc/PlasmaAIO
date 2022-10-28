using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlasmaDevToolkit.ModLoader
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
                if (_assembly != value && AssemblyLoaded != null)
                    AssemblyLoaded.Invoke();

                _assembly = value;
            }
        }
        public AssemblyType Type;
        public event Action AssemblyLoaded;
        public bool IsLoaded
        {
            get { return Assembly != null; }
        }
        public AssemblyContainer(Assembly assembly, AssemblyType type)
        {
            Assembly = assembly;
            Type = type;
        }
        public AssemblyContainer(Assembly assembly)
        {
            Assembly = assembly;
            switch(assembly.GetName().Name.ToLower())
            {
                case string n when n.Contains("system"):
                    Type = AssemblyType.System;
                    break;
                case string n when n.Contains("unity"):
                    Type = AssemblyType.Unity;
                    break;
                case string n when n.Contains("sirenix"):
                    Type = AssemblyType.Sirenix;
                    break;
                default:
                    Type = AssemblyType.Modded;
                    break;
            }
                
        }
    }
}
