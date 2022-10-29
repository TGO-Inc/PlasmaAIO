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
// Token: 0x020000CA RID: 202
public class SerialPortAgent : Agent
{
	// Token: 0x06000905 RID: 2309 RVA: 0x00031778 File Offset: 0x0002F978
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000906 RID: 2310 RVA: 0x00031794 File Offset: 0x0002F994
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x06000907 RID: 2311 RVA: 0x000317BA File Offset: 0x0002F9BA
	[SketchNodePortOperation(1)]
	public void Open(SketchNode sketchNode)
	{

	}

	// Token: 0x06000908 RID: 2312 RVA: 0x000317C3 File Offset: 0x0002F9C3
	[SketchNodePortOperation(2)]
	public void Close(SketchNode sketchNode)
	{

	}

	// Token: 0x06000909 RID: 2313 RVA: 0x000317CC File Offset: 0x0002F9CC
	[SketchNodePortOperation(3)]
	public void Send(SketchNode sketchNode)
	{

	}

	// Token: 0x04000856 RID: 2134
	private AgentProperty _propertyReceiveBuffer;

	// Token: 0x04000857 RID: 2135
	private AgentProperty _propertyHasReceivedData;

	// Token: 0x02000388 RID: 904
	public enum Commands
	{
		// Token: 0x04001C5C RID: 7260
		Open = 1,
		// Token: 0x04001C5D RID: 7261
		Close,
		// Token: 0x04001C5E RID: 7262
		Send
	}
}
}