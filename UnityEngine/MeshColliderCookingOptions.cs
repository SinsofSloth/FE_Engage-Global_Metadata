// Namespace: UnityEngine
[FlagsAttribute] // RVA: 0x4856F0 Offset: 0x4857F1 VA: 0x4856F0
public enum MeshColliderCookingOptions // TypeDefIndex: 4185
{
	// Fields
	public int value__; // 0x0
	public const MeshColliderCookingOptions None = 0;
	[ObsoleteAttribute] // RVA: 0x485DA0 Offset: 0x485EA1 VA: 0x485DA0
	public const MeshColliderCookingOptions InflateConvexMesh = 1;
	public const MeshColliderCookingOptions CookForFasterSimulation = 2;
	public const MeshColliderCookingOptions EnableMeshCleaning = 4;
	public const MeshColliderCookingOptions WeldColocatedVertices = 8;
	public const MeshColliderCookingOptions UseFastMidphase = 16;
}

