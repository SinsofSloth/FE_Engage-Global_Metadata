// Namespace: nn.fs
public struct DirectoryEntry // TypeDefIndex: 14732
{
	// Fields
	public string name; // 0x0
	private byte _reserved0; // 0x8
	private byte _reserved1; // 0x9
	private byte _reserved2; // 0xA
	private sbyte _entryType; // 0xB
	private byte _reserved3; // 0xC
	private byte _reserved4; // 0xD
	private byte _reserved5; // 0xE
	private long fileSize; // 0x10

	// Properties
	public EntryType entryType { get; set; }

	// Methods

	// RVA: 0x2374190 Offset: 0x2374291 VA: 0x2374190
	public EntryType get_entryType() { }

	// RVA: 0x23741A0 Offset: 0x23742A1 VA: 0x23741A0
	public void set_entryType(EntryType value) { }

	// RVA: 0x23741B0 Offset: 0x23742B1 VA: 0x23741B0 Slot: 3
	public override string ToString() { }
}

