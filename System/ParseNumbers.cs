// Namespace: System
internal static class ParseNumbers // TypeDefIndex: 344
{
	// Methods

	// RVA: 0x381A030 Offset: 0x381A131 VA: 0x381A030
	public static int StringToInt(string value, int fromBase, int flags) { }

	// RVA: 0x381A040 Offset: 0x381A141 VA: 0x381A040
	public static int StringToInt(string value, int fromBase, int flags, int* parsePos) { }

	// RVA: 0x381A4B0 Offset: 0x381A5B1 VA: 0x381A4B0
	public static string LongToString(long value, int toBase, int width, char paddingChar, int flags) { }

	// RVA: 0x381ABF0 Offset: 0x381ACF1 VA: 0x381ABF0
	public static long StringToLong(string value, int fromBase, int flags, int* parsePos) { }

	// RVA: 0x381B080 Offset: 0x381B181 VA: 0x381B080
	public static string IntToString(int value, int toBase, int width, char paddingChar, int flags) { }

	// RVA: 0x381B2C0 Offset: 0x381B3C1 VA: 0x381B2C0
	private static void EndianSwap(ref byte[] value) { }

	// RVA: 0x381A5E0 Offset: 0x381A6E1 VA: 0x381A5E0
	private static StringBuilder ConvertToBase2(byte[] value) { }

	// RVA: 0x381A850 Offset: 0x381A951 VA: 0x381A850
	private static StringBuilder ConvertToBase8(byte[] value) { }

	// RVA: 0x381AA40 Offset: 0x381AB41 VA: 0x381AA40
	private static StringBuilder ConvertToBase16(byte[] value) { }
}

