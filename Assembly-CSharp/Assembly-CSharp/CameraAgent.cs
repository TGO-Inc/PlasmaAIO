using System;
using System.Collections.Generic;
using Behavior;

// Token: 0x02000060 RID: 96
public class CameraAgent : Agent
{
	// Token: 0x060005BC RID: 1468 RVA: 0x00021A96 File Offset: 0x0001FC96
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060005BD RID: 1469 RVA: 0x00021AAA File Offset: 0x0001FCAA
	public static Dictionary<AssetController.ResourceTypes, int> GetResourcesDescription()
	{

        return default;
    }

	// Token: 0x060005BE RID: 1470 RVA: 0x00021ABC File Offset: 0x0001FCBC
	public override void AllocResources()
	{

	}

	// Token: 0x060005BF RID: 1471 RVA: 0x00021B6E File Offset: 0x0001FD6E
	public override void DeallocResources()
	{

	}

	// Token: 0x060005C0 RID: 1472 RVA: 0x00021B9A File Offset: 0x0001FD9A
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x060005C1 RID: 1473 RVA: 0x00021BD5 File Offset: 0x0001FDD5
	[SketchNodePortOperation(1)]
	public void TakePicture(SketchNode sketchNode)
	{

	}

	// Token: 0x04000500 RID: 1280
	public Data.Image feedData;

	// Token: 0x04000501 RID: 1281
	public Data.Image pictureData;

	// Token: 0x04000502 RID: 1282
	private AgentProperty _stateProperty;

	// Token: 0x0200034D RID: 845
	public enum Commands
	{
		// Token: 0x04001B97 RID: 7063
		SetState = 1,
		// Token: 0x04001B98 RID: 7064
		RenderFeed,
		// Token: 0x04001B99 RID: 7065
		TakePicture,
		// Token: 0x04001B9A RID: 7066
		SetFOV,
		// Token: 0x04001B9B RID: 7067
		SetViewDistance
	}
}
