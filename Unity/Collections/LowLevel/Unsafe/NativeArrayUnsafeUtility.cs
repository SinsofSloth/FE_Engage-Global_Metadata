// Namespace: Unity.Collections.LowLevel.Unsafe
[ExtensionAttribute] // RVA: 0x43B7A0 Offset: 0x43B8A1 VA: 0x43B7A0
public static class NativeArrayUnsafeUtility // TypeDefIndex: 3383
{
	// Methods

	// RVA: -1 Offset: -1
	public static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29670E0 Offset: 0x29671E1 VA: 0x29670E0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BatchVisibility>
	|
	|-RVA: 0x29670F0 Offset: 0x29671F1 VA: 0x29670F0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BoneWeight1>
	|
	|-RVA: 0x2967100 Offset: 0x2967201 VA: 0x2967100
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>
	|
	|-RVA: 0x2967110 Offset: 0x2967211 VA: 0x2967110
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>
	|
	|-RVA: 0x2967120 Offset: 0x2967221 VA: 0x2967120
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Int32Enum>
	|
	|-RVA: 0x2967130 Offset: 0x2967231 VA: 0x2967130
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<JobHandle>
	|
	|-RVA: 0x2967140 Offset: 0x2967241 VA: 0x2967140
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<LengthLimitProperties>
	|
	|-RVA: 0x2967150 Offset: 0x2967251 VA: 0x2967150
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<LightDataGI>
	|
	|-RVA: 0x2967160 Offset: 0x2967261 VA: 0x2967160
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Plane>
	|
	|-RVA: 0x2967170 Offset: 0x2967271 VA: 0x2967170
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<PreTile>
	|
	|-RVA: 0x2967180 Offset: 0x2967281 VA: 0x2967180
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<RenderStateBlock>
	|
	|-RVA: 0x2967190 Offset: 0x2967291 VA: 0x2967190
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ShaderTagId>
	|
	|-RVA: 0x29671A0 Offset: 0x29672A1 VA: 0x29671A0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<SpringBoneComponents>
	|
	|-RVA: 0x29671B0 Offset: 0x29672B1 VA: 0x29671B0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<SpringBoneProperties>
	|
	|-RVA: 0x29671C0 Offset: 0x29672C1 VA: 0x29671C0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<SpringColliderComponents>
	|
	|-RVA: 0x29671D0 Offset: 0x29672D1 VA: 0x29671D0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<SpringColliderProperties>
	|
	|-RVA: 0x29671E0 Offset: 0x29672E1 VA: 0x29671E0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<SpringForceComponent>
	|
	|-RVA: 0x29671F0 Offset: 0x29672F1 VA: 0x29671F0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<SpringJobElement>
	|
	|-RVA: 0x2967200 Offset: 0x2967301 VA: 0x2967200
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ushort>
	|
	|-RVA: 0x2967210 Offset: 0x2967311 VA: 0x2967210
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<uint>
	|
	|-RVA: 0x2967220 Offset: 0x2967321 VA: 0x2967220
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector2>
	|
	|-RVA: 0x2967230 Offset: 0x2967331 VA: 0x2967230
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector3>
	|
	|-RVA: 0x2967240 Offset: 0x2967341 VA: 0x2967240
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<VertexAttributeDescriptor>
	|
	|-RVA: 0x2967250 Offset: 0x2967351 VA: 0x2967250
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<VisibleLight>
	|
	|-RVA: 0x2967260 Offset: 0x2967361 VA: 0x2967260
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float3>
	|
	|-RVA: 0x2967270 Offset: 0x2967371 VA: 0x2967270
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float4x4>
	|
	|-RVA: 0x2967280 Offset: 0x2967381 VA: 0x2967280
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<uint4>
	|
	|-RVA: 0x2967290 Offset: 0x2967391 VA: 0x2967290
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<DeferredTiler.PrePunctualLight>
	|
	|-RVA: 0x29672A0 Offset: 0x29673A1 VA: 0x29672A0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x29672B0 Offset: 0x29673B1 VA: 0x29672B0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<LightUtility.SpriteLightMeshVertex>
	|
	|-RVA: 0x29672C0 Offset: 0x29673C1 VA: 0x29672C0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ParticleSystem.Particle>
	|
	|-RVA: 0x29672D0 Offset: 0x29673D1 VA: 0x29672D0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ShaderInput.LightData>
	|
	|-RVA: 0x29672E0 Offset: 0x29673E1 VA: 0x29672E0
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ShaderInput.ShadowData>
	*/

