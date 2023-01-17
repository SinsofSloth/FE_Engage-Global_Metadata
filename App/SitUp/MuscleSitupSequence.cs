// Namespace: App.SitUp
public class MuscleSitupSequence : ProcInst // TypeDefIndex: 14195
{
	// Fields
	private const string ObjectRootPath = "Hub/Prefabs/MuscleExercise/";
	private const string cUIRootPath = "UI/Hub/MuscleExercises/Prefabs/";
	private const string cUIWindow = "AbsRoot";
	private const string cUIResult = "ResultRoot";
	private const string cUIPopUpGood = "Popup_Good";
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
	private const float cBarDownBaseSpeed = -1;
	private const float cBarTopHeight = 285;
	private const float cBarBottomHeight = -285;
	private const float cBarLength = 570;
	private const float cResetReachRate = 32;
	private const float cDangerLineRate = 16;
	private const float cCountDownFrame = 244;
	private const float cFinishFrame = 1.3;
	private const float cResultMinimumSec = 2.4;
	private const float cAnimeRoopFrame = 3;
	private Vector3 cPlayerPos; // 0x78
	private const float cPlayerRotY = 45;
	private Vector3 cAssistPos; // 0x84
	private const float cAssistRotY = 309.0036;
	private string[] PushRateSEs; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x29DC70 Offset: 0x29DD71 VA: 0x29DC70
	private int <SelectLevel>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x29DC80 Offset: 0x29DD81 VA: 0x29DC80
	private int <AssistLevel>k__BackingField; // 0x9C
	private GameObject m_Window; // 0xA0
	private GameObject m_BarObj; // 0xA8
	private RectTransform m_BarTrans; // 0xB0
	private Image m_BarImage; // 0xB8
	private GameObject m_AButton; // 0xC0
	private Animator m_AButtonAnime; // 0xC8
	private GameObject m_DangerArea; // 0xD0
	private Animator m_DangerAreaAnime; // 0xD8
	private GameObject m_PlayerRoot; // 0xE0
	private HubUnitController m_PlayerController; // 0xE8
	private GameObject m_ExerciseChara; // 0xF0
	private Animator m_PlayerAnimator; // 0xF8
	private Vector3 m_PlayerResetPos; // 0x100
	private Quaternion m_PlayerResetRot; // 0x10C
	private float m_PlayerResetDir; // 0x11C
	private float m_AnimeFrame; // 0x120
	private InterpolatorFloat m_AnimeFrameInterp; // 0x128
	private bool m_IsReadyPlayerModel; // 0x130
	private bool m_IsClear; // 0x131
	private const int CameraAnimeCountMax = 3;
	private Camera m_UseCamera; // 0x138
	private Animation m_CameraAnime; // 0x140
	private int m_UseCameraAnimeIndex; // 0x148
	private ResourceHandle[] m_CameraAnimeResouce; // 0x150
	private List<GameObject> m_CameraResourceObjList; // 0x158
	private Transform m_Talker; // 0x160
	private Character m_TalkChara; // 0x168
	private GameSound.Handle m_VoiceHandle; // 0x170
	private float m_VoiceIntervalTimer; // 0x178
	private const float VoiceIntervalSec = 2;
	private Character m_Sola; // 0x180
	private Animator m_SolaAnime; // 0x188
	private bool m_SolaReaction; // 0x190
	private int m_AssistMax; // 0x194
	private int m_AssistCount; // 0x198
	private bool m_IsReadyAssistModel; // 0x19C
	private GameObject m_HubSolaLct; // 0x1A0
	private bool m_IsSetSolaInvisible; // 0x1A8
	private float m_AssistSpeed; // 0x1AC
	private bool m_IsDoingAssist; // 0x1B0
	private float m_CountTimer; // 0x1B4
	private GameObject m_CountTelop; // 0x1B8
	private GameObject m_StopTelop; // 0x1C0
	private TextMeshProUGUI m_CountText; // 0x1C8
	private int m_PastCount; // 0x1D0
	private TextMeshProUGUI m_PerfectText; // 0x1D8
	private TextMeshProUGUI m_GoodText; // 0x1E0
	private GameObject m_BadBase; // 0x1E8
	private Animator m_BadAnime; // 0x1F0
	private int m_BadCount; // 0x1F8
	private int m_PerfectCount; // 0x1FC
	private int m_GoodCount; // 0x200
	[CompilerGeneratedAttribute] // RVA: 0x29DC90 Offset: 0x29DD91 VA: 0x29DC90
	private bool <IsReachTop>k__BackingField; // 0x204
	private float m_BarRate; // 0x208
	private float m_FallSpeed; // 0x20C
	private float m_FallSpeedHigh; // 0x210
	private float m_GainHeight; // 0x214
	private float m_RankTimer; // 0x218
	private float m_DangerTimer; // 0x21C
	[CompilerGeneratedAttribute] // RVA: 0x29DCA0 Offset: 0x29DDA1 VA: 0x29DCA0
	private bool <IsDangerArea>k__BackingField; // 0x220
	private GameObject m_ResultWindow; // 0x228
	private GameObject m_PopUpPerfect; // 0x230
	private GameObject m_PopUpGood; // 0x238
	private GameObject m_PopUpAssist; // 0x240
	private RectTransform m_PopUpAssistRectTrans; // 0x248
	private GameObject m_AssistGlitter; // 0x250
	private GameObject m_CurrentPopUp; // 0x258
	private float m_PopupTimer; // 0x260
	private float m_PopupAssistTimer; // 0x264
	private List<MuscleSitUpFallData> m_SpeedList; // 0x268
	private int m_UseSpeedNum; // 0x270
	private float m_PerfectLimit; // 0x274
	private int m_GoodScore; // 0x278
	private int m_PerfectScore; // 0x27C
	private int m_TargetScore; // 0x280
	private int m_EndlessLimitCount; // 0x284
	private string m_RankStr; // 0x288
	private string m_RankBonus; // 0x290
	private int m_RankBond; // 0x298
	private float m_ResultTimer; // 0x29C

