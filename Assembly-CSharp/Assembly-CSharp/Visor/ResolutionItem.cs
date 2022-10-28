using System;
using Sirenix.OdinInspector;
using TMPro;

namespace Visor
{
	// Token: 0x020002AB RID: 683
	public class ResolutionItem : SerializedMonoBehaviour
	{
		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x000876CD File Offset: 0x000858CD
		// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x000876D5 File Offset: 0x000858D5
		public int index { get; private set; }

		// Token: 0x06001AD6 RID: 6870 RVA: 0x000876DE File Offset: 0x000858DE
		public void Setup(string theResolution, int theIndex, SettingsPopup settingsPopup)
		{

		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x000876FA File Offset: 0x000858FA
		public void OnClicked()
		{

		}

		// Token: 0x06001AD8 RID: 6872 RVA: 0x00087708 File Offset: 0x00085908
		public void Select()
		{

		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x0008771B File Offset: 0x0008591B
		public void Deselect()
		{

		}

		// Token: 0x040015D7 RID: 5591
		public TextMeshProUGUI resolution;

		// Token: 0x040015D8 RID: 5592
		public UIBetterButtonColorMapper normalMapper;

		// Token: 0x040015D9 RID: 5593
		public UIBetterButtonColorMapper selectedMapper;

		// Token: 0x040015DA RID: 5594
		private SettingsPopup _settingsPopup;
	}
}
