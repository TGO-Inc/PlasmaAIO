using System;
using System.Collections.Generic;
using Behavior;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using UnityEngine;
using Visor;

// Token: 0x02000137 RID: 311
public class UIComposerAgent : Agent
{
	// Token: 0x06000B8C RID: 2956 RVA: 0x0003C180 File Offset: 0x0003A380
	protected override void OnSetupFinished()
	{

	}

	// Token: 0x06000B8D RID: 2957 RVA: 0x0003C2AE File Offset: 0x0003A4AE
	protected override void OnCleanUpFinished()
	{

	}

	// Token: 0x06000B8E RID: 2958 RVA: 0x0003C2C9 File Offset: 0x0003A4C9
	public override void OnDeviceReset()
	{

	}

	// Token: 0x06000B8F RID: 2959 RVA: 0x0003C2D9 File Offset: 0x0003A4D9
	public static Dictionary<AssetController.ResourceTypes, int> GetResourcesDescription()
	{

        return default;
    }

	// Token: 0x06000B90 RID: 2960 RVA: 0x0003C2E8 File Offset: 0x0003A4E8
	public override void AllocResources()
	{

	}

	// Token: 0x06000B91 RID: 2961 RVA: 0x0003C347 File Offset: 0x0003A547
	public override void DeallocResources()
	{

	}

	// Token: 0x06000B92 RID: 2962 RVA: 0x0003C35E File Offset: 0x0003A55E
	[AgentPropertyHandler(1)]
	public void HandleChange(AgentProperty property)
	{

	}

	// Token: 0x06000B93 RID: 2963 RVA: 0x0003C38C File Offset: 0x0003A58C
	public override void ExecuteSketchNodeLogic(SketchNode sketchNode)
	{

	}

	// Token: 0x06000B94 RID: 2964 RVA: 0x0003C5F0 File Offset: 0x0003A7F0
	private bool GenerateUI()
	{

        return default;
    }

	// Token: 0x06000B95 RID: 2965 RVA: 0x0003C6B8 File Offset: 0x0003A8B8
	private void RenderUI(SketchNode sketchNode)
	{

	}

	// Token: 0x04000A40 RID: 2624
	private Data.Image _uiData;

	// Token: 0x04000A41 RID: 2625
	private AgentProperty _stateProperty;

	// Token: 0x04000A42 RID: 2626
	private AgentProperty _transparentBackgroundProperty;

	// Token: 0x04000A43 RID: 2627
	private AgentProperty _backgroundColorProperty;

	// Token: 0x04000A44 RID: 2628
	private AgentProperty _documentProperty;

	// Token: 0x04000A45 RID: 2629
	private AgentProperty _interactiveProperty;

	// Token: 0x04000A46 RID: 2630
	private AgentProperty _forceRenderingProperty;

	// Token: 0x04000A47 RID: 2631
	private AgentProperty _pointerXProperty;

	// Token: 0x04000A48 RID: 2632
	private AgentProperty _pointerYProperty;

	// Token: 0x04000A49 RID: 2633
	private AgentProperty _pointerPressedProperty;

	// Token: 0x04000A4A RID: 2634
	private AgentProperty _previousDescriptionProperty;

	// Token: 0x04000A4B RID: 2635
	private List<DisplayUIElement> _elements;

	// Token: 0x04000A4C RID: 2636
	private DisplayUIElement _activeElement;

	// Token: 0x04000A4D RID: 2637
	private DisplayUIElement _pressedElement;

	// Token: 0x04000A4E RID: 2638
	private DisplayUIConverter _converter;

	// Token: 0x04000A4F RID: 2639
	private bool _shouldGenerateUI;

	// Token: 0x04000A50 RID: 2640
	private GameObject _container;

	// Token: 0x04000A51 RID: 2641
	private Transform _canvas;

	// Token: 0x04000A52 RID: 2642
	private Camera _camera;
}
