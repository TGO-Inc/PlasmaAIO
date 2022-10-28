using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using FMOD.Studio;
using FMODUnity;
using NodeCanvas.Framework;
using ParadoxNotion;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using CanvasGroup = UnityEngine.CanvasGroup;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x020002AE RID: 686
	public class Visor : MonoBehaviour
	{
		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001B00 RID: 6912 RVA: 0x00087D6E File Offset: 0x00085F6E
		// (set) Token: 0x06001B01 RID: 6913 RVA: 0x00087D76 File Offset: 0x00085F76
		public Visor.Events lastEvent { get; private set; }

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x00087D7F File Offset: 0x00085F7F
		// (set) Token: 0x06001B03 RID: 6915 RVA: 0x00087D87 File Offset: 0x00085F87
		public AgentGestalt.ComponentCategories lastComponentLibraryCategory { get; set; }

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001B04 RID: 6916 RVA: 0x00087D90 File Offset: 0x00085F90
		// (set) Token: 0x06001B05 RID: 6917 RVA: 0x00087D98 File Offset: 0x00085F98
		public float lastComponentLibraryPosition { get; set; }

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x00087DA1 File Offset: 0x00085FA1
		// (set) Token: 0x06001B07 RID: 6919 RVA: 0x00087DA9 File Offset: 0x00085FA9
		public bool canQuickbarSpawnComponents { get; private set; }

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x00087DB2 File Offset: 0x00085FB2
		public Color normalRadialBarColorValue
		{
			get
			{
				return Holder.instance.UIColorPalette[this.normalRadialBarColor].color;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x00087DCE File Offset: 0x00085FCE
		public Color warningRadialBarColorValue
		{
			get
			{
				return Holder.instance.UIColorPalette[this.warningRadialBarColor].color;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x00087DEA File Offset: 0x00085FEA
		public Color confirmRadialBarColorValue
		{
			get
			{
				return Holder.instance.UIColorPalette[this.confirmRadialBarColor].color;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x00087E06 File Offset: 0x00086006
		public Vector2 referenceResolution
		{
			get
			{
				return this._canvasScaler.referenceResolution;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001B0C RID: 6924 RVA: 0x00087E14 File Offset: 0x00086014
		public bool isUIShown
		{
			get
			{
				return (this.specialWindows.childCount > 0 && (this._processorUI == null || this._processorUI.isAnyWindowShown)) || this.genericWindows.childCount > 0 || this.popupCanvas.gameObject.activeSelf || this.dialogBoxCanvas.gameObject.activeSelf;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001B0D RID: 6925 RVA: 0x00087E7C File Offset: 0x0008607C
		// (set) Token: 0x06001B0E RID: 6926 RVA: 0x00087E84 File Offset: 0x00086084
		public bool closingGenericWindow { get; private set; }

		// Token: 0x06001B0F RID: 6927 RVA: 0x00087E90 File Offset: 0x00086090
		private IList<ValueDropdownItem<int>> ColorList()
		{

            return default;
        }

		// Token: 0x06001B10 RID: 6928 RVA: 0x00087F2C File Offset: 0x0008612C
		private void Awake()
		{

		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x00088110 File Offset: 0x00086310
		public void SetActiveElements(VisorElements elements)
		{

		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x000881D0 File Offset: 0x000863D0
		public void RefreshVisorElements()
		{

		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x000881EC File Offset: 0x000863EC
		public void SendSpawnComponentEvent(AgentGestaltEnum componentGestaltId)
		{

		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x00088214 File Offset: 0x00086414
		private void Blur()
		{

		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x00088244 File Offset: 0x00086444
		private void Unblur()
		{

		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x00088268 File Offset: 0x00086468
		private IEnumerator RunBlur(float endValue, float duration)
		{

            return default;
        }

		// Token: 0x06001B17 RID: 6935 RVA: 0x00088285 File Offset: 0x00086485
		public void ShowTutorialMessage(TutorialGestaltEnum id, string extraText = null)
		{

		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00088294 File Offset: 0x00086494
		public void OpenPropertyEditor(ComponentHandler targetComponent)
		{

		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0008831D File Offset: 0x0008651D
		public void ClosePropertyEditor()
		{

		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x00088326 File Offset: 0x00086526
		public void ClosePropertyEditorAndOpenImporter()
		{

		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x0008832F File Offset: 0x0008652F
		public void ClosePropertyEditorAndOpenDeviceEditor()
		{

		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x00088338 File Offset: 0x00086538
		public void ClosePropertyEditorAndOpenSaveDevice()
		{

		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x00088342 File Offset: 0x00086542
		public void ClosePropertyEditorAndSolidifyDevice()
		{

		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x0008834C File Offset: 0x0008654C
		private void ClosePropertyEditor(Visor.Events eventType)
		{

		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x000883B0 File Offset: 0x000865B0
		public bool CanOpenPropertyEditor()
		{

            return default;
        }

		// Token: 0x06001B20 RID: 6944 RVA: 0x000883BC File Offset: 0x000865BC
		public void OpenDeviceEditor(Device targetDevice)
		{

		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x00088445 File Offset: 0x00086645
		public void CloseDeviceEditor()
		{

		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0008844E File Offset: 0x0008664E
		public void CloseDeviceEditorAndOpenSaveDevice()
		{

		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x00088458 File Offset: 0x00086658
		private void CloseDeviceEditor(Visor.Events eventType)
		{

		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x000884BC File Offset: 0x000866BC
		public void OpenComponentLibrary()
		{

		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x00088531 File Offset: 0x00086731
		public void CloseComponentLibrary()
		{

		}

		// Token: 0x06001B26 RID: 6950 RVA: 0x0008853B File Offset: 0x0008673B
		public void CloseComponentLibraryAndSpawnComponent(AgentGestaltEnum componentGestaltId)
		{

		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x00088548 File Offset: 0x00086748
		private void CloseComponentLibrary(Visor.Events eventType, AgentGestaltEnum componentGestaltId)
		{

		}

		// Token: 0x06001B28 RID: 6952 RVA: 0x000885B3 File Offset: 0x000867B3
		public bool CanOpenComponentLibrary()
		{

            return default;
        }

		// Token: 0x06001B29 RID: 6953 RVA: 0x000885C0 File Offset: 0x000867C0
		public void OpenProcessorUI(Device targetDevice, ProcessorAgent targetProcessor)
		{

		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x00088618 File Offset: 0x00086818
		public void CloseProcessorUI()
		{

		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x00088624 File Offset: 0x00086824
		private void CloseProcessorUI(Visor.Events eventType)
		{

		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x00088688 File Offset: 0x00086888
		public bool CanOpenProcessorUI()
		{

            return default;
        }

		// Token: 0x06001B2D RID: 6957 RVA: 0x00088694 File Offset: 0x00086894
		public LoadingScreen OpenLoadingScreen(bool shouldFadeIn)
		{

            return default;
        }

		// Token: 0x06001B2E RID: 6958 RVA: 0x00088702 File Offset: 0x00086902
		public void CloseLoadingScreen()
		{

		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x00088728 File Offset: 0x00086928
		public void FadeInCurtain(float duration)
		{

		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x00088775 File Offset: 0x00086975
		public void FadeOutCurtain(float duration)
		{

		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0008879F File Offset: 0x0008699F
		public void OpenAssetOrganizer()
		{

		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x000887AE File Offset: 0x000869AE
		public void OpenDeviceBrowser()
		{

		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x000887BD File Offset: 0x000869BD
		public void OpenWorldBrowser()
		{

		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x000887CC File Offset: 0x000869CC
		public void OpenWorldSettings()
		{

		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x000887DE File Offset: 0x000869DE
		public void OpenWelcome()
		{

		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x000887F6 File Offset: 0x000869F6
		public void OpenNews()
		{

		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x0008880C File Offset: 0x00086A0C
		public void OpenPauseMenu()
		{

		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x00088864 File Offset: 0x00086A64
		public void ClosePauseMenu(Visor.Events closeEvent, ulong worldIdToRestart = 0UL)
		{

		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x00088906 File Offset: 0x00086B06
		public bool CanOpenPauseMenu()
		{

            return default;
        }

		// Token: 0x06001B3A RID: 6970 RVA: 0x00088920 File Offset: 0x00086B20
		public void OpenSettings()
		{

		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00088932 File Offset: 0x00086B32
		public void OpenSaveWorld()
		{

		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x00088944 File Offset: 0x00086B44
		public void OpenCreateNewWorld()
		{

		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00088956 File Offset: 0x00086B56
		public void OpenSaveDevice(Device device)
		{

		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00088968 File Offset: 0x00086B68
		public void OpenShareWorld()
		{

		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00088983 File Offset: 0x00086B83
		public void OpenEncyclopedia()
		{

		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0008899B File Offset: 0x00086B9B
		public void OpenBlockingTutorial(BlockingTutorialGestaltEnum tutorialId)
		{

		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x000889B8 File Offset: 0x00086BB8
		public void OpenFeedback()
		{

		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x000889C7 File Offset: 0x00086BC7
		private IEnumerator TakeScreenshotAndOpenFeedback()
		{

            return default;
        }

		// Token: 0x06001B43 RID: 6979 RVA: 0x000889D6 File Offset: 0x00086BD6
		public void OpenExceptionPopup()
		{

		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x000889E5 File Offset: 0x00086BE5
		private IEnumerator TakeScreenshotAndOpenException()
		{

            return default;
        }

		// Token: 0x06001B45 RID: 6981 RVA: 0x000889F4 File Offset: 0x00086BF4
		public bool CanOpenExceptionPopup()
		{

            return default;
        }

		// Token: 0x06001B46 RID: 6982 RVA: 0x00088A0C File Offset: 0x00086C0C
		private void OpenGenericWindow(GameObject innerPrefab, object setupData = null)
		{

		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00088A8C File Offset: 0x00086C8C
		public void CloseGenericWindow(bool redirect = false)
		{

		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00088B13 File Offset: 0x00086D13
		public bool CanOpenGenericWindow()
		{

            return default;
        }

		// Token: 0x06001B49 RID: 6985 RVA: 0x00088B20 File Offset: 0x00086D20
		public void OpenGenericPopup(GameObject popupContent, Visor.PopupHandler handler, object setupData = null, bool controlMouseVisibility = true, bool useDarkerBackground = false)
		{

		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x00088C14 File Offset: 0x00086E14
		public void CloseGenericPopup(object payload, bool redirect = false)
		{

		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x00088CCC File Offset: 0x00086ECC
		public bool CanOpenGenericPopup()
		{

            return default;
        }

		// Token: 0x06001B4C RID: 6988 RVA: 0x00088CD8 File Offset: 0x00086ED8
		public void OpenDialogBox(string title, string message, string cancelText, string okText, Visor.DialogBoxHandler handler, bool critical = false, bool showLoadingCircle = false, float timer = 0f)
		{

		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00088E14 File Offset: 0x00087014
		public void CloseDialogBox(Visor.DialogBoxResponses response)
		{

		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x00088ED9 File Offset: 0x000870D9
		public bool CanOpenDialogBox()
		{

            return default;
        }

		// Token: 0x06001B4F RID: 6991 RVA: 0x00088EE4 File Offset: 0x000870E4
		public bool IsDialogBoxOpen()
		{

            return default;
        }

		// Token: 0x06001B50 RID: 6992 RVA: 0x00088EF4 File Offset: 0x000870F4
		public void StartRadialProgressBar(float duration, Color color, string message, bool playSound)
		{

		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x00089090 File Offset: 0x00087290
		public void CancelRadialProgressBar()
		{

		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00089142 File Offset: 0x00087342
		public bool IsRadialProgressBarComplete()
		{

            return default;
        }

		// Token: 0x06001B53 RID: 6995 RVA: 0x0008914A File Offset: 0x0008734A
		public void SetCrosshairState(Crosshair.States state)
		{

		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x00089159 File Offset: 0x00087359
		public void ReleaseCrosshairState()
		{

		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x00089166 File Offset: 0x00087366
		public void ShowPogressBar(float total)
		{

		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x0008918C File Offset: 0x0008738C
		public void UpdateProgressBar(float value)
		{

		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x000891A9 File Offset: 0x000873A9
		public void HideProgressBar()
		{

		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x000891B7 File Offset: 0x000873B7
		public void ToggleVisibility()
		{

		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x000891EC File Offset: 0x000873EC
		public void EnterAdvancedHudEditMode()
		{

		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x000891F9 File Offset: 0x000873F9
		public void ExitAdvancedHudEditMode()
		{

		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x00089206 File Offset: 0x00087406
		public void OpenTutorialVideoPlayer(int index)
		{

		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x00089245 File Offset: 0x00087445
		public void CloseTutorialVideoPlayer()
		{

		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x00089252 File Offset: 0x00087452
		public void ShowVFSMessage(string message, Visor.VFSMessageTypes type)
		{

		}

		// Token: 0x04001601 RID: 5633
		public Crosshair crosshair;

		// Token: 0x04001602 RID: 5634
		public Image radialProgressBar;

		// Token: 0x04001603 RID: 5635
		public RectTransform radialMessageContainer;

		// Token: 0x04001604 RID: 5636
		public Hud hud;

		// Token: 0x04001605 RID: 5637
		public GameObject progressBar;

		// Token: 0x04001606 RID: 5638
		public RectTransform progressBarForeground;

		// Token: 0x04001607 RID: 5639
		public FunctionKeysPanel functionKeysPanel;

		// Token: 0x04001608 RID: 5640
		public StageTools stageTools;

		// Token: 0x04001609 RID: 5641
		public TutorialPanel tutorialPanel;

		// Token: 0x0400160A RID: 5642
		public PaletteSelector paletteSelector;

		// Token: 0x0400160B RID: 5643
		public TutorialVideoPlayer tutorialVideoPlayer;

		// Token: 0x0400160C RID: 5644
		public Canvas mainCanvas;

		// Token: 0x0400160D RID: 5645
		public Canvas popupCanvas;

		// Token: 0x0400160E RID: 5646
		public Canvas dialogBoxCanvas;

		// Token: 0x0400160F RID: 5647
		public Canvas exceptionCanvas;

		// Token: 0x04001610 RID: 5648
		public Canvas loadingScreenCanvas;

		// Token: 0x04001611 RID: 5649
		public Canvas curtainCanvas;

		// Token: 0x04001612 RID: 5650
		public RectTransform genericWindows;

		// Token: 0x04001613 RID: 5651
		public RectTransform specialWindows;

		// Token: 0x04001614 RID: 5652
		public Quickbar quickbar;

		// Token: 0x04001615 RID: 5653
		public VFSPanel vfsPanel;

		// Token: 0x04001616 RID: 5654
		public SketchView sketchView;

		// Token: 0x04001617 RID: 5655
		public Camera uiCamera;

		// Token: 0x04001618 RID: 5656
		public Transform displayContainers;

		// Token: 0x04001619 RID: 5657
		public GameObject stageBorder;

		// Token: 0x0400161A RID: 5658
		public PauseMenu pauseMenu;

		// Token: 0x0400161B RID: 5659
		[EventRef]
		public string radialSound;

		// Token: 0x0400161C RID: 5660
		public GameObject componentLibraryPrefab;

		// Token: 0x0400161D RID: 5661
		public GameObject propertyEditorPrefab;

		// Token: 0x0400161E RID: 5662
		public GameObject deviceEditorPrefab;

		// Token: 0x0400161F RID: 5663
		public GameObject processorUIPrefab;

		// Token: 0x04001620 RID: 5664
		public GameObject assetOrganizerPrefab;

		// Token: 0x04001621 RID: 5665
		public GameObject deviceBrowserPrefab;

		// Token: 0x04001622 RID: 5666
		public GameObject worldBrowserPrefab;

		// Token: 0x04001623 RID: 5667
		public GameObject worldSettingsPopupPrefab;

		// Token: 0x04001624 RID: 5668
		public GameObject saveWorldPopupPrefab;

		// Token: 0x04001625 RID: 5669
		public GameObject saveDevicePopupPrefab;

		// Token: 0x04001626 RID: 5670
		public GameObject createNewWorldPrefab;

		// Token: 0x04001627 RID: 5671
		public GameObject shareWorldPopupPrefab;

		// Token: 0x04001628 RID: 5672
		public GameObject newsPrefab;

		// Token: 0x04001629 RID: 5673
		public GameObject genericWindowPrefab;

		// Token: 0x0400162A RID: 5674
		public GameObject genericPopupPrefab;

		// Token: 0x0400162B RID: 5675
		public GameObject dialogBoxPrefab;

		// Token: 0x0400162C RID: 5676
		public GameObject loadingScreenPrefab;

		// Token: 0x0400162D RID: 5677
		public GameObject welcomePopupPrefab;

		// Token: 0x0400162E RID: 5678
		public GameObject feedbackPrefab;

		// Token: 0x0400162F RID: 5679
		public GameObject settingsPopupPrefab;

		// Token: 0x04001630 RID: 5680
		public GameObject encyclopediaPopupPrefab;

		// Token: 0x04001631 RID: 5681
		public GameObject blockingTutorialPopupPrefab;

		// Token: 0x04001632 RID: 5682
		public GameObject displayContainerPrefab;

		// Token: 0x04001633 RID: 5683
		public GameObject displayTextPrefab;

		// Token: 0x04001634 RID: 5684
		public GameObject displayButtonPrefab;

		// Token: 0x04001635 RID: 5685
		public GameObject displayImagePrefab;

		// Token: 0x04001636 RID: 5686
		[ColorEntity]
		public int normalRadialBarColor;

		// Token: 0x04001637 RID: 5687
		[ColorEntity]
		public int warningRadialBarColor;

		// Token: 0x04001638 RID: 5688
		[ColorEntity]
		public int confirmRadialBarColor;

		// Token: 0x04001639 RID: 5689
		private PropertyEditor _propertyEditor;

		// Token: 0x0400163A RID: 5690
		private DeviceEditor _deviceEditor;

		// Token: 0x0400163B RID: 5691
		private ComponentLibrary _componentLibrary;

		// Token: 0x0400163C RID: 5692
		private ProcessorUI _processorUI;

		// Token: 0x0400163D RID: 5693
		private GenericWindow _genericWindow;

		// Token: 0x0400163E RID: 5694
		private GenericPopup _genericPopup;

		// Token: 0x0400163F RID: 5695
		private DialogBox _dialogBox;

		// Token: 0x04001640 RID: 5696
		private ExceptionPopup _exceptionPopup;

		// Token: 0x04001641 RID: 5697
		private GraphicRaycaster _mainCanvasRaycaster;

		// Token: 0x04001642 RID: 5698
		private GraphicRaycaster _popupCanvasRaycaster;

		// Token: 0x04001643 RID: 5699
		private LoadingScreen _loadingScreen;

		// Token: 0x04001644 RID: 5700
		private Image _blurImage;

		// Token: 0x04001645 RID: 5701
		private bool _closingPropertyEditor;

		// Token: 0x04001646 RID: 5702
		private bool _closingComponentLibrary;

		// Token: 0x04001647 RID: 5703
		private bool _closingProcessorUI;

		// Token: 0x04001648 RID: 5704
		private bool _closingGenericPopup;

		// Token: 0x04001649 RID: 5705
		private bool _closingDialogBox;

		// Token: 0x0400164A RID: 5706
		private bool _mainCanvasOriginalState;

		// Token: 0x0400164B RID: 5707
		private bool _popupCanvasOriginalState;

		// Token: 0x0400164C RID: 5708
		private bool _popupControlsMouseVisibility;

		// Token: 0x0400164D RID: 5709
		private Visor.PopupHandler _popupHandler;

		// Token: 0x0400164E RID: 5710
		private Visor.DialogBoxHandler _dialogBoxHandler;

		// Token: 0x0400164F RID: 5711
		private Crosshair _crosshair;

		// Token: 0x04001650 RID: 5712
		private Sequence _radialBarSequence;

		// Token: 0x04001651 RID: 5713
		private bool _radialBarComplete;

		// Token: 0x04001652 RID: 5714
		private Dictionary<VisorElements, VisorElement> _visorElements;

		// Token: 0x04001653 RID: 5715
		private CanvasGroup _radialCanvasGroup;

		// Token: 0x04001654 RID: 5716
		private TextMeshProUGUI _radialMessage;

		// Token: 0x04001655 RID: 5717
		private CanvasScaler _canvasScaler;

		// Token: 0x04001656 RID: 5718
		private EventInstance _radialSoundInstance;

		// Token: 0x04001657 RID: 5719
		private float _progressBarWidth;

		// Token: 0x04001658 RID: 5720
		private float _progressBarTotal;

		// Token: 0x04001659 RID: 5721
		private VisorElements _currentVisorElements;

		// Token: 0x0400165A RID: 5722
		private const float _radialMessageMinWidth = 120f;

		// Token: 0x02000495 RID: 1173
		// (Invoke) Token: 0x060023CA RID: 9162
		public delegate void PopupHandler(object payload);

		// Token: 0x02000496 RID: 1174
		// (Invoke) Token: 0x060023CE RID: 9166
		public delegate void DialogBoxHandler(Visor.DialogBoxResponses response);

		// Token: 0x02000497 RID: 1175
		public enum Events
		{
			// Token: 0x04002016 RID: 8214
			None,
			// Token: 0x04002017 RID: 8215
			OnClose,
			// Token: 0x04002018 RID: 8216
			OnClosePopup,
			// Token: 0x04002019 RID: 8217
			CloseAndOpenImporter,
			// Token: 0x0400201A RID: 8218
			CloseAndOpenDeviceEditor,
			// Token: 0x0400201B RID: 8219
			SpawnComponent,
			// Token: 0x0400201C RID: 8220
			BuildDevice,
			// Token: 0x0400201D RID: 8221
			OnDeviceLoaded,
			// Token: 0x0400201E RID: 8222
			OnComponentCloned,
			// Token: 0x0400201F RID: 8223
			CloseAndOpenSaveDevice,
			// Token: 0x04002020 RID: 8224
			LoadWorld,
			// Token: 0x04002021 RID: 8225
			LoadWorkshopWorld,
			// Token: 0x04002022 RID: 8226
			LoadProgressWorld,
			// Token: 0x04002023 RID: 8227
			OnWorldLoaded,
			// Token: 0x04002024 RID: 8228
			CloseAndOpenSettings,
			// Token: 0x04002025 RID: 8229
			CloseAndOpenPauseMenu,
			// Token: 0x04002026 RID: 8230
			CloseAndOpenDeviceBrowser,
			// Token: 0x04002027 RID: 8231
			CloseAndOpenWorldBrowser,
			// Token: 0x04002028 RID: 8232
			CloseAndOpenImageManager,
			// Token: 0x04002029 RID: 8233
			CloseAndOpenWorldSettings,
			// Token: 0x0400202A RID: 8234
			CloseAndOpenSaveWorld,
			// Token: 0x0400202B RID: 8235
			CloseAndOpenCreateNewWorld,
			// Token: 0x0400202C RID: 8236
			CloseAndOpenShareWorld,
			// Token: 0x0400202D RID: 8237
			CloseAndRestartCurrentWorld,
			// Token: 0x0400202E RID: 8238
			CloseAndRestartTutorial,
			// Token: 0x0400202F RID: 8239
			CloseAndResumeTutorial,
			// Token: 0x04002030 RID: 8240
			CloseAndSolidifyDevice,
			// Token: 0x04002031 RID: 8241
			BuildWorkshopDevice,
			// Token: 0x04002032 RID: 8242
			ShowError,
			// Token: 0x04002033 RID: 8243
			OnTutorialLoadError
		}

		// Token: 0x02000498 RID: 1176
		public enum VFSMessageTypes
		{
			// Token: 0x04002035 RID: 8245
			Info,
			// Token: 0x04002036 RID: 8246
			Error
		}

		// Token: 0x02000499 RID: 1177
		public enum DialogBoxResponses
		{
			// Token: 0x04002038 RID: 8248
			Cancel,
			// Token: 0x04002039 RID: 8249
			Ok
		}
	}
}
