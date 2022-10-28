using System;
using UnityEngine;
using UnityEngine.Events;

namespace Visor
{
	// Token: 0x0200027D RID: 637
	public class SketchViewButton : MonoBehaviour, ISketchViewInteractable
	{
		// Token: 0x17000302 RID: 770
		// (get) Token: 0x060018AD RID: 6317 RVA: 0x0007C152 File Offset: 0x0007A352
		// (set) Token: 0x060018AE RID: 6318 RVA: 0x0007C15A File Offset: 0x0007A35A
		public SketchViewAreaTrigger sketchViewTrigger { get; private set; }

		// Token: 0x060018AF RID: 6319 RVA: 0x0007C164 File Offset: 0x0007A364
		private void Awake()
		{

		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0007C1C2 File Offset: 0x0007A3C2
		public void Setup(SketchView sketchView)
		{

		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0007C1D0 File Offset: 0x0007A3D0
		public void Show()
		{

		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0007C1EB File Offset: 0x0007A3EB
		public void Hide()
		{

		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x0007C205 File Offset: 0x0007A405
		public void ShowAlternate()
		{

		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0007C235 File Offset: 0x0007A435
		public void ShowNormal()
		{

		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0007C265 File Offset: 0x0007A465
		public void OnMousePointerEnter(SketchViewInteractables triggerId)
		{

		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0007C280 File Offset: 0x0007A480
		public void OnMousePointerExit(SketchViewInteractables triggerId)
		{

		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x0007C29C File Offset: 0x0007A49C
		public void OnTopmostTrigger(SketchViewInteractables id)
		{
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0007C29E File Offset: 0x0007A49E
		public void OnBackgroundTrigger(SketchViewInteractables id)
		{
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x0007C2A0 File Offset: 0x0007A4A0
		public void OnMouseLeftButtonDown(SketchViewInteractables id)
		{

		}

		// Token: 0x060018BA RID: 6330 RVA: 0x0007C2BE File Offset: 0x0007A4BE
		public void OnMouseLeftButtonUp(SketchViewInteractables id)
		{

		}

		// Token: 0x060018BB RID: 6331 RVA: 0x0007C2D1 File Offset: 0x0007A4D1
		public void OnMouseRightButtonDown(SketchViewInteractables id)
		{
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x0007C2D3 File Offset: 0x0007A4D3
		public void OnMouseRightButtonUp(SketchViewInteractables id)
		{
		}

		// Token: 0x040013F7 RID: 5111
		public Sprite alternateIcon;

		// Token: 0x040013F8 RID: 5112
		public UnityEvent action;

		// Token: 0x040013F9 RID: 5113
		private UIColorMapperController _mapperController;

		// Token: 0x040013FA RID: 5114
		private Sprite _icon;

		// Token: 0x040013FB RID: 5115
		private SpriteRenderer _iconRenderer;

		// Token: 0x040013FC RID: 5116
		private bool _hidden;

		// Token: 0x040013FD RID: 5117
		private string _normal;
	}
}
