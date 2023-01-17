// Namespace: App
public class MuscleDifficultMenu : BasicMenu // TypeDefIndex: 11274
{
	// Fields
	private bool[] m_EnableChecker; // 0xC8
	private MuscleDifficultMenu.DecideEventHandler m_DecideEventHandler; // 0xD0
	private int m_PastDeside; // 0xD8

	// Methods

	// RVA: 0x2280A40 Offset: 0x2280B41 VA: 0x2280A40
	public void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent, MuscleDifficultMenu.DecideEventHandler decideEventHandler, bool[] enableArray, int pastDeside) { }

	// RVA: 0x2280B10 Offset: 0x2280C11 VA: 0x2280B10
	public static void CreateBind(ProcInst super, int pastDeside, int initialSelect, MuscleDifficultMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2282410 Offset: 0x2282511 VA: 0x2282410 Slot: 30
	public override string GetName() { }

	// RVA: 0x2282460 Offset: 0x2282561 VA: 0x2282460 Slot: 26
	public override void OnClose() { }

	// RVA: 0x2282470 Offset: 0x2282571 VA: 0x2282470 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x22824A0 Offset: 0x22825A1 VA: 0x22824A0 Slot: 52
	protected override BasicMenu.Result XCall() { }

	// RVA: 0x22825B0 Offset: 0x22826B1 VA: 0x22825B0 Slot: 50
	protected override BasicMenu.Result ACall() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3FE0 Offset: 0x2C40E1 VA: 0x2C3FE0
	// RVA: 0x2281F30 Offset: 0x2282031 VA: 0x2281F30
	internal static void <CreateBind>g__GetRank|5_0(int level, int score, ref int rank, ref MuscleDifficultMenu.<>c__DisplayClass5_0 ) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C3FF0 Offset: 0x2C40F1 VA: 0x2C3FF0
	// RVA: 0x2282190 Offset: 0x2282291 VA: 0x2282190
	internal static void <CreateBind>g__SetRankVisible|5_1(string rankID, Transform target, int score) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4000 Offset: 0x2C4101 VA: 0x2C4000
	// RVA: 0x2281D70 Offset: 0x2281E71 VA: 0x2281D70
	internal static void <CreateBind>g__SetNoRecord|5_2(Transform target) { }
}

