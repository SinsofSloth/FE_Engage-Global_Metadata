// Namespace: App
public class ArenaBondLevelSelectMenu : BasicMenu // TypeDefIndex: 10953
{
	// Fields
	private ArenaBondLevelSelectMenu.DecideEventHandler m_DecideEventHandler; // 0xC8
	private ArenaBondLevelSelectMenu.SelectEventHandler m_SelectEventHandler; // 0xD0
	private ArenaBondLevelSelectMenu.ChangeGodEventHandle m_ChangeGodToPrevEventHandler; // 0xD8
	private ArenaBondLevelSelectMenu.ChangeGodEventHandle m_ChangeGodToNextEventHandler; // 0xE0

	// Methods

	// RVA: 0x21045C0 Offset: 0x21046C1 VA: 0x21045C0
	public static ArenaBondLevelSelectMenu CreateBind(ProcInst super, ArenaBondLevelSelectMenuContent menuContent, Unit selectedUnit, GodUnit selectedGod, RingCleaningSequence.GodType selectedType, ArenaBondLevelSelectMenu.DecideEventHandler decideEventHandler, ArenaBondLevelSelectMenu.SelectEventHandler selectEventHandler, ArenaBondLevelSelectMenu.ChangeGodEventHandle changeGodToPrevEventHandler, ArenaBondLevelSelectMenu.ChangeGodEventHandle changeGodToNextEventHandler) { }

	// RVA: 0x2104BC0 Offset: 0x2104CC1 VA: 0x2104BC0
	protected void .ctor(List<BasicMenuItem> menuItemList, ArenaBondLevelSelectMenuContent menuContent, ArenaBondLevelSelectMenu.DecideEventHandler decideEventHandler, ArenaBondLevelSelectMenu.SelectEventHandler selectEventHandler, ArenaBondLevelSelectMenu.ChangeGodEventHandle changeGodToPrevEventHandler, ArenaBondLevelSelectMenu.ChangeGodEventHandle changeGodToNextEventHandler) { }

	// RVA: 0x2104C40 Offset: 0x2104D41 VA: 0x2104C40 Slot: 30
	public override string GetName() { }

	// RVA: 0x2104C90 Offset: 0x2104D91 VA: 0x2104C90
	public void RebuildMenu(Unit unit, GodUnit god, RingCleaningSequence.GodType type) { }

	// RVA: 0x2104720 Offset: 0x2104821 VA: 0x2104720
	public static List<BasicMenuItem> CreateMenuItem(Unit selectedUnit, GodUnit selectedGod, RingCleaningSequence.GodType selectedType, ArenaBondLevelSelectMenu.DecideEventHandler decideEventHandler, ArenaBondLevelSelectMenu.SelectEventHandler selectEventHandler, ArenaBondLevelSelectMenu.ChangeGodEventHandle changeUnitToPrevEventHandler, ArenaBondLevelSelectMenu.ChangeGodEventHandle changeUnitToNextEventHandler) { }
}

