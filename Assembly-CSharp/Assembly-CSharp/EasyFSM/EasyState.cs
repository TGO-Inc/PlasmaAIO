using System;
using System.Collections;
using System.Collections.Generic;

namespace EasyFSM
{
	// Token: 0x02000228 RID: 552
	public class EasyState
	{
		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00063B8E File Offset: 0x00061D8E
		public string name { get; }

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06001358 RID: 4952 RVA: 0x00063B96 File Offset: 0x00061D96
		// (set) Token: 0x06001359 RID: 4953 RVA: 0x00063B9E File Offset: 0x00061D9E
		public EasyStateMachine owner { get; set; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600135A RID: 4954 RVA: 0x00063BA7 File Offset: 0x00061DA7
		// (set) Token: 0x0600135B RID: 4955 RVA: 0x00063BAF File Offset: 0x00061DAF
		public EasyState.Status status { get; private set; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600135C RID: 4956 RVA: 0x00063BB8 File Offset: 0x00061DB8
		public bool hasTransitions
		{
			get
			{
				return this._transitions.Count > 0;
			}
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00063BC8 File Offset: 0x00061DC8
		public EasyState(string theName)
		{

		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00063C15 File Offset: 0x00061E15
		public void AddInstantTask(EasyState.InstantTask instantTask, EasyState.Stages stage = EasyState.Stages.OnUpdate)
		{

		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00063C24 File Offset: 0x00061E24
		public void AddCoroutineTask(Func<IEnumerator> coroutineTask, EasyState.Stages stage = EasyState.Stages.OnUpdate)
		{

		}

		// Token: 0x06001360 RID: 4960 RVA: 0x00063C33 File Offset: 0x00061E33
		public void AddCoroutineTask(Func<object, IEnumerator> coroutineTask, object coroutineParameter, EasyState.Stages stage = EasyState.Stages.OnUpdate)
		{

		}

		// Token: 0x06001361 RID: 4961 RVA: 0x00063C43 File Offset: 0x00061E43
		private void AddTask(EasyState.Task task, EasyState.Stages stage)
		{

		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00063C7E File Offset: 0x00061E7E
		public void AddTransition(EasyTransition transition)
		{

		}

		// Token: 0x06001363 RID: 4963 RVA: 0x00063C8C File Offset: 0x00061E8C
		public void Enter()
		{

		}

		// Token: 0x06001364 RID: 4964 RVA: 0x00063CFB File Offset: 0x00061EFB
		public IEnumerator Execute()
		{

            return default;
        }

		// Token: 0x06001365 RID: 4965 RVA: 0x00063D0C File Offset: 0x00061F0C
		public void Exit()
		{

		}

		// Token: 0x06001366 RID: 4966 RVA: 0x00063D6C File Offset: 0x00061F6C
		public EasyState CheckTransitions()
		{

            return default;
        }

		// Token: 0x04000FDA RID: 4058
		private List<EasyState.Task> _onEnterTasks;

		// Token: 0x04000FDB RID: 4059
		private List<EasyState.Task> _onUpdateTasks;

		// Token: 0x04000FDC RID: 4060
		private List<EasyState.Task> _onExitTasks;

		// Token: 0x04000FDD RID: 4061
		private List<EasyTransition> _transitions;

		// Token: 0x02000439 RID: 1081
		// (Invoke) Token: 0x06002268 RID: 8808
		public delegate void InstantTask();

		// Token: 0x0200043A RID: 1082
		private class Task
		{
			// Token: 0x0600226B RID: 8811 RVA: 0x000A5379 File Offset: 0x000A3579
			public Task(EasyState.InstantTask instantTask)
			{

			}

			// Token: 0x0600226C RID: 8812 RVA: 0x000A5388 File Offset: 0x000A3588
			public Task(Func<IEnumerator> coroutineTask)
			{

			}

			// Token: 0x0600226D RID: 8813 RVA: 0x000A5397 File Offset: 0x000A3597
			public Task(Func<object, IEnumerator> coroutineTaskWithParameter, object coroutineParameter)
			{

			}

			// Token: 0x04001EBA RID: 7866
			public EasyState.InstantTask instantTask;

			// Token: 0x04001EBB RID: 7867
			public Func<IEnumerator> coroutineTask;

			// Token: 0x04001EBC RID: 7868
			public Func<object, IEnumerator> coroutineTaskWithParameter;

			// Token: 0x04001EBD RID: 7869
			public object coroutineParameter;
		}

		// Token: 0x0200043B RID: 1083
		public enum Status
		{
			// Token: 0x04001EBF RID: 7871
			Stopped,
			// Token: 0x04001EC0 RID: 7872
			Running,
			// Token: 0x04001EC1 RID: 7873
			Resting
		}

		// Token: 0x0200043C RID: 1084
		public enum Stages
		{
			// Token: 0x04001EC3 RID: 7875
			OnEnter,
			// Token: 0x04001EC4 RID: 7876
			OnUpdate,
			// Token: 0x04001EC5 RID: 7877
			OnExit
		}
	}
}
