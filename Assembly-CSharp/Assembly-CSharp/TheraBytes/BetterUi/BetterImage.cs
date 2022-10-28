using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Sprites;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.TheraBytes.BetterUi
{
	// Token: 0x020001CD RID: 461
	[AddComponentMenu("Better UI/Controls/Better Image", 30)]
	public class BetterImage : Image, IResolutionDependency, IImageAppearanceProvider
	{
		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06001061 RID: 4193 RVA: 0x0005801F File Offset: 0x0005621F
		// (set) Token: 0x06001062 RID: 4194 RVA: 0x00058027 File Offset: 0x00056227
		public bool KeepBorderAspectRatio
		{
			get
			{
				return this.keepBorderAspectRatio;
			}
			set
			{
				this.keepBorderAspectRatio = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06001063 RID: 4195 RVA: 0x00058036 File Offset: 0x00056236
		public Vector2SizeModifier SpriteBorderScale
		{
			get
			{
				return this.customBorderScales.GetCurrentItem(this.spriteBorderScaleFallback);
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x00058049 File Offset: 0x00056249
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x00058051 File Offset: 0x00056251
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

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x0005806C File Offset: 0x0005626C
		// (set) Token: 0x06001067 RID: 4199 RVA: 0x00058074 File Offset: 0x00056274
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

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x0005808F File Offset: 0x0005628F
		public VertexMaterialData MaterialProperties
		{
			get
			{
				return this.materialProperties;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06001069 RID: 4201 RVA: 0x00058097 File Offset: 0x00056297
		// (set) Token: 0x0600106A RID: 4202 RVA: 0x0005809F File Offset: 0x0005629F
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

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x000580A8 File Offset: 0x000562A8
		// (set) Token: 0x0600106C RID: 4204 RVA: 0x000580B0 File Offset: 0x000562B0
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

		// Token: 0x0600106D RID: 4205 RVA: 0x000580BC File Offset: 0x000562BC
		protected override void OnEnable()
		{

		}

		// Token: 0x0600106E RID: 4206 RVA: 0x0005815E File Offset: 0x0005635E
		public float GetMaterialPropertyValue(int propertyIndex)
		{

            return default;
        }

		// Token: 0x0600106F RID: 4207 RVA: 0x00058178 File Offset: 0x00056378
		public void SetMaterialProperty(int propertyIndex, float value)
		{

		}

		// Token: 0x06001070 RID: 4208 RVA: 0x0005819C File Offset: 0x0005639C
		protected override void OnPopulateMesh(VertexHelper toFill)
		{

		}

		// Token: 0x06001071 RID: 4209 RVA: 0x000582B0 File Offset: 0x000564B0
		private void GenerateSimpleSprite(VertexHelper vh, bool preserveAspect)
		{

		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00058338 File Offset: 0x00056538
		private Rect GetDrawingRect(bool shouldPreserveAspect)
		{

            return default;
        }

		// Token: 0x06001073 RID: 4211 RVA: 0x00058524 File Offset: 0x00056724
		private void GenerateSlicedSprite(VertexHelper toFill)
		{

		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0005895C File Offset: 0x00056B5C
		private void GenerateTiledSprite(VertexHelper toFill)
		{

		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00059024 File Offset: 0x00057224
		private void AddQuad(VertexHelper vertexHelper, Rect bounds, Vector2 posMin, Vector2 posMax, ColorMode mode, Color colorA, Color colorB, Vector2 uvMin, Vector2 uvMax)
		{

		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0005904C File Offset: 0x0005724C
		private Vector4 GetAdjustedBorders(Vector4 border, Rect rect, bool keepAspect, Vector2 texSize)
		{

            return default;
        }

		// Token: 0x06001077 RID: 4215 RVA: 0x00059183 File Offset: 0x00057383
		public void OnResolutionChanged()
		{

		}

		// Token: 0x04000E75 RID: 3701
		private static readonly Vector2[] vertScratch = new Vector2[4];

		// Token: 0x04000E76 RID: 3702
		private static readonly Vector2[] uvScratch = new Vector2[4];

		// Token: 0x04000E77 RID: 3703
		[SerializeField]
		private ColorMode colorMode;

		// Token: 0x04000E78 RID: 3704
		[SerializeField]
		private Color secondColor = Color.white;

		// Token: 0x04000E79 RID: 3705
		[SerializeField]
		private VertexMaterialData materialProperties = new VertexMaterialData();

		// Token: 0x04000E7A RID: 3706
		[SerializeField]
		private string materialType;

		// Token: 0x04000E7B RID: 3707
		[SerializeField]
		private MaterialEffect materialEffect;

		// Token: 0x04000E7C RID: 3708
		[SerializeField]
		private float materialProperty1;

		// Token: 0x04000E7D RID: 3709
		[SerializeField]
		private float materialProperty2;

		// Token: 0x04000E7E RID: 3710
		[SerializeField]
		private float materialProperty3;

		// Token: 0x04000E7F RID: 3711
		[SerializeField]
		private bool keepBorderAspectRatio;

		// Token: 0x04000E80 RID: 3712
		[FormerlySerializedAs("spriteBorderScale")]
		[SerializeField]
		private Vector2SizeModifier spriteBorderScaleFallback = new Vector2SizeModifier(Vector2.one, Vector2.zero, 3f * Vector2.one);

		// Token: 0x04000E81 RID: 3713
		[SerializeField]
		private Vector2SizeConfigCollection customBorderScales = new Vector2SizeConfigCollection();

		// Token: 0x04000E82 RID: 3714
		private Animator animator;
	}
}
