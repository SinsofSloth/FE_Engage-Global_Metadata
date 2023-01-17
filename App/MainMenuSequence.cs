// Namespace: App
public class MainMenuSequence : SingletonProcInst<MainMenuSequence> // TypeDefIndex: 13102
{
	// Fields
	private const string GameStartSceneName = "CharacterSelect";
	private MainMenuSequence.Label m_PrevSequence; // 0x74
	private MainMenuSequence.Label m_NowSequence; // 0x78
	private MainMenuSequence.Label m_NextSequence; // 0x7C
	private MainMenuSequence.CharacterWork m_CharacterWorkPlayerMale; // 0x80
	private MainMenuSequence.CharacterWork m_CharacterWorkPlayerFemale; // 0x88
	private MainMenuSequence.CameraWork m_CameraWork; // 0x90
	private MainMenuSequence.HistoryInfo m_HistoryInfo; // 0x98
	private GameSaveDataHeaderReader m_saveDataHeaderReader; // 0xA0
	private bool m_IsFirst; // 0xA8
	private bool m_IsContinueEnable; // 0xA9
	private int m_TopMenuCursorIndex; // 0xAC
	private int m_OptionMenuCursorIndex; // 0xB0
	private Difficulty m_Difficulty; // 0xB4
	private GameMode m_GameMode; // 0xB8
	private GrowMode m_GrowMode; // 0xBC
	private bool m_IsNetworkService; // 0xC0
	private bool m_IsNetworkLoginOnce; // 0xC1
	private Gender m_PlayerGender; // 0xC4
	private string m_PlayerName; // 0xC8
	private int m_DayOfPlayerBirthday; // 0xD0
	private int m_MonthOfPlayerBirthday; // 0xD4
	private bool m_IsReloadLanguageMess; // 0xD8
	private Language.Langs m_ReloadLanguageMess; // 0xDC
	private bool m_IsReloadLanguageVoice; // 0xE0
	private Language.Voices m_ReloadLanguageVoice; // 0xE4

	// Methods

	// RVA: 0x1F98160 Offset: 0x1F98261 VA: 0x1F98160
	private void LoadGameStartScene() { }

	// RVA: 0x1F981F0 Offset: 0x1F982F1 VA: 0x1F981F0
	private void UnloadGameStartScene() { }

	// RVA: 0x1F98280 Offset: 0x1F98381 VA: 0x1F98280
	private void LoadEmptyScene() { }

	// RVA: 0x1F98310 Offset: 0x1F98411 VA: 0x1F98310
	private void JumpToNextSequence() { }

	// RVA: 0x1F983A0 Offset: 0x1F984A1 VA: 0x1F983A0
	private void Start() { }

	// RVA: 0x1F983B0 Offset: 0x1F984B1 VA: 0x1F983B0
	private void BgmToStartGame() { }

	// RVA: 0x1F984E0 Offset: 0x1F985E1 VA: 0x1F984E0
	private void BgmToContinueGame() { }

	// RVA: 0x1F98540 Offset: 0x1F98641 VA: 0x1F98540
	private void BgmToTitleLoop() { }

	// RVA: 0x1F985A0 Offset: 0x1F986A1 VA: 0x1F985A0
	private void BgmToTitle() { }

	// RVA: 0x1F985B0 Offset: 0x1F986B1 VA: 0x1F985B0
	public string CreateDLCNewsMessage(int patchNumber) { }

	// RVA: 0x1F98740 Offset: 0x1F98841 VA: 0x1F98740
	private void CreateDLCNewsDialog() { }

	// RVA: 0x1F987B0 Offset: 0x1F988B1 VA: 0x1F987B0
	private void LoadSaveDataHeader() { }

	// RVA: 0x1F98830 Offset: 0x1F98931 VA: 0x1F98830
	private void DecideIsContinueEnable() { }

	// RVA: 0x1F98A80 Offset: 0x1F98B81 VA: 0x1F98A80
	private void CreateContinueSequence() { }

	// RVA: 0x1F98A90 Offset: 0x1F98B91 VA: 0x1F98A90
	private void AfterContinueSequence() { }

	// RVA: 0x1F98B80 Offset: 0x1F98C81 VA: 0x1F98B80
	private void CreateSaveDataCopyMenu() { }

	// RVA: 0x1F98BB0 Offset: 0x1F98CB1 VA: 0x1F98BB0
	private void CreateSaveDataDeleteMenu() { }

