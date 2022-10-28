using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// Token: 0x02000020 RID: 32
public class ImageDebugger : MonoBehaviour
{
	// Token: 0x06000094 RID: 148 RVA: 0x00004EC3 File Offset: 0x000030C3
	private void Awake()
	{

	}

	// Token: 0x06000095 RID: 149 RVA: 0x00004F03 File Offset: 0x00003103
	private void OnDestroy()
	{

	}

	// Token: 0x06000096 RID: 150 RVA: 0x00004F38 File Offset: 0x00003138
	private void OnEnable()
	{

	}

	// Token: 0x06000097 RID: 151 RVA: 0x00004FAC File Offset: 0x000031AC
	private void HandleOnImageAdded(int index)
	{

	}

	// Token: 0x06000098 RID: 152 RVA: 0x00005184 File Offset: 0x00003384
	private void HandleOnImagesRemoved(List<int> indices)
	{

	}

	// Token: 0x06000099 RID: 153 RVA: 0x000052CC File Offset: 0x000034CC
	private void HandlOnImageReferenceCountUpdated(int index)
	{

	}

	// Token: 0x0600009A RID: 154 RVA: 0x00005318 File Offset: 0x00003518
	private int GetBitsPerPixelTexture2D(TextureFormat format)
	{

        return default;
    }

	// Token: 0x0600009B RID: 155 RVA: 0x000053D0 File Offset: 0x000035D0
	private int GetBitsPerPixelRenderTexture(RenderTextureFormat format)
	{

        return default;
    }

	// Token: 0x0600009C RID: 156 RVA: 0x000054A8 File Offset: 0x000036A8
	private int CalculateTextureSizeBytes(Texture texture)
	{

        return default;
    }

	// Token: 0x040000B9 RID: 185
	public Transform grid;

	// Token: 0x040000BA RID: 186
	public GameObject cellTemplate;

	// Token: 0x040000BB RID: 187
	public TextMeshProUGUI totalMemoryLabel;

	// Token: 0x040000BC RID: 188
	private Dictionary<int, GameObject> _cells;

	// Token: 0x040000BD RID: 189
	private int _totalMemory;
}
