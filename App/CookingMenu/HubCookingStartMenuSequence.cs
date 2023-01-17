// Namespace: App.CookingMenu
public class HubCookingStartMenuSequence : ProcInst // TypeDefIndex: 14216
{
	// Fields
	private HubCookingStartMenuSequence.DecideEventHandler m_DecideCallback; // 0x70
	private Action m_EndCallback; // 0x78
	private List<Unit> m_SelectUnitList; // 0x80
	private FoodData m_SelectFood; // 0x88
	private List<FoodstuffData> m_SelectFoodstuffList; // 0x90
	private DishAllMenuContent m_AllContent; // 0x98

	// Methods

	// RVA: 0x30538D0 Offset: 0x30539D1 VA: 0x30538D0
	public static void LoadResources() { }

	// RVA: 0x3053910 Offset: 0x3053A11 VA: 0x3053910
	public static bool IsLoadingResources() { }

	// RVA: 0x3057810 Offset: 0x3057911 VA: 0x3057810
	public static void UnloadResources() { }

	// RVA: 0x30596F0 Offset: 0x30597F1 VA: 0x30596F0
	private void .ctor(HubCookingStartMenuSequence.DecideEventHandler decideEventHandler, Action endEventHandler) { }

	// RVA: 0x3059810 Offset: 0x3059911 VA: 0x3059810
	private void CreateHistory() { }

	// RVA: 0x3059840 Offset: 0x3059941 VA: 0x3059840
	private void OpenSelectUnitMenu() { }

	// RVA: 0x3059910 Offset: 0x3059A11 VA: 0x3059910
	private void PostSelectUnit() { }

	// RVA: 0x3059A00 Offset: 0x3059B01 VA: 0x3059A00
	private void OpenSelectFoodMenu() { }

	// RVA: 0x3059C40 Offset: 0x3059D41 VA: 0x3059C40
	private void PostOpenFoodMenu() { }

	// RVA: 0x3059CC0 Offset: 0x3059DC1 VA: 0x3059CC0
	private void OpenSelectFoodstuffMenu() { }

	// RVA: 0x3059DC0 Offset: 0x3059EC1 VA: 0x3059DC0
	private void OpenConfirmDialog() { }

	// RVA: 0x3059E60 Offset: 0x3059F61 VA: 0x3059E60
	private void ReturnSelectFoodstuff() { }

	// RVA: 0x3059ED0 Offset: 0x3059FD1 VA: 0x3059ED0
	private void Decide() { }

	// RVA: 0x3059FA0 Offset: 0x305A0A1 VA: 0x3059FA0
	private void CloseAllContent() { }

	[IteratorStateMachineAttribute] // RVA: 0x2CE2B0 Offset: 0x2CE3B1 VA: 0x2CE2B0
	// RVA: 0x3059FB0 Offset: 0x305A0B1 VA: 0x3059FB0
	private IEnumerator DeleteHistory() { }

	// RVA: 0x305A030 Offset: 0x305A131 VA: 0x305A030
	private void End() { }

	// RVA: 0x3053D40 Offset: 0x3053E41 VA: 0x3053D40
	public static void CreateBind(ProcInst super, HubCookingStartMenuSequence.DecideEventHandler decideEventHandler, Action endEventHandler) { }

	// RVA: 0x305A040 Offset: 0x305A141 VA: 0x305A040
	public static CookData GetCook() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE320 Offset: 0x2CE421 VA: 0x2CE320
	// RVA: 0x305A150 Offset: 0x305A251 VA: 0x305A150
	private void <OpenSelectUnitMenu>b__13_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE330 Offset: 0x2CE431 VA: 0x2CE330
	// RVA: 0x305A160 Offset: 0x305A261 VA: 0x305A160
	private void <OpenSelectFoodMenu>b__15_0(FoodData food) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE340 Offset: 0x2CE441 VA: 0x2CE340
	// RVA: 0x305A2C0 Offset: 0x305A3C1 VA: 0x305A2C0
	private void <OpenSelectFoodMenu>b__15_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE350 Offset: 0x2CE451 VA: 0x2CE350
	// RVA: 0x305A460 Offset: 0x305A561 VA: 0x305A460
	private void <OpenSelectFoodstuffMenu>b__17_0(List<FoodstuffData> foodstuffs) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE360 Offset: 0x2CE461 VA: 0x2CE360
	// RVA: 0x305A4F0 Offset: 0x305A5F1 VA: 0x305A4F0
	private void <OpenSelectFoodstuffMenu>b__17_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE370 Offset: 0x2CE471 VA: 0x2CE370
	// RVA: 0x305A590 Offset: 0x305A691 VA: 0x305A590
	private void <OpenConfirmDialog>b__18_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE380 Offset: 0x2CE481 VA: 0x2CE380
	// RVA: 0x305A600 Offset: 0x305A701 VA: 0x305A600
	private void <Decide>b__20_0() { }
}

