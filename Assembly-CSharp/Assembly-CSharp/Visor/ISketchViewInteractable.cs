using System;

namespace Visor
{
	// Token: 0x02000260 RID: 608
	public interface ISketchViewInteractable
	{
		// Token: 0x060016A1 RID: 5793
		void OnMousePointerEnter(SketchViewInteractables triggerId);

		// Token: 0x060016A2 RID: 5794
		void OnMousePointerExit(SketchViewInteractables triggerId);

		// Token: 0x060016A3 RID: 5795
		void OnTopmostTrigger(SketchViewInteractables id);

		// Token: 0x060016A4 RID: 5796
		void OnBackgroundTrigger(SketchViewInteractables id);

		// Token: 0x060016A5 RID: 5797
		void OnMouseLeftButtonDown(SketchViewInteractables id);

		// Token: 0x060016A6 RID: 5798
		void OnMouseLeftButtonUp(SketchViewInteractables id);

		// Token: 0x060016A7 RID: 5799
		void OnMouseRightButtonDown(SketchViewInteractables id);

		// Token: 0x060016A8 RID: 5800
		void OnMouseRightButtonUp(SketchViewInteractables id);
	}
}
