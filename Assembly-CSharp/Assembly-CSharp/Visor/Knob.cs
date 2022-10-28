using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x02000299 RID: 665
	public class Knob : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x06001A1D RID: 6685
		[DllImport("user32.dll")]
		private static extern bool SetCursorPos(int X, int Y);

		// Token: 0x06001A1E RID: 6686 RVA: 0x00083FE4 File Offset: 0x000821E4
		public void Setup(IKnobHandler handler, float value, FloatRange range, float interval)
		{

		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x00084058 File Offset: 0x00082258
		public void OnDrag(PointerEventData eventData)
		{

		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x000840CC File Offset: 0x000822CC
		public void OnBeginDrag(PointerEventData eventData)
		{

		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00084180 File Offset: 0x00082380
		public void OnEndDrag(PointerEventData eventData)
		{

		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x000841FC File Offset: 0x000823FC
		public void OnPointerEnter(PointerEventData eventData)
		{

		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00084221 File Offset: 0x00082421
		public void OnPointerExit(PointerEventData eventData)
		{

		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x0008423C File Offset: 0x0008243C
		private float GetValue()
		{

            return default;
        }

		// Token: 0x04001534 RID: 5428
		public Image handle;

		// Token: 0x04001535 RID: 5429
		public Transform blocker;

		// Token: 0x04001536 RID: 5430
		public float sensitivity;

		// Token: 0x04001537 RID: 5431
		private IKnobHandler _handler;

		// Token: 0x04001538 RID: 5432
		private FloatRange _range;

		// Token: 0x04001539 RID: 5433
		private float _interval;

		// Token: 0x0400153A RID: 5434
		private Vector2 _startMousePosition;

		// Token: 0x0400153B RID: 5435
		private float _currentAngle;

		// Token: 0x0400153C RID: 5436
		private Transform _oldParent;

		// Token: 0x0400153D RID: 5437
		private UIColorMapperController _mapper;

		// Token: 0x0400153E RID: 5438
		private bool _held;

		// Token: 0x0400153F RID: 5439
		private const float _maxAngle = -270f;
	}
}
