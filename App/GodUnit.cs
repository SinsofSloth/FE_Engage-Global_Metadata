// Namespace: App
public class GodUnit : LinkNode<GodUnit> // TypeDefIndex: 13472
{
	// Fields
	public const int Version = 8;
	public const int MaxSynchroCount = 9999;
	private GodData m_Data; // 0x20
	private Unit m_Parent; // 0x28
	private Unit m_Child; // 0x30
	private GodBondHolder m_Bonds; // 0x38
	private Unit m_SavedParent; // 0x40
	private bool m_IsTemporaryParent; // 0x48
	private bool m_IsTemporaryChanged; // 0x49
	private bool m_IsReservedDeleting; // 0x4A
	private bool m_IsEscaping; // 0x4B
	private byte m_Dirty; // 0x4C
	private Dictionary<string, int> m_SynchroCounts; // 0x50
	private Dictionary<string, GodWeaponRefineLevels> m_WeaponRefineLevels; // 0x58
	private Dictionary<string, GodWeaponRefineResult> m_WeaponRefineResults; // 0x60
	private SkillArray m_SyncroSkills; // 0x68
	public const int DirtyMax = 255;
	[CompilerGeneratedAttribute] // RVA: 0x29C340 Offset: 0x29C441 VA: 0x29C340
	private bool <IsDarkness>k__BackingField; // 0x70
	private static readonly List<ItemData> s_NullItems; // 0x0
	private static readonly SkillArray s_NullSkills; // 0x8

	// Properties
	public bool IsReservedDeleting { get; }
	public bool IsEscaping { get; set; }
	public int Dirty { get; set; }
	public GodData Data { get; }
	public GodData InfoData { get; }
	public GodData ActualData { get; }
	public GodData ResultData { get; }
	public string Gid { get; }
	public string ActualGid { get; }
	public bool IsDarkness { get; set; }
	public bool IsDarknessIcon { get; }
	public bool IsDarknessGauge { get; }
	public bool IsOnlyEngageWeapon { get; }
	public bool IsEngaging { get; }
	public bool IsChanged { get; }
	public Force.Type ForceType { get; }
	public int EngageLimit { get; }
	public Unit Parent { get; }
	public Unit Child { get; }
	public Dictionary<string, int> SynchroCounts { get; }
	public GodBondHolder GodBonds { get; }
	public static float RingDirtySep1 { get; }
	public static float RingDirtySep2 { get; }
	public override int SortKey { get; }

	// Methods

	// RVA: 0x27A8630 Offset: 0x27A8731 VA: 0x27A8630
	public GodUnit Build(GodData data) { }

	// RVA: 0x27A8820 Offset: 0x27A8921 VA: 0x27A8820
	public void Delete() { }

	// RVA: 0x27A89A0 Offset: 0x27A8AA1 VA: 0x27A89A0
	public void ReserveDeleting() { }

	// RVA: 0x27A8700 Offset: 0x27A8801 VA: 0x27A8700
	public void CancelToReserveDeleting() { }

	// RVA: 0x27B1E70 Offset: 0x27B1F71 VA: 0x27B1E70
	public bool get_IsReservedDeleting() { }

	// RVA: 0x27B1E80 Offset: 0x27B1F81 VA: 0x27B1E80
	public bool get_IsEscaping() { }

	// RVA: 0x27B1E90 Offset: 0x27B1F91 VA: 0x27B1E90
	public void set_IsEscaping(bool value) { }

	// RVA: 0x27B1EA0 Offset: 0x27B1FA1 VA: 0x27B1EA0
	public int get_Dirty() { }

	// RVA: 0x27B1EB0 Offset: 0x27B1FB1 VA: 0x27B1EB0
	public void set_Dirty(int value) { }

	// RVA: 0x27B1EC0 Offset: 0x27B1FC1 VA: 0x27B1EC0
	public GodData get_Data() { }

	// RVA: 0x27B1F50 Offset: 0x27B2051 VA: 0x27B1F50
	public GodData get_InfoData() { }

	// RVA: 0x27B1FF0 Offset: 0x27B20F1 VA: 0x27B1FF0
	public GodData get_ActualData() { }

