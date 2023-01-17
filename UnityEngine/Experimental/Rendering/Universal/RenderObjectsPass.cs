// Namespace: UnityEngine.Experimental.Rendering.Universal
[MovedFromAttribute] // RVA: 0x4804A0 Offset: 0x4805A1 VA: 0x4804A0
public class RenderObjectsPass : ScriptableRenderPass // TypeDefIndex: 5499
{
	// Fields
	private RenderQueueType renderQueueType; // 0x70
	private FilteringSettings m_FilteringSettings; // 0x74
	private RenderObjects.CustomCameraSettings m_CameraSettings; // 0x90
	private string m_ProfilerTag; // 0x98
	private ProfilingSampler m_ProfilingSampler; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x4843B0 Offset: 0x4844B1 VA: 0x4843B0
	private Material <overrideMaterial>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x4843C0 Offset: 0x4844C1 VA: 0x4843C0
	private int <overrideMaterialPassIndex>k__BackingField; // 0xB0
	private List<ShaderTagId> m_ShaderTagIdList; // 0xB8
	private RenderStateBlock m_RenderStateBlock; // 0xC0

	// Properties
	public Material overrideMaterial { get; set; }
	public int overrideMaterialPassIndex { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x485380 Offset: 0x485481 VA: 0x485380
	// RVA: 0x33766C0 Offset: 0x33767C1 VA: 0x33766C0
	public Material get_overrideMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x485390 Offset: 0x485491 VA: 0x485390
	// RVA: 0x33766D0 Offset: 0x33767D1 VA: 0x33766D0
	public void set_overrideMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4853A0 Offset: 0x4854A1 VA: 0x4853A0
	// RVA: 0x33766E0 Offset: 0x33767E1 VA: 0x33766E0
	public int get_overrideMaterialPassIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x4853B0 Offset: 0x4854B1 VA: 0x4853B0
	// RVA: 0x33766F0 Offset: 0x33767F1 VA: 0x33766F0
	public void set_overrideMaterialPassIndex(int value) { }

	// RVA: 0x33764C0 Offset: 0x33765C1 VA: 0x33764C0
	public void SetDetphState(bool writeEnabled, CompareFunction function = 2) { }

	// RVA: 0x3376530 Offset: 0x3376631 VA: 0x3376530
	public void SetStencilState(int reference, CompareFunction compareFunction, StencilOp passOp, StencilOp failOp, StencilOp zFailOp) { }

	// RVA: 0x3376090 Offset: 0x3376191 VA: 0x3376090
	public void .ctor(string profilerTag, RenderPassEvent renderPassEvent, string[] shaderTags, RenderQueueType renderQueueType, int layerMask, RenderObjects.CustomCameraSettings cameraSettings) { }

	// RVA: 0x3376700 Offset: 0x3376801 VA: 0x3376700
	internal void .ctor(URPProfileId profileId, RenderPassEvent renderPassEvent, string[] shaderTags, RenderQueueType renderQueueType, int layerMask, RenderObjects.CustomCameraSettings cameraSettings) { }

	// RVA: 0x3376800 Offset: 0x3376901 VA: 0x3376800 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }
}

