// Namespace: App
public class MapTarget : SingletonClass<MapTarget> // TypeDefIndex: 12247
{
	// Fields
	protected const uint WeaponMask = 894;
	private Unit m_Unit; // 0x20
	private sbyte m_X; // 0x28
	private sbyte m_Z; // 0x29
	private MapMind.Type m_Mind; // 0x2C
	private MapTarget.ActionMask m_ActionMask; // 0x30
	private MapTarget.ActionMask m_ActionTemp; // 0x34
	private MapTarget.DataSet m_DataSet; // 0x38
	private MapTarget.DataSet m_BufferA; // 0x40
	private MapTarget.DataSet m_BufferB; // 0x48
	private Unit m_SelectUnit; // 0x50
	private sbyte m_SelectX; // 0x58
	private sbyte m_SelectZ; // 0x59
	private int m_SelectItemIndex; // 0x5C
	private SkillData m_CommandSkill; // 0x60
	private MapFor.TargetFunction m_EnumerateAttackUnitItems; // 0x68
	private MapFor.TargetFunction m_EnumerateAttackSpecifiedItem; // 0x70
	private MapFor.TargetFunction m_EnumerateRodUnitItems; // 0x78
	private MapFor.TargetFunction m_EnumerateRodSpecifiedItem; // 0x80
	private static MapTarget.Data s_DummyData; // 0x0

	// Properties
	public Unit Unit { get; set; }
	public int X { get; }
	public int Z { get; }
	public MapMind.Type Mind { get; set; }
	public bool IsActive { get; }
	public bool IsAttack { get; }
	public MapTarget.ActionMask ActionMaskValue { get; set; }
	public MapTarget.DataSet Datas { get; }
	public int DataCount { get; }
	public uint DataItemMask { get; }
	public int DataItemCount { get; }
	public Unit SelectUnit { get; set; }
	public int SelectX { get; }
	public int SelectZ { get; }
	public int SelectItemIndex { get; set; }
	public SkillData CommandSkill { get; }
	public UnitItem SpecifiedItem { get; }

	// Methods

	// RVA: 0x2744D80 Offset: 0x2744E81 VA: 0x2744D80
	public void .ctor() { }

	// RVA: 0x27450A0 Offset: 0x27451A1 VA: 0x27450A0
	public void BeginTempBuffer() { }

	// RVA: 0x27450E0 Offset: 0x27451E1 VA: 0x27450E0
	public void EndTempBuffer() { }

	// RVA: 0x2745120 Offset: 0x2745221 VA: 0x2745120
	private void ResetDataSet(MapTarget.DataSet dataSet) { }

	// RVA: 0x2745140 Offset: 0x2745241 VA: 0x2745140
	private void ResetDataSet() { }

	// RVA: 0x2745020 Offset: 0x2745121 VA: 0x2745020
	public void Reset() { }

	// RVA: 0x2745160 Offset: 0x2745261 VA: 0x2745160
	public void Reset(Unit unit, MapMind.Type mind, SkillData skill) { }

	// RVA: 0x2745220 Offset: 0x2745321 VA: 0x2745220
	public void Dump(string label) { }

	// RVA: 0x2745730 Offset: 0x2745831 VA: 0x2745730
	public void ReEnumerate() { }

	// RVA: 0x2745740 Offset: 0x2745841 VA: 0x2745740
	public void Enumerate(MapTarget.ActionMask mask = 0) { }

	// RVA: 0x274C230 Offset: 0x274C331 VA: 0x274C230
	public bool CheckDataItemMask(int index) { }

	// RVA: 0x274C250 Offset: 0x274C351 VA: 0x274C250
	public void SetPosition(int x, int z) { }

	// RVA: 0x274C260 Offset: 0x274C361 VA: 0x274C260
	public void SetSelectPosition(int x, int z) { }

	// RVA: 0x274C270 Offset: 0x274C371 VA: 0x274C270
	public Unit get_Unit() { }

	// RVA: 0x274C280 Offset: 0x274C381 VA: 0x274C280
	public void set_Unit(Unit value) { }

	// RVA: 0x274C290 Offset: 0x274C391 VA: 0x274C290
	public int get_X() { }

	// RVA: 0x274C2A0 Offset: 0x274C3A1 VA: 0x274C2A0
	public int get_Z() { }

	// RVA: 0x274C2B0 Offset: 0x274C3B1 VA: 0x274C2B0
	public MapMind.Type get_Mind() { }

	// RVA: 0x274C2C0 Offset: 0x274C3C1 VA: 0x274C2C0
	public void set_Mind(MapMind.Type value) { }

	// RVA: 0x274C2D0 Offset: 0x274C3D1 VA: 0x274C2D0
	public bool get_IsActive() { }

	// RVA: 0x274C2E0 Offset: 0x274C3E1 VA: 0x274C2E0
	public bool get_IsAttack() { }

