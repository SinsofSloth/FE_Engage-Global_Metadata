// Namespace: App
public class DebugOverlap : SingletonMonoBehaviour<DebugOverlap> // TypeDefIndex: 8958
{
	// Fields
	public Shader m_Shader; // 0x20
	private Camera m_Camera; // 0x28
	private CameraClearFlags m_ClearFlags; // 0x30
	private Color m_BackgroundColor; // 0x34
	private Dictionary<Renderer, Material[]> m_Renders; // 0x48

	// Methods

	// RVA: 0x2EA7B50 Offset: 0x2EA7C51 VA: 0x2EA7B50
	private Material[] GetMaterials(Renderer render) { }

	// RVA: 0x2EA7BF0 Offset: 0x2EA7CF1 VA: 0x2EA7BF0
	private void SetMaterials(Renderer render, Material[] materials) { }

	// RVA: 0x2EA7CA0 Offset: 0x2EA7DA1 VA: 0x2EA7CA0
	private void OnEnable() { }

	// RVA: 0x2EA80E0 Offset: 0x2EA81E1 VA: 0x2EA80E0
	private void OnDisable() { }

	// RVA: 0x2EA8330 Offset: 0x2EA8431 VA: 0x2EA8330
	public void .ctor() { }
}

