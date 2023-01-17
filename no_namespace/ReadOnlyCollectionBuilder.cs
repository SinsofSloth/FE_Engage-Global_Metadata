// Namespace: 
[Serializable]
private class ReadOnlyCollectionBuilder.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 3267
{
	// Fields
	private readonly ReadOnlyCollectionBuilder<T> _builder; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ReadOnlyCollectionBuilder<T> builder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB9B00 Offset: 0x2EB9C01 VA: 0x2EB9B00
	|-ReadOnlyCollectionBuilder.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB9B50 Offset: 0x2EB9C51 VA: 0x2EB9B50
	|-ReadOnlyCollectionBuilder.Enumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB9B60 Offset: 0x2EB9C61 VA: 0x2EB9B60
	|-ReadOnlyCollectionBuilder.Enumerator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB9B70 Offset: 0x2EB9C71 VA: 0x2EB9B70
	|-ReadOnlyCollectionBuilder.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB9BD0 Offset: 0x2EB9CD1 VA: 0x2EB9BD0
	|-ReadOnlyCollectionBuilder.Enumerator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2EB9C90 Offset: 0x2EB9D91 VA: 0x2EB9C90
	|-ReadOnlyCollectionBuilder.Enumerator<object>.System.Collections.IEnumerator.Reset
	*/
}

