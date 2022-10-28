using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Common.Extension;
using PlasmaAPI.GameClass.Common.Math;
using PlasmaAPI.GameClass.EasyFSM;
using FMOD.Studio;
using FMODUnity;
using Microsoft.Win32;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using ParadoxNotion;
using Rewired;
using Sirenix.Serialization;
using Tayx.Graphy;
using Tayx.Graphy.Utils;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using PlasmaAPI.GameClass.Visor;

namespace PlasmaAPI.GameClass {
// Token: 0x02000051 RID: 81
public class WorldController : Controller
{
	// Token: 0x060002C3 RID: 707 RVA: 0x00014C4C File Offset: 0x00012E4C
	private void SetupDeleteComponentFSM()
	{

	}

	// Token: 0x060002C4 RID: 708 RVA: 0x00014E50 File Offset: 0x00013050
	public void RequestDeleteComponent()
	{

	}

	// Token: 0x060002C5 RID: 709 RVA: 0x00014E5F File Offset: 0x0001305F
	public bool ShouldStartDeleteComponent()
	{

        return default;
    }

	// Token: 0x060002C6 RID: 710 RVA: 0x00014E99 File Offset: 0x00013099
	private bool ShouldCancelDeleteComponent()
	{

        return default;
    }

	// Token: 0x060002C7 RID: 711 RVA: 0x00014EAB File Offset: 0x000130AB
	private bool ShouldConfirmDeleteComponent()
	{

        return default;
    }

	// Token: 0x060002C8 RID: 712 RVA: 0x00014EB8 File Offset: 0x000130B8
	public void RequestQuickDeleteComponent()
	{

	}

	// Token: 0x060002C9 RID: 713 RVA: 0x00014EC0 File Offset: 0x000130C0
	private void PerformDelete()
	{

	}

	// Token: 0x060002CA RID: 714 RVA: 0x00014F60 File Offset: 0x00013160
	private void SetupEasyStateMachines()
	{

	}

	// Token: 0x060002CB RID: 715 RVA: 0x00014F92 File Offset: 0x00013192
	public void RunEasyFSM(EasyFSMEnum id)
	{

	}

	// Token: 0x060002CC RID: 716 RVA: 0x00014F9F File Offset: 0x0001319F
	private static bool IsEasyFSMDone(EasyFSMEnum id)
	{

        return default;
    }

	// Token: 0x060002CD RID: 717 RVA: 0x00014FAC File Offset: 0x000131AC
	private IEnumerator RunWaitForPlayerCancel(object parameters)
	{

        return default;
    }

	// Token: 0x060002CE RID: 718 RVA: 0x00014FC2 File Offset: 0x000131C2
	private IEnumerator RunCancelAction()
	{

        return default;
    }

	// Token: 0x060002CF RID: 719 RVA: 0x00014FD1 File Offset: 0x000131D1
	public IEnumerator RunFirstPersonMode()
	{

        return default;
    }

	// Token: 0x060002D0 RID: 720 RVA: 0x00014FE0 File Offset: 0x000131E0
	public void EnterFirstPersonMode()
	{

	}