	// RVA: 0x274C2F0 Offset: 0x274C3F1 VA: 0x274C2F0
	public MapTarget.ActionMask get_ActionMaskValue() { }

	// RVA: 0x274C300 Offset: 0x274C401 VA: 0x274C300
	public void set_ActionMaskValue(MapTarget.ActionMask value) { }

	// RVA: 0x274C310 Offset: 0x274C411 VA: 0x274C310
	public MapTarget.DataSet get_Datas() { }

	// RVA: 0x27456E0 Offset: 0x27457E1 VA: 0x27456E0
	public int get_DataCount() { }

	// RVA: 0x274C320 Offset: 0x274C421 VA: 0x274C320
	public uint get_DataItemMask() { }

	// RVA: 0x274C330 Offset: 0x274C431 VA: 0x274C330
	public int get_DataItemCount() { }

	// RVA: 0x274C380 Offset: 0x274C481 VA: 0x274C380
	public Unit get_SelectUnit() { }

	// RVA: 0x274C390 Offset: 0x274C491 VA: 0x274C390
	public void set_SelectUnit(Unit value) { }

	// RVA: 0x274C3A0 Offset: 0x274C4A1 VA: 0x274C3A0
	public int get_SelectX() { }

	// RVA: 0x274C3B0 Offset: 0x274C4B1 VA: 0x274C3B0
	public int get_SelectZ() { }

	// RVA: 0x274C3C0 Offset: 0x274C4C1 VA: 0x274C3C0
	public int get_SelectItemIndex() { }

	// RVA: 0x274C3D0 Offset: 0x274C4D1 VA: 0x274C3D0
	public void set_SelectItemIndex(int value) { }

	// RVA: 0x274C3E0 Offset: 0x274C4E1 VA: 0x274C3E0
	public SkillData get_CommandSkill() { }

	// RVA: 0x274C3F0 Offset: 0x274C4F1 VA: 0x274C3F0
	public UnitItem get_SpecifiedItem() { }

	// RVA: 0x274C410 Offset: 0x274C511 VA: 0x274C410
	public static bool CanAttack(Unit unit, Unit target, SkillData skill) { }

	// RVA: 0x274C490 Offset: 0x274C591 VA: 0x274C490
	public static bool CanAttack(MapMind.Type mind, Unit unit, Unit target, SkillData skill) { }

	// RVA: 0x274C890 Offset: 0x274C991 VA: 0x274C890
	public static uint PrecheckItemMaskAttack(Unit unit, MapTarget.ActionMask mask, SkillData skill) { }

	// RVA: 0x274D030 Offset: 0x274D131 VA: 0x274D030
	public static MapTarget.RangeType CalcAttackRange(Unit unit, MapTarget.ActionMask mask, SkillData skill, UnitItem specifiedItem, out int minRange, out int maxRange) { }

	// RVA: 0x274D0F0 Offset: 0x274D1F1 VA: 0x274D0F0
	private static MapTarget.RangeType CalcAttackRange(Unit unit, MapTarget.ActionMask mask, SkillData skill, UnitItem specifiedItem, out int minRange, out int maxRange, out uint itemMask) { }

	// RVA: 0x274E350 Offset: 0x274E451 VA: 0x274E350
	private void EnumerateAttackUnitItems(int attackX, int attackZ, int targetX, int targetZ, Unit target, uint itemMask, UnitItem specifiedItem) { }

	// RVA: 0x274E6C0 Offset: 0x274E7C1 VA: 0x274E6C0
	private void EnumerateAttackSpecifiedItem(int attackX, int attackZ, int targetX, int targetZ, Unit target, uint itemMask, UnitItem specifiedItem) { }

	// RVA: 0x27459C0 Offset: 0x2745AC1 VA: 0x27459C0
	private void EnumerateAttack(MapTarget.ActionMask mask) { }

	// RVA: 0x2745DF0 Offset: 0x2745EF1 VA: 0x2745DF0
	private void EnumerateFullBullet() { }

	// RVA: 0x274E830 Offset: 0x274E931 VA: 0x274E830
	private void EnumerateRod(UnitItem specifiedItem) { }

	// RVA: 0x274F1E0 Offset: 0x274F2E1 VA: 0x274F1E0
	private void EnumerateRod(uint itemMask) { }

	// RVA: 0x2747310 Offset: 0x2747411 VA: 0x2747310
	private void EnumerateRod() { }

	// RVA: 0x274FAD0 Offset: 0x274FBD1 VA: 0x274FAD0
	private void EnumerateRodUnitItems(int attackX, int attackZ, int targetX, int targetZ, Unit target, uint itemMask, UnitItem specifiedItem) { }

	// RVA: 0x274FDE0 Offset: 0x274FEE1 VA: 0x274FDE0
	private void EnumerateRodSpecifiedItem(int attackX, int attackZ, int targetX, int targetZ, Unit target, uint itemMask, UnitItem specifiedItem) { }

