// Namespace: System.Net
[Serializable]
public class IPEndPoint : EndPoint // TypeDefIndex: 2461
{
	// Fields
	private IPAddress m_Address; // 0x10
	private int m_Port; // 0x18
	internal static IPEndPoint Any; // 0x0
	internal static IPEndPoint IPv6Any; // 0x8

	// Properties
	public override AddressFamily AddressFamily { get; }
	public IPAddress Address { get; }
	public int Port { get; }

	// Methods

	// RVA: 0x1AF41C0 Offset: 0x1AF42C1 VA: 0x1AF41C0 Slot: 4
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0x1AE5790 Offset: 0x1AE5891 VA: 0x1AE5790
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0x1AF41D0 Offset: 0x1AF42D1 VA: 0x1AF41D0
	public IPAddress get_Address() { }

	// RVA: 0x1AF41E0 Offset: 0x1AF42E1 VA: 0x1AF41E0
	public int get_Port() { }

	// RVA: 0x1AF41F0 Offset: 0x1AF42F1 VA: 0x1AF41F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AF42B0 Offset: 0x1AF43B1 VA: 0x1AF42B0 Slot: 5
	public override SocketAddress Serialize() { }

	// RVA: 0x1AF4330 Offset: 0x1AF4431 VA: 0x1AF4330 Slot: 6
	public override EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x1AF45D0 Offset: 0x1AF46D1 VA: 0x1AF45D0 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1AF46C0 Offset: 0x1AF47C1 VA: 0x1AF46C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AF4700 Offset: 0x1AF4801 VA: 0x1AF4700
	private static void .cctor() { }
}

