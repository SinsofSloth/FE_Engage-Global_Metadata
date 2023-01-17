// Namespace: UnityEngine.Rendering.Universal
[MovedFromAttribute] // RVA: 0x47F8E0 Offset: 0x47F9E1 VA: 0x47F8E0
public struct RenderTargetHandle // TypeDefIndex: 5323
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x482AC0 Offset: 0x482BC1 VA: 0x482AC0
	private int <id>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x482AD0 Offset: 0x482BD1 VA: 0x482AD0
	private RenderTargetIdentifier <rtid>k__BackingField; // 0x8
	public static readonly RenderTargetHandle CameraTarget; // 0x0

	// Properties
	public int id { get; set; }
	private RenderTargetIdentifier rtid { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x484690 Offset: 0x484791 VA: 0x484690
	// RVA: 0x3376EA0 Offset: 0x3376FA1 VA: 0x3376EA0
	public void set_id(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4846A0 Offset: 0x4847A1 VA: 0x4846A0
	[IsReadOnlyAttribute] // RVA: 0x4846A0 Offset: 0x4847A1 VA: 0x4846A0
	// RVA: 0x3376EB0 Offset: 0x3376FB1 VA: 0x3376EB0
	public int get_id() { }

	[CompilerGeneratedAttribute] // RVA: 0x4846E0 Offset: 0x4847E1 VA: 0x4846E0
	// RVA: 0x3376EC0 Offset: 0x3376FC1 VA: 0x3376EC0
	private void set_rtid(RenderTargetIdentifier value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4846F0 Offset: 0x4847F1 VA: 0x4846F0
	[IsReadOnlyAttribute] // RVA: 0x4846F0 Offset: 0x4847F1 VA: 0x4846F0
	// RVA: 0x3376EE0 Offset: 0x3376FE1 VA: 0x3376EE0
	private RenderTargetIdentifier get_rtid() { }

	// RVA: 0x3376F00 Offset: 0x3377001 VA: 0x3376F00
	public void .ctor(RenderTargetIdentifier renderTargetIdentifier) { }

	// RVA: 0x336F090 Offset: 0x336F191 VA: 0x336F090
	internal static RenderTargetHandle GetCameraTarget(XRPass xr) { }

	// RVA: 0x3376F20 Offset: 0x3377021 VA: 0x3376F20
	public void Init(string shaderProperty) { }

	// RVA: 0x3376F50 Offset: 0x3377051 VA: 0x3376F50
	public void Init(RenderTargetIdentifier renderTargetIdentifier) { }

	// RVA: 0x336AB70 Offset: 0x336AC71 VA: 0x336AB70
	public RenderTargetIdentifier Identifier() { }

	// RVA: 0x3364A90 Offset: 0x3364B91 VA: 0x3364A90
	public bool HasInternalRenderTargetId() { }

	// RVA: 0x3376F70 Offset: 0x3377071 VA: 0x3376F70
	public bool Equals(RenderTargetHandle other) { }

	// RVA: 0x3377110 Offset: 0x3377211 VA: 0x3377110 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x33771C0 Offset: 0x33772C1 VA: 0x33771C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3364A50 Offset: 0x3364B51 VA: 0x3364A50
	public static bool op_Equality(RenderTargetHandle c1, RenderTargetHandle c2) { }

	// RVA: 0x33728D0 Offset: 0x33729D1 VA: 0x33728D0
	public static bool op_Inequality(RenderTargetHandle c1, RenderTargetHandle c2) { }

	// RVA: 0x33771D0 Offset: 0x33772D1 VA: 0x33771D0
	private static void .cctor() { }
}

