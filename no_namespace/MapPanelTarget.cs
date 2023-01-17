// Namespace: 
public class MapPanelTarget : MapPanelBase<MapPanelTarget> // TypeDefIndex: 7639
{
	// Fields
	public GameCurve m_MovingAlpha; // 0x40
	public GameCurve m_StoppedAlpha; // 0x48
	private const float m_TargetTexW = 0.25;
	private Dictionary<int, MapPanelTarget.DangerType> m_DangerUnits; // 0x50
	[SerializeField] // RVA: 0x27B610 Offset: 0x27B711 VA: 0x27B610
	[SpaceAttribute] // RVA: 0x27B610 Offset: 0x27B711 VA: 0x27B610
	[HeaderAttribute] // RVA: 0x27B610 Offset: 0x27B711 VA: 0x27B610
	private Material m_GeneralMaterial; // 0x58
	[SerializeField] // RVA: 0x27B670 Offset: 0x27B771 VA: 0x27B670
	private Material m_EngageMaterial; // 0x60
	[SerializeField] // RVA: 0x27B680 Offset: 0x27B781 VA: 0x27B680
	private Material m_GunnerMaterial; // 0x68
	[SerializeField] // RVA: 0x27B690 Offset: 0x27B791 VA: 0x27B690
	private Material m_FullBulletMaterial; // 0x70
	[SerializeField] // RVA: 0x27B6A0 Offset: 0x27B7A1 VA: 0x27B6A0
	[HeaderAttribute] // RVA: 0x27B6A0 Offset: 0x27B7A1 VA: 0x27B6A0
	[SpaceAttribute] // RVA: 0x27B6A0 Offset: 0x27B7A1 VA: 0x27B6A0
	private Color m_DefaultColor; // 0x78
	[SerializeField] // RVA: 0x27B700 Offset: 0x27B801 VA: 0x27B700
	private Color m_DisadvantageColor; // 0x88
	[SerializeField] // RVA: 0x27B710 Offset: 0x27B811 VA: 0x27B710
	private Color m_CriticaledColor; // 0x98
	[SerializeField] // RVA: 0x27B720 Offset: 0x27B821 VA: 0x27B720
	private Color m_EngageColor; // 0xA8
	[SerializeField] // RVA: 0x27B730 Offset: 0x27B831 VA: 0x27B730
	private Color m_GunnerColor; // 0xB8
	[SpaceAttribute] // RVA: 0x27B740 Offset: 0x27B841 VA: 0x27B740
	[HeaderAttribute] // RVA: 0x27B740 Offset: 0x27B841 VA: 0x27B740
	[SerializeField] // RVA: 0x27B740 Offset: 0x27B841 VA: 0x27B740
	private Color m_FriendlyImpactColor; // 0xC8
	[SerializeField] // RVA: 0x27B7A0 Offset: 0x27B8A1 VA: 0x27B7A0
	private Color m_HostileImpactColor; // 0xD8
	[SpaceAttribute] // RVA: 0x27B7B0 Offset: 0x27B8B1 VA: 0x27B7B0
	[HeaderAttribute] // RVA: 0x27B7B0 Offset: 0x27B8B1 VA: 0x27B7B0
	[SerializeField] // RVA: 0x27B7B0 Offset: 0x27B8B1 VA: 0x27B7B0
	private AnimationCurve m_ScrollForGeneral; // 0xE8
	[SerializeField] // RVA: 0x27B810 Offset: 0x27B911 VA: 0x27B810
	private AnimationCurve m_ScrollForGunner; // 0xF0
	[SerializeField] // RVA: 0x27B820 Offset: 0x27B921 VA: 0x27B820
	[SpaceAttribute] // RVA: 0x27B820 Offset: 0x27B921 VA: 0x27B820
	[HeaderAttribute] // RVA: 0x27B820 Offset: 0x27B921 VA: 0x27B820
	private AnimationCurve m_AlphaCurve; // 0xF8
	[SpaceAttribute] // RVA: 0x27B880 Offset: 0x27B981 VA: 0x27B880
	[HeaderAttribute] // RVA: 0x27B880 Offset: 0x27B981 VA: 0x27B880
	[HeaderAttribute] // RVA: 0x27B880 Offset: 0x27B981 VA: 0x27B880
	[SerializeField] // RVA: 0x27B880 Offset: 0x27B981 VA: 0x27B880
	private float m_PositionZOffsetForGeneral; // 0x100
	[SerializeField] // RVA: 0x27B900 Offset: 0x27BA01 VA: 0x27B900
	private float m_PositionZOffsetForHorse; // 0x104
	[SerializeField] // RVA: 0x27B910 Offset: 0x27BA11 VA: 0x27B910
	private float m_PositionZOffsetForFly; // 0x108
	[SerializeField] // RVA: 0x27B920 Offset: 0x27BA21 VA: 0x27B920
	private float m_PositionZOffsetForBmapSize2; // 0x10C
	[SerializeField] // RVA: 0x27B930 Offset: 0x27BA31 VA: 0x27B930
	private float m_PositionZOffsetForBmapSize3; // 0x110
	[SerializeField] // RVA: 0x27B940 Offset: 0x27BA41 VA: 0x27B940
	private float m_PositionZOffsetForBmapSize5; // 0x114
	[SerializeField] // RVA: 0x27B950 Offset: 0x27BA51 VA: 0x27B950
	[HeaderAttribute] // RVA: 0x27B950 Offset: 0x27BA51 VA: 0x27B950
	[SpaceAttribute] // RVA: 0x27B950 Offset: 0x27BA51 VA: 0x27B950
	[HeaderAttribute] // RVA: 0x27B950 Offset: 0x27BA51 VA: 0x27B950
	private float m_ArchHeightOffset; // 0x118
	private List<Unit> m_GeneralAttackerList; // 0x120
	private List<Unit> m_EngageAttackerList; // 0x128
	private List<Unit> m_GunnerList; // 0x130
	private List<Unit> m_FullBulletList; // 0x138
	private Unit m_Target; // 0x140
	private int m_DestX; // 0x148
	private int m_DestZ; // 0x14C
	private int m_PropertyID; // 0x150
	private float m_Time; // 0x154
	private GameCurve m_Current; // 0x158
	private MapArrow m_Arrow; // 0x160
	private MapPanelTarget.DirtyType m_DirtyFlag; // 0x168

