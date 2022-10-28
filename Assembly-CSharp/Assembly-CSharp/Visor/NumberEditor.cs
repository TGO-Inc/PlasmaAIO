using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Behavior;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x0200029C RID: 668
	public class NumberEditor : DataEditor
	{
		// Token: 0x06001A2E RID: 6702 RVA: 0x00084364 File Offset: 0x00082564
		public override void Setup(Agent agent, int propertyId, ProcessorUI processorUI = null, bool canClose = true)
		{

		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x0008444C File Offset: 0x0008264C
		public override void CleanUp()
		{

		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x000845C0 File Offset: 0x000827C0
		private void SetupLayout()
		{

		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x00084918 File Offset: 0x00082B18
		private void HandleChange(string text)
		{

		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x00084924 File Offset: 0x00082B24
		private void SetTimeEditors(float time, bool notify)
		{

		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0008499C File Offset: 0x00082B9C
		private void SetupInputFieldAndSlider()
		{

		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00084BF4 File Offset: 0x00082DF4
		public void OnSetDecorator(NumberDecoratorButton button)
		{

		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x00084C64 File Offset: 0x00082E64
		private void Update()
		{

		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00084D24 File Offset: 0x00082F24
		private void SetHours(bool setData)
		{

		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00084D9C File Offset: 0x00082F9C
		private void HandleSubmitHours(string text)
		{

		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00084E03 File Offset: 0x00083003
		private void HandleSelectionHours(string text)
		{

		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x00084E0C File Offset: 0x0008300C
		private void HandleEndEditHours(string text)
		{

		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x00084E44 File Offset: 0x00083044
		private void SetMinutes(bool setData)
		{

		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x00084EBC File Offset: 0x000830BC
		private void HandleSubmitMinutes(string text)
		{

		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x00084F23 File Offset: 0x00083123
		private void HandleSelectionMinutes(string text)
		{

		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x00084F2C File Offset: 0x0008312C
		private void HandleEndEditMinutes(string text)
		{

		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x00084F64 File Offset: 0x00083164
		private void SetSeconds(bool setData)
		{

		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x00084FE8 File Offset: 0x000831E8
		private void HandleSubmitSeconds(string text)
		{

		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0008504F File Offset: 0x0008324F
		private void HandleSelectionSeconds(string text)
		{

		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x00085058 File Offset: 0x00083258
		private void HandleEndEditSeconds(string text)
		{

		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0008508E File Offset: 0x0008328E
		private static char OnValidateInputSeconds(string text, int charIndex, char addedChar)
		{

            return default;
        }

		// Token: 0x06001A43 RID: 6723 RVA: 0x000850BC File Offset: 0x000832BC
		private void SetGenericNumber()
		{

		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x000851AC File Offset: 0x000833AC
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00085212 File Offset: 0x00083412
		private void HandleSelection(string text)
		{

		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0008521B File Offset: 0x0008341B
		private void HandleEndEdit(string text)
		{

		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0008524C File Offset: 0x0008344C
		private static char OnValidateInput(string text, int charIndex, char addedChar)
		{

            return default;
        }

		// Token: 0x06001A48 RID: 6728 RVA: 0x0008527C File Offset: 0x0008347C
		private void SliderOnValueChange(float value)
		{

		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00085327 File Offset: 0x00083527
		private float CalculateTime()
		{

            return default;
        }

		// Token: 0x06001A4A RID: 6730 RVA: 0x00085347 File Offset: 0x00083547
		private void SetTimeData()
		{

		}

		// Token: 0x04001546 RID: 5446
		public Dictionary<Data.NumberDecorators, NumberDecoratorButton> decoratorButtons;

		// Token: 0x04001547 RID: 5447
		public GameObject normalInputField;

		// Token: 0x04001548 RID: 5448
		public GameObject percentInputField;

		// Token: 0x04001549 RID: 5449
		public GameObject timeEditor;

		// Token: 0x0400154A RID: 5450
		public TMP_InputField hoursInputField;

		// Token: 0x0400154B RID: 5451
		public TMP_InputField minutesInputField;

		// Token: 0x0400154C RID: 5452
		public TMP_InputField secondsInputField;

		// Token: 0x0400154D RID: 5453
		public Slider slider;

		// Token: 0x0400154E RID: 5454
		public TextMeshProUGUI extraInfo;

		// Token: 0x0400154F RID: 5455
		private TMP_InputField _inputField;

		// Token: 0x04001550 RID: 5456
		private string _undoValue;

		// Token: 0x04001551 RID: 5457
		private string _hoursUndoValue;

		// Token: 0x04001552 RID: 5458
		private string _minutesUndoValue;

		// Token: 0x04001553 RID: 5459
		private string _secondsUndoValue;

		// Token: 0x04001554 RID: 5460
		private int _hours;

		// Token: 0x04001555 RID: 5461
		private int _minutes;

		// Token: 0x04001556 RID: 5462
		private float _seconds;

		// Token: 0x04001557 RID: 5463
		private bool _wasSubmitted;

		// Token: 0x04001558 RID: 5464
		private NumberDecoratorButton _currentDecorator;

		// Token: 0x04001559 RID: 5465
		private Data _temporaryData;
	}
}
