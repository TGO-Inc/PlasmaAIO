using System;
using System.Collections.Generic;
using System.Globalization;
using Sirenix.OdinInspector;
using UnityEngine;

namespace PlasmaAPI.GameClass.Behavior
{
	// Token: 0x0200021D RID: 541
	[Serializable]
	public class Data
	{
		// Token: 0x06001292 RID: 4754 RVA: 0x0005EB04 File Offset: 0x0005CD04
		private IList<ValueDropdownItem<Data.Types>> ValidTypes()
		{

            return default;
        }

		// Token: 0x06001293 RID: 4755 RVA: 0x0005EB58 File Offset: 0x0005CD58
		public Data()
		{

		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0005EC03 File Offset: 0x0005CE03
		public Data(Data data)
		{

		}

		// Token: 0x06001295 RID: 4757 RVA: 0x0005EC12 File Offset: 0x0005CE12
		public Data(bool value) : this()
		{

		}

		// Token: 0x06001296 RID: 4758 RVA: 0x0005EC28 File Offset: 0x0005CE28
		public Data(Color value) : this()
		{

		}

		// Token: 0x06001297 RID: 4759 RVA: 0x0005EC3E File Offset: 0x0005CE3E
		public Data(Data.ComponentProperty value) : this()
		{

		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0005EC54 File Offset: 0x0005CE54
		public Data(float value) : this()
		{

		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0005EC71 File Offset: 0x0005CE71
		public Data(float value, Data.NumberDecorators decorator) : this()
		{

		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0005EC8E File Offset: 0x0005CE8E
		public Data(Data.Image value) : this()
		{

		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0005ECA4 File Offset: 0x0005CEA4
		public Data(int value) : this()
		{

		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0005ECC2 File Offset: 0x0005CEC2
		public Data(int value, Data.NumberDecorators decorator) : this()
		{

		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0005ECE0 File Offset: 0x0005CEE0
		public Data(Data.ModuleInterface value) : this()
		{

		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0005ECF7 File Offset: 0x0005CEF7
		public Data(Data.Selection value) : this()
		{

		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0005ED0D File Offset: 0x0005CF0D
		public Data(Data.Sound value) : this()
		{

		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x0005ED23 File Offset: 0x0005CF23
		public Data(string value) : this()
		{

		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x0005ED3C File Offset: 0x0005CF3C
		public void Copy(Data data)
		{

		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x0005EDF0 File Offset: 0x0005CFF0
		public bool IsEqualTo(Data data, bool compareDecorators = true)
		{

            return default;
        }

		// Token: 0x060012A3 RID: 4771 RVA: 0x0005EF5A File Offset: 0x0005D15A
		public static bool CheckCompatibility(Data.Types type1, Data.Types type2)
		{

            return default;
        }

		// Token: 0x060012A4 RID: 4772 RVA: 0x0005EF60 File Offset: 0x0005D160
		public static string TypeToString(Data.Types type)
		{

            return default;
        }

		// Token: 0x060012A5 RID: 4773 RVA: 0x0005EFF8 File Offset: 0x0005D1F8
		public string ToNiceString(bool includeType, int decimalDigits = 2)
		{

            return default;
        }

		// Token: 0x060012A6 RID: 4774 RVA: 0x0005F250 File Offset: 0x0005D450
		public override string ToString()
		{

            return default;
        }

		// Token: 0x04000F7F RID: 3967
		public Data.Types type;

		// Token: 0x04000F80 RID: 3968
		public bool booleanValue;

		// Token: 0x04000F81 RID: 3969
		public Color colorValue;

		// Token: 0x04000F82 RID: 3970
		public Data.ComponentProperty componentPropertyValue;

		// Token: 0x04000F83 RID: 3971
		public Data.Image imageValue;

		// Token: 0x04000F84 RID: 3972
		public Data.ModuleInterface moduleInterfaceValue;

		// Token: 0x04000F85 RID: 3973
		public float numberValue;

		// Token: 0x04000F86 RID: 3974
		public Data.NumberDecorators numberDecorator;

		// Token: 0x04000F87 RID: 3975
		public Data.Selection selectionValue;

		// Token: 0x04000F88 RID: 3976
		public Data.Sound soundValue;

		// Token: 0x04000F89 RID: 3977
		public string stringValue;

		// Token: 0x02000421 RID: 1057
		public enum Types
		{
			// Token: 0x04001E6F RID: 7791
			Boolean,
			// Token: 0x04001E70 RID: 7792
			Number,
			// Token: 0x04001E71 RID: 7793
			Color,
			// Token: 0x04001E72 RID: 7794
			String = 4,
			// Token: 0x04001E73 RID: 7795
			Image,
			// Token: 0x04001E74 RID: 7796
			ComponentProperty,
			// Token: 0x04001E75 RID: 7797
			Selection,
			// Token: 0x04001E76 RID: 7798
			Sound,
			// Token: 0x04001E77 RID: 7799
			ModuleInterface,
			// Token: 0x04001E78 RID: 7800
			None = 101
		}

		// Token: 0x02000422 RID: 1058
		public enum NumberDecorators
		{
			// Token: 0x04001E7A RID: 7802
			Generic,
			// Token: 0x04001E7B RID: 7803
			Percentage,
			// Token: 0x04001E7C RID: 7804
			Time,
			// Token: 0x04001E7D RID: 7805
			Integer
		}

		// Token: 0x02000423 RID: 1059
		public struct ComponentProperty
		{
			// Token: 0x17000533 RID: 1331
			// (get) Token: 0x0600222B RID: 8747 RVA: 0x000A4F23 File Offset: 0x000A3123
			public bool isProper
			{
				get
				{
					return !string.IsNullOrEmpty(this.componentDisplayName) && this.property > 0;
				}
			}

			// Token: 0x0600222C RID: 8748 RVA: 0x000A4F3D File Offset: 0x000A313D
			public override bool Equals(object obj)
			{

                return default;
            }

			// Token: 0x0600222D RID: 8749 RVA: 0x000A4F5C File Offset: 0x000A315C
			public static bool operator ==(Data.ComponentProperty c1, Data.ComponentProperty c2)
			{

                return default;
            }

			// Token: 0x0600222E RID: 8750 RVA: 0x000A4FC1 File Offset: 0x000A31C1
			public static bool operator !=(Data.ComponentProperty c1, Data.ComponentProperty c2)
			{

                return default;
            }

			// Token: 0x0600222F RID: 8751 RVA: 0x000A4FCD File Offset: 0x000A31CD
			public override int GetHashCode()
			{

                return default;
            }

			// Token: 0x04001E7E RID: 7806
			public string componentDisplayName;

			// Token: 0x04001E7F RID: 7807
			public int property;
		}

		// Token: 0x02000424 RID: 1060
		public struct Selection
		{
			// Token: 0x06002230 RID: 8752 RVA: 0x000A4FE6 File Offset: 0x000A31E6
			public override bool Equals(object obj)
			{

                return default;
            }

			// Token: 0x06002231 RID: 8753 RVA: 0x000A5003 File Offset: 0x000A3203
			public static bool operator ==(Data.Selection s1, Data.Selection s2)
			{

                return default;
            }

			// Token: 0x06002232 RID: 8754 RVA: 0x000A5034 File Offset: 0x000A3234
			public static bool operator !=(Data.Selection s1, Data.Selection s2)
			{

                return default;
            }

			// Token: 0x06002233 RID: 8755 RVA: 0x000A5040 File Offset: 0x000A3240
			public override int GetHashCode()
			{

                return default;
            }

			// Token: 0x06002234 RID: 8756 RVA: 0x000A5068 File Offset: 0x000A3268
			private IList<ValueDropdownItem<Type>> IDataSelectionProviderTypes()
			{

                return default;
            }

			// Token: 0x04001E80 RID: 7808
			public Type provider;

			// Token: 0x04001E81 RID: 7809
			public int category;

			// Token: 0x04001E82 RID: 7810
			public int id;
		}

		// Token: 0x02000425 RID: 1061
		public struct Image
		{
			// Token: 0x06002235 RID: 8757 RVA: 0x000A50B0 File Offset: 0x000A32B0
			public override bool Equals(object obj)
			{

                return default;
            }

			// Token: 0x06002236 RID: 8758 RVA: 0x000A50CD File Offset: 0x000A32CD
			public static bool operator ==(Data.Image i1, Data.Image i2)
			{

                return default;
            }

			// Token: 0x06002237 RID: 8759 RVA: 0x000A50DD File Offset: 0x000A32DD
			public static bool operator !=(Data.Image i1, Data.Image i2)
			{

                return default;
            }

			// Token: 0x06002238 RID: 8760 RVA: 0x000A50E9 File Offset: 0x000A32E9
			public override int GetHashCode()
			{

                return default;
            }

			// Token: 0x04001E83 RID: 7811
			public int index;

			// Token: 0x04001E84 RID: 7812
			public string md5Hash;
		}

		// Token: 0x02000426 RID: 1062
		public struct Sound
		{
			// Token: 0x17000534 RID: 1332
			// (get) Token: 0x06002239 RID: 8761 RVA: 0x000A50F6 File Offset: 0x000A32F6
			public bool isEmpty
			{
				get
				{
					return string.IsNullOrEmpty(this.soundEvent);
				}
			}

			// Token: 0x0600223A RID: 8762 RVA: 0x000A5103 File Offset: 0x000A3303
			public void SetAsEmpty()
			{

			}

			// Token: 0x0600223B RID: 8763 RVA: 0x000A510C File Offset: 0x000A330C
			public override bool Equals(object obj)
			{

                return default;
            }

			// Token: 0x0600223C RID: 8764 RVA: 0x000A5129 File Offset: 0x000A3329
			public static bool operator ==(Data.Sound i1, Data.Sound i2)
			{

                return default;
            }

			// Token: 0x0600223D RID: 8765 RVA: 0x000A5167 File Offset: 0x000A3367
			public static bool operator !=(Data.Sound i1, Data.Sound i2)
			{

                return default;
            }

			// Token: 0x0600223E RID: 8766 RVA: 0x000A5173 File Offset: 0x000A3373
			public override int GetHashCode()
			{

                return default;
            }

			// Token: 0x04001E85 RID: 7813
			public string soundEvent;
		}

		// Token: 0x02000427 RID: 1063
		public struct ModuleInterface
		{
			// Token: 0x0600223F RID: 8767 RVA: 0x000A5180 File Offset: 0x000A3380
			public override bool Equals(object obj)
			{

                return default;
            }

			// Token: 0x06002240 RID: 8768 RVA: 0x000A519D File Offset: 0x000A339D
			public static bool operator ==(Data.ModuleInterface i1, Data.ModuleInterface i2)
			{

                return default;
            }

			// Token: 0x06002241 RID: 8769 RVA: 0x000A51CE File Offset: 0x000A33CE
			public static bool operator !=(Data.ModuleInterface i1, Data.ModuleInterface i2)
			{

                return default;
            }

			// Token: 0x06002242 RID: 8770 RVA: 0x000A51DA File Offset: 0x000A33DA
			public override int GetHashCode()
			{

                return default;
            }

			// Token: 0x04001E86 RID: 7814
			public AgentGestalt.Port.Types type;

			// Token: 0x04001E87 RID: 7815
			public int id;

			// Token: 0x04001E88 RID: 7816
			public string label;
		}
	}
}
