// Namespace: App
public class SoundManager : SingletonMonoBehaviour<SoundManager> // TypeDefIndex: 13793
{
	// Fields
	public const float VoiceVolumeMin = -48;
	public const float VoiceVolumeMax = 0;
	public const float SeVolumeMin = -48;
	public const float SeVolumeMax = 0;
	private const string EventSeGameParamName = "EvtSeVolume";
	private bool m_isInitialized; // 0x20
	private SoundManager.ParamFader m_masterBaseBgmVolume; // 0x28
	private SoundManager.ParamFader m_masterBaseSeVolume; // 0x30
	private SoundManager.ParamFader m_masterBaseEnvVolume; // 0x38
	private SoundManager.ParamFader m_masterBaseVoiceVolume; // 0x40
	private float m_masterBgmVolumeOld; // 0x48
	private float m_masterSeVolumeOld; // 0x4C
	private float m_masterEnvVolumeOld; // 0x50
	private float m_masterVoiceVolumeOld; // 0x54
	private float m_configBgmVolumeOld; // 0x58
	private float m_configSeVolumeOld; // 0x5C
	private float m_configEnvVolumeOld; // 0x60
	private float m_configVoiceVolumeOld; // 0x64
	private float m_mapCameraHeightRateOld; // 0x68
	private float m_eventSeVolume; // 0x6C
	private AudioDevice.AudioDeviceName m_outputDeviceIndex; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x29CB80 Offset: 0x29CC81 VA: 0x29CB80
	private SoundSystem.ISoundParam <Param>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x29CB90 Offset: 0x29CC91 VA: 0x29CB90
	private SoundSystem.ISoundLoad <Loader>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x29CBA0 Offset: 0x29CCA1 VA: 0x29CBA0
	private SoundSystem.ISoundPlay <Player>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x29CBB0 Offset: 0x29CCB1 VA: 0x29CBB0
	private FieldBgmManager <FieldBgmManager>k__BackingField; // 0x90
	private List<SoundSystem.SoundHandle> m_soundHandleList; // 0x98
	private List<SoundSystem.SoundHandle> m_deleteSoundHandleList; // 0xA0
	private Stack<uint> m_GlobalEnumParamStack_MapOrCombat; // 0xA8
	private float m_TimeCounterForUpdateOutput; // 0xB0
	private bool m_isMuteByGameSkip; // 0xB4
	private Dictionary<string, SoundSystem.LipSyncDataFile> m_lipSyncDataFileDictionary; // 0xB8

