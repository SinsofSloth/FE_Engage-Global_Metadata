// Namespace: App
public class VersusServerCasualData : VersusServerData // TypeDefIndex: 13771
{
	// Fields
	private const int Version = 3;
	[CompilerGeneratedAttribute] // RVA: 0x29CB40 Offset: 0x29CC41 VA: 0x29CB40
	private readonly List<Unit> <UnitList>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x29CB50 Offset: 0x29CC51 VA: 0x29CB50
	private readonly Dictionary<string, GodUnit> <m_GodDict>k__BackingField; // 0x30

	// Properties
	public List<Unit> UnitList { get; }
	private Dictionary<string, GodUnit> m_GodDict { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CD3A0 Offset: 0x2CD4A1 VA: 0x2CD3A0
	// RVA: 0x2A53360 Offset: 0x2A53461 VA: 0x2A53360
	public List<Unit> get_UnitList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD3B0 Offset: 0x2CD4B1 VA: 0x2CD3B0
	// RVA: 0x2A53370 Offset: 0x2A53471 VA: 0x2A53370
	private Dictionary<string, GodUnit> get_m_GodDict() { }

	// RVA: 0x2A44E10 Offset: 0x2A44F11 VA: 0x2A44E10
	public void .ctor() { }

	// RVA: 0x2A53450 Offset: 0x2A53551 VA: 0x2A53450
	public GodUnit TryGetPairGodUnit(Unit unit) { }

	// RVA: 0x2A53510 Offset: 0x2A53611 VA: 0x2A53510 Slot: 4
	public override void Serialize() { }

	// RVA: 0x2A45AD0 Offset: 0x2A45BD1 VA: 0x2A45AD0
	public void SerializeInit() { }

	// RVA: 0x2A53720 Offset: 0x2A53821 VA: 0x2A53720
	private void WriteHeader(Stream stream) { }

	// RVA: 0x2A53760 Offset: 0x2A53861 VA: 0x2A53760
	private void WriteUnit(Stream stream) { }

	// RVA: 0x2A53E60 Offset: 0x2A53F61 VA: 0x2A53E60
	private void WriteUnitInit(Stream stream) { }

	// RVA: 0x2A54400 Offset: 0x2A54501 VA: 0x2A54400
	private void WriteUnit(Stream stream, Unit unit) { }

	// RVA: 0x2A53BA0 Offset: 0x2A53CA1 VA: 0x2A53BA0
	private void WriteBonds(Stream stream) { }

	// RVA: 0x2A545E0 Offset: 0x2A546E1 VA: 0x2A545E0 Slot: 5
	public override bool Deserialize() { }

	// RVA: 0x2A54880 Offset: 0x2A54981 VA: 0x2A54880
	private void ReadHeader(Stream stream) { }

	// RVA: 0x2A548C0 Offset: 0x2A549C1 VA: 0x2A548C0
	private void ReadUnit(Stream stream) { }

	// RVA: 0x2A557A0 Offset: 0x2A558A1 VA: 0x2A557A0
	private Dictionary<string, string> SaveGodBond() { }

	// RVA: 0x2A55A00 Offset: 0x2A55B01 VA: 0x2A55A00
	private void LoadGodBond(Dictionary<string, string> bondDict) { }

	// RVA: 0x2A55370 Offset: 0x2A55471 VA: 0x2A55370
	private void ReadBonds(Stream stream) { }
}

