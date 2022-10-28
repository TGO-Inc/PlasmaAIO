using PlasmaAPI.GameClass.Behavior;
﻿using System;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x0200019C RID: 412
[AddComponentMenu("Effects/TubeRenderer")]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[ExecuteInEditMode]
public class TubeRenderer : MonoBehaviour
{
	// Token: 0x17000142 RID: 322
	// (get) Token: 0x06000F68 RID: 3944 RVA: 0x0004F0B0 File Offset: 0x0004D2B0
	// (set) Token: 0x06000F69 RID: 3945 RVA: 0x0004F0B8 File Offset: 0x0004D2B8
	public Vector3[] points
	{
		get
		{
			return this._points;
		}
		set
		{
			if (value == null)
			{
				this._points = new Vector3[0];
				return;
			}
			if (value.Length == 1)
			{
				this._points = value;
				return;
			}
			if (value.Length != this._points.Length)
			{
				if (TubeRenderer.ComputeVertexCountForProperties(value.Length, this._edgeCount, this._normalMode, this._caps) > 65000)
				{
					Debug.LogWarning("<b>[TubeRenderer]</b> Points change for " + base.name + " was ignored. You are exceeding Unity's 65000 vertex limit.\n");
					return;
				}
				this._dirtyVertexCount = true;
				this._dirtyTriangles = true;
				this._dirtyUVs = true;
				this._dirtyColors = true;
			}
			if (this._uvAntiStretching)
			{
				this._dirtyUVs = true;
			}
			this._dirtyRotations = true;
			this._dirtySteepnessAngles = true;
			this._redrawFlag = true;
			this._points = value;
		}
	}

	// Token: 0x17000143 RID: 323
	// (get) Token: 0x06000F6A RID: 3946 RVA: 0x0004F173 File Offset: 0x0004D373
	// (set) Token: 0x06000F6B RID: 3947 RVA: 0x0004F17B File Offset: 0x0004D37B
	public float[] radiuses
	{
		get
		{
			return this._radiuses;
		}
		set
		{
			if (value == null)
			{
				this._radiuses = new float[0];
			}
			else
			{
				this._radiuses = value;
				this._dirtySteepnessAngles = true;
			}
			this._redrawFlag = true;
		}
	}

	// Token: 0x17000144 RID: 324
	// (get) Token: 0x06000F6C RID: 3948 RVA: 0x0004F1A3 File Offset: 0x0004D3A3
	// (set) Token: 0x06000F6D RID: 3949 RVA: 0x0004F1AB File Offset: 0x0004D3AB
	public float radius
	{
		get
		{
			return this._radius;
		}
		set
		{
			if (this._radiuses.Length != 0)
			{
				this._radiuses = new float[0];
				this._steepnessAngles = null;
			}
			if (value == this._radius)
			{
				return;
			}
			this._redrawFlag = true;
			this._radius = value;
		}
	}

	// Token: 0x17000145 RID: 325
	// (get) Token: 0x06000F6E RID: 3950 RVA: 0x0004F1E1 File Offset: 0x0004D3E1
	// (set) Token: 0x06000F6F RID: 3951 RVA: 0x0004F1E9 File Offset: 0x0004D3E9
	public Color32[] colors
	{
		get
		{
			return this._pointColors;
		}
		set
		{
			if (value == null)
			{
				return;
			}
			if (value != null && value.Length == 0)
			{
				this._pointColors = null;
			}
			else
			{
				this._pointColors = value;
			}
			this._dirtyColors = true;
		}
	}

	// Token: 0x17000146 RID: 326
	// (get) Token: 0x06000F70 RID: 3952 RVA: 0x0004F20D File Offset: 0x0004D40D
	// (set) Token: 0x06000F71 RID: 3953 RVA: 0x0004F215 File Offset: 0x0004D415
	public float[] twists
	{
		get
		{
			return this._twists;
		}
		set
		{
			if (value == null)
			{
				this._twists = new float[0];
			}
			else
			{
				this._twists = value;
				this._dirtyRotations = true;
			}
			this._redrawFlag = true;
		}
	}

