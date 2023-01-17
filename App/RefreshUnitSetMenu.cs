// Namespace: App
public class RefreshUnitSetMenu : BasicMenu // TypeDefIndex: 11718
{
	// Fields
	private RefreshUnitSetMenu.SelectFacilityEventHandler m_SelectFacilityEventHandler; // 0xC8
	private RefreshUnitSetMenu.SetUnitEventHandler m_SetUnitEventHandler; // 0xD0
	private RefreshUnitSetMenu.DecideEventHandler m_DecideEventHandler; // 0xD8
	private RefreshUnitSetDecideMenu m_DecideMenu; // 0xE0
	private int m_FacilityIndex; // 0xE8
	private Dictionary<string, Unit[]> m_Unit; // 0xF0

	// Methods

	// RVA: 0x252E090 Offset: 0x252E191 VA: 0x252E090
	public static RefreshUnitSetMenu CreateBind(ProcInst super, RefreshUnitSetMenuContent menuContent, Dictionary<string, Unit[]> unitArrayDic, HubFacilityData initialFacilityData, RefreshUnitSetMenu.SelectFacilityEventHandler selectFacilityEventHandler, RefreshUnitSetMenu.SetUnitEventHandler setUnitEventHandler, RefreshUnitSetMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2533510 Offset: 0x2533611 VA: 0x2533510
	private static List<BasicMenuItem> CreateMenuItem(Unit[] unitArray, RefreshUnitSetMenu.DecideEventHandler decideEventHandler, out int initialSelectIndex) { }

	// RVA: 0x25336C0 Offset: 0x25337C1 VA: 0x25336C0
	private void .ctor(List<BasicMenuItem> menuItemList, RefreshUnitSetMenuContent menuContent, int initialSelectIndex, Dictionary<string, Unit[]> unitArrayDic, HubFacilityData initialFacilityData, RefreshUnitSetMenu.SelectFacilityEventHandler selectFacilityEventHandler, RefreshUnitSetMenu.SetUnitEventHandler setUnitEventHandler, RefreshUnitSetMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x25341C0 Offset: 0x25342C1 VA: 0x25341C0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2534210 Offset: 0x2534311 VA: 0x2534210
	public HubFacilityData GetFacilityData() { }

	// RVA: 0x2532E70 Offset: 0x2532F71 VA: 0x2532E70
	public void IncFacilityIndex() { }

	// RVA: 0x2532BE0 Offset: 0x2532CE1 VA: 0x2532BE0
	public void DecFacilityIndex() { }

	// RVA: 0x2532BD0 Offset: 0x2532CD1 VA: 0x2532BD0
	public bool IsSelectedFirstFacility() { }

	// RVA: 0x2532DE0 Offset: 0x2532EE1 VA: 0x2532DE0
	public bool IsSelectedLastFacility() { }

	// RVA: 0x2534370 Offset: 0x2534471 VA: 0x2534370
	private void ChangeFacilityIndex() { }

	// RVA: 0x2533EA0 Offset: 0x2533FA1 VA: 0x2533EA0
	private void UpdataFacility() { }

	// RVA: 0x2534540 Offset: 0x2534641 VA: 0x2534540
	public void SetUnit(int index, Unit unit) { }

	// RVA: 0x2532FA0 Offset: 0x25330A1 VA: 0x2532FA0
	public void EntrustUnit() { }

	// RVA: 0x2534A20 Offset: 0x2534B21 VA: 0x2534A20
	public void DecideUnit(int index, bool decided) { }

	// RVA: 0x2533FF0 Offset: 0x25340F1 VA: 0x2533FF0
	private void UpdateReliance() { }

	// RVA: 0x2533A60 Offset: 0x2533B61 VA: 0x2533A60
	private bool IsEnabledDecideMenu() { }

	// RVA: 0x2533C10 Offset: 0x2533D11 VA: 0x2533C10
	private bool IsUsabledDecideMenu() { }

	// RVA: 0x2534700 Offset: 0x2534801 VA: 0x2534700
	private void UpdateDecideMenu() { }

	// RVA: 0x2533DE0 Offset: 0x2533EE1 VA: 0x2533DE0
	private void FocusDecideMenu() { }

	// RVA: 0x2533D20 Offset: 0x2533E21 VA: 0x2533D20
	private void FocusThisMenu() { }

	// RVA: 0x2534B50 Offset: 0x2534C51 VA: 0x2534B50 Slot: 40
	protected override void KeyUp(bool isTrigger) { }

	// RVA: 0x2534B80 Offset: 0x2534C81 VA: 0x2534B80 Slot: 41
	protected override void KeyDown(bool isTrigger) { }

	// RVA: 0x2534BB0 Offset: 0x2534CB1 VA: 0x2534BB0 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x2534C50 Offset: 0x2534D51 VA: 0x2534C50 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2534D60 Offset: 0x2534E61 VA: 0x2534D60 Slot: 54
	protected override BasicMenu.Result LCall() { }

	// RVA: 0x2534D80 Offset: 0x2534E81 VA: 0x2534D80 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x2534DD0 Offset: 0x2534ED1 VA: 0x2534DD0 Slot: 10
	protected override void OnDispose() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6420 Offset: 0x2C6521 VA: 0x2C6420
	// RVA: 0x2534EA0 Offset: 0x2534FA1 VA: 0x2534EA0
	private void <.ctor>b__12_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6430 Offset: 0x2C6531 VA: 0x2C6430
	// RVA: 0x2534EB0 Offset: 0x2534FB1 VA: 0x2534EB0
	private void <.ctor>b__12_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6440 Offset: 0x2C6541 VA: 0x2C6440
	// RVA: 0x2534EC0 Offset: 0x2534FC1 VA: 0x2534EC0
	private void <.ctor>b__12_2(RefreshUnitSetDecideMenu.Result2 decideMenuResult) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6450 Offset: 0x2C6551 VA: 0x2C6450
	// RVA: 0x2534FD0 Offset: 0x25350D1 VA: 0x2534FD0
	private void <.ctor>b__12_3(RefreshConfirmDialog.Result2 confirmDialogResult) { }
}

