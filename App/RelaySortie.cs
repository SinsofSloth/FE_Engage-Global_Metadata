// Namespace: App
internal class RelaySortie // TypeDefIndex: 12940
{
	// Fields
	private const int NearbyFriendsThreshold = 100;
	private int m_MaxTotalCount; // 0x10
	private int m_ReqMyCount; // 0x14
	private int m_ReqTotalCountNoClamp; // 0x18
	private int m_ReqTotalCount; // 0x1C
	private int m_TotalCount; // 0x20
	private int m_MyCount; // 0x24
	private int m_OtherCount; // 0x28
	private HashSet<string> m_OtherPids; // 0x30
	private Dictionary<int, MapPos> m_OtherPos; // 0x38
	private int[] m_NearbyFriendsScores; // 0x40

	// Properties
	public int MaxTotalCount { get; }
	public int ReqMyCount { get; }
	public int ReqTotalCountNoClamp { get; }
	public int ReqTotalCount { get; }
	public int TotalCount { get; set; }
	public int MyCount { get; set; }
	public int OtherCount { get; }

	// Methods

	// RVA: 0x24C4BE0 Offset: 0x24C4CE1 VA: 0x24C4BE0
	public void Initialize() { }

	// RVA: 0x24C4D00 Offset: 0x24C4E01 VA: 0x24C4D00
	public void Setup() { }

	// RVA: 0x24C5200 Offset: 0x24C5301 VA: 0x24C5200
	private void CountUnits() { }

	// RVA: 0x24C5320 Offset: 0x24C5421 VA: 0x24C5320
	private void SetupUnits() { }

	// RVA: 0x24C4E00 Offset: 0x24C4F01 VA: 0x24C4E00
	private void CreateSortiePosition() { }

	// RVA: 0x24C5500 Offset: 0x24C5601 VA: 0x24C5500
	public void PrerelocationUnits() { }

	// RVA: 0x24C55E0 Offset: 0x24C56E1 VA: 0x24C55E0
	public void RelocationUnitForTakeOver(Unit unit) { }

	// RVA: 0x24C5980 Offset: 0x24C5A81 VA: 0x24C5980
	private bool FindEmptySortiePosition(out int x, out int z) { }

	// RVA: 0x24C5090 Offset: 0x24C5191 VA: 0x24C5090
	private int CountEmptySortiePosition() { }

	// RVA: 0x24C5B20 Offset: 0x24C5C21 VA: 0x24C5B20
	private bool FindSortiePositionNearbyFriends(out int x, out int z) { }

	// RVA: 0x24C4CF0 Offset: 0x24C4DF1 VA: 0x24C4CF0
	public bool IsIgnore(Unit unit) { }

	// RVA: 0x24C5D80 Offset: 0x24C5E81 VA: 0x24C5D80
	public bool IsIgnoreForTroop(Unit unit, bool isInBattleMap) { }

	// RVA: 0x24C5E00 Offset: 0x24C5F01 VA: 0x24C5E00
	public bool CanSortie(Unit unit) { }

	// RVA: 0x24C5E80 Offset: 0x24C5F81 VA: 0x24C5E80
	public bool CanToggle(Unit unit) { }

	// RVA: 0x24C6000 Offset: 0x24C6101 VA: 0x24C6000
	public void Toggle(Unit unit) { }

	// RVA: 0x24C6150 Offset: 0x24C6251 VA: 0x24C6150
	public bool CanStartBattle() { }

	// RVA: 0x24C6160 Offset: 0x24C6261 VA: 0x24C6160
	public bool CanBackTo() { }

	// RVA: 0x24C61E0 Offset: 0x24C62E1 VA: 0x24C61E0
	public int get_MaxTotalCount() { }

	// RVA: 0x24C61F0 Offset: 0x24C62F1 VA: 0x24C61F0
	public int get_ReqMyCount() { }

	// RVA: 0x24C6200 Offset: 0x24C6301 VA: 0x24C6200
	public int get_ReqTotalCountNoClamp() { }

	// RVA: 0x24C6210 Offset: 0x24C6311 VA: 0x24C6210
	public int get_ReqTotalCount() { }

	// RVA: 0x24C6220 Offset: 0x24C6321 VA: 0x24C6220
	public int get_TotalCount() { }

	// RVA: 0x24C6230 Offset: 0x24C6331 VA: 0x24C6230
	public void set_TotalCount(int value) { }

	// RVA: 0x24C6240 Offset: 0x24C6341 VA: 0x24C6240
	public int get_MyCount() { }

	// RVA: 0x24C6250 Offset: 0x24C6351 VA: 0x24C6250
	public void set_MyCount(int value) { }

	// RVA: 0x24C6260 Offset: 0x24C6361 VA: 0x24C6260
	public int get_OtherCount() { }

	// RVA: 0x24C6270 Offset: 0x24C6371 VA: 0x24C6270
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA360 Offset: 0x2CA461 VA: 0x2CA360
	// RVA: 0x24C6280 Offset: 0x24C6381 VA: 0x24C6280
	private void <FindSortiePositionNearbyFriends>b__20_0(Unit unit) { }
}

