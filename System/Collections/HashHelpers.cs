// Namespace: System.Collections
[FriendAccessAllowedAttribute] // RVA: 0x476D00 Offset: 0x476E01 VA: 0x476D00
internal static class HashHelpers // TypeDefIndex: 1355
{
	// Fields
	public static readonly int[] primes; // 0x0
	private static ConditionalWeakTable<object, SerializationInfo> s_SerializationInfoTable; // 0x8

	// Properties
	internal static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable { get; }

	// Methods

	// RVA: 0x38BF430 Offset: 0x38BF531 VA: 0x38BF430
	internal static ConditionalWeakTable<object, SerializationInfo> get_SerializationInfoTable() { }

	[ReliabilityContractAttribute] // RVA: 0x47D8A0 Offset: 0x47D9A1 VA: 0x47D8A0
	// RVA: 0x38BF540 Offset: 0x38BF641 VA: 0x38BF540
	public static bool IsPrime(int candidate) { }

	[ReliabilityContractAttribute] // RVA: 0x47D8C0 Offset: 0x47D9C1 VA: 0x47D8C0
	// RVA: 0x38BF630 Offset: 0x38BF731 VA: 0x38BF630
	public static int GetPrime(int min) { }

	// RVA: 0x38BF880 Offset: 0x38BF981 VA: 0x38BF880
	public static int ExpandPrime(int oldSize) { }

	// RVA: 0x38BF920 Offset: 0x38BFA21 VA: 0x38BF920
	private static void .cctor() { }
}

