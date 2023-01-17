// Namespace: nn.ec
public struct NsUid : IEquatable<NsUid> // TypeDefIndex: 14772
{
	// Fields
	public ulong value; // 0x0

	// Methods

	// RVA: 0x23616C0 Offset: 0x23617C1 VA: 0x23616C0
	public void .ctor(ulong _value) { }

	// RVA: 0x23616D0 Offset: 0x23617D1 VA: 0x23616D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x23616E0 Offset: 0x23617E1 VA: 0x23616E0
	public static NsUid GetInvalidId() { }

	// RVA: 0x23616F0 Offset: 0x23617F1 VA: 0x23616F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2361780 Offset: 0x2361881 VA: 0x2361780 Slot: 4
	public bool Equals(NsUid other) { }

	// RVA: 0x23617A0 Offset: 0x23618A1 VA: 0x23617A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2361790 Offset: 0x2361891 VA: 0x2361790
	public static bool op_Equality(NsUid lhs, NsUid rhs) { }

	// RVA: 0x2361810 Offset: 0x2361911 VA: 0x2361810
	public static bool op_Inequality(NsUid lhs, NsUid rhs) { }
}