	// Token: 0x060002D1 RID: 721 RVA: 0x00015016 File Offset: 0x00013216
	public void ExitFirstPersonMode()
	{
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x00015018 File Offset: 0x00013218
	public void EnterMountModifierMode()
	{

	}

	// Token: 0x060002D3 RID: 723 RVA: 0x0001502C File Offset: 0x0001322C
	public void ExitMountModifierMode()
	{

	}

	// Token: 0x060002D4 RID: 724 RVA: 0x00015039 File Offset: 0x00013239
	public void MountDevice()
	{

	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00015068 File Offset: 0x00013268
	public void UnmountDevice()
	{

	}

	// Token: 0x060002D6 RID: 726 RVA: 0x00015092 File Offset: 0x00013292
	private IEnumerator UnmountCoroutine()
	{

        return default;
    }

	// Token: 0x060002D7 RID: 727 RVA: 0x000150A1 File Offset: 0x000132A1
	public bool ShouldEnterMountModifierMode()
	{

        return default;
    }

	// Token: 0x060002D8 RID: 728 RVA: 0x000150C3 File Offset: 0x000132C3
	public bool ShouldExitMountModifierMode()
	{

        return default;
    }

	// Token: 0x060002D9 RID: 729 RVA: 0x000150D8 File Offset: 0x000132D8
	public bool ShouldMountDevice()
	{

        return default;
    }

	// Token: 0x060002DA RID: 730 RVA: 0x0001514C File Offset: 0x0001334C
	public bool ShouldDenyMountDevice()
	{

        return default;
    }

	// Token: 0x060002DB RID: 731 RVA: 0x000151C3 File Offset: 0x000133C3
	public void DenyMountDevice()
	{

	}

	// Token: 0x060002DC RID: 732 RVA: 0x000151D6 File Offset: 0x000133D6
	public bool ShouldUnmountDevice()
	{

        return default;
    }

	// Token: 0x060002DD RID: 733 RVA: 0x000151E8 File Offset: 0x000133E8
	public bool ShouldToggleSocketEditing()
	{

        return default;
    }

	// Token: 0x060002DE RID: 734 RVA: 0x00015217 File Offset: 0x00013417
	public void ToggleSocketEditing()
	{

	}

	// Token: 0x060002DF RID: 735 RVA: 0x00015240 File Offset: 0x00013440
	public bool ShouldPlaceNewSocket()
	{

        return default;
    }

	// Token: 0x060002E0 RID: 736 RVA: 0x00015280 File Offset: 0x00013480
	public void PlaceNewSocket()
	{

	}

	// Token: 0x060002E1 RID: 737 RVA: 0x0001531C File Offset: 0x0001351C
	public bool ShouldDeleteSocket()
	{

        return default;
    }

	// Token: 0x060002E2 RID: 738 RVA: 0x00015384 File Offset: 0x00013584
	public void DeleteSocket()
	{

	}

	// Token: 0x060002E3 RID: 739 RVA: 0x000153C1 File Offset: 0x000135C1
	public IEnumerator RunDockedMode()
	{

        return default;
    }

	// Token: 0x060002E4 RID: 740 RVA: 0x000153D0 File Offset: 0x000135D0
	public IEnumerator EnterDockedMode()
	{

        return default;
    }

	// Token: 0x060002E5 RID: 741 RVA: 0x000153DF File Offset: 0x000135DF
	public IEnumerator ExitDockedMode()
	{

        return default;
    }

	// Token: 0x060002E6 RID: 742 RVA: 0x000153F0 File Offset: 0x000135F0
	private void ExitDockedModeInstant()
	{

	}

	// Token: 0x060002E7 RID: 743 RVA: 0x00015496 File Offset: 0x00013696
	public void SetOperatingComponentWhenDocked()
	{

	}

	// Token: 0x060002E8 RID: 744 RVA: 0x000154A4 File Offset: 0x000136A4
	public bool ShouldEnterDockedMode()
	{

        return default;
    }

	// Token: 0x060002E9 RID: 745 RVA: 0x000154FD File Offset: 0x000136FD
	public bool ShouldExitDockedMode()
	{

        return default;
    }

	// Token: 0x060002EA RID: 746 RVA: 0x00015519 File Offset: 0x00013719
	public IEnumerator RunPhotoMode()
	{

        return default;
    }

	// Token: 0x060002EB RID: 747 RVA: 0x00015528 File Offset: 0x00013728
	private void HandlePhotoModeResponse(Visor.Visor.DialogBoxResponses response)
	{

	}

	// Token: 0x060002EC RID: 748 RVA: 0x00015554 File Offset: 0x00013754
	public void EnterPhotoMode()
	{

	}

	// Token: 0x060002ED RID: 749 RVA: 0x000155E7 File Offset: 0x000137E7
	public void ExitPhotoMode()
	{

	}

	// Token: 0x060002EE RID: 750 RVA: 0x000155F0 File Offset: 0x000137F0
	public void SetOperatingComponentWhenInPhotoMode()
	{

	}

	// Token: 0x060002EF RID: 751 RVA: 0x000155FE File Offset: 0x000137FE
	public bool ShouldEnterPhotoMode()
	{

        return default;
    }

	// Token: 0x060002F0 RID: 752 RVA: 0x00015610 File Offset: 0x00013810
	public bool ShouldExitPhotoMode()
	{

        return default;
    }

	// Token: 0x060002F1 RID: 753 RVA: 0x0001562C File Offset: 0x0001382C
	public void AttachComponent()
	{

	}

	// Token: 0x060002F2 RID: 754 RVA: 0x00015AEE File Offset: 0x00013CEE
	public void DenyAttachComponent()
	{

	}

	// Token: 0x060002F3 RID: 755 RVA: 0x00015B04 File Offset: 0x00013D04
	public bool ShouldAttachComponent()
	{

        return default;
    }

	// Token: 0x060002F4 RID: 756 RVA: 0x00015B90 File Offset: 0x00013D90
	public bool ShouldDenyAttachComponent()
	{

        return default;
    }

	// Token: 0x060002F5 RID: 757 RVA: 0x00015C0A File Offset: 0x00013E0A
	public IEnumerator InteractWithComponent()
	{

        return default;
    }

	// Token: 0x060002F6 RID: 758 RVA: 0x00015C19 File Offset: 0x00013E19
	public void StartInteractWithComponent()
	{

	}

	// Token: 0x060002F7 RID: 759 RVA: 0x00015C33 File Offset: 0x00013E33
	public void StopInteractWithComponent()
	{

	}

	// Token: 0x060002F8 RID: 760 RVA: 0x00015C40 File Offset: 0x00013E40
	public bool ShouldInteractWithComponent()
	{

        return default;
    }

	// Token: 0x060002F9 RID: 761 RVA: 0x00015C9E File Offset: 0x00013E9E
	public bool ShouldStopInteractingWithComponent()
	{

        return default;
    }

	// Token: 0x060002FA RID: 762 RVA: 0x00015CB0 File Offset: 0x00013EB0
	public IEnumerator RunFocusOnComponent()
	{

        return default;
    }

	// Token: 0x060002FB RID: 763 RVA: 0x00015CC0 File Offset: 0x00013EC0
	public void EnterFocusOnComponent()
	{

	}

	// Token: 0x060002FC RID: 764 RVA: 0x00015D16 File Offset: 0x00013F16
	public void ExitFocusOnComponent()
	{

	}

	// Token: 0x060002FD RID: 765 RVA: 0x00015D40 File Offset: 0x00013F40
	public bool ShouldFocusOnComponent()
	{

        return default;
    }

	// Token: 0x060002FE RID: 766 RVA: 0x00015E45 File Offset: 0x00014045
	public bool ShouldStopFocusingOnComponent()
	{

        return default;
    }

	// Token: 0x060002FF RID: 767 RVA: 0x00015E57 File Offset: 0x00014057
	public IEnumerator RunRotateComponent()
	{

        return default;
    }

	// Token: 0x06000300 RID: 768 RVA: 0x00015E66 File Offset: 0x00014066
	public void DenyRotateStructure()
	{

	}

	// Token: 0x06000301 RID: 769 RVA: 0x00015E7C File Offset: 0x0001407C
	public void EnterRotateComponent()
	{

	}

	// Token: 0x06000302 RID: 770 RVA: 0x00015FD8 File Offset: 0x000141D8
	public void ExitRotateComponent()
	{

	}

	// Token: 0x06000303 RID: 771 RVA: 0x0001609B File Offset: 0x0001429B
	public void SetComponentRotation(ComponentHandler component, Vector3 rotation)
	{

	}

	// Token: 0x06000304 RID: 772 RVA: 0x000160AC File Offset: 0x000142AC
	private IEnumerator SetComponentRotationCoroutine(ComponentHandler component, Vector3 rotation)
	{

        return default;
    }

	// Token: 0x06000305 RID: 773 RVA: 0x000160CC File Offset: 0x000142CC
	public bool ShouldEnterRotateComponent()
	{

        return default;
    }

	// Token: 0x06000306 RID: 774 RVA: 0x00016144 File Offset: 0x00014344
	public bool ShouldDenyRotateComponent()
	{

        return default;
    }

	// Token: 0x06000307 RID: 775 RVA: 0x000161A1 File Offset: 0x000143A1
	public bool ShouldExitRotateComponent()
	{

        return default;
    }

	// Token: 0x06000308 RID: 776 RVA: 0x000161B3 File Offset: 0x000143B3
	public IEnumerator RunRotateDevice()
	{

        return default;
    }

	// Token: 0x06000309 RID: 777 RVA: 0x000161C4 File Offset: 0x000143C4
	private void UpdateHudProperty()
	{

	}

	// Token: 0x0600030A RID: 778 RVA: 0x00016224 File Offset: 0x00014424
	public void EnterRotateDevice()
	{

	}

	// Token: 0x0600030B RID: 779 RVA: 0x00016340 File Offset: 0x00014540
	public void ExitRotateDevice()
	{

	}

	// Token: 0x0600030C RID: 780 RVA: 0x00016455 File Offset: 0x00014655
	public void SetDeviceRotation(Device device, Vector3 euler)
	{

	}

	// Token: 0x0600030D RID: 781 RVA: 0x0001646B File Offset: 0x0001466B
	private IEnumerator SetDeviceRotationCoroutine(Device device, Quaternion rotation)
	{

        return default;
    }

	// Token: 0x0600030E RID: 782 RVA: 0x00016488 File Offset: 0x00014688
	public bool ShouldEnterRotateDevice()
	{

        return default;
    }

	// Token: 0x0600030F RID: 783 RVA: 0x00016500 File Offset: 0x00014700
	public bool ShouldDenyRotateDevice()
	{

        return default;
    }

	// Token: 0x06000310 RID: 784 RVA: 0x0001655D File Offset: 0x0001475D
	public IEnumerator RunOffsetComponent()
	{

        return default;
    }

	// Token: 0x06000311 RID: 785 RVA: 0x0001656C File Offset: 0x0001476C
	public void EnterOffsetComponent()
	{

	}

	// Token: 0x06000312 RID: 786 RVA: 0x0001661C File Offset: 0x0001481C
	public void ExitOffsetComponent()
	{

	}

	// Token: 0x06000313 RID: 787 RVA: 0x00016679 File Offset: 0x00014879
	public void SetComponentOffset(ComponentHandler component, float offset)
	{

	}

	// Token: 0x06000314 RID: 788 RVA: 0x0001668A File Offset: 0x0001488A
	private IEnumerator SetComponentOffsetCoroutine(ComponentHandler component, float offset)
	{

        return default;
    }

	// Token: 0x06000315 RID: 789 RVA: 0x000166A8 File Offset: 0x000148A8
	public bool ShouldEnterOffsetComponent()
	{

        return default;
    }

	// Token: 0x06000316 RID: 790 RVA: 0x00016704 File Offset: 0x00014904
	public bool ShouldEnterOffsetComponentDirectly()
	{

        return default;
    }

	// Token: 0x06000317 RID: 791 RVA: 0x0001675D File Offset: 0x0001495D
	public bool ShouldExitOffsetComponent()
	{

        return default;
    }

	// Token: 0x06000318 RID: 792 RVA: 0x00016783 File Offset: 0x00014983
	public bool ShouldInterruptMove()
	{

        return default;
    }

	// Token: 0x06000319 RID: 793 RVA: 0x000167A8 File Offset: 0x000149A8
	public void EnterInterruptMove()
	{

	}

	// Token: 0x0600031A RID: 794 RVA: 0x000168F3 File Offset: 0x00014AF3
	public IEnumerator RunScaleComponent()
	{

        return default;
    }

	// Token: 0x0600031B RID: 795 RVA: 0x00016902 File Offset: 0x00014B02
	public void DenyScaleStructure()
	{

	}

	// Token: 0x0600031C RID: 796 RVA: 0x00016915 File Offset: 0x00014B15
	public void DenyScaleComponent()
	{

	}

	// Token: 0x0600031D RID: 797 RVA: 0x00016928 File Offset: 0x00014B28
	public void DenyScaleComponentInsideStructure()
	{

	}

	// Token: 0x0600031E RID: 798 RVA: 0x0001693C File Offset: 0x00014B3C
	private void ScaleComponentFromFSM(ComponentHandler componentHandler, float amount, AgentGestalt.NUSDefinition nusDefinition, bool clampValue)
	{

	}

	// Token: 0x0600031F RID: 799 RVA: 0x00016B14 File Offset: 0x00014D14
	public void SetScale(ComponentHandler component, Vector3 scale)
	{

	}

	// Token: 0x06000320 RID: 800 RVA: 0x00016B25 File Offset: 0x00014D25
	private IEnumerator SetScaleCoroutine(ComponentHandler component, Vector3 scale)
	{

        return default;
    }

	// Token: 0x06000321 RID: 801 RVA: 0x00016B44 File Offset: 0x00014D44
	private void ApplyScaleFinal(ComponentHandler component)
	{

	}

	// Token: 0x06000322 RID: 802 RVA: 0x00016BE4 File Offset: 0x00014DE4
	public void EnterScaleComponent()
	{

	}

	// Token: 0x06000323 RID: 803 RVA: 0x00016CA4 File Offset: 0x00014EA4
	public void ExitScaleComponent()
	{

	}

	// Token: 0x06000324 RID: 804 RVA: 0x00016D35 File Offset: 0x00014F35
	public bool ShouldExitScaleComponent()
	{

        return default;
    }

	// Token: 0x06000325 RID: 805 RVA: 0x00016D48 File Offset: 0x00014F48
	public bool ShouldScaleComponent()
	{

        return default;
    }

	// Token: 0x06000326 RID: 806 RVA: 0x00016DC4 File Offset: 0x00014FC4
	public bool ShouldDenyScaleStructure()
	{

        return default;
    }

	// Token: 0x06000327 RID: 807 RVA: 0x00016E24 File Offset: 0x00015024
	public bool ShouldDenyScaleComponent()
	{

        return default;
    }

	// Token: 0x06000328 RID: 808 RVA: 0x00016E84 File Offset: 0x00015084
	public bool ShouldDenyScaleComponentInsideStructure()
	{

        return default;
    }

	// Token: 0x06000329 RID: 809 RVA: 0x00016EE7 File Offset: 0x000150E7
	public bool ShouldEnterCycleSocket()
	{

        return default;
    }

	// Token: 0x0600032A RID: 810 RVA: 0x00016F27 File Offset: 0x00015127
	public IEnumerator RunCycleSocket()
	{

        return default;
    }

	// Token: 0x0600032B RID: 811 RVA: 0x00016F38 File Offset: 0x00015138
	public IEnumerator RunMoveWireframeComponent()
	{

        return default;
    }

	// Token: 0x0600032C RID: 812 RVA: 0x00016FBA File Offset: 0x000151BA
	private IEnumerator RunMoveWireframeComponentEssential()
	{

        return default;
    }

	// Token: 0x0600032D RID: 813 RVA: 0x00016FCC File Offset: 0x000151CC
	public void EnterMoveWireframeComponent()
	{

	}

	// Token: 0x0600032E RID: 814 RVA: 0x000170DC File Offset: 0x000152DC
	public void ExitMoveWireframeComponent()
	{

	}

	// Token: 0x0600032F RID: 815 RVA: 0x0001713B File Offset: 0x0001533B
	public bool ShouldRespawnMovingComponent()
	{

        return default;
    }

	// Token: 0x06000330 RID: 816 RVA: 0x0001715C File Offset: 0x0001535C
	public void RespawnMovingComponent()
	{

	}

	// Token: 0x06000331 RID: 817 RVA: 0x000171C6 File Offset: 0x000153C6
	public bool ShouldDeleteAndSpawnNewComponent()
	{

        return default;
    }

	// Token: 0x06000332 RID: 818 RVA: 0x000171D3 File Offset: 0x000153D3
	public bool ShouldQuickDeleteNewComponent()
	{

        return default;
    }

	// Token: 0x06000333 RID: 819 RVA: 0x000171F4 File Offset: 0x000153F4
	public IEnumerator RunMoveSolidComponent()
	{

        return default;
    }

	// Token: 0x06000334 RID: 820 RVA: 0x00017204 File Offset: 0x00015404
	public void EnterMoveSolidComponent()
	{

	}

	// Token: 0x06000335 RID: 821 RVA: 0x00017280 File Offset: 0x00015480
	public void ExitMoveSolidComponent()
	{

	}

	// Token: 0x06000336 RID: 822 RVA: 0x000172FF File Offset: 0x000154FF
	public bool ShouldExitMoveSolidComponent()
	{

        return default;
    }

	// Token: 0x06000337 RID: 823 RVA: 0x00017325 File Offset: 0x00015525
	public bool ShouldEnterMoveSolidComponent()
	{

        return default;
    }

	// Token: 0x06000338 RID: 824 RVA: 0x00017358 File Offset: 0x00015558
	public void DynamicPropDestroy(GameObject dynamicProp)
	{

	}

	// Token: 0x06000339 RID: 825 RVA: 0x000173A5 File Offset: 0x000155A5
	public IEnumerator RunMoveProp()
	{

        return default;
    }

	// Token: 0x0600033A RID: 826 RVA: 0x000173B4 File Offset: 0x000155B4
	public void RequestReleaseProp()
	{

	}

	// Token: 0x0600033B RID: 827 RVA: 0x000173DE File Offset: 0x000155DE
	public bool ShouldReleaseProp()
	{

        return default;
    }

	// Token: 0x0600033C RID: 828 RVA: 0x00017412 File Offset: 0x00015612
	public IEnumerator RunCloneComponent()
	{

        return default;
    }

	// Token: 0x0600033D RID: 829 RVA: 0x00017421 File Offset: 0x00015621
	public void EnterCloneComponent()
	{

	}

	// Token: 0x0600033E RID: 830 RVA: 0x0001745F File Offset: 0x0001565F
	public void ExitCloneComponent()
	{

	}

	// Token: 0x0600033F RID: 831 RVA: 0x0001747D File Offset: 0x0001567D
	public void SetTargetAsComponentToClone()
	{

	}

	// Token: 0x06000340 RID: 832 RVA: 0x0001748C File Offset: 0x0001568C
	public bool ShouldEnterCloneComponent()
	{

        return default;
    }

	// Token: 0x06000341 RID: 833 RVA: 0x000174D9 File Offset: 0x000156D9
	public bool ShouldRecloneComponent()
	{

        return default;
    }

	// Token: 0x06000342 RID: 834 RVA: 0x000174E4 File Offset: 0x000156E4
	public void SpawnComponent(AgentGestaltEnum componentGestaltId)
	{

	}

	// Token: 0x06000343 RID: 835 RVA: 0x000178A4 File Offset: 0x00015AA4
	public void PinComponent()
	{

	}

	// Token: 0x06000344 RID: 836 RVA: 0x00017B06 File Offset: 0x00015D06
	public void DenyPinComponent()
	{

	}

	// Token: 0x06000345 RID: 837 RVA: 0x00017B1C File Offset: 0x00015D1C
	public bool ShouldPinComponent()
	{

        return default;
    }

	// Token: 0x06000346 RID: 838 RVA: 0x00017BAC File Offset: 0x00015DAC
	public bool ShouldDenyPinComponent()
	{

        return default;
    }

	// Token: 0x06000347 RID: 839 RVA: 0x00017BFF File Offset: 0x00015DFF
	public IEnumerator RunGhostMode()
	{

        return default;
    }

	// Token: 0x06000348 RID: 840 RVA: 0x00017C10 File Offset: 0x00015E10
	public void EnterGhostMode()
	{

	}

	// Token: 0x06000349 RID: 841 RVA: 0x00017C72 File Offset: 0x00015E72
	public void ExitGhostMode()
	{

	}

	// Token: 0x0600034A RID: 842 RVA: 0x00017C90 File Offset: 0x00015E90
	public bool ShouldEnterGhostMode()
	{

        return default;
    }

	// Token: 0x0600034B RID: 843 RVA: 0x00017CB7 File Offset: 0x00015EB7
	public bool ShouldExitGhostMode()
	{

        return default;
    }

	// Token: 0x0600034C RID: 844 RVA: 0x00017CDD File Offset: 0x00015EDD
	public bool ShouldExitGhostModeAndOpenPropertyEditor()
	{

        return default;
    }

	// Token: 0x0600034D RID: 845 RVA: 0x00017D10 File Offset: 0x00015F10
	public void ToggleDeviceStaticOption()
	{

	}

	// Token: 0x0600034E RID: 846 RVA: 0x00017DC8 File Offset: 0x00015FC8
	public bool ShouldToggleDeviceStaticOption()
	{

        return default;
    }

	// Token: 0x0600034F RID: 847 RVA: 0x00017E06 File Offset: 0x00016006
	public IEnumerator RunBuildDevice()
	{

        return default;
    }

	// Token: 0x06000350 RID: 848 RVA: 0x00017E15 File Offset: 0x00016015
	public void EnterBuildDevice(string blueprintPath)
	{

	}

	// Token: 0x06000351 RID: 849 RVA: 0x00017E1E File Offset: 0x0001601E
	public void ExitBuildDevice()
	{

	}

	// Token: 0x06000352 RID: 850 RVA: 0x00017E36 File Offset: 0x00016036
	public void EnterBuildDeviceFromWorkshop(object publishedFileId)
	{

	}

	// Token: 0x06000353 RID: 851 RVA: 0x00017E44 File Offset: 0x00016044
	public void ExitBuildDeviceFromWorkshop()
	{

	}

	// Token: 0x06000354 RID: 852 RVA: 0x00017E5C File Offset: 0x0001605C
	public void ShowErrorDialogBox(string errorMessage)
	{

	}

	// Token: 0x06000355 RID: 853 RVA: 0x00017EAD File Offset: 0x000160AD
	private void HandleErrorDialogBoxResponse(Visor.Visor.DialogBoxResponses response)
	{

	}

	// Token: 0x06000356 RID: 854 RVA: 0x00017EB6 File Offset: 0x000160B6
	public bool ShouldCloseErrorDialogBox()
	{

        return default;
    }

	// Token: 0x06000357 RID: 855 RVA: 0x00017EBE File Offset: 0x000160BE
	public void OpenExceptionPopup()
	{

	}

	// Token: 0x06000358 RID: 856 RVA: 0x00017ED2 File Offset: 0x000160D2
	public bool ShouldOpenExceptionPopup()
	{

        return default;
    }

	// Token: 0x06000359 RID: 857 RVA: 0x00017EE9 File Offset: 0x000160E9
	public IEnumerator RunLoadWorld(string filename, bool firstWorldLoad, WorldController.WorldTypes worldType)
	{

        return default;
    }

	// Token: 0x0600035A RID: 858 RVA: 0x00017F0D File Offset: 0x0001610D
	public void ExitLoadWorld()
	{

	}

	// Token: 0x0600035B RID: 859 RVA: 0x00017F4D File Offset: 0x0001614D
	private IEnumerator TriggerWelcomePopup()
	{

        return default;
    }

	// Token: 0x0600035C RID: 860 RVA: 0x00017F5C File Offset: 0x0001615C
	public void ShowTutorialLoadError()
	{

	}

	// Token: 0x0600035D RID: 861 RVA: 0x00017FB7 File Offset: 0x000161B7
	public IEnumerator RunPrepareForStagePlaytest()
	{

        return default;
    }

	// Token: 0x0600035E RID: 862 RVA: 0x00017FC6 File Offset: 0x000161C6
	public void ExitPrepareForStagePlaytest()
	{

	}

	// Token: 0x0600035F RID: 863 RVA: 0x00017FE5 File Offset: 0x000161E5
	public void DenyPrepareForStagePlaytest()
	{

	}

	// Token: 0x06000360 RID: 864 RVA: 0x00018020 File Offset: 0x00016220
	public bool ShouldPrepareForStagePlaytest()
	{

        return default;
    }

	// Token: 0x06000361 RID: 865 RVA: 0x0001805F File Offset: 0x0001625F
	public bool ShouldDenyPrepareForStagePlaytest()
	{

        return default;
    }

	// Token: 0x06000362 RID: 866 RVA: 0x0001809B File Offset: 0x0001629B
	public IEnumerator RunRestoreSandboxState()
	{

        return default;
    }

	// Token: 0x06000363 RID: 867 RVA: 0x000180AA File Offset: 0x000162AA
	public void ExitRestoreSandboxState()
	{

	}

	// Token: 0x06000364 RID: 868 RVA: 0x000180C9 File Offset: 0x000162C9
	public bool ShouldRestoreSandboxState()
	{

        return default;
    }

	// Token: 0x06000365 RID: 869 RVA: 0x00018100 File Offset: 0x00016300
	public void GameStart()
	{

	}

	// Token: 0x06000366 RID: 870 RVA: 0x000181D8 File Offset: 0x000163D8
	public IEnumerator CreateWorld()
	{

        return default;
    }

	// Token: 0x06000367 RID: 871 RVA: 0x000181E7 File Offset: 0x000163E7
	public bool ShouldCreateWorld()
	{

        return default;
    }

	// Token: 0x06000368 RID: 872 RVA: 0x000181EF File Offset: 0x000163EF
	public void OpenWorldSettings()
	{

	}

	// Token: 0x06000369 RID: 873 RVA: 0x00018220 File Offset: 0x00016420
	public void CloseWorldSettings()
	{

	}

	// Token: 0x0600036A RID: 874 RVA: 0x00018234 File Offset: 0x00016434
	public void OpenPropertyEditor()
	{

	}

	// Token: 0x0600036B RID: 875 RVA: 0x000182CC File Offset: 0x000164CC
	public void ClosePropertyEditor()
	{

	}

	// Token: 0x0600036C RID: 876 RVA: 0x000182F4 File Offset: 0x000164F4
	public bool ShouldOpenPropertyEditor()
	{

        return default;
    }

	// Token: 0x0600036D RID: 877 RVA: 0x00018333 File Offset: 0x00016533
	public void OpenDeviceEditor()
	{

	}

	// Token: 0x0600036E RID: 878 RVA: 0x0001835A File Offset: 0x0001655A
	public void CloseDeviceEditor()
	{
	}

	// Token: 0x0600036F RID: 879 RVA: 0x0001835C File Offset: 0x0001655C
	public void OpenComponentLibrary()
	{

	}

	// Token: 0x06000370 RID: 880 RVA: 0x0001837D File Offset: 0x0001657D
	public void CloseComponentLibrary()
	{
	}

	// Token: 0x06000371 RID: 881 RVA: 0x0001837F File Offset: 0x0001657F
	public bool ShouldOpenComponentLibrary()
	{

        return default;
    }

	// Token: 0x06000372 RID: 882 RVA: 0x000183BC File Offset: 0x000165BC
	public void OpenProcessorUI()
	{

	}

	// Token: 0x06000373 RID: 883 RVA: 0x000184A0 File Offset: 0x000166A0
	public void CloseProcessorUI()
	{

	}

	// Token: 0x06000374 RID: 884 RVA: 0x0001850C File Offset: 0x0001670C
	public void DenyOpenProcessorUI()
	{

	}

	// Token: 0x06000375 RID: 885 RVA: 0x00018540 File Offset: 0x00016740
	public bool ShouldOpenProcessorUI()
	{

        return default;
    }

	// Token: 0x06000376 RID: 886 RVA: 0x000185AC File Offset: 0x000167AC
	public bool ShouldDenyOpenProcessorUI()
	{

        return default;
    }

	// Token: 0x06000377 RID: 887 RVA: 0x00018625 File Offset: 0x00016825
	public void OpenAssetOrganizer()
	{

	}

	// Token: 0x06000378 RID: 888 RVA: 0x0001864B File Offset: 0x0001684B
	public void CloseAssetOrganizer()
	{

	}

	// Token: 0x06000379 RID: 889 RVA: 0x00018653 File Offset: 0x00016853
	public void OpenDeviceBrowser()
	{

	}

	// Token: 0x0600037A RID: 890 RVA: 0x00018679 File Offset: 0x00016879
	public void CloseDeviceBrowser()
	{

	}

	// Token: 0x0600037B RID: 891 RVA: 0x00018688 File Offset: 0x00016888
	public bool ShouldOpenDeviceBrowser()
	{

        return default;
    }

	// Token: 0x0600037C RID: 892 RVA: 0x000186BB File Offset: 0x000168BB
	public void OpenSaveDevice()
	{

	}

	// Token: 0x0600037D RID: 893 RVA: 0x000186ED File Offset: 0x000168ED
	public void CloseSaveDevice()
	{

	}

	// Token: 0x0600037E RID: 894 RVA: 0x000186F5 File Offset: 0x000168F5
	public bool ShouldOpenSaveDevice()
	{

        return default;
    }

	// Token: 0x0600037F RID: 895 RVA: 0x00018724 File Offset: 0x00016924
	public void OpenWorldBrowser()
	{

	}

	// Token: 0x06000380 RID: 896 RVA: 0x0001874A File Offset: 0x0001694A
	public void CloseWorldBrowser()
	{

	}

	// Token: 0x06000381 RID: 897 RVA: 0x00018759 File Offset: 0x00016959
	public bool ShouldOpenWorldBrowser()
	{

        return default;
    }

	// Token: 0x06000382 RID: 898 RVA: 0x00018783 File Offset: 0x00016983
	public void OpenSaveWorld()
	{

	}

	// Token: 0x06000383 RID: 899 RVA: 0x000187BE File Offset: 0x000169BE
	public void CloseSaveWorld()
	{
	}

	// Token: 0x06000384 RID: 900 RVA: 0x000187C0 File Offset: 0x000169C0
	public bool ShouldOpenSaveWorld()
	{

        return default;
    }

	// Token: 0x06000385 RID: 901 RVA: 0x000187F1 File Offset: 0x000169F1
	public void OpenShareWorld()
	{

	}

	// Token: 0x06000386 RID: 902 RVA: 0x0001882C File Offset: 0x00016A2C
	public void CloseShareWorld()
	{
	}

	// Token: 0x06000387 RID: 903 RVA: 0x0001882E File Offset: 0x00016A2E
	public void OpenPauseMenu()
	{

	}

	// Token: 0x06000388 RID: 904 RVA: 0x00018854 File Offset: 0x00016A54
	public void ClosePauseMenu()
	{

	}

	// Token: 0x06000389 RID: 905 RVA: 0x0001885C File Offset: 0x00016A5C
	public bool ShouldOpenPauseMenu()
	{

        return default;
    }

	// Token: 0x0600038A RID: 906 RVA: 0x00018892 File Offset: 0x00016A92
	public void OpenWelcome()
	{

	}

	// Token: 0x0600038B RID: 907 RVA: 0x000188C3 File Offset: 0x00016AC3
	public void CloseWelcome()
	{

	}

	// Token: 0x0600038C RID: 908 RVA: 0x000188D8 File Offset: 0x00016AD8
	public bool ShouldOpenWelcome()
	{

        return default;
    }

	// Token: 0x0600038D RID: 909 RVA: 0x000188EA File Offset: 0x00016AEA
	public void OpenCreateNewWorld()
	{

	}

	// Token: 0x0600038E RID: 910 RVA: 0x0001890A File Offset: 0x00016B0A
	public void CloseCreateNewWorld()
	{

	}

	// Token: 0x0600038F RID: 911 RVA: 0x00018912 File Offset: 0x00016B12
	public void OpenNews()
	{

	}

	// Token: 0x06000390 RID: 912 RVA: 0x00018938 File Offset: 0x00016B38
	public void CloseNews()
	{

	}

	// Token: 0x06000391 RID: 913 RVA: 0x00018947 File Offset: 0x00016B47
	public bool ShouldOpenNews()
	{

        return default;
    }

	// Token: 0x06000392 RID: 914 RVA: 0x00018971 File Offset: 0x00016B71
	public void OpenFeedback()
	{

	}

	// Token: 0x06000393 RID: 915 RVA: 0x0001898B File Offset: 0x00016B8B
	public void CloseFeedback()
	{

	}

	// Token: 0x06000394 RID: 916 RVA: 0x0001899A File Offset: 0x00016B9A
	public bool ShouldOpenFeedback()
	{

        return default;
    }

	// Token: 0x06000395 RID: 917 RVA: 0x000189C4 File Offset: 0x00016BC4
	public void OpenEncyclopedia()
	{

	}

	// Token: 0x06000396 RID: 918 RVA: 0x000189DE File Offset: 0x00016BDE
	public void CloseEncyclopedia()
	{

	}

	// Token: 0x06000397 RID: 919 RVA: 0x000189E6 File Offset: 0x00016BE6
	public bool ShouldOpenEncyclopedia()
	{

        return default;
    }

	// Token: 0x06000398 RID: 920 RVA: 0x000189E9 File Offset: 0x00016BE9
	public void OpenBlockingTutorial()
	{

	}

	// Token: 0x06000399 RID: 921 RVA: 0x00018A15 File Offset: 0x00016C15
	public void CloseBlockingTutorial()
	{

	}

	// Token: 0x0600039A RID: 922 RVA: 0x00018A24 File Offset: 0x00016C24
	public bool ShouldOpenBlockingTutorial()
	{

        return default;
    }

	// Token: 0x0600039B RID: 923 RVA: 0x00018A3B File Offset: 0x00016C3B
	public void OpenSettings()
	{

	}

	// Token: 0x0600039C RID: 924 RVA: 0x00018A4F File Offset: 0x00016C4F
	public void CloseSettings()
	{
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00018A51 File Offset: 0x00016C51
	public IEnumerator EnterAdvancedHudEdit()
	{

        return default;
    }

	// Token: 0x0600039E RID: 926 RVA: 0x00018A60 File Offset: 0x00016C60
	public void ExitAdvancedEdit()
	{

	}

	// Token: 0x0600039F RID: 927 RVA: 0x00018A7E File Offset: 0x00016C7E
	public IEnumerator WaitOneFrame()
	{

        return default;
    }

	// Token: 0x060003A0 RID: 928 RVA: 0x00018A86 File Offset: 0x00016C86
	public bool ShouldEnterAdvancedHudEdit()
	{

        return default;
    }

	// Token: 0x060003A1 RID: 929 RVA: 0x00018AC4 File Offset: 0x00016CC4
	public bool ShouldExitAdvancedHudEdit()
	{

        return default;
    }

	// Token: 0x060003A2 RID: 930 RVA: 0x00018AEA File Offset: 0x00016CEA
	public void Quit()
	{

	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00018AF1 File Offset: 0x00016CF1
	public bool ShouldOpenConsole()
	{

        return default;
    }

	// Token: 0x060003A4 RID: 932 RVA: 0x00018B11 File Offset: 0x00016D11
	public bool ShouldCloseConsole()
	{

        return default;
    }

	// Token: 0x060003A5 RID: 933 RVA: 0x00018B31 File Offset: 0x00016D31
	public void ShowConsole()
	{

	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00018B44 File Offset: 0x00016D44
	public void HideConsole()
	{

	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00018B50 File Offset: 0x00016D50
	public void EnterDebugMode()
	{

	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00018B71 File Offset: 0x00016D71
	public void ExitDebugMode()
	{

	}

	// Token: 0x060003A9 RID: 937 RVA: 0x00018B7F File Offset: 0x00016D7F
	public bool ShouldToggleDebugMode()
	{

        return default;
    }

	// Token: 0x060003AA RID: 938 RVA: 0x00018B82 File Offset: 0x00016D82
	public void SolidifyDevice()
	{

	}

	// Token: 0x060003AB RID: 939 RVA: 0x00018BAB File Offset: 0x00016DAB
	public void ShowBuildReplayEditor()
	{

	}

	// Token: 0x060003AC RID: 940 RVA: 0x00018BDD File Offset: 0x00016DDD
	public void HideBuildReplayEditor()
	{

	}

	// Token: 0x060003AD RID: 941 RVA: 0x00018BFC File Offset: 0x00016DFC
	public bool ShouldShowBuildReplayEditor()
	{

        return default;
    }

	// Token: 0x060003AE RID: 942 RVA: 0x00018C1E File Offset: 0x00016E1E
	public bool ShouldHideBuildReplayEditor()
	{

        return default;
    }

	// Token: 0x060003AF RID: 943 RVA: 0x00018C30 File Offset: 0x00016E30
	public IEnumerator RunBuildReplayAutoMode()
	{

        return default;
    }

	// Token: 0x060003B0 RID: 944 RVA: 0x00018C40 File Offset: 0x00016E40
	private void SetupGrabPropFSM()
	{

	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00018D61 File Offset: 0x00016F61
	public bool ShouldStartGrabProp()
	{

        return default;
    }

	// Token: 0x060003B2 RID: 946 RVA: 0x00018D83 File Offset: 0x00016F83
	private bool ShouldCancelGrabProp()
	{

        return default;
    }

	// Token: 0x060003B3 RID: 947 RVA: 0x00018DA5 File Offset: 0x00016FA5
	private bool ShouldConfirmGrabProp()
	{

        return default;
    }

	// Token: 0x060003B4 RID: 948 RVA: 0x00018DC4 File Offset: 0x00016FC4
	private void SetupGrabSolidComponentFSM()
	{

	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00018EEC File Offset: 0x000170EC
	public bool ShouldStartGrabSolidComponent()
	{

        return default;
    }

	// Token: 0x060003B6 RID: 950 RVA: 0x00018FC2 File Offset: 0x000171C2
	private bool ShouldCancelGrabSolidComponent()
	{

        return default;
    }

	// Token: 0x060003B7 RID: 951 RVA: 0x00018FFC File Offset: 0x000171FC
	private bool ShouldConfirmGrabSolidComponent()
	{

        return default;
    }

	// Token: 0x060003B8 RID: 952 RVA: 0x0001901C File Offset: 0x0001721C
	private void SetupGrabWireframeComponentFSM()
	{

	}

	// Token: 0x060003B9 RID: 953 RVA: 0x000193F0 File Offset: 0x000175F0
	private void DetachComponent(bool makeUndo = true, bool playSound = true)
	{

	}

	// Token: 0x060003BA RID: 954 RVA: 0x00019714 File Offset: 0x00017914
	private void GrabComponent()
	{

	}

	// Token: 0x060003BB RID: 955 RVA: 0x000197F8 File Offset: 0x000179F8
	private bool ShouldStartGrabComponent()
	{

        return default;
    }

	// Token: 0x060003BC RID: 956 RVA: 0x0001989A File Offset: 0x00017A9A
	private bool ShouldCancelGrabComponent()
	{

        return default;
    }

	// Token: 0x060003BD RID: 957 RVA: 0x000198D4 File Offset: 0x00017AD4
	private bool ShouldCancelDetachComponent()
	{

        return default;
    }

	// Token: 0x060003BE RID: 958 RVA: 0x0001990C File Offset: 0x00017B0C
	private bool ShouldConfirmGrabComponent()
	{

        return default;
    }

	// Token: 0x060003BF RID: 959 RVA: 0x00019960 File Offset: 0x00017B60
	private bool ShouldConfirmDetachComponent()
	{

        return default;
    }

	// Token: 0x060003C0 RID: 960 RVA: 0x000199B0 File Offset: 0x00017BB0
	private bool ShouldDenyGrabComponent()
	{

        return default;
    }

	// Token: 0x060003C1 RID: 961 RVA: 0x00019A20 File Offset: 0x00017C20
	private bool ShouldDenyDetachComponent()
	{

        return default;
    }

	// Token: 0x060003C2 RID: 962 RVA: 0x00019A6C File Offset: 0x00017C6C
	private bool ShouldDenyDetachStructure()
	{

        return default;
    }

	// Token: 0x060003C3 RID: 963 RVA: 0x00019AD0 File Offset: 0x00017CD0
	private void SetupPaintOrSelectColorFSM()
	{

	}

	// Token: 0x060003C4 RID: 964 RVA: 0x00019BD8 File Offset: 0x00017DD8
	private void PaintComponent()
	{

	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00019C9C File Offset: 0x00017E9C
	public bool ShouldStartPaintComponent()
	{

        return default;
    }

	// Token: 0x060003C6 RID: 966 RVA: 0x00019CC4 File Offset: 0x00017EC4
	private bool ShouldConfirmPaintComponent()
	{

        return default;
    }

	// Token: 0x060003C7 RID: 967 RVA: 0x00019D58 File Offset: 0x00017F58
	private bool ShouldCancelPaintComponent()
	{

        return default;
    }

	// Token: 0x060003C8 RID: 968 RVA: 0x00019DDE File Offset: 0x00017FDE
	private bool ShouldStartSelectColor()
	{

        return default;
    }

	// Token: 0x060003C9 RID: 969 RVA: 0x00019E01 File Offset: 0x00018001
	public IEnumerator WaitForSelection()
	{

        return default;
    }

	// Token: 0x060003CA RID: 970 RVA: 0x00019E10 File Offset: 0x00018010
	public void EnterPaletteSelection()
	{

	}

	// Token: 0x060003CB RID: 971 RVA: 0x00019E44 File Offset: 0x00018044
	public void ExitPaletteSelection()
	{

	}

	// Token: 0x060003CC RID: 972 RVA: 0x00019EC2 File Offset: 0x000180C2
	public bool ShouldClosePaletteSelector()
	{

        return default;
    }

	// Token: 0x060003CD RID: 973 RVA: 0x00019ED8 File Offset: 0x000180D8
	private void SetupRebaseDeviceFSM()
	{

	}

	// Token: 0x060003CE RID: 974 RVA: 0x00019FFC File Offset: 0x000181FC
	public void RebaseDevice()
	{

	}

	// Token: 0x060003CF RID: 975 RVA: 0x0001A0A4 File Offset: 0x000182A4
	public bool ShouldStartRebaseDevice()
	{

        return default;
    }

	// Token: 0x060003D0 RID: 976 RVA: 0x0001A0FA File Offset: 0x000182FA
	private bool ShouldCancelRebaseDevice()
	{

        return default;
    }

	// Token: 0x060003D1 RID: 977 RVA: 0x0001A12F File Offset: 0x0001832F
	private bool ShouldConfirmRebaseDevice()
	{

        return default;
    }

	// Token: 0x060003D2 RID: 978 RVA: 0x0001A13C File Offset: 0x0001833C
	private void SetupToggleOrResetDeviceFSM()
	{

	}

	// Token: 0x060003D3 RID: 979 RVA: 0x0001A34C File Offset: 0x0001854C
	private void ToggleDeviceState()
	{

	}

	// Token: 0x060003D4 RID: 980 RVA: 0x0001A380 File Offset: 0x00018580
	private void ResetDevice()
	{

	}

	// Token: 0x060003D5 RID: 981 RVA: 0x0001A412 File Offset: 0x00018612
	private void DenyToggleDeviceState()
	{

	}

	// Token: 0x060003D6 RID: 982 RVA: 0x0001A425 File Offset: 0x00018625
	public bool ShouldStartToggleDeviceState()
	{

        return default;
    }

	// Token: 0x060003D7 RID: 983 RVA: 0x0001A454 File Offset: 0x00018654
	private bool ShouldConfirmToggleDeviceState()
	{

        return default;
    }

	// Token: 0x060003D8 RID: 984 RVA: 0x0001A4B4 File Offset: 0x000186B4
	private bool ShouldDenyToggleDeviceState()
	{

        return default;
    }

	// Token: 0x060003D9 RID: 985 RVA: 0x0001A510 File Offset: 0x00018710
	private bool ShouldCancelToggleDeviceState()
	{

        return default;
    }

	// Token: 0x060003DA RID: 986 RVA: 0x0001A564 File Offset: 0x00018764
	private bool ShouldStartResetDevice()
	{

        return default;
    }

	// Token: 0x060003DB RID: 987 RVA: 0x0001A5B6 File Offset: 0x000187B6
	private bool ShouldConfirmResetDevice()
	{

        return default;
    }

	// Token: 0x060003DC RID: 988 RVA: 0x0001A5D3 File Offset: 0x000187D3
	private bool ShouldCancelResetDevice()
	{

        return default;
    }

	// Token: 0x060003DD RID: 989 RVA: 0x0001A5FC File Offset: 0x000187FC
	private void SetupUndoFSM()
	{

	}

	// Token: 0x060003DE RID: 990 RVA: 0x0001A720 File Offset: 0x00018920
	public void ExecuteUndo()
	{

	}

	// Token: 0x060003DF RID: 991 RVA: 0x0001A849 File Offset: 0x00018A49
	private void AddOperationToUndoQueue(UndoOperation undoOperation)
	{

	}

	// Token: 0x060003E0 RID: 992 RVA: 0x0001A857 File Offset: 0x00018A57
	private void ClearUndoQueue()
	{

	}

	// Token: 0x060003E1 RID: 993 RVA: 0x0001A864 File Offset: 0x00018A64
	public bool ShouldStartUndo()
	{

        return default;
    }

	// Token: 0x060003E2 RID: 994 RVA: 0x0001A888 File Offset: 0x00018A88
	private bool ShouldCancelUndo()
	{

        return default;
    }

	// Token: 0x060003E3 RID: 995 RVA: 0x0001A89A File Offset: 0x00018A9A
	private bool ShouldConfirmUndo()
	{

        return default;
    }

	// Token: 0x14000007 RID: 7
	// (add) Token: 0x060003E4 RID: 996 RVA: 0x0001A8A8 File Offset: 0x00018AA8
	// (remove) Token: 0x060003E5 RID: 997 RVA: 0x0001A8DC File Offset: 0x00018ADC
	public static event WorldController.ComponentTargetEvent OnComponentTargetUpdate;

	// Token: 0x14000008 RID: 8
	// (add) Token: 0x060003E6 RID: 998 RVA: 0x0001A910 File Offset: 0x00018B10
	// (remove) Token: 0x060003E7 RID: 999 RVA: 0x0001A944 File Offset: 0x00018B44
	public static event WorldController.DevicesUpdateEvent OnPreUpdateDevices;

	// Token: 0x14000009 RID: 9
	// (add) Token: 0x060003E8 RID: 1000 RVA: 0x0001A978 File Offset: 0x00018B78
	// (remove) Token: 0x060003E9 RID: 1001 RVA: 0x0001A9AC File Offset: 0x00018BAC
	public static event WorldController.DevicesUpdateEvent OnPostUpdateDevices;

	// Token: 0x1400000A RID: 10
	// (add) Token: 0x060003EA RID: 1002 RVA: 0x0001A9E0 File Offset: 0x00018BE0
	// (remove) Token: 0x060003EB RID: 1003 RVA: 0x0001AA14 File Offset: 0x00018C14
	public static event WorldController.DeviceEvent OnDeviceLoaded;

	// Token: 0x1400000B RID: 11
	// (add) Token: 0x060003EC RID: 1004 RVA: 0x0001AA48 File Offset: 0x00018C48
	// (remove) Token: 0x060003ED RID: 1005 RVA: 0x0001AA7C File Offset: 0x00018C7C
	public static event WorldController.DeviceEvent OnDeviceDeleted;

	// Token: 0x1400000C RID: 12
	// (add) Token: 0x060003EE RID: 1006 RVA: 0x0001AAB0 File Offset: 0x00018CB0
	// (remove) Token: 0x060003EF RID: 1007 RVA: 0x0001AAE4 File Offset: 0x00018CE4
	public static event WorldController.DeviceEvent OnDeviceGrabbed;

	// Token: 0x1400000D RID: 13
	// (add) Token: 0x060003F0 RID: 1008 RVA: 0x0001AB18 File Offset: 0x00018D18
	// (remove) Token: 0x060003F1 RID: 1009 RVA: 0x0001AB4C File Offset: 0x00018D4C
	public static event WorldController.DeviceEvent OnDeviceReleased;

	// Token: 0x1400000E RID: 14
	// (add) Token: 0x060003F2 RID: 1010 RVA: 0x0001AB80 File Offset: 0x00018D80
	// (remove) Token: 0x060003F3 RID: 1011 RVA: 0x0001ABB4 File Offset: 0x00018DB4
	public static event WorldController.DeviceEvent OnDeviceSpawned;

	// Token: 0x1400000F RID: 15
	// (add) Token: 0x060003F4 RID: 1012 RVA: 0x0001ABE8 File Offset: 0x00018DE8
	// (remove) Token: 0x060003F5 RID: 1013 RVA: 0x0001AC1C File Offset: 0x00018E1C
	public static event WorldController.DeviceEvent OnDeviceStateChanged;

	// Token: 0x14000010 RID: 16
	// (add) Token: 0x060003F6 RID: 1014 RVA: 0x0001AC50 File Offset: 0x00018E50
	// (remove) Token: 0x060003F7 RID: 1015 RVA: 0x0001AC84 File Offset: 0x00018E84
	public static event WorldController.DeviceEvent OnComponentAttached;

	// Token: 0x14000011 RID: 17
	// (add) Token: 0x060003F8 RID: 1016 RVA: 0x0001ACB8 File Offset: 0x00018EB8
	// (remove) Token: 0x060003F9 RID: 1017 RVA: 0x0001ACEC File Offset: 0x00018EEC
	public static event WorldController.PhysicsEvent OnPhysicsTick;

	// Token: 0x14000012 RID: 18
	// (add) Token: 0x060003FA RID: 1018 RVA: 0x0001AD20 File Offset: 0x00018F20
	// (remove) Token: 0x060003FB RID: 1019 RVA: 0x0001AD54 File Offset: 0x00018F54
	public static event WorldController.ComponentTransformUpdate OnComponentTransformUpdate;

	// Token: 0x14000013 RID: 19
	// (add) Token: 0x060003FC RID: 1020 RVA: 0x0001AD88 File Offset: 0x00018F88
	// (remove) Token: 0x060003FD RID: 1021 RVA: 0x0001ADBC File Offset: 0x00018FBC
	public static event WorldController.ProjectileEvent OnProjectileDeleted;

	// Token: 0x14000014 RID: 20
	// (add) Token: 0x060003FE RID: 1022 RVA: 0x0001ADF0 File Offset: 0x00018FF0
	// (remove) Token: 0x060003FF RID: 1023 RVA: 0x0001AE24 File Offset: 0x00019024
	public static event WorldController.GameEvent OnGamePaused;

	// Token: 0x14000015 RID: 21
	// (add) Token: 0x06000400 RID: 1024 RVA: 0x0001AE58 File Offset: 0x00019058
	// (remove) Token: 0x06000401 RID: 1025 RVA: 0x0001AE8C File Offset: 0x0001908C
	public static event WorldController.GameEvent OnGameResumed;

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x06000402 RID: 1026 RVA: 0x0001AEBF File Offset: 0x000190BF
	// (set) Token: 0x06000403 RID: 1027 RVA: 0x0001AEC7 File Offset: 0x000190C7
	public string exceptionCondition { get; private set; }

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000404 RID: 1028 RVA: 0x0001AED0 File Offset: 0x000190D0
	// (set) Token: 0x06000405 RID: 1029 RVA: 0x0001AED8 File Offset: 0x000190D8
	public string exceptionStackTrace { get; private set; }

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06000406 RID: 1030 RVA: 0x0001AEE1 File Offset: 0x000190E1
	public IEnumerable<Device> devices
	{
		get
		{
			return this._devices.Values;
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x06000407 RID: 1031 RVA: 0x0001AEEE File Offset: 0x000190EE
	public int numberOfDevices
	{
		get
		{
			return this._devices.Count;
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06000408 RID: 1032 RVA: 0x0001AEFB File Offset: 0x000190FB
	public IEnumerable<Light> lightSources
	{
		get
		{
			return this._lightSources;
		}
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x06000409 RID: 1033 RVA: 0x0001AF03 File Offset: 0x00019103
	public SubComponentHandler candidateParentSubComponentDuringOperation
	{
		get
		{
			return this._candidateParentSubComponent;
		}
	}

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x0600040A RID: 1034 RVA: 0x0001AF0B File Offset: 0x0001910B
	public Vector3 playerPosition
	{
		get
		{
			return this._localCharacter.position;
		}
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x0600040B RID: 1035 RVA: 0x0001AF18 File Offset: 0x00019118
	public Vector3 playerOrientation
	{
		get
		{
			return this._localCharacter.orientation;
		}
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x0600040C RID: 1036 RVA: 0x0001AF25 File Offset: 0x00019125
	public Vector3 playerVelocity
	{
		get
		{
			return this._localCharacter.velocity;
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x0600040D RID: 1037 RVA: 0x0001AF32 File Offset: 0x00019132
	// (set) Token: 0x0600040E RID: 1038 RVA: 0x0001AF3A File Offset: 0x0001913A
	public bool shouldPlayerUndock { get; set; }

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x0600040F RID: 1039 RVA: 0x0001AF43 File Offset: 0x00019143
	public ComponentHandler mountedComponent
	{
		get
		{
			return this._mountedComponent;
		}
	}

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x06000410 RID: 1040 RVA: 0x0001AF4B File Offset: 0x0001914B
	// (set) Token: 0x06000411 RID: 1041 RVA: 0x0001AF53 File Offset: 0x00019153
	public Transform world { get; private set; }

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x06000412 RID: 1042 RVA: 0x0001AF5C File Offset: 0x0001915C
	// (set) Token: 0x06000413 RID: 1043 RVA: 0x0001AF64 File Offset: 0x00019164
	public Transform biome { get; private set; }

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x06000414 RID: 1044 RVA: 0x0001AF6D File Offset: 0x0001916D
	// (set) Token: 0x06000415 RID: 1045 RVA: 0x0001AF75 File Offset: 0x00019175
	public bool shouldWorldBeSaved { get; set; }

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x06000416 RID: 1046 RVA: 0x0001AF7E File Offset: 0x0001917E
	// (set) Token: 0x06000417 RID: 1047 RVA: 0x0001AF86 File Offset: 0x00019186
	public string lastSavedWorld { get; set; }

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x06000418 RID: 1048 RVA: 0x0001AF8F File Offset: 0x0001918F
	// (set) Token: 0x06000419 RID: 1049 RVA: 0x0001AF97 File Offset: 0x00019197
	public bool isWorldTutorial { get; private set; }

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x0600041A RID: 1050 RVA: 0x0001AFA0 File Offset: 0x000191A0
	// (set) Token: 0x0600041B RID: 1051 RVA: 0x0001AFA8 File Offset: 0x000191A8
	public bool deviceWantsToCreateWorld { get; set; }

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x0600041C RID: 1052 RVA: 0x0001AFB1 File Offset: 0x000191B1
	// (set) Token: 0x0600041D RID: 1053 RVA: 0x0001AFB9 File Offset: 0x000191B9
	public BiomeGestaltEnum worldToBeCreated { get; set; }

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x0600041E RID: 1054 RVA: 0x0001AFC2 File Offset: 0x000191C2
	// (set) Token: 0x0600041F RID: 1055 RVA: 0x0001AFCC File Offset: 0x000191CC
	public WorldController.WorldPermissions worldPermissions
	{
		get
		{
			return this._worldPermissions;
		}
		set
		{
			if (this._worldPermissions != value)
			{
				WorldController.WorldPermissions worldPermissions = this._worldPermissions;
				this._worldPermissions = value;
				if ((worldPermissions & WorldController.WorldPermissions.PlayerCanSpawnComponents) != (value & WorldController.WorldPermissions.PlayerCanSpawnComponents) || (worldPermissions & WorldController.WorldPermissions.PlayerCanMakeNewDevices) != (value & WorldController.WorldPermissions.PlayerCanMakeNewDevices))
				{
					this._visor.RefreshVisorElements();
				}
			}
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000420 RID: 1056 RVA: 0x0001B00B File Offset: 0x0001920B
	// (set) Token: 0x06000421 RID: 1057 RVA: 0x0001B013 File Offset: 0x00019213
	public WorldController.GlobalPermissions globalPermissions
	{
		get
		{
			return this._globalPermissions;
		}
		set
		{
			this._globalPermissions = value;
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x06000422 RID: 1058 RVA: 0x0001B01C File Offset: 0x0001921C
	// (set) Token: 0x06000423 RID: 1059 RVA: 0x0001B024 File Offset: 0x00019224
	public WorldController.Stage stage { get; private set; }

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x06000424 RID: 1060 RVA: 0x0001B02D File Offset: 0x0001922D
	// (set) Token: 0x06000425 RID: 1061 RVA: 0x0001B035 File Offset: 0x00019235
	public SerializedWorldMetaData worldMetaData { get; private set; }

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x06000426 RID: 1062 RVA: 0x0001B03E File Offset: 0x0001923E
	// (set) Token: 0x06000427 RID: 1063 RVA: 0x0001B046 File Offset: 0x00019246
	public bool isPlaytestingStage { get; private set; }

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06000428 RID: 1064 RVA: 0x0001B04F File Offset: 0x0001924F
	// (set) Token: 0x06000429 RID: 1065 RVA: 0x0001B057 File Offset: 0x00019257
	public SerializedWorld sandboxState { get; set; }

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x0600042A RID: 1066 RVA: 0x0001B060 File Offset: 0x00019260
	// (set) Token: 0x0600042B RID: 1067 RVA: 0x0001B068 File Offset: 0x00019268
	public bool userWorldScreenshotTaken { get; set; }

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x0600042C RID: 1068 RVA: 0x0001B071 File Offset: 0x00019271
	public DynamicPropsManager dynamicPropsManager
	{
		get
		{
			return this._dynamicPropsManager;
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x0600042D RID: 1069 RVA: 0x0001B079 File Offset: 0x00019279
	public Texture2D deviceScreenshotTexture
	{
		get
		{
			return this._deviceScreenshotTexture;
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x0600042E RID: 1070 RVA: 0x0001B081 File Offset: 0x00019281
	public Texture2D worldScreenshotTexture
	{
		get
		{
			return this._worldScreenshotTexture;
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x0600042F RID: 1071 RVA: 0x0001B089 File Offset: 0x00019289
	// (set) Token: 0x06000430 RID: 1072 RVA: 0x0001B091 File Offset: 0x00019291
	public Device dockingStationDevice { get; private set; }

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000431 RID: 1073 RVA: 0x0001B09A File Offset: 0x0001929A
	// (set) Token: 0x06000432 RID: 1074 RVA: 0x0001B0A2 File Offset: 0x000192A2
	public BlockingTutorialGestaltEnum blockingTutorialToBeShown { get; set; }

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000433 RID: 1075 RVA: 0x0001B0AB File Offset: 0x000192AB
	// (set) Token: 0x06000434 RID: 1076 RVA: 0x0001B0B3 File Offset: 0x000192B3
	public WorldController.Windows windowToBeOpened { get; set; }

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000435 RID: 1077 RVA: 0x0001B0BC File Offset: 0x000192BC
	// (set) Token: 0x06000436 RID: 1078 RVA: 0x0001B0C4 File Offset: 0x000192C4
	public Device deviceToSolidify { get; set; }

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000437 RID: 1079 RVA: 0x0001B0CD File Offset: 0x000192CD
	// (set) Token: 0x06000438 RID: 1080 RVA: 0x0001B0D5 File Offset: 0x000192D5
	public bool temporarilyDisableGuruMeditation { get; set; }

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06000439 RID: 1081 RVA: 0x0001B0DE File Offset: 0x000192DE
	// (set) Token: 0x0600043A RID: 1082 RVA: 0x0001B0E6 File Offset: 0x000192E6
	public int numberOfComponentsLoaded { get; set; }

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x0600043B RID: 1083 RVA: 0x0001B0EF File Offset: 0x000192EF
	// (set) Token: 0x0600043C RID: 1084 RVA: 0x0001B0F7 File Offset: 0x000192F7
	public int paintPrimaryColor { get; set; }

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x0600043D RID: 1085 RVA: 0x0001B100 File Offset: 0x00019300
	// (set) Token: 0x0600043E RID: 1086 RVA: 0x0001B108 File Offset: 0x00019308
	public int paintSecondaryColor { get; set; }

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x0600043F RID: 1087 RVA: 0x0001B111 File Offset: 0x00019311
	public IBlackboard blackboard
	{
		get
		{
			return this._stateMachine.blackboard;
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x06000440 RID: 1088 RVA: 0x0001B11E File Offset: 0x0001931E
	public RigidbodyCharacter character
	{
		get
		{
			return this._localCharacter;
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000441 RID: 1089 RVA: 0x0001B126 File Offset: 0x00019326
	public Visor.Visor visor
	{
		get
		{
			return this._visor;
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000442 RID: 1090 RVA: 0x0001B12E File Offset: 0x0001932E
	public Camera currentCamera
	{
		get
		{
			if (this._localCharacter.cameraIsTaken && this._dummyCamera != null)
			{
				return this._dummyCamera;
			}
			return this._camera;
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000443 RID: 1091 RVA: 0x0001B158 File Offset: 0x00019358
	public Device targetDevice
	{
		get
		{
			return this._targetDevice;
		}
	}

	// Token: 0x06000444 RID: 1092
	public override void Init()
	{

	}

	// Token: 0x06000445 RID: 1093 RVA: 0x0001B560 File Offset: 0x00019760
	private void HandleLogMessageReceived(string condition, string stacktrace, LogType type)
	{

	}

	// Token: 0x06000446 RID: 1094
	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	// Token: 0x06000447 RID: 1095
	[DllImport("user32.dll")]
	private static extern uint GetWindowThreadProcessId(IntPtr hwnd, IntPtr proccess);

	// Token: 0x06000448 RID: 1096
	[DllImport("user32.dll")]
	private static extern IntPtr GetKeyboardLayout(uint thread);

	// Token: 0x06000449 RID: 1097 RVA: 0x0001B6A8 File Offset: 0x000198A8
	private static int GetCurrentKeyboardLayout()
	{

        return default;
    }

	// Token: 0x0600044A RID: 1098 RVA: 0x0001B700 File Offset: 0x00019900
	public void Run()
	{

	}

	// Token: 0x0600044B RID: 1099 RVA: 0x0001B72B File Offset: 0x0001992B
	public void PauseGame()
	{

	}

	// Token: 0x0600044C RID: 1100 RVA: 0x0001B75F File Offset: 0x0001995F
	public void ResumGame()
	{

	}

	// Token: 0x0600044D RID: 1101 RVA: 0x0001B793 File Offset: 0x00019993
	public static int GetTicksForTime(float time)
	{

        return default;
    }

	// Token: 0x0600044E RID: 1102 RVA: 0x0001B7A1 File Offset: 0x000199A1
	public static float GetTimeForTicks(int ticks)
	{

        return default;
    }

	// Token: 0x0600044F RID: 1103 RVA: 0x0001B7AC File Offset: 0x000199AC
	private void OnDestroy()
	{

	}

	// Token: 0x06000450 RID: 1104 RVA: 0x0001B7FC File Offset: 0x000199FC
	public bool IsInFirstPersonMode()
	{

        return default;
    }

	// Token: 0x06000451 RID: 1105 RVA: 0x0001B830 File Offset: 0x00019A30
	private bool IsInMoveWireframeComponent()
	{

        return default;
    }

	// Token: 0x06000452 RID: 1106 RVA: 0x0001B864 File Offset: 0x00019A64
	private void CheckNews()
	{
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x0001B866 File Offset: 0x00019A66
	private IEnumerator RunCheckNews()
	{

        return default;
    }

	// Token: 0x06000454 RID: 1108 RVA: 0x0001B875 File Offset: 0x00019A75
	private void HandleWorkshopItemDownloaded(bool success, WorkshopController.WorkshopItemDownloadedResult result)
	{

	}

	// Token: 0x06000455 RID: 1109 RVA: 0x0001B896 File Offset: 0x00019A96
	public bool DoesPlayerHaveAuthority()
	{

        return default;
    }

	// Token: 0x06000456 RID: 1110 RVA: 0x0001B8C9 File Offset: 0x00019AC9
	public bool DoesPlayerOwnWorld()
	{

        return default;
    }

	// Token: 0x06000457 RID: 1111 RVA: 0x0001B8E4 File Offset: 0x00019AE4
	public bool DoesPlayerHavePermission(Device device, WorldController.GlobalPermissions permission)
	{

        return default;
    }

	// Token: 0x06000458 RID: 1112 RVA: 0x0001B939 File Offset: 0x00019B39
	public bool DoesPlayerHaveWorldPermission(WorldController.WorldPermissions permission)
	{

        return default;
    }

	// Token: 0x06000459 RID: 1113 RVA: 0x0001B950 File Offset: 0x00019B50
	public bool IsStageWithAuthor()
	{

        return default;
    }

	// Token: 0x0600045A RID: 1114 RVA: 0x0001B978 File Offset: 0x00019B78
	public Dictionary<WorldController.GlobalPermissions, bool> ValidateSpecialGlobalPermissions()
	{

        return default;
    }

	// Token: 0x0600045B RID: 1115 RVA: 0x0001BA34 File Offset: 0x00019C34
	public Device GetDeviceByName(string deviceName)
	{

        return default;
    }

	// Token: 0x0600045C RID: 1116 RVA: 0x0001BAA8 File Offset: 0x00019CA8
	public void EnableStage()
	{

	}

	// Token: 0x0600045D RID: 1117 RVA: 0x0001BB26 File Offset: 0x00019D26
	public void DisableStage()
	{

	}

	// Token: 0x0600045E RID: 1118 RVA: 0x0001BB4C File Offset: 0x00019D4C
	private void ApplyStageInitialState(bool fromLoadWorld)
	{

	}

	// Token: 0x0600045F RID: 1119 RVA: 0x0001BCAC File Offset: 0x00019EAC
	public bool IsWithinBiome(Vector3 position)
	{

        return default;
    }

	// Token: 0x06000460 RID: 1120 RVA: 0x0001BCD8 File Offset: 0x00019ED8
	private bool IsWithinBiomeOuterArea(Vector3 position)
	{

        return default;
    }

	// Token: 0x06000461 RID: 1121 RVA: 0x0001BD18 File Offset: 0x00019F18
	private void DoTargetRaycast()
	{

	}

	// Token: 0x06000462 RID: 1122 RVA: 0x0001C034 File Offset: 0x0001A234
	private void HandleRaycastTargetUpdate(ComponentHandler componentHandler, SubComponentHandler subComponentHandler, Device.State state, DynamicProp dynamicProp, bool interactive, bool dockable, bool reactsToRaycast)
	{

	}

	// Token: 0x06000463 RID: 1123 RVA: 0x0001C118 File Offset: 0x0001A318
	private void DoSocketRaycast()
	{

	}

	// Token: 0x06000464 RID: 1124 RVA: 0x0001C294 File Offset: 0x0001A494
	private void UpdateCameraMouseLook()
	{

	}

	// Token: 0x06000465 RID: 1125 RVA: 0x0001C36B File Offset: 0x0001A56B
	private void UpdateFirstPersonMovement()
	{

	}

	// Token: 0x06000466 RID: 1126 RVA: 0x0001C380 File Offset: 0x0001A580
	private void SetBackgroundTasks(WorldController.BackgroundTasks tasks)
	{

	}

	// Token: 0x06000467 RID: 1127 RVA: 0x0001C3F9 File Offset: 0x0001A5F9
	private void DisableSnappingPoints()
	{

	}

	// Token: 0x06000468 RID: 1128 RVA: 0x0001C42F File Offset: 0x0001A62F
	public void AddLightSource(Light spotlight)
	{

	}

	// Token: 0x06000469 RID: 1129 RVA: 0x0001C43D File Offset: 0x0001A63D
	public void RemoveLightSource(Light spotlight)
	{

	}

	// Token: 0x0600046A RID: 1130 RVA: 0x0001C44C File Offset: 0x0001A64C
	public void AddProjectile(PlasmaProjectile projectile)
	{

	}

	// Token: 0x0600046B RID: 1131 RVA: 0x0001C45A File Offset: 0x0001A65A
	public void RemoveProjectile(PlasmaProjectile projectile)
	{

	}

	// Token: 0x0600046C RID: 1132 RVA: 0x0001C47B File Offset: 0x0001A67B
	public void SetMouseSensitivity(float value)
	{

	}

	// Token: 0x0600046D RID: 1133 RVA: 0x0001C48F File Offset: 0x0001A68F
	public void SetHudHintsVisibility(bool value)
	{

	}

	// Token: 0x0600046E RID: 1134 RVA: 0x0001C4A9 File Offset: 0x0001A6A9
	public void SetInvertY(bool value)
	{

	}

	// Token: 0x0600046F RID: 1135 RVA: 0x0001C4C4 File Offset: 0x0001A6C4
	private void TakeScreenshotOfTargetDevice()
	{

	}

	// Token: 0x06000470 RID: 1136 RVA: 0x0001C674 File Offset: 0x0001A874
	private void TakeScreenshotOfWorld()
	{

	}

	// Token: 0x06000471 RID: 1137 RVA: 0x0001C78C File Offset: 0x0001A98C
	private void Update()
	{

	}

	// Token: 0x06000472 RID: 1138 RVA: 0x0001C840 File Offset: 0x0001AA40
	private void LateUpdate()
	{

	}

	// Token: 0x06000473 RID: 1139 RVA: 0x0001CFF8 File Offset: 0x0001B1F8
	private IEnumerator TrailerRevealDevice(Device device)
	{

        return default;
    }

	// Token: 0x06000474 RID: 1140 RVA: 0x0001D007 File Offset: 0x0001B207
	public void ExitToMainMenu()
	{

	}

	// Token: 0x06000475 RID: 1141 RVA: 0x0001D016 File Offset: 0x0001B216
	private IEnumerator Exit()
	{

        return default;
    }

	// Token: 0x06000476 RID: 1142 RVA: 0x0001D028 File Offset: 0x0001B228
	public Device GetDeviceWithGuid(int guid)
	{

        return default;
    }

	// Token: 0x06000477 RID: 1143 RVA: 0x0001D048 File Offset: 0x0001B248
	private int GenerateDeviceGUID()
	{

        return default;
    }

	// Token: 0x06000478 RID: 1144 RVA: 0x0001D068 File Offset: 0x0001B268
	public Device InstantiateDevice(int guid, string displayName)
	{

        return default;
    }

	// Token: 0x06000479 RID: 1145 RVA: 0x0001D0C4 File Offset: 0x0001B2C4
	private Device CreateNewDevice(AgentGestalt rootComponentGestalt)
	{

        return default;
    }

	// Token: 0x0600047A RID: 1146 RVA: 0x0001D2FC File Offset: 0x0001B4FC
	public void SaveDeviceToDisk(string deviceName, string deviceDescription, bool overwrite)
	{

	}

	// Token: 0x0600047B RID: 1147 RVA: 0x0001D34C File Offset: 0x0001B54C
	private void BuildDeviceFromDeviceBlueprint(string deviceFilename)
	{

	}

	// Token: 0x0600047C RID: 1148 RVA: 0x0001D444 File Offset: 0x0001B644
	private void BuildDeviceFromWorkshop(ulong publishedFileId)
	{

	}

	// Token: 0x0600047D RID: 1149 RVA: 0x0001D5D8 File Offset: 0x0001B7D8
	private void FinishedLoadingDevice(Device device)
	{

	}

	// Token: 0x0600047E RID: 1150 RVA: 0x0001D709 File Offset: 0x0001B909
	private IEnumerator LoadDevice(Device device, SerializedDevice serializedDevice, SerializedAssetsLibrary serializedAssetsLibrary, bool restoreRuntime, bool asyncLoad)
	{

        return default;
    }

	// Token: 0x0600047F RID: 1151 RVA: 0x0001D740 File Offset: 0x0001B940
	public void SaveWorldToDisk(bool overwrite, Action handler = null)
	{

	}

	// Token: 0x06000480 RID: 1152 RVA: 0x0001D7A0 File Offset: 0x0001B9A0
	private static HashSet<string> GetExistingWorldsNames()
	{

        return default;
    }

	// Token: 0x06000481 RID: 1153 RVA: 0x0001D7F4 File Offset: 0x0001B9F4
	public static string GetFirstAvailableWorldName()
	{

        return default;
    }

	// Token: 0x06000482 RID: 1154 RVA: 0x0001D836 File Offset: 0x0001BA36
	public string CreateNewWorld(BiomeGestaltEnum biomeToCreateId, string worldName)
	{

        return default;
    }

	// Token: 0x06000483 RID: 1155 RVA: 0x0001D84E File Offset: 0x0001BA4E
	private IEnumerator CloneComponentCoroutine(Device newDevice, ComponentHandler component)
	{

        return default;
    }

	// Token: 0x06000484 RID: 1156 RVA: 0x0001D86C File Offset: 0x0001BA6C
	private void CloneComponent(ComponentHandler component)
	{

	}

	// Token: 0x06000485 RID: 1157 RVA: 0x0001D938 File Offset: 0x0001BB38
	private void FinishedCloningComponent(Device device)
	{

	}

	// Token: 0x06000486 RID: 1158 RVA: 0x0001DB50 File Offset: 0x0001BD50
	public void RemoveDevice(Device device, bool immediate = false)
	{

	}

	// Token: 0x06000487 RID: 1159 RVA: 0x0001DBB8 File Offset: 0x0001BDB8
	private void Purge()
	{

	}

	// Token: 0x06000488 RID: 1160 RVA: 0x0001DC2C File Offset: 0x0001BE2C
	private string GetNewDisplayNameForDevice()
	{

        return default;
    }

	// Token: 0x06000489 RID: 1161 RVA: 0x0001DC8C File Offset: 0x0001BE8C
	private bool IsDisplayNameAvailable(string displayName)
	{

        return default;
    }

	// Token: 0x0600048A RID: 1162 RVA: 0x0001DCFC File Offset: 0x0001BEFC
	private void CleanUpState()
	{

	}

	// Token: 0x0600048B RID: 1163 RVA: 0x0001DD68 File Offset: 0x0001BF68
	public void BuildReplayPinOrAttachComponent(SubComponentHandler parentSubComponent)
	{

	}

	// Token: 0x0600048C RID: 1164 RVA: 0x0001DDE4 File Offset: 0x0001BFE4
	public IEnumerator BuildReplaySpawnComponent(AgentGestaltEnum agentGestaltEnum)
	{

        return default;
    }

	// Token: 0x0600048D RID: 1165 RVA: 0x0001DDFA File Offset: 0x0001BFFA
	public void BuildReplayToggleDevice()
	{

	}

	// Token: 0x0600048E RID: 1166 RVA: 0x0001DE24 File Offset: 0x0001C024
	public void BuildReplayGrabComponent(int deviceId, int componentId)
	{

	}

	// Token: 0x0600048F RID: 1167 RVA: 0x0001DF4C File Offset: 0x0001C14C
	public void BuildReplayGrabComponent(ComponentHandler componentHandler)
	{

	}

	// Token: 0x06000490 RID: 1168 RVA: 0x0001DFB8 File Offset: 0x0001C1B8
	public void BuildReplayExplodeDevice()
	{

	}

	// Token: 0x06000491 RID: 1169 RVA: 0x0001E03C File Offset: 0x0001C23C
	public void BuildReplayOpenSketch(ComponentHandler componentHandler)
	{

	}

	// Token: 0x06000492 RID: 1170 RVA: 0x0001E06D File Offset: 0x0001C26D
	public void BuildReplayRotateComponent(Vector3 value)
	{

	}

	// Token: 0x06000493 RID: 1171 RVA: 0x0001E094 File Offset: 0x0001C294
	public BuildReplayCanvas.SerializedData BuildReplaySave()
	{

        return default;
    }

	// Token: 0x06000494 RID: 1172 RVA: 0x0001E0B6 File Offset: 0x0001C2B6
	public void BuildReplayLoad(BuildReplayCanvas.SerializedData serializedData)
	{

	}

	// Token: 0x06000495 RID: 1173 RVA: 0x0001E0D7 File Offset: 0x0001C2D7
	public void BuildReplayStart()
	{

	}

	// Token: 0x06000496 RID: 1174 RVA: 0x0001E0F7 File Offset: 0x0001C2F7
	public void BuildReplayScaleComponent(Vector3 value)
	{

	}

	// Token: 0x06000497 RID: 1175 RVA: 0x0001E129 File Offset: 0x0001C329
	public void BuildReplayOffsetComponent(float value)
	{

	}

	// Token: 0x06000498 RID: 1176 RVA: 0x0001E150 File Offset: 0x0001C350
	public void BuildReplayColorComponent(int primary, int secondary)
	{

	}

	// Token: 0x06000499 RID: 1177 RVA: 0x0001E17C File Offset: 0x0001C37C
	public void BuildReplaySetTransform(Vector3 position, Quaternion rotation)
	{

	}

	// Token: 0x0600049A RID: 1178 RVA: 0x0001E1CB File Offset: 0x0001C3CB
	public void BuildReplaySelectSocket(int index)
	{

	}

	// Token: 0x0600049B RID: 1179 RVA: 0x0001E1E7 File Offset: 0x0001C3E7
	private static void Log(string message)
	{

	}

	// Token: 0x0600049C RID: 1180 RVA: 0x0001E1F6 File Offset: 0x0001C3F6
	private static void LogVerbose(string message)
	{

	}

	// Token: 0x0600049D RID: 1181 RVA: 0x0001E205 File Offset: 0x0001C405
	private static void LogWarning(string message)
	{

	}

	// Token: 0x0600049E RID: 1182 RVA: 0x0001E214 File Offset: 0x0001C414
	private static void LogError(string message)
	{

	}

	// Token: 0x04000396 RID: 918
	private bool _errorPopupClosed;

	// Token: 0x04000397 RID: 919
	private string _paintKey;

	// Token: 0x04000398 RID: 920
	private bool _inSelector;

	// Token: 0x040003A8 RID: 936
	public static float fixedTimeStep = 0.033333335f;

	// Token: 0x040003A9 RID: 937
	public bool manualUpdate;

	// Token: 0x040003AA RID: 938
	public bool skipLoadingScreen;

	// Token: 0x040003AB RID: 939
	public bool skipWelcomePopup;

	// Token: 0x040003AC RID: 940
	public bool skipTutorial;

	// Token: 0x040003AD RID: 941
	public bool disableGuruMeditation;

	// Token: 0x040003AE RID: 942
	public ulong slowDownFactor;

	// Token: 0x040003AF RID: 943
	public FloatRange cameraPitchLimits;

	// Token: 0x040003B0 RID: 944
	public float cameraSmoothing;

	// Token: 0x040003B1 RID: 945
	public GameObject localPlayerPrefab;

	// Token: 0x040003B2 RID: 946
	public GameObject devicePrefab;

	// Token: 0x040003B3 RID: 947
	public GameObject articulationPrefab;

	// Token: 0x040003B4 RID: 948
	public GameObject socketPrefab;

	// Token: 0x040003B5 RID: 949
	public bool skipPhysics;

	// Token: 0x040003B6 RID: 950
	public Dictionary<AgentGestalt.MassCategories, float> massCategoriesMultipliers;

	// Token: 0x040003B7 RID: 951
	public float mouseSensitivity;

	// Token: 0x040003B8 RID: 952
	public FloatRange offsetLimits;

	// Token: 0x040003B9 RID: 953
	public float translationSpeed;

	// Token: 0x040003BA RID: 954
	public float scaleSpeed;

	// Token: 0x040003BB RID: 955
	public float componentOffsetSpeed;

	// Token: 0x040003BC RID: 956
	public float genericRaycastDistance;

	// Token: 0x040003BD RID: 957
	public float interactionRaycastDistance;

	// Token: 0x040003BE RID: 958
	public float surfingRaycastDistanceOffset;

	// Token: 0x040003BF RID: 959
	public float deviceRotationMultiplier;

	// Token: 0x040003C0 RID: 960
	public float snapRotateInterval;

	// Token: 0x040003C1 RID: 961
	public float spawnDistance;

	// Token: 0x040003C2 RID: 962
	public float worldSeaLevelOffset;

	// Token: 0x040003C3 RID: 963
	public float volumeToMassRatio;

	// Token: 0x040003C4 RID: 964
	public float outerBiomeAreaWidth;

	// Token: 0x040003C5 RID: 965
	public float socketCycleAnimationDuration;

	// Token: 0x040003C6 RID: 966
	public bool hudHintsVisibility;

	// Token: 0x040003C7 RID: 967
	public bool invertY;

	// Token: 0x040003C8 RID: 968
	public int componentsCountPerFrameOnLoad;

	// Token: 0x040003C9 RID: 969
	public int devicesCountPerFrameOnSave;

	// Token: 0x040003CA RID: 970
	public float characterProjectileForceMultiplier;

	// Token: 0x040003CB RID: 971
	public bool disableNonInterpolatedComponents;

	// Token: 0x040003CC RID: 972
	public float shortHoldActionDuration;

	// Token: 0x040003CD RID: 973
	public float normalHoldActionDuration;

	// Token: 0x040003CE RID: 974
	public float longHoldActionDuration;

	// Token: 0x040003CF RID: 975
	public float veryLongHoldActionDuration;

	// Token: 0x040003D0 RID: 976
	public float quickbarHideDelay;

	// Token: 0x040003D1 RID: 977
	public float welcomePopupDelay;

	// Token: 0x040003D2 RID: 978
	public float saveReminderInteraval;

	// Token: 0x040003D3 RID: 979
	public float playtestingFadeDuration;

	// Token: 0x040003D4 RID: 980
	[EventRef]
	public string attachSound;

	// Token: 0x040003D5 RID: 981
	[EventRef]
	public string detachSound;

	// Token: 0x040003D6 RID: 982
	[EventRef]
	public string paintPrimarySound;

	// Token: 0x040003D7 RID: 983
	[EventRef]
	public string paintSecondarySound;

	// Token: 0x040003D8 RID: 984
	[EventRef]
	public string cloneSound;

	// Token: 0x040003D9 RID: 985
	[EventRef]
	public string deviceStaticSound;

	// Token: 0x040003DA RID: 986
	[EventRef]
	public string deviceDynamicSound;

	// Token: 0x040003DB RID: 987
	[EventRef]
	public string pinSound;

	// Token: 0x040003DC RID: 988
	[EventRef]
	public string grabSound;

	// Token: 0x040003DD RID: 989
	[EventRef]
	public string deleteSound;

	// Token: 0x040003DE RID: 990
	[EventRef]
	public string resetDeviceSound;

	// Token: 0x040003DF RID: 991
	[EventRef]
	public string treeLineOnSound;

	// Token: 0x040003E0 RID: 992
	[EventRef]
	public string treeLineOffSound;

	// Token: 0x040003E1 RID: 993
	[EventRef]
	public string enterAdvancedHudSound;

	// Token: 0x040003E2 RID: 994
	[EventRef]
	public string exitAdvancedHudSound;

	// Token: 0x040003E3 RID: 995
	[EventRef]
	public string confirmAdvancedHudSound;

	// Token: 0x040003E4 RID: 996
	[EventRef]
	public string stepAdvancedHudSound;

	// Token: 0x040003E5 RID: 997
	[EventRef]
	public string rebaseSound;

	// Token: 0x040003E6 RID: 998
	[EventRef]
	public string rotateStepsSound;

	// Token: 0x040003E7 RID: 999
	[EventRef]
	public string rotateLinearSound;

	// Token: 0x040003E8 RID: 1000
	[EventRef]
	public string offsetLinearSound;

	// Token: 0x040003E9 RID: 1001
	[EventRef]
	public string scaleUpSound;

	// Token: 0x040003EA RID: 1002
	[EventRef]
	public string scaleDownSound;

	// Token: 0x040003EB RID: 1003
	public Dictionary<AgentGestaltEnum, TutorialGestaltEnum> componentTutorials;

	// Token: 0x040003EC RID: 1004
	public ulong tutorialAuthorSteamId;

	// Token: 0x040003ED RID: 1005
	public ulong tutorialPublishedFileId;

	// Token: 0x040003EE RID: 1006
	public string tutorialFilename;

	// Token: 0x040003EF RID: 1007
	private FSMOwner _stateMachine;

	// Token: 0x040003F0 RID: 1008
	private Visor.Visor _visor;

	// Token: 0x040003F1 RID: 1009
	private RigidbodyCharacter _localCharacter;

	// Token: 0x040003F2 RID: 1010
	private Player _input;

	// Token: 0x040003F3 RID: 1011
	private bool _playerIsDocked;

	// Token: 0x040003F4 RID: 1012
	private bool _playerIsInPhotoMode;

	// Token: 0x040003F5 RID: 1013
	private bool _playerTookPhoto;

	// Token: 0x040003F6 RID: 1014
	private Camera _camera;

	// Token: 0x040003F7 RID: 1015
	private Camera _dummyCamera;

	// Token: 0x040003F8 RID: 1016
	private float _cameraPitch;

	// Token: 0x040003F9 RID: 1017
	private float _cameraYaw;

	// Token: 0x040003FA RID: 1018
	private Camera _deviceScreenshotCamera;

	// Token: 0x040003FB RID: 1019
	private Camera _worldScreenshotCamera;

	// Token: 0x040003FC RID: 1020
	private int _uniqueDeviceID;

	// Token: 0x040003FD RID: 1021
	private Dictionary<int, Device> _devices;

	// Token: 0x040003FE RID: 1022
	private Transform _safeZone;

	// Token: 0x040003FF RID: 1023
	private bool _firstWorldLoad;

	// Token: 0x04000400 RID: 1024
	private bool _shouldOpenWelcome;

	// Token: 0x04000401 RID: 1025
	private bool _playerIsWithinOuterArea;

	// Token: 0x04000402 RID: 1026
	private Device _targetDevice;

	// Token: 0x04000403 RID: 1027
	private ComponentHandler _targetComponent;

	// Token: 0x04000404 RID: 1028
	private SubComponentHandler _targetSubComponent;

	// Token: 0x04000405 RID: 1029
	private DynamicProp _targetDynamicProp;

	// Token: 0x04000406 RID: 1030
	private Vector3 _targetPosition;

	// Token: 0x04000407 RID: 1031
	private Vector3 _targetAngle;

	// Token: 0x04000408 RID: 1032
	private DynamicProp _enabledDynamicProp;

	// Token: 0x04000409 RID: 1033
	private SubComponentHandler _candidateParentSubComponent;

	// Token: 0x0400040A RID: 1034
	private SnappingGeneric _candidateSnappingObject;

	// Token: 0x0400040B RID: 1035
	private Device.State _targetState;

	// Token: 0x0400040C RID: 1036
	private bool _targetInteractive;

	// Token: 0x0400040D RID: 1037
	private bool _targetReactsToRaycast;

	// Token: 0x0400040E RID: 1038
	private bool _targetDockable;

	// Token: 0x0400040F RID: 1039
	private float _targetDistance;

	// Token: 0x04000410 RID: 1040
	private Vector3 _candidatePositionReferenceFrame;

	// Token: 0x04000411 RID: 1041
	private Quaternion _candidateRotationReferenceFrame;

	// Token: 0x04000412 RID: 1042
	private ComponentHandler _previousTargetComponent;

	// Token: 0x04000413 RID: 1043
	private Device.State _previousTargetState;

	// Token: 0x04000414 RID: 1044
	private Device _previousTargetDevice;

	// Token: 0x04000415 RID: 1045
	private ComponentHandler _operatingComponent;

	// Token: 0x04000416 RID: 1046
	private SubComponentHandler _operatingSubComponent;

	// Token: 0x04000417 RID: 1047
	private ComponentHandler _dockingStationComponent;

	// Token: 0x04000418 RID: 1048
	private Device _operatingDevice;

	// Token: 0x04000419 RID: 1049
	private ComponentRotator _componentRotator;

	// Token: 0x0400041A RID: 1050
	private float _moveComponentDistance;

	// Token: 0x0400041B RID: 1051
	private Quaternion _cameraViewOffset;

	// Token: 0x0400041C RID: 1052
	private float _sketchTimeAccumulator;

	// Token: 0x0400041D RID: 1053
	private float _biomeRadiusSquared;

	// Token: 0x0400041E RID: 1054
	private Vector3 _biomeDefaultSpawnPosition;

	// Token: 0x0400041F RID: 1055
	private Vector3 _biomeDeviceRespawnPosition;

	// Token: 0x04000420 RID: 1056
	private Vector3 _biomeSurfaceCenter;

	// Token: 0x04000421 RID: 1057
	private int _componentColorId;

	// Token: 0x04000422 RID: 1058
	private int _altComponentColorId;

	// Token: 0x04000423 RID: 1059
	private List<HintGestaltEnum> _hintGestaltIds;

	// Token: 0x04000424 RID: 1060
	private List<HintGestaltEnum> _advancedHintGestaltIds;

	// Token: 0x04000425 RID: 1061
	private WorldController.BackgroundTasks _enabledBackgroundTasks;

	// Token: 0x04000426 RID: 1062
	private List<Light> _lightSources;

	// Token: 0x04000427 RID: 1063
	private List<PlasmaProjectile> _projectiles;

	// Token: 0x04000428 RID: 1064
	private RotationOverlay _rotationOverlay;

	// Token: 0x04000429 RID: 1065
	private ScaleOverlay _scaleOverlay;

	// Token: 0x0400042A RID: 1066
	private DynamicGridProjector _dynamicGridProjector;

	// Token: 0x0400042B RID: 1067
	private bool _forceRaycastNotification;

	// Token: 0x0400042C RID: 1068
	private int _deviceRotationAxis;

	// Token: 0x0400042D RID: 1069
	private bool _freePlacementWhileMovingWireframe;

	// Token: 0x0400042E RID: 1070
	private Quaternion _componentToCameraYRootOffset;

	// Token: 0x0400042F RID: 1071
	private bool _tickPhysics;

	// Token: 0x04000430 RID: 1072
	private ulong _tickNumber;

	// Token: 0x04000431 RID: 1073
	private bool _canRun;

	// Token: 0x04000432 RID: 1074
	private bool _isPaused;

	// Token: 0x04000433 RID: 1075
	private DynamicPropsManager _dynamicPropsManager;

	// Token: 0x04000434 RID: 1076
	private List<GameObject> _toDestroyLateUpdate;

	// Token: 0x04000435 RID: 1077
	private Texture2D _deviceScreenshotTexture;

	// Token: 0x04000436 RID: 1078
	private Texture2D _worldScreenshotTexture;

	// Token: 0x04000437 RID: 1079
	private bool _waitForTick;

	// Token: 0x04000438 RID: 1080
	private bool _shouldRecloneComponent;

	// Token: 0x04000439 RID: 1081
	private bool _isDeletingComponent;

	// Token: 0x0400043A RID: 1082
	private WorldController.WorldPermissions _worldPermissions;

	// Token: 0x0400043B RID: 1083
	private WorldController.GlobalPermissions _globalPermissions;

	// Token: 0x0400043C RID: 1084
	private bool _exceptionUnhandled;

	// Token: 0x0400043D RID: 1085
	private float _lastFrameScrollAmount;

	// Token: 0x0400043E RID: 1086
	private bool _deviceWasSolidBeforeProcessorUI;

	// Token: 0x0400043F RID: 1087
	private bool _deviceWasSolidBeforePropertyEditor;

	// Token: 0x04000440 RID: 1088
	private float _timeSinceLastSaveReminder;

	// Token: 0x04000441 RID: 1089
	private bool _errorLoadingTutorial;

	// Token: 0x04000442 RID: 1090
	private List<UndoOperation> _undoQueue;

	// Token: 0x04000443 RID: 1091
	private Vector3 _positionAtStartOfOperation;

	// Token: 0x04000444 RID: 1092
	private Quaternion _rotationAtStartOfOperation;

	// Token: 0x04000445 RID: 1093
	private Vector3 _pitchYawRollAtStartOfOperation;

	// Token: 0x04000446 RID: 1094
	private Vector3 _scaleAtStartOfOperation;

	// Token: 0x04000447 RID: 1095
	private float _offsetAtStartOfOperation;

	// Token: 0x04000448 RID: 1096
	private bool _hudForceUpdate;

	// Token: 0x04000449 RID: 1097
	private ComponentHandler _mountedComponent;

	// Token: 0x0400044A RID: 1098
	private Device _movingDevice;

	// Token: 0x0400044B RID: 1099
	private Vector3 _movingDevicePosOffset;

	// Token: 0x0400044C RID: 1100
	private Quaternion _movingDeviceBaseRotation;

	// Token: 0x0400044D RID: 1101
	private int _numberOfComponentsToLoad;

	// Token: 0x0400044E RID: 1102
	private bool _inGhostMode;

	// Token: 0x0400044F RID: 1103
	private bool _showingAdvancedActions;

	// Token: 0x04000450 RID: 1104
	private EventInstance _freeRotationSoundInstance;

	// Token: 0x04000451 RID: 1105
	private EventInstance _offsetSoundInstance;

	// Token: 0x04000452 RID: 1106
	private FemaleSocketPoint _candidateSocket;

	// Token: 0x04000453 RID: 1107
	private Vector3 _socketPlacementPosition;

	// Token: 0x04000454 RID: 1108
	private Quaternion _socketPlacementRotation;

	// Token: 0x04000455 RID: 1109
	private GameObject _floatingSocket;

	// Token: 0x04000456 RID: 1110
	private GameObject _buildReplayCanvas;

	// Token: 0x04000457 RID: 1111
	private ComponentHandler _lastSpawnedComponent;

	// Token: 0x04000458 RID: 1112
	private const string _bbWorldToLoad = "worldToLoad";

	// Token: 0x04000459 RID: 1113
	private const string _bbWorldTypeToLoad = "worldTypeToLoad";

	// Token: 0x0400045A RID: 1114
	public const string bbPublishedWorldInfo = "publishedWorldInfo";

	// Token: 0x0400045B RID: 1115
	public const string bbShouldSaveWorld = "shouldSaveWorld";

	// Token: 0x0400045C RID: 1116
	public const string bbShouldQuit = "shouldQuit";

	// Token: 0x0400045D RID: 1117
	private const float _maxRotationDelta = 10f;

	// Token: 0x0400045E RID: 1118
	private const float _maxOffsetMultiplier = 1500f;

	// Token: 0x0400045F RID: 1119
	private const int _frenchKeyboardId = 1036;

	// Token: 0x04000460 RID: 1120
	private const int _germanKeyboardId = 1031;

	// Token: 0x0400230D RID: 8973
	private Assembly ModLoader;

	// Token: 0x02000300 RID: 768
	private class WaitActionParameters
	{
		// Token: 0x04001A2C RID: 6700
		public float duration;

		// Token: 0x04001A2D RID: 6701
		public Color color;

		// Token: 0x04001A2E RID: 6702
		public string message;

		// Token: 0x04001A2F RID: 6703
		public bool playSound = true;
	}

	// Token: 0x02000301 RID: 769
	[Serializable]
	private class NewsMetaData
	{
		// Token: 0x04001A30 RID: 6704
		public int id;

		// Token: 0x04001A31 RID: 6705
		public string text;
	}

	// Token: 0x02000302 RID: 770
	public class Stage
	{
		// Token: 0x04001A32 RID: 6706
		public float timeOfDay;

		// Token: 0x04001A33 RID: 6707
		public float timeSpeed;

		// Token: 0x04001A34 RID: 6708
		public Vector3 playerPosition;

		// Token: 0x04001A35 RID: 6709
		public Vector3 playerOrientation;
	}

	// Token: 0x02000303 RID: 771
	[Flags]
	public enum WorldPermissions
	{
		// Token: 0x04001A37 RID: 6711
		PlayerCanSpawnComponents = 1,
		// Token: 0x04001A38 RID: 6712
		PlayerCanFly = 2,
		// Token: 0x04001A39 RID: 6713
		PlayerCanMakeNewDevices = 4,
		// Token: 0x04001A3A RID: 6714
		All = 7
	}

	// Token: 0x02000304 RID: 772
	public enum GlobalPermissions
	{
		// Token: 0x04001A3C RID: 6716
		ComponentManipulation = 2,
		// Token: 0x04001A3D RID: 6717
		StateToggle = 4,
		// Token: 0x04001A3E RID: 6718
		GrabWireframe = 8,
		// Token: 0x04001A3F RID: 6719
		PropertyEditorAccess = 16,
		// Token: 0x04001A40 RID: 6720
		SketchAccess = 32,
		// Token: 0x04001A41 RID: 6721
		SketchEdit = 64,
		// Token: 0x04001A42 RID: 6722
		DeviceDelete = 128,
		// Token: 0x04001A43 RID: 6723
		AttachDetach = 256,
		// Token: 0x04001A44 RID: 6724
		GrabSolid = 512,
		// Token: 0x04001A45 RID: 6725
		Clone = 1024,
		// Token: 0x04001A46 RID: 6726
		ResetDevice = 2048,
		// Token: 0x04001A47 RID: 6727
		PaintComponent = 4096,
		// Token: 0x04001A48 RID: 6728
		All = 8190
	}

	// Token: 0x02000305 RID: 773
	public enum GlobalPermissionStates
	{
		// Token: 0x04001A4A RID: 6730
		True,
		// Token: 0x04001A4B RID: 6731
		Global,
		// Token: 0x04001A4C RID: 6732
		False
	}

	// Token: 0x02000306 RID: 774
	public enum Windows
	{
		// Token: 0x04001A4E RID: 6734
		Invalid,
		// Token: 0x04001A4F RID: 6735
		DeviceBrowser,
		// Token: 0x04001A50 RID: 6736
		WorldBrowser,
		// Token: 0x04001A51 RID: 6737
		News,
		// Token: 0x04001A52 RID: 6738
		Feedback
	}

	// Token: 0x02000307 RID: 775
	public enum WorldTypes
	{
		// Token: 0x04001A54 RID: 6740
		Local,
		// Token: 0x04001A55 RID: 6741
		Workshop,
		// Token: 0x04001A56 RID: 6742
		Progress,
		// Token: 0x04001A57 RID: 6743
		Temporary,
		// Token: 0x04001A58 RID: 6744
		Tutorial,
		// Token: 0x04001A59 RID: 6745
		TutorialProgress
	}

	// Token: 0x02000308 RID: 776
	// (Invoke) Token: 0x06001ED6 RID: 7894
	public delegate void ComponentTargetEvent(ComponentHandler component, SubComponentHandler subComponent, Device.State state, DynamicProp dynamicProp, bool interactive, bool dockable, bool reactsToRaycast);

	// Token: 0x02000309 RID: 777
	// (Invoke) Token: 0x06001EDA RID: 7898
	public delegate void DevicesUpdateEvent();

	// Token: 0x0200030A RID: 778
	// (Invoke) Token: 0x06001EDE RID: 7902
	public delegate void DeviceEvent(int guid, string deviceName, string componentName);

	// Token: 0x0200030B RID: 779
	// (Invoke) Token: 0x06001EE2 RID: 7906
	public delegate void PhysicsEvent();

	// Token: 0x0200030C RID: 780
	// (Invoke) Token: 0x06001EE6 RID: 7910
	public delegate void ProjectileEvent(PlasmaProjectile projectile);

	// Token: 0x0200030D RID: 781
	// (Invoke) Token: 0x06001EEA RID: 7914
	public delegate void ComponentTransformUpdate(ComponentHandler componentHandler);

	// Token: 0x0200030E RID: 782
	// (Invoke) Token: 0x06001EEE RID: 7918
	public delegate void GameEvent();

	// Token: 0x0200030F RID: 783
	[Flags]
	private enum BackgroundTasks
	{
		// Token: 0x04001A5B RID: 6747
		PlayerLookAround = 1,
		// Token: 0x04001A5C RID: 6748
		PlayerMove = 2,
		// Token: 0x04001A5D RID: 6749
		PlayerRaycast = 4,
		// Token: 0x04001A5E RID: 6750
		Outline = 8,
		// Token: 0x04001A5F RID: 6751
		TreeLine = 16
	}
}
}