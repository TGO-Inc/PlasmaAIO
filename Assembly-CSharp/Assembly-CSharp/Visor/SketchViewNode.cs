using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Behavior;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000284 RID: 644
	public class SketchViewNode : SerializedMonoBehaviour, ISketchViewInteractable
	{
		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x0007E359 File Offset: 0x0007C559
		public Agent agent
		{
			get
			{
				return this.sketchNode.agent;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x0007E366 File Offset: 0x0007C566
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x0007E36E File Offset: 0x0007C56E
		public SketchNode sketchNode { get; private set; }

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x0007E377 File Offset: 0x0007C577
		public SketchView sketchView
		{
			get
			{
				return this._sketchView;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x0007E37F File Offset: 0x0007C57F
		public IEnumerable<SketchViewNodePort> allPorts
		{
			get
			{
				return this._sketchViewNodePorts;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0007E387 File Offset: 0x0007C587
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x0007E38F File Offset: 0x0007C58F
		public SketchViewAreaTrigger mainSketchViewTrigger { get; private set; }

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x0007E398 File Offset: 0x0007C598
		public Bounds bounds
		{
			get
			{
				return new Bounds
				{
					size = new Vector3(this._finalSize.x + 2f, this._finalSize.y),
					center = new Vector3(base.transform.localPosition.x + this._finalSize.x / 2f, base.transform.localPosition.y - this._finalSize.y / 2f)
				};
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x0007E426 File Offset: 0x0007C626
		public Vector2 size
		{
			get
			{
				return this._finalSize;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x0007E42E File Offset: 0x0007C62E
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x0007E436 File Offset: 0x0007C636
		public int id { get; private set; }

		// Token: 0x06001930 RID: 6448 RVA: 0x0007E43F File Offset: 0x0007C63F
		private void Awake()
		{

		}

		// Token: 0x06001931 RID: 6449 RVA: 0x0007E45C File Offset: 0x0007C65C
		public void Setup(SketchNode theSketchNode, SketchView theSketchView, SketchNode.MetaData.Node metaData)
		{

		}

		// Token: 0x06001932 RID: 6450 RVA: 0x0007F638 File Offset: 0x0007D838
		private int SetupCommands(List<SketchNodePort> commandPorts, Transform commandsArea, int maxCommandAreaWidth)
		{

            return default;
        }

		// Token: 0x06001933 RID: 6451 RVA: 0x0007F708 File Offset: 0x0007D908
		private int SetupOutputs(List<SketchNodePort> outputPorts, Transform outputsArea, int maxOutputAreaWidth)
		{

            return default;
        }

		// Token: 0x06001934 RID: 6452 RVA: 0x0007F7EC File Offset: 0x0007D9EC
		private int SetupProperties(List<SketchNodePort> propertyPorts, Transform propertiesArea, int maxPropertyAreaWidth)
		{

            return default;
        }

		// Token: 0x06001935 RID: 6453 RVA: 0x0007F904 File Offset: 0x0007DB04
		private void CleanUp()
		{

		}

		// Token: 0x06001936 RID: 6454 RVA: 0x0007F98C File Offset: 0x0007DB8C
		public void RebuildRowTypeButtons()
		{

		}

		// Token: 0x06001937 RID: 6455 RVA: 0x0007F9E8 File Offset: 0x0007DBE8
		public void RebuildAllRowsPreviews()
		{

		}

		// Token: 0x06001938 RID: 6456 RVA: 0x0007FA44 File Offset: 0x0007DC44
		public void ComposeMetaData()
		{

		}

		// Token: 0x06001939 RID: 6457 RVA: 0x0007FAA8 File Offset: 0x0007DCA8
		public int GrabNextConnectionIndex()
		{

            return default;
        }

		// Token: 0x0600193A RID: 6458 RVA: 0x0007FADD File Offset: 0x0007DCDD
		public void ReleaseConnectionIndex(int index)
		{

		}

		// Token: 0x0600193B RID: 6459 RVA: 0x0007FAEC File Offset: 0x0007DCEC
		public SketchViewNodePort GetPortById(int portId)
		{

            return default;
        }

		// Token: 0x0600193C RID: 6460 RVA: 0x0007FB50 File Offset: 0x0007DD50
		public void HighlightHeader()
		{

		}

		// Token: 0x0600193D RID: 6461 RVA: 0x0007FB70 File Offset: 0x0007DD70
		public void UnhighlightHeader()
		{

		}

		// Token: 0x0600193E RID: 6462 RVA: 0x0007FBC0 File Offset: 0x0007DDC0
		public void ShowSafetyBuffer()
		{

		}

		// Token: 0x0600193F RID: 6463 RVA: 0x0007FD71 File Offset: 0x0007DF71
		public void HideSafetyBuffer()
		{

		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0007FD80 File Offset: 0x0007DF80
		private GameObject CreateSafetyBufferTile(bool alternate)
		{

            return default;
        }

		// Token: 0x06001941 RID: 6465 RVA: 0x0007FDF4 File Offset: 0x0007DFF4
		public void UpdateAllConnections(bool updateTriggers)
		{

		}

		// Token: 0x06001942 RID: 6466 RVA: 0x0007FE78 File Offset: 0x0007E078
		public void SetSortingLayer(string layer)
		{

		}

		// Token: 0x06001943 RID: 6467 RVA: 0x0007FEC8 File Offset: 0x0007E0C8
		public void PreparePortsForWiring(SketchViewNodePort excludedPort)
		{

		}

		// Token: 0x06001944 RID: 6468 RVA: 0x0007FF2C File Offset: 0x0007E12C
		public void ResetPortsToProperState()
		{

		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0007FF7C File Offset: 0x0007E17C
		private void HandleOnNotification(SketchNotifications.Notification notification)
		{

		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0007FFBC File Offset: 0x0007E1BC
		private void SetupValidationFailedState()
		{

		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00080028 File Offset: 0x0007E228
		private void ClearValidationFailedState()
		{

		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0008006F File Offset: 0x0007E26F
		private void TurnOnWarningIcon()
		{

		}

		// Token: 0x06001949 RID: 6473 RVA: 0x0008009A File Offset: 0x0007E29A
		private void TurnOffWarningIcon()
		{

		}

		// Token: 0x0600194A RID: 6474 RVA: 0x000800BC File Offset: 0x0007E2BC
		private void SlideTitle(bool left, float duration)
		{

		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00080104 File Offset: 0x0007E304
		public void UpdateMultiIcon()
		{

		}

		// Token: 0x0600194C RID: 6476 RVA: 0x0008015C File Offset: 0x0007E35C
		public void Close()
		{

		}

		// Token: 0x0600194D RID: 6477 RVA: 0x0008016A File Offset: 0x0007E36A
		public void ShowEncyclopedia()
		{

		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00080178 File Offset: 0x0007E378
		public SketchViewNodePort GetPort(int portId)
		{

            return default;
        }

		// Token: 0x0600194F RID: 6479 RVA: 0x000801DC File Offset: 0x0007E3DC
		private void OnDestroy()
		{

		}

		// Token: 0x06001950 RID: 6480 RVA: 0x000801E4 File Offset: 0x0007E3E4
		public void OnMousePointerEnter(SketchViewInteractables triggerId)
		{

		}

		// Token: 0x06001951 RID: 6481 RVA: 0x00080330 File Offset: 0x0007E530
		public void OnMousePointerExit(SketchViewInteractables triggerId)
		{

		}

		// Token: 0x06001952 RID: 6482 RVA: 0x000803BB File Offset: 0x0007E5BB
		public void OnTopmostTrigger(SketchViewInteractables triggerId)
		{

		}

		// Token: 0x06001953 RID: 6483 RVA: 0x000803D3 File Offset: 0x0007E5D3
		public void OnBackgroundTrigger(SketchViewInteractables triggerId)
		{
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x000803D5 File Offset: 0x0007E5D5
		public void OnMouseLeftButtonDown(SketchViewInteractables triggerId)
		{
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x000803D7 File Offset: 0x0007E5D7
		public void OnMouseLeftButtonUp(SketchViewInteractables triggerId)
		{
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x000803D9 File Offset: 0x0007E5D9
		public void OnMouseRightButtonDown(SketchViewInteractables triggerId)
		{
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x000803DB File Offset: 0x0007E5DB
		public void OnMouseRightButtonUp(SketchViewInteractables triggerId)
		{
		}

		// Token: 0x0400144F RID: 5199
		public GameObject leftRowTemplate;

		// Token: 0x04001450 RID: 5200
		public GameObject rightRowTemplate;

		// Token: 0x04001451 RID: 5201
		public GameObject diagonalStripeTemplate1;

		// Token: 0x04001452 RID: 5202
		public GameObject diagonalStripeTemplate2;

		// Token: 0x04001453 RID: 5203
		public SpriteRenderer horizontalSeparatorSprite;

		// Token: 0x04001454 RID: 5204
		public SpriteRenderer separatorIntersectionSprite;

		// Token: 0x04001455 RID: 5205
		public SpriteRenderer verticalSeparatorSprite;

		// Token: 0x04001456 RID: 5206
		public SpriteRenderer backgroundSprite;

		// Token: 0x04001457 RID: 5207
		public SpriteRenderer headerSprite;

		// Token: 0x04001458 RID: 5208
		public SpriteRenderer footerSprite;

		// Token: 0x04001459 RID: 5209
		public SpriteRenderer interfaceSeparatorSprite;

		// Token: 0x0400145A RID: 5210
		public SpriteRenderer interfaceHorizontalSeparatorSprite;

		// Token: 0x0400145B RID: 5211
		public SpriteRenderer interfaceSeparatorIntersectionSprite;

		// Token: 0x0400145C RID: 5212
		public SpriteRenderer interfaceVerticalSeparatorSprite;

		// Token: 0x0400145D RID: 5213
		public SpriteRenderer fakeInterfaceSeparatorSprite;

		// Token: 0x0400145E RID: 5214
		public GameObject interfaceArea;

		// Token: 0x0400145F RID: 5215
		public GameObject fakeInterfaceArea;

		// Token: 0x04001460 RID: 5216
		public RectTransform fakeInterfaceMessage;

		// Token: 0x04001461 RID: 5217
		public TextMeshPro title;

		// Token: 0x04001462 RID: 5218
		public SketchViewButton closeButton;

		// Token: 0x04001463 RID: 5219
		public SketchViewButton infoButton;

		// Token: 0x04001464 RID: 5220
		public GameObject warningIcon;

		// Token: 0x04001465 RID: 5221
		public GameObject unmappedIcon;

		// Token: 0x04001466 RID: 5222
		public GameObject multiIcon;

		// Token: 0x04001467 RID: 5223
		public Transform commands;

		// Token: 0x04001468 RID: 5224
		public Transform outputs;

		// Token: 0x04001469 RID: 5225
		public Transform properties;

		// Token: 0x0400146A RID: 5226
		public Transform interfaceCommands;

		// Token: 0x0400146B RID: 5227
		public Transform interfaceOutputs;

		// Token: 0x0400146C RID: 5228
		public Transform interfaceProperties;

		// Token: 0x0400146D RID: 5229
		public Transform safetyBuffer;

		// Token: 0x0400146E RID: 5230
		public SpriteColorMapper backgroundColor;

		// Token: 0x0400146F RID: 5231
		public SpriteColorMapper headerColor;

		// Token: 0x04001470 RID: 5232
		public SpriteColorMapper footerColor;

		// Token: 0x04001471 RID: 5233
		public SpriteColorMapper horizontalSeparatorColor;

		// Token: 0x04001472 RID: 5234
		public SpriteColorMapper separatorIntersectionColor;

		// Token: 0x04001473 RID: 5235
		public SpriteColorMapper verticalSeparatorColor;

		// Token: 0x04001474 RID: 5236
		public SpriteColorMapper interfaceSeparatorColor;

		// Token: 0x04001475 RID: 5237
		public SpriteColorMapper interfaceHorizontalSeparatorColor;

		// Token: 0x04001476 RID: 5238
		public SpriteColorMapper interfaceSeparatorIntersectionColor;

		// Token: 0x04001477 RID: 5239
		public SpriteColorMapper interfaceVerticalSeparatorColor;

		// Token: 0x04001478 RID: 5240
		public SpriteColorMapper fakeInterfaceSeparatorColor;

		// Token: 0x04001479 RID: 5241
		private SketchView _sketchView;

		// Token: 0x0400147A RID: 5242
		private SketchViewTriggerContainer _triggerContainer;

		// Token: 0x0400147B RID: 5243
		private Vector2 _finalSize;

		// Token: 0x0400147C RID: 5244
		private Holder.SketchColorTheme _colorTheme;

		// Token: 0x0400147D RID: 5245
		private List<SketchViewNodePort> _sketchViewNodePorts;

		// Token: 0x0400147E RID: 5246
		private List<SketchViewNodeRow> _sketchViewNodeRows;

		// Token: 0x0400147F RID: 5247
		private bool[] _connectionPriorities;

		// Token: 0x04001480 RID: 5248
		private int _tooltipIndex;

		// Token: 0x04001481 RID: 5249
		private string _warningMessage;

		// Token: 0x04001482 RID: 5250
		private bool _wasMultiIconOn;

		// Token: 0x04001483 RID: 5251
		private static char[] _delimiters = new char[]
		{
			' ',
			'\r',
			'\n'
		};
	}
}
