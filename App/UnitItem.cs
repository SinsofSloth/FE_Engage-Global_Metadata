// Namespace: App
[DebuggerDisplayAttribute] // RVA: 0x278F40 Offset: 0x279041 VA: 0x278F40
public class UnitItem : IDisposable // TypeDefIndex: 13534
{
	// Fields
	public const int NoItemIndex = 0;
	public const int EngageStockIndex = 2;
	private const int Version = 5;
	private int m_Index; // 0x10
	private ItemData m_Item; // 0x18
	private byte m_Endurance; // 0x20
	private byte m_RefineLevel; // 0x21
	private UnitItem.Flags m_Flags; // 0x24
	private GodData m_Engrave; // 0x28
	private GodUnit m_GodUnit; // 0x30
	private static int s_EnchantHash; // 0x0

	// Properties
	public ItemData.Kinds Kind { get; }
	public ItemData.UseTypes UseType { get; }
	public ItemData.RodTypes RodType { get; }
	public string Iid { get; }
	public int Index { get; }
	public bool IsEquipped { get; set; }
	public bool IsDrop { get; set; }
	public bool IsSkipLog { get; set; }
	public bool IsEnchant { get; }
	public UnitItem.Flags FlagsValue { get; set; }
	public int Endurance { get; set; }
	public int RefineLevel { get; set; }

	// Methods

	// RVA: 0x2436770 Offset: 0x2436871 VA: 0x2436770
	public void .ctor() { }

	// RVA: 0x2436830 Offset: 0x2436931 VA: 0x2436830
	public void .ctor(ItemData item) { }

	// RVA: 0x2436950 Offset: 0x2436A51 VA: 0x2436950
	public void .ctor(string iid) { }

	// RVA: 0x2436BA0 Offset: 0x2436CA1 VA: 0x2436BA0
	public void .ctor(int index) { }

	// RVA: 0x2436D30 Offset: 0x2436E31 VA: 0x2436D30
	public void .ctor(UnitItem unitItem) { }

	// RVA: 0x2436E60 Offset: 0x2436F61 VA: 0x2436E60 Slot: 4
	public void Dispose() { }

	// RVA: 0x241F250 Offset: 0x241F351 VA: 0x241F250
	public static ItemData op_Implicit(UnitItem p) { }

	// RVA: 0x2436F20 Offset: 0x2437021 VA: 0x2436F20
	public void New(ItemData item) { }

	// RVA: 0x2437030 Offset: 0x2437131 VA: 0x2437030
	public void New(string iid) { }

	// RVA: 0x2437260 Offset: 0x2437361 VA: 0x2437260
	public void New(int index) { }

	// RVA: 0x24373E0 Offset: 0x24374E1 VA: 0x24373E0
	public void New(UnitItem unitItem) { }

	// RVA: 0x2437510 Offset: 0x2437611 VA: 0x2437510
	public void Clear() { }

	// RVA: 0x24375D0 Offset: 0x24376D1 VA: 0x24375D0
	public bool Expend() { }

	// RVA: 0x2437640 Offset: 0x2437741 VA: 0x2437640
	public void DoTrade() { }

	// RVA: 0x2437670 Offset: 0x2437771 VA: 0x2437670
	public void DoTransporter() { }

	// RVA: 0x2437680 Offset: 0x2437781 VA: 0x2437680
	public void DoDrop() { }

	// RVA: 0x2437690 Offset: 0x2437791 VA: 0x2437690
	public void DoTransfer() { }

	// RVA: 0x2437620 Offset: 0x2437721 VA: 0x2437620
	public bool CanExpend() { }

	// RVA: 0x24376A0 Offset: 0x24377A1 VA: 0x24376A0
	public int GetExpend() { }

	// RVA: 0x24376C0 Offset: 0x24377C1 VA: 0x24376C0
	public bool CanEnchant() { }

	// RVA: 0x24376D0 Offset: 0x24377D1 VA: 0x24376D0
	public bool CanEnchant(Unit unit) { }

	// RVA: 0x2437710 Offset: 0x2437811 VA: 0x2437710
	public bool IsEmpty() { }

	// RVA: 0x2437720 Offset: 0x2437821 VA: 0x2437720
	public bool IsExist() { }

	// RVA: 0x2437730 Offset: 0x2437831 VA: 0x2437730
	public bool IsIntegrate(UnitItem otherItem) { }

	// RVA: 0x2437770 Offset: 0x2437871 VA: 0x2437770
	public bool IsLongRange() { }

