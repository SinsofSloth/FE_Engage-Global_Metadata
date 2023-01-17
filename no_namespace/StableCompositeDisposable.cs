// Namespace: 
private class StableCompositeDisposable.NAry : StableCompositeDisposable // TypeDefIndex: 6543
{
	// Fields
	private int disposedCallCount; // 0x10
	private List<IDisposable> _disposables; // 0x18

	// Properties
	public override bool IsDisposed { get; }

	// Methods

	// RVA: 0x1AF7F80 Offset: 0x1AF8081 VA: 0x1AF7F80
	public void .ctor(IDisposable[] disposables) { }

	// RVA: 0x1AF8100 Offset: 0x1AF8201 VA: 0x1AF8100
	public void .ctor(IEnumerable<IDisposable> disposables) { }

	// RVA: 0x1B09D80 Offset: 0x1B09E81 VA: 0x1B09D80 Slot: 7
	public override bool get_IsDisposed() { }

	// RVA: 0x1B09D90 Offset: 0x1B09E91 VA: 0x1B09D90 Slot: 6
	public override void Dispose() { }
}

