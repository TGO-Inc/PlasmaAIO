using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x020002B2 RID: 690
	public class NewWorldPopup : MonoBehaviour, IGenericWindow
	{
		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x00089758 File Offset: 0x00087958
		public string title
		{
			get
			{
				return "CREATE NEW WORLD";
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x0008975F File Offset: 0x0008795F
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(1500f, 1500f);
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x00089770 File Offset: 0x00087970
		// (set) Token: 0x06001B92 RID: 7058 RVA: 0x00089778 File Offset: 0x00087978
		public bool canClose { get; private set; }

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x00089781 File Offset: 0x00087981
		// (set) Token: 0x06001B94 RID: 7060 RVA: 0x00089789 File Offset: 0x00087989
		public object payload { get; private set; }

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001B95 RID: 7061 RVA: 0x00089792 File Offset: 0x00087992
		// (set) Token: 0x06001B96 RID: 7062 RVA: 0x0008979A File Offset: 0x0008799A
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x000897A3 File Offset: 0x000879A3
		// (set) Token: 0x06001B98 RID: 7064 RVA: 0x000897AB File Offset: 0x000879AB
		public object closeEventPayload { get; private set; }

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x000897B4 File Offset: 0x000879B4
		// (set) Token: 0x06001B9A RID: 7066 RVA: 0x000897BC File Offset: 0x000879BC
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x000897C5 File Offset: 0x000879C5
		public string exitKey
		{
			get
			{
				return "GW_Exit";
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x000897CC File Offset: 0x000879CC
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x000897CF File Offset: 0x000879CF
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x000897D4 File Offset: 0x000879D4
		public void Setup(object setupData)
		{

		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x00089918 File Offset: 0x00087B18
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00089935 File Offset: 0x00087B35
		private void HandleEndEdit(string text)
		{

		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x00089943 File Offset: 0x00087B43
		private void HandleChange(string text)
		{

		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x00089961 File Offset: 0x00087B61
		public void NextBiome()
		{

		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0008999C File Offset: 0x00087B9C
		public void PreviousBiome()
		{

		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x000899F0 File Offset: 0x00087BF0
		public void OnReveal()
		{

		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x000899F9 File Offset: 0x00087BF9
		public void OnFinishReveal()
		{
		}

		// Token: 0x06001BA6 RID: 7078 RVA: 0x000899FB File Offset: 0x00087BFB
		public void OnConceal()
		{
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x00089A00 File Offset: 0x00087C00
		private void RefreshPreview()
		{

		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00089AC1 File Offset: 0x00087CC1
		private bool IsDemoBiome()
		{

            return default;
        }

		// Token: 0x06001BA9 RID: 7081 RVA: 0x00089AD0 File Offset: 0x00087CD0
		public void CreateNewWorld()
		{

		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00089B65 File Offset: 0x00087D65
		private void HandleInvalidResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x00089B6E File Offset: 0x00087D6E
		public void Close()
		{

		}

		// Token: 0x04001675 RID: 5749
		public TMP_InputField worldName;

		// Token: 0x04001676 RID: 5750
		public RawImage preview;

		// Token: 0x04001677 RID: 5751
		public Button createButton;

		// Token: 0x04001678 RID: 5752
		public TextMeshProUGUI typeValue;

		// Token: 0x04001679 RID: 5753
		public TextMeshProUGUI sizeValue;

		// Token: 0x0400167A RID: 5754
		public TextMeshProUGUI gravityValue;

		// Token: 0x0400167B RID: 5755
		public TextMeshProUGUI descriptionValue;

		// Token: 0x0400167C RID: 5756
		private Visor _visor;

		// Token: 0x0400167D RID: 5757
		private BiomeGestaltEnum _biomeId;

		// Token: 0x0400167E RID: 5758
		private List<BiomeGestaltEnum> _availbleBiomeIds;

		// Token: 0x0400167F RID: 5759
		private int _biomeIndex;
	}
}
