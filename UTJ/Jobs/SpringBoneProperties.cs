// Namespace: UTJ.Jobs
[Serializable]
public struct SpringBoneProperties // TypeDefIndex: 6447
{
	// Fields
	public float stiffnessForce; // 0x0
	public float dragForce; // 0x4
	public float3 springForce; // 0x8
	public float windInfluence; // 0x14
	public float angularStiffness; // 0x18
	public AngleLimitComponent yAngleLimits; // 0x1C
	public AngleLimitComponent zAngleLimits; // 0x28
	public float radius; // 0x34
	public float springLength; // 0x38
	public float3 boneAxis; // 0x3C
	public float3 localPosition; // 0x48
	public quaternion initialLocalRotation; // 0x54
	public int parentIndex; // 0x64
	public int pivotIndex; // 0x68
	public float4x4 pivotLocalMatrix; // 0x6C
	public NestedNativeArray<int> collisionNumbers; // 0xB0
	public NestedNativeArray<LengthLimitProperties> lengthLimitProps; // 0xC0
}