	// RVA: 0x27B2000 Offset: 0x27B2101 VA: 0x27B2000
	public GodData get_ResultData() { }

	// RVA: 0x27B2020 Offset: 0x27B2121 VA: 0x27B2020
	public string get_Gid() { }

	// RVA: 0x27B20C0 Offset: 0x27B21C1 VA: 0x27B20C0
	public string get_ActualGid() { }

	// RVA: 0x27B20E0 Offset: 0x27B21E1 VA: 0x27B20E0
	public bool IsHero() { }

	// RVA: 0x27B2220 Offset: 0x27B2321 VA: 0x27B2220
	public bool IsFlag(GodData.Flags flag) { }

	// RVA: 0x27B2360 Offset: 0x27B2461 VA: 0x27B2360
	public string GetName() { }

	// RVA: 0x27B2530 Offset: 0x27B2631 VA: 0x27B2530
	public string GetInfoName() { }

	// RVA: 0x27A4270 Offset: 0x27A4371 VA: 0x27A4270
	public string GetMainName() { }

	// RVA: 0x27B2430 Offset: 0x27B2531 VA: 0x27B2430
	public static string GetName(GodData data) { }

	// RVA: 0x27A9890 Offset: 0x27A9991 VA: 0x27A9890
	public string GetAsciiName() { }

	// RVA: 0x27B2610 Offset: 0x27B2711 VA: 0x27B2610
	public string GetMainAsciiName() { }

	// RVA: 0x27B2700 Offset: 0x27B2801 VA: 0x27B2700
	public string GetFaceIconName() { }

	// RVA: 0x27B2790 Offset: 0x27B2891 VA: 0x27B2790
	public string GetInfoFaceIconName() { }

	// RVA: 0x27B2830 Offset: 0x27B2931 VA: 0x27B2830
	public string GetFaceIconNameDarkness() { }

	// RVA: 0x27B28C0 Offset: 0x27B29C1 VA: 0x27B28C0
	public string GetFaceIconNameForHero() { }

	// RVA: 0x27B2950 Offset: 0x27B2A51 VA: 0x27B2950
	public string GetFaceIconNameForHeroine() { }

	// RVA: 0x27B29E0 Offset: 0x27B2AE1 VA: 0x27B29E0
	public string GetRingName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBAD0 Offset: 0x2CBBD1 VA: 0x2CBAD0
	// RVA: 0x27B2B60 Offset: 0x27B2C61 VA: 0x27B2B60
	public bool get_IsDarkness() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBAE0 Offset: 0x2CBBE1 VA: 0x2CBAE0
	// RVA: 0x27B2B70 Offset: 0x27B2C71 VA: 0x27B2B70
	public void set_IsDarkness(bool value) { }

	// RVA: 0x27B2B80 Offset: 0x27B2C81 VA: 0x27B2B80
	public bool get_IsDarknessIcon() { }

	// RVA: 0x27B2C70 Offset: 0x27B2D71 VA: 0x27B2C70
	public bool get_IsDarknessGauge() { }

	// RVA: 0x27B2D60 Offset: 0x27B2E61 VA: 0x27B2D60
	public bool get_IsOnlyEngageWeapon() { }

	// RVA: 0x27B2E30 Offset: 0x27B2F31 VA: 0x27B2E30
	public Gender GetGender() { }

	// RVA: 0x27B3020 Offset: 0x27B3121 VA: 0x27B3020
	public bool IsFemale() { }

	// RVA: 0x27B3040 Offset: 0x27B3141 VA: 0x27B3040
	public bool ChangeMain() { }

	// RVA: 0x27B3120 Offset: 0x27B3221 VA: 0x27B3120
	public bool CanSwap() { }

	// RVA: 0x27B3150 Offset: 0x27B3251 VA: 0x27B3150
	public bool Swap() { }

	// RVA: 0x27B30A0 Offset: 0x27B31A1 VA: 0x27B30A0
	public bool Change(int index) { }

	// RVA: 0x27B31C0 Offset: 0x27B32C1 VA: 0x27B31C0
	public bool Change(GodData data) { }

