// Namespace: System.Net.Security
public abstract class AuthenticatedStream : Stream // TypeDefIndex: 2643
{
	// Fields
	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Properties
	protected Stream InnerStream { get; }
	public abstract bool IsAuthenticated { get; }

	// Methods

	// RVA: 0x1B3ED70 Offset: 0x1B3EE71 VA: 0x1B3ED70
	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x1B3EF40 Offset: 0x1B3F041 VA: 0x1B3EF40
	protected Stream get_InnerStream() { }

	// RVA: 0x1B3EF50 Offset: 0x1B3F051 VA: 0x1B3EF50 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract bool get_IsAuthenticated();
}

