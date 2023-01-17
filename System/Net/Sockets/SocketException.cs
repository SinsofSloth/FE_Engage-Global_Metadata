// Namespace: System.Net.Sockets
[Serializable]
public class SocketException : Win32Exception // TypeDefIndex: 2615
{
	// Fields
	private EndPoint m_EndPoint; // 0x90

	// Properties
	public override string Message { get; }
	public SocketError SocketErrorCode { get; }

	// Methods

	// RVA: 0x2D10FF0 Offset: 0x2D110F1 VA: 0x2D10FF0
	private static int WSAGetLastError_internal() { }

	// RVA: 0x2D08D70 Offset: 0x2D08E71 VA: 0x2D08D70
	public void .ctor() { }

	// RVA: 0x2D11000 Offset: 0x2D11101 VA: 0x2D11000
	internal void .ctor(int error, string message) { }

	// RVA: 0x2D048F0 Offset: 0x2D049F1 VA: 0x2D048F0
	public void .ctor(int errorCode) { }

	// RVA: 0x2D09D60 Offset: 0x2D09E61 VA: 0x2D09D60
	internal void .ctor(SocketError socketError) { }

	// RVA: 0x2D11090 Offset: 0x2D11191 VA: 0x2D11090
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x2D11120 Offset: 0x2D11221 VA: 0x2D11120 Slot: 5
	public override string get_Message() { }

	// RVA: 0x2D10CF0 Offset: 0x2D10DF1 VA: 0x2D10CF0
	public SocketError get_SocketErrorCode() { }
}

