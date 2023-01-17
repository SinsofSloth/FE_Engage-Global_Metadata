// Namespace: App
public class RefreshUnitSetDecideMenu : BasicMenu // TypeDefIndex: 11725
{
	// Fields
	private RefreshUnitSetDecideMenu.KeyUpEventHandler m_KeyUpEventHandler; // 0xC8
	private RefreshUnitSetDecideMenu.KeyDownEventHandler m_KeyDownEventHandler; // 0xD0
	private RefreshUnitSetDecideMenu.DecideEventHandler m_DecideEventHandler; // 0xD8
	private bool m_Closed; // 0xE0

	// Methods

	// RVA: 0x2532190 Offset: 0x2532291 VA: 0x2532190
	public static RefreshUnitSetDecideMenu Create(ProcInst super, RefreshUnitSetDecideMenuContent menuContent, bool enabled, bool usabled, RefreshUnitSetDecideMenu.KeyUpEventHandler keyUpEventHandler, RefreshUnitSetDecideMenu.KeyDownEventHandler keyDownEventHandler, RefreshUnitSetDecideMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2532380 Offset: 0x2532481 VA: 0x2532380
	public void .ctor(List<BasicMenuItem> menuItemList, RefreshUnitSetDecideMenuContent menuContent, bool usabled, RefreshUnitSetDecideMenu.KeyUpEventHandler keyUpEventHandler, RefreshUnitSetDecideMenu.KeyDownEventHandler keyDownEventHandler, RefreshUnitSetDecideMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2532290 Offset: 0x2532391 VA: 0x2532290
	public static List<BasicMenuItem> CreateMenuItemList(bool enabled, bool usabled, RefreshUnitSetDecideMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x25325D0 Offset: 0x25326D1 VA: 0x25325D0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2532620 Offset: 0x2532721 VA: 0x2532620 Slot: 38
	protected override void Tick() { }

	// RVA: 0x2532670 Offset: 0x2532771 VA: 0x2532670
	public void SetTextColor(Color color) { }

	// RVA: 0x2532880 Offset: 0x2532981 VA: 0x2532880
	public void UpdateEnabled(bool enabled, bool usabled) { }

	// RVA: 0x2532980 Offset: 0x2532A81 VA: 0x2532980
	public void FocusThisMenu() { }

	// RVA: 0x2532A00 Offset: 0x2532B01 VA: 0x2532A00
	public void UnfocusThisMenu() { }

	// RVA: 0x2532A70 Offset: 0x2532B71 VA: 0x2532A70
	public bool IsFocusedThisMenu() { }

	// RVA: 0x2532A90 Offset: 0x2532B91 VA: 0x2532A90 Slot: 40
	protected override void KeyUp(bool isTrigger) { }

	// RVA: 0x2532AA0 Offset: 0x2532BA1 VA: 0x2532AA0 Slot: 41
	protected override void KeyDown(bool isTrigger) { }

	// RVA: 0x2532AC0 Offset: 0x2532BC1 VA: 0x2532AC0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x2532C70 Offset: 0x2532D71 VA: 0x2532C70 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2532F10 Offset: 0x2533011 VA: 0x2532F10 Slot: 54
	protected override BasicMenu.Result LCall() { }

	// RVA: 0x2533130 Offset: 0x2533231 VA: 0x2533130 Slot: 10
	protected override void OnDispose() { }
}

