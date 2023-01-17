// Namespace: App
public class MapPanelActive : MapPanelBase<MapPanelActive> // TypeDefIndex: 9049
{
	// Fields
	private List<MapPanelActive.MeshIndex>[] m_ImageList; // 0x40
	[HeaderAttribute] // RVA: 0x286540 Offset: 0x286641 VA: 0x286540
	[SpaceAttribute] // RVA: 0x286540 Offset: 0x286641 VA: 0x286540
	public Material m_MoveImage; // 0x48
	public Material m_AttackImage; // 0x50
	public Material m_HealImage; // 0x58
	public Material m_SupportImage; // 0x60
	public Material m_InterferenceImage; // 0x68
	public Material m_DanceImage; // 0x70
	public Material m_ActionImage; // 0x78
	public Material m_RangeImage; // 0x80
	public Material m_OverlapImage; // 0x88
	private MapMind.Type m_Mind; // 0x90
	private MapPanelDeploy.Mode m_Mode; // 0x94
	private MapPanelActive.FlagField m_Flag; // 0x98
	private bool m_IsUpdate; // 0xA0
	private InterpolatorFloat m_Alpha; // 0xA8
	[SerializeField] // RVA: 0x286590 Offset: 0x286691 VA: 0x286590
	[HeaderAttribute] // RVA: 0x286590 Offset: 0x286691 VA: 0x286590
	[SpaceAttribute] // RVA: 0x286590 Offset: 0x286691 VA: 0x286590
	private Color m_MoveColor; // 0xB0
	[SerializeField] // RVA: 0x2865F0 Offset: 0x2866F1 VA: 0x2865F0
	private Color m_AttackColor; // 0xC0
	[SerializeField] // RVA: 0x286600 Offset: 0x286701 VA: 0x286600
	private Color m_HealColor; // 0xD0
	[SerializeField] // RVA: 0x286610 Offset: 0x286711 VA: 0x286610
	private Color m_SupportColor; // 0xE0
	[SerializeField] // RVA: 0x286620 Offset: 0x286721 VA: 0x286620
	private Color m_InterferenceColor; // 0xF0
	[SerializeField] // RVA: 0x286630 Offset: 0x286731 VA: 0x286630
	private Color m_DanceColor; // 0x100
	[SerializeField] // RVA: 0x286640 Offset: 0x286741 VA: 0x286640
	private Color m_ActionColor; // 0x110
	[SerializeField] // RVA: 0x286650 Offset: 0x286751 VA: 0x286650
	private Color m_DragonVeinColor; // 0x120
	[SerializeField] // RVA: 0x286660 Offset: 0x286761 VA: 0x286660
	private Color m_OverlapColor; // 0x130
	[SerializeField] // RVA: 0x286670 Offset: 0x286771 VA: 0x286670
	private Color m_AttackRangeColor; // 0x140
	[SerializeField] // RVA: 0x286680 Offset: 0x286781 VA: 0x286680
	private Color m_HealRangeColor; // 0x150
	[SerializeField] // RVA: 0x286690 Offset: 0x286791 VA: 0x286690
	private Color m_SupportRangeColor; // 0x160
	[SerializeField] // RVA: 0x2866A0 Offset: 0x2867A1 VA: 0x2866A0
	private Color m_InterferenceRangeColor; // 0x170
	[SerializeField] // RVA: 0x2866B0 Offset: 0x2867B1 VA: 0x2866B0
	private Color m_WarpRangeColor; // 0x180
	[SerializeField] // RVA: 0x2866C0 Offset: 0x2867C1 VA: 0x2866C0
	private Color m_DanceRangeColor; // 0x190
	[SerializeField] // RVA: 0x2866D0 Offset: 0x2867D1 VA: 0x2866D0
	private Color m_ActionRangeColor; // 0x1A0
	private Color m_RangeColor; // 0x1B0
	private Color m_DisplayColor; // 0x1C0
	private MapImageCoreBit m_TempImage; // 0x1D0
	public GameCurve m_MovingAlpha; // 0x1D8
	public GameCurve m_StoppedAlpha; // 0x1E0
	private float m_Time; // 0x1E8
	private Unit m_Unit; // 0x1F0
	private static readonly Vector2Int[] AROUND; // 0x0
	private static readonly int[] ROTATION; // 0x8
	private static readonly Vector2Int[] FLAG; // 0x10

	// Properties
	public override int SubMeshCount { get; }
	public bool IsUpdate { set; }
	public MapMind.Type Mind { get; set; }
	public MapPanelActive.FlagField Flag { set; }
	public Color HealColor { get; }
	public Color ActionColor { get; }
	public Color DragonVeinColor { get; }
	public Color AttackRangeColor { get; }
	public Color HealRangeColor { get; }
	public Color SupportRangeColor { get; }
	public Color InterferenceRangeColor { get; }
	public Color WarpRangeColor { get; }
	public Color DanceRangeColor { get; }
	public Color ActionRangeColor { get; }
	public Color DisplayColor { set; }
	public Color RangeColor { get; set; }

	// Methods

	// RVA: 0x22188E0 Offset: 0x22189E1 VA: 0x22188E0 Slot: 6
	public override int get_SubMeshCount() { }

	// RVA: 0x22188F0 Offset: 0x22189F1 VA: 0x22188F0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2218950 Offset: 0x2218A51 VA: 0x2218950
	private void Start() { }

	// RVA: 0x2218A80 Offset: 0x2218B81 VA: 0x2218A80
	private void Update() { }

	// RVA: 0x2218E10 Offset: 0x2218F11 VA: 0x2218E10 Slot: 5
	protected override Material[] GetSourceMaterials() { }

