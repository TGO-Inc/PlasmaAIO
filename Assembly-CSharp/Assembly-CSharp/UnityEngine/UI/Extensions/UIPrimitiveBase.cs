using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000231 RID: 561
	public class UIPrimitiveBase : MaskableGraphic, ILayoutElement, ICanvasRaycastFilter
	{
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060013B8 RID: 5048 RVA: 0x00065BA2 File Offset: 0x00063DA2
		// (set) Token: 0x060013B9 RID: 5049 RVA: 0x00065BAA File Offset: 0x00063DAA
		public Sprite sprite
		{
			get
			{
				return this.m_Sprite;
			}
			set
			{
				if (SetPropertyUtility.SetClass<Sprite>(ref this.m_Sprite, value))
				{
					this.GeneratedUVs();
				}
				this.SetAllDirty();
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x00065BC6 File Offset: 0x00063DC6
		// (set) Token: 0x060013BB RID: 5051 RVA: 0x00065BCE File Offset: 0x00063DCE
		public Sprite overrideSprite
		{
			get
			{
				return this.activeSprite;
			}
			set
			{
				if (SetPropertyUtility.SetClass<Sprite>(ref this.m_OverrideSprite, value))
				{
					this.GeneratedUVs();
				}
				this.SetAllDirty();
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x00065BEA File Offset: 0x00063DEA
		protected Sprite activeSprite
		{
			get
			{
				if (!(this.m_OverrideSprite != null))
				{
					return this.sprite;
				}
				return this.m_OverrideSprite;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x00065C07 File Offset: 0x00063E07
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x00065C0F File Offset: 0x00063E0F
		public float eventAlphaThreshold
		{
			get
			{
				return this.m_EventAlphaThreshold;
			}
			set
			{
				this.m_EventAlphaThreshold = value;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x00065C18 File Offset: 0x00063E18
		// (set) Token: 0x060013C0 RID: 5056 RVA: 0x00065C20 File Offset: 0x00063E20
		public ResolutionMode ImproveResolution
		{
			get
			{
				return this.m_improveResolution;
			}
			set
			{
				this.m_improveResolution = value;
				this.SetAllDirty();
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x00065C2F File Offset: 0x00063E2F
		// (set) Token: 0x060013C2 RID: 5058 RVA: 0x00065C37 File Offset: 0x00063E37
		public float Resoloution
		{
			get
			{
				return this.m_Resolution;
			}
			set
			{
				this.m_Resolution = value;
				this.SetAllDirty();
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x00065C46 File Offset: 0x00063E46
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x00065C4E File Offset: 0x00063E4E
		public bool UseNativeSize
		{
			get
			{
				return this.m_useNativeSize;
			}
			set
			{
				this.m_useNativeSize = value;
				this.SetAllDirty();
			}
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x00065C5D File Offset: 0x00063E5D
		protected UIPrimitiveBase()
		{

		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x00065C77 File Offset: 0x00063E77
		public static Material defaultETC1GraphicMaterial
		{
			get
			{
				if (UIPrimitiveBase.s_ETC1DefaultUI == null)
				{
					UIPrimitiveBase.s_ETC1DefaultUI = Canvas.GetETC1SupportedCanvasMaterial();
				}
				return UIPrimitiveBase.s_ETC1DefaultUI;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x00065C98 File Offset: 0x00063E98
		public override Texture mainTexture
		{
			get
			{
				if (!(this.activeSprite == null))
				{
					return this.activeSprite.texture;
				}
				if (this.material != null && this.material.mainTexture != null)
				{
					return this.material.mainTexture;
				}
				return Graphic.s_WhiteTexture;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060013C8 RID: 5064 RVA: 0x00065CF4 File Offset: 0x00063EF4
		public bool hasBorder
		{
			get
			{
				return this.activeSprite != null && this.activeSprite.border.sqrMagnitude > 0f;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060013C9 RID: 5065 RVA: 0x00065D2C File Offset: 0x00063F2C
		public float pixelsPerUnit
		{
			get
			{
				float num = 100f;
				if (this.activeSprite)
				{
					num = this.activeSprite.pixelsPerUnit;
				}
				float num2 = 100f;
				if (base.canvas)
				{
					num2 = base.canvas.referencePixelsPerUnit;
				}
				return num / num2;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060013CA RID: 5066 RVA: 0x00065D7C File Offset: 0x00063F7C
		// (set) Token: 0x060013CB RID: 5067 RVA: 0x00065DCA File Offset: 0x00063FCA
		public override Material material
		{
			get
			{
				if (this.m_Material != null)
				{
					return this.m_Material;
				}
				if (this.activeSprite && this.activeSprite.associatedAlphaSplitTexture != null)
				{
					return UIPrimitiveBase.defaultETC1GraphicMaterial;
				}
				return this.defaultMaterial;
			}
			set
			{
				base.material = value;
			}
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x00065DD4 File Offset: 0x00063FD4
		protected UIVertex[] SetVbo(Vector2[] vertices, Vector2[] uvs)
		{

            return default;
        }

		// Token: 0x060013CD RID: 5069 RVA: 0x00065E40 File Offset: 0x00064040
		protected Vector2[] IncreaseResolution(Vector2[] input)
		{

            return default;
        }

		// Token: 0x060013CE RID: 5070 RVA: 0x00065FC7 File Offset: 0x000641C7
		protected virtual void GeneratedUVs()
		{
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x00065FC9 File Offset: 0x000641C9
		protected virtual void ResolutionToNativeSize(float distance)
		{
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x00065FCB File Offset: 0x000641CB
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x00065FCD File Offset: 0x000641CD
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x00065FCF File Offset: 0x000641CF
		public virtual float minWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060013D3 RID: 5075 RVA: 0x00065FD8 File Offset: 0x000641D8
		public virtual float preferredWidth
		{
			get
			{
				if (this.overrideSprite == null)
				{
					return 0f;
				}
				return this.overrideSprite.rect.size.x / this.pixelsPerUnit;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060013D4 RID: 5076 RVA: 0x00066018 File Offset: 0x00064218
		public virtual float flexibleWidth
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060013D5 RID: 5077 RVA: 0x0006601F File Offset: 0x0006421F
		public virtual float minHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x00066028 File Offset: 0x00064228
		public virtual float preferredHeight
		{
			get
			{
				if (this.overrideSprite == null)
				{
					return 0f;
				}
				return this.overrideSprite.rect.size.y / this.pixelsPerUnit;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x00066068 File Offset: 0x00064268
		public virtual float flexibleHeight
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x0006606F File Offset: 0x0006426F
		public virtual int layoutPriority
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00066074 File Offset: 0x00064274
		public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
		{

            return default;
        }

		// Token: 0x060013DA RID: 5082 RVA: 0x000661DC File Offset: 0x000643DC
		private Vector2 MapCoordinate(Vector2 local, Rect rect)
		{

            return default;
        }

		// Token: 0x060013DB RID: 5083 RVA: 0x0006620C File Offset: 0x0006440C
		private Vector4 GetAdjustedBorders(Vector4 border, Rect rect)
		{

            return default;
        }

		// Token: 0x060013DC RID: 5084 RVA: 0x000662A3 File Offset: 0x000644A3
		protected override void OnEnable()
		{

		}

		// Token: 0x04001019 RID: 4121
		protected static Material s_ETC1DefaultUI;

		// Token: 0x0400101A RID: 4122
		[SerializeField]
		private Sprite m_Sprite;

		// Token: 0x0400101B RID: 4123
		[NonSerialized]
		private Sprite m_OverrideSprite;

		// Token: 0x0400101C RID: 4124
		internal float m_EventAlphaThreshold = 1f;

		// Token: 0x0400101D RID: 4125
		[SerializeField]
		private ResolutionMode m_improveResolution;

		// Token: 0x0400101E RID: 4126
		[SerializeField]
		protected float m_Resolution;

		// Token: 0x0400101F RID: 4127
		[SerializeField]
		private bool m_useNativeSize;
	}
}