	// RVA: 0x27B3210 Offset: 0x27B3311 VA: 0x27B3210
	public void SetGodDataForRewind(GodData data) { }

	// RVA: 0x27B3220 Offset: 0x27B3321 VA: 0x27B3220
	public bool get_IsEngaging() { }

	// RVA: 0x27B32A0 Offset: 0x27B33A1 VA: 0x27B32A0
	public bool get_IsChanged() { }

	// RVA: 0x27A8ED0 Offset: 0x27A8FD1 VA: 0x27A8ED0
	public Force.Type get_ForceType() { }

	// RVA: 0x27B3340 Offset: 0x27B3441 VA: 0x27B3340
	public int get_EngageLimit() { }

	// RVA: 0x27B33D0 Offset: 0x27B34D1 VA: 0x27B33D0
	public Unit get_Parent() { }

	// RVA: 0x27B33E0 Offset: 0x27B34E1 VA: 0x27B33E0
	public Unit get_Child() { }

	// RVA: 0x27B33F0 Offset: 0x27B34F1 VA: 0x27B33F0
	public void SetParent(Unit unit, GodState godState) { }

	// RVA: 0x27B34E0 Offset: 0x27B35E1 VA: 0x27B34E0
	public void ClearParent() { }

	// RVA: 0x27B3560 Offset: 0x27B3661 VA: 0x27B3560
	public void SetChild(Unit unit) { }

	// RVA: 0x27B3570 Offset: 0x27B3671 VA: 0x27B3570
	public void ClearChild() { }

	// RVA: 0x27B3580 Offset: 0x27B3681 VA: 0x27B3580
	public Unit GetLink(Unit unit) { }

	// RVA: 0x27B35B0 Offset: 0x27B36B1 VA: 0x27B35B0
	public void SetTemporaryParent(Unit unit) { }

	// RVA: 0x27B3660 Offset: 0x27B3761 VA: 0x27B3660
	public void ClearTemporaryParent(Unit unit) { }

	// RVA: 0x27B3780 Offset: 0x27B3881 VA: 0x27B3780
	public Dictionary<string, int> get_SynchroCounts() { }

	// RVA: 0x27B3790 Offset: 0x27B3891 VA: 0x27B3790
	public void AddSynchroCount(string pid) { }

	// RVA: 0x27B3870 Offset: 0x27B3971 VA: 0x27B3870
	public void SetSynchroCount(string pid, int count) { }

	// RVA: 0x27B3940 Offset: 0x27B3A41 VA: 0x27B3940
	public int GetSynchroCount(string pid) { }

	[ConditionalAttribute] // RVA: 0x2CBAF0 Offset: 0x2CBBF1 VA: 0x2CBAF0
	// RVA: 0x27B39C0 Offset: 0x27B3AC1 VA: 0x27B39C0
	public void DbgSetExp(Unit unit, int exp) { }

	// RVA: 0x27B39E0 Offset: 0x27B3AE1 VA: 0x27B39E0
	public void SetExpForRewind(Unit unit, int exp) { }

	// RVA: 0x27B3A20 Offset: 0x27B3B21 VA: 0x27B3A20
	public bool CanAddExp(Unit unit) { }

	// RVA: 0x27B3A80 Offset: 0x27B3B81 VA: 0x27B3A80
	public bool CanAddExp() { }

	// RVA: 0x27B3AE0 Offset: 0x27B3BE1 VA: 0x27B3AE0
	public bool TryAddExp(Unit unit, int exp) { }

	// RVA: 0x27B3B20 Offset: 0x27B3C21 VA: 0x27B3B20
	public bool TryAddExpCurrentLevel(Unit unit, int exp) { }

	// RVA: 0x27B3BB0 Offset: 0x27B3CB1 VA: 0x27B3BB0
	public int GetExp(Unit unit) { }

	// RVA: 0x27B3BE0 Offset: 0x27B3CE1 VA: 0x27B3BE0
	public int GetExp() { }

	// RVA: 0x27B3C10 Offset: 0x27B3D11 VA: 0x27B3C10
	public int GetNextLevelExp(Unit unit) { }

