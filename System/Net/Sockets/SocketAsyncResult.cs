// Namespace: System.Net.Sockets
internal sealed class SocketAsyncResult : IOAsyncResult // TypeDefIndex: 2639
{
	// Fields
	public Socket socket; // 0x30
	public SocketOperation operation; // 0x38
	private Exception DelayedException; // 0x40
	public EndPoint EndPoint; // 0x48
	public byte[] Buffer; // 0x50
	public int Offset; // 0x58
	public int Size; // 0x5C
	public SocketFlags SockFlags; // 0x60
	public Socket AcceptSocket; // 0x68
	public IPAddress[] Addresses; // 0x70
	public int Port; // 0x78
	public IList<ArraySegment<byte>> Buffers; // 0x80
	public bool ReuseSocket; // 0x88
	public int CurrentAddress; // 0x8C
	public Socket AcceptedSocket; // 0x90
	public int Total; // 0x98
	internal int error; // 0x9C
	public int EndCalled; // 0xA0

	// Properties
	public IntPtr Handle { get; }
	public SocketError ErrorCode { get; }

	// Methods

	// RVA: 0x2D0DE00 Offset: 0x2D0DF01 VA: 0x2D0DE00
	public IntPtr get_Handle() { }

	// RVA: 0x2D0D650 Offset: 0x2D0D751 VA: 0x2D0D650
	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x2D0E6E0 Offset: 0x2D0E7E1 VA: 0x2D0E6E0
	public SocketError get_ErrorCode() { }

	// RVA: 0x2D0CB50 Offset: 0x2D0CC51 VA: 0x2D0CB50
	public void CheckIfThrowDelayedException() { }

	// RVA: 0x2D10D00 Offset: 0x2D10E01 VA: 0x2D10D00 Slot: 8
	internal override void CompleteDisposed() { }

	// RVA: 0x2D10D10 Offset: 0x2D10E11 VA: 0x2D10D10
	public void Complete() { }

	// RVA: 0x2D0DDF0 Offset: 0x2D0DEF1 VA: 0x2D0DDF0
	public void Complete(bool synch) { }

	// RVA: 0x2D0F080 Offset: 0x2D0F181 VA: 0x2D0F080
	public void Complete(int total) { }

	// RVA: 0x2D0DDB0 Offset: 0x2D0DEB1 VA: 0x2D0DDB0
	public void Complete(Exception e, bool synch) { }

	// RVA: 0x2D0F050 Offset: 0x2D0F151 VA: 0x2D0F050
	public void Complete(Exception e) { }

	// RVA: 0x2D10F10 Offset: 0x2D11011 VA: 0x2D10F10
	public void Complete(Socket s) { }

	// RVA: 0x2D10F40 Offset: 0x2D11041 VA: 0x2D10F40
	public void Complete(Socket s, int total) { }
}

