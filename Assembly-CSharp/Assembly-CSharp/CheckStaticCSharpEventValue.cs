using System;
using System.Reflection;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Token: 0x02000032 RID: 50
[Category("✫ Script Control/Common")]
[Description("STOCA Will subscribe to a public static event of Action type and return true when the event is raised and its value is equal to provided value as well.\n(eg public event System.Action<T> [name])")]
public class CheckStaticCSharpEventValue<T> : ConditionTask
{
	// Token: 0x1700001B RID: 27
	// (get) Token: 0x0600011A RID: 282 RVA: 0x00008353 File Offset: 0x00006553
	protected override string info
	{
		get
		{
			if (string.IsNullOrEmpty(this.eventName))
			{
				return "No Event Selected";
			}
			return string.Format("'{0}' Raised && Value == {1}", this.eventName, this.checkValue);
		}
	}

	// Token: 0x0600011B RID: 283 RVA: 0x00008380 File Offset: 0x00006580
	protected override string OnInit()
	{

        return default;
    }

	// Token: 0x0600011C RID: 284 RVA: 0x000083D2 File Offset: 0x000065D2
	public void Raised(T eventValue)
	{

	}

	// Token: 0x0600011D RID: 285 RVA: 0x000083F8 File Offset: 0x000065F8
	protected override bool OnCheck()
	{

        return default;
    }

	// Token: 0x0400014C RID: 332
	[SerializeField]
	private Type targetType;

	// Token: 0x0400014D RID: 333
	[SerializeField]
	private string eventName;

	// Token: 0x0400014E RID: 334
	[SerializeField]
	[BlackboardOnly]
	private BBParameter<T> checkValue;
}
