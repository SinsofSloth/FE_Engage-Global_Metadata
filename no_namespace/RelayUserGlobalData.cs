// Namespace: 
private struct RelayUserGlobalData.Uncommitted // TypeDefIndex: 12867
{
	// Fields
	private const byte Version = 0;
	public int ticketCount; // 0x0
	public long ticketLastTime; // 0x8
	public bool isValidTicketLastTime; // 0x10

	// Methods

	// RVA: 0x1F46B10 Offset: 0x1F46C11 VA: 0x1F46B10
	public void Clear() { }

	// RVA: 0x1F46B20 Offset: 0x1F46C21 VA: 0x1F46B20
	public bool IsDirty() { }

	// RVA: 0x1F46B40 Offset: 0x1F46C41 VA: 0x1F46B40
	public void Serialize(Stream stream) { }

	// RVA: 0x1F46BA0 Offset: 0x1F46CA1 VA: 0x1F46BA0
	public void Deserialize(Stream stream) { }
}

