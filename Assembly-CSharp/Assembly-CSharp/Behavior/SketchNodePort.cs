using System;
using System.Collections.Generic;

namespace Behavior
{
	// Token: 0x02000223 RID: 547
	public class SketchNodePort
	{
		// Token: 0x1400001E RID: 30
		// (add) Token: 0x0600132D RID: 4909 RVA: 0x00062DA8 File Offset: 0x00060FA8
		// (remove) Token: 0x0600132E RID: 4910 RVA: 0x00062DDC File Offset: 0x00060FDC
		public static event SketchNodePort.SketchNodePortDebugEvent OnPush;

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x00062E0F File Offset: 0x0006100F
		public AgentGestalt.Port definition
		{
			get
			{
				return this._definition;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x00062E17 File Offset: 0x00061017
		public SketchNode node
		{
			get
			{
				return this._node;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x00062E1F File Offset: 0x0006101F
		public bool isConnected
		{
			get
			{
				return this._connections.Count > 0;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x00062E2F File Offset: 0x0006102F
		public int id { get; }

		// Token: 0x06001333 RID: 4915 RVA: 0x00062E38 File Offset: 0x00061038
		public SketchNodePort(KeyValuePair<int, AgentGestalt.Port> definition, SketchNode node)
		{

		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00062E8D File Offset: 0x0006108D
		public void AddConnection(SketchConnection connection)
		{

		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00062E9B File Offset: 0x0006109B
		public void RemoveConnection(SketchConnection connection)
		{

		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00062EAC File Offset: 0x000610AC
		public bool IsConnectedTo(SketchNodePort port)
		{

            return default;
        }

		// Token: 0x06001337 RID: 4919 RVA: 0x00062F3C File Offset: 0x0006113C
		public void Clear()
		{

		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00062F50 File Offset: 0x00061150
		public void Commit(Data payload)
		{

		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00063084 File Offset: 0x00061284
		public void RemoteCommit(Data payload, SketchNodePort inputPort)
		{

		}

		// Token: 0x0600133A RID: 4922 RVA: 0x000630BC File Offset: 0x000612BC
		public IEnumerable<SketchNodePort> Push()
		{

            return default;
        }

		// Token: 0x0600133B RID: 4923 RVA: 0x00063174 File Offset: 0x00061374
		private void Accept(SketchNodePort.Signal signal)
		{

		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00063184 File Offset: 0x00061384
		public bool Pull()
		{

            return default;
        }

		// Token: 0x0600133D RID: 4925 RVA: 0x000633CD File Offset: 0x000615CD
		public Data Peek()
		{

            return default;
        }

		// Token: 0x0600133E RID: 4926 RVA: 0x000633F8 File Offset: 0x000615F8
		public void Log(string message)
		{

		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00063468 File Offset: 0x00061668
		public void LogWarning(string message)
		{

		}

		// Token: 0x06001340 RID: 4928 RVA: 0x000634D8 File Offset: 0x000616D8
		public void LogError(string message)
		{

		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00063544 File Offset: 0x00061744
		public void LogCommit(Data data)
		{

		}

		// Token: 0x06001342 RID: 4930 RVA: 0x000635D4 File Offset: 0x000617D4
		public void LogPull()
		{

		}

		// Token: 0x04000FB7 RID: 4023
		private AgentGestalt.Port _definition;

		// Token: 0x04000FB8 RID: 4024
		private SketchNode _node;

		// Token: 0x04000FB9 RID: 4025
		private List<SketchConnection> _connections;

		// Token: 0x04000FBA RID: 4026
		private SketchNodePort.Signal _acceptedSignal;

		// Token: 0x04000FBB RID: 4027
		private List<SketchNodePort> _triggeredPorts;

		// Token: 0x04000FBC RID: 4028
		private Dictionary<SketchNodePort, SketchNodePort.Signal> _pendingSignals;

		// Token: 0x04000FBD RID: 4029
		private static Data _empty = new Data();

		// Token: 0x02000434 RID: 1076
		public class Signal
		{
			// Token: 0x06002260 RID: 8800 RVA: 0x000A5355 File Offset: 0x000A3555
			public Signal()
			{
			}

			// Token: 0x06002261 RID: 8801 RVA: 0x000A535D File Offset: 0x000A355D
			public Signal(SketchNodePort.Signal signal)
			{

			}

			// Token: 0x04001EA2 RID: 7842
			public Data payload;
		}

		// Token: 0x02000435 RID: 1077
		// (Invoke) Token: 0x06002263 RID: 8803
		public delegate void SketchNodePortDebugEvent(int deviceGuid, SketchNodePort fromPort, SketchNodePort toPort, Data data);
	}
}
