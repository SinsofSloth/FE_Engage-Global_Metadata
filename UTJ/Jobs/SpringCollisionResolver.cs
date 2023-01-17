// Namespace: UTJ.Jobs
public static class SpringCollisionResolver // TypeDefIndex: 6445
{
	// Methods

	// RVA: 0x311C490 Offset: 0x311C591 VA: 0x311C490
	public static bool ResolveCapsule(SpringColliderProperties capsule, SpringColliderComponents transform, float3 moverHeadPosition, ref float3 moverPosition, ref float3 hitNormal, float moverRadius) { }

	// RVA: 0x311D260 Offset: 0x311D361 VA: 0x311D260
	public static bool ResolvePanel(SpringColliderProperties panel, SpringColliderComponents transform, float3 headPosition, ref float3 tailPosition, ref float3 hitNormal, float length, float tailRadius) { }

	// RVA: 0x311D9B0 Offset: 0x311DAB1 VA: 0x311D9B0
	public static bool ResolvePanelOnAxis(float3 localHeadPosition, ref float3 localTailPosition, float localLength, float localTailRadius, SpringCollisionResolver.Axis upAxis) { }

	// RVA: 0x311DC80 Offset: 0x311DD81 VA: 0x311DC80
	public static bool ResolveSphere(SpringColliderProperties sphere, SpringColliderComponents transform, float3 headPosition, ref float3 tailPosition, ref float3 hitNormal, float tailRadius) { }

	// RVA: 0x311CF60 Offset: 0x311D061 VA: 0x311CF60
	private static bool ComputeIntersection_Sphere(float3 originA, float radiusA, float3 originB, float radiusB, out Intersection intersection) { }

	// RVA: 0x311D120 Offset: 0x311D221 VA: 0x311D120
	private static float3 ComputeNewTailPosition_Sphere(Intersection intersection, float3 tailPosition) { }
}

