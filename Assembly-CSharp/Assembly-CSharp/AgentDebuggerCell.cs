using System;
using System.Collections;
using System.Collections.Generic;
using Behavior;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000005 RID: 5
public class AgentDebuggerCell : SerializedMonoBehaviour
{
	// Token: 0x06000009 RID: 9 RVA: 0x0000214C File Offset: 0x0000034C
	public void Setup(AgentProperty property)
	{

	}

	// Token: 0x0600000A RID: 10 RVA: 0x000021B4 File Offset: 0x000003B4
	private void Build()
	{

	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002258 File Offset: 0x00000458
	private void UpdateContent()
	{

	}

	// Token: 0x0600000C RID: 12 RVA: 0x0000237F File Offset: 0x0000057F
	private IEnumerator HighlightContent()
	{

        return default;
    }

	// Token: 0x0600000D RID: 13 RVA: 0x0000238E File Offset: 0x0000058E
	private void OnDestroy()
	{

	}

	// Token: 0x0400000B RID: 11
	public TextMeshProUGUI propertyName;

	// Token: 0x0400000C RID: 12
	public Image dataType;

	// Token: 0x0400000D RID: 13
	public Dictionary<Data.Types, GameObject> types;

	// Token: 0x0400000E RID: 14
	public Color normalColor;

	// Token: 0x0400000F RID: 15
	public Color highlightColor;

	// Token: 0x04000010 RID: 16
	public Color normalBackgroundColor;

	// Token: 0x04000011 RID: 17
	public Color highlightBackgroundColor;

	// Token: 0x04000012 RID: 18
	public float highlightDuration;

	// Token: 0x04000013 RID: 19
	private AgentProperty _property;

	// Token: 0x04000014 RID: 20
	private Data.Types _type;

	// Token: 0x04000015 RID: 21
	private GameObject _area;

	// Token: 0x04000016 RID: 22
	private RawImage _image;

	// Token: 0x04000017 RID: 23
	private TextMeshProUGUI _text;

	// Token: 0x04000018 RID: 24
	private Data _oldValue;

	// Token: 0x04000019 RID: 25
	private Coroutine _coroutine;

	// Token: 0x0400001A RID: 26
	private float _elapsed;
}
