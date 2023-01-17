// Namespace: Unity.Collections.LowLevel.Unsafe
[NativeHeaderAttribute] // RVA: 0x43B7C0 Offset: 0x43B8C1 VA: 0x43B7C0
[StaticAccessorAttribute] // RVA: 0x43B7C0 Offset: 0x43B8C1 VA: 0x43B7C0
public static class UnsafeUtility // TypeDefIndex: 3386
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool IsBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2030C50 Offset: 0x2030D51 VA: 0x2030C50
	|-UnsafeUtility.IsBlittable<int>
	*/

	[ThreadSafeAttribute] // RVA: 0x445B30 Offset: 0x445C31 VA: 0x445B30
	// RVA: 0x384D040 Offset: 0x384D141 VA: 0x384D040
	public static void* Malloc(long size, int alignment, Allocator allocator) { }

	[ThreadSafeAttribute] // RVA: 0x445B70 Offset: 0x445C71 VA: 0x445B70
	// RVA: 0x384D0A0 Offset: 0x384D1A1 VA: 0x384D0A0
	public static void Free(void* memory, Allocator allocator) { }

	[ThreadSafeAttribute] // RVA: 0x445BB0 Offset: 0x445CB1 VA: 0x445BB0
	// RVA: 0x384D0F0 Offset: 0x384D1F1 VA: 0x384D0F0
	public static void MemCpy(void* destination, void* source, long size) { }

	[ThreadSafeAttribute] // RVA: 0x445BF0 Offset: 0x445CF1 VA: 0x445BF0
	// RVA: 0x384D150 Offset: 0x384D251 VA: 0x384D150
	public static void MemSet(void* destination, byte value, long size) { }

	// RVA: 0x384D1B0 Offset: 0x384D2B1 VA: 0x384D1B0
	public static void MemClear(void* destination, long size) { }

	[ThreadSafeAttribute] // RVA: 0x445C30 Offset: 0x445D31 VA: 0x445C30
	// RVA: 0x384D210 Offset: 0x384D311 VA: 0x384D210
	public static int SizeOf(Type type) { }

	[ThreadSafeAttribute] // RVA: 0x445C40 Offset: 0x445D41 VA: 0x445C40
	// RVA: 0x384D260 Offset: 0x384D361 VA: 0x384D260
	public static bool IsBlittable(Type type) { }

	// RVA: 0x384D2B0 Offset: 0x384D3B1 VA: 0x384D2B0
	private static bool IsBlittableValueType(Type t) { }

	// RVA: 0x384D320 Offset: 0x384D421 VA: 0x384D320
	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	// RVA: 0x384D540 Offset: 0x384D641 VA: 0x384D540
	internal static bool IsArrayBlittable(Array arr) { }

	// RVA: -1 Offset: -1
	internal static bool IsGenericListBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2030CD0 Offset: 0x2030DD1 VA: 0x2030CD0
	|-UnsafeUtility.IsGenericListBlittable<int>
	*/

	// RVA: 0x384D5D0 Offset: 0x384D6D1 VA: 0x384D5D0
	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	// RVA: -1 Offset: -1
	internal static string GetReasonForGenericListNonBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2030B60 Offset: 0x2030C61 VA: 0x2030B60
	|-UnsafeUtility.GetReasonForGenericListNonBlittable<int>
	*/

	// RVA: -1 Offset: -1
	public static int AlignOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2030070 Offset: 0x2030171 VA: 0x2030070
	|-UnsafeUtility.AlignOf<BatchVisibility>
	|
	|-RVA: 0x20300C0 Offset: 0x20301C1 VA: 0x20300C0
	|-UnsafeUtility.AlignOf<BoneWeight1>
	|
	|-RVA: 0x2030110 Offset: 0x2030211 VA: 0x2030110
	|-UnsafeUtility.AlignOf<byte>
	|
	|-RVA: 0x2030160 Offset: 0x2030261 VA: 0x2030160
	|-UnsafeUtility.AlignOf<int>
	|
	|-RVA: 0x20301B0 Offset: 0x20302B1 VA: 0x20301B0
	|-UnsafeUtility.AlignOf<Int32Enum>
	|
	|-RVA: 0x2030200 Offset: 0x2030301 VA: 0x2030200
	|-UnsafeUtility.AlignOf<IntPtr>
	|
	|-RVA: 0x2030250 Offset: 0x2030351 VA: 0x2030250
	|-UnsafeUtility.AlignOf<JobHandle>
	|
	|-RVA: 0x20302A0 Offset: 0x20303A1 VA: 0x20302A0
	|-UnsafeUtility.AlignOf<LengthLimitProperties>
	|
	|-RVA: 0x20302F0 Offset: 0x20303F1 VA: 0x20302F0
	|-UnsafeUtility.AlignOf<LightDataGI>
	|
	|-RVA: 0x2030340 Offset: 0x2030441 VA: 0x2030340
	|-UnsafeUtility.AlignOf<Plane>
	|
	|-RVA: 0x2030390 Offset: 0x2030491 VA: 0x2030390
	|-UnsafeUtility.AlignOf<PreTile>
	|
	|-RVA: 0x20303E0 Offset: 0x20304E1 VA: 0x20303E0
	|-UnsafeUtility.AlignOf<RenderStateBlock>
	|
	|-RVA: 0x2030430 Offset: 0x2030531 VA: 0x2030430
	|-UnsafeUtility.AlignOf<ShaderTagId>
	|
	|-RVA: 0x2030480 Offset: 0x2030581 VA: 0x2030480
	|-UnsafeUtility.AlignOf<SpringBoneComponents>
	|
	|-RVA: 0x20304D0 Offset: 0x20305D1 VA: 0x20304D0
	|-UnsafeUtility.AlignOf<SpringBoneProperties>
	|
	|-RVA: 0x2030520 Offset: 0x2030621 VA: 0x2030520
	|-UnsafeUtility.AlignOf<SpringColliderComponents>
	|
	|-RVA: 0x2030570 Offset: 0x2030671 VA: 0x2030570
	|-UnsafeUtility.AlignOf<SpringColliderProperties>
	|
	|-RVA: 0x20305C0 Offset: 0x20306C1 VA: 0x20305C0
	|-UnsafeUtility.AlignOf<SpringForceComponent>
	|
	|-RVA: 0x2030610 Offset: 0x2030711 VA: 0x2030610
	|-UnsafeUtility.AlignOf<SpringJobElement>
	|
	|-RVA: 0x2030660 Offset: 0x2030761 VA: 0x2030660
	|-UnsafeUtility.AlignOf<ushort>
	|
	|-RVA: 0x20306B0 Offset: 0x20307B1 VA: 0x20306B0
	|-UnsafeUtility.AlignOf<uint>
	|
	|-RVA: 0x2030700 Offset: 0x2030801 VA: 0x2030700
	|-UnsafeUtility.AlignOf<Vector2>
	|
	|-RVA: 0x2030750 Offset: 0x2030851 VA: 0x2030750
	|-UnsafeUtility.AlignOf<Vector3>
	|
	|-RVA: 0x20307A0 Offset: 0x20308A1 VA: 0x20307A0
	|-UnsafeUtility.AlignOf<VertexAttributeDescriptor>
	|
	|-RVA: 0x20307F0 Offset: 0x20308F1 VA: 0x20307F0
	|-UnsafeUtility.AlignOf<VisibleLight>
	|
	|-RVA: 0x2030840 Offset: 0x2030941 VA: 0x2030840
	|-UnsafeUtility.AlignOf<float3>
	|
	|-RVA: 0x2030890 Offset: 0x2030991 VA: 0x2030890
	|-UnsafeUtility.AlignOf<float4x4>
	|
	|-RVA: 0x20308E0 Offset: 0x20309E1 VA: 0x20308E0
	|-UnsafeUtility.AlignOf<uint4>
	|
	|-RVA: 0x2030930 Offset: 0x2030A31 VA: 0x2030930
	|-UnsafeUtility.AlignOf<DeferredTiler.PrePunctualLight>
	|
	|-RVA: 0x2030980 Offset: 0x2030A81 VA: 0x2030980
	|-UnsafeUtility.AlignOf<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x20309D0 Offset: 0x2030AD1 VA: 0x20309D0
	|-UnsafeUtility.AlignOf<LightUtility.SpriteLightMeshVertex>
	|
	|-RVA: 0x2030A20 Offset: 0x2030B21 VA: 0x2030A20
	|-UnsafeUtility.AlignOf<ParticleSystem.Particle>
	|
	|-RVA: 0x2030A70 Offset: 0x2030B71 VA: 0x2030A70
	|-UnsafeUtility.AlignOf<ShaderInput.LightData>
	|
	|-RVA: 0x2030AC0 Offset: 0x2030BC1 VA: 0x2030AC0
	|-UnsafeUtility.AlignOf<ShaderInput.ShadowData>
	*/

	// RVA: -1 Offset: -1
	public static void CopyPtrToStructure<T>(void* ptr, out T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2030B10 Offset: 0x2030C11 VA: 0x2030B10
	|-UnsafeUtility.CopyPtrToStructure<IJobParallelForTransformExtensions.TransformParallelForLoopStruct.TransformJobData<SpringBoneApplyJob>>
	|
	|-RVA: 0x2030B20 Offset: 0x2030C21 VA: 0x2030B20
	|-UnsafeUtility.CopyPtrToStructure<IJobParallelForTransformExtensions.TransformParallelForLoopStruct.TransformJobData<SpringColliderJob>>
	|
	|-RVA: 0x2030B30 Offset: 0x2030C31 VA: 0x2030B30
	|-UnsafeUtility.CopyPtrToStructure<IJobParallelForTransformExtensions.TransformParallelForLoopStruct.TransformJobData<SpringLengthTargetJob>>
	|
	|-RVA: 0x2030B40 Offset: 0x2030C41 VA: 0x2030B40
	|-UnsafeUtility.CopyPtrToStructure<IJobParallelForTransformExtensions.TransformParallelForLoopStruct.TransformJobData<SpringParentJob>>
	|
	|-RVA: 0x2030B50 Offset: 0x2030C51 VA: 0x2030B50
	|-UnsafeUtility.CopyPtrToStructure<IJobParallelForTransformExtensions.TransformParallelForLoopStruct.TransformJobData<SpringPivotJob>>
	*/

	// RVA: -1 Offset: -1
	private static void InternalCopyPtrToStructure<T>(void* ptr, out T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2030C00 Offset: 0x2030D01 VA: 0x2030C00
	|-UnsafeUtility.InternalCopyPtrToStructure<IJobParallelForTransformExtensions.TransformParallelForLoopStruct.TransformJobData<SpringBoneApplyJob>>
	|
	|-RVA: 0x2030C10 Offset: 0x2030D11 VA: 0x2030C10
	|-UnsafeUtility.InternalCopyPtrToStructure<IJobParallelForTransformExtensions.TransformParallelForLoopStruct.TransformJobData<SpringColliderJob>>
	|
	|-RVA: 0x2030C20 Offset: 0x2030D21 VA: 0x2030C20
	|-UnsafeUtility.InternalCopyPtrToStructure<IJobParallelForTransformExtensions.TransformParallelForLoopStruct.TransformJobData<SpringLengthTargetJob>>
	|
	|-RVA: 0x2030C30 Offset: 0x2030D31 VA: 0x2030C30
	|-UnsafeUtility.InternalCopyPtrToStructure<IJobParallelForTransformExtensions.TransformParallelForLoopStruct.TransformJobData<SpringParentJob>>
	|
	|-RVA: 0x2030C40 Offset: 0x2030D41 VA: 0x2030C40
	|-UnsafeUtility.InternalCopyPtrToStructure<IJobParallelForTransformExtensions.TransformParallelForLoopStruct.TransformJobData<SpringPivotJob>>
	*/

	// RVA: -1 Offset: -1
	public static T ReadArrayElement<T>(void* source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2030CE0 Offset: 0x2030DE1 VA: 0x2030CE0
	|-UnsafeUtility.ReadArrayElement<BatchVisibility>
	|
	|-RVA: 0x2030D00 Offset: 0x2030E01 VA: 0x2030D00
	|-UnsafeUtility.ReadArrayElement<BoneWeight1>
	|
	|-RVA: 0x2030D10 Offset: 0x2030E11 VA: 0x2030D10
	|-UnsafeUtility.ReadArrayElement<byte>
	|
	|-RVA: 0x2030D20 Offset: 0x2030E21 VA: 0x2030D20
	|-UnsafeUtility.ReadArrayElement<Hash128>
	|
	|-RVA: 0x2030D30 Offset: 0x2030E31 VA: 0x2030D30
	|-UnsafeUtility.ReadArrayElement<int>
	|
	|-RVA: 0x2030D40 Offset: 0x2030E41 VA: 0x2030D40
	|-UnsafeUtility.ReadArrayElement<Int32Enum>
	|
	|-RVA: 0x2030D50 Offset: 0x2030E51 VA: 0x2030D50
	|-UnsafeUtility.ReadArrayElement<JobHandle>
	|
	|-RVA: 0x2030D60 Offset: 0x2030E61 VA: 0x2030D60
	|-UnsafeUtility.ReadArrayElement<LengthLimitProperties>
	|
	|-RVA: 0x2030D70 Offset: 0x2030E71 VA: 0x2030D70
	|-UnsafeUtility.ReadArrayElement<LightDataGI>
	|
	|-RVA: 0x2030DA0 Offset: 0x2030EA1 VA: 0x2030DA0
	|-UnsafeUtility.ReadArrayElement<object>
	|
	|-RVA: 0x2030DB0 Offset: 0x2030EB1 VA: 0x2030DB0
	|-UnsafeUtility.ReadArrayElement<Plane>
	|
	|-RVA: 0x2030DC0 Offset: 0x2030EC1 VA: 0x2030DC0
	|-UnsafeUtility.ReadArrayElement<PreTile>
	|
	|-RVA: 0x2030DF0 Offset: 0x2030EF1 VA: 0x2030DF0
	|-UnsafeUtility.ReadArrayElement<RenderStateBlock>
	|
	|-RVA: 0x2030E10 Offset: 0x2030F11 VA: 0x2030E10
	|-UnsafeUtility.ReadArrayElement<ShaderTagId>
	|
	|-RVA: 0x2030E20 Offset: 0x2030F21 VA: 0x2030E20
	|-UnsafeUtility.ReadArrayElement<SpringBoneComponents>
	|
	|-RVA: 0x2030E40 Offset: 0x2030F41 VA: 0x2030E40
	|-UnsafeUtility.ReadArrayElement<SpringBoneProperties>
	|
	|-RVA: 0x2030E60 Offset: 0x2030F61 VA: 0x2030E60
	|-UnsafeUtility.ReadArrayElement<SpringColliderComponents>
	|
	|-RVA: 0x2030E90 Offset: 0x2030F91 VA: 0x2030E90
	|-UnsafeUtility.ReadArrayElement<SpringColliderProperties>
	|
	|-RVA: 0x2030EA0 Offset: 0x2030FA1 VA: 0x2030EA0
	|-UnsafeUtility.ReadArrayElement<SpringForceComponent>
	|
	|-RVA: 0x2030ED0 Offset: 0x2030FD1 VA: 0x2030ED0
	|-UnsafeUtility.ReadArrayElement<SpringJobElement>
	|
	|-RVA: 0x2030EF0 Offset: 0x2030FF1 VA: 0x2030EF0
	|-UnsafeUtility.ReadArrayElement<ushort>
	|
	|-RVA: 0x2030F00 Offset: 0x2031001 VA: 0x2030F00
	|-UnsafeUtility.ReadArrayElement<uint>
	|
	|-RVA: 0x2030F10 Offset: 0x2031011 VA: 0x2030F10
	|-UnsafeUtility.ReadArrayElement<Vector2>
	|
	|-RVA: 0x2030F20 Offset: 0x2031021 VA: 0x2030F20
	|-UnsafeUtility.ReadArrayElement<Vector3>
	|
	|-RVA: 0x2030F40 Offset: 0x2031041 VA: 0x2030F40
	|-UnsafeUtility.ReadArrayElement<VertexAttributeDescriptor>
	|
	|-RVA: 0x2030F50 Offset: 0x2031051 VA: 0x2030F50
	|-UnsafeUtility.ReadArrayElement<VisibleLight>
	|
	|-RVA: 0x2030F70 Offset: 0x2031071 VA: 0x2030F70
	|-UnsafeUtility.ReadArrayElement<float3>
	|
	|-RVA: 0x2030F90 Offset: 0x2031091 VA: 0x2030F90
	|-UnsafeUtility.ReadArrayElement<float4x4>
	|
	|-RVA: 0x2030FC0 Offset: 0x20310C1 VA: 0x2030FC0
	|-UnsafeUtility.ReadArrayElement<uint4>
	|
	|-RVA: 0x2030FD0 Offset: 0x20310D1 VA: 0x2030FD0
	|-UnsafeUtility.ReadArrayElement<DeferredTiler.PrePunctualLight>
	|
	|-RVA: 0x2030FF0 Offset: 0x20310F1 VA: 0x2030FF0
	|-UnsafeUtility.ReadArrayElement<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x2031020 Offset: 0x2031121 VA: 0x2031020
	|-UnsafeUtility.ReadArrayElement<LightUtility.SpriteLightMeshVertex>
	|
	|-RVA: 0x2031040 Offset: 0x2031141 VA: 0x2031040
	|-UnsafeUtility.ReadArrayElement<ParticleSystem.Particle>
	|
	|-RVA: 0x2031060 Offset: 0x2031161 VA: 0x2031060
	|-UnsafeUtility.ReadArrayElement<ShaderInput.LightData>
	|
	|-RVA: 0x2031080 Offset: 0x2031181 VA: 0x2031080
	|-UnsafeUtility.ReadArrayElement<ShaderInput.ShadowData>
	*/

	// RVA: -1 Offset: -1
	public static T ReadArrayElementWithStride<T>(void* source, int index, int stride) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20310A0 Offset: 0x20311A1 VA: 0x20310A0
	|-UnsafeUtility.ReadArrayElementWithStride<object>
	|
	|-RVA: 0x20310B0 Offset: 0x20311B1 VA: 0x20310B0
	|-UnsafeUtility.ReadArrayElementWithStride<Vector2>
	|
	|-RVA: 0x20310C0 Offset: 0x20311C1 VA: 0x20310C0
	|-UnsafeUtility.ReadArrayElementWithStride<Vector3>
	*/

	// RVA: -1 Offset: -1
	public static void WriteArrayElement<T>(void* destination, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2031510 Offset: 0x2031611 VA: 0x2031510
	|-UnsafeUtility.WriteArrayElement<BatchVisibility>
	|
	|-RVA: 0x2031530 Offset: 0x2031631 VA: 0x2031530
	|-UnsafeUtility.WriteArrayElement<BoneWeight1>
	|
	|-RVA: 0x2031540 Offset: 0x2031641 VA: 0x2031540
	|-UnsafeUtility.WriteArrayElement<byte>
	|
	|-RVA: 0x2031550 Offset: 0x2031651 VA: 0x2031550
	|-UnsafeUtility.WriteArrayElement<int>
	|
	|-RVA: 0x2031560 Offset: 0x2031661 VA: 0x2031560
	|-UnsafeUtility.WriteArrayElement<Int32Enum>
	|
	|-RVA: 0x2031570 Offset: 0x2031671 VA: 0x2031570
	|-UnsafeUtility.WriteArrayElement<JobHandle>
	|
	|-RVA: 0x2031580 Offset: 0x2031681 VA: 0x2031580
	|-UnsafeUtility.WriteArrayElement<LengthLimitProperties>
	|
	|-RVA: 0x2031590 Offset: 0x2031691 VA: 0x2031590
	|-UnsafeUtility.WriteArrayElement<LightDataGI>
	|
	|-RVA: 0x20315C0 Offset: 0x20316C1 VA: 0x20315C0
	|-UnsafeUtility.WriteArrayElement<object>
	|
	|-RVA: 0x20315D0 Offset: 0x20316D1 VA: 0x20315D0
	|-UnsafeUtility.WriteArrayElement<Plane>
	|
	|-RVA: 0x20315F0 Offset: 0x20316F1 VA: 0x20315F0
	|-UnsafeUtility.WriteArrayElement<PreTile>
	|
	|-RVA: 0x2031620 Offset: 0x2031721 VA: 0x2031620
	|-UnsafeUtility.WriteArrayElement<RenderStateBlock>
	|
	|-RVA: 0x2031650 Offset: 0x2031751 VA: 0x2031650
	|-UnsafeUtility.WriteArrayElement<ShaderTagId>
	|
	|-RVA: 0x2031660 Offset: 0x2031761 VA: 0x2031660
	|-UnsafeUtility.WriteArrayElement<SpringBoneComponents>
	|
	|-RVA: 0x2031690 Offset: 0x2031791 VA: 0x2031690
	|-UnsafeUtility.WriteArrayElement<SpringBoneProperties>
	|
	|-RVA: 0x20316C0 Offset: 0x20317C1 VA: 0x20316C0
	|-UnsafeUtility.WriteArrayElement<SpringColliderComponents>
	|
	|-RVA: 0x20316F0 Offset: 0x20317F1 VA: 0x20316F0
	|-UnsafeUtility.WriteArrayElement<SpringColliderProperties>
	|
	|-RVA: 0x2031700 Offset: 0x2031801 VA: 0x2031700
	|-UnsafeUtility.WriteArrayElement<SpringForceComponent>
	|
	|-RVA: 0x2031730 Offset: 0x2031831 VA: 0x2031730
	|-UnsafeUtility.WriteArrayElement<SpringJobElement>
	|
	|-RVA: 0x2031760 Offset: 0x2031861 VA: 0x2031760
	|-UnsafeUtility.WriteArrayElement<ushort>
	|
	|-RVA: 0x2031770 Offset: 0x2031871 VA: 0x2031770
	|-UnsafeUtility.WriteArrayElement<uint>
	|
	|-RVA: 0x2031780 Offset: 0x2031881 VA: 0x2031780
	|-UnsafeUtility.WriteArrayElement<Vector2>
	|
	|-RVA: 0x2031790 Offset: 0x2031891 VA: 0x2031790
	|-UnsafeUtility.WriteArrayElement<Vector3>
	|
	|-RVA: 0x20317B0 Offset: 0x20318B1 VA: 0x20317B0
	|-UnsafeUtility.WriteArrayElement<VertexAttributeDescriptor>
	|
	|-RVA: 0x20317C0 Offset: 0x20318C1 VA: 0x20317C0
	|-UnsafeUtility.WriteArrayElement<VisibleLight>
	|
	|-RVA: 0x20317F0 Offset: 0x20318F1 VA: 0x20317F0
	|-UnsafeUtility.WriteArrayElement<float3>
	|
	|-RVA: 0x2031810 Offset: 0x2031911 VA: 0x2031810
	|-UnsafeUtility.WriteArrayElement<float4x4>
	|
	|-RVA: 0x2031840 Offset: 0x2031941 VA: 0x2031840
	|-UnsafeUtility.WriteArrayElement<uint4>
	|
	|-RVA: 0x2031850 Offset: 0x2031951 VA: 0x2031850
	|-UnsafeUtility.WriteArrayElement<DeferredTiler.PrePunctualLight>
	|
	|-RVA: 0x2031870 Offset: 0x2031971 VA: 0x2031870
	|-UnsafeUtility.WriteArrayElement<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x20318A0 Offset: 0x20319A1 VA: 0x20318A0
	|-UnsafeUtility.WriteArrayElement<LightUtility.SpriteLightMeshVertex>
	|
	|-RVA: 0x20318D0 Offset: 0x20319D1 VA: 0x20318D0
	|-UnsafeUtility.WriteArrayElement<ParticleSystem.Particle>
	|
	|-RVA: 0x2031900 Offset: 0x2031A01 VA: 0x2031900
	|-UnsafeUtility.WriteArrayElement<ShaderInput.LightData>
	|
	|-RVA: 0x2031930 Offset: 0x2031A31 VA: 0x2031930
	|-UnsafeUtility.WriteArrayElement<ShaderInput.ShadowData>
	*/

	// RVA: -1 Offset: -1
	public static void* AddressOf<T>(ref T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2030000 Offset: 0x2030101 VA: 0x2030000
	|-UnsafeUtility.AddressOf<SpringBoneApplyJob>
	|
	|-RVA: 0x2030010 Offset: 0x2030111 VA: 0x2030010
	|-UnsafeUtility.AddressOf<SpringColliderJob>
	|
	|-RVA: 0x2030020 Offset: 0x2030121 VA: 0x2030020
	|-UnsafeUtility.AddressOf<SpringJob>
	|
	|-RVA: 0x2030030 Offset: 0x2030131 VA: 0x2030030
	|-UnsafeUtility.AddressOf<SpringLengthTargetJob>
	|
	|-RVA: 0x2030040 Offset: 0x2030141 VA: 0x2030040
	|-UnsafeUtility.AddressOf<SpringParentJob>
	|
	|-RVA: 0x2030050 Offset: 0x2030151 VA: 0x2030050
	|-UnsafeUtility.AddressOf<SpringPivotJob>
	|
	|-RVA: 0x2030060 Offset: 0x2030161 VA: 0x2030060
	|-UnsafeUtility.AddressOf<DeferredLights.CullLightsJob>
	*/

	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20310D0 Offset: 0x20311D1 VA: 0x20310D0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BatchVisibility>>
	|
	|-RVA: 0x20310E0 Offset: 0x20311E1 VA: 0x20310E0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BoneWeight1>>
	|
	|-RVA: 0x20310F0 Offset: 0x20311F1 VA: 0x20310F0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<byte>>
	|
	|-RVA: 0x2031100 Offset: 0x2031201 VA: 0x2031100
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<int>>
	|
	|-RVA: 0x2031110 Offset: 0x2031211 VA: 0x2031110
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Int32Enum>>
	|
	|-RVA: 0x2031120 Offset: 0x2031221 VA: 0x2031120
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<IntPtr>>
	|
	|-RVA: 0x2031130 Offset: 0x2031231 VA: 0x2031130
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<JobHandle>>
	|
	|-RVA: 0x2031140 Offset: 0x2031241 VA: 0x2031140
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LengthLimitProperties>>
	|
	|-RVA: 0x2031150 Offset: 0x2031251 VA: 0x2031150
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LightDataGI>>
	|
	|-RVA: 0x2031160 Offset: 0x2031261 VA: 0x2031160
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Plane>>
	|
	|-RVA: 0x2031170 Offset: 0x2031271 VA: 0x2031170
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<PreTile>>
	|
	|-RVA: 0x2031180 Offset: 0x2031281 VA: 0x2031180
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<RenderStateBlock>>
	|
	|-RVA: 0x2031190 Offset: 0x2031291 VA: 0x2031190
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ShaderTagId>>
	|
	|-RVA: 0x20311A0 Offset: 0x20312A1 VA: 0x20311A0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<SpringBoneComponents>>
	|
	|-RVA: 0x20311B0 Offset: 0x20312B1 VA: 0x20311B0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<SpringBoneProperties>>
	|
	|-RVA: 0x20311C0 Offset: 0x20312C1 VA: 0x20311C0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<SpringColliderComponents>>
	|
	|-RVA: 0x20311D0 Offset: 0x20312D1 VA: 0x20311D0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<SpringColliderProperties>>
	|
	|-RVA: 0x20311E0 Offset: 0x20312E1 VA: 0x20311E0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<SpringForceComponent>>
	|
	|-RVA: 0x20311F0 Offset: 0x20312F1 VA: 0x20311F0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<SpringJobElement>>
	|
	|-RVA: 0x2031200 Offset: 0x2031301 VA: 0x2031200
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ushort>>
	|
	|-RVA: 0x2031210 Offset: 0x2031311 VA: 0x2031210
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<uint>>
	|
	|-RVA: 0x2031220 Offset: 0x2031321 VA: 0x2031220
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector2>>
	|
	|-RVA: 0x2031230 Offset: 0x2031331 VA: 0x2031230
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector3>>
	|
	|-RVA: 0x2031240 Offset: 0x2031341 VA: 0x2031240
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<VertexAttributeDescriptor>>
	|
	|-RVA: 0x2031250 Offset: 0x2031351 VA: 0x2031250
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<VisibleLight>>
	|
	|-RVA: 0x2031260 Offset: 0x2031361 VA: 0x2031260
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float3>>
	|
	|-RVA: 0x2031270 Offset: 0x2031371 VA: 0x2031270
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float4x4>>
	|
	|-RVA: 0x2031280 Offset: 0x2031381 VA: 0x2031280
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<uint4>>
	|
	|-RVA: 0x2031290 Offset: 0x2031391 VA: 0x2031290
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<DeferredTiler.PrePunctualLight>>
	|
	|-RVA: 0x20312A0 Offset: 0x20313A1 VA: 0x20312A0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LightUtility.ParametricLightMeshVertex>>
	|
	|-RVA: 0x20312B0 Offset: 0x20313B1 VA: 0x20312B0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LightUtility.SpriteLightMeshVertex>>
	|
	|-RVA: 0x20312C0 Offset: 0x20313C1 VA: 0x20312C0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ParticleSystem.Particle>>
	|
	|-RVA: 0x20312D0 Offset: 0x20313D1 VA: 0x20312D0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ShaderInput.LightData>>
	|
	|-RVA: 0x20312E0 Offset: 0x20313E1 VA: 0x20312E0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ShaderInput.ShadowData>>
	|
	|-RVA: 0x20312F0 Offset: 0x20313F1 VA: 0x20312F0
	|-UnsafeUtility.SizeOf<BatchVisibility>
	|
	|-RVA: 0x2031300 Offset: 0x2031401 VA: 0x2031300
	|-UnsafeUtility.SizeOf<BoneWeight1>
	|
	|-RVA: 0x2031310 Offset: 0x2031411 VA: 0x2031310
	|-UnsafeUtility.SizeOf<byte>
	|
	|-RVA: 0x2031320 Offset: 0x2031421 VA: 0x2031320
	|-UnsafeUtility.SizeOf<int>
	|
	|-RVA: 0x2031330 Offset: 0x2031431 VA: 0x2031330
	|-UnsafeUtility.SizeOf<Int32Enum>
	|
	|-RVA: 0x2031340 Offset: 0x2031441 VA: 0x2031340
	|-UnsafeUtility.SizeOf<IntPtr>
	|
	|-RVA: 0x2031350 Offset: 0x2031451 VA: 0x2031350
	|-UnsafeUtility.SizeOf<JobHandle>
	|
	|-RVA: 0x2031360 Offset: 0x2031461 VA: 0x2031360
	|-UnsafeUtility.SizeOf<LengthLimitProperties>
	|
	|-RVA: 0x2031370 Offset: 0x2031471 VA: 0x2031370
	|-UnsafeUtility.SizeOf<LightDataGI>
	|
	|-RVA: 0x2031380 Offset: 0x2031481 VA: 0x2031380
	|-UnsafeUtility.SizeOf<Plane>
	|
	|-RVA: 0x2031390 Offset: 0x2031491 VA: 0x2031390
	|-UnsafeUtility.SizeOf<PreTile>
	|
	|-RVA: 0x20313A0 Offset: 0x20314A1 VA: 0x20313A0
	|-UnsafeUtility.SizeOf<RenderStateBlock>
	|
	|-RVA: 0x20313B0 Offset: 0x20314B1 VA: 0x20313B0
	|-UnsafeUtility.SizeOf<ShaderTagId>
	|
	|-RVA: 0x20313C0 Offset: 0x20314C1 VA: 0x20313C0
	|-UnsafeUtility.SizeOf<SpringBoneComponents>
	|
	|-RVA: 0x20313D0 Offset: 0x20314D1 VA: 0x20313D0
	|-UnsafeUtility.SizeOf<SpringBoneProperties>
	|
	|-RVA: 0x20313E0 Offset: 0x20314E1 VA: 0x20313E0
	|-UnsafeUtility.SizeOf<SpringColliderComponents>
	|
	|-RVA: 0x20313F0 Offset: 0x20314F1 VA: 0x20313F0
	|-UnsafeUtility.SizeOf<SpringColliderProperties>
	|
	|-RVA: 0x2031400 Offset: 0x2031501 VA: 0x2031400
	|-UnsafeUtility.SizeOf<SpringForceComponent>
	|
	|-RVA: 0x2031410 Offset: 0x2031511 VA: 0x2031410
	|-UnsafeUtility.SizeOf<SpringJobElement>
	|
	|-RVA: 0x2031420 Offset: 0x2031521 VA: 0x2031420
	|-UnsafeUtility.SizeOf<ushort>
	|
	|-RVA: 0x2031430 Offset: 0x2031531 VA: 0x2031430
	|-UnsafeUtility.SizeOf<uint>
	|
	|-RVA: 0x2031440 Offset: 0x2031541 VA: 0x2031440
	|-UnsafeUtility.SizeOf<Vector2>
	|
	|-RVA: 0x2031450 Offset: 0x2031551 VA: 0x2031450
	|-UnsafeUtility.SizeOf<Vector3>
	|
	|-RVA: 0x2031460 Offset: 0x2031561 VA: 0x2031460
	|-UnsafeUtility.SizeOf<VertexAttributeDescriptor>
	|
	|-RVA: 0x2031470 Offset: 0x2031571 VA: 0x2031470
	|-UnsafeUtility.SizeOf<VisibleLight>
	|
	|-RVA: 0x2031480 Offset: 0x2031581 VA: 0x2031480
	|-UnsafeUtility.SizeOf<float3>
	|
	|-RVA: 0x2031490 Offset: 0x2031591 VA: 0x2031490
	|-UnsafeUtility.SizeOf<float4x4>
	|
	|-RVA: 0x20314A0 Offset: 0x20315A1 VA: 0x20314A0
	|-UnsafeUtility.SizeOf<uint4>
	|
	|-RVA: 0x20314B0 Offset: 0x20315B1 VA: 0x20314B0
	|-UnsafeUtility.SizeOf<DeferredTiler.PrePunctualLight>
	|
	|-RVA: 0x20314C0 Offset: 0x20315C1 VA: 0x20314C0
	|-UnsafeUtility.SizeOf<LightUtility.ParametricLightMeshVertex>
	|
	|-RVA: 0x20314D0 Offset: 0x20315D1 VA: 0x20314D0
	|-UnsafeUtility.SizeOf<LightUtility.SpriteLightMeshVertex>
	|
	|-RVA: 0x20314E0 Offset: 0x20315E1 VA: 0x20314E0
	|-UnsafeUtility.SizeOf<ParticleSystem.Particle>
	|
	|-RVA: 0x20314F0 Offset: 0x20315F1 VA: 0x20314F0
	|-UnsafeUtility.SizeOf<ShaderInput.LightData>
	|
	|-RVA: 0x2031500 Offset: 0x2031601 VA: 0x2031500
	|-UnsafeUtility.SizeOf<ShaderInput.ShadowData>
	*/
}

