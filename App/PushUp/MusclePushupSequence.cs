// Namespace: App.PushUp
public class MusclePushupSequence : ProcInst // TypeDefIndex: 14199
{
	// Fields
	private const string ObjectRootPath = "Hub/Prefabs/MuscleExercise/";
	private const string cUIRootPath = "UI/Hub/MuscleExercises/Prefabs/";
	private const string cUIWindow = "Push-UpsRoot";
	private const string cUIResult = "ResultRoot";
	private const string cUICirclePerfect = "Circle_Perfect";
	private const string cUICircleGood = "Circle_Good";
	private const string cUIPopupAssist = "Popup_Assist";
	private const string cTelopRootPath = "UI/Hub/Telop/MiniGame/Prefabs/";
	private const string cTelopCountDown = "StartCountdown";
	private const string cTelopFinish = "Finish";
	private const string cTelopStop = "Stop";
	private const string cEffectRootPath = "Effects/Field/Hub/MuscleExercises/Prefabs/";
	private const string cEffectAssist = "Eff_AssistGlitter_00";
	private const string cEffectEraseBad = "Eff_BadGlitter_00";
	private string[] cLoadObjectList; // 0x70
	private const float cBarTop = 290;
	private float cAreaDisplayRadiusAdd; // 0x78
	private const float cBarBottom = -290;
	private const float cAnimeRoopFrame = 2.15;
	private Vector3 cPlayerPos; // 0x7C
	private const float cPlayerRotY = 45;
	private Vector3 cAssistPos; // 0x88
	private const float cAssistRotY = 8.0702;
	private const float cCountDownFrame = 244;
	private const float cFinishFrame = 1.3;
	private const float cResultMinimumSec = 2.4;
	[CompilerGeneratedAttribute] // RVA: 0x29DCB0 Offset: 0x29DDB1 VA: 0x29DCB0
	private int <SelectLevel>k__BackingField; // 0x94
	[CompilerGeneratedAttribute] // RVA: 0x29DCC0 Offset: 0x29DDC1 VA: 0x29DCC0
	private int <AssistLevel>k__BackingField; // 0x98
	private GameObject m_Window; // 0xA0
	private GameObject m_BarObj; // 0xA8
	private RectTransform m_BarTrans; // 0xB0
	private Image m_BarImage; // 0xB8
	private float m_AreaG_Center; // 0xC0
	private float m_AreaG_Radius; // 0xC4
	private float m_AreaP_Center; // 0xC8
	private float m_AreaP_Radius; // 0xCC
	private GameObject m_AButton; // 0xD0
	private Animator m_AButtonAnime; // 0xD8
	private RectTransform m_AreaPTrans; // 0xE0
	private RectTransform m_AreaGTrans; // 0xE8
	private GameObject m_ResultWindow; // 0xF0
	private GameObject m_PopUpPerfect; // 0xF8
	private GameObject m_PopUpGood; // 0x100
	private GameObject m_PopUpBad; // 0x108
	private GameObject m_PopUpAssist; // 0x110
	private RectTransform m_PopUpAssistRectTrans; // 0x118
	private GameObject m_AssistGlitter; // 0x120
	private GameObject m_SpeedUpTelop; // 0x128
	private Animator m_SpeedUpAnime; // 0x130
	private float m_SpeedUpAnimeTimer; // 0x138
	private GameObject m_CurrentPopUp; // 0x140
	private float m_PopupTimer; // 0x148
	private float m_PopupAssistTimer; // 0x14C
	private GameObject m_PlayerRoot; // 0x150
	private GameObject m_ExerciseChara; // 0x158
	private Animator m_PlayerAnimator; // 0x160
	private Vector3 m_PlayerResetPos; // 0x168
	private Quaternion m_PlayerResetRot; // 0x174
	private float m_PlayerResetDir; // 0x184
	private float m_AnimeFrame; // 0x188
	private float m_NormalizedTime; // 0x18C
	private bool m_IsReadyPlayerModel; // 0x190
	private bool m_IsClear; // 0x191
	[CompilerGeneratedAttribute] // RVA: 0x29DCD0 Offset: 0x29DDD1 VA: 0x29DCD0
	private bool <IsAnimeContinue>k__BackingField; // 0x192
	private const int CameraAnimeCountMax = 3;
	private Camera m_UseCamera; // 0x198
	private Animation m_CameraAnime; // 0x1A0
	private int m_UseCameraAnimeIndex; // 0x1A8
	private ResourceHandle[] m_CameraAnimeResouce; // 0x1B0
	private List<GameObject> m_CameraResourceObjList; // 0x1B8
	private Transform m_Talker; // 0x1C0
	private Character m_TalkChara; // 0x1C8
	private GameSound.Handle m_VoiceHandle; // 0x1D0
	private float m_VoiceIntervalTimer; // 0x1D8
	private const float VoiceIntervalSec = 2;
	private Character m_Sola; // 0x1E0
	private Animator m_SolaAnime; // 0x1E8
	private bool m_SolaReaction; // 0x1F0
	private int m_AssistMax; // 0x1F4
	private int m_AssistCount; // 0x1F8
	private bool m_IsReadyAssistModel; // 0x1FC
	private GameObject m_HubSolaLct; // 0x200
	private bool m_IsSetSolaInvisible; // 0x208
	private float m_CountTimer; // 0x20C
	private GameObject m_CountTelop; // 0x210
	private GameObject m_StopTelop; // 0x218
	private TextMeshProUGUI m_CountText; // 0x220
	private int m_PastCount; // 0x228
	private TextMeshProUGUI m_PerfectText; // 0x230
	private TextMeshProUGUI m_GoodText; // 0x238
	private GameObject m_BadBase; // 0x240
	private Animator[] m_BadAnime; // 0x248
	private int m_GoodScore; // 0x250
	private int m_PerfectScore; // 0x254
	private int m_TargetScore; // 0x258
	private int m_LimitCount; // 0x25C
	private int m_BadCount; // 0x260
	private int m_PerfectCount; // 0x264
	private int m_GoodCount; // 0x268
	private List<MusclePushUpSpeedData> m_SpeedList; // 0x270
	private int m_UseSpeedCount; // 0x278
	private int m_SpeedLevelUpCount; // 0x27C
	[CompilerGeneratedAttribute] // RVA: 0x29DCE0 Offset: 0x29DDE1 VA: 0x29DCE0
	private bool <IsReachTop>k__BackingField; // 0x280
	[CompilerGeneratedAttribute] // RVA: 0x29DCF0 Offset: 0x29DDF1 VA: 0x29DCF0
	private bool <IsCountPoint>k__BackingField; // 0x281
	[CompilerGeneratedAttribute] // RVA: 0x29DD00 Offset: 0x29DE01 VA: 0x29DD00
	private bool <IsWaitRestart>k__BackingField; // 0x282
	private float m_BarPosY; // 0x284
	private float m_BaseSpeed; // 0x288
	private float m_AnimSpeedMult; // 0x28C
	private InterpolatorFloat m_AheadSpeed; // 0x290
	private InterpolatorFloat m_ComebackSpeed; // 0x298
	private float m_RoopSec; // 0x2A0
	private bool m_IsButtonBlink; // 0x2A4
	private string m_RankStr; // 0x2A8
	private string m_RankBonus; // 0x2B0
	private int m_RankBond; // 0x2B8
	private float m_ResultTimer; // 0x2BC

