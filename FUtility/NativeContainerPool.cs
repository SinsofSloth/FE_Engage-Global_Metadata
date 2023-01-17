// Namespace: FUtility
[Il2CppSetOptionAttribute] // RVA: 0x5AFD0 Offset: 0x5B0D1 VA: 0x5AFD0
[Il2CppSetOptionAttribute] // RVA: 0x5AFD0 Offset: 0x5B0D1 VA: 0x5AFD0
[Il2CppSetOptionAttribute] // RVA: 0x5AFD0 Offset: 0x5B0D1 VA: 0x5AFD0
public class NativeContainerPool<T> // TypeDefIndex: 6335
{
	// Fields
	private NativeArray<T> array; // 0x0
	private TaskSystem<NativeBlock> freePool; // 0x0
	private TaskSystem<NativeBlock> usedPool; // 0x0
	private MatchHandler<NativeBlock> getFreeBlockHandler; // 0x0
	private MatchHandler<NativeBlock> getusedBlockHandler; // 0x0
	private MatchHandler<NativeBlock> connectBlockTopHandler; // 0x0
	private MatchHandler<NativeBlock> connectBlockEndHandler; // 0x0
	private int needSize; // 0x0
	private void* freeAddress; // 0x0
	private NativeBlock connectBlock; // 0x0

	// Properties
	public NativeArray<T> nativeArray { get; }

	// Methods

	// RVA: -1 Offset: -1
	public NativeArray<T> get_nativeArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A0800 Offset: 0x31A0901 VA: 0x31A0800
	|-NativeContainerPool<int>.get_nativeArray
	|
	|-RVA: 0x31A0FE0 Offset: 0x31A10E1 VA: 0x31A0FE0
	|-NativeContainerPool<LengthLimitProperties>.get_nativeArray
	|
	|-RVA: 0x31A17C0 Offset: 0x31A18C1 VA: 0x31A17C0
	|-NativeContainerPool<SpringBoneProperties>.get_nativeArray
	|
	|-RVA: 0x31A1FA0 Offset: 0x31A20A1 VA: 0x31A1FA0
	|-NativeContainerPool<SpringColliderProperties>.get_nativeArray
	|
	|-RVA: 0x31A27A0 Offset: 0x31A28A1 VA: 0x31A27A0
	|-NativeContainerPool<float3>.get_nativeArray
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int arraySize, int blockCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A0810 Offset: 0x31A0911 VA: 0x31A0810
	|-NativeContainerPool<int>..ctor
	|
	|-RVA: 0x31A0FF0 Offset: 0x31A10F1 VA: 0x31A0FF0
	|-NativeContainerPool<LengthLimitProperties>..ctor
	|
	|-RVA: 0x31A17D0 Offset: 0x31A18D1 VA: 0x31A17D0
	|-NativeContainerPool<SpringBoneProperties>..ctor
	|
	|-RVA: 0x31A1FB0 Offset: 0x31A20B1 VA: 0x31A1FB0
	|-NativeContainerPool<SpringColliderProperties>..ctor
	|
	|-RVA: 0x31A27B0 Offset: 0x31A28B1 VA: 0x31A27B0
	|-NativeContainerPool<float3>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A0AC0 Offset: 0x31A0BC1 VA: 0x31A0AC0
	|-NativeContainerPool<int>.Dispose
	|
	|-RVA: 0x31A12A0 Offset: 0x31A13A1 VA: 0x31A12A0
	|-NativeContainerPool<LengthLimitProperties>.Dispose
	|
	|-RVA: 0x31A1A80 Offset: 0x31A1B81 VA: 0x31A1A80
	|-NativeContainerPool<SpringBoneProperties>.Dispose
	|
	|-RVA: 0x31A2290 Offset: 0x31A2391 VA: 0x31A2290
	|-NativeContainerPool<SpringColliderProperties>.Dispose
	|
	|-RVA: 0x31A2A90 Offset: 0x31A2B91 VA: 0x31A2A90
	|-NativeContainerPool<float3>.Dispose
	*/

