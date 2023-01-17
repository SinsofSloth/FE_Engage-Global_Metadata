// Namespace: UTJ.Jobs
[Serializable]
public struct AngleLimitComponent // TypeDefIndex: 6438
{
	// Fields
	public bool active; // 0x0
	public float min; // 0x4
	public float max; // 0x8

	// Methods

	// RVA: 0x3105740 Offset: 0x3105841 VA: 0x3105740
	private static float ComputeFalloff(float value, float range) { }

	// RVA: 0x3105850 Offset: 0x3105951 VA: 0x3105850
	public float3 ConstrainVector(float3 target, float3 basisSide, float3 basisUp, float3 basisForward, float springStrength, float deltaTime) { }

	// RVA: 0x3105C20 Offset: 0x3105D21 VA: 0x3105C20
	public static float3 Project(float3 vector, float3 onNormal) { }
}

