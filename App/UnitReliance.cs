// Namespace: App
public class UnitReliance // TypeDefIndex: 13541
{
	// Fields
	public const int MaxScore = 100;
	private const int Version = 1;
	private static Dictionary<string, UnitRelianceData> s_DataDict; // 0x0
	private static EachDictionary<int, UnitRelianceData> s_EachDataDict; // 0x8

	// Methods

	// RVA: 0x20893B0 Offset: 0x20894B1 VA: 0x20893B0
	public static void Initialize() { }

	// RVA: 0x20898C0 Offset: 0x20899C1 VA: 0x20898C0
	public static void Reset() { }

	// RVA: 0x20898D0 Offset: 0x20899D1 VA: 0x20898D0
	public static void ResetMapBegin() { }

	// RVA: 0x2089A20 Offset: 0x2089B21 VA: 0x2089A20
	public static void ReflectScore() { }

	// RVA: 0x2087AD0 Offset: 0x2087BD1 VA: 0x2087AD0
	public static UnitRelianceData TryGet(string pidA, string pidB) { }

	// RVA: 0x208A2B0 Offset: 0x208A3B1 VA: 0x208A2B0
	public static UnitRelianceData TryGet(Unit unitA, Unit unitB) { }

	// RVA: 0x208A210 Offset: 0x208A311 VA: 0x208A210
	public static UnitRelianceData TryGet(PersonData personA, PersonData personB) { }

	// RVA: 0x208A380 Offset: 0x208A481 VA: 0x208A380
	public static bool CanAddScore(Unit unitA, Unit unitB) { }

	// RVA: 0x208A4D0 Offset: 0x208A5D1 VA: 0x208A4D0
	private static bool CanAddScore(Unit unitA, Unit unitB, UnitRelianceData data) { }

	// RVA: 0x208A580 Offset: 0x208A681 VA: 0x208A580
	private static bool CanAddExpHub(Unit unitA, Unit unitB, UnitRelianceData data) { }

	// RVA: 0x208A5A0 Offset: 0x208A6A1 VA: 0x208A5A0
	public static bool CanAddExpHub(Unit unitA, Unit unitB) { }

	// RVA: 0x208A690 Offset: 0x208A791 VA: 0x208A690
	public static bool TryAddScore(Unit unitA, Unit unitB, int value) { }

	// RVA: 0x208A8A0 Offset: 0x208A9A1 VA: 0x208A8A0
	public static bool TryAddExpByHub(Unit unitA, Unit unitB, int value) { }

	// RVA: 0x208A9E0 Offset: 0x208AAE1 VA: 0x208A9E0
	public static bool CanLevelUp(PersonData personA, PersonData personB) { }

	// RVA: 0x208ABA0 Offset: 0x208ACA1 VA: 0x208ABA0
	public static bool CanLevelUp(Unit unitA, Unit unitB) { }

	// RVA: 0x208ABC0 Offset: 0x208ACC1 VA: 0x208ABC0
	public static void LevelUp(PersonData personA, PersonData personB) { }

	// RVA: 0x208AE60 Offset: 0x208AF61 VA: 0x208AE60
	public static void LevelUp(Unit unitA, Unit unitB) { }

	// RVA: 0x208AE80 Offset: 0x208AF81 VA: 0x208AE80
	public static bool CanBeLevelAPlus(PersonData personA, PersonData personB) { }

	// RVA: 0x208B080 Offset: 0x208B181 VA: 0x208B080
	public static bool CanBeLevelAPlus(Unit unitA, Unit unitB) { }

	// RVA: 0x208B0A0 Offset: 0x208B1A1 VA: 0x208B0A0
	public static void SetLevelAPlus(PersonData personA, PersonData personB) { }

	// RVA: 0x208B290 Offset: 0x208B391 VA: 0x208B290
	public static void SetLevelAPlus(Unit unitA, Unit unitB) { }

	// RVA: 0x208B2B0 Offset: 0x208B3B1 VA: 0x208B2B0
	public static bool TryGetLevel(string pidA, string pidB, out RelianceData.Level level) { }

	// RVA: 0x208B2F0 Offset: 0x208B3F1 VA: 0x208B2F0
	public static bool TryGetLevel(PersonData personA, PersonData personB, out RelianceData.Level level) { }

	// RVA: 0x208B350 Offset: 0x208B451 VA: 0x208B350
	public static bool TryGetLevel(Unit unitA, Unit unitB, out RelianceData.Level level) { }

	// RVA: 0x208B3C0 Offset: 0x208B4C1 VA: 0x208B3C0
	public static SupportData TryGetSupportData(Unit unitA, Unit unitB, out RelianceData.Level level) { }

	// RVA: 0x208B500 Offset: 0x208B601 VA: 0x208B500
	public static void Serialize(Stream stream) { }

	// RVA: 0x208B740 Offset: 0x208B841 VA: 0x208B740
	public static void Deserialize(Stream stream) { }

	// RVA: 0x2089760 Offset: 0x2089861 VA: 0x2089760
	private static RelianceExpData GetValidRelianceExpData(int indexA, int indexB) { }

	// RVA: 0x2089870 Offset: 0x2089971 VA: 0x2089870
	private static string MakeDataDictKey(string pidA, string pidB) { }

	// RVA: 0x2089E40 Offset: 0x2089F41 VA: 0x2089E40
	private static void GetPidFromDictKey(string key, out string pidA, out string pidB) { }

	// RVA: 0x208C0F0 Offset: 0x208C1F1 VA: 0x208C0F0
	private static RelianceExpData GetRelianceExpDataFromDictKey(string key) { }

	// RVA: 0x208A020 Offset: 0x208A121 VA: 0x208A020
	private static void ShuffleSameScore(List<UnitRelianceMapResult> results) { }

	// RVA: 0x208C3B0 Offset: 0x208C4B1 VA: 0x208C3B0
	private static void ShuffleSameScore(List<UnitRelianceMapResult> results, int startIndex, int endIndex) { }

	// RVA: 0x208AFB0 Offset: 0x208B0B1 VA: 0x208AFB0
	private static GodUnit LinkGodUnitGet(PersonData person) { }

	// RVA: 0x208C4D0 Offset: 0x208C5D1 VA: 0x208C4D0
	public static bool LinkGodUnitIsExists(PersonData personA, PersonData personB) { }

	// RVA: 0x208C550 Offset: 0x208C651 VA: 0x208C550
	private static bool LinkGodUnitIsExists(Unit unitA, Unit unitB) { }

	// RVA: 0x208ACC0 Offset: 0x208ADC1 VA: 0x208ACC0
	private static void LinkGodUnitLevelUp(PersonData personA, PersonData personB, RelianceData.Level level) { }

	// RVA: 0x208AFD0 Offset: 0x208B0D1 VA: 0x208AFD0
	private static bool LinkGodUnitCanBeRelianceLevelS(GodUnit godUnitA, PersonData personB) { }

	// RVA: 0x208B1E0 Offset: 0x208B2E1 VA: 0x208B1E0
	private static void LinkGodUnitSetRelianceLevelS(GodUnit godUnitA, PersonData personB) { }

	// RVA: 0x208C5F0 Offset: 0x208C6F1 VA: 0x208C5F0
	public void .ctor() { }
}

