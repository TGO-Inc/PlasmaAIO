using System;
using System.Collections;
using System.IO.Ports;
using System.Threading;
using UnityEngine;

// Token: 0x020000CB RID: 203
public class SerialPortDriver : ComponentDriver
{
	// Token: 0x0600090B RID: 2315 RVA: 0x000317DD File Offset: 0x0002F9DD
	public override void Awake()
	{

	}

	// Token: 0x0600090C RID: 2316 RVA: 0x00031800 File Offset: 0x0002FA00
	protected override void OnAgentSet()
	{

	}

	// Token: 0x0600090D RID: 2317 RVA: 0x00031899 File Offset: 0x0002FA99
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x0600090E RID: 2318 RVA: 0x000318A8 File Offset: 0x0002FAA8
	public override void OnSolidEnter()
	{

	}

	// Token: 0x0600090F RID: 2319 RVA: 0x000318C4 File Offset: 0x0002FAC4
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000910 RID: 2320 RVA: 0x00031930 File Offset: 0x0002FB30
	private void StartCommunication()
	{

	}

	// Token: 0x06000911 RID: 2321 RVA: 0x0003197C File Offset: 0x0002FB7C
	private void UpdateVisuals()
	{

	}

	// Token: 0x06000912 RID: 2322 RVA: 0x000319A8 File Offset: 0x0002FBA8
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x06000913 RID: 2323 RVA: 0x00031A3C File Offset: 0x0002FC3C
	private void RunSerialCommunication()
	{

	}

	// Token: 0x06000914 RID: 2324 RVA: 0x00031BE0 File Offset: 0x0002FDE0
	private void SetLEDColor(Color color)
	{

	}

	// Token: 0x06000915 RID: 2325 RVA: 0x00031C16 File Offset: 0x0002FE16
	private void OnDestroy()
	{

	}

	// Token: 0x04000858 RID: 2136
	public MeshRenderer meshRenderer;

	// Token: 0x04000859 RID: 2137
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x0400085A RID: 2138
	private int _colorId;

	// Token: 0x0400085B RID: 2139
	private AgentProperty _propertyPort;

	// Token: 0x0400085C RID: 2140
	private AgentProperty _propertySpeed;

	// Token: 0x0400085D RID: 2141
	private AgentProperty _propertySendBuffer;

	// Token: 0x0400085E RID: 2142
	private AgentProperty _propertyReceiveBuffer;

	// Token: 0x0400085F RID: 2143
	private AgentProperty _propertyHasReceivedData;

	// Token: 0x04000860 RID: 2144
	private AgentProperty _propertyIsOpen;

	// Token: 0x04000861 RID: 2145
	private SerialPort _serialPort;

	// Token: 0x04000862 RID: 2146
	private Thread _thread;

	// Token: 0x04000863 RID: 2147
	private Queue _inputQueue;

	// Token: 0x04000864 RID: 2148
	private Queue _outputQueue;

	// Token: 0x04000865 RID: 2149
	private bool _isRunning;

	// Token: 0x04000866 RID: 2150
	private bool _isOpen;
}
