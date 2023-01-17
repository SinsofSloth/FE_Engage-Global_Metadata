// Namespace: System.Runtime.InteropServices
[ComVisibleAttribute] // RVA: 0x476100 Offset: 0x476201 VA: 0x476100
public struct HandleRef // TypeDefIndex: 1309
{
	// Fields
	internal object m_wrapper; // 0x0
	internal IntPtr m_handle; // 0x8

	// Properties
	public IntPtr Handle { get; }

	// Methods

	// RVA: 0x38BEED0 Offset: 0x38BEFD1 VA: 0x38BEED0
	public void .ctor(object wrapper, IntPtr handle) { }

	// RVA: 0x38BEF00 Offset: 0x38BF001 VA: 0x38BEF00
	public IntPtr get_Handle() { }
}

