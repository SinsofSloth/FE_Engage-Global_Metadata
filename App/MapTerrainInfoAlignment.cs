// Namespace: App
public class MapTerrainInfoAlignment : MonoBehaviour // TypeDefIndex: 12496
{
	// Fields
	public MapTerrainInfoAlignment.Type m_Type; // 0x18
	[HeaderAttribute] // RVA: 0x29A380 Offset: 0x29A481 VA: 0x29A380
	[SerializeField] // RVA: 0x29A380 Offset: 0x29A481 VA: 0x29A380
	private List<GameObject> m_InversionObjList; // 0x20
	[HeaderAttribute] // RVA: 0x29A3D0 Offset: 0x29A4D1 VA: 0x29A3D0
	[SerializeField] // RVA: 0x29A3D0 Offset: 0x29A4D1 VA: 0x29A3D0
	private float m_WidthMax; // 0x28
	[HeaderAttribute] // RVA: 0x29A420 Offset: 0x29A521 VA: 0x29A420
	[SerializeField] // RVA: 0x29A420 Offset: 0x29A521 VA: 0x29A420
	private GameObject m_MapTerrainObj; // 0x30
	[SerializeField] // RVA: 0x29A470 Offset: 0x29A571 VA: 0x29A470
	[HeaderAttribute] // RVA: 0x29A470 Offset: 0x29A571 VA: 0x29A470
	private GameObject m_TitleObj; // 0x38
	[SerializeField] // RVA: 0x29A4C0 Offset: 0x29A5C1 VA: 0x29A4C0
	private GameObject m_TerrainObj; // 0x40
	[SerializeField] // RVA: 0x29A4D0 Offset: 0x29A5D1 VA: 0x29A4D0
	private GameObject m_OverlapObj; // 0x48
	[SerializeField] // RVA: 0x29A4E0 Offset: 0x29A5E1 VA: 0x29A4E0
	private List<GameObject> m_OverlapObjList; // 0x50
	[HeaderAttribute] // RVA: 0x29A4F0 Offset: 0x29A5F1 VA: 0x29A4F0
	[SerializeField] // RVA: 0x29A4F0 Offset: 0x29A5F1 VA: 0x29A4F0
	private GameObject m_CannonInfoObj; // 0x58
	[SerializeField] // RVA: 0x29A540 Offset: 0x29A641 VA: 0x29A540
	private List<GameObject> m_CannonInfoObjList; // 0x60
	[HeaderAttribute] // RVA: 0x29A550 Offset: 0x29A651 VA: 0x29A550
	[SerializeField] // RVA: 0x29A550 Offset: 0x29A651 VA: 0x29A550
	private GameObject m_DetailsObj; // 0x68
	[HeaderAttribute] // RVA: 0x29A5A0 Offset: 0x29A6A1 VA: 0x29A5A0
	[SerializeField] // RVA: 0x29A5A0 Offset: 0x29A6A1 VA: 0x29A5A0
	private GameObject m_MapTerrainEffectsObj; // 0x70
	[SerializeField] // RVA: 0x29A5F0 Offset: 0x29A6F1 VA: 0x29A5F0
	private RectTransform m_MapTerrainEffectsPointRectTransform; // 0x78
	[HeaderAttribute] // RVA: 0x29A600 Offset: 0x29A701 VA: 0x29A600
	[SerializeField] // RVA: 0x29A600 Offset: 0x29A701 VA: 0x29A600
	private GameObject m_MapTerrainEffectsContentsObj; // 0x80
	[SerializeField] // RVA: 0x29A650 Offset: 0x29A751 VA: 0x29A650
	private List<GameObject> m_MapTerrainEffectsContentsObjList; // 0x88
	[SerializeField] // RVA: 0x29A660 Offset: 0x29A761 VA: 0x29A660
	[HeaderAttribute] // RVA: 0x29A660 Offset: 0x29A761 VA: 0x29A660
	private GameObject m_SkillObj; // 0x90
	[SerializeField] // RVA: 0x29A6B0 Offset: 0x29A7B1 VA: 0x29A6B0
	private RectTransform m_SkillPointRectTransform; // 0x98
	[HeaderAttribute] // RVA: 0x29A6C0 Offset: 0x29A7C1 VA: 0x29A6C0
	[SerializeField] // RVA: 0x29A6C0 Offset: 0x29A7C1 VA: 0x29A6C0
	private GameObject m_SkillContentsObj; // 0xA0
	[SerializeField] // RVA: 0x29A710 Offset: 0x29A811 VA: 0x29A710
	private GameObject m_SkillContentsTitleObj; // 0xA8
	[SerializeField] // RVA: 0x29A720 Offset: 0x29A821 VA: 0x29A720
	private GameObject m_SkillIconObj; // 0xB0
	[SerializeField] // RVA: 0x29A730 Offset: 0x29A831 VA: 0x29A730
	private List<GameObject> m_SkillIconList; // 0xB8
	[SerializeField] // RVA: 0x29A740 Offset: 0x29A841 VA: 0x29A740
	[HeaderAttribute] // RVA: 0x29A740 Offset: 0x29A841 VA: 0x29A740
	private float m_SkillIconWidth; // 0xC0
	private bool m_IsCompress; // 0xC4
	private MapTerrainInfoAlignment.AlignParent m_RootAlignParent; // 0xC8
	private MapTerrainInfoAlignment.AlignParent m_MapTerrainAlignParent; // 0xD0
	private MapTerrainInfoAlignment.AlignParent m_DetailsAlignParent; // 0xD8
	private MapTerrainInfoAlignment.AlignParent m_MapTerrainEffectsAlignParent; // 0xE0
	private MapTerrainInfoAlignment.AlignParent m_SkillAlignParent; // 0xE8
	private MapTerrainInfoAlignment.AlignParent m_TitleAlignParent; // 0xF0
	private MapTerrainInfoAlignment.AlignParent m_OverlapAlignParent; // 0xF8
	private MapTerrainInfoAlignment.AlignParent m_CannonInfoAlignParent; // 0x100
	private MapTerrainInfoAlignment.AlignParent m_MapTerrainEffectsContentsAlignParent; // 0x108
	private MapTerrainInfoAlignment.AlignParent m_SkillContentsAlignParent; // 0x110
	private MapTerrainInfoAlignment.AlignParent m_SkillIconAlignParent; // 0x118
	private MapTerrainInfoAlignment.AlignMember m_TerrainAlignMember; // 0x120
	private MapTerrainInfoAlignment.AlignMember m_SkillContentsTitleAlignMember; // 0x128
	private List<MapTerrainInfoAlignment.AlignMember> m_FirstLeftList; // 0x130
	private List<MapTerrainInfoAlignment.AlignMember> m_FirstRightList; // 0x138
	private List<MapTerrainInfoAlignment.AlignMember> m_SecondList; // 0x140
	private List<MapTerrainInfoAlignment.AlignMember> m_ThirdList; // 0x148
	private List<MapTerrainInfoAlignment.InversionMember> m_InversionMemberList; // 0x150

	// Methods

	// RVA: 0x2753B00 Offset: 0x2753C01 VA: 0x2753B00
	private void Start() { }

	// RVA: 0x27542D0 Offset: 0x27543D1 VA: 0x27542D0
	public void Alignment() { }

	// RVA: 0x2754530 Offset: 0x2754631 VA: 0x2754530
	private Vector2 AlignmentFirst(float rate = 1) { }

	// RVA: 0x2754B30 Offset: 0x2754C31 VA: 0x2754B30
	private Vector2 AlignmentSecond(float rate = 1) { }

	// RVA: 0x2754F30 Offset: 0x2755031 VA: 0x2754F30
	private Vector2 AlignmentThird(float rate = 1) { }

	// RVA: 0x2755400 Offset: 0x2755501 VA: 0x2755400
	public void .ctor() { }
}

