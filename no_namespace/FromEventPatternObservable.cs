// Namespace: 
private class FromEventPatternObservable.FromEventPattern<TDelegate, TEventArgs> : IDisposable // TypeDefIndex: 6969
{
	// Fields
	private readonly FromEventPatternObservable<TDelegate, TEventArgs> parent; // 0x0
	private readonly IObserver<EventPattern<TEventArgs>> observer; // 0x0
	private TDelegate handler; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(FromEventPatternObservable<TDelegate, TEventArgs> parent, IObserver<EventPattern<TEventArgs>> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E3810 Offset: 0x33E3911 VA: 0x33E3810
	|-FromEventPatternObservable.FromEventPattern<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Register() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E3860 Offset: 0x33E3961 VA: 0x33E3860
	|-FromEventPatternObservable.FromEventPattern<object, object>.Register
	*/

	// RVA: -1 Offset: -1
	private void OnNext(object sender, TEventArgs eventArgs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E3A30 Offset: 0x33E3B31 VA: 0x33E3A30
	|-FromEventPatternObservable.FromEventPattern<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x33E3B20 Offset: 0x33E3C21 VA: 0x33E3B20
	|-FromEventPatternObservable.FromEventPattern<object, object>.Dispose
	*/
}

