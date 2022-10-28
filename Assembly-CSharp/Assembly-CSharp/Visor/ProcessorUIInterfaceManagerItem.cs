using System;
using Behavior;
using TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x0200026B RID: 619
	public class ProcessorUIInterfaceManagerItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x06001789 RID: 6025 RVA: 0x000759DB File Offset: 0x00073BDB
		private void Awake()
		{

		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00075A08 File Offset: 0x00073C08
		public void Setup(int portId, AgentGestalt.Port port, bool alternate)
		{

		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00075B15 File Offset: 0x00073D15
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00075B54 File Offset: 0x00073D54
		private void HandleEndEdit(string text)
		{

		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00075BCB File Offset: 0x00073DCB
		private void HandleSelection(string text)
		{

		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00075BDC File Offset: 0x00073DDC
		private void RenamePort(string text)
		{

		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00075CBC File Offset: 0x00073EBC
		public void Remove()
		{

		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00075D1D File Offset: 0x00073F1D
		public void ShowDataTypeSelector()
		{

		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00075D4B File Offset: 0x00073F4B
		public void ShowDescriptionEditor()
		{

		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00075D64 File Offset: 0x00073F64
		public void OnPointerEnter(PointerEventData data)
		{

		}

		// Token: 0x06001793 RID: 6035 RVA: 0x00075E3C File Offset: 0x0007403C
		public void OnPointerExit(PointerEventData data)
		{

		}

		// Token: 0x06001794 RID: 6036 RVA: 0x00075E58 File Offset: 0x00074058
		private void Unhighlight()
		{

		}

		// Token: 0x04001328 RID: 4904
		public TMP_InputField title;

		// Token: 0x04001329 RID: 4905
		public GameObject trashButton;

		// Token: 0x0400132A RID: 4906
		public GameObject descriptionButton;

		// Token: 0x0400132B RID: 4907
		public BetterButton typeButton;

		// Token: 0x0400132C RID: 4908
		private ProcessorUIInterfaceManager _manager;

		// Token: 0x0400132D RID: 4909
		private UIBetterInputFieldColorMapper _nameColorMapper;

		// Token: 0x0400132E RID: 4910
		private UIColorMapperController _mapperController;

		// Token: 0x0400132F RID: 4911
		private bool _alternate;

		// Token: 0x04001330 RID: 4912
		private bool _mouseInside;

		// Token: 0x04001331 RID: 4913
		private int _portId;

		// Token: 0x04001332 RID: 4914
		private AgentGestalt.Port _port;
	}
}
