// Namespace: App
[RequireComponent] // RVA: 0x274EA0 Offset: 0x274FA1 VA: 0x274EA0
[RequireComponent] // RVA: 0x274EA0 Offset: 0x274FA1 VA: 0x274EA0
public class MapInfoCircle : SingletonMonoBehaviour<MapInfoCircle> // TypeDefIndex: 9012
{
	// Fields
	private List<Unit> m_WarpUnitList; // 0x20
	[SpaceAttribute] // RVA: 0x2859C0 Offset: 0x285AC1 VA: 0x2859C0
	[HeaderAttribute] // RVA: 0x2859C0 Offset: 0x285AC1 VA: 0x2859C0
	public Material m_NormalCircle; // 0x28
	public Material m_BossCircle; // 0x30
	public Material m_LastBossCircle; // 0x38
	[SpaceAttribute] // RVA: 0x285A10 Offset: 0x285B11 VA: 0x285A10
	[HeaderAttribute] // RVA: 0x285A10 Offset: 0x285B11 VA: 0x285A10
	[SerializeField] // RVA: 0x285A10 Offset: 0x285B11 VA: 0x285A10
	private Color m_PlayerColor; // 0x40
	[SerializeField] // RVA: 0x285A70 Offset: 0x285B71 VA: 0x285A70
	private Color m_PlayerFixedColor; // 0x50
	[SerializeField] // RVA: 0x285A80 Offset: 0x285B81 VA: 0x285A80
	private Color m_EnemyColor; // 0x60
	[SerializeField] // RVA: 0x285A90 Offset: 0x285B91 VA: 0x285A90
	private Color m_EnemyFixedColor; // 0x70
	[SerializeField] // RVA: 0x285AA0 Offset: 0x285BA1 VA: 0x285AA0
	private Color m_AllyColor; // 0x80
	[SerializeField] // RVA: 0x285AB0 Offset: 0x285BB1 VA: 0x285AB0
	private Color m_AllyFixedColor; // 0x90
	[SerializeField] // RVA: 0x285AC0 Offset: 0x285BC1 VA: 0x285AC0
	private Color m_ThirdColor; // 0xA0
	[SerializeField] // RVA: 0x285AD0 Offset: 0x285BD1 VA: 0x285AD0
	private Color m_ThirdFixedColor; // 0xB0
	[SpaceAttribute] // RVA: 0x285AE0 Offset: 0x285BE1 VA: 0x285AE0
	[SerializeField] // RVA: 0x285AE0 Offset: 0x285BE1 VA: 0x285AE0
	private float m_TimesSpeed; // 0xC0
	[SerializeField] // RVA: 0x285B20 Offset: 0x285C21 VA: 0x285B20
	private float m_RotateSpeed; // 0xC4
	private MapInfoCircle.Animes m_Anime; // 0xC8
	private int m_SubMeshCount; // 0xCC
	private Color[] m_Colors; // 0xD0
	private Color[] m_FixedColors; // 0xD8
	private Unit m_ActiveUnit; // 0xE0
	private MapPos[] m_Cells; // 0xE8
	public Material[] m_Materials; // 0xF0
	private MapInfoCircle.CircleState m_State; // 0xF8
	private int m_PropertyID; // 0xFC
	private float m_Time; // 0x100
	private float m_UvRotate; // 0x104
	private bool m_IsActive; // 0x108
	private MapDeployAttackImage m_AttackImage; // 0x110
	private MapDeployRodImage m_RodImage; // 0x118
	private MapDeployHealImage m_HealImage; // 0x120
	private MapDeploySupportImage m_SupportImage; // 0x128
	private MapDeploySupportForUnitImage m_SupportForUnitImage; // 0x130
	private MapDeployInterferenceImage m_InterferenceImage; // 0x138
	private MapDeployActionImage m_ActionImage; // 0x140
	private MapDeployRangeImage m_RangeImage; // 0x148
	private MapDeployOverlapImage m_OverlapImage; // 0x150
	private MapDeployDanceImage m_DanceImage; // 0x158
	private MapDeployCannonImage m_CannonImage; // 0x160
	private Map.CellMesh m_Mesh; // 0x168
	private MeshRenderer m_Renderer; // 0x170
	private MapFor.UnitFunction m_DrawNormalCircle; // 0x178
	private MapFor.UnitFunction m_DrawBossCircle; // 0x180
	private MapFor.UnitFunction m_DrawLastBossCircle; // 0x188
	private MapFor.UnitFunction m_ResistWarpUnit; // 0x190
	private MapFor.UnitFunction m_ResistRewarpUnit; // 0x198

