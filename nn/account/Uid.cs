// Namespace: nn.account
public struct Uid : IEquatable<Uid> // TypeDefIndex: 14785
{
	// Fields
	public ulong _data0; // 0x0
	public ulong _data1; // 0x8

	// Properties
	public static Uid Invalid { get; }

	// Methods

	// RVA: 0x257E5F0 Offset: 0x257E6F1 VA: 0x257E5F0
	public static Uid get_Invalid() { }

	// RVA: 0x257E600 Offset: 0x257E701 VA: 0x257E600
	public bool IsValid() { }

	// RVA: 0x257E620 Offset: 0x257E721 VA: 0x257E620 Slot: 3
	public override string ToString() { }

	// RVA: 0x257E6D0 Offset: 0x257E7D1 VA: 0x257E6D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x257E770 Offset: 0x257E871 VA: 0x257E770 Slot: 4
	public bool Equals(Uid other) { }

	// RVA: 0x257E7B0 Offset: 0x257E8B1 VA: 0x257E7B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x257E790 Offset: 0x257E891 VA: 0x257E790
	public static bool op_Equality(Uid lhs, Uid rhs) { }

	// RVA: 0x257E820 Offset: 0x257E921 VA: 0x257E820
	public static bool op_Inequality(Uid lhs, Uid rhs) { }
}

