using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x02000209 RID: 521
	public class ResolutionMonitor : SingletonScriptableObject<ResolutionMonitor>
	{
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x0005D0EA File Offset: 0x0005B2EA
		private static string FilePath
		{
			get
			{
				return "TheraBytes/Resources/ResolutionMonitor";
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x0005D0F1 File Offset: 0x0005B2F1
		// (set) Token: 0x060011F2 RID: 4594 RVA: 0x0005D0FD File Offset: 0x0005B2FD
		[Obsolete("Use 'GetOptimizedResolution()' instead.")]
		public static Vector2 OptimizedResolution
		{
			get
			{
				return SingletonScriptableObject<ResolutionMonitor>.Instance.optimizedResolutionFallback;
			}
			set
			{
				if (SingletonScriptableObject<ResolutionMonitor>.Instance.optimizedResolutionFallback == value)
				{
					return;
				}
				SingletonScriptableObject<ResolutionMonitor>.Instance.optimizedResolutionFallback = value;
				ResolutionMonitor.CallResolutionChanged();
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x0005D122 File Offset: 0x0005B322
		// (set) Token: 0x060011F4 RID: 4596 RVA: 0x0005D12E File Offset: 0x0005B32E
		[Obsolete("Use 'GetOptimizedDpi()' instead.")]
		public static float OptimizedDpi
		{
			get
			{
				return SingletonScriptableObject<ResolutionMonitor>.Instance.optimizedDpiFallback;
			}
			set
			{
				if (SingletonScriptableObject<ResolutionMonitor>.Instance.optimizedDpiFallback == value)
				{
					return;
				}
				SingletonScriptableObject<ResolutionMonitor>.Instance.optimizedDpiFallback = value;
				ResolutionMonitor.CallResolutionChanged();
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x0005D14E File Offset: 0x0005B34E
		public static Vector2 CurrentResolution
		{
			get
			{
				if (ResolutionMonitor.lastScreenResolution == Vector2.zero)
				{
					ResolutionMonitor.lastScreenResolution = new Vector2((float)Screen.width, (float)Screen.height);
				}
				return ResolutionMonitor.lastScreenResolution;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x0005D17C File Offset: 0x0005B37C
		public static float CurrentDpi
		{
			get
			{
				if (ResolutionMonitor.lastDpi == 0f)
				{
					ResolutionMonitor.lastDpi = SingletonScriptableObject<ResolutionMonitor>.Instance.dpiManager.GetDpi();
				}
				return ResolutionMonitor.lastDpi;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x0005D1A3 File Offset: 0x0005B3A3
		// (set) Token: 0x060011F8 RID: 4600 RVA: 0x0005D1AB File Offset: 0x0005B3AB
		public string FallbackName
		{
			get
			{
				return this.fallbackName;
			}
			set
			{
				this.fallbackName = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x0005D1B4 File Offset: 0x0005B3B4
		public static Vector2 OptimizedResolutionFallback
		{
			get
			{
				return SingletonScriptableObject<ResolutionMonitor>.Instance.optimizedResolutionFallback;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x0005D1C0 File Offset: 0x0005B3C0
		public static float OptimizedDpiFallback
		{
			get
			{
				return SingletonScriptableObject<ResolutionMonitor>.Instance.optimizedDpiFallback;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x0005D1CC File Offset: 0x0005B3CC
		public List<ScreenTypeConditions> OptimizedScreens
		{
			get
			{
				return this.optimizedScreens;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x0005D1D4 File Offset: 0x0005B3D4
		public static ScreenTypeConditions CurrentScreenConfiguration
		{
			get
			{
				return SingletonScriptableObject<ResolutionMonitor>.Instance.currentScreenConfig;
			}
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0005D1E0 File Offset: 0x0005B3E0
		public static ScreenTypeConditions GetConfig(string name)
		{

            return default;
        }

		// Token: 0x060011FE RID: 4606 RVA: 0x0005D27C File Offset: 0x0005B47C
		public static ScreenInfo GetOpimizedScreenInfo(string name)
		{

            return default;
        }

		// Token: 0x060011FF RID: 4607 RVA: 0x0005D2A1 File Offset: 0x0005B4A1
		public static IEnumerable<ScreenTypeConditions> GetCurrentScreenConfigurations()
		{

            return default;
        }

		// Token: 0x06001200 RID: 4608 RVA: 0x0005D2AA File Offset: 0x0005B4AA
		public static void SetDirty()
		{

		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0005D2B4 File Offset: 0x0005B4B4
		public static float GetOptimizedDpi(string screenName)
		{

            return default;
        }

		// Token: 0x06001202 RID: 4610 RVA: 0x0005D340 File Offset: 0x0005B540
		public static Vector2 GetOptimizedResolution(string screenName)
		{

            return default;
        }

		// Token: 0x06001203 RID: 4611 RVA: 0x0005D384 File Offset: 0x0005B584
		public static bool IsOptimizedResolution(int width, int height)
		{

            return default;
        }

		// Token: 0x06001204 RID: 4612 RVA: 0x0005D420 File Offset: 0x0005B620
		public static void Update()
		{

		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0005D452 File Offset: 0x0005B652
		public static void CallResolutionChanged()
		{

		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0005D460 File Offset: 0x0005B660
		public void ResolutionChanged()
		{

		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0005D518 File Offset: 0x0005B718
		private static IEnumerable<IResolutionDependency> AllResolutionDependencies()
		{

            return default;
        }

		// Token: 0x06001208 RID: 4616 RVA: 0x0005D521 File Offset: 0x0005B721
		private static Vector2 GetCurrentResolution()
		{

            return default;
        }

		// Token: 0x06001209 RID: 4617 RVA: 0x0005D534 File Offset: 0x0005B734
		private static float GetCurrentDpi()
		{

            return default;
        }

		// Token: 0x04000F28 RID: 3880
		[FormerlySerializedAs("optimizedResolution")]
		[SerializeField]
		private Vector2 optimizedResolutionFallback = new Vector2(1080f, 1920f);

		// Token: 0x04000F29 RID: 3881
		[FormerlySerializedAs("optimizedDpi")]
		[SerializeField]
		private float optimizedDpiFallback = 96f;

		// Token: 0x04000F2A RID: 3882
		[SerializeField]
		private string fallbackName = "Portrait";

		// Token: 0x04000F2B RID: 3883
		[SerializeField]
		private DpiManager dpiManager = new DpiManager();

		// Token: 0x04000F2C RID: 3884
		private ScreenTypeConditions currentScreenConfig;

		// Token: 0x04000F2D RID: 3885
		[SerializeField]
		private List<ScreenTypeConditions> optimizedScreens = new List<ScreenTypeConditions>
		{
			new ScreenTypeConditions("Landscape", true, true, false, false, false, false, false)
		};

		// Token: 0x04000F2E RID: 3886
		private static Dictionary<string, ScreenTypeConditions> lookUpScreens = new Dictionary<string, ScreenTypeConditions>();

		// Token: 0x04000F2F RID: 3887
		private static Vector2 lastScreenResolution;

		// Token: 0x04000F30 RID: 3888
		private static float lastDpi;

		// Token: 0x04000F31 RID: 3889
		private static bool isDirty;
	}
}
