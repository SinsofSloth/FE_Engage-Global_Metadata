// Namespace: App
public class GodBondHolder : LinkNode<GodBondHolder> // TypeDefIndex: 13467
{
	// Fields
	private const int MaxUnit = 48;
	private GodData m_Data; // 0x20
	private GodRelianceS m_RelianceS; // 0x28
	private Dictionary<string, GodBond> m_Bonds; // 0x30
	private Pool.List<GodBond> m_Pool; // 0x38

	// Properties
	public GodData Data { get; }

	// Methods

	// RVA: 0x2CFAC80 Offset: 0x2CFAD81 VA: 0x2CFAC80
	public GodBondHolder Build(GodData data) { }

	// RVA: 0x2CFAEC0 Offset: 0x2CFAFC1 VA: 0x2CFAEC0
	public GodBond Get(Unit unit) { }

	// RVA: 0x2CFB060 Offset: 0x2CFB161 VA: 0x2CFB060
	public void Create(Unit unit) { }

	// RVA: 0x2CFB070 Offset: 0x2CFB171 VA: 0x2CFB070
	public void UpdateAllBondsForGodState(GodState godState) { }

	// RVA: 0x2CFB1A0 Offset: 0x2CFB2A1 VA: 0x2CFB1A0
	public void DeleteExluding(List<string> pids) { }

	// RVA: 0x2CFB430 Offset: 0x2CFB531 VA: 0x2CFB430
	public int GetMaxLevel() { }

	// RVA: 0x2CFB5A0 Offset: 0x2CFB6A1 VA: 0x2CFB5A0
	public int GetCountOfRelianceLevelA() { }

	// RVA: 0x2CFAFF0 Offset: 0x2CFB0F1 VA: 0x2CFAFF0
	private GodBond NewGodBond(string pid) { }

	// RVA: 0x2CFADA0 Offset: 0x2CFAEA1 VA: 0x2CFADA0
	private void Clear() { }

	// RVA: 0x2CFAE10 Offset: 0x2CFAF11 VA: 0x2CFAE10
	private void SetLevelFromUnitRelianceIfPossible(GodData data) { }

	// RVA: 0x2CFB6D0 Offset: 0x2CFB7D1 VA: 0x2CFB6D0
	private void SetLevelFromUnitReliance(Unit linkUnit, Force.Type forceType) { }

	// RVA: 0x2CFB7D0 Offset: 0x2CFB8D1 VA: 0x2CFB7D0
	public void ChangeOpponent(GodData data) { }

	// RVA: 0x2CFB910 Offset: 0x2CFBA11 VA: 0x2CFB910 Slot: 7
	public override void OnSerialize(Stream stream) { }

	// RVA: 0x2CFBB20 Offset: 0x2CFBC21 VA: 0x2CFBB20 Slot: 8
	public override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x2CFC310 Offset: 0x2CFC411 VA: 0x2CFC310
	public void SerializeForRewindLatest(Stream stream, HashSet<string> excludePids) { }

	// RVA: 0x2CFC530 Offset: 0x2CFC631 VA: 0x2CFC530
	public void DeserializeForRewindLatest(Stream stream) { }

	// RVA: 0x2CFC8B0 Offset: 0x2CFC9B1 VA: 0x2CFC8B0
	public GodData get_Data() { }

	// RVA: 0x2CFC8C0 Offset: 0x2CFC9C1 VA: 0x2CFC8C0 Slot: 5
	public override bool IsValid() { }

	// RVA: 0x2CFC8D0 Offset: 0x2CFC9D1 VA: 0x2CFC8D0
	public void .ctor() { }
}

