using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Visor
{
	// Token: 0x02000279 RID: 633
	public class ProcessorUIVariableManager : SerializedMonoBehaviour, IEscapeHandler
	{
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x00078036 File Offset: 0x00076236
		// (set) Token: 0x06001809 RID: 6153 RVA: 0x0007803E File Offset: 0x0007623E
		public ProcessorUI processorUI { get; private set; }

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x00078047 File Offset: 0x00076247
		// (set) Token: 0x0600180B RID: 6155 RVA: 0x0007804F File Offset: 0x0007624F
		public bool itemIsBeingEdited { get; set; }

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x00078058 File Offset: 0x00076258
		// (set) Token: 0x0600180D RID: 6157 RVA: 0x00078060 File Offset: 0x00076260
		public ProcessorUIVariableManagerItem lastEditedItem { get; set; }

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x00078069 File Offset: 0x00076269
		// (set) Token: 0x0600180F RID: 6159 RVA: 0x00078071 File Offset: 0x00076271
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x06001810 RID: 6160 RVA: 0x0007807C File Offset: 0x0007627C
		public void Setup(ProcessorUI theProcessorUI)
		{

		}

		// Token: 0x06001811 RID: 6161 RVA: 0x000780DF File Offset: 0x000762DF
		public void Close()
		{

		}

		// Token: 0x06001812 RID: 6162 RVA: 0x000780FE File Offset: 0x000762FE
		public void OnEscapePressed()
		{

		}

		// Token: 0x06001813 RID: 6163 RVA: 0x00078137 File Offset: 0x00076337
		public void ShowWarning(string theMessage)
		{

		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00078156 File Offset: 0x00076356
		public void HideWarning()
		{

		}

		// Token: 0x06001815 RID: 6165 RVA: 0x0007816C File Offset: 0x0007636C
		public void RemoveVariable(string variableName)
		{

		}

		// Token: 0x06001816 RID: 6166 RVA: 0x000781C4 File Offset: 0x000763C4
		public void AddVariable()
		{

		}

		// Token: 0x06001817 RID: 6167 RVA: 0x0007822C File Offset: 0x0007642C
		public void Populate()
		{

		}

		// Token: 0x06001818 RID: 6168 RVA: 0x000782F4 File Offset: 0x000764F4
		private IEnumerator ResetEscapeFlag()
		{

            return default;
        }

		// Token: 0x04001389 RID: 5001
		public GameObject itemPrefab;

		// Token: 0x0400138A RID: 5002
		public RectTransform content;

		// Token: 0x0400138B RID: 5003
		public GameObject message;

		// Token: 0x0400138C RID: 5004
		public TextMeshProUGUI warning;

		// Token: 0x0400138D RID: 5005
		public ScrollRectNoDragging scrollView;

		// Token: 0x0400138E RID: 5006
		private EscapeManager _escapeManager;
	}
}
