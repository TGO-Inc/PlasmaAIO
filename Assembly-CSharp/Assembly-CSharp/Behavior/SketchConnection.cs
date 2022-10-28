using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass.Behavior
{
	// Token: 0x02000221 RID: 545
	public class SketchConnection
	{
		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x00061D78 File Offset: 0x0005FF78
		public SketchNodePort output
		{
			get
			{
				return this._output;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x00061D80 File Offset: 0x0005FF80
		public SketchNodePort input
		{
			get
			{
				return this._input;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x00061D88 File Offset: 0x0005FF88
		// (set) Token: 0x060012EC RID: 4844 RVA: 0x00061D90 File Offset: 0x0005FF90
		public SketchConnection.States state { get; set; }

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x00061D99 File Offset: 0x0005FF99
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x00061DA1 File Offset: 0x0005FFA1
		public SketchConnection.MetaData metaData { get; set; }

		// Token: 0x060012EF RID: 4847 RVA: 0x00061DAA File Offset: 0x0005FFAA
		public SketchConnection(SketchNodePort output, SketchNodePort input)
		{

		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00061DC0 File Offset: 0x0005FFC0
		public static bool CheckValidity(AgentGestalt.Port output, AgentGestalt.Port input)
		{

            return default;
        }

		// Token: 0x04000F9F RID: 3999
		private SketchNodePort _output;

		// Token: 0x04000FA0 RID: 4000
		private SketchNodePort _input;

		// Token: 0x0200042E RID: 1070
		public enum States
		{
			// Token: 0x04001E92 RID: 7826
			Normal,
			// Token: 0x04001E93 RID: 7827
			DisabledByUser,
			// Token: 0x04001E94 RID: 7828
			DisabledByVariable
		}

		// Token: 0x0200042F RID: 1071
		public class MetaData
		{
			// Token: 0x04001E95 RID: 7829
			public int outputPortId;

			// Token: 0x04001E96 RID: 7830
			public int inputPortId;

			// Token: 0x04001E97 RID: 7831
			public int outputNodeId;

			// Token: 0x04001E98 RID: 7832
			public int inputNodeId;

			// Token: 0x04001E99 RID: 7833
			public Color lineColor;

			// Token: 0x04001E9A RID: 7834
			public List<Vector3> pinPositions;

			// Token: 0x04001E9B RID: 7835
			public int index;
		}
	}
}
