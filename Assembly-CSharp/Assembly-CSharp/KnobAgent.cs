using System;
using Behavior;
using UnityEngine;

// Token: 0x02000096 RID: 150
public class KnobAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000757 RID: 1879 RVA: 0x0002A1A4 File Offset: 0x000283A4
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000758 RID: 1880 RVA: 0x0002A20C File Offset: 0x0002840C
	public override void OnDeviceStateChanged(Device.State state)
	{

	}

	// Token: 0x06000759 RID: 1881 RVA: 0x0002A218 File Offset: 0x00028418
	public override void OnTicksPostprocess()
	{

	}

	// Token: 0x0600075A RID: 1882 RVA: 0x0002A220 File Offset: 0x00028420
	private void ResetPreviousValues()
	{

	}

	// Token: 0x0600075B RID: 1883 RVA: 0x0002A276 File Offset: 0x00028476
	public override void PrepareForSketchFirstTick()
	{

	}

	// Token: 0x0600075C RID: 1884 RVA: 0x0002A27F File Offset: 0x0002847F
	public override void PrepareForSketchRetrigger()
	{

	}

	// Token: 0x0600075D RID: 1885 RVA: 0x0002A288 File Offset: 0x00028488
	[AgentPropertyHandler(1)]
	public void HandleCurrentStep(AgentProperty property)
	{

	}

	// Token: 0x0600075E RID: 1886 RVA: 0x0002A2D7 File Offset: 0x000284D7
	[AgentPropertyHandler(2)]
	public void HandleSteps(AgentProperty property)
	{

	}

	// Token: 0x0600075F RID: 1887 RVA: 0x0002A2E8 File Offset: 0x000284E8
	[AgentPropertyHandler(3)]
	public void HandleMode(AgentProperty property)
	{

	}

	// Token: 0x06000760 RID: 1888 RVA: 0x0002A330 File Offset: 0x00028530
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x06000761 RID: 1889 RVA: 0x0002A3CC File Offset: 0x000285CC
	public override FloatRange GetLimitsForProperty(int propertyId)
	{

        return default;
    }

	// Token: 0x040006BD RID: 1725
	private AgentProperty _currentAnalogValueProperty;

	// Token: 0x040006BE RID: 1726
	private AgentProperty _previousAnalogValueProperty;

	// Token: 0x040006BF RID: 1727
	private AgentProperty _currentStepValueProperty;

	// Token: 0x040006C0 RID: 1728
	private AgentProperty _previousStepValueProperty;

	// Token: 0x040006C1 RID: 1729
	private AgentProperty _stepsProperty;

	// Token: 0x040006C2 RID: 1730
	private bool _shouldConsumeInput;

	// Token: 0x02000365 RID: 869
	public enum Commands
	{
		// Token: 0x04001BF5 RID: 7157
		UpdateVisuals = 1,
		// Token: 0x04001BF6 RID: 7158
		SetLEDStripColor
	}

	// Token: 0x02000366 RID: 870
	public enum Mode
	{
		// Token: 0x04001BF8 RID: 7160
		Analog,
		// Token: 0x04001BF9 RID: 7161
		Stepped
	}
}
