// Namespace: App
public class TradeMenuContent : GridMenuContent // TypeDefIndex: 12675
{
	// Fields
	private static readonly string PrefabPath; // 0x0
	private static readonly string LeftMenuItemBgName; // 0x8
	private static readonly string RightMenuItemBgName; // 0x10
	private static readonly string LeftNameBgName; // 0x18
	private static readonly string LeftNameTextName; // 0x20
	private static readonly string RightNameBgName; // 0x28
	private static readonly string RightNameTextName; // 0x30
	private static readonly string SelectBackCursorName; // 0x38
	protected Image m_leftMenuItemBgImage; // 0xF0
	protected Image m_rightMenuItemBgImage; // 0xF8
	protected Image m_leftNameBgImage; // 0x100
	protected Text m_leftNameText; // 0x108
	protected Image m_rightNameBgImage; // 0x110
	protected Text m_rightNameText; // 0x118
	protected GameObject m_objSelectBackCursor; // 0x120
	protected Image m_selectBackCursorImage; // 0x128

	// Methods

	// RVA: 0x25E98F0 Offset: 0x25E99F1 VA: 0x25E98F0 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x25E9900 Offset: 0x25E9A01 VA: 0x25E9900 Slot: 13
	protected override void InitObjReference() { }

	// RVA: 0x25E9B50 Offset: 0x25E9C51 VA: 0x25E9B50 Slot: 19
	public override void BuildMaterial() { }

	// RVA: 0x25E9C20 Offset: 0x25E9D21 VA: 0x25E9C20 Slot: 37
	protected override void UpdateCursorSize() { }

	// RVA: 0x25E9710 Offset: 0x25E9811 VA: 0x25E9710
	public void SetLeftName(string name) { }

	// RVA: 0x25E9730 Offset: 0x25E9831 VA: 0x25E9730
	public void SetRightName(string name) { }

	// RVA: 0x25E9820 Offset: 0x25E9921 VA: 0x25E9820
	public void SetSelectCursorPos(int menuItemIndex) { }

	// RVA: 0x25E9770 Offset: 0x25E9871 VA: 0x25E9770
	public void ShowSelectCursor() { }

	// RVA: 0x25E9810 Offset: 0x25E9911 VA: 0x25E9810
	public void HideSelectCursor() { }

	// RVA: 0x25E9D50 Offset: 0x25E9E51 VA: 0x25E9D50
	public static void LoadPrefabAsync() { }

	// RVA: 0x25E9DF0 Offset: 0x25E9EF1 VA: 0x25E9DF0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x25E9E90 Offset: 0x25E9F91 VA: 0x25E9E90
	public static void UnloadPrefab() { }

	// RVA: 0x25E9F30 Offset: 0x25EA031 VA: 0x25E9F30
	public static TradeMenuContent Create() { }

	// RVA: 0x25E9FF0 Offset: 0x25EA0F1 VA: 0x25E9FF0
	public void .ctor() { }

	// RVA: 0x25EA060 Offset: 0x25EA161 VA: 0x25EA060
	private static void .cctor() { }
}

