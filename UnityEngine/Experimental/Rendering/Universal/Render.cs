// Namespace: UnityEngine.Experimental.Rendering.Universal
internal class Render2DLightingPass : ScriptableRenderPass, IRenderPass2D // TypeDefIndex: 5482
{
	// Fields
	private static readonly int k_HDREmulationScaleID; // 0x0
	private static readonly int k_InverseHDREmulationScaleID; // 0x4
	private static readonly int k_UseSceneLightingID; // 0x8
	private static readonly int k_RendererColorID; // 0xC
	private static readonly int k_ShapeLightTexture0ID; // 0x10
	private static readonly int k_ShapeLightTexture1ID; // 0x14
	private static readonly int k_ShapeLightTexture2ID; // 0x18
	private static readonly int k_ShapeLightTexture3ID; // 0x1C
	private static readonly ShaderTagId k_CombinedRenderingPassNameOld; // 0x20
	private static readonly ShaderTagId k_CombinedRenderingPassName; // 0x24
	private static readonly ShaderTagId k_NormalsRenderingPassName; // 0x28
	private static readonly ShaderTagId k_LegacyPassName; // 0x2C
	private static readonly List<ShaderTagId> k_ShaderTags; // 0x30
	private static readonly ProfilingSampler m_ProfilingSampler; // 0x38
	private static readonly ProfilingSampler m_ProfilingSamplerUnlit; // 0x40
	private readonly Renderer2DData m_Renderer2DData; // 0x70

	// Properties
	private Renderer2DData UnityEngine.Experimental.Rendering.Universal.IRenderPass2D.rendererData { get; }

	// Methods

	// RVA: 0x3372B90 Offset: 0x3372C91 VA: 0x3372B90
	public void .ctor(Renderer2DData rendererData) { }

	// RVA: 0x3372BD0 Offset: 0x3372CD1 VA: 0x3372BD0
	private void GetTransparencySortingMode(Camera camera, ref SortingSettings sortingSettings) { }

	// RVA: 0x3372C90 Offset: 0x3372D91 VA: 0x3372C90
	private bool CompareLightsInLayer(int layerIndex1, int layerIndex2, SortingLayer[] sortingLayers) { }

	// RVA: 0x3372EE0 Offset: 0x3372FE1 VA: 0x3372EE0
	private int FindUpperBoundInBatch(int startLayerIndex, SortingLayer[] sortingLayers) { }

	// RVA: 0x3372F50 Offset: 0x3373051 VA: 0x3372F50 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x3375B00 Offset: 0x3375C01 VA: 0x3375B00 Slot: 10
	private Renderer2DData UnityEngine.Experimental.Rendering.Universal.IRenderPass2D.get_rendererData() { }

	// RVA: 0x3375B10 Offset: 0x3375C11 VA: 0x3375B10
	private static void .cctor() { }
}

