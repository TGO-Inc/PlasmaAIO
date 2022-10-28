using System;
using System.Collections;
using System.Collections.Generic;
using Common.Math;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

// Token: 0x02000007 RID: 7
public class BuildReplayCanvas : MonoBehaviour
{
	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000019 RID: 25 RVA: 0x00002559 File Offset: 0x00000759
	public Transform dummyCamera
	{
		get
		{
			return this._dummyTransform.transform;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600001A RID: 26 RVA: 0x00002566 File Offset: 0x00000766
	// (set) Token: 0x0600001B RID: 27 RVA: 0x0000256E File Offset: 0x0000076E
	public Device operatingDevice { get; set; }

	// Token: 0x0600001C RID: 28 RVA: 0x00002577 File Offset: 0x00000777
	private void Awake()
	{

	}

	// Token: 0x0600001D RID: 29 RVA: 0x0000259F File Offset: 0x0000079F
	public void StartReplay()
	{

	}

	// Token: 0x0600001E RID: 30 RVA: 0x000025AE File Offset: 0x000007AE
	private IEnumerator ReplayCoroutine()
	{

        return default;
    }

	// Token: 0x0600001F RID: 31 RVA: 0x000025BD File Offset: 0x000007BD
	public void ToggleMakeSolid(bool value)
	{

	}

	// Token: 0x06000020 RID: 32 RVA: 0x000025C8 File Offset: 0x000007C8
	public void GenerateEventsNew()
	{

	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002704 File Offset: 0x00000904
	public void Clear()
	{

	}

	// Token: 0x06000022 RID: 34 RVA: 0x0000276C File Offset: 0x0000096C
	public void EnterCameraMode()
	{

	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002834 File Offset: 0x00000A34
	public List<ComponentHandler> GetComponentsForOperations()
	{

        return default;
    }

	// Token: 0x06000024 RID: 36 RVA: 0x000028A0 File Offset: 0x00000AA0
	private BuildReplayComponent FindByComponent(ComponentHandler componentHandler)
	{

        return default;
    }

	// Token: 0x06000025 RID: 37 RVA: 0x00002904 File Offset: 0x00000B04
	private BuildReplayComponent FindByGuid(int guid)
	{

        return default;
    }

	// Token: 0x06000026 RID: 38 RVA: 0x00002960 File Offset: 0x00000B60
	public void Delete(BuildReplayComponent component)
	{

	}

	// Token: 0x06000027 RID: 39 RVA: 0x0000297C File Offset: 0x00000B7C
	private Vector3 LocalPosition(Vector3 p)
	{

        return default;
    }

	// Token: 0x06000028 RID: 40 RVA: 0x000029BC File Offset: 0x00000BBC
	public void SetOVerrideKeylightRotation(Vector3 value)
	{

	}

	// Token: 0x06000029 RID: 41 RVA: 0x000029CC File Offset: 0x00000BCC
	private Quaternion LocalRotation(Quaternion r)
	{

        return default;
    }

	// Token: 0x0600002A RID: 42 RVA: 0x000029F0 File Offset: 0x00000BF0
	public void SetCameraTransform()
	{

	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002B62 File Offset: 0x00000D62
	public void OpenSketch(ComponentHandler componentHandler)
	{

	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002B6F File Offset: 0x00000D6F
	public void OnSketchClose()
	{

	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002B8C File Offset: 0x00000D8C
	public BuildReplayCanvas.SerializedData Save()
	{

        return default;
    }

	// Token: 0x0600002E RID: 46 RVA: 0x00002C6C File Offset: 0x00000E6C
	public void Load(BuildReplayCanvas.SerializedData serializedData)
	{

	}

	// Token: 0x04000021 RID: 33
	public GameObject componentEventPrefab;

	// Token: 0x04000022 RID: 34
	public Transform content;

	// Token: 0x04000023 RID: 35
	public float stepChange = 0.05f;

	// Token: 0x04000024 RID: 36
	public float cameraTime = 0.5f;

	// Token: 0x04000025 RID: 37
	public float waitTime = 0.2f;

	// Token: 0x04000026 RID: 38
	public float delayTime = 1f;

	// Token: 0x04000027 RID: 39
	private List<BuildReplayComponent> _components;

	// Token: 0x04000028 RID: 40
	private int _cameraMoveIndex;

	// Token: 0x04000029 RID: 41
	private GameObject _dummyTransform;

	// Token: 0x0400002A RID: 42
	private bool _hasSpawned;

	// Token: 0x0400002B RID: 43
	private Camera _camera;

	// Token: 0x0400002C RID: 44
	private bool _cameraSetToggle;

	// Token: 0x0400002D RID: 45
	private bool _makeSolid;

	// Token: 0x0400002E RID: 46
	private int _uniqueGuid;

	// Token: 0x0400002F RID: 47
	private bool _overrideKeylightRotation;

	// Token: 0x04000030 RID: 48
	private Vector3 _keylightRotation;

	// Token: 0x04000031 RID: 49
	private BuildReplayComponent _current;

	// Token: 0x020002CE RID: 718
	public class SerializedData
	{
		// Token: 0x0400191E RID: 6430
		public int deviceGuid;

		// Token: 0x0400191F RID: 6431
		public BuildReplayCanvas.SerializedComponent[] components;

		// Token: 0x04001920 RID: 6432
		public float timerWait;

		// Token: 0x04001921 RID: 6433
		public float timerCamera;

		// Token: 0x04001922 RID: 6434
		public float timerStep;

		// Token: 0x04001923 RID: 6435
		public float timerDelay;

		// Token: 0x04001924 RID: 6436
		public bool makeSolid;

		// Token: 0x04001925 RID: 6437
		public bool overrideKeylightRotation;

		// Token: 0x04001926 RID: 6438
		public Vector3 keyLightRotation;
	}

	// Token: 0x020002CF RID: 719
	public class SerializedComponent
	{
		// Token: 0x06001E43 RID: 7747 RVA: 0x00095A69 File Offset: 0x00093C69
		public SerializedComponent()
		{

		}

		// Token: 0x04001927 RID: 6439
		public int uniqueId;

		// Token: 0x04001928 RID: 6440
		public int parentUniqueId;

		// Token: 0x04001929 RID: 6441
		public int[] childrenIndices;

		// Token: 0x0400192A RID: 6442
		public int componentGuid;

		// Token: 0x0400192B RID: 6443
		public Vector3 fromPosition;

		// Token: 0x0400192C RID: 6444
		public Vector3 toPosition;

		// Token: 0x0400192D RID: 6445
		public Quaternion fromRotation;

		// Token: 0x0400192E RID: 6446
		public Quaternion toRotation;

		// Token: 0x0400192F RID: 6447
		public QTransform childReferenceFrame;

		// Token: 0x04001930 RID: 6448
		public QTransform parentReferenceFrame;

		// Token: 0x04001931 RID: 6449
		public int[] mergedComponentIds;

		// Token: 0x04001932 RID: 6450
		public bool openSketch;
	}
}
