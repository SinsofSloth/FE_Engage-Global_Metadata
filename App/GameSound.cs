// Namespace: App
public class GameSound // TypeDefIndex: 13386
{
	// Fields
	private static readonly string[] DefaultBankNameArray; // 0x0
	private static readonly string[] DefaultDLCBankNameArray; // 0x8
	private static readonly string EventName_SystemVoice; // 0x10
	private static readonly string EventName_UnitPickVoice; // 0x18
	private static readonly string SwitchGroupName_Person; // 0x20
	private static readonly string SwitchGroupName_Engage; // 0x28
	private static readonly string SwitchGroupName_SystemVoice; // 0x30
	private static readonly string[] SwitchNameArray_SystemVoice; // 0x38
	private static readonly string SwitchGroupName_UnitHp; // 0x40
	private static readonly string[] SwitchNameArray_UnitHp; // 0x48
	private static bool s_initialized; // 0x50
	private static List<string> s_LoadedPackageFileNameList; // 0x58
	private static string s_chapterBankName; // 0x60
	private static readonly string[] strLevelTable; // 0x68
	private static readonly string[] strPatternTable; // 0x70
	private static readonly string[] strSituationTable; // 0x78
	private static readonly string[] strRingCleaningPatternTable; // 0x80

	// Methods

	// RVA: 0x26B0AB0 Offset: 0x26B0BB1 VA: 0x26B0AB0
	public static int GetFadeMsecByFadeSpeedType(GameSound.FadeSpeedType fadeSpeedType) { }

	// RVA: 0x26B0AE0 Offset: 0x26B0BE1 VA: 0x26B0AE0
	public static string GetStringByFadeSpeedType(GameSound.FadeSpeedType fadeSpeedType) { }

	// RVA: 0x26B0B90 Offset: 0x26B0C91 VA: 0x26B0B90
	public static bool IsEnable() { }

	// RVA: 0x26B0D20 Offset: 0x26B0E21 VA: 0x26B0D20
	public static bool IsGameSkip() { }

	// RVA: 0x26B0D60 Offset: 0x26B0E61 VA: 0x26B0D60
	public static bool IsUseGameSoundMode() { }

	// RVA: 0x26B0D70 Offset: 0x26B0E71 VA: 0x26B0D70
	public static GameObject GetAudioListenerObject() { }

	// RVA: 0x26B0E50 Offset: 0x26B0F51 VA: 0x26B0E50
	public static void AddBasePaths() { }

	// RVA: 0x26B0F10 Offset: 0x26B1011 VA: 0x26B0F10
	public static int GetPatchVerNum() { }

	// RVA: 0x26B0F20 Offset: 0x26B1021 VA: 0x26B0F20
	private static string GetPatchPackageFileName(int patchIndex) { }

	// RVA: 0x26B0FD0 Offset: 0x26B10D1 VA: 0x26B0FD0
	private static string GetPatchPackageFilePath(int patchIndex) { }

	// RVA: 0x26B1190 Offset: 0x26B1291 VA: 0x26B1190
	public static void LoadPackageFiles() { }

	// RVA: 0x26B1230 Offset: 0x26B1331 VA: 0x26B1230
	private static bool LoadPackageFile(int patchIndex) { }

	// RVA: 0x26B12A0 Offset: 0x26B13A1 VA: 0x26B12A0
	private static bool LoadPackageFileImpl(string packageFilePath) { }

	// RVA: 0x26B13F0 Offset: 0x26B14F1 VA: 0x26B13F0
	private static string ConvertToDLCSoundBankName(string originalBankName, string packageFileName) { }

	// RVA: 0x26B1490 Offset: 0x26B1591 VA: 0x26B1490
	public static void Initialize() { }

	// RVA: 0x26B1510 Offset: 0x26B1611 VA: 0x26B1510
	public static void LoadDefaultSoundBanks() { }

	// RVA: 0x26B18C0 Offset: 0x26B19C1 VA: 0x26B18C0
	public static void PostInitialize() { }

