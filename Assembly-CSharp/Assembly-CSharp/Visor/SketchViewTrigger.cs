using System;
using System.Collections.Generic;
using DataStructures.ViliWonka.KDTree;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Serialization;

namespace Visor
{
	// Token: 0x02000289 RID: 649
	public abstract class SketchViewTrigger : SerializedMonoBehaviour
	{
		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060019A0 RID: 6560 RVA: 0x000822E7 File Offset: 0x000804E7
		// (set) Token: 0x060019A1 RID: 6561 RVA: 0x000822EF File Offset: 0x000804EF
		public SketchViewNode sketchViewNode { get; private set; }

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x000822F8 File Offset: 0x000804F8
		// (set) Token: 0x060019A3 RID: 6563 RVA: 0x00082300 File Offset: 0x00080500
		public SketchViewLabel sketchViewLabel { get; private set; }

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x00082309 File Offset: 0x00080509
		// (set) Token: 0x060019A5 RID: 6565 RVA: 0x00082332 File Offset: 0x00080532
		public int priority
		{
			get
			{
				if (this._container != null)
				{
					return this._container.priorityBase + this.localPriority;
				}
				return this.localPriority;
			}
			set
			{
				this.localPriority = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x0008233B File Offset: 0x0008053B
		// (set) Token: 0x060019A7 RID: 6567 RVA: 0x00082343 File Offset: 0x00080543
		public bool disabled { get; set; }

		// Token: 0x060019A8 RID: 6568 RVA: 0x0008234C File Offset: 0x0008054C
		protected void CommonSetup(SketchView sketchView)
		{

		}

		// Token: 0x060019A9 RID: 6569
		protected abstract void UnregisterPointProviders();

		// Token: 0x060019AA RID: 6570 RVA: 0x000823A9 File Offset: 0x000805A9
		public void CleanUp(bool removeFromContainer)
		{

		}

		// Token: 0x060019AB RID: 6571
		public abstract bool Contains(Vector2 position);

		// Token: 0x060019AC RID: 6572 RVA: 0x000823E4 File Offset: 0x000805E4
		public virtual void OnDrawGizmos()
		{

		}

		// Token: 0x040014CC RID: 5324
		public ISketchViewInteractable handler;

		// Token: 0x040014CD RID: 5325
		[FormerlySerializedAs("priority")]
		public int localPriority;

		// Token: 0x040014CE RID: 5326
		public SketchViewInteractables id;

		// Token: 0x040014CF RID: 5327
		public const float distanceBetweenPoints = 20f;

		// Token: 0x040014D0 RID: 5328
		protected SketchView _sketchView;

		// Token: 0x040014D1 RID: 5329
		protected List<SketchViewTrigger.Point> _kdPoints;

		// Token: 0x040014D2 RID: 5330
		private SketchViewTriggerContainer _container;

		// Token: 0x0200048B RID: 1163
		public class Point : IKDPoint
		{
			// Token: 0x17000585 RID: 1413
			// (get) Token: 0x060023AA RID: 9130 RVA: 0x000AA49D File Offset: 0x000A869D
			// (set) Token: 0x060023AB RID: 9131 RVA: 0x000AA4B5 File Offset: 0x000A86B5
			public Vector3 point
			{
				get
				{
					return this.parent.position + this.position;
				}
				set
				{
				}
			}

			// Token: 0x17000586 RID: 1414
			// (get) Token: 0x060023AC RID: 9132 RVA: 0x000AA4B7 File Offset: 0x000A86B7
			// (set) Token: 0x060023AD RID: 9133 RVA: 0x000AA4BF File Offset: 0x000A86BF
			public object owner { get; set; }

			// Token: 0x04001FF0 RID: 8176
			public Transform parent;

			// Token: 0x04001FF1 RID: 8177
			public Vector3 position;

			// Token: 0x04001FF2 RID: 8178
			public int index;
		}
	}
}
