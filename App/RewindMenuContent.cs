// Namespace: App
public class RewindMenuContent : BasicMenuContent // TypeDefIndex: 12616
{
	// Fields
	private const string PrefabPath = "UI/Battle/Rewind/Prefabs/RewindRoot";
	public const int ShowRowMax = 11;
	public GameObject m_PlayerPhaseObj; // 0xE8
	public GameObject m_EnemyPhaseObj; // 0xF0
	public GameObject m_AllyPhaseObj; // 0xF8
	public GameObject m_Enemy2PhaseObj; // 0x100
	public GameObject m_ScrollArrowUpObj; // 0x108
	public GameObject m_ScrollArrowDownObj; // 0x110
	public GameObject m_RestRewindTimesObj; // 0x118
	public GameObject m_KeyHelpObj; // 0x120
	public Color m_ForcePlayerColor; // 0x128
	public Color m_ForceEnemyColor; // 0x138
	public Color m_ForceAllyColor; // 0x148
	public Color m_ForceEnemy2Color; // 0x158
	private Animator m_RootAnimator; // 0x168
	private RewindMenuContent.Phase m_PlayerPhase; // 0x170
	private RewindMenuContent.Phase m_EnemyPhase; // 0x178
	private RewindMenuContent.Phase m_AllyPhase; // 0x180
	private RewindMenuContent.Phase m_Enemy2Phase; // 0x188
	private RewindMenuContent.ScrollArrow m_ScrollArrowUp; // 0x190
	private RewindMenuContent.ScrollArrow m_ScrollArrowDown; // 0x198
	private RewindMenuContent.RestRewindTimes m_RestRewindTimes; // 0x1A0
	private RewindMenuContent.KeyHelp m_KeyHelp; // 0x1A8

	// Methods

	// RVA: 0x24D54B0 Offset: 0x24D55B1 VA: 0x24D54B0
	public void .ctor() { }

	// RVA: 0x24D5520 Offset: 0x24D5621 VA: 0x24D5520 Slot: 6
	public override bool IsOpening() { }

	// RVA: 0x24D55D0 Offset: 0x24D56D1 VA: 0x24D55D0 Slot: 7
	public override bool IsClosing() { }

	// RVA: 0x24D5680 Offset: 0x24D5781 VA: 0x24D5680 Slot: 8
	public override bool IsClosed() { }

	// RVA: 0x24D5730 Offset: 0x24D5831 VA: 0x24D5730 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x24D5740 Offset: 0x24D5841 VA: 0x24D5740
	public RewindMenuItemContent GetRewindMenuItemContent(int itemIndex) { }

	// RVA: 0x24D5810 Offset: 0x24D5911 VA: 0x24D5810 Slot: 13
	protected override void InitObjReference() { }

	// RVA: 0x24D5900 Offset: 0x24D5A01 VA: 0x24D5900 Slot: 18
	public override void BuildMenuItemContent() { }

	// RVA: 0x24D5AA0 Offset: 0x24D5BA1 VA: 0x24D5AA0 Slot: 20
	public override void BuildWH() { }

	// RVA: 0x24D5AB0 Offset: 0x24D5BB1 VA: 0x24D5AB0 Slot: 21
	public override float CalcW() { }

	// RVA: 0x24D5AC0 Offset: 0x24D5BC1 VA: 0x24D5AC0 Slot: 22
	public override float CalcH() { }

	// RVA: 0x24D5AD0 Offset: 0x24D5BD1 VA: 0x24D5AD0 Slot: 28
	protected override void CycleMenuItemContent(bool isForward, int cycleCount) { }

	// RVA: 0x24D5AE0 Offset: 0x24D5BE1 VA: 0x24D5AE0 Slot: 29
	protected override float GetLineHeightForScroll() { }

	// RVA: 0x24D5AF0 Offset: 0x24D5BF1 VA: 0x24D5AF0 Slot: 30
	protected override void Awake() { }

	// RVA: 0x24D5D30 Offset: 0x24D5E31 VA: 0x24D5D30 Slot: 31
	protected override void Start() { }

	// RVA: 0x24D5D40 Offset: 0x24D5E41 VA: 0x24D5D40 Slot: 32
	protected override void Update() { }

	// RVA: 0x24D5E70 Offset: 0x24D5F71 VA: 0x24D5E70 Slot: 27
	public override void AfterBuild() { }

	// RVA: 0x24D5E80 Offset: 0x24D5F81 VA: 0x24D5E80 Slot: 15
	public override void Suspend() { }

	// RVA: 0x24D5E90 Offset: 0x24D5F91 VA: 0x24D5E90 Slot: 16
	public override void UnSuspend() { }

	// RVA: 0x24D45D0 Offset: 0x24D46D1 VA: 0x24D45D0
	public void UpdateParts(Force.Type currentForceType, int turn, int restUnitNum) { }

	// RVA: 0x24D3910 Offset: 0x24D3A11 VA: 0x24D3910
	public bool IsMenuItemMoving() { }

	// RVA: 0x24D4190 Offset: 0x24D4291 VA: 0x24D4190
	public void MoveUp(int scrollCount) { }

	// RVA: 0x24D3E10 Offset: 0x24D3F11 VA: 0x24D3E10
	public void MoveDown(int scrollCount) { }

	// RVA: 0x24D61B0 Offset: 0x24D62B1 VA: 0x24D61B0
	public static void LoadAsync() { }

	// RVA: 0x24D6230 Offset: 0x24D6331 VA: 0x24D6230
	public static void Unload() { }

	// RVA: 0x24D62B0 Offset: 0x24D63B1 VA: 0x24D62B0
	public static bool IsLoading() { }

	// RVA: 0x24D5400 Offset: 0x24D5501 VA: 0x24D5400
	public static RewindMenuContent CreateContent() { }
}

