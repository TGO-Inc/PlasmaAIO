using PlasmaAPI.GameClass.Behavior;
﻿using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000243 RID: 579
	public class AdvancedHudProperty : MonoBehaviour
	{
		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x0006AEFB File Offset: 0x000690FB
		// (set) Token: 0x0600151D RID: 5405 RVA: 0x0006AF03 File Offset: 0x00069103
		public ComponentHandler componentHandler { get; set; }

		// Token: 0x0600151E RID: 5406 RVA: 0x0006AF0C File Offset: 0x0006910C
		private void Awake()
		{

		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0006AFA4 File Offset: 0x000691A4
		private char OnValidateInput(string text, int charIndex, char addedChar)
		{

            return default;
        }

		// Token: 0x06001520 RID: 5408 RVA: 0x0006AFD4 File Offset: 0x000691D4
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x06001521 RID: 5409 RVA: 0x0006B006 File Offset: 0x00069206
		private void HandleEndEdit(string text)
		{

		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0006B014 File Offset: 0x00069214
		private void ApplyFunction()
		{

		}

		// Token: 0x06001523 RID: 5411 RVA: 0x0006B418 File Offset: 0x00069618
		public void SetValue(float value, bool notify = true)
		{

		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0006B466 File Offset: 0x00069666
		public void SetFormatPercentage(bool value)
		{

		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0006B4A4 File Offset: 0x000696A4
		public void SetPosition(float position)
		{

		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0006B4D2 File Offset: 0x000696D2
		public void CleanUp()
		{

		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0006B4EB File Offset: 0x000696EB
		public void SetReadyState()
		{

		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0006B518 File Offset: 0x00069718
		private void HandleOnComponentTransformUpdate(ComponentHandler componenthandler)
		{

		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0006B5EF File Offset: 0x000697EF
		public void CleanUpEdit()
		{

		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0006B602 File Offset: 0x00069802
		public void SetNormalState()
		{

		}

		// Token: 0x0600152B RID: 5419 RVA: 0x0006B627 File Offset: 0x00069827
		public void SetHighlightedState()
		{

		}

		// Token: 0x0600152C RID: 5420 RVA: 0x0006B64C File Offset: 0x0006984C
		public void StartEditing()
		{

		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0006B67C File Offset: 0x0006987C
		public void StopEditing(bool submit)
		{

		}

		// Token: 0x04001129 RID: 4393
		public TextMeshProUGUI label;

		// Token: 0x0400112A RID: 4394
		public string format;

		// Token: 0x0400112B RID: 4395
		public AdvancedHudProperty.Functions function;

		// Token: 0x0400112C RID: 4396
		public TextMeshProUGUI suffix;

		// Token: 0x0400112D RID: 4397
		private TMP_InputField _inputField;

		// Token: 0x0400112E RID: 4398
		private UIColorMapperController _mapperController;

		// Token: 0x0400112F RID: 4399
		private RectTransform _rectTransform;

		// Token: 0x04001130 RID: 4400
		private float _originalWidth;

		// Token: 0x0200045A RID: 1114
		public enum Functions
		{
			// Token: 0x04001F26 RID: 7974
			Roll,
			// Token: 0x04001F27 RID: 7975
			Pitch,
			// Token: 0x04001F28 RID: 7976
			Yaw,
			// Token: 0x04001F29 RID: 7977
			Offset,
			// Token: 0x04001F2A RID: 7978
			ScaleOne,
			// Token: 0x04001F2B RID: 7979
			ScaleTwo,
			// Token: 0x04001F2C RID: 7980
			ScaleThree
		}
	}
}
