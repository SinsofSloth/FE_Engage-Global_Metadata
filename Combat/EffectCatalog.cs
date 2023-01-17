// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x274550 Offset: 0x274651 VA: 0x274550
public sealed class EffectCatalog : SingletonMonoBehaviour<EffectCatalog> // TypeDefIndex: 8734
{
	// Fields
	[SerializeField] // RVA: 0x284070 Offset: 0x284171 VA: 0x284070
	private GameObject[] EffectPrefab; // 0x20
	private int[] m_HashTable; // 0x28

	// Methods

	// RVA: 0x25F1400 Offset: 0x25F1501 VA: 0x25F1400 Slot: 4
	protected override void Awake() { }

	// RVA: 0x25F1580 Offset: 0x25F1681 VA: 0x25F1580
	public static GameObject Create(string name, Transform parent) { }

	// RVA: 0x25F19C0 Offset: 0x25F1AC1 VA: 0x25F19C0
	public static GameObject Create(string name, Vector3 pos) { }

	// RVA: 0x25F1AA0 Offset: 0x25F1BA1 VA: 0x25F1AA0
	public static GameObject Create(string name, Vector3 pos, Vector3 dir) { }

	// RVA: 0x25F1BD0 Offset: 0x25F1CD1 VA: 0x25F1BD0
	public static GameObject Create(string name, TR tr) { }

	// RVA: 0x25F1C90 Offset: 0x25F1D91 VA: 0x25F1C90
	public void .ctor() { }
}

