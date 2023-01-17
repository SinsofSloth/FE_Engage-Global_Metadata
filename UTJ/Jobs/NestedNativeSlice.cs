// Namespace: UTJ.Jobs
public struct NestedNativeSlice<T> // TypeDefIndex: 6446
{
	// Fields
	public IntPtr intPtr; // 0x0
	public int stride; // 0x0
	public int length; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(NativeSlice<T> slice) { }

	// RVA: -1 Offset: -1
	public void .ctor(NativeArray<T> array, int startIndex, int length) { }

	// RVA: -1 Offset: -1
	public static NativeSlice<T> op_Implicit(NestedNativeSlice<T> nested) { }

	// RVA: -1 Offset: -1
	public NativeSlice<T> Convert() { }
}

