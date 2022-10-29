using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using Data = PlasmaAPI.GameClass.Behavior.Data;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x020002A6 RID: 678
	public class TypeButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x06001AB6 RID: 6838 RVA: 0x00087272 File Offset: 0x00085472
		private void Awake()
		{

		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0008728A File Offset: 0x0008548A
		public void Select()
		{

		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0008729D File Offset: 0x0008549D
		public void Deselect()
		{

		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x000872B0 File Offset: 0x000854B0
		public void OnPointerEnter(PointerEventData data)
		{

		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x0008730C File Offset: 0x0008550C
		public void OnPointerExit(PointerEventData data)
		{

		}

		// Token: 0x040015BC RID: 5564
		public UIBetterButtonColorMapper normalMapper;

		// Token: 0x040015BD RID: 5565
		public UIBetterButtonColorMapper selectedMapper;

		// Token: 0x040015BE RID: 5566
		public Data.Types type;

		// Token: 0x040015BF RID: 5567
		public float finalPosition;

		// Token: 0x040015C0 RID: 5568
		private Tween _transition;

		// Token: 0x040015C1 RID: 5569
		private float _originalPosition;
	}
}
