using System;
using System.Reflection;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	// Token: 0x0200022B RID: 555
	[Category("✫ Script Control/Standalone Only")]
	[Description("Call a function with none or up to 6 parameters on a component and return whether or not the return value is equal to the check value")]
	public class CheckFunctionSetValueInt : ConditionTask, ISubParametersContainer
	{
		// Token: 0x0600137A RID: 4986 RVA: 0x0006406C File Offset: 0x0006226C
		BBParameter[] ISubParametersContainer.GetSubParameters()
		{
			if (this.functionWrapper == null)
			{
				return null;
			}
			return this.functionWrapper.GetVariables();
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x00064083 File Offset: 0x00062283
		private MethodInfo targetMethod
		{
			get
			{
				if (this.functionWrapper == null)
				{
					return null;
				}
				return this.functionWrapper.GetMethod();
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x0006409A File Offset: 0x0006229A
		public override Type agentType
		{
			get
			{
				if (this.targetMethod == null)
				{
					return typeof(Transform);
				}
				if (!this.targetMethod.IsStatic)
				{
					return this.targetMethod.RTReflectedOrDeclaredType();
				}
				return null;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x000640D0 File Offset: 0x000622D0
		protected override string info
		{
			get
			{
				if (this.functionWrapper == null)
				{
					return "No Method Selected";
				}
				if (this.targetMethod == null)
				{
					return string.Format("<color=#ff6457>* {0} *</color>", this.functionWrapper.GetMethodString());
				}
				BBParameter[] variables = this.functionWrapper.GetVariables();
				string text = "";
				for (int i = 1; i < variables.Length; i++)
				{
					text = text + ((i != 1) ? ", " : "") + variables[i].ToString();
				}
				string text2 = this.targetMethod.IsStatic ? this.targetMethod.RTReflectedOrDeclaredType().FriendlyName(false) : base.agentInfo;
				string format = "{0}.{1}({2}){3}";
				object[] array = new object[4];
				array[0] = text2;
				array[1] = this.targetMethod.Name;
				array[2] = text;
				int num = 3;
				string compareString = OperationTools.GetCompareString(this.comparison);
				BBParameter bbparameter = this.checkValue;
				array[num] = compareString + ((bbparameter != null) ? bbparameter.ToString() : null);
				return string.Format(format, array);
			}
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x000641C0 File Offset: 0x000623C0
		public override void OnValidate(ITaskSystem ownerSystem)
		{

		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00064228 File Offset: 0x00062428
		protected override string OnInit()
		{

            return default;
        }

		// Token: 0x06001380 RID: 4992 RVA: 0x0006428C File Offset: 0x0006248C
		protected override bool OnCheck()
		{

            return default;
        }

		// Token: 0x06001381 RID: 4993 RVA: 0x00064369 File Offset: 0x00062569
		private void SetMethod(MethodInfo method)
		{

		}

		// Token: 0x04000FEC RID: 4076
		[SerializeField]
		protected ReflectedFunctionWrapper functionWrapper;

		// Token: 0x04000FED RID: 4077
		[SerializeField]
		protected BBParameter checkValue;

		// Token: 0x04000FEE RID: 4078
		[SerializeField]
		protected CompareMethod comparison;

		// Token: 0x04000FEF RID: 4079
		[SerializeField]
		[BlackboardOnly]
		private BBParameter<int> saveAs;

		// Token: 0x04000FF0 RID: 4080
		[SerializeField]
		private BBParameter<int> saveValue;
	}
}
