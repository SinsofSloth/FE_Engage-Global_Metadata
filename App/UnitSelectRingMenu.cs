// Namespace: App
public class UnitSelectRingMenu : BasicMenu // TypeDefIndex: 13337
{
	// Fields
	private UnitSelectRingMenu.CloseEventHandler m_CloseEventHandler; // 0xC8

	// Methods

	// RVA: 0x2090E50 Offset: 0x2090F51 VA: 0x2090E50
	public static UnitSelectRingMenu CreateBind(ProcInst super, UnitSelectRingMenu.CloseEventHandler closeEventHandler) { }

	// RVA: 0x2091050 Offset: 0x2091151 VA: 0x2091050
	private void .ctor(List<BasicMenuItem> menuItemList, UnitSelectRingMenu.CloseEventHandler closeEventHandler) { }

	// RVA: 0x20910F0 Offset: 0x20911F1 VA: 0x20910F0 Slot: 26
	public override void OnClose() { }

	// RVA: 0x2091110 Offset: 0x2091211 VA: 0x2091110
	public void EntrustRing() { }

	// RVA: 0x2091960 Offset: 0x2091A61 VA: 0x2091960
	public void TakeOffAllRings() { }

	// RVA: 0x20918A0 Offset: 0x20919A1 VA: 0x20918A0
	public void TakeOffRing(Unit unit) { }

	// RVA: 0x2091A80 Offset: 0x2091B81 VA: 0x2091A80
	public bool IsExistToBeAnabledToTakeOffRings() { }

	// RVA: 0x2091920 Offset: 0x2091A21 VA: 0x2091920
	private bool IsEquippedRing(Unit unit) { }
}

