using System;
using System.Collections;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Rewired;
using UnityEngine;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x02000255 RID: 597
	public class PaletteSelector : VisorElement
	{
		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x0006F7CB File Offset: 0x0006D9CB
		// (set) Token: 0x0600162A RID: 5674 RVA: 0x0006F7D3 File Offset: 0x0006D9D3
		public bool isRunning { get; set; }

		// Token: 0x0600162B RID: 5675 RVA: 0x0006F7DC File Offset: 0x0006D9DC
		protected override void CustomSetup()
		{

		}

		// Token: 0x0600162C RID: 5676 RVA: 0x0006F857 File Offset: 0x0006DA57
		public IEnumerator RunSelection(bool primary)
		{

            return default;
        }

		// Token: 0x0600162D RID: 5677 RVA: 0x0006F870 File Offset: 0x0006DA70
		private void HighlightColor(int index, bool sound = true)
		{

		}

		// Token: 0x0600162E RID: 5678 RVA: 0x0006F8D0 File Offset: 0x0006DAD0
		private void RefreshColors()
		{

		}

		// Token: 0x0600162F RID: 5679 RVA: 0x0006F928 File Offset: 0x0006DB28
		public void SetupColors(bool primary)
		{

		}

		// Token: 0x040011F0 RID: 4592
		public Image primaryColor;

		// Token: 0x040011F1 RID: 4593
		public Image secondaryColor;

		// Token: 0x040011F2 RID: 4594
		public RectTransform panel;

		// Token: 0x040011F3 RID: 4595
		public Transform colors;

		// Token: 0x040011F4 RID: 4596
		private int _previousIndex;

		// Token: 0x040011F5 RID: 4597
		private string _paintKey;

		// Token: 0x040011F6 RID: 4598
		private Player _input;
	}
}
