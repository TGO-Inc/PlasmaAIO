using System;

// Token: 0x02000151 RID: 337
[AttributeUsage(AttributeTargets.Method)]
public class SketchNodePortOperationAttribute : Attribute
{
	// Token: 0x06000DA2 RID: 3490 RVA: 0x00045CFB File Offset: 0x00043EFB
	public SketchNodePortOperationAttribute(int id)
	{

	}

	// Token: 0x04000B0E RID: 2830
	public readonly int id;
}
