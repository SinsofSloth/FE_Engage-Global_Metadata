// Namespace: App.Talk3D
public class TalkSequence : SingletonProcInst<TalkSequence> // TypeDefIndex: 14138
{
	// Fields
	private static bool sm_IsContinue; // 0x0
	private static GameObject sm_ReservedPrefabRootObject; // 0x8
	private GameObject m_PrefabRootObject; // 0x78
	private TalkSound m_TalkSound; // 0x80
	private TalkTagParser m_TagParser; // 0x88
	private TalkPtr m_TalkPtr; // 0x90
	private TalkTag m_ReservedTag; // 0x98
	private TalkSequence.ReplaceText m_ReplaceText; // 0xA0
	private ProcInst m_BindProc; // 0xA8
	private TalkBuilder m_ErrorMessageBuilder; // 0xB0
	private bool m_IsStartByContinuousNumber; // 0xB8
	private bool m_IsFlushedSoundList; // 0xB9
	private bool m_IsShowMapTerrainInfo; // 0xBA
	private bool m_IsBindMapCamera; // 0xBB
	private bool m_IsPushedUnitInfo; // 0xBC
	private List<string> m_LoadedSoundBankNameList; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x29DAA0 Offset: 0x29DBA1 VA: 0x29DAA0
	private string <Mid>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x29DAB0 Offset: 0x29DBB1 VA: 0x29DAB0
	private Talk.TalkType <TalkType>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x29DAC0 Offset: 0x29DBC1 VA: 0x29DAC0
	private string <ActivePid>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x29DAD0 Offset: 0x29DBD1 VA: 0x29DAD0
	private bool <StrToLowerTrigger>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x29DAE0 Offset: 0x29DBE1 VA: 0x29DAE0
	private bool <IsLatestStrPatchim1>k__BackingField; // 0xE1
	[CompilerGeneratedAttribute] // RVA: 0x29DAF0 Offset: 0x29DBF1 VA: 0x29DAF0
	private bool <IsLatestStrPatchim2>k__BackingField; // 0xE2
	public bool m_IsLoadingCharacter; // 0xE3
	private const float LoadingCharacterTimeoutCounterMax = 5;
	private float m_LoadingCharacterTimeoutCounter; // 0xE4
	private Dictionary<string, string> m_ReplaceTalkerNameDictionary; // 0xE8

