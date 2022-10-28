using System;
using System.Collections.Generic;
using Behavior;
using Rewired;
using UnityEngine;

// Token: 0x02000084 RID: 132
public class GamepadInterfaceAgent : Agent, IDataSelectionProvider
{
	// Token: 0x060006C3 RID: 1731 RVA: 0x00026CB0 File Offset: 0x00024EB0
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x00026D29 File Offset: 0x00024F29
	protected override void OnBeforeCopyConfiguredToRuntimeProperties()
	{

	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x00026D34 File Offset: 0x00024F34
	public override void OnComponentSpawned()
	{

	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x00026D9B File Offset: 0x00024F9B
	public override void OnDeviceStateChanged(Device.State state)
	{

	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00026DA8 File Offset: 0x00024FA8
	private void ValidateGamepad(bool applyToRuntime)
	{

	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x00026E27 File Offset: 0x00025027
	public override void OnTicksPostprocess()
	{

	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x00026E3C File Offset: 0x0002503C
	public static Dictionary<int, string> GetDynamicOptions()
	{

        return default;
    }

	// Token: 0x060006CA RID: 1738 RVA: 0x00026E8D File Offset: 0x0002508D
	public static string GetDynamicOption(int id)
	{

        return default;
    }

	// Token: 0x060006CB RID: 1739 RVA: 0x00026E9A File Offset: 0x0002509A
	public override void ValidateSelectionForProperty(int id)
	{

	}

	// Token: 0x060006CC RID: 1740 RVA: 0x00026EA7 File Offset: 0x000250A7
	[AgentPropertyHandler(1)]
	public void HandleGamepad(AgentProperty property)
	{

	}

	// Token: 0x060006CD RID: 1741 RVA: 0x00026ECB File Offset: 0x000250CB
	public override void PrepareForSketchFirstTick()
	{

	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00026ED4 File Offset: 0x000250D4
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x04000620 RID: 1568
	public Dictionary<GamepadInterfacePropertyEnum, KeyValuePair<float, float>> axisValues;

	// Token: 0x04000621 RID: 1569
	public Dictionary<GamepadInterfacePropertyEnum, KeyValuePair<bool, bool>> buttonValues;

	// Token: 0x04000622 RID: 1570
	public Dictionary<GamepadInterfacePropertyEnum, KeyValuePair<bool, bool>> specialButtonValues;

	// Token: 0x04000623 RID: 1571
	private AgentProperty _gamepadProperty;

	// Token: 0x04000624 RID: 1572
	private AgentProperty _continuousAxisOutputProperty;

	// Token: 0x04000625 RID: 1573
	private AgentProperty _continuousButtonOutputProperty;

	// Token: 0x04000626 RID: 1574
	private AgentProperty _isConnectedProperty;

	// Token: 0x04000627 RID: 1575
	private bool _wasConnected;

	// Token: 0x04000628 RID: 1576
	private bool _shouldConsumeInput;
}
