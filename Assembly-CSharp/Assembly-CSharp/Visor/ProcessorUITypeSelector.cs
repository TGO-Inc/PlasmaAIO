using System;
using UnityEngine;

namespace Visor
{
	// Token: 0x02000276 RID: 630
	public class ProcessorUITypeSelector : MonoBehaviour, IEscapeHandler
	{
		// Token: 0x060017F5 RID: 6133 RVA: 0x00077BE8 File Offset: 0x00075DE8
		public void Setup(ProcessorUI processorUI, bool showVariable, bool forInterface, bool showAny, bool showNone)
		{

		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00077C41 File Offset: 0x00075E41
		public void CleanUp()
		{

		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00077C4E File Offset: 0x00075E4E
		public void Close()
		{

		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00077C70 File Offset: 0x00075E70
		public void OnEscapePressed()
		{

		}

		// Token: 0x04001378 RID: 4984
		public GameObject variableArea;

		// Token: 0x04001379 RID: 4985
		public GameObject noneType;

		// Token: 0x0400137A RID: 4986
		public GameObject anyType;

		// Token: 0x0400137B RID: 4987
		private ProcessorUI _processorUI;

		// Token: 0x0400137C RID: 4988
		private EscapeManager _escapeManager;

		// Token: 0x0400137D RID: 4989
		private bool _forInterface;
	}
}
