// Namespace: 
private class SkipObservable.Skip_<T> : OperatorObserverBase<T, T> // TypeDefIndex: 7063
{
	// Fields
	private readonly SkipObservable<T> parent; // 0x0
	private bool open; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(SkipObservable<T> parent, IObserver<T> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3443C40 Offset: 0x3443D41 VA: 0x3443C40
	|-SkipObservable.Skip_<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3443C90 Offset: 0x3443D91 VA: 0x3443C90
	|-SkipObservable.Skip_<object>.Run
	*/

	// RVA: -1 Offset: -1
	private void Tick() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3443E20 Offset: 0x3443F21 VA: 0x3443E20
	|-SkipObservable.Skip_<object>.Tick
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3443E50 Offset: 0x3443F51 VA: 0x3443E50
	|-SkipObservable.Skip_<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3443F20 Offset: 0x3444021 VA: 0x3443F20
	|-SkipObservable.Skip_<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3444060 Offset: 0x3444161 VA: 0x3444060
	|-SkipObservable.Skip_<object>.OnCompleted
	*/
}