	// Properties
	public override int SubMeshCount { get; }
	public AnimationCurve AlphaCurve { get; }
	public float PositionZOffsetForGeneral { get; }
	public float PositionZOffsetForHorse { get; }
	public float PositionZOffsetForFly { get; }
	public float PositionZOffsetForBmapSize2 { get; }
	public float PositionZOffsetForBmapSize3 { get; }
	public float PositionZOffsetForBmapSize5 { get; }
	public float ArchHeightOffset { get; }

	// Methods

	// RVA: 0x2787C50 Offset: 0x2787D51 VA: 0x2787C50 Slot: 6
	public override int get_SubMeshCount() { }

	// RVA: 0x2787C60 Offset: 0x2787D61 VA: 0x2787C60 Slot: 4
	protected override void Awake() { }

	// RVA: 0x2787CC0 Offset: 0x2787DC1 VA: 0x2787CC0
	private void Start() { }

	// RVA: 0x2787E10 Offset: 0x2787F11 VA: 0x2787E10
	private void LateUpdate() { }

	// RVA: 0x2789050 Offset: 0x2789151 VA: 0x2789050 Slot: 5
	protected override Material[] GetSourceMaterials() { }

	// RVA: 0x27891B0 Offset: 0x27892B1 VA: 0x27891B0
	private void UpdateDangerUnits() { }

	// RVA: 0x2789600 Offset: 0x2789701 VA: 0x2789600
	private Unit GetTargetUnit() { }

	// RVA: 0x2789AD0 Offset: 0x2789BD1 VA: 0x2789AD0
	public bool IsEnemyAttackRange(Unit unit, int x, int z) { }

	// RVA: 0x2789E90 Offset: 0x2789F91 VA: 0x2789E90
	public void CommitForAttack(Unit unit, int x, int z) { }

	// RVA: 0x2787ED0 Offset: 0x2787FD1 VA: 0x2787ED0
	private void CommitForFullBullet() { }

	// RVA: 0x2788190 Offset: 0x2788291 VA: 0x2788190
	private void SetMesh() { }

	// RVA: 0x278A610 Offset: 0x278A711 VA: 0x278A610
	private void SetMeshForGeneralAttack(Vector3 destPos, Vector2 uv0, Vector2 uv2) { }

	// RVA: 0x278A880 Offset: 0x278A981 VA: 0x278A880
	private void SetMeshForEngageAttack(Vector3 destPos, Vector2 uv0, Vector2 uv2) { }

	// RVA: 0x278AA20 Offset: 0x278AB21 VA: 0x278AA20
	private void SetMeshForGunner(Vector3 destPos, Vector2 uv0, Vector2 uv2) { }

	// RVA: 0x278AC90 Offset: 0x278AD91 VA: 0x278AC90
	private void SetMeshForFullBullet(Vector2 uv0, Vector2 uv2) { }

	// RVA: 0x278A5D0 Offset: 0x278A6D1 VA: 0x278A5D0
	private bool IsTargetedForGeneralAttack(Unit enemy, int x, int z) { }

	// RVA: 0x278A530 Offset: 0x278A631 VA: 0x278A530
	private bool IsTargetedForEngageAttack(Unit enemy, Unit target) { }

	// RVA: 0x278A540 Offset: 0x278A641 VA: 0x278A540
	private bool IsTargetedForGunner(Unit enemy, int x, int z) { }

	// RVA: 0x278BED0 Offset: 0x278BFD1 VA: 0x278BED0
	public AnimationCurve get_AlphaCurve() { }

	// RVA: 0x278BEE0 Offset: 0x278BFE1 VA: 0x278BEE0
	public float get_PositionZOffsetForGeneral() { }

	// RVA: 0x278BEF0 Offset: 0x278BFF1 VA: 0x278BEF0
	public float get_PositionZOffsetForHorse() { }

	// RVA: 0x278BF00 Offset: 0x278C001 VA: 0x278BF00
	public float get_PositionZOffsetForFly() { }

	// RVA: 0x278BF10 Offset: 0x278C011 VA: 0x278BF10
	public float get_PositionZOffsetForBmapSize2() { }

	// RVA: 0x278BF20 Offset: 0x278C021 VA: 0x278BF20
	public float get_PositionZOffsetForBmapSize3() { }

	// RVA: 0x278BF30 Offset: 0x278C031 VA: 0x278BF30
	public float get_PositionZOffsetForBmapSize5() { }

	// RVA: 0x278BF40 Offset: 0x278C041 VA: 0x278BF40
	public float get_ArchHeightOffset() { }

	// RVA: 0x278BF50 Offset: 0x278C051 VA: 0x278BF50
	public void .ctor() { }
}