	// RVA: 0x27B3C40 Offset: 0x27B3D41 VA: 0x27B3C40
	public int GetNextLevelExp() { }

	// RVA: 0x27B3C70 Offset: 0x27B3D71 VA: 0x27B3C70
	public int GetNextLevelCap() { }

	// RVA: 0x27B3CA0 Offset: 0x27B3DA1 VA: 0x27B3CA0
	public int GetNextLevelCap(Unit unit) { }

	// RVA: 0x27B3CD0 Offset: 0x27B3DD1 VA: 0x27B3CD0
	public int GetLevelExp(int level) { }

	// RVA: 0x27B3D20 Offset: 0x27B3E21 VA: 0x27B3D20
	public int GetLevelExp(Unit unit, int level) { }

	// RVA: 0x27B3D60 Offset: 0x27B3E61 VA: 0x27B3D60
	public int GetMaxExp(Unit unit) { }

	// RVA: 0x27B3D90 Offset: 0x27B3E91 VA: 0x27B3D90
	public int GetMaxExp() { }

	// RVA: 0x27AA030 Offset: 0x27AA131 VA: 0x27AA030
	public int GetDiffExp(Unit unit) { }

	// RVA: 0x27B3DC0 Offset: 0x27B3EC1 VA: 0x27B3DC0
	public int GetDiffExp() { }

	// RVA: 0x27A9FE0 Offset: 0x27AA0E1 VA: 0x27A9FE0
	public int GetMaxDiffExp(Unit unit) { }

	// RVA: 0x27B3E00 Offset: 0x27B3F01 VA: 0x27B3E00
	public int GetMaxDiffExp() { }

	// RVA: 0x27B3E50 Offset: 0x27B3F51 VA: 0x27B3E50
	public void SetLevel(Unit unit, int level) { }

	// RVA: 0x27B3E90 Offset: 0x27B3F91 VA: 0x27B3E90
	public void SetLevel(int level) { }

	// RVA: 0x27B3EE0 Offset: 0x27B3FE1 VA: 0x27B3EE0
	public void SetLevelFromUnitReliance(Unit unit, RelianceData.Level unitRelianceLevel) { }

	[ConditionalAttribute] // RVA: 0x2CBB30 Offset: 0x2CBC31 VA: 0x2CBB30
	// RVA: 0x27B3F20 Offset: 0x27B4021 VA: 0x27B3F20
	public void DbgSetLevel(Unit unit, int level) { }

	// RVA: 0x27A3DA0 Offset: 0x27A3EA1 VA: 0x27A3DA0
	public int GetLevel(Unit unit) { }

	// RVA: 0x27B3F30 Offset: 0x27B4031 VA: 0x27B3F30
	public int GetLevel() { }

	// RVA: 0x27A43D0 Offset: 0x27A44D1 VA: 0x27A43D0
	public int GetLevelFromExp(Unit unit) { }

	// RVA: 0x27B3F70 Offset: 0x27B4071 VA: 0x27B3F70
	public int GetMaxLevel(Unit unit) { }

	// RVA: 0x27A7DF0 Offset: 0x27A7EF1 VA: 0x27A7DF0
	public void LevelUp(Unit unit) { }

	// RVA: 0x27B3FA0 Offset: 0x27B40A1 VA: 0x27B3FA0
	public bool IsUnlockedLevelCap() { }

	// RVA: 0x27B4010 Offset: 0x27B4111 VA: 0x27B4010
	public static bool IsUnlockedLevelCap(GodData godData) { }

	// RVA: 0x27B4160 Offset: 0x27B4261 VA: 0x27B4160
	public void UnlockLevelCap() { }

	// RVA: 0x27B41D0 Offset: 0x27B42D1 VA: 0x27B41D0
	public static void UnlockLevelCap(GodData godData) { }

	// RVA: 0x27B4400 Offset: 0x27B4501 VA: 0x27B4400
	public void LockLevelCap() { }

	// RVA: 0x27B4470 Offset: 0x27B4571 VA: 0x27B4470
	public static void LockLevelCap(GodData godData) { }

	// RVA: 0x27B4670 Offset: 0x27B4771 VA: 0x27B4670
	public bool IsLevelCapNormal(Unit unit) { }

