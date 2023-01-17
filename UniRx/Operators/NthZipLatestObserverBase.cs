// Namespace: UniRx.Operators
internal abstract class NthZipLatestObserverBase<T> : OperatorObserverBase<T, T>, IZipLatestObservable // TypeDefIndex: 7194
{
	// Fields
	private readonly int length; // 0x0
	private readonly bool[] isStarted; // 0x0
	private readonly bool[] isCompleted; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int length, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A8DB0 Offset: 0x31A8EB1 VA: 0x31A8DB0
	|-NthZipLatestObserverBase<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public abstract T GetResult();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-NthZipLatestObserverBase<object>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Publish(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A8E80 Offset: 0x31A8F81 VA: 0x31A8E80
	|-NthZipLatestObserverBase<object>.Publish
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public void Done(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A9350 Offset: 0x31A9451 VA: 0x31A9350
	|-NthZipLatestObserverBase<object>.Done
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Fail(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x31A94E0 Offset: 0x31A95E1 VA: 0x31A94E0
	|-NthZipLatestObserverBase<object>.Fail
	*/
}

