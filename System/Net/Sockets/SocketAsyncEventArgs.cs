// Namespace: System.Net.Sockets
public class SocketAsyncEventArgs : EventArgs, IDisposable // TypeDefIndex: 2637
{
	// Fields
	private bool disposed; // 0x10
	internal int in_progress; // 0x14
	internal EndPoint remote_ep; // 0x18
	internal Socket current_socket; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x31AC0 Offset: 0x31BC1 VA: 0x31AC0
	private Socket <AcceptSocket>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x31AD0 Offset: 0x31BD1 VA: 0x31AD0
	private int <BytesTransferred>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x31AE0 Offset: 0x31BE1 VA: 0x31AE0
	private SocketError <SocketError>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x31AF0 Offset: 0x31BF1 VA: 0x31AF0
	private EventHandler<SocketAsyncEventArgs> Completed; // 0x38

	// Properties
	public Socket AcceptSocket { get; set; }
	internal int BytesTransferred { set; }
	public SocketError SocketError { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x338E0 Offset: 0x339E1 VA: 0x338E0
	// RVA: 0x2D10B90 Offset: 0x2D10C91 VA: 0x2D10B90
	public Socket get_AcceptSocket() { }

	[CompilerGeneratedAttribute] // RVA: 0x338F0 Offset: 0x339F1 VA: 0x338F0
	// RVA: 0x2D10BA0 Offset: 0x2D10CA1 VA: 0x2D10BA0
	public void set_AcceptSocket(Socket value) { }

	[CompilerGeneratedAttribute] // RVA: 0x33900 Offset: 0x33A01 VA: 0x33900
	// RVA: 0x2D10BB0 Offset: 0x2D10CB1 VA: 0x2D10BB0
	internal void set_BytesTransferred(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x33910 Offset: 0x33A11 VA: 0x33910
	// RVA: 0x2D10BC0 Offset: 0x2D10CC1 VA: 0x2D10BC0
	public void set_SocketError(SocketError value) { }

	// RVA: 0x2D10BD0 Offset: 0x2D10CD1 VA: 0x2D10BD0
	private void Dispose(bool disposing) { }

	// RVA: 0x2D10BF0 Offset: 0x2D10CF1 VA: 0x2D10BF0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2D10C70 Offset: 0x2D10D71 VA: 0x2D10C70
	internal void Complete() { }

	// RVA: 0x2D10C80 Offset: 0x2D10D81 VA: 0x2D10C80 Slot: 5
	protected virtual void OnCompleted(SocketAsyncEventArgs e) { }
}

