// Namespace: 
protected enum AmiiboSequence.Label // TypeDefIndex: 10398
{
	// Fields
	public int value__; // 0x0
	public const AmiiboSequence.Label AmiiboReadingMenu = 0;
	public const AmiiboSequence.Label Initialize = 1;
	public const AmiiboSequence.Label SetupDevice = 2;
	public const AmiiboSequence.Label ReadAmiibo = 3;
	public const AmiiboSequence.Label Mount = 4;
	public const AmiiboSequence.Label GetItem = 5;
	public const AmiiboSequence.Label AlreadyGetItem = 6;
	public const AmiiboSequence.Label TagLostStandbyReady = 7;
	public const AmiiboSequence.Label End = 8;
}

// Namespace: 
private struct AmiiboSequence.TagData // TypeDefIndex: 10399
{
	// Fields
	public uint characterIdBase; // 0x0
	public byte characterIdDetail; // 0x4
	public ushort numberingId; // 0x6
	public byte seriesId; // 0x8
	public byte nfpType; // 0x9
	public string nameBase; // 0x10
	public string nameDetail; // 0x18

	// Methods

	// RVA: 0x1F5C8D0 Offset: 0x1F5C9D1 VA: 0x1F5C8D0
	public void .ctor(uint characterIdBase, byte characterIdDetail, ushort numberingId, byte seriesId, byte nfpType, string nameBase, string nameDetail) { }
}

// Namespace: 
private enum AmiiboSequence.ItemType // TypeDefIndex: 10400
{
	// Fields
	public int value__; // 0x0
	public const AmiiboSequence.ItemType Item = 0;
	public const AmiiboSequence.ItemType BGM = 1;
	public const AmiiboSequence.ItemType DressTicket = 2;
	public const AmiiboSequence.ItemType RelayTicket = 3;
	public const AmiiboSequence.ItemType Kizuna = 4;
}

// Namespace: 
private struct AmiiboSequence.GainItemData // TypeDefIndex: 10401
{
	// Fields
	public string name; // 0x0
	public int num; // 0x8
	public AmiiboSequence.ItemType type; // 0xC
}

