// Namespace: 
public sealed class RingListSkillMenu.CancelEventHandler : MulticastDelegate // TypeDefIndex: 12618
{
	// Methods

	// RVA: 0x1F521C0 Offset: 0x1F522C1 VA: 0x1F521C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F521E0 Offset: 0x1F522E1 VA: 0x1F521E0 Slot: 13
	public virtual BasicMenu.Result Invoke() { }

	// RVA: 0x1F523F0 Offset: 0x1F524F1 VA: 0x1F523F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F52420 Offset: 0x1F52521 VA: 0x1F52420 Slot: 15
	public virtual BasicMenu.Result EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class RingListSkillMenu.Menu : BasicMenu // TypeDefIndex: 12619
{
	// Fields
	private RingListSkillMenu.CancelEventHandler m_CancelEventHandler; // 0xC8
	private bool m_IsBindParent; // 0xD0

	// Methods

	// RVA: 0x1F52640 Offset: 0x1F52741 VA: 0x1F52640
	public void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, RingListSkillMenu.CancelEventHandler cancel, bool isBindParent) { }

	// RVA: 0x1F52690 Offset: 0x1F52791 VA: 0x1F52690
	public static RingListSkillMenu.Menu CreateMenu(ProcInst super, List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, BasicMenuSelect ms, RingListSkillMenu.CancelEventHandler cancel, bool isBindParent) { }

	// RVA: 0x1F527B0 Offset: 0x1F528B1 VA: 0x1F527B0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x1F527D0 Offset: 0x1F528D1 VA: 0x1F527D0 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x1F52930 Offset: 0x1F52A31 VA: 0x1F52930
	public int GetDisplayIndex() { }
}

// Namespace: 
public class RingListSkillMenu.MenuContent : BasicMenuContent // TypeDefIndex: 12620
{
	// Methods

	// RVA: 0x1F52940 Offset: 0x1F52A41 VA: 0x1F52940 Slot: 21
	public override float CalcW() { }

	// RVA: 0x1F529A0 Offset: 0x1F52AA1 VA: 0x1F529A0 Slot: 22
	public override float CalcH() { }

	// RVA: 0x1F52A10 Offset: 0x1F52B11 VA: 0x1F52A10 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x1F52AD0 Offset: 0x1F52BD1 VA: 0x1F52AD0
	public void .ctor() { }
}

// Namespace: 
public abstract class RingListSkillMenu.MenuItem : BasicMenuItem // TypeDefIndex: 12621
{
	// Fields
	protected RingListSkillMenu m_Root; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x29B440 Offset: 0x29B541 VA: 0x29B440
	private int <Level>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x29B450 Offset: 0x29B551 VA: 0x29B450
	private bool <IsGotSKill>k__BackingField; // 0x74