	// RVA: 0x27A4080 Offset: 0x27A4181 VA: 0x27A4080
	public bool IsLevelCapTalk(Unit unit) { }

	// RVA: 0x27A4050 Offset: 0x27A4151 VA: 0x27A4050
	public bool IsNotifiedLevelCapTalk(Unit unit) { }

	// RVA: 0x27A42E0 Offset: 0x27A43E1 VA: 0x27A42E0
	public void SetNotifiedLevelCapTalk(Unit unit, bool flag = True) { }

	// RVA: 0x27A9920 Offset: 0x27A9A21 VA: 0x27A9920
	public GodData.RelianceLevel GetRelianceLevel(Unit unit) { }

	// RVA: 0x27B46A0 Offset: 0x27B47A1 VA: 0x27B46A0
	public GodData.RelianceLevel GetMaxRelianceLevel(Unit unit) { }

	// RVA: 0x27B46D0 Offset: 0x27B47D1 VA: 0x27B46D0
	public bool CanBeRelianceLevelS(Unit unit) { }

	// RVA: 0x27B4700 Offset: 0x27B4801 VA: 0x27B4700
	public void SetRelianceLevelS(Unit unit) { }

	[ConditionalAttribute] // RVA: 0x2CBB70 Offset: 0x2CBC71 VA: 0x2CBB70
	// RVA: 0x27B4730 Offset: 0x27B4831 VA: 0x27B4730
	public void DbgSetRelianceLevelS(Unit unit) { }

	// RVA: 0x27B4740 Offset: 0x27B4841 VA: 0x27B4740
	public int GetCountOfRelianceLevelA() { }

	// RVA: 0x27A7E20 Offset: 0x27A7F21 VA: 0x27A7E20
	public void UpdateState() { }

	// RVA: 0x27A40B0 Offset: 0x27A41B1 VA: 0x27A40B0
	public bool CanTalk(Unit unit) { }

	// RVA: 0x27B4750 Offset: 0x27B4851 VA: 0x27B4750
	public GodInheritedSkills GetInheritedSkills(Unit unit) { }

	// RVA: 0x27B4780 Offset: 0x27B4881 VA: 0x27B4780
	public bool CanInheritSkills(Unit unit) { }

	// RVA: 0x27B4810 Offset: 0x27B4911 VA: 0x27B4810
	public bool CanAddEngageTurnLimit(Unit unit) { }

	// RVA: 0x27B48A0 Offset: 0x27B49A1 VA: 0x27B48A0
	public bool CanAddEngageTurnLimit() { }

	// RVA: 0x27B4930 Offset: 0x27B4A31 VA: 0x27B4930
	public bool CanSubEngageCountLimit(Unit unit) { }

	// RVA: 0x27B49C0 Offset: 0x27B4AC1 VA: 0x27B49C0
	public bool CanSubEngageCountLimit() { }

	// RVA: 0x27B4A50 Offset: 0x27B4B51 VA: 0x27B4A50
	public SkillData GetEngageAttack() { }

	// RVA: 0x27B4DD0 Offset: 0x27B4ED1 VA: 0x27B4DD0
	private static bool IsAround(Unit unitA, Unit unitB) { }

	// RVA: 0x27B5310 Offset: 0x27B5411 VA: 0x27B5310
	private static bool IsAround(GodUnit godUnit, Unit unit) { }

	// RVA: 0x27B53A0 Offset: 0x27B54A1 VA: 0x27B53A0
	public GodUnit GetLinkGodUnit() { }

	// RVA: 0x27B4A60 Offset: 0x27B4B61 VA: 0x27B4A60
	public SkillData GetEngageAttack(Unit unit) { }

	// RVA: 0x27B5430 Offset: 0x27B5531 VA: 0x27B5430
	public SkillArray GetEngageSkills(Unit unit) { }

	// RVA: 0x27B54D0 Offset: 0x27B55D1 VA: 0x27B54D0
	public SkillArray GetEngageSkills() { }

	// RVA: 0x27B5570 Offset: 0x27B5671 VA: 0x27B5570
	public SkillData GetEngageSkill(Unit unit, int index) { }

