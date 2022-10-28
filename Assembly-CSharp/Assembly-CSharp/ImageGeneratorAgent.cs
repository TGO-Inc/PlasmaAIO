using System;
using System.Collections.Generic;
using Behavior;
using UnityEngine;

// Token: 0x02000107 RID: 263
public class ImageGeneratorAgent : Agent
{
	// Token: 0x06000A76 RID: 2678 RVA: 0x00036C31 File Offset: 0x00034E31
	public static Dictionary<AssetController.ResourceTypes, int> GetResourcesDescription()
	{

        return default;
    }

	// Token: 0x06000A77 RID: 2679 RVA: 0x00036C40 File Offset: 0x00034E40
	public override void AllocResources()
	{

	}

	// Token: 0x06000A78 RID: 2680 RVA: 0x00036C78 File Offset: 0x00034E78
	public override void DeallocResources()
	{

	}

	// Token: 0x06000A79 RID: 2681 RVA: 0x00036C8A File Offset: 0x00034E8A
	public override List<KeyValuePair<int, int>> GetSerializableTexturesLabels()
	{

        return default;
    }

	// Token: 0x06000A7A RID: 2682 RVA: 0x00036CA3 File Offset: 0x00034EA3
	public override int GetTextureIndexForLabel(int label)
	{

        return default;
    }

	// Token: 0x06000A7B RID: 2683 RVA: 0x00036CAB File Offset: 0x00034EAB
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000A7C RID: 2684 RVA: 0x00036CE3 File Offset: 0x00034EE3
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000A7D RID: 2685 RVA: 0x00036D04 File Offset: 0x00034F04
	[AgentPropertyHandler(1)]
	public void HandleUseColor(AgentProperty property)
	{

	}

	// Token: 0x06000A7E RID: 2686 RVA: 0x00036D20 File Offset: 0x00034F20
	[SketchNodePortOperation(1)]
	public void Generate(SketchNode sketchNode)
	{

	}

	// Token: 0x0400097D RID: 2429
	private AgentProperty _imageProperty;

	// Token: 0x0400097E RID: 2430
	private AgentProperty _clearWithColorProperty;

	// Token: 0x0400097F RID: 2431
	private AgentProperty _colorProperty;

	// Token: 0x04000980 RID: 2432
	private int _imageTextureIndex;

	// Token: 0x04000981 RID: 2433
	private const int _imageTextureLabel = 1;
}
