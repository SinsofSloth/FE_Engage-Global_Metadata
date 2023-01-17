// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
internal struct ResourceHandle // TypeDefIndex: 4498
{
	// Fields
	private const uint kValidityMask = 4294901760;
	private const uint kIndexMask = 65535;
	private uint m_Value; // 0x0
	private static uint s_CurrentValidBit; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x3C9D0 Offset: 0x3CAD1 VA: 0x3C9D0
	private RenderGraphResourceType <type>k__BackingField; // 0x4

	// Properties
	public int index { get; }
	public RenderGraphResourceType type { get; set; }
	public int iType { get; }

	// Methods

	// RVA: 0x3542620 Offset: 0x3542721 VA: 0x3542620
	public int get_index() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D4D0 Offset: 0x3D5D1 VA: 0x3D4D0
	[IsReadOnlyAttribute] // RVA: 0x3D4D0 Offset: 0x3D5D1 VA: 0x3D4D0
	// RVA: 0x3545EA0 Offset: 0x3545FA1 VA: 0x3545EA0
	public RenderGraphResourceType get_type() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D510 Offset: 0x3D611 VA: 0x3D510
	// RVA: 0x3545EB0 Offset: 0x3545FB1 VA: 0x3545EB0
	private void set_type(RenderGraphResourceType value) { }

	// RVA: 0x3541410 Offset: 0x3541511 VA: 0x3541410
	public int get_iType() { }

	// RVA: 0x3545EC0 Offset: 0x3545FC1 VA: 0x3545EC0
	internal void .ctor(int value, RenderGraphResourceType type) { }

	// RVA: 0x3543090 Offset: 0x3543191 VA: 0x3543090
	public static int op_Implicit(ResourceHandle handle) { }

	// RVA: 0x3545F50 Offset: 0x3546051 VA: 0x3545F50
	public bool IsValid() { }

	// RVA: 0x3542470 Offset: 0x3542571 VA: 0x3542470
	public static void NewFrame(int executionIndex) { }

	// RVA: 0x3545FE0 Offset: 0x35460E1 VA: 0x3545FE0
	private static void .cctor() { }
}