	// RVA: 0x2437790 Offset: 0x2437891 VA: 0x2437790
	public ItemData GetData() { }

	// RVA: 0x24377A0 Offset: 0x24378A1 VA: 0x24377A0
	public int GetPrice() { }

	// RVA: 0x24377B0 Offset: 0x24378B1 VA: 0x24377B0
	public int GetSelling() { }

	// RVA: 0x24378B0 Offset: 0x24379B1 VA: 0x24378B0
	public bool IsFlag(ItemData.Flags flags) { }

	// RVA: 0x2437920 Offset: 0x2437A21 VA: 0x2437920
	public bool NotFlag(ItemData.Flags flags) { }

	// RVA: 0x2437990 Offset: 0x2437A91 VA: 0x2437990
	public bool IsNone() { }

	// RVA: 0x24379B0 Offset: 0x2437AB1 VA: 0x24379B0
	public bool IsInventory() { }

	// RVA: 0x24379C0 Offset: 0x2437AC1 VA: 0x24379C0
	public ItemData.Kinds get_Kind() { }

	// RVA: 0x24379D0 Offset: 0x2437AD1 VA: 0x24379D0
	public ItemData.UseTypes get_UseType() { }

	// RVA: 0x24379E0 Offset: 0x2437AE1 VA: 0x24379E0
	public ItemData.RodTypes get_RodType() { }

	// RVA: 0x24379F0 Offset: 0x2437AF1 VA: 0x24379F0
	public bool IsRangeTarget() { }

	// RVA: 0x2437A60 Offset: 0x2437B61 VA: 0x2437A60
	public bool IsRangeHeal() { }

	// RVA: 0x2437AE0 Offset: 0x2437BE1 VA: 0x2437AE0
	public bool IsRangeRestHeal() { }

	// RVA: 0x2437B60 Offset: 0x2437C61 VA: 0x2437B60
	public bool IsRangeAgain() { }

	// RVA: 0x2437BE0 Offset: 0x2437CE1 VA: 0x2437BE0
	public bool IsRangeEngageAdd() { }

	// RVA: 0x2437C60 Offset: 0x2437D61 VA: 0x2437C60
	public bool IsBless() { }

	// RVA: 0x2437C80 Offset: 0x2437D81 VA: 0x2437C80
	public bool IsBullet() { }

	// RVA: 0x2437C90 Offset: 0x2437D91 VA: 0x2437C90
	public EffectData GetShootEffect() { }

	// RVA: 0x2437CB0 Offset: 0x2437DB1 VA: 0x2437CB0
	public EffectData GetHitEffect() { }

	// RVA: 0x2437CD0 Offset: 0x2437DD1 VA: 0x2437CD0
	public EffectSequence GetCannonEffect() { }

	// RVA: 0x2437CF0 Offset: 0x2437DF1 VA: 0x2437CF0
	public ItemData.Attrs GetAttr() { }

	// RVA: 0x2437D00 Offset: 0x2437E01 VA: 0x2437D00
	public ItemData.WeaponAttrs GetWeaponAttr() { }

	// RVA: 0x2437D10 Offset: 0x2437E11 VA: 0x2437D10
	public bool IsWeapon() { }

	// RVA: 0x2437D20 Offset: 0x2437E21 VA: 0x2437D20
	public bool IsPhysical() { }

	// RVA: 0x2437D40 Offset: 0x2437E41 VA: 0x2437D40
	public bool IsMagic() { }

	// RVA: 0x2437D60 Offset: 0x2437E61 VA: 0x2437D60
	public bool IsBreath() { }

	// RVA: 0x2437DD0 Offset: 0x2437ED1 VA: 0x2437DD0
	public bool IsSurehit() { }

	// RVA: 0x2437E00 Offset: 0x2437F01 VA: 0x2437E00
	public bool IsRod() { }

	// RVA: 0x2437E20 Offset: 0x2437F21 VA: 0x2437E20
	public ItemData.RodTypes GetRodType() { }

	// RVA: 0x2437E40 Offset: 0x2437F41 VA: 0x2437E40
	public bool IsSingleRod() { }

	// RVA: 0x2437ED0 Offset: 0x2437FD1 VA: 0x2437ED0
	public ItemData.Kinds GetKind() { }

	// RVA: 0x2437EE0 Offset: 0x2437FE1 VA: 0x2437EE0
	public bool IsEfficacy(Unit target) { }

	// RVA: 0x24380F0 Offset: 0x24381F1 VA: 0x24380F0
	public string GetName(bool withRefineLevel = True) { }

