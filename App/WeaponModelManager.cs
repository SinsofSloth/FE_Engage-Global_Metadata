// Namespace: App
public abstract class WeaponModelManager : MonoBehaviour // TypeDefIndex: 14069
{
	// Fields
	private static AssetTable.Result s_AssetTableResult; // 0x0
	private Dictionary<int, ResourceGameObject> m_Resources; // 0x18
	private Dictionary<int, GameObject> m_GmaeObjects; // 0x20

	// Methods

	// RVA: 0x26CCD90 Offset: 0x26CCE91 VA: 0x26CCD90
	private GameObject TryCreateGameObject(int key, string name, string child) { }

	// RVA: 0x26CD2D0 Offset: 0x26CD3D1 VA: 0x26CD2D0
	public void Show(string iid) { }

	// RVA: 0x26CD150 Offset: 0x26CD251 VA: 0x26CD150
	private void Show(GameObject root) { }

	// RVA: 0x26CD360 Offset: 0x26CD461 VA: 0x26CD360
	public void Show(ItemData item) { }

	// RVA: 0x26CD770 Offset: 0x26CD871 VA: 0x26CD770
	public void Hide() { }

	// RVA: 0x26CD8A0 Offset: 0x26CD9A1 VA: 0x26CD8A0
	public void Clear() { }

	// RVA: 0x26CDB80 Offset: 0x26CDC81 VA: 0x26CDB80
	private void OnDestroy() { }

	// RVA: 0x26CDB90 Offset: 0x26CDC91 VA: 0x26CDB90
	protected void .ctor() { }

	// RVA: 0x26CDC70 Offset: 0x26CDD71 VA: 0x26CDC70
	private static void .cctor() { }
}

