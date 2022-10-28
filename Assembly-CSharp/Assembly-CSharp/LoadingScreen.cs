using System;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000025 RID: 37
public class LoadingScreen : MonoBehaviour
{
	// Token: 0x1700000F RID: 15
	// (get) Token: 0x060000B0 RID: 176 RVA: 0x000058F9 File Offset: 0x00003AF9
	// (set) Token: 0x060000B1 RID: 177 RVA: 0x00005901 File Offset: 0x00003B01
	public bool isDone { get; private set; }

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000590A File Offset: 0x00003B0A
	public bool isRotating
	{
		get
		{
			return this._state == LoadingScreen.States.Rotating;
		}
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00005915 File Offset: 0x00003B15
	private void Awake()
	{

	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00005924 File Offset: 0x00003B24
	public void Setup(bool shouldFadeIn)
	{

	}

	// Token: 0x060000B5 RID: 181 RVA: 0x000059A4 File Offset: 0x00003BA4
	private void Update()
	{

	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00005E62 File Offset: 0x00004062
	public void End()
	{

	}

	// Token: 0x040000C9 RID: 201
	public RectTransform outerDisc;

	// Token: 0x040000CA RID: 202
	public RectTransform innerDisc;

	// Token: 0x040000CB RID: 203
	[ColorUsage(true, true)]
	public Color orange;

	// Token: 0x040000CC RID: 204
	[ColorUsage(true, true)]
	public Color green;

	// Token: 0x040000CD RID: 205
	public Image led;

	// Token: 0x040000CE RID: 206
	public Image reader;

	// Token: 0x040000CF RID: 207
	public float maxSpeed;

	// Token: 0x040000D0 RID: 208
	public float startStopDuration;

	// Token: 0x040000D1 RID: 209
	public float searchDuration;

	// Token: 0x040000D2 RID: 210
	public float connectionDuration;

	// Token: 0x040000D3 RID: 211
	public float rotationDuration;

	// Token: 0x040000D4 RID: 212
	public float alignDuration;

	// Token: 0x040000D5 RID: 213
	public float endDuration;

	// Token: 0x040000D6 RID: 214
	public float fadeDuration;

	// Token: 0x040000D7 RID: 215
	private CanvasGroup _canvasGroup;

	// Token: 0x040000D8 RID: 216
	private bool _shouldEnd;

	// Token: 0x040000D9 RID: 217
	private float _finalSpeed;

	// Token: 0x040000DA RID: 218
	private float _speed;

	// Token: 0x040000DB RID: 219
	private float _elapsed;

	// Token: 0x040000DC RID: 220
	private LoadingScreen.States _state;

	// Token: 0x040000DD RID: 221
	private int _lastIndex;

	// Token: 0x040000DE RID: 222
	private int _attempts;

	// Token: 0x020002D3 RID: 723
	private enum States
	{
		// Token: 0x04001946 RID: 6470
		Delay,
		// Token: 0x04001947 RID: 6471
		FadeIn,
		// Token: 0x04001948 RID: 6472
		Waiting,
		// Token: 0x04001949 RID: 6473
		Starting,
		// Token: 0x0400194A RID: 6474
		Searching,
		// Token: 0x0400194B RID: 6475
		StartConnecting,
		// Token: 0x0400194C RID: 6476
		Connecting,
		// Token: 0x0400194D RID: 6477
		StartRotating,
		// Token: 0x0400194E RID: 6478
		Rotating,
		// Token: 0x0400194F RID: 6479
		StopRotating,
		// Token: 0x04001950 RID: 6480
		Aligning,
		// Token: 0x04001951 RID: 6481
		Stopping
	}
}
