// Namespace: System.Runtime.InteropServices
[ComVisibleAttribute] // RVA: 0x4761D0 Offset: 0x4762D1 VA: 0x4761D0
[AttributeUsageAttribute] // RVA: 0x4761D0 Offset: 0x4762D1 VA: 0x4761D0
public sealed class MarshalAsAttribute : Attribute // TypeDefIndex: 1316
{
	// Fields
	public string MarshalCookie; // 0x10
	[ComVisibleAttribute] // RVA: 0x479400 Offset: 0x479501 VA: 0x479400
	public string MarshalType; // 0x18
	[ComVisibleAttribute] // RVA: 0x479420 Offset: 0x479521 VA: 0x479420
	public Type MarshalTypeRef; // 0x20
	public Type SafeArrayUserDefinedSubType; // 0x28
	private UnmanagedType utype; // 0x30
	public UnmanagedType ArraySubType; // 0x34
	public VarEnum SafeArraySubType; // 0x38
	public int SizeConst; // 0x3C
	public int IidParameterIndex; // 0x40
	public short SizeParamIndex; // 0x44

	// Methods

	// RVA: 0x34E6020 Offset: 0x34E6121 VA: 0x34E6020
	internal MarshalAsAttribute Copy() { }
}

