// Namespace: UnityEngine.Experimental.Rendering
public struct RendererList // TypeDefIndex: 4458
{
	// Fields
	private static readonly ShaderTagId s_EmptyName; // 0x0
	public static readonly RendererList nullRendererList; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x3C600 Offset: 0x3C701 VA: 0x3C600
	private bool <isValid>k__BackingField; // 0x0
	public CullingResults cullingResult; // 0x8
	public DrawingSettings drawSettings; // 0x18
	public FilteringSettings filteringSettings; // 0x150
	public Nullable<RenderStateBlock> stateBlock; // 0x168

	// Properties
	public bool isValid { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3CFE0 Offset: 0x3D0E1 VA: 0x3CFE0
	[IsReadOnlyAttribute] // RVA: 0x3CFE0 Offset: 0x3D0E1 VA: 0x3CFE0
	// RVA: 0x3545940 Offset: 0x3545A41 VA: 0x3545940
	public bool get_isValid() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D020 Offset: 0x3D121 VA: 0x3D020
	// RVA: 0x3545950 Offset: 0x3545A51 VA: 0x3545950
	private void set_isValid(bool value) { }

	// RVA: 0x3544E90 Offset: 0x3544F91 VA: 0x3544E90
	public static RendererList Create(in RendererListDesc desc) { }

	// RVA: 0x3545A50 Offset: 0x3545B51 VA: 0x3545A50
	private static void .cctor() { }
}

