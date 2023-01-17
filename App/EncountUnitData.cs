// Namespace: App
public class EncountUnitData // TypeDefIndex: 10257
{
	// Fields
	private DisposData m_DisposData; // 0x10
	private EncountUnitData.RareType m_RareType; // 0x18
	private JobData m_JobData; // 0x20

	// Properties
	public DisposData Dispos { get; }
	public EncountUnitData.RareType Rare { get; }
	public JobData Job { get; }

	// Methods

	// RVA: 0x25FB540 Offset: 0x25FB641 VA: 0x25FB540
	public void .ctor(DisposData data) { }

	// RVA: 0x25FB5A0 Offset: 0x25FB6A1 VA: 0x25FB5A0
	public void SetRareType(EncountUnitData.RareType type) { }

	// RVA: 0x25FB5B0 Offset: 0x25FB6B1 VA: 0x25FB5B0
	public DisposData get_Dispos() { }

	// RVA: 0x25FB5C0 Offset: 0x25FB6C1 VA: 0x25FB5C0
	public EncountUnitData.RareType get_Rare() { }

	// RVA: 0x25FB5D0 Offset: 0x25FB6D1 VA: 0x25FB5D0
	public JobData get_Job() { }

	// RVA: 0x25FB5E0 Offset: 0x25FB6E1 VA: 0x25FB5E0
	private bool IsGunner() { }

	// RVA: 0x25FB600 Offset: 0x25FB701 VA: 0x25FB600
	private bool IsWolf() { }

	// RVA: 0x25FB660 Offset: 0x25FB761 VA: 0x25FB660
	private bool IsDragon() { }

	// RVA: 0x25FB6C0 Offset: 0x25FB7C1 VA: 0x25FB6C0
	public static List<EncountUnitData> CreateList(List<DisposData> disposList, bool isDlc) { }

	// RVA: 0x25FB930 Offset: 0x25FBA31 VA: 0x25FB930
	private static void CreateJobData(List<EncountUnitData> unitDataList) { }

	// RVA: 0x25FC220 Offset: 0x25FC321 VA: 0x25FC220
	private static void CreatePackOfWolves(List<EncountUnitData> unitDataList) { }

	// RVA: 0x25FC890 Offset: 0x25FC991 VA: 0x25FC890
	private static void SetRareFlags(List<EncountUnitData> encountUnitDataList, bool isDlc) { }

	// RVA: 0x25FD6B0 Offset: 0x25FD7B1 VA: 0x25FD6B0
	public static string AppendSkill(int level, JobData data) { }

	// RVA: 0x25FD8F0 Offset: 0x25FD9F1 VA: 0x25FD8F0
	private static string GetRandomKillingSid() { }
}