	// Token: 0x17000147 RID: 327
	// (get) Token: 0x06000F72 RID: 3954 RVA: 0x0004F23D File Offset: 0x0004D43D
	// (set) Token: 0x06000F73 RID: 3955 RVA: 0x0004F248 File Offset: 0x0004D448
	public int edgeCount
	{
		get
		{
			return this._edgeCount;
		}
		set
		{
			if (value == this._edgeCount)
			{
				return;
			}
			if (value < 3)
			{
				Debug.LogWarning("<b>[TubeRenderer]</b> Edge count change for " + base.name + " was ignored. A tube must have at least three edges.");
				return;
			}
			if (TubeRenderer.ComputeVertexCountForProperties(this._points.Length, value, this._normalMode, this._caps) > 65000)
			{
				Debug.LogWarning("<b>[TubeRenderer]</b> Edge count change for " + base.name + " was ignored. You are exceeding Unity's 65000 vertex limit.\n");
				return;
			}
			this._dirtyCircle = true;
			this._dirtyVertexCount = true;
			this._redrawFlag = true;
			this._dirtyTriangles = true;
			this._dirtyUVs = true;
			this._dirtyColors = true;
			this._edgeCount = value;
		}
	}

	// Token: 0x17000148 RID: 328
	// (get) Token: 0x06000F74 RID: 3956 RVA: 0x0004F2EB File Offset: 0x0004D4EB
	// (set) Token: 0x06000F75 RID: 3957 RVA: 0x0004F2F3 File Offset: 0x0004D4F3
	public bool calculateTangents
	{
		get
		{
			return this._calculateTangents;
		}
		set
		{
			if (value == this._calculateTangents)
			{
				return;
			}
			if (!value)
			{
				this._tangents = null;
				this._mesh.tangents = null;
			}
			this._dirtyVertexCount = true;
			this._redrawFlag = true;
			this._calculateTangents = value;
		}
	}

	// Token: 0x17000149 RID: 329
	// (get) Token: 0x06000F76 RID: 3958 RVA: 0x0004F32A File Offset: 0x0004D52A
	// (set) Token: 0x06000F77 RID: 3959 RVA: 0x0004F332 File Offset: 0x0004D532
	public bool invertMesh
	{
		get
		{
			return this._invertMesh;
		}
		set
		{
			if (value == this._invertMesh)
			{
				return;
			}
			this._dirtyTriangles = true;
			this._redrawFlag = true;
			this._invertMesh = value;
		}
	}

	// Token: 0x1700014A RID: 330
	// (get) Token: 0x06000F78 RID: 3960 RVA: 0x0004F353 File Offset: 0x0004D553
	// (set) Token: 0x06000F79 RID: 3961 RVA: 0x0004F35C File Offset: 0x0004D55C
	public TubeRenderer.NormalMode normalMode
	{
		get
		{
			return this._normalMode;
		}
		set
		{
			if (value == this._normalMode)
			{
				return;
			}
			if (TubeRenderer.ComputeVertexCountForProperties(this._points.Length, this._edgeCount, value, this._caps) > 65000)
			{
				Debug.LogWarning("<b>[TubeRenderer]</b> Normal mode change for " + base.name + " was ignored. You are exceeding Unity's 65000 vertex limit.\n");
				return;
			}
			this._dirtyCircle = true;
			this._dirtyVertexCount = true;
			this._redrawFlag = true;
			this._dirtyTriangles = true;
			this._dirtyUVs = true;
			this._dirtyColors = true;
			this._normalMode = value;
		}
	}

