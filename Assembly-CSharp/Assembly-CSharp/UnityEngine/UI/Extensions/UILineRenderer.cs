using System;
using System.Collections.Generic;
using UnityEngine.Sprites;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200022F RID: 559
	[AddComponentMenu("UI/Extensions/Primitives/UILineRenderer")]
	[RequireComponent(typeof(RectTransform))]
	public class UILineRenderer : UIPrimitiveBase
	{
		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060013A3 RID: 5027 RVA: 0x00064FD1 File Offset: 0x000631D1
		// (set) Token: 0x060013A4 RID: 5028 RVA: 0x00064FD9 File Offset: 0x000631D9
		public float LineThickness
		{
			get
			{
				return this.lineThickness;
			}
			set
			{
				this.lineThickness = value;
				this.SetAllDirty();
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x00064FE8 File Offset: 0x000631E8
		// (set) Token: 0x060013A6 RID: 5030 RVA: 0x00064FF0 File Offset: 0x000631F0
		public bool RelativeSize
		{
			get
			{
				return this.relativeSize;
			}
			set
			{
				this.relativeSize = value;
				this.SetAllDirty();
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x00064FFF File Offset: 0x000631FF
		// (set) Token: 0x060013A8 RID: 5032 RVA: 0x00065007 File Offset: 0x00063207
		public bool LineList
		{
			get
			{
				return this.lineList;
			}
			set
			{
				this.lineList = value;
				this.SetAllDirty();
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x00065016 File Offset: 0x00063216
		// (set) Token: 0x060013AA RID: 5034 RVA: 0x0006501E File Offset: 0x0006321E
		public bool LineCaps
		{
			get
			{
				return this.lineCaps;
			}
			set
			{
				this.lineCaps = value;
				this.SetAllDirty();
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x0006502D File Offset: 0x0006322D
		// (set) Token: 0x060013AC RID: 5036 RVA: 0x00065035 File Offset: 0x00063235
		public int BezierSegmentsPerCurve
		{
			get
			{
				return this.bezierSegmentsPerCurve;
			}
			set
			{
				this.bezierSegmentsPerCurve = value;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060013AD RID: 5037 RVA: 0x0006503E File Offset: 0x0006323E
		// (set) Token: 0x060013AE RID: 5038 RVA: 0x00065046 File Offset: 0x00063246
		public Vector2[] Points
		{
			get
			{
				return this.m_points;
			}
			set
			{
				if (this.m_points == value)
				{
					return;
				}
				this.m_points = value;
				this.SetAllDirty();
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060013AF RID: 5039 RVA: 0x0006505F File Offset: 0x0006325F
		// (set) Token: 0x060013B0 RID: 5040 RVA: 0x00065067 File Offset: 0x00063267
		public List<Vector2[]> Segments
		{
			get
			{
				return this.m_segments;
			}
			set
			{
				this.m_segments = value;
				this.SetAllDirty();
			}
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00065078 File Offset: 0x00063278
		private void PopulateMesh(VertexHelper vh, Vector2[] pointsToDraw)
		{

		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00065664 File Offset: 0x00063864
		protected override void OnPopulateMesh(VertexHelper vh)
		{

		}

		// Token: 0x060013B3 RID: 5043 RVA: 0x000656EC File Offset: 0x000638EC
		private UIVertex[] CreateLineCap(Vector2 start, Vector2 end, UILineRenderer.SegmentType type)
		{

            return default;
        }

		// Token: 0x060013B4 RID: 5044 RVA: 0x00065778 File Offset: 0x00063978
		private UIVertex[] CreateLineSegment(Vector2 start, Vector2 end, UILineRenderer.SegmentType type)
		{

            return default;
        }

		// Token: 0x060013B5 RID: 5045 RVA: 0x000658CC File Offset: 0x00063ACC
		protected override void GeneratedUVs()
		{

		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x00065B30 File Offset: 0x00063D30
		protected override void ResolutionToNativeSize(float distance)
		{

		}

		// Token: 0x04000FFD RID: 4093
		private const float MIN_MITER_JOIN = 0.2617994f;

		// Token: 0x04000FFE RID: 4094
		private const float MIN_BEVEL_NICE_JOIN = 0.5235988f;

		// Token: 0x04000FFF RID: 4095
		private static Vector2 UV_TOP_LEFT;

		// Token: 0x04001000 RID: 4096
		private static Vector2 UV_BOTTOM_LEFT;

		// Token: 0x04001001 RID: 4097
		private static Vector2 UV_TOP_CENTER_LEFT;

		// Token: 0x04001002 RID: 4098
		private static Vector2 UV_TOP_CENTER_RIGHT;

		// Token: 0x04001003 RID: 4099
		private static Vector2 UV_BOTTOM_CENTER_LEFT;

		// Token: 0x04001004 RID: 4100
		private static Vector2 UV_BOTTOM_CENTER_RIGHT;

		// Token: 0x04001005 RID: 4101
		private static Vector2 UV_TOP_RIGHT;

		// Token: 0x04001006 RID: 4102
		private static Vector2 UV_BOTTOM_RIGHT;

		// Token: 0x04001007 RID: 4103
		private static Vector2[] startUvs;

		// Token: 0x04001008 RID: 4104
		private static Vector2[] middleUvs;

		// Token: 0x04001009 RID: 4105
		private static Vector2[] endUvs;

		// Token: 0x0400100A RID: 4106
		private static Vector2[] fullUvs;

		// Token: 0x0400100B RID: 4107
		[SerializeField]
		[Tooltip("Points to draw lines between\n Can be improved using the Resolution Option")]
		internal Vector2[] m_points;

		// Token: 0x0400100C RID: 4108
		[SerializeField]
		[Tooltip("Segments to be drawn\n This is a list of arrays of points")]
		internal List<Vector2[]> m_segments;

		// Token: 0x0400100D RID: 4109
		[SerializeField]
		[Tooltip("Thickness of the line")]
		internal float lineThickness = 2f;

		// Token: 0x0400100E RID: 4110
		[SerializeField]
		[Tooltip("Use the relative bounds of the Rect Transform (0,0 -> 0,1) or screen space coordinates")]
		internal bool relativeSize;

		// Token: 0x0400100F RID: 4111
		[SerializeField]
		[Tooltip("Do the points identify a single line or split pairs of lines")]
		internal bool lineList;

		// Token: 0x04001010 RID: 4112
		[SerializeField]
		[Tooltip("Add end caps to each line\nMultiple caps when used with Line List")]
		internal bool lineCaps;

		// Token: 0x04001011 RID: 4113
		[SerializeField]
		[Tooltip("Resolution of the Bezier curve, different to line Resolution")]
		internal int bezierSegmentsPerCurve = 10;

		// Token: 0x04001012 RID: 4114
		[Tooltip("The type of Join used between lines, Square/Mitre or Curved/Bevel")]
		public UILineRenderer.JoinType LineJoins;

		// Token: 0x04001013 RID: 4115
		[Tooltip("Bezier method to apply to line, see docs for options\nCan't be used in conjunction with Resolution as Bezier already changes the resolution")]
		public UILineRenderer.BezierType BezierMode;

		// Token: 0x04001014 RID: 4116
		[HideInInspector]
		public bool drivenExternally;

		// Token: 0x02000442 RID: 1090
		private enum SegmentType
		{
			// Token: 0x04001ED7 RID: 7895
			Start,
			// Token: 0x04001ED8 RID: 7896
			Middle,
			// Token: 0x04001ED9 RID: 7897
			End,
			// Token: 0x04001EDA RID: 7898
			Full
		}

		// Token: 0x02000443 RID: 1091
		public enum JoinType
		{
			// Token: 0x04001EDC RID: 7900
			Bevel,
			// Token: 0x04001EDD RID: 7901
			Miter
		}

		// Token: 0x02000444 RID: 1092
		public enum BezierType
		{
			// Token: 0x04001EDF RID: 7903
			None,
			// Token: 0x04001EE0 RID: 7904
			Quick,
			// Token: 0x04001EE1 RID: 7905
			Basic,
			// Token: 0x04001EE2 RID: 7906
			Improved,
			// Token: 0x04001EE3 RID: 7907
			Catenary
		}
	}
}
