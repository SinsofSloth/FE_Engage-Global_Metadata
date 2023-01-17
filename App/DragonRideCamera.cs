// Namespace: App
[ExecuteInEditMode] // RVA: 0x276C40 Offset: 0x276D41 VA: 0x276C40
[Serializable]
public abstract class DragonRideCamera : MonoBehaviour // TypeDefIndex: 10497
{
	// Fields
	private const string cShotPrefabPath = "Hub/Prefabs/DragonRide/Shot";
	private const string InstructionPrefabPath = "UI/Hub/DragonRide/Prefabs/InstructionRoot";
	private const string SolaRenderPath = "Hub/Prefabs/DragonRide/DragonRideSolaImageRender";
	private float m_ShotIntervalTimer; // 0x18
	private GameObject m_Root; // 0x20
	private Character m_PlayerChara; // 0x28
	private ReinsController m_DragonReins; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28E730 Offset: 0x28E831 VA: 0x28E730
	private bool <IsReadyPlayerModel>k__BackingField; // 0x38
	private Character m_AssistChara; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x28E740 Offset: 0x28E841 VA: 0x28E740
	private bool <IsReadyAssistModel>k__BackingField; // 0x48
	private GameObject m_ScreenDust; // 0x50
	private ParticleSystem m_DustEffect; // 0x58
	private GameObject m_Camera; // 0x60
	private GameObject m_Cart; // 0x68
	private GameObject m_EventCart; // 0x70
	private CinemachineDollyCart m_ResultCartComponent; // 0x78
	private PlayableDirector m_Timeline; // 0x80
	private GameObject m_CursorObj; // 0x88
	private GameObject m_StartTelop; // 0x90
	private GameObject m_FinishTelop; // 0x98
	private bool m_IsPlayStartTelop; // 0xA0
	private bool m_IsPlayFinishTelop; // 0xA1
	private bool m_IsDoneStartTelop; // 0xA2
	private bool m_IsDoneFinishTelop; // 0xA3
	private GameObject m_ShotParent; // 0xA8
	private Vector3 m_PastPosition; // 0xB0
	private string m_LevelStr; // 0xC0
	private string m_CourseID; // 0xC8
	private string[] m_ShowGroupList; // 0xD0
	private const int cAssistLevelMax = 10;
	private float m_AngleX; // 0xD8
	private float m_AngleY; // 0xDC
	private float m_AngleXSpeed; // 0xE0
	private float m_AngleYSpeed; // 0xE4
	private float m_AngleSpeedRate; // 0xE8
	private float m_AngleSpeedLerpCounter; // 0xEC
	private const float cAngleSpeedRateMin = 0.25;
	private const float cAngleSpeedRateMax = 1;
	private GameObject m_SolaRenderObj; // 0xF0
	private DragonRideSolaImageRender m_SolaImagerRender; // 0xF8
	private Animator m_Cutin; // 0x100
	private Animator m_Cutin2; // 0x108
	private DragonRideCamera.CutinState m_CutinSate; // 0x110
	private float m_CutinTimer; // 0x114
	private float m_SpecialTimer; // 0x118
	private GameObject m_InstructionObj; // 0x120
	private int m_ShotNamingCounter; // 0x128
	private int m_AssistNamingCounter; // 0x12C
	private DragonRideConfig m_Config; // 0x130
	private DragonRideEventFader m_FaderScript; // 0x138
	private float m_AssistIntervalTimer; // 0x140
	private int[] cAssistIntervalFrame; // 0x148
	private string[] cLevelString; // 0x150
	public float m_RotateSpeedXZAxis; // 0x158
	public float m_RotateSpeedYAxis; // 0x15C
	public float m_RotateHighSpeedMult; // 0x160
	public float m_XZAxisRotateMax; // 0x164
	public float m_XZAxisRotateMin; // 0x168
	public float m_YAxisRotateMax; // 0x16C
	public float m_YAxisRotateMin; // 0x170
	public float m_ShotAdjustX; // 0x174
	public float m_ShotAdjustY; // 0x178
	public float m_AssistShotAngle; // 0x17C
	public float m_AssistCutInRate; // 0x180
	private const float cAssistAngleMax = 60;
	public float m_ShotSpeed; // 0x184
	public float m_AssistShotSpeed; // 0x188
	public float m_ShotLifeSecond; // 0x18C
	public float m_ShotInterpStraightSec; // 0x190
	public float m_MuzzleOffsetX; // 0x194
	public float m_MuzzleOffsetY; // 0x198
	public float m_MuzzleOffsetZ; // 0x19C
	public float m_TargetDistanceMax; // 0x1A0
	public float m_CursorMoveHalfWidth; // 0x1A4
	public float m_CursorMoveHalfHeight; // 0x1A8
	public float m_CursorMaxSpeed; // 0x1AC
	[CompilerGeneratedAttribute] // RVA: 0x28E750 Offset: 0x28E851 VA: 0x28E750
	private readonly string <CameraRoateteParamName>k__BackingField; // 0x1B0
	[CompilerGeneratedAttribute] // RVA: 0x28E760 Offset: 0x28E861 VA: 0x28E760
	private bool <IsSpecialTime>k__BackingField; // 0x1B8
	[CompilerGeneratedAttribute] // RVA: 0x28E770 Offset: 0x28E871 VA: 0x28E770
	private bool <IsRailFinished>k__BackingField; // 0x1B9
	[CompilerGeneratedAttribute] // RVA: 0x28E780 Offset: 0x28E881 VA: 0x28E780
	private bool <IsFirstCameraEventFinish>k__BackingField; // 0x1BA
	[CompilerGeneratedAttribute] // RVA: 0x28E790 Offset: 0x28E891 VA: 0x28E790
	private bool <IsEventCamera>k__BackingField; // 0x1BB
	[CompilerGeneratedAttribute] // RVA: 0x28E7A0 Offset: 0x28E8A1 VA: 0x28E7A0
	private bool <IsReadyEventCamera>k__BackingField; // 0x1BC
	[CompilerGeneratedAttribute] // RVA: 0x28E7B0 Offset: 0x28E8B1 VA: 0x28E7B0
	private double <LastEventTime>k__BackingField; // 0x1C0
	[CompilerGeneratedAttribute] // RVA: 0x28E7C0 Offset: 0x28E8C1 VA: 0x28E7C0
	private double <LastControleTargetTime>k__BackingField; // 0x1C8
	[CompilerGeneratedAttribute] // RVA: 0x28E7D0 Offset: 0x28E8D1 VA: 0x28E7D0
	private double <LastFadeMarkerTime>k__BackingField; // 0x1D0
	[CompilerGeneratedAttribute] // RVA: 0x28E7E0 Offset: 0x28E8E1 VA: 0x28E7E0
	private bool <IsNeedAssistRequest>k__BackingField; // 0x1D8
	[CompilerGeneratedAttribute] // RVA: 0x28E7F0 Offset: 0x28E8F1 VA: 0x28E7F0
	private int <AssistLevel>k__BackingField; // 0x1DC
	[CompilerGeneratedAttribute] // RVA: 0x28E800 Offset: 0x28E901 VA: 0x28E800
	private bool <IsPlaySpecialSE>k__BackingField; // 0x1E0
	[CompilerGeneratedAttribute] // RVA: 0x28E810 Offset: 0x28E911 VA: 0x28E810
	private bool <IsNeedTestPatternRequest>k__BackingField; // 0x1E1
	[CompilerGeneratedAttribute] // RVA: 0x28E820 Offset: 0x28E921 VA: 0x28E820
	private string <TestPatternRequest>k__BackingField; // 0x1E8
	[CompilerGeneratedAttribute] // RVA: 0x28E830 Offset: 0x28E931 VA: 0x28E830
	private int <TestPatternCount>k__BackingField; // 0x1F0
	[CompilerGeneratedAttribute] // RVA: 0x28E840 Offset: 0x28E941 VA: 0x28E840
	private DragonRideCamera.TargetControleFlag <TargetShowHideFlag>k__BackingField; // 0x1F4
	[CompilerGeneratedAttribute] // RVA: 0x28E850 Offset: 0x28E951 VA: 0x28E850
	private bool <IsPauseStop>k__BackingField; // 0x1F8
	[CompilerGeneratedAttribute] // RVA: 0x28E860 Offset: 0x28E961 VA: 0x28E860
	private bool <RetireGame>k__BackingField; // 0x1F9
	private float m_BaseAngleX; // 0x1FC
	private float m_BaseAngleZ; // 0x200
	private GyroMnager.DeviceType m_DeviceType; // 0x204

