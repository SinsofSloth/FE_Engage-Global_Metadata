// Namespace: App
public class ShopWeaponModelRenderer : MonoBehaviour // TypeDefIndex: 11220
{
	// Fields
	private static readonly string PrefabPath; // 0x0
	public Camera m_Camera; // 0x18
	public GameObject m_ModelRoot; // 0x20
	private string m_ModelPath; // 0x28
	private GameObject m_ModelObject; // 0x30
	private string m_ModelPathLoading; // 0x38
	private ItemData m_ItemData; // 0x40

	// Methods

	// RVA: 0x2340B50 Offset: 0x2340C51 VA: 0x2340B50
	public static void LoadPrefabAsync() { }

	// RVA: 0x2340C10 Offset: 0x2340D11 VA: 0x2340C10
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2340CB0 Offset: 0x2340DB1 VA: 0x2340CB0
	public static void UnloadPrefab() { }

	// RVA: 0x2340D50 Offset: 0x2340E51 VA: 0x2340D50
	public static ShopWeaponModelRenderer Create() { }

	// RVA: 0x2340ED0 Offset: 0x2340FD1 VA: 0x2340ED0
	private void CreateInternal() { }

	// RVA: 0x2340EE0 Offset: 0x2340FE1 VA: 0x2340EE0
	public void Destroy() { }

	// RVA: 0x2340FB0 Offset: 0x23410B1 VA: 0x2340FB0
	public RenderTexture GetRenderTexture() { }

	// RVA: 0x2341050 Offset: 0x2341151 VA: 0x2341050
	public void SetWeapon(ItemData itemData, bool delayLoading = True) { }

	// RVA: 0x2341220 Offset: 0x2341321 VA: 0x2341220
	private void LoadWeaponModel(ItemData itemData) { }

	// RVA: 0x23414C0 Offset: 0x23415C1 VA: 0x23414C0
	private void OnFinishLoadingWeapon(GameObject gameObjectIn) { }

	// RVA: 0x2340F80 Offset: 0x2341081 VA: 0x2340F80
	public void RemoveWeapon() { }

	// RVA: 0x2341780 Offset: 0x2341881 VA: 0x2341780
	private void RemoveWeaponCore() { }

	// RVA: 0x23418D0 Offset: 0x23419D1 VA: 0x23418D0
	public void .ctor() { }

	// RVA: 0x23418E0 Offset: 0x23419E1 VA: 0x23418E0
	private static void .cctor() { }
}

