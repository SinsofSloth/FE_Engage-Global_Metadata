// Namespace: UniRx
public sealed class SerialDisposable : IDisposable, ICancelable // TypeDefIndex: 6538
{
	// Fields
	private readonly object gate; // 0x10
	private IDisposable current; // 0x18
	private bool disposed; // 0x20

	// Properties
	public bool IsDisposed { get; }
	public IDisposable Disposable { get; set; }

	// Methods

	// RVA: 0x1AF6F60 Offset: 0x1AF7061 VA: 0x1AF6F60 Slot: 5
	public bool get_IsDisposed() { }

	// RVA: 0x1AF7040 Offset: 0x1AF7141 VA: 0x1AF7040
	public IDisposable get_Disposable() { }

	// RVA: 0x1AF7050 Offset: 0x1AF7151 VA: 0x1AF7050
	public void set_Disposable(IDisposable value) { }

	// RVA: 0x1AF7250 Offset: 0x1AF7351 VA: 0x1AF7250 Slot: 4
	public void Dispose() { }

	// RVA: 0x1AF73D0 Offset: 0x1AF74D1 VA: 0x1AF73D0
	public void .ctor() { }
}

