// Namespace: 
private class Disposable.EmptyDisposable : IDisposable // TypeDefIndex: 6476
{
	// Fields
	public static Disposable.EmptyDisposable Singleton; // 0x0

	// Methods

	// RVA: 0x1AFDD90 Offset: 0x1AFDE91 VA: 0x1AFDD90
	private void .ctor() { }

	// RVA: 0x1AFDDA0 Offset: 0x1AFDEA1 VA: 0x1AFDDA0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1AFDDB0 Offset: 0x1AFDEB1 VA: 0x1AFDDB0
	private static void .cctor() { }
}

// Namespace: 
private class Disposable.AnonymousDisposable : IDisposable // TypeDefIndex: 6477
{
	// Fields
	private bool isDisposed; // 0x10
	private readonly Action dispose; // 0x18

	// Methods

	// RVA: 0x1AFDD30 Offset: 0x1AFDE31 VA: 0x1AFDD30
	public void .ctor(Action dispose) { }

	// RVA: 0x1AFDD70 Offset: 0x1AFDE71 VA: 0x1AFDD70 Slot: 4
	public void Dispose() { }
}

// Namespace: 
private class Disposable.AnonymousDisposable<T> : IDisposable // TypeDefIndex: 6478
{
	// Fields
	private bool isDisposed; // 0x0
	private readonly T state; // 0x0
	private readonly Action<T> dispose; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T state, Action<T> dispose) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF8190 Offset: 0x1FF8291 VA: 0x1FF8190
	|-Disposable.AnonymousDisposable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1FF81E0 Offset: 0x1FF82E1 VA: 0x1FF81E0
	|-Disposable.AnonymousDisposable<object>.Dispose
	*/
}

