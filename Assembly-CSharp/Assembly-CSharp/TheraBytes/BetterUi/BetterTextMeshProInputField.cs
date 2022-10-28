using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TheraBytes.BetterUi
{
	// Token: 0x02000217 RID: 535
	[AddComponentMenu("Better UI/TextMeshPro/Better TextMeshPro - Input Field", 30)]
	public class BetterTextMeshProInputField : TMP_InputField, IBetterTransitionUiElement, IResolutionDependency
	{
		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x0005E06E File Offset: 0x0005C26E
		public List<Transitions> BetterTransitions
		{
			get
			{
				return this.betterTransitions;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x0005E076 File Offset: 0x0005C276
		public List<Graphic> AdditionalPlaceholders
		{
			get
			{
				return this.additionalPlaceholders;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x0005E07E File Offset: 0x0005C27E
		public FloatSizeModifier PointSizeScaler
		{
			get
			{
				return this.pointSizeScaler;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x0005E086 File Offset: 0x0005C286
		// (set) Token: 0x0600125F RID: 4703 RVA: 0x0005E08E File Offset: 0x0005C28E
		public bool OverridePointSizeSettings
		{
			get
			{
				return this.overridePointSize;
			}
			set
			{
				this.overridePointSize = value;
			}
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0005E098 File Offset: 0x0005C298
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{

		}

		// Token: 0x06001261 RID: 4705 RVA: 0x0005E10C File Offset: 0x0005C30C
		public override void OnUpdateSelected(BaseEventData eventData)
		{

		}

		// Token: 0x06001262 RID: 4706 RVA: 0x0005E124 File Offset: 0x0005C324
		private void DisplayPlaceholders(string input)
		{

		}

		// Token: 0x06001263 RID: 4707 RVA: 0x0005E184 File Offset: 0x0005C384
		protected override void OnEnable()
		{

		}

		// Token: 0x06001264 RID: 4708 RVA: 0x0005E192 File Offset: 0x0005C392
		protected override void OnRectTransformDimensionsChange()
		{

		}

		// Token: 0x06001265 RID: 4709 RVA: 0x0005E1A0 File Offset: 0x0005C3A0
		public void OnResolutionChanged()
		{

		}

		// Token: 0x06001266 RID: 4710 RVA: 0x0005E1A8 File Offset: 0x0005C3A8
		public void CalculateSize()
		{

		}

		// Token: 0x06001267 RID: 4711 RVA: 0x0005E250 File Offset: 0x0005C450
		private void OverrideBetterTextMeshSize(BetterTextMeshProUGUI better, float size)
		{

		}

		// Token: 0x04000F6C RID: 3948
		[SerializeField]
		private List<Transitions> betterTransitions = new List<Transitions>();

		// Token: 0x04000F6D RID: 3949
		[SerializeField]
		private List<Graphic> additionalPlaceholders = new List<Graphic>();

		// Token: 0x04000F6E RID: 3950
		[SerializeField]
		private FloatSizeModifier pointSizeScaler = new FloatSizeModifier(36f, 10f, 500f);

		// Token: 0x04000F6F RID: 3951
		[SerializeField]
		private bool overridePointSize;
	}
}