	// RVA: 0x2438440 Offset: 0x2438541 VA: 0x2438440
	public string GetOriginalName() { }

	// RVA: 0x2438450 Offset: 0x2438551 VA: 0x2438450
	public int GetPower() { }

	// RVA: 0x2438610 Offset: 0x2438711 VA: 0x2438610
	public int GetWeight() { }

	// RVA: 0x24386E0 Offset: 0x24387E1 VA: 0x24386E0
	public int GetHit() { }

	// RVA: 0x24387E0 Offset: 0x24388E1 VA: 0x24387E0
	public int GetCritical() { }

	// RVA: 0x24388E0 Offset: 0x24389E1 VA: 0x24388E0
	public int GetAvoid() { }

	// RVA: 0x2438950 Offset: 0x2438A51 VA: 0x2438950
	public int GetSecure() { }

	// RVA: 0x24389C0 Offset: 0x2438AC1 VA: 0x24389C0
	public CapabilitySbyte GetEnhance() { }

	// RVA: 0x2438A10 Offset: 0x2438B11 VA: 0x2438A10
	public int GetTimes() { }

	// RVA: 0x2438A20 Offset: 0x2438B21 VA: 0x2438A20
	public SkillArray GetEquipSkills() { }

	// RVA: 0x2438BF0 Offset: 0x2438CF1 VA: 0x2438BF0
	public long GetSort() { }

	// RVA: 0x2438430 Offset: 0x2438531 VA: 0x2438430
	public bool IsRefined() { }

	// RVA: 0x2438CD0 Offset: 0x2438DD1 VA: 0x2438CD0
	public int GetMaxRefineLevel() { }

	// RVA: 0x2438D20 Offset: 0x2438E21 VA: 0x2438D20
	public bool IsExistRefineData() { }

	// RVA: 0x2438550 Offset: 0x2438651 VA: 0x2438550
	public ItemRefineData GetCurrentRefineData() { }

	// RVA: 0x2438D50 Offset: 0x2438E51 VA: 0x2438D50
	public ItemRefineData GetNextRefineData() { }

	// RVA: 0x2438DF0 Offset: 0x2438EF1 VA: 0x2438DF0
	public List<ItemRefineData> GetRefineDataList() { }

	// RVA: 0x2438E00 Offset: 0x2438F01 VA: 0x2438E00
	public bool CanEvolve() { }

	// RVA: 0x2438E60 Offset: 0x2438F61 VA: 0x2438E60
	public bool IsExistEvolveData() { }

	// RVA: 0x2438E90 Offset: 0x2438F91 VA: 0x2438E90
	public List<ItemEvolveData> GetEvolveDataList() { }

	// RVA: 0x2438EA0 Offset: 0x2438FA1 VA: 0x2438EA0
	public bool CanEngrave() { }

	// RVA: 0x2438420 Offset: 0x2438521 VA: 0x2438420
	public bool IsEngraved() { }

	// RVA: 0x2438ED0 Offset: 0x2438FD1 VA: 0x2438ED0
	public void SetEngrave(GodData godData) { }

	// RVA: 0x2438F20 Offset: 0x2439021 VA: 0x2438F20
	public GodData GetEngrave() { }

	// RVA: 0x2438F30 Offset: 0x2439031 VA: 0x2438F30
	public void GetMenuText(out string iconText, out string nameText, out string enduranceText, bool withMaxEndurance = False) { }

	// RVA: 0x2439320 Offset: 0x2439421 VA: 0x2439320
	public GodUnit GetEngageWeaponGod() { }

	// RVA: 0x2439330 Offset: 0x2439431 VA: 0x2439330
	public void SetEngageWeaponGod(Unit unit) { }

	// RVA: 0x2439380 Offset: 0x2439481 VA: 0x2439380
	public void SetEngageWeaponGod(GodUnit godUnit) { }

	// RVA: 0x243B040 Offset: 0x243B141 VA: 0x243B040
	public void ClearEngageWeaponGod() { }

	// RVA: 0x24393B0 Offset: 0x24394B1 VA: 0x24393B0
	public void UpdateEngageWeaponParam() { }

	// RVA: 0x243B070 Offset: 0x243B171 VA: 0x243B070
	public void Serialize(Stream stream) { }

	// RVA: 0x243B170 Offset: 0x243B271 VA: 0x243B170
	public void Deserialize(Stream stream) { }

	// RVA: 0x242CAB0 Offset: 0x242CBB1 VA: 0x242CAB0
	public string get_Iid() { }

