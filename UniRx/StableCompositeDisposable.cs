// Namespace: UniRx
public abstract class StableCompositeDisposable : ICancelable, IDisposable // TypeDefIndex: 6545
{
	// Properties
	public abstract bool IsDisposed { get; }

	// Methods

	// RVA: 0x1AF7960 Offset: 0x1AF7A61 VA: 0x1AF7960
	public static ICancelable Create(IDisposable disposable1, IDisposable disposable2) { }

	// RVA: 0x1AF7AD0 Offset: 0x1AF7BD1 VA: 0x1AF7AD0
	public static ICancelable Create(IDisposable disposable1, IDisposable disposable2, IDisposable disposable3) { }

	// RVA: 0x1AF7CA0 Offset: 0x1AF7DA1 VA: 0x1AF7CA0
	public static ICancelable Create(IDisposable disposable1, IDisposable disposable2, IDisposable disposable3, IDisposable disposable4) { }

	// RVA: 0x1AF7ED0 Offset: 0x1AF7FD1 VA: 0x1AF7ED0
	public static ICancelable Create(IDisposable[] disposables) { }

	// RVA: 0x1AF7F90 Offset: 0x1AF8091 VA: 0x1AF7F90
	public static ICancelable CreateUnsafe(IDisposable[] disposables) { }

	// RVA: 0x1AF8050 Offset: 0x1AF8151 VA: 0x1AF8050
	public static ICancelable Create(IEnumerable<IDisposable> disposables) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Dispose();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_IsDisposed();

	// RVA: 0x1AF8240 Offset: 0x1AF8341 VA: 0x1AF8240
	protected void .ctor() { }
}