	// Methods

	// RVA: 0x2474990 Offset: 0x2474A91 VA: 0x2474990
	private void Start() { }

	// RVA: 0x2474EA0 Offset: 0x2474FA1 VA: 0x2474EA0
	private Material[] GetMaterials() { }

	// RVA: 0x2474FC0 Offset: 0x24750C1 VA: 0x2474FC0
	private Color GetColor(Unit unit, bool isCheckFixed = True) { }

	// RVA: 0x2475320 Offset: 0x2475421 VA: 0x2475320
	private bool CanTarget(Unit unit, Unit target) { }

	// RVA: 0x24755C0 Offset: 0x24756C1 VA: 0x24755C0
	private bool CanAttack(Unit unit, Unit target) { }

	// RVA: 0x24756C0 Offset: 0x24757C1 VA: 0x24756C0
	private bool CanDance(Unit dancer, Unit target) { }

	// RVA: 0x2475990 Offset: 0x2475A91 VA: 0x2475990
	private bool CanContract(Unit contractor, Unit target) { }

	// RVA: 0x2475BE0 Offset: 0x2475CE1 VA: 0x2475BE0
	private bool CanUseHealRod(Unit user, Unit target) { }

	// RVA: 0x2475F20 Offset: 0x2476021 VA: 0x2475F20
	private bool CanUseHealRod(Unit user, Unit target, ItemData itemData) { }

	// RVA: 0x2475F60 Offset: 0x2476061 VA: 0x2475F60
	private bool CanUseSupportRod(Unit user, Unit target) { }

	// RVA: 0x2476730 Offset: 0x2476831 VA: 0x2476730
	private bool CanUseSupportRod(Unit user, Unit target, ItemData itemData, bool isItemSelected = False) { }

	// RVA: 0x2476B70 Offset: 0x2476C71 VA: 0x2476B70
	private bool CanUseInterferenceRod(Unit user, Unit target) { }

	// RVA: 0x2476E20 Offset: 0x2476F21 VA: 0x2476E20
	private bool CanUseEngageRod(Unit unit, Unit target) { }

	// RVA: 0x2477280 Offset: 0x2477381 VA: 0x2477280
	private bool CanEnchantItem(Unit unit, Unit target) { }

	// RVA: 0x2477350 Offset: 0x2477451 VA: 0x2477350
	private void DrawCircle(Unit unit, int index) { }

	// RVA: 0x247D750 Offset: 0x247D851 VA: 0x247D750
	private void DrawNormalCircle(Unit unit) { }

	// RVA: 0x247D880 Offset: 0x247D981 VA: 0x247D880
	private void DrawBossCircle(Unit unit) { }

	// RVA: 0x247D9C0 Offset: 0x247DAC1 VA: 0x247D9C0
	private void DrawLastBossCircle(Unit unit) { }

	// RVA: 0x247B300 Offset: 0x247B401 VA: 0x247B300
	private bool IsDrawLowRotateCircle(Unit unit) { }

	// RVA: 0x247CCC0 Offset: 0x247CDC1 VA: 0x247CCC0
	private bool IsDrawHighRotateCircle(Unit unit) { }

	// RVA: 0x247DB00 Offset: 0x247DC01 VA: 0x247DB00
	private void LateUpdate() { }

	// RVA: 0x247E080 Offset: 0x247E181 VA: 0x247E080
	public void SetActive(bool active) { }

	// RVA: 0x247E0B0 Offset: 0x247E1B1 VA: 0x247E0B0
	public void SetUnit(Unit unit) { }

	// RVA: 0x247E0C0 Offset: 0x247E1C1 VA: 0x247E0C0
	public void SetAnime(MapInfoCircle.Animes anime) { }

	// RVA: 0x247E0D0 Offset: 0x247E1D1 VA: 0x247E0D0
	public void SetWarpUnit() { }

	// RVA: 0x247E160 Offset: 0x247E261 VA: 0x247E160
	public void SetRewarpUnit() { }

	// RVA: 0x247E1F0 Offset: 0x247E2F1 VA: 0x247E1F0
	private void ResistWarpUnit(Unit unit) { }

	// RVA: 0x247E320 Offset: 0x247E421 VA: 0x247E320
	private void ResistRewarpUnit(Unit unit) { }

	// RVA: 0x247E430 Offset: 0x247E531 VA: 0x247E430
	public void ClearWarpUnit() { }

	// RVA: 0x247E490 Offset: 0x247E591 VA: 0x247E490
	public void .ctor() { }
}

