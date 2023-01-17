// Namespace: UnityEngine
internal static class SpookyHash // TypeDefIndex: 3528
{
	// Fields
	private static readonly bool AllowUnalignedRead; // 0x0

	// Methods

	// RVA: 0x31ED380 Offset: 0x31ED481 VA: 0x31ED380
	private static bool AttemptDetectAllowUnalignedRead() { }

	// RVA: 0x31ED430 Offset: 0x31ED531 VA: 0x31ED430
	public static void Hash(void* message, ulong length, ulong* hash1, ulong* hash2) { }

	// RVA: 0x31EE170 Offset: 0x31EE271 VA: 0x31EE170
	private static void End(ulong* data, ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11) { }

	// RVA: 0x31EE400 Offset: 0x31EE501 VA: 0x31EE400
	private static void EndPartial(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11) { }

	// RVA: 0x31EE6A0 Offset: 0x31EE7A1 VA: 0x31EE6A0
	private static void Rot64(ref ulong x, int k) { }

	// RVA: 0x31ED7B0 Offset: 0x31ED8B1 VA: 0x31ED7B0
	private static void Short(void* message, ulong length, ulong* hash1, ulong* hash2) { }

	// RVA: 0x31EE6C0 Offset: 0x31EE7C1 VA: 0x31EE6C0
	private static void ShortMix(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3) { }

	// RVA: 0x31EE8F0 Offset: 0x31EE9F1 VA: 0x31EE8F0
	private static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3) { }

	// RVA: 0x31EDBF0 Offset: 0x31EDCF1 VA: 0x31EDBF0
	private static void Mix(ulong* data, ref ulong s0, ref ulong s1, ref ulong s2, ref ulong s3, ref ulong s4, ref ulong s5, ref ulong s6, ref ulong s7, ref ulong s8, ref ulong s9, ref ulong s10, ref ulong s11) { }

	// RVA: 0x31EE060 Offset: 0x31EE161 VA: 0x31EE060
	private static void memset(void* dst, int value, ulong numberOfBytes) { }

	// RVA: 0x31EEB00 Offset: 0x31EEC01 VA: 0x31EEB00
	private static void .cctor() { }
}

