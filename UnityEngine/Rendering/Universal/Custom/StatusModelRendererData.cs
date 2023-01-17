// Namespace: UnityEngine.Rendering.Universal.Custom
[ExcludeFromPresetAttribute] // RVA: 0x4800A0 Offset: 0x4801A1 VA: 0x4800A0
[ReloadGroupAttribute] // RVA: 0x4800A0 Offset: 0x4801A1 VA: 0x4800A0
[Serializable]
public class StatusModelRendererData : ScriptableRendererData // TypeDefIndex: 5443
{
	// Fields
	[ReloadAttribute] // RVA: 0x4838E0 Offset: 0x4839E1 VA: 0x4838E0
	public PostProcessData postProcessData; // 0x30
	public StatusModelRendererData.ShaderResources shaders; // 0x38
	[SerializeField] // RVA: 0x483920 Offset: 0x483A21 VA: 0x483920
	private LayerMask m_OpaqueLayerMask; // 0x40
	[SerializeField] // RVA: 0x483930 Offset: 0x483A31 VA: 0x483930
	private LayerMask m_TransparentLayerMask; // 0x44
	[SerializeField] // RVA: 0x483940 Offset: 0x483A41 VA: 0x483940
	private StencilStateData m_DefaultStencilState; // 0x48
	[SerializeField] // RVA: 0x483950 Offset: 0x483A51 VA: 0x483950
	private bool m_ShadowTransparentReceive; // 0x50

	// Properties
	public LayerMask opaqueLayerMask { get; set; }
	public LayerMask transparentLayerMask { get; set; }
	public StencilStateData defaultStencilState { get; set; }
	public bool shadowTransparentReceive { get; set; }

	// Methods

	// RVA: 0x31376A0 Offset: 0x31377A1 VA: 0x31376A0 Slot: 4
	protected override ScriptableRenderer Create() { }

	// RVA: 0x3137710 Offset: 0x3137811 VA: 0x3137710
	public LayerMask get_opaqueLayerMask() { }

	// RVA: 0x3137720 Offset: 0x3137821 VA: 0x3137720
	public void set_opaqueLayerMask(LayerMask value) { }

	// RVA: 0x3137730 Offset: 0x3137831 VA: 0x3137730
	public LayerMask get_transparentLayerMask() { }

	// RVA: 0x3137740 Offset: 0x3137841 VA: 0x3137740
	public void set_transparentLayerMask(LayerMask value) { }

	// RVA: 0x3137750 Offset: 0x3137851 VA: 0x3137750
	public StencilStateData get_defaultStencilState() { }

	// RVA: 0x3137760 Offset: 0x3137861 VA: 0x3137760
	public void set_defaultStencilState(StencilStateData value) { }

	// RVA: 0x3137770 Offset: 0x3137871 VA: 0x3137770
	public bool get_shadowTransparentReceive() { }

	// RVA: 0x3137780 Offset: 0x3137881 VA: 0x3137780
	public void set_shadowTransparentReceive(bool value) { }

	// RVA: 0x31377A0 Offset: 0x31378A1 VA: 0x31377A0 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x31377B0 Offset: 0x31378B1 VA: 0x31377B0
	public void .ctor() { }
}

