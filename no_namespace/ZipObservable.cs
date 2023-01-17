// Namespace: 
private class ZipObservable.Zip.ZipObserver<T> : IObserver<T> // TypeDefIndex: 7155
{
	// Fields
	private readonly ZipObservable.Zip<T> parent; // 0x0
	private readonly int index; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ZipObservable.Zip<T> parent, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF8DD0 Offset: 0x3EF8ED1 VA: 0x3EF8DD0
	|-ZipObservable.Zip.ZipObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF8E20 Offset: 0x3EF8F21 VA: 0x3EF8E20
	|-ZipObservable.Zip.ZipObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception ex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF8F60 Offset: 0x3EF9061 VA: 0x3EF8F60
	|-ZipObservable.Zip.ZipObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF9050 Offset: 0x3EF9151 VA: 0x3EF9050
	|-ZipObservable.Zip.ZipObserver<object>.OnCompleted
	*/
}

