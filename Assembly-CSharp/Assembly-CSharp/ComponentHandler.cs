using System;
using System.Collections.Generic;
using System.Linq;
using Common.Extension;
using Common.Math;
using Rewired;
using UnityEngine;

// Token: 0x02000147 RID: 327
public class ComponentHandler : MonoBehaviour
{
	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06000C0C RID: 3084 RVA: 0x0003DAE1 File Offset: 0x0003BCE1
	// (set) Token: 0x06000C0D RID: 3085 RVA: 0x0003DAE9 File Offset: 0x0003BCE9
	public AgentGestalt gestalt { get; set; }

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06000C0E RID: 3086 RVA: 0x0003DAF2 File Offset: 0x0003BCF2
	public int guid
	{
		get
		{
			if (this.agentId != null)
			{
				return this.agentId.guid;
			}
			return -1;
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x06000C0F RID: 3087 RVA: 0x0003DB0F File Offset: 0x0003BD0F
	// (set) Token: 0x06000C10 RID: 3088 RVA: 0x0003DB17 File Offset: 0x0003BD17
	public Device device { get; set; }

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06000C11 RID: 3089 RVA: 0x0003DB20 File Offset: 0x0003BD20
	// (set) Token: 0x06000C12 RID: 3090 RVA: 0x0003DB28 File Offset: 0x0003BD28
	public Articulation articulation { get; set; }

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000C13 RID: 3091 RVA: 0x0003DB31 File Offset: 0x0003BD31
	public AgentId agentId
	{
		get
		{
			return this.agent.agentId;
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0003DB3E File Offset: 0x0003BD3E
	// (set) Token: 0x06000C15 RID: 3093 RVA: 0x0003DB46 File Offset: 0x0003BD46
	public Agent agent { get; set; }

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x06000C16 RID: 3094 RVA: 0x0003DB4F File Offset: 0x0003BD4F
	// (set) Token: 0x06000C17 RID: 3095 RVA: 0x0003DB57 File Offset: 0x0003BD57
	public bool freshlySpawned { get; set; }

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x06000C18 RID: 3096 RVA: 0x0003DB60 File Offset: 0x0003BD60
	// (set) Token: 0x06000C19 RID: 3097 RVA: 0x0003DB68 File Offset: 0x0003BD68
	public bool freshlyCloned { get; set; }

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06000C1A RID: 3098 RVA: 0x0003DB74 File Offset: 0x0003BD74
	public IEnumerable<ComponentHandler> childComponents
	{
		get
		{
			List<ComponentHandler> list = new List<ComponentHandler>();
			foreach (SubComponentHandler subComponentHandler in this._subComponents.Values)
			{
				list.AddRange(subComponentHandler.childComponents);
			}
			return list;
		}
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06000C1B RID: 3099 RVA: 0x0003DBD8 File Offset: 0x0003BDD8
	public bool hasChildren
	{
		get
		{
			using (Dictionary<int, SubComponentHandler>.ValueCollection.Enumerator enumerator = this._subComponents.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.hasChildren)
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06000C1C RID: 3100 RVA: 0x0003DC38 File Offset: 0x0003BE38
	// (set) Token: 0x06000C1D RID: 3101 RVA: 0x0003DC40 File Offset: 0x0003BE40
	public bool isBroken { get; set; }

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0003DC49 File Offset: 0x0003BE49
	public ComponentDriver componentDriver
	{
		get
		{
			return this._componentDriver;
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06000C1F RID: 3103 RVA: 0x0003DC51 File Offset: 0x0003BE51
	// (set) Token: 0x06000C20 RID: 3104 RVA: 0x0003DC59 File Offset: 0x0003BE59
	public Colorizer colorizer { get; private set; }

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06000C21 RID: 3105 RVA: 0x0003DC62 File Offset: 0x0003BE62
	// (set) Token: 0x06000C22 RID: 3106 RVA: 0x0003DC6A File Offset: 0x0003BE6A
	public TreeNode treeNode { get; private set; }

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06000C23 RID: 3107 RVA: 0x0003DC73 File Offset: 0x0003BE73
	// (set) Token: 0x06000C24 RID: 3108 RVA: 0x0003DC7B File Offset: 0x0003BE7B
	public int treeNodeIndex { get; set; }

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x06000C25 RID: 3109 RVA: 0x0003DC84 File Offset: 0x0003BE84
	// (set) Token: 0x06000C26 RID: 3110 RVA: 0x0003DC8C File Offset: 0x0003BE8C
	public VFXComponent vfxComponent { get; private set; }

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x06000C27 RID: 3111 RVA: 0x0003DC95 File Offset: 0x0003BE95
	// (set) Token: 0x06000C28 RID: 3112 RVA: 0x0003DC9D File Offset: 0x0003BE9D
	public Vector3 scale { get; set; }

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x06000C29 RID: 3113 RVA: 0x0003DCA6 File Offset: 0x0003BEA6
	// (set) Token: 0x06000C2A RID: 3114 RVA: 0x0003DCAE File Offset: 0x0003BEAE
	public Vector3 pitchYawRoll { get; set; }

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x06000C2B RID: 3115 RVA: 0x0003DCB8 File Offset: 0x0003BEB8
	// (set) Token: 0x06000C2C RID: 3116 RVA: 0x0003DCD3 File Offset: 0x0003BED3
	public Quaternion attachmentPivotLocalRotation
	{
		get
		{
			Vector3 pitchYawRoll = this.pitchYawRoll;
			return QuaternionUtil.PlasmaAngles(pitchYawRoll);
		}
		set
		{
			this.pitchYawRoll = value.GetPlasmaAngles();
		}
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x06000C2D RID: 3117 RVA: 0x0003DCE2 File Offset: 0x0003BEE2
	// (set) Token: 0x06000C2E RID: 3118 RVA: 0x0003DCEA File Offset: 0x0003BEEA
	public float attachmentPointOffset { get; set; }

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06000C2F RID: 3119 RVA: 0x0003DCF3 File Offset: 0x0003BEF3
	// (set) Token: 0x06000C30 RID: 3120 RVA: 0x0003DD06 File Offset: 0x0003BF06
	public FemaleSocketPoint currentLocalFemaleSocketPoint
	{
		get
		{
			return this._femaleSocketPoints[this._currentLocalFemaleSocketPointID];
		}
		set
		{
			this._currentLocalFemaleSocketPointID = this._femaleSocketPoints.IndexOf(value);
		}
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06000C31 RID: 3121 RVA: 0x0003DD1A File Offset: 0x0003BF1A
	// (set) Token: 0x06000C32 RID: 3122 RVA: 0x0003DD22 File Offset: 0x0003BF22
	public Dictionary<AssetController.ResourceTypes, List<int>> resourceIDs { get; set; }

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x06000C33 RID: 3123 RVA: 0x0003DD2B File Offset: 0x0003BF2B
	// (set) Token: 0x06000C34 RID: 3124 RVA: 0x0003DD48 File Offset: 0x0003BF48
	public Vector3 wireframePosition
	{
		get
		{
			return this._subComponents[0].rigidbody.transform.position;
		}
		set
		{
			this._subComponents[0].rigidbody.transform.position = value;
			this._subComponents[0].rigidbody.position = value;
		}
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06000C35 RID: 3125 RVA: 0x0003DD7D File Offset: 0x0003BF7D
	// (set) Token: 0x06000C36 RID: 3126 RVA: 0x0003DD95 File Offset: 0x0003BF95
	public Quaternion wireframeRotation
	{
		get
		{
			return this._subComponents[0].rigidbody.rotation;
		}
		set
		{
			this._subComponents[0].rigidbody.transform.rotation = value;
			this._subComponents[0].rigidbody.rotation = value;
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000C37 RID: 3127 RVA: 0x0003DDCA File Offset: 0x0003BFCA
	public Transform wireframeTransform
	{
		get
		{
			return this._subComponents[0].rigidbodyCollidersGroup.transform;
		}
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06000C38 RID: 3128 RVA: 0x0003DDE2 File Offset: 0x0003BFE2
	public Vector3 solidPosition
	{
		get
		{
			return this._subComponents[0].articulationCollidersGroup.position;
		}
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x06000C39 RID: 3129 RVA: 0x0003DDFA File Offset: 0x0003BFFA
	public Quaternion solidRotation
	{
		get
		{
			return this._subComponents[0].articulationCollidersGroup.rotation;
		}
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x06000C3A RID: 3130 RVA: 0x0003DE12 File Offset: 0x0003C012
	public Transform solidTransform
	{
		get
		{
			return this._subComponents[0].articulationCollidersGroup.transform;
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x06000C3B RID: 3131 RVA: 0x0003DE2A File Offset: 0x0003C02A
	public Vector3 livePosition
	{
		get
		{
			if (!this.device.isSolid)
			{
				return this.wireframePosition;
			}
			return this.solidPosition;
		}
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0003DE48 File Offset: 0x0003C048
	public Quaternion interpolatedRotation
	{
		get
		{
			foreach (ComponentMeshHandler componentMeshHandler in this._componentMeshHandlers)
			{
				if (componentMeshHandler.subComponent == this.baseSubComponent)
				{
					return componentMeshHandler.transform.rotation;
				}
			}
			return Quaternion.identity;
		}
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x06000C3D RID: 3133 RVA: 0x0003DEBC File Offset: 0x0003C0BC
	public IEnumerable<SubComponentHandler> allSubComponents
	{
		get
		{
			return this._subComponents.Values;
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x06000C3E RID: 3134 RVA: 0x0003DEC9 File Offset: 0x0003C0C9
	public int subComponentsCount
	{
		get
		{
			return this._subComponents.Count;
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x06000C3F RID: 3135 RVA: 0x0003DED6 File Offset: 0x0003C0D6
	public bool shouldSaveToMechanicState
	{
		get
		{
			return this._subComponents.Count > 1;
		}
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06000C40 RID: 3136 RVA: 0x0003DEE6 File Offset: 0x0003C0E6
	public Vector3 parentWorldPositionReferenceFrame
	{
		get
		{
			return this.parentSubComponent.rigidbody.transform.TransformPoint(Vector3.Scale(this.parentSubComponent.component.scale, this.parentReferenceFrame.position));
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06000C41 RID: 3137 RVA: 0x0003DF1D File Offset: 0x0003C11D
	public Quaternion parentWorldRotationReferenceFrame
	{
		get
		{
			return this.parentSubComponent.rigidbody.transform.rotation * this.parentReferenceFrame.rotation;
		}
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06000C42 RID: 3138 RVA: 0x0003DF44 File Offset: 0x0003C144
	public Quaternion childWorldRotationReferenceFrame
	{
		get
		{
			return this.childSubComponent.rigidbody.transform.rotation * this.childReferenceFrame.rotation;
		}
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x06000C43 RID: 3139 RVA: 0x0003DF6B File Offset: 0x0003C16B
	// (set) Token: 0x06000C44 RID: 3140 RVA: 0x0003DF73 File Offset: 0x0003C173
	public Quaternion attachmentReferenceFrame { get; private set; }

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x06000C45 RID: 3141 RVA: 0x0003DF7C File Offset: 0x0003C17C
	// (set) Token: 0x06000C46 RID: 3142 RVA: 0x0003DF84 File Offset: 0x0003C184
	public FemaleSocketPoint childAttachmentSocket { get; private set; }

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x06000C47 RID: 3143 RVA: 0x0003DF8D File Offset: 0x0003C18D
	// (set) Token: 0x06000C48 RID: 3144 RVA: 0x0003DF95 File Offset: 0x0003C195
	public FemaleSocketPoint parentAttachmentSocket { get; private set; }

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x06000C49 RID: 3145 RVA: 0x0003DF9E File Offset: 0x0003C19E
	// (set) Token: 0x06000C4A RID: 3146 RVA: 0x0003DFA6 File Offset: 0x0003C1A6
	public SubComponentHandler lastDetachedParent { get; set; }

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x06000C4B RID: 3147 RVA: 0x0003DFAF File Offset: 0x0003C1AF
	public bool isRootComponent
	{
		get
		{
			return this.device.rootComponent == this;
		}
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x06000C4C RID: 3148 RVA: 0x0003DFC2 File Offset: 0x0003C1C2
	public SubComponentHandler baseSubComponent
	{
		get
		{
			return this._subComponents[0];
		}
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x06000C4D RID: 3149 RVA: 0x0003DFD0 File Offset: 0x0003C1D0
	// (set) Token: 0x06000C4E RID: 3150 RVA: 0x0003DFD8 File Offset: 0x0003C1D8
	public SubComponentHandler parentSubComponent { get; private set; }

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x06000C4F RID: 3151 RVA: 0x0003DFE1 File Offset: 0x0003C1E1
	// (set) Token: 0x06000C50 RID: 3152 RVA: 0x0003DFE9 File Offset: 0x0003C1E9
	public SubComponentHandler childSubComponent { get; private set; }

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x06000C51 RID: 3153 RVA: 0x0003DFF4 File Offset: 0x0003C1F4
	public bool isTriggerColliding
	{
		get
		{
			foreach (SubComponentHandler subComponentHandler in this.allSubComponents)
			{
				if (subComponentHandler.wireframeComponentListener != null && subComponentHandler.wireframeComponentListener.isColliding)
				{
					return true;
				}
			}
			return false;
		}
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0003E05C File Offset: 0x0003C25C
	public IEnumerable<ComponentMeshHandler> componentMeshHandlers
	{
		get
		{
			return this._componentMeshHandlers;
		}
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x06000C53 RID: 3155 RVA: 0x0003E064 File Offset: 0x0003C264
	public AgentGestalt.MassCategories massCategory
	{
		get
		{
			return this._massCategory;
		}
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x06000C55 RID: 3157 RVA: 0x0003E075 File Offset: 0x0003C275
	// (set) Token: 0x06000C54 RID: 3156 RVA: 0x0003E06C File Offset: 0x0003C26C
	public float massMultiplier
	{
		get
		{
			return this._massMultiplier;
		}
		set
		{
			this._massMultiplier = value;
		}
	}

	// Token: 0x170000C6 RID: 198
	// (get) Token: 0x06000C56 RID: 3158 RVA: 0x0003E07D File Offset: 0x0003C27D
	// (set) Token: 0x06000C57 RID: 3159 RVA: 0x0003E08A File Offset: 0x0003C28A
	public float bounciness
	{
		get
		{
			return this._physicMaterial.bounciness;
		}
		set
		{
			this._physicMaterial.bounciness = value;
		}
	}

	// Token: 0x170000C7 RID: 199
	// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0003E098 File Offset: 0x0003C298
	// (set) Token: 0x06000C59 RID: 3161 RVA: 0x0003E0A5 File Offset: 0x0003C2A5
	public float dynamicFriction
	{
		get
		{
			return this._physicMaterial.dynamicFriction;
		}
		set
		{
			this._physicMaterial.dynamicFriction = value;
		}
	}

	// Token: 0x170000C8 RID: 200
	// (get) Token: 0x06000C5A RID: 3162 RVA: 0x0003E0B3 File Offset: 0x0003C2B3
	// (set) Token: 0x06000C5B RID: 3163 RVA: 0x0003E0C0 File Offset: 0x0003C2C0
	public float staticFriction
	{
		get
		{
			return this._physicMaterial.staticFriction;
		}
		set
		{
			this._physicMaterial.staticFriction = value;
		}
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0003E0CE File Offset: 0x0003C2CE
	// (set) Token: 0x06000C5D RID: 3165 RVA: 0x0003E0D6 File Offset: 0x0003C2D6
	public float audioVolume { get; set; }

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x06000C5E RID: 3166 RVA: 0x0003E0DF File Offset: 0x0003C2DF
	public AgentGestalt.NUSDefinition nusDefinition
	{
		get
		{
			if (this.gestalt.nusDefinitions != null && this._currentNusLabelIndex != -1)
			{
				return this.gestalt.nusDefinitions[this._currentNusLabelIndex];
			}
			return null;
		}
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x06000C5F RID: 3167 RVA: 0x0003E10F File Offset: 0x0003C30F
	public bool uniformScalingActive
	{
		get
		{
			return this._currentNusLabelIndex == -1;
		}
	}

	// Token: 0x170000CC RID: 204
	// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0003E11A File Offset: 0x0003C31A
	public int currentNusLabelIndex
	{
		get
		{
			return this._currentNusLabelIndex;
		}
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06000C61 RID: 3169 RVA: 0x0003E122 File Offset: 0x0003C322
	// (set) Token: 0x06000C62 RID: 3170 RVA: 0x0003E12A File Offset: 0x0003C32A
	public SnappingGeneric parentSnappingObject { get; set; }

	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06000C63 RID: 3171 RVA: 0x0003E133 File Offset: 0x0003C333
	// (set) Token: 0x06000C64 RID: 3172 RVA: 0x0003E13B File Offset: 0x0003C33B
	public Transform dockingPoint { get; private set; }

	// Token: 0x170000CF RID: 207
	// (get) Token: 0x06000C65 RID: 3173 RVA: 0x0003E144 File Offset: 0x0003C344
	public ArticulationBody ownerArticulationBody
	{
		get
		{
			return this.GetSubComponent(0).articulationCollidersGroup.GetComponentsInParent<ArticulationBody>(true)[0];
		}
	}

	// Token: 0x170000D0 RID: 208
	// (get) Token: 0x06000C66 RID: 3174 RVA: 0x0003E15A File Offset: 0x0003C35A
	public PhysicMaterial physicMaterial
	{
		get
		{
			return this._physicMaterial;
		}
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x0003E164 File Offset: 0x0003C364
	private void Awake()
	{

	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x0003E384 File Offset: 0x0003C584
	private void MakeComponentMeshHandler()
	{

	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x0003E5D0 File Offset: 0x0003C7D0
	public bool ShouldBreak()
	{

        return default;
    }

	// Token: 0x06000C6A RID: 3178 RVA: 0x0003E5F5 File Offset: 0x0003C7F5
	public void Paint(int colorIndex, bool secondary)
	{

	}

	// Token: 0x06000C6B RID: 3179 RVA: 0x0003E62F File Offset: 0x0003C82F
	public int GetPaintColor()
	{

        return default;
    }

	// Token: 0x06000C6C RID: 3180 RVA: 0x0003E64C File Offset: 0x0003C84C
	public int GetAltPaintColor()
	{

        return default;
    }

	// Token: 0x06000C6D RID: 3181 RVA: 0x0003E66C File Offset: 0x0003C86C
	public void UpdateScale()
	{

	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x0003E8E4 File Offset: 0x0003CAE4
	public Quaternion CycleRootComponentRotation(bool forward)
	{

        return default;
    }

	// Token: 0x06000C6F RID: 3183 RVA: 0x0003E95B File Offset: 0x0003CB5B
	public void ResetRootComponentRotationCycle()
	{

	}

	// Token: 0x06000C70 RID: 3184 RVA: 0x0003E964 File Offset: 0x0003CB64
	public void SetScaleFromAdvancedHud(float scaleValue, AgentGestalt.NUSDefinition theNUSDefinition)
	{

	}

	// Token: 0x06000C71 RID: 3185 RVA: 0x0003EA24 File Offset: 0x0003CC24
	public float GetScaleValueForLabelIndex(int labelIndex)
	{

        return default;
    }

	// Token: 0x06000C72 RID: 3186 RVA: 0x0003EADB File Offset: 0x0003CCDB
	public float GetOffsetPercentageValue()
	{

        return default;
    }

	// Token: 0x06000C73 RID: 3187 RVA: 0x0003EB00 File Offset: 0x0003CD00
	public Vector3 StepComponentScale(AgentGestalt.NUSDefinition theNUSDefinition, int direction)
	{

        return default;
    }

	// Token: 0x06000C74 RID: 3188 RVA: 0x0003EED0 File Offset: 0x0003D0D0
	public void CycleNUSLabel(bool forward)
	{

	}

	// Token: 0x06000C75 RID: 3189 RVA: 0x0003EF40 File Offset: 0x0003D140
	public Vector3 ClampScale(Vector3 theScale)
	{

        return default;
    }

	// Token: 0x06000C76 RID: 3190 RVA: 0x0003EFE4 File Offset: 0x0003D1E4
	public float GetScaleRatio()
	{

        return default;
    }

	// Token: 0x06000C77 RID: 3191 RVA: 0x0003F004 File Offset: 0x0003D204
	public void StoreInterpolationState()
	{

	}

	// Token: 0x06000C78 RID: 3192 RVA: 0x0003F054 File Offset: 0x0003D254
	public void Interpolate(float delta, bool mounted = false)
	{

	}

	// Token: 0x06000C79 RID: 3193 RVA: 0x0003F0B4 File Offset: 0x0003D2B4
	public void OverrideInterpolationTransforms()
	{

	}

	// Token: 0x06000C7A RID: 3194 RVA: 0x0003F104 File Offset: 0x0003D304
	public void SetEnabled(bool value)
	{

	}

	// Token: 0x06000C7B RID: 3195 RVA: 0x0003F1B4 File Offset: 0x0003D3B4
	public void MergeUpstream()
	{

	}

	// Token: 0x06000C7C RID: 3196 RVA: 0x0003F280 File Offset: 0x0003D480
	public float GetMass()
	{

        return default;
    }

	// Token: 0x06000C7D RID: 3197 RVA: 0x0003F2D8 File Offset: 0x0003D4D8
	public void SetMeshCollidersEnabled(bool value)
	{

	}

	// Token: 0x06000C7E RID: 3198 RVA: 0x0003F370 File Offset: 0x0003D570
	public void SetMeshCollidersLayers(int layer)
	{

	}

	// Token: 0x06000C7F RID: 3199 RVA: 0x0003F3C4 File Offset: 0x0003D5C4
	public void SetWireframeCollidersEnabled(bool value)
	{

	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x0003F4B0 File Offset: 0x0003D6B0
	public void SetWireframeCollidersToTrigger(bool value)
	{

	}

	// Token: 0x06000C81 RID: 3201 RVA: 0x0003F590 File Offset: 0x0003D790
	public void SetPhysicsCollidersEnabled(bool value, bool exemptEntryCollisions = true)
	{

	}

	// Token: 0x06000C82 RID: 3202 RVA: 0x0003F61C File Offset: 0x0003D81C
	public void MakingSolid()
	{

	}

	// Token: 0x06000C83 RID: 3203 RVA: 0x0003F668 File Offset: 0x0003D868
	public void SimulatePhysicsContraints()
	{

	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x0003F694 File Offset: 0x0003D894
	public void PreTickTriggerListeners()
	{

	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x0003F6F4 File Offset: 0x0003D8F4
	public void PostTickTriggerListeners()
	{

	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x0003F754 File Offset: 0x0003D954
	public SubComponentHandler GetSubComponent(int subComponentIndex)
	{

        return default;
    }

	// Token: 0x06000C87 RID: 3207 RVA: 0x0003F764 File Offset: 0x0003D964
	public void RebaseComponentWithSubComponentAsRoot(SubComponentHandler subComponent, bool makeBase)
	{

	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x0003F8F4 File Offset: 0x0003DAF4
	private void SwapParentAndChildInternalNew(ArticulationBody newParentBody, SubComponentHandler subComponent, SubComponentHandler theParentSubComponent)
	{

	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x0003F9DC File Offset: 0x0003DBDC
	public bool IsSubComponentCurrentRoot(SubComponentHandler subComponentHandler)
	{

        return default;
    }

	// Token: 0x06000C8A RID: 3210 RVA: 0x0003F9E7 File Offset: 0x0003DBE7
	public bool CanHaveZeroMass()
	{

        return default;
    }

	// Token: 0x06000C8B RID: 3211 RVA: 0x0003FA0C File Offset: 0x0003DC0C
	public void SetParentSubComponent(SubComponentHandler subComponentHandler)
	{

	}

	// Token: 0x06000C8C RID: 3212 RVA: 0x0003FA15 File Offset: 0x0003DC15
	public void SetChildSubComponent(SubComponentHandler subComponentHandler)
	{

	}

	// Token: 0x06000C8D RID: 3213 RVA: 0x0003FA1E File Offset: 0x0003DC1E
	public void SetAttachmentReferenceFrame(Quaternion q)
	{

	}

	// Token: 0x06000C8E RID: 3214 RVA: 0x0003FA27 File Offset: 0x0003DC27
	public void SetChildAttachmentSocketPoint(FemaleSocketPoint femaleSocketPoint)
	{

	}

	// Token: 0x06000C8F RID: 3215 RVA: 0x0003FA37 File Offset: 0x0003DC37
	public void SetParentAttachmentSocketPoint(FemaleSocketPoint femaleSocketPoint)
	{

	}

	// Token: 0x06000C90 RID: 3216 RVA: 0x0003FA40 File Offset: 0x0003DC40
	public void RemoveChildFromAllSubComponents(SubComponentHandler childToRemove)
	{

	}

	// Token: 0x06000C91 RID: 3217 RVA: 0x0003FA8C File Offset: 0x0003DC8C
	public void DoAttachmentCalculations()
	{

	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x0003FAA4 File Offset: 0x0003DCA4
	public void UpdateTransforms()
	{

	}

	// Token: 0x06000C93 RID: 3219 RVA: 0x0003FC34 File Offset: 0x0003DE34
	public void StoreLocalTransforms()
	{

	}

	// Token: 0x06000C94 RID: 3220 RVA: 0x0003FC84 File Offset: 0x0003DE84
	public void CalculatePreviewTransforms(SubComponentHandler theParentSubComponent, Vector3 positionReferenceFrame, Quaternion rotationReferenceFrame, out Vector3 worldPosition, out Quaternion worldRotation)
	{
        worldPosition = default;
        worldRotation = default;

	}

	// Token: 0x06000C95 RID: 3221 RVA: 0x0003FE10 File Offset: 0x0003E010
	public void UpdateOrientationPreference(SnappingGeneric.ChildOrientationPreference childOrientationPreference)
	{

	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x0003FED4 File Offset: 0x0003E0D4
	public void SetCurrentFemaleSocketIndex(int value)
	{

	}

	// Token: 0x06000C97 RID: 3223 RVA: 0x0003FEDD File Offset: 0x0003E0DD
	public int GetCurrentFemaleSocketIndex()
	{

        return default;
    }

	// Token: 0x06000C98 RID: 3224 RVA: 0x0003FEE5 File Offset: 0x0003E0E5
	public bool CanHandleInteraction(Ray ray)
	{

        return default;
    }

	// Token: 0x06000C99 RID: 3225 RVA: 0x0003FF03 File Offset: 0x0003E103
	public bool InteractionAllowsPlayerLookAround()
	{

        return default;
    }

	// Token: 0x06000C9A RID: 3226 RVA: 0x0003FF13 File Offset: 0x0003E113
	public bool InteractionTriggeredByPlasma()
	{

        return default;
    }

	// Token: 0x06000C9B RID: 3227 RVA: 0x0003FF20 File Offset: 0x0003E120
	public void HandleInteractionDown(Ray ray)
	{

	}

	// Token: 0x06000C9C RID: 3228 RVA: 0x0003FF3C File Offset: 0x0003E13C
	public void HandleInteractionUp()
	{

	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x0003FF57 File Offset: 0x0003E157
	public void HandleInteractionHold(Camera theCamera, Vector2 movement)
	{

	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x0003FF74 File Offset: 0x0003E174
	public void HandlePlasmaInteraction()
	{

	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x0003FF8F File Offset: 0x0003E18F
	public bool CanHandleRaycast(Ray ray)
	{

        return default;
    }

	// Token: 0x06000CA0 RID: 3232 RVA: 0x0003FFAD File Offset: 0x0003E1AD
	public void HandleRaycast(Ray ray)
	{

	}

	// Token: 0x06000CA1 RID: 3233 RVA: 0x0003FFC9 File Offset: 0x0003E1C9
	public bool CanHandleFocus(Ray ray)
	{

        return default;
    }

	// Token: 0x06000CA2 RID: 3234 RVA: 0x0003FFE7 File Offset: 0x0003E1E7
	public bool FocusAllowsPlayerLookAround()
	{

        return default;
    }

	// Token: 0x06000CA3 RID: 3235 RVA: 0x0003FFF7 File Offset: 0x0003E1F7
	public void HandleFocusDown(Ray ray)
	{

	}

	// Token: 0x06000CA4 RID: 3236 RVA: 0x00040013 File Offset: 0x0003E213
	public void HandleFocusUp()
	{

	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x0004002E File Offset: 0x0003E22E
	public void HandleFocusHold(Camera theCamera, Player input)
	{

	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x0004004C File Offset: 0x0003E24C
	public IEnumerable<ComponentHandler> GetChildren(bool recursive, List<ComponentHandler> list = null)
	{

        return default;
    }

	// Token: 0x06000CA7 RID: 3239 RVA: 0x000400B4 File Offset: 0x0003E2B4
	public void HandleDocking()
	{

	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x000400CF File Offset: 0x0003E2CF
	public void HandleUndocking()
	{

	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x000400EA File Offset: 0x0003E2EA
	public bool CanDock()
	{

        return default;
    }

	// Token: 0x06000CAA RID: 3242 RVA: 0x00040107 File Offset: 0x0003E307
	public bool CanMount()
	{

        return default;
    }

	// Token: 0x06000CAB RID: 3243 RVA: 0x00040124 File Offset: 0x0003E324
	public void HandleMountModifierStart()
	{

	}

	// Token: 0x06000CAC RID: 3244 RVA: 0x0004013F File Offset: 0x0003E33F
	public void HandleMountModifierStop()
	{

	}

	// Token: 0x06000CAD RID: 3245 RVA: 0x0004015C File Offset: 0x0003E35C
	public IEnumerable<VFXComponent> GetVFXChildren(bool recursive, bool includeBroken = true, bool includeSelf = true)
	{

        return default;
    }

	// Token: 0x06000CAE RID: 3246 RVA: 0x000401F0 File Offset: 0x0003E3F0
	public void SetWireframeColorColliding(bool colliding)
	{

	}

	// Token: 0x06000CAF RID: 3247 RVA: 0x00040200 File Offset: 0x0003E400
	public void SetSocketsEnabled(bool value)
	{

	}

	// Token: 0x06000CB0 RID: 3248 RVA: 0x00040258 File Offset: 0x0003E458
	public void AddSocket(FemaleSocketPoint newSocket, bool fromLoad = false)
	{

	}

	// Token: 0x06000CB1 RID: 3249 RVA: 0x000402D0 File Offset: 0x0003E4D0
	public void DeleteSocket(GameObject socketToDelete)
	{

	}

	// Token: 0x06000CB2 RID: 3250 RVA: 0x00040370 File Offset: 0x0003E570
	public List<FemaleSocketPoint> GetCustomSockets()
	{

        return default;
    }

	// Token: 0x06000CB3 RID: 3251 RVA: 0x000403D4 File Offset: 0x0003E5D4
	public SnappingGeneric GetSnappingObjectByIndex(int index)
	{

        return default;
    }

	// Token: 0x06000CB4 RID: 3252 RVA: 0x00040430 File Offset: 0x0003E630
	public FemaleSocketPoint GetSocketByIndex(int index)
	{

        return default;
    }

	// Token: 0x06000CB5 RID: 3253 RVA: 0x0004048C File Offset: 0x0003E68C
	public FemaleSocketPoint GetSocketAtPosition(Vector3 worldPosition)
	{

        return default;
    }

	// Token: 0x06000CB6 RID: 3254 RVA: 0x000404F4 File Offset: 0x0003E6F4
	public bool ValidateCurrentFemaleSocket(int increment)
	{

        return default;
    }

	// Token: 0x06000CB7 RID: 3255 RVA: 0x0004054C File Offset: 0x0003E74C
	private void StepFemaleSocketPoint(int increment)
	{

	}

	// Token: 0x06000CB8 RID: 3256 RVA: 0x000405A4 File Offset: 0x0003E7A4
	public void SetSnappingPointsEnabled(bool value)
	{

	}

	// Token: 0x06000CB9 RID: 3257 RVA: 0x000405E0 File Offset: 0x0003E7E0
	public void SetSnappingPointsEnabled(bool value, ComponentHandler child, SnappingGeneric.ChildCompatibility snappingPointChildCompatibility)
	{

	}

	// Token: 0x06000CBA RID: 3258 RVA: 0x00040674 File Offset: 0x0003E874
	public void SetRenderGroupVisible(bool value)
	{

	}

	// Token: 0x06000CBB RID: 3259 RVA: 0x000406C0 File Offset: 0x0003E8C0
	public void SetRaycastMeshColliderEnabled(bool value)
	{

	}

	// Token: 0x04000A7D RID: 2685
	public QTransform parentReferenceFrame;

	// Token: 0x04000A7E RID: 2686
	public QTransform childReferenceFrame;

	// Token: 0x04000A7F RID: 2687
	public const float maxMassMultiplier = 14f;

	// Token: 0x04000A80 RID: 2688
	private Dictionary<int, SubComponentHandler> _subComponents;

	// Token: 0x04000A81 RID: 2689
	private ComponentDriver _componentDriver;

	// Token: 0x04000A82 RID: 2690
	private PlasmaPhysicsConstraint[] _physicsConstraints;

	// Token: 0x04000A83 RID: 2691
	private List<FemaleSocketPoint> _femaleSocketPoints;

	// Token: 0x04000A84 RID: 2692
	private int _currentLocalFemaleSocketPointID;

	// Token: 0x04000A85 RID: 2693
	private List<SnappingGeneric> _snappingObjects;

	// Token: 0x04000A86 RID: 2694
	private List<ComponentMeshHandler> _componentMeshHandlers;

	// Token: 0x04000A87 RID: 2695
	private DynamicGridProjector[] _dynamicGridProjectors;

	// Token: 0x04000A88 RID: 2696
	private StructureTriggerListener[] _structureTriggerListener;

	// Token: 0x04000A89 RID: 2697
	private int _rootComponentAxisRotation;

	// Token: 0x04000A8A RID: 2698
	private AgentGestalt.MassCategories _massCategory;

	// Token: 0x04000A8B RID: 2699
	private float _massMultiplier;

	// Token: 0x04000A8C RID: 2700
	private int _currentNusLabelIndex;

	// Token: 0x04000A8D RID: 2701
	private PhysicMaterial _physicMaterial;

	// Token: 0x04000A8E RID: 2702
	private static List<Vector3> _cycleRotations = new List<Vector3>
	{
		Vector3.forward,
		Vector3.down,
		Vector3.back,
		Vector3.left,
		Vector3.up,
		Vector3.right
	};
}
