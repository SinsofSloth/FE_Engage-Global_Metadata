// Namespace: App
public class ClassChangeJobMenu : BasicMenu // TypeDefIndex: 13191
{
	// Fields
	private const int c_JobSortMax = 2000;
	private static bool s_IsSortJobSort; // 0x0
	private ClassChangeRoot m_Root; // 0xC8

	// Methods

	// RVA: 0x22C1DB0 Offset: 0x22C1EB1 VA: 0x22C1DB0
	public static ClassChangeJobMenu Create(ProcInst super, ClassChangeRoot classChangeRoot) { }

	// RVA: 0x22C21B0 Offset: 0x22C22B1 VA: 0x22C21B0
	protected void .ctor(List<BasicMenuItem> menuItemList, ClassChangeRoot root) { }

	// RVA: 0x22C2280 Offset: 0x22C2381 VA: 0x22C2280 Slot: 25
	protected override void AfterBuild() { }

	// RVA: 0x22C24F0 Offset: 0x22C25F1 VA: 0x22C24F0 Slot: 30
	public override string GetName() { }

	// RVA: 0x22C2540 Offset: 0x22C2641 VA: 0x22C2540 Slot: 58
	protected override BasicMenu.Result CustomCall() { }

	// RVA: 0x22C2FE0 Offset: 0x22C30E1 VA: 0x22C2FE0
	private void SortMenuItem() { }

	// RVA: 0x22C2410 Offset: 0x22C2511 VA: 0x22C2410
	public void SetUnitInfoAll() { }

	// RVA: 0x22C21F0 Offset: 0x22C22F1 VA: 0x22C21F0
	public void SetUnitInfoAll(ClassChange.ChangeJobData afterChangeJobData) { }

	// RVA: 0x22C36F0 Offset: 0x22C37F1 VA: 0x22C36F0
	public void SetUnitInfoAfter(Unit unitBefore, ClassChange.ChangeJobData data) { }

	// RVA: 0x22C2380 Offset: 0x22C2481 VA: 0x22C2380
	private void SetJobDetails(ClassChange.ChangeJobData data) { }

	// RVA: 0x22C3330 Offset: 0x22C3431 VA: 0x22C3330
	public static Unit GetUnit() { }

	// RVA: 0x22C47F0 Offset: 0x22C48F1 VA: 0x22C47F0
	private static void .cctor() { }
}