	// Properties
	public int SelectLevel { get; set; }
	public int AssistLevel { get; set; }
	private bool IsAssist { get; }
	private bool IsReachTop { get; set; }
	private bool IsDangerArea { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CE130 Offset: 0x2CE231 VA: 0x2CE130
	// RVA: 0x30A3D80 Offset: 0x30A3E81 VA: 0x30A3D80
	public int get_SelectLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE140 Offset: 0x2CE241 VA: 0x2CE140
	// RVA: 0x30A3D90 Offset: 0x30A3E91 VA: 0x30A3D90
	public void set_SelectLevel(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE150 Offset: 0x2CE251 VA: 0x2CE150
	// RVA: 0x30A3DA0 Offset: 0x30A3EA1 VA: 0x30A3DA0
	public int get_AssistLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE160 Offset: 0x2CE261 VA: 0x2CE160
	// RVA: 0x30A3DB0 Offset: 0x30A3EB1 VA: 0x30A3DB0
	public void set_AssistLevel(int value) { }

	// RVA: 0x30A3DC0 Offset: 0x30A3EC1 VA: 0x30A3DC0
	private bool get_IsAssist() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE170 Offset: 0x2CE271 VA: 0x2CE170
	// RVA: 0x30A3DD0 Offset: 0x30A3ED1 VA: 0x30A3DD0
	private bool get_IsReachTop() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE180 Offset: 0x2CE281 VA: 0x2CE180
	// RVA: 0x30A3DE0 Offset: 0x30A3EE1 VA: 0x30A3DE0
	private void set_IsReachTop(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE190 Offset: 0x2CE291 VA: 0x2CE190
	// RVA: 0x30A3DF0 Offset: 0x30A3EF1 VA: 0x30A3DF0
	private bool get_IsDangerArea() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE1A0 Offset: 0x2CE2A1 VA: 0x2CE1A0
	// RVA: 0x30A3E00 Offset: 0x30A3F01 VA: 0x30A3E00
	private void set_IsDangerArea(bool value) { }

	// RVA: 0x30A3E10 Offset: 0x30A3F11 VA: 0x30A3E10
	public void .ctor() { }

	// RVA: -1 Offset: -1
	private static void CheckAndLoadResource<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2966FE0 Offset: 0x29670E1 VA: 0x2966FE0
	|-MuscleSitupSequence.CheckAndLoadResource<GameObject>
	|-MuscleSitupSequence.CheckAndLoadResource<object>
	*/

	// RVA: 0x30A47E0 Offset: 0x30A48E1 VA: 0x30A47E0
	private void LoadResources() { }

	// RVA: 0x30A4880 Offset: 0x30A4981 VA: 0x30A4880
	private bool IsLoading() { }

	// RVA: 0x30A4950 Offset: 0x30A4A51 VA: 0x30A4950
	private void Init() { }

	// RVA: 0x30A6030 Offset: 0x30A6131 VA: 0x30A6030
	private bool IsReadyModel() { }

	// RVA: 0x30A6070 Offset: 0x30A6171 VA: 0x30A6070
	private void SetupCamera() { }

	// RVA: 0x30A6530 Offset: 0x30A6631 VA: 0x30A6530
	private bool IsLoadingCamera() { }

	// RVA: 0x30A65C0 Offset: 0x30A66C1 VA: 0x30A65C0
	private void FinalizeCamera() { }

	// RVA: 0x30A6790 Offset: 0x30A6891 VA: 0x30A6790
	private float GetAnimeRate() { }

	// RVA: 0x30A67C0 Offset: 0x30A68C1 VA: 0x30A67C0
	private void InitCountDown() { }

	// RVA: 0x30A69C0 Offset: 0x30A6AC1 VA: 0x30A69C0
	private void TickCount() { }

	// RVA: 0x30A6A70 Offset: 0x30A6B71 VA: 0x30A6A70
	private void JumpMain() { }

	// RVA: 0x30A6BA0 Offset: 0x30A6CA1 VA: 0x30A6BA0
	private bool CheckClear() { }

	// RVA: 0x30A6BC0 Offset: 0x30A6CC1 VA: 0x30A6BC0
	private bool CheckStop() { }

	// RVA: 0x30A6BD0 Offset: 0x30A6CD1 VA: 0x30A6BD0
	private void JumpReadyFinish(bool isClear) { }

	// RVA: 0x30A6D40 Offset: 0x30A6E41 VA: 0x30A6D40
	private void JumpFinish() { }

	// RVA: 0x30A71D0 Offset: 0x30A72D1 VA: 0x30A71D0
	private void StartPopUp(MuscleSitupSequence.judgeRank setRank) { }

	// RVA: 0x30A75A0 Offset: 0x30A76A1 VA: 0x30A75A0
	private void TickPopup() { }

	// RVA: 0x30A7800 Offset: 0x30A7901 VA: 0x30A7800
	private void PopUpPerfect() { }

	// RVA: 0x30A7810 Offset: 0x30A7911 VA: 0x30A7810
	private void PopUpGood() { }

	// RVA: 0x30A7820 Offset: 0x30A7921 VA: 0x30A7820
	private void PopUpAssist() { }

	// RVA: 0x30A7830 Offset: 0x30A7931 VA: 0x30A7830
	private void AddCirclePerfect() { }

	// RVA: 0x30A7950 Offset: 0x30A7A51 VA: 0x30A7950
	private void AddCircleGood() { }

	// RVA: 0x30A7A70 Offset: 0x30A7B71 VA: 0x30A7A70
	private void AddPerfectCount() { }

	// RVA: 0x30A7B10 Offset: 0x30A7C11 VA: 0x30A7B10
	private void AddGoodCount() { }

	// RVA: 0x30A7BB0 Offset: 0x30A7CB1 VA: 0x30A7BB0
	private void PlaySEPerfect() { }

	// RVA: 0x30A7C30 Offset: 0x30A7D31 VA: 0x30A7C30
	private void PlaySEGood() { }

	// RVA: 0x30A7CB0 Offset: 0x30A7DB1 VA: 0x30A7CB0
	private void PlaySEBad() { }

	// RVA: 0x30A7D30 Offset: 0x30A7E31 VA: 0x30A7D30
	private void PlaySEStart() { }

	// RVA: 0x30A7120 Offset: 0x30A7221 VA: 0x30A7120
	private void PlaySEFinish() { }

	// RVA: 0x30A7DB0 Offset: 0x30A7EB1 VA: 0x30A7DB0
	private void SetReachTop() { }

	// RVA: 0x30A7E70 Offset: 0x30A7F71 VA: 0x30A7E70
	private void ResetReachTop() { }

	// RVA: 0x30A7F20 Offset: 0x30A8021 VA: 0x30A7F20
	private void TickCamera() { }

	// RVA: 0x30A8040 Offset: 0x30A8141 VA: 0x30A8040
	private void PlayButtonPushSE(float rate) { }

	// RVA: 0x30A8130 Offset: 0x30A8231 VA: 0x30A8130
	private void TickMain() { }

	// RVA: 0x30A9030 Offset: 0x30A9131 VA: 0x30A9030
	private void TickReadyFinish() { }

	// RVA: 0x30A90D0 Offset: 0x30A91D1 VA: 0x30A90D0
	private void TickFinish() { }

	// RVA: 0x30A9170 Offset: 0x30A9271 VA: 0x30A9170
	private void CalcRank() { }

	// RVA: 0x30A9690 Offset: 0x30A9791 VA: 0x30A9690
	private void ReadyResultCameraAndAnime() { }

	// RVA: 0x30A9870 Offset: 0x30A9971 VA: 0x30A9870
	private void InitResult() { }

	// RVA: 0x30AAA20 Offset: 0x30AAB21 VA: 0x30AAA20
	private void PlayResultVoice() { }

	// RVA: 0x30AADD0 Offset: 0x30AAED1 VA: 0x30AADD0
	private void TickResult() { }

	// RVA: 0x30AB010 Offset: 0x30AB111 VA: 0x30AB010
	private void CloseResult() { }

	// RVA: 0x30AB110 Offset: 0x30AB211 VA: 0x30AB110
	public bool IsClosedResult() { }

	// RVA: 0x30AB210 Offset: 0x30AB311 VA: 0x30AB210
	private void ExitResult() { }

	// RVA: 0x30AB280 Offset: 0x30AB381 VA: 0x30AB280
	private void SetMascotBond() { }

	// RVA: 0x30AB310 Offset: 0x30AB411 VA: 0x30AB310
	private bool CheckGetablePrize() { }

	// RVA: 0x30AB430 Offset: 0x30AB531 VA: 0x30AB430
	private void SetPrizeFlag() { }

	// RVA: 0x30AB600 Offset: 0x30AB701 VA: 0x30AB600
	private void GetPrizeBonus() { }

	// RVA: 0x30AB900 Offset: 0x30ABA01 VA: 0x30AB900
	private void GetPrizeBond() { }

	// RVA: 0x30ABAE0 Offset: 0x30ABBE1 VA: 0x30ABAE0
	private void UnloadResource() { }

	// RVA: 0x30ABBB0 Offset: 0x30ABCB1 VA: 0x30ABBB0
	private void Final() { }

	// RVA: 0x30ABE70 Offset: 0x30ABF71 VA: 0x30ABE70
	private bool IsEnableVoice() { }

	// RVA: 0x30A8EF0 Offset: 0x30A8FF1 VA: 0x30A8EF0
	private bool IsPlayingVoice() { }

	// RVA: 0x30ABE80 Offset: 0x30ABF81 VA: 0x30ABE80
	private void TryPlayVoice(string id) { }

	// RVA: 0x30A8F10 Offset: 0x30A9011 VA: 0x30A8F10
	private void VoicePerfect() { }

	// RVA: 0x30A8F70 Offset: 0x30A9071 VA: 0x30A8F70
	private void VoiceGood() { }

	// RVA: 0x30A8FD0 Offset: 0x30A90D1 VA: 0x30A8FD0
	private void VoiceBad() { }

	// RVA: 0x30ABF60 Offset: 0x30AC061 VA: 0x30ABF60
	private void VoiceEnhance1() { }

	// RVA: 0x30ABFC0 Offset: 0x30AC0C1 VA: 0x30ABFC0
	private void VoiceEnhance2() { }

	// RVA: 0x30AC020 Offset: 0x30AC121 VA: 0x30AC020
	private void VoiceEnhance3() { }

	// RVA: 0x30AACB0 Offset: 0x30AADB1 VA: 0x30AACB0
	private void VoiceResultPerfect() { }

	// RVA: 0x30AAD10 Offset: 0x30AAE11 VA: 0x30AAD10
	private void VoiceResultGood() { }

	// RVA: 0x30AAD70 Offset: 0x30AAE71 VA: 0x30AAD70
	private void VoiceResultBad() { }

	// RVA: 0x30AC080 Offset: 0x30AC181 VA: 0x30AC080
	public static void CreateBind(ProcInst super, int level, bool assist) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE1B0 Offset: 0x2CE2B1 VA: 0x2CE1B0
	// RVA: 0x30A5F40 Offset: 0x30A6041 VA: 0x30A5F40
	internal static Character <Init>g__CreateSola|133_1(CharacterAppearance app, Transform parent, bool invisible) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE1C0 Offset: 0x2CE2C1 VA: 0x2CE1C0
	// RVA: 0x30AD3E0 Offset: 0x30AD4E1 VA: 0x30AD3E0
	private void <SetupCamera>b__135_0(GameObject prefab) { }
}

