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
private class WhenAllObservable.WhenAll<T> : OperatorObserverBase<T[], T[]> // TypeDefIndex: 7127
{
	// Fields
	private readonly IObservable<T>[] sources; // 0x0
	private readonly object gate; // 0x0
	private int completedCount; // 0x0
	private int length; // 0x0
	private T[] values; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObservable<T>[] sources, IObserver<T[]> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDC570 Offset: 0x2FDC671 VA: 0x2FDC570
	|-WhenAllObservable.WhenAll<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDC630 Offset: 0x2FDC731 VA: 0x2FDC630
	|-WhenAllObservable.WhenAll<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDC9C0 Offset: 0x2FDCAC1 VA: 0x2FDC9C0
	|-WhenAllObservable.WhenAll<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDCA70 Offset: 0x2FDCB71 VA: 0x2FDCA70
	|-WhenAllObservable.WhenAll<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FDCBB0 Offset: 0x2FDCCB1 VA: 0x2FDCBB0
	|-WhenAllObservable.WhenAll<object>.OnCompleted
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
private class WhenAllObservable.WhenAll_<T> : OperatorObserverBase<T[], T[]> // TypeDefIndex: 7129
{
	// Fields
	private readonly IList<IObservable<T>> sources; // 0x0
	private readonly object gate; // 0x0
	private int completedCount; // 0x0
	private int length; // 0x0
	private T[] values; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IList<IObservable<T>> sources, IObserver<T[]> observer, IDisposable cancel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE1E30 Offset: 0x2FE1F31 VA: 0x2FE1E30
	|-WhenAllObservable.WhenAll_<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public IDisposable Run() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE1EF0 Offset: 0x2FE1FF1 VA: 0x2FE1EF0
	|-WhenAllObservable.WhenAll_<object>.Run
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override void OnNext(T[] value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2350 Offset: 0x2FE2451 VA: 0x2FE2350
	|-WhenAllObservable.WhenAll_<object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2400 Offset: 0x2FE2501 VA: 0x2FE2400
	|-WhenAllObservable.WhenAll_<object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FE2540 Offset: 0x2FE2641 VA: 0x2FE2540
	|-WhenAllObservable.WhenAll_<object>.OnCompleted
	*/
}

// Namespace: 
private class WhenAllObservable.WhenAll.WhenAllCollectionObserver : IObserver<Unit> // TypeDefIndex: 7131
{
	// Fields
	private readonly WhenAllObservable.WhenAll parent; // 0x10
	private bool isCompleted; // 0x18

	// Methods

	// RVA: 0x1B0C130 Offset: 0x1B0C231 VA: 0x1B0C130
	public void .ctor(WhenAllObservable.WhenAll parent) { }

	// RVA: 0x1B0E800 Offset: 0x1B0E901 VA: 0x1B0E800 Slot: 4
	public void OnNext(Unit value) { }

	// RVA: 0x1B0E810 Offset: 0x1B0E911 VA: 0x1B0E810 Slot: 5
	public void OnError(Exception error) { }

	// RVA: 0x1B0E900 Offset: 0x1B0EA01 VA: 0x1B0E900 Slot: 6
	public void OnCompleted() { }
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
private class WhenAllObservable.WhenAll_.WhenAllCollectionObserver : IObserver<Unit> // TypeDefIndex: 7133
{
	// Fields
	private readonly WhenAllObservable.WhenAll_ parent; // 0x10
	private bool isCompleted; // 0x18

	// Methods

	// RVA: 0x1B0C460 Offset: 0x1B0C561 VA: 0x1B0C460
	public void .ctor(WhenAllObservable.WhenAll_ parent) { }

	// RVA: 0x1B0EAD0 Offset: 0x1B0EBD1 VA: 0x1B0EAD0 Slot: 4
	public void OnNext(Unit value) { }

	// RVA: 0x1B0EAE0 Offset: 0x1B0EBE1 VA: 0x1B0EAE0 Slot: 5
	public void OnError(Exception error) { }

	// RVA: 0x1B0EBD0 Offset: 0x1B0ECD1 VA: 0x1B0EBD0 Slot: 6
	public void OnCompleted() { }
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

