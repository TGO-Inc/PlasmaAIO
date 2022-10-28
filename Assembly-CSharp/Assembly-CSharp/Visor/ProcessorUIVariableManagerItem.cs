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
	// Token: 0x0200027A RID: 634
	public class ProcessorUIVariableManagerItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x0600181A RID: 6170 RVA: 0x0007830B File Offset: 0x0007650B
		private void Awake()
		{

		}

		// Token: 0x0600181B RID: 6171 RVA: 0x00078338 File Offset: 0x00076538
		public void Setup(AgentProperty theVariable, bool alternate)
		{

		}

		// Token: 0x0600181C RID: 6172 RVA: 0x000783D4 File Offset: 0x000765D4
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00078414 File Offset: 0x00076614
		private void HandleEndEdit(string text)
		{

		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00078490 File Offset: 0x00076690
		private void HandleSelection(string text)
		{

		}

		// Token: 0x0600181F RID: 6175 RVA: 0x000784A0 File Offset: 0x000766A0
		private void RenameVariable(string text)
		{

		}

		// Token: 0x06001820 RID: 6176 RVA: 0x000785A0 File Offset: 0x000767A0
		private void UpdateUsages()
		{

		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00078610 File Offset: 0x00076810
		private void BuildPreview()
		{

		}

		// Token: 0x06001822 RID: 6178 RVA: 0x000787AC File Offset: 0x000769AC
		public void RemoveVariable()
		{

		}

		// Token: 0x06001823 RID: 6179 RVA: 0x000787C9 File Offset: 0x000769C9
		public void ShowDataTypeSelector()
		{

		}

		// Token: 0x06001824 RID: 6180 RVA: 0x000787FC File Offset: 0x000769FC
		public void ShowEditor()
		{

		}

		// Token: 0x06001825 RID: 6181 RVA: 0x0007882F File Offset: 0x00076A2F
		public void ToggleBoolean()
		{

		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00078864 File Offset: 0x00076A64
		public void OnPointerEnter(PointerEventData data)
		{

		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00078983 File Offset: 0x00076B83
		public void OnPointerExit(PointerEventData data)
		{

		}

		// Token: 0x06001828 RID: 6184 RVA: 0x000789A0 File Offset: 0x00076BA0
		private void Unhighlight()
		{

		}

		// Token: 0x04001393 RID: 5011
		public TMP_InputField title;

		// Token: 0x04001394 RID: 5012
		public TextMeshProUGUI usagesLabel;

		// Token: 0x04001395 RID: 5013
		public GameObject trashButton;

		// Token: 0x04001396 RID: 5014
		public GameObject nonePreview;

		// Token: 0x04001397 RID: 5015
		public GameObject booleanPreview;

		// Token: 0x04001398 RID: 5016
		public GameObject textPreview;

		// Token: 0x04001399 RID: 5017
		public GameObject colorPreview;

		// Token: 0x0400139A RID: 5018
		public GameObject booleanSymbol;

		// Token: 0x0400139B RID: 5019
		public BetterButton typeButton;

		// Token: 0x0400139C RID: 5020
		private ProcessorUIVariableManager _manager;

		// Token: 0x0400139D RID: 5021
		private UIBetterInputFieldColorMapper _nameColorMapper;

		// Token: 0x0400139E RID: 5022
		private UIColorMapperController _mapperController;

		// Token: 0x0400139F RID: 5023
		private bool _alternate;

		// Token: 0x040013A0 RID: 5024
		private bool _mouseInside;

		// Token: 0x040013A1 RID: 5025
		private AgentProperty _variable;
	}
}
