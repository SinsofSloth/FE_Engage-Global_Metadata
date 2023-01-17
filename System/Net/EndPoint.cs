// Namespace: System.Net
[Serializable]
public abstract class EndPoint // TypeDefIndex: 2451
{
	// Properties
	public virtual AddressFamily AddressFamily { get; }

	// Methods

	// RVA: 0x1ADB500 Offset: 0x1ADB601 VA: 0x1ADB500 Slot: 4
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0x1ADB5C0 Offset: 0x1ADB6C1 VA: 0x1ADB5C0 Slot: 5
	public virtual SocketAddress Serialize() { }

	// RVA: 0x1ADB680 Offset: 0x1ADB781 VA: 0x1ADB680 Slot: 6
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x1ADB6B0 Offset: 0x1ADB7B1 VA: 0x1ADB6B0
	protected void .ctor() { }
}