	// Properties
	private SoundSystem.ISoundParam Param { get; set; }
	private SoundSystem.ISoundLoad Loader { get; set; }
	private SoundSystem.ISoundPlay Player { get; set; }
	private FieldBgmManager FieldBgmManager { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CD5E0 Offset: 0x2CD6E1 VA: 0x2CD5E0
	// RVA: 0x2176140 Offset: 0x2176241 VA: 0x2176140
	private SoundSystem.ISoundParam get_Param() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD5F0 Offset: 0x2CD6F1 VA: 0x2CD5F0
	// RVA: 0x2176150 Offset: 0x2176251 VA: 0x2176150
	private void set_Param(SoundSystem.ISoundParam value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD600 Offset: 0x2CD701 VA: 0x2CD600
	// RVA: 0x2176160 Offset: 0x2176261 VA: 0x2176160
	private SoundSystem.ISoundLoad get_Loader() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD610 Offset: 0x2CD711 VA: 0x2CD610
	// RVA: 0x2176170 Offset: 0x2176271 VA: 0x2176170
	private void set_Loader(SoundSystem.ISoundLoad value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD620 Offset: 0x2CD721 VA: 0x2CD620
	// RVA: 0x2176180 Offset: 0x2176281 VA: 0x2176180
	private SoundSystem.ISoundPlay get_Player() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD630 Offset: 0x2CD731 VA: 0x2CD630
	// RVA: 0x2176190 Offset: 0x2176291 VA: 0x2176190
	private void set_Player(SoundSystem.ISoundPlay value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD640 Offset: 0x2CD741 VA: 0x2CD640
	// RVA: 0x21761A0 Offset: 0x21762A1 VA: 0x21761A0
	private FieldBgmManager get_FieldBgmManager() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD650 Offset: 0x2CD751 VA: 0x2CD650
	// RVA: 0x21761B0 Offset: 0x21762B1 VA: 0x21761B0
	private void set_FieldBgmManager(FieldBgmManager value) { }

	// RVA: 0x21761C0 Offset: 0x21762C1 VA: 0x21761C0
	public void .ctor() { }

	// RVA: 0x21762E0 Offset: 0x21763E1 VA: 0x21762E0
	private void OnEnable() { }

	// RVA: 0x2176430 Offset: 0x2176531 VA: 0x2176430
	public void Init() { }

	// RVA: 0x2176790 Offset: 0x2176891 VA: 0x2176790
	public void ResetMasterVolume() { }

	// RVA: 0x2177120 Offset: 0x2177221 VA: 0x2177120
	public void Serialize(Stream stream) { }

	// RVA: 0x2177130 Offset: 0x2177231 VA: 0x2177130
	public void Deserialize(Stream stream) { }

	// RVA: 0x2177030 Offset: 0x2177131 VA: 0x2177030
	public void SetLanguage(Language.Langs language) { }

	// RVA: 0x2177140 Offset: 0x2177241 VA: 0x2177140
	public float GetEventSeVolume() { }

	// RVA: 0x2177160 Offset: 0x2177261 VA: 0x2177160
	public bool IsEventLoaded(string eventName) { }

	// RVA: 0x2177210 Offset: 0x2177311 VA: 0x2177210
	public bool IsEventPlaying(string eventName) { }

	// RVA: 0x21773A0 Offset: 0x21774A1 VA: 0x21773A0
	private bool IsBgmEventPlaying(string eventName) { }

	// RVA: 0x2177230 Offset: 0x2177331 VA: 0x2177230
	public SoundSystem.SoundHandle FindSoundHandleByEventName(string eventName) { }

	// RVA: 0x2177440 Offset: 0x2177541 VA: 0x2177440
	public List<SoundSystem.SoundHandle> FindSoundHandlesByEventName(string eventName) { }

	// RVA: 0x21775F0 Offset: 0x21776F1 VA: 0x21775F0
	public SoundSystem.SoundHandle FindSoundHandleByEventId(uint eventId) { }

	// RVA: 0x2177760 Offset: 0x2177861 VA: 0x2177760
	public List<SoundSystem.SoundHandle> FindSoundHandlesByEventId(uint eventId) { }

	// RVA: 0x2177910 Offset: 0x2177A11 VA: 0x2177910
	public List<SoundSystem.SoundHandle> GetSoundHandleList(string prefix) { }

	// RVA: 0x2177AC0 Offset: 0x2177BC1 VA: 0x2177AC0
	public bool IsEventSePlaying() { }

	// RVA: 0x2177AE0 Offset: 0x2177BE1 VA: 0x2177AE0
	public GameObject GetAudioListenerObject() { }

	// RVA: 0x2177BA0 Offset: 0x2177CA1 VA: 0x2177BA0
	public Vector3 GetAudioListenerPosition() { }

	// RVA: 0x2177C50 Offset: 0x2177D51 VA: 0x2177C50
	public Quaternion GetAudioListenerRotation() { }

	// RVA: 0x2177D00 Offset: 0x2177E01 VA: 0x2177D00
	public void LoadSound(string name) { }

	// RVA: 0x2177E00 Offset: 0x2177F01 VA: 0x2177E00
	public void LoadSoundAsync(string name) { }

	// RVA: 0x2177F00 Offset: 0x2178001 VA: 0x2177F00
	public bool IsLoadingSound() { }

	// RVA: 0x2177FC0 Offset: 0x21780C1 VA: 0x2177FC0
	public bool IsLoadingSound(string name) { }

	// RVA: 0x2178090 Offset: 0x2178191 VA: 0x2178090
	public void UnloadSound(string name) { }

	// RVA: 0x2178190 Offset: 0x2178291 VA: 0x2178190
	public void UnloadSoundAll() { }

	// RVA: 0x2178280 Offset: 0x2178381 VA: 0x2178280
	public void ReloadSoundBySetLanguage(Language.Voices language) { }

	// RVA: 0x2178350 Offset: 0x2178451 VA: 0x2178350
	public bool PrepareEvent(string eventName) { }

	// RVA: 0x2178400 Offset: 0x2178501 VA: 0x2178400
	public bool PrepareEvent(string[] eventNameArray) { }

	// RVA: 0x21784B0 Offset: 0x21785B1 VA: 0x21784B0
	public bool PrepareEventAsync(string eventName, out SoundSystem.ResultSoundLoad resultSoundLoad) { }

	// RVA: 0x2178570 Offset: 0x2178671 VA: 0x2178570
	public bool PrepareEventAsync(string[] eventNameArray, out SoundSystem.ResultSoundLoad resultSoundLoad) { }

	// RVA: 0x2178630 Offset: 0x2178731 VA: 0x2178630
	public void UnprepareEvent(string eventNameArray) { }

	// RVA: 0x21786E0 Offset: 0x21787E1 VA: 0x21786E0
	public void UnprepareEvent(string[] eventNameArray) { }

	// RVA: 0x2178790 Offset: 0x2178891 VA: 0x2178790
	public bool PrepareSwitch(string switchGroupName, string switchName) { }

	// RVA: 0x2178850 Offset: 0x2178951 VA: 0x2178850
	public bool PrepareSwitch(string switchGroupName, string[] switchNameArray) { }

	// RVA: 0x2178910 Offset: 0x2178A11 VA: 0x2178910
	public bool PrepareSwitchAsync(string switchGroupName, string switchName, out SoundSystem.ResultSoundLoad resultSoundLoad) { }

	// RVA: 0x21789E0 Offset: 0x2178AE1 VA: 0x21789E0
	public bool PrepareSwitchAsync(string switchGroupName, string[] switchNameArray, out SoundSystem.ResultSoundLoad resultSoundLoad) { }

	// RVA: 0x2178AB0 Offset: 0x2178BB1 VA: 0x2178AB0
	public void UnprepareSwitch(string switchGroupName, string switchNameArray) { }

	// RVA: 0x2178B70 Offset: 0x2178C71 VA: 0x2178B70
	public void UnprepareSwitch(string switchGroupName, string[] switchNameArray) { }

	// RVA: 0x2178C30 Offset: 0x2178D31 VA: 0x2178C30
	public void ClearPrepare() { }

	// RVA: 0x2178CE0 Offset: 0x2178DE1 VA: 0x2178CE0
	public GameObject GetTemporaryGameObject() { }

	[ConditionalAttribute] // RVA: 0x2CD660 Offset: 0x2CD761 VA: 0x2CD660
	// RVA: 0x2178D90 Offset: 0x2178E91 VA: 0x2178D90
	private static void TryDebugLog(string eventName) { }

	// RVA: 0x2178DA0 Offset: 0x2178EA1 VA: 0x2178DA0
	public SoundSystem.SoundHandle PostEvent(string eventName, Character character, bool isGetPosition) { }

	// RVA: 0x2178FF0 Offset: 0x21790F1 VA: 0x2178FF0
	public SoundSystem.SoundHandle PostEvent(string eventName, GameObject gameObject, Character character, bool isGetPosition) { }

	// RVA: 0x2179240 Offset: 0x2179341 VA: 0x2179240
	public SoundSystem.SoundHandle PostEventWithTemporaryGameObject(string eventName, GameObject temporaryGameObject, Character character, bool isGetPosition) { }

	// RVA: 0x2179490 Offset: 0x2179591 VA: 0x2179490
	public SoundSystem.SoundHandle PostEventDirect(string eventName, GameObject gameObject, uint flag, AkCallbackManager.EventCallback callback, object cookie) { }

	// RVA: 0x2179700 Offset: 0x2179801 VA: 0x2179700
	public AKRESULT ExecuteActionOnEventDirect(string eventName, AkActionOnEventType eventType, int msec, AkCurveInterpolation interpolation, GameObject gameObject, uint playingId) { }

	// RVA: 0x21797B0 Offset: 0x21798B1 VA: 0x21797B0
	public void StopSoundOnEvent(string eventName, int fadeMsec) { }

	// RVA: 0x2179870 Offset: 0x2179971 VA: 0x2179870
	public void StopSoundOnEvent(string eventName, int fadeMsec, GameObject gameObject) { }

	// RVA: 0x2179940 Offset: 0x2179A41 VA: 0x2179940
	public void PauseSoundOnEvent(string eventName, int fadeMsec) { }

	// RVA: 0x2179A00 Offset: 0x2179B01 VA: 0x2179A00
	public void PauseSoundOnEvent(string eventName, int fadeMsec, GameObject gameObject) { }

	// RVA: 0x2179AD0 Offset: 0x2179BD1 VA: 0x2179AD0
	public void ResumeSoundOnEvent(string eventName, int fadeMsec) { }

	// RVA: 0x2179B90 Offset: 0x2179C91 VA: 0x2179B90
	public void ResumeSoundOnEvent(string eventName, int fadeMsec, GameObject gameObject) { }

	// RVA: 0x2179C60 Offset: 0x2179D61 VA: 0x2179C60
	public void StopByPlayingId(uint playingId, int fadeMsec) { }

	// RVA: 0x2179D20 Offset: 0x2179E21 VA: 0x2179D20
	public int GetPlayPosition(uint playingId, int positionOffset) { }

	// RVA: 0x2179DE0 Offset: 0x2179EE1 VA: 0x2179DE0
	public float GetMasterBgmVolume() { }

	// RVA: 0x2179DF0 Offset: 0x2179EF1 VA: 0x2179DF0
	public float GetMasterSeVolume() { }

	// RVA: 0x2179E00 Offset: 0x2179F01 VA: 0x2179E00
	public float GetMasterEnvVolume() { }

	// RVA: 0x2179E10 Offset: 0x2179F11 VA: 0x2179E10
	public float GetMasterVoiceVolume() { }

	// RVA: 0x2179E20 Offset: 0x2179F21 VA: 0x2179E20
	public void SetMasterBgmVolume(float vol, int fadeMsec) { }

	// RVA: 0x2179E30 Offset: 0x2179F31 VA: 0x2179E30
	public void SetMasterSeVolume(float vol, int fadeMsec) { }

	// RVA: 0x2179E40 Offset: 0x2179F41 VA: 0x2179E40
	public void SetMasterEnvVolume(float vol, int fadeMsec) { }

	// RVA: 0x2179E50 Offset: 0x2179F51 VA: 0x2179E50
	public void SetMasterVoiceVolume(float vol, int fadeMsec) { }

	// RVA: 0x2179E60 Offset: 0x2179F61 VA: 0x2179E60
	public float GetConfigBgmVolume() { }

	// RVA: 0x2179EE0 Offset: 0x2179FE1 VA: 0x2179EE0
	public float GetConfigSeVolume() { }

	// RVA: 0x2179F60 Offset: 0x217A061 VA: 0x2179F60
	public float GetConfigEnvVolume() { }

	// RVA: 0x2179FE0 Offset: 0x217A0E1 VA: 0x2179FE0
	public float GetConfigVoiceVolume() { }

	// RVA: 0x217A060 Offset: 0x217A161 VA: 0x217A060
	public void SetConfigBgmVolume(float vol) { }

	// RVA: 0x217A0F0 Offset: 0x217A1F1 VA: 0x217A0F0
	public void SetConfigSeVolume(float vol) { }

	// RVA: 0x217A180 Offset: 0x217A281 VA: 0x217A180
	public void SetConfigEnvVolume(float vol) { }

	// RVA: 0x217A210 Offset: 0x217A311 VA: 0x217A210
	public void SetConfigVoiceVolume(float vol) { }

	// RVA: 0x217A2A0 Offset: 0x217A3A1 VA: 0x217A2A0
	public void SetVolume(float vol, GameObject gameObject) { }

	// RVA: 0x217A360 Offset: 0x217A461 VA: 0x217A360
	public bool GetGlobalEnumParam(string valueName, out uint value) { }

	// RVA: 0x217A430 Offset: 0x217A531 VA: 0x217A430
	public bool GetEnumParam(string valueName, out uint value) { }

	// RVA: 0x217A500 Offset: 0x217A601 VA: 0x217A500
	public bool GetGameParam(string valueName, out float value) { }

	// RVA: 0x217A5C0 Offset: 0x217A6C1 VA: 0x217A5C0
	public bool GetGameParam(string valueName, GameObject gameObject, out float value) { }

	// RVA: 0x217A690 Offset: 0x217A791 VA: 0x217A690
	public bool SetGlobalEnumParam(string valueName, string value) { }

	// RVA: 0x217A760 Offset: 0x217A861 VA: 0x217A760
	public bool SetGlobalEnumParam(string valueName, uint value) { }

	// RVA: 0x217A830 Offset: 0x217A931 VA: 0x217A830
	public bool SetEnumParam(string valueName, string value) { }

	// RVA: 0x217A900 Offset: 0x217AA01 VA: 0x217A900
	public bool SetEnumParam(string valueName, string value, GameObject gameObject) { }

	// RVA: 0x2176C60 Offset: 0x2176D61 VA: 0x2176C60
	public bool SetGameParam(string valueName, float value) { }

	// RVA: 0x217A9D0 Offset: 0x217AAD1 VA: 0x217A9D0
	public bool SetGameParam(string valueName, float value, GameObject gameObject) { }

	// RVA: 0x217AB30 Offset: 0x217AC31 VA: 0x217AB30
	public void PushGlobalEnumParam_MapOrCombat(string value) { }

	// RVA: 0x217AD00 Offset: 0x217AE01 VA: 0x217AD00
	public void PopGlobalEnumParam_MapOrCombat() { }

	// RVA: 0x217AE40 Offset: 0x217AF41 VA: 0x217AE40
	public void SetPosition(Vector3 pos, GameObject temporaryGameObject) { }

	// RVA: 0x217AFD0 Offset: 0x217B0D1 VA: 0x217AFD0
	public bool FieldBgm_IsSetPhaseBgm() { }

	// RVA: 0x217AFE0 Offset: 0x217B0E1 VA: 0x217AFE0
	public void FieldBgm_Init() { }

	// RVA: 0x217AFF0 Offset: 0x217B0F1 VA: 0x217AFF0
	public void FieldBgm_Final(int fadeMsec) { }

	// RVA: 0x217B000 Offset: 0x217B101 VA: 0x217B000
	public void FieldBgm_SetPhaseBgm(ChapterData chapter, bool isEncount) { }

	// RVA: 0x217B010 Offset: 0x217B111 VA: 0x217B010
	public void FieldBgm_RestorePhaseBgm() { }

	// RVA: 0x217B020 Offset: 0x217B121 VA: 0x217B020
	public bool FieldBgm_SetPhaseBgm(string playerPhaseBgm, string enemyPhaseBgm, string allyPhaseBgm) { }

	// RVA: 0x217B030 Offset: 0x217B131 VA: 0x217B030
	public void FieldBgm_PlayBgm(Force.Type forceType) { }

	// RVA: 0x217B040 Offset: 0x217B141 VA: 0x217B040
	public void FieldBgm_StopBgm(int fadeMsec) { }

	// RVA: 0x217B050 Offset: 0x217B151 VA: 0x217B050
	public void FieldBgm_PauseBgm(int fadeMsec) { }

	// RVA: 0x217B060 Offset: 0x217B161 VA: 0x217B060
	public void FieldBgm_ResumeBgm(int fadeMsec) { }

	// RVA: 0x217B070 Offset: 0x217B171 VA: 0x217B070
	public void FieldBgm_SetBgmVolume(float vol, int fadeMsec) { }

	// RVA: 0x217B080 Offset: 0x217B181 VA: 0x217B080
	public void FieldBgm_SetWarSituationParam(string valueName) { }

	// RVA: 0x217B090 Offset: 0x217B191 VA: 0x217B090
	public void FieldBgm_RestoreWarSituationParam() { }

	// RVA: 0x217B0A0 Offset: 0x217B1A1 VA: 0x217B0A0
	public void FieldBgm_StartSpecialBattleBgmContinueTurn() { }

	// RVA: 0x217B0B0 Offset: 0x217B1B1 VA: 0x217B0B0
	public void FieldBgm_SetSpecialBattleBgmContinueTurnForRewind(int turn) { }

	// RVA: 0x217B0C0 Offset: 0x217B1C1 VA: 0x217B0C0
	public void FieldBgm_ChangeForceType(Force.Type forceType, ProcInst super, bool isTurnElapsed) { }

	// RVA: 0x217B0D0 Offset: 0x217B1D1 VA: 0x217B0D0
	public void FieldBgm_ChangeForceTypeImm(Force.Type forceType) { }

	// RVA: 0x217B0E0 Offset: 0x217B1E1 VA: 0x217B0E0
	public void FieldBgm_SetFirstPlayedFlag() { }

	// RVA: 0x217B0F0 Offset: 0x217B1F1 VA: 0x217B0F0
	public void FieldBgm_PlaySpecialBattleBgm(string eventName) { }

	// RVA: 0x217B100 Offset: 0x217B201 VA: 0x217B100
	public void FieldBgm_PauseSpecialBattleBgm(string eventName) { }

	// RVA: 0x217B110 Offset: 0x217B211 VA: 0x217B110
	public bool FieldBgm_IsSpecialBattleBgmExist(string eventName) { }

	// RVA: 0x217B120 Offset: 0x217B221 VA: 0x217B120
	private void Update() { }

	// RVA: 0x217B190 Offset: 0x217B291 VA: 0x217B190
	private void UpdateListenerPosition() { }

	// RVA: 0x217C400 Offset: 0x217C501 VA: 0x217C400
	private void UpdateMasterVolume() { }

	// RVA: 0x217C790 Offset: 0x217C891 VA: 0x217C790
	private void UpdateConfigVolume() { }

	// RVA: 0x217CB90 Offset: 0x217CC91 VA: 0x217CB90
	private void UpdateMapCameraHeight() { }

	// RVA: 0x217CF10 Offset: 0x217D011 VA: 0x217CF10
	private void UpdateSoundHandleList() { }

	// RVA: 0x217CE50 Offset: 0x217CF51 VA: 0x217CE50
	private void UpdateOutputDevice() { }

	// RVA: 0x2176DB0 Offset: 0x2176EB1 VA: 0x2176DB0
	private void SetGlobalEnumParamByOutputDevice(AudioDevice.AudioDeviceName deviceIndex) { }

	// RVA: 0x217CCF0 Offset: 0x217CDF1 VA: 0x217CCF0
	private void MeasureBusVolume() { }

	// RVA: 0x217D440 Offset: 0x217D541 VA: 0x217D440
	private bool IsInBmapSequence() { }

	// RVA: 0x217D1C0 Offset: 0x217D2C1 VA: 0x217D1C0
	private bool IsInUnitDetailOrClassChange() { }

	// RVA: 0x217D300 Offset: 0x217D401 VA: 0x217D300
	private bool IsInCombat() { }

	// RVA: 0x217D4C0 Offset: 0x217D5C1 VA: 0x217D4C0
	public void LoadLipSyncDataAsync(string lipSyncDataFileName) { }

	// RVA: 0x217D5A0 Offset: 0x217D6A1 VA: 0x217D5A0
	public void UnloadLipSyncData(string lipSyncDataFileName) { }

	// RVA: 0x217D650 Offset: 0x217D751 VA: 0x217D650
	public void UnloadLipSyncDataAll() { }

	// RVA: 0x217D790 Offset: 0x217D891 VA: 0x217D790
	public SoundSystem.LipSyncData GetLipSyncData(string eventName) { }
}

