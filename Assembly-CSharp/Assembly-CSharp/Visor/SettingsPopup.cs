using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using System.Globalization;
using PlasmaAPI.GameClass.TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x020002AC RID: 684
	public class SettingsPopup : MonoBehaviour, IGenericWindow
	{
		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001ADB RID: 6875 RVA: 0x00087736 File Offset: 0x00085936
		public string title
		{
			get
			{
				return "SETTINGS";
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001ADC RID: 6876 RVA: 0x0008773D File Offset: 0x0008593D
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(1500f, 1840f);
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001ADD RID: 6877 RVA: 0x0008774E File Offset: 0x0008594E
		// (set) Token: 0x06001ADE RID: 6878 RVA: 0x00087756 File Offset: 0x00085956
		public bool canClose { get; private set; }

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x0008775F File Offset: 0x0008595F
		// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x00087767 File Offset: 0x00085967
		public object payload { get; private set; }

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001AE1 RID: 6881 RVA: 0x00087770 File Offset: 0x00085970
		// (set) Token: 0x06001AE2 RID: 6882 RVA: 0x00087778 File Offset: 0x00085978
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001AE3 RID: 6883 RVA: 0x00087781 File Offset: 0x00085981
		// (set) Token: 0x06001AE4 RID: 6884 RVA: 0x00087789 File Offset: 0x00085989
		public object closeEventPayload { get; private set; }

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x00087792 File Offset: 0x00085992
		// (set) Token: 0x06001AE6 RID: 6886 RVA: 0x0008779A File Offset: 0x0008599A
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x000877A3 File Offset: 0x000859A3
		public string exitKey
		{
			get
			{
				return "GW_Exit";
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x000877AA File Offset: 0x000859AA
		public bool redirect
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x000877AD File Offset: 0x000859AD
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x000877B0 File Offset: 0x000859B0
		public void Setup(object setupData)
		{

		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x000877D8 File Offset: 0x000859D8
		public void SetFOV(float value)
		{

		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00087813 File Offset: 0x00085A13
		public void SetMouseSensitivity(float value)
		{

		}

		// Token: 0x06001AED RID: 6893 RVA: 0x00087848 File Offset: 0x00085A48
		public void SetMasterVolume(float value)
		{

		}

		// Token: 0x06001AEE RID: 6894 RVA: 0x0008787F File Offset: 0x00085A7F
		public void SetVSync(bool value)
		{

		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0008788C File Offset: 0x00085A8C
		public void SetFullscreen(bool value)
		{

		}

		// Token: 0x06001AF0 RID: 6896 RVA: 0x00087894 File Offset: 0x00085A94
		public void SetHudHints(bool value)
		{

		}

		// Token: 0x06001AF1 RID: 6897 RVA: 0x000878A1 File Offset: 0x00085AA1
		public void SetInvertY(bool value)
		{

		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x000878B0 File Offset: 0x00085AB0
		public void TrySettingResolution(ResolutionItem item)
		{

		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x00087910 File Offset: 0x00085B10
		private void HandleResolutionResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001AF4 RID: 6900 RVA: 0x00087960 File Offset: 0x00085B60
		public void TrySettingDisplay(DisplayItem item)
		{

		}

		// Token: 0x06001AF5 RID: 6901 RVA: 0x000879C0 File Offset: 0x00085BC0
		private void HandleDisplayResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00087A18 File Offset: 0x00085C18
		public void SetQuality(QualityItem item)
		{

		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x00087A68 File Offset: 0x00085C68
		private void PopulateResolutions()
		{

		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x00087B0C File Offset: 0x00085D0C
		private void PopuplateDisplays()
		{

		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x00087B78 File Offset: 0x00085D78
		private void PopuplateQuality()
		{

		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00087C0C File Offset: 0x00085E0C
		public void OnReveal()
		{

		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x00087CC6 File Offset: 0x00085EC6
		public void OnFinishReveal()
		{
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00087CC8 File Offset: 0x00085EC8
		public void OnConceal()
		{

		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00087CD4 File Offset: 0x00085ED4
		public void Close()
		{

		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00087CEC File Offset: 0x00085EEC
		private static void SnapTo(Transform target, ScrollRect scrollRect, RectTransform content)
		{

		}

		// Token: 0x040015DC RID: 5596
		public RectTransform resolutionsContent;

		// Token: 0x040015DD RID: 5597
		public RectTransform qualityContent;

		// Token: 0x040015DE RID: 5598
		public RectTransform displaysContent;

		// Token: 0x040015DF RID: 5599
		public ScrollRect resolutionsScrollRect;

		// Token: 0x040015E0 RID: 5600
		public ScrollRect qualityScrollRect;

		// Token: 0x040015E1 RID: 5601
		public BetterToggle vSyncToggle;

		// Token: 0x040015E2 RID: 5602
		public BetterToggle fullscreenToggle;

		// Token: 0x040015E3 RID: 5603
		public TextMeshProUGUI fovValue;

		// Token: 0x040015E4 RID: 5604
		public TextMeshProUGUI mouseValue;

		// Token: 0x040015E5 RID: 5605
		public TextMeshProUGUI masterVolumeValue;

		// Token: 0x040015E6 RID: 5606
		public BetterSlider fovSlider;

		// Token: 0x040015E7 RID: 5607
		public BetterSlider mouseSlider;

		// Token: 0x040015E8 RID: 5608
		public BetterSlider masterVolumeSlider;

		// Token: 0x040015E9 RID: 5609
		public BetterToggle invertY;

		// Token: 0x040015EA RID: 5610
		public BetterToggle hudHintsToggle;

		// Token: 0x040015EB RID: 5611
		public GameObject resolutionItemPrefab;

		// Token: 0x040015EC RID: 5612
		public GameObject qualityItemPrefab;

		// Token: 0x040015ED RID: 5613
		public GameObject displayItemPrefab;

		// Token: 0x040015EE RID: 5614
		private Visor _visor;

		// Token: 0x040015EF RID: 5615
		private ResolutionItem _currentResolution;

		// Token: 0x040015F0 RID: 5616
		private ResolutionItem _candidateResolution;

		// Token: 0x040015F1 RID: 5617
		private DisplayItem _currentDisplay;

		// Token: 0x040015F2 RID: 5618
		private DisplayItem _candidateDisplay;

		// Token: 0x040015F3 RID: 5619
		private QualityItem _currentQuality;
	}
}
