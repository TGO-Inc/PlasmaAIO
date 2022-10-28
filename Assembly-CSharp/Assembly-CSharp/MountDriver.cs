using System;
using System.Collections.Generic;
using DG.Tweening.Timeline;
using FMODUnity;
using Rewired;
using UnityEngine;

// Token: 0x020000AB RID: 171
public class MountDriver : ComponentDriver
{
	// Token: 0x17000081 RID: 129
	// (get) Token: 0x06000803 RID: 2051 RVA: 0x0002CEAC File Offset: 0x0002B0AC
	private ArticulationBody leftArmHinge
	{
		get
		{
			return this._component.GetSubComponent(1).articulationBody;
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x06000804 RID: 2052 RVA: 0x0002CEBF File Offset: 0x0002B0BF
	private ArticulationBody leftHandHinge
	{
		get
		{
			return this._component.GetSubComponent(2).articulationBody;
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x06000805 RID: 2053 RVA: 0x0002CED2 File Offset: 0x0002B0D2
	private ArticulationBody rightArmHinge
	{
		get
		{
			return this._component.GetSubComponent(3).articulationBody;
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x06000806 RID: 2054 RVA: 0x0002CEE5 File Offset: 0x0002B0E5
	private ArticulationBody rightHandHinge
	{
		get
		{
			return this._component.GetSubComponent(4).articulationBody;
		}
	}

	// Token: 0x06000807 RID: 2055 RVA: 0x0002CEF8 File Offset: 0x0002B0F8
	public override void Awake()
	{

	}

	// Token: 0x06000808 RID: 2056 RVA: 0x0002CF14 File Offset: 0x0002B114
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000809 RID: 2057 RVA: 0x0002D138 File Offset: 0x0002B338
	public override void Preprocess()
	{

	}

	// Token: 0x0600080A RID: 2058 RVA: 0x0002D6F0 File Offset: 0x0002B8F0
	private void SetPhysics()
	{

	}

	// Token: 0x0600080B RID: 2059 RVA: 0x0002D86D File Offset: 0x0002BA6D
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x0600080C RID: 2060 RVA: 0x0002D89F File Offset: 0x0002BA9F
	public override void OnSolidEnter()
	{

	}

	// Token: 0x0600080D RID: 2061 RVA: 0x0002D8C6 File Offset: 0x0002BAC6
	public override void ProcessInput(Player input)
	{

	}

	// Token: 0x0600080E RID: 2062 RVA: 0x0002D8E9 File Offset: 0x0002BAE9
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x0600080F RID: 2063 RVA: 0x0002D8F4 File Offset: 0x0002BAF4
	public override void OnMountStartListening()
	{

	}

	// Token: 0x06000810 RID: 2064 RVA: 0x0002D980 File Offset: 0x0002BB80
	public override void OnMountStopListening()
	{

	}

	// Token: 0x06000811 RID: 2065 RVA: 0x0002D989 File Offset: 0x0002BB89
	public override bool CanMount()
	{

        return default;
    }

	// Token: 0x06000812 RID: 2066 RVA: 0x0002D991 File Offset: 0x0002BB91
	public override void OnMount()
	{

	}

	// Token: 0x06000813 RID: 2067 RVA: 0x0002D9BC File Offset: 0x0002BBBC
	public override void OnUnmount()
	{

	}

	// Token: 0x06000814 RID: 2068 RVA: 0x0002DBA4 File Offset: 0x0002BDA4
	public override void SimulateMountedPhysics()
	{

	}

	// Token: 0x06000815 RID: 2069 RVA: 0x0002DE1F File Offset: 0x0002C01F
	private void OnDestroy()
	{

	}

	// Token: 0x06000816 RID: 2070 RVA: 0x0002DE39 File Offset: 0x0002C039
	private static void ReplayTween(DOVisualSequence visualSequence)
	{

	}

	// Token: 0x06000817 RID: 2071 RVA: 0x0002DE50 File Offset: 0x0002C050
	public override void OnSensorTriggerEnter(Collider trigger)
	{

	}

	// Token: 0x06000818 RID: 2072 RVA: 0x0002DEB0 File Offset: 0x0002C0B0
	public override void OnSensorTriggerExit(Collider trigger)
	{

	}

	// Token: 0x04000766 RID: 1894
	public StudioEventEmitter FMODEmitterMount;

	// Token: 0x04000767 RID: 1895
	public StudioEventEmitter FMODEmitterUnmount;

	// Token: 0x04000768 RID: 1896
	public DOVisualSequence popInAnimation;

	// Token: 0x04000769 RID: 1897
	public DOVisualSequence popOutAnimation;

	// Token: 0x0400076A RID: 1898
	public float movingRange;

	// Token: 0x0400076B RID: 1899
	public float movingStep;

	// Token: 0x0400076C RID: 1900
	public float simulatedMotorDelta;

	// Token: 0x0400076D RID: 1901
	public float simulatedMaxSpeed;

	// Token: 0x0400076E RID: 1902
	private bool _isPlayerClose;

	// Token: 0x0400076F RID: 1903
	private bool _listenForMountInput;

	// Token: 0x04000770 RID: 1904
	private MountAgent _agent;

	// Token: 0x04000771 RID: 1905
	private Player _input;

	// Token: 0x04000772 RID: 1906
	private ArticulationDrive _leftArmDrive;

	// Token: 0x04000773 RID: 1907
	private ArticulationDrive _leftHandDrive;

	// Token: 0x04000774 RID: 1908
	private ArticulationDrive _rightArmDrive;

	// Token: 0x04000775 RID: 1909
	private ArticulationDrive _rightHandDrive;

	// Token: 0x04000776 RID: 1910
	private AgentProperty _leftArmPositionProperty;

	// Token: 0x04000777 RID: 1911
	private AgentProperty _leftHandPositionProperty;

	// Token: 0x04000778 RID: 1912
	private AgentProperty _rightArmPositionProperty;

	// Token: 0x04000779 RID: 1913
	private AgentProperty _rightHandPositionProperty;

	// Token: 0x0400077A RID: 1914
	private bool _otherSide;

	// Token: 0x0400077B RID: 1915
	private bool _moveFromKeyboardInput;
}
