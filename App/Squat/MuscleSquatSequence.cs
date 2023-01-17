// Namespace: App.Squat
public class MuscleSquatSequence : ProcInst // TypeDefIndex: 14188
{
	// Fields
	private const string ObjectRootPath = "Hub/Prefabs/MuscleExercise/";
	private const string cUIRootPath = "UI/Hub/MuscleExercises/Prefabs/";
	private const string cUIWindow = "SquatRoot";
	private const string cUINotes = "Notes";
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
	private const string cUINotesRight = "Notes_Right";
	private const string cUINotesLeft = "Notes_Left";
	private const string cUINotesUp = "Notes_Up";
	private const string cUINotesDown = "Notes_Down";
	private const string cUINotesClockwise = "Notes_RightRotation";
	private const string cUINotesUnClockwise = "Notes_LeftRotation";
	private string[] cLoadObjectList; // 0x70
	private const float cAnimeRoopFrame = 3;
	private Vector3 cPlayerPos; // 0x78
	private const float cPlayerRotY = 45;
	private Vector3 cAssistPos; // 0x84
	private const float cAssistRotY = 1.317;
	private const float cCountDownFrame = 244;
	private const float cFinishFrame = 1.3;
	private const float cResultMinimumSec = 2.4;
	[CompilerGeneratedAttribute] // RVA: 0x29DBF0 Offset: 0x29DCF1 VA: 0x29DBF0
	private int <SelectLevel>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x29DC00 Offset: 0x29DD01 VA: 0x29DC00
	private int <AssistLevel>k__BackingField; // 0x94
	[CompilerGeneratedAttribute] // RVA: 0x29DC10 Offset: 0x29DD11 VA: 0x29DC10
	private bool <IsImmortal>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x29DC20 Offset: 0x29DD21 VA: 0x29DC20
	private bool <IsClear>k__BackingField; // 0x99
	private GameObject m_Window; // 0xA0
	private GameObject m_ResultWindow; // 0xA8
	private GameObject m_PopUpPerfect; // 0xB0
	private GameObject m_PopUpGood; // 0xB8
	private GameObject m_PopUpBad; // 0xC0
	private GameObject m_PopUpAssist; // 0xC8
	private RectTransform m_PopUpAssistRectTrans; // 0xD0
	private GameObject m_AssistGlitter; // 0xD8
	private GameObject m_CurrentPopUp; // 0xE0
	private float m_PopupTimer; // 0xE8
	private float m_PopupAssistTimer; // 0xEC
	private float m_TimeMult; // 0xF0
	private float m_NotesHeightMult; // 0xF4
	private float m_ClockWiseLengthMult; // 0xF8
	private Stick m_StickR; // 0x100
	private Stick m_StickL; // 0x108
	private GameObject m_NotesCanvasRoot; // 0x110
	private List<Note> m_NotesR; // 0x118
	private List<Note> m_NotesL; // 0x120
	private List<Note> m_EraseNoteReserveR; // 0x128
	private List<Note> m_EraseNoteReserveL; // 0x130
	private int m_RightRankReserver; // 0x138
	private int m_LeftRankReserver; // 0x13C
	private MuscleSquatJudgeAreaData m_JudgeData; // 0x140
	private int[] m_NotesPatternA_R; // 0x148
	private int[] m_NotesPatternA_L; // 0x150
	private int[] m_NotesPatternB_R; // 0x158
	private int[] m_NotesPatternB_L; // 0x160
	private int[] m_NotesPatternC_R; // 0x168
	private int[] m_NotesPatternC_L; // 0x170
	private int[] m_NotesPatternD_R; // 0x178
	private int[] m_NotesPatternD_L; // 0x180
	private int[] m_NotesPatternE_R; // 0x188
	private int[] m_NotesPatternE_L; // 0x190
	private List<string> m_SelectedTypeList; // 0x198
	private int m_UsePatternCount; // 0x1A0
	private TextMeshProUGUI m_CountText; // 0x1A8
	private int m_TotalNotesCount; // 0x1B0
	private int m_PastCount; // 0x1B4
	private TextMeshProUGUI m_PerfectText; // 0x1B8
	private TextMeshProUGUI m_GoodText; // 0x1C0
	private GameObject m_BadBase; // 0x1C8
	private Animator[] m_BadAnime; // 0x1D0
	private int m_GoodScore; // 0x1D8
	private int m_PerfectScore; // 0x1DC
	private int m_TargetScore; // 0x1E0
	private int m_EndlessLimitCount; // 0x1E4
	private int m_BadCount; // 0x1E8
	private int m_PerfectCount; // 0x1EC
	private int m_GoodCount; // 0x1F0
	private GameObject m_PlayerRoot; // 0x1F8
	private GameObject m_ExerciseChara; // 0x200
	private Animator m_PlayerAnimator; // 0x208
	private Vector3 m_PlayerResetPos; // 0x210
	private Quaternion m_PlayerResetRot; // 0x21C
	private float m_PlayerResetDir; // 0x22C
	private float m_AnimeFrame; // 0x230
	private InterpolatorFloat m_AnimeFrameInterp; // 0x238
	private bool m_IsReadyPlayerModel; // 0x240
	private bool m_IsClear; // 0x241
	private const int CameraAnimeCountMax = 3;
	private Camera m_UseCamera; // 0x248
	private Animation m_CameraAnime; // 0x250
	private int m_UseCameraAnimeIndex; // 0x258
	private ResourceHandle[] m_CameraAnimeResouce; // 0x260
	private List<GameObject> m_CameraResourceObjList; // 0x268
	private Transform m_Talker; // 0x270
	private Character m_TalkChara; // 0x278
	private GameSound.Handle m_VoiceHandle; // 0x280
	private float m_VoiceIntervalTimer; // 0x288
	private const float VoiceIntervalSec = 2;
	private Character m_Sola; // 0x290
	private Animator m_SolaAnime; // 0x298
	private bool m_SolaReaction; // 0x2A0
	private int m_AssistMax; // 0x2A4
	private int m_AssistCount; // 0x2A8
	private bool m_IsReadyAssistModel; // 0x2AC
	private GameObject m_HubSolaLct; // 0x2B0
	private bool m_IsSetSolaInvisible; // 0x2B8
	private float m_CountTimer; // 0x2BC
	private GameObject m_CountTelop; // 0x2C0
	private GameObject m_StopTelop; // 0x2C8
	private string m_RankStr; // 0x2D0
	private string m_RankBonus; // 0x2D8
	private int m_RankBond; // 0x2E0
	private float m_ResultTimer; // 0x2E4
	private float m_JudgeFB; // 0x2E8
	private float m_JudgeFG; // 0x2EC
	private float m_JudgeFP; // 0x2F0
	private float m_JudgeLP; // 0x2F4
	private float m_JudgeLG; // 0x2F8
	private float m_JudgeLB; // 0x2FC

