// Namespace: App
public class DragonRideGameSequence : ProcSceneSequence<HubSequence> // TypeDefIndex: 10516
{
	// Fields
	private const float cIntervalSec = 0.5;
	private const string cShotPrefabPath = "Hub/Prefabs/DragonRide/Shot";
	private const string SolaRenderPath = "Hub/Prefabs/DragonRide/DragonRideSolaImageRender";
	private const string cGroupPrefabPath = "Hub/Prefabs/DragonRide/TargetGroup";
	private const string cEffectRootPath = "Effects/Field/Hub/DragonRide/Prefabs/";
	private string[] cLoadEffectList; // 0x88
	private const string cUIRootPath = "UI/Hub/DragonRide/Prefabs/";
	private const string cUITotalScorePath = "HudRoot";
	private const string cUITargetScorePath = "PopupNum_Score";
	private const string cUIResultPath = "ResultRoot";
	private const string cUIInstructionPath = "InstructionRoot";
	private string[] cLoadUIList; // 0x90
	private const string cTelopRootPath = "UI/Hub/Telop/MiniGame/Prefabs/";
	private const string cStartTelopPath = "Start";
	private const string cFinishTelopPath = "Finish";
	[CompilerGeneratedAttribute] // RVA: 0x28F370 Offset: 0x28F471 VA: 0x28F370
	private string <CourseID>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x28F380 Offset: 0x28F481 VA: 0x28F380
	private bool <IsEventMode>k__BackingField; // 0xA0
	private DragonRideCamera m_CameraComponent; // 0xA8
	private List<GameObject> m_TargetGroupList; // 0xB0
	private int m_Level; // 0xB8
	private float m_ResultCloseTimer; // 0xBC
	private DragonRideResultUI m_ResultUI; // 0xC0
	private GameObject m_ScoreUI; // 0xC8
	private TextMeshProUGUI m_ScoreText; // 0xD0
	private int m_PrevScore; // 0xD8
	private DragonRideConfig m_Config; // 0xE0
	private ResourceGameObject m_TargetGroupResource; // 0xE8
	private List<Vector3> m_AssistTargetPosList; // 0xF0
	private GameObject m_HubSolaLct; // 0xF8
	private bool m_IsSetSolaInvisible; // 0x100
	private HubPlayerController m_PlayerCtrl; // 0x108
	private int m_WalkThroughCount; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x28F390 Offset: 0x28F491 VA: 0x28F390
	private bool <IsEnableWalkThrough>k__BackingField; // 0x114
	[CompilerGeneratedAttribute] // RVA: 0x28F3A0 Offset: 0x28F4A1 VA: 0x28F3A0
	private bool <IsEnableUpdateTargetList>k__BackingField; // 0x115

