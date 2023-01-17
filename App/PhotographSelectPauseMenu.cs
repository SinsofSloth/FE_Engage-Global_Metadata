// Namespace: App
public class PhotographSelectPauseMenu : BasicMenu // TypeDefIndex: 11520
{
	// Fields
	private PhotographDisposManager m_DisposManager; // 0xC8
	private PhotographPauseData m_PauseDataOld; // 0xD0
	private List<string> m_CategoryList; // 0xD8
	private int m_CurCategoryIdx; // 0xE0
	private BasicMenuSelect[] m_MenuSelectList; // 0xE8
	private PhotographSelectPauseMenu.UpdateUIObjHandler m_UpdateUIObjHandler; // 0xF0

	// Methods

	// RVA: 0x2A38070 Offset: 0x2A38171 VA: 0x2A38070
	public void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, PhotographDisposManager disposManager, PhotographSelectPauseMenu.UpdateUIObjHandler updateUIObjHandler) { }

	// RVA: 0x2A383B0 Offset: 0x2A384B1 VA: 0x2A383B0
	public static void CreateBind(ProcInst super, BasicMenuContent menuContent, PhotographDisposManager disposManager, PhotographSelectPauseMenu.UpdateUIObjHandler updateUIObjHandler) { }

	// RVA: 0x2A38750 Offset: 0x2A38851 VA: 0x2A38750 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x2A38B20 Offset: 0x2A38C21 VA: 0x2A38B20 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x2A38EF0 Offset: 0x2A38FF1 VA: 0x2A38EF0 Slot: 30
	public override string GetName() { }
}

