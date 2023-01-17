// Namespace: App
public class InfoUtil // TypeDefIndex: 11825
{
	// Fields
	public const int SKILL_SLOT_MAX = 10;
	private static readonly StringBuilder s_EmptyStringBuilder; // 0x0

	// Methods

	// RVA: 0x2C46B30 Offset: 0x2C46C31 VA: 0x2C46B30
	public static void TrySetText(TextMeshProUGUI tmp, string str) { }

	// RVA: 0x2C46C50 Offset: 0x2C46D51 VA: 0x2C46C50
	public static void TrySetText(TextMeshProUGUI tmp, int value) { }

	// RVA: 0x2C46E40 Offset: 0x2C46F41 VA: 0x2C46E40
	public static void TrySetText(GameObject gameObject, string str) { }

	// RVA: 0x2C46EF0 Offset: 0x2C46FF1 VA: 0x2C46EF0
	public static void TrySetColor(TextMeshProUGUI tmp, Color color) { }

	// RVA: 0x2C46FC0 Offset: 0x2C470C1 VA: 0x2C46FC0
	public static void TrySetColor(GameObject gameObject, Color color) { }

	// RVA: 0x2C47070 Offset: 0x2C47171 VA: 0x2C47070
	public static void TrySetColor(Image image, Color color) { }

	// RVA: 0x2C47140 Offset: 0x2C47241 VA: 0x2C47140
	public static void TrySetSprite(GameObject gameObject, Sprite spr) { }

	// RVA: 0x2C471C0 Offset: 0x2C472C1 VA: 0x2C471C0
	public static void TrySetSprite(Image image, Sprite spr) { }

	// RVA: 0x2C47260 Offset: 0x2C47361 VA: 0x2C47260
	public static void TrySetActive(GameObject obj, bool isActive) { }

	// RVA: 0x2C47300 Offset: 0x2C47401 VA: 0x2C47300
	public static void TrySetActive(Component c, bool isActive) { }

	// RVA: 0x2C473A0 Offset: 0x2C474A1 VA: 0x2C473A0
	public static void TrySetParentActive(GameObject obj, bool isActive) { }

	// RVA: 0x2C474E0 Offset: 0x2C475E1 VA: 0x2C474E0
	public static void TrySetParentActive(Component c, bool isActive) { }

	// RVA: 0x2C47630 Offset: 0x2C47731 VA: 0x2C47630
	public static void TrySetActive(Component c, string name, bool isActive) { }

	// RVA: 0x2C47790 Offset: 0x2C47891 VA: 0x2C47790
	public static void TrySetParentActive(Component c, string name, bool isActive) { }

	// RVA: 0x2C478F0 Offset: 0x2C479F1 VA: 0x2C478F0
	public static void TrySetGrandParentActive(GameObject obj, bool isActive) { }

	// RVA: 0x2C479D0 Offset: 0x2C47AD1 VA: 0x2C479D0
	public static void TrySetGrandParentActive(Component c, bool isActive) { }

	// RVA: 0x2C47AB0 Offset: 0x2C47BB1 VA: 0x2C47AB0
	public static void TryResetTextAnime(TextMeshProUGUI tmp) { }

	// RVA: 0x2C47B70 Offset: 0x2C47C71 VA: 0x2C47B70
	public static void TrySetParamTitle(TextMeshProUGUI tmp, string title) { }

	// RVA: 0x2C47BE0 Offset: 0x2C47CE1 VA: 0x2C47BE0
	public static void TrySetParamTitle(TextMeshProUGUI tmp, string title, Color color) { }

	// RVA: 0x2C47D00 Offset: 0x2C47E01 VA: 0x2C47D00
	public static void TryUpdateChildGauge(GameObject gaugeObj, int value, int max, bool isHideWhen0 = False) { }

	// RVA: 0x2C47FB0 Offset: 0x2C480B1 VA: 0x2C47FB0
	public static void TryUpdateGauge(GameObject gaugeObj, int value, int max) { }

	// RVA: 0x2C48150 Offset: 0x2C48251 VA: 0x2C48150
	public static void TrySetMaterial(Image img, Material mat) { }

	// RVA: 0x2C481F0 Offset: 0x2C482F1 VA: 0x2C481F0
	private static int AddSkill(InfoUtil.StatusSkill[] list, SkillArray skillArray, int slotIndex, int slotNum, bool isPackSlot = True, bool forceDisp = False, Unit unit, bool isViewRestriction = False) { }

	// RVA: 0x2C48AC0 Offset: 0x2C48BC1 VA: 0x2C48AC0
	public static InfoUtil.StatusSkill[] GetSkillListForUnitInfo(Unit unit, bool isSkillEquip = False, bool isPack = False, int size = 10) { }

	// RVA: 0x2C49560 Offset: 0x2C49661 VA: 0x2C49560
	private static void AddSkillArray(Unit unit, SkillArray skillArray, ref InfoUtil.StatusSkill[] list, ref int index, int slotNum) { }

