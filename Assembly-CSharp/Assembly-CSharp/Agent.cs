using System;
using System.Collections.Generic;
using System.Reflection;
using Behavior;
using Rewired;
using UnityEngine;

// Token: 0x02000053 RID: 83
public class Agent
{
	// Token: 0x1700005C RID: 92
	// (get) Token: 0x060004DC RID: 1244 RVA: 0x0001E8BD File Offset: 0x0001CABD
	// (set) Token: 0x060004DD RID: 1245 RVA: 0x0001E8C5 File Offset: 0x0001CAC5
	public AgentGestalt gestalt { get; private set; }

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x060004DE RID: 1246 RVA: 0x0001E8CE File Offset: 0x0001CACE
	// (set) Token: 0x060004DF RID: 1247 RVA: 0x0001E8D6 File Offset: 0x0001CAD6
	public AgentId agentId { get; private set; }

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x060004E0 RID: 1248 RVA: 0x0001E8DF File Offset: 0x0001CADF
	public Dictionary<int, AgentProperty> runtimeProperties
	{
		get
		{
			return this._runtimeProperties;
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x060004E1 RID: 1249 RVA: 0x0001E8E7 File Offset: 0x0001CAE7
	public Dictionary<int, AgentProperty> configuredProperties
	{
		get
		{
			return this._configuredProperties;
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0001E8EF File Offset: 0x0001CAEF
	public Dictionary<AssetController.ResourceTypes, List<int>> resourceIds
	{
		get
		{
			return this._resourceIds;
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0001E8F7 File Offset: 0x0001CAF7
	// (set) Token: 0x060004E4 RID: 1252 RVA: 0x0001E8FF File Offset: 0x0001CAFF
	public ComponentDriver driver
	{
		get
		{
			return this._driver;
		}
		set
		{
			this._driver = value;
			this.OnDriverSet();
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0001E90E File Offset: 0x0001CB0E
	// (set) Token: 0x060004E6 RID: 1254 RVA: 0x0001E916 File Offset: 0x0001CB16
	public ComponentHandler component { get; set; }

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0001E91F File Offset: 0x0001CB1F
	// (set) Token: 0x060004E8 RID: 1256 RVA: 0x0001E927 File Offset: 0x0001CB27
	public int lastSelectedPropertyPosition { get; set; }

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0001E930 File Offset: 0x0001CB30
	public Device device
	{
		get
		{
			return this._device;
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x060004EA RID: 1258 RVA: 0x0001E938 File Offset: 0x0001CB38
	// (set) Token: 0x060004EB RID: 1259 RVA: 0x0001E940 File Offset: 0x0001CB40
	public ProcessorAgent processorAgent { get; set; }

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x060004EC RID: 1260 RVA: 0x0001E949 File Offset: 0x0001CB49
	// (set) Token: 0x060004ED RID: 1261 RVA: 0x0001E951 File Offset: 0x0001CB51
	public SketchNode currentSketchNode { get; private set; }

	// Token: 0x060004EE RID: 1262 RVA: 0x0001E95C File Offset: 0x0001CB5C
	public void Setup(AgentGestalt theGestalt, AgentId theAgentId, Device theDevice, Dictionary<AssetController.ResourceTypes, List<int>> resourceIDs, Agent.ModuleInterface theModuleInterface)
	{

	}

	// Token: 0x060004EF RID: 1263 RVA: 0x0001EAF8 File Offset: 0x0001CCF8
	private void SetupModuleInterfaceAndProperties()
	{

	}

	// Token: 0x060004F0 RID: 1264 RVA: 0x0001ED44 File Offset: 0x0001CF44
	public void UpdatePortsAndProperties()
	{

	}

	// Token: 0x060004F1 RID: 1265 RVA: 0x0001F048 File Offset: 0x0001D248
	public Dictionary<int, AgentGestalt.Port> GetModuleInterfaceFeature(AgentGestalt.Port.Types type)
	{

        return default;
    }

	// Token: 0x060004F2 RID: 1266 RVA: 0x0001F096 File Offset: 0x0001D296
	public void SetDevice(Device theDevice)
	{

	}

	// Token: 0x060004F3 RID: 1267 RVA: 0x0001F0A0 File Offset: 0x0001D2A0
	public void CleanUp()
	{

	}

	// Token: 0x060004F4 RID: 1268 RVA: 0x0001F14C File Offset: 0x0001D34C
	public AgentProperty GetRuntimeProperty(int id)
	{

        return default;
    }

	// Token: 0x060004F5 RID: 1269 RVA: 0x0001F188 File Offset: 0x0001D388
	public AgentProperty GetConfiguredProperty(int id)
	{

        return default;
    }

	// Token: 0x060004F6 RID: 1270 RVA: 0x0001F1C4 File Offset: 0x0001D3C4
	public void CopyConfiguredToRuntimeProperties()
	{

	}

	// Token: 0x060004F7 RID: 1271 RVA: 0x0001F264 File Offset: 0x0001D464
	public void CopyConfiguredPropertiesFromAgent(Agent agent)
	{

	}

	// Token: 0x060004F8 RID: 1272 RVA: 0x0001F300 File Offset: 0x0001D500
	public void RunDriverCommand(int commandId)
	{

	}

	// Token: 0x060004F9 RID: 1273 RVA: 0x0001F31C File Offset: 0x0001D51C
	public virtual FloatRange GetLimitsForProperty(int propertyId)
	{

        return default;
    }

	// Token: 0x060004FA RID: 1274 RVA: 0x0001F32D File Offset: 0x0001D52D
	protected virtual void OnSetupStarted()
	{
	}

	// Token: 0x060004FB RID: 1275 RVA: 0x0001F32F File Offset: 0x0001D52F
	protected virtual void OnSetupFinished()
	{
	}

	// Token: 0x060004FC RID: 1276 RVA: 0x0001F331 File Offset: 0x0001D531
	protected virtual void OnCleanUpFinished()
	{
	}

	// Token: 0x060004FD RID: 1277 RVA: 0x0001F333 File Offset: 0x0001D533
	public virtual void OnComponentSpawned()
	{
	}

	// Token: 0x060004FE RID: 1278 RVA: 0x0001F335 File Offset: 0x0001D535
	protected virtual void OnDriverSet()
	{
	}

	// Token: 0x060004FF RID: 1279 RVA: 0x0001F337 File Offset: 0x0001D537
	protected virtual void OnBeforeCopyConfiguredToRuntimeProperties()
	{
	}

	// Token: 0x06000500 RID: 1280 RVA: 0x0001F339 File Offset: 0x0001D539
	public virtual void OnAgentsChangedIdsDuringMove(List<AgentId> agentIds, List<AgentId> newAgentIds)
	{
	}

	// Token: 0x06000501 RID: 1281 RVA: 0x0001F33B File Offset: 0x0001D53B
	public virtual void OnDeviceStateChanged(Device.State state)
	{
	}

	// Token: 0x06000502 RID: 1282 RVA: 0x0001F33D File Offset: 0x0001D53D
	public virtual void OnDeviceReset()
	{

	}

	// Token: 0x06000503 RID: 1283 RVA: 0x0001F358 File Offset: 0x0001D558
	public virtual void OnDeviceResetFinished()
	{

	}

	// Token: 0x06000504 RID: 1284 RVA: 0x0001F373 File Offset: 0x0001D573
	public virtual void OnDeviceLoaded()
	{
	}

	// Token: 0x06000505 RID: 1285 RVA: 0x0001F375 File Offset: 0x0001D575
	public virtual void OnComponentDetachedDuringSimulation(AgentId theAgentId)
	{
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x0001F377 File Offset: 0x0001D577
	public virtual void OnAgentRenamed(AgentId theAgentId)
	{
	}

	// Token: 0x06000507 RID: 1287 RVA: 0x0001F379 File Offset: 0x0001D579
	public virtual void OnAgentInterfaceChanged(AgentId theAgentId)
	{
	}

	// Token: 0x06000508 RID: 1288 RVA: 0x0001F37B File Offset: 0x0001D57B
	public virtual void OnAgentsChanged()
	{
	}

	// Token: 0x06000509 RID: 1289 RVA: 0x0001F37D File Offset: 0x0001D57D
	public virtual IEnumerable<Agent> GetDependentAgents()
	{

        return default;
    }

	// Token: 0x0600050A RID: 1290 RVA: 0x0001F380 File Offset: 0x0001D580
	public void PreprocessDriver()
	{

	}

	// Token: 0x0600050B RID: 1291 RVA: 0x0001F39C File Offset: 0x0001D59C
	public void UpdateDriver()
	{

	}

	// Token: 0x0600050C RID: 1292 RVA: 0x0001F3E8 File Offset: 0x0001D5E8
	public void ProcessModuleInterface()
	{

	}

	// Token: 0x0600050D RID: 1293 RVA: 0x0001F45F File Offset: 0x0001D65F
	public void UpdateInput(Player input)
	{

	}

	// Token: 0x0600050E RID: 1294 RVA: 0x0001F47B File Offset: 0x0001D67B
	public virtual void OnTicksPreprocess()
	{
	}

	// Token: 0x0600050F RID: 1295 RVA: 0x0001F47D File Offset: 0x0001D67D
	public virtual void OnTicksPostprocess()
	{
	}

	// Token: 0x06000510 RID: 1296 RVA: 0x0001F47F File Offset: 0x0001D67F
	public virtual void OnPreWorldTickUpdate()
	{
	}

	// Token: 0x06000511 RID: 1297 RVA: 0x0001F481 File Offset: 0x0001D681
	public virtual void OnWorldTickUpdate()
	{
	}

	// Token: 0x06000512 RID: 1298 RVA: 0x0001F483 File Offset: 0x0001D683
	public virtual void OnLateWorldTickUpdate(bool firstStep)
	{
	}

	// Token: 0x06000513 RID: 1299 RVA: 0x0001F485 File Offset: 0x0001D685
	public virtual void OnPostWorldTickUpdate()
	{
	}

	// Token: 0x06000514 RID: 1300 RVA: 0x0001F487 File Offset: 0x0001D687
	public virtual string GetStringForPercentageProperty(int propertyId, float percentage)
	{

        return default;
    }

	// Token: 0x06000515 RID: 1301 RVA: 0x0001F4AC File Offset: 0x0001D6AC
	public void OnProjectileExplosion(Vector3 explosionForce)
	{

	}

	// Token: 0x06000516 RID: 1302 RVA: 0x0001F4C8 File Offset: 0x0001D6C8
	public virtual void AllocResources()
	{
	}

	// Token: 0x06000517 RID: 1303 RVA: 0x0001F4CA File Offset: 0x0001D6CA
	public virtual void DeallocResources()
	{
	}

	// Token: 0x06000518 RID: 1304 RVA: 0x0001F4CC File Offset: 0x0001D6CC
	public virtual List<KeyValuePair<int, int>> GetSerializableTexturesLabels()
	{

        return default;
    }

	// Token: 0x06000519 RID: 1305 RVA: 0x0001F4CF File Offset: 0x0001D6CF
	public virtual int GetTextureIndexForLabel(int label)
	{

        return default;
    }

	// Token: 0x0600051A RID: 1306 RVA: 0x0001F4D2 File Offset: 0x0001D6D2
	public virtual bool NeedsRemoteOutputPort()
	{

        return default;
    }

	// Token: 0x0600051B RID: 1307 RVA: 0x0001F4D5 File Offset: 0x0001D6D5
	public virtual void HandleRemotePortLogic()
	{
	}

	// Token: 0x0600051C RID: 1308 RVA: 0x0001F4D7 File Offset: 0x0001D6D7
	public virtual void PrepareForSketchFirstTick()
	{
	}

	// Token: 0x0600051D RID: 1309 RVA: 0x0001F4D9 File Offset: 0x0001D6D9
	public virtual void PrepareForSketchRetrigger()
	{
	}

	// Token: 0x0600051E RID: 1310 RVA: 0x0001F4DB File Offset: 0x0001D6DB
	public void SetCurrentSketchNode(SketchNode sketchNode)
	{

	}

	// Token: 0x0600051F RID: 1311 RVA: 0x0001F4E4 File Offset: 0x0001D6E4
	public virtual void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{
	}

	// Token: 0x06000520 RID: 1312 RVA: 0x0001F4E6 File Offset: 0x0001D6E6
	public void ExecuteSketchNodeOperation(SketchNode sketchNode, int portId, int operationId)
	{

	}

	// Token: 0x06000521 RID: 1313 RVA: 0x0001F50C File Offset: 0x0001D70C
	public virtual void StartSketchNodeRepeatOperation()
	{
	}

	// Token: 0x06000522 RID: 1314 RVA: 0x0001F50E File Offset: 0x0001D70E
	public virtual void ExecuteSketchNodeRepeatOperation(SketchNode sketchNode)
	{
	}

	// Token: 0x06000523 RID: 1315 RVA: 0x0001F510 File Offset: 0x0001D710
	public virtual bool ShouldSketchNodeRepeat()
	{

        return default;
    }

	// Token: 0x06000524 RID: 1316 RVA: 0x0001F513 File Offset: 0x0001D713
	public virtual bool Validate(SketchNode sketchNode, out string message, out List<int> propertyIds)
	{
        message = default;
        propertyIds = default;

        return default;
    }

	// Token: 0x06000525 RID: 1317 RVA: 0x0001F520 File Offset: 0x0001D720
	public virtual void ValidateSelectionForProperty(int id)
	{
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x0001F522 File Offset: 0x0001D722
	public virtual void OnSketchCompiling(Sketch sketch)
	{
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x0001F524 File Offset: 0x0001D724
	public virtual void OnNodeMapped(SketchNode sketchNode)
	{

	}

	// Token: 0x06000528 RID: 1320 RVA: 0x0001F537 File Offset: 0x0001D737
	public virtual void OnNodeUnmapped(SketchNode sketchNode)
	{

	}

	// Token: 0x06000529 RID: 1321 RVA: 0x0001F540 File Offset: 0x0001D740
	[SketchNodePortOperation(64)]
	public void ExecuteModuleCommand(SketchNode sketchNode)
	{

	}

	// Token: 0x0600052A RID: 1322 RVA: 0x0001F559 File Offset: 0x0001D759
	[AgentPropertyHandler(64)]
	public void HandleModuleProperty(AgentProperty property)
	{

	}

	// Token: 0x0600052B RID: 1323 RVA: 0x0001F578 File Offset: 0x0001D778
	public virtual object ComposePermanentStorage(Agent.Storage storage = null)
	{

        return default;
    }

	// Token: 0x0600052C RID: 1324 RVA: 0x0001F5F8 File Offset: 0x0001D7F8
	public virtual void ApplyPermanentStorage(object data)
	{

	}

	// Token: 0x0600052D RID: 1325 RVA: 0x0001F698 File Offset: 0x0001D898
	public object ComposeRuntimeStorage()
	{

        return default;
    }

	// Token: 0x0600052E RID: 1326 RVA: 0x0001F71C File Offset: 0x0001D91C
	public void ApplyRuntimeStorage(object data)
	{

	}

	// Token: 0x0600052F RID: 1327 RVA: 0x0001F7BC File Offset: 0x0001D9BC
	public virtual void PrepareForComposeRuntimeStorage()
	{
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x0001F7BE File Offset: 0x0001D9BE
	public void Log(string message)
	{

	}

	// Token: 0x06000531 RID: 1329 RVA: 0x0001F7D8 File Offset: 0x0001D9D8
	public void LogWarning(string message)
	{

	}

	// Token: 0x06000532 RID: 1330 RVA: 0x0001F7F2 File Offset: 0x0001D9F2
	public void LogError(string message)
	{

	}

	// Token: 0x04000479 RID: 1145
	public Agent.ModuleInterface moduleInterface;

	// Token: 0x0400047A RID: 1146
	protected Dictionary<int, AgentProperty> _runtimeProperties;

	// Token: 0x0400047B RID: 1147
	protected Dictionary<int, AgentProperty> _configuredProperties;

	// Token: 0x0400047C RID: 1148
	protected Device _device;

	// Token: 0x0400047D RID: 1149
	protected Dictionary<AssetController.ResourceTypes, List<int>> _resourceIds;

	// Token: 0x0400047E RID: 1150
	protected Dictionary<int, int> _receivedModuleCommands;

	// Token: 0x0400047F RID: 1151
	protected List<KeyValuePair<int, Data>> _receivedModuleOutputs;

	// Token: 0x04000480 RID: 1152
	protected Dictionary<int, List<Data>> _changedModuleProperties;

	// Token: 0x04000481 RID: 1153
	private int _currentlyProcessedPortId;

	// Token: 0x04000482 RID: 1154
	private Dictionary<int, MethodInfo> _operations;

	// Token: 0x04000483 RID: 1155
	private ComponentDriver _driver;

	// Token: 0x0200033C RID: 828
	public class Storage
	{
		// Token: 0x04001B3C RID: 6972
		public Dictionary<int, object> properties;
	}

	// Token: 0x0200033D RID: 829
	public class ModuleInterface
	{
		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x0009F37A File Offset: 0x0009D57A
		public bool isValid
		{
			get
			{
				return this.commandPorts.Count > 0 || this.propertyPorts.Count > 0 || this.outputPorts.Count > 0;
			}
		}

		// Token: 0x04001B3D RID: 6973
		public Dictionary<int, AgentGestalt.Port> commandPorts;

		// Token: 0x04001B3E RID: 6974
		public Dictionary<int, AgentGestalt.Port> propertyPorts;

		// Token: 0x04001B3F RID: 6975
		public Dictionary<int, AgentGestalt.Port> outputPorts;

		// Token: 0x04001B40 RID: 6976
		public Dictionary<int, AgentGestalt.Property> properties;

		// Token: 0x04001B41 RID: 6977
		public int nextCommandId;

		// Token: 0x04001B42 RID: 6978
		public int nextPropertyPortId;

		// Token: 0x04001B43 RID: 6979
		public int nextOutputId;

		// Token: 0x04001B44 RID: 6980
		public int nextPropertyId;

		// Token: 0x04001B45 RID: 6981
		[NonSerialized]
		public Dictionary<int, KeyValuePair<AgentGestalt.Port.Types, Agent.ModuleInterface.Actions>> portsActions;

		// Token: 0x04001B46 RID: 6982
		[NonSerialized]
		public Dictionary<int, KeyValuePair<int, Agent.ModuleInterface.Actions>> propertyPortsActions;

		// Token: 0x020004BD RID: 1213
		public enum Actions
		{
			// Token: 0x040020F0 RID: 8432
			Added,
			// Token: 0x040020F1 RID: 8433
			Edited,
			// Token: 0x040020F2 RID: 8434
			Removed
		}
	}
}
