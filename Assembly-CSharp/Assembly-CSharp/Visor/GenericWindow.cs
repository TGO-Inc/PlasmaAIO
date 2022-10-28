using System;
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

namespace Visor
{
	// Token: 0x02000242 RID: 578
	public class GenericWindow : MonoBehaviour
	{
		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x0006AB50 File Offset: 0x00068D50
		public Visor.Events closeEvent
		{
			get
			{
				return this._client.closeEvent;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x0006AB5D File Offset: 0x00068D5D
		public object closeEventPayload
		{
			get
			{
				return this._client.closeEventPayload;
			}
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0006AB6A File Offset: 0x00068D6A
		private void Awake()
		{

		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0006AB89 File Offset: 0x00068D89
		private void Start()
		{

		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0006AB98 File Offset: 0x00068D98
		public void Setup(GameObject contentPrefab, object setupData)
		{

		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0006AD3B File Offset: 0x00068F3B
		public void Obscure()
		{

		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0006AD5E File Offset: 0x00068F5E
		public Tween Unobscure()
		{

            return default;
        }

		// Token: 0x06001510 RID: 5392 RVA: 0x0006AD96 File Offset: 0x00068F96
		private IEnumerator CheckInput()
		{

            return default;
        }

		// Token: 0x06001511 RID: 5393 RVA: 0x0006ADA5 File Offset: 0x00068FA5
		public void PreOpen()
		{

		}

		// Token: 0x06001512 RID: 5394 RVA: 0x0006ADB4 File Offset: 0x00068FB4
		public void PostOpen()
		{

		}

		// Token: 0x06001513 RID: 5395 RVA: 0x0006AE1B File Offset: 0x0006901B
		public void PreClose()
		{

		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0006AE36 File Offset: 0x00069036
		public Sequence GetOpenSequence()
		{

            return default;
        }

		// Token: 0x06001515 RID: 5397 RVA: 0x0006AE40 File Offset: 0x00069040
		public Sequence GetCloseSequence()
		{

            return default;
        }

		// Token: 0x06001516 RID: 5398 RVA: 0x0006AEA1 File Offset: 0x000690A1
		public void Close()
		{

		}

		// Token: 0x0400111C RID: 4380
		public RectTransform content;

		// Token: 0x0400111D RID: 4381
		public TextMeshProUGUI title;

		// Token: 0x0400111E RID: 4382
		public DOVisualSequence openSequence;

		// Token: 0x0400111F RID: 4383
		public DOVisualSequence closeSequence;

		// Token: 0x04001120 RID: 4384
		public DOVisualSequence revealSequence;

		// Token: 0x04001121 RID: 4385
		[EventRef]
		public string openSound;

		// Token: 0x04001122 RID: 4386
		[EventRef]
		public string closeSound;

		// Token: 0x04001123 RID: 4387
		private Player _input;

		// Token: 0x04001124 RID: 4388
		private CanvasGroup _canvasGroup;

		// Token: 0x04001125 RID: 4389
		private IEnumerator _coroutine;

		// Token: 0x04001126 RID: 4390
		private IGenericWindow _client;

		// Token: 0x04001127 RID: 4391
		private Vector2 _windowSize;

		// Token: 0x04001128 RID: 4392
		private Sequence _openSequence;
	}
}
