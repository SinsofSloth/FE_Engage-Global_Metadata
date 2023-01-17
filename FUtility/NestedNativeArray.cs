// Namespace: FUtility
[DefaultMemberAttribute] // RVA: 0x5B0B0 Offset: 0x5B1B1 VA: 0x5B0B0
public struct NestedNativeArray<T> // TypeDefIndex: 6336
{
	// Fields
	private void* ptr; // 0x0
	private int length; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(NativeArray<T> array, int startIndex, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A39C0 Offset: 0x31A3AC1 VA: 0x31A39C0
	|-NestedNativeArray<int>..ctor
	|
	|-RVA: 0x31A3BF0 Offset: 0x31A3CF1 VA: 0x31A3BF0
	|-NestedNativeArray<LengthLimitProperties>..ctor
	|
	|-RVA: 0x31A3E20 Offset: 0x31A3F21 VA: 0x31A3E20
	|-NestedNativeArray<SpringBoneComponents>..ctor
	|
	|-RVA: 0x31A40D0 Offset: 0x31A41D1 VA: 0x31A40D0
	|-NestedNativeArray<SpringBoneProperties>..ctor
	|
	|-RVA: 0x31A4340 Offset: 0x31A4441 VA: 0x31A4340
	|-NestedNativeArray<SpringColliderComponents>..ctor
	|
	|-RVA: 0x31A4620 Offset: 0x31A4721 VA: 0x31A4620
	|-NestedNativeArray<SpringColliderProperties>..ctor
	|
	|-RVA: 0x31A4850 Offset: 0x31A4951 VA: 0x31A4850
	|-NestedNativeArray<float3>..ctor
	|
	|-RVA: 0x31A4AA0 Offset: 0x31A4BA1 VA: 0x31A4AA0
	|-NestedNativeArray<float4x4>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A3AA0 Offset: 0x31A3BA1 VA: 0x31A3AA0
	|-NestedNativeArray<int>.get_Length
	|
	|-RVA: 0x31A3CD0 Offset: 0x31A3DD1 VA: 0x31A3CD0
	|-NestedNativeArray<LengthLimitProperties>.get_Length
	|
	|-RVA: 0x31A3F00 Offset: 0x31A4001 VA: 0x31A3F00
	|-NestedNativeArray<SpringBoneComponents>.get_Length
	|
	|-RVA: 0x31A41B0 Offset: 0x31A42B1 VA: 0x31A41B0
	|-NestedNativeArray<SpringBoneProperties>.get_Length
	|
	|-RVA: 0x31A4420 Offset: 0x31A4521 VA: 0x31A4420
	|-NestedNativeArray<SpringColliderComponents>.get_Length
	|
	|-RVA: 0x31A4700 Offset: 0x31A4801 VA: 0x31A4700
	|-NestedNativeArray<SpringColliderProperties>.get_Length
	|
	|-RVA: 0x31A4930 Offset: 0x31A4A31 VA: 0x31A4930
	|-NestedNativeArray<float3>.get_Length
	|
	|-RVA: 0x31A4B80 Offset: 0x31A4C81 VA: 0x31A4B80
	|-NestedNativeArray<float4x4>.get_Length
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A3AB0 Offset: 0x31A3BB1 VA: 0x31A3AB0
	|-NestedNativeArray<int>.get_Item
	|
	|-RVA: 0x31A3CE0 Offset: 0x31A3DE1 VA: 0x31A3CE0
	|-NestedNativeArray<LengthLimitProperties>.get_Item
	|
	|-RVA: 0x31A3F10 Offset: 0x31A4011 VA: 0x31A3F10
	|-NestedNativeArray<SpringBoneComponents>.get_Item
	|
	|-RVA: 0x31A41C0 Offset: 0x31A42C1 VA: 0x31A41C0
	|-NestedNativeArray<SpringBoneProperties>.get_Item
	|
	|-RVA: 0x31A4430 Offset: 0x31A4531 VA: 0x31A4430
	|-NestedNativeArray<SpringColliderComponents>.get_Item
	|
	|-RVA: 0x31A4710 Offset: 0x31A4811 VA: 0x31A4710
	|-NestedNativeArray<SpringColliderProperties>.get_Item
	|
	|-RVA: 0x31A4940 Offset: 0x31A4A41 VA: 0x31A4940
	|-NestedNativeArray<float3>.get_Item
	|
	|-RVA: 0x31A4B90 Offset: 0x31A4C91 VA: 0x31A4B90
	|-NestedNativeArray<float4x4>.get_Item
	*/

	[WriteAccessRequiredAttribute] // RVA: 0x5C050 Offset: 0x5C151 VA: 0x5C050
	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A3B40 Offset: 0x31A3C41 VA: 0x31A3B40
	|-NestedNativeArray<int>.set_Item
	|
	|-RVA: 0x31A3D70 Offset: 0x31A3E71 VA: 0x31A3D70
	|-NestedNativeArray<LengthLimitProperties>.set_Item
	|
	|-RVA: 0x31A3FD0 Offset: 0x31A40D1 VA: 0x31A3FD0
	|-NestedNativeArray<SpringBoneComponents>.set_Item
	|
	|-RVA: 0x31A4270 Offset: 0x31A4371 VA: 0x31A4270
	|-NestedNativeArray<SpringBoneProperties>.set_Item
	|
	|-RVA: 0x31A4500 Offset: 0x31A4601 VA: 0x31A4500
	|-NestedNativeArray<SpringColliderComponents>.set_Item
	|
	|-RVA: 0x31A47A0 Offset: 0x31A48A1 VA: 0x31A47A0
	|-NestedNativeArray<SpringColliderProperties>.set_Item
	|
	|-RVA: 0x31A49D0 Offset: 0x31A4AD1 VA: 0x31A49D0
	|-NestedNativeArray<float3>.set_Item
	|
	|-RVA: 0x31A4C40 Offset: 0x31A4D41 VA: 0x31A4C40
	|-NestedNativeArray<float4x4>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void* GetUnsafeReadOnlyPtr() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A3BE0 Offset: 0x31A3CE1 VA: 0x31A3BE0
	|-NestedNativeArray<int>.GetUnsafeReadOnlyPtr
	|
	|-RVA: 0x31A3E10 Offset: 0x31A3F11 VA: 0x31A3E10
	|-NestedNativeArray<LengthLimitProperties>.GetUnsafeReadOnlyPtr
	|
	|-RVA: 0x31A40C0 Offset: 0x31A41C1 VA: 0x31A40C0
	|-NestedNativeArray<SpringBoneComponents>.GetUnsafeReadOnlyPtr
	|
	|-RVA: 0x31A4330 Offset: 0x31A4431 VA: 0x31A4330
	|-NestedNativeArray<SpringBoneProperties>.GetUnsafeReadOnlyPtr
	|
	|-RVA: 0x31A4610 Offset: 0x31A4711 VA: 0x31A4610
	|-NestedNativeArray<SpringColliderComponents>.GetUnsafeReadOnlyPtr
	|
	|-RVA: 0x31A4840 Offset: 0x31A4941 VA: 0x31A4840
	|-NestedNativeArray<SpringColliderProperties>.GetUnsafeReadOnlyPtr
	|
	|-RVA: 0x31A4A90 Offset: 0x31A4B91 VA: 0x31A4A90
	|-NestedNativeArray<float3>.GetUnsafeReadOnlyPtr
	|
	|-RVA: 0x31A4D10 Offset: 0x31A4E11 VA: 0x31A4D10
	|-NestedNativeArray<float4x4>.GetUnsafeReadOnlyPtr
	*/
}

