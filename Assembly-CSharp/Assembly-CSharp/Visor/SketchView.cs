using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Behavior;
using DataStructures.ViliWonka.KDTree;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DG.Tweening.Timeline;
using DigitalRuby.FastLineRenderer;
using NodeCanvas.StateMachines;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PlasmaAPI.GameClass.Visor 
{
	// Token: 0x0200027B RID: 635
	public class SketchView : MonoBehaviour
	{
		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x00078A88 File Offset: 0x00076C88
		public ProcessorUI processorUI
		{
			get
			{
				return this._processorUI;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x00078A90 File Offset: 0x00076C90
		// (set) Token: 0x0600182C RID: 6188 RVA: 0x00078A98 File Offset: 0x00076C98
		public SketchView.Reactions reaction { get; private set; }

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x00078AA1 File Offset: 0x00076CA1
		// (set) Token: 0x0600182E RID: 6190 RVA: 0x00078AA9 File Offset: 0x00076CA9
		public SketchViewNodePort candidateInputPort { get; set; }

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600182F RID: 6191 RVA: 0x00078AB2 File Offset: 0x00076CB2
		public SketchViewTrigger topMostSketchViewTrigger
		{
			get
			{
				return this._topTriggeredInteractable;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x00078ABA File Offset: 0x00076CBA
		public IEnumerable<SketchViewNode> allSketchViewNodes
		{
			get
			{
				return this._allNodes;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x00078AC2 File Offset: 0x00076CC2
		public int numberOfNodes
		{
			get
			{
				return this._allNodes.Count;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x00078ACF File Offset: 0x00076CCF
		public IEnumerable<SketchViewConnection> allSketchViewConnections
		{
			get
			{
				return this._connections.Values;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x00078ADC File Offset: 0x00076CDC
		// (set) Token: 0x06001834 RID: 6196 RVA: 0x00078AE4 File Offset: 0x00076CE4
		public Bounds viewportBounds { get; private set; }

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x00078AED File Offset: 0x00076CED
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x00078AF8 File Offset: 0x00076CF8
		public float zoomFactor
		{
			get
			{
				return this._zoomFactor;
			}
			set
			{
				this.viewCamera.orthographicSize = 27f * value;
				this.secondaryUI.localScale = new Vector3(value, value, 1f);
				if (this._processorUI.isReady)
				{
					this._processorUI.minimap.ResizeViewport(value);
				}
				this._zoomFactor = value;
			}
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00078B54 File Offset: 0x00076D54
		public void Setup(ProcessorUI processorUIInstance, Sketch sketch)
		{

		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00078FB1 File Offset: 0x000771B1
		private IEnumerator BuildViewAsync()
		{

            return default;
        }

		// Token: 0x06001839 RID: 6201 RVA: 0x00078FC0 File Offset: 0x000771C0
		public void BuildView()
		{

		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00078FD0 File Offset: 0x000771D0
		public void RebuildTypeButtons()
		{

		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00079028 File Offset: 0x00077228
		public void ComposeMetaData()
		{

		}

		// Token: 0x0600183C RID: 6204 RVA: 0x000791D0 File Offset: 0x000773D0
		private void CreateOutOfBoundsArea(Vector2 position, Vector2 size)
		{

		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00079208 File Offset: 0x00077408
		private void ShowCurtain(Bounds hole)
		{

		}

		// Token: 0x0600183E RID: 6206 RVA: 0x00079628 File Offset: 0x00077828
		private void CreateCurtainRegion(Bounds bounds)
		{

		}

		// Token: 0x0600183F RID: 6207 RVA: 0x0007967B File Offset: 0x0007787B
		private void HideCurtain()
		{

		}

		// Token: 0x06001840 RID: 6208 RVA: 0x00079690 File Offset: 0x00077890
		private void CalculateBounds()
		{

		}

		// Token: 0x06001841 RID: 6209 RVA: 0x000796FC File Offset: 0x000778FC
		public void CleanUp()
		{

		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00079750 File Offset: 0x00077950
		public bool IsIdle()
		{

            return default;
        }

		// Token: 0x06001843 RID: 6211 RVA: 0x00079784 File Offset: 0x00077984
		public void ShowHintForNode(AgentId node)
		{

		}

		// Token: 0x06001844 RID: 6212 RVA: 0x000797CD File Offset: 0x000779CD
		public void ShowHintForPort(AgentGestalt.Port portDefinition)
		{

		}

		// Token: 0x06001845 RID: 6213 RVA: 0x000797FA File Offset: 0x000779FA
		public void ShowHintForConnection()
		{

		}

		// Token: 0x06001846 RID: 6214 RVA: 0x0007980C File Offset: 0x00077A0C
		public void HideHint()
		{

		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00079820 File Offset: 0x00077A20
		private void MoveSketchViewNodeToMousePosition(SketchViewNode sketchViewNode)
		{

		}

		// Token: 0x06001848 RID: 6216 RVA: 0x000798B8 File Offset: 0x00077AB8
		public SketchViewNode AddNode(AgentId agentId, bool fromComponentLibrary, bool fromCode = false, Vector2? fromCodePosition = null)
		{

            return default;
        }

		// Token: 0x06001849 RID: 6217 RVA: 0x000799E4 File Offset: 0x00077BE4
		public void RemoveNode(SketchViewNode sketchViewNode)
		{

		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00079BD0 File Offset: 0x00077DD0
		public void TryToConnectToNewNode(SketchViewNode newNode)
		{

		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00079C70 File Offset: 0x00077E70
		private void CreateWireInternal()
		{

		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00079E2C File Offset: 0x0007802C
		private SketchViewNode GetNodeById(int id)
		{

            return default;
        }

		// Token: 0x0600184D RID: 6221 RVA: 0x00079E88 File Offset: 0x00078088
		public bool IsSketchNodeMulti(SketchNode sketchNode)
		{

            return default;
        }

		// Token: 0x0600184E RID: 6222 RVA: 0x00079E94 File Offset: 0x00078094
		public int GetNumberOfMultiNodes(SketchNode sketchNode)
		{

            return default;
        }

		// Token: 0x0600184F RID: 6223 RVA: 0x00079EBC File Offset: 0x000780BC
		public List<SketchViewNode> GetNodes(SketchNode sketchNode)
		{

            return default;
        }

		// Token: 0x06001850 RID: 6224 RVA: 0x00079EDC File Offset: 0x000780DC
		private SketchViewConnection AddConnection(SketchViewNodePort outputPort, SketchViewNodePort inputPort, bool updateVisuals = true)
		{

            return default;
        }

		// Token: 0x06001851 RID: 6225 RVA: 0x00079F67 File Offset: 0x00078167
		public void RemoveConnection(SketchViewConnection sketchViewConnection, bool nodeIsBeingDestroyed)
		{

		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00079F9B File Offset: 0x0007819B
		public void ToggleConnection(SketchViewConnection sketchViewConnection)
		{

		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00079FD0 File Offset: 0x000781D0
		private SketchViewNode SpawnNode(SketchNode sketchNode, SketchNode.MetaData.Node metaData)
		{

            return default;
        }

		// Token: 0x06001854 RID: 6228 RVA: 0x0007A038 File Offset: 0x00078238
		private void DestroyNode(SketchViewNode sketchViewNode)
		{

		}

		// Token: 0x06001855 RID: 6229 RVA: 0x0007A090 File Offset: 0x00078290
		private SketchViewConnection SpawnConnection(SketchConnection sketchConnection, SketchViewNodePort outputPort, SketchViewNodePort inputPort, SketchConnection.MetaData metaData = null)
		{

            return default;
        }

		// Token: 0x06001856 RID: 6230 RVA: 0x0007A0DA File Offset: 0x000782DA
		private void DestroyConnection(SketchViewConnection sketchViewConnection, bool nodeIsBeingDestroyed)
		{

		}

		// Token: 0x06001857 RID: 6231 RVA: 0x0007A100 File Offset: 0x00078300
		public SketchViewLabel SpawnLabel(ProcessorAgent.SketchMetaData.Label metaData = null)
		{

            return default;
        }

		// Token: 0x06001858 RID: 6232 RVA: 0x0007A19A File Offset: 0x0007839A
		public void DestroyLabel(SketchViewLabel label)
		{

		}

		// Token: 0x06001859 RID: 6233 RVA: 0x0007A1C0 File Offset: 0x000783C0
		private bool HandleInteractables(bool forceEmptyResults = false)
		{

            return default;
        }

		// Token: 0x0600185A RID: 6234 RVA: 0x0007A58C File Offset: 0x0007878C
		private void DetectTopTriggeredInteractable()
		{

		}

		// Token: 0x0600185B RID: 6235 RVA: 0x0007A640 File Offset: 0x00078840
		private IEnumerable<SketchViewTrigger> GetCloseByTriggers(Vector2 position, SketchViewInteractables id)
		{

            return default;
        }

		// Token: 0x0600185C RID: 6236 RVA: 0x0007A6E4 File Offset: 0x000788E4
		private void ScrollViewByDelta(Vector3 delta)
		{

		}

		// Token: 0x0600185D RID: 6237 RVA: 0x0007A700 File Offset: 0x00078900
		public void ScrollViewToPosition(Vector3 position, bool instant = true, bool updateMinimap = true)
		{

		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0007A75C File Offset: 0x0007895C
		private void ScrollView(Vector3 position, bool updateMinimap = true)
		{

		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0007A7F0 File Offset: 0x000789F0
		public int GrabNextNodeIndex()
		{

            return default;
        }

		// Token: 0x06001860 RID: 6240 RVA: 0x0007A825 File Offset: 0x00078A25
		public void ReleaseNodeIndex(int index)
		{

		}

		// Token: 0x06001861 RID: 6241 RVA: 0x0007A834 File Offset: 0x00078A34
		public int GrabNextLabelIndex()
		{

            return default;
        }

		// Token: 0x06001862 RID: 6242 RVA: 0x0007A866 File Offset: 0x00078A66
		public void ReleaseLabelIndex(int index)
		{

		}

		// Token: 0x06001863 RID: 6243 RVA: 0x0007A873 File Offset: 0x00078A73
		public IEnumerator RunIdle()
		{

            return default;
        }

		// Token: 0x06001864 RID: 6244 RVA: 0x0007A882 File Offset: 0x00078A82
		public IEnumerator RunPan()
		{

            return default;
        }

		// Token: 0x06001865 RID: 6245 RVA: 0x0007A891 File Offset: 0x00078A91
		public void ExitPan()
		{

		}

		// Token: 0x06001866 RID: 6246 RVA: 0x0007A8C4 File Offset: 0x00078AC4
		public bool ShouldEnterPan()
		{

            return default;
        }

		// Token: 0x06001867 RID: 6247 RVA: 0x0007A917 File Offset: 0x00078B17
		public bool ShouldExitPan()
		{

            return default;
        }

		// Token: 0x06001868 RID: 6248 RVA: 0x0007A929 File Offset: 0x00078B29
		public IEnumerator RunUI()
		{

            return default;
        }

		// Token: 0x06001869 RID: 6249 RVA: 0x0007A938 File Offset: 0x00078B38
		public bool IsMouseOverUI()
		{

            return default;
        }

		// Token: 0x0600186A RID: 6250 RVA: 0x0007A944 File Offset: 0x00078B44
		public IEnumerator RunMoveNode()
		{

            return default;
        }

		// Token: 0x0600186B RID: 6251 RVA: 0x0007A954 File Offset: 0x00078B54
		public void SetupMoveNewNode()
		{

		}

		// Token: 0x0600186C RID: 6252 RVA: 0x0007A9A8 File Offset: 0x00078BA8
		public void SetupMoveExistingNode()
		{

		}

		// Token: 0x0600186D RID: 6253 RVA: 0x0007A9E3 File Offset: 0x00078BE3
		public void DeleteNewNode()
		{

		}

		// Token: 0x0600186E RID: 6254 RVA: 0x0007A9F4 File Offset: 0x00078BF4
		public void ExitMoveNode()
		{

		}

		// Token: 0x0600186F RID: 6255 RVA: 0x0007AA9A File Offset: 0x00078C9A
		public bool ShouldEnterMoveNode()
		{

            return default;
        }

		// Token: 0x06001870 RID: 6256 RVA: 0x0007AAC9 File Offset: 0x00078CC9
		public bool ShouldExitMoveNode()
		{

            return default;
        }

		// Token: 0x06001871 RID: 6257 RVA: 0x0007AAE5 File Offset: 0x00078CE5
		public bool ShouldDeleteNewNode()
		{

            return default;
        }

		// Token: 0x06001872 RID: 6258 RVA: 0x0007AAF7 File Offset: 0x00078CF7
		public bool ShouldMoveNewNode()
		{

            return default;
        }

		// Token: 0x06001873 RID: 6259 RVA: 0x0007AB05 File Offset: 0x00078D05
		public IEnumerator RunMoveLabel()
		{

            return default;
        }

		// Token: 0x06001874 RID: 6260 RVA: 0x0007AB14 File Offset: 0x00078D14
		public void ExitMoveLabel()
		{

		}

		// Token: 0x06001875 RID: 6261 RVA: 0x0007AB93 File Offset: 0x00078D93
		public bool ShouldEnterMoveLabel()
		{

            return default;
        }

		// Token: 0x06001876 RID: 6262 RVA: 0x0007ABC4 File Offset: 0x00078DC4
		public bool ShouldExitMoveLabel()
		{

            return default;
        }

		// Token: 0x06001877 RID: 6263 RVA: 0x0007ABD6 File Offset: 0x00078DD6
		public IEnumerator RunResizeLabel()
		{

            return default;
        }

		// Token: 0x06001878 RID: 6264 RVA: 0x0007ABE5 File Offset: 0x00078DE5
		public void ExitResizeLabel()
		{

		}

		// Token: 0x06001879 RID: 6265 RVA: 0x0007AC03 File Offset: 0x00078E03
		public bool ShouldEnterResizeLabel()
		{

            return default;
        }

		// Token: 0x0600187A RID: 6266 RVA: 0x0007AC34 File Offset: 0x00078E34
		public bool ShouldExitResizeLabel()
		{

            return default;
        }

		// Token: 0x0600187B RID: 6267 RVA: 0x0007AC46 File Offset: 0x00078E46
		public IEnumerator RunSelection()
		{

            return default;
        }

		// Token: 0x0600187C RID: 6268 RVA: 0x0007AC58 File Offset: 0x00078E58
		public void CleanupSelection()
		{

		}

		// Token: 0x0600187D RID: 6269 RVA: 0x0007AD34 File Offset: 0x00078F34
		public bool ShouldEnterSelection()
		{

            return default;
        }

		// Token: 0x0600187E RID: 6270 RVA: 0x0007AD72 File Offset: 0x00078F72
		public bool ShouldCancelSelection()
		{

            return default;
        }

		// Token: 0x0600187F RID: 6271 RVA: 0x0007ADA3 File Offset: 0x00078FA3
		public IEnumerator IdleSelection()
		{

            return default;
        }

		// Token: 0x06001880 RID: 6272 RVA: 0x0007ADB4 File Offset: 0x00078FB4
		public void SetupIdleSelection()
		{

		}

		// Token: 0x06001881 RID: 6273 RVA: 0x0007AF48 File Offset: 0x00079148
		public bool ShouldEnterIdleSelection()
		{

            return default;
        }

		// Token: 0x06001882 RID: 6274 RVA: 0x0007AF7C File Offset: 0x0007917C
		public bool ShouldExitIdleSelection()
		{

            return default;
        }

		// Token: 0x06001883 RID: 6275 RVA: 0x0007AF9B File Offset: 0x0007919B
		public IEnumerator RunMoveSelection()
		{

            return default;
        }

		// Token: 0x06001884 RID: 6276 RVA: 0x0007AFAC File Offset: 0x000791AC
		public void ExitMoveSelection()
		{

		}

		// Token: 0x06001885 RID: 6277 RVA: 0x0007B034 File Offset: 0x00079234
		public bool ShouldEnterMoveSelection()
		{

            return default;
        }

		// Token: 0x06001886 RID: 6278 RVA: 0x0007B050 File Offset: 0x00079250
		public bool ShouldExitMoveSelection()
		{

            return default;
        }

		// Token: 0x06001887 RID: 6279 RVA: 0x0007B06C File Offset: 0x0007926C
		public void DuplicateSelection()
		{

		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0007B554 File Offset: 0x00079754
		public bool ShouldDuplicateSelection()
		{

            return default;
        }

		// Token: 0x06001889 RID: 6281 RVA: 0x0007B570 File Offset: 0x00079770
		public void DeleteSelection()
		{

		}

		// Token: 0x0600188A RID: 6282 RVA: 0x0007B620 File Offset: 0x00079820
		public bool ShouldDeleteSelection()
		{

            return default;
        }

		// Token: 0x0600188B RID: 6283 RVA: 0x0007B634 File Offset: 0x00079834
		public void DuplicateNode()
		{

		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0007B744 File Offset: 0x00079944
		public bool ShouldDuplicateNode()
		{

            return default;
        }

		// Token: 0x0600188D RID: 6285 RVA: 0x0007B7E0 File Offset: 0x000799E0
		public IEnumerator RunWiring()
		{

            return default;
        }

		// Token: 0x0600188E RID: 6286 RVA: 0x0007B7F0 File Offset: 0x000799F0
		public void ExitWiring()
		{

		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0007B89C File Offset: 0x00079A9C
		public void DelayWiring()
		{

		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0007B924 File Offset: 0x00079B24
		public void CancelWiring()
		{

		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0007B994 File Offset: 0x00079B94
		public void CreateWire()
		{

		}

		// Token: 0x06001892 RID: 6290 RVA: 0x0007B9BA File Offset: 0x00079BBA
		public bool ShouldEnterWiring()
		{

            return default;
        }

		// Token: 0x06001893 RID: 6291 RVA: 0x0007B9EC File Offset: 0x00079BEC
		public bool ShouldDelayWiring()
		{

            return default;
        }

		// Token: 0x06001894 RID: 6292 RVA: 0x0007BA3C File Offset: 0x00079C3C
		public bool ShouldCancelWiring()
		{

            return default;
        }

		// Token: 0x06001895 RID: 6293 RVA: 0x0007BA8D File Offset: 0x00079C8D
		public bool ShouldCreateWire()
		{

            return default;
        }

		// Token: 0x06001896 RID: 6294 RVA: 0x0007BAAF File Offset: 0x00079CAF
		public IEnumerator RunMovePin()
		{

            return default;
        }

		// Token: 0x06001897 RID: 6295 RVA: 0x0007BABE File Offset: 0x00079CBE
		public void StartMovePin(SketchViewConnection sketchViewConnection)
		{

		}

		// Token: 0x06001898 RID: 6296 RVA: 0x0007BAC8 File Offset: 0x00079CC8
		public void ExitMovePin()
		{

		}

		// Token: 0x06001899 RID: 6297 RVA: 0x0007BB1D File Offset: 0x00079D1D
		public bool ShouldEnterMovePin()
		{

            return default;
        }

		// Token: 0x0600189A RID: 6298 RVA: 0x0007BB2B File Offset: 0x00079D2B
		public bool ShouldExitMovePin()
		{

            return default;
        }

		// Token: 0x0600189B RID: 6299 RVA: 0x0007BB40 File Offset: 0x00079D40
		private Vector3 GetMousePositionInArea(bool snapped)
		{

            return default;
        }

		// Token: 0x0600189C RID: 6300 RVA: 0x0007BBDC File Offset: 0x00079DDC
		public int RegisterPointProvider(IKDPoint provider)
		{

            return default;
        }

		// Token: 0x0600189D RID: 6301 RVA: 0x0007BC0C File Offset: 0x00079E0C
		public void UnregisterPointProvider(int index)
		{

		}

		// Token: 0x0600189E RID: 6302 RVA: 0x0007BC24 File Offset: 0x00079E24
		private void ClearPointProvider(int index, bool callOnMouseExit = false)
		{

		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0007BC8C File Offset: 0x00079E8C
		public void BuildPointCloud()
		{

		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0007BCC1 File Offset: 0x00079EC1
		public void UpdatePointCloud()
		{

		}

		// Token: 0x040013A2 RID: 5026
		public GameObject nodePrefab;

		// Token: 0x040013A3 RID: 5027
		public GameObject diagonalStripePrefab;

		// Token: 0x040013A4 RID: 5028
		public GameObject fullTilePrefab;

		// Token: 0x040013A5 RID: 5029
		public GameObject connectionPrefab;

		// Token: 0x040013A6 RID: 5030
		public GameObject draggedWirePrefab;

		// Token: 0x040013A7 RID: 5031
		public GameObject labelPrefab;

		// Token: 0x040013A8 RID: 5032
		public FastLineRenderer draggedLineTemplate;

		// Token: 0x040013A9 RID: 5033
		public FastLineRenderer lineTemplate;

		// Token: 0x040013AA RID: 5034
		public Transform area;

		// Token: 0x040013AB RID: 5035
		public Transform outOfBounds;

		// Token: 0x040013AC RID: 5036
		public Transform nodesContainer;

		// Token: 0x040013AD RID: 5037
		public Transform connectionsContainer;

		// Token: 0x040013AE RID: 5038
		public Transform labelsContainer;

		// Token: 0x040013AF RID: 5039
		public Transform curtain;

		// Token: 0x040013B0 RID: 5040
		public SketchViewSelection selection;

		// Token: 0x040013B1 RID: 5041
		public Camera viewCamera;

		// Token: 0x040013B2 RID: 5042
		public RectTransform secondaryUI;

		// Token: 0x040013B3 RID: 5043
		public TextMeshPro deviceName;

		// Token: 0x040013B4 RID: 5044
		public RectTransform hints;

		// Token: 0x040013B5 RID: 5045
		public TextMeshPro hintDescription;

		// Token: 0x040013B6 RID: 5046
		public MeshRenderer background;

		// Token: 0x040013B7 RID: 5047
		public FloatRange autoscrollSpeed;

		// Token: 0x040013B8 RID: 5048
		public DOVisualSequence fadeInSequence;

		// Token: 0x040013B9 RID: 5049
		public DOVisualSequence fadeOutSequence;

		// Token: 0x040013BA RID: 5050
		public const int maxConnectionsPerNode = 256;

		// Token: 0x040013BB RID: 5051
		public const int maxNodes = 256;

		// Token: 0x040013BC RID: 5052
		public const int maxLabels = 64;

		// Token: 0x040013BD RID: 5053
		private List<IKDPoint> _pointCloud;

		// Token: 0x040013BE RID: 5054
		private Dictionary<int, IKDPoint> _pointProviders;

		// Token: 0x040013BF RID: 5055
		private KDTree _kdTree;

		// Token: 0x040013C0 RID: 5056
		private KDQuery _kdQuery;

		// Token: 0x040013C1 RID: 5057
		private int _pointProviderIndex;

		// Token: 0x040013C2 RID: 5058
		private ProcessorUI _processorUI;

		// Token: 0x040013C3 RID: 5059
		private Sketch _sketch;

		// Token: 0x040013C4 RID: 5060
		private Player _input;

		// Token: 0x040013C5 RID: 5061
		private List<SketchViewTrigger> _triggeredInteractables;

		// Token: 0x040013C6 RID: 5062
		private List<SketchViewTrigger> _untriggeredInteractables;

		// Token: 0x040013C7 RID: 5063
		private List<SketchViewTrigger> _candidateInteractables;

		// Token: 0x040013C8 RID: 5064
		private FSMOwner _stateMachine;

		// Token: 0x040013C9 RID: 5065
		private SketchViewTrigger _topTriggeredInteractable;

		// Token: 0x040013CA RID: 5066
		private SketchViewTrigger _lastTopTriggeredInteractable;

		// Token: 0x040013CB RID: 5067
		private SketchViewTrigger _interactingTrigger;

		// Token: 0x040013CC RID: 5068
		private SketchViewNode _operatingNode;

		// Token: 0x040013CD RID: 5069
		private SketchViewLabel _operatingLabel;

		// Token: 0x040013CE RID: 5070
		private SketchViewConnection _operatingConnection;

		// Token: 0x040013CF RID: 5071
		private SketchViewNode _newNode;

		// Token: 0x040013D0 RID: 5072
		private Bounds _contentBounds;

		// Token: 0x040013D1 RID: 5073
		private Dictionary<SketchNode, List<SketchViewNode>> _nodes;

		// Token: 0x040013D2 RID: 5074
		private Dictionary<SketchConnection, SketchViewConnection> _connections;

		// Token: 0x040013D3 RID: 5075
		private List<SketchViewNode> _allNodes;

		// Token: 0x040013D4 RID: 5076
		private List<SketchViewLabel> _labels;

		// Token: 0x040013D5 RID: 5077
		private HashSet<SketchViewTrigger> _returnedTriggers;

		// Token: 0x040013D6 RID: 5078
		private HashSet<SketchViewTrigger> _closeByTriggers;

		// Token: 0x040013D7 RID: 5079
		private Dictionary<SketchViewNode, Vector3> _grabbedNodes;

		// Token: 0x040013D8 RID: 5080
		private Dictionary<SketchViewConnection, Dictionary<SketchViewConnectionPin, Vector3>> _grabbedPins;

		// Token: 0x040013D9 RID: 5081
		private bool _illegalMoveNodeOperation;

		// Token: 0x040013DA RID: 5082
		private DraggedWire _draggedWire;

		// Token: 0x040013DB RID: 5083
		private SketchViewNodePort _wireOutputPort;

		// Token: 0x040013DC RID: 5084
		private SketchViewNodePort _wireInputPort;

		// Token: 0x040013DD RID: 5085
		private SketchViewNode _nodeToDuplicate;

		// Token: 0x040013DE RID: 5086
		private bool[] _nodePriorities;

		// Token: 0x040013DF RID: 5087
		private bool[] _labelPriorities;

		// Token: 0x040013E0 RID: 5088
		private Tween _scrollTween;

		// Token: 0x040013E1 RID: 5089
		private Bounds _selectionBounds;

		// Token: 0x040013E2 RID: 5090
		private bool _mouseOverSelection;

		// Token: 0x040013E3 RID: 5091
		private bool _selectionValid;

		// Token: 0x040013E4 RID: 5092
		private bool _wasLibraryShown;

		// Token: 0x040013E5 RID: 5093
		private float _zoomFactor;

		// Token: 0x040013E6 RID: 5094
		private bool _dontScrollLeft;

		// Token: 0x040013E7 RID: 5095
		private Vector2 _safetyBuffer1 = new Vector2(2f, 2f);

		// Token: 0x040013E8 RID: 5096
		private Vector2 _safetyBuffer2 = new Vector2(4f, 0f);

		// Token: 0x040013E9 RID: 5097
		private bool _selectionContainsOnlyUnmappedNodes;

		// Token: 0x040013EA RID: 5098
		private const int _objectsPerFrame = 2;

		// Token: 0x040013EB RID: 5099
		private const int _loadingCircleThreshold = 10;

		// Token: 0x040013EC RID: 5100
		private const float _cameraSize = 27f;

		// Token: 0x040013ED RID: 5101
		private const float _viewportMargin = 0.08f;

		// Token: 0x0200047A RID: 1146
		public enum Reactions
		{
			// Token: 0x04001FA0 RID: 8096
			None,
			// Token: 0x04001FA1 RID: 8097
			Normal,
			// Token: 0x04001FA2 RID: 8098
			ToConnector
		}

		// Token: 0x0200047B RID: 1147
		private enum WiringStates
		{
			// Token: 0x04001FA4 RID: 8100
			None,
			// Token: 0x04001FA5 RID: 8101
			CloseToPort,
			// Token: 0x04001FA6 RID: 8102
			Snapped
		}
	}
}
