// Namespace: App
public class MuscleStartSequence : ProcInst // TypeDefIndex: 11281
{
	// Fields
	private int m_SelectedType; // 0x70
	private int m_SelectedLevel; // 0x74
	private int m_AssistDeside; // 0x78
	private bool m_IsCreateGameSequence; // 0x7C
	private bool m_IsCotinueExercise; // 0x7D
	private Character m_TalkerChara; // 0x80
	private List<string> m_AnnouceDifficult; // 0x88
	private bool m_IsAnnounceVoiceOnce; // 0x90

	// Methods

	// RVA: 0x30B9290 Offset: 0x30B9391 VA: 0x30B9290
	public void .ctor() { }

	// RVA: 0x30B9320 Offset: 0x30B9421 VA: 0x30B9320
	private void LoadResources() { }

	// RVA: 0x30B93C0 Offset: 0x30B94C1 VA: 0x30B93C0
	private bool IsLoading() { }

	// RVA: 0x30B9440 Offset: 0x30B9541 VA: 0x30B9440
	private void Init() { }

	// RVA: 0x30B95C0 Offset: 0x30B96C1 VA: 0x30B95C0
	private void OpenTitleBar() { }

	// RVA: 0x30B97B0 Offset: 0x30B98B1 VA: 0x30B97B0
	private void CloseTitleBar() { }

	// RVA: 0x30B9910 Offset: 0x30B9A11 VA: 0x30B9910
	private void OpenExerciseTypeMenu() { }

	// RVA: 0x30B99A0 Offset: 0x30B9AA1 VA: 0x30B99A0
	private void Tutorial() { }

	// RVA: 0x30B9AB0 Offset: 0x30B9BB1 VA: 0x30B9AB0
	private void CheckNewDifficult() { }

	// RVA: 0x30BA220 Offset: 0x30BA321 VA: 0x30BA220
	private void AnnounceNewDifficult() { }

	// RVA: 0x30BA570 Offset: 0x30BA671 VA: 0x30BA570
	private bool CheckAnnounceDifficult() { }

	// RVA: 0x30BA5C0 Offset: 0x30BA6C1 VA: 0x30BA5C0
	private void OpenDifficultMenu() { }

	// RVA: 0x30BA660 Offset: 0x30BA761 VA: 0x30BA660
	private void CreateAssistDialog() { }

	// RVA: 0x30BA730 Offset: 0x30BA831 VA: 0x30BA730
	private void CreateGameSequence() { }

	// RVA: 0x30BA820 Offset: 0x30BA921 VA: 0x30BA820
	private void CreateContinueDialog() { }

	// RVA: 0x30BA8B0 Offset: 0x30BA9B1 VA: 0x30BA8B0
	private bool CheckContinue() { }

	// RVA: 0x30BA8C0 Offset: 0x30BA9C1 VA: 0x30BA8C0
	private void Exit() { }

	// RVA: 0x30BA8D0 Offset: 0x30BA9D1 VA: 0x30BA8D0
	private void UnloadResources() { }

	// RVA: 0x30BA950 Offset: 0x30BAA51 VA: 0x30BA950
	private void VoiceSelectType() { }

	// RVA: 0x30BA490 Offset: 0x30BA591 VA: 0x30BA490
	private void VoiceNewDifficult() { }

	// RVA: 0x30BAA30 Offset: 0x30BAB31 VA: 0x30BAA30
	private void VoiceSelectDifficult() { }

	// RVA: 0x30BAB10 Offset: 0x30BAC11 VA: 0x30BAB10
	private void VoiceFinishExercise() { }

	// RVA: 0x30BAC20 Offset: 0x30BAD21 VA: 0x30BAC20
	public static void CreateBind(ProcInst super) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4010 Offset: 0x2C4111 VA: 0x2C4010
	// RVA: 0x30BBE90 Offset: 0x30BBF91 VA: 0x30BBE90
	private void <OpenExerciseTypeMenu>b__15_0(Type r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4020 Offset: 0x2C4121 VA: 0x2C4020
	// RVA: 0x30BC110 Offset: 0x30BC211 VA: 0x30BC110
	private void <OpenDifficultMenu>b__20_0(Level r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4030 Offset: 0x2C4131 VA: 0x2C4030
	// RVA: 0x30BC2D0 Offset: 0x30BC3D1 VA: 0x30BC2D0
	private void <CreateAssistDialog>b__21_0(int r) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C4040 Offset: 0x2C4141 VA: 0x2C4040
	// RVA: 0x30BC360 Offset: 0x30BC461 VA: 0x30BC360
	private void <CreateContinueDialog>b__23_0(bool r) { }
}

