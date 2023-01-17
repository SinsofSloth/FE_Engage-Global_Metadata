// Namespace: App
public class MapEditData // TypeDefIndex: 11980
{
	// Fields
	private const int Version = 10;
	public const int MaxStream = 131072;
	private string m_Name; // 0x10
	private Stream m_Stream; // 0x18
	private DateTime m_SaveTime; // 0x20
	private List<MapEditData.UnitInfo> m_SortieUnitInfoList; // 0x28
	private List<string> m_SortieGidList; // 0x30
	private Dictionary<string, string> m_SortieLinkGodDict; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x299AA0 Offset: 0x299BA1 VA: 0x299AA0
	private readonly List<Unit> <UnitList>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x299AB0 Offset: 0x299BB1 VA: 0x299AB0
	private readonly Dictionary<string, GodUnit> <m_GodDict>k__BackingField; // 0x48

	// Properties
	public string Name { get; set; }
	public DateTime SaveTime { get; }
	public List<Unit> UnitList { get; }
	private Dictionary<string, GodUnit> m_GodDict { get; }
	public List<MapEditData.UnitInfo> SortieUnitInfoList { get; }
	public List<string> SortieGidList { get; }

	// Methods

	// RVA: 0x21AA6C0 Offset: 0x21AA7C1 VA: 0x21AA6C0
	public string get_Name() { }

	// RVA: 0x21AA6D0 Offset: 0x21AA7D1 VA: 0x21AA6D0
	public void set_Name(string value) { }

	// RVA: 0x21AA6E0 Offset: 0x21AA7E1 VA: 0x21AA6E0
	public DateTime get_SaveTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7280 Offset: 0x2C7381 VA: 0x2C7280
	// RVA: 0x21AA6F0 Offset: 0x21AA7F1 VA: 0x21AA6F0
	public List<Unit> get_UnitList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7290 Offset: 0x2C7391 VA: 0x2C7290
	// RVA: 0x21AA700 Offset: 0x21AA801 VA: 0x21AA700
	private Dictionary<string, GodUnit> get_m_GodDict() { }

	// RVA: 0x21AA710 Offset: 0x21AA811 VA: 0x21AA710
	public void .ctor() { }

	// RVA: 0x21AA990 Offset: 0x21AAA91 VA: 0x21AA990
	public void Clear() { }

	// RVA: 0x21AAAB0 Offset: 0x21AABB1 VA: 0x21AAAB0
	private void ClearValue() { }

	// RVA: 0x21AAB50 Offset: 0x21AAC51 VA: 0x21AAB50
	public void CopyFrom(MapEditData from) { }

	// RVA: 0x21AABD0 Offset: 0x21AACD1 VA: 0x21AABD0
	public bool IsEmpty() { }

	// RVA: 0x21AAC00 Offset: 0x21AAD01 VA: 0x21AAC00
	public bool IsSaved() { }

	// RVA: 0x21AAC80 Offset: 0x21AAD81 VA: 0x21AAC80
	public int StreamPosition() { }

	// RVA: 0x21AAC90 Offset: 0x21AAD91 VA: 0x21AAC90
	public GodUnit TryGetPairGodUnit(Unit unit) { }

	// RVA: 0x21AAD50 Offset: 0x21AAE51 VA: 0x21AAD50
	private void WriteHeader(Stream stream) { }

	// RVA: 0x21AADA0 Offset: 0x21AAEA1 VA: 0x21AADA0
	private void WriteMap(Stream stream) { }

	// RVA: 0x21AB010 Offset: 0x21AB111 VA: 0x21AB010
	private void WriteUnit(Stream stream) { }

	// RVA: 0x21AB510 Offset: 0x21AB611 VA: 0x21AB510
	private void WriteBonds(Stream stream) { }

	// RVA: 0x21AB5F0 Offset: 0x21AB6F1 VA: 0x21AB5F0
	private void ReadHeader(Stream stream) { }

	// RVA: 0x21AB890 Offset: 0x21AB991 VA: 0x21AB890
	private void ReadMap(Stream stream, bool isOpponent = False, bool isAppend = False) { }

	// RVA: 0x21AC250 Offset: 0x21AC351 VA: 0x21AC250
	private void ReadUnit(Stream stream) { }

	// RVA: 0x21ACE80 Offset: 0x21ACF81 VA: 0x21ACE80
	private void ReadUnitForEnemy(Stream stream) { }

	// RVA: 0x21ADDE0 Offset: 0x21ADEE1 VA: 0x21ADDE0
	private Dictionary<string, string> SaveGodBond() { }

	// RVA: 0x21AE040 Offset: 0x21AE141 VA: 0x21AE040
	private void LoadGodBond(Dictionary<string, string> bondDict) { }

	// RVA: 0x21AE340 Offset: 0x21AE441 VA: 0x21AE340
	private void ReadBondsForEnemy(Stream stream) { }

	// RVA: 0x21AE4D0 Offset: 0x21AE5D1 VA: 0x21AE4D0
	public void Save() { }

	// RVA: 0x21AE5E0 Offset: 0x21AE6E1 VA: 0x21AE5E0
	public void Load() { }

	// RVA: 0x21AE740 Offset: 0x21AE841 VA: 0x21AE740
	public void LoadForEnemy() { }

	// RVA: 0x21AE890 Offset: 0x21AE991 VA: 0x21AE890
	public void Serialize(Stream stream) { }

	// RVA: 0x21AE900 Offset: 0x21AEA01 VA: 0x21AE900
	public void Deserialize(Stream stream) { }

	// RVA: 0x21AEB40 Offset: 0x21AEC41 VA: 0x21AEB40
	public static void SerializeForMapHistoryReplay(Stream stream) { }

	// RVA: 0x21AEFD0 Offset: 0x21AF0D1 VA: 0x21AEFD0
	public static void DeserializeForMapHistoryReplay(Stream stream) { }

	// RVA: 0x21AF4D0 Offset: 0x21AF5D1 VA: 0x21AF4D0
	public List<MapEditData.UnitInfo> get_SortieUnitInfoList() { }

	// RVA: 0x21AF4E0 Offset: 0x21AF5E1 VA: 0x21AF4E0
	public List<string> get_SortieGidList() { }

	// RVA: 0x21AF4F0 Offset: 0x21AF5F1 VA: 0x21AF4F0
	public MapEditData.UnitInfo TryGetSortieUnit(string pid) { }

	// RVA: 0x21AF650 Offset: 0x21AF751 VA: 0x21AF650
	public string TryGetSortieGod(string pid) { }
}

