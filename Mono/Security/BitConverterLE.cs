// Namespace: Mono.Security
internal sealed class BitConverterLE // TypeDefIndex: 46
{
	// Methods

	// RVA: 0x350ABC0 Offset: 0x350ACC1 VA: 0x350ABC0
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x350ACE0 Offset: 0x350ADE1 VA: 0x350ACE0
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x350AE80 Offset: 0x350AF81 VA: 0x350AE80
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x35088C0 Offset: 0x35089C1 VA: 0x35088C0
	internal static byte[] GetBytes(float value) { }

	// RVA: 0x3508480 Offset: 0x3508581 VA: 0x3508480
	internal static byte[] GetBytes(double value) { }

	// RVA: 0x350AEB0 Offset: 0x350AFB1 VA: 0x350AEB0
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x350B020 Offset: 0x350B121 VA: 0x350B020
	private static void ULongFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x3506E80 Offset: 0x3506F81 VA: 0x3506E80
	internal static float ToSingle(byte[] value, int startIndex) { }

	// RVA: 0x3506F00 Offset: 0x3507001 VA: 0x3506F00
	internal static double ToDouble(byte[] value, int startIndex) { }
}

// Namespace: Mono.Security
internal sealed class BitConverterLE // TypeDefIndex: 1528
{
	// Methods

	// RVA: 0x1BC7300 Offset: 0x1BC7401 VA: 0x1BC7300
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x1BC7420 Offset: 0x1BC7521 VA: 0x1BC7420
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x1BC2810 Offset: 0x1BC2911 VA: 0x1BC2810
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x1BC75C0 Offset: 0x1BC76C1 VA: 0x1BC75C0
	internal static byte[] GetBytes(long value) { }

	// RVA: 0x1BC75F0 Offset: 0x1BC76F1 VA: 0x1BC75F0
	private static void UShortFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1BC76F0 Offset: 0x1BC77F1 VA: 0x1BC76F0
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1BC7860 Offset: 0x1BC7961 VA: 0x1BC7860
	internal static ushort ToUInt16(byte[] value, int startIndex) { }

	// RVA: 0x1BC7890 Offset: 0x1BC7991 VA: 0x1BC7890
	internal static uint ToUInt32(byte[] value, int startIndex) { }
}