	// Properties
	public int SelectLevel { get; set; }
	public int AssistLevel { get; set; }
	private bool IsAssist { get; }
	private bool IsAnimeContinue { get; set; }
	private bool IsReachTop { get; set; }
	private bool IsCountPoint { get; set; }
	private bool IsWaitRestart { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CE1D0 Offset: 0x2CE2D1 VA: 0x2CE1D0
	// RVA: 0x2287CA0 Offset: 0x2287DA1 VA: 0x2287CA0
	public int get_SelectLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE1E0 Offset: 0x2CE2E1 VA: 0x2CE1E0
	// RVA: 0x2287CB0 Offset: 0x2287DB1 VA: 0x2287CB0
	public void set_SelectLevel(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE1F0 Offset: 0x2CE2F1 VA: 0x2CE1F0
	// RVA: 0x2287CC0 Offset: 0x2287DC1 VA: 0x2287CC0
	public int get_AssistLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE200 Offset: 0x2CE301 VA: 0x2CE200
	// RVA: 0x2287CD0 Offset: 0x2287DD1 VA: 0x2287CD0
	public void set_AssistLevel(int value) { }

	// RVA: 0x2287CE0 Offset: 0x2287DE1 VA: 0x2287CE0
	private bool get_IsAssist() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE210 Offset: 0x2CE311 VA: 0x2CE210
	// RVA: 0x2287CF0 Offset: 0x2287DF1 VA: 0x2287CF0
	private bool get_IsAnimeContinue() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE220 Offset: 0x2CE321 VA: 0x2CE220
	// RVA: 0x2287D00 Offset: 0x2287E01 VA: 0x2287D00
	private void set_IsAnimeContinue(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE230 Offset: 0x2CE331 VA: 0x2CE230
	// RVA: 0x2287D10 Offset: 0x2287E11 VA: 0x2287D10
	private bool get_IsReachTop() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE240 Offset: 0x2CE341 VA: 0x2CE240
	// RVA: 0x2287D20 Offset: 0x2287E21 VA: 0x2287D20
	private void set_IsReachTop(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE250 Offset: 0x2CE351 VA: 0x2CE250
	// RVA: 0x2287D30 Offset: 0x2287E31 VA: 0x2287D30
	private bool get_IsCountPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE260 Offset: 0x2CE361 VA: 0x2CE260
	// RVA: 0x2287D40 Offset: 0x2287E41 VA: 0x2287D40
	private void set_IsCountPoint(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE270 Offset: 0x2CE371 VA: 0x2CE270
	// RVA: 0x2287D50 Offset: 0x2287E51 VA: 0x2287D50
	private bool get_IsWaitRestart() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE280 Offset: 0x2CE381 VA: 0x2CE280
	// RVA: 0x2287D60 Offset: 0x2287E61 VA: 0x2287D60
	private void set_IsWaitRestart(bool value) { }

	// RVA: 0x2287D70 Offset: 0x2287E71 VA: 0x2287D70
	public void .ctor() { }

	// RVA: -1 Offset: -1
	private static void CheckAndLoadResource<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2966F60 Offset: 0x2967061 VA: 0x2966F60
	|-MusclePushupSequence.CheckAndLoadResource<GameObject>
	|-MusclePushupSequence.CheckAndLoadResource<object>
	*/

	// RVA: 0x2288360 Offset: 0x2288461 VA: 0x2288360
	private void LoadResources() { }

	// RVA: 0x2288400 Offset: 0x2288501 VA: 0x2288400
	private bool IsLoading() { }

	// RVA: 0x22884D0 Offset: 0x22885D1 VA: 0x22884D0
	private void CalcRoopSec() { }

	// RVA: 0x22885C0 Offset: 0x22886C1 VA: 0x22885C0
	private void Init() { }

	// RVA: 0x228A370 Offset: 0x228A471 VA: 0x228A370
	private void SetupCamera() { }

	// RVA: 0x228A820 Offset: 0x228A921 VA: 0x228A820
	private bool IsLoadingCamera() { }

	// RVA: 0x228A8B0 Offset: 0x228A9B1 VA: 0x228A8B0
	private void FinalizeCamera() { }

	// RVA: 0x228AA80 Offset: 0x228AB81 VA: 0x228AA80
	private bool IsReadyModel() { }

	// RVA: 0x228AAC0 Offset: 0x228ABC1 VA: 0x228AAC0
	private void AddBadCount() { }

	// RVA: 0x228AB50 Offset: 0x228AC51 VA: 0x228AB50
	private void InitCountDown() { }

	// RVA: 0x228AD50 Offset: 0x228AE51 VA: 0x228AD50
	private void TickCount() { }

	// RVA: 0x228AE00 Offset: 0x228AF01 VA: 0x228AE00
	private void JumpMain() { }

	// RVA: 0x228AF20 Offset: 0x228B021 VA: 0x228AF20
	private bool CheckClear() { }

	// RVA: 0x228AF40 Offset: 0x228B041 VA: 0x228AF40
	private bool CheckStop() { }

	// RVA: 0x228AF50 Offset: 0x228B051 VA: 0x228AF50
	private void JumpReadyFinish(bool isClear) { }

	// RVA: 0x228B080 Offset: 0x228B181 VA: 0x228B080
	private void JumpFinish() { }

	// RVA: 0x228B4E0 Offset: 0x228B5E1 VA: 0x228B4E0
	private float GetRate() { }

	// RVA: 0x228B500 Offset: 0x228B601 VA: 0x228B500
	private void StartPopUp(MusclePushupSequence.judgeRank setRank) { }

	// RVA: 0x228B8B0 Offset: 0x228B9B1 VA: 0x228B8B0
	private void TickPopup() { }

	// RVA: 0x228BB10 Offset: 0x228BC11 VA: 0x228BB10
	private void TickSpeedUpTelop() { }

	// RVA: 0x228BBC0 Offset: 0x228BCC1 VA: 0x228BBC0
	private void PopUpPerfect() { }

	// RVA: 0x228BBD0 Offset: 0x228BCD1 VA: 0x228BBD0
	private void PopUpGood() { }

	// RVA: 0x228BBE0 Offset: 0x228BCE1 VA: 0x228BBE0
	private void PopUpBad() { }

	// RVA: 0x228BBF0 Offset: 0x228BCF1 VA: 0x228BBF0
	private void PopUpAssist() { }

	// RVA: 0x228BC00 Offset: 0x228BD01 VA: 0x228BC00
	private void AddCirclePerfect() { }

	// RVA: 0x228BD20 Offset: 0x228BE21 VA: 0x228BD20
	private void AddCircleGood() { }

	// RVA: 0x228BE40 Offset: 0x228BF41 VA: 0x228BE40
	private void AddPerfectCount() { }

	// RVA: 0x228BEE0 Offset: 0x228BFE1 VA: 0x228BEE0
	private void AddGoodCount() { }

	// RVA: 0x228BF80 Offset: 0x228C081 VA: 0x228BF80
	private void PlaySEPerfect() { }

	// RVA: 0x228C000 Offset: 0x228C101 VA: 0x228C000
	private void PlaySEGood() { }

	// RVA: 0x228C080 Offset: 0x228C181 VA: 0x228C080
	private void PlaySEBad() { }

	// RVA: 0x228C100 Offset: 0x228C201 VA: 0x228C100
	private void PlaySEStart() { }

	// RVA: 0x228B430 Offset: 0x228B531 VA: 0x228B430
	private void PlaySEFinish() { }

	// RVA: 0x228C180 Offset: 0x228C281 VA: 0x228C180
	private void PlaySolaAnimeGood() { }

	// RVA: 0x228C200 Offset: 0x228C301 VA: 0x228C200
	private void PlaySolaAnimeBad() { }

	// RVA: 0x228C280 Offset: 0x228C381 VA: 0x228C280
	private void PlaySolaAnimeAssist() { }

	// RVA: 0x228C300 Offset: 0x228C401 VA: 0x228C300
	private void ResetBar() { }

	// RVA: 0x228C5C0 Offset: 0x228C6C1 VA: 0x228C5C0
	private void TickCamera() { }

	// RVA: 0x228C6E0 Offset: 0x228C7E1 VA: 0x228C6E0
	private void TickMain() { }

	// RVA: 0x228D630 Offset: 0x228D731 VA: 0x228D630
	private void TickReadyFinish() { }

	// RVA: 0x228D6D0 Offset: 0x228D7D1 VA: 0x228D6D0
	private void TickFinish() { }

	// RVA: 0x228D770 Offset: 0x228D871 VA: 0x228D770
	private void CalcRank() { }

	// RVA: 0x228DB10 Offset: 0x228DC11 VA: 0x228DB10
	private void ReadyResultCameraAndAnime() { }

	// RVA: 0x228DCF0 Offset: 0x228DDF1 VA: 0x228DCF0
	private void InitResult() { }

	// RVA: 0x228EEC0 Offset: 0x228EFC1 VA: 0x228EEC0
	private void PlayResultVoice() { }

	// RVA: 0x228F270 Offset: 0x228F371 VA: 0x228F270
	private void TickResult() { }

	// RVA: 0x228F4B0 Offset: 0x228F5B1 VA: 0x228F4B0
	private void CloseResult() { }

	// RVA: 0x228F5B0 Offset: 0x228F6B1 VA: 0x228F5B0
	public bool IsClosedResult() { }

	// RVA: 0x228F6B0 Offset: 0x228F7B1 VA: 0x228F6B0
	private void ExitResult() { }

	// RVA: 0x228F720 Offset: 0x228F821 VA: 0x228F720
	private bool CheckGetablePrize() { }

	// RVA: 0x228F840 Offset: 0x228F941 VA: 0x228F840
	private void SetPrizeFlag() { }

	// RVA: 0x228FA10 Offset: 0x228FB11 VA: 0x228FA10
	private void GetPrizeBonus() { }

	// RVA: 0x228FD10 Offset: 0x228FE11 VA: 0x228FD10
	private void GetPrizeBond() { }

	// RVA: 0x228FEF0 Offset: 0x228FFF1 VA: 0x228FEF0
	private void SetMascotBond() { }

	// RVA: 0x228FF80 Offset: 0x2290081 VA: 0x228FF80
	private void UnloadResource() { }

	// RVA: 0x2290050 Offset: 0x2290151 VA: 0x2290050
	private void Final() { }

	// RVA: 0x2290300 Offset: 0x2290401 VA: 0x2290300
	private bool IsEnableVoice() { }

	// RVA: 0x228D4F0 Offset: 0x228D5F1 VA: 0x228D4F0
	private bool IsPlayingVoice() { }

	// RVA: 0x2290310 Offset: 0x2290411 VA: 0x2290310
	private void TryPlayVoice(string id) { }

	// RVA: 0x228D510 Offset: 0x228D611 VA: 0x228D510
	private void VoicePerfect() { }

	// RVA: 0x228D570 Offset: 0x228D671 VA: 0x228D570
	private void VoiceGood() { }

	// RVA: 0x228D5D0 Offset: 0x228D6D1 VA: 0x228D5D0
	private void VoiceBad() { }

	// RVA: 0x228F150 Offset: 0x228F251 VA: 0x228F150
	private void VoiceResultPerfect() { }

	// RVA: 0x228F1B0 Offset: 0x228F2B1 VA: 0x228F1B0
	private void VoiceResultGood() { }

	// RVA: 0x228F210 Offset: 0x228F311 VA: 0x228F210
	private void VoiceResultBad() { }

	// RVA: 0x22840A0 Offset: 0x22841A1 VA: 0x22840A0
	public static void CreateBind(ProcInst super, int level, bool assist) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE290 Offset: 0x2CE391 VA: 0x2CE290
	// RVA: 0x228A280 Offset: 0x228A381 VA: 0x228A280
	internal static Character <Init>g__CreateSola|143_1(CharacterAppearance app, Transform parent, bool invisible) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE2A0 Offset: 0x2CE3A1 VA: 0x2CE2A0
	// RVA: 0x22903F0 Offset: 0x22904F1 VA: 0x22903F0
	private void <SetupCamera>b__144_0(GameObject prefab) { }
}

