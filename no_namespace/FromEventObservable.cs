// Namespace: 
private class FromEventObservable_.FromEvent<T> : IDisposable // TypeDefIndex: 6977
{
	// Fields
	private readonly FromEventObservable_<T> parent; // 0x0
	private readonly IObserver<T> observer; // 0x0
	private Action<T> handler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(FromEventObservable_<T> parent, IObserver<T> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E1860 Offset: 0x33E1961 VA: 0x33E1860
	|-FromEventObservable_.FromEvent<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Register() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E1910 Offset: 0x33E1A11 VA: 0x33E1910
	|-FromEventObservable_.FromEvent<object>.Register
	*/

	// RVA: -1 Offset: -1
	private void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E1A70 Offset: 0x33E1B71 VA: 0x33E1A70
	|-FromEventObservable_.FromEvent<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E1B10 Offset: 0x33E1C11 VA: 0x33E1B10
	|-FromEventObservable_.FromEvent<object>.Dispose
	*/
}

