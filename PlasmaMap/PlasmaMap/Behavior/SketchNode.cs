using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass.Behavior
{
	// Token: 0x02000222 RID: 546
	public class SketchNode
	{
		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060012F1 RID: 4849 RVA: 0x00061EAC File Offset: 0x000600AC
		// (remove) Token: 0x060012F2 RID: 4850 RVA: 0x00061EE0 File Offset: 0x000600E0
		public static event SketchNode.SketchNodeDebugEvent OnPreProcessInputPorts;

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x060012F3 RID: 4851 RVA: 0x00061F14 File Offset: 0x00060114
		// (remove) Token: 0x060012F4 RID: 4852 RVA: 0x00061F48 File Offset: 0x00060148
		public static event SketchNode.SketchNodeDebugEvent OnPostGenericOperation;

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x00061F7B File Offset: 0x0006017B
		public AgentGestalt agentGestalt
		{
			get
			{
				return this._agentGestalt;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060012F6 RID: 4854 RVA: 0x00061F83 File Offset: 0x00060183
		// (set) Token: 0x060012F7 RID: 4855 RVA: 0x00061F8B File Offset: 0x0006018B
		public AgentId agentId { get; set; }

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x00061F94 File Offset: 0x00060194
		// (set) Token: 0x060012F9 RID: 4857 RVA: 0x00061F9C File Offset: 0x0006019C
		public Agent agent { get; private set; }

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x00061FA5 File Offset: 0x000601A5
		public Dictionary<int, SketchNodePort> ports
		{
			get
			{
				return this._ports;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x00061FAD File Offset: 0x000601AD
		public string name
		{
			get
			{
				return this.agentId.displayName;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x00061FBA File Offset: 0x000601BA
		// (set) Token: 0x060012FD RID: 4861 RVA: 0x00061FC2 File Offset: 0x000601C2
		public Sketch sketch { get; private set; }

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x00061FCB File Offset: 0x000601CB
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x00061FD3 File Offset: 0x000601D3
		public Device device { get; set; }

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x00061FDC File Offset: 0x000601DC
		// (set) Token: 0x06001301 RID: 4865 RVA: 0x00061FE4 File Offset: 0x000601E4
		public bool isValid
		{
			get
			{
				return this._isValid;
			}
			private set
			{
				this._isValid = value;
				SketchNotifications.Notification notification = new SketchNotifications.Notification();
				notification.level = (value ? SketchNotifications.Levels.Normal : SketchNotifications.Levels.Warning);
				notification.type = (value ? SketchNotifications.Types.ValidationPassed : SketchNotifications.Types.ValidationFailed);
				notification.node = this;
				notification.propertyIds = this._validationPropertyIds;
				notification.log = this._validationMessage;
				this.sketch.SendNotification(notification);
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00062043 File Offset: 0x00060243
		public string validationMessage
		{
			get
			{
				return this._validationMessage;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06001303 RID: 4867 RVA: 0x0006204B File Offset: 0x0006024B
		public List<int> validationPropertyIds
		{
			get
			{
				return this._validationPropertyIds;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x00062053 File Offset: 0x00060253
		// (set) Token: 0x06001305 RID: 4869 RVA: 0x0006205B File Offset: 0x0006025B
		public bool isBroken { get; set; }

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x00062064 File Offset: 0x00060264
		// (set) Token: 0x06001307 RID: 4871 RVA: 0x0006206C File Offset: 0x0006026C
		public bool isMapped { get; private set; }

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x00062075 File Offset: 0x00060275
		// (set) Token: 0x06001309 RID: 4873 RVA: 0x0006207D File Offset: 0x0006027D
		public bool alwaysRunProcessed { get; set; }

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x00062086 File Offset: 0x00060286
		// (set) Token: 0x0600130B RID: 4875 RVA: 0x0006208E File Offset: 0x0006028E
		public SketchNode.MetaData metaData { get; set; }

		// Token: 0x0600130C RID: 4876 RVA: 0x00062098 File Offset: 0x00060298
		public void Setup(AgentId theAgentId, Device theDevice, Sketch theSketch)
		{

		}

		// Token: 0x0600130D RID: 4877 RVA: 0x0006222C File Offset: 0x0006042C
		public void UpdateModuleInterfacePorts()
		{

		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0006235C File Offset: 0x0006055C
		private void ProcessPortActions(int portId, AgentGestalt.Port port, Agent.ModuleInterface.Actions action)
		{

		}

		// Token: 0x0600130F RID: 4879 RVA: 0x000623FC File Offset: 0x000605FC
		public void RemoveConnectionsFromToModuleInterfacePorts()
		{

		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00062468 File Offset: 0x00060668
		public void RebuildModuleInterface()
		{

		}

		// Token: 0x06001311 RID: 4881 RVA: 0x000625DC File Offset: 0x000607DC
		public void CleanUp()
		{

		}

		// Token: 0x06001312 RID: 4882 RVA: 0x000625F4 File Offset: 0x000607F4
		public void MapAgent(bool forceUnmap = false)
		{

		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00062684 File Offset: 0x00060884
		private void ManageSubscriptionToProperties(Agent theAgent, bool subscribe)
		{

		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0006270C File Offset: 0x0006090C
		private void HandleOnPropertyValueChanged(AgentProperty property)
		{

		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00062714 File Offset: 0x00060914
		public void Validate()
		{

		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00062761 File Offset: 0x00060961
		public SketchNodePort GetPort(int id)
		{

            return default;
        }

		// Token: 0x06001317 RID: 4887 RVA: 0x0006279C File Offset: 0x0006099C
		public List<SketchNodePort> GetPortsOfType(AgentGestalt.Port.Types type, bool fromModuleInterface)
		{

            return default;
        }

		// Token: 0x06001318 RID: 4888 RVA: 0x00062878 File Offset: 0x00060A78
		public void PrepareForCompilation()
		{

		}

		// Token: 0x06001319 RID: 4889 RVA: 0x000628AC File Offset: 0x00060AAC
		public void ApplyOutwardConnection(SketchConnection connection)
		{

		}

		// Token: 0x0600131A RID: 4890 RVA: 0x000628E0 File Offset: 0x00060AE0
		public void ApplyInwardConnection(SketchConnection connection)
		{

		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00062913 File Offset: 0x00060B13
		public void ApplyInwardRemoteConnection(int inputPortId)
		{

		}

		// Token: 0x0600131C RID: 4892 RVA: 0x0006292F File Offset: 0x00060B2F
		public void ApplyOutwardRemoteConnection()
		{

		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00062954 File Offset: 0x00060B54
		public void ClearPorts()
		{

		}

		// Token: 0x0600131E RID: 4894 RVA: 0x000629B4 File Offset: 0x00060BB4
		public bool ProcessInputPorts(bool alwaysRunOnly)
		{

            return default;
        }

		// Token: 0x0600131F RID: 4895 RVA: 0x00062AC8 File Offset: 0x00060CC8
		public void PrepareForRetrigger()
		{

		}

		// Token: 0x06001320 RID: 4896 RVA: 0x00062AD5 File Offset: 0x00060CD5
		public void AttachToAgent()
		{

		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00062AE3 File Offset: 0x00060CE3
		public void RunGenericOperation()
		{

		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00062B0E File Offset: 0x00060D0E
		public void RunModuleInterfaceProcess()
		{

		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00062B1B File Offset: 0x00060D1B
		public void StartRepeatOperation()
		{

		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00062B28 File Offset: 0x00060D28
		public void RunRepeatOperation()
		{

		}

		// Token: 0x06001325 RID: 4901 RVA: 0x00062B36 File Offset: 0x00060D36
		public bool CheckRepeatOperation()
		{

            return default;
        }

		// Token: 0x06001326 RID: 4902 RVA: 0x00062B44 File Offset: 0x00060D44
		public IEnumerable<SketchNode> ProcessOutputPorts()
		{

            return default;
        }

		// Token: 0x06001327 RID: 4903 RVA: 0x00062C08 File Offset: 0x00060E08
		public object ComposeStorage()
		{

            return default;
        }

		// Token: 0x06001328 RID: 4904 RVA: 0x00062C38 File Offset: 0x00060E38
		public void ApplyStorage(object data, Device theDevice, Sketch theSketch)
		{

		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00062C74 File Offset: 0x00060E74
		public void Log(string message)
		{

		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00062CD8 File Offset: 0x00060ED8
		public void LogWarning(string message)
		{

		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00062D3C File Offset: 0x00060F3C
		public void LogError(string message)
		{

		}

		// Token: 0x04000FA5 RID: 4005
		private AgentGestalt _agentGestalt;

		// Token: 0x04000FA6 RID: 4006
		private AgentGestaltEnum _agentGestaltId;

		// Token: 0x04000FA7 RID: 4007
		private Dictionary<int, SketchNodePort> _ports;

		// Token: 0x04000FA8 RID: 4008
		private List<int> _connectedOutputPorts;

		// Token: 0x04000FA9 RID: 4009
		private List<int> _connectedInputPorts;

		// Token: 0x04000FAA RID: 4010
		private List<SketchNode> _triggeredNodes;

		// Token: 0x04000FAB RID: 4011
		private bool _isValid;

		// Token: 0x04000FAC RID: 4012
		private string _validationMessage;

		// Token: 0x04000FAD RID: 4013
		private List<int> _validationPropertyIds;

		// Token: 0x02000430 RID: 1072
		public class Storage
		{
			// Token: 0x04001E9C RID: 7836
			public AgentId agentId;

			// Token: 0x04001E9D RID: 7837
			public AgentGestaltEnum agentGestaltId;

			// Token: 0x04001E9E RID: 7838
			public SketchNode.MetaData metaData;
		}

		// Token: 0x02000431 RID: 1073
		public class MetaData
		{
			// Token: 0x04001E9F RID: 7839
			public List<SketchNode.MetaData.Node> nodes;

			// Token: 0x020004C2 RID: 1218
			public class Node
			{
				// Token: 0x04002107 RID: 8455
				public Vector2 position;

				// Token: 0x04002108 RID: 8456
				public int id;

				// Token: 0x04002109 RID: 8457
				public bool[] connectionPriorities;
			}
		}

		// Token: 0x02000432 RID: 1074
		// (Invoke) Token: 0x0600225A RID: 8794
		public delegate void SketchNodeDebugEvent(int deviceGuid, SketchNode sketchNode);
	}
}
