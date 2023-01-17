// Namespace: App
public class MapKillBonus : SingletonClass<MapKillBonus> // TypeDefIndex: 12182
{
	// Fields
	public const int MaxBonusCount = 10;
	private const int MaxWidth = 32;
	private const int MaxHeight = 32;
	private const int MaxCellCount = 1024;
	private MapKillBonus.KindImage m_KindImage; // 0x20
	private MapKillBonus.CountImage[] m_CountImages; // 0x28
	private MapKillBonus.KillBonus[] m_KillBonuses; // 0x30
	private int m_KillBonusIndex; // 0x38
	private int m_KillBonusCount; // 0x3C
	private MapKillBonus.KilledBonus[] m_KilledBonuses; // 0x40
	private MapKillBonus.KilledBonus[] m_KilledGodBonuses; // 0x48
	private int m_KilledBonusIndex; // 0x50
	private int m_KilledBonusCount; // 0x54
	private MapKillBonus.Work m_Work; // 0x58

	// Properties
	public bool IsNetSucceeded { get; }
	protected override int Version { get; }

	// Methods

	// RVA: 0x2208E00 Offset: 0x2208F01 VA: 0x2208E00 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x22094D0 Offset: 0x22095D1 VA: 0x22094D0 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x2209550 Offset: 0x2209651 VA: 0x2209550
	public static bool IsEnable() { }

	// RVA: 0x2209670 Offset: 0x2209771 VA: 0x2209670
	private static bool IsEnableChapter(ChapterData chapter) { }

	// RVA: 0x2209690 Offset: 0x2209791 VA: 0x2209690
	public bool Download(ProcInst super) { }

	// RVA: 0x2209840 Offset: 0x2209941 VA: 0x2209840
	public bool Upload(ProcInst super) { }

	// RVA: 0x2209A20 Offset: 0x2209B21 VA: 0x2209A20
	private void Setup() { }

	// RVA: 0x220A370 Offset: 0x220A471 VA: 0x220A370
	public void TryGain(ProcInst super, Unit unit) { }

	// RVA: 0x220A450 Offset: 0x220A551 VA: 0x220A450
	public MapKillBonus.Kinds GetKind(int x, int z) { }

	// RVA: 0x220A460 Offset: 0x220A561 VA: 0x220A460
	public void CopyKindImageTo(MapKillBonus.KindImage kindImage) { }

	// RVA: 0x220A4C0 Offset: 0x220A5C1 VA: 0x220A4C0
	public void TryCreateEffect(int x, int z) { }

	// RVA: 0x220A500 Offset: 0x220A601 VA: 0x220A500
	public void TryCreateEffect(int x, int z, MapKillBonus.Kinds kind) { }

	// RVA: 0x220A410 Offset: 0x220A511 VA: 0x220A410
	public void TryDeleteEffect(int x, int z) { }

	// RVA: 0x220A690 Offset: 0x220A791 VA: 0x220A690
	public void TryDeleteEffect(int x, int z, MapKillBonus.Kinds kind) { }

	// RVA: 0x220A780 Offset: 0x220A881 VA: 0x220A780
	public void AddCount(Unit deadUnit) { }

	// RVA: 0x220A8E0 Offset: 0x220A9E1 VA: 0x220A8E0
	public void AddCount(int x, int z, MapKillBonus.Kinds kind) { }

	// RVA: 0x22099D0 Offset: 0x2209AD1 VA: 0x22099D0
	public MapKillBonus.CountImage GetCountImage(MapKillBonus.Kinds kind) { }

	// RVA: 0x22097C0 Offset: 0x22098C1 VA: 0x22097C0
	public void ClearNetSucceeded() { }

	// RVA: 0x220AA50 Offset: 0x220AB51 VA: 0x220AA50
	public int GetBonusIndex(MapKillBonus.Kinds kind) { }

	// RVA: 0x220AA70 Offset: 0x220AB71 VA: 0x220AA70
	public void RewindBonus(int x, int z, MapKillBonus.Kinds kind, int bonusIndex) { }

	// RVA: 0x220AAF0 Offset: 0x220ABF1 VA: 0x220AAF0
	public void RewindCount(int x, int z, MapKillBonus.Kinds kind, int count) { }

	// RVA: 0x2209B50 Offset: 0x2209C51 VA: 0x2209B50
	public bool get_IsNetSucceeded() { }

	// RVA: 0x2209BD0 Offset: 0x2209CD1 VA: 0x2209BD0
	private void DecideCells(int mapMaxKillBonusCount, int mapMaxKilledBonusCount) { }

	// RVA: 0x220ABC0 Offset: 0x220ACC1 VA: 0x220ABC0
	private void DecideCells(int[,,] netData, int netKind, MapKillBonus.Kinds kind, int mapMaxBonusCount) { }

	// RVA: 0x2209C90 Offset: 0x2209D91 VA: 0x2209C90
	private void DecideKillBonus(int mapMaxBonusCount) { }

	// RVA: 0x2209EF0 Offset: 0x2209FF1 VA: 0x2209EF0
	private void DecideKilledBonus(int mapMaxBonusCount) { }

	// RVA: 0x220AEA0 Offset: 0x220AFA1 VA: 0x220AEA0
	private StructDataArrayList<KillBonusData> GetKillBonusData() { }

	// RVA: 0x220B150 Offset: 0x220B251 VA: 0x220B150
	private StructDataArrayList<KilledBonusData> GetKilledBonusData() { }

	// RVA: 0x22090E0 Offset: 0x22091E1 VA: 0x22090E0
	private void Clear() { }

	// RVA: 0x220B120 Offset: 0x220B221 VA: 0x220B120
	private static int GetRandomValue(int num) { }

	// RVA: 0x220B3D0 Offset: 0x220B4D1 VA: 0x220B3D0 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x220B3E0 Offset: 0x220B4E1 VA: 0x220B3E0 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x220B900 Offset: 0x220BA01 VA: 0x220B900 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	[ConditionalAttribute] // RVA: 0x2C7D60 Offset: 0x2C7E61 VA: 0x2C7D60
	// RVA: 0x220BEB0 Offset: 0x220BFB1 VA: 0x220BEB0
	public void DbgDump() { }

	[ConditionalAttribute] // RVA: 0x2C7DA0 Offset: 0x2C7EA1 VA: 0x2C7DA0
	// RVA: 0x220BF60 Offset: 0x220C061 VA: 0x220BF60
	public void DbgDumpKindImage(StringBuilder sb) { }

	[ConditionalAttribute] // RVA: 0x2C7DE0 Offset: 0x2C7EE1 VA: 0x2C7DE0
	// RVA: 0x220C260 Offset: 0x220C361 VA: 0x220C260
	public void DbgDumpKillBonus(StringBuilder sb) { }

	[ConditionalAttribute] // RVA: 0x2C7E20 Offset: 0x2C7F21 VA: 0x2C7E20
	// RVA: 0x220C470 Offset: 0x220C571 VA: 0x220C470
	public void DbgDumpKilledBonus(StringBuilder sb) { }

	// RVA: 0x220C780 Offset: 0x220C881 VA: 0x220C780
	public void .ctor() { }
}

