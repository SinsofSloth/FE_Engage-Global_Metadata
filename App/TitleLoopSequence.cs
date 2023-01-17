// Namespace: App
public class TitleLoopSequence : ProcSceneSequence<TitleLoopSequence> // TypeDefIndex: 13144
{
	// Fields
	private static bool s_isGOPFirst; // 0x0
	private static bool s_IsGOPMovieHeroFemale; // 0x1
	private static TitleLoopSequence.LoopSequenceFromTitle s_LoopSequenceFromTitle; // 0x4
	private static bool s_IsFromMainMenu; // 0x8
	private bool m_IsEndFromTitle; // 0x84

	// Methods

	// RVA: 0x25E2960 Offset: 0x25E2A61 VA: 0x25E2960
	private void .ctor() { }

	// RVA: 0x25E29C0 Offset: 0x25E2AC1 VA: 0x25E29C0
	private void EnableMovieCanvas() { }

	// RVA: 0x25E2A80 Offset: 0x25E2B81 VA: 0x25E2A80
	private void DisableMovieCanvas() { }

	// RVA: 0x25E2B40 Offset: 0x25E2C41 VA: 0x25E2B40
	private void LoadJobIntroData() { }

	// RVA: 0x25E2F40 Offset: 0x25E3041 VA: 0x25E2F40
	private void UnloadJobIntroData() { }

	// RVA: 0x25E2FC0 Offset: 0x25E30C1 VA: 0x25E2FC0
	private void IncJobIntroGroupIndex() { }

	// RVA: 0x25E2FD0 Offset: 0x25E30D1 VA: 0x25E2FD0
	private void LoadMoviePrefab() { }

	// RVA: 0x25E3090 Offset: 0x25E3191 VA: 0x25E3090
	private void PrepareGOPMovie() { }

	// RVA: 0x25E3140 Offset: 0x25E3241 VA: 0x25E3140
	private void UnloadEmptyScene() { }

	// RVA: 0x25E3200 Offset: 0x25E3301 VA: 0x25E3200
	private void BranchFirst() { }

	// RVA: 0x25E3300 Offset: 0x25E3401 VA: 0x25E3300
	private void BranchFromTitle() { }

	// RVA: 0x25E3640 Offset: 0x25E3741 VA: 0x25E3640
	private void EnableGOPMovieFromTitle() { }

	// RVA: 0x25E36E0 Offset: 0x25E37E1 VA: 0x25E36E0
	private void DisableGOPMovieFromTitle() { }

	// RVA: 0x25E3780 Offset: 0x25E3881 VA: 0x25E3780
	private void PlayGOPMovie() { }

	// RVA: 0x25E3840 Offset: 0x25E3941 VA: 0x25E3840
	private void StartTitleCall() { }

	// RVA: 0x25E38B0 Offset: 0x25E39B1 VA: 0x25E38B0
	private ProcDesc[] GetDesc() { }

	// RVA: 0x25E4AC0 Offset: 0x25E4BC1 VA: 0x25E4AC0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x25E4B70 Offset: 0x25E4C71 VA: 0x25E4B70
	public static void SetFromMainMenuOn() { }

	// RVA: 0x25E4BE0 Offset: 0x25E4CE1 VA: 0x25E4BE0
	public static bool IsGOPMovieHeroFemale() { }

	// RVA: 0x25E4C50 Offset: 0x25E4D51 VA: 0x25E4C50
	public static void SwitchGOPMovieByHeroGender() { }

	// RVA: 0x25E4D10 Offset: 0x25E4E11 VA: 0x25E4D10
	public static void SetNextSequenceFromTitleToEnd() { }

	// RVA: 0x25E3560 Offset: 0x25E3661 VA: 0x25E3560
	public static bool IsNextSequenceGrandOpeningFromTitle() { }

	// RVA: 0x25E35D0 Offset: 0x25E36D1 VA: 0x25E35D0
	public static bool IsNextSequenceJobIntroFromTitle() { }

	// RVA: 0x25E4DB0 Offset: 0x25E4EB1 VA: 0x25E4DB0
	private static void .cctor() { }
}

