// Namespace: 
private class SubjectExtensions.AnonymousSubject<T, U> : ISubject<T, U>, IObserver<T>, IObservable<U> // TypeDefIndex: 6645
{
	// Fields
	private readonly IObserver<T> observer; // 0x0
	private readonly IObservable<U> observable; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObserver<T> observer, IObservable<U> observable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8410 Offset: 0x1FF8511 VA: 0x1FF8410
	|-SubjectExtensions.AnonymousSubject<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void OnCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8460 Offset: 0x1FF8561 VA: 0x1FF8460
	|-SubjectExtensions.AnonymousSubject<object, object>.OnCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void OnError(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF84F0 Offset: 0x1FF85F1 VA: 0x1FF84F0
	|-SubjectExtensions.AnonymousSubject<object, object>.OnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void OnNext(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF85E0 Offset: 0x1FF86E1 VA: 0x1FF85E0
	|-SubjectExtensions.AnonymousSubject<object, object>.OnNext
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public IDisposable Subscribe(IObserver<U> observer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8680 Offset: 0x1FF8781 VA: 0x1FF8680
	|-SubjectExtensions.AnonymousSubject<object, object>.Subscribe
	*/
}

// Namespace: 
private class SubjectExtensions.AnonymousSubject<T> : SubjectExtensions.AnonymousSubject<T, T>, ISubject<T>, ISubject<T, T>, IObserver<T>, IObservable<T> // TypeDefIndex: 6646
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IObserver<T> observer, IObservable<T> observable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF83F0 Offset: 0x1FF84F1 VA: 0x1FF83F0
	|-SubjectExtensions.AnonymousSubject<object>..ctor
	*/
}

