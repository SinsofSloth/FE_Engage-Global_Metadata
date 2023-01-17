// Namespace: Combat
public class ClassChangeSequence : SingletonProcInst<ClassChangeSequence> // TypeDefIndex: 8676
{
	// Fields
	private const string SceneName = "ClassChangeZone_01";
	private readonly Unit m_Before; // 0x78
	private readonly Unit m_After; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x283870 Offset: 0x283971 VA: 0x283870
	private readonly ViewMode.Mode <ReturnMode>k__BackingField; // 0x88
	private readonly CharacterGameStatus[] m_Status; // 0x90
	private readonly Character[] m_Characters; // 0x98
	private ResourceHandle m_ZoneHandle; // 0xA0
	private GameObject m_ChangeEffect; // 0xA8
	private List<GameObject> m_GameObjects; // 0xB0

	// Properties
	protected override string GlobalAssetPath { get; }
	private ViewMode.Mode ReturnMode { get; }

	// Methods

	// RVA: 0x22C5520 Offset: 0x22C5621 VA: 0x22C5520 Slot: 19
	protected override string get_GlobalAssetPath() { }

	// RVA: 0x22C5570 Offset: 0x22C5671 VA: 0x22C5570
	public static bool IsExist() { }

	// RVA: 0x22C55F0 Offset: 0x22C56F1 VA: 0x22C55F0
	public static void CreateBind(ProcInst super, Unit before, Unit after, bool doFade, ViewMode.Mode cameraMode) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ABA50 Offset: 0x2ABB51 VA: 0x2ABA50
	// RVA: 0x22C6600 Offset: 0x22C6701 VA: 0x22C6600
	private ViewMode.Mode get_ReturnMode() { }

	// RVA: 0x22C6330 Offset: 0x22C6431 VA: 0x22C6330
	public void .ctor(Unit before, Unit after, ViewMode.Mode cameraMode) { }

	[IteratorStateMachineAttribute] // RVA: 0x2ABA60 Offset: 0x2ABB61 VA: 0x2ABA60
	// RVA: 0x22C6610 Offset: 0x22C6711 VA: 0x22C6610
	private IEnumerator Load() { }

	[IteratorStateMachineAttribute] // RVA: 0x2ABAD0 Offset: 0x2ABBD1 VA: 0x2ABAD0
	// RVA: 0x22C6690 Offset: 0x22C6791 VA: 0x22C6690
	private IEnumerator ChangeAnimation() { }

	// RVA: 0x22C6710 Offset: 0x22C6811 VA: 0x22C6710
	private void Change() { }

	[IteratorStateMachineAttribute] // RVA: 0x2ABB40 Offset: 0x2ABC41 VA: 0x2ABB40
	// RVA: 0x22C69E0 Offset: 0x22C6AE1 VA: 0x22C69E0
	private IEnumerator PoseAnimation() { }

	// RVA: 0x22C6A60 Offset: 0x22C6B61 VA: 0x22C6A60
	private void Telop() { }

	// RVA: 0x22C6AE0 Offset: 0x22C6BE1 VA: 0x22C6AE0
	private void DisplayParams() { }

	// RVA: 0x22C6B80 Offset: 0x22C6C81 VA: 0x22C6B80
	private void Exit() { }

	// RVA: 0x22C70E0 Offset: 0x22C71E1 VA: 0x22C70E0
	private bool IsCharacterLoading() { }

	// RVA: 0x22C7230 Offset: 0x22C7331 VA: 0x22C7230
	private void ExitAfter() { }

	// RVA: 0x22C7360 Offset: 0x22C7461 VA: 0x22C7360
	private void StartBeforeBGM() { }

	// RVA: 0x22C7410 Offset: 0x22C7511 VA: 0x22C7410
	private void StartSkipBGM() { }

	// RVA: 0x22C74C0 Offset: 0x22C75C1 VA: 0x22C74C0
	private void StartAfterBGM() { }

	// RVA: 0x22C7570 Offset: 0x22C7671 VA: 0x22C7570
	private void ResumeBGM() { }

	// RVA: 0x22C7620 Offset: 0x22C7721 VA: 0x22C7620
	private void StartSE() { }

	// RVA: 0x22C76A0 Offset: 0x22C77A1 VA: 0x22C76A0
	private void StopSE() { }

	// RVA: 0x22C7720 Offset: 0x22C7821 VA: 0x22C7720
	private void SetupGameStatus() { }

	[IteratorStateMachineAttribute] // RVA: 0x2ABBB0 Offset: 0x2ABCB1 VA: 0x2ABBB0
	// RVA: 0x22C7910 Offset: 0x22C7A11 VA: 0x22C7910
	private IEnumerator CreateCharacter(int side, PreloadAnims preloadAnim, BaseCombatLocation locator, bool visible) { }

	[CompilerGeneratedAttribute] // RVA: 0x2ABC20 Offset: 0x2ABD21 VA: 0x2ABC20
	// RVA: 0x22C79D0 Offset: 0x22C7AD1 VA: 0x22C79D0
	private void <ChangeAnimation>b__18_0(Unit _) { }
}

