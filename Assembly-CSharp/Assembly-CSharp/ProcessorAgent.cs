using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using Behavior;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x020000BD RID: 189
public class ProcessorAgent : Agent
{
	// Token: 0x17000087 RID: 135
	// (get) Token: 0x0600089C RID: 2204 RVA: 0x0002FBE3 File Offset: 0x0002DDE3
	// (set) Token: 0x0600089D RID: 2205 RVA: 0x0002FBEB File Offset: 0x0002DDEB
	public Sketch sketch { get; private set; }

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x0600089E RID: 2206 RVA: 0x0002FBF4 File Offset: 0x0002DDF4
	// (set) Token: 0x0600089F RID: 2207 RVA: 0x0002FBFC File Offset: 0x0002DDFC
	public VariablesContainerAgent variablesAgent { get; private set; }

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0002FC05 File Offset: 0x0002DE05
	// (set) Token: 0x060008A1 RID: 2209 RVA: 0x0002FC0D File Offset: 0x0002DE0D
	public ProcessorAgent.SketchMetaData sketchMetaData { get; private set; }

	// Token: 0x060008A2 RID: 2210 RVA: 0x0002FC18 File Offset: 0x0002DE18
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x060008A3 RID: 2211 RVA: 0x0002FCD8 File Offset: 0x0002DED8
	public override void OnComponentSpawned()
	{

	}

	// Token: 0x060008A4 RID: 2212 RVA: 0x0002FD24 File Offset: 0x0002DF24
	[AgentPropertyHandler(1)]
	public void HandleState(AgentProperty property)
	{

	}

	// Token: 0x060008A5 RID: 2213 RVA: 0x0002FD3C File Offset: 0x0002DF3C
	private void HandleSketchNotification(SketchNotifications.Notification notification)
	{

	}

	// Token: 0x060008A6 RID: 2214 RVA: 0x0002FD7B File Offset: 0x0002DF7B
	public override void OnAgentsChangedIdsDuringMove(List<AgentId> oldAgentIDs, List<AgentId> newAgentIDs)
	{

	}

	// Token: 0x060008A7 RID: 2215 RVA: 0x0002FD8A File Offset: 0x0002DF8A
	public override void OnLateWorldTickUpdate(bool firstStep)
	{

	}

	// Token: 0x060008A8 RID: 2216 RVA: 0x0002FDB3 File Offset: 0x0002DFB3
	public override void OnAgentsChanged()
	{

	}

	// Token: 0x060008A9 RID: 2217 RVA: 0x0002FDCC File Offset: 0x0002DFCC
	public override IEnumerable<Agent> GetDependentAgents()
	{

        return default;
    }

	// Token: 0x060008AA RID: 2218 RVA: 0x0002FE4C File Offset: 0x0002E04C
	public override void OnDeviceStateChanged(Device.State state)
	{

	}

	// Token: 0x060008AB RID: 2219 RVA: 0x0002FF02 File Offset: 0x0002E102
	public override void OnComponentDetachedDuringSimulation(AgentId theAgentId)
	{

	}

	// Token: 0x060008AC RID: 2220 RVA: 0x0002FF1E File Offset: 0x0002E11E
	public override void OnDeviceReset()
	{

	}

	// Token: 0x060008AD RID: 2221 RVA: 0x0002FF58 File Offset: 0x0002E158
	public override void OnDeviceResetFinished()
	{

	}

	// Token: 0x060008AE RID: 2222 RVA: 0x0002FF65 File Offset: 0x0002E165
	public override void OnDeviceLoaded()
	{

	}

	// Token: 0x060008AF RID: 2223 RVA: 0x0002FF7D File Offset: 0x0002E17D
	public override void OnAgentRenamed(AgentId theAgentId)
	{

	}

	// Token: 0x060008B0 RID: 2224 RVA: 0x0002FF8B File Offset: 0x0002E18B
	public override void OnAgentInterfaceChanged(AgentId theAgentId)
	{

	}

	// Token: 0x060008B1 RID: 2225 RVA: 0x0002FF99 File Offset: 0x0002E199
	public override void StartSketchNodeRepeatOperation()
	{

	}

	// Token: 0x060008B2 RID: 2226 RVA: 0x0002FFB4 File Offset: 0x0002E1B4
	public override void ExecuteSketchNodeRepeatOperation(SketchNode sketchNode)
	{

	}

