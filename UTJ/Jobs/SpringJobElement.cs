// Namespace: UTJ.Jobs
public struct SpringJobElement // TypeDefIndex: 6451
{
	// Fields
	public bool isPaused; // 0x0
	public float deltaTime; // 0x4
	public float dynamicRatio; // 0x8
	public float3 gravity; // 0xC
	public float bounce; // 0x18
	public float friction; // 0x1C
	public bool enableAngleLimits; // 0x20
	public bool enableCollision; // 0x21
	public bool enableLengthLimits; // 0x22
	public bool collideWithGround; // 0x23
	public float groundHeight; // 0x24
	public bool windDisabled; // 0x28
	public float windInfluence; // 0x2C
	public float3 windPower; // 0x30
	public float3 windDir; // 0x3C
	public float3 distanceRate; // 0x48
	public NestedNativeArray<SpringBoneProperties> nestedProperties; // 0x58
	public NestedNativeArray<SpringBoneComponents> nestedComponents; // 0x68
	public NestedNativeArray<float4x4> nestedParentComponents; // 0x78
	public NestedNativeArray<float4x4> nestedPivotComponents; // 0x88
	public NestedNativeArray<SpringColliderProperties> nestedColliderProperties; // 0x98
	public NestedNativeArray<SpringColliderComponents> nestedColliderComponents; // 0xA8
	public NestedNativeArray<float3> nestedLengthLimitTargets; // 0xB8

	// Methods

	// RVA: 0x311E110 Offset: 0x311E211 VA: 0x311E110
	public void Execute(NativeArray<SpringForceComponent> forces, int forceCount) { }

	// RVA: 0x311EA10 Offset: 0x311EB11 VA: 0x311EA10
	private void UpdateSpring(ref SpringBoneComponents bone, in SpringBoneProperties prop, quaternion baseWorldRotation, float3 externalForce) { }

	// RVA: 0x311ED00 Offset: 0x311EE01 VA: 0x311ED00
	private void ResolveCollisionsAndConstraints(ref SpringBoneComponents bone, in SpringBoneProperties prop, int index, NestedNativeArray<SpringBoneComponents> boneComponents) { }

	// RVA: 0x311F390 Offset: 0x311F491 VA: 0x311F390
	private void ApplyLengthLimits(ref SpringBoneComponents bone, in SpringBoneProperties prop, NestedNativeArray<SpringBoneComponents> boneComponents) { }

	// RVA: 0x311FE10 Offset: 0x311FF11 VA: 0x311FE10
	private bool ResolveGroundCollision(ref SpringBoneComponents bone, in SpringBoneProperties prop) { }

	// RVA: 0x311FF60 Offset: 0x3120061 VA: 0x311FF60
	private static float3 FixBoneLength(ref SpringBoneComponents bone, in SpringBoneProperties prop, in float3 tailPosition) { }

	// RVA: 0x311F670 Offset: 0x311F771 VA: 0x311F670
	private bool ResolveCollisions(ref SpringBoneComponents bone, in SpringBoneProperties prop) { }

	// RVA: 0x311FC20 Offset: 0x311FD21 VA: 0x311FC20
	private void ApplyAngleLimits(ref SpringBoneComponents bone, in SpringBoneProperties prop, in float4x4 pivotLocalToWorld) { }

	// RVA: 0x311F0C0 Offset: 0x311F1C1 VA: 0x311F0C0
	private void UpdateRotation(ref SpringBoneComponents bone, in SpringBoneProperties prop, quaternion baseWorldRotation) { }

	// RVA: 0x3120350 Offset: 0x3120451 VA: 0x3120350
	public static quaternion FromToRotation(float3 from, float3 to) { }

	// RVA: 0x3120130 Offset: 0x3120231 VA: 0x3120130
	private static quaternion ComputeLocalRotation(in quaternion baseWorldRotation, ref SpringBoneComponents bone, in SpringBoneProperties prop) { }

	// RVA: 0x3120720 Offset: 0x3120821 VA: 0x3120720
	private float3 ApplyWindForce(in float3 pos, float time) { }

	// RVA: 0x311E870 Offset: 0x311E971 VA: 0x311E870
	private float3 GetTotalForceOnBone(in SpringBoneComponents bone, in SpringBoneProperties prop, NativeArray<SpringForceComponent> forces, int forceCount) { }

	// RVA: 0x3120840 Offset: 0x3120941 VA: 0x3120840
	private static float3 ComputeForceOnBone(in SpringForceComponent force, in SpringBoneComponents bone, float boneWindInfluence) { }
}

