// Namespace: App
public class EncountDataManager : SingletonClass<EncountDataManager> // TypeDefIndex: 10253
{
	// Fields
	private static bool isLoadEncountJobData; // 0x0

	// Methods

	// RVA: 0x25F5220 Offset: 0x25F5321 VA: 0x25F5220 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x25F55C0 Offset: 0x25F56C1 VA: 0x25F55C0 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x25F5780 Offset: 0x25F5881 VA: 0x25F5780
	public ItemData[] GetWeapons(int rank, WeaponMask weaponMask) { }

	// RVA: 0x25F58C0 Offset: 0x25F59C1 VA: 0x25F58C0
	private ItemData GetNormalWeapon(int rank, ItemData.Kinds[] kinds) { }

	// RVA: 0x25F5ED0 Offset: 0x25F5FD1 VA: 0x25F5ED0
	private ItemData GetAppendWeaponList(int rank, ItemData.Kinds[] kinds) { }

	// RVA: 0x25F6400 Offset: 0x25F6501 VA: 0x25F6400
	private StructDataArrayList<EncountWeaponCategoryData> GetNormalWeaponArrayList(int rank, ItemData.Kinds[] kinds) { }

	// RVA: 0x25F6620 Offset: 0x25F6721 VA: 0x25F6620
	private StructDataArrayList<EncountEquipData> GetData(int rank) { }

	// RVA: 0x25F6910 Offset: 0x25F6A11 VA: 0x25F6910
	public static List<EncountUnitData> ReductDispos(List<EncountUnitData> encountUnitDataList) { }

	// RVA: 0x25F6C00 Offset: 0x25F6D01 VA: 0x25F6C00
	private static float GetReductRate() { }

	// RVA: 0x25F6C40 Offset: 0x25F6D41 VA: 0x25F6C40
	public static ItemData TryGetRareMoneyItem(Difficulty difficulty, int nationLevel) { }

	// RVA: 0x25F6F00 Offset: 0x25F7001 VA: 0x25F6F00
	public void .ctor() { }

	// RVA: 0x25F6F80 Offset: 0x25F7081 VA: 0x25F6F80
	private static void .cctor() { }
}

