using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	// Token: 0x020001E2 RID: 482
	[AddComponentMenu("Better UI/Layout/Better Content Size Fitter", 30)]
	public class BetterContentSizeFitter : ContentSizeFitter, IResolutionDependency, ILayoutChildDependency
	{
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x0005A7C0 File Offset: 0x000589C0
		private RectTransform rectTransform
		{
			get
			{
				return base.transform as RectTransform;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x0005A7CD File Offset: 0x000589CD
		public BetterContentSizeFitter.Settings CurrentSettings
		{
			get
			{
				return this.customSettings.GetCurrentItem(this.settingsFallback);
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x0005A7E0 File Offset: 0x000589E0
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x0005A7FD File Offset: 0x000589FD
		public RectTransform Source
		{
			get
			{
				if (!(this.source != null))
				{
					return this.rectTransform;
				}
				return this.source;
			}
			set
			{
				this.source = value;
				base.SetDirty();
			}
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0005A80C File Offset: 0x00058A0C
		protected override void OnEnable()
		{

		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0005A81A File Offset: 0x00058A1A
		protected override void OnDisable()
		{

		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0005A829 File Offset: 0x00058A29
		public void OnResolutionChanged()
		{

		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0005A834 File Offset: 0x00058A34
		private void Apply()
		{

		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0005A866 File Offset: 0x00058A66
		public override void SetLayoutHorizontal()
		{

		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0005A86F File Offset: 0x00058A6F
		public override void SetLayoutVertical()
		{

		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0005A878 File Offset: 0x00058A78
		private void SetLayout(int axis)
		{

		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0005A93C File Offset: 0x00058B3C
		private void ApplyOffsetToDefaultSize(int axis, ContentSizeFitter.FitMode fitMode)
		{

		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0005AA00 File Offset: 0x00058C00
		private float ClampSize(RectTransform.Axis axis, float size)
		{

            return default;
        }

		// Token: 0x0600111A RID: 4378 RVA: 0x0005AAC8 File Offset: 0x00058CC8
		private Bounds GetChildBounds()
		{

            return default;
        }

		// Token: 0x0600111B RID: 4379 RVA: 0x0005AB2C File Offset: 0x00058D2C
		public void ChildSizeChanged(Transform child)
		{

		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0005AB34 File Offset: 0x00058D34
		public void ChildAddedOrEnabled(Transform child)
		{

		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0005AB3C File Offset: 0x00058D3C
		public void ChildRemovedOrDisabled(Transform child)
		{

		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0005AB44 File Offset: 0x00058D44
		private void ChildChanged()
		{

		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0005AB81 File Offset: 0x00058D81
		private void Animate()
		{

		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0005ABA4 File Offset: 0x00058DA4
		private IEnumerator CoAnimate()
		{

            return default;
        }

		// Token: 0x04000EC3 RID: 3779
		[SerializeField]
		private RectTransform source;

		// Token: 0x04000EC4 RID: 3780
		[SerializeField]
		private BetterContentSizeFitter.Settings settingsFallback = new BetterContentSizeFitter.Settings();

		// Token: 0x04000EC5 RID: 3781
		[SerializeField]
		private BetterContentSizeFitter.SettingsConfigCollection customSettings = new BetterContentSizeFitter.SettingsConfigCollection();

		// Token: 0x04000EC6 RID: 3782
		[SerializeField]
		private FloatSizeModifier minWidthSizerFallback = new FloatSizeModifier(0f, 0f, 4000f);

		// Token: 0x04000EC7 RID: 3783
		[SerializeField]
		private FloatSizeConfigCollection minWidthSizers = new FloatSizeConfigCollection();

		// Token: 0x04000EC8 RID: 3784
		[SerializeField]
		private FloatSizeModifier minHeightSizerFallback = new FloatSizeModifier(0f, 0f, 4000f);

		// Token: 0x04000EC9 RID: 3785
		[SerializeField]
		private FloatSizeConfigCollection minHeightSizers = new FloatSizeConfigCollection();

		// Token: 0x04000ECA RID: 3786
		[SerializeField]
		private FloatSizeModifier maxWidthSizerFallback = new FloatSizeModifier(1000f, 0f, 4000f);

		// Token: 0x04000ECB RID: 3787
		[SerializeField]
		private FloatSizeConfigCollection maxWidthSizers = new FloatSizeConfigCollection();

		// Token: 0x04000ECC RID: 3788
		[SerializeField]
		private FloatSizeModifier maxHeightSizerFallback = new FloatSizeModifier(1000f, 0f, 4000f);

		// Token: 0x04000ECD RID: 3789
		[SerializeField]
		private FloatSizeConfigCollection maxHeightSizers = new FloatSizeConfigCollection();

		// Token: 0x04000ECE RID: 3790
		[SerializeField]
		private Vector2SizeModifier paddingFallback = new Vector2SizeModifier(default(Vector2), new Vector2(-5000f, -5000f), new Vector2(5000f, 5000f));

		// Token: 0x04000ECF RID: 3791
		[SerializeField]
		private Vector2SizeConfigCollection paddingSizers = new Vector2SizeConfigCollection();

		// Token: 0x04000ED0 RID: 3792
		private RectTransformData start = new RectTransformData();

		// Token: 0x04000ED1 RID: 3793
		private RectTransformData end = new RectTransformData();

		// Token: 0x04000ED2 RID: 3794
		private bool isAnimating;

		// Token: 0x020003F9 RID: 1017
		[Serializable]
		public class Settings : IScreenConfigConnection
		{
			// Token: 0x17000517 RID: 1303
			// (get) Token: 0x0600219C RID: 8604 RVA: 0x000A3E76 File Offset: 0x000A2076
			// (set) Token: 0x0600219D RID: 8605 RVA: 0x000A3E7E File Offset: 0x000A207E
			public string ScreenConfigName
			{
				get
				{
					return this.screenConfigName;
				}
				set
				{
					this.screenConfigName = value;
				}
			}

			// Token: 0x04001DF2 RID: 7666
			public ContentSizeFitter.FitMode HorizontalFit;

			// Token: 0x04001DF3 RID: 7667
			public ContentSizeFitter.FitMode VerticalFit;

			// Token: 0x04001DF4 RID: 7668
			public bool IsAnimated;

			// Token: 0x04001DF5 RID: 7669
			public float AnimationTime = 0.2f;

			// Token: 0x04001DF6 RID: 7670
			public bool HasMinWidth;

			// Token: 0x04001DF7 RID: 7671
			public bool HasMinHeight;

			// Token: 0x04001DF8 RID: 7672
			public bool HasMaxWidth;

			// Token: 0x04001DF9 RID: 7673
			public bool HasMaxHeight;

			// Token: 0x04001DFA RID: 7674
			[SerializeField]
			private string screenConfigName;
		}

		// Token: 0x020003FA RID: 1018
		[Serializable]
		public class SettingsConfigCollection : SizeConfigCollection<BetterContentSizeFitter.Settings>
		{
		}
	}
}
