using System;
using System.Collections.Generic;
using Behavior;

// Token: 0x02000134 RID: 308
public class TutorialPresenterAgent : Agent, IDataSelectionProvider
{
	// Token: 0x06000B80 RID: 2944 RVA: 0x0003BDB2 File Offset: 0x00039FB2
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B81 RID: 2945 RVA: 0x0003BDC8 File Offset: 0x00039FC8
	public static Dictionary<int, string> GetDynamicOptions()
	{

        return default;
    }

	// Token: 0x06000B82 RID: 2946 RVA: 0x0003BE44 File Offset: 0x0003A044
	public static string GetDynamicOption(int id)
	{

        return default;
    }

	// Token: 0x06000B83 RID: 2947 RVA: 0x0003BE60 File Offset: 0x0003A060
	[SketchNodePortOperation(1)]
	public void Present(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A32 RID: 2610
	private AgentProperty _tutorialProperty;
}