	// RVA: 0x27B5710 Offset: 0x27B5811 VA: 0x27B5710
	public SkillData GetEngageSkill(int index) { }

	// RVA: 0x27B5720 Offset: 0x27B5821 VA: 0x27B5720
	public List<ItemData> GetEngageItems(Unit unit) { }

	// RVA: 0x27B57E0 Offset: 0x27B58E1 VA: 0x27B57E0
	public List<ItemData> GetEngageItems() { }

	// RVA: 0x27B57F0 Offset: 0x27B58F1 VA: 0x27B57F0
	public SkillArray GetSyncroSkills(Unit unit) { }

	// RVA: 0x27B6190 Offset: 0x27B6291 VA: 0x27B6190
	public SkillArray GetSyncroSkills() { }

	// RVA: 0x27B61A0 Offset: 0x27B62A1 VA: 0x27B61A0
	public WeaponMask GetAptitude(Unit unit) { }

	// RVA: 0x27B61D0 Offset: 0x27B62D1 VA: 0x27B61D0
	public WeaponMask GetAptitude() { }

	// RVA: 0x27B6200 Offset: 0x27B6301 VA: 0x27B6200
	public bool CanUpdateForGodState() { }

	// RVA: 0x27B6220 Offset: 0x27B6321 VA: 0x27B6220
	public void UpdateAllBondsForGodState(GodState godState) { }

	// RVA: 0x27B3490 Offset: 0x27B3591 VA: 0x27B3490
	public void UpdateForGodState(Unit unit, GodState godState) { }

	// RVA: 0x27B6240 Offset: 0x27B6341 VA: 0x27B6240
	public void DeleteBondsExluding(List<string> pids) { }

	// RVA: 0x27B6250 Offset: 0x27B6351 VA: 0x27B6250
	public GodBondHolder get_GodBonds() { }

	// RVA: 0x27B39D0 Offset: 0x27B3AD1 VA: 0x27B39D0
	private GodBond GetBond(Unit unit) { }

	// RVA: 0x27B3480 Offset: 0x27B3581 VA: 0x27B3480
	private void CreateBond(Unit unit) { }

	// RVA: 0x27AAB00 Offset: 0x27AAC01 VA: 0x27AAB00
	public bool CanLink() { }

	// RVA: 0x27B6170 Offset: 0x27B6271 VA: 0x27B6170
	public bool CanChange() { }

	// RVA: 0x27B6260 Offset: 0x27B6361 VA: 0x27B6260
	public string GetRingPrefabPath() { }

	// RVA: 0x27B6440 Offset: 0x27B6541 VA: 0x27B6440
	public int GetDirtyLevel() { }

	// RVA: 0x27B6530 Offset: 0x27B6631 VA: 0x27B6530
	public static float get_RingDirtySep1() { }

	// RVA: 0x27B6540 Offset: 0x27B6641 VA: 0x27B6540
	public static float get_RingDirtySep2() { }

	// RVA: 0x27A3F30 Offset: 0x27A4031 VA: 0x27A3F30
	public void AddDirty(int dirty) { }

	// RVA: 0x27B6550 Offset: 0x27B6651 VA: 0x27B6550
	public void ChangeOpponent() { }

	// RVA: 0x27B1C30 Offset: 0x27B1D31 VA: 0x27B1C30
	private void InitGodWeaponRefine() { }

	// RVA: 0x27B67D0 Offset: 0x27B68D1 VA: 0x27B67D0
	public List<string> GetGodWeaponList() { }

	// RVA: 0x27B6E60 Offset: 0x27B6F61 VA: 0x27B6E60
	public int GetGodWeaponRefineLevel(string iid, GodWeaponRefineData.Kind kind) { }

	// RVA: 0x27B70B0 Offset: 0x27B71B1 VA: 0x27B70B0
	public void AddGodWeaponRefineEnhance(string iid, CapabilitySbyte capability) { }

	// RVA: 0x27B7450 Offset: 0x27B7551 VA: 0x27B7450
	public string GetGodWeaponRefineSkill(string iid) { }

