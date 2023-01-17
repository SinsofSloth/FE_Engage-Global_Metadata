// Namespace: UnityEngine.Experimental.Rendering
public struct RendererListDesc // TypeDefIndex: 4459
{
	// Fields
	public SortingCriteria sortingCriteria; // 0x0
	public PerObjectData rendererConfiguration; // 0x4
	public RenderQueueRange renderQueueRange; // 0x8
	public Nullable<RenderStateBlock> stateBlock; // 0x10
	public Material overrideMaterial; // 0x80
	public bool excludeObjectMotionVectors; // 0x88
	public int layerMask; // 0x8C
	public int overrideMaterialPassIndex; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x3C610 Offset: 0x3C711 VA: 0x3C610
	private CullingResults <cullingResult>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x3C620 Offset: 0x3C721 VA: 0x3C620
	private Camera <camera>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x3C630 Offset: 0x3C731 VA: 0x3C630
	private ShaderTagId <passName>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x3C640 Offset: 0x3C741 VA: 0x3C640
	private ShaderTagId[] <passNames>k__BackingField; // 0xB8

	// Properties
	internal CullingResults cullingResult { get; set; }
	internal Camera camera { get; set; }
	internal ShaderTagId passName { get; set; }
	internal ShaderTagId[] passNames { get; set; }

	// Methods

	[IsReadOnlyAttribute] // RVA: 0x3D030 Offset: 0x3D131 VA: 0x3D030
	[CompilerGeneratedAttribute] // RVA: 0x3D030 Offset: 0x3D131 VA: 0x3D030
	// RVA: 0x3545AF0 Offset: 0x3545BF1 VA: 0x3545AF0
	internal CullingResults get_cullingResult() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D070 Offset: 0x3D171 VA: 0x3D070
	// RVA: 0x3545B00 Offset: 0x3545C01 VA: 0x3545B00
	private void set_cullingResult(CullingResults value) { }

	[IsReadOnlyAttribute] // RVA: 0x3D080 Offset: 0x3D181 VA: 0x3D080
	[CompilerGeneratedAttribute] // RVA: 0x3D080 Offset: 0x3D181 VA: 0x3D080
	// RVA: 0x3545B10 Offset: 0x3545C11 VA: 0x3545B10
	internal Camera get_camera() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D0C0 Offset: 0x3D1C1 VA: 0x3D0C0
	// RVA: 0x3545B20 Offset: 0x3545C21 VA: 0x3545B20
	internal void set_camera(Camera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D0D0 Offset: 0x3D1D1 VA: 0x3D0D0
	[IsReadOnlyAttribute] // RVA: 0x3D0D0 Offset: 0x3D1D1 VA: 0x3D0D0
	// RVA: 0x3545B30 Offset: 0x3545C31 VA: 0x3545B30
	internal ShaderTagId get_passName() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D110 Offset: 0x3D211 VA: 0x3D110
	// RVA: 0x3545B40 Offset: 0x3545C41 VA: 0x3545B40
	private void set_passName(ShaderTagId value) { }

	[IsReadOnlyAttribute] // RVA: 0x3D120 Offset: 0x3D221 VA: 0x3D120
	[CompilerGeneratedAttribute] // RVA: 0x3D120 Offset: 0x3D221 VA: 0x3D120
	// RVA: 0x3545B50 Offset: 0x3545C51 VA: 0x3545B50
	internal ShaderTagId[] get_passNames() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D160 Offset: 0x3D261 VA: 0x3D160
	// RVA: 0x3545B60 Offset: 0x3545C61 VA: 0x3545B60
	private void set_passNames(ShaderTagId[] value) { }

	// RVA: 0x3545B70 Offset: 0x3545C71 VA: 0x3545B70
	public void .ctor(ShaderTagId passName, CullingResults cullingResult, Camera camera) { }

	// RVA: 0x3545C20 Offset: 0x3545D21 VA: 0x3545C20
	public void .ctor(ShaderTagId[] passNames, CullingResults cullingResult, Camera camera) { }

	// RVA: 0x3545960 Offset: 0x3545A61 VA: 0x3545960
	public bool IsValid() { }
}

