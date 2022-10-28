using System;
using System.Collections.Generic;

namespace Behavior
{
	// Token: 0x02000224 RID: 548
	public static class SketchNotifications
	{
		// Token: 0x06001344 RID: 4932 RVA: 0x00063660 File Offset: 0x00061860
		public static string Format(string template, SketchNotifications.Notification notification)
		{

            return default;
        }

		// Token: 0x02000436 RID: 1078
		public enum Levels
		{
			// Token: 0x04001EA4 RID: 7844
			Log,
			// Token: 0x04001EA5 RID: 7845
			Normal,
			// Token: 0x04001EA6 RID: 7846
			Warning,
			// Token: 0x04001EA7 RID: 7847
			Error
		}

		// Token: 0x02000437 RID: 1079
		public enum Types
		{
			// Token: 0x04001EA9 RID: 7849
			Log = 1,
			// Token: 0x04001EAA RID: 7850
			InfiniteLoop,
			// Token: 0x04001EAB RID: 7851
			SetValueOnDisabledProperty,
			// Token: 0x04001EAC RID: 7852
			IncompatibleDataType,
			// Token: 0x04001EAD RID: 7853
			ValidationPassed,
			// Token: 0x04001EAE RID: 7854
			ValidationFailed,
			// Token: 0x04001EAF RID: 7855
			MaxCapacityReached,
			// Token: 0x04001EB0 RID: 7856
			MaxProcessedNodesReached
		}

		// Token: 0x02000438 RID: 1080
		public class Notification
		{
			// Token: 0x04001EB1 RID: 7857
			public SketchNotifications.Levels level;

			// Token: 0x04001EB2 RID: 7858
			public SketchNotifications.Types type;

			// Token: 0x04001EB3 RID: 7859
			public SketchNode node;

			// Token: 0x04001EB4 RID: 7860
			public int propertyId;

			// Token: 0x04001EB5 RID: 7861
			public int portId;

			// Token: 0x04001EB6 RID: 7862
			public Data payload;

			// Token: 0x04001EB7 RID: 7863
			public Data data;

			// Token: 0x04001EB8 RID: 7864
			public string log;

			// Token: 0x04001EB9 RID: 7865
			public List<int> propertyIds;
		}
	}
}
