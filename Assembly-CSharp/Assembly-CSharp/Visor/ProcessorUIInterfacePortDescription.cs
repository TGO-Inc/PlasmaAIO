using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x0200026C RID: 620
	public class ProcessorUIInterfacePortDescription : MonoBehaviour, IEscapeHandler
	{
		// Token: 0x06001796 RID: 6038 RVA: 0x00075EFC File Offset: 0x000740FC
		public void Setup(AgentGestalt.Port port, ProcessorUI processorUI)
		{

		}

		// Token: 0x06001797 RID: 6039 RVA: 0x00075F8E File Offset: 0x0007418E
		public void CleanUp()
		{

		}

		// Token: 0x06001798 RID: 6040 RVA: 0x00075FB6 File Offset: 0x000741B6
		public void OnEscapePressed()
		{

		}

		// Token: 0x06001799 RID: 6041 RVA: 0x00075FC3 File Offset: 0x000741C3
		public void Apply()
		{

		}

		// Token: 0x0600179A RID: 6042 RVA: 0x00075FE8 File Offset: 0x000741E8
		private void HandleDescriptionChange(string text)
		{

		}

		// Token: 0x04001333 RID: 4915
		public TextMeshProUGUI title;

		// Token: 0x04001334 RID: 4916
		public TMP_InputField descriptionField;

		// Token: 0x04001335 RID: 4917
		public Button applyButton;

		// Token: 0x04001336 RID: 4918
		private AgentGestalt.Port _port;

		// Token: 0x04001337 RID: 4919
		private EscapeManager _escapeManager;

		// Token: 0x04001338 RID: 4920
		private ProcessorUI _processorUI;
	}
}
