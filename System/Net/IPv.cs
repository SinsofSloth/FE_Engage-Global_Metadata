// Namespace: System.Net
internal struct IPv6AddressFormatter // TypeDefIndex: 2565
{
	// Fields
	private ushort[] address; // 0x0
	private long scopeId; // 0x8

	// Methods

	// RVA: 0x1ABF9C0 Offset: 0x1ABFAC1 VA: 0x1ABF9C0
	public void .ctor(ushort[] addr, long scopeId) { }

	// RVA: 0x1ABF9F0 Offset: 0x1ABFAF1 VA: 0x1ABF9F0
	private static ushort SwapUShort(ushort number) { }

	// RVA: 0x1ABFA00 Offset: 0x1ABFB01 VA: 0x1ABFA00
	private uint AsIPv4Int() { }

	// RVA: 0x1ABFA50 Offset: 0x1ABFB51 VA: 0x1ABFA50
	private bool IsIPv4Compatible() { }

	// RVA: 0x1ABFB10 Offset: 0x1ABFC11 VA: 0x1ABFB10
	private bool IsIPv4Mapped() { }

	// RVA: 0x1ABFBB0 Offset: 0x1ABFCB1 VA: 0x1ABFBB0 Slot: 3
	public override string ToString() { }
}

