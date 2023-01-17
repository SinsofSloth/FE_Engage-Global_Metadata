// Namespace: App
public class DebugMipmapVisualizer : SingletonMonoBehaviour<DebugMipmapVisualizer> // TypeDefIndex: 8956
{
	// Fields
	public Shader m_Shader; // 0x20
	public Texture2D m_MipmapTexture; // 0x28
	private Dictionary<Renderer, Material[]> m_Backup; // 0x30
	private int m_MipmapTextureIndexProp; // 0x38

	// Methods

	// RVA: 0x2EA7020 Offset: 0x2EA7121 VA: 0x2EA7020
	private Material[] GetMaterials(Renderer render) { }

	// RVA: 0x2EA70C0 Offset: 0x2EA71C1 VA: 0x2EA70C0
	private void SetMaterials(Renderer render, Material[] materials) { }

	// RVA: 0x2EA7170 Offset: 0x2EA7271 VA: 0x2EA7170
	private bool CompareRenderers(Renderer[] a, Renderer[] b) { }

	// RVA: 0x2EA7390 Offset: 0x2EA7491 VA: 0x2EA7390
	private void OnEnable() { }

	// RVA: 0x2EA77D0 Offset: 0x2EA78D1 VA: 0x2EA77D0
	private void OnDisable() { }

	// RVA: 0x2EA79E0 Offset: 0x2EA7AE1 VA: 0x2EA79E0
	public void .ctor() { }
}

