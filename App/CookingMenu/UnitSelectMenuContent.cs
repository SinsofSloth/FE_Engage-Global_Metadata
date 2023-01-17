// Namespace: App.CookingMenu
public class UnitSelectMenuContent : BasicMenuContent // TypeDefIndex: 14260
{
	// Fields
	private EatUnitsSelectMenuRelianceContent m_RelianceContent; // 0xE8
	private List<Animator> m_winSubAnimatorList; // 0xF0
	[SerializeField] // RVA: 0x29E410 Offset: 0x29E511 VA: 0x29E410
	private TextMeshProUGUI m_FriendText; // 0xF8
	[SerializeField] // RVA: 0x29E420 Offset: 0x29E521 VA: 0x29E420
	private TextMeshProUGUI m_RelianceText; // 0x100

	// Methods

	// RVA: 0x208FA70 Offset: 0x208FB71 VA: 0x208FA70 Slot: 21
	public override float CalcW() { }

	// RVA: 0x208FA80 Offset: 0x208FB81 VA: 0x208FA80 Slot: 27
	public override void AfterBuild() { }

	// RVA: 0x208FD30 Offset: 0x208FE31 VA: 0x208FD30 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x208FDF0 Offset: 0x208FEF1 VA: 0x208FDF0 Slot: 30
	protected override void Awake() { }

	// RVA: 0x208EDC0 Offset: 0x208EEC1 VA: 0x208EDC0
	public void SetReliance(List<Unit> selectUnitList, Unit nowCursorUnit) { }

	// RVA: 0x208F6E0 Offset: 0x208F7E1 VA: 0x208F6E0
	public void OnClose() { }

	// RVA: 0x208FF70 Offset: 0x2090071 VA: 0x208FF70
	public void .ctor() { }
}

