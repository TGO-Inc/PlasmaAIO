using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200004A RID: 74
public class VFXController : Controller
{
	// Token: 0x1700002F RID: 47
	// (get) Token: 0x06000268 RID: 616 RVA: 0x000112B4 File Offset: 0x0000F4B4
	public Material gridMaterialInstance
	{
		get
		{
			return this._gridMaterialInstance;
		}
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x06000269 RID: 617 RVA: 0x000112BC File Offset: 0x0000F4BC
	public Material gridCylinderMaterialInstance
	{
		get
		{
			return this._gridCylinderMaterialInstance;
		}
	}

	// Token: 0x0600026A RID: 618 RVA: 0x000112C4 File Offset: 0x0000F4C4
	private void Awake()
	{

	}

	// Token: 0x0600026B RID: 619 RVA: 0x00011BDC File Offset: 0x0000FDDC
	private void UpdateComponentMats()
	{

	}

	// Token: 0x0600026C RID: 620 RVA: 0x00011E0C File Offset: 0x0001000C
	public override void Init()
	{

	}

	// Token: 0x0600026D RID: 621 RVA: 0x00011EE0 File Offset: 0x000100E0
	public void SetOutlineEnabled(bool value)
	{

	}

	// Token: 0x0600026E RID: 622 RVA: 0x00011EF8 File Offset: 0x000100F8
	public void UpdateOutline(VFXComponent vfxComponent)
	{

	}

	// Token: 0x0600026F RID: 623 RVA: 0x00011F5C File Offset: 0x0001015C
	private void OutlineOn(VFXComponent vfxComponent)
	{

	}

	// Token: 0x06000270 RID: 624 RVA: 0x00012010 File Offset: 0x00010210
	private void OutlineOff()
	{

	}

	// Token: 0x06000271 RID: 625 RVA: 0x00012078 File Offset: 0x00010278
	public void AuraOn(VFXDevice vfxDevice)
	{

	}

	// Token: 0x06000272 RID: 626 RVA: 0x000120A2 File Offset: 0x000102A2
	public void AuraOff()
	{

	}

	// Token: 0x06000273 RID: 627 RVA: 0x000120B5 File Offset: 0x000102B5
	private void ChangeAuraPreset(int _id)
	{

	}

	// Token: 0x06000274 RID: 628 RVA: 0x000120DD File Offset: 0x000102DD
	public void SetTreeLineEnabled(bool value)
	{

	}

	// Token: 0x06000275 RID: 629 RVA: 0x000120F4 File Offset: 0x000102F4
	public void UpdateTreeLine(Device device, bool forceRebuild = false, bool instant = false)
	{

	}

	// Token: 0x06000276 RID: 630 RVA: 0x0001226F File Offset: 0x0001046F
	private IEnumerator TreeLineFadeOut()
	{

        return default;
    }

	// Token: 0x06000277 RID: 631 RVA: 0x0001227E File Offset: 0x0001047E
	private void TreeLineOff()
	{

	}

	// Token: 0x06000278 RID: 632 RVA: 0x000122AC File Offset: 0x000104AC
	private void TreeLineOn(Device device)
	{

	}

	// Token: 0x06000279 RID: 633 RVA: 0x00012308 File Offset: 0x00010508
	private void VisitTreeNode(ComponentHandler parentComponent, bool enable)
	{

	}

	// Token: 0x0600027A RID: 634 RVA: 0x000123A4 File Offset: 0x000105A4
	private void VisitTreeNodeColor(ComponentHandler parentComponent, bool outlined, bool fadeOut)
	{

	}

	// Token: 0x0600027B RID: 635 RVA: 0x00012554 File Offset: 0x00010754
	private void CleanupAuraBuffer()
	{

	}

	// Token: 0x0600027C RID: 636 RVA: 0x0001257C File Offset: 0x0001077C
	private void CleanupOutlineBuffer()
	{

	}

	// Token: 0x0600027D RID: 637 RVA: 0x000125B4 File Offset: 0x000107B4
	private void UpdateAuraCommandBuffer()
	{

	}

	// Token: 0x0600027E RID: 638 RVA: 0x000126FC File Offset: 0x000108FC
	private void UpdateOutlineCommandBuffer()
	{

	}

	// Token: 0x0600027F RID: 639 RVA: 0x00012844 File Offset: 0x00010A44
	private void SetCurrentAuraParams()
	{

	}

	// Token: 0x06000280 RID: 640 RVA: 0x00012A9E File Offset: 0x00010C9E
	private void ChangeAuraPresetByOffset(int offset)
	{

	}

	// Token: 0x06000281 RID: 641 RVA: 0x00012ADC File Offset: 0x00010CDC
	private void SetPresetNow(int i)
	{

	}

	// Token: 0x06000282 RID: 642 RVA: 0x00012D54 File Offset: 0x00010F54
	private void SaveCurrentPreset()
	{

	}

	// Token: 0x06000283 RID: 643 RVA: 0x00012EF8 File Offset: 0x000110F8
	public static Bounds CalculateObjectBounds(List<MeshRenderer> renderers)
	{

        return default;
    }

	// Token: 0x06000284 RID: 644 RVA: 0x00012F5C File Offset: 0x0001115C
	private void Update()
	{

	}

	// Token: 0x06000285 RID: 645 RVA: 0x00012FAA File Offset: 0x000111AA
	private void Reset()
	{

	}

	// Token: 0x0400027F RID: 639
	private static Color pink = new Color(1f, 0.7f, 0.9f);

	// Token: 0x04000280 RID: 640
	private static Color pink2 = new Color(1f, 0.9f, 0.8f);

	// Token: 0x04000281 RID: 641
	private static Color blue = new Color(0.4f, 0.8f, 1f);

	// Token: 0x04000282 RID: 642
	private static Color green = new Color(0.4f, 1f, 0.4f);

	// Token: 0x04000283 RID: 643
	private static Color green2 = new Color(0.6f, 1f, 0.6f);

	// Token: 0x04000284 RID: 644
	private static Color sea = new Color(0.3f, 0.8f, 0.8f);

	// Token: 0x04000285 RID: 645
	private static Color lightCyan = new Color(0.8f, 0.9f, 1f);

	// Token: 0x04000286 RID: 646
	private static Color red = new Color(1f, 0.3f, 0.3f);

	// Token: 0x04000287 RID: 647
	private static Color yellow = new Color(1f, 1f, 0.7f);

	// Token: 0x04000288 RID: 648
	[Header("[TESTING]")]
	public bool updateAuraContinuously;

	// Token: 0x04000289 RID: 649
	public bool updateComponentMatsContinuously;

	// Token: 0x0400028A RID: 650
	public int auraPresetToTest;

	// Token: 0x0400028B RID: 651
	public Material GenericComponentMat;

	// Token: 0x0400028C RID: 652
	public Material GenericComponentTranspMat;

	// Token: 0x0400028D RID: 653
	public Material auraMat;

	// Token: 0x0400028E RID: 654
	public Material fillMat;

	// Token: 0x0400028F RID: 655
	public Material maskMat;

	// Token: 0x04000290 RID: 656
	public Material fillOutlineMat;

	// Token: 0x04000291 RID: 657
	public Material maskOutlineMat;

	// Token: 0x04000292 RID: 658
	[Space]
	[ColorUsage(true, true)]
	public Color wireframeColor;

	// Token: 0x04000293 RID: 659
	[ColorUsage(true, true)]
	public Color wireframeCollidingColor;

	// Token: 0x04000294 RID: 660
	[ColorUsage(true, true)]
	public Color wireframeGrabbingColor;

	// Token: 0x04000295 RID: 661
	[Range(0f, 8f)]
	public float wireframeMaxLum;

	// Token: 0x04000296 RID: 662
	[ColorUsage(true, true)]
	public Color cutlineColor;

	// Token: 0x04000297 RID: 663
	[ColorUsage(false, true)]
	public Color feedbackFxColor;

	// Token: 0x04000298 RID: 664
	public Texture2D detailAlbTex;

	// Token: 0x04000299 RID: 665
	public Texture2D detailEmTex;

	// Token: 0x0400029A RID: 666
	public Texture2D detailNmlTex;

	// Token: 0x0400029B RID: 667
	public Texture2D detailMaskTex;

	// Token: 0x0400029C RID: 668
	public Texture2D detailMaskTex2;

	// Token: 0x0400029D RID: 669
	[Range(0f, 1f)]
	public float csGlossiness;

	// Token: 0x0400029E RID: 670
	[Range(0f, 1f)]
	public float csMetallic;

	// Token: 0x0400029F RID: 671
	[Range(0f, 1f)]
	public float csDetailNormalFactor;

	// Token: 0x040002A0 RID: 672
	[Range(0.5f, 15f)]
	public float csRimPower;

	// Token: 0x040002A1 RID: 673
	[Range(0f, 20f)]
	public float csRimMUL;

	// Token: 0x040002A2 RID: 674
	public Texture2D triTex1;

	// Token: 0x040002A3 RID: 675
	[ColorUsage(true, true)]
	public Color triColor3;

	// Token: 0x040002A4 RID: 676
	public Vector4 triUVOff1;

	// Token: 0x040002A5 RID: 677
	public Vector4 triUVOff3;

	// Token: 0x040002A6 RID: 678
	public Vector4 triUVOff4;

	// Token: 0x040002A7 RID: 679
	public Vector4 triUVMul1;

	// Token: 0x040002A8 RID: 680
	public Vector4 triUVMul3;

	// Token: 0x040002A9 RID: 681
	public Vector4 triUVMul4;

	// Token: 0x040002AA RID: 682
	public Vector4 triUVOff2;

	// Token: 0x040002AB RID: 683
	public Vector4 triUVMul2;

	// Token: 0x040002AC RID: 684
	public float wireframeMUL;

	// Token: 0x040002AD RID: 685
	public float feedbackFxTime;

	// Token: 0x040002AE RID: 686
	public AnimationCurve feedbackFxCurve;

	// Token: 0x040002AF RID: 687
	public Ease solidToWireframeEase;

	// Token: 0x040002B0 RID: 688
	public Ease wireframeToSolidEase;

	// Token: 0x040002B1 RID: 689
	public Ease packedToSolidEase;

	// Token: 0x040002B2 RID: 690
	public Ease solidToPackedEase;

	// Token: 0x040002B3 RID: 691
	public float solidToWireframeTime;

	// Token: 0x040002B4 RID: 692
	public float wireframeToSolidTime;

	// Token: 0x040002B5 RID: 693
	public float packedToSolidTime;

	// Token: 0x040002B6 RID: 694
	public float solidToPackedTime;

	// Token: 0x040002B7 RID: 695
	public float packedToWireframeTime;

	// Token: 0x040002B8 RID: 696
	public Ease packedToWireframeEase;

	// Token: 0x040002B9 RID: 697
	public float wireframeToPackedTime;

	// Token: 0x040002BA RID: 698
	[Space]
	public float wireframeTilingMulMin = 1f;

	// Token: 0x040002BB RID: 699
	public float wireframeTilingMulMax = 10f;

	// Token: 0x040002BC RID: 700
	public float wireframeObjectSizeMin = 1f;

	// Token: 0x040002BD RID: 701
	public float wireframeObjectSizeMax = 100f;

	// Token: 0x040002BE RID: 702
	public Ease easeShrink = Ease.OutSine;

	// Token: 0x040002BF RID: 703
	public Ease easeExpand = Ease.InSine;

	// Token: 0x040002C0 RID: 704
	[Space]
	public MaterialTransitionerTransparentParameters transparentParams;

	// Token: 0x040002C1 RID: 705
	public MaterialTransitionerTransparentParameters opaqueParams;

	// Token: 0x040002C2 RID: 706
	[Space]
	[Range(1f, 16f)]
	public float auraBlurRadius;

	// Token: 0x040002C3 RID: 707
	[Range(0f, 10f)]
	public float intensity = 1f;

	// Token: 0x040002C4 RID: 708
	public int auraResDivider = 2;

	// Token: 0x040002C5 RID: 709
	public int outlineResDivider = 1;

	// Token: 0x040002C6 RID: 710
	[Space]
	[ColorUsage(true, true)]
	public Color outlineColor;

	// Token: 0x040002C7 RID: 711
	public float outlineInSize;

	// Token: 0x040002C8 RID: 712
	public float outlineOutSize;

	// Token: 0x040002C9 RID: 713
	public CameraEvent cameraEvent = CameraEvent.BeforeImageEffects;

	// Token: 0x040002CA RID: 714
	public float treeStayTime;

	// Token: 0x040002CB RID: 715
	public float treeFadeOutTime;

	// Token: 0x040002CC RID: 716
	public string presetName;

	// Token: 0x040002CD RID: 717
	public bool saveToPreset;

	// Token: 0x040002CE RID: 718
	[Space]
	public List<AuraParameterSet> auraPresets;

	// Token: 0x040002CF RID: 719
	[Space]
	public float socketSize;

	// Token: 0x040002D0 RID: 720
	public Mesh socketMesh;

	// Token: 0x040002D1 RID: 721
	public Material activatedSocketMaterial;

	// Token: 0x040002D2 RID: 722
	public Material deactivatedSocketMaterial;

	// Token: 0x040002D3 RID: 723
	[Space]
	public float gridMeshSize;

	// Token: 0x040002D4 RID: 724
	public float cylinderMeshHeight;

	// Token: 0x040002D5 RID: 725
	public Mesh gridMesh;

	// Token: 0x040002D6 RID: 726
	public Mesh cylinderGridMesh;

	// Token: 0x040002D7 RID: 727
	public Material gridMaterial;

	// Token: 0x040002D8 RID: 728
	public Material cylinderGridMaterial;

	// Token: 0x040002D9 RID: 729
	public float gridInnerRadius;

	// Token: 0x040002DA RID: 730
	public float gridBorder;

	// Token: 0x040002DB RID: 731
	public Color gridBaseColor;

	// Token: 0x040002DC RID: 732
	public float gridEmissionMUL;

	// Token: 0x040002DD RID: 733
	[ColorUsage(true, true)]
	public Color gridColor;

	// Token: 0x040002DE RID: 734
	[ColorUsage(true, true)]
	public Color highlightColor;

	// Token: 0x040002DF RID: 735
	public float highlightInnerRadius;

	// Token: 0x040002E0 RID: 736
	public float highlightBorder;

	// Token: 0x040002E1 RID: 737
	[ColorUsage(true, true)]
	public Color hightlightCrossColor;

	// Token: 0x040002E2 RID: 738
	public float hightlightCrossRadius;

	// Token: 0x040002E3 RID: 739
	public AuraParameterSet currentAuraParams;

	// Token: 0x040002E4 RID: 740
	public List<MeshRenderer> auraRenderers;

	// Token: 0x040002E5 RID: 741
	public List<MeshRenderer> outlineRenderers;

	// Token: 0x040002E6 RID: 742
	public int currentPreset;

	// Token: 0x040002E7 RID: 743
	public RenderTexture[] textures = new RenderTexture[16];

	// Token: 0x040002E8 RID: 744
	public CommandBuffer auraBuffer;

	// Token: 0x040002E9 RID: 745
	public CommandBuffer outlineBuffer;

	// Token: 0x040002EA RID: 746
	public RenderTexture rtAura;

	// Token: 0x040002EB RID: 747
	public RenderTexture rtOutline;

	// Token: 0x040002EC RID: 748
	public static int boxDownPrefilterPass = 0;

	// Token: 0x040002ED RID: 749
	public static int boxDownPass = 1;

	// Token: 0x040002EE RID: 750
	public static int boxUpPass = 2;

	// Token: 0x040002EF RID: 751
	public static int bpplyBloomPass = 3;

	// Token: 0x040002F0 RID: 752
	private Camera _camera;

	// Token: 0x040002F1 RID: 753
	private VFXComponent _outlinedComponent;

	// Token: 0x040002F2 RID: 754
	private bool _outlineEnabled;

	// Token: 0x040002F3 RID: 755
	private bool _treeLineEnabled;

	// Token: 0x040002F4 RID: 756
	private TheLineRenderer _treeLineRenderer;

	// Token: 0x040002F5 RID: 757
	private Device _treeLinedDevice;

	// Token: 0x040002F6 RID: 758
	private int _treeLineSegmentIndex;

	// Token: 0x040002F7 RID: 759
	private float _treeLineFadeOutRatio;

	// Token: 0x040002F8 RID: 760
	private Coroutine _treeLineFadeOutCoroutine;

	// Token: 0x040002F9 RID: 761
	private Material _gridMaterialInstance;

	// Token: 0x040002FA RID: 762
	private Material _gridCylinderMaterialInstance;

	// Token: 0x040002FB RID: 763
	[HideInInspector]
	public int p_AlphaADD;

	// Token: 0x040002FC RID: 764
	[HideInInspector]
	public int p_AlphaBri;

	// Token: 0x040002FD RID: 765
	[HideInInspector]
	public int p_AlphaCon;

	// Token: 0x040002FE RID: 766
	[HideInInspector]
	public int p_AlphaRimMUL;

	// Token: 0x040002FF RID: 767
	[HideInInspector]
	public int p_AlphaRimPower;

	// Token: 0x04000300 RID: 768
	[HideInInspector]
	public int p_Amplitude;

	// Token: 0x04000301 RID: 769
	[HideInInspector]
	public int p_AuraSize;

	// Token: 0x04000302 RID: 770
	[HideInInspector]
	public int p_BaseColor;

	// Token: 0x04000303 RID: 771
	[HideInInspector]
	public int p_Color;

	// Token: 0x04000304 RID: 772
	[HideInInspector]
	public int p_Color1;

	// Token: 0x04000305 RID: 773
	[HideInInspector]
	public int p_Color2;

	// Token: 0x04000306 RID: 774
	[HideInInspector]
	public int p_ColorClamp;

	// Token: 0x04000307 RID: 775
	[HideInInspector]
	public int p_ColorMUL;

	// Token: 0x04000308 RID: 776
	[HideInInspector]
	public int p_CutXYWH;

	// Token: 0x04000309 RID: 777
	[HideInInspector]
	public int p_CutlineColor;

	// Token: 0x0400030A RID: 778
	[HideInInspector]
	public int p_DestColor;

	// Token: 0x0400030B RID: 779
	[HideInInspector]
	public int p_DestXYWH;

	// Token: 0x0400030C RID: 780
	[HideInInspector]
	public int p_DetailAlbTex;

	// Token: 0x0400030D RID: 781
	[HideInInspector]
	public int p_DetailEmTex;

	// Token: 0x0400030E RID: 782
	[HideInInspector]
	public int p_DetailNmlTex;

	// Token: 0x0400030F RID: 783
	[HideInInspector]
	public int p_DetailMaskTex;

	// Token: 0x04000310 RID: 784
	[HideInInspector]
	public int p_DetailMaskTex2;

	// Token: 0x04000311 RID: 785
	[HideInInspector]
	public int p_csGlossiness;

	// Token: 0x04000312 RID: 786
	[HideInInspector]
	public int p_csMetallic;

	// Token: 0x04000313 RID: 787
	[HideInInspector]
	public int p_csDetailNormalFactor;

	// Token: 0x04000314 RID: 788
	[HideInInspector]
	public int p_csRimPower;

	// Token: 0x04000315 RID: 789
	[HideInInspector]
	public int p_csRimMUL;

	// Token: 0x04000316 RID: 790
	[HideInInspector]
	public int p_EmissionMUL;

	// Token: 0x04000317 RID: 791
	[HideInInspector]
	public int p_Exposure;

	// Token: 0x04000318 RID: 792
	[HideInInspector]
	public int p_Exposure1;

	// Token: 0x04000319 RID: 793
	[HideInInspector]
	public int p_Exposure2;

	// Token: 0x0400031A RID: 794
	[HideInInspector]
	public int p_FadeToWhite;

	// Token: 0x0400031B RID: 795
	[HideInInspector]
	public int p_Feedback;

	// Token: 0x0400031C RID: 796
	[HideInInspector]
	public int p_FeedbackColor;

	// Token: 0x0400031D RID: 797
	[HideInInspector]
	public int p_Frequency;

	// Token: 0x0400031E RID: 798
	[HideInInspector]
	public int p_MainTex;

	// Token: 0x0400031F RID: 799
	[HideInInspector]
	public int p_OverlayMode;

	// Token: 0x04000320 RID: 800
	[HideInInspector]
	public int p_CSRimColor;

	// Token: 0x04000321 RID: 801
	[HideInInspector]
	public int p_RimColor1;

	// Token: 0x04000322 RID: 802
	[HideInInspector]
	public int p_RimColor2;

	// Token: 0x04000323 RID: 803
	[HideInInspector]
	public int p_RimMUL1;

	// Token: 0x04000324 RID: 804
	[HideInInspector]
	public int p_RimMUL2;

	// Token: 0x04000325 RID: 805
	[HideInInspector]
	public int p_RimPower1;

	// Token: 0x04000326 RID: 806
	[HideInInspector]
	public int p_RimPower2;

	// Token: 0x04000327 RID: 807
	[HideInInspector]
	public int p_RNDParams;

	// Token: 0x04000328 RID: 808
	[HideInInspector]
	public int p_RNDTex;

	// Token: 0x04000329 RID: 809
	[HideInInspector]
	public int p_ScanlinesParams1;

	// Token: 0x0400032A RID: 810
	[HideInInspector]
	public int p_ScanlinesParams2;

	// Token: 0x0400032B RID: 811
	[HideInInspector]
	public int p_ScanlinesTex;

	// Token: 0x0400032C RID: 812
	[HideInInspector]
	public int p_SecondTex;

	// Token: 0x0400032D RID: 813
	[HideInInspector]
	public int p_SourceTex;

	// Token: 0x0400032E RID: 814
	[HideInInspector]
	public int p_Speed;

	// Token: 0x0400032F RID: 815
	[HideInInspector]
	public int p_SpherePos;

	// Token: 0x04000330 RID: 816
	[HideInInspector]
	public int p_StaticColor;

	// Token: 0x04000331 RID: 817
	[HideInInspector]
	public int p_SunDir;

	// Token: 0x04000332 RID: 818
	[HideInInspector]
	public int p_SunIntensity;

	// Token: 0x04000333 RID: 819
	[HideInInspector]
	public int p_Tex;

	// Token: 0x04000334 RID: 820
	[HideInInspector]
	public int p_Tex1;

	// Token: 0x04000335 RID: 821
	[HideInInspector]
	public int p_Tex2;

	// Token: 0x04000336 RID: 822
	[HideInInspector]
	public int p_Tex1Par;

	// Token: 0x04000337 RID: 823
	[HideInInspector]
	public int p_Tex2Par;

	// Token: 0x04000338 RID: 824
	[HideInInspector]
	public int p_Tint;

	// Token: 0x04000339 RID: 825
	[HideInInspector]
	public int p_Tint1;

	// Token: 0x0400033A RID: 826
	[HideInInspector]
	public int p_Tint2;

	// Token: 0x0400033B RID: 827
	[HideInInspector]
	public int p_TriColor3;

	// Token: 0x0400033C RID: 828
	[HideInInspector]
	public int p_TriColor4;

	// Token: 0x0400033D RID: 829
	[HideInInspector]
	public int p_TriTex1;

	// Token: 0x0400033E RID: 830
	[HideInInspector]
	public int p_TriUVMul1;

	// Token: 0x0400033F RID: 831
	[HideInInspector]
	public int p_TriUVMul3;

	// Token: 0x04000340 RID: 832
	[HideInInspector]
	public int p_TriUVMul4;

	// Token: 0x04000341 RID: 833
	[HideInInspector]
	public int p_TriUVOff1;

	// Token: 0x04000342 RID: 834
	[HideInInspector]
	public int p_TriUVOff3;

	// Token: 0x04000343 RID: 835
	[HideInInspector]
	public int p_TriUVOff4;

	// Token: 0x04000344 RID: 836
	[HideInInspector]
	public int p_UV1MUL;

	// Token: 0x04000345 RID: 837
	[HideInInspector]
	public int p_UV2MUL;

	// Token: 0x04000346 RID: 838
	[HideInInspector]
	public int p_W1;

	// Token: 0x04000347 RID: 839
	[HideInInspector]
	public int p_W2;

	// Token: 0x04000348 RID: 840
	[HideInInspector]
	public int p_WireframeSphereRadius;

	// Token: 0x04000349 RID: 841
	[HideInInspector]
	public int p_wireframeMUL;
}
