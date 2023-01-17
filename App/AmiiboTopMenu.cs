// Namespace: App
public class AmiiboTopMenu : BasicMenu // TypeDefIndex: 10423
{
	// Fields
	public const string AmiiboHelpPrefabPath = "UI/Network/Amiibo/Prefabs/AmiiboHelp";
	[CompilerGeneratedAttribute] // RVA: 0x28DFF0 Offset: 0x28E0F1 VA: 0x28DFF0
	private AmiiboTopMenu.DecideEventHandler <m_DecideEventHandler>k__BackingField; // 0xC8

	// Properties
	public AmiiboTopMenu.DecideEventHandler m_DecideEventHandler { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BDEB0 Offset: 0x2BDFB1 VA: 0x2BDEB0
	// RVA: 0x20F0C40 Offset: 0x20F0D41 VA: 0x20F0C40
	public AmiiboTopMenu.DecideEventHandler get_m_DecideEventHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDEC0 Offset: 0x2BDFC1 VA: 0x2BDEC0
	// RVA: 0x20F0C50 Offset: 0x20F0D51 VA: 0x20F0C50
	public void set_m_DecideEventHandler(AmiiboTopMenu.DecideEventHandler value) { }

	// RVA: 0x20F0C60 Offset: 0x20F0D61 VA: 0x20F0C60 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x20F0D00 Offset: 0x20F0E01 VA: 0x20F0D00
	protected void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, AmiiboTopMenu.MenuResult initialSelected, AmiiboTopMenu.DecideEventHandler eventHandler) { }

	// RVA: 0x20F0DA0 Offset: 0x20F0EA1 VA: 0x20F0DA0 Slot: 30
	public override string GetName() { }

	// RVA: 0x20F0E20 Offset: 0x20F0F21 VA: 0x20F0E20 Slot: 26
	public override void OnClose() { }

	// RVA: 0x20F0E30 Offset: 0x20F0F31 VA: 0x20F0E30
	public static void CreateBind(ProcInst super, AmiiboTopMenu.MenuResult initialSelected, AmiiboTopMenu.DecideEventHandler eventHandler) { }
}

