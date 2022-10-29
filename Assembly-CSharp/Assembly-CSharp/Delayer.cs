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
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000052 RID: 82
public class Delayer : MonoBehaviour
{
	// Token: 0x060004D4 RID: 1236 RVA: 0x0001E6D4 File Offset: 0x0001C8D4
	public static Coroutine Frames(MonoBehaviour _crExecutor, int _frames, Action _onWaitDone)
	{

        return default;
    }

	// Token: 0x060004D5 RID: 1237 RVA: 0x0001E724 File Offset: 0x0001C924
	public static Coroutine Seconds(MonoBehaviour _crExecutor, float _seconds, Action _onWaitDone)
	{

        return default;
    }

	// Token: 0x060004D6 RID: 1238 RVA: 0x0001E774 File Offset: 0x0001C974
	public static Coroutine LerpFloat(MonoBehaviour _crExecutor, float _from, float _to, float _time, Action<float> _onValueChange = null, Action _onComplete = null)
	{

        return default;
    }

	// Token: 0x060004D7 RID: 1239 RVA: 0x0001E827 File Offset: 0x0001CA27
	private static IEnumerator CR_WaitFrames(int _frames, Action _onWaitDone, GameObject _goToDestroy)
	{

        return default;
    }

	// Token: 0x060004D8 RID: 1240 RVA: 0x0001E844 File Offset: 0x0001CA44
	private static IEnumerator CR_WaitSeconds(float _seconds, Action _onWaitDone, GameObject _goToDestroy)
	{

        return default;
    }

	// Token: 0x060004D9 RID: 1241 RVA: 0x0001E861 File Offset: 0x0001CA61
	private static IEnumerator CR_LerpFloat(float _from, float _to, float _timeTotal, Action<float> _onValueChange, Action _onComplete, GameObject _goToDestroy)
	{

        return default;
    }

	// Token: 0x04000478 RID: 1144
	public static AnimationCurve curveEaseInOut = AnimationCurve.EaseInOut(0f, 0f, 1f, 1f);
}
}