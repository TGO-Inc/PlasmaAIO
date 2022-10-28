using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x02000249 RID: 585
	public class AssetItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x06001566 RID: 5478 RVA: 0x0006D19C File Offset: 0x0006B39C
		public void Setup(UserAssetsController.AssetDescription assetDescription, bool preloadTexture)
		{

		}

		// Token: 0x06001567 RID: 5479 RVA: 0x0006D282 File Offset: 0x0006B482
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0006D2B4 File Offset: 0x0006B4B4
		private void HandleEndEdit(string text)
		{

		}

		// Token: 0x06001569 RID: 5481 RVA: 0x0006D320 File Offset: 0x0006B520
		private void HandleSelection(string text)
		{

		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0006D32E File Offset: 0x0006B52E
		public void ShowDeleteDialogBox()
		{

		}

		// Token: 0x0600156B RID: 5483 RVA: 0x0006D344 File Offset: 0x0006B544
		private void Update()
		{

		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0006D3D8 File Offset: 0x0006B5D8
		public void OnPointerEnter(PointerEventData data)
		{

		}

		// Token: 0x0600156D RID: 5485 RVA: 0x0006D482 File Offset: 0x0006B682
		public void OnPointerExit(PointerEventData data)
		{

		}

		// Token: 0x0600156E RID: 5486 RVA: 0x0006D49E File Offset: 0x0006B69E
		private void Unhighlight()
		{

		}

		// Token: 0x04001171 RID: 4465
		public TMP_InputField title;

		// Token: 0x04001172 RID: 4466
		public RawImage image;

		// Token: 0x04001173 RID: 4467
		public UIImageColorMapper borderNormalMapper;

		// Token: 0x04001174 RID: 4468
		public UIImageColorMapper borderHighlightedMapper;

		// Token: 0x04001175 RID: 4469
		public GameObject trashButton;

		// Token: 0x04001176 RID: 4470
		private UserAssetsController.AssetDescription _assetDescription;

		// Token: 0x04001177 RID: 4471
		private Rect _viewportRect;

		// Token: 0x04001178 RID: 4472
		private RectTransform _rectTransform;

		// Token: 0x04001179 RID: 4473
		private bool _visible;

		// Token: 0x0400117A RID: 4474
		private ImageManager _manager;

		// Token: 0x0400117B RID: 4475
		private bool _mouseInside;

		// Token: 0x0400117C RID: 4476
		private bool _renamed;
	}
}