	// RVA: 0x26B0C00 Offset: 0x26B0D01 VA: 0x26B0C00
	public static bool IsInitialized() { }

	// RVA: 0x26B1AF0 Offset: 0x26B1BF1 VA: 0x26B1AF0
	public static void ResetMasterVolume() { }

	// RVA: 0x26B1C00 Offset: 0x26B1D01 VA: 0x26B1C00
	public static void Serialize(Stream stream) { }

	// RVA: 0x26B1C90 Offset: 0x26B1D91 VA: 0x26B1C90
	public static void Deserialize(Stream stream) { }

	// RVA: 0x26B1D20 Offset: 0x26B1E21 VA: 0x26B1D20
	public static void SetLanguage(Language.Voices language) { }

	// RVA: 0x26B1A40 Offset: 0x26B1B41 VA: 0x26B1A40
	private static void SetState_Language(Language.Voices language) { }

	// RVA: 0x26B1E60 Offset: 0x26B1F61 VA: 0x26B1E60
	public static void LoadBank(string bankName) { }

	// RVA: 0x26B1F90 Offset: 0x26B2091 VA: 0x26B1F90
	public static void LoadBankAsync(string bankName) { }

	// RVA: 0x26B20C0 Offset: 0x26B21C1 VA: 0x26B20C0
	public static void LoadBanks(string[] bankNames) { }

	// RVA: 0x26B2180 Offset: 0x26B2281 VA: 0x26B2180
	public static void LoadBanksAsync(string[] bankNames) { }

	// RVA: 0x26B2240 Offset: 0x26B2341 VA: 0x26B2240
	public static void UnloadBank(string bankName) { }

	// RVA: 0x26B2370 Offset: 0x26B2471 VA: 0x26B2370
	public static void UnloadBanks(string[] bankNames) { }

	// RVA: 0x26B2430 Offset: 0x26B2531 VA: 0x26B2430
	public static bool IsLoadingBank() { }

	// RVA: 0x26B2540 Offset: 0x26B2641 VA: 0x26B2540
	public static bool IsLoadingBank(string bankName) { }

	// RVA: 0x26B2670 Offset: 0x26B2771 VA: 0x26B2670
	public static void LoadChapterBank(ChapterData chapter) { }

	// RVA: 0x26B2770 Offset: 0x26B2871 VA: 0x26B2770
	private static void UnloadChapterBank() { }

	// RVA: 0x26B2830 Offset: 0x26B2931 VA: 0x26B2830
	public static void ClearPrepare() { }

	// RVA: 0x26B28B0 Offset: 0x26B29B1 VA: 0x26B28B0
	public static bool IsEventLoaded(string eventName) { }

	// RVA: 0x26B29D0 Offset: 0x26B2AD1 VA: 0x26B29D0
	public static bool IsEventPlaying(string eventName) { }

	// RVA: 0x26B2AF0 Offset: 0x26B2BF1 VA: 0x26B2AF0
	public static GameSound.Handle FindSoundHandleByEventName(string eventName) { }

	// RVA: 0x26B2C50 Offset: 0x26B2D51 VA: 0x26B2C50
	public static List<GameSound.Handle> FindSoundHandlesByEventName(string eventName) { }

	// RVA: 0x26B2EE0 Offset: 0x26B2FE1 VA: 0x26B2EE0
	public static List<GameSound.Handle> GetSoundHandleList(string prefix) { }

	// RVA: 0x269CC40 Offset: 0x269CD41 VA: 0x269CC40
	public static GameSound.Handle PostEvent(string eventName, Character character) { }

	// RVA: 0x26B3170 Offset: 0x26B3271 VA: 0x26B3170
	public static GameSound.Handle PostEvent(string eventName, GameObject gameObject, Character character) { }

	// RVA: 0x26B3300 Offset: 0x26B3401 VA: 0x26B3300
	public static GameSound.Handle PostEvent(string eventName, Vector3 position, Character character) { }

