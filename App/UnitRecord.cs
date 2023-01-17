// Namespace: App
public class UnitRecord // TypeDefIndex: 13540
{
	// Fields
	private const int Version = 4;
	private static readonly string[] s_Names; // 0x0
	private static Dictionary<UnitRecord.Kinds, int> s_Keys; // 0x8
	private static Dictionary<int, UnitRecord.Kinds> s_Kinds; // 0x10
	private int[] m_Values; // 0x10

	// Methods

	// RVA: 0x2086A60 Offset: 0x2086B61 VA: 0x2086A60
	public static void Initialize() { }

	// RVA: 0x2086E00 Offset: 0x2086F01 VA: 0x2086E00
	public static int GetKey(UnitRecord.Kinds kind) { }

	// RVA: 0x2086EB0 Offset: 0x2086FB1 VA: 0x2086EB0
	public static UnitRecord.Kinds GetKind(int key) { }

	// RVA: 0x2086D70 Offset: 0x2086E71 VA: 0x2086D70
	public static string GetName(UnitRecord.Kinds kind) { }

	// RVA: 0x2086F60 Offset: 0x2087061 VA: 0x2086F60
	public void .ctor() { }

	// RVA: 0x2086FD0 Offset: 0x20870D1 VA: 0x2086FD0
	public int Get(UnitRecord.Kinds kind) { }

	// RVA: 0x2087010 Offset: 0x2087111 VA: 0x2087010
	public void Set(UnitRecord.Kinds kind, int value) { }

	// RVA: 0x2087050 Offset: 0x2087151 VA: 0x2087050
	public void Add(UnitRecord.Kinds kind, int value = 1) { }

	// RVA: 0x2087090 Offset: 0x2087191 VA: 0x2087090
	public void ResetMapBegin(Unit unit) { }

	// RVA: 0x20873F0 Offset: 0x20874F1 VA: 0x20873F0
	public void ResetMapEnd(Unit unit) { }

	// RVA: 0x2087440 Offset: 0x2087541 VA: 0x2087440
	public void Clear() { }

	// RVA: 0x2087490 Offset: 0x2087591 VA: 0x2087490
	public void Copy(UnitRecord src) { }

	// RVA: 0x20874B0 Offset: 0x20875B1 VA: 0x20874B0
	public void Serialize(Stream stream) { }

	// RVA: 0x2087640 Offset: 0x2087741 VA: 0x2087640
	public void Deserialize(Stream stream) { }

	// RVA: 0x2087A60 Offset: 0x2087B61 VA: 0x2087A60
	private static int GetHeroReliance(Unit unit) { }

	// RVA: 0x2087BF0 Offset: 0x2087CF1 VA: 0x2087BF0
	public static Unit GetMvpUnit() { }

	// RVA: 0x20881A0 Offset: 0x20882A1 VA: 0x20881A0
	public ChapterData GetDeadChapter() { }

	// RVA: 0x2088250 Offset: 0x2088351 VA: 0x2088250
	public void SetDeadChapter(ChapterData chapter) { }

	// RVA: 0x20882A0 Offset: 0x20883A1 VA: 0x20882A0
	public UnitRecord.DeadFlags GetDeadFlag() { }

	// RVA: 0x20882D0 Offset: 0x20883D1 VA: 0x20882D0
	public void SetDeadFlag(UnitRecord.DeadFlags flags) { }

	// RVA: 0x2088300 Offset: 0x2088401 VA: 0x2088300
	private static void .cctor() { }
}

