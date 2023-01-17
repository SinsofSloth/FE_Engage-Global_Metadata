// Namespace: App
public class GmapWholeMapController : MonoBehaviour // TypeDefIndex: 10360
{
	// Fields
	private const string PrefabPath = "UI/Gmap/Prefabs/GmapWholeMapRoot";
	private const string GmapGodPath = "UI/Gmap/Textures/Gmap2DView_G";
	private const string GmapEvilPath = "UI/Gmap/Textures/Gmap2DView_E";
	[SerializeField] // RVA: 0x28DEB0 Offset: 0x28DFB1 VA: 0x28DEB0
	private Sprite m_MapImageBefore; // 0x18
	[SerializeField] // RVA: 0x28DEC0 Offset: 0x28DFC1 VA: 0x28DEC0
	private Sprite m_MapImageAfter; // 0x20
	private static string s_LoadedPath; // 0x0
	private CanvasGroup m_CanvasGroup; // 0x28
	private InterpolatorFloat m_Alpha; // 0x30

	// Methods

	// RVA: 0x2CE77D0 Offset: 0x2CE78D1 VA: 0x2CE77D0
	public static void LoadPrefabAsync() { }

	// RVA: 0x2CE7B10 Offset: 0x2CE7C11 VA: 0x2CE7B10
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2CE6C10 Offset: 0x2CE6D11 VA: 0x2CE6C10
	public static void UnloadPrefab() { }

	// RVA: 0x2CE9210 Offset: 0x2CE9311 VA: 0x2CE9210
	public static GmapWholeMapController Create() { }

	// RVA: 0x2CE6B90 Offset: 0x2CE6C91 VA: 0x2CE6B90
	public static void Destroy(GmapWholeMapController content) { }

	// RVA: 0x2CF8000 Offset: 0x2CF8101 VA: 0x2CF8000
	private static string GetDlcPath() { }

	// RVA: 0x2CF80C0 Offset: 0x2CF81C1 VA: 0x2CF80C0
	private void Awake() { }

	// RVA: 0x2CF81A0 Offset: 0x2CF82A1 VA: 0x2CF81A0
	private void SetSprite() { }

	// RVA: 0x2CF8370 Offset: 0x2CF8471 VA: 0x2CF8370
	private void Update() { }

	// RVA: 0x2CF8360 Offset: 0x2CF8461 VA: 0x2CF8360
	public void SetAlpha(float alpha, float time = 0) { }

	// RVA: 0x2CF84D0 Offset: 0x2CF85D1 VA: 0x2CF84D0
	public void .ctor() { }

	// RVA: 0x2CF8550 Offset: 0x2CF8651 VA: 0x2CF8550
	private static void .cctor() { }
}

