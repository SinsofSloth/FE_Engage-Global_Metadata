// Namespace: System.Net.Sockets
public class TcpListener // TypeDefIndex: 2635
{
	// Fields
	private IPEndPoint m_ServerSocketEP; // 0x10
	private Socket m_ServerSocket; // 0x18
	private bool m_Active; // 0x20
	private bool m_ExclusiveAddressUse; // 0x21

	// Methods

	// RVA: 0x2D139A0 Offset: 0x2D13AA1 VA: 0x2D139A0
	public void .ctor(IPAddress localaddr, int port) { }

	// RVA: 0x2D13B50 Offset: 0x2D13C51 VA: 0x2D13B50
	public void Start() { }

	// RVA: 0x2D13B60 Offset: 0x2D13C61 VA: 0x2D13B60
	public void Start(int backlog) { }

	// RVA: 0x2D13D00 Offset: 0x2D13E01 VA: 0x2D13D00
	public void Stop() { }

	// RVA: 0x2D13E50 Offset: 0x2D13F51 VA: 0x2D13E50
	public Socket AcceptSocket() { }
}

