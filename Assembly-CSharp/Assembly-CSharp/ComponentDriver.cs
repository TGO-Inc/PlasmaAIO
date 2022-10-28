using System;
using Rewired;
using Sirenix.OdinInspector;
using UnityEngine;

// Token: 0x02000146 RID: 326
public class ComponentDriver : SerializedMonoBehaviour
{
	// Token: 0x17000094 RID: 148
	// (get) Token: 0x06000BDC RID: 3036 RVA: 0x0003DA48 File Offset: 0x0003BC48
	// (set) Token: 0x06000BDD RID: 3037 RVA: 0x0003DA50 File Offset: 0x0003BC50
	public Agent agent
	{
		get
		{
			return this._agent;
		}
		set
		{
			this._agent = value;
			if (value != null)
			{
				this.OnAgentSet();
			}
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06000BDE RID: 3038 RVA: 0x0003DA62 File Offset: 0x0003BC62
	public ComponentHandler component
	{
		get
		{
			return this._component;
		}
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x0003DA6A File Offset: 0x0003BC6A
	public virtual void Awake()
	{

	}

	// Token: 0x06000BE0 RID: 3040 RVA: 0x0003DA78 File Offset: 0x0003BC78
	public virtual void OnWireframeEnter()
	{
	}

	// Token: 0x06000BE1 RID: 3041 RVA: 0x0003DA7A File Offset: 0x0003BC7A
	public virtual void OnSolidEnter()
	{
	}

	// Token: 0x06000BE2 RID: 3042 RVA: 0x0003DA7C File Offset: 0x0003BC7C
	public virtual void OnReset()
	{
	}

	// Token: 0x06000BE3 RID: 3043 RVA: 0x0003DA7E File Offset: 0x0003BC7E
	public virtual void OnResetFinished()
	{
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x0003DA80 File Offset: 0x0003BC80
	protected virtual void OnAgentSet()
	{
	}

	// Token: 0x06000BE5 RID: 3045 RVA: 0x0003DA82 File Offset: 0x0003BC82
	public virtual void OnScaleChanged()
	{
	}

	// Token: 0x06000BE6 RID: 3046 RVA: 0x0003DA84 File Offset: 0x0003BC84
	public virtual void RunCommand(int commandId)
	{
	}

	// Token: 0x06000BE7 RID: 3047 RVA: 0x0003DA86 File Offset: 0x0003BC86
	public virtual void Preprocess()
	{
	}

	// Token: 0x06000BE8 RID: 3048 RVA: 0x0003DA88 File Offset: 0x0003BC88
	public virtual void ProcessInput(Player input)
	{
	}

	// Token: 0x06000BE9 RID: 3049 RVA: 0x0003DA8A File Offset: 0x0003BC8A
	public virtual void UpdateConcreteProperties()
	{
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x0003DA8C File Offset: 0x0003BC8C
	public virtual void SimulateMountedPhysics()
	{
	}

	// Token: 0x06000BEB RID: 3051 RVA: 0x0003DA8E File Offset: 0x0003BC8E
	public virtual string GetRealValueStringForProperty(int propertyId, float value)
	{

        return default;
    }

	// Token: 0x06000BEC RID: 3052 RVA: 0x0003DA91 File Offset: 0x0003BC91
	public virtual void OnMount()
	{
	}

	// Token: 0x06000BED RID: 3053 RVA: 0x0003DA93 File Offset: 0x0003BC93
	public virtual void OnUnmount()
	{
	}

	// Token: 0x06000BEE RID: 3054 RVA: 0x0003DA95 File Offset: 0x0003BC95
	public virtual void OnProjectileExplosion(Vector3 explosionForce)
	{
	}

	// Token: 0x06000BEF RID: 3055 RVA: 0x0003DA97 File Offset: 0x0003BC97
	public virtual bool CanInteractWithRaycast(Ray ray)
	{

        return default;
    }

	// Token: 0x06000BF0 RID: 3056 RVA: 0x0003DA9A File Offset: 0x0003BC9A
	public virtual void OnInteractionDown(Ray ray)
	{
	}

	// Token: 0x06000BF1 RID: 3057 RVA: 0x0003DA9C File Offset: 0x0003BC9C
	public virtual void OnInteractionHold(Camera theCamera, Vector2 movement)
	{
	}

	// Token: 0x06000BF2 RID: 3058 RVA: 0x0003DA9E File Offset: 0x0003BC9E
	public virtual void OnInteractionUp()
	{
	}

	// Token: 0x06000BF3 RID: 3059 RVA: 0x0003DAA0 File Offset: 0x0003BCA0
	public virtual void OnPlasmaInteraction()
	{
	}

	// Token: 0x06000BF4 RID: 3060 RVA: 0x0003DAA2 File Offset: 0x0003BCA2
	public virtual bool CanReactToRaycast(Ray ray)
	{

        return default;
    }

	// Token: 0x06000BF5 RID: 3061 RVA: 0x0003DAA5 File Offset: 0x0003BCA5
	public virtual void OnRaycastInteraction(Ray ray)
	{
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x0003DAA7 File Offset: 0x0003BCA7
	public virtual void OnDock()
	{
	}

	// Token: 0x06000BF7 RID: 3063 RVA: 0x0003DAA9 File Offset: 0x0003BCA9
	public virtual void OnUndock()
	{
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x0003DAAB File Offset: 0x0003BCAB
	public virtual bool CanDock()
	{

        return default;
    }

	// Token: 0x06000BF9 RID: 3065 RVA: 0x0003DAAE File Offset: 0x0003BCAE
	public virtual void OnMountStartListening()
	{
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x0003DAB0 File Offset: 0x0003BCB0
	public virtual void OnMountStopListening()
	{
	}

	// Token: 0x06000BFB RID: 3067 RVA: 0x0003DAB2 File Offset: 0x0003BCB2
	public virtual bool CanMount()
	{

        return default;
    }

	// Token: 0x06000BFC RID: 3068 RVA: 0x0003DAB5 File Offset: 0x0003BCB5
	public virtual void OnPropertyEditorOpen()
	{
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x0003DAB7 File Offset: 0x0003BCB7
	public virtual void OnPropertyEditorClose()
	{
	}

	// Token: 0x06000BFE RID: 3070 RVA: 0x0003DAB9 File Offset: 0x0003BCB9
	public virtual bool CanFocusOnComponent(Ray ray)
	{

        return default;
    }

	// Token: 0x06000BFF RID: 3071 RVA: 0x0003DABC File Offset: 0x0003BCBC
	public virtual void OnFocusDown(Ray ray)
	{
	}

	// Token: 0x06000C00 RID: 3072 RVA: 0x0003DABE File Offset: 0x0003BCBE
	public virtual void OnFocusUpdate(Camera theCamera, Player input)
	{
	}

	// Token: 0x06000C01 RID: 3073 RVA: 0x0003DAC0 File Offset: 0x0003BCC0
	public virtual void OnFocusUp()
	{
	}

	// Token: 0x06000C02 RID: 3074 RVA: 0x0003DAC2 File Offset: 0x0003BCC2
	public virtual void OnSensorTriggerEnter(Collider trigger)
	{
	}

	// Token: 0x06000C03 RID: 3075 RVA: 0x0003DAC4 File Offset: 0x0003BCC4
	public virtual void OnSensorTriggerStay(Collider trigger)
	{
	}

	// Token: 0x06000C04 RID: 3076 RVA: 0x0003DAC6 File Offset: 0x0003BCC6
	public virtual void OnSensorTriggerExit(Collider trigger)
	{
	}

	// Token: 0x06000C05 RID: 3077 RVA: 0x0003DAC8 File Offset: 0x0003BCC8
	public virtual void OnSensorCollisionEnter(Collision collision, DeviceComponentModifier modifier)
	{
	}

	// Token: 0x06000C06 RID: 3078 RVA: 0x0003DACA File Offset: 0x0003BCCA
	public virtual void OnSensorCollisionStay(Collision collision, DeviceComponentModifier modifier)
	{
	}

	// Token: 0x06000C07 RID: 3079 RVA: 0x0003DACC File Offset: 0x0003BCCC
	public virtual void OnSensorCollisionExit(Collision collision, DeviceComponentModifier modifier)
	{
	}

	// Token: 0x06000C08 RID: 3080 RVA: 0x0003DACE File Offset: 0x0003BCCE
	public virtual void OnTransparencyVFXEnter()
	{
	}

	// Token: 0x06000C09 RID: 3081 RVA: 0x0003DAD0 File Offset: 0x0003BCD0
	public virtual void OnTransparencyVFXExit()
	{
	}

	// Token: 0x06000C0A RID: 3082 RVA: 0x0003DAD2 File Offset: 0x0003BCD2
	public virtual float GetLimit(bool unscaled = false)
	{

        return default;
    }

	// Token: 0x04000A7B RID: 2683
	protected ComponentHandler _component;

	// Token: 0x04000A7C RID: 2684
	private Agent _agent;
}
