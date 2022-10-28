using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x0200027F RID: 639
	public class SketchViewConnectionPin : MonoBehaviour, ISketchViewInteractable
	{
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x0007D51E File Offset: 0x0007B71E
		// (set) Token: 0x060018EA RID: 6378 RVA: 0x0007D526 File Offset: 0x0007B726
		public SketchViewConnection sketchViewConnection { get; private set; }

		// Token: 0x060018EB RID: 6379 RVA: 0x0007D52F File Offset: 0x0007B72F
		private void Awake()
		{

		}

		// Token: 0x060018EC RID: 6380 RVA: 0x0007D56C File Offset: 0x0007B76C
		public void Setup(SketchViewConnection theSketchViewConnection, int layerOrder)
		{

		}

		// Token: 0x060018ED RID: 6381 RVA: 0x0007D59F File Offset: 0x0007B79F
		public void CleanUp()
		{

		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0007D5AD File Offset: 0x0007B7AD
		public void Highlight()
		{

		}

		// Token: 0x060018EF RID: 6383 RVA: 0x0007D5CD File Offset: 0x0007B7CD
		public void Unhighlight()
		{

		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x0007D5F1 File Offset: 0x0007B7F1
		public void SetPriority(int priority)
		{

		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0007D60B File Offset: 0x0007B80B
		public void SetNormalPriority()
		{

		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0007D619 File Offset: 0x0007B819
		public void OnMousePointerEnter(SketchViewInteractables triggerId)
		{
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x0007D61B File Offset: 0x0007B81B
		public void OnMousePointerExit(SketchViewInteractables triggerId)
		{

		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x0007D631 File Offset: 0x0007B831
		public void OnTopmostTrigger(SketchViewInteractables id)
		{

		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0007D647 File Offset: 0x0007B847
		public void OnBackgroundTrigger(SketchViewInteractables id)
		{

		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x0007D65D File Offset: 0x0007B85D
		public void OnMouseLeftButtonDown(SketchViewInteractables id)
		{

		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0007D679 File Offset: 0x0007B879
		public void OnMouseLeftButtonUp(SketchViewInteractables id)
		{
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x0007D67B File Offset: 0x0007B87B
		public void OnMouseRightButtonDown(SketchViewInteractables id)
		{

		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x0007D697 File Offset: 0x0007B897
		public void OnMouseRightButtonUp(SketchViewInteractables id)
		{
		}

		// Token: 0x04001420 RID: 5152
		private SketchViewAreaTrigger _sketchViewTrigger;

		// Token: 0x04001421 RID: 5153
		private SpriteColorMapper _colorMapper;

		// Token: 0x04001422 RID: 5154
		private SpriteRenderer _renderer;

		// Token: 0x04001423 RID: 5155
		private SketchView _sketchView;

		// Token: 0x04001424 RID: 5156
		private int _originalColor;

		// Token: 0x04001425 RID: 5157
		private int _layerOrder;
	}
}
