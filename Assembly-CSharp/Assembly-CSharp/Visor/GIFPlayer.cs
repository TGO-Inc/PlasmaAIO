using System;
using System.Collections;
using GifPlayer;
using UnityEngine;

namespace Visor
{
	// Token: 0x0200025E RID: 606
	public class GIFPlayer : MonoBehaviour
	{
		// Token: 0x0600169C RID: 5788 RVA: 0x0007177A File Offset: 0x0006F97A
		private void Awake()
		{

		}

		// Token: 0x0600169D RID: 5789 RVA: 0x00071788 File Offset: 0x0006F988
		private IEnumerator PlayNextFrame()
		{

            return default;
        }

		// Token: 0x0600169E RID: 5790 RVA: 0x00071797 File Offset: 0x0006F997
		public void Play()
		{

		}

		// Token: 0x0600169F RID: 5791 RVA: 0x000717C5 File Offset: 0x0006F9C5
		public void Stop()
		{

		}

		// Token: 0x0400125D RID: 4701
		public SequenceFrame[] Frames;

		// Token: 0x0400125E RID: 4702
		public bool loop;

		// Token: 0x0400125F RID: 4703
		private SpriteRenderer _renderer;

		// Token: 0x04001260 RID: 4704
		private int _frameIndex;

		// Token: 0x04001261 RID: 4705
		private bool _shouldPlay;
	}
}
