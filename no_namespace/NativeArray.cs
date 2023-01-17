// Namespace: 
[ExcludeFromDocsAttribute] // RVA: 0x43B3B0 Offset: 0x43B4B1 VA: 0x43B3B0
public struct NativeArray.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 3365
{
	// Fields
	private NativeArray<T> m_Array; // 0x0
	private int m_Index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ref NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB24B0 Offset: 0x2EB25B1 VA: 0x2EB24B0
	|-NativeArray.Enumerator<BatchVisibility>..ctor
	|
	|-RVA: 0x2EB2890 Offset: 0x2EB2991 VA: 0x2EB2890
	|-NativeArray.Enumerator<BoneWeight1>..ctor
	|
	|-RVA: 0x2EB2EF0 Offset: 0x2EB2FF1 VA: 0x2EB2EF0
	|-NativeArray.Enumerator<byte>..ctor
	|
	|-RVA: 0x2EB6490 Offset: 0x2EB6591 VA: 0x2EB6490
	|-NativeArray.Enumerator<int>..ctor
	|
	|-RVA: 0x2EB7180 Offset: 0x2EB7281 VA: 0x2EB7180
	|-NativeArray.Enumerator<Int32Enum>..ctor
	|
	|-RVA: 0x2EB8090 Offset: 0x2EB8191 VA: 0x2EB8090
	|-NativeArray.Enumerator<JobHandle>..ctor
	|
	|-RVA: 0x2EB8450 Offset: 0x2EB8551 VA: 0x2EB8450
	|-NativeArray.Enumerator<LengthLimitProperties>..ctor
	|
	|-RVA: 0x2EB8550 Offset: 0x2EB8651 VA: 0x2EB8550
	|-NativeArray.Enumerator<LightDataGI>..ctor
	|
	|-RVA: 0x2EBAFD0 Offset: 0x2EBB0D1 VA: 0x2EBAFD0
	|-NativeArray.Enumerator<Plane>..ctor
	|
	|-RVA: 0x2EBB960 Offset: 0x2EBBA61 VA: 0x2EBB960
	|-NativeArray.Enumerator<PreTile>..ctor
	|
	|-RVA: 0x2EBCC00 Offset: 0x2EBCD01 VA: 0x2EBCC00
	|-NativeArray.Enumerator<RenderStateBlock>..ctor
	|
	|-RVA: 0x2EBD820 Offset: 0x2EBD921 VA: 0x2EBD820
	|-NativeArray.Enumerator<ShaderTagId>..ctor
	|
	|-RVA: 0x2EBE260 Offset: 0x2EBE361 VA: 0x2EBE260
	|-NativeArray.Enumerator<SpringBoneComponents>..ctor
	|
	|-RVA: 0x2EBE3B0 Offset: 0x2EBE4B1 VA: 0x2EBE3B0
	|-NativeArray.Enumerator<SpringBoneProperties>..ctor
	|
	|-RVA: 0x2EBE4E0 Offset: 0x2EBE5E1 VA: 0x2EBE4E0
	|-NativeArray.Enumerator<SpringColliderComponents>..ctor
	|
	|-RVA: 0x2EBE630 Offset: 0x2EBE731 VA: 0x2EBE630
	|-NativeArray.Enumerator<SpringColliderProperties>..ctor
	|
	|-RVA: 0x2EBE740 Offset: 0x2EBE841 VA: 0x2EBE740
	|-NativeArray.Enumerator<SpringForceComponent>..ctor
	|
	|-RVA: 0x2EBE870 Offset: 0x2EBE971 VA: 0x2EBE870
	|-NativeArray.Enumerator<SpringJobElement>..ctor
	|
	|-RVA: 0x2E038B0 Offset: 0x2E039B1 VA: 0x2E038B0
	|-NativeArray.Enumerator<ushort>..ctor
	|
	|-RVA: 0x2E03F50 Offset: 0x2E04051 VA: 0x2E03F50
	|-NativeArray.Enumerator<uint>..ctor
	|
	|-RVA: 0x2E04BB0 Offset: 0x2E04CB1 VA: 0x2E04BB0
	|-NativeArray.Enumerator<Vector2>..ctor
	|
	|-RVA: 0x2E05120 Offset: 0x2E05221 VA: 0x2E05120
	|-NativeArray.Enumerator<Vector3>..ctor
	|
	|-RVA: 0x2E05950 Offset: 0x2E05A51 VA: 0x2E05950
	|-NativeArray.Enumerator<VertexAttributeDescriptor>..ctor
	|
	|-RVA: 0x2E05A60 Offset: 0x2E05B61 VA: 0x2E05A60
	|-NativeArray.Enumerator<VisibleLight>..ctor
	|
	|-RVA: 0x2E061E0 Offset: 0x2E062E1 VA: 0x2E061E0
	|-NativeArray.Enumerator<float3>..ctor
	|
	|-RVA: 0x2E06300 Offset: 0x2E06401 VA: 0x2E06300
	|-NativeArray.Enumerator<float4x4>..ctor
	|
	|-RVA: 0x2E06430 Offset: 0x2E06531 VA: 0x2E06430
	|-NativeArray.Enumerator<uint4>..ctor
	|
	|-RVA: 0x2E07E40 Offset: 0x2E07F41 VA: 0x2E07E40
	|-NativeArray.Enumerator<DeferredTiler.PrePunctualLight>..ctor
	|
	|-RVA: 0x2E0A2E0 Offset: 0x2E0A3E1 VA: 0x2E0A2E0
	|-NativeArray.Enumerator<LightUtility.ParametricLightMeshVertex>..ctor
	|
	|-RVA: 0x2E0A420 Offset: 0x2E0A521 VA: 0x2E0A420
	|-NativeArray.Enumerator<LightUtility.SpriteLightMeshVertex>..ctor
	|
	|-RVA: 0x2E0C220 Offset: 0x2E0C321 VA: 0x2E0C220
	|-NativeArray.Enumerator<ParticleSystem.Particle>..ctor
	|
	|-RVA: 0x2E0D570 Offset: 0x2E0D671 VA: 0x2E0D570
	|-NativeArray.Enumerator<ShaderInput.LightData>..ctor
	|
	|-RVA: 0x2E0D6B0 Offset: 0x2E0D7B1 VA: 0x2E0D6B0
	|-NativeArray.Enumerator<ShaderInput.ShadowData>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB24D0 Offset: 0x2EB25D1 VA: 0x2EB24D0
	|-NativeArray.Enumerator<BatchVisibility>.Dispose
	|
	|-RVA: 0x2EB28B0 Offset: 0x2EB29B1 VA: 0x2EB28B0
	|-NativeArray.Enumerator<BoneWeight1>.Dispose
	|
	|-RVA: 0x2EB2F10 Offset: 0x2EB3011 VA: 0x2EB2F10
	|-NativeArray.Enumerator<byte>.Dispose
	|
	|-RVA: 0x2EB64B0 Offset: 0x2EB65B1 VA: 0x2EB64B0
	|-NativeArray.Enumerator<int>.Dispose
	|
	|-RVA: 0x2EB71A0 Offset: 0x2EB72A1 VA: 0x2EB71A0
	|-NativeArray.Enumerator<Int32Enum>.Dispose
	|
	|-RVA: 0x2EB80B0 Offset: 0x2EB81B1 VA: 0x2EB80B0
	|-NativeArray.Enumerator<JobHandle>.Dispose
	|
	|-RVA: 0x2EB8470 Offset: 0x2EB8571 VA: 0x2EB8470
	|-NativeArray.Enumerator<LengthLimitProperties>.Dispose
	|
	|-RVA: 0x2EB8570 Offset: 0x2EB8671 VA: 0x2EB8570
	|-NativeArray.Enumerator<LightDataGI>.Dispose
	|
	|-RVA: 0x2EBAFF0 Offset: 0x2EBB0F1 VA: 0x2EBAFF0
	|-NativeArray.Enumerator<Plane>.Dispose
	|
	|-RVA: 0x2EBB980 Offset: 0x2EBBA81 VA: 0x2EBB980
	|-NativeArray.Enumerator<PreTile>.Dispose
	|
	|-RVA: 0x2EBCC20 Offset: 0x2EBCD21 VA: 0x2EBCC20
	|-NativeArray.Enumerator<RenderStateBlock>.Dispose
	|
	|-RVA: 0x2EBD840 Offset: 0x2EBD941 VA: 0x2EBD840
	|-NativeArray.Enumerator<ShaderTagId>.Dispose
	|
	|-RVA: 0x2EBE280 Offset: 0x2EBE381 VA: 0x2EBE280
	|-NativeArray.Enumerator<SpringBoneComponents>.Dispose
	|
	|-RVA: 0x2EBE3D0 Offset: 0x2EBE4D1 VA: 0x2EBE3D0
	|-NativeArray.Enumerator<SpringBoneProperties>.Dispose
	|
	|-RVA: 0x2EBE500 Offset: 0x2EBE601 VA: 0x2EBE500
	|-NativeArray.Enumerator<SpringColliderComponents>.Dispose
	|
	|-RVA: 0x2EBE650 Offset: 0x2EBE751 VA: 0x2EBE650
	|-NativeArray.Enumerator<SpringColliderProperties>.Dispose
	|
	|-RVA: 0x2EBE760 Offset: 0x2EBE861 VA: 0x2EBE760
	|-NativeArray.Enumerator<SpringForceComponent>.Dispose
	|
	|-RVA: 0x2EBE890 Offset: 0x2EBE991 VA: 0x2EBE890
	|-NativeArray.Enumerator<SpringJobElement>.Dispose
	|
	|-RVA: 0x2E038D0 Offset: 0x2E039D1 VA: 0x2E038D0
	|-NativeArray.Enumerator<ushort>.Dispose
	|
	|-RVA: 0x2E03F70 Offset: 0x2E04071 VA: 0x2E03F70
	|-NativeArray.Enumerator<uint>.Dispose
	|
	|-RVA: 0x2E04BD0 Offset: 0x2E04CD1 VA: 0x2E04BD0
	|-NativeArray.Enumerator<Vector2>.Dispose
	|
	|-RVA: 0x2E05140 Offset: 0x2E05241 VA: 0x2E05140
	|-NativeArray.Enumerator<Vector3>.Dispose
	|
	|-RVA: 0x2E05970 Offset: 0x2E05A71 VA: 0x2E05970
	|-NativeArray.Enumerator<VertexAttributeDescriptor>.Dispose
	|
	|-RVA: 0x2E05A80 Offset: 0x2E05B81 VA: 0x2E05A80
	|-NativeArray.Enumerator<VisibleLight>.Dispose
	|
	|-RVA: 0x2E06200 Offset: 0x2E06301 VA: 0x2E06200
	|-NativeArray.Enumerator<float3>.Dispose
	|
	|-RVA: 0x2E06320 Offset: 0x2E06421 VA: 0x2E06320
	|-NativeArray.Enumerator<float4x4>.Dispose
	|
	|-RVA: 0x2E06450 Offset: 0x2E06551 VA: 0x2E06450
	|-NativeArray.Enumerator<uint4>.Dispose
	|
	|-RVA: 0x2E07E60 Offset: 0x2E07F61 VA: 0x2E07E60
	|-NativeArray.Enumerator<DeferredTiler.PrePunctualLight>.Dispose
	|
	|-RVA: 0x2E0A300 Offset: 0x2E0A401 VA: 0x2E0A300
	|-NativeArray.Enumerator<LightUtility.ParametricLightMeshVertex>.Dispose
	|
	|-RVA: 0x2E0A440 Offset: 0x2E0A541 VA: 0x2E0A440
	|-NativeArray.Enumerator<LightUtility.SpriteLightMeshVertex>.Dispose
	|
	|-RVA: 0x2E0C240 Offset: 0x2E0C341 VA: 0x2E0C240
	|-NativeArray.Enumerator<ParticleSystem.Particle>.Dispose
	|
	|-RVA: 0x2E0D590 Offset: 0x2E0D691 VA: 0x2E0D590
	|-NativeArray.Enumerator<ShaderInput.LightData>.Dispose
	|
	|-RVA: 0x2E0D6D0 Offset: 0x2E0D7D1 VA: 0x2E0D6D0
	|-NativeArray.Enumerator<ShaderInput.ShadowData>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB24E0 Offset: 0x2EB25E1 VA: 0x2EB24E0
	|-NativeArray.Enumerator<BatchVisibility>.MoveNext
	|
	|-RVA: 0x2EB28C0 Offset: 0x2EB29C1 VA: 0x2EB28C0
	|-NativeArray.Enumerator<BoneWeight1>.MoveNext
	|
	|-RVA: 0x2EB2F20 Offset: 0x2EB3021 VA: 0x2EB2F20
	|-NativeArray.Enumerator<byte>.MoveNext
	|
	|-RVA: 0x2EB64C0 Offset: 0x2EB65C1 VA: 0x2EB64C0
	|-NativeArray.Enumerator<int>.MoveNext
	|
	|-RVA: 0x2EB71B0 Offset: 0x2EB72B1 VA: 0x2EB71B0
	|-NativeArray.Enumerator<Int32Enum>.MoveNext
	|
	|-RVA: 0x2EB80C0 Offset: 0x2EB81C1 VA: 0x2EB80C0
	|-NativeArray.Enumerator<JobHandle>.MoveNext
	|
	|-RVA: 0x2EB8480 Offset: 0x2EB8581 VA: 0x2EB8480
	|-NativeArray.Enumerator<LengthLimitProperties>.MoveNext
	|
	|-RVA: 0x2EB8580 Offset: 0x2EB8681 VA: 0x2EB8580
	|-NativeArray.Enumerator<LightDataGI>.MoveNext
	|
	|-RVA: 0x2EBB000 Offset: 0x2EBB101 VA: 0x2EBB000
	|-NativeArray.Enumerator<Plane>.MoveNext
	|
	|-RVA: 0x2EBB990 Offset: 0x2EBBA91 VA: 0x2EBB990
	|-NativeArray.Enumerator<PreTile>.MoveNext
	|
	|-RVA: 0x2EBCC30 Offset: 0x2EBCD31 VA: 0x2EBCC30
	|-NativeArray.Enumerator<RenderStateBlock>.MoveNext
	|
	|-RVA: 0x2EBD850 Offset: 0x2EBD951 VA: 0x2EBD850
	|-NativeArray.Enumerator<ShaderTagId>.MoveNext
	|
	|-RVA: 0x2EBE290 Offset: 0x2EBE391 VA: 0x2EBE290
	|-NativeArray.Enumerator<SpringBoneComponents>.MoveNext
	|
	|-RVA: 0x2EBE3E0 Offset: 0x2EBE4E1 VA: 0x2EBE3E0
	|-NativeArray.Enumerator<SpringBoneProperties>.MoveNext
	|
	|-RVA: 0x2EBE510 Offset: 0x2EBE611 VA: 0x2EBE510
	|-NativeArray.Enumerator<SpringColliderComponents>.MoveNext
	|
	|-RVA: 0x2EBE660 Offset: 0x2EBE761 VA: 0x2EBE660
	|-NativeArray.Enumerator<SpringColliderProperties>.MoveNext
	|
	|-RVA: 0x2EBE770 Offset: 0x2EBE871 VA: 0x2EBE770
	|-NativeArray.Enumerator<SpringForceComponent>.MoveNext
	|
	|-RVA: 0x2EBE8A0 Offset: 0x2EBE9A1 VA: 0x2EBE8A0
	|-NativeArray.Enumerator<SpringJobElement>.MoveNext
	|
	|-RVA: 0x2E038E0 Offset: 0x2E039E1 VA: 0x2E038E0
	|-NativeArray.Enumerator<ushort>.MoveNext
	|
	|-RVA: 0x2E03F80 Offset: 0x2E04081 VA: 0x2E03F80
	|-NativeArray.Enumerator<uint>.MoveNext
	|
	|-RVA: 0x2E04BE0 Offset: 0x2E04CE1 VA: 0x2E04BE0
	|-NativeArray.Enumerator<Vector2>.MoveNext
	|
	|-RVA: 0x2E05150 Offset: 0x2E05251 VA: 0x2E05150
	|-NativeArray.Enumerator<Vector3>.MoveNext
	|
	|-RVA: 0x2E05980 Offset: 0x2E05A81 VA: 0x2E05980
	|-NativeArray.Enumerator<VertexAttributeDescriptor>.MoveNext
	|
	|-RVA: 0x2E05A90 Offset: 0x2E05B91 VA: 0x2E05A90
	|-NativeArray.Enumerator<VisibleLight>.MoveNext
	|
	|-RVA: 0x2E06210 Offset: 0x2E06311 VA: 0x2E06210
	|-NativeArray.Enumerator<float3>.MoveNext
	|
	|-RVA: 0x2E06330 Offset: 0x2E06431 VA: 0x2E06330
	|-NativeArray.Enumerator<float4x4>.MoveNext
	|
	|-RVA: 0x2E06460 Offset: 0x2E06561 VA: 0x2E06460
	|-NativeArray.Enumerator<uint4>.MoveNext
	|
	|-RVA: 0x2E07E70 Offset: 0x2E07F71 VA: 0x2E07E70
	|-NativeArray.Enumerator<DeferredTiler.PrePunctualLight>.MoveNext
	|
	|-RVA: 0x2E0A310 Offset: 0x2E0A411 VA: 0x2E0A310
	|-NativeArray.Enumerator<LightUtility.ParametricLightMeshVertex>.MoveNext
	|
	|-RVA: 0x2E0A450 Offset: 0x2E0A551 VA: 0x2E0A450
	|-NativeArray.Enumerator<LightUtility.SpriteLightMeshVertex>.MoveNext
	|
	|-RVA: 0x2E0C250 Offset: 0x2E0C351 VA: 0x2E0C250
	|-NativeArray.Enumerator<ParticleSystem.Particle>.MoveNext
	|
	|-RVA: 0x2E0D5A0 Offset: 0x2E0D6A1 VA: 0x2E0D5A0
	|-NativeArray.Enumerator<ShaderInput.LightData>.MoveNext
	|
	|-RVA: 0x2E0D6E0 Offset: 0x2E0D7E1 VA: 0x2E0D6E0
	|-NativeArray.Enumerator<ShaderInput.ShadowData>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB2500 Offset: 0x2EB2601 VA: 0x2EB2500
	|-NativeArray.Enumerator<BatchVisibility>.Reset
	|
	|-RVA: 0x2EB28E0 Offset: 0x2EB29E1 VA: 0x2EB28E0
	|-NativeArray.Enumerator<BoneWeight1>.Reset
	|
	|-RVA: 0x2EB2F40 Offset: 0x2EB3041 VA: 0x2EB2F40
	|-NativeArray.Enumerator<byte>.Reset
	|
	|-RVA: 0x2EB64E0 Offset: 0x2EB65E1 VA: 0x2EB64E0
	|-NativeArray.Enumerator<int>.Reset
	|
	|-RVA: 0x2EB71D0 Offset: 0x2EB72D1 VA: 0x2EB71D0
	|-NativeArray.Enumerator<Int32Enum>.Reset
	|
	|-RVA: 0x2EB80E0 Offset: 0x2EB81E1 VA: 0x2EB80E0
	|-NativeArray.Enumerator<JobHandle>.Reset
	|
	|-RVA: 0x2EB84A0 Offset: 0x2EB85A1 VA: 0x2EB84A0
	|-NativeArray.Enumerator<LengthLimitProperties>.Reset
	|
	|-RVA: 0x2EB85A0 Offset: 0x2EB86A1 VA: 0x2EB85A0
	|-NativeArray.Enumerator<LightDataGI>.Reset
	|
	|-RVA: 0x2EBB020 Offset: 0x2EBB121 VA: 0x2EBB020
	|-NativeArray.Enumerator<Plane>.Reset
	|
	|-RVA: 0x2EBB9B0 Offset: 0x2EBBAB1 VA: 0x2EBB9B0
	|-NativeArray.Enumerator<PreTile>.Reset
	|
	|-RVA: 0x2EBCC50 Offset: 0x2EBCD51 VA: 0x2EBCC50
	|-NativeArray.Enumerator<RenderStateBlock>.Reset
	|
	|-RVA: 0x2EBD870 Offset: 0x2EBD971 VA: 0x2EBD870
	|-NativeArray.Enumerator<ShaderTagId>.Reset
	|
	|-RVA: 0x2EBE2B0 Offset: 0x2EBE3B1 VA: 0x2EBE2B0
	|-NativeArray.Enumerator<SpringBoneComponents>.Reset
	|
	|-RVA: 0x2EBE400 Offset: 0x2EBE501 VA: 0x2EBE400
	|-NativeArray.Enumerator<SpringBoneProperties>.Reset
	|
	|-RVA: 0x2EBE530 Offset: 0x2EBE631 VA: 0x2EBE530
	|-NativeArray.Enumerator<SpringColliderComponents>.Reset
	|
	|-RVA: 0x2EBE680 Offset: 0x2EBE781 VA: 0x2EBE680
	|-NativeArray.Enumerator<SpringColliderProperties>.Reset
	|
	|-RVA: 0x2EBE790 Offset: 0x2EBE891 VA: 0x2EBE790
	|-NativeArray.Enumerator<SpringForceComponent>.Reset
	|
	|-RVA: 0x2EBE8C0 Offset: 0x2EBE9C1 VA: 0x2EBE8C0
	|-NativeArray.Enumerator<SpringJobElement>.Reset
	|
	|-RVA: 0x2E03900 Offset: 0x2E03A01 VA: 0x2E03900
	|-NativeArray.Enumerator<ushort>.Reset
	|
	|-RVA: 0x2E03FA0 Offset: 0x2E040A1 VA: 0x2E03FA0
	|-NativeArray.Enumerator<uint>.Reset
	|
	|-RVA: 0x2E04C00 Offset: 0x2E04D01 VA: 0x2E04C00
	|-NativeArray.Enumerator<Vector2>.Reset
	|
	|-RVA: 0x2E05170 Offset: 0x2E05271 VA: 0x2E05170
	|-NativeArray.Enumerator<Vector3>.Reset
	|
	|-RVA: 0x2E059A0 Offset: 0x2E05AA1 VA: 0x2E059A0
	|-NativeArray.Enumerator<VertexAttributeDescriptor>.Reset
	|
	|-RVA: 0x2E05AB0 Offset: 0x2E05BB1 VA: 0x2E05AB0
	|-NativeArray.Enumerator<VisibleLight>.Reset
	|
	|-RVA: 0x2E06230 Offset: 0x2E06331 VA: 0x2E06230
	|-NativeArray.Enumerator<float3>.Reset
	|
	|-RVA: 0x2E06350 Offset: 0x2E06451 VA: 0x2E06350
	|-NativeArray.Enumerator<float4x4>.Reset
	|
	|-RVA: 0x2E06480 Offset: 0x2E06581 VA: 0x2E06480
	|-NativeArray.Enumerator<uint4>.Reset
	|
	|-RVA: 0x2E07E90 Offset: 0x2E07F91 VA: 0x2E07E90
	|-NativeArray.Enumerator<DeferredTiler.PrePunctualLight>.Reset
	|
	|-RVA: 0x2E0A330 Offset: 0x2E0A431 VA: 0x2E0A330
	|-NativeArray.Enumerator<LightUtility.ParametricLightMeshVertex>.Reset
	|
	|-RVA: 0x2E0A470 Offset: 0x2E0A571 VA: 0x2E0A470
	|-NativeArray.Enumerator<LightUtility.SpriteLightMeshVertex>.Reset
	|
	|-RVA: 0x2E0C270 Offset: 0x2E0C371 VA: 0x2E0C270
	|-NativeArray.Enumerator<ParticleSystem.Particle>.Reset
	|
	|-RVA: 0x2E0D5C0 Offset: 0x2E0D6C1 VA: 0x2E0D5C0
	|-NativeArray.Enumerator<ShaderInput.LightData>.Reset
	|
	|-RVA: 0x2E0D700 Offset: 0x2E0D801 VA: 0x2E0D700
	|-NativeArray.Enumerator<ShaderInput.ShadowData>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB2510 Offset: 0x2EB2611 VA: 0x2EB2510
	|-NativeArray.Enumerator<BatchVisibility>.get_Current
	|
	|-RVA: 0x2EB28F0 Offset: 0x2EB29F1 VA: 0x2EB28F0
	|-NativeArray.Enumerator<BoneWeight1>.get_Current
	|
	|-RVA: 0x2EB2F50 Offset: 0x2EB3051 VA: 0x2EB2F50
	|-NativeArray.Enumerator<byte>.get_Current
	|
	|-RVA: 0x2EB64F0 Offset: 0x2EB65F1 VA: 0x2EB64F0
	|-NativeArray.Enumerator<int>.get_Current
	|
	|-RVA: 0x2EB71E0 Offset: 0x2EB72E1 VA: 0x2EB71E0
	|-NativeArray.Enumerator<Int32Enum>.get_Current
	|
	|-RVA: 0x2EB80F0 Offset: 0x2EB81F1 VA: 0x2EB80F0
	|-NativeArray.Enumerator<JobHandle>.get_Current
	|
	|-RVA: 0x2EB84B0 Offset: 0x2EB85B1 VA: 0x2EB84B0
	|-NativeArray.Enumerator<LengthLimitProperties>.get_Current
	|
	|-RVA: 0x2EB85B0 Offset: 0x2EB86B1 VA: 0x2EB85B0
	|-NativeArray.Enumerator<LightDataGI>.get_Current
	|
	|-RVA: 0x2EBB030 Offset: 0x2EBB131 VA: 0x2EBB030
	|-NativeArray.Enumerator<Plane>.get_Current
	|
	|-RVA: 0x2EBB9C0 Offset: 0x2EBBAC1 VA: 0x2EBB9C0
	|-NativeArray.Enumerator<PreTile>.get_Current
	|
	|-RVA: 0x2EBCC60 Offset: 0x2EBCD61 VA: 0x2EBCC60
	|-NativeArray.Enumerator<RenderStateBlock>.get_Current
	|
	|-RVA: 0x2EBD880 Offset: 0x2EBD981 VA: 0x2EBD880
	|-NativeArray.Enumerator<ShaderTagId>.get_Current
	|
	|-RVA: 0x2EBE2C0 Offset: 0x2EBE3C1 VA: 0x2EBE2C0
	|-NativeArray.Enumerator<SpringBoneComponents>.get_Current
	|
	|-RVA: 0x2EBE410 Offset: 0x2EBE511 VA: 0x2EBE410
	|-NativeArray.Enumerator<SpringBoneProperties>.get_Current
	|
	|-RVA: 0x2EBE540 Offset: 0x2EBE641 VA: 0x2EBE540
	|-NativeArray.Enumerator<SpringColliderComponents>.get_Current
	|
	|-RVA: 0x2EBE690 Offset: 0x2EBE791 VA: 0x2EBE690
	|-NativeArray.Enumerator<SpringColliderProperties>.get_Current
	|
	|-RVA: 0x2EBE7A0 Offset: 0x2EBE8A1 VA: 0x2EBE7A0
	|-NativeArray.Enumerator<SpringForceComponent>.get_Current
	|
	|-RVA: 0x2EBE8D0 Offset: 0x2EBE9D1 VA: 0x2EBE8D0
	|-NativeArray.Enumerator<SpringJobElement>.get_Current
	|
	|-RVA: 0x2E03910 Offset: 0x2E03A11 VA: 0x2E03910
	|-NativeArray.Enumerator<ushort>.get_Current
	|
	|-RVA: 0x2E03FB0 Offset: 0x2E040B1 VA: 0x2E03FB0
	|-NativeArray.Enumerator<uint>.get_Current
	|
	|-RVA: 0x2E04C10 Offset: 0x2E04D11 VA: 0x2E04C10
	|-NativeArray.Enumerator<Vector2>.get_Current
	|
	|-RVA: 0x2E05180 Offset: 0x2E05281 VA: 0x2E05180
	|-NativeArray.Enumerator<Vector3>.get_Current
	|
	|-RVA: 0x2E059B0 Offset: 0x2E05AB1 VA: 0x2E059B0
	|-NativeArray.Enumerator<VertexAttributeDescriptor>.get_Current
	|
	|-RVA: 0x2E05AC0 Offset: 0x2E05BC1 VA: 0x2E05AC0
	|-NativeArray.Enumerator<VisibleLight>.get_Current
	|
	|-RVA: 0x2E06240 Offset: 0x2E06341 VA: 0x2E06240
	|-NativeArray.Enumerator<float3>.get_Current
	|
	|-RVA: 0x2E06360 Offset: 0x2E06461 VA: 0x2E06360
	|-NativeArray.Enumerator<float4x4>.get_Current
	|
	|-RVA: 0x2E06490 Offset: 0x2E06591 VA: 0x2E06490
	|-NativeArray.Enumerator<uint4>.get_Current
	|
	|-RVA: 0x2E07EA0 Offset: 0x2E07FA1 VA: 0x2E07EA0
	|-NativeArray.Enumerator<DeferredTiler.PrePunctualLight>.get_Current
	|
	|-RVA: 0x2E0A340 Offset: 0x2E0A441 VA: 0x2E0A340
	|-NativeArray.Enumerator<LightUtility.ParametricLightMeshVertex>.get_Current
	|
	|-RVA: 0x2E0A480 Offset: 0x2E0A581 VA: 0x2E0A480
	|-NativeArray.Enumerator<LightUtility.SpriteLightMeshVertex>.get_Current
	|
	|-RVA: 0x2E0C280 Offset: 0x2E0C381 VA: 0x2E0C280
	|-NativeArray.Enumerator<ParticleSystem.Particle>.get_Current
	|
	|-RVA: 0x2E0D5D0 Offset: 0x2E0D6D1 VA: 0x2E0D5D0
	|-NativeArray.Enumerator<ShaderInput.LightData>.get_Current
	|
	|-RVA: 0x2E0D710 Offset: 0x2E0D811 VA: 0x2E0D710
	|-NativeArray.Enumerator<ShaderInput.ShadowData>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB2530 Offset: 0x2EB2631 VA: 0x2EB2530
	|-NativeArray.Enumerator<BatchVisibility>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB2900 Offset: 0x2EB2A01 VA: 0x2EB2900
	|-NativeArray.Enumerator<BoneWeight1>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB2F60 Offset: 0x2EB3061 VA: 0x2EB2F60
	|-NativeArray.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB6500 Offset: 0x2EB6601 VA: 0x2EB6500
	|-NativeArray.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB71F0 Offset: 0x2EB72F1 VA: 0x2EB71F0
	|-NativeArray.Enumerator<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB8110 Offset: 0x2EB8211 VA: 0x2EB8110
	|-NativeArray.Enumerator<JobHandle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB84C0 Offset: 0x2EB85C1 VA: 0x2EB84C0
	|-NativeArray.Enumerator<LengthLimitProperties>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EB8600 Offset: 0x2EB8701 VA: 0x2EB8600
	|-NativeArray.Enumerator<LightDataGI>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBB050 Offset: 0x2EBB151 VA: 0x2EBB050
	|-NativeArray.Enumerator<Plane>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBB9F0 Offset: 0x2EBBAF1 VA: 0x2EBB9F0
	|-NativeArray.Enumerator<PreTile>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBCCC0 Offset: 0x2EBCDC1 VA: 0x2EBCCC0
	|-NativeArray.Enumerator<RenderStateBlock>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBD890 Offset: 0x2EBD991 VA: 0x2EBD890
	|-NativeArray.Enumerator<ShaderTagId>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBE310 Offset: 0x2EBE411 VA: 0x2EBE310
	|-NativeArray.Enumerator<SpringBoneComponents>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBE440 Offset: 0x2EBE541 VA: 0x2EBE440
	|-NativeArray.Enumerator<SpringBoneProperties>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBE590 Offset: 0x2EBE691 VA: 0x2EBE590
	|-NativeArray.Enumerator<SpringColliderComponents>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBE6B0 Offset: 0x2EBE7B1 VA: 0x2EBE6B0
	|-NativeArray.Enumerator<SpringColliderProperties>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBE7D0 Offset: 0x2EBE8D1 VA: 0x2EBE7D0
	|-NativeArray.Enumerator<SpringForceComponent>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2EBE900 Offset: 0x2EBEA01 VA: 0x2EBE900
	|-NativeArray.Enumerator<SpringJobElement>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E03920 Offset: 0x2E03A21 VA: 0x2E03920
	|-NativeArray.Enumerator<ushort>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E03FC0 Offset: 0x2E040C1 VA: 0x2E03FC0
	|-NativeArray.Enumerator<uint>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E04C30 Offset: 0x2E04D31 VA: 0x2E04C30
	|-NativeArray.Enumerator<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E051A0 Offset: 0x2E052A1 VA: 0x2E051A0
	|-NativeArray.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E059D0 Offset: 0x2E05AD1 VA: 0x2E059D0
	|-NativeArray.Enumerator<VertexAttributeDescriptor>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E05B20 Offset: 0x2E05C21 VA: 0x2E05B20
	|-NativeArray.Enumerator<VisibleLight>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E06260 Offset: 0x2E06361 VA: 0x2E06260
	|-NativeArray.Enumerator<float3>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E06390 Offset: 0x2E06491 VA: 0x2E06390
	|-NativeArray.Enumerator<float4x4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E064B0 Offset: 0x2E065B1 VA: 0x2E064B0
	|-NativeArray.Enumerator<uint4>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E07EC0 Offset: 0x2E07FC1 VA: 0x2E07EC0
	|-NativeArray.Enumerator<DeferredTiler.PrePunctualLight>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0A370 Offset: 0x2E0A471 VA: 0x2E0A370
	|-NativeArray.Enumerator<LightUtility.ParametricLightMeshVertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0A4B0 Offset: 0x2E0A5B1 VA: 0x2E0A4B0
	|-NativeArray.Enumerator<LightUtility.SpriteLightMeshVertex>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0C2B0 Offset: 0x2E0C3B1 VA: 0x2E0C2B0
	|-NativeArray.Enumerator<ParticleSystem.Particle>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0D610 Offset: 0x2E0D711 VA: 0x2E0D610
	|-NativeArray.Enumerator<ShaderInput.LightData>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E0D750 Offset: 0x2E0D851 VA: 0x2E0D750
	|-NativeArray.Enumerator<ShaderInput.ShadowData>.System.Collections.IEnumerator.get_Current
	*/
}