	// Properties
	public bool IsReadyPlayerModel { get; set; }
	public bool IsReadyAssistModel { get; set; }
	private string CameraRoateteParamName { get; }
	public bool IsSpecialTime { get; set; }
	public bool IsRailFinished { get; set; }
	public bool IsFirstCameraEventFinish { get; set; }
	public bool IsEventCamera { get; set; }
	public bool IsReadyEventCamera { get; set; }
	private double LastEventTime { get; set; }
	private double LastControleTargetTime { get; set; }
	public double LastFadeMarkerTime { get; set; }
	public bool IsNeedAssistRequest { get; set; }
	public int AssistLevel { get; set; }
	public bool IsAssist { get; }
	private bool IsPlaySpecialSE { get; set; }
	public bool IsNeedTestPatternRequest { get; set; }
	public string TestPatternRequest { get; set; }
	public int TestPatternCount { get; set; }
	public DragonRideCamera.TargetControleFlag TargetShowHideFlag { get; set; }
	private bool IsPauseStop { get; set; }
	public bool RetireGame { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BEB50 Offset: 0x2BEC51 VA: 0x2BEB50
	// RVA: 0x23822B0 Offset: 0x23823B1 VA: 0x23822B0
	public bool get_IsReadyPlayerModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEB60 Offset: 0x2BEC61 VA: 0x2BEB60
	// RVA: 0x23822C0 Offset: 0x23823C1 VA: 0x23822C0
	private void set_IsReadyPlayerModel(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEB70 Offset: 0x2BEC71 VA: 0x2BEB70
	// RVA: 0x23822D0 Offset: 0x23823D1 VA: 0x23822D0
	public bool get_IsReadyAssistModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEB80 Offset: 0x2BEC81 VA: 0x2BEB80
	// RVA: 0x23822E0 Offset: 0x23823E1 VA: 0x23822E0
	private void set_IsReadyAssistModel(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEB90 Offset: 0x2BEC91 VA: 0x2BEB90
	// RVA: 0x23822F0 Offset: 0x23823F1 VA: 0x23822F0
	private string get_CameraRoateteParamName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEBA0 Offset: 0x2BECA1 VA: 0x2BEBA0
	// RVA: 0x2382300 Offset: 0x2382401 VA: 0x2382300
	public bool get_IsSpecialTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEBB0 Offset: 0x2BECB1 VA: 0x2BEBB0
	// RVA: 0x2382310 Offset: 0x2382411 VA: 0x2382310
	private void set_IsSpecialTime(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEBC0 Offset: 0x2BECC1 VA: 0x2BEBC0
	// RVA: 0x2382320 Offset: 0x2382421 VA: 0x2382320
	public bool get_IsRailFinished() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEBD0 Offset: 0x2BECD1 VA: 0x2BEBD0
	// RVA: 0x2382330 Offset: 0x2382431 VA: 0x2382330
	private void set_IsRailFinished(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEBE0 Offset: 0x2BECE1 VA: 0x2BEBE0
	// RVA: 0x2382340 Offset: 0x2382441 VA: 0x2382340
	public bool get_IsFirstCameraEventFinish() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEBF0 Offset: 0x2BECF1 VA: 0x2BEBF0
	// RVA: 0x2382350 Offset: 0x2382451 VA: 0x2382350
	private void set_IsFirstCameraEventFinish(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEC00 Offset: 0x2BED01 VA: 0x2BEC00
	// RVA: 0x2382360 Offset: 0x2382461 VA: 0x2382360
	public bool get_IsEventCamera() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEC10 Offset: 0x2BED11 VA: 0x2BEC10
	// RVA: 0x2382370 Offset: 0x2382471 VA: 0x2382370
	private void set_IsEventCamera(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEC20 Offset: 0x2BED21 VA: 0x2BEC20
	// RVA: 0x2382380 Offset: 0x2382481 VA: 0x2382380
	public bool get_IsReadyEventCamera() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEC30 Offset: 0x2BED31 VA: 0x2BEC30
	// RVA: 0x2382390 Offset: 0x2382491 VA: 0x2382390
	public void set_IsReadyEventCamera(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEC40 Offset: 0x2BED41 VA: 0x2BEC40
	// RVA: 0x23823A0 Offset: 0x23824A1 VA: 0x23823A0
	private double get_LastEventTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEC50 Offset: 0x2BED51 VA: 0x2BEC50
	// RVA: 0x23823B0 Offset: 0x23824B1 VA: 0x23823B0
	private void set_LastEventTime(double value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEC60 Offset: 0x2BED61 VA: 0x2BEC60
	// RVA: 0x23823C0 Offset: 0x23824C1 VA: 0x23823C0
	private double get_LastControleTargetTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEC70 Offset: 0x2BED71 VA: 0x2BEC70
	// RVA: 0x23823D0 Offset: 0x23824D1 VA: 0x23823D0
	private void set_LastControleTargetTime(double value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEC80 Offset: 0x2BED81 VA: 0x2BEC80
	// RVA: 0x23823E0 Offset: 0x23824E1 VA: 0x23823E0
	public double get_LastFadeMarkerTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEC90 Offset: 0x2BED91 VA: 0x2BEC90
	// RVA: 0x23823F0 Offset: 0x23824F1 VA: 0x23823F0
	public void set_LastFadeMarkerTime(double value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BECA0 Offset: 0x2BEDA1 VA: 0x2BECA0
	// RVA: 0x2382400 Offset: 0x2382501 VA: 0x2382400
	public bool get_IsNeedAssistRequest() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BECB0 Offset: 0x2BEDB1 VA: 0x2BECB0
	// RVA: 0x2382410 Offset: 0x2382511 VA: 0x2382410
	private void set_IsNeedAssistRequest(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BECC0 Offset: 0x2BEDC1 VA: 0x2BECC0
	// RVA: 0x2382420 Offset: 0x2382521 VA: 0x2382420
	public int get_AssistLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BECD0 Offset: 0x2BEDD1 VA: 0x2BECD0
	// RVA: 0x2382430 Offset: 0x2382531 VA: 0x2382430
	private void set_AssistLevel(int value) { }

	// RVA: 0x2382440 Offset: 0x2382541 VA: 0x2382440
	public bool get_IsAssist() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BECE0 Offset: 0x2BEDE1 VA: 0x2BECE0
	// RVA: 0x2382450 Offset: 0x2382551 VA: 0x2382450
	private bool get_IsPlaySpecialSE() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BECF0 Offset: 0x2BEDF1 VA: 0x2BECF0
	// RVA: 0x2382460 Offset: 0x2382561 VA: 0x2382460
	private void set_IsPlaySpecialSE(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BED00 Offset: 0x2BEE01 VA: 0x2BED00
	// RVA: 0x2382470 Offset: 0x2382571 VA: 0x2382470
	public bool get_IsNeedTestPatternRequest() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BED10 Offset: 0x2BEE11 VA: 0x2BED10
	// RVA: 0x2382480 Offset: 0x2382581 VA: 0x2382480
	public void set_IsNeedTestPatternRequest(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BED20 Offset: 0x2BEE21 VA: 0x2BED20
	// RVA: 0x2382490 Offset: 0x2382591 VA: 0x2382490
	public string get_TestPatternRequest() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BED30 Offset: 0x2BEE31 VA: 0x2BED30
	// RVA: 0x23824A0 Offset: 0x23825A1 VA: 0x23824A0
	public void set_TestPatternRequest(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BED40 Offset: 0x2BEE41 VA: 0x2BED40
	// RVA: 0x23824B0 Offset: 0x23825B1 VA: 0x23824B0
	public int get_TestPatternCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BED50 Offset: 0x2BEE51 VA: 0x2BED50
	// RVA: 0x23824C0 Offset: 0x23825C1 VA: 0x23824C0
	public void set_TestPatternCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BED60 Offset: 0x2BEE61 VA: 0x2BED60
	// RVA: 0x23824D0 Offset: 0x23825D1 VA: 0x23824D0
	public DragonRideCamera.TargetControleFlag get_TargetShowHideFlag() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BED70 Offset: 0x2BEE71 VA: 0x2BED70
	// RVA: 0x23824E0 Offset: 0x23825E1 VA: 0x23824E0
	private void set_TargetShowHideFlag(DragonRideCamera.TargetControleFlag value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BED80 Offset: 0x2BEE81 VA: 0x2BED80
	// RVA: 0x23824F0 Offset: 0x23825F1 VA: 0x23824F0
	private bool get_IsPauseStop() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BED90 Offset: 0x2BEE91 VA: 0x2BED90
	// RVA: 0x2382500 Offset: 0x2382601 VA: 0x2382500
	private void set_IsPauseStop(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEDA0 Offset: 0x2BEEA1 VA: 0x2BEDA0
	// RVA: 0x2382510 Offset: 0x2382611 VA: 0x2382510
	public bool get_RetireGame() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEDB0 Offset: 0x2BEEB1 VA: 0x2BEDB0
	// RVA: 0x2382520 Offset: 0x2382621 VA: 0x2382520
	public void set_RetireGame(bool value) { }

	// RVA: 0x2382530 Offset: 0x2382631 VA: 0x2382530
	private void OnEnable() { }

	// RVA: 0x2382540 Offset: 0x2382641 VA: 0x2382540
	private static float GetParamTime(string name) { }

	// RVA: 0x2382580 Offset: 0x2382681 VA: 0x2382580
	private void Start() { }

	// RVA: 0x2382590 Offset: 0x2382691 VA: 0x2382590
	private void ResetCursol(bool IsResetAngle = True) { }

	// RVA: 0x2382B60 Offset: 0x2382C61 VA: 0x2382B60
	private Character CreateDragonRideCharacter(CharacterAppearance app, Transform parent, bool invisible) { }

	// RVA: 0x2382C50 Offset: 0x2382D51 VA: 0x2382C50
	public void CreateDragonModel() { }

	// RVA: 0x2382E90 Offset: 0x2382F91 VA: 0x2382E90
	public void CreateAssistModel() { }

	// RVA: 0x2383320 Offset: 0x2383421 VA: 0x2383320
	public void InitializeCameraBase() { }

	// RVA: 0x2383BA0 Offset: 0x2383CA1 VA: 0x2383BA0
	public bool CheckEnableCutin() { }

	// RVA: 0x2383BB0 Offset: 0x2383CB1 VA: 0x2383BB0
	public void OpenCutin() { }

	// RVA: 0x2383CF0 Offset: 0x2383DF1 VA: 0x2383CF0
	public void CloseCutin() { }

	// RVA: 0x2383DC0 Offset: 0x2383EC1 VA: 0x2383DC0
	public void FinalizeCameraBase() { }

	// RVA: 0x2384150 Offset: 0x2384251 VA: 0x2384150
	public void InitializeCourseCamera(string courseID, int level) { }

	// RVA: 0x23844A0 Offset: 0x23845A1 VA: 0x23844A0
	public void InitFake() { }

	// RVA: 0x23844B0 Offset: 0x23845B1 VA: 0x23844B0
	public void TickFake() { }

	// RVA: 0x23844C0 Offset: 0x23845C1 VA: 0x23844C0
	public void StartTimeline() { }

	// RVA: 0x23844D0 Offset: 0x23845D1 VA: 0x23844D0
	private void UpdateCameraParam() { }

	// RVA: 0x2384CD0 Offset: 0x2384DD1 VA: 0x2384CD0
	private void UpdateCameraParam_Key() { }

	// RVA: 0x2382650 Offset: 0x2382751 VA: 0x2382650
	private void UpdateCameraParam_Gyro(bool isReset) { }

	// RVA: 0x23859F0 Offset: 0x2385AF1 VA: 0x23859F0
	private void CommitCamera() { }

	// RVA: 0x2385B40 Offset: 0x2385C41 VA: 0x2385B40
	private void CommitEventCamera() { }

	// RVA: 0x2385C90 Offset: 0x2385D91 VA: 0x2385C90
	private void UpdateShot() { }

	// RVA: 0x2386BA0 Offset: 0x2386CA1 VA: 0x2386BA0
	private void UpdateAssist() { }

	// RVA: 0x2386C70 Offset: 0x2386D71 VA: 0x2386C70
	public Vector3 GetForwardVec() { }

	// RVA: 0x2386C90 Offset: 0x2386D91 VA: 0x2386C90
	public float GetAssistShotDotRate() { }

	// RVA: 0x2386CB0 Offset: 0x2386DB1 VA: 0x2386CB0
	public float GetAssistCutInDotRate() { }

	// RVA: 0x2386CC0 Offset: 0x2386DC1 VA: 0x2386CC0
	public void AssistShot(bool isAiming, Vector3 AimPos, bool isPenetrate) { }

	// RVA: 0x2387000 Offset: 0x2387101 VA: 0x2387000
	public void SetTestPattern(string patternID, int num) { }

	// RVA: 0x2387040 Offset: 0x2387141 VA: 0x2387040
	public int GetSelectedTestPatternNum() { }

	// RVA: 0x2387050 Offset: 0x2387151 VA: 0x2387050
	private void FixedUpdate() { }

	// RVA: 0x2387060 Offset: 0x2387161 VA: 0x2387060
	public void TickMain() { }

	// RVA: 0x2387730 Offset: 0x2387831 VA: 0x2387730
	public void TickResult() { }

	// RVA: 0x23878F0 Offset: 0x23879F1 VA: 0x23878F0
	private void _RefreshObj(ref GameObject target) { }

	// RVA: 0x23879A0 Offset: 0x2387AA1 VA: 0x23879A0
	public void FinalizeCourseCamera() { }

	// RVA: 0x2387AB0 Offset: 0x2387BB1 VA: 0x2387AB0
	public void SetEventMode(bool flag, double time, GameObject notifyObj) { }

	// RVA: 0x2387E50 Offset: 0x2387F51 VA: 0x2387E50
	public void PlayOneShotSE(string label) { }

	// RVA: 0x2387EC0 Offset: 0x2387FC1 VA: 0x2387EC0
	public void FinishRail() { }

	// RVA: 0x2387ED0 Offset: 0x2387FD1 VA: 0x2387ED0
	public void SetShowGroupList(string[] groupList, double time) { }

	// RVA: 0x2387F20 Offset: 0x2388021 VA: 0x2387F20
	public void SetHideGroupList(string[] groupList, double time) { }

	// RVA: 0x2387F70 Offset: 0x2388071 VA: 0x2387F70
	public void GetControleGroupList(ref string[] listRef) { }

	// RVA: 0x2387FB0 Offset: 0x23880B1 VA: 0x2387FB0
	public void SetResultMode() { }

	// RVA: 0x2388280 Offset: 0x2388381 VA: 0x2388280
	public double GetTimelineMsec() { }

	// RVA: 0x2388320 Offset: 0x2388421 VA: 0x2388320
	public void RunEventFadeIn(FadeType type) { }

	// RVA: 0x2388330 Offset: 0x2388431 VA: 0x2388330
	public void RunEventFadeOut(FadeType type) { }

	// RVA: 0x2388340 Offset: 0x2388441 VA: 0x2388340
	public void SetSpecialTime() { }

	// RVA: 0x2388390 Offset: 0x2388491 VA: 0x2388390
	public void CreateStartTelop() { }

	// RVA: 0x23883B0 Offset: 0x23884B1 VA: 0x23883B0
	public void CreateFinishTelop() { }

	// RVA: 0x23883D0 Offset: 0x23884D1 VA: 0x23883D0
	public void StopWindLineEffect() { }

	// RVA: 0x23883F0 Offset: 0x23884F1 VA: 0x23883F0
	public void RestartWindLineEffect() { }

	// RVA: 0x2386AA0 Offset: 0x2386BA1 VA: 0x2386AA0
	private void PlaySpecialBurstSE() { }

	// RVA: 0x2384C20 Offset: 0x2384D21 VA: 0x2384C20
	private void StopSpecialBurstSE() { }

	// RVA: 0x2388400 Offset: 0x2388501 VA: 0x2388400
	protected void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEDC0 Offset: 0x2BEEC1 VA: 0x2BEDC0
	// RVA: 0x23887A0 Offset: 0x23888A1 VA: 0x23887A0
	private void <CreateDragonModel>b__162_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEDD0 Offset: 0x2BEED1 VA: 0x2BEDD0
	// RVA: 0x2388BF0 Offset: 0x2388CF1 VA: 0x2388BF0
	private void <CreateAssistModel>b__163_0() { }
}

