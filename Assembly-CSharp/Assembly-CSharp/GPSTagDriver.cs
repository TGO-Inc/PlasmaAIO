using System;
using UnityEngine;

// Token: 0x02000089 RID: 137
public class GPSTagDriver : ComponentDriver
{
	// Token: 0x17000075 RID: 117
	// (get) Token: 0x060006E7 RID: 1767 RVA: 0x00027D58 File Offset: 0x00025F58
	public Vector3 worldPosition
	{
		get
		{
			return this._transform.position;
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00027D65 File Offset: 0x00025F65
	public Vector3 velocity
	{
		get
		{
			return this._articulationBody.velocity;
		}
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x00027D72 File Offset: 0x00025F72
	protected override void OnAgentSet()
	{

	}

	// Token: 0x060006EA RID: 1770 RVA: 0x00027D9D File Offset: 0x00025F9D
	public override void OnSolidEnter()
	{

	}

	// Token: 0x060006EB RID: 1771 RVA: 0x00027DC6 File Offset: 0x00025FC6
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x060006EC RID: 1772 RVA: 0x00027DDD File Offset: 0x00025FDD
	public override void OnMount()
	{

	}

	// Token: 0x060006ED RID: 1773 RVA: 0x00027DF6 File Offset: 0x00025FF6
	public override void OnUnmount()
	{

	}

	// Token: 0x0400063A RID: 1594
	private AgentProperty _idProperty;

	// Token: 0x0400063B RID: 1595
	private Transform _transform;

	// Token: 0x0400063C RID: 1596
	private ArticulationBody _articulationBody;
}
