// Namespace: UnityEngine.Rendering.Universal
[ExcludeFromPresetAttribute] // RVA: 0x47FA10 Offset: 0x47FB11 VA: 0x47FA10
[MovedFromAttribute] // RVA: 0x47FA10 Offset: 0x47FB11 VA: 0x47FA10
public abstract class ScriptableRendererFeature : ScriptableObject, IDisposable // TypeDefIndex: 5335
{
	// Fields
	[SerializeField] // RVA: 0x482BD0 Offset: 0x482CD1 VA: 0x482BD0
	[HideInInspector] // RVA: 0x482BD0 Offset: 0x482CD1 VA: 0x482BD0
	private bool m_Active; // 0x18

	// Properties
	public bool isActive { get; }

	// Methods

	// RVA: 0x312E6B0 Offset: 0x312E7B1 VA: 0x312E6B0
	public bool get_isActive() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Create();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData);

	// RVA: 0x312E6C0 Offset: 0x312E7C1 VA: 0x312E6C0
	private void OnEnable() { }

	// RVA: 0x312E6D0 Offset: 0x312E7D1 VA: 0x312E6D0
	private void OnValidate() { }

	// RVA: 0x312E6E0 Offset: 0x312E7E1 VA: 0x312E6E0
	public void SetActive(bool active) { }

	// RVA: 0x3129AC0 Offset: 0x3129BC1 VA: 0x3129AC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x312E6F0 Offset: 0x312E7F1 VA: 0x312E6F0 Slot: 7
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3126AA0 Offset: 0x3126BA1 VA: 0x3126AA0
	protected void .ctor() { }
}

