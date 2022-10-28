using System;
using System.IO;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x02000214 RID: 532
	public abstract class SingletonScriptableObject<T> : ScriptableObject where T : SingletonScriptableObject<T>
	{
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x0005DCA5 File Offset: 0x0005BEA5
		public static T Instance
		{
			get
			{
				SingletonScriptableObject<T>.EnsureInstance();
				return SingletonScriptableObject<T>.instance;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x0005DCB2 File Offset: 0x0005BEB2
		public static bool HasInstance
		{
			get
			{
				return SingletonScriptableObject<T>.instance != null;
			}
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x0005DCC4 File Offset: 0x0005BEC4
		public static T EnsureInstance()
		{

            return default;
        }

		// Token: 0x04000F67 RID: 3943
		private static T instance;

		// Token: 0x04000F68 RID: 3944
		private static bool creatingInstance;
	}
}
