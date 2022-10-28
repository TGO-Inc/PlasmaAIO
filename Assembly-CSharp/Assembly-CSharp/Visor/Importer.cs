using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using System.IO;
using PlasmaAPI.GameClass.TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x0200024C RID: 588
	public class Importer : MonoBehaviour, IGenericWindow
	{
		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x0006D906 File Offset: 0x0006BB06
		public string title
		{
			get
			{
				return "IMPORTER";
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x0006D90D File Offset: 0x0006BB0D
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(2440f, 1400f);
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x0006D91E File Offset: 0x0006BB1E
		// (set) Token: 0x06001597 RID: 5527 RVA: 0x0006D926 File Offset: 0x0006BB26
		public bool canClose { get; private set; }

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x0006D92F File Offset: 0x0006BB2F
		// (set) Token: 0x06001599 RID: 5529 RVA: 0x0006D937 File Offset: 0x0006BB37
		public object payload { get; private set; }

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x0006D940 File Offset: 0x0006BB40
		// (set) Token: 0x0600159B RID: 5531 RVA: 0x0006D948 File Offset: 0x0006BB48
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x0006D951 File Offset: 0x0006BB51
		// (set) Token: 0x0600159D RID: 5533 RVA: 0x0006D959 File Offset: 0x0006BB59
		public object closeEventPayload { get; private set; }

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x0006D962 File Offset: 0x0006BB62
		// (set) Token: 0x0600159F RID: 5535 RVA: 0x0006D96A File Offset: 0x0006BB6A
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x0006D973 File Offset: 0x0006BB73
		public string exitKey
		{
			get
			{
				return "GW_Exit";
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x0006D97A File Offset: 0x0006BB7A
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x0006D97D File Offset: 0x0006BB7D
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x0006D980 File Offset: 0x0006BB80
		public void Setup(object setupData)
		{

		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0006DA04 File Offset: 0x0006BC04
		public void OnReveal()
		{

		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0006DA8B File Offset: 0x0006BC8B
		public void OnFinishReveal()
		{
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x0006DA8D File Offset: 0x0006BC8D
		public void OnConceal()
		{
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x0006DA90 File Offset: 0x0006BC90
		public void SelectFileItem(AssetFileItem fileItem)
		{

		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x0006DB27 File Offset: 0x0006BD27
		public void OpenFolder()
		{

		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x0006DB3D File Offset: 0x0006BD3D
		public void Import()
		{

		}

		// Token: 0x060015AA RID: 5546 RVA: 0x0006DB45 File Offset: 0x0006BD45
		public void Close(bool returnValue)
		{

		}

		// Token: 0x060015AB RID: 5547 RVA: 0x0006DB65 File Offset: 0x0006BD65
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x060015AC RID: 5548 RVA: 0x0006DB82 File Offset: 0x0006BD82
		private void HandleEndEdit(string text)
		{

		}

		// Token: 0x060015AD RID: 5549 RVA: 0x0006DBAC File Offset: 0x0006BDAC
		private void Populate()
		{

		}

		// Token: 0x060015AE RID: 5550 RVA: 0x0006DC6C File Offset: 0x0006BE6C
		private void ShowSelectedImage()
		{

		}

		// Token: 0x060015AF RID: 5551 RVA: 0x0006DE84 File Offset: 0x0006C084
		private void SetupTexture(Texture2D texture, Importer.TextureOperations operation)
		{

		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x0006DFC0 File Offset: 0x0006C1C0
		private void ScaleToFitHorizontally(Texture2D loadedTexture)
		{

		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x0006E024 File Offset: 0x0006C224
		private void ScaleToFitVertically(Texture2D loadedTexture)
		{

		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x0006E087 File Offset: 0x0006C287
		public void RotateClockwise()
		{

		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x0006E0A0 File Offset: 0x0006C2A0
		public void RotateAntiClockwise()
		{

		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x0006E0B9 File Offset: 0x0006C2B9
		public void SetZoom(float zoomLevel)
		{

		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x0006E0C4 File Offset: 0x0006C2C4
		private void ImportImage()
		{

		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x0006E2B4 File Offset: 0x0006C4B4
		private void UpdateImageScale()
		{

		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0006E304 File Offset: 0x0006C504
		private void OnApplicationFocus(bool hasFocus)
		{

		}

		// Token: 0x0400118C RID: 4492
		public TMP_InputField renameField;

		// Token: 0x0400118D RID: 4493
		public GameObject noFilesMessage;

		// Token: 0x0400118E RID: 4494
		public GameObject pleaseMessage;

		// Token: 0x0400118F RID: 4495
		public TextMeshProUGUI imageErrorMessage;

		// Token: 0x04001190 RID: 4496
		public TextMeshProUGUI imageInfoMessage;

		// Token: 0x04001191 RID: 4497
		public Transform content;

		// Token: 0x04001192 RID: 4498
		public GameObject imageScrollRect;

		// Token: 0x04001193 RID: 4499
		public RawImage textureImage;

		// Token: 0x04001194 RID: 4500
		public BetterSlider zoomSlider;

		// Token: 0x04001195 RID: 4501
		public BetterButton rotateClockwise;

		// Token: 0x04001196 RID: 4502
		public BetterButton rotateAntiClockwise;

		// Token: 0x04001197 RID: 4503
		public BetterButton importButton;

		// Token: 0x04001198 RID: 4504
		public GameObject imagePanel;

		// Token: 0x04001199 RID: 4505
		public RectTransform raycastBlocker;

		// Token: 0x0400119A RID: 4506
		public GameObject fileItemPrefab;

		// Token: 0x0400119B RID: 4507
		public int assetNameLimit;

		// Token: 0x0400119C RID: 4508
		private Visor _visor;

		// Token: 0x0400119D RID: 4509
		private AssetFileItem _selectedFileItem;

		// Token: 0x0400119E RID: 4510
		private RectTransform _textureImageRect;

		// Token: 0x0400119F RID: 4511
		private float _minWidthRatio;

		// Token: 0x040011A0 RID: 4512
		private float _minHeightRatio;

		// Token: 0x040011A1 RID: 4513
		private bool _useWidthRatioForZoom;

		// Token: 0x02000460 RID: 1120
		private enum TextureOperations
		{
			// Token: 0x04001F41 RID: 8001
			None,
			// Token: 0x04001F42 RID: 8002
			RotateClockwise,
			// Token: 0x04001F43 RID: 8003
			RotateAntiClockwise
		}
	}
}
