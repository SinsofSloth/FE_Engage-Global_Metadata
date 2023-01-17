// Namespace: nn
public struct Result : IEquatable<Result> // TypeDefIndex: 14495
{
	// Fields
	public const int ModuleBitsOffset = 0;
	public const int ModuleBitsCount = 9;
	public const int ModuleBitsMask = 511;
	public const int DescriptionBitsOffset = 9;
	public const int DescriptionBitsCount = 13;
	public const int DescriptionBitsMask = 8191;
	public uint innerValue; // 0x0

	// Methods

	// RVA: 0x24D20A0 Offset: 0x24D21A1 VA: 0x24D20A0
	public void .ctor(int module, int description) { }

	// RVA: 0x24D20B0 Offset: 0x24D21B1 VA: 0x24D20B0
	public bool IsSuccess() { }

	// RVA: 0x24D20C0 Offset: 0x24D21C1 VA: 0x24D20C0
	public void abortUnlessSuccess() { }

	// RVA: 0x24D21E0 Offset: 0x24D22E1 VA: 0x24D21E0
	public int GetModule() { }

	// RVA: 0x24D21F0 Offset: 0x24D22F1 VA: 0x24D21F0
	public int GetDescription() { }

	// RVA: 0x24D20F0 Offset: 0x24D21F1 VA: 0x24D20F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x24D2200 Offset: 0x24D2301 VA: 0x24D2200 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x24D2290 Offset: 0x24D2391 VA: 0x24D2290 Slot: 4
	public bool Equals(Result other) { }

	// RVA: 0x24D22B0 Offset: 0x24D23B1 VA: 0x24D22B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x24D22A0 Offset: 0x24D23A1 VA: 0x24D22A0
	public static bool op_Equality(Result lhs, Result rhs) { }

	// RVA: 0x24D2320 Offset: 0x24D2421 VA: 0x24D2320
	public static bool op_Inequality(Result lhs, Result rhs) { }
}

