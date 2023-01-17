// Namespace: UniRx.Operators
internal class ZipObserver<T> : IObserver<T> // TypeDefIndex: 7170
{
	// Fields
	private readonly object gate; // 0x0
	private readonly IZipObservable parent; // 0x0
	private readonly int index; // 0x0
	private readonly Queue<T> queue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object gate, IZipObservable parent, int index, Queue<T> queue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF91B0 Offset: 0x3EF92B1 VA: 0x3EF91B0
	|-ZipObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF9230 Offset: 0x3EF9331 VA: 0x3EF9230
	|-ZipObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF93B0 Offset: 0x3EF94B1 VA: 0x3EF93B0
	|-ZipObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF9510 Offset: 0x3EF9611 VA: 0x3EF9510
	|-ZipObserver<object>.OnCompleted
	*/
}

