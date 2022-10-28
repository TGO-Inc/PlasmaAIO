using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DG.Tweening.Timeline;
using DG.Tweening.Timeline.Core;
using FMODUnity;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000241 RID: 577
	public class GenericPopup : MonoBehaviour
	{
		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x0006A7B4 File Offset: 0x000689B4
		public Visor.Events closeEvent
		{
			get
			{
				return this._client.closeEvent;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x0006A7C1 File Offset: 0x000689C1
		public object closeEventPayload
		{
			get
			{
				return this._client.closeEventPayload;
			}
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0006A7CE File Offset: 0x000689CE
		private void Awake()
		{

		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0006A7FC File Offset: 0x000689FC
		public void Setup(GameObject contentPrefab, object setupData, bool useDarkerBackground)
		{

		}

		// Token: 0x060014FB RID: 5371 RVA: 0x0006A9D8 File Offset: 0x00068BD8
		public void Obscure()
		{

		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0006A9FB File Offset: 0x00068BFB
		public Tween Unobscure()
		{

            return default;
        }

		// Token: 0x060014FD RID: 5373 RVA: 0x0006AA33 File Offset: 0x00068C33
		private IEnumerator CheckInput()
		{

            return default;
        }

		// Token: 0x060014FE RID: 5374 RVA: 0x0006AA42 File Offset: 0x00068C42
		public void PostOpen()
		{

		}

		// Token: 0x060014FF RID: 5375 RVA: 0x0006AA5D File Offset: 0x00068C5D
		public void PreClose()
		{

		}

		// Token: 0x06001500 RID: 5376 RVA: 0x0006AA6B File Offset: 0x00068C6B
		public void RevealContent()
		{

		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0006AA78 File Offset: 0x00068C78
		public Sequence GetOpenSequence()
		{

            return default;
        }

		// Token: 0x06001502 RID: 5378 RVA: 0x0006AA80 File Offset: 0x00068C80
		public Sequence GetCloseSequence()
		{

            return default;
        }

		// Token: 0x06001503 RID: 5379 RVA: 0x0006AAE1 File Offset: 0x00068CE1
		public void Close()
		{

		}

		// Token: 0x0400110E RID: 4366
		public RectTransform content;

		// Token: 0x0400110F RID: 4367
		public TextMeshProUGUI title;

		// Token: 0x04001110 RID: 4368
		public GameObject line;

		// Token: 0x04001111 RID: 4369
		public DOVisualSequence openSequence;

		// Token: 0x04001112 RID: 4370
		public DOVisualSequence closeSequence;

		// Token: 0x04001113 RID: 4371
		[EventRef]
		public string openSound;

		// Token: 0x04001114 RID: 4372
		[EventRef]
		public string closeSound;

		// Token: 0x04001115 RID: 4373
		private Player _input;

		// Token: 0x04001116 RID: 4374
		private CanvasGroup _canvasGroup;

		// Token: 0x04001117 RID: 4375
		private IEnumerator _coroutine;

		// Token: 0x04001118 RID: 4376
		private IGenericWindow _client;

		// Token: 0x04001119 RID: 4377
		private Vector2 _windowSize;

		// Token: 0x0400111A RID: 4378
		private UIColorMapperController _mapperController;

		// Token: 0x0400111B RID: 4379
		private Sequence _openSequence;
	}
}
