using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200017D RID: 381
public class WireframeComponentListener : MonoBehaviour
{
	// Token: 0x17000127 RID: 295
	// (get) Token: 0x06000E77 RID: 3703 RVA: 0x00049F4E File Offset: 0x0004814E
	// (set) Token: 0x06000E78 RID: 3704 RVA: 0x00049F56 File Offset: 0x00048156
	public SubComponentHandler subComponent { get; set; }

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x06000E79 RID: 3705 RVA: 0x00049F5F File Offset: 0x0004815F
	public bool isColliding
	{
		get
		{
			return this._colliding;
		}
	}

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x06000E7A RID: 3706 RVA: 0x00049F67 File Offset: 0x00048167
	public bool listen
	{
		get
		{
			return this._listen;
		}
	}

	// Token: 0x06000E7B RID: 3707 RVA: 0x00049F6F File Offset: 0x0004816F
	private void Awake()
	{

	}

	// Token: 0x06000E7C RID: 3708 RVA: 0x00049F7C File Offset: 0x0004817C
	public void SetListening(bool value, bool exemptEntryCollisions)
	{

	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x00049FA0 File Offset: 0x000481A0
	public void OnTriggerEnter(Collider other)
	{

	}

	// Token: 0x06000E7E RID: 3710 RVA: 0x0004A07C File Offset: 0x0004827C
	public void OnTriggerExit(Collider other)
	{

	}

	// Token: 0x06000E7F RID: 3711 RVA: 0x0004A085 File Offset: 0x00048285
	public void OnTriggerStay(Collider other)
	{

	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x0004A0BF File Offset: 0x000482BF
	public void PreTick()
	{

	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x0004A0C8 File Offset: 0x000482C8
	public void PostTick()
	{

	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x0004A104 File Offset: 0x00048304
	private bool IsValidTriggerCollision(Collider otherCollider)
	{

        return default;
    }

	// Token: 0x04000BE6 RID: 3046
	private bool _colliding;

	// Token: 0x04000BE7 RID: 3047
	private bool _listen;

	// Token: 0x04000BE8 RID: 3048
	private int _hackCounter;

	// Token: 0x04000BE9 RID: 3049
	private bool _shaderColliding;

	// Token: 0x04000BEA RID: 3050
	private List<WireframeComponentListener.CollisionPair> _entryCollisions;

	// Token: 0x020003C0 RID: 960
	private struct CollisionPair
	{
		// Token: 0x060020F2 RID: 8434 RVA: 0x000A252C File Offset: 0x000A072C
		public CollisionPair(GameObject myGameObject, GameObject otherGameObject)
		{

		}

		// Token: 0x04001D42 RID: 7490
		public Vector3 myPosition;

		// Token: 0x04001D43 RID: 7491
		public Quaternion myRotation;

		// Token: 0x04001D44 RID: 7492
		public Vector3 myScale;

		// Token: 0x04001D45 RID: 7493
		public GameObject otherGameObject;

		// Token: 0x04001D46 RID: 7494
		public Vector3 otherPosition;

		// Token: 0x04001D47 RID: 7495
		public Quaternion otherRotation;

		// Token: 0x04001D48 RID: 7496
		public Vector3 otherScale;
	}
}