	// Properties
	public int SelectLevel { get; set; }
	public int AssistLevel { get; set; }
	private bool IsAssist { get; }
	private bool IsImmortal { get; set; }
	private bool IsClear { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CE000 Offset: 0x2CE101 VA: 0x2CE000
	// RVA: 0x30ADDA0 Offset: 0x30ADEA1 VA: 0x30ADDA0
	public int get_SelectLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE010 Offset: 0x2CE111 VA: 0x2CE010
	// RVA: 0x30ADDB0 Offset: 0x30ADEB1 VA: 0x30ADDB0
	public void set_SelectLevel(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE020 Offset: 0x2CE121 VA: 0x2CE020
	// RVA: 0x30ADDC0 Offset: 0x30ADEC1 VA: 0x30ADDC0
	public int get_AssistLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE030 Offset: 0x2CE131 VA: 0x2CE030
	// RVA: 0x30ADDD0 Offset: 0x30ADED1 VA: 0x30ADDD0
	public void set_AssistLevel(int value) { }

	// RVA: 0x30ADDE0 Offset: 0x30ADEE1 VA: 0x30ADDE0
	private bool get_IsAssist() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE040 Offset: 0x2CE141 VA: 0x2CE040
	// RVA: 0x30ADDF0 Offset: 0x30ADEF1 VA: 0x30ADDF0
	private bool get_IsImmortal() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE050 Offset: 0x2CE151 VA: 0x2CE050
	// RVA: 0x30ADE00 Offset: 0x30ADF01 VA: 0x30ADE00
	private void set_IsImmortal(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE060 Offset: 0x2CE161 VA: 0x2CE060
	// RVA: 0x30ADE10 Offset: 0x30ADF11 VA: 0x30ADE10
	private bool get_IsClear() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE070 Offset: 0x2CE171 VA: 0x2CE070
	// RVA: 0x30ADE20 Offset: 0x30ADF21 VA: 0x30ADE20
	private void set_IsClear(bool value) { }

	// RVA: 0x30ADE30 Offset: 0x30ADF31 VA: 0x30ADE30
	public void .ctor() { }

	// RVA: -1 Offset: -1
	private static void CheckAndLoadResource<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2967060 Offset: 0x2967161 VA: 0x2967060
	|-MuscleSquatSequence.CheckAndLoadResource<GameObject>
	|-MuscleSquatSequence.CheckAndLoadResource<object>
	*/

	// RVA: 0x30AE690 Offset: 0x30AE791 VA: 0x30AE690
	private void LoadResources() { }

	// RVA: 0x30AE730 Offset: 0x30AE831 VA: 0x30AE730
	private bool IsLoading() { }

	// RVA: 0x30AE800 Offset: 0x30AE901 VA: 0x30AE800
	private void CreateScorePattern() { }

	// RVA: 0x30AECD0 Offset: 0x30AEDD1 VA: 0x30AECD0
	private void SelectScorePattern(ref MuscleSquatJudgeAreaData judge) { }

	// RVA: 0x30AF780 Offset: 0x30AF881 VA: 0x30AF780
	private void Init() { }

	// RVA: 0x30B1000 Offset: 0x30B1101 VA: 0x30B1000
	private void SetupCamera() { }

	// RVA: 0x30B14B0 Offset: 0x30B15B1 VA: 0x30B14B0
	private bool IsLoadingCamera() { }

	// RVA: 0x30B1540 Offset: 0x30B1641 VA: 0x30B1540
	private void FinalizeCamera() { }

	// RVA: 0x30B1710 Offset: 0x30B1811 VA: 0x30B1710
	private bool IsReadyModel() { }

	// RVA: 0x30B1750 Offset: 0x30B1851 VA: 0x30B1750
	private void StartPopUp(Note.ResultRank setRank) { }

	// RVA: 0x30B1B00 Offset: 0x30B1C01 VA: 0x30B1B00
	private void AddPerfectCount() { }

	// RVA: 0x30B1BA0 Offset: 0x30B1CA1 VA: 0x30B1BA0
	private void AddGoodCount() { }

	// RVA: 0x30B1C40 Offset: 0x30B1D41 VA: 0x30B1C40
	private bool AddBadCount() { }

	// RVA: 0x30B1CF0 Offset: 0x30B1DF1 VA: 0x30B1CF0
	private void AddCirclePerfect(Vector3 pos) { }

	// RVA: 0x30B1E40 Offset: 0x30B1F41 VA: 0x30B1E40
	private void AddCircleGood(Vector3 pos) { }

	// RVA: 0x30B1F90 Offset: 0x30B2091 VA: 0x30B1F90
	private void PlaySEPerfect() { }

	// RVA: 0x30B2010 Offset: 0x30B2111 VA: 0x30B2010
	private void PlaySEGood() { }

	// RVA: 0x30B2090 Offset: 0x30B2191 VA: 0x30B2090
	private void PlaySEBad() { }

	// RVA: 0x30B2110 Offset: 0x30B2211 VA: 0x30B2110
	private void PlaySEStart() { }

	// RVA: 0x30B2190 Offset: 0x30B2291 VA: 0x30B2190
	private void PlaySEFinish() { }

	// RVA: 0x30B2240 Offset: 0x30B2341 VA: 0x30B2240
	private void PlaySolaAnimeGood() { }

	// RVA: 0x30B22B0 Offset: 0x30B23B1 VA: 0x30B22B0
	private void PlaySolaAnimeBad() { }

	// RVA: 0x30B2320 Offset: 0x30B2421 VA: 0x30B2320
	private void PlaySolaAnimeAssist() { }

	// RVA: 0x30B2390 Offset: 0x30B2491 VA: 0x30B2390
	private void TickPopup() { }

	// RVA: 0x30B2600 Offset: 0x30B2701 VA: 0x30B2600
	private void InitCountDown() { }

	// RVA: 0x30B2800 Offset: 0x30B2901 VA: 0x30B2800
	private void TickCount() { }

	// RVA: 0x30B28B0 Offset: 0x30B29B1 VA: 0x30B28B0
	private void JumpMain() { }

	// RVA: 0x30B29E0 Offset: 0x30B2AE1 VA: 0x30B29E0
	private bool CheckClear() { }

	// RVA: 0x30B2AE0 Offset: 0x30B2BE1 VA: 0x30B2AE0
	private void JumpReadyFinish(bool isClear) { }

	// RVA: 0x30B2C60 Offset: 0x30B2D61 VA: 0x30B2C60
	private void JumpFinish() { }

	// RVA: 0x30B31C0 Offset: 0x30B32C1 VA: 0x30B31C0
	private void TickMain() { }

	// RVA: 0x30B40E0 Offset: 0x30B41E1 VA: 0x30B40E0
	private void TickCamera() { }

	// RVA: 0x30B4340 Offset: 0x30B4441 VA: 0x30B4340
	private void TickReadyFinish() { }

	// RVA: 0x30B43E0 Offset: 0x30B44E1 VA: 0x30B43E0
	private void TickFinish() { }

	// RVA: 0x30B4480 Offset: 0x30B4581 VA: 0x30B4480
	private void DestroyGameWindow() { }

	// RVA: 0x30B44F0 Offset: 0x30B45F1 VA: 0x30B44F0
	private void CalcRank() { }

	// RVA: 0x30B48A0 Offset: 0x30B49A1 VA: 0x30B48A0
	private void ReadyResultCameraAndAnime() { }

	// RVA: 0x30B4A80 Offset: 0x30B4B81 VA: 0x30B4A80
	private void InitResult() { }

	// RVA: 0x30B5C50 Offset: 0x30B5D51 VA: 0x30B5C50
	private void PlayResultVoice() { }

	// RVA: 0x30B6000 Offset: 0x30B6101 VA: 0x30B6000
	private void TickResult() { }

	// RVA: 0x30B6240 Offset: 0x30B6341 VA: 0x30B6240
	private void CloseResult() { }

	// RVA: 0x30B6340 Offset: 0x30B6441 VA: 0x30B6340
	public bool IsClosedResult() { }

	// RVA: 0x30B6440 Offset: 0x30B6541 VA: 0x30B6440
	private void ExitResult() { }

	// RVA: 0x30B64B0 Offset: 0x30B65B1 VA: 0x30B64B0
	private bool CheckGetablePrize() { }

	// RVA: 0x30B65D0 Offset: 0x30B66D1 VA: 0x30B65D0
	private void SetPrizeFlag() { }

	// RVA: 0x30B67A0 Offset: 0x30B68A1 VA: 0x30B67A0
	private void GetPrizeBonus() { }

	// RVA: 0x30B6AA0 Offset: 0x30B6BA1 VA: 0x30B6AA0
	private void GetPrizeBond() { }

	// RVA: 0x30B6C80 Offset: 0x30B6D81 VA: 0x30B6C80
	private void SetMascotBond() { }

	// RVA: 0x30B6D10 Offset: 0x30B6E11 VA: 0x30B6D10
	private void UnloadResource() { }

	// RVA: 0x30B6DE0 Offset: 0x30B6EE1 VA: 0x30B6DE0
	private void Final() { }

	// RVA: 0x30B73E0 Offset: 0x30B74E1 VA: 0x30B73E0
	private bool IsEnableVoice() { }

	// RVA: 0x30B4200 Offset: 0x30B4301 VA: 0x30B4200
	private bool IsPlayingVoice() { }

	// RVA: 0x30B73F0 Offset: 0x30B74F1 VA: 0x30B73F0
	private void TryPlayVoice(string id) { }

	// RVA: 0x30B4220 Offset: 0x30B4321 VA: 0x30B4220
	private void VoicePerfect() { }

	// RVA: 0x30B4280 Offset: 0x30B4381 VA: 0x30B4280
	private void VoiceGood() { }

	// RVA: 0x30B42E0 Offset: 0x30B43E1 VA: 0x30B42E0
	private void VoiceBad() { }

	// RVA: 0x30B5EE0 Offset: 0x30B5FE1 VA: 0x30B5EE0
	private void VoiceResultPerfect() { }

	// RVA: 0x30B5F40 Offset: 0x30B6041 VA: 0x30B5F40
	private void VoiceResultGood() { }

	// RVA: 0x30B5FA0 Offset: 0x30B60A1 VA: 0x30B5FA0
	private void VoiceResultBad() { }

	// RVA: 0x30B74D0 Offset: 0x30B75D1 VA: 0x30B74D0
	public static void CreateBind(ProcInst super, int level, bool assist) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE080 Offset: 0x2CE181 VA: 0x2CE080
	// RVA: 0x30AF510 Offset: 0x30AF611 VA: 0x30AF510
	private void <SelectScorePattern>g__CreateNotesByList|147_0(ref GameObject canvas, ref int[] notesList, Transform baseTrans, float timeMult, ref List<Note> targetList, ref MuscleSquatJudgeAreaData judgeParam) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE090 Offset: 0x2CE191 VA: 0x2CE090
	// RVA: 0x30B0F10 Offset: 0x30B1011 VA: 0x30B0F10
	internal static Character <Init>g__CreateSola|148_1(CharacterAppearance app, Transform parent, bool invisible) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE0A0 Offset: 0x2CE1A1 VA: 0x2CE0A0
	// RVA: 0x30B88A0 Offset: 0x30B89A1 VA: 0x30B88A0
	private void <SetupCamera>b__149_0(GameObject prefab) { }
}

