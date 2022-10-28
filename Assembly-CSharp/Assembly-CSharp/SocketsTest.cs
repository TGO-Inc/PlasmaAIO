using System;
using UnityEngine;

// Token: 0x020001BA RID: 442
public class SocketsTest : MonoBehaviour
{
	// Token: 0x06001025 RID: 4133 RVA: 0x00055794 File Offset: 0x00053994
	private void Start()
	{

	}

	// Token: 0x06001026 RID: 4134 RVA: 0x00055828 File Offset: 0x00053A28
	private void Update()
	{

	}

	// Token: 0x04000E1F RID: 3615
	[Header("[REFERENCES]")]
	public GameObject socketRendererPrefab;

	// Token: 0x04000E20 RID: 3616
	public Transform[] sockets;

	// Token: 0x04000E21 RID: 3617
	[Header("[PARAMETERS]")]
	public float socketSize;

	// Token: 0x04000E22 RID: 3618
	private ParticleSystem socketsPS;

	// Token: 0x04000E23 RID: 3619
	private ParticleSystem.MainModule socketsMainModule;

	// Token: 0x04000E24 RID: 3620
	private ParticleSystem.EmissionModule socketsEmissionModule;

	// Token: 0x04000E25 RID: 3621
	private ParticleSystem.Particle[] socketsParticles;
}
