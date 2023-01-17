// Namespace: 
private class WhenAllObservable.WhenAll.WhenAllCollectionObserver<T> : IObserver<T> // TypeDefIndex: 7126
{
	// Fields
	private readonly WhenAllObservable.WhenAll<T> parent; // 0x0
	private readonly int index; // 0x0
	private bool isCompleted; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(WhenAllObservable.WhenAll<T> parent, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDCCE0 Offset: 0x2FDCDE1 VA: 0x2FDCCE0
	|-WhenAllObservable.WhenAll.WhenAllCollectionObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDCD30 Offset: 0x2FDCE31 VA: 0x2FDCD30
	|-WhenAllObservable.WhenAll.WhenAllCollectionObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDCE40 Offset: 0x2FDCF41 VA: 0x2FDCE40
	|-WhenAllObservable.WhenAll.WhenAllCollectionObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDCF30 Offset: 0x2FDD031 VA: 0x2FDCF30
	|-WhenAllObservable.WhenAll.WhenAllCollectionObserver<object>.OnCompleted
	*/
}

// Namespace: 
private class WhenAllObservable.WhenAll_.WhenAllCollectionObserver<T> : IObserver<T> // TypeDefIndex: 7128
{
	// Fields
	private readonly WhenAllObservable.WhenAll_<T> parent; // 0x0
	private readonly int index; // 0x0
	private bool isCompleted; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(WhenAllObservable.WhenAll_<T> parent, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDD050 Offset: 0x2FDD151 VA: 0x2FDD050
	|-WhenAllObservable.WhenAll_.WhenAllCollectionObserver<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDD0A0 Offset: 0x2FDD1A1 VA: 0x2FDD0A0
	|-WhenAllObservable.WhenAll_.WhenAllCollectionObserver<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDD1B0 Offset: 0x2FDD2B1 VA: 0x2FDD1B0
	|-WhenAllObservable.WhenAll_.WhenAllCollectionObserver<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDD2A0 Offset: 0x2FDD3A1 VA: 0x2FDD2A0
	|-WhenAllObservable.WhenAll_.WhenAllCollectionObserver<object>.OnCompleted
	*/
}

// Namespace: 
private class WhenAllObservable.WhenAll : OperatorObserverBase<Unit, Unit> // TypeDefIndex: 7132
{
	// Fields
	private readonly IObservable<Unit>[] sources; // 0x20
	private readonly object gate; // 0x28
	private int completedCount; // 0x30
	private int length; // 0x34

	// Methods

	// RVA: 0x1AFC760 Offset: 0x1AFC861 VA: 0x1AFC760
	public void .ctor(IObservable<Unit>[] sources, IObserver<Unit> observer, IDisposable cancel) { }

	// RVA: 0x1AFC820 Offset: 0x1AFC921 VA: 0x1AFC820
	public IDisposable Run() { }

	// RVA: 0x1B0C170 Offset: 0x1B0C271 VA: 0x1B0C170 Slot: 8
	public override void OnNext(Unit value) { }

	// RVA: 0x1B0C230 Offset: 0x1B0C331 VA: 0x1B0C230 Slot: 9
	public override void OnError(Exception error) { }

	// RVA: 0x1B0C350 Offset: 0x1B0C451 VA: 0x1B0C350 Slot: 10
	public override void OnCompleted() { }
}

// Namespace: 
private class WhenAllObservable.WhenAll_ : OperatorObserverBase<Unit, Unit> // TypeDefIndex: 7134
{
	// Fields
	private readonly IList<IObservable<Unit>> sources; // 0x20
	private readonly object gate; // 0x28
	private int completedCount; // 0x30
	private int length; // 0x34

	// Methods

	// RVA: 0x1AFCBE0 Offset: 0x1AFCCE1 VA: 0x1AFCBE0
	public void .ctor(IList<IObservable<Unit>> sources, IObserver<Unit> observer, IDisposable cancel) { }

	// RVA: 0x1AFCCA0 Offset: 0x1AFCDA1 VA: 0x1AFCCA0
	public IDisposable Run() { }

	// RVA: 0x1B0C4A0 Offset: 0x1B0C5A1 VA: 0x1B0C4A0 Slot: 8
	public override void OnNext(Unit value) { }

	// RVA: 0x1B0C560 Offset: 0x1B0C661 VA: 0x1B0C560 Slot: 9
	public override void OnError(Exception error) { }

	// RVA: 0x1B0C680 Offset: 0x1B0C781 VA: 0x1B0C680 Slot: 10
	public override void OnCompleted() { }
}

