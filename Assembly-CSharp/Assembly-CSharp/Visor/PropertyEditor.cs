using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using DG.Tweening;
using DG.Tweening.Timeline;
using Rewired;
using TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x0200029D RID: 669
	public class PropertyEditor : MonoBehaviour, IKnobHandler
	{
		// Token: 0x06001A4C RID: 6732 RVA: 0x00085370 File Offset: 0x00083570
		private void Awake()
		{

		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00085384 File Offset: 0x00083584
		public void Setup(ComponentHandler targetComponent)
		{

		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x00085599 File Offset: 0x00083799
		public void SliderOnValueChange(float value)
		{

		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x000855D4 File Offset: 0x000837D4
		public void OnKnobChangeValue(Knob knob, float value)
		{

		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x000856B1 File Offset: 0x000838B1
		private void HandleSelection(string text)
		{

		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x000856CE File Offset: 0x000838CE
		private void Start()
		{

		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x000856DC File Offset: 0x000838DC
		private IEnumerator CheckInput()
		{

            return default;
        }

		// Token: 0x06001A53 RID: 6739 RVA: 0x000856EC File Offset: 0x000838EC
		public bool AreCommandsAccepted(TMP_InputField fieldToSkip)
		{

            return default;
        }

		// Token: 0x06001A54 RID: 6740 RVA: 0x0008573C File Offset: 0x0008393C
		private void Populate()
		{

		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x00085798 File Offset: 0x00083998
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x000858AC File Offset: 0x00083AAC
		public void PreOpen()
		{

		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x00085903 File Offset: 0x00083B03
		public void PostOpen()
		{

		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00085920 File Offset: 0x00083B20
		public Sequence GetOpenSequence()
		{

            return default;
        }

		// Token: 0x06001A59 RID: 6745 RVA: 0x0008594C File Offset: 0x00083B4C
		public void PreClose()
		{

		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x000859A0 File Offset: 0x00083BA0
		public Sequence GetCloseSequence()
		{

            return default;
        }

		// Token: 0x06001A5B RID: 6747 RVA: 0x000859CA File Offset: 0x00083BCA
		public void Close()
		{

		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x000859DB File Offset: 0x00083BDB
		public void CloseAndOpenImporter()
		{

		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x000859EC File Offset: 0x00083BEC
		public void CloseAndOpenDeviceEditor()
		{

		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x000859FD File Offset: 0x00083BFD
		public void CloseAndOpenSaveDevice()
		{

		}

		// Token: 0x0400155A RID: 5466
		public GameObject deviceSettingsButton;

		// Token: 0x0400155B RID: 5467
		public GameObject saveDeviceButton;

		// Token: 0x0400155C RID: 5468
		public GameObject volumePanel;

		// Token: 0x0400155D RID: 5469
		public Image icon;

		// Token: 0x0400155E RID: 5470
		public Knob massKnob;

		// Token: 0x0400155F RID: 5471
		public Knob frictionKnob;

		// Token: 0x04001560 RID: 5472
		public Knob bounceKnob;

		// Token: 0x04001561 RID: 5473
		public BetterSlider volumeSlider;

		// Token: 0x04001562 RID: 5474
		public UIImageColorMapper volumeNormalMapper;

		// Token: 0x04001563 RID: 5475
		public UIImageColorMapper volumeDisabledMapper;

		// Token: 0x04001564 RID: 5476
		public TextMeshProUGUI massValue;

		// Token: 0x04001565 RID: 5477
		public TextMeshProUGUI frictionValue;

		// Token: 0x04001566 RID: 5478
		public TextMeshProUGUI bounceValue;

		// Token: 0x04001567 RID: 5479
		public TMP_InputField nameField;

		// Token: 0x04001568 RID: 5480
		public PropertyList propertyList;

		// Token: 0x04001569 RID: 5481
		public DOVisualSequence openSequence;

		// Token: 0x0400156A RID: 5482
		public DOVisualSequence closeSequence;

		// Token: 0x0400156B RID: 5483
		private Player _input;

		// Token: 0x0400156C RID: 5484
		private IEnumerator _coroutine;

		// Token: 0x0400156D RID: 5485
		private string _oldComponentName;

		// Token: 0x0400156E RID: 5486
		private ComponentHandler _targetComponent;
	}
}
