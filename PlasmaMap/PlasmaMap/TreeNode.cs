using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000155 RID: 341
public class TreeNode : MonoBehaviour
{
	// Token: 0x06000DDA RID: 3546 RVA: 0x00046B42 File Offset: 0x00044D42
	public void Awake()
	{

	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x00046B68 File Offset: 0x00044D68
	public void UpdateVisuals(TreeNode.States state, Color color)
	{

	}

	// Token: 0x04000B2D RID: 2861
	public MeshRenderer iconRenderer;

	// Token: 0x04000B2E RID: 2862
	public Texture baseIcon;

	// Token: 0x04000B2F RID: 2863
	public Texture highlightedIcon;

	// Token: 0x04000B30 RID: 2864
	private MeshRenderer _meshRenderer;

	// Token: 0x04000B31 RID: 2865
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x020003B3 RID: 947
	public enum States
	{
		// Token: 0x04001D10 RID: 7440
		Normal,
		// Token: 0x04001D11 RID: 7441
		Base,
		// Token: 0x04001D12 RID: 7442
		Highlighted
	}
}
}