// Namespace: 
private class StableCompositeDisposable.Binary : StableCompositeDisposable // TypeDefIndex: 6540
{
	// Fields
	private int disposedCallCount; // 0x10
	private IDisposable _disposable1; // 0x18
	private IDisposable _disposable2; // 0x20

	// Properties
	public override bool IsDisposed { get; }

	// Methods

	// RVA: 0x1AF7A70 Offset: 0x1AF7B71 VA: 0x1AF7A70
	public void .ctor(IDisposable disposable1, IDisposable disposable2) { }

	// RVA: 0x1B09C40 Offset: 0x1B09D41 VA: 0x1B09C40 Slot: 7
	public override bool get_IsDisposed() { }

	// RVA: 0x1B09C50 Offset: 0x1B09D51 VA: 0x1B09C50 Slot: 6
	public override void Dispose() { }
}

// Namespace: 
private class StableCompositeDisposable.Quaternary : StableCompositeDisposable // TypeDefIndex: 6542
{
	// Fields
	private int disposedCallCount; // 0x10
	private IDisposable _disposable1; // 0x18
	private IDisposable _disposable2; // 0x20
	private IDisposable _disposable3; // 0x28
	private IDisposable _disposable4; // 0x30

	// Properties
	public override bool IsDisposed { get; }

	// Methods

	// RVA: 0x1AF7E30 Offset: 0x1AF7F31 VA: 0x1AF7E30
	public void .ctor(IDisposable disposable1, IDisposable disposable2, IDisposable disposable3, IDisposable disposable4) { }

	// RVA: 0x1B0A050 Offset: 0x1B0A151 VA: 0x1B0A050 Slot: 7
	public override bool get_IsDisposed() { }

	// RVA: 0x1B0A060 Offset: 0x1B0A161 VA: 0x1B0A060 Slot: 6
	public override void Dispose() { }
}

// Namespace: 
private class StableCompositeDisposable.NAryUnsafe : StableCompositeDisposable // TypeDefIndex: 6544
{
	// Fields
	private int disposedCallCount; // 0x10
	private IDisposable[] _disposables; // 0x18

	// Properties
	public override bool IsDisposed { get; }

	// Methods

	// RVA: 0x1AF8010 Offset: 0x1AF8111 VA: 0x1AF8010
	public void .ctor(IDisposable[] disposables) { }

	// RVA: 0x1B09F20 Offset: 0x1B0A021 VA: 0x1B09F20 Slot: 7
	public override bool get_IsDisposed() { }

	// RVA: 0x1B09F30 Offset: 0x1B0A031 VA: 0x1B09F30 Slot: 6
	public override void Dispose() { }
}

