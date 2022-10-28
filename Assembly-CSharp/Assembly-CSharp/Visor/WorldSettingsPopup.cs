using System;
using System.Collections.Generic;
using TheraBytes.BetterUi;
using TMPro;
using UnityEngine;

namespace Visor
{
	// Token: 0x020002B9 RID: 697
	public class WorldSettingsPopup : MonoBehaviour, IGenericWindow
	{
		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x0008D15F File Offset: 0x0008B35F
		public string title
		{
			get
			{
				return "WORLD SETTINGS";
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x0008D166 File Offset: 0x0008B366
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(1660f, this._height);
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x0008D178 File Offset: 0x0008B378
		// (set) Token: 0x06001C5C RID: 7260 RVA: 0x0008D180 File Offset: 0x0008B380
		public bool canClose { get; private set; }

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001C5D RID: 7261 RVA: 0x0008D189 File Offset: 0x0008B389
		// (set) Token: 0x06001C5E RID: 7262 RVA: 0x0008D191 File Offset: 0x0008B391
		public object payload { get; private set; }

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001C5F RID: 7263 RVA: 0x0008D19A File Offset: 0x0008B39A
		// (set) Token: 0x06001C60 RID: 7264 RVA: 0x0008D1A2 File Offset: 0x0008B3A2
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x0008D1AB File Offset: 0x0008B3AB
		// (set) Token: 0x06001C62 RID: 7266 RVA: 0x0008D1B3 File Offset: 0x0008B3B3
		public object closeEventPayload { get; private set; }

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001C63 RID: 7267 RVA: 0x0008D1BC File Offset: 0x0008B3BC
		// (set) Token: 0x06001C64 RID: 7268 RVA: 0x0008D1C4 File Offset: 0x0008B3C4
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x0008D1CD File Offset: 0x0008B3CD
		public string exitKey
		{
			get
			{
				return "GW_Exit";
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x0008D1D4 File Offset: 0x0008B3D4
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x0008D1D7 File Offset: 0x0008B3D7
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0008D1DC File Offset: 0x0008B3DC
		public void Setup(object setupData)
		{

		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x0008D2AE File Offset: 0x0008B4AE
		public void SetTimeOfDay(float value)
		{

		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0008D2D6 File Offset: 0x0008B4D6
		public void SetTimeSpeed(float value)
		{

		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0008D300 File Offset: 0x0008B500
		private void RefreshTimeOfDay()
		{

		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x0008D32C File Offset: 0x0008B52C
		private void RefreshTimeSpeed()
		{

		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x0008D366 File Offset: 0x0008B566
		public void SetGlobalPermission(WorldController.GlobalPermissions permission, bool value)
		{

		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0008D3A3 File Offset: 0x0008B5A3
		public void SetWorldPermission(WorldController.WorldPermissions permission, bool value)
		{

		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0008D3DC File Offset: 0x0008B5DC
		private void UpdateSpecialPermissions()
		{

		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x0008D48A File Offset: 0x0008B68A
		public void SetStartTimeOfDay(float value)
		{

		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0008D4AD File Offset: 0x0008B6AD
		public void SetStartTimeSpeed(float value)
		{

		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0008D4DC File Offset: 0x0008B6DC
		private void RefreshStartTimeOfDay()
		{

		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0008D508 File Offset: 0x0008B708
		private void RefreshStartTimeSpeed()
		{

		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0008D544 File Offset: 0x0008B744
		private void UpdateStageSettings()
		{

		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0008D654 File Offset: 0x0008B854
		public void OnStageToggled(bool value)
		{

		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0008D676 File Offset: 0x0008B876
		private void UpdateStage(bool value)
		{

		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0008D6A8 File Offset: 0x0008B8A8
		public void OnReveal()
		{

		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x0008D6EC File Offset: 0x0008B8EC
		public void OnFinishReveal()
		{
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0008D6EE File Offset: 0x0008B8EE
		public void OnConceal()
		{
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x0008D6F0 File Offset: 0x0008B8F0
		public void Close()
		{

		}

		// Token: 0x0400171C RID: 5916
		public RectTransform content;

		// Token: 0x0400171D RID: 5917
		public BetterSlider timeOfDaySlider;

		// Token: 0x0400171E RID: 5918
		public BetterSlider timeSpeedSlider;

		// Token: 0x0400171F RID: 5919
		public TextMeshProUGUI timeOfDayValue;

		// Token: 0x04001720 RID: 5920
		public TextMeshProUGUI timeSpeedValue;

		// Token: 0x04001721 RID: 5921
		public BetterToggle stagingTools;

		// Token: 0x04001722 RID: 5922
		public CanvasGroup stageArea;

		// Token: 0x04001723 RID: 5923
		public BetterSlider startTimeOfDaySlider;

		// Token: 0x04001724 RID: 5924
		public BetterSlider startTimeSpeedSlider;

		// Token: 0x04001725 RID: 5925
		public TextMeshProUGUI startTimeOfDayValue;

		// Token: 0x04001726 RID: 5926
		public TextMeshProUGUI startTimeSpeedValue;

		// Token: 0x04001727 RID: 5927
		public BetterToggle resetDevicePermission;

		// Token: 0x04001728 RID: 5928
		public BetterToggle editSketchPermission;

		// Token: 0x04001729 RID: 5929
		public BetterToggle deletePermission;

		// Token: 0x0400172A RID: 5930
		public List<WorldPermission> worldPermissions;

		// Token: 0x0400172B RID: 5931
		public List<GlobalPermission> globalPermissions;

		// Token: 0x0400172C RID: 5932
		public TextMeshProUGUI description;

		// Token: 0x0400172D RID: 5933
		public float minimalHeight;

		// Token: 0x0400172E RID: 5934
		public float minimalContentHeight;

		// Token: 0x0400172F RID: 5935
		private Visor _visor;

		// Token: 0x04001730 RID: 5936
		private float _height;
	}
}
