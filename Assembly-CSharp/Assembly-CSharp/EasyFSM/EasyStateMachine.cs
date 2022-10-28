using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass.EasyFSM
{
	// Token: 0x02000229 RID: 553
	public class EasyStateMachine
	{
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x00063DCC File Offset: 0x00061FCC
		// (set) Token: 0x06001368 RID: 4968 RVA: 0x00063DD4 File Offset: 0x00061FD4
		public EasyStateMachine.Status status { get; private set; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x00063DDD File Offset: 0x00061FDD
		// (set) Token: 0x0600136A RID: 4970 RVA: 0x00063DE5 File Offset: 0x00061FE5
		public EasyState nextState { get; set; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x00063DEE File Offset: 0x00061FEE
		public string name
		{
			get
			{
				return this._id.ToString();
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x00063E01 File Offset: 0x00062001
		public string currentStateName
		{
			get
			{
				EasyState currentState = this._currentState;
				if (currentState == null)
				{
					return null;
				}
				return currentState.name;
			}
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00063E14 File Offset: 0x00062014
		public EasyStateMachine(EasyFSMEnum id)
		{

		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00063E40 File Offset: 0x00062040
		public EasyStateMachine AddState(EasyState state)
		{

            return default;
        }

		// Token: 0x0600136F RID: 4975 RVA: 0x00063E56 File Offset: 0x00062056
		public void SetStartState(EasyState state)
		{

		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00063E60 File Offset: 0x00062060
		public void Run()
		{

		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00063EE3 File Offset: 0x000620E3
		private IEnumerator MainLoop()
		{

            return default;
        }

		// Token: 0x06001372 RID: 4978 RVA: 0x00063EF4 File Offset: 0x000620F4
		public void Stop()
		{

		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00063F4C File Offset: 0x0006214C
		private bool TryMovingToNextState()
		{

            return default;
        }

		// Token: 0x04000FE1 RID: 4065
		private EasyFSMEnum _id;

		// Token: 0x04000FE2 RID: 4066
		private List<EasyState> _states;

		// Token: 0x04000FE3 RID: 4067
		private EasyState _startState;

		// Token: 0x04000FE4 RID: 4068
		private EasyState _currentState;

		// Token: 0x04000FE5 RID: 4069
		private Coroutine _coroutine;

		// Token: 0x04000FE6 RID: 4070
		private EasyFSMController _controller;

		// Token: 0x0200043E RID: 1086
		public enum Status
		{
			// Token: 0x04001ECC RID: 7884
			Idling,
			// Token: 0x04001ECD RID: 7885
			Running,
			// Token: 0x04001ECE RID: 7886
			Finished
		}
	}
}
