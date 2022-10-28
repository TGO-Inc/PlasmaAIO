using System;
using System.Collections.Generic;
using Behavior;
using UnityEngine;

// Token: 0x0200006E RID: 110
public class DisplayCommonnAgent : Agent, IDataSelectionProvider
{
	// Token: 0x17000070 RID: 112
	// (get) Token: 0x0600061B RID: 1563 RVA: 0x000234BA File Offset: 0x000216BA
	// (set) Token: 0x0600061C RID: 1564 RVA: 0x000234C2 File Offset: 0x000216C2
	public RenderTexture renderTexture { get; private set; }

	// Token: 0x0600061D RID: 1565 RVA: 0x000234CB File Offset: 0x000216CB
	public static Dictionary<AssetController.ResourceTypes, int> GetResourcesDescription()
	{

        return default;
    }

	// Token: 0x0600061E RID: 1566 RVA: 0x000234DC File Offset: 0x000216DC
	public override void AllocResources()
	{

	}

	// Token: 0x0600061F RID: 1567 RVA: 0x00023575 File Offset: 0x00021775
	public override void DeallocResources()
	{

	}

	// Token: 0x06000620 RID: 1568 RVA: 0x00023597 File Offset: 0x00021797
	public override List<KeyValuePair<int, int>> GetSerializableTexturesLabels()
	{

        return default;
    }

	// Token: 0x06000621 RID: 1569 RVA: 0x000235B0 File Offset: 0x000217B0
	public override int GetTextureIndexForLabel(int label)
	{

        return default;
    }

	// Token: 0x06000622 RID: 1570 RVA: 0x000235BE File Offset: 0x000217BE
	[AgentPropertyHandler(2)]
	public void HandleAutosize(AgentProperty property)
	{

	}

	// Token: 0x04000558 RID: 1368
	public int renderTextureIndex;

	// Token: 0x04000559 RID: 1369
	public int contentPropertyId;

	// Token: 0x0400055A RID: 1370
	public int statePropertyId;

	// Token: 0x0400055B RID: 1371
	public int backgroundColorPropertyId;

	// Token: 0x0400055C RID: 1372
	public int foregroundColorPropertyId;

	// Token: 0x0400055D RID: 1373
	public int autosizePropertyId;

	// Token: 0x0400055E RID: 1374
	public int fontSizePropertyId;

	// Token: 0x0400055F RID: 1375
	public int horizontalAlignmentPropertyId;

	// Token: 0x04000560 RID: 1376
	public int verticalAlignmentPropertyId;

	// Token: 0x04000561 RID: 1377
	public int decimalDigitsPropertyId;

	// Token: 0x04000562 RID: 1378
	public string infoName;

	// Token: 0x04000563 RID: 1379
	private int _bufferTextureIndex;

	// Token: 0x04000564 RID: 1380
	private const int _bufferTextureLabel = 1;

	// Token: 0x02000354 RID: 852
	public enum Commands
	{
		// Token: 0x04001BB6 RID: 7094
		SetState = 1,
		// Token: 0x04001BB7 RID: 7095
		SetBackgroundColor,
		// Token: 0x04001BB8 RID: 7096
		SetForegroundColor,
		// Token: 0x04001BB9 RID: 7097
		UpdateVisuals,
		// Token: 0x04001BBA RID: 7098
		SetFont,
		// Token: 0x04001BBB RID: 7099
		SetAlignment
	}
}
