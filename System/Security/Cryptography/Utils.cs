// Namespace: System.Security.Cryptography
internal static class Utils // TypeDefIndex: 965
{
	// Fields
	private static RNGCryptoServiceProvider _rng; // 0x0

	// Properties
	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator { get; }

	// Methods

	// RVA: 0x34CC0B0 Offset: 0x34CC1B1 VA: 0x34CC0B0
	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	// RVA: 0x34CC160 Offset: 0x34CC261 VA: 0x34CC160
	internal static byte[] GenerateRandom(int keySize) { }

	// RVA: 0x34CC1E0 Offset: 0x34CC2E1 VA: 0x34CC1E0
	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	// RVA: 0x34CC1F0 Offset: 0x34CC2F1 VA: 0x34CC1F0
	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	// RVA: 0x34CC200 Offset: 0x34CC301 VA: 0x34CC200
	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x34CC3C0 Offset: 0x34CC4C1 VA: 0x34CC3C0
	internal static int ConvertByteArrayToInt(byte[] input) { }

	// RVA: 0x34CC430 Offset: 0x34CC531 VA: 0x34CC430
	internal static byte[] ConvertIntToByteArray(int dwInput) { }

	// RVA: 0x34CC560 Offset: 0x34CC661 VA: 0x34CC560
	internal static byte[] FixupKeyParity(byte[] key) { }

	// RVA: 0x34CC630 Offset: 0x34CC731 VA: 0x34CC630
	internal static void DWORDFromLittleEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x34CC680 Offset: 0x34CC781 VA: 0x34CC680
	internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x34CC770 Offset: 0x34CC871 VA: 0x34CC770
	internal static void DWORDFromBigEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x34CC7D0 Offset: 0x34CC8D1 VA: 0x34CC7D0
	internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x34CC8C0 Offset: 0x34CC9C1 VA: 0x34CC8C0
	internal static void QuadWordFromBigEndian(ulong* x, int digits, byte* block) { }

	// RVA: 0x34CC950 Offset: 0x34CCA51 VA: 0x34CC950
	internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits) { }

	// RVA: 0x34CCB10 Offset: 0x34CCC11 VA: 0x34CCB10
	internal static bool _ProduceLegacyHmacValues() { }
}

