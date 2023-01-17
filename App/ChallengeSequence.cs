// Namespace: App
public class ChallengeSequence : ProcInst // TypeDefIndex: 9787
{
	// Fields
	private ChallengeMapSelectRoot m_ChallengeMapSelectRoot; // 0x70
	private MenuBg m_Bg; // 0x78
	private BasicMenu.Result m_Result; // 0x80
	private ChallengeData m_ChallengeData; // 0x88
	private int m_Difficulty; // 0x90

	// Methods

	// RVA: 0x2E136F0 Offset: 0x2E137F1 VA: 0x2E136F0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2E137C0 Offset: 0x2E138C1 VA: 0x2E137C0
	protected void .ctor() { }

	// RVA: 0x2E13840 Offset: 0x2E13941 VA: 0x2E13840
	protected ProcDesc[] CreateDesc() { }

	// RVA: 0x2E146D0 Offset: 0x2E147D1 VA: 0x2E146D0
	private void LoadResources() { }

	// RVA: 0x2E146F0 Offset: 0x2E147F1 VA: 0x2E146F0
	private bool IsLoadingResources() { }

	// RVA: 0x2E14720 Offset: 0x2E14821 VA: 0x2E14720
	private void StartSequence() { }

	// RVA: 0x2E14800 Offset: 0x2E14901 VA: 0x2E14800
	private void CreateMapSelectRoot() { }

	// RVA: 0x2E14830 Offset: 0x2E14931 VA: 0x2E14830
	private void OpenTitle() { }

	// RVA: 0x2E14970 Offset: 0x2E14A71 VA: 0x2E14970
	private void CreateMapSelectMenu() { }

	// RVA: 0x2E14A10 Offset: 0x2E14B11 VA: 0x2E14A10
	private void CreateDifficultyMenu() { }

	// RVA: 0x2E14CC0 Offset: 0x2E14DC1 VA: 0x2E14CC0
	public void Close() { }

	// RVA: 0x2E14DF0 Offset: 0x2E14EF1 VA: 0x2E14DF0
	public bool IsClosed() { }

	// RVA: 0x2E14E90 Offset: 0x2E14F91 VA: 0x2E14E90
	private void DestroyMapSelectRoot() { }

	// RVA: 0x2E14F40 Offset: 0x2E15041 VA: 0x2E14F40
	private void SetupChallenge() { }

	// RVA: 0x2E15070 Offset: 0x2E15171 VA: 0x2E15070
	private void EndSequence() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0D90 Offset: 0x2B0E91 VA: 0x2B0D90
	// RVA: 0x2E150C0 Offset: 0x2E151C1 VA: 0x2E150C0
	private bool <CreateDesc>b__8_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0DA0 Offset: 0x2B0EA1 VA: 0x2B0DA0
	// RVA: 0x2E150D0 Offset: 0x2E151D1 VA: 0x2E150D0
	private bool <CreateDesc>b__8_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0DB0 Offset: 0x2B0EB1 VA: 0x2B0DB0
	// RVA: 0x2E150E0 Offset: 0x2E151E1 VA: 0x2E150E0
	private bool <CreateDesc>b__8_2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0DC0 Offset: 0x2B0EC1 VA: 0x2B0DC0
	// RVA: 0x2E150F0 Offset: 0x2E151F1 VA: 0x2E150F0
	private bool <CreateDesc>b__8_3() { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0DD0 Offset: 0x2B0ED1 VA: 0x2B0DD0
	// RVA: 0x2E15100 Offset: 0x2E15201 VA: 0x2E15100
	private void <CreateMapSelectMenu>b__14_0(BasicMenu.Result r, ChallengeData challengeData) { }

	[CompilerGeneratedAttribute] // RVA: 0x2B0DE0 Offset: 0x2B0EE1 VA: 0x2B0DE0
	// RVA: 0x2E15150 Offset: 0x2E15251 VA: 0x2E15150
	private void <CreateDifficultyMenu>b__15_0(BasicMenu.Result r, int difficulty) { }
}

