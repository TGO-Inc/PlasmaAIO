using System;

// Token: 0x02000054 RID: 84
public class AgentId
{
	// Token: 0x06000534 RID: 1332 RVA: 0x0001F813 File Offset: 0x0001DA13
	public AgentId()
	{
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x0001F81B File Offset: 0x0001DA1B
	public AgentId(AgentId id)
	{

	}

	// Token: 0x06000536 RID: 1334 RVA: 0x0001F853 File Offset: 0x0001DA53
	public override bool Equals(object obj)
	{

        return default;
    }

	// Token: 0x06000537 RID: 1335 RVA: 0x0001F86B File Offset: 0x0001DA6B
	public static bool operator ==(AgentId i1, AgentId i2)
	{

        return default;
    }

	// Token: 0x06000538 RID: 1336 RVA: 0x0001F8A9 File Offset: 0x0001DAA9
	public static bool operator !=(AgentId i1, AgentId i2)
	{

        return default;
    }

	// Token: 0x06000539 RID: 1337 RVA: 0x0001F8B5 File Offset: 0x0001DAB5
	public override int GetHashCode()
	{

        return default;
    }

	// Token: 0x0600053A RID: 1338 RVA: 0x0001F8D4 File Offset: 0x0001DAD4
	public override string ToString()
	{

        return default;
    }

	// Token: 0x0400048A RID: 1162
	public AgentGestalt.Types type;

	// Token: 0x0400048B RID: 1163
	public AgentGestaltEnum agentGestaltId;

	// Token: 0x0400048C RID: 1164
	public int guid;

	// Token: 0x0400048D RID: 1165
	public string displayName;
}
