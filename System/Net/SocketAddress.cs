// Namespace: System.Net
[DefaultMemberAttribute] // RVA: 0x30E60 Offset: 0x30F61 VA: 0x30E60
public class SocketAddress // TypeDefIndex: 2473
{
	// Fields
	internal int m_Size; // 0x10
	internal byte[] m_Buffer; // 0x18
	private bool m_changed; // 0x20
	private int m_hash; // 0x24

	// Properties
	public AddressFamily Family { get; }
	public int Size { get; }
	public byte Item { get; }

	// Methods

	// RVA: 0x2D0FE20 Offset: 0x2D0FF21 VA: 0x2D0FE20
	public AddressFamily get_Family() { }

	// RVA: 0x2D0FE60 Offset: 0x2D0FF61 VA: 0x2D0FE60
	public int get_Size() { }

	// RVA: 0x2D0FE70 Offset: 0x2D0FF71 VA: 0x2D0FE70
	public byte get_Item(int offset) { }

	// RVA: 0x2D0FEF0 Offset: 0x2D0FFF1 VA: 0x2D0FEF0
	public void .ctor(AddressFamily family, int size) { }

	// RVA: 0x2D10030 Offset: 0x2D10131 VA: 0x2D10030
	internal void .ctor(IPAddress ipAddress) { }

	// RVA: 0x2D10240 Offset: 0x2D10341 VA: 0x2D10240
	internal void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0x2D102A0 Offset: 0x2D103A1 VA: 0x2D102A0
	internal IPAddress GetIPAddress() { }

	// RVA: 0x2D104A0 Offset: 0x2D105A1 VA: 0x2D104A0
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0x2D10550 Offset: 0x2D10651 VA: 0x2D10550 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x2D10660 Offset: 0x2D10761 VA: 0x2D10660 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2D107C0 Offset: 0x2D108C1 VA: 0x2D107C0 Slot: 3
	public override string ToString() { }
}