	// Properties
	public string Mid { get; set; }
	public Talk.TalkType TalkType { get; set; }
	public string ActivePid { get; set; }
	public bool StrToLowerTrigger { get; set; }
	public bool IsLatestStrPatchim1 { get; set; }
	public bool IsLatestStrPatchim2 { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CDE00 Offset: 0x2CDF01 VA: 0x2CDE00
	// RVA: 0x2C303C0 Offset: 0x2C304C1 VA: 0x2C303C0
	public string get_Mid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDE10 Offset: 0x2CDF11 VA: 0x2CDE10
	// RVA: 0x2C303D0 Offset: 0x2C304D1 VA: 0x2C303D0
	public void set_Mid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDE20 Offset: 0x2CDF21 VA: 0x2CDE20
	// RVA: 0x2C303E0 Offset: 0x2C304E1 VA: 0x2C303E0
	public Talk.TalkType get_TalkType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDE30 Offset: 0x2CDF31 VA: 0x2CDE30
	// RVA: 0x2C303F0 Offset: 0x2C304F1 VA: 0x2C303F0
	public void set_TalkType(Talk.TalkType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDE40 Offset: 0x2CDF41 VA: 0x2CDE40
	// RVA: 0x2C30400 Offset: 0x2C30501 VA: 0x2C30400
	public string get_ActivePid() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDE50 Offset: 0x2CDF51 VA: 0x2CDE50
	// RVA: 0x2C30410 Offset: 0x2C30511 VA: 0x2C30410
	public void set_ActivePid(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDE60 Offset: 0x2CDF61 VA: 0x2CDE60
	// RVA: 0x2C30420 Offset: 0x2C30521 VA: 0x2C30420
	public bool get_StrToLowerTrigger() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDE70 Offset: 0x2CDF71 VA: 0x2CDE70
	// RVA: 0x2C30430 Offset: 0x2C30531 VA: 0x2C30430
	public void set_StrToLowerTrigger(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDE80 Offset: 0x2CDF81 VA: 0x2CDE80
	// RVA: 0x2C30440 Offset: 0x2C30541 VA: 0x2C30440
	public bool get_IsLatestStrPatchim1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDE90 Offset: 0x2CDF91 VA: 0x2CDE90
	// RVA: 0x2C30450 Offset: 0x2C30551 VA: 0x2C30450
	public void set_IsLatestStrPatchim1(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDEA0 Offset: 0x2CDFA1 VA: 0x2CDEA0
	// RVA: 0x2C30460 Offset: 0x2C30561 VA: 0x2C30460
	public bool get_IsLatestStrPatchim2() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDEB0 Offset: 0x2CDFB1 VA: 0x2CDEB0
	// RVA: 0x2C30470 Offset: 0x2C30571 VA: 0x2C30470
	public void set_IsLatestStrPatchim2(bool value) { }

	// RVA: 0x2C26E30 Offset: 0x2C26F31 VA: 0x2C26E30
	public void EnableIsLoadingCharacter() { }

	// RVA: 0x2C30480 Offset: 0x2C30581 VA: 0x2C30480
	public void DisableIsLoadingCharacter() { }

	// RVA: 0x2C30490 Offset: 0x2C30591 VA: 0x2C30490
	public string GetReplaceTalkerName(string pid) { }

	// RVA: 0x2C30510 Offset: 0x2C30611 VA: 0x2C30510
	public void AddReplaceTalkerName(string pid, string talkerName) { }

	// RVA: 0x2C305E0 Offset: 0x2C306E1 VA: 0x2C305E0
	public static void ReserveTalkPrefab() { }

	// RVA: 0x2C30720 Offset: 0x2C30821 VA: 0x2C30720
	public static GameObject CreateTalkPrefab() { }

	// RVA: 0x2C30860 Offset: 0x2C30961 VA: 0x2C30860
	public static bool IsFastForward() { }

	// RVA: 0x2C309B0 Offset: 0x2C30AB1 VA: 0x2C309B0
	public void Start(string mid, bool isContinuousNumber) { }

	// RVA: 0x2C30C70 Offset: 0x2C30D71 VA: 0x2C30C70
	public void Restart(string mid, bool isContinuousNumber) { }

	// RVA: 0x2C309C0 Offset: 0x2C30AC1 VA: 0x2C309C0
	public void StartImpl(string mid, bool isContinuousNumber) { }

	// RVA: 0x2C30DB0 Offset: 0x2C30EB1 VA: 0x2C30DB0
	private void InitTalk(string mid) { }

	// RVA: 0x2C31840 Offset: 0x2C31941 VA: 0x2C31840
	private void TryNextLabel() { }

	// RVA: 0x2C31210 Offset: 0x2C31311 VA: 0x2C31210
	private void FlushSoundList(bool isExecBeforeOfNowLabel) { }

	// RVA: 0x2C31B50 Offset: 0x2C31C51 VA: 0x2C31B50
	private void WaitCamera() { }

	// RVA: 0x2C31B90 Offset: 0x2C31C91 VA: 0x2C31B90
	private void TryMapCameraBind() { }

	// RVA: 0x2C31C30 Offset: 0x2C31D31 VA: 0x2C31C30
	private void TryMapCameraUnbind() { }

	// RVA: 0x2C31CC0 Offset: 0x2C31DC1 VA: 0x2C31CC0
	private void LoadSoundBank() { }

	// RVA: 0x2C31EE0 Offset: 0x2C31FE1 VA: 0x2C31EE0
	private void WaitSoundbankLoading() { }

	// RVA: 0x2C31F80 Offset: 0x2C32081 VA: 0x2C31F80
	private void LoadScene() { }

	// RVA: 0x2C31A50 Offset: 0x2C31B51 VA: 0x2C31A50
	private void Finish(bool isEndContinuousNumber) { }

	// RVA: 0x2C322F0 Offset: 0x2C323F1 VA: 0x2C322F0
	private void Release() { }

	// RVA: 0x2C32580 Offset: 0x2C32681 VA: 0x2C32580
	public Character GetActiveCharacter() { }

	// RVA: 0x2C29A00 Offset: 0x2C29B01 VA: 0x2C29A00
	public string GetPersonVoice() { }

	// RVA: 0x2C32890 Offset: 0x2C32991 VA: 0x2C32890
	public void TryPlayVoice(Character character) { }

	// RVA: 0x2C2A3F0 Offset: 0x2C2A4F1 VA: 0x2C2A3F0
	public void StopAllVoice() { }

	// RVA: 0x2C32A70 Offset: 0x2C32B71 VA: 0x2C32A70
	private void Persistent() { }

	// RVA: 0x2C32A80 Offset: 0x2C32B81 VA: 0x2C32A80
	private void TickSoundBefore() { }

	// RVA: 0x2C32AC0 Offset: 0x2C32BC1 VA: 0x2C32AC0
	private void TickSoundAfter() { }

	// RVA: 0x2C32B50 Offset: 0x2C32C51 VA: 0x2C32B50
	private void Tick() { }

	// RVA: 0x2C33010 Offset: 0x2C33111 VA: 0x2C33010
	private void ProcessMessage(int addCharCount) { }

	// RVA: 0x2C332E0 Offset: 0x2C333E1 VA: 0x2C332E0
	private void Close() { }

	// RVA: 0x2C33490 Offset: 0x2C33591 VA: 0x2C33490
	private void WaitClose() { }

	// RVA: 0x2C33560 Offset: 0x2C33661 VA: 0x2C33560
	private void CheckContinue() { }

	// RVA: 0x2C336A0 Offset: 0x2C337A1 VA: 0x2C336A0
	public static void BeginContinueTalk() { }

	// RVA: 0x2C33710 Offset: 0x2C33811 VA: 0x2C33710
	public static void EndContinueTalk() { }

	// RVA: 0x2C33780 Offset: 0x2C33881 VA: 0x2C33780
	public void StartKeyWait() { }

	// RVA: 0x2C33790 Offset: 0x2C33891 VA: 0x2C33790
	public void StartTimeWait(float sec) { }

	// RVA: 0x2C337A0 Offset: 0x2C338A1 VA: 0x2C337A0
	public void StartFadeOut(float time, Color color) { }

	// RVA: 0x2C33870 Offset: 0x2C33971 VA: 0x2C33870
	public void StartFadeIn(float time) { }

	// RVA: 0x2C33910 Offset: 0x2C33A11 VA: 0x2C33910
	public void SetReplaceText(string text) { }

	// RVA: 0x2C33920 Offset: 0x2C33A21 VA: 0x2C33920
	private void WaitGameSkipEnd() { }

	// RVA: 0x2C33960 Offset: 0x2C33A61 VA: 0x2C33960
	private void Skip() { }

	// RVA: 0x2C33A50 Offset: 0x2C33B51 VA: 0x2C33A50
	public void StartTextScroll() { }

	// RVA: 0x2C2F1F0 Offset: 0x2C2F2F1 VA: 0x2C2F1F0
	public void EndTextScroll() { }

	// RVA: 0x2C31690 Offset: 0x2C31791 VA: 0x2C31690
	private void BindParent() { }

	// RVA: 0x2C322A0 Offset: 0x2C323A1 VA: 0x2C322A0
	private void UnbindParent() { }

	// RVA: 0x2C33A80 Offset: 0x2C33B81 VA: 0x2C33A80
	private ProcDesc[] GetDesc() { }

	// RVA: 0x2C34610 Offset: 0x2C34711 VA: 0x2C34610
	public static TalkSequence Create(ProcInst parent) { }

	// RVA: 0x2C34800 Offset: 0x2C34901 VA: 0x2C34800 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x2C34820 Offset: 0x2C34921 VA: 0x2C34820 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2C349A0 Offset: 0x2C34AA1 VA: 0x2C349A0 Slot: 15
	protected override void OnShutdown() { }

	// RVA: 0x2C34690 Offset: 0x2C34791 VA: 0x2C34690
	public void .ctor() { }

	// RVA: 0x2C34A70 Offset: 0x2C34B71 VA: 0x2C34A70
	private static void .cctor() { }
}

