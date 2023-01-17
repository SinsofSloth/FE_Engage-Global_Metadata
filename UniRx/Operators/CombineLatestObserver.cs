// Namespace: UniRx.Operators
internal class CombineLatestObserver<T> : IObserver<T> // TypeDefIndex: 6912
{
	// Fields
	private readonly object gate; // 0x0
	private readonly ICombineLatestObservable parent; // 0x0
	private readonly int index; // 0x0
	private T value; // 0x0

	// Properties
	public T Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E4600 Offset: 0x30E4701 VA: 0x30E4600
	|-CombineLatestObserver<object>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object gate, ICombineLatestObservable parent, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E4610 Offset: 0x30E4711 VA: 0x30E4610
	|-CombineLatestObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E4670 Offset: 0x30E4771 VA: 0x30E4670
	|-CombineLatestObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E47E0 Offset: 0x30E48E1 VA: 0x30E47E0
	|-CombineLatestObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x30E4940 Offset: 0x30E4A41 VA: 0x30E4940
	|-CombineLatestObserver<object>.OnCompleted
	*/
}

