using System;
using UnityEngine;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001CF RID: 463
	[AddComponentMenu("Better UI/Controls/Better Raw Image", 30)]
	public class BetterRawImage : RawImage, IImageAppearanceProvider
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x00059316 File Offset: 0x00057516
		// (set) Token: 0x06001081 RID: 4225 RVA: 0x0005931E File Offset: 0x0005751E
		public string MaterialType
		{
			get
			{
				return this.materialType;
			}
			set
			{
				ImageAppearanceProviderHelper.SetMaterialType(value, this, this.materialProperties, ref this.materialEffect, ref this.materialType);
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x00059339 File Offset: 0x00057539
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x00059341 File Offset: 0x00057541
		public MaterialEffect MaterialEffect
		{
			get
			{
				return this.materialEffect;
			}
			set
			{
				ImageAppearanceProviderHelper.SetMaterialEffect(value, this, this.materialProperties, ref this.materialEffect, ref this.materialType);
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x0005935C File Offset: 0x0005755C
		public VertexMaterialData MaterialProperties
		{
			get
			{
				return this.materialProperties;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06001085 RID: 4229 RVA: 0x00059364 File Offset: 0x00057564
		// (set) Token: 0x06001086 RID: 4230 RVA: 0x0005936C File Offset: 0x0005756C
		public ColorMode ColoringMode
		{
			get
			{
				return this.colorMode;
			}
			set
			{
				this.colorMode = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x00059375 File Offset: 0x00057575
		// (set) Token: 0x06001088 RID: 4232 RVA: 0x0005937D File Offset: 0x0005757D
		public Color SecondColor
		{
			get
			{
				return this.secondColor;
			}
			set
			{
				this.secondColor = value;
			}
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00059388 File Offset: 0x00057588
		protected override void OnEnable()
		{

		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0005941E File Offset: 0x0005761E
		public float GetMaterialPropertyValue(int propertyIndex)
		{

            return default;
        }

		// Token: 0x0600108B RID: 4235 RVA: 0x00059438 File Offset: 0x00057638
		public void SetMaterialProperty(int propertyIndex, float value)
		{

		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0005945C File Offset: 0x0005765C
		protected override void OnPopulateMesh(VertexHelper vh)
		{

		}

		// Token: 0x04000E85 RID: 3717
		[SerializeField]
		private ColorMode colorMode;

		// Token: 0x04000E86 RID: 3718
		[SerializeField]
		private Color secondColor = Color.white;

		// Token: 0x04000E87 RID: 3719
		[SerializeField]
		private VertexMaterialData materialProperties = new VertexMaterialData();

		// Token: 0x04000E88 RID: 3720
		[SerializeField]
		private string materialType;

		// Token: 0x04000E89 RID: 3721
		[SerializeField]
		private MaterialEffect materialEffect;

		// Token: 0x04000E8A RID: 3722
		[SerializeField]
		private float materialProperty1;

		// Token: 0x04000E8B RID: 3723
		[SerializeField]
		private float materialProperty2;

		// Token: 0x04000E8C RID: 3724
		[SerializeField]
		private float materialProperty3;
	}
}
