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
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass {
// Token: 0x020001AD RID: 429
public class FastColorPicker : MonoBehaviour, IDragHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
{
	// Token: 0x06000FEC RID: 4076 RVA: 0x00053B14 File Offset: 0x00051D14
	private void Awake()
	{

	}

	// Token: 0x06000FED RID: 4077 RVA: 0x00053B6D File Offset: 0x00051D6D
	private void Start()
	{
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x00053B70 File Offset: 0x00051D70
	private void Update()
	{

	}

	// Token: 0x06000FEF RID: 4079 RVA: 0x00053BD0 File Offset: 0x00051DD0
	public void SetPickerColor(Color newcolor, bool doInvoke = true)
	{

	}

	// Token: 0x06000FF0 RID: 4080 RVA: 0x00053C48 File Offset: 0x00051E48
	public void Reinitialize()
	{

	}

	// Token: 0x06000FF1 RID: 4081 RVA: 0x00053F15 File Offset: 0x00052115
	private void SetCursorColor(Color col)
	{

	}

	// Token: 0x06000FF2 RID: 4082 RVA: 0x00053F30 File Offset: 0x00052130
	private void GetUIElementPos01(RectTransform rectTrans, PointerEventData ped, ref Vector2 position)
	{

	}

	// Token: 0x06000FF3 RID: 4083 RVA: 0x00053FBC File Offset: 0x000521BC
	private Color ColorToLinear(Color col)
	{

        return default;
    }

	// Token: 0x06000FF4 RID: 4084 RVA: 0x00054010 File Offset: 0x00052210
	private void SetCursorPos01(Vector2 pos, bool immediate)
	{

	}

	// Token: 0x06000FF5 RID: 4085 RVA: 0x0005408C File Offset: 0x0005228C
	private void CircleSetColor(Color col, bool fromHueOnly, bool doInvoke)
	{

	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x000541B8 File Offset: 0x000523B8
	private void UpdateCursorPosBasedOnColor()
	{

	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x00054298 File Offset: 0x00052498
	private void ProcessMouseEvent(PointerEventData ped, bool drag)
	{

	}

	// Token: 0x06000FF8 RID: 4088 RVA: 0x00054398 File Offset: 0x00052598
	private void DoCircleStuff(bool drag, bool doInvoke, float hue = -1f)
	{

	}

	// Token: 0x06000FF9 RID: 4089 RVA: 0x0005451C File Offset: 0x0005271C
	private void DoTheTriangleStuff()
	{

	}

	// Token: 0x06000FFA RID: 4090 RVA: 0x00054734 File Offset: 0x00052934
	private Color GetTriangleColor01(Vector2 pos)
	{

        return default;
    }

	// Token: 0x06000FFB RID: 4091 RVA: 0x000548C4 File Offset: 0x00052AC4
	private Vector3 Barycentric(Vector3 p, Vector3 a, Vector3 b, Vector3 c)
	{

        return default;
    }

	// Token: 0x06000FFC RID: 4092 RVA: 0x0005496A File Offset: 0x00052B6A
	public void OnDrag(PointerEventData ped)
	{

	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x00054994 File Offset: 0x00052B94
	public void OnPointerDown(PointerEventData ped)
	{

	}

	// Token: 0x06000FFE RID: 4094 RVA: 0x000549A5 File Offset: 0x00052BA5
	public void OnPointerUp(PointerEventData ped)
	{

	}

	// Token: 0x04000D9D RID: 3485
	[Header("[REFERENCES]")]
	public RawImage circleRawImage;

	// Token: 0x04000D9E RID: 3486
	public RawImage triangleRawImage;

	// Token: 0x04000D9F RID: 3487
	public RawImage cursorRawImage;

	// Token: 0x04000DA0 RID: 3488
	public RectTransform cursor;

	// Token: 0x04000DA1 RID: 3489
	[Header("[PARAMETERS]")]
	public Color startingColor;

	// Token: 0x04000DA2 RID: 3490
	public int textureSize;

	// Token: 0x04000DA3 RID: 3491
	public float cursorSmoothTime;

	// Token: 0x04000DA4 RID: 3492
	[Header("[DEBUG]")]
	public Material circleMaterial;

	// Token: 0x04000DA5 RID: 3493
	public Material triangleMaterial;

	// Token: 0x04000DA6 RID: 3494
	public ActiveObjectType activeObject;

	// Token: 0x04000DA7 RID: 3495
	public bool initialized;

	// Token: 0x04000DA8 RID: 3496
	public RenderTexture rtCircle;

	// Token: 0x04000DA9 RID: 3497
	public RenderTexture rtTriangle;

	// Token: 0x04000DAA RID: 3498
	public Texture2D tempTexture;

	// Token: 0x04000DAB RID: 3499
	public Texture2D tempCircleTexture;

	// Token: 0x04000DAC RID: 3500
	public Texture2D tempTriangleTexture;

	// Token: 0x04000DAD RID: 3501
	public RectTransform rectCircle;

	// Token: 0x04000DAE RID: 3502
	public RectTransform rectTriangle;

	// Token: 0x04000DAF RID: 3503
	public Vector2 circlePos;

	// Token: 0x04000DB0 RID: 3504
	public Color circleSelectedColor;

	// Token: 0x04000DB1 RID: 3505
	public Color triangleSelectedColor;

	// Token: 0x04000DB2 RID: 3506
	public Color finalSelectedColor;

	// Token: 0x04000DB3 RID: 3507
	public Vector2 lastCursorPos01;

	// Token: 0x04000DB4 RID: 3508
	public Vector2 lastValidCursorPos01;

	// Token: 0x04000DB5 RID: 3509
	public Vector2 wantedCursorPos01;

	// Token: 0x04000DB6 RID: 3510
	public Vector2 currentCursorPos01;

	// Token: 0x04000DB7 RID: 3511
	public Vector2 trianglePos01;

	// Token: 0x04000DB8 RID: 3512
	private Vector2 v2;

	// Token: 0x04000DB9 RID: 3513
	private Vector3[] RPoints;

	// Token: 0x04000DBA RID: 3514
	private float currentCircleAngle;

	// Token: 0x04000DBB RID: 3515
	private float previousCircleAngle;

	// Token: 0x04000DBC RID: 3516
	public FastColorPicker.ChangedColorEvent changedColorEvent;

	// Token: 0x020003D5 RID: 981
	// (Invoke) Token: 0x06002113 RID: 8467
	public delegate void ChangedColorEvent(Color color);
}
}