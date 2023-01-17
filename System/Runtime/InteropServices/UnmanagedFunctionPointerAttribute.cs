// Namespace: System.Runtime.InteropServices
[AttributeUsageAttribute] // RVA: 0x475AD0 Offset: 0x475BD1 VA: 0x475AD0
[ComVisibleAttribute] // RVA: 0x475AD0 Offset: 0x475BD1 VA: 0x475AD0
public sealed class UnmanagedFunctionPointerAttribute : Attribute // TypeDefIndex: 1283
{
	// Fields
	private CallingConvention m_callingConvention; // 0x10
	public CharSet CharSet; // 0x14
	public bool BestFitMapping; // 0x18
	public bool ThrowOnUnmappableChar; // 0x19
	public bool SetLastError; // 0x1A

	// Methods

	// RVA: 0x34CA490 Offset: 0x34CA591 VA: 0x34CA490
	public void .ctor(CallingConvention callingConvention) { }
}

