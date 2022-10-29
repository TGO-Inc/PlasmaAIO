using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Behavior;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DigitalRuby.FastLineRenderer;
using Rewired;
using UnityEngine;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using Data = PlasmaAPI.GameClass.Behavior.Data;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x0200027E RID: 638
	public class SketchViewConnection : MonoBehaviour, ISketchViewInteractable
	{
		// Token: 0x17000303 RID: 771
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x0007C2DD File Offset: 0x0007A4DD
		public SketchView sketchView
		{
			get
			{
				return this._sketchView;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x060018BF RID: 6335 RVA: 0x0007C2E5 File Offset: 0x0007A4E5
		// (set) Token: 0x060018C0 RID: 6336 RVA: 0x0007C2ED File Offset: 0x0007A4ED
		public SketchConnection connection { get; private set; }

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x060018C1 RID: 6337 RVA: 0x0007C2F6 File Offset: 0x0007A4F6
		public SketchViewNode inputNode
		{
			get
			{
				return this._sketchViewNodeInputPort.sketchViewNode;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x0007C303 File Offset: 0x0007A503
		public SketchViewNode outputNode
		{
			get
			{
				return this._outputSketchViewNode;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x060018C3 RID: 6339 RVA: 0x0007C30B File Offset: 0x0007A50B
		// (set) Token: 0x060018C4 RID: 6340 RVA: 0x0007C313 File Offset: 0x0007A513
		public int colorIndex { get; private set; }

		// Token: 0x060018C5 RID: 6341 RVA: 0x0007C31C File Offset: 0x0007A51C
		private void Awake()
		{

		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x0007C330 File Offset: 0x0007A530
		public void Setup(SketchConnection theConnection, SketchViewNodePort sketchViewNodeOutputPort, SketchViewNodePort sketchViewNodeInputPort, Transform area, FastLineRenderer template, SketchConnection.MetaData metaData)
		{

		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x0007C6E8 File Offset: 0x0007A8E8
		private void HandleProcessorUIOnClose()
		{

		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x0007C704 File Offset: 0x0007A904
		public void CleanUp(bool nodeIsBeingDestroyed)
		{

		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x0007C79C File Offset: 0x0007A99C
		public void ComposeMetaData()
		{

		}

		// Token: 0x060018CA RID: 6346 RVA: 0x0007C894 File Offset: 0x0007AA94
		public void UpdateSegments(bool updateTrigger)
		{

		}

		// Token: 0x060018CB RID: 6347 RVA: 0x0007CB20 File Offset: 0x0007AD20
		private SketchViewConnection.Segment CreateSegment(bool alsoPin)
		{

            return default;
        }

		// Token: 0x060018CC RID: 6348 RVA: 0x0007CBEC File Offset: 0x0007ADEC
		private SketchViewConnectionPin SplitSegment(int index, Vector3 position)
		{

            return default;
        }

		// Token: 0x060018CD RID: 6349 RVA: 0x0007CC28 File Offset: 0x0007AE28
		public void RemoveSegment(SketchViewConnectionPin pin)
		{

		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0007CCCC File Offset: 0x0007AECC
		public IEnumerable<SketchViewConnectionPin> GetPins()
		{

            return default;
        }

		// Token: 0x060018CF RID: 6351 RVA: 0x0007CD3C File Offset: 0x0007AF3C
		public void SetPins(IEnumerable<SketchViewConnectionPin> pins)
		{

		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0007CDB4 File Offset: 0x0007AFB4
		private void Update()
		{

		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x0007CF6B File Offset: 0x0007B16B
		public void StartMovePin(SketchViewConnectionPin pin)
		{

		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0007CFA8 File Offset: 0x0007B1A8
		public void MovePin(Vector3 position)
		{

		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0007CFCD File Offset: 0x0007B1CD
		public void EndMovePin()
		{

		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0007CFEE File Offset: 0x0007B1EE
		public void UpdateVisuals()
		{

		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0007D023 File Offset: 0x0007B223
		private Color GetLineColor()
		{

            return default;
        }

		// Token: 0x060018D6 RID: 6358 RVA: 0x0007D04F File Offset: 0x0007B24F
		private Color GetConnectorColor()
		{

            return default;
        }

		// Token: 0x060018D7 RID: 6359 RVA: 0x0007D07C File Offset: 0x0007B27C
		public void FadeOut()
		{

		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x0007D180 File Offset: 0x0007B380
		public void FadeIn()
		{

		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0007D270 File Offset: 0x0007B470
		private void Highlight()
		{

		}

		// Token: 0x060018DA RID: 6362 RVA: 0x0007D344 File Offset: 0x0007B544
		private void Unhighlight()
		{

		}

		// Token: 0x060018DB RID: 6363 RVA: 0x0007D410 File Offset: 0x0007B610
		public void OnMousePointerEnter(SketchViewInteractables triggerId)
		{
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x0007D412 File Offset: 0x0007B612
		public void OnMousePointerExit(SketchViewInteractables triggerId)
		{

		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0007D428 File Offset: 0x0007B628
		public void OnTopmostTrigger(SketchViewInteractables triggerId)
		{

		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0007D449 File Offset: 0x0007B649
		public void OnBackgroundTrigger(SketchViewInteractables triggerId)
		{

		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0007D45F File Offset: 0x0007B65F
		public void OnMouseLeftButtonDown(SketchViewInteractables id)
		{
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x0007D461 File Offset: 0x0007B661
		public void OnMouseLeftButtonUp(SketchViewInteractables id)
		{
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x0007D463 File Offset: 0x0007B663
		public void OnMouseRightButtonDown(SketchViewInteractables triggerId)
		{
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x0007D465 File Offset: 0x0007B665
		public void OnMouseRightButtonUp(SketchViewInteractables id)
		{

		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0007D4A1 File Offset: 0x0007B6A1
		private void OnDestroy()
		{

		}

		// Token: 0x040013FF RID: 5119
		public Transform connector;

		// Token: 0x04001400 RID: 5120
		public Transform end;

		// Token: 0x04001401 RID: 5121
		public Transform segments;

		// Token: 0x04001402 RID: 5122
		public GameObject pinPrefab;

		// Token: 0x04001403 RID: 5123
		public GameObject segmentPrefab;

		// Token: 0x04001404 RID: 5124
		private FastLineRenderer _lineRenderer;

		// Token: 0x04001405 RID: 5125
		private FastLineRendererProperties _props;

		// Token: 0x04001406 RID: 5126
		private SketchView _sketchView;

		// Token: 0x04001407 RID: 5127
		private SketchViewNodePort _sketchViewNodeOutputPort;

		// Token: 0x04001408 RID: 5128
		private SketchViewNodePort _sketchViewNodeInputPort;

		// Token: 0x04001409 RID: 5129
		private SketchViewNode _outputSketchViewNode;

		// Token: 0x0400140A RID: 5130
		private SpriteRenderer _connectorRenderer;

		// Token: 0x0400140B RID: 5131
		private SpriteRenderer _endRenderer;

		// Token: 0x0400140C RID: 5132
		private SketchViewTriggerContainer _triggerContainer;

		// Token: 0x0400140D RID: 5133
		private Transform _area;

		// Token: 0x0400140E RID: 5134
		private Player _input;

		// Token: 0x0400140F RID: 5135
		private List<Vector3> _points;

		// Token: 0x04001410 RID: 5136
		private List<SketchViewConnection.Segment> _segments;

		// Token: 0x04001411 RID: 5137
		private Color _inputColor;

		// Token: 0x04001412 RID: 5138
		private Color _outputColor;

		// Token: 0x04001413 RID: 5139
		private Color _lineColor;

		// Token: 0x04001414 RID: 5140
		private float _transitionDuration;

		// Token: 0x04001415 RID: 5141
		private Sequence _fadingSequence;

		// Token: 0x04001416 RID: 5142
		private int _layerOrder;

		// Token: 0x04001417 RID: 5143
		private int _connectionIndex;

		// Token: 0x04001418 RID: 5144
		private bool _highlighted;

		// Token: 0x04001419 RID: 5145
		private SketchViewConnectionPin _operatingPin;

		// Token: 0x0400141A RID: 5146
		private bool _movingPin;

		// Token: 0x0400141B RID: 5147
		private const float _lineRadius = 0.2f;

		// Token: 0x0400141C RID: 5148
		private const int _topPriority = 512;

		// Token: 0x0400141D RID: 5149
		private static int _currentColorIndex;

		// Token: 0x02000489 RID: 1161
		private class Segment
		{
			// Token: 0x04001FE6 RID: 8166
			public SketchViewLineTrigger trigger;

			// Token: 0x04001FE7 RID: 8167
			public SketchViewConnectionPin pin;

			// Token: 0x04001FE8 RID: 8168
			public Vector3 worldStart;

			// Token: 0x04001FE9 RID: 8169
			public Vector3 worldEnd;

			// Token: 0x04001FEA RID: 8170
			public Vector3 localStart;

			// Token: 0x04001FEB RID: 8171
			public Vector3 localEnd;
		}
	}
}
