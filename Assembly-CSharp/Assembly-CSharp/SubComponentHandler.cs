using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000154 RID: 340
public class SubComponentHandler : MonoBehaviour
{
	// Token: 0x1700010A RID: 266
	// (get) Token: 0x06000DAC RID: 3500 RVA: 0x00045DF9 File Offset: 0x00043FF9
	public bool isChildLink
	{
		get
		{
			return this.jointType > SubComponentHandler.Type.None;
		}
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x06000DAD RID: 3501 RVA: 0x00045E04 File Offset: 0x00044004
	// (set) Token: 0x06000DAE RID: 3502 RVA: 0x00045E0C File Offset: 0x0004400C
	public SubComponentHandler.Type jointType { get; private set; }

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06000DAF RID: 3503 RVA: 0x00045E15 File Offset: 0x00044015
	public bool isRootSubComponent
	{
		get
		{
			return this.component.IsSubComponentCurrentRoot(this);
		}
	}

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x00045E23 File Offset: 0x00044023
	public int internalSubComponentIndex
	{
		get
		{
			return this._internalSubComponentIndex;
		}
	}

	// Token: 0x1700010E RID: 270
	// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x00045E2B File Offset: 0x0004402B
	public IEnumerable<SubComponentHandler> childSubComponents
	{
		get
		{
			return this._childSubComponents;
		}
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x00045E33 File Offset: 0x00044033
	public bool hasChildren
	{
		get
		{
			return this._childSubComponents.Count > 0;
		}
	}

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x00045E44 File Offset: 0x00044044
	public IEnumerable<ComponentHandler> childComponents
	{
		get
		{
			List<ComponentHandler> list = new List<ComponentHandler>();
			foreach (SubComponentHandler subComponentHandler in this._childSubComponents)
			{
				list.Add(subComponentHandler.component);
			}
			return list;
		}
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x00045EA4 File Offset: 0x000440A4
	public Vector3 position
	{
		get
		{
			if (this.component.device.isSolid && !this.component.device.isMounted)
			{
				return this.articulationCollidersGroup.position;
			}
			return this.rigidbody.transform.position;
		}
	}

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x00045EF1 File Offset: 0x000440F1
	public Quaternion rotation
	{
		get
		{
			if (this.component.device.isSolid && !this.component.device.isMounted)
			{
				return this.articulationCollidersGroup.rotation;
			}
			return this.rigidbodyCollidersGroup.rotation;
		}
	}

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x00045F2E File Offset: 0x0004412E
	// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x00045F36 File Offset: 0x00044136
	public ArticulationBody articulationBody { get; private set; }

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x00045F3F File Offset: 0x0004413F
	// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x00045F47 File Offset: 0x00044147
	public Rigidbody rigidbody { get; private set; }

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x06000DBA RID: 3514 RVA: 0x00045F50 File Offset: 0x00044150
	// (set) Token: 0x06000DBB RID: 3515 RVA: 0x00045F58 File Offset: 0x00044158
	public WireframeComponentListener wireframeComponentListener { get; private set; }

	// Token: 0x17000116 RID: 278
	// (get) Token: 0x06000DBC RID: 3516 RVA: 0x00045F61 File Offset: 0x00044161
	// (set) Token: 0x06000DBD RID: 3517 RVA: 0x00045F69 File Offset: 0x00044169
	public Transform articulationCollidersGroup { get; private set; }

	// Token: 0x17000117 RID: 279
	// (get) Token: 0x06000DBE RID: 3518 RVA: 0x00045F72 File Offset: 0x00044172
	// (set) Token: 0x06000DBF RID: 3519 RVA: 0x00045F7A File Offset: 0x0004417A
	public Transform rigidbodyCollidersGroup { get; private set; }

	// Token: 0x17000118 RID: 280
	// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x00045F83 File Offset: 0x00044183
	// (set) Token: 0x06000DC1 RID: 3521 RVA: 0x00045F8B File Offset: 0x0004418B
	public Transform renderGroup { get; set; }

	// Token: 0x17000119 RID: 281
	// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x00045F94 File Offset: 0x00044194
	// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x00045F9C File Offset: 0x0004419C
	public ComponentMeshHandler meshHandler { get; set; }

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00045FA5 File Offset: 0x000441A5
	public bool canSolidGrab
	{
		get
		{
			return this._canSolidGrab;
		}
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x00045FAD File Offset: 0x000441AD
	public Collider[] colliders
	{
		get
		{
			return this._colliders;
		}
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x00045FB5 File Offset: 0x000441B5
	// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x00045FBD File Offset: 0x000441BD
	public Device.Branch branch { get; set; }

	// Token: 0x06000DC8 RID: 3528 RVA: 0x00045FC8 File Offset: 0x000441C8
	public void Setup()
	{

	}

	// Token: 0x06000DC9 RID: 3529 RVA: 0x00046088 File Offset: 0x00044288
	public void ForceUpdate()
	{

	}

	// Token: 0x06000DCA RID: 3530 RVA: 0x0004610C File Offset: 0x0004430C
	public void RegenerateAfterSplit(Device device, bool isKinematic)
	{

	}

	// Token: 0x06000DCB RID: 3531 RVA: 0x00046234 File Offset: 0x00044434
	public void MergeUpstream()
	{

	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x000463A4 File Offset: 0x000445A4
	private void MakeRigidbody()
	{

	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x0004644C File Offset: 0x0004464C
	public void ResetParent()
	{

	}

	// Token: 0x06000DCE RID: 3534 RVA: 0x000464C8 File Offset: 0x000446C8
	public void ResetPosition(bool applyDOF = false)
	{

	}

	// Token: 0x06000DCF RID: 3535 RVA: 0x000468B1 File Offset: 0x00044AB1
	public void AddChildSubComponent(SubComponentHandler subComponentHandler)
	{

	}

	// Token: 0x06000DD0 RID: 3536 RVA: 0x000468BF File Offset: 0x00044ABF
	public void RemoveChildSubComponent(SubComponentHandler subComponentHandler)
	{

	}

	// Token: 0x06000DD1 RID: 3537 RVA: 0x000468D0 File Offset: 0x00044AD0
	public void RemoveChildComponent(ComponentHandler componentHandler)
	{

	}

	// Token: 0x06000DD2 RID: 3538 RVA: 0x0004697C File Offset: 0x00044B7C
	public void GetChildSubComponentsRecursive(List<SubComponentHandler> list)
	{

	}

	// Token: 0x06000DD3 RID: 3539 RVA: 0x000469DC File Offset: 0x00044BDC
	public void UpdateScale()
	{

	}

	// Token: 0x06000DD4 RID: 3540 RVA: 0x00046A4E File Offset: 0x00044C4E
	public int GetDofCount()
	{

        return default;
    }

	// Token: 0x06000DD5 RID: 3541 RVA: 0x00046A68 File Offset: 0x00044C68
	public void SetDofLimits(float lowerLimit, float upperLimit)
	{

	}

	// Token: 0x06000DD6 RID: 3542 RVA: 0x00046A9D File Offset: 0x00044C9D
	public float GetDofOffset(int dof)
	{

        return default;
    }

	// Token: 0x06000DD7 RID: 3543 RVA: 0x00046AC7 File Offset: 0x00044CC7
	public void MakingSolid()
	{

	}

	// Token: 0x06000DD8 RID: 3544 RVA: 0x00046AE8 File Offset: 0x00044CE8
	public void SetRenderGroupVisible(bool value)
	{

	}

	// Token: 0x04000B17 RID: 2839
	public int subComponentIndex;

	// Token: 0x04000B18 RID: 2840
	public ComponentHandler component;

	// Token: 0x04000B19 RID: 2841
	public SubComponentHandler parentSubComponent;

	// Token: 0x04000B1A RID: 2842
	public Vector3 axis;

	// Token: 0x04000B1B RID: 2843
	public Vector3 offset;

	// Token: 0x04000B1C RID: 2844
	public List<float> dofOffsets;

	// Token: 0x04000B1D RID: 2845
	public float massRatio = 1f;

	// Token: 0x04000B1E RID: 2846
	private int _internalSubComponentIndex;

	// Token: 0x04000B1F RID: 2847
	private List<SubComponentHandler> _childSubComponents;

	// Token: 0x04000B20 RID: 2848
	private Vector3 _startingLocalPosition = Vector3.zero;

	// Token: 0x04000B21 RID: 2849
	private Quaternion _startingLocalRotation = Quaternion.identity;

	// Token: 0x04000B22 RID: 2850
	private bool _canSolidGrab;

	// Token: 0x04000B23 RID: 2851
	private Collider[] _colliders;

	// Token: 0x020003B2 RID: 946
	public enum Type
	{
		// Token: 0x04001D0A RID: 7434
		None,
		// Token: 0x04001D0B RID: 7435
		Fixed,
		// Token: 0x04001D0C RID: 7436
		Hinge,
		// Token: 0x04001D0D RID: 7437
		Slider,
		// Token: 0x04001D0E RID: 7438
		Ball
	}
}
