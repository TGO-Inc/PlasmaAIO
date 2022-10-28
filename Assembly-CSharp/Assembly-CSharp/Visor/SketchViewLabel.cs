using PlasmaAPI.GameClass.Behavior;
﻿using System;
using GifPlayer;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000282 RID: 642
	public class SketchViewLabel : SerializedMonoBehaviour, ISketchViewInteractable
	{
		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x0007D7C6 File Offset: 0x0007B9C6
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x0007D7CE File Offset: 0x0007B9CE
		public SketchView sketchView { get; private set; }

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x0007D7D7 File Offset: 0x0007B9D7
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x0007D7DF File Offset: 0x0007B9DF
		public SketchViewAreaTrigger mainSketchViewTrigger { get; private set; }

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x0007D7E8 File Offset: 0x0007B9E8
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x0007D7F5 File Offset: 0x0007B9F5
		public string title
		{
			get
			{
				return this.titleLabel.text;
			}
			set
			{
				this.titleLabel.text = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x0007D803 File Offset: 0x0007BA03
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x0007D810 File Offset: 0x0007BA10
		public string comment
		{
			get
			{
				return this.commentLabel.text;
			}
			set
			{
				this.commentLabel.text = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x0007D81E File Offset: 0x0007BA1E
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x0007D828 File Offset: 0x0007BA28
		public int demoImageAsset
		{
			get
			{
				return this._demoImageAsset;
			}
			set
			{
				this._demoImageAsset = value;
				if (this._demoImageAsset > 0 && this._demoImageAsset <= Holder.instance.demoImageAssets.Count)
				{
					GifData gifData = new GifData(Holder.instance.demoImageAssets[this._demoImageAsset].bytes);
					GifHelper.GetFramesVoid(gifData);
					this.GIFPlayer.Frames = gifData.Frames;
					Vector2 size = this.GIFPlayer.Frames[0].Sprite.rect.size;
					this.imageSprite.transform.localScale = new Vector2(size.y / 40f, size.y / 40f);
					this.Resize(Mathf.FloorToInt(size.x / 40f * 2f), Mathf.FloorToInt(size.y / 40f * 2f) + 3);
					this.GIFPlayer.Play();
					this.imageSprite.enabled = true;
					this.commentLabel.enabled = false;
					return;
				}
				this.imageSprite.enabled = false;
				this.commentLabel.enabled = true;
			}
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x0007D95D File Offset: 0x0007BB5D
		private void Awake()
		{

		}

		// Token: 0x0600190B RID: 6411 RVA: 0x0007D978 File Offset: 0x0007BB78
		public void Setup(SketchView theSketchView, ProcessorAgent.SketchMetaData.Label metaData)
		{

		}

		// Token: 0x0600190C RID: 6412 RVA: 0x0007DB17 File Offset: 0x0007BD17
		public void CleanUp()
		{

		}

		// Token: 0x0600190D RID: 6413 RVA: 0x0007DB38 File Offset: 0x0007BD38
		public ProcessorAgent.SketchMetaData.Label ComposeMetaData()
		{

            return default;
        }

		// Token: 0x0600190E RID: 6414 RVA: 0x0007DB9C File Offset: 0x0007BD9C
		public void Resize(int width, int height)
		{

		}

		// Token: 0x0600190F RID: 6415 RVA: 0x0007DE62 File Offset: 0x0007C062
		public void EditSettings()
		{

		}

		// Token: 0x06001910 RID: 6416 RVA: 0x0007DE75 File Offset: 0x0007C075
		public void UnhighlightCornerButton()
		{

		}

		// Token: 0x06001911 RID: 6417 RVA: 0x0007DE82 File Offset: 0x0007C082
		public void HighlightHeader()
		{

		}

		// Token: 0x06001912 RID: 6418 RVA: 0x0007DEA1 File Offset: 0x0007C0A1
		public void UnhighlightHeader()
		{

		}

		// Token: 0x06001913 RID: 6419 RVA: 0x0007DEC8 File Offset: 0x0007C0C8
		public void SetSortingLayer(string layer)
		{

		}

		// Token: 0x06001914 RID: 6420 RVA: 0x0007DF16 File Offset: 0x0007C116
		public void Close()
		{

		}

		// Token: 0x06001915 RID: 6421 RVA: 0x0007DF24 File Offset: 0x0007C124
		public void OnMousePointerEnter(SketchViewInteractables triggerId)
		{
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x0007DF26 File Offset: 0x0007C126
		public void OnMousePointerExit(SketchViewInteractables triggerId)
		{

		}

		// Token: 0x06001917 RID: 6423 RVA: 0x0007DF51 File Offset: 0x0007C151
		public void OnTopmostTrigger(SketchViewInteractables id)
		{

		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0007DF7C File Offset: 0x0007C17C
		public void OnBackgroundTrigger(SketchViewInteractables id)
		{

		}

		// Token: 0x06001919 RID: 6425 RVA: 0x0007DFEC File Offset: 0x0007C1EC
		public void OnMouseLeftButtonDown(SketchViewInteractables id)
		{
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x0007DFEE File Offset: 0x0007C1EE
		public void OnMouseLeftButtonUp(SketchViewInteractables id)
		{
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x0007DFF0 File Offset: 0x0007C1F0
		public void OnMouseRightButtonDown(SketchViewInteractables id)
		{
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x0007DFF2 File Offset: 0x0007C1F2
		public void OnMouseRightButtonUp(SketchViewInteractables id)
		{
		}

		// Token: 0x0400142F RID: 5167
		public SpriteRenderer leftBorderSprite;

		// Token: 0x04001430 RID: 5168
		public SpriteRenderer rightBorderSprite;

		// Token: 0x04001431 RID: 5169
		public SpriteRenderer backgroundSprite;

		// Token: 0x04001432 RID: 5170
		public SpriteRenderer headerSprite;

		// Token: 0x04001433 RID: 5171
		public SpriteRenderer footerSprite;

		// Token: 0x04001434 RID: 5172
		public TextMeshPro titleLabel;

		// Token: 0x04001435 RID: 5173
		public TextMeshPro commentLabel;

		// Token: 0x04001436 RID: 5174
		public SpriteRenderer imageSprite;

		// Token: 0x04001437 RID: 5175
		public SketchViewButton closeButton;

		// Token: 0x04001438 RID: 5176
		public SketchViewButton settingsButton;

		// Token: 0x04001439 RID: 5177
		public SketchViewButton cornerButton;

		// Token: 0x0400143A RID: 5178
		public SpriteColorMapper headerColor;

		// Token: 0x0400143B RID: 5179
		public GIFPlayer GIFPlayer;

		// Token: 0x0400143C RID: 5180
		public int defaultWidth;

		// Token: 0x0400143D RID: 5181
		public int defaultHeight;

		// Token: 0x0400143E RID: 5182
		public int minWidth;

		// Token: 0x0400143F RID: 5183
		public int minHeight;

		// Token: 0x04001440 RID: 5184
		private SketchViewTriggerContainer _triggerContainer;

		// Token: 0x04001441 RID: 5185
		private Vector2 _finalSize;

		// Token: 0x04001442 RID: 5186
		private int _headerColor;

		// Token: 0x04001443 RID: 5187
		private int _id;

		// Token: 0x04001444 RID: 5188
		private int _demoImageAsset;

		// Token: 0x04001445 RID: 5189
		private const int _priorityBase = -70000;
	}
}
