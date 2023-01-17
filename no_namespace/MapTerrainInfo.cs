// Namespace: 
public class MapTerrainInfo.MapTerrainInfoSingle // TypeDefIndex: 12489
{
	// Fields
	private GameObject m_GameObject; // 0x10
	private GameObject[] m_ElemGameObjects; // 0x18
	private TextMeshProUGUI[] m_ElemTitleTextMeshes; // 0x20
	private TextMeshProUGUI[] m_ElemValueTextMeshes; // 0x28
	private bool m_IsValid; // 0x30
	private bool m_IsShow; // 0x31
	private bool m_IsEventShow; // 0x32
	private GameObject m_Border; // 0x38
	private GameObject m_EffectRoot; // 0x40
	private GameObject m_SkillRoot; // 0x48
	private MapTerrainInfoAlignment m_Alignment; // 0x50
	private MapTerrainInfo.Side m_Side; // 0x58

	// Methods

	// RVA: 0x2140970 Offset: 0x2140A71 VA: 0x2140970
	public void CreateObjects(GameObject prefabObj, MapTerrainInfo.Side side) { }

	// RVA: 0x21411D0 Offset: 0x21412D1 VA: 0x21411D0
	private void CreateElement(MapTerrainInfo.Element elem, GameObject parentObj, string objName) { }

	// RVA: 0x2141010 Offset: 0x2141111 VA: 0x2141010
	private void CreatePairElement(MapTerrainInfo.Element elem, GameObject parentObj, string objName) { }

	// RVA: 0x2141310 Offset: 0x2141411 VA: 0x2141310
	public void DestroyObjects() { }

	// RVA: 0x21336B0 Offset: 0x21337B1 VA: 0x21336B0
	public void Show() { }

	// RVA: 0x2133400 Offset: 0x2133501 VA: 0x2133400
	public void Hide() { }

	// RVA: 0x2141700 Offset: 0x2141801 VA: 0x2141700
	public void EventShow() { }

	// RVA: 0x2141720 Offset: 0x2141821 VA: 0x2141720
	public void EventHide() { }

	// RVA: 0x2141730 Offset: 0x2141831 VA: 0x2141730
	public bool IsShow() { }

	// RVA: 0x2141410 Offset: 0x2141511 VA: 0x2141410
	private void SetVisible(bool isVisible) { }

	// RVA: 0x21418F0 Offset: 0x21419F1 VA: 0x21418F0
	private static TerrainData GetTerrain(int x, int z) { }

	// RVA: 0x2141A40 Offset: 0x2141B41 VA: 0x2141A40
	public void Set(int x, int z) { }

	// RVA: 0x2143C00 Offset: 0x2143D01 VA: 0x2143C00
	public void Set(TerrainData terrain) { }

	// RVA: 0x2141B30 Offset: 0x2141C31 VA: 0x2141B30
	public void SetImpl(TerrainData terrain, TerrainData overlap, int x, int z) { }

	// RVA: 0x2143DC0 Offset: 0x2143EC1 VA: 0x2143DC0
	private void SetElement(MapTerrainInfo.Element element, string name, int value, bool isForce = False, bool isColorReverse = False) { }

	// RVA: 0x2143C10 Offset: 0x2143D11 VA: 0x2143C10
	private void SetElement(MapTerrainInfo.Element element, string name, string value, bool isForce = False) { }

	// RVA: 0x21441F0 Offset: 0x21442F1 VA: 0x21441F0
	public void .ctor() { }
}

