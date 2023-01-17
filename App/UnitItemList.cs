// Namespace: App
[DefaultMemberAttribute] // RVA: 0x278F90 Offset: 0x279091 VA: 0x278F90
public class UnitItemList // TypeDefIndex: 13535
{
	// Fields
	public const int EngageItemMax = 3;
	public const int ItemMax = 8;
	private const int Version = 2;
	private UnitItem[] m_UnitItems; // 0x10

	// Properties
	public UnitItem Item { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x243C240 Offset: 0x243C341 VA: 0x243C240
	public void .ctor() { }

	// RVA: 0x243C520 Offset: 0x243C621 VA: 0x243C520
	public void Clear() { }

	// RVA: 0x243C640 Offset: 0x243C741 VA: 0x243C640
	public void CopyFrom(UnitItemList from) { }

	// RVA: 0x243C7E0 Offset: 0x243C8E1 VA: 0x243C7E0
	private int GetEmptyIndex() { }

	// RVA: 0x243C900 Offset: 0x243CA01 VA: 0x243C900
	public int Add(ItemData item) { }

	// RVA: 0x243CA50 Offset: 0x243CB51 VA: 0x243CA50
	public int Add(UnitItem unitItem) { }

	// RVA: 0x243CC50 Offset: 0x243CD51 VA: 0x243CC50
	public void Move(int from, int to) { }

	// RVA: 0x243CE40 Offset: 0x243CF41 VA: 0x243CE40
	public void CloseUp() { }

	// RVA: 0x243D5B0 Offset: 0x243D6B1 VA: 0x243D5B0
	public void Equip(int index) { }

	// RVA: 0x243D750 Offset: 0x243D851 VA: 0x243D750
	public bool TakeOff(int index) { }

	// RVA: 0x243D7A0 Offset: 0x243D8A1 VA: 0x243D7A0
	public bool PutOff(int index, bool closeup) { }

	// RVA: 0x243DA20 Offset: 0x243DB21 VA: 0x243DA20
	public void PutOffAll() { }

	// RVA: 0x243DAC0 Offset: 0x243DBC1 VA: 0x243DAC0
	public bool IsEquipped() { }

	// RVA: 0x243DAE0 Offset: 0x243DBE1 VA: 0x243DAE0
	public UnitItem GetEquipped() { }

	// RVA: 0x243DB40 Offset: 0x243DC41 VA: 0x243DB40
	public UnitItem GetEquipped(int index) { }

	// RVA: 0x243D630 Offset: 0x243D731 VA: 0x243D630
	public int GetIndexEquipped() { }

	// RVA: 0x243DBB0 Offset: 0x243DCB1 VA: 0x243DBB0
	public int GetIndexEnchantable(ItemData item) { }

	// RVA: 0x243DCF0 Offset: 0x243DDF1 VA: 0x243DCF0
	public bool HasEnchanted() { }

	// RVA: 0x243DE10 Offset: 0x243DF11 VA: 0x243DE10
	public UnitItem GetHold(Unit unit) { }

	// RVA: 0x243DE70 Offset: 0x243DF71 VA: 0x243DE70
	public int GetIndexHold(Unit unit) { }

	// RVA: 0x243E530 Offset: 0x243E631 VA: 0x243E530
	public bool HasRod(Unit unit, bool canUseCheck = False) { }

	// RVA: 0x243EBE0 Offset: 0x243ECE1 VA: 0x243EBE0
	public bool HasHealRod(Unit unit, bool canUseCheck = False) { }

	// RVA: 0x243F2A0 Offset: 0x243F3A1 VA: 0x243F2A0
	public bool HasHealRodForOneself(Unit unit, bool canUseCheck = False) { }

	// RVA: 0x243F2C0 Offset: 0x243F3C1 VA: 0x243F2C0
	public bool HasSupportRod(Unit unit, bool canUseCheck = False, bool isOneself = False) { }

	// RVA: 0x243F9B0 Offset: 0x243FAB1 VA: 0x243F9B0
	public bool HasInterferenceRod(Unit unit, bool canUsCheck = False) { }

	// RVA: 0x2440070 Offset: 0x2440171 VA: 0x2440070
	public bool HasCriticalWeapon(Unit unit, bool canUseCheck = False) { }

	// RVA: 0x2440850 Offset: 0x2440951 VA: 0x2440850
	public bool HasEfficacyWeapon(Unit unit, Unit target, bool canUseCheck = False) { }

	// RVA: 0x24410E0 Offset: 0x24411E1 VA: 0x24410E0
	public bool HasDropItem() { }

	// RVA: 0x24411B0 Offset: 0x24412B1 VA: 0x24411B0
	public bool HasItem(ItemData item) { }

	// RVA: 0x24411D0 Offset: 0x24412D1 VA: 0x24411D0
	private int FindItem(ItemData item) { }

	// RVA: 0x2441310 Offset: 0x2441411 VA: 0x2441310
	public void PutEngageItem(GodUnit godUnit, bool engaged) { }

	// RVA: 0x2441780 Offset: 0x2441881 VA: 0x2441780
	public int GetItemCount(ItemData item) { }

	// RVA: 0x2441830 Offset: 0x2441931 VA: 0x2441830
	public void Serialize(Stream stream) { }

	// RVA: 0x2441960 Offset: 0x2441A61 VA: 0x2441960
	public void Deserialize(Stream stream) { }

	// RVA: 0x2441AF0 Offset: 0x2441BF1 VA: 0x2441AF0
	public UnitItem get_Item(int index) { }

	// RVA: 0x2441B30 Offset: 0x2441C31 VA: 0x2441B30
	public int get_Count() { }
}

