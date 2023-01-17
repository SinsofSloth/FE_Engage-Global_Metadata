// Namespace: UniRx
public sealed class ScheduledDisposable : ICancelable, IDisposable // TypeDefIndex: 6537
{
	// Fields
	private readonly IScheduler scheduler; // 0x10
	private IDisposable disposable; // 0x18
	private int isDisposed; // 0x20

	// Properties
	public IScheduler Scheduler { get; }
	public IDisposable Disposable { get; }
	public bool IsDisposed { get; }

	// Methods

	// RVA: 0x1AF5350 Offset: 0x1AF5451 VA: 0x1AF5350
	public void .ctor(IScheduler scheduler, IDisposable disposable) { }

	// RVA: 0x1AF53B0 Offset: 0x1AF54B1 VA: 0x1AF53B0
	public IScheduler get_Scheduler() { }

	// RVA: 0x1AF53C0 Offset: 0x1AF54C1 VA: 0x1AF53C0
	public IDisposable get_Disposable() { }

	// RVA: 0x1AF53F0 Offset: 0x1AF54F1 VA: 0x1AF53F0 Slot: 4
	public bool get_IsDisposed() { }

	// RVA: 0x1AF5400 Offset: 0x1AF5501 VA: 0x1AF5400 Slot: 5
	public void Dispose() { }

	// RVA: 0x1AF5500 Offset: 0x1AF5601 VA: 0x1AF5500
	private void DisposeInner() { }
}

