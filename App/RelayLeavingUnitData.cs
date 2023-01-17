// Namespace: App
internal class RelayLeavingUnitData // TypeDefIndex: 12860
{
	// Fields
	private const ushort Version = 0;
	private UnitEdit m_Edit; // 0x10
	private PersonData m_Person; // 0x18
	private JobData m_Job; // 0x20
	private GodData m_God; // 0x28
	private UnitRecord m_Record; // 0x30
	private byte m_RelayPlayerIndex; // 0x38
	private bool m_IsMorph; // 0x39

	// Properties
	public UnitEdit Edit { get; }
	public PersonData Person { get; }
	public JobData Job { get; }
	public GodData God { get; }
	public UnitRecord Record { get; }
	public byte RelayPlayerIndex { get; }
	public bool IsMorph { get; }

	// Methods

	// RVA: 0x24B6D50 Offset: 0x24B6E51 VA: 0x24B6D50
	public void .ctor() { }

	// RVA: 0x24B6ED0 Offset: 0x24B6FD1 VA: 0x24B6ED0
	public void Register(Unit unit) { }

	// RVA: 0x24B6E60 Offset: 0x24B6F61 VA: 0x24B6E60
	public void Clear() { }

	// RVA: 0x24B70F0 Offset: 0x24B71F1 VA: 0x24B70F0
	public string GetName() { }

	// RVA: 0x24B7190 Offset: 0x24B7291 VA: 0x24B7190
	public bool IsFemale() { }

	// RVA: 0x24B7220 Offset: 0x24B7321 VA: 0x24B7220
	public string GetGodName() { }

	// RVA: 0x24B72A0 Offset: 0x24B73A1 VA: 0x24B72A0
	public void Serialize(Stream stream) { }

	// RVA: 0x24B73A0 Offset: 0x24B74A1 VA: 0x24B73A0
	public void Deserialize(Stream stream) { }

	// RVA: 0x24B78B0 Offset: 0x24B79B1 VA: 0x24B78B0
	public UnitEdit get_Edit() { }

	// RVA: 0x24B78C0 Offset: 0x24B79C1 VA: 0x24B78C0
	public PersonData get_Person() { }

	// RVA: 0x24B78D0 Offset: 0x24B79D1 VA: 0x24B78D0
	public JobData get_Job() { }

	// RVA: 0x24B78E0 Offset: 0x24B79E1 VA: 0x24B78E0
	public GodData get_God() { }

	// RVA: 0x24B78F0 Offset: 0x24B79F1 VA: 0x24B78F0
	public UnitRecord get_Record() { }

	// RVA: 0x24B7900 Offset: 0x24B7A01 VA: 0x24B7900
	public byte get_RelayPlayerIndex() { }

	// RVA: 0x24B7910 Offset: 0x24B7A11 VA: 0x24B7910
	public bool get_IsMorph() { }
}

