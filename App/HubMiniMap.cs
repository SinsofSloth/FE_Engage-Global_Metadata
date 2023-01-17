// Namespace: App
public class HubMiniMap : MonoBehaviour // TypeDefIndex: 10735
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x294C70 Offset: 0x294D71 VA: 0x294C70
	private int <EnvSoundColliderCount>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x294C80 Offset: 0x294D81 VA: 0x294C80
	private string <EnvSoundID>k__BackingField; // 0x20
	private bool m_initialized; // 0x28
	private ResourceHandle m_res; // 0x30
	private ResourceHandle m_image; // 0x38
	private HubMiniMap.MapMode m_prevMapMode; // 0x40
	private SpriteAtlasManager m_icon; // 0x48
	private GameObject m_gameRoot; // 0x50
	private GameObject m_root; // 0x58
	private GameObject m_iconPoint; // 0x60
	private GameObject m_iconLueur; // 0x68
	private GameObject m_iconItem; // 0x70
	private GameObject m_iconUnit; // 0x78
	private GameObject m_cameraArea; // 0x80
	private GameObject m_mapS; // 0x88
	private GameObject m_rotate; // 0x90
	private GameObject m_imageS; // 0x98
	private GameObject m_playerMarkerS; // 0xA0
	private GameObject m_playerCameraS; // 0xA8
	private GameObject m_mascotMarkerS; // 0xB0
	private GameObject m_mapL; // 0xB8
	private GameObject m_imageL; // 0xC0
	private GameObject m_playerMarkerL; // 0xC8
	private GameObject m_playerCameraL; // 0xD0
	private GameObject m_mascotMarkerL; // 0xD8
	private GameObject m_cafeS; // 0xE0
	private GameObject m_cafeL; // 0xE8
	private GameObject m_caveS; // 0xF0
	private GameObject m_caveL; // 0xF8
	private Sprite m_talkReliance; // 0x100
	private Sprite m_talkStory; // 0x108
	private Vector3 m_center; // 0x110
	private Vector3 m_size; // 0x11C
	private bool m_reverse; // 0x128
	private RectTransform m_rt; // 0x130
	private Rect m_uv; // 0x138
	private float m_offsetX; // 0x148
	private float m_offsetY; // 0x14C
	private bool m_systemShow; // 0x150
	private List<int> m_Layer; // 0x158
	private List<HubMiniMap.IconData> m_iconList; // 0x160

	// Properties
	private int EnvSoundColliderCount { get; set; }
	public string EnvSoundID { get; set; }
	private HubMiniMap.MapMode CurrentMapMode { get; set; }
	private bool IsMinimapRotate { get; }
	private bool IsMascotEnable { get; }

	// Methods

	// RVA: 0x2BEA1D0 Offset: 0x2BEA2D1 VA: 0x2BEA1D0
	public void NextChangeMode() { }

	// RVA: 0x2BE7C80 Offset: 0x2BE7D81 VA: 0x2BE7C80
	public void ShowSystemMenu() { }

	// RVA: 0x2BE7F80 Offset: 0x2BE8081 VA: 0x2BE7F80
	public void HideSystemMenu() { }

	// RVA: 0x2BEA4E0 Offset: 0x2BEA5E1 VA: 0x2BEA4E0
	public void Show() { }

	// RVA: 0x2BEA500 Offset: 0x2BEA601 VA: 0x2BEA500
	public void Hide() { }

	// RVA: 0x2BEA520 Offset: 0x2BEA621 VA: 0x2BEA520
	public void PushLayer(int layer) { }

	// RVA: 0x2BEA5C0 Offset: 0x2BEA6C1 VA: 0x2BEA5C0
	public void PopLayer(int layer) { }

	// RVA: 0x2BEA660 Offset: 0x2BEA761 VA: 0x2BEA660
	public void PushEnvSoundID(string id) { }

	// RVA: 0x2BEA6A0 Offset: 0x2BEA7A1 VA: 0x2BEA6A0
	public void PopEnvSoundID(string id) { }

	// RVA: 0x2BEA6B0 Offset: 0x2BEA7B1 VA: 0x2BEA6B0
	public bool IsCave() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0A50 Offset: 0x2C0B51 VA: 0x2C0A50
	// RVA: 0x2BEA730 Offset: 0x2BEA831 VA: 0x2BEA730
	private int get_EnvSoundColliderCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0A60 Offset: 0x2C0B61 VA: 0x2C0A60
	// RVA: 0x2BEA740 Offset: 0x2BEA841 VA: 0x2BEA740
	private void set_EnvSoundColliderCount(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0A70 Offset: 0x2C0B71 VA: 0x2C0A70
	// RVA: 0x2BEA750 Offset: 0x2BEA851 VA: 0x2BEA750
	public string get_EnvSoundID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0A80 Offset: 0x2C0B81 VA: 0x2C0A80
	// RVA: 0x2BEA760 Offset: 0x2BEA861 VA: 0x2BEA760
	private void set_EnvSoundID(string value) { }

	// RVA: 0x2BEA2F0 Offset: 0x2BEA3F1 VA: 0x2BEA2F0
	private HubMiniMap.MapMode get_CurrentMapMode() { }

	// RVA: 0x2BEA450 Offset: 0x2BEA551 VA: 0x2BEA450
	private void set_CurrentMapMode(HubMiniMap.MapMode value) { }

	// RVA: 0x2BEA770 Offset: 0x2BEA871 VA: 0x2BEA770
	private bool get_IsMinimapRotate() { }

	// RVA: 0x2BEA7F0 Offset: 0x2BEA8F1 VA: 0x2BEA7F0
	private bool get_IsMascotEnable() { }

	// RVA: 0x2BEA8B0 Offset: 0x2BEA9B1 VA: 0x2BEA8B0
	private HubMiniMapCaptureParam.CaptureParam1 GetCaptureParam(string mapName) { }

	[IteratorStateMachineAttribute] // RVA: 0x2C0A90 Offset: 0x2C0B91 VA: 0x2C0A90
	// RVA: 0x2BEAA70 Offset: 0x2BEAB71 VA: 0x2BEAA70
	public IEnumerator Load() { }

	// RVA: 0x2BEAAF0 Offset: 0x2BEABF1 VA: 0x2BEAAF0
	private void OnDestroy() { }

	// RVA: 0x2BEAC90 Offset: 0x2BEAD91 VA: 0x2BEAC90
	private void ClearIcon() { }

	// RVA: 0x2BEB090 Offset: 0x2BEB191 VA: 0x2BEB090
	private GameObject GetBasePoint(HubAccess access) { }

	// RVA: 0x2BEB160 Offset: 0x2BEB261 VA: 0x2BEB160
	private string GetDisposName(HubAccess access) { }

	// RVA: 0x2BEB300 Offset: 0x2BEB401 VA: 0x2BEB300
	private void Setup(GameObject root, string prefixlessCid) { }

	// RVA: 0x2BEBD70 Offset: 0x2BEBE71 VA: 0x2BEBD70
	public void Restore() { }

	// RVA: 0x2BECF50 Offset: 0x2BED051 VA: 0x2BECF50
	private void ArrangeIconPosition() { }

	// RVA: 0x2BED1F0 Offset: 0x2BED2F1 VA: 0x2BED1F0
	private bool IsShow() { }

	// RVA: 0x2BED310 Offset: 0x2BED411 VA: 0x2BED310
	private void Update() { }

	// RVA: 0x2BED4E0 Offset: 0x2BED5E1 VA: 0x2BED4E0
	private void Scroll() { }

	// RVA: 0x2BEA370 Offset: 0x2BEA471 VA: 0x2BEA370
	private void SetMode(HubMiniMap.MapMode mode) { }

	// RVA: 0x2BECE70 Offset: 0x2BECF71 VA: 0x2BECE70
	private Vector3 TransformPosition(Vector3 position) { }

	// RVA: 0x2BEE6E0 Offset: 0x2BEE7E1 VA: 0x2BEE6E0
	private Vector3 WorldToScreenPosition(Vector3 position) { }

	// RVA: 0x2BEE800 Offset: 0x2BEE901 VA: 0x2BEE800
	public void .ctor() { }
}

