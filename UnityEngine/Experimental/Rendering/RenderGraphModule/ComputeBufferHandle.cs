// Namespace: UnityEngine.Experimental.Rendering.RenderGraphModule
[DebuggerDisplayAttribute] // RVA: 0x3B380 Offset: 0x3B481 VA: 0x3B380
public struct ComputeBufferHandle // TypeDefIndex: 4500
{
	// Fields
	private static ComputeBufferHandle s_NullHandle; // 0x0
	internal ResourceHandle handle; // 0x0

	// Properties
	public static ComputeBufferHandle nullHandle { get; }

	// Methods

	// RVA: 0x1B2CDE0 Offset: 0x1B2CEE1 VA: 0x1B2CDE0
	public static ComputeBufferHandle get_nullHandle() { }

	// RVA: 0x1B2CE50 Offset: 0x1B2CF51 VA: 0x1B2CE50
	internal void .ctor(int handle) { }

	// RVA: 0x1B2CE90 Offset: 0x1B2CF91 VA: 0x1B2CE90
	public static ComputeBuffer op_Implicit(ComputeBufferHandle buffer) { }

	// RVA: 0x1B2CF80 Offset: 0x1B2D081 VA: 0x1B2CF80
	public bool IsValid() { }

	// RVA: 0x1B2CF90 Offset: 0x1B2D091 VA: 0x1B2CF90
	private static void .cctor() { }
}

