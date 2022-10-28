using System;
using UnityEngine;

namespace TubeRendererExamples
{
	// Token: 0x020001C3 RID: 451
	public class Herd : MonoBehaviour
	{
		// Token: 0x06001042 RID: 4162 RVA: 0x00056CA4 File Offset: 0x00054EA4
		private void Start()
		{

		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00056D20 File Offset: 0x00054F20
		private void Update()
		{

		}

		// Token: 0x04000E58 RID: 3672
		private const int CRITTER_COUNT = 10;

		// Token: 0x04000E59 RID: 3673
		private const int POINT_COUNT = 50;

		// Token: 0x04000E5A RID: 3674
		private const float POINT_SPACING = 0.05f;

		// Token: 0x04000E5B RID: 3675
		private const float DISPERSION = 0.3f;

		// Token: 0x04000E5C RID: 3676
		private Herd.Critter[] _critters;

		// Token: 0x020003D7 RID: 983
		private class Critter
		{
			// Token: 0x0600211B RID: 8475 RVA: 0x000A2A8C File Offset: 0x000A0C8C
			public Critter()
			{

			}

			// Token: 0x0600211C RID: 8476 RVA: 0x000A2B58 File Offset: 0x000A0D58
			public void Update()
			{

			}

			// Token: 0x0600211D RID: 8477 RVA: 0x000A2C1C File Offset: 0x000A0E1C
			private Vector3 SmoothRandom(float t)
			{

                return default;
            }

			// Token: 0x04001D92 RID: 7570
			public TubeRenderer tube;
		}
	}
}
