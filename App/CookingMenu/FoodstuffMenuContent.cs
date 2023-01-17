// Namespace: App.CookingMenu
public class FoodstuffMenuContent : BasicMenuContent // TypeDefIndex: 14254
{
	// Fields
	[SerializeField] // RVA: 0x29E350 Offset: 0x29E451 VA: 0x29E350
	private TextMeshProUGUI m_NormalFoodstuffNum; // 0xE8
	[SerializeField] // RVA: 0x29E360 Offset: 0x29E461 VA: 0x29E360
	private TextMeshProUGUI m_RareFoodstuffNum; // 0xF0
	private int m_NormalMax; // 0xF8
	private int m_RareMax; // 0xFC
	private FoodstuffMenuContent.CursorController m_MainCursor; // 0x100
	private FoodstuffMenuContent.CursorController m_SubCursor; // 0x108
	[HeaderAttribute] // RVA: 0x29E370 Offset: 0x29E471 VA: 0x29E370
	[SerializeField] // RVA: 0x29E370 Offset: 0x29E471 VA: 0x29E370
	private TextMeshProUGUI m_FoodstuffTitleText; // 0x110
	[SerializeField] // RVA: 0x29E3C0 Offset: 0x29E4C1 VA: 0x29E3C0
	private TextMeshProUGUI m_FoodstuffCountText; // 0x118
	[SerializeField] // RVA: 0x29E3D0 Offset: 0x29E4D1 VA: 0x29E3D0
	private TextMeshProUGUI m_RareTitleText; // 0x120
	[SerializeField] // RVA: 0x29E3E0 Offset: 0x29E4E1 VA: 0x29E3E0
	private TextMeshProUGUI m_RareCountText; // 0x128

	// Methods

	// RVA: 0x29FDD20 Offset: 0x29FDE21 VA: 0x29FDD20 Slot: 30
	protected override void Awake() { }

	// RVA: 0x29FDD50 Offset: 0x29FDE51 VA: 0x29FDD50
	private void SetMessages() { }

	// RVA: 0x29FDEB0 Offset: 0x29FDFB1 VA: 0x29FDEB0 Slot: 13
	protected override void InitObjReference() { }

	// RVA: 0x29FE470 Offset: 0x29FE571 VA: 0x29FE470 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x29FE480 Offset: 0x29FE581 VA: 0x29FE480 Slot: 18
	public override void BuildMenuItemContent() { }

	// RVA: 0x29FE6B0 Offset: 0x29FE7B1 VA: 0x29FE6B0 Slot: 27
	public override void AfterBuild() { }

	// RVA: 0x29FE8C0 Offset: 0x29FE9C1 VA: 0x29FE8C0
	private void SetFoodstuffNum() { }

	// RVA: 0x29FEA30 Offset: 0x29FEB31 VA: 0x29FEA30 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x29FD9A0 Offset: 0x29FDAA1 VA: 0x29FD9A0
	public void SetCursorEnable(bool isFoodstuff, bool isDecide, BasicMenuItem.Attribute attribute) { }

	// RVA: 0x29FEAF0 Offset: 0x29FEBF1 VA: 0x29FEAF0
	private void ChangeCursorColor(bool isEnable) { }

	// RVA: 0x29FD850 Offset: 0x29FD951 VA: 0x29FD850
	public void UpdateNum() { }

	// RVA: 0x29FEC70 Offset: 0x29FED71 VA: 0x29FEC70
	private void SetNormalNum(int num) { }

	// RVA: 0x29FEE90 Offset: 0x29FEF91 VA: 0x29FEE90
	private void SetRareNum(int num) { }

	// RVA: 0x29FEB10 Offset: 0x29FEC11 VA: 0x29FEB10
	private int GetSelectedNormalCount() { }

	// RVA: 0x29FED70 Offset: 0x29FEE71 VA: 0x29FED70
	private int GetSelectedRareCount() { }

	// RVA: 0x29FEF90 Offset: 0x29FF091 VA: 0x29FEF90
	public void PutCursorInFront(int cursorIndex) { }

	// RVA: 0x29FF0A0 Offset: 0x29FF1A1 VA: 0x29FF0A0
	public void PutCursorInBack(int cursorIndex) { }

	// RVA: 0x29FF1B0 Offset: 0x29FF2B1 VA: 0x29FF1B0
	public void .ctor() { }
}

