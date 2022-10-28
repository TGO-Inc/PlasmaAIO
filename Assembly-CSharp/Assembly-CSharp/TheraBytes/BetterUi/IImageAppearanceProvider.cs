using System;
using UnityEngine;

namespace TheraBytes.BetterUi
{
	// Token: 0x02000202 RID: 514
	public interface IImageAppearanceProvider
	{
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060011C9 RID: 4553
		ColorMode ColoringMode { get; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060011CA RID: 4554
		Color SecondColor { get; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060011CB RID: 4555
		Color color { get; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060011CC RID: 4556
		// (set) Token: 0x060011CD RID: 4557
		string MaterialType { get; set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060011CE RID: 4558
		// (set) Token: 0x060011CF RID: 4559
		MaterialEffect MaterialEffect { get; set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060011D0 RID: 4560
		VertexMaterialData MaterialProperties { get; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060011D1 RID: 4561
		Material material { get; }

		// Token: 0x060011D2 RID: 4562
		void SetMaterialProperty(int propertyIndex, float value);

		// Token: 0x060011D3 RID: 4563
		float GetMaterialPropertyValue(int propertyIndex);

		// Token: 0x060011D4 RID: 4564
		void SetMaterialDirty();
	}
}
