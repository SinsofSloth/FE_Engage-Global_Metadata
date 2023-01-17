// Namespace: UnityEngine.Rendering
[NativeHeaderAttribute] // RVA: 0x440970 Offset: 0x440A71 VA: 0x440970
[StaticAccessorAttribute] // RVA: 0x440970 Offset: 0x440A71 VA: 0x440970
public sealed class GraphicsSettings : Object // TypeDefIndex: 3918
{
	// Properties
	public static bool lightsUseLinearIntensity { get; set; }
	public static bool useScriptableRenderPipelineBatching { set; }
	[NativeNameAttribute] // RVA: 0x45A550 Offset: 0x45A651 VA: 0x45A550
	private static ScriptableObject INTERNAL_currentRenderPipeline { get; }
	public static RenderPipelineAsset currentRenderPipeline { get; }
	public static RenderPipelineAsset renderPipelineAsset { get; set; }
	[NativeNameAttribute] // RVA: 0x45A590 Offset: 0x45A691 VA: 0x45A590
	private static ScriptableObject INTERNAL_defaultRenderPipeline { get; set; }
	public static RenderPipelineAsset defaultRenderPipeline { get; set; }

	// Methods

	// RVA: 0x2F24CB0 Offset: 0x2F24DB1 VA: 0x2F24CB0
	public static bool get_lightsUseLinearIntensity() { }

	// RVA: 0x2F24CF0 Offset: 0x2F24DF1 VA: 0x2F24CF0
	public static void set_lightsUseLinearIntensity(bool value) { }

	// RVA: 0x2F24D40 Offset: 0x2F24E41 VA: 0x2F24D40
	public static void set_useScriptableRenderPipelineBatching(bool value) { }

	// RVA: 0x2F24D90 Offset: 0x2F24E91 VA: 0x2F24D90
	public static bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash) { }

	// RVA: 0x2F24DE0 Offset: 0x2F24EE1 VA: 0x2F24DE0
	private static ScriptableObject get_INTERNAL_currentRenderPipeline() { }

	// RVA: 0x2F12A30 Offset: 0x2F12B31 VA: 0x2F12A30
	public static RenderPipelineAsset get_currentRenderPipeline() { }

	// RVA: 0x2F24E20 Offset: 0x2F24F21 VA: 0x2F24E20
	public static RenderPipelineAsset get_renderPipelineAsset() { }

	// RVA: 0x2F24FC0 Offset: 0x2F250C1 VA: 0x2F24FC0
	public static void set_renderPipelineAsset(RenderPipelineAsset value) { }

	// RVA: 0x2F25060 Offset: 0x2F25161 VA: 0x2F25060
	private static ScriptableObject get_INTERNAL_defaultRenderPipeline() { }

	// RVA: 0x2F250A0 Offset: 0x2F251A1 VA: 0x2F250A0
	private static void set_INTERNAL_defaultRenderPipeline(ScriptableObject value) { }

	// RVA: 0x2F24EF0 Offset: 0x2F24FF1 VA: 0x2F24EF0
	public static RenderPipelineAsset get_defaultRenderPipeline() { }

	// RVA: 0x2F25010 Offset: 0x2F25111 VA: 0x2F25010
	public static void set_defaultRenderPipeline(RenderPipelineAsset value) { }
}

