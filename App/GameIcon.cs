// Namespace: App
public class GameIcon // TypeDefIndex: 10376
{
	// Fields
	private static SpriteAtlasManager s_Skill; // 0x0
	private static SpriteAtlasManager s_Item; // 0x8
	private static SpriteAtlasManager s_Efficacy; // 0x10
	private static SpriteAtlasManager s_EfficacyOutline; // 0x18
	private static SpriteAtlasManager s_ItemKinds; // 0x20
	private static SpriteAtlasManager s_ItemOutlineKinds; // 0x28
	private static SpriteAtlasManager s_GodSymbol; // 0x30
	private static SpriteAtlasManager s_GodRing; // 0x38
	private static SpriteAtlasManager s_System; // 0x40
	private static SpriteAtlasManager s_UnitIconIndex; // 0x48
	private static SpriteAtlasManager s_UnitIconPallete; // 0x50

	// Methods

	// RVA: 0x26A5C20 Offset: 0x26A5D21 VA: 0x26A5C20
	public static void LoadAsync() { }

	// RVA: 0x26A6180 Offset: 0x26A6281 VA: 0x26A6180
	public static void Unload() { }

	// RVA: 0x26A63B0 Offset: 0x26A64B1 VA: 0x26A63B0
	public static Sprite TryGetItemKind(string iconName, bool isOutline = False) { }

	// RVA: 0x26A6430 Offset: 0x26A6531 VA: 0x26A6430
	public static Sprite TryGetItemKind(ItemData.Kinds itemKind, bool isOutline = False) { }

	// RVA: 0x26A6710 Offset: 0x26A6811 VA: 0x26A6710
	public static Sprite TryGetItemKind(ItemData.Kinds itemKind, bool isBullet, bool isOutline = False) { }

	// RVA: 0x26A6720 Offset: 0x26A6821 VA: 0x26A6720
	public static Sprite TryGetItemKind(ItemData.Kinds itemKind, JobData jobData, bool isOutline = False) { }

	// RVA: 0x26A6760 Offset: 0x26A6861 VA: 0x26A6760
	public static Sprite TryGetItemKind(ItemData itemData, bool isOutline = False) { }

	// RVA: 0x26A67A0 Offset: 0x26A68A1 VA: 0x26A67A0
	public static Sprite TryGetItem(string iconName) { }

	// RVA: 0x26A6820 Offset: 0x26A6921 VA: 0x26A6820
	public static Sprite TryGetItem(ItemData item) { }

	// RVA: 0x26A69B0 Offset: 0x26A6AB1 VA: 0x26A69B0
	public static Sprite TryGetSystemItem(ItemData item) { }

	// RVA: 0x26A6AE0 Offset: 0x26A6BE1 VA: 0x26A6AE0
	public static Sprite TryGetEfficacy(string iconLabel, bool isOutline) { }

	// RVA: 0x26A6B60 Offset: 0x26A6C61 VA: 0x26A6B60
	public static Sprite TryGetSkill(string skillIconName) { }

	// RVA: 0x26A6C70 Offset: 0x26A6D71 VA: 0x26A6C70
	public static Sprite TryGetSkillEmpty() { }

	// RVA: 0x26A6CE0 Offset: 0x26A6DE1 VA: 0x26A6CE0
	public static Sprite TryGetGodSymbol(GodData godData) { }

	// RVA: 0x26A6D40 Offset: 0x26A6E41 VA: 0x26A6D40
	public static Sprite TryGetGodRing(Unit unit) { }

	// RVA: 0x26A6ED0 Offset: 0x26A6FD1 VA: 0x26A6ED0
	public static Sprite TryGetGodRing(GodData godData) { }

	// RVA: 0x26A6F40 Offset: 0x26A7041 VA: 0x26A6F40
	public static Sprite TryGetGodRing(RingData ring) { }

	// RVA: 0x26A6F50 Offset: 0x26A7051 VA: 0x26A6F50
	public static Sprite TryGetGodRing(RingData.Ranks rank) { }

	// RVA: 0x26A7000 Offset: 0x26A7101 VA: 0x26A7000
	public static Sprite TryGetAccessoryKinds(AccessoryData.Kinds accessoryKinds) { }

	// RVA: 0x26A70A0 Offset: 0x26A71A1 VA: 0x26A70A0
	public static Sprite TryGetCommonRing(RingData.Ranks ringDataRank) { }

	// RVA: 0x26A6950 Offset: 0x26A6A51 VA: 0x26A6950
	public static Sprite TryGetSystem(string iconName) { }

	// RVA: 0x26A7160 Offset: 0x26A7261 VA: 0x26A7160
	public static Sprite TyrGetUnitIconIndex(string name) { }

	// RVA: 0x26A71E0 Offset: 0x26A72E1 VA: 0x26A71E0
	public static Sprite TyrGetUnitIconPallete(string name) { }

	// RVA: 0x26A7260 Offset: 0x26A7361 VA: 0x26A7260
	public static void ClearUnitIconCache() { }

	// RVA: 0x26A72D0 Offset: 0x26A73D1 VA: 0x26A72D0
	public void .ctor() { }
}

