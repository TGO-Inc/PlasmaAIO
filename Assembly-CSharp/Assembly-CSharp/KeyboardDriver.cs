using Data = PlasmaAPI.GameClass.Behavior.Data;
using IDataSelectionProvider = PlasmaAPI.GameClass.Behavior.IDataSelectionProvider;
using SketchNode = PlasmaAPI.GameClass.Behavior.SketchNode;
using SketchNodePort = PlasmaAPI.GameClass.Behavior.SketchNodePort;
using Sketch = PlasmaAPI.GameClass.Behavior.Sketch;
using SketchConnection = PlasmaAPI.GameClass.Behavior.SketchConnection;
using SketchNotifications = PlasmaAPI.GameClass.Behavior.SketchNotifications;
using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using DG.Tweening;
using FMODUnity;
using Rewired;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000093 RID: 147
public class KeyboardDriver : ComponentDriver
{
	// Token: 0x06000732 RID: 1842 RVA: 0x0002937C File Offset: 0x0002757C
	public override void Awake()
	{

	}

	// Token: 0x06000733 RID: 1843 RVA: 0x000293DB File Offset: 0x000275DB
	public override void OnWireframeEnter()
	{

	}

	// Token: 0x06000734 RID: 1844 RVA: 0x000293FC File Offset: 0x000275FC
	public override void OnSolidEnter()
	{

	}

	// Token: 0x06000735 RID: 1845 RVA: 0x00029484 File Offset: 0x00027684
	protected override void OnAgentSet()
	{

	}

	// Token: 0x06000736 RID: 1846 RVA: 0x000294EC File Offset: 0x000276EC
	public override void RunCommand(int commandId)
	{

	}

	// Token: 0x06000737 RID: 1847 RVA: 0x00029514 File Offset: 0x00027714
	public override bool CanInteractWithRaycast(Ray ray)
	{

        return default;
    }

	// Token: 0x06000738 RID: 1848 RVA: 0x00029554 File Offset: 0x00027754
	public override void OnInteractionDown(Ray ray)
	{

	}

	// Token: 0x06000739 RID: 1849 RVA: 0x00029630 File Offset: 0x00027830
	public override void Preprocess()
	{

	}

	// Token: 0x0600073A RID: 1850 RVA: 0x000297D3 File Offset: 0x000279D3
	public override void UpdateConcreteProperties()
	{

	}

	// Token: 0x0600073B RID: 1851 RVA: 0x00029809 File Offset: 0x00027A09
	public override bool CanFocusOnComponent(Ray ray)
	{

        return default;
    }

	// Token: 0x0600073C RID: 1852 RVA: 0x00029834 File Offset: 0x00027A34
	public override void OnFocusDown(Ray ray)
	{

	}

	// Token: 0x0600073D RID: 1853 RVA: 0x000298BC File Offset: 0x00027ABC
	public override void OnFocusUpdate(Camera theCamera, Player input)
	{

	}

	// Token: 0x0600073E RID: 1854 RVA: 0x00029A3C File Offset: 0x00027C3C
	public override void OnFocusUp()
	{

	}

	// Token: 0x0600073F RID: 1855 RVA: 0x00029A72 File Offset: 0x00027C72
	private void AnimateButtonPress(Transform target)
	{

	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00029AB2 File Offset: 0x00027CB2
	private void SetLEDFocusColor(Color color)
	{

	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00029AE8 File Offset: 0x00027CE8
	private void SetLEDIndicatorColor()
	{

	}

	// Token: 0x06000742 RID: 1858 RVA: 0x00029B28 File Offset: 0x00027D28
	private void SetLEDStripColor()
	{

	}

	// Token: 0x0400068F RID: 1679
	public StudioEventEmitter FMODEmitter;

	// Token: 0x04000690 RID: 1680
	public Dictionary<Transform, KeyCode> keysColliders;

	// Token: 0x04000691 RID: 1681
	public Dictionary<KeyCode, Transform> keysTransforms;

	// Token: 0x04000692 RID: 1682
	public List<MeshRenderer> allKeysMeshRenderers;

	// Token: 0x04000693 RID: 1683
	public MeshRenderer focusKeyMeshRenderer;

	// Token: 0x04000694 RID: 1684
	public MeshRenderer baseMeshRenderer;

	// Token: 0x04000695 RID: 1685
	public Transform focusKey;

	// Token: 0x04000696 RID: 1686
	public float restingKeyHeight;

	// Token: 0x04000697 RID: 1687
	public float pressedKeyHeight;

	// Token: 0x04000698 RID: 1688
	private AgentProperty _pressedKeyProperty;

	// Token: 0x04000699 RID: 1689
	private AgentProperty _charactersProperty;

	// Token: 0x0400069A RID: 1690
	private AgentProperty _LEDKeyColorProperty;

	// Token: 0x0400069B RID: 1691
	private AgentProperty _LEDIndicatorColorProperty;

	// Token: 0x0400069C RID: 1692
	private KeyboardAgent _keyboardAgent;

	// Token: 0x0400069D RID: 1693
	private MaterialPropertyBlock _propertyBlock;

	// Token: 0x0400069E RID: 1694
	private Player _input;

	// Token: 0x0400069F RID: 1695
	private KeyCode _pressedKey;

	// Token: 0x040006A0 RID: 1696
	private string _characters;

	// Token: 0x040006A1 RID: 1697
	private bool _focusDown;

	// Token: 0x040006A2 RID: 1698
	private bool _isFocused;

	// Token: 0x040006A3 RID: 1699
	private int _colorId0;

	// Token: 0x040006A4 RID: 1700
	private int _colorId1;

	// Token: 0x040006A5 RID: 1701
	private int _colorId2;

	// Token: 0x040006A6 RID: 1702
	private const string _FMODParamKeyboard = "Keyboard";

	// Token: 0x040006A7 RID: 1703
	private const string _FMODParamSize = "Size";
}
}