	// Properties
	public int Level { get; set; }
	public bool IsGotSKill { get; set; }
	public bool IsEnableGotIcon { get; }
	public bool IsEnableUnitGotIcon { get; }
	public int FromLv { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C9CF0 Offset: 0x2C9DF1 VA: 0x2C9CF0
	// RVA: 0x1F52B40 Offset: 0x1F52C41 VA: 0x1F52B40
	public int get_Level() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9D00 Offset: 0x2C9E01 VA: 0x2C9D00
	// RVA: 0x1F52B50 Offset: 0x1F52C51 VA: 0x1F52B50
	public void set_Level(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9D10 Offset: 0x2C9E11 VA: 0x2C9D10
	// RVA: 0x1F52B60 Offset: 0x1F52C61 VA: 0x1F52B60
	public bool get_IsGotSKill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9D20 Offset: 0x2C9E21 VA: 0x2C9D20
	// RVA: 0x1F52B70 Offset: 0x1F52C71 VA: 0x1F52B70
	public void set_IsGotSKill(bool value) { }

	// RVA: 0x1F52B80 Offset: 0x1F52C81 VA: 0x1F52B80
	public bool get_IsEnableGotIcon() { }

	// RVA: 0x1F52BA0 Offset: 0x1F52CA1 VA: 0x1F52BA0
	public bool get_IsEnableUnitGotIcon() { }

	// RVA: 0x1F52BC0 Offset: 0x1F52CC1 VA: 0x1F52BC0
	public int get_FromLv() { }

	// RVA: 0x1F52BE0 Offset: 0x1F52CE1 VA: 0x1F52BE0
	public void .ctor(RingListSkillMenu root, int level, bool isGotSkill) { }

	// RVA: 0x1F52C40 Offset: 0x1F52D41 VA: 0x1F52C40 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F52C90 Offset: 0x1F52D91 VA: 0x1F52C90 Slot: 5
	public override float GetWidth() { }

	// RVA: 0x1F52CA0 Offset: 0x1F52DA1 VA: 0x1F52CA0 Slot: 6
	public override float GetHeight() { }

	// RVA: 0x1F52CB0 Offset: 0x1F52DB1 VA: 0x1F52CB0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1F52CC0 Offset: 0x1F52DC1 VA: 0x1F52CC0 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
public class RingListSkillMenu.MenuItem_EngageItem : RingListSkillMenu.MenuItem // TypeDefIndex: 12622
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29B460 Offset: 0x29B561 VA: 0x29B460
	private ItemData <Item>k__BackingField; // 0x78

	// Properties
	public ItemData Item { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C9D30 Offset: 0x2C9E31 VA: 0x2C9D30
	// RVA: 0x1F53F40 Offset: 0x1F54041 VA: 0x1F53F40
	public ItemData get_Item() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9D40 Offset: 0x2C9E41 VA: 0x2C9D40
	// RVA: 0x1F53F50 Offset: 0x1F54051 VA: 0x1F53F50
	public void set_Item(ItemData value) { }

	// RVA: 0x1F53F60 Offset: 0x1F54061 VA: 0x1F53F60
	public void .ctor(RingListSkillMenu root, int level, ItemData itemData, bool isGotSkill) { }

	// RVA: 0x1F53FD0 Offset: 0x1F540D1 VA: 0x1F53FD0 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
public class RingListSkillMenu.MenuItem_Skill : RingListSkillMenu.MenuItem // TypeDefIndex: 12623
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29B470 Offset: 0x29B571 VA: 0x29B470
	private SkillData <Skill>k__BackingField; // 0x78

	// Properties
	public SkillData Skill { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C9D50 Offset: 0x2C9E51 VA: 0x2C9D50
	// RVA: 0x1F54710 Offset: 0x1F54811 VA: 0x1F54710
	public SkillData get_Skill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9D60 Offset: 0x2C9E61 VA: 0x2C9D60
	// RVA: 0x1F54720 Offset: 0x1F54821 VA: 0x1F54720
	public void set_Skill(SkillData value) { }

	// RVA: 0x1F54730 Offset: 0x1F54831 VA: 0x1F54730
	public void .ctor(RingListSkillMenu root, int level, SkillData skillData, bool isGotSkill) { }

	// RVA: 0x1F547A0 Offset: 0x1F548A1 VA: 0x1F547A0 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
public enum RingListSkillMenu.MenuItem_ExtraSkill.SkillType // TypeDefIndex: 12624
{
	// Fields
	public int value__; // 0x0
	public const RingListSkillMenu.MenuItem_ExtraSkill.SkillType UnlockSkillInheritance = 0;
	public const RingListSkillMenu.MenuItem_ExtraSkill.SkillType AddEngageTurnLimit = 1;
	public const RingListSkillMenu.MenuItem_ExtraSkill.SkillType SubEngageCountLimit = 2;
	public const RingListSkillMenu.MenuItem_ExtraSkill.SkillType Max = 3;
}

// Namespace: 
public class RingListSkillMenu.MenuItem_ExtraSkill : RingListSkillMenu.MenuItem // TypeDefIndex: 12625
{
	// Fields
	private static readonly string[] SpriteNameTable; // 0x0
	private static readonly string[] NameMidTable; // 0x8
	private static readonly string[] HelpMidTable; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29B480 Offset: 0x29B581 VA: 0x29B480
	private RingListSkillMenu.MenuItem_ExtraSkill.SkillType <Type>k__BackingField; // 0x78

	// Properties
	public RingListSkillMenu.MenuItem_ExtraSkill.SkillType Type { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C9D70 Offset: 0x2C9E71 VA: 0x2C9D70
	// RVA: 0x1F540F0 Offset: 0x1F541F1 VA: 0x1F540F0
	public RingListSkillMenu.MenuItem_ExtraSkill.SkillType get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9D80 Offset: 0x2C9E81 VA: 0x2C9D80
	// RVA: 0x1F54100 Offset: 0x1F54201 VA: 0x1F54100
	public void set_Type(RingListSkillMenu.MenuItem_ExtraSkill.SkillType value) { }

	// RVA: 0x1F536C0 Offset: 0x1F537C1 VA: 0x1F536C0
	public Sprite GetSprite() { }

	// RVA: 0x1F53760 Offset: 0x1F53861 VA: 0x1F53760
	public string GetSkillName() { }

	// RVA: 0x1F54110 Offset: 0x1F54211 VA: 0x1F54110
	public string GetSkillHelp() { }

	// RVA: 0x1F541E0 Offset: 0x1F542E1 VA: 0x1F541E0
	public void .ctor(RingListSkillMenu root, int level, RingListSkillMenu.MenuItem_ExtraSkill.SkillType skillType, bool isGotSkill) { }

	// RVA: 0x1F54250 Offset: 0x1F54351 VA: 0x1F54250 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1F54330 Offset: 0x1F54431 VA: 0x1F54330
	private static void .cctor() { }
}

// Namespace: 
public class RingListSkillMenu.MenuItem_WeaponTalent : RingListSkillMenu.MenuItem // TypeDefIndex: 12626
{
	// Fields
	public static readonly ItemData.Kinds[] ItemKindTable; // 0x0
	private static readonly string[] NameMidTable; // 0x8
	private static readonly string[] HelpMidTable; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29B490 Offset: 0x29B591 VA: 0x29B490
	private int <ItemKindTableIndex>k__BackingField; // 0x78

	// Properties
	public int ItemKindTableIndex { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C9D90 Offset: 0x2C9E91 VA: 0x2C9D90
	// RVA: 0x1F548E0 Offset: 0x1F549E1 VA: 0x1F548E0
	public int get_ItemKindTableIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9DA0 Offset: 0x2C9EA1 VA: 0x2C9DA0
	// RVA: 0x1F548F0 Offset: 0x1F549F1 VA: 0x1F548F0
	public void set_ItemKindTableIndex(int value) { }

	// RVA: 0x1F53830 Offset: 0x1F53931 VA: 0x1F53830
	public Sprite GetSprite() { }

	// RVA: 0x1F538D0 Offset: 0x1F539D1 VA: 0x1F538D0
	public string GetSkillName() { }

	// RVA: 0x1F54900 Offset: 0x1F54A01 VA: 0x1F54900
	public string GetSkillHelp() { }

	// RVA: 0x1F549D0 Offset: 0x1F54AD1 VA: 0x1F549D0
	public void .ctor(RingListSkillMenu root, int level, ItemData.Kinds itemKind, bool isGotSkill) { }

	// RVA: 0x1F54AE0 Offset: 0x1F54BE1 VA: 0x1F54AE0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1F54BB0 Offset: 0x1F54CB1 VA: 0x1F54BB0
	private static void .cctor() { }
}

// Namespace: 
public class RingListSkillMenu.MenuItemContent : BasicMenuItemContent // TypeDefIndex: 12627
{
	// Fields
	private TextMeshProUGUI m_Level; // 0x48
	private TextMeshProUGUI m_LevelText; // 0x50
	private Image m_IconImage; // 0x58
	private Image m_IconFrameImage; // 0x60
	private TextMeshProUGUI m_NameText; // 0x68
	private Image m_GotCheckImage; // 0x70
	private bool m_IsDisable; // 0x78
	private bool m_IsInitialized; // 0x79

	// Methods

	// RVA: 0x1F52CD0 Offset: 0x1F52DD1 VA: 0x1F52CD0 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x1F53150 Offset: 0x1F53251 VA: 0x1F53150
	public void SetupByMenuItem(RingListSkillMenu.MenuItem menuItem) { }

	// RVA: 0x1F539A0 Offset: 0x1F53AA1 VA: 0x1F539A0
	public void SetDisable(bool disable) { }

	// RVA: 0x1F539B0 Offset: 0x1F53AB1 VA: 0x1F539B0 Slot: 11
	public override void BuildTextColor() { }

	// RVA: 0x1F53AF0 Offset: 0x1F53BF1 VA: 0x1F53AF0 Slot: 7
	protected override void UpdateTextColor() { }

	// RVA: 0x1F53F30 Offset: 0x1F54031 VA: 0x1F53F30
	public void .ctor() { }
}

// Namespace: 
public class RingListSkillMenu.ItemHelpWindow // TypeDefIndex: 12628
{
	// Fields
	private GameObject m_RootObject; // 0x10
	private Animator m_RootAnimator; // 0x18
	private ItemMenuDetailSetter m_ItemDetailSetter; // 0x20

	// Methods

	// RVA: 0x1F52450 Offset: 0x1F52551 VA: 0x1F52450
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x1F52540 Offset: 0x1F52641 VA: 0x1F52540
	public void SetItemData(ItemData itemData) { }

	// RVA: 0x1F525D0 Offset: 0x1F526D1 VA: 0x1F525D0
	public void Show() { }

	// RVA: 0x1F52530 Offset: 0x1F52631 VA: 0x1F52530
	public void Hide() { }
}

// Namespace: 
public class RingListSkillMenu.SkillHelpWindow // TypeDefIndex: 12629
{
	// Fields
	private GameObject m_RootObject; // 0x10
	private Animator m_RootAnimator; // 0x18
	private TextMeshProUGUI m_HelpText; // 0x20

	// Methods

	// RVA: 0x1F55320 Offset: 0x1F55421 VA: 0x1F55320
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x1F54820 Offset: 0x1F54921 VA: 0x1F54820
	public void SetSkillData(RingListSkillMenu.MenuItem_Skill menuItem) { }

	// RVA: 0x1F542E0 Offset: 0x1F543E1 VA: 0x1F542E0
	public void SetSkillData(RingListSkillMenu.MenuItem_ExtraSkill menuItem) { }

	// RVA: 0x1F54B70 Offset: 0x1F54C71 VA: 0x1F54B70
	public void SetItemKind(RingListSkillMenu.MenuItem_WeaponTalent menuItem) { }

	// RVA: 0x1F54320 Offset: 0x1F54421 VA: 0x1F54320
	public void Show() { }

	// RVA: 0x1F540E0 Offset: 0x1F541E1 VA: 0x1F540E0
	public void Hide() { }
}

