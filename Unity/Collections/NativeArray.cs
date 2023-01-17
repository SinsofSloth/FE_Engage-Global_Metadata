// Namespace: Unity.Collections
[NativeContainerAttribute] // RVA: 0x43B2C0 Offset: 0x43B3C1 VA: 0x43B2C0
[NativeContainerSupportsMinMaxWriteRestrictionAttribute] // RVA: 0x43B2C0 Offset: 0x43B3C1 VA: 0x43B2C0
[DebuggerDisplayAttribute] // RVA: 0x43B2C0 Offset: 0x43B3C1 VA: 0x43B2C0
[NativeContainerSupportsDeallocateOnJobCompletionAttribute] // RVA: 0x43B2C0 Offset: 0x43B3C1 VA: 0x43B2C0
[DefaultMemberAttribute] // RVA: 0x43B2C0 Offset: 0x43B3C1 VA: 0x43B2C0
[DebuggerTypeProxyAttribute] // RVA: 0x43B2C0 Offset: 0x43B3C1 VA: 0x43B2C0
[NativeContainerSupportsDeferredConvertListToArray] // RVA: 0x43B2C0 Offset: 0x43B3C1 VA: 0x43B2C0
public struct NativeArray<T> : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray<T>> // TypeDefIndex: 3366
{
	// Fields
	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x441F00 Offset: 0x442001 VA: 0x441F00
	internal void* m_Buffer; // 0x0
	internal int m_Length; // 0x0
	internal Allocator m_AllocatorLabel; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; set; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, Allocator allocator, NativeArrayOptions options = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949600 Offset: 0x2949701 VA: 0x2949600
	|-NativeArray<BatchVisibility>..ctor
	|
	|-RVA: 0x294A560 Offset: 0x294A661 VA: 0x294A560
	|-NativeArray<BoneWeight1>..ctor
	|
	|-RVA: 0x294B4C0 Offset: 0x294B5C1 VA: 0x294B4C0
	|-NativeArray<byte>..ctor
	|
	|-RVA: 0x294C420 Offset: 0x294C521 VA: 0x294C420
	|-NativeArray<int>..ctor
	|
	|-RVA: 0x294D380 Offset: 0x294D481 VA: 0x294D380
	|-NativeArray<Int32Enum>..ctor
	|-NativeArray<RenderPassEvent>..ctor
	|
	|-RVA: 0x294E2E0 Offset: 0x294E3E1 VA: 0x294E2E0
	|-NativeArray<JobHandle>..ctor
	|
	|-RVA: 0x294F240 Offset: 0x294F341 VA: 0x294F240
	|-NativeArray<LengthLimitProperties>..ctor
	|
	|-RVA: 0x29501A0 Offset: 0x29502A1 VA: 0x29501A0
	|-NativeArray<LightDataGI>..ctor
	|
	|-RVA: 0x29511D0 Offset: 0x29512D1 VA: 0x29511D0
	|-NativeArray<Plane>..ctor
	|
	|-RVA: 0x2952150 Offset: 0x2952251 VA: 0x2952150
	|-NativeArray<PreTile>..ctor
	|
	|-RVA: 0x2953130 Offset: 0x2953231 VA: 0x2953130
	|-NativeArray<RenderStateBlock>..ctor
	|
	|-RVA: 0x29541B0 Offset: 0x29542B1 VA: 0x29541B0
	|-NativeArray<ShaderTagId>..ctor
	|
	|-RVA: 0x2955110 Offset: 0x2955211 VA: 0x2955110
	|-NativeArray<SpringBoneComponents>..ctor
	|
	|-RVA: 0x2956130 Offset: 0x2956231 VA: 0x2956130
	|-NativeArray<SpringBoneProperties>..ctor
	|
	|-RVA: 0x2957110 Offset: 0x2957211 VA: 0x2957110
	|-NativeArray<SpringColliderComponents>..ctor
	|
	|-RVA: 0x318EDA0 Offset: 0x318EEA1 VA: 0x318EDA0
	|-NativeArray<SpringColliderProperties>..ctor
	|
	|-RVA: 0x318FD00 Offset: 0x318FE01 VA: 0x318FD00
	|-NativeArray<SpringForceComponent>..ctor
	|
	|-RVA: 0x3190CE0 Offset: 0x3190DE1 VA: 0x3190CE0
	|-NativeArray<SpringJobElement>..ctor
	|
	|-RVA: 0x3191CC0 Offset: 0x3191DC1 VA: 0x3191CC0
	|-NativeArray<ushort>..ctor
	|
	|-RVA: 0x3192C20 Offset: 0x3192D21 VA: 0x3192C20
	|-NativeArray<uint>..ctor
	|
	|-RVA: 0x3193B80 Offset: 0x3193C81 VA: 0x3193B80
	|-NativeArray<Vector2>..ctor
	|
	|-RVA: 0x3194AE0 Offset: 0x3194BE1 VA: 0x3194AE0
	|-NativeArray<Vector3>..ctor
	|
	|-RVA: 0x3195A60 Offset: 0x3195B61 VA: 0x3195A60
	|-NativeArray<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x31969C0 Offset: 0x3196AC1 VA: 0x31969C0
	|-NativeArray<VisibleLight>..ctor
	|
	|-RVA: 0x3197A50 Offset: 0x3197B51 VA: 0x3197A50
	|-NativeArray<float3>..ctor
	|
	|-RVA: 0x31989D0 Offset: 0x3198AD1 VA: 0x31989D0
	|-NativeArray<float4x4>..ctor
	|
	|-RVA: 0x31999B0 Offset: 0x3199AB1 VA: 0x31999B0
	|-NativeArray<uint4>..ctor
	|
	|-RVA: 0x319A910 Offset: 0x319AA11 VA: 0x319A910
	|-NativeArray<DeferredTiler.PrePunctualLight>..ctor
	|
	|-RVA: 0x319B8A0 Offset: 0x319B9A1 VA: 0x319B8A0
	|-NativeArray<LightUtility.ParametricLightMeshVertex>..ctor
	|
	|-RVA: 0x319C850 Offset: 0x319C951 VA: 0x319C850
	|-NativeArray<LightUtility.SpriteLightMeshVertex>..ctor
	|
	|-RVA: 0x319D810 Offset: 0x319D911 VA: 0x319D810
	|-NativeArray<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x319E7E0 Offset: 0x319E8E1 VA: 0x319E7E0
	|-NativeArray<ShaderInput.LightData>..ctor
	|
	|-RVA: 0x319F7F0 Offset: 0x319F8F1 VA: 0x319F7F0
	|-NativeArray<ShaderInput.ShadowData>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949710 Offset: 0x2949811 VA: 0x2949710
	|-NativeArray<BatchVisibility>..ctor
	|
	|-RVA: 0x294A670 Offset: 0x294A771 VA: 0x294A670
	|-NativeArray<BoneWeight1>..ctor
	|
	|-RVA: 0x294B5D0 Offset: 0x294B6D1 VA: 0x294B5D0
	|-NativeArray<byte>..ctor
	|
	|-RVA: 0x294C530 Offset: 0x294C631 VA: 0x294C530
	|-NativeArray<int>..ctor
	|
	|-RVA: 0x294D490 Offset: 0x294D591 VA: 0x294D490
	|-NativeArray<Int32Enum>..ctor
	|
	|-RVA: 0x294E3F0 Offset: 0x294E4F1 VA: 0x294E3F0
	|-NativeArray<JobHandle>..ctor
	|
	|-RVA: 0x294F350 Offset: 0x294F451 VA: 0x294F350
	|-NativeArray<LengthLimitProperties>..ctor
	|
	|-RVA: 0x29502B0 Offset: 0x29503B1 VA: 0x29502B0
	|-NativeArray<LightDataGI>..ctor
	|
	|-RVA: 0x29512E0 Offset: 0x29513E1 VA: 0x29512E0
	|-NativeArray<Plane>..ctor
	|
	|-RVA: 0x2952260 Offset: 0x2952361 VA: 0x2952260
	|-NativeArray<PreTile>..ctor
	|
	|-RVA: 0x2953240 Offset: 0x2953341 VA: 0x2953240
	|-NativeArray<RenderStateBlock>..ctor
	|
	|-RVA: 0x29542C0 Offset: 0x29543C1 VA: 0x29542C0
	|-NativeArray<ShaderTagId>..ctor
	|
	|-RVA: 0x2955220 Offset: 0x2955321 VA: 0x2955220
	|-NativeArray<SpringBoneComponents>..ctor
	|
	|-RVA: 0x2956240 Offset: 0x2956341 VA: 0x2956240
	|-NativeArray<SpringBoneProperties>..ctor
	|
	|-RVA: 0x2957220 Offset: 0x2957321 VA: 0x2957220
	|-NativeArray<SpringColliderComponents>..ctor
	|
	|-RVA: 0x318EEB0 Offset: 0x318EFB1 VA: 0x318EEB0
	|-NativeArray<SpringColliderProperties>..ctor
	|
	|-RVA: 0x318FE10 Offset: 0x318FF11 VA: 0x318FE10
	|-NativeArray<SpringForceComponent>..ctor
	|
	|-RVA: 0x3190DF0 Offset: 0x3190EF1 VA: 0x3190DF0
	|-NativeArray<SpringJobElement>..ctor
	|
	|-RVA: 0x3191DD0 Offset: 0x3191ED1 VA: 0x3191DD0
	|-NativeArray<ushort>..ctor
	|
	|-RVA: 0x3192D30 Offset: 0x3192E31 VA: 0x3192D30
	|-NativeArray<uint>..ctor
	|
	|-RVA: 0x3193C90 Offset: 0x3193D91 VA: 0x3193C90
	|-NativeArray<Vector2>..ctor
	|
	|-RVA: 0x3194BF0 Offset: 0x3194CF1 VA: 0x3194BF0
	|-NativeArray<Vector3>..ctor
	|
	|-RVA: 0x3195B70 Offset: 0x3195C71 VA: 0x3195B70
	|-NativeArray<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x3196AD0 Offset: 0x3196BD1 VA: 0x3196AD0
	|-NativeArray<VisibleLight>..ctor
	|
	|-RVA: 0x3197B60 Offset: 0x3197C61 VA: 0x3197B60
	|-NativeArray<float3>..ctor
	|
	|-RVA: 0x3198AE0 Offset: 0x3198BE1 VA: 0x3198AE0
	|-NativeArray<float4x4>..ctor
	|
	|-RVA: 0x3199AC0 Offset: 0x3199BC1 VA: 0x3199AC0
	|-NativeArray<uint4>..ctor
	|
	|-RVA: 0x319AA20 Offset: 0x319AB21 VA: 0x319AA20
	|-NativeArray<DeferredTiler.PrePunctualLight>..ctor
	|
	|-RVA: 0x319B9B0 Offset: 0x319BAB1 VA: 0x319B9B0
	|-NativeArray<LightUtility.ParametricLightMeshVertex>..ctor
	|
	|-RVA: 0x319C960 Offset: 0x319CA61 VA: 0x319C960
	|-NativeArray<LightUtility.SpriteLightMeshVertex>..ctor
	|
	|-RVA: 0x319D920 Offset: 0x319DA21 VA: 0x319D920
	|-NativeArray<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x319E8F0 Offset: 0x319E9F1 VA: 0x319E8F0
	|-NativeArray<ShaderInput.LightData>..ctor
	|
	|-RVA: 0x319F900 Offset: 0x319FA01 VA: 0x319F900
	|-NativeArray<ShaderInput.ShadowData>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void Allocate(int length, Allocator allocator, out NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949800 Offset: 0x2949901 VA: 0x2949800
	|-NativeArray<BatchVisibility>.Allocate
	|
	|-RVA: 0x294A760 Offset: 0x294A861 VA: 0x294A760
	|-NativeArray<BoneWeight1>.Allocate
	|
	|-RVA: 0x294B6C0 Offset: 0x294B7C1 VA: 0x294B6C0
	|-NativeArray<byte>.Allocate
	|
	|-RVA: 0x294C620 Offset: 0x294C721 VA: 0x294C620
	|-NativeArray<int>.Allocate
	|
	|-RVA: 0x294D580 Offset: 0x294D681 VA: 0x294D580
	|-NativeArray<Int32Enum>.Allocate
	|
	|-RVA: 0x294E4E0 Offset: 0x294E5E1 VA: 0x294E4E0
	|-NativeArray<JobHandle>.Allocate
	|
	|-RVA: 0x294F440 Offset: 0x294F541 VA: 0x294F440
	|-NativeArray<LengthLimitProperties>.Allocate
	|
	|-RVA: 0x29503A0 Offset: 0x29504A1 VA: 0x29503A0
	|-NativeArray<LightDataGI>.Allocate
	|
	|-RVA: 0x29513D0 Offset: 0x29514D1 VA: 0x29513D0
	|-NativeArray<Plane>.Allocate
	|
	|-RVA: 0x2952350 Offset: 0x2952451 VA: 0x2952350
	|-NativeArray<PreTile>.Allocate
	|
	|-RVA: 0x2953330 Offset: 0x2953431 VA: 0x2953330
	|-NativeArray<RenderStateBlock>.Allocate
	|
	|-RVA: 0x29543B0 Offset: 0x29544B1 VA: 0x29543B0
	|-NativeArray<ShaderTagId>.Allocate
	|
	|-RVA: 0x2955310 Offset: 0x2955411 VA: 0x2955310
	|-NativeArray<SpringBoneComponents>.Allocate
	|
	|-RVA: 0x2956330 Offset: 0x2956431 VA: 0x2956330
	|-NativeArray<SpringBoneProperties>.Allocate
	|
	|-RVA: 0x2957310 Offset: 0x2957411 VA: 0x2957310
	|-NativeArray<SpringColliderComponents>.Allocate
	|
	|-RVA: 0x318EFA0 Offset: 0x318F0A1 VA: 0x318EFA0
	|-NativeArray<SpringColliderProperties>.Allocate
	|
	|-RVA: 0x318FF00 Offset: 0x3190001 VA: 0x318FF00
	|-NativeArray<SpringForceComponent>.Allocate
	|
	|-RVA: 0x3190EE0 Offset: 0x3190FE1 VA: 0x3190EE0
	|-NativeArray<SpringJobElement>.Allocate
	|
	|-RVA: 0x3191EC0 Offset: 0x3191FC1 VA: 0x3191EC0
	|-NativeArray<ushort>.Allocate
	|
	|-RVA: 0x3192E20 Offset: 0x3192F21 VA: 0x3192E20
	|-NativeArray<uint>.Allocate
	|
	|-RVA: 0x3193D80 Offset: 0x3193E81 VA: 0x3193D80
	|-NativeArray<Vector2>.Allocate
	|
	|-RVA: 0x3194CE0 Offset: 0x3194DE1 VA: 0x3194CE0
	|-NativeArray<Vector3>.Allocate
	|
	|-RVA: 0x3195C60 Offset: 0x3195D61 VA: 0x3195C60
	|-NativeArray<VertexAttributeDescriptor>.Allocate
	|
	|-RVA: 0x3196BC0 Offset: 0x3196CC1 VA: 0x3196BC0
	|-NativeArray<VisibleLight>.Allocate
	|
	|-RVA: 0x3197C50 Offset: 0x3197D51 VA: 0x3197C50
	|-NativeArray<float3>.Allocate
	|
	|-RVA: 0x3198BD0 Offset: 0x3198CD1 VA: 0x3198BD0
	|-NativeArray<float4x4>.Allocate
	|
	|-RVA: 0x3199BB0 Offset: 0x3199CB1 VA: 0x3199BB0
	|-NativeArray<uint4>.Allocate
	|
	|-RVA: 0x319AB10 Offset: 0x319AC11 VA: 0x319AB10
	|-NativeArray<DeferredTiler.PrePunctualLight>.Allocate
	|
	|-RVA: 0x319BAA0 Offset: 0x319BBA1 VA: 0x319BAA0
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.Allocate
	|
	|-RVA: 0x319CA50 Offset: 0x319CB51 VA: 0x319CA50
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.Allocate
	|
	|-RVA: 0x319DA10 Offset: 0x319DB11 VA: 0x319DA10
	|-NativeArray<ParticleSystem.Particle>.Allocate
	|
	|-RVA: 0x319E9E0 Offset: 0x319EAE1 VA: 0x319E9E0
	|-NativeArray<ShaderInput.LightData>.Allocate
	|
	|-RVA: 0x319F9F0 Offset: 0x319FAF1 VA: 0x319F9F0
	|-NativeArray<ShaderInput.ShadowData>.Allocate
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29498F0 Offset: 0x29499F1 VA: 0x29498F0
	|-NativeArray<BatchVisibility>.get_Length
	|
	|-RVA: 0x294A850 Offset: 0x294A951 VA: 0x294A850
	|-NativeArray<BoneWeight1>.get_Length
	|
	|-RVA: 0x294B7B0 Offset: 0x294B8B1 VA: 0x294B7B0
	|-NativeArray<byte>.get_Length
	|
	|-RVA: 0x294C710 Offset: 0x294C811 VA: 0x294C710
	|-NativeArray<int>.get_Length
	|
	|-RVA: 0x294D670 Offset: 0x294D771 VA: 0x294D670
	|-NativeArray<Int32Enum>.get_Length
	|
	|-RVA: 0x294E5D0 Offset: 0x294E6D1 VA: 0x294E5D0
	|-NativeArray<JobHandle>.get_Length
	|
	|-RVA: 0x294F530 Offset: 0x294F631 VA: 0x294F530
	|-NativeArray<LengthLimitProperties>.get_Length
	|
	|-RVA: 0x2950490 Offset: 0x2950591 VA: 0x2950490
	|-NativeArray<LightDataGI>.get_Length
	|
	|-RVA: 0x29514C0 Offset: 0x29515C1 VA: 0x29514C0
	|-NativeArray<Plane>.get_Length
	|
	|-RVA: 0x2952440 Offset: 0x2952541 VA: 0x2952440
	|-NativeArray<PreTile>.get_Length
	|
	|-RVA: 0x2953420 Offset: 0x2953521 VA: 0x2953420
	|-NativeArray<RenderStateBlock>.get_Length
	|
	|-RVA: 0x29544A0 Offset: 0x29545A1 VA: 0x29544A0
	|-NativeArray<ShaderTagId>.get_Length
	|
	|-RVA: 0x2955400 Offset: 0x2955501 VA: 0x2955400
	|-NativeArray<SpringBoneComponents>.get_Length
	|
	|-RVA: 0x2956420 Offset: 0x2956521 VA: 0x2956420
	|-NativeArray<SpringBoneProperties>.get_Length
	|
	|-RVA: 0x2957400 Offset: 0x2957501 VA: 0x2957400
	|-NativeArray<SpringColliderComponents>.get_Length
	|
	|-RVA: 0x318F090 Offset: 0x318F191 VA: 0x318F090
	|-NativeArray<SpringColliderProperties>.get_Length
	|
	|-RVA: 0x318FFF0 Offset: 0x31900F1 VA: 0x318FFF0
	|-NativeArray<SpringForceComponent>.get_Length
	|
	|-RVA: 0x3190FD0 Offset: 0x31910D1 VA: 0x3190FD0
	|-NativeArray<SpringJobElement>.get_Length
	|
	|-RVA: 0x3191FB0 Offset: 0x31920B1 VA: 0x3191FB0
	|-NativeArray<ushort>.get_Length
	|
	|-RVA: 0x3192F10 Offset: 0x3193011 VA: 0x3192F10
	|-NativeArray<uint>.get_Length
	|
	|-RVA: 0x3193E70 Offset: 0x3193F71 VA: 0x3193E70
	|-NativeArray<Vector2>.get_Length
	|
	|-RVA: 0x3194DD0 Offset: 0x3194ED1 VA: 0x3194DD0
	|-NativeArray<Vector3>.get_Length
	|
	|-RVA: 0x3195D50 Offset: 0x3195E51 VA: 0x3195D50
	|-NativeArray<VertexAttributeDescriptor>.get_Length
	|
	|-RVA: 0x3196CB0 Offset: 0x3196DB1 VA: 0x3196CB0
	|-NativeArray<VisibleLight>.get_Length
	|
	|-RVA: 0x3197D40 Offset: 0x3197E41 VA: 0x3197D40
	|-NativeArray<float3>.get_Length
	|
	|-RVA: 0x3198CC0 Offset: 0x3198DC1 VA: 0x3198CC0
	|-NativeArray<float4x4>.get_Length
	|
	|-RVA: 0x3199CA0 Offset: 0x3199DA1 VA: 0x3199CA0
	|-NativeArray<uint4>.get_Length
	|
	|-RVA: 0x319AC00 Offset: 0x319AD01 VA: 0x319AC00
	|-NativeArray<DeferredTiler.PrePunctualLight>.get_Length
	|
	|-RVA: 0x319BB90 Offset: 0x319BC91 VA: 0x319BB90
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.get_Length
	|
	|-RVA: 0x319CB40 Offset: 0x319CC41 VA: 0x319CB40
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.get_Length
	|
	|-RVA: 0x319DB00 Offset: 0x319DC01 VA: 0x319DB00
	|-NativeArray<ParticleSystem.Particle>.get_Length
	|
	|-RVA: 0x319EAD0 Offset: 0x319EBD1 VA: 0x319EAD0
	|-NativeArray<ShaderInput.LightData>.get_Length
	|
	|-RVA: 0x319FAE0 Offset: 0x319FBE1 VA: 0x319FAE0
	|-NativeArray<ShaderInput.ShadowData>.get_Length
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949900 Offset: 0x2949A01 VA: 0x2949900
	|-NativeArray<BatchVisibility>.get_Item
	|
	|-RVA: 0x294A860 Offset: 0x294A961 VA: 0x294A860
	|-NativeArray<BoneWeight1>.get_Item
	|
	|-RVA: 0x294B7C0 Offset: 0x294B8C1 VA: 0x294B7C0
	|-NativeArray<byte>.get_Item
	|
	|-RVA: 0x294C720 Offset: 0x294C821 VA: 0x294C720
	|-NativeArray<int>.get_Item
	|
	|-RVA: 0x294D680 Offset: 0x294D781 VA: 0x294D680
	|-NativeArray<Int32Enum>.get_Item
	|
	|-RVA: 0x294E5E0 Offset: 0x294E6E1 VA: 0x294E5E0
	|-NativeArray<JobHandle>.get_Item
	|
	|-RVA: 0x294F540 Offset: 0x294F641 VA: 0x294F540
	|-NativeArray<LengthLimitProperties>.get_Item
	|
	|-RVA: 0x29504A0 Offset: 0x29505A1 VA: 0x29504A0
	|-NativeArray<LightDataGI>.get_Item
	|
	|-RVA: 0x29514D0 Offset: 0x29515D1 VA: 0x29514D0
	|-NativeArray<Plane>.get_Item
	|
	|-RVA: 0x2952450 Offset: 0x2952551 VA: 0x2952450
	|-NativeArray<PreTile>.get_Item
	|
	|-RVA: 0x2953430 Offset: 0x2953531 VA: 0x2953430
	|-NativeArray<RenderStateBlock>.get_Item
	|
	|-RVA: 0x29544B0 Offset: 0x29545B1 VA: 0x29544B0
	|-NativeArray<ShaderTagId>.get_Item
	|
	|-RVA: 0x2955410 Offset: 0x2955511 VA: 0x2955410
	|-NativeArray<SpringBoneComponents>.get_Item
	|
	|-RVA: 0x2956430 Offset: 0x2956531 VA: 0x2956430
	|-NativeArray<SpringBoneProperties>.get_Item
	|
	|-RVA: 0x2957410 Offset: 0x2957511 VA: 0x2957410
	|-NativeArray<SpringColliderComponents>.get_Item
	|
	|-RVA: 0x318F0A0 Offset: 0x318F1A1 VA: 0x318F0A0
	|-NativeArray<SpringColliderProperties>.get_Item
	|
	|-RVA: 0x3190000 Offset: 0x3190101 VA: 0x3190000
	|-NativeArray<SpringForceComponent>.get_Item
	|
	|-RVA: 0x3190FE0 Offset: 0x31910E1 VA: 0x3190FE0
	|-NativeArray<SpringJobElement>.get_Item
	|
	|-RVA: 0x3191FC0 Offset: 0x31920C1 VA: 0x3191FC0
	|-NativeArray<ushort>.get_Item
	|
	|-RVA: 0x3192F20 Offset: 0x3193021 VA: 0x3192F20
	|-NativeArray<uint>.get_Item
	|
	|-RVA: 0x3193E80 Offset: 0x3193F81 VA: 0x3193E80
	|-NativeArray<Vector2>.get_Item
	|
	|-RVA: 0x3194DE0 Offset: 0x3194EE1 VA: 0x3194DE0
	|-NativeArray<Vector3>.get_Item
	|
	|-RVA: 0x3195D60 Offset: 0x3195E61 VA: 0x3195D60
	|-NativeArray<VertexAttributeDescriptor>.get_Item
	|
	|-RVA: 0x3196CC0 Offset: 0x3196DC1 VA: 0x3196CC0
	|-NativeArray<VisibleLight>.get_Item
	|
	|-RVA: 0x3197D50 Offset: 0x3197E51 VA: 0x3197D50
	|-NativeArray<float3>.get_Item
	|
	|-RVA: 0x3198CD0 Offset: 0x3198DD1 VA: 0x3198CD0
	|-NativeArray<float4x4>.get_Item
	|
	|-RVA: 0x3199CB0 Offset: 0x3199DB1 VA: 0x3199CB0
	|-NativeArray<uint4>.get_Item
	|
	|-RVA: 0x319AC10 Offset: 0x319AD11 VA: 0x319AC10
	|-NativeArray<DeferredTiler.PrePunctualLight>.get_Item
	|
	|-RVA: 0x319BBA0 Offset: 0x319BCA1 VA: 0x319BBA0
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.get_Item
	|
	|-RVA: 0x319CB50 Offset: 0x319CC51 VA: 0x319CB50
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.get_Item
	|
	|-RVA: 0x319DB10 Offset: 0x319DC11 VA: 0x319DB10
	|-NativeArray<ParticleSystem.Particle>.get_Item
	|
	|-RVA: 0x319EAE0 Offset: 0x319EBE1 VA: 0x319EAE0
	|-NativeArray<ShaderInput.LightData>.get_Item
	|
	|-RVA: 0x319FAF0 Offset: 0x319FBF1 VA: 0x319FAF0
	|-NativeArray<ShaderInput.ShadowData>.get_Item
	*/

	[WriteAccessRequiredAttribute] // RVA: 0x445AC0 Offset: 0x445BC1 VA: 0x445AC0
	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949990 Offset: 0x2949A91 VA: 0x2949990
	|-NativeArray<BatchVisibility>.set_Item
	|
	|-RVA: 0x294A8F0 Offset: 0x294A9F1 VA: 0x294A8F0
	|-NativeArray<BoneWeight1>.set_Item
	|
	|-RVA: 0x294B850 Offset: 0x294B951 VA: 0x294B850
	|-NativeArray<byte>.set_Item
	|
	|-RVA: 0x294C7B0 Offset: 0x294C8B1 VA: 0x294C7B0
	|-NativeArray<int>.set_Item
	|
	|-RVA: 0x294D710 Offset: 0x294D811 VA: 0x294D710
	|-NativeArray<Int32Enum>.set_Item
	|
	|-RVA: 0x294E670 Offset: 0x294E771 VA: 0x294E670
	|-NativeArray<JobHandle>.set_Item
	|
	|-RVA: 0x294F5D0 Offset: 0x294F6D1 VA: 0x294F5D0
	|-NativeArray<LengthLimitProperties>.set_Item
	|
	|-RVA: 0x29505B0 Offset: 0x29506B1 VA: 0x29505B0
	|-NativeArray<LightDataGI>.set_Item
	|
	|-RVA: 0x2951560 Offset: 0x2951661 VA: 0x2951560
	|-NativeArray<Plane>.set_Item
	|
	|-RVA: 0x2952530 Offset: 0x2952631 VA: 0x2952530
	|-NativeArray<PreTile>.set_Item
	|
	|-RVA: 0x2953570 Offset: 0x2953671 VA: 0x2953570
	|-NativeArray<RenderStateBlock>.set_Item
	|
	|-RVA: 0x2954540 Offset: 0x2954641 VA: 0x2954540
	|-NativeArray<ShaderTagId>.set_Item
	|
	|-RVA: 0x2955510 Offset: 0x2955611 VA: 0x2955510
	|-NativeArray<SpringBoneComponents>.set_Item
	|
	|-RVA: 0x2956520 Offset: 0x2956621 VA: 0x2956520
	|-NativeArray<SpringBoneProperties>.set_Item
	|
	|-RVA: 0x2957550 Offset: 0x2957651 VA: 0x2957550
	|-NativeArray<SpringColliderComponents>.set_Item
	|
	|-RVA: 0x318F130 Offset: 0x318F231 VA: 0x318F130
	|-NativeArray<SpringColliderProperties>.set_Item
	|
	|-RVA: 0x31900E0 Offset: 0x31901E1 VA: 0x31900E0
	|-NativeArray<SpringForceComponent>.set_Item
	|
	|-RVA: 0x31910D0 Offset: 0x31911D1 VA: 0x31910D0
	|-NativeArray<SpringJobElement>.set_Item
	|
	|-RVA: 0x3192050 Offset: 0x3192151 VA: 0x3192050
	|-NativeArray<ushort>.set_Item
	|
	|-RVA: 0x3192FB0 Offset: 0x31930B1 VA: 0x3192FB0
	|-NativeArray<uint>.set_Item
	|
	|-RVA: 0x3193F10 Offset: 0x3194011 VA: 0x3193F10
	|-NativeArray<Vector2>.set_Item
	|
	|-RVA: 0x3194E70 Offset: 0x3194F71 VA: 0x3194E70
	|-NativeArray<Vector3>.set_Item
	|
	|-RVA: 0x3195DF0 Offset: 0x3195EF1 VA: 0x3195DF0
	|-NativeArray<VertexAttributeDescriptor>.set_Item
	|
	|-RVA: 0x3196E00 Offset: 0x3196F01 VA: 0x3196E00
	|-NativeArray<VisibleLight>.set_Item
	|
	|-RVA: 0x3197DE0 Offset: 0x3197EE1 VA: 0x3197DE0
	|-NativeArray<float3>.set_Item
	|
	|-RVA: 0x3198DB0 Offset: 0x3198EB1 VA: 0x3198DB0
	|-NativeArray<float4x4>.set_Item
	|
	|-RVA: 0x3199D40 Offset: 0x3199E41 VA: 0x3199D40
	|-NativeArray<uint4>.set_Item
	|
	|-RVA: 0x319ACC0 Offset: 0x319ADC1 VA: 0x319ACC0
	|-NativeArray<DeferredTiler.PrePunctualLight>.set_Item
	|
	|-RVA: 0x319BC60 Offset: 0x319BD61 VA: 0x319BC60
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.set_Item
	|
	|-RVA: 0x319CC10 Offset: 0x319CD11 VA: 0x319CC10
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.set_Item
	|
	|-RVA: 0x319DBF0 Offset: 0x319DCF1 VA: 0x319DBF0
	|-NativeArray<ParticleSystem.Particle>.set_Item
	|
	|-RVA: 0x319EBE0 Offset: 0x319ECE1 VA: 0x319EBE0
	|-NativeArray<ShaderInput.LightData>.set_Item
	|
	|-RVA: 0x319FBF0 Offset: 0x319FCF1 VA: 0x319FBF0
	|-NativeArray<ShaderInput.ShadowData>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949A30 Offset: 0x2949B31 VA: 0x2949A30
	|-NativeArray<BatchVisibility>.get_IsCreated
	|
	|-RVA: 0x294A990 Offset: 0x294AA91 VA: 0x294A990
	|-NativeArray<BoneWeight1>.get_IsCreated
	|
	|-RVA: 0x294B8F0 Offset: 0x294B9F1 VA: 0x294B8F0
	|-NativeArray<byte>.get_IsCreated
	|
	|-RVA: 0x294C850 Offset: 0x294C951 VA: 0x294C850
	|-NativeArray<int>.get_IsCreated
	|
	|-RVA: 0x294D7B0 Offset: 0x294D8B1 VA: 0x294D7B0
	|-NativeArray<Int32Enum>.get_IsCreated
	|
	|-RVA: 0x294E710 Offset: 0x294E811 VA: 0x294E710
	|-NativeArray<JobHandle>.get_IsCreated
	|
	|-RVA: 0x294F670 Offset: 0x294F771 VA: 0x294F670
	|-NativeArray<LengthLimitProperties>.get_IsCreated
	|
	|-RVA: 0x29506A0 Offset: 0x29507A1 VA: 0x29506A0
	|-NativeArray<LightDataGI>.get_IsCreated
	|
	|-RVA: 0x2951620 Offset: 0x2951721 VA: 0x2951620
	|-NativeArray<Plane>.get_IsCreated
	|
	|-RVA: 0x2952600 Offset: 0x2952701 VA: 0x2952600
	|-NativeArray<PreTile>.get_IsCreated
	|
	|-RVA: 0x2953680 Offset: 0x2953781 VA: 0x2953680
	|-NativeArray<RenderStateBlock>.get_IsCreated
	|
	|-RVA: 0x29545E0 Offset: 0x29546E1 VA: 0x29545E0
	|-NativeArray<ShaderTagId>.get_IsCreated
	|
	|-RVA: 0x2955600 Offset: 0x2955701 VA: 0x2955600
	|-NativeArray<SpringBoneComponents>.get_IsCreated
	|
	|-RVA: 0x29565E0 Offset: 0x29566E1 VA: 0x29565E0
	|-NativeArray<SpringBoneProperties>.get_IsCreated
	|
	|-RVA: 0x2957660 Offset: 0x2957761 VA: 0x2957660
	|-NativeArray<SpringColliderComponents>.get_IsCreated
	|
	|-RVA: 0x318F1D0 Offset: 0x318F2D1 VA: 0x318F1D0
	|-NativeArray<SpringColliderProperties>.get_IsCreated
	|
	|-RVA: 0x31901B0 Offset: 0x31902B1 VA: 0x31901B0
	|-NativeArray<SpringForceComponent>.get_IsCreated
	|
	|-RVA: 0x3191190 Offset: 0x3191291 VA: 0x3191190
	|-NativeArray<SpringJobElement>.get_IsCreated
	|
	|-RVA: 0x31920F0 Offset: 0x31921F1 VA: 0x31920F0
	|-NativeArray<ushort>.get_IsCreated
	|
	|-RVA: 0x3193050 Offset: 0x3193151 VA: 0x3193050
	|-NativeArray<uint>.get_IsCreated
	|
	|-RVA: 0x3193FB0 Offset: 0x31940B1 VA: 0x3193FB0
	|-NativeArray<Vector2>.get_IsCreated
	|
	|-RVA: 0x3194F30 Offset: 0x3195031 VA: 0x3194F30
	|-NativeArray<Vector3>.get_IsCreated
	|
	|-RVA: 0x3195E90 Offset: 0x3195F91 VA: 0x3195E90
	|-NativeArray<VertexAttributeDescriptor>.get_IsCreated
	|
	|-RVA: 0x3196F20 Offset: 0x3197021 VA: 0x3196F20
	|-NativeArray<VisibleLight>.get_IsCreated
	|
	|-RVA: 0x3197EA0 Offset: 0x3197FA1 VA: 0x3197EA0
	|-NativeArray<float3>.get_IsCreated
	|
	|-RVA: 0x3198E80 Offset: 0x3198F81 VA: 0x3198E80
	|-NativeArray<float4x4>.get_IsCreated
	|
	|-RVA: 0x3199DE0 Offset: 0x3199EE1 VA: 0x3199DE0
	|-NativeArray<uint4>.get_IsCreated
	|
	|-RVA: 0x319AD70 Offset: 0x319AE71 VA: 0x319AD70
	|-NativeArray<DeferredTiler.PrePunctualLight>.get_IsCreated
	|
	|-RVA: 0x319BD20 Offset: 0x319BE21 VA: 0x319BD20
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.get_IsCreated
	|
	|-RVA: 0x319CCE0 Offset: 0x319CDE1 VA: 0x319CCE0
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.get_IsCreated
	|
	|-RVA: 0x319DCB0 Offset: 0x319DDB1 VA: 0x319DCB0
	|-NativeArray<ParticleSystem.Particle>.get_IsCreated
	|
	|-RVA: 0x319ECC0 Offset: 0x319EDC1 VA: 0x319ECC0
	|-NativeArray<ShaderInput.LightData>.get_IsCreated
	|
	|-RVA: 0x319FCD0 Offset: 0x319FDD1 VA: 0x319FCD0
	|-NativeArray<ShaderInput.ShadowData>.get_IsCreated
	*/

	[WriteAccessRequiredAttribute] // RVA: 0x445AD0 Offset: 0x445BD1 VA: 0x445AD0
	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949A40 Offset: 0x2949B41 VA: 0x2949A40
	|-NativeArray<BatchVisibility>.Dispose
	|
	|-RVA: 0x294A9A0 Offset: 0x294AAA1 VA: 0x294A9A0
	|-NativeArray<BoneWeight1>.Dispose
	|
	|-RVA: 0x294B900 Offset: 0x294BA01 VA: 0x294B900
	|-NativeArray<byte>.Dispose
	|
	|-RVA: 0x294C860 Offset: 0x294C961 VA: 0x294C860
	|-NativeArray<int>.Dispose
	|
	|-RVA: 0x294D7C0 Offset: 0x294D8C1 VA: 0x294D7C0
	|-NativeArray<Int32Enum>.Dispose
	|-NativeArray<RenderPassEvent>.Dispose
	|
	|-RVA: 0x294E720 Offset: 0x294E821 VA: 0x294E720
	|-NativeArray<JobHandle>.Dispose
	|
	|-RVA: 0x294F680 Offset: 0x294F781 VA: 0x294F680
	|-NativeArray<LengthLimitProperties>.Dispose
	|
	|-RVA: 0x29506B0 Offset: 0x29507B1 VA: 0x29506B0
	|-NativeArray<LightDataGI>.Dispose
	|
	|-RVA: 0x2951630 Offset: 0x2951731 VA: 0x2951630
	|-NativeArray<Plane>.Dispose
	|
	|-RVA: 0x2952610 Offset: 0x2952711 VA: 0x2952610
	|-NativeArray<PreTile>.Dispose
	|
	|-RVA: 0x2953690 Offset: 0x2953791 VA: 0x2953690
	|-NativeArray<RenderStateBlock>.Dispose
	|
	|-RVA: 0x29545F0 Offset: 0x29546F1 VA: 0x29545F0
	|-NativeArray<ShaderTagId>.Dispose
	|
	|-RVA: 0x2955610 Offset: 0x2955711 VA: 0x2955610
	|-NativeArray<SpringBoneComponents>.Dispose
	|
	|-RVA: 0x29565F0 Offset: 0x29566F1 VA: 0x29565F0
	|-NativeArray<SpringBoneProperties>.Dispose
	|
	|-RVA: 0x2957670 Offset: 0x2957771 VA: 0x2957670
	|-NativeArray<SpringColliderComponents>.Dispose
	|
	|-RVA: 0x318F1E0 Offset: 0x318F2E1 VA: 0x318F1E0
	|-NativeArray<SpringColliderProperties>.Dispose
	|
	|-RVA: 0x31901C0 Offset: 0x31902C1 VA: 0x31901C0
	|-NativeArray<SpringForceComponent>.Dispose
	|
	|-RVA: 0x31911A0 Offset: 0x31912A1 VA: 0x31911A0
	|-NativeArray<SpringJobElement>.Dispose
	|
	|-RVA: 0x3192100 Offset: 0x3192201 VA: 0x3192100
	|-NativeArray<ushort>.Dispose
	|
	|-RVA: 0x3193060 Offset: 0x3193161 VA: 0x3193060
	|-NativeArray<uint>.Dispose
	|
	|-RVA: 0x3193FC0 Offset: 0x31940C1 VA: 0x3193FC0
	|-NativeArray<Vector2>.Dispose
	|
	|-RVA: 0x3194F40 Offset: 0x3195041 VA: 0x3194F40
	|-NativeArray<Vector3>.Dispose
	|
	|-RVA: 0x3195EA0 Offset: 0x3195FA1 VA: 0x3195EA0
	|-NativeArray<VertexAttributeDescriptor>.Dispose
	|
	|-RVA: 0x3196F30 Offset: 0x3197031 VA: 0x3196F30
	|-NativeArray<VisibleLight>.Dispose
	|
	|-RVA: 0x3197EB0 Offset: 0x3197FB1 VA: 0x3197EB0
	|-NativeArray<float3>.Dispose
	|
	|-RVA: 0x3198E90 Offset: 0x3198F91 VA: 0x3198E90
	|-NativeArray<float4x4>.Dispose
	|
	|-RVA: 0x3199DF0 Offset: 0x3199EF1 VA: 0x3199DF0
	|-NativeArray<uint4>.Dispose
	|
	|-RVA: 0x319AD80 Offset: 0x319AE81 VA: 0x319AD80
	|-NativeArray<DeferredTiler.PrePunctualLight>.Dispose
	|
	|-RVA: 0x319BD30 Offset: 0x319BE31 VA: 0x319BD30
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.Dispose
	|
	|-RVA: 0x319CCF0 Offset: 0x319CDF1 VA: 0x319CCF0
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.Dispose
	|
	|-RVA: 0x319DCC0 Offset: 0x319DDC1 VA: 0x319DCC0
	|-NativeArray<ParticleSystem.Particle>.Dispose
	|
	|-RVA: 0x319ECD0 Offset: 0x319EDD1 VA: 0x319ECD0
	|-NativeArray<ShaderInput.LightData>.Dispose
	|
	|-RVA: 0x319FCE0 Offset: 0x319FDE1 VA: 0x319FCE0
	|-NativeArray<ShaderInput.ShadowData>.Dispose
	*/

	[WriteAccessRequiredAttribute] // RVA: 0x445AE0 Offset: 0x445BE1 VA: 0x445AE0
	// RVA: -1 Offset: -1
	public void CopyFrom(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949B10 Offset: 0x2949C11 VA: 0x2949B10
	|-NativeArray<BatchVisibility>.CopyFrom
	|
	|-RVA: 0x294AA70 Offset: 0x294AB71 VA: 0x294AA70
	|-NativeArray<BoneWeight1>.CopyFrom
	|
	|-RVA: 0x294B9D0 Offset: 0x294BAD1 VA: 0x294B9D0
	|-NativeArray<byte>.CopyFrom
	|
	|-RVA: 0x294C930 Offset: 0x294CA31 VA: 0x294C930
	|-NativeArray<int>.CopyFrom
	|
	|-RVA: 0x294D890 Offset: 0x294D991 VA: 0x294D890
	|-NativeArray<Int32Enum>.CopyFrom
	|
	|-RVA: 0x294E7F0 Offset: 0x294E8F1 VA: 0x294E7F0
	|-NativeArray<JobHandle>.CopyFrom
	|
	|-RVA: 0x294F750 Offset: 0x294F851 VA: 0x294F750
	|-NativeArray<LengthLimitProperties>.CopyFrom
	|
	|-RVA: 0x2950780 Offset: 0x2950881 VA: 0x2950780
	|-NativeArray<LightDataGI>.CopyFrom
	|
	|-RVA: 0x2951700 Offset: 0x2951801 VA: 0x2951700
	|-NativeArray<Plane>.CopyFrom
	|
	|-RVA: 0x29526E0 Offset: 0x29527E1 VA: 0x29526E0
	|-NativeArray<PreTile>.CopyFrom
	|
	|-RVA: 0x2953760 Offset: 0x2953861 VA: 0x2953760
	|-NativeArray<RenderStateBlock>.CopyFrom
	|
	|-RVA: 0x29546C0 Offset: 0x29547C1 VA: 0x29546C0
	|-NativeArray<ShaderTagId>.CopyFrom
	|
	|-RVA: 0x29556E0 Offset: 0x29557E1 VA: 0x29556E0
	|-NativeArray<SpringBoneComponents>.CopyFrom
	|
	|-RVA: 0x29566C0 Offset: 0x29567C1 VA: 0x29566C0
	|-NativeArray<SpringBoneProperties>.CopyFrom
	|
	|-RVA: 0x2957740 Offset: 0x2957841 VA: 0x2957740
	|-NativeArray<SpringColliderComponents>.CopyFrom
	|
	|-RVA: 0x318F2B0 Offset: 0x318F3B1 VA: 0x318F2B0
	|-NativeArray<SpringColliderProperties>.CopyFrom
	|
	|-RVA: 0x3190290 Offset: 0x3190391 VA: 0x3190290
	|-NativeArray<SpringForceComponent>.CopyFrom
	|
	|-RVA: 0x3191270 Offset: 0x3191371 VA: 0x3191270
	|-NativeArray<SpringJobElement>.CopyFrom
	|
	|-RVA: 0x31921D0 Offset: 0x31922D1 VA: 0x31921D0
	|-NativeArray<ushort>.CopyFrom
	|
	|-RVA: 0x3193130 Offset: 0x3193231 VA: 0x3193130
	|-NativeArray<uint>.CopyFrom
	|
	|-RVA: 0x3194090 Offset: 0x3194191 VA: 0x3194090
	|-NativeArray<Vector2>.CopyFrom
	|
	|-RVA: 0x3195010 Offset: 0x3195111 VA: 0x3195010
	|-NativeArray<Vector3>.CopyFrom
	|
	|-RVA: 0x3195F70 Offset: 0x3196071 VA: 0x3195F70
	|-NativeArray<VertexAttributeDescriptor>.CopyFrom
	|
	|-RVA: 0x3197000 Offset: 0x3197101 VA: 0x3197000
	|-NativeArray<VisibleLight>.CopyFrom
	|
	|-RVA: 0x3197F80 Offset: 0x3198081 VA: 0x3197F80
	|-NativeArray<float3>.CopyFrom
	|
	|-RVA: 0x3198F60 Offset: 0x3199061 VA: 0x3198F60
	|-NativeArray<float4x4>.CopyFrom
	|
	|-RVA: 0x3199EC0 Offset: 0x3199FC1 VA: 0x3199EC0
	|-NativeArray<uint4>.CopyFrom
	|
	|-RVA: 0x319AE50 Offset: 0x319AF51 VA: 0x319AE50
	|-NativeArray<DeferredTiler.PrePunctualLight>.CopyFrom
	|
	|-RVA: 0x319BE00 Offset: 0x319BF01 VA: 0x319BE00
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.CopyFrom
	|
	|-RVA: 0x319CDC0 Offset: 0x319CEC1 VA: 0x319CDC0
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.CopyFrom
	|
	|-RVA: 0x319DD90 Offset: 0x319DE91 VA: 0x319DD90
	|-NativeArray<ParticleSystem.Particle>.CopyFrom
	|
	|-RVA: 0x319EDA0 Offset: 0x319EEA1 VA: 0x319EDA0
	|-NativeArray<ShaderInput.LightData>.CopyFrom
	|
	|-RVA: 0x319FDB0 Offset: 0x319FEB1 VA: 0x319FDB0
	|-NativeArray<ShaderInput.ShadowData>.CopyFrom
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949BA0 Offset: 0x2949CA1 VA: 0x2949BA0
	|-NativeArray<BatchVisibility>.ToArray
	|
	|-RVA: 0x294AB00 Offset: 0x294AC01 VA: 0x294AB00
	|-NativeArray<BoneWeight1>.ToArray
	|
	|-RVA: 0x294BA60 Offset: 0x294BB61 VA: 0x294BA60
	|-NativeArray<byte>.ToArray
	|
	|-RVA: 0x294C9C0 Offset: 0x294CAC1 VA: 0x294C9C0
	|-NativeArray<int>.ToArray
	|
	|-RVA: 0x294D920 Offset: 0x294DA21 VA: 0x294D920
	|-NativeArray<Int32Enum>.ToArray
	|
	|-RVA: 0x294E880 Offset: 0x294E981 VA: 0x294E880
	|-NativeArray<JobHandle>.ToArray
	|
	|-RVA: 0x294F7E0 Offset: 0x294F8E1 VA: 0x294F7E0
	|-NativeArray<LengthLimitProperties>.ToArray
	|
	|-RVA: 0x2950810 Offset: 0x2950911 VA: 0x2950810
	|-NativeArray<LightDataGI>.ToArray
	|
	|-RVA: 0x2951790 Offset: 0x2951891 VA: 0x2951790
	|-NativeArray<Plane>.ToArray
	|
	|-RVA: 0x2952770 Offset: 0x2952871 VA: 0x2952770
	|-NativeArray<PreTile>.ToArray
	|
	|-RVA: 0x29537F0 Offset: 0x29538F1 VA: 0x29537F0
	|-NativeArray<RenderStateBlock>.ToArray
	|
	|-RVA: 0x2954750 Offset: 0x2954851 VA: 0x2954750
	|-NativeArray<ShaderTagId>.ToArray
	|
	|-RVA: 0x2955770 Offset: 0x2955871 VA: 0x2955770
	|-NativeArray<SpringBoneComponents>.ToArray
	|
	|-RVA: 0x2956750 Offset: 0x2956851 VA: 0x2956750
	|-NativeArray<SpringBoneProperties>.ToArray
	|
	|-RVA: 0x29577D0 Offset: 0x29578D1 VA: 0x29577D0
	|-NativeArray<SpringColliderComponents>.ToArray
	|
	|-RVA: 0x318F340 Offset: 0x318F441 VA: 0x318F340
	|-NativeArray<SpringColliderProperties>.ToArray
	|
	|-RVA: 0x3190320 Offset: 0x3190421 VA: 0x3190320
	|-NativeArray<SpringForceComponent>.ToArray
	|
	|-RVA: 0x3191300 Offset: 0x3191401 VA: 0x3191300
	|-NativeArray<SpringJobElement>.ToArray
	|
	|-RVA: 0x3192260 Offset: 0x3192361 VA: 0x3192260
	|-NativeArray<ushort>.ToArray
	|
	|-RVA: 0x31931C0 Offset: 0x31932C1 VA: 0x31931C0
	|-NativeArray<uint>.ToArray
	|
	|-RVA: 0x3194120 Offset: 0x3194221 VA: 0x3194120
	|-NativeArray<Vector2>.ToArray
	|
	|-RVA: 0x31950A0 Offset: 0x31951A1 VA: 0x31950A0
	|-NativeArray<Vector3>.ToArray
	|
	|-RVA: 0x3196000 Offset: 0x3196101 VA: 0x3196000
	|-NativeArray<VertexAttributeDescriptor>.ToArray
	|
	|-RVA: 0x3197090 Offset: 0x3197191 VA: 0x3197090
	|-NativeArray<VisibleLight>.ToArray
	|
	|-RVA: 0x3198010 Offset: 0x3198111 VA: 0x3198010
	|-NativeArray<float3>.ToArray
	|
	|-RVA: 0x3198FF0 Offset: 0x31990F1 VA: 0x3198FF0
	|-NativeArray<float4x4>.ToArray
	|
	|-RVA: 0x3199F50 Offset: 0x319A051 VA: 0x3199F50
	|-NativeArray<uint4>.ToArray
	|
	|-RVA: 0x319AEE0 Offset: 0x319AFE1 VA: 0x319AEE0
	|-NativeArray<DeferredTiler.PrePunctualLight>.ToArray
	|
	|-RVA: 0x319BE90 Offset: 0x319BF91 VA: 0x319BE90
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.ToArray
	|
	|-RVA: 0x319CE50 Offset: 0x319CF51 VA: 0x319CE50
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.ToArray
	|
	|-RVA: 0x319DE20 Offset: 0x319DF21 VA: 0x319DE20
	|-NativeArray<ParticleSystem.Particle>.ToArray
	|
	|-RVA: 0x319EE30 Offset: 0x319EF31 VA: 0x319EE30
	|-NativeArray<ShaderInput.LightData>.ToArray
	|
	|-RVA: 0x319FE40 Offset: 0x319FF41 VA: 0x319FE40
	|-NativeArray<ShaderInput.ShadowData>.ToArray
	*/

	// RVA: -1 Offset: -1
	public NativeArray.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949C70 Offset: 0x2949D71 VA: 0x2949C70
	|-NativeArray<BatchVisibility>.GetEnumerator
	|
	|-RVA: 0x294ABD0 Offset: 0x294ACD1 VA: 0x294ABD0
	|-NativeArray<BoneWeight1>.GetEnumerator
	|
	|-RVA: 0x294BB30 Offset: 0x294BC31 VA: 0x294BB30
	|-NativeArray<byte>.GetEnumerator
	|
	|-RVA: 0x294CA90 Offset: 0x294CB91 VA: 0x294CA90
	|-NativeArray<int>.GetEnumerator
	|
	|-RVA: 0x294D9F0 Offset: 0x294DAF1 VA: 0x294D9F0
	|-NativeArray<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x294E950 Offset: 0x294EA51 VA: 0x294E950
	|-NativeArray<JobHandle>.GetEnumerator
	|
	|-RVA: 0x294F8B0 Offset: 0x294F9B1 VA: 0x294F8B0
	|-NativeArray<LengthLimitProperties>.GetEnumerator
	|
	|-RVA: 0x29508E0 Offset: 0x29509E1 VA: 0x29508E0
	|-NativeArray<LightDataGI>.GetEnumerator
	|
	|-RVA: 0x2951860 Offset: 0x2951961 VA: 0x2951860
	|-NativeArray<Plane>.GetEnumerator
	|
	|-RVA: 0x2952840 Offset: 0x2952941 VA: 0x2952840
	|-NativeArray<PreTile>.GetEnumerator
	|
	|-RVA: 0x29538C0 Offset: 0x29539C1 VA: 0x29538C0
	|-NativeArray<RenderStateBlock>.GetEnumerator
	|
	|-RVA: 0x2954820 Offset: 0x2954921 VA: 0x2954820
	|-NativeArray<ShaderTagId>.GetEnumerator
	|
	|-RVA: 0x2955840 Offset: 0x2955941 VA: 0x2955840
	|-NativeArray<SpringBoneComponents>.GetEnumerator
	|
	|-RVA: 0x2956820 Offset: 0x2956921 VA: 0x2956820
	|-NativeArray<SpringBoneProperties>.GetEnumerator
	|
	|-RVA: 0x29578A0 Offset: 0x29579A1 VA: 0x29578A0
	|-NativeArray<SpringColliderComponents>.GetEnumerator
	|
	|-RVA: 0x318F410 Offset: 0x318F511 VA: 0x318F410
	|-NativeArray<SpringColliderProperties>.GetEnumerator
	|
	|-RVA: 0x31903F0 Offset: 0x31904F1 VA: 0x31903F0
	|-NativeArray<SpringForceComponent>.GetEnumerator
	|
	|-RVA: 0x31913D0 Offset: 0x31914D1 VA: 0x31913D0
	|-NativeArray<SpringJobElement>.GetEnumerator
	|
	|-RVA: 0x3192330 Offset: 0x3192431 VA: 0x3192330
	|-NativeArray<ushort>.GetEnumerator
	|
	|-RVA: 0x3193290 Offset: 0x3193391 VA: 0x3193290
	|-NativeArray<uint>.GetEnumerator
	|
	|-RVA: 0x31941F0 Offset: 0x31942F1 VA: 0x31941F0
	|-NativeArray<Vector2>.GetEnumerator
	|
	|-RVA: 0x3195170 Offset: 0x3195271 VA: 0x3195170
	|-NativeArray<Vector3>.GetEnumerator
	|
	|-RVA: 0x31960D0 Offset: 0x31961D1 VA: 0x31960D0
	|-NativeArray<VertexAttributeDescriptor>.GetEnumerator
	|
	|-RVA: 0x3197160 Offset: 0x3197261 VA: 0x3197160
	|-NativeArray<VisibleLight>.GetEnumerator
	|
	|-RVA: 0x31980E0 Offset: 0x31981E1 VA: 0x31980E0
	|-NativeArray<float3>.GetEnumerator
	|
	|-RVA: 0x31990C0 Offset: 0x31991C1 VA: 0x31990C0
	|-NativeArray<float4x4>.GetEnumerator
	|
	|-RVA: 0x319A020 Offset: 0x319A121 VA: 0x319A020
	|-NativeArray<uint4>.GetEnumerator
	|
	|-RVA: 0x319AFB0 Offset: 0x319B0B1 VA: 0x319AFB0
	|-NativeArray<DeferredTiler.PrePunctualLight>.GetEnumerator
	|
	|-RVA: 0x319BF60 Offset: 0x319C061 VA: 0x319BF60
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.GetEnumerator
	|
	|-RVA: 0x319CF20 Offset: 0x319D021 VA: 0x319CF20
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.GetEnumerator
	|
	|-RVA: 0x319DEF0 Offset: 0x319DFF1 VA: 0x319DEF0
	|-NativeArray<ParticleSystem.Particle>.GetEnumerator
	|
	|-RVA: 0x319EF00 Offset: 0x319F001 VA: 0x319EF00
	|-NativeArray<ShaderInput.LightData>.GetEnumerator
	|
	|-RVA: 0x319FF10 Offset: 0x31A0011 VA: 0x319FF10
	|-NativeArray<ShaderInput.ShadowData>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949CF0 Offset: 0x2949DF1 VA: 0x2949CF0
	|-NativeArray<BatchVisibility>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x294AC50 Offset: 0x294AD51 VA: 0x294AC50
	|-NativeArray<BoneWeight1>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x294BBB0 Offset: 0x294BCB1 VA: 0x294BBB0
	|-NativeArray<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x294CB10 Offset: 0x294CC11 VA: 0x294CB10
	|-NativeArray<int>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x294DA70 Offset: 0x294DB71 VA: 0x294DA70
	|-NativeArray<Int32Enum>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x294E9D0 Offset: 0x294EAD1 VA: 0x294E9D0
	|-NativeArray<JobHandle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x294F930 Offset: 0x294FA31 VA: 0x294F930
	|-NativeArray<LengthLimitProperties>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2950960 Offset: 0x2950A61 VA: 0x2950960
	|-NativeArray<LightDataGI>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x29518E0 Offset: 0x29519E1 VA: 0x29518E0
	|-NativeArray<Plane>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x29528C0 Offset: 0x29529C1 VA: 0x29528C0
	|-NativeArray<PreTile>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2953940 Offset: 0x2953A41 VA: 0x2953940
	|-NativeArray<RenderStateBlock>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x29548A0 Offset: 0x29549A1 VA: 0x29548A0
	|-NativeArray<ShaderTagId>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x29558C0 Offset: 0x29559C1 VA: 0x29558C0
	|-NativeArray<SpringBoneComponents>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x29568A0 Offset: 0x29569A1 VA: 0x29568A0
	|-NativeArray<SpringBoneProperties>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x2957920 Offset: 0x2957A21 VA: 0x2957920
	|-NativeArray<SpringColliderComponents>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x318F490 Offset: 0x318F591 VA: 0x318F490
	|-NativeArray<SpringColliderProperties>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3190470 Offset: 0x3190571 VA: 0x3190470
	|-NativeArray<SpringForceComponent>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3191450 Offset: 0x3191551 VA: 0x3191450
	|-NativeArray<SpringJobElement>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31923B0 Offset: 0x31924B1 VA: 0x31923B0
	|-NativeArray<ushort>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3193310 Offset: 0x3193411 VA: 0x3193310
	|-NativeArray<uint>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3194270 Offset: 0x3194371 VA: 0x3194270
	|-NativeArray<Vector2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31951F0 Offset: 0x31952F1 VA: 0x31951F0
	|-NativeArray<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3196150 Offset: 0x3196251 VA: 0x3196150
	|-NativeArray<VertexAttributeDescriptor>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31971E0 Offset: 0x31972E1 VA: 0x31971E0
	|-NativeArray<VisibleLight>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3198160 Offset: 0x3198261 VA: 0x3198160
	|-NativeArray<float3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x3199140 Offset: 0x3199241 VA: 0x3199140
	|-NativeArray<float4x4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x319A0A0 Offset: 0x319A1A1 VA: 0x319A0A0
	|-NativeArray<uint4>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x319B030 Offset: 0x319B131 VA: 0x319B030
	|-NativeArray<DeferredTiler.PrePunctualLight>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x319BFE0 Offset: 0x319C0E1 VA: 0x319BFE0
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x319CFA0 Offset: 0x319D0A1 VA: 0x319CFA0
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x319DF70 Offset: 0x319E071 VA: 0x319DF70
	|-NativeArray<ParticleSystem.Particle>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x319EF80 Offset: 0x319F081 VA: 0x319EF80
	|-NativeArray<ShaderInput.LightData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x319FF90 Offset: 0x31A0091 VA: 0x319FF90
	|-NativeArray<ShaderInput.ShadowData>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949DA0 Offset: 0x2949EA1 VA: 0x2949DA0
	|-NativeArray<BatchVisibility>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x294AD00 Offset: 0x294AE01 VA: 0x294AD00
	|-NativeArray<BoneWeight1>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x294BC60 Offset: 0x294BD61 VA: 0x294BC60
	|-NativeArray<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x294CBC0 Offset: 0x294CCC1 VA: 0x294CBC0
	|-NativeArray<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x294DB20 Offset: 0x294DC21 VA: 0x294DB20
	|-NativeArray<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x294EA80 Offset: 0x294EB81 VA: 0x294EA80
	|-NativeArray<JobHandle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x294F9E0 Offset: 0x294FAE1 VA: 0x294F9E0
	|-NativeArray<LengthLimitProperties>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2950A10 Offset: 0x2950B11 VA: 0x2950A10
	|-NativeArray<LightDataGI>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2951990 Offset: 0x2951A91 VA: 0x2951990
	|-NativeArray<Plane>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2952970 Offset: 0x2952A71 VA: 0x2952970
	|-NativeArray<PreTile>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29539F0 Offset: 0x2953AF1 VA: 0x29539F0
	|-NativeArray<RenderStateBlock>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2954950 Offset: 0x2954A51 VA: 0x2954950
	|-NativeArray<ShaderTagId>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2955970 Offset: 0x2955A71 VA: 0x2955970
	|-NativeArray<SpringBoneComponents>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x2956950 Offset: 0x2956A51 VA: 0x2956950
	|-NativeArray<SpringBoneProperties>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x29579D0 Offset: 0x2957AD1 VA: 0x29579D0
	|-NativeArray<SpringColliderComponents>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x318F540 Offset: 0x318F641 VA: 0x318F540
	|-NativeArray<SpringColliderProperties>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3190520 Offset: 0x3190621 VA: 0x3190520
	|-NativeArray<SpringForceComponent>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3191500 Offset: 0x3191601 VA: 0x3191500
	|-NativeArray<SpringJobElement>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3192460 Offset: 0x3192561 VA: 0x3192460
	|-NativeArray<ushort>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31933C0 Offset: 0x31934C1 VA: 0x31933C0
	|-NativeArray<uint>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3194320 Offset: 0x3194421 VA: 0x3194320
	|-NativeArray<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31952A0 Offset: 0x31953A1 VA: 0x31952A0
	|-NativeArray<Vector3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3196200 Offset: 0x3196301 VA: 0x3196200
	|-NativeArray<VertexAttributeDescriptor>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3197290 Offset: 0x3197391 VA: 0x3197290
	|-NativeArray<VisibleLight>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x3198210 Offset: 0x3198311 VA: 0x3198210
	|-NativeArray<float3>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31991F0 Offset: 0x31992F1 VA: 0x31991F0
	|-NativeArray<float4x4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x319A150 Offset: 0x319A251 VA: 0x319A150
	|-NativeArray<uint4>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x319B0E0 Offset: 0x319B1E1 VA: 0x319B0E0
	|-NativeArray<DeferredTiler.PrePunctualLight>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x319C090 Offset: 0x319C191 VA: 0x319C090
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x319D050 Offset: 0x319D151 VA: 0x319D050
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x319E020 Offset: 0x319E121 VA: 0x319E020
	|-NativeArray<ParticleSystem.Particle>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x319F030 Offset: 0x319F131 VA: 0x319F030
	|-NativeArray<ShaderInput.LightData>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31A0040 Offset: 0x31A0141 VA: 0x31A0040
	|-NativeArray<ShaderInput.ShadowData>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool Equals(NativeArray<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949E80 Offset: 0x2949F81 VA: 0x2949E80
	|-NativeArray<BatchVisibility>.Equals
	|
	|-RVA: 0x294ADE0 Offset: 0x294AEE1 VA: 0x294ADE0
	|-NativeArray<BoneWeight1>.Equals
	|
	|-RVA: 0x294BD40 Offset: 0x294BE41 VA: 0x294BD40
	|-NativeArray<byte>.Equals
	|
	|-RVA: 0x294CCA0 Offset: 0x294CDA1 VA: 0x294CCA0
	|-NativeArray<int>.Equals
	|
	|-RVA: 0x294DC00 Offset: 0x294DD01 VA: 0x294DC00
	|-NativeArray<Int32Enum>.Equals
	|
	|-RVA: 0x294EB60 Offset: 0x294EC61 VA: 0x294EB60
	|-NativeArray<JobHandle>.Equals
	|
	|-RVA: 0x294FAC0 Offset: 0x294FBC1 VA: 0x294FAC0
	|-NativeArray<LengthLimitProperties>.Equals
	|
	|-RVA: 0x2950AF0 Offset: 0x2950BF1 VA: 0x2950AF0
	|-NativeArray<LightDataGI>.Equals
	|
	|-RVA: 0x2951A70 Offset: 0x2951B71 VA: 0x2951A70
	|-NativeArray<Plane>.Equals
	|
	|-RVA: 0x2952A50 Offset: 0x2952B51 VA: 0x2952A50
	|-NativeArray<PreTile>.Equals
	|
	|-RVA: 0x2953AD0 Offset: 0x2953BD1 VA: 0x2953AD0
	|-NativeArray<RenderStateBlock>.Equals
	|
	|-RVA: 0x2954A30 Offset: 0x2954B31 VA: 0x2954A30
	|-NativeArray<ShaderTagId>.Equals
	|
	|-RVA: 0x2955A50 Offset: 0x2955B51 VA: 0x2955A50
	|-NativeArray<SpringBoneComponents>.Equals
	|
	|-RVA: 0x2956A30 Offset: 0x2956B31 VA: 0x2956A30
	|-NativeArray<SpringBoneProperties>.Equals
	|
	|-RVA: 0x2957AB0 Offset: 0x2957BB1 VA: 0x2957AB0
	|-NativeArray<SpringColliderComponents>.Equals
	|
	|-RVA: 0x318F620 Offset: 0x318F721 VA: 0x318F620
	|-NativeArray<SpringColliderProperties>.Equals
	|
	|-RVA: 0x3190600 Offset: 0x3190701 VA: 0x3190600
	|-NativeArray<SpringForceComponent>.Equals
	|
	|-RVA: 0x31915E0 Offset: 0x31916E1 VA: 0x31915E0
	|-NativeArray<SpringJobElement>.Equals
	|
	|-RVA: 0x3192540 Offset: 0x3192641 VA: 0x3192540
	|-NativeArray<ushort>.Equals
	|
	|-RVA: 0x31934A0 Offset: 0x31935A1 VA: 0x31934A0
	|-NativeArray<uint>.Equals
	|
	|-RVA: 0x3194400 Offset: 0x3194501 VA: 0x3194400
	|-NativeArray<Vector2>.Equals
	|
	|-RVA: 0x3195380 Offset: 0x3195481 VA: 0x3195380
	|-NativeArray<Vector3>.Equals
	|
	|-RVA: 0x31962E0 Offset: 0x31963E1 VA: 0x31962E0
	|-NativeArray<VertexAttributeDescriptor>.Equals
	|
	|-RVA: 0x3197370 Offset: 0x3197471 VA: 0x3197370
	|-NativeArray<VisibleLight>.Equals
	|
	|-RVA: 0x31982F0 Offset: 0x31983F1 VA: 0x31982F0
	|-NativeArray<float3>.Equals
	|
	|-RVA: 0x31992D0 Offset: 0x31993D1 VA: 0x31992D0
	|-NativeArray<float4x4>.Equals
	|
	|-RVA: 0x319A230 Offset: 0x319A331 VA: 0x319A230
	|-NativeArray<uint4>.Equals
	|
	|-RVA: 0x319B1C0 Offset: 0x319B2C1 VA: 0x319B1C0
	|-NativeArray<DeferredTiler.PrePunctualLight>.Equals
	|
	|-RVA: 0x319C170 Offset: 0x319C271 VA: 0x319C170
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.Equals
	|
	|-RVA: 0x319D130 Offset: 0x319D231 VA: 0x319D130
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.Equals
	|
	|-RVA: 0x319E100 Offset: 0x319E201 VA: 0x319E100
	|-NativeArray<ParticleSystem.Particle>.Equals
	|
	|-RVA: 0x319F110 Offset: 0x319F211 VA: 0x319F110
	|-NativeArray<ShaderInput.LightData>.Equals
	|
	|-RVA: 0x31A0120 Offset: 0x31A0221 VA: 0x31A0120
	|-NativeArray<ShaderInput.ShadowData>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949EB0 Offset: 0x2949FB1 VA: 0x2949EB0
	|-NativeArray<BatchVisibility>.Equals
	|
	|-RVA: 0x294AE10 Offset: 0x294AF11 VA: 0x294AE10
	|-NativeArray<BoneWeight1>.Equals
	|
	|-RVA: 0x294BD70 Offset: 0x294BE71 VA: 0x294BD70
	|-NativeArray<byte>.Equals
	|
	|-RVA: 0x294CCD0 Offset: 0x294CDD1 VA: 0x294CCD0
	|-NativeArray<int>.Equals
	|
	|-RVA: 0x294DC30 Offset: 0x294DD31 VA: 0x294DC30
	|-NativeArray<Int32Enum>.Equals
	|
	|-RVA: 0x294EB90 Offset: 0x294EC91 VA: 0x294EB90
	|-NativeArray<JobHandle>.Equals
	|
	|-RVA: 0x294FAF0 Offset: 0x294FBF1 VA: 0x294FAF0
	|-NativeArray<LengthLimitProperties>.Equals
	|
	|-RVA: 0x2950B20 Offset: 0x2950C21 VA: 0x2950B20
	|-NativeArray<LightDataGI>.Equals
	|
	|-RVA: 0x2951AA0 Offset: 0x2951BA1 VA: 0x2951AA0
	|-NativeArray<Plane>.Equals
	|
	|-RVA: 0x2952A80 Offset: 0x2952B81 VA: 0x2952A80
	|-NativeArray<PreTile>.Equals
	|
	|-RVA: 0x2953B00 Offset: 0x2953C01 VA: 0x2953B00
	|-NativeArray<RenderStateBlock>.Equals
	|
	|-RVA: 0x2954A60 Offset: 0x2954B61 VA: 0x2954A60
	|-NativeArray<ShaderTagId>.Equals
	|
	|-RVA: 0x2955A80 Offset: 0x2955B81 VA: 0x2955A80
	|-NativeArray<SpringBoneComponents>.Equals
	|
	|-RVA: 0x2956A60 Offset: 0x2956B61 VA: 0x2956A60
	|-NativeArray<SpringBoneProperties>.Equals
	|
	|-RVA: 0x2957AE0 Offset: 0x2957BE1 VA: 0x2957AE0
	|-NativeArray<SpringColliderComponents>.Equals
	|
	|-RVA: 0x318F650 Offset: 0x318F751 VA: 0x318F650
	|-NativeArray<SpringColliderProperties>.Equals
	|
	|-RVA: 0x3190630 Offset: 0x3190731 VA: 0x3190630
	|-NativeArray<SpringForceComponent>.Equals
	|
	|-RVA: 0x3191610 Offset: 0x3191711 VA: 0x3191610
	|-NativeArray<SpringJobElement>.Equals
	|
	|-RVA: 0x3192570 Offset: 0x3192671 VA: 0x3192570
	|-NativeArray<ushort>.Equals
	|
	|-RVA: 0x31934D0 Offset: 0x31935D1 VA: 0x31934D0
	|-NativeArray<uint>.Equals
	|
	|-RVA: 0x3194430 Offset: 0x3194531 VA: 0x3194430
	|-NativeArray<Vector2>.Equals
	|
	|-RVA: 0x31953B0 Offset: 0x31954B1 VA: 0x31953B0
	|-NativeArray<Vector3>.Equals
	|
	|-RVA: 0x3196310 Offset: 0x3196411 VA: 0x3196310
	|-NativeArray<VertexAttributeDescriptor>.Equals
	|
	|-RVA: 0x31973A0 Offset: 0x31974A1 VA: 0x31973A0
	|-NativeArray<VisibleLight>.Equals
	|
	|-RVA: 0x3198320 Offset: 0x3198421 VA: 0x3198320
	|-NativeArray<float3>.Equals
	|
	|-RVA: 0x3199300 Offset: 0x3199401 VA: 0x3199300
	|-NativeArray<float4x4>.Equals
	|
	|-RVA: 0x319A260 Offset: 0x319A361 VA: 0x319A260
	|-NativeArray<uint4>.Equals
	|
	|-RVA: 0x319B1F0 Offset: 0x319B2F1 VA: 0x319B1F0
	|-NativeArray<DeferredTiler.PrePunctualLight>.Equals
	|
	|-RVA: 0x319C1A0 Offset: 0x319C2A1 VA: 0x319C1A0
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.Equals
	|
	|-RVA: 0x319D160 Offset: 0x319D261 VA: 0x319D160
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.Equals
	|
	|-RVA: 0x319E130 Offset: 0x319E231 VA: 0x319E130
	|-NativeArray<ParticleSystem.Particle>.Equals
	|
	|-RVA: 0x319F140 Offset: 0x319F241 VA: 0x319F140
	|-NativeArray<ShaderInput.LightData>.Equals
	|
	|-RVA: 0x31A0150 Offset: 0x31A0251 VA: 0x31A0150
	|-NativeArray<ShaderInput.ShadowData>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2949FE0 Offset: 0x294A0E1 VA: 0x2949FE0
	|-NativeArray<BatchVisibility>.GetHashCode
	|
	|-RVA: 0x294AF40 Offset: 0x294B041 VA: 0x294AF40
	|-NativeArray<BoneWeight1>.GetHashCode
	|
	|-RVA: 0x294BEA0 Offset: 0x294BFA1 VA: 0x294BEA0
	|-NativeArray<byte>.GetHashCode
	|
	|-RVA: 0x294CE00 Offset: 0x294CF01 VA: 0x294CE00
	|-NativeArray<int>.GetHashCode
	|
	|-RVA: 0x294DD60 Offset: 0x294DE61 VA: 0x294DD60
	|-NativeArray<Int32Enum>.GetHashCode
	|
	|-RVA: 0x294ECC0 Offset: 0x294EDC1 VA: 0x294ECC0
	|-NativeArray<JobHandle>.GetHashCode
	|
	|-RVA: 0x294FC20 Offset: 0x294FD21 VA: 0x294FC20
	|-NativeArray<LengthLimitProperties>.GetHashCode
	|
	|-RVA: 0x2950C50 Offset: 0x2950D51 VA: 0x2950C50
	|-NativeArray<LightDataGI>.GetHashCode
	|
	|-RVA: 0x2951BD0 Offset: 0x2951CD1 VA: 0x2951BD0
	|-NativeArray<Plane>.GetHashCode
	|
	|-RVA: 0x2952BB0 Offset: 0x2952CB1 VA: 0x2952BB0
	|-NativeArray<PreTile>.GetHashCode
	|
	|-RVA: 0x2953C30 Offset: 0x2953D31 VA: 0x2953C30
	|-NativeArray<RenderStateBlock>.GetHashCode
	|
	|-RVA: 0x2954B90 Offset: 0x2954C91 VA: 0x2954B90
	|-NativeArray<ShaderTagId>.GetHashCode
	|
	|-RVA: 0x2955BB0 Offset: 0x2955CB1 VA: 0x2955BB0
	|-NativeArray<SpringBoneComponents>.GetHashCode
	|
	|-RVA: 0x2956B90 Offset: 0x2956C91 VA: 0x2956B90
	|-NativeArray<SpringBoneProperties>.GetHashCode
	|
	|-RVA: 0x2957C10 Offset: 0x2957D11 VA: 0x2957C10
	|-NativeArray<SpringColliderComponents>.GetHashCode
	|
	|-RVA: 0x318F780 Offset: 0x318F881 VA: 0x318F780
	|-NativeArray<SpringColliderProperties>.GetHashCode
	|
	|-RVA: 0x3190760 Offset: 0x3190861 VA: 0x3190760
	|-NativeArray<SpringForceComponent>.GetHashCode
	|
	|-RVA: 0x3191740 Offset: 0x3191841 VA: 0x3191740
	|-NativeArray<SpringJobElement>.GetHashCode
	|
	|-RVA: 0x31926A0 Offset: 0x31927A1 VA: 0x31926A0
	|-NativeArray<ushort>.GetHashCode
	|
	|-RVA: 0x3193600 Offset: 0x3193701 VA: 0x3193600
	|-NativeArray<uint>.GetHashCode
	|
	|-RVA: 0x3194560 Offset: 0x3194661 VA: 0x3194560
	|-NativeArray<Vector2>.GetHashCode
	|
	|-RVA: 0x31954E0 Offset: 0x31955E1 VA: 0x31954E0
	|-NativeArray<Vector3>.GetHashCode
	|
	|-RVA: 0x3196440 Offset: 0x3196541 VA: 0x3196440
	|-NativeArray<VertexAttributeDescriptor>.GetHashCode
	|
	|-RVA: 0x31974D0 Offset: 0x31975D1 VA: 0x31974D0
	|-NativeArray<VisibleLight>.GetHashCode
	|
	|-RVA: 0x3198450 Offset: 0x3198551 VA: 0x3198450
	|-NativeArray<float3>.GetHashCode
	|
	|-RVA: 0x3199430 Offset: 0x3199531 VA: 0x3199430
	|-NativeArray<float4x4>.GetHashCode
	|
	|-RVA: 0x319A390 Offset: 0x319A491 VA: 0x319A390
	|-NativeArray<uint4>.GetHashCode
	|
	|-RVA: 0x319B320 Offset: 0x319B421 VA: 0x319B320
	|-NativeArray<DeferredTiler.PrePunctualLight>.GetHashCode
	|
	|-RVA: 0x319C2D0 Offset: 0x319C3D1 VA: 0x319C2D0
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.GetHashCode
	|
	|-RVA: 0x319D290 Offset: 0x319D391 VA: 0x319D290
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.GetHashCode
	|
	|-RVA: 0x319E260 Offset: 0x319E361 VA: 0x319E260
	|-NativeArray<ParticleSystem.Particle>.GetHashCode
	|
	|-RVA: 0x319F270 Offset: 0x319F371 VA: 0x319F270
	|-NativeArray<ShaderInput.LightData>.GetHashCode
	|
	|-RVA: 0x31A0280 Offset: 0x31A0381 VA: 0x31A0280
	|-NativeArray<ShaderInput.ShadowData>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static void Copy(T[] src, NativeArray<T> dst) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x294A000 Offset: 0x294A101 VA: 0x294A000
	|-NativeArray<BatchVisibility>.Copy
	|
	|-RVA: 0x294AF60 Offset: 0x294B061 VA: 0x294AF60
	|-NativeArray<BoneWeight1>.Copy
	|
	|-RVA: 0x294BEC0 Offset: 0x294BFC1 VA: 0x294BEC0
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x294CE20 Offset: 0x294CF21 VA: 0x294CE20
	|-NativeArray<int>.Copy
	|
	|-RVA: 0x294DD80 Offset: 0x294DE81 VA: 0x294DD80
	|-NativeArray<Int32Enum>.Copy
	|
	|-RVA: 0x294ECE0 Offset: 0x294EDE1 VA: 0x294ECE0
	|-NativeArray<JobHandle>.Copy
	|
	|-RVA: 0x294FC40 Offset: 0x294FD41 VA: 0x294FC40
	|-NativeArray<LengthLimitProperties>.Copy
	|
	|-RVA: 0x2950C70 Offset: 0x2950D71 VA: 0x2950C70
	|-NativeArray<LightDataGI>.Copy
	|
	|-RVA: 0x2951BF0 Offset: 0x2951CF1 VA: 0x2951BF0
	|-NativeArray<Plane>.Copy
	|
	|-RVA: 0x2952BD0 Offset: 0x2952CD1 VA: 0x2952BD0
	|-NativeArray<PreTile>.Copy
	|
	|-RVA: 0x2953C50 Offset: 0x2953D51 VA: 0x2953C50
	|-NativeArray<RenderStateBlock>.Copy
	|
	|-RVA: 0x2954BB0 Offset: 0x2954CB1 VA: 0x2954BB0
	|-NativeArray<ShaderTagId>.Copy
	|
	|-RVA: 0x2955BD0 Offset: 0x2955CD1 VA: 0x2955BD0
	|-NativeArray<SpringBoneComponents>.Copy
	|
	|-RVA: 0x2956BB0 Offset: 0x2956CB1 VA: 0x2956BB0
	|-NativeArray<SpringBoneProperties>.Copy
	|
	|-RVA: 0x2957C30 Offset: 0x2957D31 VA: 0x2957C30
	|-NativeArray<SpringColliderComponents>.Copy
	|
	|-RVA: 0x318F7A0 Offset: 0x318F8A1 VA: 0x318F7A0
	|-NativeArray<SpringColliderProperties>.Copy
	|
	|-RVA: 0x3190780 Offset: 0x3190881 VA: 0x3190780
	|-NativeArray<SpringForceComponent>.Copy
	|
	|-RVA: 0x3191760 Offset: 0x3191861 VA: 0x3191760
	|-NativeArray<SpringJobElement>.Copy
	|
	|-RVA: 0x31926C0 Offset: 0x31927C1 VA: 0x31926C0
	|-NativeArray<ushort>.Copy
	|
	|-RVA: 0x3193620 Offset: 0x3193721 VA: 0x3193620
	|-NativeArray<uint>.Copy
	|
	|-RVA: 0x3194580 Offset: 0x3194681 VA: 0x3194580
	|-NativeArray<Vector2>.Copy
	|
	|-RVA: 0x3195500 Offset: 0x3195601 VA: 0x3195500
	|-NativeArray<Vector3>.Copy
	|
	|-RVA: 0x3196460 Offset: 0x3196561 VA: 0x3196460
	|-NativeArray<VertexAttributeDescriptor>.Copy
	|
	|-RVA: 0x31974F0 Offset: 0x31975F1 VA: 0x31974F0
	|-NativeArray<VisibleLight>.Copy
	|
	|-RVA: 0x3198470 Offset: 0x3198571 VA: 0x3198470
	|-NativeArray<float3>.Copy
	|
	|-RVA: 0x3199450 Offset: 0x3199551 VA: 0x3199450
	|-NativeArray<float4x4>.Copy
	|
	|-RVA: 0x319A3B0 Offset: 0x319A4B1 VA: 0x319A3B0
	|-NativeArray<uint4>.Copy
	|
	|-RVA: 0x319B340 Offset: 0x319B441 VA: 0x319B340
	|-NativeArray<DeferredTiler.PrePunctualLight>.Copy
	|
	|-RVA: 0x319C2F0 Offset: 0x319C3F1 VA: 0x319C2F0
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.Copy
	|
	|-RVA: 0x319D2B0 Offset: 0x319D3B1 VA: 0x319D2B0
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.Copy
	|
	|-RVA: 0x319E280 Offset: 0x319E381 VA: 0x319E280
	|-NativeArray<ParticleSystem.Particle>.Copy
	|
	|-RVA: 0x319F290 Offset: 0x319F391 VA: 0x319F290
	|-NativeArray<ShaderInput.LightData>.Copy
	|
	|-RVA: 0x31A02A0 Offset: 0x31A03A1 VA: 0x31A02A0
	|-NativeArray<ShaderInput.ShadowData>.Copy
	*/

	// RVA: -1 Offset: -1
	public static void Copy(NativeArray<T> src, T[] dst, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x294A0B0 Offset: 0x294A1B1 VA: 0x294A0B0
	|-NativeArray<BatchVisibility>.Copy
	|
	|-RVA: 0x294B010 Offset: 0x294B111 VA: 0x294B010
	|-NativeArray<BoneWeight1>.Copy
	|
	|-RVA: 0x294BF70 Offset: 0x294C071 VA: 0x294BF70
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x294CED0 Offset: 0x294CFD1 VA: 0x294CED0
	|-NativeArray<int>.Copy
	|
	|-RVA: 0x294DE30 Offset: 0x294DF31 VA: 0x294DE30
	|-NativeArray<Int32Enum>.Copy
	|
	|-RVA: 0x294ED90 Offset: 0x294EE91 VA: 0x294ED90
	|-NativeArray<JobHandle>.Copy
	|
	|-RVA: 0x294FCF0 Offset: 0x294FDF1 VA: 0x294FCF0
	|-NativeArray<LengthLimitProperties>.Copy
	|
	|-RVA: 0x2950D20 Offset: 0x2950E21 VA: 0x2950D20
	|-NativeArray<LightDataGI>.Copy
	|
	|-RVA: 0x2951CA0 Offset: 0x2951DA1 VA: 0x2951CA0
	|-NativeArray<Plane>.Copy
	|
	|-RVA: 0x2952C80 Offset: 0x2952D81 VA: 0x2952C80
	|-NativeArray<PreTile>.Copy
	|
	|-RVA: 0x2953D00 Offset: 0x2953E01 VA: 0x2953D00
	|-NativeArray<RenderStateBlock>.Copy
	|
	|-RVA: 0x2954C60 Offset: 0x2954D61 VA: 0x2954C60
	|-NativeArray<ShaderTagId>.Copy
	|
	|-RVA: 0x2955C80 Offset: 0x2955D81 VA: 0x2955C80
	|-NativeArray<SpringBoneComponents>.Copy
	|
	|-RVA: 0x2956C60 Offset: 0x2956D61 VA: 0x2956C60
	|-NativeArray<SpringBoneProperties>.Copy
	|
	|-RVA: 0x2957CE0 Offset: 0x2957DE1 VA: 0x2957CE0
	|-NativeArray<SpringColliderComponents>.Copy
	|
	|-RVA: 0x318F850 Offset: 0x318F951 VA: 0x318F850
	|-NativeArray<SpringColliderProperties>.Copy
	|
	|-RVA: 0x3190830 Offset: 0x3190931 VA: 0x3190830
	|-NativeArray<SpringForceComponent>.Copy
	|
	|-RVA: 0x3191810 Offset: 0x3191911 VA: 0x3191810
	|-NativeArray<SpringJobElement>.Copy
	|
	|-RVA: 0x3192770 Offset: 0x3192871 VA: 0x3192770
	|-NativeArray<ushort>.Copy
	|
	|-RVA: 0x31936D0 Offset: 0x31937D1 VA: 0x31936D0
	|-NativeArray<uint>.Copy
	|
	|-RVA: 0x3194630 Offset: 0x3194731 VA: 0x3194630
	|-NativeArray<Vector2>.Copy
	|
	|-RVA: 0x31955B0 Offset: 0x31956B1 VA: 0x31955B0
	|-NativeArray<Vector3>.Copy
	|
	|-RVA: 0x3196510 Offset: 0x3196611 VA: 0x3196510
	|-NativeArray<VertexAttributeDescriptor>.Copy
	|
	|-RVA: 0x31975A0 Offset: 0x31976A1 VA: 0x31975A0
	|-NativeArray<VisibleLight>.Copy
	|
	|-RVA: 0x3198520 Offset: 0x3198621 VA: 0x3198520
	|-NativeArray<float3>.Copy
	|
	|-RVA: 0x3199500 Offset: 0x3199601 VA: 0x3199500
	|-NativeArray<float4x4>.Copy
	|
	|-RVA: 0x319A460 Offset: 0x319A561 VA: 0x319A460
	|-NativeArray<uint4>.Copy
	|
	|-RVA: 0x319B3F0 Offset: 0x319B4F1 VA: 0x319B3F0
	|-NativeArray<DeferredTiler.PrePunctualLight>.Copy
	|
	|-RVA: 0x319C3A0 Offset: 0x319C4A1 VA: 0x319C3A0
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.Copy
	|
	|-RVA: 0x319D360 Offset: 0x319D461 VA: 0x319D360
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.Copy
	|
	|-RVA: 0x319E330 Offset: 0x319E431 VA: 0x319E330
	|-NativeArray<ParticleSystem.Particle>.Copy
	|
	|-RVA: 0x319F340 Offset: 0x319F441 VA: 0x319F340
	|-NativeArray<ShaderInput.LightData>.Copy
	|
	|-RVA: 0x31A0350 Offset: 0x31A0451 VA: 0x31A0350
	|-NativeArray<ShaderInput.ShadowData>.Copy
	*/

	// RVA: -1 Offset: -1
	public static void Copy(T[] src, int srcIndex, NativeArray<T> dst, int dstIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x294A160 Offset: 0x294A261 VA: 0x294A160
	|-NativeArray<BatchVisibility>.Copy
	|
	|-RVA: 0x294B0C0 Offset: 0x294B1C1 VA: 0x294B0C0
	|-NativeArray<BoneWeight1>.Copy
	|
	|-RVA: 0x294C020 Offset: 0x294C121 VA: 0x294C020
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x294CF80 Offset: 0x294D081 VA: 0x294CF80
	|-NativeArray<int>.Copy
	|
	|-RVA: 0x294DEE0 Offset: 0x294DFE1 VA: 0x294DEE0
	|-NativeArray<Int32Enum>.Copy
	|
	|-RVA: 0x294EE40 Offset: 0x294EF41 VA: 0x294EE40
	|-NativeArray<JobHandle>.Copy
	|
	|-RVA: 0x294FDA0 Offset: 0x294FEA1 VA: 0x294FDA0
	|-NativeArray<LengthLimitProperties>.Copy
	|
	|-RVA: 0x2950DD0 Offset: 0x2950ED1 VA: 0x2950DD0
	|-NativeArray<LightDataGI>.Copy
	|
	|-RVA: 0x2951D50 Offset: 0x2951E51 VA: 0x2951D50
	|-NativeArray<Plane>.Copy
	|
	|-RVA: 0x2952D30 Offset: 0x2952E31 VA: 0x2952D30
	|-NativeArray<PreTile>.Copy
	|
	|-RVA: 0x2953DB0 Offset: 0x2953EB1 VA: 0x2953DB0
	|-NativeArray<RenderStateBlock>.Copy
	|
	|-RVA: 0x2954D10 Offset: 0x2954E11 VA: 0x2954D10
	|-NativeArray<ShaderTagId>.Copy
	|
	|-RVA: 0x2955D30 Offset: 0x2955E31 VA: 0x2955D30
	|-NativeArray<SpringBoneComponents>.Copy
	|
	|-RVA: 0x2956D10 Offset: 0x2956E11 VA: 0x2956D10
	|-NativeArray<SpringBoneProperties>.Copy
	|
	|-RVA: 0x2957D90 Offset: 0x2957E91 VA: 0x2957D90
	|-NativeArray<SpringColliderComponents>.Copy
	|
	|-RVA: 0x318F900 Offset: 0x318FA01 VA: 0x318F900
	|-NativeArray<SpringColliderProperties>.Copy
	|
	|-RVA: 0x31908E0 Offset: 0x31909E1 VA: 0x31908E0
	|-NativeArray<SpringForceComponent>.Copy
	|
	|-RVA: 0x31918C0 Offset: 0x31919C1 VA: 0x31918C0
	|-NativeArray<SpringJobElement>.Copy
	|
	|-RVA: 0x3192820 Offset: 0x3192921 VA: 0x3192820
	|-NativeArray<ushort>.Copy
	|
	|-RVA: 0x3193780 Offset: 0x3193881 VA: 0x3193780
	|-NativeArray<uint>.Copy
	|
	|-RVA: 0x31946E0 Offset: 0x31947E1 VA: 0x31946E0
	|-NativeArray<Vector2>.Copy
	|
	|-RVA: 0x3195660 Offset: 0x3195761 VA: 0x3195660
	|-NativeArray<Vector3>.Copy
	|
	|-RVA: 0x31965C0 Offset: 0x31966C1 VA: 0x31965C0
	|-NativeArray<VertexAttributeDescriptor>.Copy
	|
	|-RVA: 0x3197650 Offset: 0x3197751 VA: 0x3197650
	|-NativeArray<VisibleLight>.Copy
	|
	|-RVA: 0x31985D0 Offset: 0x31986D1 VA: 0x31985D0
	|-NativeArray<float3>.Copy
	|
	|-RVA: 0x31995B0 Offset: 0x31996B1 VA: 0x31995B0
	|-NativeArray<float4x4>.Copy
	|
	|-RVA: 0x319A510 Offset: 0x319A611 VA: 0x319A510
	|-NativeArray<uint4>.Copy
	|
	|-RVA: 0x319B4A0 Offset: 0x319B5A1 VA: 0x319B4A0
	|-NativeArray<DeferredTiler.PrePunctualLight>.Copy
	|
	|-RVA: 0x319C450 Offset: 0x319C551 VA: 0x319C450
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.Copy
	|
	|-RVA: 0x319D410 Offset: 0x319D511 VA: 0x319D410
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.Copy
	|
	|-RVA: 0x319E3E0 Offset: 0x319E4E1 VA: 0x319E3E0
	|-NativeArray<ParticleSystem.Particle>.Copy
	|
	|-RVA: 0x319F3F0 Offset: 0x319F4F1 VA: 0x319F3F0
	|-NativeArray<ShaderInput.LightData>.Copy
	|
	|-RVA: 0x31A0400 Offset: 0x31A0501 VA: 0x31A0400
	|-NativeArray<ShaderInput.ShadowData>.Copy
	*/

	// RVA: -1 Offset: -1
	public static void Copy(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x294A2F0 Offset: 0x294A3F1 VA: 0x294A2F0
	|-NativeArray<BatchVisibility>.Copy
	|
	|-RVA: 0x294B250 Offset: 0x294B351 VA: 0x294B250
	|-NativeArray<BoneWeight1>.Copy
	|
	|-RVA: 0x294C1B0 Offset: 0x294C2B1 VA: 0x294C1B0
	|-NativeArray<byte>.Copy
	|
	|-RVA: 0x294D110 Offset: 0x294D211 VA: 0x294D110
	|-NativeArray<int>.Copy
	|
	|-RVA: 0x294E070 Offset: 0x294E171 VA: 0x294E070
	|-NativeArray<Int32Enum>.Copy
	|
	|-RVA: 0x294EFD0 Offset: 0x294F0D1 VA: 0x294EFD0
	|-NativeArray<JobHandle>.Copy
	|
	|-RVA: 0x294FF30 Offset: 0x2950031 VA: 0x294FF30
	|-NativeArray<LengthLimitProperties>.Copy
	|
	|-RVA: 0x2950F60 Offset: 0x2951061 VA: 0x2950F60
	|-NativeArray<LightDataGI>.Copy
	|
	|-RVA: 0x2951EE0 Offset: 0x2951FE1 VA: 0x2951EE0
	|-NativeArray<Plane>.Copy
	|
	|-RVA: 0x2952EC0 Offset: 0x2952FC1 VA: 0x2952EC0
	|-NativeArray<PreTile>.Copy
	|
	|-RVA: 0x2953F40 Offset: 0x2954041 VA: 0x2953F40
	|-NativeArray<RenderStateBlock>.Copy
	|
	|-RVA: 0x2954EA0 Offset: 0x2954FA1 VA: 0x2954EA0
	|-NativeArray<ShaderTagId>.Copy
	|
	|-RVA: 0x2955EC0 Offset: 0x2955FC1 VA: 0x2955EC0
	|-NativeArray<SpringBoneComponents>.Copy
	|
	|-RVA: 0x2956EA0 Offset: 0x2956FA1 VA: 0x2956EA0
	|-NativeArray<SpringBoneProperties>.Copy
	|
	|-RVA: 0x2957F20 Offset: 0x2958021 VA: 0x2957F20
	|-NativeArray<SpringColliderComponents>.Copy
	|
	|-RVA: 0x318FA90 Offset: 0x318FB91 VA: 0x318FA90
	|-NativeArray<SpringColliderProperties>.Copy
	|
	|-RVA: 0x3190A70 Offset: 0x3190B71 VA: 0x3190A70
	|-NativeArray<SpringForceComponent>.Copy
	|
	|-RVA: 0x3191A50 Offset: 0x3191B51 VA: 0x3191A50
	|-NativeArray<SpringJobElement>.Copy
	|
	|-RVA: 0x31929B0 Offset: 0x3192AB1 VA: 0x31929B0
	|-NativeArray<ushort>.Copy
	|
	|-RVA: 0x3193910 Offset: 0x3193A11 VA: 0x3193910
	|-NativeArray<uint>.Copy
	|
	|-RVA: 0x3194870 Offset: 0x3194971 VA: 0x3194870
	|-NativeArray<Vector2>.Copy
	|
	|-RVA: 0x31957F0 Offset: 0x31958F1 VA: 0x31957F0
	|-NativeArray<Vector3>.Copy
	|
	|-RVA: 0x3196750 Offset: 0x3196851 VA: 0x3196750
	|-NativeArray<VertexAttributeDescriptor>.Copy
	|
	|-RVA: 0x31977E0 Offset: 0x31978E1 VA: 0x31977E0
	|-NativeArray<VisibleLight>.Copy
	|
	|-RVA: 0x3198760 Offset: 0x3198861 VA: 0x3198760
	|-NativeArray<float3>.Copy
	|
	|-RVA: 0x3199740 Offset: 0x3199841 VA: 0x3199740
	|-NativeArray<float4x4>.Copy
	|
	|-RVA: 0x319A6A0 Offset: 0x319A7A1 VA: 0x319A6A0
	|-NativeArray<uint4>.Copy
	|
	|-RVA: 0x319B630 Offset: 0x319B731 VA: 0x319B630
	|-NativeArray<DeferredTiler.PrePunctualLight>.Copy
	|
	|-RVA: 0x319C5E0 Offset: 0x319C6E1 VA: 0x319C5E0
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.Copy
	|
	|-RVA: 0x319D5A0 Offset: 0x319D6A1 VA: 0x319D5A0
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.Copy
	|
	|-RVA: 0x319E570 Offset: 0x319E671 VA: 0x319E570
	|-NativeArray<ParticleSystem.Particle>.Copy
	|
	|-RVA: 0x319F580 Offset: 0x319F681 VA: 0x319F580
	|-NativeArray<ShaderInput.LightData>.Copy
	|
	|-RVA: 0x31A0590 Offset: 0x31A0691 VA: 0x31A0590
	|-NativeArray<ShaderInput.ShadowData>.Copy
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> GetSubArray(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x294A480 Offset: 0x294A581 VA: 0x294A480
	|-NativeArray<BatchVisibility>.GetSubArray
	|
	|-RVA: 0x294B3E0 Offset: 0x294B4E1 VA: 0x294B3E0
	|-NativeArray<BoneWeight1>.GetSubArray
	|
	|-RVA: 0x294C340 Offset: 0x294C441 VA: 0x294C340
	|-NativeArray<byte>.GetSubArray
	|
	|-RVA: 0x294D2A0 Offset: 0x294D3A1 VA: 0x294D2A0
	|-NativeArray<int>.GetSubArray
	|
	|-RVA: 0x294E200 Offset: 0x294E301 VA: 0x294E200
	|-NativeArray<Int32Enum>.GetSubArray
	|
	|-RVA: 0x294F160 Offset: 0x294F261 VA: 0x294F160
	|-NativeArray<JobHandle>.GetSubArray
	|
	|-RVA: 0x29500C0 Offset: 0x29501C1 VA: 0x29500C0
	|-NativeArray<LengthLimitProperties>.GetSubArray
	|
	|-RVA: 0x29510F0 Offset: 0x29511F1 VA: 0x29510F0
	|-NativeArray<LightDataGI>.GetSubArray
	|
	|-RVA: 0x2952070 Offset: 0x2952171 VA: 0x2952070
	|-NativeArray<Plane>.GetSubArray
	|
	|-RVA: 0x2953050 Offset: 0x2953151 VA: 0x2953050
	|-NativeArray<PreTile>.GetSubArray
	|
	|-RVA: 0x29540D0 Offset: 0x29541D1 VA: 0x29540D0
	|-NativeArray<RenderStateBlock>.GetSubArray
	|
	|-RVA: 0x2955030 Offset: 0x2955131 VA: 0x2955030
	|-NativeArray<ShaderTagId>.GetSubArray
	|
	|-RVA: 0x2956050 Offset: 0x2956151 VA: 0x2956050
	|-NativeArray<SpringBoneComponents>.GetSubArray
	|
	|-RVA: 0x2957030 Offset: 0x2957131 VA: 0x2957030
	|-NativeArray<SpringBoneProperties>.GetSubArray
	|
	|-RVA: 0x29580B0 Offset: 0x29581B1 VA: 0x29580B0
	|-NativeArray<SpringColliderComponents>.GetSubArray
	|
	|-RVA: 0x318FC20 Offset: 0x318FD21 VA: 0x318FC20
	|-NativeArray<SpringColliderProperties>.GetSubArray
	|
	|-RVA: 0x3190C00 Offset: 0x3190D01 VA: 0x3190C00
	|-NativeArray<SpringForceComponent>.GetSubArray
	|
	|-RVA: 0x3191BE0 Offset: 0x3191CE1 VA: 0x3191BE0
	|-NativeArray<SpringJobElement>.GetSubArray
	|
	|-RVA: 0x3192B40 Offset: 0x3192C41 VA: 0x3192B40
	|-NativeArray<ushort>.GetSubArray
	|
	|-RVA: 0x3193AA0 Offset: 0x3193BA1 VA: 0x3193AA0
	|-NativeArray<uint>.GetSubArray
	|
	|-RVA: 0x3194A00 Offset: 0x3194B01 VA: 0x3194A00
	|-NativeArray<Vector2>.GetSubArray
	|
	|-RVA: 0x3195980 Offset: 0x3195A81 VA: 0x3195980
	|-NativeArray<Vector3>.GetSubArray
	|
	|-RVA: 0x31968E0 Offset: 0x31969E1 VA: 0x31968E0
	|-NativeArray<VertexAttributeDescriptor>.GetSubArray
	|
	|-RVA: 0x3197970 Offset: 0x3197A71 VA: 0x3197970
	|-NativeArray<VisibleLight>.GetSubArray
	|
	|-RVA: 0x31988F0 Offset: 0x31989F1 VA: 0x31988F0
	|-NativeArray<float3>.GetSubArray
	|
	|-RVA: 0x31998D0 Offset: 0x31999D1 VA: 0x31998D0
	|-NativeArray<float4x4>.GetSubArray
	|
	|-RVA: 0x319A830 Offset: 0x319A931 VA: 0x319A830
	|-NativeArray<uint4>.GetSubArray
	|
	|-RVA: 0x319B7C0 Offset: 0x319B8C1 VA: 0x319B7C0
	|-NativeArray<DeferredTiler.PrePunctualLight>.GetSubArray
	|
	|-RVA: 0x319C770 Offset: 0x319C871 VA: 0x319C770
	|-NativeArray<LightUtility.ParametricLightMeshVertex>.GetSubArray
	|
	|-RVA: 0x319D730 Offset: 0x319D831 VA: 0x319D730
	|-NativeArray<LightUtility.SpriteLightMeshVertex>.GetSubArray
	|
	|-RVA: 0x319E700 Offset: 0x319E801 VA: 0x319E700
	|-NativeArray<ParticleSystem.Particle>.GetSubArray
	|
	|-RVA: 0x319F710 Offset: 0x319F811 VA: 0x319F710
	|-NativeArray<ShaderInput.LightData>.GetSubArray
	|
	|-RVA: 0x31A0720 Offset: 0x31A0821 VA: 0x31A0720
	|-NativeArray<ShaderInput.ShadowData>.GetSubArray
	*/
}

