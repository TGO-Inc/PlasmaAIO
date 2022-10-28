using System;
using Behavior;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x0200028F RID: 655
	public class ColorEditor : DataEditor
	{
		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x00082F6C File Offset: 0x0008116C
		public override TMP_InputField mainTextField
		{
			get
			{
				return this.hexValue;
			}
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00082F74 File Offset: 0x00081174
		public override void Setup(Agent agent, int propertyId, ProcessorUI processorUI = null, bool canClose = true)
		{

		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x000830A3 File Offset: 0x000812A3
		public override void CleanUp()
		{

		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x000830DC File Offset: 0x000812DC
		private void SetColor(Color color)
		{

		}

		// Token: 0x060019DA RID: 6618 RVA: 0x00083131 File Offset: 0x00081331
		public void RevertToOldColor()
		{

		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00083151 File Offset: 0x00081351
		public void UseSwatch(int index)
		{

		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0008317B File Offset: 0x0008137B
		public void SetSwatch(ColorSwatch swatch)
		{

		}

		// Token: 0x060019DD RID: 6621 RVA: 0x000831AE File Offset: 0x000813AE
		private void HandleChange(string text)
		{

		}

		// Token: 0x060019DE RID: 6622 RVA: 0x000831B8 File Offset: 0x000813B8
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0008323E File Offset: 0x0008143E
		private void HandleSelection(string text)
		{

		}

		// Token: 0x040014F2 RID: 5362
		public Image oldColor;

		// Token: 0x040014F3 RID: 5363
		public Image currentColor;

		// Token: 0x040014F4 RID: 5364
		public TMP_InputField hexValue;

		// Token: 0x040014F5 RID: 5365
		public FastColorPicker colorPicker;

		// Token: 0x040014F6 RID: 5366
		public Transform swatches;

		// Token: 0x040014F7 RID: 5367
		private Color _oldColor;

		// Token: 0x040014F8 RID: 5368
		private string _undoValue;
	}
}
