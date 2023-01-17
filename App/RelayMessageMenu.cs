// Namespace: App
internal class RelayMessageMenu : BasicMenu // TypeDefIndex: 12884
{
	// Fields
	private const RelayStampData.Kinds StartKind = 0;
	private RelayStampData.Kinds m_Kind; // 0xC4
	private List<BasicMenuSelect> m_MenuSelectList; // 0xC8

	// Methods

	// RVA: 0x24B8E50 Offset: 0x24B8F51 VA: 0x24B8E50
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x24B9040 Offset: 0x24B9141 VA: 0x24B9040
	public static List<BasicMenuItem> CreateMenuItem(RelayStampData.Kinds kind) { }

	// RVA: 0x24B98D0 Offset: 0x24B99D1 VA: 0x24B98D0
	protected void .ctor(List<BasicMenuItem> menuItemList, RelayMessageMenuContent menuContent) { }

	// RVA: 0x24B9AC0 Offset: 0x24B9BC1 VA: 0x24B9AC0 Slot: 30
	public override string GetName() { }

	// RVA: 0x24B9B10 Offset: 0x24B9C11 VA: 0x24B9B10 Slot: 42
	protected override void KeyLeft(bool isTrigger) { }

	// RVA: 0x24BA0E0 Offset: 0x24BA1E1 VA: 0x24BA0E0 Slot: 43
	protected override void KeyRight(bool isTrigger) { }

	// RVA: 0x24BA010 Offset: 0x24BA111 VA: 0x24BA010
	private void RebuildMenu() { }
}

