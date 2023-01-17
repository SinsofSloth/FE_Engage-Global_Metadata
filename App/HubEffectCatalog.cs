// Namespace: App
[DisallowMultipleComponent] // RVA: 0x2770D0 Offset: 0x2771D1 VA: 0x2770D0
public class HubEffectCatalog : SingletonMonoBehaviour<HubEffectCatalog> // TypeDefIndex: 10673
{
	// Fields
	[SerializeField] // RVA: 0x294370 Offset: 0x294471 VA: 0x294370
	private GameObject[] EffectPrefab; // 0x20
	private int[] m_HashTable; // 0x28

	// Methods

	// RVA: 0x305C0F0 Offset: 0x305C1F1 VA: 0x305C0F0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x305C270 Offset: 0x305C371 VA: 0x305C270
	public static bool Contains(string name) { }

	// RVA: 0x305C400 Offset: 0x305C501 VA: 0x305C400
	public static GameObject Create(string name, Transform parent) { }

	// RVA: 0x305C580 Offset: 0x305C681 VA: 0x305C580
	public static GameObject Create(string name, Vector3 pos) { }

	// RVA: 0x305C660 Offset: 0x305C761 VA: 0x305C660
	public static GameObject Create(string name, Vector3 pos, Vector3 dir) { }

	// RVA: 0x305C790 Offset: 0x305C891 VA: 0x305C790
	public void .ctor() { }
}

