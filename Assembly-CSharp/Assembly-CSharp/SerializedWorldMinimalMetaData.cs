using System;

// Token: 0x0200018B RID: 395
public class SerializedWorldMinimalMetaData
{
	// Token: 0x06000EAA RID: 3754 RVA: 0x0004B657 File Offset: 0x00049857
	public SerializedWorldMinimalMetaData()
	{
	}

	// Token: 0x06000EAB RID: 3755 RVA: 0x0004B660 File Offset: 0x00049860
	public SerializedWorldMinimalMetaData(SerializedWorldMinimalMetaData metaData)
	{

	}

	// Token: 0x04000C84 RID: 3204
	public ulong publishedFileId;

	// Token: 0x04000C85 RID: 3205
	public DateTime publishedDate;

	// Token: 0x04000C86 RID: 3206
	public DateTime updateDate;

	// Token: 0x04000C87 RID: 3207
	public string publishedTag;

	// Token: 0x04000C88 RID: 3208
	public SerializedWorldMetaData.Types type;

	// Token: 0x04000C89 RID: 3209
	public SerializedWorldMetaData.States state;
}
