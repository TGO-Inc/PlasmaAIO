using System;
using Behavior;

// Token: 0x02000062 RID: 98
public class CameraMasterAgent : Agent
{
	// Token: 0x060005CC RID: 1484 RVA: 0x00021E50 File Offset: 0x00020050
	[SketchNodePortOperation(1)]
	public void Take(SketchNode sketchNode)
	{

	}

	// Token: 0x060005CD RID: 1485 RVA: 0x00021E59 File Offset: 0x00020059
	[SketchNodePortOperation(2)]
	public void Release(SketchNode sketchNode)
	{

	}

	// Token: 0x060005CE RID: 1486 RVA: 0x00021E62 File Offset: 0x00020062
	[SketchNodePortOperation(3)]
	public void ToggleUI(SketchNode sketchNode)
	{

	}

	// Token: 0x060005CF RID: 1487 RVA: 0x00021E6B File Offset: 0x0002006B
	[SketchNodePortOperation(4)]
	public void StartAutobuild(SketchNode sketchNode)
	{

	}

	// Token: 0x0200034F RID: 847
	public enum Commands
	{
		// Token: 0x04001BA0 RID: 7072
		Take = 1,
		// Token: 0x04001BA1 RID: 7073
		Release,
		// Token: 0x04001BA2 RID: 7074
		ToggleUI,
		// Token: 0x04001BA3 RID: 7075
		SetFOV,
		// Token: 0x04001BA4 RID: 7076
		StartAutobuild
	}
}
