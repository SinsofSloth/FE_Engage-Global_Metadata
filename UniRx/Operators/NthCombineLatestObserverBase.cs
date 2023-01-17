// Namespace: UniRx.Operators
internal abstract class NthCombineLatestObserverBase<T> : OperatorObserverBase<T, T>, ICombineLatestObservable // TypeDefIndex: 6911
{
	// Fields
	private readonly int length; // 0x0
	private bool isAllValueStarted; // 0x0
	private readonly bool[] isStarted; // 0x0
	private readonly bool[] isCompleted; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A8500 Offset: 0x31A8601 VA: 0x31A8500
	|-NthCombineLatestObserverBase<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public abstract T GetResult();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-NthCombineLatestObserverBase<object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Publish(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A85D0 Offset: 0x31A86D1 VA: 0x31A85D0
	|-NthCombineLatestObserverBase<object>.Publish
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public void Done(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A8AE0 Offset: 0x31A8BE1 VA: 0x31A8AE0
	|-NthCombineLatestObserverBase<object>.Done
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Fail(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A8C70 Offset: 0x31A8D71 VA: 0x31A8C70
	|-NthCombineLatestObserverBase<object>.Fail
	*/
}

