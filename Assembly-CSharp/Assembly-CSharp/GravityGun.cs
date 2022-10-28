using System;
using FMODUnity;
using Rewired;
using UnityEngine;

// Token: 0x02000172 RID: 370
public class GravityGun : MonoBehaviour
{
	// Token: 0x06000E2F RID: 3631 RVA: 0x00048245 File Offset: 0x00046445
	private void Awake()
	{

	}

	// Token: 0x06000E30 RID: 3632 RVA: 0x00048260 File Offset: 0x00046460
	public void StartGravityGun(Camera theCamera, SubComponentHandler target)
	{

	}

	// Token: 0x06000E31 RID: 3633 RVA: 0x00048448 File Offset: 0x00046648
	public void StartGravityGun(Camera theCamera, Rigidbody body)
	{

	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x00048544 File Offset: 0x00046744
	public void UpdateGravityGunEmitterPosition(Vector3 position)
	{

	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x00048564 File Offset: 0x00046764
	public void StartSound()
	{

	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x00048587 File Offset: 0x00046787
	public void StopSound()
	{

	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x00048594 File Offset: 0x00046794
	public void UpdateGravityGunTargetPosition(Quaternion cameraViewOffset, float cameraDistance)
	{

	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x0004860C File Offset: 0x0004680C
	public void ProcessUserInput(Player input)
	{

	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x000486F8 File Offset: 0x000468F8
	public void Tick()
	{

	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x00048954 File Offset: 0x00046B54
	private Vector3 CalculatePositionForce(Vector3 objectPosition)
	{

        return default;
    }

	// Token: 0x06000E39 RID: 3641 RVA: 0x0004899C File Offset: 0x00046B9C
	private Vector3 CalculateTorqueForce(Vector3 angularVelocity, Vector3 inertiaTensor)
	{

        return default;
    }

	// Token: 0x06000E3A RID: 3642 RVA: 0x000489DC File Offset: 0x00046BDC
	public void EndGravityGun(bool throwObject = false)
	{

	}

	// Token: 0x06000E3B RID: 3643 RVA: 0x00048B55 File Offset: 0x00046D55
	public void DeviceBeingTeleported(Device device)
	{

	}

	// Token: 0x04000BAB RID: 2987
	public float forceMultiplierKg;

	// Token: 0x04000BAC RID: 2988
	public float maxForceKg;

	// Token: 0x04000BAD RID: 2989
	public float maxForceAbsolute;

	// Token: 0x04000BAE RID: 2990
	public float maxVelocity;

	// Token: 0x04000BAF RID: 2991
	public float velocityMultiplier;

	// Token: 0x04000BB0 RID: 2992
	public float angularDamping;

	// Token: 0x04000BB1 RID: 2993
	public float torqueMultiplier;

	// Token: 0x04000BB2 RID: 2994
	public StudioEventEmitter FMODEmitter;

	// Token: 0x04000BB3 RID: 2995
	public float defaultLinearDamping;

	// Token: 0x04000BB4 RID: 2996
	public float grabbedLinearDamping;

	// Token: 0x04000BB5 RID: 2997
	public float maxThrowForce;

	// Token: 0x04000BB6 RID: 2998
	public float maxThrowRadialDuration;

	// Token: 0x04000BB7 RID: 2999
	public float maxThrowChargeDistance;

	// Token: 0x04000BB8 RID: 3000
	public PIDController positionPidController;

	// Token: 0x04000BB9 RID: 3001
	public PIDController torquePidController;

	// Token: 0x04000BBA RID: 3002
	private Camera _camera;

	// Token: 0x04000BBB RID: 3003
	private ArticulationBody _articulationBody;

	// Token: 0x04000BBC RID: 3004
	private Rigidbody _rigidbody;

	// Token: 0x04000BBD RID: 3005
	private Quaternion _cameraOffset;

	// Token: 0x04000BBE RID: 3006
	private Vector3 _targetPosition;

	// Token: 0x04000BBF RID: 3007
	private float _savedAngularDamping;

	// Token: 0x04000BC0 RID: 3008
	private float _savedLinearDamping;

	// Token: 0x04000BC1 RID: 3009
	private float _forceMultiplier;

	// Token: 0x04000BC2 RID: 3010
	private float _torqueMultiplier;

	// Token: 0x04000BC3 RID: 3011
	private float _totalMass;

	// Token: 0x04000BC4 RID: 3012
	private bool _correctRotation;

	// Token: 0x04000BC5 RID: 3013
	private FollowTargetOnUpdate _emitterFollower;

	// Token: 0x04000BC6 RID: 3014
	private Device _targetDevice;

	// Token: 0x04000BC7 RID: 3015
	private float _throwDelta;

	// Token: 0x04000BC8 RID: 3016
	private const string _FMODParamForce = "Force";

	// Token: 0x04000BC9 RID: 3017
	private const string _FMODParamStop = "Stop";

	// Token: 0x04000BCA RID: 3018
	private const string _FMODParamResistance = "Resistance";

	// Token: 0x04000BCB RID: 3019
	private const string _FMODParamThrow = "Throw";
}
