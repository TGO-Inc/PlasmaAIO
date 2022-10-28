using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using DG.Tweening;
using DG.Tweening.Timeline;
using Rewired;
using TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Visor
{
	// Token: 0x0200023D RID: 573
	public class DeviceEditor : MonoBehaviour
	{
		// Token: 0x060014C9 RID: 5321 RVA: 0x00069C38 File Offset: 0x00067E38
		private void Awake()
		{

		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00069D18 File Offset: 0x00067F18
		public void Setup(Device device)
		{

		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00069FAC File Offset: 0x000681AC
		private void UpdateSpecialPermissions()
		{

		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0006A0BF File Offset: 0x000682BF
		private void HandleSelection(string text)
		{

		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0006A0D7 File Offset: 0x000682D7
		public void SetStaticOption(bool value)
		{

		}

		// Token: 0x060014CE RID: 5326 RVA: 0x0006A0E5 File Offset: 0x000682E5
		public void SetTreeLinesOption(bool value)
		{

		}

		// Token: 0x060014CF RID: 5327 RVA: 0x0006A0F3 File Offset: 0x000682F3
		public void SetStartInSolid(bool value)
		{

		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x0006A107 File Offset: 0x00068307
		public void SetResetOnStart(bool value)
		{

		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x0006A115 File Offset: 0x00068315
		public void SetPermission(WorldController.GlobalPermissions permission, WorldController.GlobalPermissionStates state)
		{

		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x0006A12F File Offset: 0x0006832F
		private void Start()
		{

		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0006A13D File Offset: 0x0006833D
		private IEnumerator CheckInput()
		{

            return default;
        }

		// Token: 0x060014D4 RID: 5332 RVA: 0x0006A14C File Offset: 0x0006834C
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0006A1BF File Offset: 0x000683BF
		public void PreOpen()
		{

		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0006A1F3 File Offset: 0x000683F3
		public void PostOpen()
		{

		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x0006A210 File Offset: 0x00068410
		public Sequence GetOpenSequence()
		{

            return default;
        }

		// Token: 0x060014D8 RID: 5336 RVA: 0x0006A23A File Offset: 0x0006843A
		public void PreClose()
		{

		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0006A254 File Offset: 0x00068454
		public Sequence GetCloseSequence()
		{

            return default;
        }

		// Token: 0x060014DA RID: 5338 RVA: 0x0006A27E File Offset: 0x0006847E
		public void Close()
		{

		}

		// Token: 0x060014DB RID: 5339 RVA: 0x0006A28F File Offset: 0x0006848F
		public void CloseAndOpenSaveDevice()
		{

		}

		// Token: 0x040010DC RID: 4316
		public GameObject saveDeviceButton;

		// Token: 0x040010DD RID: 4317
		public TMP_InputField nameField;

		// Token: 0x040010DE RID: 4318
		public TextMeshProUGUI description;

		// Token: 0x040010DF RID: 4319
		public BetterToggle staticOption;

		// Token: 0x040010E0 RID: 4320
		public BetterToggle treeLinesOption;

		// Token: 0x040010E1 RID: 4321
		public BetterToggle startInSolidOption;

		// Token: 0x040010E2 RID: 4322
		public BetterToggle resetOnStartOption;

		// Token: 0x040010E3 RID: 4323
		public DevicePermission manipulationPermission;

		// Token: 0x040010E4 RID: 4324
		public DevicePermission stateTogglePermission;

		// Token: 0x040010E5 RID: 4325
		public DevicePermission grabWireframePermission;

		// Token: 0x040010E6 RID: 4326
		public DevicePermission propertyEditorPermission;

		// Token: 0x040010E7 RID: 4327
		public DevicePermission sketchAccessPermission;

		// Token: 0x040010E8 RID: 4328
		public DevicePermission sketchEditPermission;

		// Token: 0x040010E9 RID: 4329
		public DevicePermission deviceDeletePermission;

		// Token: 0x040010EA RID: 4330
		public DevicePermission grabSolidPermission;

		// Token: 0x040010EB RID: 4331
		public DevicePermission attachDetachPermission;

		// Token: 0x040010EC RID: 4332
		public DevicePermission clonePermission;

		// Token: 0x040010ED RID: 4333
		public DevicePermission resetDevicePermission;

		// Token: 0x040010EE RID: 4334
		public DevicePermission paintComponentPermission;

		// Token: 0x040010EF RID: 4335
		public TextMeshProUGUI componentsNumberValue;

		// Token: 0x040010F0 RID: 4336
		public TextMeshProUGUI massValue;

		// Token: 0x040010F1 RID: 4337
		public TextMeshProUGUI lastSaveValue;

		// Token: 0x040010F2 RID: 4338
		public CanvasGroup stageArea;

		// Token: 0x040010F3 RID: 4339
		public DOVisualSequence openSequence;

		// Token: 0x040010F4 RID: 4340
		public DOVisualSequence closeSequence;

		// Token: 0x040010F5 RID: 4341
		private Player _input;

		// Token: 0x040010F6 RID: 4342
		private IEnumerator _coroutine;

		// Token: 0x040010F7 RID: 4343
		private string _oldDeviceName;

		// Token: 0x040010F8 RID: 4344
		private Device _device;

		// Token: 0x040010F9 RID: 4345
		private Dictionary<WorldController.GlobalPermissions, DevicePermission> _permissions;
	}
}
