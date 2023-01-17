// Namespace: UniRx.Operators
internal class ZipLatestObserver<T> : IObserver<T> // TypeDefIndex: 7195
{
	// Fields
	private readonly object gate; // 0x0
	private readonly IZipLatestObservable parent; // 0x0
	private readonly int index; // 0x0
	private T value; // 0x0

	// Properties
	public T Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7CF0 Offset: 0x3EF7DF1 VA: 0x3EF7CF0
	|-ZipLatestObserver<object>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object gate, IZipLatestObservable parent, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7D00 Offset: 0x3EF7E01 VA: 0x3EF7D00
	|-ZipLatestObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7D60 Offset: 0x3EF7E61 VA: 0x3EF7D60
	|-ZipLatestObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF7ED0 Offset: 0x3EF7FD1 VA: 0x3EF7ED0
	|-ZipLatestObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3EF8030 Offset: 0x3EF8131 VA: 0x3EF8030
	|-ZipLatestObserver<object>.OnCompleted
	*/
}

