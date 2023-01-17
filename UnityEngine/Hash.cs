// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x43D680 Offset: 0x43D781 VA: 0x43D680
[NativeHeaderAttribute] // RVA: 0x43D680 Offset: 0x43D781 VA: 0x43D680
[NativeHeaderAttribute] // RVA: 0x43D680 Offset: 0x43D781 VA: 0x43D680
[Serializable]
public struct Hash128 : IComparable, IComparable<Hash128>, IEquatable<Hash128> // TypeDefIndex: 3524
{
	// Fields
	private uint m_u32_0; // 0x0
	private uint m_u32_1; // 0x4
	private uint m_u32_2; // 0x8
	private uint m_u32_3; // 0xC

	// Properties
	internal ulong u64_0 { get; }
	internal ulong u64_1 { get; }

	// Methods

	// RVA: 0x2F250F0 Offset: 0x2F251F1 VA: 0x2F250F0
	public void .ctor(uint u32_0, uint u32_1, uint u32_2, uint u32_3) { }

	// RVA: 0x2F25100 Offset: 0x2F25201 VA: 0x2F25100
	public void .ctor(ulong u64_0, ulong u64_1) { }

	// RVA: 0x2F25120 Offset: 0x2F25221 VA: 0x2F25120
	internal ulong get_u64_0() { }

	// RVA: 0x2F25130 Offset: 0x2F25231 VA: 0x2F25130
	internal ulong get_u64_1() { }

	// RVA: 0x2F25140 Offset: 0x2F25241 VA: 0x2F25140 Slot: 5
	public int CompareTo(Hash128 rhs) { }

	// RVA: 0x2F25290 Offset: 0x2F25391 VA: 0x2F25290 Slot: 3
	public override string ToString() { }

	[FreeFunctionAttribute] // RVA: 0x44DF40 Offset: 0x44E041 VA: 0x44DF40
	// RVA: 0x2F25330 Offset: 0x2F25431 VA: 0x2F25330
	public static Hash128 Parse(string hashString) { }

	[FreeFunctionAttribute] // RVA: 0x44DF90 Offset: 0x44E091 VA: 0x44DF90
	// RVA: 0x2F252E0 Offset: 0x2F253E1 VA: 0x2F252E0
	private static string Hash128ToStringImpl(Hash128 hash) { }

	[FreeFunctionAttribute] // RVA: 0x44DFE0 Offset: 0x44E0E1 VA: 0x44DFE0
	// RVA: 0x2F25430 Offset: 0x2F25531 VA: 0x2F25430
	private static void ComputeFromString(string data, ref Hash128 hash) { }

	// RVA: 0x2F25480 Offset: 0x2F25581 VA: 0x2F25480
	public static Hash128 Compute(string data) { }

	// RVA: 0x2F254E0 Offset: 0x2F255E1 VA: 0x2F254E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2F255E0 Offset: 0x2F256E1 VA: 0x2F255E0 Slot: 6
	public bool Equals(Hash128 obj) { }

	// RVA: 0x2F25630 Offset: 0x2F25731 VA: 0x2F25630 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F256A0 Offset: 0x2F257A1 VA: 0x2F256A0 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x2F255A0 Offset: 0x2F256A1 VA: 0x2F255A0
	public static bool op_Equality(Hash128 hash1, Hash128 hash2) { }

	// RVA: 0x2F251D0 Offset: 0x2F252D1 VA: 0x2F251D0
	public static bool op_LessThan(Hash128 x, Hash128 y) { }

	// RVA: 0x2F25210 Offset: 0x2F25311 VA: 0x2F25210
	public static bool op_GreaterThan(Hash128 x, Hash128 y) { }

	// RVA: 0x2F25390 Offset: 0x2F25491 VA: 0x2F25390
	private static void Parse_Injected(string hashString, out Hash128 ret) { }

	// RVA: 0x2F253E0 Offset: 0x2F254E1 VA: 0x2F253E0
	private static string Hash128ToStringImpl_Injected(ref Hash128 hash) { }
}

