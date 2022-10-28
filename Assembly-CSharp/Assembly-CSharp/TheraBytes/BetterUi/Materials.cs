using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Rendering;

namespace TheraBytes.BetterUi
{
	// Token: 0x02000208 RID: 520
	public class Materials : SingletonScriptableObject<Materials>
	{
		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x0005CCC5 File Offset: 0x0005AEC5
		private static string FilePath
		{
			get
			{
				return "TheraBytes/Resources/Materials";
			}
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x0005CCCC File Offset: 0x0005AECC
		private void OnEnable()
		{

		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0005CCD4 File Offset: 0x0005AED4
		private void EnsurePredefinedMaterials()
		{

		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x0005CDAC File Offset: 0x0005AFAC
		private void AddIfNotPresent(string name, Func<MaterialEffect, Materials.MaterialInfo> CreateMaterial, params MaterialEffect[] preservedLayerEffects)
		{

		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x0005CF4C File Offset: 0x0005B14C
		private IEnumerator SetTogglePropertyDelayed(Material material, string toggleName, bool toggle)
		{

            return default;
        }

		// Token: 0x060011EA RID: 4586 RVA: 0x0005CF6C File Offset: 0x0005B16C
		public Materials.MaterialInfo GetMaterialInfo(string name, MaterialEffect e)
		{

            return default;
        }

		// Token: 0x060011EB RID: 4587 RVA: 0x0005CFA4 File Offset: 0x0005B1A4
		public Material GetMaterial(string name)
		{

            return default;
        }

		// Token: 0x060011EC RID: 4588 RVA: 0x0005CFE4 File Offset: 0x0005B1E4
		public List<string> GetAllMaterialNames()
		{

            return default;
        }

		// Token: 0x060011ED RID: 4589 RVA: 0x0005D050 File Offset: 0x0005B250
		public HashSet<MaterialEffect> GetAllMaterialEffects(string name)
		{

            return default;
        }

		// Token: 0x04000F23 RID: 3875
		private const string STANDARD = "Standard";

		// Token: 0x04000F24 RID: 3876
		private const string GRAYSCALE = "Grayscale";

		// Token: 0x04000F25 RID: 3877
		private const string HUE_SATURATION_BRIGHTNESS = "Hue Saturation Brightness";

		// Token: 0x04000F26 RID: 3878
		private static readonly List<string> materialOrder = new List<string>
		{
			"Standard",
			"Grayscale",
			"Hue Saturation Brightness"
		};

		// Token: 0x04000F27 RID: 3879
		[SerializeField]
		private List<Materials.MaterialInfo> materials = new List<Materials.MaterialInfo>();

		// Token: 0x02000412 RID: 1042
		[Serializable]
		public class MaterialInfo
		{
			// Token: 0x060021F9 RID: 8697 RVA: 0x000A480E File Offset: 0x000A2A0E
			public override string ToString()
			{

                return default;
            }

			// Token: 0x04001E38 RID: 7736
			public string Name;

			// Token: 0x04001E39 RID: 7737
			public Material Material;

			// Token: 0x04001E3A RID: 7738
			public VertexMaterialData Properties = new VertexMaterialData();

			// Token: 0x04001E3B RID: 7739
			public MaterialEffect Effect;
		}
	}
}
