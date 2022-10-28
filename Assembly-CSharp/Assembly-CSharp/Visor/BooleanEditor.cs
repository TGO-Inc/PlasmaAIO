using System;
using Behavior;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x0200028E RID: 654
	public class BooleanEditor : DataEditor
	{
		// Token: 0x060019CD RID: 6605 RVA: 0x00082C14 File Offset: 0x00080E14
		public override void Setup(Agent agent, int propertyId, ProcessorUI processorUI = null, bool canClose = true)
		{

		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00082D1A File Offset: 0x00080F1A
		public override void CleanUp()
		{

		}

		// Token: 0x060019CF RID: 6607 RVA: 0x00082D50 File Offset: 0x00080F50
		public void OnOnClicked()
		{

		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00082D74 File Offset: 0x00080F74
		public void OnOffClicked()
		{

		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00082D98 File Offset: 0x00080F98
		private void Update()
		{

		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00082E5C File Offset: 0x0008105C
		private void SetPowerButton(bool value, bool instant = false)
		{

		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00082F27 File Offset: 0x00081127
		private void HandleToggle(bool value)
		{

		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00082F36 File Offset: 0x00081136
		private void HandlePowerClick()
		{

		}

		// Token: 0x040014EE RID: 5358
		public BetterToggle normalToggle;

		// Token: 0x040014EF RID: 5359
		public BetterButton powerButton;

		// Token: 0x040014F0 RID: 5360
		public UIColorMapperController colorMapper;

		// Token: 0x040014F1 RID: 5361
		private RectTransform _powerButtonRect;
	}
}
