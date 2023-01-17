// Namespace: App
public class GodRoomUnitSelectMenu : BasicMenu // TypeDefIndex: 10997
{
	// Fields
	public static readonly uint ForceMask; // 0x0
	private static int s_ScrollIndex; // 0x4

	// Methods

	// RVA: 0x27AF410 Offset: 0x27AF511 VA: 0x27AF410
	public static GodRoomUnitSelectMenu CreateBind(ProcInst super, GodRoomUnitSelectMenu.DecideEventHandler decideEventHandler, Unit selectUnit) { }

	// RVA: 0x27AF710 Offset: 0x27AF811 VA: 0x27AF710
	protected void .ctor(List<BasicMenuItem> menuItemList, GodRoomUnitSelectMenuContent menuContent, int defaultMenuItemIndex) { }

	// RVA: 0x27AF830 Offset: 0x27AF931 VA: 0x27AF830
	public List<GodUnit> GetGodListActive() { }

	// RVA: 0x27AF910 Offset: 0x27AFA11 VA: 0x27AF910 Slot: 30
	public override string GetName() { }

	// RVA: 0x27AF960 Offset: 0x27AFA61 VA: 0x27AF960 Slot: 52
	protected override BasicMenu.Result XCall() { }

	// RVA: 0x27AFAE0 Offset: 0x27AFBE1 VA: 0x27AFAE0 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x27AFC90 Offset: 0x27AFD91 VA: 0x27AFC90
	public void UpdateUnit(Unit unit) { }

	// RVA: 0x27AFFA0 Offset: 0x27B00A1 VA: 0x27AFFA0
	public void CloseStatus() { }

	// RVA: 0x27B0170 Offset: 0x27B0271 VA: 0x27B0170
	private static void .cctor() { }
}

