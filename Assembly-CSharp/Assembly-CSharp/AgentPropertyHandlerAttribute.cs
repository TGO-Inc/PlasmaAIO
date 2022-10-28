using System;

// Token: 0x02000057 RID: 87
[AttributeUsage(AttributeTargets.Method)]
public class AgentPropertyHandlerAttribute : Attribute
{
	// Token: 0x06000589 RID: 1417 RVA: 0x00021386 File Offset: 0x0001F586
	public AgentPropertyHandlerAttribute(int id)
	{

	}

	// Token: 0x040004D9 RID: 1241
	public readonly int id;
}
