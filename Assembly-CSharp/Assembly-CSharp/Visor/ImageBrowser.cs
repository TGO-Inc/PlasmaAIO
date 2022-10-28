using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Visor
{
	// Token: 0x02000293 RID: 659
	public class ImageBrowser : MonoBehaviour, ISmoothScrollListProvider
	{
		// Token: 0x17000328 RID: 808
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x0008348F File Offset: 0x0008168F
		// (set) Token: 0x060019F6 RID: 6646 RVA: 0x00083497 File Offset: 0x00081697
		public string searchString { get; set; }

		// Token: 0x060019F7 RID: 6647 RVA: 0x000834A0 File Offset: 0x000816A0
		public void Setup(ImageEditor editor)
		{

		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x000834C4 File Offset: 0x000816C4
		public void Populate(RectTransform content)
		{

		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x000835E8 File Offset: 0x000817E8
		public void OnImageRowClicked(ImageRow imageRow)
		{

		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0008363C File Offset: 0x0008183C
		public void SelectImageRowByMD5(string md5)
		{

		}

		// Token: 0x060019FB RID: 6651 RVA: 0x000836D8 File Offset: 0x000818D8
		public void SelectEmptyImageRow()
		{

		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00083707 File Offset: 0x00081907
		public void SelectRuntimeImageRow()
		{

		}

		// Token: 0x060019FD RID: 6653 RVA: 0x00083738 File Offset: 0x00081938
		public void ModifyPosition(RectTransform item)
		{

		}

		// Token: 0x060019FE RID: 6654 RVA: 0x000837A3 File Offset: 0x000819A3
		public float GetItemHeight()
		{

            return default;
        }

		// Token: 0x060019FF RID: 6655 RVA: 0x000837BA File Offset: 0x000819BA
		public int GetInitialTopItemIndex()
		{

            return default;
        }

		// Token: 0x06001A00 RID: 6656 RVA: 0x000837BD File Offset: 0x000819BD
		public void OnEnterViewport(RectTransform item)
		{

		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x000837D6 File Offset: 0x000819D6
		public void OnExitViewport(RectTransform item)
		{

		}

		// Token: 0x0400150D RID: 5389
		public GameObject imageRowPrefab;

		// Token: 0x0400150E RID: 5390
		public GameObject imageRowRuntimePrefab;

		// Token: 0x0400150F RID: 5391
		[FormerlySerializedAs("imageRowNonePrefab")]
		public GameObject imageRowEmptyPrefab;

		// Token: 0x04001510 RID: 5392
		public GameObject searchField;

		// Token: 0x04001511 RID: 5393
		public GameObject importButton;

		// Token: 0x04001512 RID: 5394
		public GameObject noAssets;

		// Token: 0x04001513 RID: 5395
		public float radius;

		// Token: 0x04001514 RID: 5396
		public float offsetX;

		// Token: 0x04001515 RID: 5397
		public float offsetY;

		// Token: 0x04001516 RID: 5398
		private RectTransform _content;

		// Token: 0x04001517 RID: 5399
		private ImageRow _selectedImageRow;

		// Token: 0x04001518 RID: 5400
		private UISmoothScrollList _scrollList;

		// Token: 0x04001519 RID: 5401
		private ImageEditor _editor;

		// Token: 0x0400151A RID: 5402
		private ImageRow _runtimeRow;

		// Token: 0x0400151B RID: 5403
		private ImageRow _emptyRow;
	}
}
