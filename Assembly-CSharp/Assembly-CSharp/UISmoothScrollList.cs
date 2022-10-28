using System;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200001E RID: 30
public class UISmoothScrollList : MonoBehaviour, IScrollHandler, IEventSystemHandler
{
	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000088 RID: 136 RVA: 0x00004BC0 File Offset: 0x00002DC0
	// (set) Token: 0x06000089 RID: 137 RVA: 0x00004BC8 File Offset: 0x00002DC8
	public int numberOfItems { get; private set; }

	// Token: 0x0600008A RID: 138 RVA: 0x00004BD4 File Offset: 0x00002DD4
	public void Setup(ISmoothScrollListProvider provider)
	{

	}

	// Token: 0x0600008B RID: 139 RVA: 0x00004D24 File Offset: 0x00002F24
	private float CalculateContentPosition(int targetIndex)
	{

        return default;
    }

	// Token: 0x0600008C RID: 140 RVA: 0x00004D3C File Offset: 0x00002F3C
	private void DisplayItems(bool instant = false)
	{

	}

	// Token: 0x0600008D RID: 141 RVA: 0x00004DC8 File Offset: 0x00002FC8
	public void ShowItemAtPosition(int position)
	{

	}

	// Token: 0x0600008E RID: 142 RVA: 0x00004E21 File Offset: 0x00003021
	public void OnScroll(PointerEventData eventData)
	{

	}

	// Token: 0x0600008F RID: 143 RVA: 0x00004E42 File Offset: 0x00003042
	private void ScrollDown()
	{

	}

	// Token: 0x06000090 RID: 144 RVA: 0x00004E70 File Offset: 0x00003070
	private void ScrollUp()
	{

	}

	// Token: 0x040000AE RID: 174
	public RectTransform content;

	// Token: 0x040000AF RID: 175
	public UIScrollBar scrollBar;

	// Token: 0x040000B0 RID: 176
	public int visibleItems;

	// Token: 0x040000B1 RID: 177
	public float offsetY;

	// Token: 0x040000B2 RID: 178
	private ISmoothScrollListProvider _provider;

	// Token: 0x040000B3 RID: 179
	private int _topItemIndex;

	// Token: 0x040000B4 RID: 180
	private Rect _boundingRect;

	// Token: 0x040000B5 RID: 181
	private RectTransform _canvas;

	// Token: 0x040000B6 RID: 182
	private List<bool> _itemsStates;
}
