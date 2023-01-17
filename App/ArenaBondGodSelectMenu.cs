// Namespace: App
public class ArenaBondGodSelectMenu : BasicMenu // TypeDefIndex: 10938
{
	// Fields
	private ArenaBondGodSelectRoot m_Root; // 0xC8
	private ArenaBondGodSelectMenu.DecideEventHandler m_DecideEventHandler; // 0xD0
	private ArenaBondGodSelectMenu.SelectEventHandler m_SelectEventHandler; // 0xD8
	private ArenaBondGodSelectMenu.ChangeUnitEventHandle m_ChangeUnitToPrevEventHandler; // 0xE0
	private ArenaBondGodSelectMenu.ChangeUnitEventHandle m_ChangeUnitToNextEventHandler; // 0xE8
	private ArenaBondGodSelectMenu.StartHelpEventHandler m_StartHelpEventHandler; // 0xF0

	// Methods

	// RVA: 0x2101AF0 Offset: 0x2101BF1 VA: 0x2101AF0
	public static ArenaBondGodSelectMenu CreateBind(ProcInst super, ArenaBondGodSelectMenuContent menuContent, ArenaBondGodSelectRoot root, Unit selectedUnit, GodUnit defaultGod, RingCleaningSequence.GodType defaultType, ArenaBondGodSelectMenu.DecideEventHandler decideEventHandler, ArenaBondGodSelectMenu.SelectEventHandler selectEventHandler, ArenaBondGodSelectMenu.ChangeUnitEventHandle changeUnitToPrevEventHandler, ArenaBondGodSelectMenu.ChangeUnitEventHandle changeUnitToNextEventHandler, ArenaBondGodSelectMenu.StartHelpEventHandler startHelpEventHandler) { }

	// RVA: 0x2102110 Offset: 0x2102211 VA: 0x2102110
	protected void .ctor(List<BasicMenuItem> menuItemList, ArenaBondGodSelectMenuContent menuContent, ArenaBondGodSelectRoot root, ArenaBondGodSelectMenu.DecideEventHandler decideEventHandler, ArenaBondGodSelectMenu.SelectEventHandler selectEventHandler, ArenaBondGodSelectMenu.ChangeUnitEventHandle changeUnitToPrevEventHandler, ArenaBondGodSelectMenu.ChangeUnitEventHandle changeUnitToNextEventHandler, ArenaBondGodSelectMenu.StartHelpEventHandler startHelpEventHandler) { }

	// RVA: 0x21021C0 Offset: 0x21022C1 VA: 0x21021C0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2102210 Offset: 0x2102311 VA: 0x2102210
	public void RebuildMenu(Unit unit, GodUnit god, RingCleaningSequence.GodType type) { }

	// RVA: 0x21022F0 Offset: 0x21023F1 VA: 0x21022F0
	public void SetActiveForReliance(bool isActive, Unit unit, GodUnit god, RingCleaningSequence.GodType type) { }

	// RVA: 0x2101CC0 Offset: 0x2101DC1 VA: 0x2101CC0
	public static List<BasicMenuItem> CreateMenuItem(Unit unit, GodUnit defaultGod, RingCleaningSequence.GodType defaultType, out int defaultIndex, ArenaBondGodSelectMenu.DecideEventHandler decideEventHandler, ArenaBondGodSelectMenu.SelectEventHandler selectEventHandler, ArenaBondGodSelectMenu.ChangeUnitEventHandle changeUnitToPrevEventHandler, ArenaBondGodSelectMenu.ChangeUnitEventHandle changeUnitToNextEventHandler, ArenaBondGodSelectMenu.StartHelpEventHandler startHelpEventHandler) { }
}

