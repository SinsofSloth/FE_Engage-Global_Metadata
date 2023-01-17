// Namespace: App
[DefaultExecutionOrder] // RVA: 0x2771E0 Offset: 0x2772E1 VA: 0x2771E0
[DisallowMultipleComponent] // RVA: 0x2771E0 Offset: 0x2772E1 VA: 0x2771E0
public abstract class HubMaterialArray : MonoBehaviour // TypeDefIndex: 10695
{
	// Fields
	public string m_objectTag; // 0x18
	public string m_activeMaterial; // 0x20
	public HubMaterialArray.MaterialInfo[] m_materials; // 0x28
	private Renderer m_renderer; // 0x30

	// Methods

	// RVA: 0x2BE6140 Offset: 0x2BE6241 VA: 0x2BE6140
	public void ChangeMaterial(string name) { }

	// RVA: 0x2BE6380 Offset: 0x2BE6481 VA: 0x2BE6380
	private void Awake() { }

	// RVA: 0x2BE6210 Offset: 0x2BE6311 VA: 0x2BE6210
	private void ReplaceMaterial(Material material) { }

	// RVA: 0x2BE63F0 Offset: 0x2BE64F1 VA: 0x2BE63F0
	private void OnDestroy() { }

	// RVA: 0x2BE64F0 Offset: 0x2BE65F1 VA: 0x2BE64F0
	protected void .ctor() { }
}

