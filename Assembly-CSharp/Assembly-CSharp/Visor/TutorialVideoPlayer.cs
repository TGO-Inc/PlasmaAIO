using System;
using DG.Tweening;
using DG.Tweening.Timeline;
using Rewired;
using UnityEngine;
using UnityEngine.Video;

namespace Visor
{
	// Token: 0x02000259 RID: 601
	public class TutorialVideoPlayer : VisorElement
	{
		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x00070CD8 File Offset: 0x0006EED8
		// (set) Token: 0x0600166D RID: 5741 RVA: 0x00070CE0 File Offset: 0x0006EEE0
		public bool isShown { get; private set; }

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x00070CE9 File Offset: 0x0006EEE9
		// (set) Token: 0x0600166F RID: 5743 RVA: 0x00070CF1 File Offset: 0x0006EEF1
		public int clipIndex { get; set; }

		// Token: 0x06001670 RID: 5744 RVA: 0x00070CFC File Offset: 0x0006EEFC
		protected override void CustomSetup()
		{

		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00070DA9 File Offset: 0x0006EFA9
		private void OnPrepareCompleted(VideoPlayer source)
		{

		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00070DB6 File Offset: 0x0006EFB6
		public override void OnFinishEnabled()
		{

		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00070DEC File Offset: 0x0006EFEC
		public override void OnFinishDisabled()
		{

		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00070E24 File Offset: 0x0006F024
		public void ShowAndPlay()
		{

		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00070EB9 File Offset: 0x0006F0B9
		public void Close()
		{

		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00070EF0 File Offset: 0x0006F0F0
		private void Update()
		{

		}

		// Token: 0x06001677 RID: 5751 RVA: 0x0007109A File Offset: 0x0006F29A
		private void OnDestroy()
		{

		}

		// Token: 0x04001233 RID: 4659
		public VideoPlayer videoPlayer;

		// Token: 0x04001234 RID: 4660
		public RectTransform progressBar;

		// Token: 0x04001235 RID: 4661
		public DOVisualSequence showSequence;

		// Token: 0x04001236 RID: 4662
		public DOVisualSequence hideSequence;

		// Token: 0x04001237 RID: 4663
		private Player _input;

		// Token: 0x04001238 RID: 4664
		private float _progressBarWidth;

		// Token: 0x04001239 RID: 4665
		private Sequence _showSequence;

		// Token: 0x0400123A RID: 4666
		private Sequence _hideSequence;

		// Token: 0x0400123B RID: 4667
		private TutorialVideoPlayer.PlaybackStates _playbackState;

		// Token: 0x02000466 RID: 1126
		private enum PlaybackStates
		{
			// Token: 0x04001F63 RID: 8035
			Stopped,
			// Token: 0x04001F64 RID: 8036
			Playing,
			// Token: 0x04001F65 RID: 8037
			Paused
		}
	}
}
