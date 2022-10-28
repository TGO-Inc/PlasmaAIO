using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass {
// Token: 0x0200006D RID: 109
public class DirectionalIndicatorDriver : ComponentDriver
{
	// Token: 0x06000611 RID: 1553 RVA: 0x000230B8 File Offset: 0x000212B8
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000612 RID: 1554 RVA: 0x000231AC File Offset: 0x000213AC
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000613 RID: 1555 RVA: 0x000231B4 File Offset: 0x000213B4
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000614 RID: 1556 RVA: 0x000231BC File Offset: 0x000213BC
	private void CommonSetup()
	{

	}

	// Token: 0x06000615 RID: 1557 RVA: 0x00023228 File Offset: 0x00021428
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000616 RID: 1558 RVA: 0x00023330 File Offset: 0x00021530
	public static float GetDifference(float current, float target)
	{

        return default;
    }

	// Token: 0x06000617 RID: 1559 RVA: 0x0002335C File Offset: 0x0002155C
	private float CalculateCurrentDirection()
	{

        return default;
    }

	// Token: 0x06000618 RID: 1560 RVA: 0x000233C0 File Offset: 0x000215C0
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x06000619 RID: 1561 RVA: 0x00023408 File Offset: 0x00021608
	private void RenderContent()
	{

	}

	// Token: 0x0400054B RID: 1355
	public MeshRenderer imageMeshRenderer;

	// Token: 0x0400054C RID: 1356
	public Camera theCamera;

	// Token: 0x0400054D RID: 1357
	public Image compass;

	// Token: 0x0400054E RID: 1358
	public Image arrow;

	// Token: 0x0400054F RID: 1359
	private DirectionalIndicatorAgent _directionalIndicatorAgent;

	// Token: 0x04000550 RID: 1360
	private AgentProperty _stateProperty;

	// Token: 0x04000551 RID: 1361
	private AgentProperty _currentDirectionProperty;

	// Token: 0x04000552 RID: 1362
	private AgentProperty _targetDirectionProperty;

	// Token: 0x04000553 RID: 1363
	private AgentProperty _differenceProperty;

	// Token: 0x04000554 RID: 1364
	private AgentProperty _compassColorProperty;

	// Token: 0x04000555 RID: 1365
	private AgentProperty _arrowColorProperty;

	// Token: 0x04000556 RID: 1366
	private AgentProperty _backgroundColorProperty;

	// Token: 0x04000557 RID: 1367
	private AgentProperty _compassProperty;
}
}