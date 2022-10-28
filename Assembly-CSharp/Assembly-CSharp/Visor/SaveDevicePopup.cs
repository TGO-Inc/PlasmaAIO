using System;
using System.Globalization;
using TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Visor
{
	// Token: 0x0200023B RID: 571
	public class SaveDevicePopup : MonoBehaviour, IGenericWindow
	{
		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x00069394 File Offset: 0x00067594
		public string title
		{
			get
			{
				return "SAVE DEVICE";
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x0006939B File Offset: 0x0006759B
		public Vector2 requiredSize
		{
			get
			{
				return new Vector2(1860f, 1670f);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x000693AC File Offset: 0x000675AC
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x000693B4 File Offset: 0x000675B4
		public bool canClose { get; private set; }

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x000693BD File Offset: 0x000675BD
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x000693C5 File Offset: 0x000675C5
		public object payload { get; private set; }

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x000693CE File Offset: 0x000675CE
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x000693D6 File Offset: 0x000675D6
		public Visor.Events closeEvent { get; private set; }

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x000693DF File Offset: 0x000675DF
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x000693E7 File Offset: 0x000675E7
		public object closeEventPayload { get; private set; }

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x000693F0 File Offset: 0x000675F0
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x000693F8 File Offset: 0x000675F8
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x00069401 File Offset: 0x00067601
		public string exitKey
		{
			get
			{
				return "GW_Exit";
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060014A4 RID: 5284 RVA: 0x00069408 File Offset: 0x00067608
		public bool redirect
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x0006940B File Offset: 0x0006760B
		public bool useDefaultInputSystem
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00069410 File Offset: 0x00067610
		public void Setup(object setupData)
		{

		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00069572 File Offset: 0x00067772
		public void OnSaveAsModuleChanged(bool value)
		{

		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00069590 File Offset: 0x00067790
		public void OnReveal()
		{

		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00069633 File Offset: 0x00067833
		public void OnFinishReveal()
		{
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x00069635 File Offset: 0x00067835
		public void OnConceal()
		{
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x00069637 File Offset: 0x00067837
		public void Close()
		{

		}

		// Token: 0x060014AC RID: 5292 RVA: 0x0006964C File Offset: 0x0006784C
		public void Save()
		{

		}

		// Token: 0x060014AD RID: 5293 RVA: 0x00069738 File Offset: 0x00067938
		private void HandleOverwriteResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x040010B9 RID: 4281
		public TMP_InputField deviceNameField;

		// Token: 0x040010BA RID: 4282
		public TMP_InputField descriptionField;

		// Token: 0x040010BB RID: 4283
		public BetterToggle saveAsNewToggle;

		// Token: 0x040010BC RID: 4284
		public BetterToggle saveAsModule;

		// Token: 0x040010BD RID: 4285
		public GameObject moduleHint1;

		// Token: 0x040010BE RID: 4286
		public GameObject moduleHint2;

		// Token: 0x040010BF RID: 4287
		public TextMeshProUGUI numberOfComponents;

		// Token: 0x040010C0 RID: 4288
		public TextMeshProUGUI totalMass;

		// Token: 0x040010C1 RID: 4289
		public RawImage preview;

		// Token: 0x040010C2 RID: 4290
		private Visor _visor;

		// Token: 0x040010C3 RID: 4291
		private Device _device;

		// Token: 0x040010C4 RID: 4292
		private bool _conflictDetected;

		// Token: 0x040010C5 RID: 4293
		private int _serializedSaveCounter;
	}
}
