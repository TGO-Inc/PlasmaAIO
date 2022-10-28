using System;
using Behavior;

// Token: 0x0200011C RID: 284
public class PIDControllerAgent : Agent
{
	// Token: 0x06000AF7 RID: 2807 RVA: 0x000399DC File Offset: 0x00037BDC
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000AF8 RID: 2808 RVA: 0x00039A84 File Offset: 0x00037C84
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000AF9 RID: 2809 RVA: 0x00039A90 File Offset: 0x00037C90
	[SketchNodePortOperation(1)]
	public void Evaluate(SketchNode sketchNode)
	{

	}

	// Token: 0x06000AFA RID: 2810 RVA: 0x00039B34 File Offset: 0x00037D34
	[SketchNodePortOperation(2)]
	public void Reset(SketchNode sketchNode)
	{

	}

	// Token: 0x040009D6 RID: 2518
	private AgentProperty _setPointProperty;

	// Token: 0x040009D7 RID: 2519
	private AgentProperty _processVariableProperty;

	// Token: 0x040009D8 RID: 2520
	private AgentProperty _proportionalProperty;

	// Token: 0x040009D9 RID: 2521
	private AgentProperty _integralProperty;

	// Token: 0x040009DA RID: 2522
	private AgentProperty _derivativeProperty;

	// Token: 0x040009DB RID: 2523
	private PIDControllerAgent.PidController _pidController;

	// Token: 0x020003A3 RID: 931
	private sealed class PidController
	{
		// Token: 0x0600209C RID: 8348 RVA: 0x000A118D File Offset: 0x0009F38D
		public PidController(double GainProportional, double GainIntegral, double GainDerivative, double OutputMax, double OutputMin)
		{

		}

		// Token: 0x0600209D RID: 8349 RVA: 0x000A11BC File Offset: 0x0009F3BC
		public double ControlVariable(float timeSinceLastUpdate)
		{

            return default;
        }

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x000A1236 File Offset: 0x0009F436
		// (set) Token: 0x0600209F RID: 8351 RVA: 0x000A123E File Offset: 0x0009F43E
		public double GainDerivative { get; set; }

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x000A1247 File Offset: 0x0009F447
		// (set) Token: 0x060020A1 RID: 8353 RVA: 0x000A124F File Offset: 0x0009F44F
		public double GainIntegral { get; set; }

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060020A2 RID: 8354 RVA: 0x000A1258 File Offset: 0x0009F458
		// (set) Token: 0x060020A3 RID: 8355 RVA: 0x000A1260 File Offset: 0x0009F460
		public double GainProportional { get; set; }

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060020A4 RID: 8356 RVA: 0x000A1269 File Offset: 0x0009F469
		private double OutputMax { get; }

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x000A1271 File Offset: 0x0009F471
		private double OutputMin { get; }

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x000A1279 File Offset: 0x0009F479
		// (set) Token: 0x060020A7 RID: 8359 RVA: 0x000A1281 File Offset: 0x0009F481
		public double IntegralTerm { get; set; }

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x000A128A File Offset: 0x0009F48A
		// (set) Token: 0x060020A9 RID: 8361 RVA: 0x000A1292 File Offset: 0x0009F492
		public double ProcessVariable
		{
			get
			{
				return this._processVariable;
			}
			set
			{
				this.ProcessVariableLast = this._processVariable;
				this._processVariable = value;
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x000A12A7 File Offset: 0x0009F4A7
		// (set) Token: 0x060020AB RID: 8363 RVA: 0x000A12AF File Offset: 0x0009F4AF
		public double ProcessVariableLast { get; set; }

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x000A12B8 File Offset: 0x0009F4B8
		// (set) Token: 0x060020AD RID: 8365 RVA: 0x000A12C0 File Offset: 0x0009F4C0
		public double SetPoint { get; set; }

		// Token: 0x060020AE RID: 8366 RVA: 0x000A12C9 File Offset: 0x0009F4C9
		private double Clamp(double variableToClamp)
		{

            return default;
        }

		// Token: 0x04001CBD RID: 7357
		private double _processVariable;
	}
}
