using System;
using DG.Tweening.Timeline;
using FMODUnity;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x020002A8 RID: 680
	public class QuickbarSlot : MonoBehaviour
	{
		// Token: 0x06001AC0 RID: 6848 RVA: 0x0008742C File Offset: 0x0008562C
		private void Awake()
		{

		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x000874A0 File Offset: 0x000856A0
		private void Update()
		{

		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x00087552 File Offset: 0x00085752
		public void Assign()
		{

		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x00087588 File Offset: 0x00085788
		public void UpdateIcon()
		{

		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x000875D5 File Offset: 0x000857D5
		private void OnDestroy()
		{

		}

		// Token: 0x040015C4 RID: 5572
		public int index;

		// Token: 0x040015C5 RID: 5573
		public TextMeshProUGUI number;

		// Token: 0x040015C6 RID: 5574
		public Image icon;

		// Token: 0x040015C7 RID: 5575
		public UIImageColorMapper assignmentPhilFishMapper;

		// Token: 0x040015C8 RID: 5576
		public UIImageColorMapper spawnPhilFishMapper;

		// Token: 0x040015C9 RID: 5577
		public DOVisualSequence philFishSequence;

		// Token: 0x040015CA RID: 5578
		[EventRef]
		public string spawnSound;

		// Token: 0x040015CB RID: 5579
		private Player _input;

		// Token: 0x040015CC RID: 5580
		private string _keyCode;
	}
}
