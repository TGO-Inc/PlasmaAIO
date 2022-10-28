using System;
using FMODUnity;
using UnityEngine;

// Token: 0x020000BC RID: 188
public class PowerSwitchDriver : ComponentDriver
{
	// Token: 0x06000890 RID: 2192 RVA: 0x0002F967 File Offset: 0x0002DB67
	public override void Awake()
	{

	}

	// Token: 0x06000891 RID: 2193 RVA: 0x0002F98A File Offset: 0x0002DB8A
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000892 RID: 2194 RVA: 0x0002F9B0 File Offset: 0x0002DBB0
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000893 RID: 2195 RVA: 0x0002F9D0 File Offset: 0x0002DBD0
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000894 RID: 2196 RVA: 0x0002F9F0 File Offset: 0x0002DBF0
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000895 RID: 2197 RVA: 0x0002FA27 File Offset: 0x0002DC27
	public override bool CanInteractWithRaycast(Ray ray)
	{

        return default;
    }

	// Token: 0x06000896 RID: 2198 RVA: 0x0002FA2C File Offset: 0x0002DC2C
	public override void OnInteractionDown(Ray ray)
	{

	}

	// Token: 0x06000897 RID: 2199 RVA: 0x0002FAA8 File Offset: 0x0002DCA8
	public override void OnPlasmaInteraction()
	{

	}

	// Token: 0x06000898 RID: 2200 RVA: 0x0002FB22 File Offset: 0x0002DD22
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x06000899 RID: 2201 RVA: 0x0002FB38 File Offset: 0x0002DD38
	private void UpdateVisuals(bool instant)
	{

	}

	// Token: 0x0600089A RID: 2202 RVA: 0x0002FB9B File Offset: 0x0002DD9B
	private void SetLEDStripColor()
	{

	}

	// Token: 0x040007F6 RID: 2038
	public StudioEventEmitter FMODEmitterOn;

	// Token: 0x040007F7 RID: 2039
	public StudioEventEmitter FMODEmitterOff;

	// Token: 0x040007F8 RID: 2040
	public Animator animator;

	// Token: 0x040007F9 RID: 2041
	public MeshRenderer meshRenderer;

	// Token: 0x040007FA RID: 2042
	private bool _currentValue;

	// Token: 0x040007FB RID: 2043
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x040007FC RID: 2044
	private int _colorId;

	// Token: 0x040007FD RID: 2045
	private AgentProperty _stateProperty;

	// Token: 0x040007FE RID: 2046
	private AgentProperty _LEDStripColorProperty;

	// Token: 0x040007FF RID: 2047
	private const string _FMODParamSize = "Size";
}
