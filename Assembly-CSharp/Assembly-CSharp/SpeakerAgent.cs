using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using Behavior;

namespace PlasmaAPI.GameClass {
// Token: 0x020000D6 RID: 214
public class SpeakerAgent : Agent
{
	// Token: 0x0600095E RID: 2398 RVA: 0x00032A3A File Offset: 0x00030C3A
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x0600095F RID: 2399 RVA: 0x00032A60 File Offset: 0x00030C60
	protected override void OnDriverSet()
	{

	}

	// Token: 0x06000960 RID: 2400 RVA: 0x00032A73 File Offset: 0x00030C73
	public override void OnDeviceResetFinished()
	{

	}

	// Token: 0x06000961 RID: 2401 RVA: 0x00032A84 File Offset: 0x00030C84
	public override void OnDeviceStateChanged(Device.State state)
	{

	}

	// Token: 0x06000962 RID: 2402 RVA: 0x00032AFD File Offset: 0x00030CFD
	[AgentPropertyHandler(1)]
	public void HandleSound(AgentProperty agentProperty)
	{

	}

	// Token: 0x06000963 RID: 2403 RVA: 0x00032B20 File Offset: 0x00030D20
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x06000964 RID: 2404 RVA: 0x00032B58 File Offset: 0x00030D58
	[SketchNodePortOperation(1)]
	public void Play(SketchNode sketchNode)
	{

	}

	// Token: 0x06000965 RID: 2405 RVA: 0x00032BB1 File Offset: 0x00030DB1
	[SketchNodePortOperation(2)]
	public void Pause(SketchNode sketchNode)
	{

	}

	// Token: 0x06000966 RID: 2406 RVA: 0x00032BDB File Offset: 0x00030DDB
	[SketchNodePortOperation(3)]
	public void Stop(SketchNode sketchNode)
	{

	}

	// Token: 0x040008A5 RID: 2213
	private SpeakerDriver _speakerDriver;

	// Token: 0x040008A6 RID: 2214
	private AgentProperty _stateProperty;

	// Token: 0x040008A7 RID: 2215
	private AgentProperty _soundProperty;

	// Token: 0x0200038F RID: 911
	public enum Commands
	{
		// Token: 0x04001C72 RID: 7282
		SetVolume = 1,
		// Token: 0x04001C73 RID: 7283
		Stop,
		// Token: 0x04001C74 RID: 7284
		Play,
		// Token: 0x04001C75 RID: 7285
		Pause,
		// Token: 0x04001C76 RID: 7286
		Unpause,
		// Token: 0x04001C77 RID: 7287
		PlayFromPosition,
		// Token: 0x04001C78 RID: 7288
		SetLoop
	}

	// Token: 0x02000390 RID: 912
	public enum States
	{
		// Token: 0x04001C7A RID: 7290
		Stopped,
		// Token: 0x04001C7B RID: 7291
		Playing,
		// Token: 0x04001C7C RID: 7292
		Paused,
		// Token: 0x04001C7D RID: 7293
		Finished,
		// Token: 0x04001C7E RID: 7294
		WireframePaused
	}
}
}