	// Token: 0x060008B3 RID: 2227 RVA: 0x0003001C File Offset: 0x0002E21C
	public override bool ShouldSketchNodeRepeat()
	{

        return default;
    }

	// Token: 0x060008B4 RID: 2228 RVA: 0x00030024 File Offset: 0x0002E224
	[SketchNodePortOperation(2)]
	public void Reset(SketchNode sketchNode)
	{

	}

	// Token: 0x060008B5 RID: 2229 RVA: 0x00030034 File Offset: 0x0002E234
	public override object ComposePermanentStorage(Agent.Storage storage = null)
	{

        return default;
    }

	// Token: 0x060008B6 RID: 2230 RVA: 0x00030088 File Offset: 0x0002E288
	public override void ApplyPermanentStorage(object data)
	{

	}

	// Token: 0x04000800 RID: 2048
	private AgentProperty _stateProperty;

	// Token: 0x04000801 RID: 2049
	private AgentProperty _internalStateProperty;

	// Token: 0x04000802 RID: 2050
	private AgentProperty _componentsProperty;

	// Token: 0x04000803 RID: 2051
	private AgentProperty _deviceNameProperty;

	// Token: 0x04000804 RID: 2052
	private AgentProperty _nodesProperty;

	// Token: 0x04000805 RID: 2053
	private AgentProperty _connectionsProperty;

	// Token: 0x04000806 RID: 2054
	private AgentProperty _massProperty;

	// Token: 0x04000807 RID: 2055
	private int _repeatIndex;

	// Token: 0x04000808 RID: 2056
	private bool _shouldRun;

	// Token: 0x0200037D RID: 893
	public class ProcessorStorage : Agent.Storage
	{
		// Token: 0x04001C3A RID: 7226
		public object sketchStorage;

		// Token: 0x04001C3B RID: 7227
		public ProcessorAgent.SketchMetaData sketchMetaData;

		// Token: 0x04001C3C RID: 7228
		public AgentId variablesContainerAgentId;
	}

	// Token: 0x0200037E RID: 894
	public class SketchMetaData
	{
		// Token: 0x0600206E RID: 8302 RVA: 0x000A0A6B File Offset: 0x0009EC6B
		public SketchMetaData()
		{

		}

		// Token: 0x0600206F RID: 8303 RVA: 0x000A0A9C File Offset: 0x0009EC9C
		public SketchMetaData(ProcessorAgent.SketchMetaData sketchMetaData)
		{

		}

		// Token: 0x04001C3D RID: 7229
		public List<ProcessorAgent.SketchMetaData.Label> labels;

		// Token: 0x04001C3E RID: 7230
		public Vector2 viewPosition;

		// Token: 0x04001C3F RID: 7231
		public bool[] nodePriorities;

		// Token: 0x04001C40 RID: 7232
		public bool[] labelPriorities;

		// Token: 0x04001C41 RID: 7233
		public bool showMinimap;

		// Token: 0x020004BF RID: 1215
		public class Label
		{
			// Token: 0x06002441 RID: 9281 RVA: 0x000ABEFA File Offset: 0x000AA0FA
			public Label()
			{
			}

			// Token: 0x06002442 RID: 9282 RVA: 0x000ABF04 File Offset: 0x000AA104
			public Label(ProcessorAgent.SketchMetaData.Label label)
			{

			}

			// Token: 0x040020F7 RID: 8439
			public Vector2 position;

			// Token: 0x040020F8 RID: 8440
			public Vector2 size;

			// Token: 0x040020F9 RID: 8441
			public string title;

			// Token: 0x040020FA RID: 8442
			public string comment;

			// Token: 0x040020FB RID: 8443
			public int demoImageAsset;

			// Token: 0x040020FC RID: 8444
			public int index;
		}
	}

	// Token: 0x0200037F RID: 895
	public enum Commands
	{
		// Token: 0x04001C43 RID: 7235
		UpdateVisuals = 4
	}

	// Token: 0x02000380 RID: 896
	public enum Channels
	{
		// Token: 0x04001C45 RID: 7237
		One,
		// Token: 0x04001C46 RID: 7238
		Two,
		// Token: 0x04001C47 RID: 7239
		Three
	}

	// Token: 0x02000381 RID: 897
	private enum InternalStates
	{
		// Token: 0x04001C49 RID: 7241
		Normal = 1,
		// Token: 0x04001C4A RID: 7242
		Warning,
		// Token: 0x04001C4B RID: 7243
		Error
	}
}
}