using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using Behavior;
using DG.Tweening.Timeline;
using Rewired;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x0200029E RID: 670
	public class PropertyList : SerializedMonoBehaviour, ISmoothScrollListProvider
	{
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001A60 RID: 6752 RVA: 0x00085A16 File Offset: 0x00083C16
		public DataEditor currentEditor
		{
			get
			{
				if (!(this._currentEditorObject != null))
				{
					return null;
				}
				return this._currentEditorObject.GetComponent<DataEditor>();
			}
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00085A33 File Offset: 0x00083C33
		private void Awake()
		{

		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00085A48 File Offset: 0x00083C48
		public void Setup(ComponentHandler componentHandler)
		{

		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x00085B00 File Offset: 0x00083D00
		public void CleanUp()
		{

		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00085B9C File Offset: 0x00083D9C
		private void Update()
		{

		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x00085C2C File Offset: 0x00083E2C
		public void SelectNextOrPrevious(bool next)
		{

		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x00085CD8 File Offset: 0x00083ED8
		public void Populate(RectTransform content)
		{

		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x00085EE8 File Offset: 0x000840E8
		private void HandlePropertyStateChanged(AgentProperty property)
		{

		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x00085F5C File Offset: 0x0008415C
		private void ApplyStatesToProperties(PropertyRow row)
		{

		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x00085F88 File Offset: 0x00084188
		public void OnPropertyClicked(PropertyRow property)
		{

		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x000861A8 File Offset: 0x000843A8
		public void OnPropertyHighlighted(PropertyRow property)
		{

		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00086228 File Offset: 0x00084428
		private IEnumerator ShowDefaultDescription()
		{

            return default;
        }

		// Token: 0x06001A6C RID: 6764 RVA: 0x00086238 File Offset: 0x00084438
		public void OnTypeClicked(TypeButton typeButton)
		{

		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x00086364 File Offset: 0x00084564
		private void RefreshTypeSelector()
		{

		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x000863F0 File Offset: 0x000845F0
		public void SelectLastProperty()
		{

		}

		// Token: 0x06001A6F RID: 6767 RVA: 0x00086420 File Offset: 0x00084620
		public void ModifyPosition(RectTransform item)
		{

		}

		// Token: 0x06001A70 RID: 6768 RVA: 0x00086484 File Offset: 0x00084684
		public float GetItemHeight()
		{

            return default;
        }

		// Token: 0x06001A71 RID: 6769 RVA: 0x0008649B File Offset: 0x0008469B
		public int GetInitialTopItemIndex()
		{

            return default;
        }

		// Token: 0x06001A72 RID: 6770 RVA: 0x000864A8 File Offset: 0x000846A8
		public void OnEnterViewport(RectTransform item)
		{

		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x000864B6 File Offset: 0x000846B6
		public void OnExitViewport(RectTransform item)
		{

		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x000864C4 File Offset: 0x000846C4
		private void OnDestroy()
		{

		}

		// Token: 0x0400156F RID: 5487
		public GameObject propertyPrefab;

		// Token: 0x04001570 RID: 5488
		public TextMeshProUGUI description;

		// Token: 0x04001571 RID: 5489
		public TextMeshProUGUI propertyName;

		// Token: 0x04001572 RID: 5490
		public GameObject rightScrollBar;

		// Token: 0x04001573 RID: 5491
		public float radius;

		// Token: 0x04001574 RID: 5492
		public float offset;

		// Token: 0x04001575 RID: 5493
		public Dictionary<Data.Types, GameObject> editors;

		// Token: 0x04001576 RID: 5494
		public TextMeshProUGUI typeSelectorLabelText;

		// Token: 0x04001577 RID: 5495
		public Image typeSelectorLabelIcon;

		// Token: 0x04001578 RID: 5496
		public RectTransform typeButtons;

		// Token: 0x04001579 RID: 5497
		public GameObject emptyMessage1;

		// Token: 0x0400157A RID: 5498
		public GameObject emptyMessage2;

		// Token: 0x0400157B RID: 5499
		public DOVisualSequence showSelectorSequence;

		// Token: 0x0400157C RID: 5500
		public DOVisualSequence hideSelectorSequence;

		// Token: 0x0400157D RID: 5501
		private PropertyEditor _propertyEditor;

		// Token: 0x0400157E RID: 5502
		private Agent _agent;

		// Token: 0x0400157F RID: 5503
		private RectTransform _content;

		// Token: 0x04001580 RID: 5504
		private PropertyRow _selectedProperty;

		// Token: 0x04001581 RID: 5505
		private GameObject _currentEditorObject;

		// Token: 0x04001582 RID: 5506
		private UISmoothScrollList _scrollList;

		// Token: 0x04001583 RID: 5507
		private Player _input;

		// Token: 0x04001584 RID: 5508
		private bool _canSelectProperty;

		// Token: 0x04001585 RID: 5509
		private IEnumerator _descriptionCoroutine;

		// Token: 0x04001586 RID: 5510
		private PropertyRow _currentlyHighlightedProperty;
	}
}
