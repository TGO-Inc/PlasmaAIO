using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

namespace Visor
{
	// Token: 0x020002A2 RID: 674
	public class SoundBrowser : MonoBehaviour, ISmoothScrollListProvider
	{
		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001A8E RID: 6798 RVA: 0x0008698D File Offset: 0x00084B8D
		// (set) Token: 0x06001A8F RID: 6799 RVA: 0x00086995 File Offset: 0x00084B95
		public string searchString { get; set; }

		// Token: 0x06001A90 RID: 6800 RVA: 0x0008699E File Offset: 0x00084B9E
		public void Setup(SoundEditor editor)
		{

		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x000869C0 File Offset: 0x00084BC0
		public void Populate(RectTransform content)
		{

		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00086B30 File Offset: 0x00084D30
		public void StopLastSoundRow(PlaySoundButton currentSoundButton)
		{

		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00086B53 File Offset: 0x00084D53
		public void ClearLastSoundRow()
		{

		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00086B5C File Offset: 0x00084D5C
		public void OnSoundRowClicked(SoundRow soundRow)
		{

		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x00086BB0 File Offset: 0x00084DB0
		public void SelectSoundRowByEvent(string soundEvent)
		{

		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00086C48 File Offset: 0x00084E48
		public void SelectEmptySoundRow()
		{

		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00086C78 File Offset: 0x00084E78
		public void ModifyPosition(RectTransform item)
		{

		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00086CE3 File Offset: 0x00084EE3
		public float GetItemHeight()
		{

            return default;
        }

		// Token: 0x06001A99 RID: 6809 RVA: 0x00086CFA File Offset: 0x00084EFA
		public int GetInitialTopItemIndex()
		{

            return default;
        }

		// Token: 0x06001A9A RID: 6810 RVA: 0x00086CFD File Offset: 0x00084EFD
		public void OnEnterViewport(RectTransform item)
		{

		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00086D0B File Offset: 0x00084F0B
		public void OnExitViewport(RectTransform item)
		{
		}

		// Token: 0x0400159D RID: 5533
		public GameObject soundRowPrefab;

		// Token: 0x0400159E RID: 5534
		[FormerlySerializedAs("soundRowNonePrefab")]
		public GameObject soundRowEmptyPrefab;

		// Token: 0x0400159F RID: 5535
		public GameObject searchField;

		// Token: 0x040015A0 RID: 5536
		public GameObject importButton;

		// Token: 0x040015A1 RID: 5537
		public GameObject noAssets;

		// Token: 0x040015A2 RID: 5538
		public float radius;

		// Token: 0x040015A3 RID: 5539
		public float offsetX;

		// Token: 0x040015A4 RID: 5540
		public float offsetY;

		// Token: 0x040015A5 RID: 5541
		private RectTransform _content;

		// Token: 0x040015A6 RID: 5542
		private SoundRow _selectedSoundRow;

		// Token: 0x040015A7 RID: 5543
		private UISmoothScrollList _scrollList;

		// Token: 0x040015A8 RID: 5544
		private SoundEditor _editor;

		// Token: 0x040015A9 RID: 5545
		private SoundRow _emptyRow;

		// Token: 0x040015AA RID: 5546
		private PlaySoundButton _lastSoundButton;
	}
}
