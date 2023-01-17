// Namespace: UniRx
public sealed class MultipleAssignmentDisposable : IDisposable, ICancelable // TypeDefIndex: 6483
{
	// Fields
	private static readonly BooleanDisposable True; // 0x0
	private object gate; // 0x10
	private IDisposable current; // 0x18

	// Properties
	public bool IsDisposed { get; }
	public IDisposable Disposable { get; set; }

	// Methods

	// RVA: 0x19D6A00 Offset: 0x19D6B01 VA: 0x19D6A00 Slot: 5
	public bool get_IsDisposed() { }

	// RVA: 0x19D6B30 Offset: 0x19D6C31 VA: 0x19D6B30
	public IDisposable get_Disposable() { }

	// RVA: 0x19D6CB0 Offset: 0x19D6DB1 VA: 0x19D6CB0
	public void set_Disposable(IDisposable value) { }

	// RVA: 0x19D6E90 Offset: 0x19D6F91 VA: 0x19D6E90 Slot: 4
	public void Dispose() { }

	// RVA: 0x19D7080 Offset: 0x19D7181 VA: 0x19D7080
	public void .ctor() { }

	// RVA: 0x19D7100 Offset: 0x19D7201 VA: 0x19D7100
	private static void .cctor() { }
}

