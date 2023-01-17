// Namespace: 
public enum Versus.Mode // TypeDefIndex: 13748
{
	// Fields
	public int value__; // 0x0
	public const Versus.Mode None = 0;
	public const Versus.Mode Edit = 1;
	public const Versus.Mode Casual = 2;
	public const Versus.Mode Ranked = 3;
	public const Versus.Mode Replay = 4;
	public const Versus.Mode MockBattle = 5;
}

// Namespace: 
public enum Versus.MatchingType // TypeDefIndex: 13749
{
	// Fields
	public int value__; // 0x0
	public const Versus.MatchingType Random = 0;
	public const Versus.MatchingType Friend = 1;
	public const Versus.MatchingType DataCode = 2;
	public const Versus.MatchingType Profile = 3;
}

// Namespace: 
public enum Versus.MapResult // TypeDefIndex: 13750
{
	// Fields
	public int value__; // 0x0
	public const Versus.MapResult Win = 0;
	public const Versus.MapResult Lose = 1;
	public const Versus.MapResult None = 2;
	public const Versus.MapResult Abort = 3;
}

// Namespace: 
public enum Versus.Error // TypeDefIndex: 13751
{
	// Fields
	public int value__; // 0x0
	public const Versus.Error None = -1;
	public const Versus.Error RankedReport = 101;
	public const Versus.Error RankedOffenceUnitNone = 102;
	public const Versus.Error InvalidData = 103;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279280 Offset: 0x279381 VA: 0x279280
private sealed class Versus.VersusCheck.<>c__DisplayClass4_0 // TypeDefIndex: 13752
{
	// Fields
	public bool isValid; // 0x10

	// Methods

	// RVA: 0x2D6B550 Offset: 0x2D6B651 VA: 0x2D6B550
	public void .ctor() { }

	// RVA: 0x2D6B560 Offset: 0x2D6B661 VA: 0x2D6B560
	internal void <ValidateUnits>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279290 Offset: 0x279391 VA: 0x279290
private sealed class Versus.VersusCheck.<>c__DisplayClass5_0 // TypeDefIndex: 13753
{
	// Fields
	public bool isValid; // 0x10

	// Methods

	// RVA: 0x2D6B590 Offset: 0x2D6B691 VA: 0x2D6B590
	public void .ctor() { }

	// RVA: 0x2D6B5A0 Offset: 0x2D6B6A1 VA: 0x2D6B5A0
	internal void <ValidatePlayerUnits>b__0(Unit unit) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2792A0 Offset: 0x2793A1 VA: 0x2792A0
private sealed class Versus.VersusCheck.<>c__DisplayClass14_0 // TypeDefIndex: 13754
{
	// Fields
	public List<string> idList; // 0x10
	public bool isValid; // 0x18

	// Methods

	// RVA: 0x2D6B3D0 Offset: 0x2D6B4D1 VA: 0x2D6B3D0
	public void .ctor() { }

	// RVA: 0x2D6B3E0 Offset: 0x2D6B4E1 VA: 0x2D6B3E0
	internal void <ValidateForce>b__0(Unit unit) { }
}

// Namespace: 
private class Versus.VersusCheck // TypeDefIndex: 13755
{
	// Methods

	// RVA: 0x1EE0BE0 Offset: 0x1EE0CE1 VA: 0x1EE0BE0
	public static bool Validate() { }

	// RVA: 0x1EE0CB0 Offset: 0x1EE0DB1 VA: 0x1EE0CB0
	private static bool ValidateCasual() { }

	// RVA: 0x1EE0CC0 Offset: 0x1EE0DC1 VA: 0x1EE0CC0
	private static bool ValidateRanked() { }

	// RVA: 0x1EE0CF0 Offset: 0x1EE0DF1 VA: 0x1EE0CF0
	private static bool ValidateSaveEdit() { }

	// RVA: 0x1EE0D20 Offset: 0x1EE0E21 VA: 0x1EE0D20
	private static bool ValidateUnits() { }

	// RVA: 0x1EE11F0 Offset: 0x1EE12F1 VA: 0x1EE11F0
	private static bool ValidatePlayerUnits() { }

	// RVA: 0x1EE1520 Offset: 0x1EE1621 VA: 0x1EE1520
	private static bool ValidateUnit(Unit unit) { }

	// RVA: 0x1EE1580 Offset: 0x1EE1681 VA: 0x1EE1580
	private static bool ValidateParams(Unit unit) { }

	// RVA: 0x1EE16C0 Offset: 0x1EE17C1 VA: 0x1EE16C0
	private static bool ValidateSkills(Unit unit) { }

	// RVA: 0x1EE1690 Offset: 0x1EE1791 VA: 0x1EE1690
	private static bool ValidateEquipRing(Unit unit) { }

	// RVA: 0x1EE18E0 Offset: 0x1EE19E1 VA: 0x1EE18E0
	private static bool ValidateJob(Unit unit) { }

