using System;
using System.Collections.Generic;
using System.Linq;

namespace Behavior
{
	// Token: 0x02000220 RID: 544
	public class Sketch
	{
		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060012AB RID: 4779 RVA: 0x0005FF38 File Offset: 0x0005E138
		// (remove) Token: 0x060012AC RID: 4780 RVA: 0x0005FF70 File Offset: 0x0005E170
		public event Sketch.SketchNotificationEvent OnNotification;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060012AD RID: 4781 RVA: 0x0005FFA8 File Offset: 0x0005E1A8
		// (remove) Token: 0x060012AE RID: 4782 RVA: 0x0005FFE0 File Offset: 0x0005E1E0
		public event Sketch.SketchVariableEvent OnSketchNodeVariableUsageChanged;

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060012AF RID: 4783 RVA: 0x00060018 File Offset: 0x0005E218
		// (remove) Token: 0x060012B0 RID: 4784 RVA: 0x00060050 File Offset: 0x0005E250
		public event Sketch.SketchVariableEvent OnSketchNodeVariableChanged;

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x00060085 File Offset: 0x0005E285
		public List<SketchNode> nodes
		{
			get
			{
				return this._nodes;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x0006008D File Offset: 0x0005E28D
		public HashSet<SketchConnection> connections
		{
			get
			{
				return this._connections;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x00060095 File Offset: 0x0005E295
		// (set) Token: 0x060012B4 RID: 4788 RVA: 0x0006009D File Offset: 0x0005E29D
		public bool canValidate { get; private set; }

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x000600A6 File Offset: 0x0005E2A6
		public IEnumerable<AgentProperty> allVariables
		{
			get
			{
				return this._processorAgent.variablesAgent.runtimeVariables.Values;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x000600BD File Offset: 0x0005E2BD
		public bool hasVariables
		{
			get
			{
				return this._processorAgent.variablesAgent.configuredVariables.Count > 0;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x000600D7 File Offset: 0x0005E2D7
		public ProcessorAgent processorAgent
		{
			get
			{
				return this._processorAgent;
			}
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x000600E0 File Offset: 0x0005E2E0
		public Sketch(ProcessorAgent processorAgent)
		{

		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00060168 File Offset: 0x0005E368
		public void AddVariable()
		{

		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000601D2 File Offset: 0x0005E3D2
		public bool DoesVariableExist(string name)
		{

            return default;
        }

		// Token: 0x060012BB RID: 4795 RVA: 0x000601F4 File Offset: 0x0005E3F4
		public AgentProperty GetConfiguredVariable(string name)
		{

            return default;
        }

		// Token: 0x060012BC RID: 4796 RVA: 0x00060238 File Offset: 0x0005E438
		public AgentProperty GetRuntimeVariable(string name)
		{

            return default;
        }

		// Token: 0x060012BD RID: 4797 RVA: 0x0006026C File Offset: 0x0005E46C
		public void RenameVariable(string name, string newName)
		{

		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00060368 File Offset: 0x0005E568
		private void NotifyProperty(SketchNode node, int propertyId)
		{

		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00060380 File Offset: 0x0005E580
		private void NotifyPropertiesByVariable(string name, bool alsoPropagate)
		{

		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00060414 File Offset: 0x0005E614
		public void RemoveVariable(string name)
		{

		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0006046C File Offset: 0x0005E66C
		public void MapVariable(string name, SketchNode node, int propertyId)
		{

		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00060528 File Offset: 0x0005E728
		public void UnmapVariable(string name, SketchNode node, int propertyId)
		{

		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x000605A3 File Offset: 0x0005E7A3
		public bool DoesPropertyUseVariable(SketchNode node, int propertyId)
		{

            return default;
        }

		// Token: 0x060012C4 RID: 4804 RVA: 0x000605B8 File Offset: 0x0005E7B8
		public string GetMappedVariableForProperty(SketchNode node, int propertyId)
		{

            return default;
        }

		// Token: 0x060012C5 RID: 4805 RVA: 0x000605DC File Offset: 0x0005E7DC
		public int GetUsagesForVariable(string name)
		{

            return default;
        }

		// Token: 0x060012C6 RID: 4806 RVA: 0x0006060C File Offset: 0x0005E80C
		public void PropagateVariableValue(string name, bool onlyRuntime = false)
		{

		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x00060674 File Offset: 0x0005E874
		public void PropagateVariableValue(string name, SketchNode node, int propertyId)
		{

		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x000606CC File Offset: 0x0005E8CC
		private void ApplyVariableToProperty(AgentProperty variable, KeyValuePair<SketchNode, int> nodeProperty, bool runtime)
		{

		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x00060848 File Offset: 0x0005EA48
		private void ApplyVariableToProperties(AgentProperty variable, IEnumerable<KeyValuePair<SketchNode, int>> nodeProperties, bool runtime)
		{

		}

		// Token: 0x060012CA RID: 4810 RVA: 0x00060894 File Offset: 0x0005EA94
		public void SetupAllVariables()
		{

		}

		// Token: 0x060012CB RID: 4811 RVA: 0x0006093C File Offset: 0x0005EB3C
		public void RemapAllNodes()
		{

		}

		// Token: 0x060012CC RID: 4812 RVA: 0x00060B68 File Offset: 0x0005ED68
		public void HandleOnAgentsChangedIdsDuringMove(List<AgentId> oldAgentIds, List<AgentId> newAgentIds)
		{

		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00060BE8 File Offset: 0x0005EDE8
		public SketchNode AddNode(AgentId agentId)
		{

            return default;
        }

		// Token: 0x060012CE RID: 4814 RVA: 0x00060C64 File Offset: 0x0005EE64
		public void RemoveNode(SketchNode node)
		{

		}

		// Token: 0x060012CF RID: 4815 RVA: 0x00060D2C File Offset: 0x0005EF2C
		public SketchNode DuplicateLogicNode(SketchNode originalNode)
		{

            return default;
        }

		// Token: 0x060012D0 RID: 4816 RVA: 0x00060E20 File Offset: 0x0005F020
		public SketchNode GetNodeById(AgentId nodeId, bool includeUnmapped = true)
		{

            return default;
        }

		// Token: 0x060012D1 RID: 4817 RVA: 0x00060E8C File Offset: 0x0005F08C
		public void RenameNode(AgentId agentId)
		{

		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x00060FB8 File Offset: 0x0005F1B8
		public void UpdateNode(AgentId agentId)
		{

		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00060FD8 File Offset: 0x0005F1D8
		public void ValidateAllNodes()
		{

		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00061030 File Offset: 0x0005F230
		public void ResetAllLogicNodes()
		{

		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x000610A0 File Offset: 0x0005F2A0
		public SketchConnection AddConnection(SketchNodePort output, SketchNodePort input, SketchConnection.States state, SketchConnection.MetaData metaData)
		{

            return default;
        }

		// Token: 0x060012D6 RID: 4822 RVA: 0x000610EC File Offset: 0x0005F2EC
		public void RemoveConnection(SketchConnection connection)
		{

		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0006113C File Offset: 0x0005F33C
		public void RemoveConnectionsToFromPort(SketchNodePort port)
		{

		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x000611A8 File Offset: 0x0005F3A8
		public bool DoesConnectionExist(SketchNodePort output, SketchNodePort input)
		{

            return default;
        }

		// Token: 0x060012D9 RID: 4825 RVA: 0x00061210 File Offset: 0x0005F410
		public void Compile()
		{

		}

		// Token: 0x060012DA RID: 4826 RVA: 0x00061388 File Offset: 0x0005F588
		public void Reset()
		{

		}

		// Token: 0x060012DB RID: 4827 RVA: 0x000613EC File Offset: 0x0005F5EC
		public void RunTick(bool firstStep)
		{

		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00061470 File Offset: 0x0005F670
		private IEnumerable<SketchNode> ProcessNode(SketchNode node, bool alwaysRunOnly)
		{

            return default;
        }

		// Token: 0x060012DD RID: 4829 RVA: 0x0006154C File Offset: 0x0005F74C
		private void TraverseNodes(List<SketchNode> triggeredNodes, bool alwaysRunOnly)
		{

		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00061690 File Offset: 0x0005F890
		public void SendNotification(SketchNotifications.Notification notification)
		{

		}

		// Token: 0x060012DF RID: 4831 RVA: 0x000616E5 File Offset: 0x0005F8E5
		public void ClearNotifications()
		{

		}

		// Token: 0x060012E0 RID: 4832 RVA: 0x000616F4 File Offset: 0x0005F8F4
		public List<SketchNotifications.Notification> GetNotificationsForLevel(SketchNotifications.Levels level)
		{

            return default;
        }

		// Token: 0x060012E1 RID: 4833 RVA: 0x00061714 File Offset: 0x0005F914
		public int GetNotificationCountForLevel(SketchNotifications.Levels level)
		{

            return default;
        }

		// Token: 0x060012E2 RID: 4834 RVA: 0x0006173C File Offset: 0x0005F93C
		public object ComposeStorage()
		{

            return default;
        }

		// Token: 0x060012E3 RID: 4835 RVA: 0x000619F4 File Offset: 0x0005FBF4
		public void ApplyStorage(object data)
		{

		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00061BF8 File Offset: 0x0005FDF8
		public void BreakComponent(AgentId id)
		{

		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00061C5C File Offset: 0x0005FE5C
		public void RestoreBrokenComponents()
		{

		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x00061CB0 File Offset: 0x0005FEB0
		public void Log(string message)
		{

		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00061CF4 File Offset: 0x0005FEF4
		public void LogWarning(string message)
		{

		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x00061D38 File Offset: 0x0005FF38
		public void LogError(string message)
		{

		}

		// Token: 0x04000F8E RID: 3982
		public const string noVar = "---";

		// Token: 0x04000F8F RID: 3983
		private string _name;

		// Token: 0x04000F90 RID: 3984
		private List<SketchNode> _nodes;

		// Token: 0x04000F91 RID: 3985
		private HashSet<SketchConnection> _connections;

		// Token: 0x04000F92 RID: 3986
		private List<SketchNode> _alwaysRunNodes;

		// Token: 0x04000F93 RID: 3987
		private List<SketchNode> _singleAlwaysRunNode;

		// Token: 0x04000F94 RID: 3988
		private Dictionary<string, List<KeyValuePair<SketchNode, int>>> _mappedVariables;

		// Token: 0x04000F95 RID: 3989
		private Dictionary<KeyValuePair<SketchNode, int>, string> _reversedMappedVariables;

		// Token: 0x04000F96 RID: 3990
		private int _processedNodes;

		// Token: 0x04000F97 RID: 3991
		private int _depth;

		// Token: 0x04000F98 RID: 3992
		private ProcessorAgent _processorAgent;

		// Token: 0x04000F99 RID: 3993
		private Dictionary<SketchNotifications.Levels, List<SketchNotifications.Notification>> _notifications;

		// Token: 0x04000F9A RID: 3994
		private int _currentVariableId;

		// Token: 0x04000F9B RID: 3995
		private const int _maxProcessedNodes = 1024;

		// Token: 0x04000F9C RID: 3996
		private const int _maxDepth = 64;

		// Token: 0x04000F9D RID: 3997
		private const string _variablePrefix = "MyVar";

		// Token: 0x02000428 RID: 1064
		public class Storage
		{
			// Token: 0x04001E89 RID: 7817
			public string name;

			// Token: 0x04001E8A RID: 7818
			public List<object> nodes;

			// Token: 0x04001E8B RID: 7819
			public List<Sketch.Storage.Connection> connections;

			// Token: 0x04001E8C RID: 7820
			public Dictionary<string, List<KeyValuePair<AgentId, int>>> mappedVariables;

			// Token: 0x04001E8D RID: 7821
			public int currentVariableId;

			// Token: 0x020004C1 RID: 1217
			public class Connection
			{
				// Token: 0x04002101 RID: 8449
				public int outputNodeIndex;

				// Token: 0x04002102 RID: 8450
				public int outputPortId;

				// Token: 0x04002103 RID: 8451
				public int inputNodeIndex;

				// Token: 0x04002104 RID: 8452
				public int inputPortId;

				// Token: 0x04002105 RID: 8453
				public int state;

				// Token: 0x04002106 RID: 8454
				public SketchConnection.MetaData metaData;
			}
		}

		// Token: 0x02000429 RID: 1065
		// (Invoke) Token: 0x06002245 RID: 8773
		public delegate void SketchDebugEvent(int deviceGuid, int index);

		// Token: 0x0200042A RID: 1066
		// (Invoke) Token: 0x06002249 RID: 8777
		public delegate void SketchNotificationEvent(SketchNotifications.Notification notification);

		// Token: 0x0200042B RID: 1067
		// (Invoke) Token: 0x0600224D RID: 8781
		public delegate void SketchVariableEvent(SketchNode sketchNode, int propertyId);
	}
}
