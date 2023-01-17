// Namespace: UniRx
public sealed class RefCountDisposable : ICancelable, IDisposable // TypeDefIndex: 6485
{
	// Fields
	private readonly object _gate; // 0x10
	private IDisposable _disposable; // 0x18
	private bool _isPrimaryDisposed; // 0x20
	private int _count; // 0x24

	// Properties
	public bool IsDisposed { get; }

	// Methods

	// RVA: 0x1AF4CC0 Offset: 0x1AF4DC1 VA: 0x1AF4CC0
	public void .ctor(IDisposable disposable) { }

	// RVA: 0x1AF4DB0 Offset: 0x1AF4EB1 VA: 0x1AF4DB0 Slot: 4
	public bool get_IsDisposed() { }

	// RVA: 0x1AF4DC0 Offset: 0x1AF4EC1 VA: 0x1AF4DC0
	public IDisposable GetDisposable() { }

	// RVA: 0x1AF5020 Offset: 0x1AF5121 VA: 0x1AF5020 Slot: 5
	public void Dispose() { }

	// RVA: 0x1AF51B0 Offset: 0x1AF52B1 VA: 0x1AF51B0
	private void Release() { }
}

