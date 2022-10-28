using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI.Extensions;

namespace Visor
{
	// Token: 0x0200026E RID: 622
	public class ProcessorUIMinimap : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x0007637E File Offset: 0x0007457E
		public bool isShown
		{
			get
			{
				return base.gameObject.activeSelf;
			}
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x0007638C File Offset: 0x0007458C
		public void Setup()
		{

		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x000764A2 File Offset: 0x000746A2
		public void Show()
		{

		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x000764B0 File Offset: 0x000746B0
		public void Toggle()
		{

		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x000764E0 File Offset: 0x000746E0
		public void ResizeViewport(float sizeFactor)
		{

		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00076554 File Offset: 0x00074754
		public void RefreshContent()
		{

		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x0007681C File Offset: 0x00074A1C
		public void RefreshViewport()
		{

		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00076878 File Offset: 0x00074A78
		private Vector2 MoveViewport(Vector2 position)
		{

            return default;
        }

		// Token: 0x060017AB RID: 6059 RVA: 0x0007690C File Offset: 0x00074B0C
		private void DragViewport(PointerEventData eventData)
		{

		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00076986 File Offset: 0x00074B86
		public void OnPointerClick(PointerEventData eventData)
		{

		}

		// Token: 0x060017AD RID: 6061 RVA: 0x0007699A File Offset: 0x00074B9A
		public void OnDrag(PointerEventData eventData)
		{

		}

		// Token: 0x060017AE RID: 6062 RVA: 0x000769A3 File Offset: 0x00074BA3
		public void OnEndDrag(PointerEventData eventData)
		{

		}

		// Token: 0x0400133F RID: 4927
		public RectTransform content;

		// Token: 0x04001340 RID: 4928
		public RectTransform viewport;

		// Token: 0x04001341 RID: 4929
		public GameObject miniNodePrefab;

		// Token: 0x04001342 RID: 4930
		public UILineRenderer lineRendererPrefab;

		// Token: 0x04001343 RID: 4931
		private SketchView _sketchView;

		// Token: 0x04001344 RID: 4932
		private Vector2 _sizeRatio;

		// Token: 0x04001345 RID: 4933
		private Bounds _contentBounds;
	}
}