	[ExtensionAttribute] // RVA: 0x445AF0 Offset: 0x445BF1 VA: 0x445AF0
	// RVA: -1 Offset: -1
	public static void* GetUnsafePtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29673A0 Offset: 0x29674A1 VA: 0x29673A0
	|-NativeArrayUnsafeUtility.GetUnsafePtr<int>
	|
	|-RVA: 0x29673B0 Offset: 0x29674B1 VA: 0x29673B0
	|-NativeArrayUnsafeUtility.GetUnsafePtr<ushort>
	|
	|-RVA: 0x29673C0 Offset: 0x29674C1 VA: 0x29673C0
	|-NativeArrayUnsafeUtility.GetUnsafePtr<Vector3>
	|
	|-RVA: 0x29673D0 Offset: 0x29674D1 VA: 0x29673D0
	|-NativeArrayUnsafeUtility.GetUnsafePtr<ParticleSystem.Particle>
	*/

	[ExtensionAttribute] // RVA: 0x445B00 Offset: 0x445C01 VA: 0x445B00
	// RVA: -1 Offset: -1
	public static void* GetUnsafeReadOnlyPtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29673E0 Offset: 0x29674E1 VA: 0x29673E0
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<BoneWeight1>
	|
	|-RVA: 0x29673F0 Offset: 0x29674F1 VA: 0x29673F0
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<byte>
	|
	|-RVA: 0x2967400 Offset: 0x2967501 VA: 0x2967400
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<int>
	|
	|-RVA: 0x2967410 Offset: 0x2967511 VA: 0x2967410
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<JobHandle>
	|
	|-RVA: 0x2967420 Offset: 0x2967521 VA: 0x2967420
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<RenderStateBlock>
	|
	|-RVA: 0x2967430 Offset: 0x2967531 VA: 0x2967430
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ShaderTagId>
	|
	|-RVA: 0x2967440 Offset: 0x2967541 VA: 0x2967440
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ushort>
	|
	|-RVA: 0x2967450 Offset: 0x2967551 VA: 0x2967450
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<uint>
	|
	|-RVA: 0x2967460 Offset: 0x2967561 VA: 0x2967460
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<Vector3>
	|
	|-RVA: 0x2967470 Offset: 0x2967571 VA: 0x2967470
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<VertexAttributeDescriptor>
	|
	|-RVA: 0x2967480 Offset: 0x2967581 VA: 0x2967480
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<uint4>
	|
	|-RVA: 0x2967490 Offset: 0x2967591 VA: 0x2967490
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x29674A0 Offset: 0x29675A1 VA: 0x29674A0
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<LightUtility.SpriteLightMeshVertex>
	|
	|-RVA: 0x29674B0 Offset: 0x29675B1 VA: 0x29674B0
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ParticleSystem.Particle>
	|
	|-RVA: 0x29674C0 Offset: 0x29675C1 VA: 0x29674C0
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ShaderInput.LightData>
	|
	|-RVA: 0x29674D0 Offset: 0x29675D1 VA: 0x29674D0
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ShaderInput.ShadowData>
	*/

	// RVA: -1 Offset: -1
	public static void* GetUnsafeBufferPointerWithoutChecks<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29672F0 Offset: 0x29673F1 VA: 0x29672F0
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<int>
	|
	|-RVA: 0x2967300 Offset: 0x2967401 VA: 0x2967300
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<LengthLimitProperties>
	|
	|-RVA: 0x2967310 Offset: 0x2967411 VA: 0x2967310
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<SpringBoneComponents>
	|
	|-RVA: 0x2967320 Offset: 0x2967421 VA: 0x2967320
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<SpringBoneProperties>
	|
	|-RVA: 0x2967330 Offset: 0x2967431 VA: 0x2967330
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<SpringColliderComponents>
	|
	|-RVA: 0x2967340 Offset: 0x2967441 VA: 0x2967340
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<SpringColliderProperties>
	|
	|-RVA: 0x2967350 Offset: 0x2967451 VA: 0x2967350
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<ushort>
	|
	|-RVA: 0x2967360 Offset: 0x2967461 VA: 0x2967360
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<uint>
	|
	|-RVA: 0x2967370 Offset: 0x2967471 VA: 0x2967370
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<float3>
	|
	|-RVA: 0x2967380 Offset: 0x2967481 VA: 0x2967380
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<float4x4>
	|
	|-RVA: 0x2967390 Offset: 0x2967491 VA: 0x2967390
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<DeferredTiler.PrePunctualLight>
	*/
}