	// Token: 0x1700014B RID: 331
	// (get) Token: 0x06000F7A RID: 3962 RVA: 0x0004F3E0 File Offset: 0x0004D5E0
	// (set) Token: 0x06000F7B RID: 3963 RVA: 0x0004F3E8 File Offset: 0x0004D5E8
	public TubeRenderer.CapMode caps
	{
		get
		{
			return this._caps;
		}
		set
		{
			if (value == this._caps)
			{
				return;
			}
			if (TubeRenderer.ComputeVertexCountForProperties(this._points.Length, this._edgeCount, this._normalMode, value) > 65000)
			{
				Debug.LogWarning("<b>[TubeRenderer]</b> Caps mode change for " + base.name + " was ignored. You are exceeding Unity's 65000 vertex limit.\n");
				return;
			}
			this._dirtyVertexCount = true;
			this._redrawFlag = true;
			this._dirtyTriangles = true;
			this._dirtyUVs = true;
			this._dirtyColors = true;
			this._caps = value;
		}
	}

	// Token: 0x1700014C RID: 332
	// (get) Token: 0x06000F7C RID: 3964 RVA: 0x0004F465 File Offset: 0x0004D665
	// (set) Token: 0x06000F7D RID: 3965 RVA: 0x0004F46D File Offset: 0x0004D66D
	public bool postprocessContinously
	{
		get
		{
			return this._postprocessContinously;
		}
		set
		{
			this._postprocessContinously = value;
		}
	}

	// Token: 0x1700014D RID: 333
	// (get) Token: 0x06000F7E RID: 3966 RVA: 0x0004F476 File Offset: 0x0004D676
	// (set) Token: 0x06000F7F RID: 3967 RVA: 0x0004F47E File Offset: 0x0004D67E
	public Rect uvRect
	{
		get
		{
			return this._uvRect;
		}
		set
		{
			if (value == this._uvRect)
			{
				return;
			}
			this._dirtyUVs = true;
			this._uvRect = value;
		}
	}

	// Token: 0x1700014E RID: 334
	// (get) Token: 0x06000F80 RID: 3968 RVA: 0x0004F49D File Offset: 0x0004D69D
	// (set) Token: 0x06000F81 RID: 3969 RVA: 0x0004F4A5 File Offset: 0x0004D6A5
	public Rect uvRectCap
	{
		get
		{
			return this._uvRectCap;
		}
		set
		{
			if (value == this._uvRectCap)
			{
				return;
			}
			this._dirtyUVs = true;
			this._uvRectCap = value;
		}
	}

	// Token: 0x1700014F RID: 335
	// (get) Token: 0x06000F82 RID: 3970 RVA: 0x0004F4C4 File Offset: 0x0004D6C4
	// (set) Token: 0x06000F83 RID: 3971 RVA: 0x0004F4CC File Offset: 0x0004D6CC
	public bool uvRectCapEndMirrored
	{
		get
		{
			return this._uvRectCapEndMirrored;
		}
		set
		{
			if (value == this._uvRectCapEndMirrored)
			{
				return;
			}
			this._dirtyUVs = true;
			this._uvRectCapEndMirrored = value;
		}
	}

	// Token: 0x17000150 RID: 336
	// (get) Token: 0x06000F84 RID: 3972 RVA: 0x0004F4E6 File Offset: 0x0004D6E6
	// (set) Token: 0x06000F85 RID: 3973 RVA: 0x0004F4EE File Offset: 0x0004D6EE
	public bool uvAntiStretching
	{
		get
		{
			return this._uvAntiStretching;
		}
		set
		{
			if (value == this._uvAntiStretching)
			{
				return;
			}
			this._dirtyUVs = true;
			this._uvAntiStretching = value;
		}
	}

	// Token: 0x17000151 RID: 337
	// (get) Token: 0x06000F86 RID: 3974 RVA: 0x0004F508 File Offset: 0x0004D708
	// (set) Token: 0x06000F87 RID: 3975 RVA: 0x0004F510 File Offset: 0x0004D710
	public float forwardAngleOffset
	{
		get
		{
			return this._forwardAngleOffset;
		}
		set
		{
			if (value == this._forwardAngleOffset)
			{
				return;
			}
			this._dirtyCircle = true;
			this._redrawFlag = true;
			this._forwardAngleOffset = value;
		}
	}