	// RVA: 0x243B7E0 Offset: 0x243B8E1 VA: 0x243B7E0
	public int get_Index() { }

	// RVA: 0x243B7F0 Offset: 0x243B8F1 VA: 0x243B7F0
	private bool IsFlags(UnitItem.Flags flags) { }

	// RVA: 0x243B800 Offset: 0x243B901 VA: 0x243B800
	private void SetFlags(UnitItem.Flags flags) { }

	// RVA: 0x2437660 Offset: 0x2437761 VA: 0x2437660
	private void ClearFlags(UnitItem.Flags flags) { }

	// RVA: 0x243B7C0 Offset: 0x243B8C1 VA: 0x243B7C0
	private void SetFlags(UnitItem.Flags flags, bool enable) { }

	// RVA: 0x243B810 Offset: 0x243B911 VA: 0x243B810
	public bool get_IsEquipped() { }

	// RVA: 0x243B820 Offset: 0x243B921 VA: 0x243B820
	public void set_IsEquipped(bool value) { }

	// RVA: 0x243B840 Offset: 0x243B941 VA: 0x243B840
	public bool get_IsDrop() { }

	// RVA: 0x243B850 Offset: 0x243B951 VA: 0x243B850
	public void set_IsDrop(bool value) { }

	// RVA: 0x243B870 Offset: 0x243B971 VA: 0x243B870
	public bool get_IsSkipLog() { }

	// RVA: 0x243B880 Offset: 0x243B981 VA: 0x243B880
	public void set_IsSkipLog(bool value) { }

	// RVA: 0x243B8A0 Offset: 0x243B9A1 VA: 0x243B8A0
	public bool get_IsEnchant() { }

	// RVA: 0x243B980 Offset: 0x243BA81 VA: 0x243B980
	public static void ResetEnchantItem() { }

	// RVA: 0x243B9F0 Offset: 0x243BAF1 VA: 0x243B9F0
	public static void SetEnchantItem(ItemData item) { }

	// RVA: 0x243BB30 Offset: 0x243BC31 VA: 0x243BB30
	public static void SetEnchantHash(int hash) { }

	// RVA: 0x243BBA0 Offset: 0x243BCA1 VA: 0x243BBA0
	public static int GetEnchantHash() { }

	// RVA: 0x243BC10 Offset: 0x243BD11 VA: 0x243BC10
	public UnitItem.Flags get_FlagsValue() { }

	// RVA: 0x243BC20 Offset: 0x243BD21 VA: 0x243BC20
	public void set_FlagsValue(UnitItem.Flags value) { }

	// RVA: 0x243BC30 Offset: 0x243BD31 VA: 0x243BC30
	public int get_Endurance() { }

	// RVA: 0x243BC40 Offset: 0x243BD41 VA: 0x243BC40
	public void set_Endurance(int value) { }

	// RVA: 0x243BC50 Offset: 0x243BD51 VA: 0x243BC50
	public int get_RefineLevel() { }

	// RVA: 0x243BC60 Offset: 0x243BD61 VA: 0x243BC60
	public void set_RefineLevel(int value) { }

	// RVA: 0x243BC70 Offset: 0x243BD71 VA: 0x243BC70
	public static bool SortCompare(UnitItem a, UnitItem b, object arg) { }

	// RVA: 0x243BCB0 Offset: 0x243BDB1 VA: 0x243BCB0
	public SkillArray GetGiveSkills() { }

	// RVA: 0x241F260 Offset: 0x241F361 VA: 0x241F260
	public Color GetFontColor(bool isActive) { }

	// RVA: 0x241F220 Offset: 0x241F321 VA: 0x241F220
	public static bool op_Equality(UnitItem lhs, UnitItem rhs) { }

	// RVA: 0x241F180 Offset: 0x241F281 VA: 0x241F180
	public static bool op_Inequality(UnitItem lhs, UnitItem rhs) { }

	// RVA: 0x243BE60 Offset: 0x243BF61 VA: 0x243BE60 Slot: 0
	public override bool Equals(object rhsObj) { }

	// RVA: 0x243BF30 Offset: 0x243C031 VA: 0x243BF30
	public bool Equals(UnitItem rhs) { }

	// RVA: 0x243BFC0 Offset: 0x243C0C1 VA: 0x243BFC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x243BCD0 Offset: 0x243BDD1 VA: 0x243BCD0
	private bool EqualsImpl(UnitItem rhs) { }

	// RVA: 0x243BFF0 Offset: 0x243C0F1 VA: 0x243BFF0
	private static void .cctor() { }
}

