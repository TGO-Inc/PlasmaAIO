using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Behavior;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000285 RID: 645
	public class SketchViewNodePort : MonoBehaviour, ISketchViewInteractable
	{
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x000803FD File Offset: 0x0007E5FD
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x00080405 File Offset: 0x0007E605
		public SketchViewNode sketchViewNode { get; private set; }

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x0008040E File Offset: 0x0007E60E
		// (set) Token: 0x0600195D RID: 6493 RVA: 0x00080416 File Offset: 0x0007E616
		public SketchViewNodeRow sketchViewNodeRow { get; private set; }

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x0008041F File Offset: 0x0007E61F
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x00080427 File Offset: 0x0007E627
		public SketchNodePort port { get; private set; }

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x00080430 File Offset: 0x0007E630
		public IEnumerable<SketchViewConnection> sketchViewConnections
		{
			get
			{
				return this._sketchViewConnections;
			}
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00080438 File Offset: 0x0007E638
		private void Awake()
		{

		}

		// Token: 0x06001962 RID: 6498 RVA: 0x00080474 File Offset: 0x0007E674
		public void Setup(SketchViewNode theSketchViewNode, SketchViewNodeRow theSketchViewNodeRow, SketchNodePort thePort, bool setupTrigger)
		{

		}

		// Token: 0x06001963 RID: 6499 RVA: 0x000804CF File Offset: 0x0007E6CF
		public void AddConnection(SketchViewConnection connection)
		{

		}

		// Token: 0x06001964 RID: 6500 RVA: 0x000804DD File Offset: 0x0007E6DD
		public void RemoveConnection(SketchViewConnection connection, bool nodeIsBeingDestroyed)
		{

		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00080504 File Offset: 0x0007E704
		public void HideConnector()
		{

		}

		// Token: 0x06001966 RID: 6502 RVA: 0x0008057D File Offset: 0x0007E77D
		public bool ShouldSnap(Vector3 position)
		{

            return default;
        }

		// Token: 0x06001967 RID: 6503 RVA: 0x000805BC File Offset: 0x0007E7BC
		public bool ShouldUnsnap(Vector3 position)
		{

            return default;
        }

		// Token: 0x06001968 RID: 6504 RVA: 0x00080631 File Offset: 0x0007E831
		public void ResetSize()
		{

		}

		// Token: 0x06001969 RID: 6505 RVA: 0x0008066E File Offset: 0x0007E86E
		public void Extend()
		{

		}

		// Token: 0x0600196A RID: 6506 RVA: 0x000806AB File Offset: 0x0007E8AB
		public void Retract()
		{

		}

		// Token: 0x0600196B RID: 6507 RVA: 0x000806E8 File Offset: 0x0007E8E8
		public void ResetToProperState()
		{

		}

		// Token: 0x0600196C RID: 6508 RVA: 0x00080724 File Offset: 0x0007E924
		public void EnableTrigger()
		{

		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00080748 File Offset: 0x0007E948
		public void OnMousePointerEnter(SketchViewInteractables triggerId)
		{

		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00080888 File Offset: 0x0007EA88
		public void OnMousePointerExit(SketchViewInteractables triggerId)
		{

		}

		// Token: 0x0600196F RID: 6511 RVA: 0x000809E2 File Offset: 0x0007EBE2
		public void OnTopmostTrigger(SketchViewInteractables id)
		{
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x000809E4 File Offset: 0x0007EBE4
		public void OnBackgroundTrigger(SketchViewInteractables id)
		{
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x000809E6 File Offset: 0x0007EBE6
		public void OnMouseLeftButtonDown(SketchViewInteractables id)
		{
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x000809E8 File Offset: 0x0007EBE8
		public void OnMouseLeftButtonUp(SketchViewInteractables id)
		{
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x000809EA File Offset: 0x0007EBEA
		public void OnMouseRightButtonDown(SketchViewInteractables id)
		{
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x000809EC File Offset: 0x0007EBEC
		public void OnMouseRightButtonUp(SketchViewInteractables id)
		{
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x000809EE File Offset: 0x0007EBEE
		private void OnDestroy()
		{

		}

		// Token: 0x04001487 RID: 5255
		public float normalWidth;

		// Token: 0x04001488 RID: 5256
		public float extendedWidth;

		// Token: 0x04001489 RID: 5257
		public float retractedWidth;

		// Token: 0x0400148A RID: 5258
		public Transform connector;

		// Token: 0x0400148B RID: 5259
		private SpriteRenderer _renderer;

		// Token: 0x0400148C RID: 5260
		private SketchViewAreaTrigger _sketchViewTrigger;

		// Token: 0x0400148D RID: 5261
		private List<SketchViewConnection> _sketchViewConnections;

		// Token: 0x0400148E RID: 5262
		private float _transitionDuration;

		// Token: 0x0400148F RID: 5263
		private Sequence _sequence;
	}
}
