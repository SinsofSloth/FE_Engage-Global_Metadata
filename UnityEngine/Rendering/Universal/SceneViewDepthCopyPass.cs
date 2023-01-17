// Namespace: UnityEngine.Rendering.Universal
internal class SceneViewDepthCopyPass : ScriptableRenderPass // TypeDefIndex: 5316
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x482AB0 Offset: 0x482BB1 VA: 0x482AB0
	private RenderTargetHandle <source>k__BackingField; // 0x70
	private Material m_CopyDepthMaterial; // 0xA0
	private const string m_ProfilerTag = "Copy Depth for Scene View";
	private static readonly ProfilingSampler m_ProfilingSampler; // 0x0

	// Properties
	private RenderTargetHandle source { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x4845F0 Offset: 0x4846F1 VA: 0x4845F0
	// RVA: 0x31258D0 Offset: 0x31259D1 VA: 0x31258D0
	private RenderTargetHandle get_source() { }

	[CompilerGeneratedAttribute] // RVA: 0x484600 Offset: 0x484701 VA: 0x484600
	// RVA: 0x31258F0 Offset: 0x31259F1 VA: 0x31258F0
	private void set_source(RenderTargetHandle value) { }

	// RVA: 0x3125910 Offset: 0x3125A11 VA: 0x3125910
	public void .ctor(RenderPassEvent evt, Material copyDepthMaterial) { }

	// RVA: 0x3125E30 Offset: 0x3125F31 VA: 0x3125E30
	public void Setup(RenderTargetHandle source) { }

	// RVA: 0x3125E50 Offset: 0x3125F51 VA: 0x3125E50 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x3126410 Offset: 0x3126511 VA: 0x3126410
	private static void .cctor() { }
}

