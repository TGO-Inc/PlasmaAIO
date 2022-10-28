using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using Behavior;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x0200026A RID: 618
	public class ProcessorUIInterfaceManager : SerializedMonoBehaviour, IEscapeHandler
	{
		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x00074BBC File Offset: 0x00072DBC
		// (set) Token: 0x0600176D RID: 5997 RVA: 0x00074BC4 File Offset: 0x00072DC4
		public ProcessorUI processorUI { get; private set; }

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x00074BCD File Offset: 0x00072DCD
		// (set) Token: 0x0600176F RID: 5999 RVA: 0x00074BD5 File Offset: 0x00072DD5
		public bool itemIsBeingEdited { get; set; }

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x00074BDE File Offset: 0x00072DDE
		// (set) Token: 0x06001771 RID: 6001 RVA: 0x00074BE6 File Offset: 0x00072DE6
		public ProcessorUIInterfaceManagerItem lastEditedItem { get; set; }

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x00074BEF File Offset: 0x00072DEF
		// (set) Token: 0x06001773 RID: 6003 RVA: 0x00074BF7 File Offset: 0x00072DF7
		public bool escapeKeyConsumed { get; set; }

		// Token: 0x06001774 RID: 6004 RVA: 0x00074C00 File Offset: 0x00072E00
		public void Setup(ProcessorUI theProcessorUI)
		{

		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00074CE0 File Offset: 0x00072EE0
		public void Close()
		{

		}

		// Token: 0x06001776 RID: 6006 RVA: 0x00074E74 File Offset: 0x00073074
		public void OnEscapePressed()
		{

		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00074EAD File Offset: 0x000730AD
		public void ShowWarning(string theMessage)
		{

		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00074ECC File Offset: 0x000730CC
		public void HideWarning()
		{

		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00074EDF File Offset: 0x000730DF
		public void CreateNewPort()
		{

		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00074EEC File Offset: 0x000730EC
		public void AddCommand()
		{

		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00074FA8 File Offset: 0x000731A8
		public void RemoveCommand(int id)
		{

		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00075034 File Offset: 0x00073234
		public void RenameCommand(int id, string newName)
		{

		}

		// Token: 0x0600177D RID: 6013 RVA: 0x000750A0 File Offset: 0x000732A0
		public void AddOutput()
		{

		}

		// Token: 0x0600177E RID: 6014 RVA: 0x0007515C File Offset: 0x0007335C
		public void RemoveOutput(int id)
		{

		}

		// Token: 0x0600177F RID: 6015 RVA: 0x000751E8 File Offset: 0x000733E8
		public void RenameOutput(int id, string newName)
		{

		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00075254 File Offset: 0x00073454
		public void AddPropertyPort()
		{

		}

		// Token: 0x06001781 RID: 6017 RVA: 0x000753BC File Offset: 0x000735BC
		public void RemovePropertyPort(int id)
		{

		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00075478 File Offset: 0x00073678
		public void RenamePropertyPort(int id, string newName)
		{

		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00075504 File Offset: 0x00073704
		public void SetPropertyPortDataType(int id, Data.Types type)
		{

		}

		// Token: 0x06001784 RID: 6020 RVA: 0x000755CC File Offset: 0x000737CC
		private string GenerateName(AgentGestalt.Port.Types type)
		{

            return default;
        }

		// Token: 0x06001785 RID: 6021 RVA: 0x0007563C File Offset: 0x0007383C
		public bool DoesPortExist(AgentGestalt.Port.Types type, string portName)
		{

            return default;
        }

		// Token: 0x06001786 RID: 6022 RVA: 0x00075770 File Offset: 0x00073970
		public void Populate()
		{

		}

		// Token: 0x06001787 RID: 6023 RVA: 0x000759C4 File Offset: 0x00073BC4
		private IEnumerator ResetEscapeFlag()
		{

            return default;
        }

		// Token: 0x04001317 RID: 4887
		public GameObject itemPrefab;

		// Token: 0x04001318 RID: 4888
		public RectTransform content;

		// Token: 0x04001319 RID: 4889
		public GameObject message;

		// Token: 0x0400131A RID: 4890
		public TextMeshProUGUI warning;

		// Token: 0x0400131B RID: 4891
		public ScrollRectNoDragging scrollView;

		// Token: 0x0400131C RID: 4892
		private EscapeManager _escapeManager;

		// Token: 0x0400131D RID: 4893
		private Transform _commandSeparator;

		// Token: 0x0400131E RID: 4894
		private Transform _propertySeparator;

		// Token: 0x0400131F RID: 4895
		private Transform _outputSeparator;

		// Token: 0x04001320 RID: 4896
		private Agent.ModuleInterface _moduleInterface;

		// Token: 0x04001321 RID: 4897
		private const string _commandPrefix = "My Command";

		// Token: 0x04001322 RID: 4898
		private const string _propertyPrefix = "My Property";

		// Token: 0x04001323 RID: 4899
		private const string _outputPrefix = "My Output";
	}
}
