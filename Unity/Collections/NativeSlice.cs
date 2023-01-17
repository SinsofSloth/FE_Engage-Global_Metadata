// Namespace: Unity.Collections
[NativeContainerAttribute] // RVA: 0x43B3C0 Offset: 0x43B4C1 VA: 0x43B3C0
[NativeContainerSupportsMinMaxWriteRestrictionAttribute] // RVA: 0x43B3C0 Offset: 0x43B4C1 VA: 0x43B3C0
[DebuggerDisplayAttribute] // RVA: 0x43B3C0 Offset: 0x43B4C1 VA: 0x43B3C0
[DebuggerTypeProxyAttribute] // RVA: 0x43B3C0 Offset: 0x43B4C1 VA: 0x43B3C0
[DefaultMemberAttribute] // RVA: 0x43B3C0 Offset: 0x43B4C1 VA: 0x43B3C0
public struct NativeSlice<T> : IEnumerable<T>, IEnumerable, IEquatable<NativeSlice<T>> // TypeDefIndex: 3369
{
	// Fields
	[NativeDisableUnsafePtrRestrictionAttribute] // RVA: 0x441F10 Offset: 0x442011 VA: 0x441F10
	internal byte* m_Buffer; // 0x0
	internal int m_Stride; // 0x0
	internal int m_Length; // 0x0

	// Properties
	public T Item { get; }
	public int Stride { get; }
	public int Length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(NativeArray<T> array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A2FA0 Offset: 0x31A30A1 VA: 0x31A2FA0
	|-NativeSlice<Vector2>..ctor
	|
	|-RVA: 0x31A34B0 Offset: 0x31A35B1 VA: 0x31A34B0
	|-NativeSlice<Vector3>..ctor
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A3040 Offset: 0x31A3141 VA: 0x31A3040
	|-NativeSlice<Vector2>.get_Item
	|
	|-RVA: 0x31A3550 Offset: 0x31A3651 VA: 0x31A3550
	|-NativeSlice<Vector3>.get_Item
	*/

	// RVA: -1 Offset: -1
	public int get_Stride() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A30E0 Offset: 0x31A31E1 VA: 0x31A30E0
	|-NativeSlice<Vector2>.get_Stride
	|
	|-RVA: 0x31A35F0 Offset: 0x31A36F1 VA: 0x31A35F0
	|-NativeSlice<Vector3>.get_Stride
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A30F0 Offset: 0x31A31F1 VA: 0x31A30F0
	|-NativeSlice<Vector2>.get_Length
	|
	|-RVA: 0x31A3600 Offset: 0x31A3701 VA: 0x31A3600
	|-NativeSlice<Vector3>.get_Length
	*/

	// RVA: -1 Offset: -1
	public NativeSlice.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A3100 Offset: 0x31A3201 VA: 0x31A3100
	|-NativeSlice<Vector2>.GetEnumerator
	|
	|-RVA: 0x31A3610 Offset: 0x31A3711 VA: 0x31A3610
	|-NativeSlice<Vector3>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A3180 Offset: 0x31A3281 VA: 0x31A3180
	|-NativeSlice<Vector2>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x31A3690 Offset: 0x31A3791 VA: 0x31A3690
	|-NativeSlice<Vector3>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A3230 Offset: 0x31A3331 VA: 0x31A3230
	|-NativeSlice<Vector2>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x31A3740 Offset: 0x31A3841 VA: 0x31A3740
	|-NativeSlice<Vector3>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool Equals(NativeSlice<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A3310 Offset: 0x31A3411 VA: 0x31A3310
	|-NativeSlice<Vector2>.Equals
	|
	|-RVA: 0x31A3820 Offset: 0x31A3921 VA: 0x31A3820
	|-NativeSlice<Vector3>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A3350 Offset: 0x31A3451 VA: 0x31A3350
	|-NativeSlice<Vector2>.Equals
	|
	|-RVA: 0x31A3860 Offset: 0x31A3961 VA: 0x31A3860
	|-NativeSlice<Vector3>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A3490 Offset: 0x31A3591 VA: 0x31A3490
	|-NativeSlice<Vector2>.GetHashCode
	|
	|-RVA: 0x31A39A0 Offset: 0x31A3AA1 VA: 0x31A39A0
	|-NativeSlice<Vector3>.GetHashCode
	*/
}

