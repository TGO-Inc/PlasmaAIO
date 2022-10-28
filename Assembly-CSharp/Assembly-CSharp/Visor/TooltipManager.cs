using System;
using System.Collections;
using System.Collections.Generic;
using Behavior;
using UnityEngine;

namespace Visor
{
	// Token: 0x0200028B RID: 651
	public class TooltipManager : MonoBehaviour
	{
		// Token: 0x060019B4 RID: 6580 RVA: 0x00082574 File Offset: 0x00080774
		private void Awake()
		{

		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x0008258D File Offset: 0x0008078D
		public void Setup()
		{

		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x000825AA File Offset: 0x000807AA
		public void CleanUp()
		{

		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x000825B4 File Offset: 0x000807B4
		public int ShowPropertyTooltip(AgentProperty property, Vector2 position, bool right, Device device = null, Sketch sketch = null, SketchNode sketchNode = null)
		{

            return default;
        }

		// Token: 0x060019B8 RID: 6584 RVA: 0x00082640 File Offset: 0x00080840
		public int ShowIconTooltip(string message, Vector2 position, bool showAsWarning)
		{

            return default;
        }

		// Token: 0x060019B9 RID: 6585 RVA: 0x000826B1 File Offset: 0x000808B1
		public void HideTooltip(int index)
		{

		}

		// Token: 0x060019BA RID: 6586 RVA: 0x000826C5 File Offset: 0x000808C5
		public void HideAllTooltips()
		{

		}

		// Token: 0x060019BB RID: 6587 RVA: 0x000826D9 File Offset: 0x000808D9
		private IEnumerator Run()
		{

            return default;
        }

		// Token: 0x060019BC RID: 6588 RVA: 0x000826E8 File Offset: 0x000808E8
		private bool RunFSM()
		{

            return default;
        }

		// Token: 0x060019BD RID: 6589 RVA: 0x00082814 File Offset: 0x00080A14
		private KeyValuePair<TooltipManager.Events, int> GetEvent()
		{

            return default;
        }

		// Token: 0x060019BE RID: 6590 RVA: 0x00082868 File Offset: 0x00080A68
		private void SpawnTooltip()
		{

		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0008298C File Offset: 0x00080B8C
		public void ShowDatatypeWarning(Data.Types outputType, Data.Types inputType, Vector2 position)
		{

		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x000829F7 File Offset: 0x00080BF7
		public void HideDatatypeWarning()
		{

		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00082A1C File Offset: 0x00080C1C
		public void ShowConnectionExistsWarning(Vector2 position)
		{

		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00082A75 File Offset: 0x00080C75
		public void HideConnectionExistsWarning()
		{

		}

		// Token: 0x040014D8 RID: 5336
		public GameObject tooltipLeftPrefab;

		// Token: 0x040014D9 RID: 5337
		public GameObject tooltipRightPrefab;

		// Token: 0x040014DA RID: 5338
		public GameObject tooltipHeaderPrefab;

		// Token: 0x040014DB RID: 5339
		public GameObject datatypeWarningPrefab;

		// Token: 0x040014DC RID: 5340
		public GameObject connectionExistsWarningPrefab;

		// Token: 0x040014DD RID: 5341
		public float delay;

		// Token: 0x040014DE RID: 5342
		private ProcessorUI _processorUI;

		// Token: 0x040014DF RID: 5343
		private int _nextTooltipIndex;

		// Token: 0x040014E0 RID: 5344
		private TooltipManager.TooltipInfo _nextTooltip;

		// Token: 0x040014E1 RID: 5345
		private int _currentTooltipIndex;

		// Token: 0x040014E2 RID: 5346
		private TooltipManager.States _state;

		// Token: 0x040014E3 RID: 5347
		private float _elapsed;

		// Token: 0x040014E4 RID: 5348
		private List<KeyValuePair<TooltipManager.Events, int>> _queuedEvents;

		// Token: 0x040014E5 RID: 5349
		private GameObject _datatypeWarning;

		// Token: 0x040014E6 RID: 5350
		private GameObject _connectionExistsWarning;

		// Token: 0x0200048C RID: 1164
		private enum Events
		{
			// Token: 0x04001FF5 RID: 8181
			None,
			// Token: 0x04001FF6 RID: 8182
			ShowTooltip,
			// Token: 0x04001FF7 RID: 8183
			HideTooltip
		}

		// Token: 0x0200048D RID: 1165
		private enum States
		{
			// Token: 0x04001FF9 RID: 8185
			Idle,
			// Token: 0x04001FFA RID: 8186
			Wait,
			// Token: 0x04001FFB RID: 8187
			Show,
			// Token: 0x04001FFC RID: 8188
			ShowIdle,
			// Token: 0x04001FFD RID: 8189
			Hide
		}

		// Token: 0x0200048E RID: 1166
		private struct TooltipInfo
		{
			// Token: 0x04001FFE RID: 8190
			public AgentProperty property;

			// Token: 0x04001FFF RID: 8191
			public Vector2 position;

			// Token: 0x04002000 RID: 8192
			public bool right;

			// Token: 0x04002001 RID: 8193
			public string message;

			// Token: 0x04002002 RID: 8194
			public bool isWarning;

			// Token: 0x04002003 RID: 8195
			public Device device;

			// Token: 0x04002004 RID: 8196
			public Sketch sketch;

			// Token: 0x04002005 RID: 8197
			public SketchNode sketchNode;
		}
	}
}
