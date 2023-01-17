// Namespace: App
public class DebugLodVisualizer : SingletonMonoBehaviour<DebugLodVisualizer> // TypeDefIndex: 8918
{
	// Fields
	public Shader m_Shader; // 0x20
	private Dictionary<Renderer, Material[]> m_Backup; // 0x28
	private int m_LodIndexProp; // 0x30

	// Methods

	// RVA: 0x2E9DAB0 Offset: 0x2E9DBB1 VA: 0x2E9DAB0
	private Material[] GetMaterials(Renderer render) { }

	// RVA: 0x2E9DB50 Offset: 0x2E9DC51 VA: 0x2E9DB50
	private void SetMaterials(Renderer render, Material[] materials) { }

	// RVA: 0x2E9DC00 Offset: 0x2E9DD01 VA: 0x2E9DC00
	private bool CompareRenderers(Renderer[] a, Renderer[] b) { }

	// RVA: 0x2E9DE20 Offset: 0x2E9DF21 VA: 0x2E9DE20
	private void OnEnable() { }

	// RVA: 0x2E9E3A0 Offset: 0x2E9E4A1 VA: 0x2E9E3A0
	private void OnDisable() { }

	// RVA: 0x2E9E580 Offset: 0x2E9E681 VA: 0x2E9E580
	public void .ctor() { }
}