	// RVA: 0x2218DE0 Offset: 0x2218EE1 VA: 0x2218DE0
	private void UpdatePanelAlpha() { }

	// RVA: 0x2219080 Offset: 0x2219181 VA: 0x2219080
	private void UpdateAlwaysPanelAlpha() { }

	// RVA: 0x22192C0 Offset: 0x22193C1 VA: 0x22192C0
	private void UpdateOrderPanelAlpha() { }

	// RVA: 0x2219580 Offset: 0x2219681 VA: 0x2219580
	public MapPanelDeploy.Mode GetMode() { }

	// RVA: 0x2219590 Offset: 0x2219691 VA: 0x2219590
	public void SetMode(MapPanelDeploy.Mode mode, bool isForceUpdate = False, SkillData commandSkill) { }

	// RVA: 0x2218C60 Offset: 0x2218D61 VA: 0x2218C60
	private void UpdateMode() { }

	// RVA: 0x2218DB0 Offset: 0x2218EB1 VA: 0x2218DB0
	private void UpdateVertex() { }

	// RVA: 0x221A210 Offset: 0x221A311 VA: 0x221A210
	public void SetUnit(Unit unit) { }

	// RVA: 0x221A220 Offset: 0x221A321 VA: 0x221A220
	public void set_IsUpdate(bool value) { }

	// RVA: 0x221A230 Offset: 0x221A331 VA: 0x221A230
	private bool CanTarget(Unit unit, Unit target) { }

	// RVA: 0x221A4B0 Offset: 0x221A5B1 VA: 0x221A4B0
	private bool CanAttack(Unit unit, Unit target) { }

	// RVA: 0x221A5B0 Offset: 0x221A6B1 VA: 0x221A5B0
	private bool CanUseRod(Unit unit, Unit target) { }

	// RVA: 0x221A6A0 Offset: 0x221A7A1 VA: 0x221A6A0
	private void EachTargetCell(int x, int z, int minRange, int maxRange, MapPanelActive.TargetFunc func) { }

	// RVA: 0x221A7E0 Offset: 0x221A8E1 VA: 0x221A7E0
	private void AddCell(List<RangeData.Offset> ranges, int x, int z, Color color, MapPanelBase.PanelType<MapPanelActive> type) { }

	// RVA: 0x2219CA0 Offset: 0x2219DA1 VA: 0x2219CA0
	private void SetVertex() { }

	// RVA: 0x221A9B0 Offset: 0x221AAB1 VA: 0x221A9B0
	private void SetMesh(MapDeployMoveImage image, MapPanelActive.MeshIndex index) { }

	// RVA: 0x221AE00 Offset: 0x221AF01 VA: 0x221AE00
	private void SetMesh(MapImageCoreBit image, MapPanelActive.MeshIndex index, Color color, MapDeployTemplate.DisplayType<MapDeploy> display, bool isIgnoreMoveImage = False) { }

	// RVA: 0x221B5B0 Offset: 0x221B6B1 VA: 0x221B5B0
	private bool CanSetMesh(int x, int z) { }

	// RVA: 0x221B360 Offset: 0x221B461 VA: 0x221B360
	private bool CanDrawMoveImage(int x, int z) { }

	// RVA: 0x221B900 Offset: 0x221BA01 VA: 0x221B900
	public MapMind.Type get_Mind() { }

	// RVA: 0x221B910 Offset: 0x221BA11 VA: 0x221B910
	public void set_Mind(MapMind.Type value) { }

	// RVA: 0x221B920 Offset: 0x221BA21 VA: 0x221B920
	public void set_Flag(MapPanelActive.FlagField value) { }

	// RVA: 0x221B930 Offset: 0x221BA31 VA: 0x221B930
	public Color get_HealColor() { }

	// RVA: 0x221B940 Offset: 0x221BA41 VA: 0x221B940
	public Color get_ActionColor() { }

	// RVA: 0x221B960 Offset: 0x221BA61 VA: 0x221B960
	public Color get_DragonVeinColor() { }

	// RVA: 0x221B980 Offset: 0x221BA81 VA: 0x221B980
	public Color get_AttackRangeColor() { }

	// RVA: 0x221B9A0 Offset: 0x221BAA1 VA: 0x221B9A0
	public Color get_HealRangeColor() { }

	// RVA: 0x221B9C0 Offset: 0x221BAC1 VA: 0x221B9C0
	public Color get_SupportRangeColor() { }

	// RVA: 0x221B9E0 Offset: 0x221BAE1 VA: 0x221B9E0
	public Color get_InterferenceRangeColor() { }

	// RVA: 0x221BA00 Offset: 0x221BB01 VA: 0x221BA00
	public Color get_WarpRangeColor() { }

	// RVA: 0x221BA20 Offset: 0x221BB21 VA: 0x221BA20
	public Color get_DanceRangeColor() { }

	// RVA: 0x221BA40 Offset: 0x221BB41 VA: 0x221BA40
	public Color get_ActionRangeColor() { }

	// RVA: 0x221BA60 Offset: 0x221BB61 VA: 0x221BA60
	public void set_DisplayColor(Color value) { }

	// RVA: 0x221BA80 Offset: 0x221BB81 VA: 0x221BA80
	public Color get_RangeColor() { }

	// RVA: 0x221BAA0 Offset: 0x221BBA1 VA: 0x221BAA0
	public void set_RangeColor(Color value) { }

	// RVA: 0x221BAC0 Offset: 0x221BBC1 VA: 0x221BAC0
	public void .ctor() { }

	// RVA: 0x221BC00 Offset: 0x221BD01 VA: 0x221BC00
	private static void .cctor() { }
}

