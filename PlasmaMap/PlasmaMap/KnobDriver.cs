using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using FMODUnity;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000097 RID: 151
public class KnobDriver : ComponentDriver
{
	// Token: 0x06000763 RID: 1891 RVA: 0x0002A3F8 File Offset: 0x000285F8
	public override void Awake()
	{

	}

	// Token: 0x06000764 RID: 1892 RVA: 0x0002A41C File Offset: 0x0002861C
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000765 RID: 1893 RVA: 0x0002A484 File Offset: 0x00028684
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000766 RID: 1894 RVA: 0x0002A4E0 File Offset: 0x000286E0
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000767 RID: 1895 RVA: 0x0002A530 File Offset: 0x00028730
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000768 RID: 1896 RVA: 0x0002A58A File Offset: 0x0002878A
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x06000769 RID: 1897 RVA: 0x0002A5B4 File Offset: 0x000287B4
	public override bool CanInteractWithRaycast(Ray ray)
	{

        return default;
    }

	// Token: 0x0600076A RID: 1898 RVA: 0x0002A5B8 File Offset: 0x000287B8
	public override void OnInteractionDown(Ray ray)
	{

	}

	// Token: 0x0600076B RID: 1899 RVA: 0x0002A640 File Offset: 0x00028840
	public override void OnInteractionHold(Camera theCamera, Vector2 movement)
	{

	}

	// Token: 0x0600076C RID: 1900 RVA: 0x0002A796 File Offset: 0x00028996
	public override void OnInteractionUp()
	{

	}

	// Token: 0x0600076D RID: 1901 RVA: 0x0002A7B8 File Offset: 0x000289B8
	private void UpdateVisuals()
	{

	}

	// Token: 0x0600076E RID: 1902 RVA: 0x0002A853 File Offset: 0x00028A53
	private void SetLEDStripColor()
	{

	}

	// Token: 0x040006C3 RID: 1731
	public MeshRenderer meshRenderer;

	// Token: 0x040006C4 RID: 1732
	public GameObject rotatingGameObject;

	// Token: 0x040006C5 RID: 1733
	public StudioEventEmitter FMODEmitterAnalog;

	// Token: 0x040006C6 RID: 1734
	public StudioEventEmitter FMODEmitterStepped;

	// Token: 0x040006C7 RID: 1735
	public float knobSpeed;

	// Token: 0x040006C8 RID: 1736
	private AgentProperty _currentAnalogValueProperty;

	// Token: 0x040006C9 RID: 1737
	private AgentProperty _currentStepValueProperty;

	// Token: 0x040006CA RID: 1738
	private AgentProperty _stepsProperty;

	// Token: 0x040006CB RID: 1739
	private AgentProperty _modeProperty;

	// Token: 0x040006CC RID: 1740
	private AgentProperty _LEDStripColorProperty;

	// Token: 0x040006CD RID: 1741
	private float _currentAnalogValue;

	// Token: 0x040006CE RID: 1742
	private int _currentStepValue;

	// Token: 0x040006CF RID: 1743
	private float _currentStepPosition;

	// Token: 0x040006D0 RID: 1744
	private int _steps;

	// Token: 0x040006D1 RID: 1745
	private float _lastAnalogPosition;

	// Token: 0x040006D2 RID: 1746
	private int _lastStepPosition;

	// Token: 0x040006D3 RID: 1747
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x040006D4 RID: 1748
	private int _colorId;

	// Token: 0x040006D5 RID: 1749
	private float _lastAnalogDiff;

	// Token: 0x040006D6 RID: 1750
	private const float _maxRotationRange = 270f;

	// Token: 0x040006D7 RID: 1751
	private const string _FMODParamSize = "Size";

	// Token: 0x040006D8 RID: 1752
	private const string _FMODParamMovementSpeed = "MovmentSpeed";
}
}