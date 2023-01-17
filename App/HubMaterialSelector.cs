// Namespace: App
public abstract class HubMaterialSelector : MonoBehaviour // TypeDefIndex: 10696
{
	// Fields
	public GameObject m_target; // 0x18
	public List<GameObject> m_lods; // 0x20
	public uint m_submeshNo; // 0x28
	public Material m_materialMorning; // 0x30
	public Material m_materialDay; // 0x38
	public Material m_materialEvening; // 0x40
	public Material m_materialNight; // 0x48
	private List<Renderer> m_renderers; // 0x50

	// Methods

	// RVA: 0x2BE6780 Offset: 0x2BE6881 VA: 0x2BE6780
	private void Awake() { }

	// RVA: 0x2BE6A40 Offset: 0x2BE6B41 VA: 0x2BE6A40
	private void Start() { }

	// RVA: 0x2BE6AC0 Offset: 0x2BE6BC1 VA: 0x2BE6AC0
	public void Apply(HubUtil.TimezoneType timezoneType) { }

	// RVA: 0x2BE6C40 Offset: 0x2BE6D41 VA: 0x2BE6C40
	private void ReplaceMaterial(Material material) { }

	// RVA: 0x2BE6F70 Offset: 0x2BE7071 VA: 0x2BE6F70
	protected void .ctor() { }
}