	// Token: 0x17000152 RID: 338
	// (get) Token: 0x06000F88 RID: 3976 RVA: 0x0004F531 File Offset: 0x0004D731
	public float length
	{
		get
		{
			return this._length;
		}
	}

	// Token: 0x17000153 RID: 339
	// (get) Token: 0x06000F89 RID: 3977 RVA: 0x0004F539 File Offset: 0x0004D739
	public Mesh mesh
	{
		get
		{
			return this._mesh;
		}
	}

	// Token: 0x17000154 RID: 340
	// (get) Token: 0x06000F8A RID: 3978 RVA: 0x0004F541 File Offset: 0x0004D741
	// (set) Token: 0x06000F8B RID: 3979 RVA: 0x0004F549 File Offset: 0x0004D749
	public bool showMeshGizmos
	{
		get
		{
			return this._showMeshGizmos;
		}
		set
		{
			this._showMeshGizmos = value;
		}
	}

	// Token: 0x17000155 RID: 341
	// (get) Token: 0x06000F8C RID: 3980 RVA: 0x0004F552 File Offset: 0x0004D752
	// (set) Token: 0x06000F8D RID: 3981 RVA: 0x0004F55A File Offset: 0x0004D75A
	public float meshGizmoLength
	{
		get
		{
			return this._meshGizmoLength;
		}
		set
		{
			this._meshGizmoLength = value;
		}
	}

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x06000F8E RID: 3982 RVA: 0x0004F563 File Offset: 0x0004D763
	// (set) Token: 0x06000F8F RID: 3983 RVA: 0x0004F56B File Offset: 0x0004D76B
	public bool showRotationGizmos
	{
		get
		{
			return this._showRotationGizmos;
		}
		set
		{
			this._showRotationGizmos = value;
		}
	}

