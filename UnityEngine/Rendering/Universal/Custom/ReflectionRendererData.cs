// Namespace: UnityEngine.Rendering.Universal.Custom
[ExcludeFromPresetAttribute] // RVA: 0x480040 Offset: 0x480141 VA: 0x480040
[ReloadGroupAttribute] // RVA: 0x480040 Offset: 0x480141 VA: 0x480040
[Serializable]
public class ReflectionRendererData : ScriptableRendererData // TypeDefIndex: 5439
{
	// Fields
	[ReloadAttribute] // RVA: 0x483830 Offset: 0x483931 VA: 0x483830
	public PostProcessData postProcessData; // 0x30
	public ReflectionRendererData.ShaderResources shaders; // 0x38
	[SerializeField] // RVA: 0x483870 Offset: 0x483971 VA: 0x483870
	private LayerMask m_OpaqueLayerMask; // 0x40
	[SerializeField] // RVA: 0x483880 Offset: 0x483981 VA: 0x483880
	private LayerMask m_TransparentLayerMask; // 0x44
	[SerializeField] // RVA: 0x483890 Offset: 0x483991 VA: 0x483890
	private ReflectionRendererData.ReflectionTarget m_ReflectionTarget; // 0x48

	// Properties
	public LayerMask opaqueLayerMask { get; set; }
	public LayerMask transparentLayerMask { get; set; }
	public ReflectionRendererData.ReflectionTarget reflectionTarget { get; }

	// Methods

	// RVA: 0x3372A30 Offset: 0x3372B31 VA: 0x3372A30 Slot: 4
	protected override ScriptableRenderer Create() { }

	// RVA: 0x3372AA0 Offset: 0x3372BA1 VA: 0x3372AA0
	public LayerMask get_opaqueLayerMask() { }

	// RVA: 0x3372AB0 Offset: 0x3372BB1 VA: 0x3372AB0
	public void set_opaqueLayerMask(LayerMask value) { }

	// RVA: 0x3372AE0 Offset: 0x3372BE1 VA: 0x3372AE0
	public LayerMask get_transparentLayerMask() { }

	// RVA: 0x3372AF0 Offset: 0x3372BF1 VA: 0x3372AF0
	public void set_transparentLayerMask(LayerMask value) { }

	// RVA: 0x3372B20 Offset: 0x3372C21 VA: 0x3372B20
	public ReflectionRendererData.ReflectionTarget get_reflectionTarget() { }

	// RVA: 0x3372B30 Offset: 0x3372C31 VA: 0x3372B30 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x3372B40 Offset: 0x3372C41 VA: 0x3372B40
	public void .ctor() { }
}

