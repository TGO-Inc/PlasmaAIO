using System;
using Newtonsoft.Json;
using UnityEngine;
using Visor;

// Token: 0x020000EB RID: 235
public abstract class DisplayUIElement
{
	// Token: 0x060009F3 RID: 2547 RVA: 0x00034BBE File Offset: 0x00032DBE
	protected DisplayUIElement()
	{

	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x00034BD6 File Offset: 0x00032DD6
	public virtual bool IsWithinRect(Vector2Int position)
	{

        return default;
    }

	// Token: 0x060009F5 RID: 2549 RVA: 0x00034BE4 File Offset: 0x00032DE4
	public virtual void CreateUI(Transform container)
	{

	}

	// Token: 0x060009F6 RID: 2550
	public abstract GameObject GetPrefab();

	// Token: 0x060009F7 RID: 2551 RVA: 0x00034C87 File Offset: 0x00032E87
	public virtual void OnPointerEnter()
	{
	}

	// Token: 0x060009F8 RID: 2552 RVA: 0x00034C89 File Offset: 0x00032E89
	public virtual void OnPointerExit()
	{
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x00034C8B File Offset: 0x00032E8B
	public virtual void OnPointerPressed()
	{
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x00034C8D File Offset: 0x00032E8D
	public virtual void OnPointerReleased()
	{
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x00034C90 File Offset: 0x00032E90
	public string SerializeAndAppend(string document)
	{

        return default;
    }

	// Token: 0x04000910 RID: 2320
	public int type;

	// Token: 0x04000911 RID: 2321
	public int id;

	// Token: 0x04000912 RID: 2322
	public int x;

	// Token: 0x04000913 RID: 2323
	public int y;

	// Token: 0x04000914 RID: 2324
	public int width;

	// Token: 0x04000915 RID: 2325
	public int height;

	// Token: 0x04000916 RID: 2326
	public float colorR;

	// Token: 0x04000917 RID: 2327
	public float colorG;

	// Token: 0x04000918 RID: 2328
	public float colorB;

	// Token: 0x04000919 RID: 2329
	[NonSerialized]
	protected GameObject _element;

	// Token: 0x0400091A RID: 2330
	[NonSerialized]
	protected readonly Visor.Visor _visor;

	// Token: 0x0400091B RID: 2331
	[NonSerialized]
	private RectTransform _rectTransform;

	// Token: 0x0400091C RID: 2332
	[NonSerialized]
	private RectInt _rect;
}
