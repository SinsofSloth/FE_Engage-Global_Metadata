// Namespace: UniRx
public sealed class CancellationDisposable : ICancelable, IDisposable // TypeDefIndex: 6473
{
	// Fields
	private readonly CancellationTokenSource _cts; // 0x10

	// Properties
	public CancellationToken Token { get; }
	public bool IsDisposed { get; }

	// Methods

	// RVA: 0x19CDFB0 Offset: 0x19CE0B1 VA: 0x19CDFB0
	public void .ctor(CancellationTokenSource cts) { }

	// RVA: 0x19CE030 Offset: 0x19CE131 VA: 0x19CE030
	public void .ctor() { }

	// RVA: 0x19CE0A0 Offset: 0x19CE1A1 VA: 0x19CE0A0
	public CancellationToken get_Token() { }

	// RVA: 0x19CE0B0 Offset: 0x19CE1B1 VA: 0x19CE0B0 Slot: 5
	public void Dispose() { }

	// RVA: 0x19CE0C0 Offset: 0x19CE1C1 VA: 0x19CE0C0 Slot: 4
	public bool get_IsDisposed() { }
}

