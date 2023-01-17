// Namespace: UnityEngine.Rendering.Universal
[MovedFromAttribute] // RVA: 0x47F9D0 Offset: 0x47FAD1 VA: 0x47F9D0
public abstract class ScriptableRendererData : ScriptableObject // TypeDefIndex: 5334
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x482BA0 Offset: 0x482CA1 VA: 0x482BA0
	private bool <isInvalidated>k__BackingField; // 0x18
	[SerializeField] // RVA: 0x482BB0 Offset: 0x482CB1 VA: 0x482BB0
	internal List<ScriptableRendererFeature> m_RendererFeatures; // 0x20
	[SerializeField] // RVA: 0x482BC0 Offset: 0x482CC1 VA: 0x482BC0
	internal List<long> m_RendererFeatureMap; // 0x28

	// Properties
	internal bool isInvalidated { get; set; }
	public List<ScriptableRendererFeature> rendererFeatures { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x484790 Offset: 0x484891 VA: 0x484790
	// RVA: 0x312E550 Offset: 0x312E651 VA: 0x312E550
	internal bool get_isInvalidated() { }

	[CompilerGeneratedAttribute] // RVA: 0x4847A0 Offset: 0x4848A1 VA: 0x4847A0
	// RVA: 0x312E560 Offset: 0x312E661 VA: 0x312E560
	internal void set_isInvalidated(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract ScriptableRenderer Create();

	// RVA: 0x312E570 Offset: 0x312E671 VA: 0x312E570
	public List<ScriptableRendererFeature> get_rendererFeatures() { }

	// RVA: 0x312E580 Offset: 0x312E681 VA: 0x312E580
	public void SetDirty() { }

	// RVA: 0x312E590 Offset: 0x312E691 VA: 0x312E590
	internal ScriptableRenderer InternalCreateRenderer() { }

	// RVA: 0x312E5A0 Offset: 0x312E6A1 VA: 0x312E5A0 Slot: 5
	protected virtual void OnValidate() { }

	// RVA: 0x312E5B0 Offset: 0x312E6B1 VA: 0x312E5B0 Slot: 6
	protected virtual void OnEnable() { }

	// RVA: 0x312E5C0 Offset: 0x312E6C1 VA: 0x312E5C0
	protected void .ctor() { }
}

