// Namespace: App
public class PhotographEditDisposMenu : BasicMenu // TypeDefIndex: 11479
{
	// Fields
	private static int s_SelectIdx; // 0x0
	private PhotographDisposManager m_DisposManager; // 0xC8
	private PhotographPauseData m_UnitPauseData; // 0xD0
	private PhotographPauseData m_GodPauseData; // 0xD8
	private ItemData[] m_WeaponDataList; // 0xE0
	private PhotographEditDisposMenu.UpdateUIObjHandler m_UpdateUIObjHandler; // 0xE8
	private PhotographEditDisposMenu.ReturnHandler m_ReturnHandler; // 0xF0

	// Methods

	// RVA: 0x2A2F650 Offset: 0x2A2F751 VA: 0x2A2F650
	private ItemData GetWeaponData(PhotographPauseData pause) { }

	// RVA: 0x2A2F6B0 Offset: 0x2A2F7B1 VA: 0x2A2F6B0
	public static void CreateBind(ProcInst super, BasicMenuContent menuContent, PhotographDisposManager disposManager, PhotographEditDisposMenu.UpdateUIObjHandler updateUIObjHandler, PhotographEditDisposMenu.ReturnHandler returnHandler) { }

	// RVA: 0x2A2F8D0 Offset: 0x2A2F9D1 VA: 0x2A2F8D0
	public void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, PhotographDisposManager disposManager, PhotographEditDisposMenu.UpdateUIObjHandler updateUIObjHandler, PhotographEditDisposMenu.ReturnHandler returnHandler) { }

	// RVA: 0x2A2F9A0 Offset: 0x2A2FAA1 VA: 0x2A2F9A0
	private void UpdateUIObj() { }

	// RVA: 0x2A30740 Offset: 0x2A30841 VA: 0x2A30740 Slot: 24
	protected override void OnBuild(bool isFirstBuild) { }

	// RVA: 0x2A30750 Offset: 0x2A30851 VA: 0x2A30750 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x2A30780 Offset: 0x2A30881 VA: 0x2A30780 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2A307B0 Offset: 0x2A308B1 VA: 0x2A307B0 Slot: 40
	protected override void KeyUp(bool isTrigger) { }

	// RVA: 0x2A30D10 Offset: 0x2A30E11 VA: 0x2A30D10 Slot: 41
	protected override void KeyDown(bool isTrigger) { }

	// RVA: 0x2A31290 Offset: 0x2A31391 VA: 0x2A31290 Slot: 54
	protected override BasicMenu.Result LCall() { }

	// RVA: 0x2A31430 Offset: 0x2A31531 VA: 0x2A31430 Slot: 55
	protected override BasicMenu.Result RCall() { }

	// RVA: 0x2A315D0 Offset: 0x2A316D1 VA: 0x2A315D0 Slot: 52
	protected override BasicMenu.Result XCall() { }

	// RVA: 0x2A31600 Offset: 0x2A31701 VA: 0x2A31600 Slot: 56
	protected override BasicMenu.Result PlusCall() { }

	// RVA: 0x2A31690 Offset: 0x2A31791 VA: 0x2A31690 Slot: 50
	protected override BasicMenu.Result ACall() { }

	// RVA: 0x2A31840 Offset: 0x2A31941 VA: 0x2A31840 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x2A318D0 Offset: 0x2A319D1 VA: 0x2A318D0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2A31920 Offset: 0x2A31A21 VA: 0x2A31920
	private static void .cctor() { }
}

