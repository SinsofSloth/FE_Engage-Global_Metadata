// Namespace: App.CookingMenu
public class FoodstuffMenuItemContent : BasicMenuItemContent // TypeDefIndex: 14255
{
	// Fields
	private FoodstuffMenu.FoodstuffMenuItem m_FoodstuffMenuItem; // 0x48
	private FoodstuffMenu.FoodstuffMenuItem.Type m_Type; // 0x50
	private GameObject m_Cursor; // 0x58
	private GameObject m_Check; // 0x60
	private GameObject m_Food; // 0x68
	private GameObject m_Name; // 0x70
	private GameObject m_Icon; // 0x78
	[SerializeField] // RVA: 0x29E3F0 Offset: 0x29E4F1 VA: 0x29E3F0
	private GameObject m_Stock; // 0x80
	private GameObject m_Count; // 0x88
	private TextMeshProUGUI m_NameText; // 0x90
	private TextMeshProUGUI m_CountText; // 0x98
	[SerializeField] // RVA: 0x29E400 Offset: 0x29E501 VA: 0x29E400
	private TextMeshProUGUI m_DecideText; // 0xA0
	private Image m_CursorImage; // 0xA8

	// Methods

	// RVA: 0x29FF220 Offset: 0x29FF321 VA: 0x29FF220 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x29FF350 Offset: 0x29FF451 VA: 0x29FF350
	private void Setup() { }

	// RVA: 0x29FFC60 Offset: 0x29FFD61 VA: 0x29FFC60
	private void SetName(FoodstuffData foodstuff) { }

	// RVA: 0x29FFDE0 Offset: 0x29FFEE1 VA: 0x29FFDE0
	private void SetIcon(FoodstuffData foodstuff) { }

	// RVA: 0x29FFA60 Offset: 0x29FFB61 VA: 0x29FFA60
	private void ChangeSelected(bool isSelected) { }

	// RVA: 0x29FFF20 Offset: 0x2A00021 VA: 0x29FFF20 Slot: 10
	public override void BuildText() { }

	// RVA: 0x29FFF30 Offset: 0x2A00031 VA: 0x29FFF30 Slot: 15
	protected override void Update() { }

	// RVA: 0x29FFF60 Offset: 0x2A00061 VA: 0x29FFF60 Slot: 7
	protected override void UpdateTextColor() { }

	// RVA: 0x2A00390 Offset: 0x2A00491 VA: 0x2A00390
	private void UpdateDecideTextColor() { }

	// RVA: 0x2A004B0 Offset: 0x2A005B1 VA: 0x2A004B0
	private void UpdateNotHaveTextColor() { }

	// RVA: 0x2A00600 Offset: 0x2A00701 VA: 0x2A00600
	public void .ctor() { }
}

