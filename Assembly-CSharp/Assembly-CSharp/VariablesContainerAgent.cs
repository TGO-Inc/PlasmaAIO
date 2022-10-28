using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;

namespace PlasmaAPI.GameClass {
// Token: 0x0200013C RID: 316
public class VariablesContainerAgent : Agent
{
	// Token: 0x06000BA3 RID: 2979 RVA: 0x0003CAB1 File Offset: 0x0003ACB1
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000BA4 RID: 2980 RVA: 0x0003CACC File Offset: 0x0003ACCC
	public void AddVariable(string name, int id)
	{

	}

	// Token: 0x06000BA5 RID: 2981 RVA: 0x0003CB24 File Offset: 0x0003AD24
	public void RemoveVariable(string name)
	{

	}

	// Token: 0x06000BA6 RID: 2982 RVA: 0x0003CBA8 File Offset: 0x0003ADA8
	public bool RenameVariable(string name, string newName)
	{

        return default;
    }

	// Token: 0x06000BA7 RID: 2983 RVA: 0x0003CC24 File Offset: 0x0003AE24
	public override void DeallocResources()
	{

	}

	// Token: 0x06000BA8 RID: 2984 RVA: 0x0003CC88 File Offset: 0x0003AE88
	public override void ApplyPermanentStorage(object data)
	{

	}

	// Token: 0x04000A64 RID: 2660
	public Dictionary<string, AgentProperty> configuredVariables;

	// Token: 0x04000A65 RID: 2661
	public Dictionary<string, AgentProperty> runtimeVariables;
}
}