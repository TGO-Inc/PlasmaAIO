using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200009D RID: 157
public class LateralExtenderDriver : ComponentDriver
{
	// Token: 0x1700007A RID: 122
	// (get) Token: 0x0600078F RID: 1935 RVA: 0x0002ADFC File Offset: 0x00028FFC
	private ArticulationBody extender
	{
		get
		{
			return this._component.GetSubComponent(1).articulationBody;
		}
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x0002AE10 File Offset: 0x00029010
	public override void Awake()
	{

	}

	// Token: 0x06000791 RID: 1937 RVA: 0x0002AE8D File Offset: 0x0002908D
	private void HandleOnGamePaused()
	{

	}

	// Token: 0x06000792 RID: 1938 RVA: 0x0002AE9A File Offset: 0x0002909A
	private void HandleOnGameResumed()
	{

	}

	// Token: 0x06000793 RID: 1939 RVA: 0x0002AEA8 File Offset: 0x000290A8
	public float ConvertFrom01(float position)
	{

        return default;
    }

	// Token: 0x06000794 RID: 1940 RVA: 0x0002AED8 File Offset: 0x000290D8
	private float ConvertTo01(float position)
	{

        return default;
    }

	// Token: 0x06000795 RID: 1941 RVA: 0x0002AEF4 File Offset: 0x000290F4
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000796 RID: 1942 RVA: 0x0002AF4C File Offset: 0x0002914C
	private void SetPhysics()
	{

	}

	// Token: 0x06000797 RID: 1943 RVA: 0x0002B05B File Offset: 0x0002925B
	public override void OnReset()
	{

	}

	// Token: 0x06000798 RID: 1944 RVA: 0x0002B063 File Offset: 0x00029263
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000799 RID: 1945 RVA: 0x0002B078 File Offset: 0x00029278
	public override void OnSolidEnter()
	{

	}

	// Token: 0x0600079A RID: 1946 RVA: 0x0002B0B8 File Offset: 0x000292B8
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x0600079B RID: 1947 RVA: 0x0002B0E0 File Offset: 0x000292E0
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x0600079C RID: 1948 RVA: 0x0002B1D8 File Offset: 0x000293D8
	public override void SimulateMountedPhysics()
	{

	}

	// Token: 0x0600079D RID: 1949 RVA: 0x0002B285 File Offset: 0x00029485
	public override void OnScaleChanged()
	{

	}

	// Token: 0x0600079E RID: 1950 RVA: 0x0002B294 File Offset: 0x00029494
	private IEnumerator DelayedUpdateVisuals()
	{

        return default;
    }

	// Token: 0x0600079F RID: 1951 RVA: 0x0002B2A4 File Offset: 0x000294A4
	private void UpdateVisuals()
	{

	}

	// Token: 0x060007A0 RID: 1952 RVA: 0x0002B504 File Offset: 0x00029704
	public override string GetRealValueStringForProperty(int propertyId, float value)
	{

        return default;
    }

	// Token: 0x060007A1 RID: 1953 RVA: 0x0002B51A File Offset: 0x0002971A
	public override float GetLimit(bool unscale = false)
	{

        return default;
    }

	// Token: 0x060007A2 RID: 1954 RVA: 0x0002B53B File Offset: 0x0002973B
	private void OnDestroy()
	{

	}

	// Token: 0x040006EF RID: 1775
	public StudioEventEmitter FMODEmitter;

	// Token: 0x040006F0 RID: 1776
	public Transform beam1;

	// Token: 0x040006F1 RID: 1777
	public Transform beam2;

	// Token: 0x040006F2 RID: 1778
	public Transform caps;

	// Token: 0x040006F3 RID: 1779
	public float maxMotorSpeed;

	// Token: 0x040006F4 RID: 1780
	public float maxMotorForce;

	// Token: 0x040006F5 RID: 1781
	public PIDController positionPidController;

	// Token: 0x040006F6 RID: 1782
	public MeshRenderer capsRenderer;

	// Token: 0x040006F7 RID: 1783
	public MeshRenderer masterRenderer;

	// Token: 0x040006F8 RID: 1784
	public float simulatedMotorDelta;

	// Token: 0x040006F9 RID: 1785
	public float simulatedMaxMotorSpeed;

	// Token: 0x040006FA RID: 1786
	private AgentProperty _targetPositionProperty;

	// Token: 0x040006FB RID: 1787
	private AgentProperty _forceProperty;

	// Token: 0x040006FC RID: 1788
	private AgentProperty _maxSpeedProperty;

	// Token: 0x040006FD RID: 1789
	private AgentProperty _currentPositionProperty;

	// Token: 0x040006FE RID: 1790
	private ArticulationDrive _articulationDrive;

	// Token: 0x040006FF RID: 1791
	private Transform _beamsParent;

	// Token: 0x04000700 RID: 1792
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x04000701 RID: 1793
	private int _colorId1;

	// Token: 0x04000702 RID: 1794
	private int _colorId2;

	// Token: 0x04000703 RID: 1795
	private const float _extension = 0.115f;

	// Token: 0x04000704 RID: 1796
	private const string _FMODParamSpeed = "Speed";

	// Token: 0x04000705 RID: 1797
	private const string _FMODParamSize = "Size";
}
}