	// Properties
	public string CourseID { get; set; }
	public bool IsEventMode { get; set; }
	private bool IsEnableWalkThrough { get; set; }
	private bool IsEnableUpdateTargetList { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BEE10 Offset: 0x2BEF11 VA: 0x2BEE10
	// RVA: 0x2DC3F00 Offset: 0x2DC4001 VA: 0x2DC3F00
	public string get_CourseID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEE20 Offset: 0x2BEF21 VA: 0x2BEE20
	// RVA: 0x2DC3F10 Offset: 0x2DC4011 VA: 0x2DC3F10
	private void set_CourseID(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEE30 Offset: 0x2BEF31 VA: 0x2BEE30
	// RVA: 0x2DC3F20 Offset: 0x2DC4021 VA: 0x2DC3F20
	public bool get_IsEventMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEE40 Offset: 0x2BEF41 VA: 0x2BEE40
	// RVA: 0x2DC3F30 Offset: 0x2DC4031 VA: 0x2DC3F30
	public void set_IsEventMode(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEE50 Offset: 0x2BEF51 VA: 0x2BEE50
	// RVA: 0x2DC3F40 Offset: 0x2DC4041 VA: 0x2DC3F40
	private bool get_IsEnableWalkThrough() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEE60 Offset: 0x2BEF61 VA: 0x2BEE60
	// RVA: 0x2DC3F50 Offset: 0x2DC4051 VA: 0x2DC3F50
	private void set_IsEnableWalkThrough(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEE70 Offset: 0x2BEF71 VA: 0x2BEE70
	// RVA: 0x2DC3F60 Offset: 0x2DC4061 VA: 0x2DC3F60
	private bool get_IsEnableUpdateTargetList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BEE80 Offset: 0x2BEF81 VA: 0x2BEE80
	// RVA: 0x2DC3F70 Offset: 0x2DC4071 VA: 0x2DC3F70
	private void set_IsEnableUpdateTargetList(bool value) { }

	// RVA: 0x2DC3F80 Offset: 0x2DC4081 VA: 0x2DC3F80
	private void _CommonDebugMenu() { }

	// RVA: 0x2DC3F90 Offset: 0x2DC4091 VA: 0x2DC3F90
	private void InitFirst() { }

	// RVA: 0x2DC4B10 Offset: 0x2DC4C11 VA: 0x2DC4B10
	private void InitCamera() { }

	// RVA: 0x2DC4C10 Offset: 0x2DC4D11 VA: 0x2DC4C10
	private void CreatePlayerModel() { }

	// RVA: 0x2DC4C20 Offset: 0x2DC4D21 VA: 0x2DC4C20
	public bool IsReadyDragonModel() { }

	// RVA: 0x2DC4C30 Offset: 0x2DC4D31 VA: 0x2DC4C30
	private void CreateAssitModel() { }

	// RVA: 0x2DC4C40 Offset: 0x2DC4D41 VA: 0x2DC4C40
	public bool IsReadyAssistModel() { }

	// RVA: 0x2DC4C50 Offset: 0x2DC4D51 VA: 0x2DC4C50
	private void InstantTargetGroup(Transform targetTrans, string parentID, string patternID, BillboardTypes billboardType, bool activeSoon) { }

	// RVA: 0x2DC4DC0 Offset: 0x2DC4EC1 VA: 0x2DC4DC0
	private void InitTarget() { }

	// RVA: 0x2DC4FF0 Offset: 0x2DC50F1 VA: 0x2DC4FF0
	private void InitReload() { }

	// RVA: 0x2DC59F0 Offset: 0x2DC5AF1 VA: 0x2DC59F0
	private void LoadResource() { }

	// RVA: 0x2DC5C40 Offset: 0x2DC5D41 VA: 0x2DC5C40
	private bool IsLoadFinish() { }

	// RVA: 0x2DC5ED0 Offset: 0x2DC5FD1 VA: 0x2DC5ED0
	private void UnloadResource() { }

	// RVA: 0x2DC6100 Offset: 0x2DC6201 VA: 0x2DC6100
	public void SetGroupVisible(string[] lctList, bool visible) { }

	// RVA: 0x2DC7150 Offset: 0x2DC7251 VA: 0x2DC7150
	private void JumpMain() { }

	// RVA: 0x2DC7EE0 Offset: 0x2DC7FE1 VA: 0x2DC7EE0
	private void JumpRetire() { }

	// RVA: 0x2DC8250 Offset: 0x2DC8351 VA: 0x2DC8250
	private void TickRetire() { }

	// RVA: 0x2DC82F0 Offset: 0x2DC83F1 VA: 0x2DC82F0
	private void InitFake() { }

	// RVA: 0x2DC8300 Offset: 0x2DC8401 VA: 0x2DC8300
	private void TickFakeLoad() { }

	// RVA: 0x2DC8450 Offset: 0x2DC8551 VA: 0x2DC8450
	private void StartMain() { }

	// RVA: 0x2DC8460 Offset: 0x2DC8561 VA: 0x2DC8460
	private void Main() { }

	// RVA: 0x2DCA0D0 Offset: 0x2DCA1D1 VA: 0x2DCA0D0
	private void FinishMain() { }

	// RVA: 0x2DCA330 Offset: 0x2DCA431 VA: 0x2DCA330
	private void CameraFadeIn() { }

	// RVA: 0x2DCA340 Offset: 0x2DCA441 VA: 0x2DCA340
	private void SetResultSeq() { }

	// RVA: 0x2DCA350 Offset: 0x2DCA451 VA: 0x2DCA350
	private int CalcRankNum(int level, int score) { }

	// RVA: 0x2DCA3F0 Offset: 0x2DCA4F1 VA: 0x2DCA3F0
	private void CreateResultUI() { }

	// RVA: 0x2DCCD70 Offset: 0x2DCCE71 VA: 0x2DCCD70
	private void TickResult() { }

	// RVA: 0x2DCD4A0 Offset: 0x2DCD5A1 VA: 0x2DCD4A0
	private void TickResultCloseWait() { }

	// RVA: 0x2DCD570 Offset: 0x2DCD671 VA: 0x2DCD570
	private void SetMascotBond() { }

	// RVA: 0x2DCD6E0 Offset: 0x2DCD7E1 VA: 0x2DCD6E0
	private void IncreasePlayCounter() { }

	// RVA: 0x2DCD850 Offset: 0x2DCD951 VA: 0x2DCD850
	private void Exit() { }

	// RVA: 0x2DCE120 Offset: 0x2DCE221 VA: 0x2DCE120 Slot: 15
	protected override void OnShutdown() { }

	// RVA: 0x2DCE190 Offset: 0x2DCE291 VA: 0x2DCE190
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2DCF640 Offset: 0x2DCF741 VA: 0x2DCF640
	public void .ctor() { }
}