	// RVA: 0x274F3F0 Offset: 0x274F4F1 VA: 0x274F3F0
	private static uint PrecheckItemMaskRod(Unit unit, MapMind.Type mind, MapTarget.ActionMask mask) { }

	// RVA: 0x274FF60 Offset: 0x2750061 VA: 0x274FF60
	public void EnumerateRodForItemSelect(UnitItem selectedUnitItem) { }

	// RVA: 0x2750000 Offset: 0x2750101 VA: 0x2750000
	private uint GetSameTypeItemMaskRod(UnitItem sourceUnitItem) { }

	// RVA: 0x274B540 Offset: 0x274B641 VA: 0x274B540
	private void EnumerateSelfOnly(uint itemMask = 0) { }

	// RVA: 0x27507A0 Offset: 0x27508A1 VA: 0x27507A0
	public static void EachEnchantTarget(Unit unit, int x, int z, ItemData item, Action<Unit, int, int> func) { }

	// RVA: 0x2750840 Offset: 0x2750941 VA: 0x2750840
	public static void EachEnchantTarget(Unit unit, int x, int z, ItemData item, bool cancelable, Action<Unit, int, int> func) { }

	// RVA: 0x274B640 Offset: 0x274B741 VA: 0x274B640
	private void EnumerateEnchant() { }

	// RVA: 0x27464F0 Offset: 0x27465F1 VA: 0x27464F0
	private void EnumerateWeapon() { }

	// RVA: 0x2747440 Offset: 0x2747541 VA: 0x2747440
	private void EnumerateTalk() { }

	// RVA: 0x2747D00 Offset: 0x2747E01 VA: 0x2747D00
	private void EnumerateDance() { }

	// RVA: 0x274B980 Offset: 0x274BA81 VA: 0x274B980
	private void EnumerateContract() { }

	// RVA: 0x2748600 Offset: 0x2748701 VA: 0x2748600
	private void EnumerateTrade() { }

	// RVA: 0x2750E50 Offset: 0x2750F51 VA: 0x2750E50
	private uint PrecheckItemMaskRod(ItemData.UseTypes useType) { }

	// RVA: 0x2749180 Offset: 0x2749281 VA: 0x2749180
	private void EnumerateRodRewarp() { }

	// RVA: 0x27492E0 Offset: 0x27493E1 VA: 0x27492E0
	private void EnumerateRodTorch() { }

	// RVA: 0x2751520 Offset: 0x2751621 VA: 0x2751520
	private bool TryAddCreation(int x, int z, uint itemMask) { }

	// RVA: 0x2749440 Offset: 0x2749541 VA: 0x2749440
	private void EnumerateRodCreation() { }

	// RVA: 0x274A1E0 Offset: 0x274A2E1 VA: 0x274A1E0
	private void EnumerateOverlapSkill() { }

	// RVA: 0x274A6E0 Offset: 0x274A7E1 VA: 0x274A6E0
	private void EnumerateCommandSkill() { }

	// RVA: 0x2749860 Offset: 0x2749961 VA: 0x2749860
	private void EnumerateDestroy(MapTarget.ActionMask mask) { }

	// RVA: 0x27518F0 Offset: 0x27519F1 VA: 0x27518F0
	private void EnumerateDestroy(uint itemMask, int x, int z) { }

	// RVA: 0x2751670 Offset: 0x2751771 VA: 0x2751670
	private void EnumerateDestroy(uint itemMask, int x, int z, int x1, int z1, int x2, int z2) { }

	// RVA: 0x274AE70 Offset: 0x274AF71 VA: 0x274AE70
	private void EnumerateMapInspector(MapInspector.Kind kind) { }

	// RVA: 0x2746DF0 Offset: 0x2746EF1 VA: 0x2746DF0
	private void EnumerateFireCannon() { }

	// RVA: 0x274B0E0 Offset: 0x274B1E1 VA: 0x274B0E0
	private void EnumerateEngageLink() { }

	// RVA: 0x274C220 Offset: 0x274C321 VA: 0x274C220
	private void Sort() { }

	// RVA: 0x2751920 Offset: 0x2751A21 VA: 0x2751920
	public int GetUsableItemIndex(MapTarget.Data data, int itemIndex) { }

	// RVA: 0x2751A00 Offset: 0x2751B01 VA: 0x2751A00
	public ItemData GetSelectItem() { }

	// RVA: 0x2751A90 Offset: 0x2751B91 VA: 0x2751A90
	private static bool IsUnnecessaryItemCommand(MapMind.Type mind) { }

	// RVA: 0x2751AB0 Offset: 0x2751BB1 VA: 0x2751AB0
	public void GetDefaultTarget(out MapTarget.Data targetData, out int itemIndex) { }

	// RVA: 0x27526A0 Offset: 0x27527A1 VA: 0x27526A0
	private static void .cctor() { }
}

