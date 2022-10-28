using System;
using Sirenix.OdinInspector;
using TMPro;

namespace Visor
{
	// Token: 0x02000273 RID: 627
	public class ProcessorUIPropertyItem : SerializedMonoBehaviour
	{
		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x000775E0 File Offset: 0x000757E0
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x000775E8 File Offset: 0x000757E8
		public AgentProperty property { get; private set; }

		// Token: 0x060017D8 RID: 6104 RVA: 0x000775F1 File Offset: 0x000757F1
		public void Setup(AgentProperty theProperty, ProcessorUIComponentPropertyEditor editor)
		{

		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x0007761C File Offset: 0x0007581C
		public void OnClicked()
		{

		}

		// Token: 0x060017DA RID: 6106 RVA: 0x0007762B File Offset: 0x0007582B
		public void Select()
		{

		}

		// Token: 0x060017DB RID: 6107 RVA: 0x0007763E File Offset: 0x0007583E
		public void Deselect()
		{

		}

		// Token: 0x04001361 RID: 4961
		public TextMeshProUGUI propertyNameLabel;

		// Token: 0x04001362 RID: 4962
		public UIBetterButtonColorMapper normalMapper;

		// Token: 0x04001363 RID: 4963
		public UIBetterButtonColorMapper selectedMapper;

		// Token: 0x04001364 RID: 4964
		private ProcessorUIComponentPropertyEditor _editor;
	}
}
