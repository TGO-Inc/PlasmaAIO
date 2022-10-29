using PlasmaAPI.GameClass.Behavior;
﻿using System;
using DigitalRuby.FastLineRenderer;
using UnityEngine;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x0200025D RID: 605
	public class DraggedWire : MonoBehaviour
	{
		// Token: 0x06001697 RID: 5783 RVA: 0x00071560 File Offset: 0x0006F760
		public void Setup(SketchViewNodePort startingPort, Transform area, FastLineRenderer template)
		{

		}

		// Token: 0x06001698 RID: 5784 RVA: 0x0007164C File Offset: 0x0006F84C
		public void UpdateLine(Vector2 end)
		{

		}

		// Token: 0x06001699 RID: 5785 RVA: 0x0007170C File Offset: 0x0006F90C
		public void SnapToPort(SketchViewNodePort port)
		{

		}

		// Token: 0x0600169A RID: 5786 RVA: 0x00071764 File Offset: 0x0006F964
		public void Unsnap()
		{

		}

		// Token: 0x04001256 RID: 4694
		public Transform connector;

		// Token: 0x04001257 RID: 4695
		public GameObject tip;

		// Token: 0x04001258 RID: 4696
		private FastLineRenderer _lineRenderer;

		// Token: 0x04001259 RID: 4697
		private FastLineRendererProperties _props;

		// Token: 0x0400125A RID: 4698
		private SketchViewNodePort _startingPort;

		// Token: 0x0400125B RID: 4699
		private Transform _area;

		// Token: 0x0400125C RID: 4700
		private const float _lineRadius = 0.18f;
	}
}
