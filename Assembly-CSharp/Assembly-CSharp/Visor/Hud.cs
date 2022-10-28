using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using DG.Tweening;
using EasyFSM;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x02000244 RID: 580
	public class Hud : VisorElement
	{
		// Token: 0x0600152F RID: 5423 RVA: 0x0006B6B8 File Offset: 0x000698B8
		private void Awake()
		{

		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0006B708 File Offset: 0x00069908
		protected override void CustomSetup()
		{

		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0006B9FE File Offset: 0x00069BFE
		public override void OnFinishEnabled()
		{

		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0006BA0C File Offset: 0x00069C0C
		public override void OnFinishDisabled()
		{

		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0006BA1A File Offset: 0x00069C1A
		private IEnumerator Fade(object inDirection)
		{

            return default;
        }

		// Token: 0x06001534 RID: 5428 RVA: 0x0006BA30 File Offset: 0x00069C30
		private IEnumerator WaitToFade()
		{

            return default;
        }

		// Token: 0x06001535 RID: 5429 RVA: 0x0006BA40 File Offset: 0x00069C40
		public void SetComponentHandler(ComponentHandler componentHandler, bool showInSolid = false, bool forceUpdate = false)
		{

		}

		// Token: 0x06001536 RID: 5430 RVA: 0x0006BA8F File Offset: 0x00069C8F
		public void Hide()
		{

		}

		// Token: 0x06001537 RID: 5431 RVA: 0x0006BAA8 File Offset: 0x00069CA8
		private void Update()
		{

		}

		// Token: 0x06001538 RID: 5432 RVA: 0x0006BE9B File Offset: 0x0006A09B
		public void EnterEditMode()
		{

		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0006BED0 File Offset: 0x0006A0D0
		private void SetupEditMode()
		{

		}

		// Token: 0x0600153A RID: 5434 RVA: 0x0006C480 File Offset: 0x0006A680
		public void ExitEditMode()
		{

		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0006C514 File Offset: 0x0006A714
		private void SetupPropertyForEditing(int index)
		{

		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0006C550 File Offset: 0x0006A750
		private void SetLinesVisibility(bool visible)
		{

		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0006C57B File Offset: 0x0006A77B
		private void HandleRightAreaVisibility()
		{

		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0006C5A3 File Offset: 0x0006A7A3
		public void ShowInfoPanel()
		{

		}

		// Token: 0x0600153F RID: 5439 RVA: 0x0006C5E2 File Offset: 0x0006A7E2
		public void HideInfoPanel()
		{

		}

		// Token: 0x06001540 RID: 5440 RVA: 0x0006C5F8 File Offset: 0x0006A7F8
		public void ShowDetails(Hud.Details details, Hud.DetailsAxis axis = (Hud.DetailsAxis)0)
		{

		}

		// Token: 0x06001541 RID: 5441 RVA: 0x0006CCE0 File Offset: 0x0006AEE0
		public void ShowHints(List<HintGestaltEnum> hintGestaltIds, bool generic = false)
		{

		}

		// Token: 0x04001132 RID: 4402
		public TextMeshProUGUI componentName;

		// Token: 0x04001133 RID: 4403
		public TextMeshProUGUI deviceName;

		// Token: 0x04001134 RID: 4404
		public TextMeshProUGUI massValue;

		// Token: 0x04001135 RID: 4405
		public Image icon;

		// Token: 0x04001136 RID: 4406
		public GameObject leftArea;

		// Token: 0x04001137 RID: 4407
		public GameObject rightArea;

		// Token: 0x04001138 RID: 4408
		public GameObject infoArea;

		// Token: 0x04001139 RID: 4409
		public GameObject detailsArea;

		// Token: 0x0400113A RID: 4410
		public RectTransform leftArc;

		// Token: 0x0400113B RID: 4411
		public RectTransform leftVerticalLine;

		// Token: 0x0400113C RID: 4412
		public Transform hintsArea;

		// Token: 0x0400113D RID: 4413
		public RectTransform rightArc;

		// Token: 0x0400113E RID: 4414
		public RectTransform rightVerticalLine;

		// Token: 0x0400113F RID: 4415
		public float genericHintsPosition;

		// Token: 0x04001140 RID: 4416
		public TextMeshProUGUI editLabel;

		// Token: 0x04001141 RID: 4417
		public AdvancedHudProperty rollProperty;

		// Token: 0x04001142 RID: 4418
		public AdvancedHudProperty pitchProperty;

		// Token: 0x04001143 RID: 4419
		public AdvancedHudProperty yawProperty;

		// Token: 0x04001144 RID: 4420
		public AdvancedHudProperty offsetProperty;

		// Token: 0x04001145 RID: 4421
		public AdvancedHudProperty scaleOneProperty;

		// Token: 0x04001146 RID: 4422
		public AdvancedHudProperty scaleTwoProperty;

		// Token: 0x04001147 RID: 4423
		public AdvancedHudProperty scaleThreeProperty;

		// Token: 0x04001148 RID: 4424
		public Image[] lines;

		// Token: 0x04001149 RID: 4425
		public Sprite pinIcon;

		// Token: 0x0400114A RID: 4426
		public Sprite unpinIcon;

		// Token: 0x0400114B RID: 4427
		private RectTransform _infoPanelTransform;

		// Token: 0x0400114C RID: 4428
		private RectTransform _componentNameTextTransform;

		// Token: 0x0400114D RID: 4429
		private RectTransform _deviceNameTextTransform;

		// Token: 0x0400114E RID: 4430
		private RectTransform _massValueTextTransform;

		// Token: 0x0400114F RID: 4431
		private RectTransform _editLabelTransform;

		// Token: 0x04001150 RID: 4432
		private ComponentHandler _component;

		// Token: 0x04001151 RID: 4433
		private CanvasGroup _canvasGroup;

		// Token: 0x04001152 RID: 4434
		private bool _onValidComponent;

		// Token: 0x04001153 RID: 4435
		private float _fadeTimer;

		// Token: 0x04001154 RID: 4436
		private bool _shouldUpdate;

		// Token: 0x04001155 RID: 4437
		private bool _shouldHide;

		// Token: 0x04001156 RID: 4438
		private Hud.Details _currentDetails;

		// Token: 0x04001157 RID: 4439
		private float _leftDetailSize;

		// Token: 0x04001158 RID: 4440
		private float _rightDetailSize;

		// Token: 0x04001159 RID: 4441
		private Image _leftArcImage;

		// Token: 0x0400115A RID: 4442
		private float _leftArcPosition;

		// Token: 0x0400115B RID: 4443
		private List<HintGestaltEnum> _currentIds;

		// Token: 0x0400115C RID: 4444
		private List<HintGestaltEnum> _incomingIds;

		// Token: 0x0400115D RID: 4445
		private List<AdvancedHudProperty> _activeProperties;

		// Token: 0x0400115E RID: 4446
		private int _currentPropertyIndex;

		// Token: 0x0400115F RID: 4447
		private bool _inEditMode;

		// Token: 0x04001160 RID: 4448
		private bool _rootOnlyMode;

		// Token: 0x04001161 RID: 4449
		private bool _shouldShowAtStart;

		// Token: 0x04001162 RID: 4450
		private Player _input;

		// Token: 0x0200045B RID: 1115
		public enum Details
		{
			// Token: 0x04001F2E RID: 7982
			None,
			// Token: 0x04001F2F RID: 7983
			Rotation,
			// Token: 0x04001F30 RID: 7984
			Offset,
			// Token: 0x04001F31 RID: 7985
			Scale
		}

		// Token: 0x0200045C RID: 1116
		[Flags]
		public enum DetailsAxis
		{
			// Token: 0x04001F33 RID: 7987
			First = 1,
			// Token: 0x04001F34 RID: 7988
			Second = 2,
			// Token: 0x04001F35 RID: 7989
			Third = 4
		}
	}
}
