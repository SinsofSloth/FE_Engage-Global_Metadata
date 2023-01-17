// Namespace: App
internal class RelayAwardeeData // TypeDefIndex: 12856
{
	// Fields
	private const ushort Version = 0;
	private UnitEdit m_Edit; // 0x10
	private PersonData m_Person; // 0x18
	private JobData m_Job; // 0x20
	private GodData m_God; // 0x28
	private int m_RecordValue; // 0x30
	private byte m_RelayPlayerIndex; // 0x34
	private bool m_IsMorph; // 0x35
	private ItemData m_Item; // 0x38

	// Properties
	public UnitEdit Edit { get; }
	public PersonData Person { get; }
	public JobData Job { get; }
	public GodData God { get; }
	public int RecordValue { get; }
	public byte RelayPlayerIndex { get; }
	public bool IsMorth { get; }
	public ItemData Item { get; }

	// Methods

	// RVA: 0x253B140 Offset: 0x253B241 VA: 0x253B140
	public void .ctor() { }

	// RVA: 0x253B220 Offset: 0x253B321 VA: 0x253B220
	public void Register(Unit unit, int recordValue, ItemData item) { }

	// RVA: 0x253B430 Offset: 0x253B531 VA: 0x253B430
	public void Register(RelayLeavingUnitData leavingUnitData, int recordValue, ItemData item) { }

	// RVA: 0x253EC10 Offset: 0x253ED11 VA: 0x253EC10
	public void Clear() { }

	// RVA: 0x253EC80 Offset: 0x253ED81 VA: 0x253EC80
	public string GetName() { }

	// RVA: 0x253ED20 Offset: 0x253EE21 VA: 0x253ED20
	public bool IsFemale() { }

	// RVA: 0x253EDB0 Offset: 0x253EEB1 VA: 0x253EDB0
	public string GetGodName() { }

	// RVA: 0x253EE30 Offset: 0x253EF31 VA: 0x253EE30
	public void Serialize(Stream stream) { }

	// RVA: 0x253EF40 Offset: 0x253F041 VA: 0x253EF40
	public void Deserialize(Stream stream) { }

	// RVA: 0x253F4F0 Offset: 0x253F5F1 VA: 0x253F4F0
	public UnitEdit get_Edit() { }

	// RVA: 0x253F500 Offset: 0x253F601 VA: 0x253F500
	public PersonData get_Person() { }

	// RVA: 0x253F510 Offset: 0x253F611 VA: 0x253F510
	public JobData get_Job() { }

	// RVA: 0x253F520 Offset: 0x253F621 VA: 0x253F520
	public GodData get_God() { }

	// RVA: 0x253F530 Offset: 0x253F631 VA: 0x253F530
	public int get_RecordValue() { }

	// RVA: 0x253F540 Offset: 0x253F641 VA: 0x253F540
	public byte get_RelayPlayerIndex() { }

	// RVA: 0x253F550 Offset: 0x253F651 VA: 0x253F550
	public bool get_IsMorth() { }

	// RVA: 0x253F560 Offset: 0x253F661 VA: 0x253F560
	public ItemData get_Item() { }
}

