using PlasmaAPI.GameClass.Behavior;
﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace PlasmaAPI.GameClass {
// Token: 0x02000167 RID: 359
public class BiomeReferences : MonoBehaviour
{
	// Token: 0x04000B75 RID: 2933
	[Header("[REFERENCES]")]
	public Terrain terrain;

	// Token: 0x04000B76 RID: 2934
	public Transform slideRing;

	// Token: 0x04000B77 RID: 2935
	public Transform sun;

	// Token: 0x04000B78 RID: 2936
	public Transform moon;

	// Token: 0x04000B79 RID: 2937
	public GameObject planetBottom;

	// Token: 0x04000B7A RID: 2938
	public GameObject dynamicProps;

	// Token: 0x04000B7B RID: 2939
	public GameObject fx;

	// Token: 0x04000B7C RID: 2940
	public GrassFlowRenderer grassFlowRenderer;

	// Token: 0x04000B7D RID: 2941
	public Material grassflowMaterial;

	// Token: 0x04000B7E RID: 2942
	public GameObject[] plants;

	// Token: 0x04000B7F RID: 2943
	public GameObject cloudsContainer;

	// Token: 0x04000B80 RID: 2944
	[Tooltip("Be sure to start presets from 00:00 and advance chronologically")]
	public EnvironmentPreset[] environmentPresets;

	// Token: 0x04000B81 RID: 2945
	public List<MeshRenderer> allRenderers = new List<MeshRenderer>();
}
}