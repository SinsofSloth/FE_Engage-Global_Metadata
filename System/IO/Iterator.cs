// Namespace: System.IO
internal abstract class Iterator<TSource> : IEnumerable<TSource>, IEnumerable, IEnumerator<TSource>, IDisposable, IEnumerator // TypeDefIndex: 625
{
	// Fields
	private int threadId; // 0x0
	internal int state; // 0x0
	internal TSource current; // 0x0

	// Properties
	public TSource Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7E530 Offset: 0x2F7E631 VA: 0x2F7E530
	|-Iterator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public TSource get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7E570 Offset: 0x2F7E671 VA: 0x2F7E570
	|-Iterator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract Iterator<TSource> Clone();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Iterator<object>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7E580 Offset: 0x2F7E681 VA: 0x2F7E580
	|-Iterator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7E600 Offset: 0x2F7E701 VA: 0x2F7E600
	|-Iterator<object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<TSource> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7E610 Offset: 0x2F7E711 VA: 0x2F7E610
	|-Iterator<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool MoveNext();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Iterator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7E670 Offset: 0x2F7E771 VA: 0x2F7E670
	|-Iterator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7E690 Offset: 0x2F7E791 VA: 0x2F7E690
	|-Iterator<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2F7E6B0 Offset: 0x2F7E7B1 VA: 0x2F7E6B0
	|-Iterator<object>.System.Collections.IEnumerator.Reset
	*/
}

