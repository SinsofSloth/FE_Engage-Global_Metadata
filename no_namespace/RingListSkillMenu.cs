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