	// Token: 0x17000157 RID: 343
	// (get) Token: 0x06000F90 RID: 3984 RVA: 0x0004F574 File Offset: 0x0004D774
	// (set) Token: 0x06000F91 RID: 3985 RVA: 0x0004F57C File Offset: 0x0004D77C
	public float rotationGizmoLength
	{
		get
		{
			return this._rotationGizmoLength;
		}
		set
		{
			this._rotationGizmoLength = value;
		}
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x0004F585 File Offset: 0x0004D785
	public void ForceUpdate()
	{

	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x0004F58D File Offset: 0x0004D78D
	public void MarkDynamic()
	{

	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x0004F59A File Offset: 0x0004D79A
	public void AddPostprocess(TubeRenderer.Postprocess postprocess)
	{

	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x0004F5B3 File Offset: 0x0004D7B3
	public void RemovePostprocess(TubeRenderer.Postprocess postprocess)
	{

	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x0004F5CC File Offset: 0x0004D7CC
	public Quaternion GetRotationAtPoint(int index)
	{

        return default;
    }

	// Token: 0x06000F97 RID: 3991 RVA: 0x0004F5F4 File Offset: 0x0004D7F4
	private void Awake()
	{

	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x0004F730 File Offset: 0x0004D930
	private void LateUpdate()
	{

	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x0004F7EC File Offset: 0x0004D9EC
	private void OnValidate()
	{

	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x0004F85F File Offset: 0x0004DA5F
	private void OnDidApplyAnimationProperties()
	{

	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x0004F868 File Offset: 0x0004DA68
	private void OnDrawGizmos()
	{

	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x0004FB9C File Offset: 0x0004DD9C
	private void UpdateVertexCount()
	{

	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x0004FC58 File Offset: 0x0004DE58
	private void ReDraw()
	{

	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x00050468 File Offset: 0x0004E668
	private void ReDrawSmoothNormals()
	{

	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x000505F8 File Offset: 0x0004E7F8
	private void ReDrawHardNormals()
	{

	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x00050A44 File Offset: 0x0004EC44
	private void ReDrawHardNormalEdges()
	{

	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x00050F00 File Offset: 0x0004F100
	private void UpdateCircleLookup()
	{

	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x00051034 File Offset: 0x0004F234
	private void UpdateRotations()
	{

	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x00051630 File Offset: 0x0004F830
	private void UpdateSteepnessAngles()
	{

	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x0005179C File Offset: 0x0004F99C
	private void UpdateTriangles()
	{

	}

	// Token: 0x06000FA5 RID: 4005 RVA: 0x00051BEC File Offset: 0x0004FDEC
	private void UpdateUVs()
	{

	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x00052220 File Offset: 0x00050420
	private void UpdateColors()
	{

	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x00052500 File Offset: 0x00050700
	private static int ComputeVertexCountForProperties(int pointCount, int edgeCount, TubeRenderer.NormalMode normalMode, TubeRenderer.CapMode capMode)
	{

        return default;
    }

	// Token: 0x04000CE5 RID: 3301
	[SerializeField]
	private Vector3[] _points = new Vector3[0];

	// Token: 0x04000CE6 RID: 3302
	[SerializeField]
	private float[] _radiuses = new float[0];

	// Token: 0x04000CE7 RID: 3303
	[SerializeField]
	private float _radius = 0.1f;

	// Token: 0x04000CE8 RID: 3304
	[SerializeField]
	private Color32[] _pointColors = new Color32[0];

	// Token: 0x04000CE9 RID: 3305
	[SerializeField]
	private float[] _twists = new float[0];

	// Token: 0x04000CEA RID: 3306
	[SerializeField]
	private int _edgeCount = 12;

	// Token: 0x04000CEB RID: 3307
	[SerializeField]
	private bool _calculateTangents;

	// Token: 0x04000CEC RID: 3308
	[SerializeField]
	private bool _invertMesh;

	// Token: 0x04000CED RID: 3309
	[SerializeField]
	private TubeRenderer.NormalMode _normalMode;

	// Token: 0x04000CEE RID: 3310
	[SerializeField]
	private TubeRenderer.CapMode _caps = TubeRenderer.CapMode.Both;

	// Token: 0x04000CEF RID: 3311
	[SerializeField]
	private bool _postprocessContinously = true;

	// Token: 0x04000CF0 RID: 3312
	[SerializeField]
	private Rect _uvRect = new Rect(0f, 0f, 1f, 1f);

	// Token: 0x04000CF1 RID: 3313
	[SerializeField]
	private Rect _uvRectCap = new Rect(0f, 0f, 1f, 1f);

	// Token: 0x04000CF2 RID: 3314
	[SerializeField]
	private bool _uvRectCapEndMirrored;

	// Token: 0x04000CF3 RID: 3315
	[SerializeField]
	private bool _uvAntiStretching;

	// Token: 0x04000CF4 RID: 3316
	[SerializeField]
	private float _forwardAngleOffset;

	// Token: 0x04000CF5 RID: 3317
	[SerializeField]
	private Mesh _mesh;

	// Token: 0x04000CF6 RID: 3318
	[SerializeField]
	private bool _showMeshGizmos;

	// Token: 0x04000CF7 RID: 3319
	[SerializeField]
	private float _meshGizmoLength = 0.1f;

	// Token: 0x04000CF8 RID: 3320
	[SerializeField]
	private bool _showRotationGizmos;

	// Token: 0x04000CF9 RID: 3321
	[SerializeField]
	private float _rotationGizmoLength = 0.2f;

	// Token: 0x04000CFA RID: 3322
	[SerializeField]
	private bool _pointsFoldout;

	// Token: 0x04000CFB RID: 3323
	[SerializeField]
	private bool _radiusesFoldout;

	// Token: 0x04000CFC RID: 3324
	[SerializeField]
	private bool _colorsFoldout;

	// Token: 0x04000CFD RID: 3325
	[SerializeField]
	private bool _twistsFoldout;

	// Token: 0x04000CFE RID: 3326
	[SerializeField]
	private bool _uvFoldout;

	// Token: 0x04000CFF RID: 3327
	private Vector3[] _vertices;

	// Token: 0x04000D00 RID: 3328
	private Vector3[] _normals;

	// Token: 0x04000D01 RID: 3329
	private int[] _triangles;

	// Token: 0x04000D02 RID: 3330
	private Vector2[] _uvs;

	// Token: 0x04000D03 RID: 3331
	private Vector4[] _tangents;

	// Token: 0x04000D04 RID: 3332
	private Color32[] _colors32;

	// Token: 0x04000D05 RID: 3333
	private Vector3[] _circlePointLookup;

	// Token: 0x04000D06 RID: 3334
	private Vector3[] _circleNormalLookup;

	// Token: 0x04000D07 RID: 3335
	private Vector3[] _circleTangentLookup;

	// Token: 0x04000D08 RID: 3336
	private Quaternion[] _rotations;

	// Token: 0x04000D09 RID: 3337
	private Vector3[] _directions;

	// Token: 0x04000D0A RID: 3338
	private float[] _lengths;

	// Token: 0x04000D0B RID: 3339
	private float[] _steepnessAngles;

	// Token: 0x04000D0C RID: 3340
	private float[] _radiusDiffs;

	// Token: 0x04000D0D RID: 3341
	private Vector3 _pastBeginUp;

	// Token: 0x04000D0E RID: 3342
	private float _length;

	// Token: 0x04000D0F RID: 3343
	private MeshFilter _filter;

	// Token: 0x04000D10 RID: 3344
	private bool _dirtyCircle = true;

	// Token: 0x04000D11 RID: 3345
	private bool _dirtyRotations = true;

	// Token: 0x04000D12 RID: 3346
	private bool _dirtySteepnessAngles = true;

	// Token: 0x04000D13 RID: 3347
	private bool _dirtyVertexCount = true;

	// Token: 0x04000D14 RID: 3348
	private bool _redrawFlag = true;

	// Token: 0x04000D15 RID: 3349
	private bool _dirtyTriangles = true;

	// Token: 0x04000D16 RID: 3350
	private bool _dirtyUVs = true;

	// Token: 0x04000D17 RID: 3351
	private bool _dirtyColors = true;

	// Token: 0x04000D18 RID: 3352
	private const float tau = 6.2831855f;

	// Token: 0x04000D19 RID: 3353
	private const int meshVertexCountLimit = 65000;

	// Token: 0x04000D1A RID: 3354
	private const string logPrepend = "<b>[TubeRenderer]</b> ";

	// Token: 0x04000D1B RID: 3355
	private TubeRenderer.Postprocess Postprocesses;

	// Token: 0x020003D1 RID: 977
	public enum NormalMode
	{
		// Token: 0x04001D81 RID: 7553
		Smooth,
		// Token: 0x04001D82 RID: 7554
		Hard,
		// Token: 0x04001D83 RID: 7555
		HardEdges
	}

	// Token: 0x020003D2 RID: 978
	public enum CapMode
	{
		// Token: 0x04001D85 RID: 7557
		None,
		// Token: 0x04001D86 RID: 7558
		Begin,
		// Token: 0x04001D87 RID: 7559
		End,
		// Token: 0x04001D88 RID: 7560
		Both
	}

	// Token: 0x020003D3 RID: 979
	// (Invoke) Token: 0x0600210F RID: 8463
	public delegate void Postprocess(Vector3[] vertices, Vector3[] normals, Vector4[] tangents);
}
}