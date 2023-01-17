// Namespace: UniRx
public sealed class SingleAssignmentDisposable : IDisposable, ICancelable // TypeDefIndex: 6539
{
	// Fields
	private readonly object gate; // 0x10
	private IDisposable current; // 0x18
	private bool disposed; // 0x20

	// Properties
	public bool IsDisposed { get; }
	public IDisposable Disposable { get; set; }

	// Methods

	// RVA: 0x1AF7450 Offset: 0x1AF7551 VA: 0x1AF7450 Slot: 5
	public bool get_IsDisposed() { }

	// RVA: 0x1AF7530 Offset: 0x1AF7631 VA: 0x1AF7530
	public IDisposable get_Disposable() { }

	// RVA: 0x1AF7540 Offset: 0x1AF7641 VA: 0x1AF7540
	public void set_Disposable(IDisposable value) { }

	// RVA: 0x1AF7760 Offset: 0x1AF7861 VA: 0x1AF7760 Slot: 4
	public void Dispose() { }

	// RVA: 0x1AF78E0 Offset: 0x1AF79E1 VA: 0x1AF78E0
	public void .ctor() { }
}

