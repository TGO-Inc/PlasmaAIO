using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Behavior;
using DG.Tweening;
using DG.Tweening.Timeline;
using FMODUnity;
using NodeCanvas.StateMachines;
using Rewired;
using Sirenix.OdinInspector;
using PlasmaAPI.GameClass.TheraBytes.BetterUi;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x02000263 RID: 611
	public class ProcessorUI : SerializedMonoBehaviour, IEscapeHandler
	{
		// Token: 0x1400001F RID: 31
		// (add) Token: 0x060016BE RID: 5822 RVA: 0x00071C88 File Offset: 0x0006FE88
		// (remove) Token: 0x060016BF RID: 5823 RVA: 0x00071CBC File Offset: 0x0006FEBC
		public static event ProcessorUI.ProcessorUIEvent OnClose;

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x00071CEF File Offset: 0x0006FEEF
		// (set) Token: 0x060016C1 RID: 5825 RVA: 0x00071CF7 File Offset: 0x0006FEF7
		public Device device { get; private set; }

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x060016C2 RID: 5826 RVA: 0x00071D00 File Offset: 0x0006FF00
		// (set) Token: 0x060016C3 RID: 5827 RVA: 0x00071D08 File Offset: 0x0006FF08
		public ProcessorAgent processor { get; private set; }

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060016C4 RID: 5828 RVA: 0x00071D11 File Offset: 0x0006FF11
		public Sketch sketch
		{
			get
			{
				return this._sketch;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x00071D19 File Offset: 0x0006FF19
		public SketchView sketchView
		{
			get
			{
				return this._sketchView;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x00071D24 File Offset: 0x0006FF24
		public float viewportRelativeWidth
		{
			get
			{
				Vector3[] array = new Vector3[4];
				this.panel.GetWorldCorners(array);
				return Controllers.visorUIController.visor.uiCamera.WorldToViewportPoint(array[2]).x;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060016C7 RID: 5831 RVA: 0x00071D64 File Offset: 0x0006FF64
		public bool isLibraryShown
		{
			get
			{
				return this._isShown;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x00071D6C File Offset: 0x0006FF6C
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x00071D74 File Offset: 0x0006FF74
		public bool shouldToggleLibrary { get; set; }

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x00071D7D File Offset: 0x0006FF7D
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x00071D85 File Offset: 0x0006FF85
		public bool lockedLibrary { get; set; }

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x00071D8E File Offset: 0x0006FF8E
		public bool isReady
		{
			get
			{
				return this._isReady;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x00071D96 File Offset: 0x0006FF96
		// (set) Token: 0x060016CE RID: 5838 RVA: 0x00071D9E File Offset: 0x0006FF9E
		public bool shouldShowLibraryPopup { get; set; }

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x00071DA7 File Offset: 0x0006FFA7
		// (set) Token: 0x060016D0 RID: 5840 RVA: 0x00071DAF File Offset: 0x0006FFAF
		public bool shouldAutoConnectNewNode { get; set; }

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x00071DB8 File Offset: 0x0006FFB8
		// (set) Token: 0x060016D2 RID: 5842 RVA: 0x00071DC0 File Offset: 0x0006FFC0
		public bool shouldHideLibraryPopup { get; set; }

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x00071DC9 File Offset: 0x0006FFC9
		// (set) Token: 0x060016D4 RID: 5844 RVA: 0x00071DD1 File Offset: 0x0006FFD1
		public bool shouldHideVariableManager { get; set; }

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x00071DDA File Offset: 0x0006FFDA
		// (set) Token: 0x060016D6 RID: 5846 RVA: 0x00071DE2 File Offset: 0x0006FFE2
		public bool shouldHideInterfaceManager { get; set; }

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060016D7 RID: 5847 RVA: 0x00071DEB File Offset: 0x0006FFEB
		// (set) Token: 0x060016D8 RID: 5848 RVA: 0x00071DF3 File Offset: 0x0006FFF3
		public AgentId nodeToSpawn { get; set; }

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x00071DFC File Offset: 0x0006FFFC
		// (set) Token: 0x060016DA RID: 5850 RVA: 0x00071E04 File Offset: 0x00070004
		public bool canEdit { get; private set; }

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x00071E0D File Offset: 0x0007000D
		public bool isAnyWindowShown
		{
			get
			{
				return this.primaryBlocker.gameObject.activeSelf;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x00071E1F File Offset: 0x0007001F
		// (set) Token: 0x060016DD RID: 5853 RVA: 0x00071E27 File Offset: 0x00070027
		public bool sketchDemoMode { get; private set; }

		// Token: 0x060016DE RID: 5854 RVA: 0x00071E30 File Offset: 0x00070030
		private void Awake()
		{

		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00071E8C File Offset: 0x0007008C
		public void Setup(Device theDevice, ProcessorAgent theProcessor)
		{

		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x000723AC File Offset: 0x000705AC
		public void OnEscapePressed()
		{

		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x000723C4 File Offset: 0x000705C4
		private void HandleOnSketchNotification(SketchNotifications.Notification notification)
		{

		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x000723CC File Offset: 0x000705CC
		private void UpdateCounters()
		{

		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00072438 File Offset: 0x00070638
		public Vector2 FromSketchViewToUI(Vector2 position)
		{

            return default;
        }

		// Token: 0x060016E4 RID: 5860 RVA: 0x000724C4 File Offset: 0x000706C4
		public Vector2 FromScreenToUI(Vector2 position)
		{

            return default;
        }

		// Token: 0x060016E5 RID: 5861 RVA: 0x0007250E File Offset: 0x0007070E
		private void HandleChange(string text)
		{

		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00072518 File Offset: 0x00070718
		private void HandleSubmit(string text)
		{

		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x0007257C File Offset: 0x0007077C
		private void Populate()
		{

		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00072630 File Offset: 0x00070830
		public void UpdateLibraryItemVisuals(AgentId agentId, bool showMultiIcon)
		{

		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x000726B0 File Offset: 0x000708B0
		public void StartDraggingItem(GameObject item)
		{

		}

		// Token: 0x060016EA RID: 5866 RVA: 0x000726BC File Offset: 0x000708BC
		public void EnableBlocker(bool dark, ProcessorUIBlocker.BlockerClicked callback = null)
		{

		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00072718 File Offset: 0x00070918
		public void DisableBlocker()
		{

		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00072756 File Offset: 0x00070956
		public void EditAgentProperty(Agent agent, int propertyIndex, bool forVariables = false)
		{

		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00072780 File Offset: 0x00070980
		public void ApplyData()
		{

		}

		// Token: 0x060016EE RID: 5870 RVA: 0x000728DC File Offset: 0x00070ADC
		public void ToggleBooleanData(Agent agent, int propertyIndex, SketchViewNodeRow sketchViewNodeRow)
		{

		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00072961 File Offset: 0x00070B61
		public void CloseEditor()
		{

		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00072984 File Offset: 0x00070B84
		public void EditAgentPropertyDataType(Agent agent, int propertyIndex, bool forVariables = false)
		{

		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00072A10 File Offset: 0x00070C10
		private void ConfigureTypeSelector(bool showVariable, Data.Types typeToShow, bool forInterface)
		{

		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00072B10 File Offset: 0x00070D10
		public void OnTypeSelectionChanged(Data.Types type, bool usesVariable)
		{

		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00072B68 File Offset: 0x00070D68
		public void ApplyDataType()
		{

		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00072CBE File Offset: 0x00070EBE
		public void CloseTypeSelector()
		{

		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00072CE8 File Offset: 0x00070EE8
		public void ShowPortTypeSelector()
		{

		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x00072D1D File Offset: 0x00070F1D
		public void OnPortTypeSelectionChanged(AgentGestalt.Port.Types type)
		{

		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x00072D28 File Offset: 0x00070F28
		public void ClosePortTypeSelector(bool create)
		{

		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00072D98 File Offset: 0x00070F98
		public void ShowPortDataTypeSelector(int portId, string portName, Data.Types portType)
		{

		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00072E34 File Offset: 0x00071034
		public void ClosePortDataTypeSelector(bool apply)
		{

		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00072E82 File Offset: 0x00071082
		public void ShowPortDescription(AgentGestalt.Port port)
		{

		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00072EB1 File Offset: 0x000710B1
		public void ClosePortDescription()
		{

		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00072ED8 File Offset: 0x000710D8
		public void ResetPropertyType(SketchNode sketchNode, int propertyId)
		{

		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00072F7F File Offset: 0x0007117F
		public void CreateLabel()
		{

		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00072F8E File Offset: 0x0007118E
		public void EditLabelSettings(SketchViewLabel sketchViewLabel)
		{

		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00072F97 File Offset: 0x00071197
		public void CloseLabelSettings()
		{

		}

		// Token: 0x06001700 RID: 5888 RVA: 0x00072FA0 File Offset: 0x000711A0
		public void OpenVariableManager()
		{

		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00072FA9 File Offset: 0x000711A9
		public void OpenInterfaceManager()
		{

		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00072FB2 File Offset: 0x000711B2
		public void ToggleMinimap()
		{

		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00072FC0 File Offset: 0x000711C0
		public void PreOpen()
		{

		}

		// Token: 0x06001704 RID: 5892 RVA: 0x0007304F File Offset: 0x0007124F
		public void PostOpen()
		{

		}

		// Token: 0x06001705 RID: 5893 RVA: 0x0007305F File Offset: 0x0007125F
		public void ShowLoadingCircle()
		{

		}

		// Token: 0x06001706 RID: 5894 RVA: 0x00073070 File Offset: 0x00071270
		public void OnSketchViewReady()
		{

		}

		// Token: 0x06001707 RID: 5895 RVA: 0x000732A8 File Offset: 0x000714A8
		public Sequence GetOpenSequence()
		{

            return default;
        }

		// Token: 0x06001708 RID: 5896 RVA: 0x000732F8 File Offset: 0x000714F8
		public void PreClose()
		{

		}

		// Token: 0x06001709 RID: 5897 RVA: 0x000733A0 File Offset: 0x000715A0
		public Sequence GetCloseSequence()
		{

            return default;
        }

		// Token: 0x0600170A RID: 5898 RVA: 0x000733CA File Offset: 0x000715CA
		public void Close()
		{

		}

		// Token: 0x0600170B RID: 5899 RVA: 0x000733F4 File Offset: 0x000715F4
		private bool CanClose()
		{

            return default;
        }

		// Token: 0x0600170C RID: 5900 RVA: 0x00073441 File Offset: 0x00071641
		public IEnumerator RunIdle()
		{

            return default;
        }

		// Token: 0x0600170D RID: 5901 RVA: 0x00073450 File Offset: 0x00071650
		public IEnumerator RunDragItem()
		{

            return default;
        }

		// Token: 0x0600170E RID: 5902 RVA: 0x0007345F File Offset: 0x0007165F
		public void ExitDragItem()
		{

		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00073467 File Offset: 0x00071667
		public bool ShouldEnterDragItem()
		{

            return default;
        }

		// Token: 0x06001710 RID: 5904 RVA: 0x00073475 File Offset: 0x00071675
		public bool ShouldCancelDragItem()
		{

            return default;
        }

		// Token: 0x06001711 RID: 5905 RVA: 0x00073487 File Offset: 0x00071687
		public void CancelDragItem()
		{

		}

		// Token: 0x06001712 RID: 5906 RVA: 0x000734B4 File Offset: 0x000716B4
		public void CreateNode()
		{

		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00073513 File Offset: 0x00071713
		public bool ShouldCreateNode()
		{

            return default;
        }

		// Token: 0x06001714 RID: 5908 RVA: 0x0007353C File Offset: 0x0007173C
		public void ShowNodeLibrary()
		{

		}

		// Token: 0x06001715 RID: 5909 RVA: 0x00073594 File Offset: 0x00071794
		public void ExitShowNodeLibrary()
		{

		}

		// Token: 0x06001716 RID: 5910 RVA: 0x0007361E File Offset: 0x0007181E
		public bool ShouldShowNodeLibrary()
		{

            return default;
        }

		// Token: 0x06001717 RID: 5911 RVA: 0x0007364D File Offset: 0x0007184D
		public bool ShouldExitShowNodeLibrary()
		{

            return default;
        }

		// Token: 0x06001718 RID: 5912 RVA: 0x00073665 File Offset: 0x00071865
		public void ShowVariableManager()
		{

		}

		// Token: 0x06001719 RID: 5913 RVA: 0x000736A5 File Offset: 0x000718A5
		public void ExitShowVariableManager()
		{

		}

		// Token: 0x0600171A RID: 5914 RVA: 0x000736CC File Offset: 0x000718CC
		public bool ShouldShowVariableManager()
		{

            return default;
        }

		// Token: 0x0600171B RID: 5915 RVA: 0x000736D4 File Offset: 0x000718D4
		public bool ShouldExitShowVariableManager()
		{

            return default;
        }

		// Token: 0x0600171C RID: 5916 RVA: 0x000736DC File Offset: 0x000718DC
		public void ShowInterfaceManager()
		{

		}

		// Token: 0x0600171D RID: 5917 RVA: 0x0007371C File Offset: 0x0007191C
		public void ExitShowInterfaceManager()
		{

		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00073743 File Offset: 0x00071943
		public bool ShouldShowInterfaceManager()
		{

            return default;
        }

		// Token: 0x0600171F RID: 5919 RVA: 0x0007374B File Offset: 0x0007194B
		public bool ShouldExitShowInterfaceManager()
		{

            return default;
        }

		// Token: 0x06001720 RID: 5920 RVA: 0x00073754 File Offset: 0x00071954
		public void ShowEditor()
		{

		}

		// Token: 0x06001721 RID: 5921 RVA: 0x000738B3 File Offset: 0x00071AB3
		public void ExitShowEditor()
		{

		}

		// Token: 0x06001722 RID: 5922 RVA: 0x000738EA File Offset: 0x00071AEA
		public bool ShouldShowEditor()
		{

            return default;
        }

		// Token: 0x06001723 RID: 5923 RVA: 0x000738F5 File Offset: 0x00071AF5
		public bool ShouldExitShowEditor()
		{

            return default;
        }

		// Token: 0x06001724 RID: 5924 RVA: 0x00073900 File Offset: 0x00071B00
		public void ShowDataTypeSelector()
		{

		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00073A4F File Offset: 0x00071C4F
		public void ExitShowDataTypeSelector()
		{

		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00073A86 File Offset: 0x00071C86
		public bool ShouldShowDataTypeSelector()
		{

            return default;
        }

		// Token: 0x06001727 RID: 5927 RVA: 0x00073A91 File Offset: 0x00071C91
		public bool ShouldExitShowDataTypeSelector()
		{

            return default;
        }

		// Token: 0x06001728 RID: 5928 RVA: 0x00073A9C File Offset: 0x00071C9C
		public bool ShouldSwitchToEditor()
		{

            return default;
        }

		// Token: 0x06001729 RID: 5929 RVA: 0x00073AA7 File Offset: 0x00071CA7
		public void ShowLabelSettings()
		{

		}

		// Token: 0x0600172A RID: 5930 RVA: 0x00073AE5 File Offset: 0x00071CE5
		public void ExitShowLabelSettings()
		{

		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00073B17 File Offset: 0x00071D17
		public bool ShouldShowLabelSettings()
		{

            return default;
        }

		// Token: 0x0600172C RID: 5932 RVA: 0x00073B25 File Offset: 0x00071D25
		public bool ShouldExitShowLabelSettings()
		{

            return default;
        }

		// Token: 0x0600172D RID: 5933 RVA: 0x00073B33 File Offset: 0x00071D33
		public IEnumerator EnterToggleLibrary()
		{

            return default;
        }

		// Token: 0x0600172E RID: 5934 RVA: 0x00073B42 File Offset: 0x00071D42
		public void ExitToggleLibrary()
		{

		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00073B5A File Offset: 0x00071D5A
		public bool ShouldToggleLibrary()
		{

            return default;
        }

		// Token: 0x06001730 RID: 5936 RVA: 0x00073B90 File Offset: 0x00071D90
		public IEnumerator EnterZoomView()
		{

            return default;
        }

		// Token: 0x06001731 RID: 5937 RVA: 0x00073B9F File Offset: 0x00071D9F
		public void ExitZoomView()
		{

		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00073BA8 File Offset: 0x00071DA8
		public bool ShouldZoomView()
		{

            return default;
        }

		// Token: 0x06001733 RID: 5939 RVA: 0x00073BDC File Offset: 0x00071DDC
		public void UpdateNodeInfo()
		{

		}

		// Token: 0x0400128B RID: 4747
		public GameObject itemPrefab;

		// Token: 0x0400128C RID: 4748
		public GameObject separatorPrefab;

		// Token: 0x0400128D RID: 4749
		public RectTransform panel;

		// Token: 0x0400128E RID: 4750
		public Transform libraryContent;

		// Token: 0x0400128F RID: 4751
		public Transform ghosts;

		// Token: 0x04001290 RID: 4752
		public TooltipManager tooltipManager;

		// Token: 0x04001291 RID: 4753
		public TMP_InputField searchField;

		// Token: 0x04001292 RID: 4754
		public UIColorMapperController primaryBlocker;

		// Token: 0x04001293 RID: 4755
		public UIColorMapperController secondaryBlocker;

		// Token: 0x04001294 RID: 4756
		public Image editorIcon;

		// Token: 0x04001295 RID: 4757
		public TextMeshProUGUI editorTitle;

		// Token: 0x04001296 RID: 4758
		public GameObject editorContainer;

		// Token: 0x04001297 RID: 4759
		public RectTransform typeSelector;

		// Token: 0x04001298 RID: 4760
		public TextMeshProUGUI typeSelectorTitle;

		// Token: 0x04001299 RID: 4761
		public Transform typeSelectorContent;

		// Token: 0x0400129A RID: 4762
		public Button typeSelectorApplyButton;

		// Token: 0x0400129B RID: 4763
		public RectTransform[] typeSelectorTypeObjects;

		// Token: 0x0400129C RID: 4764
		public GameObject[] typeSelectorVariableObjects;

		// Token: 0x0400129D RID: 4765
		public GameObject portTypeSelector;

		// Token: 0x0400129E RID: 4766
		public ProcessorUILabelSettings labelSettings;

		// Token: 0x0400129F RID: 4767
		public ProcessorUIInterfacePortDescription portDescription;

		// Token: 0x040012A0 RID: 4768
		public TextMeshProUGUI nodeCountLabel;

		// Token: 0x040012A1 RID: 4769
		public TextMeshProUGUI logCountLabel;

		// Token: 0x040012A2 RID: 4770
		public TextMeshProUGUI warningCountLabel;

		// Token: 0x040012A3 RID: 4771
		public TextMeshProUGUI errorCountLabel;

		// Token: 0x040012A4 RID: 4772
		public ProcessorUIMinimap minimap;

		// Token: 0x040012A5 RID: 4773
		public ProcessorUINodeLibrary nodeLibrary;

		// Token: 0x040012A6 RID: 4774
		public ProcessorUIVariableEditor variableEditor;

		// Token: 0x040012A7 RID: 4775
		public ProcessorUIVariableManager variableManager;

		// Token: 0x040012A8 RID: 4776
		public ProcessorUIInterfaceManager interfaceManager;

		// Token: 0x040012A9 RID: 4777
		public BetterButton variableEditorButton;

		// Token: 0x040012AA RID: 4778
		public BetterButton labelButton;

		// Token: 0x040012AB RID: 4779
		public BetterButton consoleButton;

		// Token: 0x040012AC RID: 4780
		public GameObject loadingCircle;

		// Token: 0x040012AD RID: 4781
		public GameObject closeButton;

		// Token: 0x040012AE RID: 4782
		[EventRef]
		public string snapshot;

		// Token: 0x040012AF RID: 4783
		public Dictionary<Data.Types, DataEditor> editors;

		// Token: 0x040012B0 RID: 4784
		public float typeSelectorFullHeight;

		// Token: 0x040012B1 RID: 4785
		public float typeSelectorShortHeight;

		// Token: 0x040012B2 RID: 4786
		public float typeSelectorMiniHeight;

		// Token: 0x040012B3 RID: 4787
		public DOVisualSequence openSequence;

		// Token: 0x040012B4 RID: 4788
		public DOVisualSequence closeSequence;

		// Token: 0x040012B5 RID: 4789
		public DOVisualSequence showSequence;

		// Token: 0x040012B6 RID: 4790
		public DOVisualSequence hideSequence;

		// Token: 0x040012B7 RID: 4791
		public DOVisualSequence demoOpenSequence;

		// Token: 0x040012B8 RID: 4792
		public string introTitle;

		// Token: 0x040012B9 RID: 4793
		[Multiline]
		public string introduction;

		// Token: 0x040012BA RID: 4794
		public int introWidth;

		// Token: 0x040012BB RID: 4795
		public int introHeight;

		// Token: 0x040012BC RID: 4796
		public Vector2 introPosition;

		// Token: 0x040012BD RID: 4797
		public int introductionImpressions;

		// Token: 0x040012BE RID: 4798
		public string tickerLabelTitle;

		// Token: 0x040012BF RID: 4799
		[Multiline]
		public string tickerLabelText;

		// Token: 0x040012C0 RID: 4800
		public int tickerLabelWidth;

		// Token: 0x040012C1 RID: 4801
		public int tickerLabelHeight;

		// Token: 0x040012C2 RID: 4802
		public Vector2 tickerLabelPosition;

		// Token: 0x040012C3 RID: 4803
		public Vector2 tickerNodePosition;

		// Token: 0x040012C4 RID: 4804
		public Vector2 tickerNodeAlonePosition;

		// Token: 0x040012C5 RID: 4805
		private Player _input;

		// Token: 0x040012C6 RID: 4806
		private Sketch _sketch;

		// Token: 0x040012C7 RID: 4807
		private SketchView _sketchView;

		// Token: 0x040012C8 RID: 4808
		private bool _canClose;

		// Token: 0x040012C9 RID: 4809
		private bool _escapeKeyConsumed;

		// Token: 0x040012CA RID: 4810
		private Dictionary<AgentId, GameObject> _items;

		// Token: 0x040012CB RID: 4811
		private FSMOwner _stateMachine;

		// Token: 0x040012CC RID: 4812
		private GameObject _itemToDrag;

		// Token: 0x040012CD RID: 4813
		private GameObject _ghost;

		// Token: 0x040012CE RID: 4814
		private Agent _agentToEdit;

		// Token: 0x040012CF RID: 4815
		private Agent _agentDataTypeToEdit;

		// Token: 0x040012D0 RID: 4816
		private int _agentPropertyIdToEdit;

		// Token: 0x040012D1 RID: 4817
		private DataEditor _currentEditor;

		// Token: 0x040012D2 RID: 4818
		private Data.Types _cachedDataType;

		// Token: 0x040012D3 RID: 4819
		private bool _cachedUsesVariable;

		// Token: 0x040012D4 RID: 4820
		private SketchViewLabel _labelToEdit;

		// Token: 0x040012D5 RID: 4821
		private bool _isShown;

		// Token: 0x040012D6 RID: 4822
		private bool _isReady;

		// Token: 0x040012D7 RID: 4823
		private bool _useSecondaryBlocker;

		// Token: 0x040012D8 RID: 4824
		private bool _workingForVariables;

		// Token: 0x040012D9 RID: 4825
		private bool _shouldShowVariableManager;

		// Token: 0x040012DA RID: 4826
		private bool _shouldShowInterfaceManager;

		// Token: 0x040012DB RID: 4827
		private AgentGestalt.Port.Types _selectedPortType;

		// Token: 0x040012DC RID: 4828
		private int _interfacePortToEdit;

		// Token: 0x040012DD RID: 4829
		private Data.Types _selectedPortDataType;

		// Token: 0x040012DE RID: 4830
		private bool _typeSelectorForInterface;

		// Token: 0x040012DF RID: 4831
		private const float _typeSelectorFirstItemX = -12f;

		// Token: 0x040012E0 RID: 4832
		private const float _typeSelectorItemOffset = -80f;

		// Token: 0x0200046D RID: 1133
		// (Invoke) Token: 0x0600231A RID: 8986
		public delegate void ProcessorUIEvent();
	}
}
