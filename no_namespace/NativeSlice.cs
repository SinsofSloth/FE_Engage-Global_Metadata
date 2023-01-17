// Namespace: 
[ExcludeFromDocsAttribute] // RVA: 0x43B490 Offset: 0x43B591 VA: 0x43B490
public struct NativeSlice.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 3368
{
	// Fields
	private NativeSlice<T> m_Array; // 0x0
	private int m_Index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ref NativeSlice<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E04CC0 Offset: 0x2E04DC1 VA: 0x2E04CC0
	|-NativeSlice.Enumerator<Vector2>..ctor
	|
	|-RVA: 0x2E05240 Offset: 0x2E05341 VA: 0x2E05240
	|-NativeSlice.Enumerator<Vector3>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E04CE0 Offset: 0x2E04DE1 VA: 0x2E04CE0
	|-NativeSlice.Enumerator<Vector2>.Dispose
	|
	|-RVA: 0x2E05260 Offset: 0x2E05361 VA: 0x2E05260
	|-NativeSlice.Enumerator<Vector3>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E04CF0 Offset: 0x2E04DF1 VA: 0x2E04CF0
	|-NativeSlice.Enumerator<Vector2>.MoveNext
	|
	|-RVA: 0x2E05270 Offset: 0x2E05371 VA: 0x2E05270
	|-NativeSlice.Enumerator<Vector3>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E04D50 Offset: 0x2E04E51 VA: 0x2E04D50
	|-NativeSlice.Enumerator<Vector2>.Reset
	|
	|-RVA: 0x2E052D0 Offset: 0x2E053D1 VA: 0x2E052D0
	|-NativeSlice.Enumerator<Vector3>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E04D60 Offset: 0x2E04E61 VA: 0x2E04D60
	|-NativeSlice.Enumerator<Vector2>.get_Current
	|
	|-RVA: 0x2E052E0 Offset: 0x2E053E1 VA: 0x2E052E0
	|-NativeSlice.Enumerator<Vector3>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2E04DB0 Offset: 0x2E04EB1 VA: 0x2E04DB0
	|-NativeSlice.Enumerator<Vector2>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x2E05330 Offset: 0x2E05431 VA: 0x2E05330
	|-NativeSlice.Enumerator<Vector3>.System.Collections.IEnumerator.get_Current
	*/
}