	// RVA: 0x2C49A60 Offset: 0x2C49B61 VA: 0x2C49A60
	private static bool IsEngageItemAppear(Unit unit, ItemData item) { }

	// RVA: 0x2C49B90 Offset: 0x2C49C91 VA: 0x2C49B90
	public static int GetShowItemIconNum(Unit unit) { }

	// RVA: 0x2C49DD0 Offset: 0x2C49ED1 VA: 0x2C49DD0
	public static UnitItem GetUnitItem(Unit unit, int frameIndex) { }

	// RVA: 0x2C4A010 Offset: 0x2C4A111 VA: 0x2C4A010
	public static ItemData GetEngageItemData(Unit unit, GodUnit tempGod, int frameIndex) { }

	// RVA: 0x2C4A200 Offset: 0x2C4A301 VA: 0x2C4A200
	public static void TrySetItemIconList(GameObject[] iconList, Unit unit) { }

	// RVA: 0x2C4BB60 Offset: 0x2C4BC61 VA: 0x2C4BB60
	public static void TrySetItemIcon(GameObject itemRoot, UnitItem ui, bool isEquip) { }

	// RVA: 0x2C4BD50 Offset: 0x2C4BE51 VA: 0x2C4BD50
	public static void TrySetColorToItemIcons(GameObject itemRoot, bool isValid, Color blendColor) { }

	// RVA: 0x2C4C100 Offset: 0x2C4C201 VA: 0x2C4C100
	public static void TrySetColorToItemIcon(Image itemIconImage, bool isValid) { }

	// RVA: 0x2C4C020 Offset: 0x2C4C121 VA: 0x2C4C020
	public static Color GetItemIconColor(bool isValid) { }

	// RVA: 0x2C4C220 Offset: 0x2C4C321 VA: 0x2C4C220
	public static bool IsBattleSequence() { }

	// RVA: 0x2C4BAA0 Offset: 0x2C4BBA1 VA: 0x2C4BAA0
	public static void TrySetEngageItemIcon(GameObject itemRoot, ItemData item) { }

	// RVA: 0x2C4B3C0 Offset: 0x2C4B4C1 VA: 0x2C4B3C0
	public static void TrySetItemIconBase(GameObject itemRoot, ItemData item, bool isValid, bool isEquip, bool isDrop, bool isEnchant) { }

	// RVA: 0x2C4C330 Offset: 0x2C4C431 VA: 0x2C4C330
	public static string AddDamageString(string baseStr, int damage, int count) { }

	// RVA: 0x2C4C460 Offset: 0x2C4C561 VA: 0x2C4C460
	public static int GetBattleAtkParam(BattleSide.Type sideType, BattleSceneList sceneList, out int totalDamage, out List<string> damageList) { }

	// RVA: 0x2C4CA50 Offset: 0x2C4CB51 VA: 0x2C4CA50
	public static int GetBattleAtkCount(BattleSide.Type sideType, BattleSceneList sceneList) { }

	// RVA: 0x2C4CB60 Offset: 0x2C4CC61 VA: 0x2C4CB60
	public static void SetUnitName(Unit unit, TextMeshProUGUI text) { }

	// RVA: 0x2C4CD40 Offset: 0x2C4CE41 VA: 0x2C4CD40
	public static void SetGodName(Unit unit, GodUnit god, GameObject root, TextMeshProUGUI text) { }

	// RVA: 0x2C4D020 Offset: 0x2C4D121 VA: 0x2C4D020
	public static void SetHpStock(Unit unit, GameObject root, Image[] stocks, Sprite[] sprites, Force.Type force) { }

	// RVA: 0x2C4D490 Offset: 0x2C4D591 VA: 0x2C4D490
	public static bool GetChainAtkParam(BattleSide.Type sideType, BattleInfo info, out string damageStr, out int hit, out int crit) { }

	// RVA: 0x2C4D5A0 Offset: 0x2C4D6A1 VA: 0x2C4D5A0
	public static void SetBattleAtkTitle(bool isHeal, TextMeshProUGUI text, HelpItemFixedText help) { }

	// RVA: 0x2C4D740 Offset: 0x2C4D841 VA: 0x2C4D740
	public static bool SetupEngageWeaponText(TextMeshProUGUI contentsText, UnitItem item) { }

	// RVA: 0x2C4DB10 Offset: 0x2C4DC11 VA: 0x2C4DB10
	public static void SetEnchantText(TextMeshProUGUI enchantText, UnitItem item) { }

	// RVA: 0x2C4DD30 Offset: 0x2C4DE31 VA: 0x2C4DD30
	public void .ctor() { }

	// RVA: 0x2C4DD40 Offset: 0x2C4DE41 VA: 0x2C4DD40
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6AA0 Offset: 0x2C6BA1 VA: 0x2C6AA0
	// RVA: 0x2C4D980 Offset: 0x2C4DA81 VA: 0x2C4D980
	internal static void <SetupEngageWeaponText>g__addRefine|49_0(GodWeaponRefineData.Kind kind, ref InfoUtil.<>c__DisplayClass49_0 , ref InfoUtil.<>c__DisplayClass49_1 ) { }
}