	// RVA: 0x27B74E0 Offset: 0x27B75E1 VA: 0x27B74E0
	public void SetGodWeaponRefineLevel(string iid, GodWeaponRefineData.Kind kind, int level) { }

	// RVA: 0x27B7790 Offset: 0x27B7891 VA: 0x27B7790
	public void ResetGodWeaponRefineLevel(string iid, GodWeaponRefineData.Kind kind) { }

	// RVA: 0x27B77B0 Offset: 0x27B78B1 VA: 0x27B77B0
	public void IncGodWeaponRefineLevel(string iid, GodWeaponRefineData.Kind kind) { }

	// RVA: 0x27B7A00 Offset: 0x27B7B01 VA: 0x27B7A00
	public void SetGodWeaponRefineSkill(string iid, string sid) { }

	// RVA: 0x27B7A90 Offset: 0x27B7B91 VA: 0x27B7A90
	public void ResetGodWeaponRefineLevel(string iid) { }

	// RVA: 0x27B7B50 Offset: 0x27B7C51 VA: 0x27B7B50
	public int GetUsingCapacity(string iid) { }

	// RVA: 0x27B7BE0 Offset: 0x27B7CE1 VA: 0x27B7BE0
	public void SetUsingCapacity(string iid, int capacity) { }

	// RVA: 0x27B7C70 Offset: 0x27B7D71 VA: 0x27B7C70
	public void AddUsingCapacity(string iid, int capacity) { }

	// RVA: 0x27B7D00 Offset: 0x27B7E01 VA: 0x27B7D00
	public GodWeaponRefineResult TryGetGodWeaponRefineResult(string iid) { }

	// RVA: 0x27B7D90 Offset: 0x27B7E91 VA: 0x27B7D90
	public CapabilitySbyte TryGetGodWeaponRefineResultEnhance(string iid) { }

	// RVA: 0x27B7E40 Offset: 0x27B7F41 VA: 0x27B7E40
	public SkillArray TryGetGodWeaponRefineResultEquipSkills(string iid, bool isEnchant) { }

	// RVA: 0x27B7F00 Offset: 0x27B8001 VA: 0x27B7F00
	public void CorrectBond(int instanceID) { }

	// RVA: 0x27B80B0 Offset: 0x27B81B1 VA: 0x27B80B0 Slot: 7
	public override void OnSerialize(Stream stream) { }

	// RVA: 0x27B8580 Offset: 0x27B8681 VA: 0x27B8580 Slot: 8
	public override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x27B97A0 Offset: 0x27B98A1 VA: 0x27B97A0
	public void Serialize(Stream stream) { }

	// RVA: 0x27B97F0 Offset: 0x27B98F1 VA: 0x27B97F0
	public void Deserialize(Stream stream) { }

	// RVA: 0x27B1B50 Offset: 0x27B1C51 VA: 0x27B1B50
	private void Clear() { }

	// RVA: 0x27B9840 Offset: 0x27B9941 VA: 0x27B9840 Slot: 6
	public override int get_SortKey() { }

	// RVA: 0x27B9860 Offset: 0x27B9961 VA: 0x27B9860 Slot: 5
	public override bool IsValid() { }

	// RVA: 0x27B9870 Offset: 0x27B9971 VA: 0x27B9870
	public static GodData op_Implicit(GodUnit p) { }

	// RVA: 0x27B9900 Offset: 0x27B9A01 VA: 0x27B9900
	public void ChangeCancel() { }

	// RVA: 0x27B9A20 Offset: 0x27B9B21 VA: 0x27B9A20
	public void ChangeResume() { }

	// RVA: 0x27B9AA0 Offset: 0x27B9BA1 VA: 0x27B9AA0
	public void .ctor() { }

	// RVA: 0x27B9C40 Offset: 0x27B9D41 VA: 0x27B9C40
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBBB0 Offset: 0x2CBCB1 VA: 0x2CBBB0
	// RVA: 0x27B6D40 Offset: 0x27B6E41 VA: 0x27B6D40
	internal static void <GetGodWeaponList>g__AddEachIids|186_0(ref GodUnit.<>c__DisplayClass186_0 , ref GodUnit.<>c__DisplayClass186_1 ) { }
}

