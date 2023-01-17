// Namespace: App
public class GmapUtil // TypeDefIndex: 10359
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28DEA0 Offset: 0x28DFA1 VA: 0x28DEA0
	private static int <SortiableCount>k__BackingField; // 0x0
	private static readonly string RareGoldKey; // 0x8
	private static readonly string RareExpKey; // 0x10

	// Properties
	public static int SortiableCount { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BDDF0 Offset: 0x2BDEF1 VA: 0x2BDDF0
	// RVA: 0x2CF5F70 Offset: 0x2CF6071 VA: 0x2CF5F70
	public static int get_SortiableCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDE00 Offset: 0x2BDF01 VA: 0x2BDE00
	// RVA: 0x2CF5FE0 Offset: 0x2CF60E1 VA: 0x2CF5FE0
	public static void set_SortiableCount(int value) { }

	// RVA: 0x2CF2920 Offset: 0x2CF2A21 VA: 0x2CF2920
	public static int GetEncountRank(GmapSpot gmapSpot) { }

	// RVA: 0x2CF6050 Offset: 0x2CF6151 VA: 0x2CF6050
	private static List<int> GetSortieNum(GmapSpot gmapSpot) { }

	// RVA: 0x2CF6320 Offset: 0x2CF6421 VA: 0x2CF6320
	public static int CalcEncountRank(int sortieCount = -1, bool isDlcMode = False) { }

	// RVA: 0x2CF6BE0 Offset: 0x2CF6CE1 VA: 0x2CF6BE0
	public static int GetAverageLevel(Difficulty difficulty, int sortieCount = -1) { }

	// RVA: 0x2CF6AB0 Offset: 0x2CF6BB1 VA: 0x2CF6AB0
	private static int GetVandreLevel(out Unit vandreUnit) { }

	// RVA: 0x2CF6C80 Offset: 0x2CF6D81 VA: 0x2CF6C80
	public static List<DisposData> ReductDispos(List<DisposData> disposList) { }

	// RVA: 0x2CF6F40 Offset: 0x2CF7041 VA: 0x2CF6F40
	public static ItemData.Kinds[] GetEquipableWeapons(JobData job, out WeaponMask selectedMask) { }

	// RVA: 0x2CF7610 Offset: 0x2CF7711 VA: 0x2CF7610
	public static ItemData GetDownLevelWeapon(ItemData item, WeaponLevel.Kind level) { }

	// RVA: 0x2CECDD0 Offset: 0x2CECED1 VA: 0x2CECDD0
	public static void RegistRareDisposCount() { }

	// RVA: 0x2CF7A80 Offset: 0x2CF7B81 VA: 0x2CF7A80
	public static int GetRareExpDisposCount() { }

	// RVA: 0x2CF7C30 Offset: 0x2CF7D31 VA: 0x2CF7C30
	public static int GetRareGoldDisposCount() { }

	// RVA: 0x2CF7400 Offset: 0x2CF7501 VA: 0x2CF7400
	public static ItemData.Kinds[] WeaponMaskToArray(WeaponMask mask) { }

	// RVA: 0x2CF7280 Offset: 0x2CF7381 VA: 0x2CF7280
	public static WeaponMask WeaponArrayToMask(ItemData.Kinds[] kinds) { }

	// RVA: 0x2CF7DE0 Offset: 0x2CF7EE1 VA: 0x2CF7DE0
	public static bool IsAppearGradlon() { }

	// RVA: 0x2CE8580 Offset: 0x2CE8681 VA: 0x2CE8580
	public static void UpdateVisibleGradlon() { }

	// RVA: 0x2CF7F50 Offset: 0x2CF8051 VA: 0x2CF7F50
	public void .ctor() { }

	// RVA: 0x2CF7F60 Offset: 0x2CF8061 VA: 0x2CF7F60
	private static void .cctor() { }
}

