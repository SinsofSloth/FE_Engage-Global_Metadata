// Namespace: Unity.Mathematics
[DefaultMemberAttribute] // RVA: 0x877E0 Offset: 0x878E1 VA: 0x877E0
[DebuggerTypeProxyAttribute] // RVA: 0x877E0 Offset: 0x878E1 VA: 0x877E0
[Serializable]
public struct uint4 : IEquatable<uint4>, IFormattable // TypeDefIndex: 4783
{
	// Fields
	public uint x; // 0x0
	public uint y; // 0x4
	public uint z; // 0x8
	public uint w; // 0xC

	// Methods

	// RVA: 0x1C3DD20 Offset: 0x1C3DE21 VA: 0x1C3DD20
	public void .ctor(uint x, uint y, uint z, uint w) { }

	// RVA: 0x1C3DD30 Offset: 0x1C3DE31 VA: 0x1C3DD30
	public void .ctor(int v) { }

	// RVA: 0x1C3DD40 Offset: 0x1C3DE41 VA: 0x1C3DD40
	public static uint4 op_Multiply(uint4 lhs, uint4 rhs) { }

	// RVA: 0x1C3DD70 Offset: 0x1C3DE71 VA: 0x1C3DD70
	public static uint4 op_Addition(uint4 lhs, uint4 rhs) { }

	// RVA: 0x1C3DDA0 Offset: 0x1C3DEA1 VA: 0x1C3DDA0
	public static uint4 op_OnesComplement(uint4 val) { }

	// RVA: 0x1C3DDB0 Offset: 0x1C3DEB1 VA: 0x1C3DDB0
	public static uint4 op_BitwiseAnd(uint4 lhs, uint4 rhs) { }

	// RVA: 0x1C3DDC0 Offset: 0x1C3DEC1 VA: 0x1C3DDC0
	public static uint4 op_BitwiseOr(uint4 lhs, uint4 rhs) { }

	// RVA: 0x1C3DDD0 Offset: 0x1C3DED1 VA: 0x1C3DDD0
	public static uint4 op_ExclusiveOr(uint4 lhs, uint4 rhs) { }

	// RVA: 0x1C3DDE0 Offset: 0x1C3DEE1 VA: 0x1C3DDE0 Slot: 4
	public bool Equals(uint4 rhs) { }

	// RVA: 0x1C3DE30 Offset: 0x1C3DF31 VA: 0x1C3DE30 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1C3DF00 Offset: 0x1C3E001 VA: 0x1C3DF00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C3DF60 Offset: 0x1C3E061 VA: 0x1C3DF60 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C3E140 Offset: 0x1C3E241 VA: 0x1C3E140 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

