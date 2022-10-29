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
// Token: 0x020000B8 RID: 184
public class PlasmaTogglerDriver : ComponentDriver
{
	// Token: 0x0600086E RID: 2158 RVA: 0x0002F0A5 File Offset: 0x0002D2A5
	public override void Awake()
	{

	}

	// Token: 0x0600086F RID: 2159 RVA: 0x0002F0C6 File Offset: 0x0002D2C6
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000870 RID: 2160 RVA: 0x0002F0EA File Offset: 0x0002D2EA
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000871 RID: 2161 RVA: 0x0002F0F8 File Offset: 0x0002D2F8
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000872 RID: 2162 RVA: 0x0002F268 File Offset: 0x0002D468
	private void SetEffectEnabled(bool value)
	{

	}

	// Token: 0x06000873 RID: 2163 RVA: 0x0002F2DD File Offset: 0x0002D4DD
	private IEnumerator UpdateEffect()
	{

        return default;
    }

	// Token: 0x040007CA RID: 1994
	public StudioEventEmitter FMODEmitterState;

	// Token: 0x040007CB RID: 1995
	public StudioEventEmitter FMODEmitterInteract;

	// Token: 0x040007CC RID: 1996
	public float maxLength;

	// Token: 0x040007CD RID: 1997
	public float globalProgressSpeed;

	// Token: 0x040007CE RID: 1998
	public float globalImpactProgressSpeed;

	// Token: 0x040007CF RID: 1999
	public bool colorizeAll;

	// Token: 0x040007D0 RID: 2000
	public Color finalColor;

	// Token: 0x040007D1 RID: 2001
	public StartPointEffectControllerV3D startPointEffect;

	// Token: 0x040007D2 RID: 2002
	public EndPointEffectControllerV3D endPointEffect;

	// Token: 0x040007D3 RID: 2003
	public GameObject laserGameObject;

	// Token: 0x040007D4 RID: 2004
	public LaserLineV3D[] laserLines;

	// Token: 0x040007D5 RID: 2005
	public LightLineV3D[] lightLines;

	// Token: 0x040007D6 RID: 2006
	private Renderer[] renderers;

	// Token: 0x040007D7 RID: 2007
	private float _globalProgress;

	// Token: 0x040007D8 RID: 2008
	private float _globalImpactProgress;

	// Token: 0x040007D9 RID: 2009
	private Coroutine _coroutine;

	// Token: 0x040007DA RID: 2010
	private float _lastTime;

	// Token: 0x040007DB RID: 2011
	private const float _cooldown = 1f;
}
}