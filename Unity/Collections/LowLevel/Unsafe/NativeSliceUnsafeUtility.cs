// Namespace: Unity.Collections.LowLevel.Unsafe
[ExtensionAttribute] // RVA: 0x43B7B0 Offset: 0x43B8B1 VA: 0x43B7B0
public static class NativeSliceUnsafeUtility // TypeDefIndex: 3384
{
	// Methods

	// RVA: -1 Offset: -1
	public static NativeSlice<T> ConvertExistingDataToNativeSlice<T>(void* dataPointer, int stride, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x29674E0 Offset: 0x29675E1 VA: 0x29674E0
	|-NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<Vector2>
	|
	|-RVA: 0x29675F0 Offset: 0x29676F1 VA: 0x29675F0
	|-NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<Vector3>
	*/

	[ExtensionAttribute] // RVA: 0x445B10 Offset: 0x445C11 VA: 0x445B10
	// RVA: -1 Offset: -1
	public static void* GetUnsafePtr<T>(NativeSlice<T> nativeSlice) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2967700 Offset: 0x2967801 VA: 0x2967700
	|-NativeSliceUnsafeUtility.GetUnsafePtr<Vector3>
	*/

	[ExtensionAttribute] // RVA: 0x445B20 Offset: 0x445C21 VA: 0x445B20
	// RVA: -1 Offset: -1
	public static void* GetUnsafeReadOnlyPtr<T>(NativeSlice<T> nativeSlice) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2967710 Offset: 0x2967811 VA: 0x2967710
	|-NativeSliceUnsafeUtility.GetUnsafeReadOnlyPtr<Vector3>
	*/
}

