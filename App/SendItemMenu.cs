// Namespace: App
public sealed class SendItemMenu : BasicMenu // TypeDefIndex: 12667
{
	// Fields
	private Unit m_Unit; // 0xC8
	private UnitItem m_GainUnitItem; // 0xD0
	private SendItemRoot m_Root; // 0xD8
	private bool m_Uncancellable; // 0xE0
	private SendItemMenu.DecideCallback m_DecideCallback; // 0xE8
	private SendItemMenu.CancelCallback m_CancelCallback; // 0xF0

	// Methods

	// RVA: 0x2329790 Offset: 0x2329891 VA: 0x2329790
	public static ProcInst CreateBind(ProcInst super, Unit unit, UnitItem gainUnitItem, bool uncancellable = False, SendItemMenu.DecideCallback decideCallback, SendItemMenu.CancelCallback cancelCallback) { }

	// RVA: 0x2329C00 Offset: 0x2329D01 VA: 0x2329C00
	private void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, SendItemRoot root, Unit unit, UnitItem gainUnitItem, bool uncancellable, SendItemMenu.DecideCallback decideCallback, SendItemMenu.CancelCallback cancelCallback) { }

	// RVA: 0x2329EA0 Offset: 0x2329FA1 VA: 0x2329EA0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2329EF0 Offset: 0x2329FF1 VA: 0x2329EF0 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x232A080 Offset: 0x232A181 VA: 0x232A080
	public Unit GetUnit() { }

	// RVA: 0x232A090 Offset: 0x232A191 VA: 0x232A090
	private UnitItem GetGainUnitItem() { }

	// RVA: 0x232A0A0 Offset: 0x232A1A1 VA: 0x232A0A0 Slot: 52
	protected override BasicMenu.Result XCall() { }

	// RVA: 0x232A250 Offset: 0x232A351 VA: 0x232A250 Slot: 26
	public override void OnClose() { }

	// RVA: 0x232A3E0 Offset: 0x232A4E1 VA: 0x232A3E0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x232A5A0 Offset: 0x232A6A1 VA: 0x232A5A0
	public void SendItem(bool selectUnitItem, int unitItemIndex) { }
}

