using System;
using System.Collections.Generic;

namespace EasyFSM
{
	// Token: 0x02000225 RID: 549
	public class EasyFSMController : Controller
	{
		// Token: 0x06001345 RID: 4933 RVA: 0x000637B2 File Offset: 0x000619B2
		public override void Init()
		{

		}

		// Token: 0x06001346 RID: 4934 RVA: 0x000637CC File Offset: 0x000619CC
		public EasyStateMachine CreateStateMachine(EasyFSMEnum id)
		{

            return default;
        }

		// Token: 0x06001347 RID: 4935 RVA: 0x000637F0 File Offset: 0x000619F0
		public EasyStateMachine CreateStateMachineInstance(EasyFSMEnum id, out int index)
		{
            index = default;

            return default;
        }

		// Token: 0x06001348 RID: 4936 RVA: 0x0006382C File Offset: 0x00061A2C
		public void DeleteStateMachine(EasyFSMEnum id)
		{

		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0006385C File Offset: 0x00061A5C
		public void DeleteStateMachineInstance(int index)
		{

		}

		// Token: 0x0600134A RID: 4938 RVA: 0x0006388C File Offset: 0x00061A8C
		public void DeleteAllStateMachines()
		{

		}

		// Token: 0x0600134B RID: 4939 RVA: 0x000638EC File Offset: 0x00061AEC
		public void DeleteAllStateMachineInstances()
		{

		}

		// Token: 0x0600134C RID: 4940 RVA: 0x0006394C File Offset: 0x00061B4C
		public void StartStateMachine(EasyFSMEnum id)
		{

		}

		// Token: 0x0600134D RID: 4941 RVA: 0x000639B4 File Offset: 0x00061BB4
		public void StartStateMachineInstance(int index)
		{

		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00063A10 File Offset: 0x00061C10
		public void StopStateMachine(EasyFSMEnum id)
		{

		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00063A54 File Offset: 0x00061C54
		public void StopStateMachineInstance(int index)
		{

		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00063A90 File Offset: 0x00061C90
		public bool IsStateMachineFinished(EasyFSMEnum id)
		{

            return default;
        }

		// Token: 0x06001351 RID: 4945 RVA: 0x00063AD8 File Offset: 0x00061CD8
		public bool IsStateMachineInstanceFinished(int index)
		{

            return default;
        }

		// Token: 0x06001352 RID: 4946 RVA: 0x00063B18 File Offset: 0x00061D18
		public bool IsStateMachineInstanceInState(int index, string stateName)
		{

            return default;
        }

		// Token: 0x04000FBF RID: 4031
		private Dictionary<EasyFSMEnum, EasyStateMachine> _stateMachines;

		// Token: 0x04000FC0 RID: 4032
		private Dictionary<int, EasyStateMachine> _instancedStateMachines;

		// Token: 0x04000FC1 RID: 4033
		private int _instanceIndex;
	}
}
