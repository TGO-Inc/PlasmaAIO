using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using TMPro;
using UnityEngine;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000286 RID: 646
	public class SketchViewNodeRow : MonoBehaviour, ISketchViewInteractable
	{
		// Token: 0x1700031A RID: 794
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x00080ADA File Offset: 0x0007ECDA
		public float textWidth
		{
			get
			{
				return this.label.preferredWidth;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x00080AE7 File Offset: 0x0007ECE7
		public AgentProperty property
		{
			get
			{
				return this._property;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x00080AEF File Offset: 0x0007ECEF
		public SketchViewNodePort sketchViewNodePort
		{
			get
			{
				return this._sketchViewNodePort;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06001981 RID: 6529 RVA: 0x00080AF7 File Offset: 0x0007ECF7
		public int mappedPropertyId
		{
			get
			{
				if (this._property != null)
				{
					return this._property.id;
				}
				return 0;
			}
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00080B10 File Offset: 0x0007ED10
		private void Awake()
		{

		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00080B8C File Offset: 0x0007ED8C
		public void Setup(SketchViewNode sketchViewNode, SketchNodePort thePort, Holder.SketchColorTheme colorTheme)
		{

		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00080DC4 File Offset: 0x0007EFC4
		public void CleanUp()
		{

		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00080E48 File Offset: 0x0007F048
		public void SetWidth(int width)
		{

		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00080F48 File Offset: 0x0007F148
		public void SetAlternate(bool alternate)
		{

		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00080FC0 File Offset: 0x0007F1C0
		private void BuildTypePreview()
		{

		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00081068 File Offset: 0x0007F268
		public void BuildPreview(bool cleanUpTriggers = true)
		{

		}

		// Token: 0x06001989 RID: 6537 RVA: 0x0008131C File Offset: 0x0007F51C
		public void BuildTypeButton(bool cleanUpTriggers)
		{

		}

		// Token: 0x0600198A RID: 6538 RVA: 0x000814A9 File Offset: 0x0007F6A9
		private void HandlePropertyChanges(AgentProperty theProperty)
		{

		}

		// Token: 0x0600198B RID: 6539 RVA: 0x000814B4 File Offset: 0x0007F6B4
		private void HandleVariableUsageChanges(SketchNode sketchNode, int propertyId)
		{

		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00081558 File Offset: 0x0007F758
		private void HandleVariableChanges(SketchNode sketchNode, int propertyId)
		{

		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00081578 File Offset: 0x0007F778
		public void SetAsWarning(bool state)
		{

		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00081588 File Offset: 0x0007F788
		private void ApplyProperColor()
		{

		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00081660 File Offset: 0x0007F860
		public void OnMousePointerEnter(SketchViewInteractables triggerId)
		{

		}

		// Token: 0x06001990 RID: 6544 RVA: 0x000818A4 File Offset: 0x0007FAA4
		public void OnMousePointerExit(SketchViewInteractables triggerId)
		{

		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00081965 File Offset: 0x0007FB65
		public void OnTopmostTrigger(SketchViewInteractables id)
		{
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00081967 File Offset: 0x0007FB67
		public void OnBackgroundTrigger(SketchViewInteractables id)
		{
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x0008196C File Offset: 0x0007FB6C
		public void OnMouseLeftButtonDown(SketchViewInteractables id)
		{

		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00081B18 File Offset: 0x0007FD18
		public void OnMouseLeftButtonUp(SketchViewInteractables id)
		{

		}

		// Token: 0x06001995 RID: 6549 RVA: 0x00081B72 File Offset: 0x0007FD72
		public void OnMouseRightButtonDown(SketchViewInteractables id)
		{
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00081B74 File Offset: 0x0007FD74
		public void OnMouseRightButtonUp(SketchViewInteractables id)
		{
		}

		// Token: 0x04001493 RID: 5267
		public TextMeshPro label;

		// Token: 0x04001494 RID: 5268
		public GameObject preview;

		// Token: 0x04001495 RID: 5269
		public GameObject typePreview;

		// Token: 0x04001496 RID: 5270
		public SpriteRenderer previewValueBackground;

		// Token: 0x04001497 RID: 5271
		public SpriteRenderer previewTypeBackground;

		// Token: 0x04001498 RID: 5272
		public SpriteColorMapper normalColorMapper;

		// Token: 0x04001499 RID: 5273
		public SpriteColorMapper highlightedColorMapper;

		// Token: 0x0400149A RID: 5274
		public SpriteColorMapper typeHighlightedColorMapper;

		// Token: 0x0400149B RID: 5275
		public SpriteColorMapper previewValueColorMapper;

		// Token: 0x0400149C RID: 5276
		public GameObject nonePreview;

		// Token: 0x0400149D RID: 5277
		public GameObject booleanPreview;

		// Token: 0x0400149E RID: 5278
		public GameObject colorPreview;

		// Token: 0x0400149F RID: 5279
		public GameObject textPreview;

		// Token: 0x040014A0 RID: 5280
		public GameObject port;

		// Token: 0x040014A1 RID: 5281
		public bool onRightSide;

		// Token: 0x040014A2 RID: 5282
		private SpriteRenderer _spriteRenderer;

		// Token: 0x040014A3 RID: 5283
		private SketchViewNode _sketchViewNode;

		// Token: 0x040014A4 RID: 5284
		private SketchViewNodePort _sketchViewNodePort;

		// Token: 0x040014A5 RID: 5285
		private SketchViewAreaTrigger _sketchViewTrigger;

		// Token: 0x040014A6 RID: 5286
		private SketchViewAreaTrigger _previewValueBackgroundTrigger;

		// Token: 0x040014A7 RID: 5287
		private SketchViewAreaTrigger _previewTypeBackgroundTrigger;

		// Token: 0x040014A8 RID: 5288
		private UIColorMapperController _colorMapperController;

		// Token: 0x040014A9 RID: 5289
		private Holder.SketchColorTheme _colorTheme;

		// Token: 0x040014AA RID: 5290
		private SketchNodePort _port;

		// Token: 0x040014AB RID: 5291
		private Sketch _sketch;

		// Token: 0x040014AC RID: 5292
		private SketchNode _sketchNode;

		// Token: 0x040014AD RID: 5293
		private SpriteRenderer _typeIconRenderer;

		// Token: 0x040014AE RID: 5294
		private SpriteRenderer _typePreviewIconRenderer;

		// Token: 0x040014AF RID: 5295
		private AgentProperty _property;

		// Token: 0x040014B0 RID: 5296
		private bool _onlyShowType;

		// Token: 0x040014B1 RID: 5297
		private int _width;

		// Token: 0x040014B2 RID: 5298
		private int _tooltipIndex;

		// Token: 0x040014B3 RID: 5299
		private bool _asWarning;
	}
}
