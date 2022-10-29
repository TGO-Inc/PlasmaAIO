using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Globalization;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using FMODUnity;
using Rewired;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000256 RID: 598
	public class PauseMenu : MonoBehaviour
	{
		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x0006F98F File Offset: 0x0006DB8F
		// (set) Token: 0x06001634 RID: 5684 RVA: 0x0006F997 File Offset: 0x0006DB97
		public bool canOpen { get; private set; }

		// Token: 0x06001635 RID: 5685 RVA: 0x0006F9A0 File Offset: 0x0006DBA0
		public void Setup()
		{

		}

		// Token: 0x06001636 RID: 5686 RVA: 0x0006FA20 File Offset: 0x0006DC20
		public void Show()
		{

		}

		// Token: 0x06001637 RID: 5687 RVA: 0x0006FF4D File Offset: 0x0006E14D
		private void HandleOnUserInformationRetrieved(ulong steamId, string userName)
		{

		}

		// Token: 0x06001638 RID: 5688 RVA: 0x0006FF74 File Offset: 0x0006E174
		public void Hide()
		{

		}

		// Token: 0x06001639 RID: 5689 RVA: 0x0006FFEF File Offset: 0x0006E1EF
		private void Update()
		{

		}

		// Token: 0x0600163A RID: 5690 RVA: 0x00070014 File Offset: 0x0006E214
		public void SaveWorldOrSaveProgress()
		{

		}

		// Token: 0x0600163B RID: 5691 RVA: 0x000700A4 File Offset: 0x0006E2A4
		private void HandleOverwriteSaveProgressResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x0600163C RID: 5692 RVA: 0x000700C4 File Offset: 0x0006E2C4
		private void SaveProgress()
		{

		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00070140 File Offset: 0x0006E340
		private void HandleSaveProgressResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00070158 File Offset: 0x0006E358
		public void Restart()
		{

		}

		// Token: 0x0600163F RID: 5695 RVA: 0x000701E8 File Offset: 0x0006E3E8
		private void HandleRestartResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001640 RID: 5696 RVA: 0x00070248 File Offset: 0x0006E448
		private static void PrepareForRestart()
		{

		}

		// Token: 0x06001641 RID: 5697 RVA: 0x000702D3 File Offset: 0x0006E4D3
		public void Resume()
		{

		}

		// Token: 0x06001642 RID: 5698 RVA: 0x000702E4 File Offset: 0x0006E4E4
		public void RestartTutorial()
		{

		}

		// Token: 0x06001643 RID: 5699 RVA: 0x0007036C File Offset: 0x0006E56C
		private void HandleRestartTutorialResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001644 RID: 5700 RVA: 0x000703C4 File Offset: 0x0006E5C4
		public void ResumeTutorial()
		{

		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00070422 File Offset: 0x0006E622
		private void HandleResumeTutorialResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00070449 File Offset: 0x0006E649
		private void ResumeTutorialInternal()
		{

		}

		// Token: 0x06001647 RID: 5703 RVA: 0x0007046C File Offset: 0x0006E66C
		public void LoadTutorial()
		{

		}

		// Token: 0x06001648 RID: 5704 RVA: 0x000704CA File Offset: 0x0006E6CA
		private void HandleLoadTutorialResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001649 RID: 5705 RVA: 0x000704F4 File Offset: 0x0006E6F4
		private void LoadOrRestartTutorial()
		{

		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00070545 File Offset: 0x0006E745
		public void OpenWorldBrowser()
		{

		}

		// Token: 0x0600164B RID: 5707 RVA: 0x00070556 File Offset: 0x0006E756
		public void OpenDeviceBrowser()
		{

		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00070567 File Offset: 0x0006E767
		public void OpenWorldSettings()
		{

		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00070578 File Offset: 0x0006E778
		public void OpenSettings()
		{

		}

		// Token: 0x0600164E RID: 5710 RVA: 0x00070589 File Offset: 0x0006E789
		public void OpenShareWorld()
		{

		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0007059A File Offset: 0x0006E79A
		public void OpenImageManager()
		{

		}

		// Token: 0x06001650 RID: 5712 RVA: 0x000705AC File Offset: 0x0006E7AC
		public void CloneWorld()
		{

		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00070630 File Offset: 0x0006E830
		private void HandleCloneResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00070690 File Offset: 0x0006E890
		private void HandleCloneDoneResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001653 RID: 5715 RVA: 0x000706A5 File Offset: 0x0006E8A5
		public void OpenDiscord()
		{

		}

		// Token: 0x06001654 RID: 5716 RVA: 0x000706B1 File Offset: 0x0006E8B1
		public void OpenTwitter()
		{

		}

		// Token: 0x06001655 RID: 5717 RVA: 0x000706BD File Offset: 0x0006E8BD
		public void OpenWishlist()
		{

		}

		// Token: 0x06001656 RID: 5718 RVA: 0x000706CC File Offset: 0x0006E8CC
		public void PublishHomeworld()
		{

		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00070758 File Offset: 0x0006E958
		private void HandleWorkshopUploadHomeworld(bool success, WorkshopController.WorkshopItemPublishResult result)
		{

		}

		// Token: 0x06001658 RID: 5720 RVA: 0x000707D9 File Offset: 0x0006E9D9
		private void HandleResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001659 RID: 5721 RVA: 0x000707F0 File Offset: 0x0006E9F0
		public void PublishTutorial()
		{

		}

		// Token: 0x0600165A RID: 5722 RVA: 0x0007087C File Offset: 0x0006EA7C
		private void HandleWorkshopUploadTutorial(bool success, WorkshopController.WorkshopItemPublishResult result)
		{

		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00070900 File Offset: 0x0006EB00
		public void Quit()
		{

		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00070978 File Offset: 0x0006EB78
		private void HandleWarningQuitResponse(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x040011F8 RID: 4600
		public TextMeshProUGUI version;

		// Token: 0x040011F9 RID: 4601
		public GameObject publishTutorialButton;

		// Token: 0x040011FA RID: 4602
		public GameObject publishHomeworldButton;

		// Token: 0x040011FB RID: 4603
		public GameObject resumeTutorialButton;

		// Token: 0x040011FC RID: 4604
		public GameObject restartTutorialButton;

		// Token: 0x040011FD RID: 4605
		public GameObject loadTutorialButton;

		// Token: 0x040011FE RID: 4606
		public Button deviceBrowserButton;

		// Token: 0x040011FF RID: 4607
		public RectTransform panel;

		// Token: 0x04001200 RID: 4608
		public GameObject myWorldArea;

		// Token: 0x04001201 RID: 4609
		public GameObject publishedArea;

		// Token: 0x04001202 RID: 4610
		public GameObject otherWorldArea;

		// Token: 0x04001203 RID: 4611
		public GameObject worldSettingsButton;

		// Token: 0x04001204 RID: 4612
		public GameObject saveButton;

		// Token: 0x04001205 RID: 4613
		public GameObject cloneButton;

		// Token: 0x04001206 RID: 4614
		public GameObject shareButton;

		// Token: 0x04001207 RID: 4615
		public GameObject updateButton;

		// Token: 0x04001208 RID: 4616
		public GameObject restartButton;

		// Token: 0x04001209 RID: 4617
		public TextMeshProUGUI sandboxTitle;

		// Token: 0x0400120A RID: 4618
		public TextMeshProUGUI stageTitle;

		// Token: 0x0400120B RID: 4619
		public TextMeshProUGUI createdOn;

		// Token: 0x0400120C RID: 4620
		public TextMeshProUGUI sandboxLastSave;

		// Token: 0x0400120D RID: 4621
		public TextMeshProUGUI sandboxBiome;

		// Token: 0x0400120E RID: 4622
		public TextMeshProUGUI sandboxDevices;

		// Token: 0x0400120F RID: 4623
		public TextMeshProUGUI isStage;

		// Token: 0x04001210 RID: 4624
		public TextMeshProUGUI publishedOn;

		// Token: 0x04001211 RID: 4625
		public TextMeshProUGUI lastUpdate;

		// Token: 0x04001212 RID: 4626
		public TextMeshProUGUI author;

		// Token: 0x04001213 RID: 4627
		public TextMeshProUGUI description;

		// Token: 0x04001214 RID: 4628
		[EventRef]
		public string openSound;

		// Token: 0x04001215 RID: 4629
		[EventRef]
		public string closeSound;

		// Token: 0x04001216 RID: 4630
		[EventRef]
		public string snapshot;

		// Token: 0x04001217 RID: 4631
		private Visor _visor;

		// Token: 0x04001218 RID: 4632
		private CanvasGroup _canvasGroup;

		// Token: 0x04001219 RID: 4633
		private GraphicRaycaster _raycaster;

		// Token: 0x0400121A RID: 4634
		private Player _input;

		// Token: 0x0400121B RID: 4635
		private bool _canClose;

		// Token: 0x0400121C RID: 4636
		private string _clonedWorldName;

		// Token: 0x0400121D RID: 4637
		private const float sandboxHeight = 590f;

		// Token: 0x0400121E RID: 4638
		private const float publishedHeight = 700f;

		// Token: 0x0400121F RID: 4639
		private const float someoneelseHeight = 800f;
	}
}