	// RVA: 0x1EE19C0 Offset: 0x1EE1AC1 VA: 0x1EE19C0
	private static bool ValidateEquipSkill(SkillData skill) { }

	// RVA: 0x1EE19D0 Offset: 0x1EE1AD1 VA: 0x1EE19D0
	private static bool ValidateGodSkills(GodUnit god, Unit unit) { }

	// RVA: 0x1EE1E10 Offset: 0x1EE1F11 VA: 0x1EE1E10
	private static void GetGrowthSkills(GodUnit god, out List<string> growthSynchroSkills, out List<string> growthEngageSkills) { }

	// RVA: 0x1EE12F0 Offset: 0x1EE13F1 VA: 0x1EE12F0
	private static bool ValidateForce(uint forceMask) { }

	// RVA: 0x1EE1430 Offset: 0x1EE1531 VA: 0x1EE1430
	private static bool ValidateCount() { }

	// RVA: 0x1EE0E30 Offset: 0x1EE0F31 VA: 0x1EE0E30
	private static bool ValidateEditMap() { }

	// RVA: 0x1EE2150 Offset: 0x1EE2251 VA: 0x1EE2150
	private static void CountObjects(GameObject root, Versus.MapObjectCounter player, Versus.MapObjectCounter enemy) { }

	// RVA: 0x1EE2340 Offset: 0x1EE2441 VA: 0x1EE2340
	public void .ctor() { }
}

// Namespace: 
private class Versus.MapObjectCounter // TypeDefIndex: 13756
{
	// Fields
	private Dictionary<MapEditorCategoryData, int> m_Dict; // 0x10

	// Methods

	// RVA: 0x1EE0980 Offset: 0x1EE0A81 VA: 0x1EE0980
	public void .ctor() { }

	// RVA: 0x1EE0A10 Offset: 0x1EE0B11 VA: 0x1EE0A10
	public void Add(string objName) { }

	// RVA: 0x1EE0B60 Offset: 0x1EE0C61 VA: 0x1EE0B60
	public Dictionary.Enumerator<MapEditorCategoryData, int> GetEnumerator() { }
}

// Namespace: 
public enum Versus.CheckDataType // TypeDefIndex: 13757
{
	// Fields
	public int value__; // 0x0
	public const Versus.CheckDataType None = -1;
	public const Versus.CheckDataType PlayerCasualMeta = 0;
	public const Versus.CheckDataType PlayerRankedMeta = 1;
	public const Versus.CheckDataType ReplayMeta = 2;
	public const Versus.CheckDataType OpponentCasualFriend = 3;
	public const Versus.CheckDataType OpponentRankedFriend = 4;
	public const Versus.CheckDataType OpponentCasualProfile = 5;
	public const Versus.CheckDataType OpponentRankedProfile = 6;
	public const Versus.CheckDataType Num = 7;
}

// Namespace: 
private class Versus.DownloadHistory.CheckData // TypeDefIndex: 13758
{
	// Fields
	public bool m_IsDownloaded; // 0x10
	public long m_DataTime; // 0x18

	// Methods

	// RVA: 0x2D6B220 Offset: 0x2D6B321 VA: 0x2D6B220
	public void Reset() { }

	// RVA: 0x2D6B230 Offset: 0x2D6B331 VA: 0x2D6B230
	public bool IsDownloaded() { }

	// RVA: 0x2D6B330 Offset: 0x2D6B431 VA: 0x2D6B330
	public long GetElapsedTime() { }

	// RVA: 0x2D6B3C0 Offset: 0x2D6B4C1 VA: 0x2D6B3C0
	public void .ctor() { }
}

// Namespace: 
public class Versus.DownloadHistory // TypeDefIndex: 13759
{
	// Fields
	public static readonly long CoolTimeSecond; // 0x0
	private List<Versus.DownloadHistory.CheckData> m_DownloadedDataList; // 0x10

	// Methods

	// RVA: 0x1EE0310 Offset: 0x1EE0411 VA: 0x1EE0310
	public void .ctor() { }

	// RVA: 0x1EE03B0 Offset: 0x1EE04B1 VA: 0x1EE03B0
	private void InitializeCheckData() { }

	// RVA: 0x1EE05A0 Offset: 0x1EE06A1 VA: 0x1EE05A0
	public void SetDonwloaded(Versus.CheckDataType dataType) { }

	// RVA: 0x1EE0650 Offset: 0x1EE0751 VA: 0x1EE0650
	public bool IsDownloaded(Versus.CheckDataType dataType) { }

	// RVA: 0x1EE06C0 Offset: 0x1EE07C1 VA: 0x1EE06C0
	public void ResetCheckData(Versus.CheckDataType dataType) { }

	// RVA: 0x1EE0730 Offset: 0x1EE0831 VA: 0x1EE0730
	public void AllReset() { }

	// RVA: 0x1EE0930 Offset: 0x1EE0A31 VA: 0x1EE0930
	private static void .cctor() { }
}

