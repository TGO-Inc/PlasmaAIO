using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000153 RID: 339
public class SnappingGeneric : MonoBehaviour
{
	// Token: 0x17000108 RID: 264
	// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x00045D12 File Offset: 0x00043F12
	// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x00045D1A File Offset: 0x00043F1A
	public SubComponentHandler owner { get; set; }

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00045D23 File Offset: 0x00043F23
	// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x00045D2B File Offset: 0x00043F2B
	public bool occupiedBySocket { get; set; }

	// Token: 0x06000DA8 RID: 3496 RVA: 0x00045D34 File Offset: 0x00043F34
	public void DetachChild(ComponentHandler componentHandler)
	{

	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x00045D60 File Offset: 0x00043F60
	public bool CanAttachChild(ComponentHandler componentHandler)
	{

        return default;
    }

	// Token: 0x06000DAA RID: 3498 RVA: 0x00045DB9 File Offset: 0x00043FB9
	public void AttachChild(ComponentHandler componentHandler)
	{

	}

	// Token: 0x04000B10 RID: 2832
	public SnappingGeneric.ChildCompatibility childCompatibility;

	// Token: 0x04000B11 RID: 2833
	public SnappingGeneric.ChildOrientationPreference childOrientationPreference;

	// Token: 0x04000B12 RID: 2834
	public int index;

	// Token: 0x04000B13 RID: 2835
	private ComponentHandler _primaryChild;

	// Token: 0x04000B14 RID: 2836
	private ComponentHandler _secondaryChild;

	// Token: 0x020003B0 RID: 944
	public enum ChildCompatibility
	{
		// Token: 0x04001D01 RID: 7425
		Any,
		// Token: 0x04001D02 RID: 7426
		Components,
		// Token: 0x04001D03 RID: 7427
		Structures,
		// Token: 0x04001D04 RID: 7428
		None
	}

	// Token: 0x020003B1 RID: 945
	public enum ChildOrientationPreference
	{
		// Token: 0x04001D06 RID: 7430
		Any,
		// Token: 0x04001D07 RID: 7431
		Vertical,
		// Token: 0x04001D08 RID: 7432
		Horizontal
	}
}
}