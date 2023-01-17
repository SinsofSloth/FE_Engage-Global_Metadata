// Namespace: UnityEngine.Rendering.Universal
[ReloadGroupAttribute] // RVA: 0x47F3E0 Offset: 0x47F4E1 VA: 0x47F3E0
[ExcludeFromPresetAttribute] // RVA: 0x47F3E0 Offset: 0x47F4E1 VA: 0x47F3E0
[MovedFromAttribute] // RVA: 0x47F3E0 Offset: 0x47F4E1 VA: 0x47F3E0
[Serializable]
public class ForwardRendererData : ScriptableRendererData // TypeDefIndex: 5284
{
	// Fields
	[ReloadAttribute] // RVA: 0x481300 Offset: 0x481401 VA: 0x481300
	public PostProcessData postProcessData; // 0x30
	[ReloadAttribute] // RVA: 0x481340 Offset: 0x481441 VA: 0x481340
	public XRSystemData xrSystemData; // 0x38
	public ForwardRendererData.ShaderResources shaders; // 0x40
	[SerializeField] // RVA: 0x481380 Offset: 0x481481 VA: 0x481380
	private LayerMask m_OpaqueLayerMask; // 0x48
	[SerializeField] // RVA: 0x481390 Offset: 0x481491 VA: 0x481390
	private LayerMask m_TransparentLayerMask; // 0x4C
	[SerializeField] // RVA: 0x4813A0 Offset: 0x4814A1 VA: 0x4813A0
	private StencilStateData m_DefaultStencilState; // 0x50
	[SerializeField] // RVA: 0x4813B0 Offset: 0x4814B1 VA: 0x4813B0
	private bool m_ShadowTransparentReceive; // 0x58
	[SerializeField] // RVA: 0x4813C0 Offset: 0x4814C1 VA: 0x4813C0
	private RenderingMode m_RenderingMode; // 0x5C
	[SerializeField] // RVA: 0x4813D0 Offset: 0x4814D1 VA: 0x4813D0
	private bool m_AccurateGbufferNormals; // 0x60
	[SerializeField] // RVA: 0x4813E0 Offset: 0x4814E1 VA: 0x4813E0
	private ForwardRendererData.MixedResolutionFlag m_MixedResolutionFlag; // 0x64

	// Properties
	public LayerMask opaqueLayerMask { get; set; }
	public LayerMask transparentLayerMask { get; set; }
	public StencilStateData defaultStencilState { get; set; }
	public bool shadowTransparentReceive { get; set; }
	public RenderingMode renderingMode { get; set; }
	public bool accurateGbufferNormals { get; set; }
	public ForwardRendererData.MixedResolutionFlag mixedResolutionFlag { get; set; }

	// Methods

	// RVA: 0x3148080 Offset: 0x3148181 VA: 0x3148080 Slot: 4
	protected override ScriptableRenderer Create() { }

	// RVA: 0x31480F0 Offset: 0x31481F1 VA: 0x31480F0
	public LayerMask get_opaqueLayerMask() { }

	// RVA: 0x3148100 Offset: 0x3148201 VA: 0x3148100
	public void set_opaqueLayerMask(LayerMask value) { }

	// RVA: 0x3148130 Offset: 0x3148231 VA: 0x3148130
	public LayerMask get_transparentLayerMask() { }

	// RVA: 0x3148140 Offset: 0x3148241 VA: 0x3148140
	public void set_transparentLayerMask(LayerMask value) { }

	// RVA: 0x3148170 Offset: 0x3148271 VA: 0x3148170
	public StencilStateData get_defaultStencilState() { }

	// RVA: 0x3148180 Offset: 0x3148281 VA: 0x3148180
	public void set_defaultStencilState(StencilStateData value) { }

	// RVA: 0x31481C0 Offset: 0x31482C1 VA: 0x31481C0
	public bool get_shadowTransparentReceive() { }

	// RVA: 0x31481D0 Offset: 0x31482D1 VA: 0x31481D0
	public void set_shadowTransparentReceive(bool value) { }

	// RVA: 0x3148200 Offset: 0x3148301 VA: 0x3148200
	public RenderingMode get_renderingMode() { }

	// RVA: 0x3148210 Offset: 0x3148311 VA: 0x3148210
	public void set_renderingMode(RenderingMode value) { }

	// RVA: 0x3148240 Offset: 0x3148341 VA: 0x3148240
	public bool get_accurateGbufferNormals() { }

	// RVA: 0x3148250 Offset: 0x3148351 VA: 0x3148250
	public void set_accurateGbufferNormals(bool value) { }

	// RVA: 0x3148280 Offset: 0x3148381 VA: 0x3148280
	public ForwardRendererData.MixedResolutionFlag get_mixedResolutionFlag() { }

	// RVA: 0x3148290 Offset: 0x3148391 VA: 0x3148290
	public void set_mixedResolutionFlag(ForwardRendererData.MixedResolutionFlag value) { }

	// RVA: 0x31482C0 Offset: 0x31483C1 VA: 0x31482C0 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x31482D0 Offset: 0x31483D1 VA: 0x31482D0
	public void .ctor() { }
}

