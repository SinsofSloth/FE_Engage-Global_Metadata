// Namespace: 
public class EncountIcon : MonoBehaviour // TypeDefIndex: 7698
{
	// Fields
	private const string PrefabPath = "UI/Gmap/Prefabs/GmapBossIcon";
	[CompilerGeneratedAttribute] // RVA: 0x27C470 Offset: 0x27C571 VA: 0x27C470
	private static GameObject <RootObject>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x27C480 Offset: 0x27C581 VA: 0x27C480
	private static GmapCamera <Camera>k__BackingField; // 0x8
	private static bool s_IsVisible; // 0x10
	private UnitIcon m_UnitIcon; // 0x18
	private bool m_IsColliderHit; // 0x20
	private GmapSpot m_GmapSpot; // 0x28
	private RectTransform m_RectTransform; // 0x30
	private List<GameObject> m_ChildObjects; // 0x38
	private bool m_Initialized; // 0x40

	// Properties
	public static GameObject RootObject { get; set; }
	public static GmapCamera Camera { get; set; }

	// Methods

	// RVA: 0x25F73D0 Offset: 0x25F74D1 VA: 0x25F73D0
	public static void LoadPrefabAsync() { }

	// RVA: 0x25F7470 Offset: 0x25F7571 VA: 0x25F7470
	public static bool IsLoadingPrefab() { }

	// RVA: 0x25F74F0 Offset: 0x25F75F1 VA: 0x25F74F0
	public static void UnloadPrefab() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A6D30 Offset: 0x2A6E31 VA: 0x2A6D30
	// RVA: 0x25F7570 Offset: 0x25F7671 VA: 0x25F7570
	public static GameObject get_RootObject() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A6D40 Offset: 0x2A6E41 VA: 0x2A6D40
	// RVA: 0x25F75C0 Offset: 0x25F76C1 VA: 0x25F75C0
	public static void set_RootObject(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A6D50 Offset: 0x2A6E51 VA: 0x2A6D50
	// RVA: 0x25F7620 Offset: 0x25F7721 VA: 0x25F7620
	public static GmapCamera get_Camera() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A6D60 Offset: 0x2A6E61 VA: 0x2A6D60
	// RVA: 0x25F7670 Offset: 0x25F7771 VA: 0x25F7670
	public static void set_Camera(GmapCamera value) { }

	// RVA: 0x25F76D0 Offset: 0x25F77D1 VA: 0x25F76D0
	public static EncountIcon Create(GmapSpot gmapSpot) { }

	// RVA: 0x25F7A60 Offset: 0x25F7B61 VA: 0x25F7A60
	public static void Destroy(EncountIcon encountIcon) { }

	// RVA: 0x25F77D0 Offset: 0x25F78D1 VA: 0x25F77D0
	public void Init(GmapSpot gmapSpot) { }

	// RVA: 0x25F7AE0 Offset: 0x25F7BE1 VA: 0x25F7AE0
	private void SetIcon() { }

	// RVA: 0x25F7E80 Offset: 0x25F7F81 VA: 0x25F7E80
	private void LateUpdate() { }

	// RVA: 0x25F8360 Offset: 0x25F8461 VA: 0x25F8360
	private void UpdateVisible() { }

	// RVA: 0x25F8520 Offset: 0x25F8621 VA: 0x25F8520
	public static void Show() { }

	// RVA: 0x25F8570 Offset: 0x25F8671 VA: 0x25F8570
	public static void Hide() { }

	// RVA: 0x25F85C0 Offset: 0x25F86C1 VA: 0x25F85C0
	public void .ctor() { }
}