	// RVA: 0x26B34D0 Offset: 0x26B35D1 VA: 0x26B34D0
	private static GameSound.Handle PostEventWithTemporaryGameObject(string eventName, GameObject temporaryGameObject, Character character) { }

	// RVA: 0x26B3660 Offset: 0x26B3761 VA: 0x26B3660
	public static uint PostEventDirect(string eventName, GameObject gameObject, uint flag, AkCallbackManager.EventCallback callback, object cookie) { }

	// RVA: 0x26B37D0 Offset: 0x26B38D1 VA: 0x26B37D0
	public static AKRESULT ExecuteActionOnEventDirect(string eventName, AkActionOnEventType eventType, int msec, AkCurveInterpolation interpolation, GameObject gameObject, uint playingId) { }

	// RVA: 0x26B3930 Offset: 0x26B3A31 VA: 0x26B3930
	public static void StopSoundOnEvent(string eventName, GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B3B90 Offset: 0x26B3C91 VA: 0x26B3B90
	public static void StopSoundOnEvent(string eventName, int fadeMsec) { }

	// RVA: 0x26B3C10 Offset: 0x26B3D11 VA: 0x26B3C10
	public static void StopSoundOnEvent(string eventName, GameObject gameObject, GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B39D0 Offset: 0x26B3AD1 VA: 0x26B39D0
	public static void StopSoundOnEvent(string eventName, GameObject gameObject, int fadeMsec) { }

	// RVA: 0x26B3CC0 Offset: 0x26B3DC1 VA: 0x26B3CC0
	public static void PauseSoundOnEvent(string eventName, GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B3F50 Offset: 0x26B4051 VA: 0x26B3F50
	public static void PauseSoundOnEvent(string eventName, int fadeMsec) { }

	// RVA: 0x26B3FD0 Offset: 0x26B40D1 VA: 0x26B3FD0
	public static void PauseSoundOnEvent(string eventName, GameObject gameObject, GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B3D60 Offset: 0x26B3E61 VA: 0x26B3D60
	public static void PauseSoundOnEvent(string eventName, GameObject gameObject, int fadeMsec) { }

	// RVA: 0x26B4080 Offset: 0x26B4181 VA: 0x26B4080
	public static void ResumeSoundOnEvent(string eventName, GameSound.FadeSpeedType fadeSpeedType) { }

	// RVA: 0x26B4310 Offset: 0x26B4411 VA: 0x26B4310
	public static void ResumeSoundOnEvent(string eventName, int fadeMsec) { }

	// RVA: 0x26B4390 Offset: 0x26B4491 VA: 0x26B4390
	public static void ResumeSoundOnEvent(string eventName, GameObject gameObject, GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B4120 Offset: 0x26B4221 VA: 0x26B4120
	public static void ResumeSoundOnEvent(string eventName, GameObject gameObject, int fadeMsec) { }

	// RVA: 0x26B4440 Offset: 0x26B4541 VA: 0x26B4440
	public static void StopAllBgm(GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B4640 Offset: 0x26B4741 VA: 0x26B4640
	public static void StopAllSe(GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B46C0 Offset: 0x26B47C1 VA: 0x26B46C0
	public static void StopAllVoice(GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B4740 Offset: 0x26B4841 VA: 0x26B4740
	public static void StopAllEnv(GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B47C0 Offset: 0x26B48C1 VA: 0x26B47C0
	public static void StopAll(GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B44C0 Offset: 0x26B45C1 VA: 0x26B44C0
	private static void StopAllCommon(string eventNameBase, GameSound.FadeSpeedType fadeSpeedType) { }

	// RVA: 0x26B4840 Offset: 0x26B4941 VA: 0x26B4840
	public static int GetPlayPosition(uint playingID) { }

	// RVA: 0x26B4970 Offset: 0x26B4A71 VA: 0x26B4970
	public static float GetMasterBgmVolume() { }

	// RVA: 0x26B49F0 Offset: 0x26B4AF1 VA: 0x26B49F0
	public static float GetMasterSeVolume() { }

	// RVA: 0x26B4A70 Offset: 0x26B4B71 VA: 0x26B4A70
	public static float GetMasterEnvVolume() { }

	// RVA: 0x26B4AF0 Offset: 0x26B4BF1 VA: 0x26B4AF0
	public static float GetMasterVoiceVolume() { }

	// RVA: 0x26B4B70 Offset: 0x26B4C71 VA: 0x26B4B70
	public static void SetMasterBgmVolume(float vol, GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B4CF0 Offset: 0x26B4DF1 VA: 0x26B4CF0
	public static void SetMasterSeVolume(float vol, GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B4E70 Offset: 0x26B4F71 VA: 0x26B4E70
	public static void SetMasterEnvVolume(float vol, GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B4FF0 Offset: 0x26B50F1 VA: 0x26B4FF0
	public static void SetMasterVoiceVolume(float vol, GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B5170 Offset: 0x26B5271 VA: 0x26B5170
	public static void SetMasterAllVolume(float vol, GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B5210 Offset: 0x26B5311 VA: 0x26B5210
	public static float GetConfigBgmVolume() { }

	// RVA: 0x26B5290 Offset: 0x26B5391 VA: 0x26B5290
	public static float GetConfigSeVolume() { }

	// RVA: 0x26B5310 Offset: 0x26B5411 VA: 0x26B5310
	public static float GetConfigEnvVolume() { }

	// RVA: 0x26B5390 Offset: 0x26B5491 VA: 0x26B5390
	public static float GetConfigVoiceVolume() { }

	// RVA: 0x26B5410 Offset: 0x26B5511 VA: 0x26B5410
	public static void SetConfigBgmVolume(float vol) { }

	// RVA: 0x26B54A0 Offset: 0x26B55A1 VA: 0x26B54A0
	public static void SetConfigSeVolume(float vol) { }

	// RVA: 0x26B5530 Offset: 0x26B5631 VA: 0x26B5530
	public static void SetConfigEnvVolume(float vol) { }

	// RVA: 0x26B55C0 Offset: 0x26B56C1 VA: 0x26B55C0
	public static void SetConfigVoiceVolume(float vol) { }

	// RVA: 0x26B5650 Offset: 0x26B5751 VA: 0x26B5650
	public static void FieldBgm_Init() { }

	// RVA: 0x26B5760 Offset: 0x26B5861 VA: 0x26B5760
	public static void FieldBgm_Final() { }

	// RVA: 0x26B5890 Offset: 0x26B5991 VA: 0x26B5890
	public static bool FieldBgm_IsSetPhaseBgm() { }

	// RVA: 0x26B59A0 Offset: 0x26B5AA1 VA: 0x26B59A0
	public static void FieldBgm_SetPhaseBgm(ChapterData chapter, bool isEncount) { }

	// RVA: 0x26B5AD0 Offset: 0x26B5BD1 VA: 0x26B5AD0
	public static void FieldBgm_RestorePhaseBgm() { }

	// RVA: 0x26B5BE0 Offset: 0x26B5CE1 VA: 0x26B5BE0
	public static bool FieldBgm_SetPhaseBgm(string playerPhaseBgm, string enemyPhaseBgm, string allyPhaseBgm) { }

	// RVA: 0x26B5D20 Offset: 0x26B5E21 VA: 0x26B5D20
	public static void FieldBgm_Play(Force.Type forceType) { }

	// RVA: 0x26B5E40 Offset: 0x26B5F41 VA: 0x26B5E40
	public static void FieldBgm_Stop(GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B5EE0 Offset: 0x26B5FE1 VA: 0x26B5EE0
	public static void FieldBgm_Stop(int fadeMsec) { }

	// RVA: 0x26B6000 Offset: 0x26B6101 VA: 0x26B6000
	public static void FieldBgm_Pause(GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B60A0 Offset: 0x26B61A1 VA: 0x26B60A0
	public static void FieldBgm_Pause(int fadeMsec) { }

	// RVA: 0x26B61C0 Offset: 0x26B62C1 VA: 0x26B61C0
	public static void FieldBgm_Resume(GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B6260 Offset: 0x26B6361 VA: 0x26B6260
	public static void FieldBgm_Resume(int fadeMsec) { }

	// RVA: 0x26B6380 Offset: 0x26B6481 VA: 0x26B6380
	public static void FieldBgm_SetVolume(float vol, GameSound.FadeSpeedType fadeSpeedType = 0) { }

	// RVA: 0x26B6420 Offset: 0x26B6521 VA: 0x26B6420
	public static void FieldBgm_SetVolume(float vol, int fadeMsec) { }

	// RVA: 0x26B6550 Offset: 0x26B6651 VA: 0x26B6550
	public static void FieldBgm_SetWarSituationParam(string warSituationStateName) { }

	// RVA: 0x26B6670 Offset: 0x26B6771 VA: 0x26B6670
	public static void FieldBgm_RestoreWarSituationParam() { }

	// RVA: 0x26B6780 Offset: 0x26B6881 VA: 0x26B6780
	public static void FieldBgm_StartSpecialBattleBgmContinueTurn() { }

	// RVA: 0x26B6890 Offset: 0x26B6991 VA: 0x26B6890
	public static void FieldBgm_SetSpecialBattleBgmContinueTurnForRewind(int turn) { }

	// RVA: 0x26B69B0 Offset: 0x26B6AB1 VA: 0x26B69B0
	public static void FieldBgm_SetFirstPlayedFlag() { }

	// RVA: 0x26B6AC0 Offset: 0x26B6BC1 VA: 0x26B6AC0
	public static void FieldBgm_ChangeForceType(Force.Type forceType, ProcInst super) { }

	// RVA: 0x26B6BF0 Offset: 0x26B6CF1 VA: 0x26B6BF0
	public static void FieldBgm_ChangeForceTypeImm(Force.Type forceType) { }

	// RVA: 0x26B6D10 Offset: 0x26B6E11 VA: 0x26B6D10
	public static void FieldBgm_PlaySpecialBattleBgm(string eventName) { }

	// RVA: 0x26B6E30 Offset: 0x26B6F31 VA: 0x26B6E30
	public static void FieldBgm_PauseSpecialBattleBgm(string eventName) { }

	// RVA: 0x26B6F50 Offset: 0x26B7051 VA: 0x26B6F50
	public static bool FieldBgm_IsSpecialBattleBgmExist(string eventName) { }

	// RVA: 0x26B7070 Offset: 0x26B7171 VA: 0x26B7070
	public static void FieldBgm_ToPreBattleBgm(BattleCalculator calculator, bool isSimpleBattle) { }

	// RVA: 0x26B7E10 Offset: 0x26B7F11 VA: 0x26B7E10
	public static void FieldBgm_ToMainBattleBgm(BattleCalculator calculator, bool isSimpleBattle) { }

	// RVA: 0x26B7F10 Offset: 0x26B8011 VA: 0x26B7F10
	public static void FieldBgm_ReturnFromBattleBgm(BattleCalculator calculator, bool isSimpleBattle) { }

	// RVA: 0x26B71E0 Offset: 0x26B72E1 VA: 0x26B71E0
	private static bool FieldBgm_IsSpecialBattleBGM(BattleCalculator calculator) { }

	// RVA: 0x26B7760 Offset: 0x26B7861 VA: 0x26B7760
	private static string FieldBgm_GetSpecialBattleBGMEventName(BattleCalculator calculator) { }

	// RVA: 0x26B7FD0 Offset: 0x26B80D1 VA: 0x26B7FD0
	private static bool IsLeaderEnemyUnit(Unit unit) { }

	// RVA: 0x26B7FA0 Offset: 0x26B80A1 VA: 0x26B7FA0
	private static bool IsCombatBgmExist(PersonData person) { }

	// RVA: 0x26B8100 Offset: 0x26B8201 VA: 0x26B8100
	public static GameSound.ResultLoad LoadSystemVoice(string personSwitchName) { }

	// RVA: 0x26B8320 Offset: 0x26B8421 VA: 0x26B8320
	public static void UnloadSystemVoice(string personSwitchName) { }

	// RVA: 0x26B84C0 Offset: 0x26B85C1 VA: 0x26B84C0
	public static GameSound.ResultLoad LoadSystemVoiceForEngageInCombat(string engageSwitchName) { }

	// RVA: 0x26B87E0 Offset: 0x26B88E1 VA: 0x26B87E0
	public static void UnloadSystemVoiceForEngageInCombat(string engageSwitchName) { }

	// RVA: 0x26B8980 Offset: 0x26B8A81 VA: 0x26B8980
	public static void SetState_Phase(Force.Type turn) { }

	// RVA: 0x26B8B20 Offset: 0x26B8C21 VA: 0x26B8B20
	public static void SetState_FieldSituation(string name) { }

	// RVA: 0x26B7CD0 Offset: 0x26B7DD1 VA: 0x26B7CD0
	public static void SetState_SpecialBattle(string name) { }

	// RVA: 0x26B8C70 Offset: 0x26B8D71 VA: 0x26B8C70
	public static void RestoreSpecialBattleParam() { }

	// RVA: 0x26B8DB0 Offset: 0x26B8EB1 VA: 0x26B8DB0
	public static void PushState_MapOrCombat(string name) { }

	// RVA: 0x26B8ED0 Offset: 0x26B8FD1 VA: 0x26B8ED0
	public static void PopState_MapOrCombat() { }

	// RVA: 0x26B8FE0 Offset: 0x26B90E1 VA: 0x26B8FE0
	public static bool SetSwitch_Person(string name) { }

	// RVA: 0x26B9130 Offset: 0x26B9231 VA: 0x26B9130
	public static bool SetSwitch_Person(GameObject gameObject, string name) { }

	// RVA: 0x26B9290 Offset: 0x26B9391 VA: 0x26B9290
	public static bool SetSwitch_Engage(string name) { }

	// RVA: 0x26B93E0 Offset: 0x26B94E1 VA: 0x26B93E0
	public static bool SetSwitch_Engage(GameObject gameObject, string name) { }

	// RVA: 0x26B86D0 Offset: 0x26B87D1 VA: 0x26B86D0
	private static string ConvertHeroEngageSwitchName(string name) { }

	// RVA: 0x26B9540 Offset: 0x26B9641 VA: 0x26B9540
	public static void SetSwitch_Weapon(string weaponName, GameObject gameObject, ItemData.Kinds itemKind) { }

	// RVA: 0x26A8A70 Offset: 0x26A8B71 VA: 0x26A8A70
	public static void ItemGet(ItemData item, bool isForceImportant = False) { }

	// RVA: 0x26A9100 Offset: 0x26A9201 VA: 0x26A9100
	public static void MoneyGet() { }

	// RVA: 0x26B9650 Offset: 0x26B9751 VA: 0x26B9650
	public static void JoinUnit() { }

	// RVA: 0x26B96D0 Offset: 0x26B97D1 VA: 0x26B96D0
	public static void SelectUnit() { }

	// RVA: 0x26B9750 Offset: 0x26B9851 VA: 0x26B9750
	public static void ExchangeUnit() { }

	// RVA: 0x26B97D0 Offset: 0x26B98D1 VA: 0x26B97D0
	public static void Cancel() { }

	// RVA: 0x26B9850 Offset: 0x26B9951 VA: 0x26B9850
	public static void Failure() { }

	// RVA: 0x26B98D0 Offset: 0x26B99D1 VA: 0x26B98D0
	public static void UnitSound(string eventName, GameObject gameObject, AssetTable.Sound assetSound, string groundMaterial, string assetWeaponName, ItemData.Kinds itemKind, float unitSpeed) { }

	// RVA: 0x26B9BB0 Offset: 0x26B9CB1 VA: 0x26B9BB0
	public static void UnitSound(string eventName, GameObject gameObject, AssetTable.Sound assetSound, Vector3 position, string assetWeaponName, ItemData.Kinds itemKind, float unitSpeed) { }

	// RVA: 0x26B9CC0 Offset: 0x26B9DC1 VA: 0x26B9CC0
	public static void Footstep(GameObject gameObject, string groundMaterial, AssetTable.Sound assetSound, float walkingSpeed = 100) { }

	// RVA: 0x26BA030 Offset: 0x26BA131 VA: 0x26BA030
	public static void Footstep(GameObject gameObject, Vector3 position, AssetTable.Sound assetSound, float walkingSpeed = 100) { }

	// RVA: 0x26BA150 Offset: 0x26BA251 VA: 0x26BA150
	public static void Landing(GameObject gameObject, string groundMaterial, AssetTable.Sound assetSound) { }

	// RVA: 0x26BA200 Offset: 0x26BA301 VA: 0x26BA200
	public static void Landing(GameObject gameObject, Vector3 position, AssetTable.Sound assetSound) { }

	// RVA: 0x26BA320 Offset: 0x26BA421 VA: 0x26BA320
	public static void DefeatLanding(GameObject gameObject, string groundMaterial, AssetTable.Sound assetSound) { }

	// RVA: 0x26BA3D0 Offset: 0x26BA4D1 VA: 0x26BA3D0
	public static void DefeatLanding(GameObject gameObject, Vector3 position, AssetTable.Sound assetSound) { }

	// RVA: 0x26B9D70 Offset: 0x26B9E71 VA: 0x26B9D70
	private static void TerrainSound(string eventName, GameObject gameObject, string groundMaterial, string unitFootstep, string unitMaterial, float walkingSpeed) { }

	// RVA: 0x26BA4F0 Offset: 0x26BA5F1 VA: 0x26BA4F0
	public static void Flap(GameObject gameObject, string unitFootstep) { }

	// RVA: 0x26BA6A0 Offset: 0x26BA7A1 VA: 0x26BA6A0
	public static void Flap(GameObject gameObject, AssetTable.Sound assetSound) { }

	// RVA: 0x26BA720 Offset: 0x26BA821 VA: 0x26BA720
	public static void Swing(GameObject gameObject, string assetWeaponName, ItemData.Kinds itemKind, float unitSpeed) { }

	// RVA: 0x26BA920 Offset: 0x26BAA21 VA: 0x26BA920
	public static void Shoot(GameObject gameObject, string assetWeaponName, ItemData.Kinds itemKind, float unitSpeed) { }

	// RVA: 0x26BAB20 Offset: 0x26BAC21 VA: 0x26BAB20
	public static void WeaponLanding(GameObject gameObject, string assetWeaponName, ItemData.Kinds itemKind, string groundMaterial) { }

	// RVA: 0x26BAD50 Offset: 0x26BAE51 VA: 0x26BAD50
	public static void WeaponLanding(GameObject gameObject, string assetWeaponName, ItemData.Kinds itemKind, Vector3 position) { }

	// RVA: 0x26BAE10 Offset: 0x26BAF11 VA: 0x26BAE10
	public static void WeaponOpen(GameObject gameObject, string assetWeaponName, ItemData.Kinds itemKind) { }

	// RVA: 0x26BAFD0 Offset: 0x26BB0D1 VA: 0x26BAFD0
	public static void WeaponClose(GameObject gameObject, string assetWeaponName, ItemData.Kinds itemKind) { }

	// RVA: 0x26BB190 Offset: 0x26BB291 VA: 0x26BB190
	public static void Hit(Vector3 position, AttackType attackType, DamageLevel damageLevel, AssetTable.Sound assetSound) { }

	// RVA: 0x26BB4D0 Offset: 0x26BB5D1 VA: 0x26BB4D0
	public static void Hit(Vector3 position, AttackType attackType, DamageLevel damageLevel, AssetTable.Result assetResult) { }

	// RVA: 0x26BB240 Offset: 0x26BB341 VA: 0x26BB240
	public static void Hit(Vector3 position, AttackType attackType, DamageLevel damageLevel, string unitMaterial) { }

	// RVA: 0x26BB580 Offset: 0x26BB681 VA: 0x26BB580
	public static bool IsSeriousChapter() { }

	// RVA: 0x26BB6B0 Offset: 0x26BB7B1 VA: 0x26BB6B0
	public static void TalkVoice(string eventName) { }

	// RVA: 0x26BB770 Offset: 0x26BB871 VA: 0x26BB770
	public static void TalkVoice(string eventName, Character character) { }

	// RVA: 0x26BB7F0 Offset: 0x26BB8F1 VA: 0x26BB7F0
	public static void PersonVoice(string personSwitchName, string engageSwitchName, string eventName) { }

	// RVA: 0x26BB880 Offset: 0x26BB981 VA: 0x26BB880
	public static void PersonVoice(string personSwitchName, string engageSwitchName, string eventName, Character character) { }

	// RVA: 0x26BBA90 Offset: 0x26BBB91 VA: 0x26BBA90
	public static void PersonVoice(GameObject gameObject, string personSwitchName, string engageSwitchName, string eventName) { }

	// RVA: 0x26BBB20 Offset: 0x26BBC21 VA: 0x26BBB20
	public static void PersonVoice(GameObject gameObject, string personSwitchName, string engageSwitchName, string eventName, Character character) { }

	// RVA: 0x26BBC10 Offset: 0x26BBD11 VA: 0x26BBC10
	public static void UnitPickVoice(Unit unit) { }

	// RVA: 0x26BC010 Offset: 0x26BC111 VA: 0x26BC010
	public static string GetWakeupSoundBankName(int patchIndex = -1) { }

	// RVA: 0x26BC0C0 Offset: 0x26BC1C1 VA: 0x26BC0C0
	public static void LoadWakeupVoice() { }

	// RVA: 0x26BC1E0 Offset: 0x26BC2E1 VA: 0x26BC1E0
	public static void UnloadWakeupVoice() { }

	// RVA: 0x26BC300 Offset: 0x26BC401 VA: 0x26BC300
	public static string WakeupVoice(string personSwitchName, RelianceData.Level level, GameSound.WakeupVoiceSituation situation, GameSound.WakeupVoicePattern pattern, Character character) { }

	// RVA: 0x26BC5C0 Offset: 0x26BC6C1 VA: 0x26BC5C0
	public static void RingCleaningVoice(string personSwitchName, GameSound.RingCleaningVoicePattern pattern) { }

	// RVA: 0x26BC6C0 Offset: 0x26BC7C1 VA: 0x26BC6C0
	public static void RingCleaningVoice(string personSwitchName, GameSound.RingCleaningVoicePattern pattern, int number) { }

	// RVA: 0x26BC840 Offset: 0x26BC941 VA: 0x26BC840
	public static void RingCleaningVoice(string personSwitchName, string eventName, Character character) { }

	// RVA: 0x26BC8F0 Offset: 0x26BC9F1 VA: 0x26BC8F0
	public static bool IsPlayingRingFinishCleaningVoice() { }

	// RVA: 0x26BCAF0 Offset: 0x26BCBF1 VA: 0x26BCAF0
	public static float GetEventSeVolume() { }

	// RVA: 0x26BCC00 Offset: 0x26BCD01 VA: 0x26BCC00
	public static bool IsEventSePlaying() { }

	// RVA: 0x26BCD10 Offset: 0x26BCE11 VA: 0x26BCD10
	public static void UnloadLipSyncDataAll() { }

	// RVA: 0x26BCE20 Offset: 0x26BCF21 VA: 0x26BCE20
	public static GameSound.LipSyncData GetLipSyncData(string eventName) { }

	// RVA: 0x26BCF80 Offset: 0x26BD081 VA: 0x26BCF80
	public static ProcDesc PEvent(string eventName) { }

	// RVA: 0x26BCFF0 Offset: 0x26BD0F1 VA: 0x26BCFF0
	public void .ctor() { }

	// RVA: 0x26BD000 Offset: 0x26BD101 VA: 0x26BD000
	private static void .cctor() { }
}

