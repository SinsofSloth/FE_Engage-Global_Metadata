// Namespace: App
internal class MyRoomSequence : SingletonProcInst<MyRoomSequence> // TypeDefIndex: 11375
{
	// Fields
	private MyRoomTopMenu.MenuResult m_TopMenuResult; // 0x74
	private MyRoomRecallMenu.MenuResult m_RecallMenuResult; // 0x78
	private BasicMenu.Result m_MenuItemResult; // 0x7C
	private static MyRoomSequence.RelianceUnitMenuItem m_relianceActiveMenu; // 0x0
	private string messName; // 0x80
	private string demoName; // 0x88

	// Properties
	private HubPlayerController Player { get; }

	// Methods

	// RVA: 0x2839170 Offset: 0x2839271 VA: 0x2839170
	public static void ShowTitle() { }

	// RVA: 0x2839240 Offset: 0x2839341 VA: 0x2839240
	public static void HideTitle() { }

	// RVA: 0x2839310 Offset: 0x2839411 VA: 0x2839310
	private HubPlayerController get_Player() { }

	// RVA: 0x2839390 Offset: 0x2839491 VA: 0x2839390
	private void Init() { }

	// RVA: 0x2839450 Offset: 0x2839551 VA: 0x2839450
	private void LoadResources() { }

	// RVA: 0x2839590 Offset: 0x2839691 VA: 0x2839590
	private bool IsLoadingResources() { }

	// RVA: 0x2839600 Offset: 0x2839701 VA: 0x2839600
	private void StartSequence() { }

	// RVA: 0x2839740 Offset: 0x2839841 VA: 0x2839740
	private void CreateTopMenu() { }

	// RVA: 0x2839A10 Offset: 0x2839B11 VA: 0x2839A10
	private void CreateRecallMenu() { }

	// RVA: 0x2839BC0 Offset: 0x2839CC1 VA: 0x2839BC0
	private void InitReliance() { }

	// RVA: 0x2839D90 Offset: 0x2839E91 VA: 0x2839D90
	private void MainReliance() { }

	// RVA: 0x2839E10 Offset: 0x2839F11 VA: 0x2839E10
	private void ExitReliance() { }

	// RVA: 0x2839EC0 Offset: 0x2839FC1 VA: 0x2839EC0
	private void InitWakeup() { }

	// RVA: 0x2839F90 Offset: 0x283A091 VA: 0x2839F90
	private void MainWakeup() { }

	// RVA: 0x283A090 Offset: 0x283A191 VA: 0x283A090
	private void ExitWakeup() { }

	// RVA: 0x283A160 Offset: 0x283A261 VA: 0x283A160
	private void CreateSoundMenu() { }

	// RVA: 0x283A260 Offset: 0x283A361 VA: 0x283A260
	private void CreateRelianceMenu() { }

	// RVA: 0x283A2D0 Offset: 0x283A3D1 VA: 0x283A2D0
	private void CreateWakeupMenu() { }

	// RVA: 0x283A3C0 Offset: 0x283A4C1 VA: 0x283A3C0
	private void CreateMovieMenu() { }

	// RVA: 0x283A3D0 Offset: 0x283A4D1 VA: 0x283A3D0
	private void CreateSetDifficulty() { }

	// RVA: 0x283A450 Offset: 0x283A551 VA: 0x283A450
	private void Exit() { }

	// RVA: 0x283A7B0 Offset: 0x283A8B1 VA: 0x283A7B0
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x283BC60 Offset: 0x283BD61 VA: 0x283BC60
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x283BDB0 Offset: 0x283BEB1 VA: 0x283BDB0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C50F0 Offset: 0x2C51F1 VA: 0x2C50F0
	// RVA: 0x283BE30 Offset: 0x283BF31 VA: 0x283BE30
	private void <CreateTopMenu>b__16_0(MyRoomTopMenu.MenuResult r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5100 Offset: 0x2C5201 VA: 0x2C5100
	// RVA: 0x283BE40 Offset: 0x283BF41 VA: 0x283BE40
	private void <CreateRecallMenu>b__17_0(MyRoomRecallMenu.MenuResult r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5110 Offset: 0x2C5211 VA: 0x2C5110
	// RVA: 0x283BFB0 Offset: 0x283C0B1 VA: 0x283BFB0
	private bool <CreateDesc>b__32_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5120 Offset: 0x2C5221 VA: 0x2C5120
	// RVA: 0x283BFC0 Offset: 0x283C0C1 VA: 0x283BFC0
	private bool <CreateDesc>b__32_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5130 Offset: 0x2C5231 VA: 0x2C5130
	// RVA: 0x283BFD0 Offset: 0x283C0D1 VA: 0x283BFD0
	private bool <CreateDesc>b__32_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5140 Offset: 0x2C5241 VA: 0x2C5140
	// RVA: 0x283BFE0 Offset: 0x283C0E1 VA: 0x283BFE0
	private bool <CreateDesc>b__32_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5150 Offset: 0x2C5251 VA: 0x2C5150
	// RVA: 0x283BFF0 Offset: 0x283C0F1 VA: 0x283BFF0
	private bool <CreateDesc>b__32_4() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5160 Offset: 0x2C5261 VA: 0x2C5160
	// RVA: 0x283C000 Offset: 0x283C101 VA: 0x283C000
	private bool <CreateDesc>b__32_5() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5170 Offset: 0x2C5271 VA: 0x2C5170
	// RVA: 0x283C010 Offset: 0x283C111 VA: 0x283C010
	private bool <CreateDesc>b__32_6() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5180 Offset: 0x2C5281 VA: 0x2C5180
	// RVA: 0x283C020 Offset: 0x283C121 VA: 0x283C020
	private bool <CreateDesc>b__32_7() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5190 Offset: 0x2C5291 VA: 0x2C5190
	// RVA: 0x283C030 Offset: 0x283C131 VA: 0x283C030
	private bool <CreateDesc>b__32_8() { }
}

