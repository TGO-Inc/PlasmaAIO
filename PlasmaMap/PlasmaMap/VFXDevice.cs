using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using PlasmaAPI.GameClass.EasyFSM;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000197 RID: 407
public class VFXDevice : MonoBehaviour
{
	// Token: 0x1700013A RID: 314
	// (get) Token: 0x06000F10 RID: 3856 RVA: 0x0004D524 File Offset: 0x0004B724
	public IEnumerable<MeshRenderer> allMeshRenderers
	{
		get
		{
			return this._cachedMeshRenderers;
		}
	}

	// Token: 0x1700013B RID: 315
	// (get) Token: 0x06000F11 RID: 3857 RVA: 0x0004D52C File Offset: 0x0004B72C
	public Bounds bounds
	{
		get
		{
			return this._cachedBounds;
		}
	}

	// Token: 0x1700013C RID: 316
	// (get) Token: 0x06000F12 RID: 3858 RVA: 0x0004D534 File Offset: 0x0004B734
	// (set) Token: 0x06000F13 RID: 3859 RVA: 0x0004D53C File Offset: 0x0004B73C
	public VFXDevice.Commands command { get; set; }

	// Token: 0x06000F14 RID: 3860 RVA: 0x0004D545 File Offset: 0x0004B745
	private void Awake()
	{

	}

	// Token: 0x06000F15 RID: 3861 RVA: 0x0004D56F File Offset: 0x0004B76F
	private void Start()
	{

	}

	// Token: 0x06000F16 RID: 3862 RVA: 0x0004D584 File Offset: 0x0004B784
	private void SetupFSM()
	{

	}

	// Token: 0x06000F17 RID: 3863 RVA: 0x0004DB5D File Offset: 0x0004BD5D
	private IEnumerator UpdateBoundsAndSphere()
	{

        return default;
    }

	// Token: 0x06000F18 RID: 3864 RVA: 0x0004DB6C File Offset: 0x0004BD6C
	private void RefreshCache()
	{

	}

	// Token: 0x06000F19 RID: 3865 RVA: 0x0004DC1C File Offset: 0x0004BE1C
	private void RefreshBounds(bool force = false)
	{

	}

	// Token: 0x06000F1A RID: 3866 RVA: 0x0004DC53 File Offset: 0x0004BE53
	public void ForceRefreshBounds()
	{

	}

	// Token: 0x06000F1B RID: 3867 RVA: 0x0004DC64 File Offset: 0x0004BE64
	private void AnimateToWireframe()
	{

	}

	// Token: 0x06000F1C RID: 3868 RVA: 0x0004DD40 File Offset: 0x0004BF40
	private void UpdatePositionAndRadius(bool isSolid, bool updateSpecialMaterials)
	{

	}

	// Token: 0x06000F1D RID: 3869 RVA: 0x0004DDCC File Offset: 0x0004BFCC
	public void CompleteTransition()
	{

	}

	// Token: 0x06000F1E RID: 3870 RVA: 0x0004DE1C File Offset: 0x0004C01C
	public void ForceUpdateWireframe()
	{

	}

	// Token: 0x06000F1F RID: 3871 RVA: 0x0004DE34 File Offset: 0x0004C034
	private void AnimateToSolid()
	{

	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x0004DF00 File Offset: 0x0004C100
	public void MakeTransparent(bool value)
	{

	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x0004DF54 File Offset: 0x0004C154
	public void SetWireframeColorGrabbing(bool grabbing)
	{

	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x0004DFA8 File Offset: 0x0004C1A8
	public void ShowFeedbackEffect()
	{

	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x0004DFF8 File Offset: 0x0004C1F8
	public void CleanUp()
	{

	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x0004E00C File Offset: 0x0004C20C
	private void OnDrawGizmos()
	{

	}

	// Token: 0x04000CC2 RID: 3266
	private Device _device;

	// Token: 0x04000CC3 RID: 3267
	private List<VFXComponent> _cachedChildren;

	// Token: 0x04000CC4 RID: 3268
	private List<MeshRenderer> _cachedMeshRenderers;

	// Token: 0x04000CC5 RID: 3269
	private Bounds _cachedBounds;

	// Token: 0x04000CC6 RID: 3270
	private int _stateMachine;

	// Token: 0x04000CC7 RID: 3271
	private float _currentRadius;

	// Token: 0x04000CC8 RID: 3272
	private Tween _transitionTween;

	// Token: 0x04000CC9 RID: 3273
	private bool _toWireframeAnimatedDone;

	// Token: 0x04000CCA RID: 3274
	private bool _toSolidAnimatedDone;

	// Token: 0x04000CCB RID: 3275
	private bool _forceRefreshBounds;

	// Token: 0x020003CC RID: 972
	public enum Commands
	{
		// Token: 0x04001D70 RID: 7536
		None,
		// Token: 0x04001D71 RID: 7537
		GoToWireframe,
		// Token: 0x04001D72 RID: 7538
		GoToWireframeAnimated,
		// Token: 0x04001D73 RID: 7539
		GoToSolid,
		// Token: 0x04001D74 RID: 7540
		GoToSolidAnimated,
		// Token: 0x04001D75 RID: 7541
		GoToTransparent,
		// Token: 0x04001D76 RID: 7542
		Update,
		// Token: 0x04001D77 RID: 7543
		TurnOffTransparencyAndUpdate
	}
}
}