	// RVA: -1 Offset: -1
	public bool AllocNestedArray(int size, out int index, out NestedNativeArray<T> nestedArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A0B40 Offset: 0x31A0C41 VA: 0x31A0B40
	|-NativeContainerPool<int>.AllocNestedArray
	|
	|-RVA: 0x31A1320 Offset: 0x31A1421 VA: 0x31A1320
	|-NativeContainerPool<LengthLimitProperties>.AllocNestedArray
	|
	|-RVA: 0x31A1B00 Offset: 0x31A1C01 VA: 0x31A1B00
	|-NativeContainerPool<SpringBoneProperties>.AllocNestedArray
	|
	|-RVA: 0x31A2300 Offset: 0x31A2401 VA: 0x31A2300
	|-NativeContainerPool<SpringColliderProperties>.AllocNestedArray
	|
	|-RVA: 0x31A2B00 Offset: 0x31A2C01 VA: 0x31A2B00
	|-NativeContainerPool<float3>.AllocNestedArray
	*/

	// RVA: -1 Offset: -1
	public bool AllocSubArray(int size, out int index, out NativeArray<T> subArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A0C80 Offset: 0x31A0D81 VA: 0x31A0C80
	|-NativeContainerPool<int>.AllocSubArray
	|
	|-RVA: 0x31A1460 Offset: 0x31A1561 VA: 0x31A1460
	|-NativeContainerPool<LengthLimitProperties>.AllocSubArray
	|
	|-RVA: 0x31A1C40 Offset: 0x31A1D41 VA: 0x31A1C40
	|-NativeContainerPool<SpringBoneProperties>.AllocSubArray
	|
	|-RVA: 0x31A2440 Offset: 0x31A2541 VA: 0x31A2440
	|-NativeContainerPool<SpringColliderProperties>.AllocSubArray
	|
	|-RVA: 0x31A2C40 Offset: 0x31A2D41 VA: 0x31A2C40
	|-NativeContainerPool<float3>.AllocSubArray
	*/

	// RVA: -1 Offset: -1
	private int GetFreeBlock(NativeBlock block) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A0DD0 Offset: 0x31A0ED1 VA: 0x31A0DD0
	|-NativeContainerPool<int>.GetFreeBlock
	|
	|-RVA: 0x31A15B0 Offset: 0x31A16B1 VA: 0x31A15B0
	|-NativeContainerPool<LengthLimitProperties>.GetFreeBlock
	|
	|-RVA: 0x31A1D90 Offset: 0x31A1E91 VA: 0x31A1D90
	|-NativeContainerPool<SpringBoneProperties>.GetFreeBlock
	|
	|-RVA: 0x31A2590 Offset: 0x31A2691 VA: 0x31A2590
	|-NativeContainerPool<SpringColliderProperties>.GetFreeBlock
	|
	|-RVA: 0x31A2D90 Offset: 0x31A2E91 VA: 0x31A2D90
	|-NativeContainerPool<float3>.GetFreeBlock
	*/

	// RVA: -1 Offset: -1
	public bool Free(NestedNativeArray<T> nestedArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A0DF0 Offset: 0x31A0EF1 VA: 0x31A0DF0
	|-NativeContainerPool<int>.Free
	|
	|-RVA: 0x31A15D0 Offset: 0x31A16D1 VA: 0x31A15D0
	|-NativeContainerPool<LengthLimitProperties>.Free
	|
	|-RVA: 0x31A1DB0 Offset: 0x31A1EB1 VA: 0x31A1DB0
	|-NativeContainerPool<SpringBoneProperties>.Free
	|
	|-RVA: 0x31A25B0 Offset: 0x31A26B1 VA: 0x31A25B0
	|-NativeContainerPool<SpringColliderProperties>.Free
	|
	|-RVA: 0x31A2DB0 Offset: 0x31A2EB1 VA: 0x31A2DB0
	|-NativeContainerPool<float3>.Free
	*/

	// RVA: -1 Offset: -1
	public bool Free(NativeArray<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A0E10 Offset: 0x31A0F11 VA: 0x31A0E10
	|-NativeContainerPool<int>.Free
	|
	|-RVA: 0x31A15F0 Offset: 0x31A16F1 VA: 0x31A15F0
	|-NativeContainerPool<LengthLimitProperties>.Free
	|
	|-RVA: 0x31A1DD0 Offset: 0x31A1ED1 VA: 0x31A1DD0
	|-NativeContainerPool<SpringBoneProperties>.Free
	|
	|-RVA: 0x31A25D0 Offset: 0x31A26D1 VA: 0x31A25D0
	|-NativeContainerPool<SpringColliderProperties>.Free
	|
	|-RVA: 0x31A2DD0 Offset: 0x31A2ED1 VA: 0x31A2DD0
	|-NativeContainerPool<float3>.Free
	*/

	// RVA: -1 Offset: -1
	private bool Free(void* ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A0E80 Offset: 0x31A0F81 VA: 0x31A0E80
	|-NativeContainerPool<int>.Free
	|
	|-RVA: 0x31A1660 Offset: 0x31A1761 VA: 0x31A1660
	|-NativeContainerPool<LengthLimitProperties>.Free
	|
	|-RVA: 0x31A1E40 Offset: 0x31A1F41 VA: 0x31A1E40
	|-NativeContainerPool<SpringBoneProperties>.Free
	|
	|-RVA: 0x31A2640 Offset: 0x31A2741 VA: 0x31A2640
	|-NativeContainerPool<SpringColliderProperties>.Free
	|
	|-RVA: 0x31A2E40 Offset: 0x31A2F41 VA: 0x31A2E40
	|-NativeContainerPool<float3>.Free
	*/

	// RVA: -1 Offset: -1
	private int GetUsedBlock(NativeBlock block) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A0F90 Offset: 0x31A1091 VA: 0x31A0F90
	|-NativeContainerPool<int>.GetUsedBlock
	|
	|-RVA: 0x31A1770 Offset: 0x31A1871 VA: 0x31A1770
	|-NativeContainerPool<LengthLimitProperties>.GetUsedBlock
	|
	|-RVA: 0x31A1F50 Offset: 0x31A2051 VA: 0x31A1F50
	|-NativeContainerPool<SpringBoneProperties>.GetUsedBlock
	|
	|-RVA: 0x31A2750 Offset: 0x31A2851 VA: 0x31A2750
	|-NativeContainerPool<SpringColliderProperties>.GetUsedBlock
	|
	|-RVA: 0x31A2F50 Offset: 0x31A3051 VA: 0x31A2F50
	|-NativeContainerPool<float3>.GetUsedBlock
	*/

	// RVA: -1 Offset: -1
	private int ConnectBlockTop(NativeBlock block) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A0FA0 Offset: 0x31A10A1 VA: 0x31A0FA0
	|-NativeContainerPool<int>.ConnectBlockTop
	|
	|-RVA: 0x31A1780 Offset: 0x31A1881 VA: 0x31A1780
	|-NativeContainerPool<LengthLimitProperties>.ConnectBlockTop
	|
	|-RVA: 0x31A1F60 Offset: 0x31A2061 VA: 0x31A1F60
	|-NativeContainerPool<SpringBoneProperties>.ConnectBlockTop
	|
	|-RVA: 0x31A2760 Offset: 0x31A2861 VA: 0x31A2760
	|-NativeContainerPool<SpringColliderProperties>.ConnectBlockTop
	|
	|-RVA: 0x31A2F60 Offset: 0x31A3061 VA: 0x31A2F60
	|-NativeContainerPool<float3>.ConnectBlockTop
	*/

	// RVA: -1 Offset: -1
	private int ConnectBlockEnd(NativeBlock block) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A0FC0 Offset: 0x31A10C1 VA: 0x31A0FC0
	|-NativeContainerPool<int>.ConnectBlockEnd
	|
	|-RVA: 0x31A17A0 Offset: 0x31A18A1 VA: 0x31A17A0
	|-NativeContainerPool<LengthLimitProperties>.ConnectBlockEnd
	|
	|-RVA: 0x31A1F80 Offset: 0x31A2081 VA: 0x31A1F80
	|-NativeContainerPool<SpringBoneProperties>.ConnectBlockEnd
	|
	|-RVA: 0x31A2780 Offset: 0x31A2881 VA: 0x31A2780
	|-NativeContainerPool<SpringColliderProperties>.ConnectBlockEnd
	|
	|-RVA: 0x31A2F80 Offset: 0x31A3081 VA: 0x31A2F80
	|-NativeContainerPool<float3>.ConnectBlockEnd
	*/
}