	// RVA: 0x1F98BE0 Offset: 0x1F98CE1 VA: 0x1F98BE0
	private void ReloadLanguage() { }

	// RVA: 0x1F98E30 Offset: 0x1F98F31 VA: 0x1F98E30
	private void StartDLCShop() { }

	// RVA: 0x1F98F40 Offset: 0x1F99041 VA: 0x1F98F40
	private void SetToTitleLoop() { }

	// RVA: 0x1F99040 Offset: 0x1F99141 VA: 0x1F99040
	private ProcDesc[] GetProcDesc() { }

	// RVA: 0x1F9C2F0 Offset: 0x1F9C3F1 VA: 0x1F9C2F0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1F9C480 Offset: 0x1F9C581 VA: 0x1F9C480
	private bool IsGrowModeSelectEnable() { }

	// RVA: 0x1F9C500 Offset: 0x1F9C601 VA: 0x1F9C500
	private bool IsGrowModeRandomInLunaticEnable() { }

	// RVA: 0x1F9C610 Offset: 0x1F9C711 VA: 0x1F9C610
	private static string GetBirthdayString(int month, int day) { }

	// RVA: 0x1F9C6C0 Offset: 0x1F9C7C1 VA: 0x1F9C6C0
	private void InitGameStart() { }

	// RVA: 0x1F9C7C0 Offset: 0x1F9C8C1 VA: 0x1F9C7C0
	private void ExecuteGameStart() { }

	// RVA: 0x1F9CB20 Offset: 0x1F9CC21 VA: 0x1F9CB20
	private void NetworkLogin() { }

	// RVA: 0x1F9CBB0 Offset: 0x1F9CCB1 VA: 0x1F9CBB0
	private MainMenuSequence.CharacterWork CreateCharacter(string pid) { }

	// RVA: 0x1F9CE40 Offset: 0x1F9CF41 VA: 0x1F9CE40
	private void SetupGameStartScene() { }

	// RVA: 0x1F9CEE0 Offset: 0x1F9CFE1 VA: 0x1F9CEE0
	private void AfterSetupGameStartScene() { }

	// RVA: 0x1F9D2F0 Offset: 0x1F9D3F1 VA: 0x1F9D2F0
	private void SetupTitleScene() { }

	// RVA: 0x1F9D350 Offset: 0x1F9D451 VA: 0x1F9D350
	private void Persistent_PlayerSelect() { }

	// RVA: 0x1F9D3A0 Offset: 0x1F9D4A1 VA: 0x1F9D3A0
	private void InitCameraZoomInToPlayer() { }

	// RVA: 0x1F9D6C0 Offset: 0x1F9D7C1 VA: 0x1F9D6C0
	private void WaitCameraZoomInToPlayer() { }

	// RVA: 0x1F9D760 Offset: 0x1F9D861 VA: 0x1F9D760
	private void InitCameraZoomOutFromPlayer() { }

	// RVA: 0x1F9D8B0 Offset: 0x1F9D9B1 VA: 0x1F9D8B0
	private void WaitCameraZoomOutFromPlayer() { }

	// RVA: 0x1F9D950 Offset: 0x1F9DA51 VA: 0x1F9D950
	private void SetupHistoryInfo() { }

	// RVA: 0x1F9D960 Offset: 0x1F9DA61 VA: 0x1F9D960
	private void FadeInHistoryInfo() { }

	// RVA: 0x1F9D970 Offset: 0x1F9DA71 VA: 0x1F9D970
	private void FadeOutHistoryInfo() { }

	// RVA: 0x1F9D980 Offset: 0x1F9DA81 VA: 0x1F9D980
	private void StartPlayerNameInput() { }

	// RVA: 0x1F9DA50 Offset: 0x1F9DB51 VA: 0x1F9DA50
	private void AfterPlayerNameInput() { }

	// RVA: 0x1F9DBF0 Offset: 0x1F9DCF1 VA: 0x1F9DBF0
	private void PlayPlayerStartAnim() { }

	// RVA: 0x1F9C3E0 Offset: 0x1F9C4E1 VA: 0x1F9C3E0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB0E0 Offset: 0x2CB1E1 VA: 0x2CB0E0
	// RVA: 0x1F9DC10 Offset: 0x1F9DD11 VA: 0x1F9DC10
	private void <NetworkLogin>b__66_0(bool isEnable) { }
}

