// Namespace: System.Xml
public class XmlConvert // TypeDefIndex: 1740
{
	// Fields
	private static XmlCharType xmlCharType; // 0x0
	internal static char[] crt; // 0x8
	private static readonly int c_EncodedCharLength; // 0x10
	internal static readonly char[] WhitespaceChars; // 0x18

	// Methods

	// RVA: 0x1A9C0D0 Offset: 0x1A9C1D1 VA: 0x1A9C0D0
	internal static byte[] FromBinHexString(string s, bool allowOddCount) { }

	// RVA: 0x1AA1850 Offset: 0x1AA1951 VA: 0x1AA1850
	internal static string ToBinHexString(byte[] inArray) { }

	// RVA: 0x1AA18C0 Offset: 0x1AA19C1 VA: 0x1AA18C0
	public static string VerifyName(string name) { }

	// RVA: 0x1AA1B30 Offset: 0x1AA1C31 VA: 0x1AA1B30
	internal static Exception TryVerifyName(string name) { }

	// RVA: 0x1AA1C90 Offset: 0x1AA1D91 VA: 0x1AA1C90
	public static string VerifyNCName(string name) { }

	// RVA: 0x1AA1D00 Offset: 0x1AA1E01 VA: 0x1AA1D00
	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	// RVA: 0x1AA1EA0 Offset: 0x1AA1FA1 VA: 0x1AA1EA0
	internal static Exception TryVerifyNCName(string name) { }

	// RVA: 0x1AA1F60 Offset: 0x1AA2061 VA: 0x1AA1F60
	public static string VerifyTOKEN(string token) { }

	// RVA: 0x1AA20B0 Offset: 0x1AA21B1 VA: 0x1AA20B0
	internal static Exception TryVerifyTOKEN(string token) { }

	// RVA: 0x1AA2200 Offset: 0x1AA2301 VA: 0x1AA2200
	internal static Exception TryVerifyNMTOKEN(string name) { }

	// RVA: 0x1AA2340 Offset: 0x1AA2441 VA: 0x1AA2340
	internal static Exception TryVerifyNormalizedString(string str) { }

	// RVA: 0x1A9EBB0 Offset: 0x1A9ECB1 VA: 0x1A9EBB0
	public static string ToString(bool value) { }

	// RVA: 0x1A9D090 Offset: 0x1A9D191 VA: 0x1A9D090
	public static string ToString(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x47820 Offset: 0x47921 VA: 0x47820
	// RVA: 0x1AA2420 Offset: 0x1AA2521 VA: 0x1AA2420
	public static string ToString(sbyte value) { }

	// RVA: 0x1AA2460 Offset: 0x1AA2561 VA: 0x1AA2460
	public static string ToString(short value) { }

	// RVA: 0x1A9D600 Offset: 0x1A9D701 VA: 0x1A9D600
	public static string ToString(int value) { }

	// RVA: 0x1A9DAC0 Offset: 0x1A9DBC1 VA: 0x1A9DAC0
	public static string ToString(long value) { }

	// RVA: 0x1AA24A0 Offset: 0x1AA25A1 VA: 0x1AA24A0
	public static string ToString(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x47840 Offset: 0x47941 VA: 0x47840
	// RVA: 0x1AA24E0 Offset: 0x1AA25E1 VA: 0x1AA24E0
	public static string ToString(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x47860 Offset: 0x47961 VA: 0x47860
	// RVA: 0x1AA2520 Offset: 0x1AA2621 VA: 0x1AA2520
	public static string ToString(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x47880 Offset: 0x47981 VA: 0x47880
	// RVA: 0x1AA2560 Offset: 0x1AA2661 VA: 0x1AA2560
	public static string ToString(ulong value) { }

	// RVA: 0x1AA25A0 Offset: 0x1AA26A1 VA: 0x1AA25A0
	public static string ToString(float value) { }

	// RVA: 0x1AA27D0 Offset: 0x1AA28D1 VA: 0x1AA27D0
	public static string ToString(double value) { }

	// RVA: 0x1A9E5A0 Offset: 0x1A9E6A1 VA: 0x1A9E5A0
	public static bool ToBoolean(string s) { }

	// RVA: 0x1AA29B0 Offset: 0x1AA2AB1 VA: 0x1AA29B0
	internal static Exception TryToBoolean(string s, out bool result) { }

	// RVA: 0x1AA2C50 Offset: 0x1AA2D51 VA: 0x1AA2C50
	public static char ToChar(string s) { }

	// RVA: 0x1AA2D20 Offset: 0x1AA2E21 VA: 0x1AA2D20
	internal static Exception TryToChar(string s, out char result) { }

	// RVA: 0x1AA2EC0 Offset: 0x1AA2FC1 VA: 0x1AA2EC0
	public static Decimal ToDecimal(string s) { }

	// RVA: 0x1AA2F40 Offset: 0x1AA3041 VA: 0x1AA2F40
	internal static Exception TryToDecimal(string s, out Decimal result) { }

	// RVA: 0x1AA30F0 Offset: 0x1AA31F1 VA: 0x1AA30F0
	internal static Decimal ToInteger(string s) { }

	// RVA: 0x1AA3170 Offset: 0x1AA3271 VA: 0x1AA3170
	internal static Exception TryToInteger(string s, out Decimal result) { }

	// RVA: 0x1AA3320 Offset: 0x1AA3421 VA: 0x1AA3320
	internal static Exception TryToSByte(string s, out sbyte result) { }

	// RVA: 0x1AA34A0 Offset: 0x1AA35A1 VA: 0x1AA34A0
	internal static Exception TryToInt16(string s, out short result) { }

	// RVA: 0x1AA3620 Offset: 0x1AA3721 VA: 0x1AA3620
	public static int ToInt32(string s) { }

	// RVA: 0x1AA3660 Offset: 0x1AA3761 VA: 0x1AA3660
	internal static Exception TryToInt32(string s, out int result) { }

	// RVA: 0x1AA37E0 Offset: 0x1AA38E1 VA: 0x1AA37E0
	public static long ToInt64(string s) { }

	// RVA: 0x1AA3820 Offset: 0x1AA3921 VA: 0x1AA3820
	internal static Exception TryToInt64(string s, out long result) { }

	// RVA: 0x1AA39A0 Offset: 0x1AA3AA1 VA: 0x1AA39A0
	internal static Exception TryToByte(string s, out byte result) { }

	// RVA: 0x1AA3B20 Offset: 0x1AA3C21 VA: 0x1AA3B20
	internal static Exception TryToUInt16(string s, out ushort result) { }

	// RVA: 0x1AA3CA0 Offset: 0x1AA3DA1 VA: 0x1AA3CA0
	internal static Exception TryToUInt32(string s, out uint result) { }

	// RVA: 0x1AA3E20 Offset: 0x1AA3F21 VA: 0x1AA3E20
	internal static Exception TryToUInt64(string s, out ulong result) { }

	// RVA: 0x1AA3FA0 Offset: 0x1AA40A1 VA: 0x1AA3FA0
	public static float ToSingle(string s) { }

	// RVA: 0x1AA4120 Offset: 0x1AA4221 VA: 0x1AA4120
	internal static Exception TryToSingle(string s, out float result) { }

	// RVA: 0x1AA43E0 Offset: 0x1AA44E1 VA: 0x1AA43E0
	public static double ToDouble(string s) { }

	// RVA: 0x1AA4590 Offset: 0x1AA4691 VA: 0x1AA4590
	internal static Exception TryToDouble(string s, out double result) { }

	// RVA: 0x1AA4880 Offset: 0x1AA4981 VA: 0x1AA4880
	internal static double ToXPathDouble(object o) { }

	// RVA: 0x1AA4B80 Offset: 0x1AA4C81 VA: 0x1AA4B80
	internal static Exception TryToTimeSpan(string s, out TimeSpan result) { }

	// RVA: 0x1AA4C40 Offset: 0x1AA4D41 VA: 0x1AA4C40
	public static Guid ToGuid(string s) { }

	// RVA: 0x1AA4C70 Offset: 0x1AA4D71 VA: 0x1AA4C70
	internal static Exception TryToGuid(string s, out Guid result) { }

	// RVA: 0x1AA4E90 Offset: 0x1AA4F91 VA: 0x1AA4E90
	internal static Uri ToUri(string s) { }

	// RVA: 0x1AA50A0 Offset: 0x1AA51A1 VA: 0x1AA50A0
	internal static Exception TryToUri(string s, out Uri result) { }

	// RVA: 0x1AA5320 Offset: 0x1AA5421 VA: 0x1AA5320
	internal static bool StrEqual(char[] chars, int strPos1, int strLen1, string str2) { }

	// RVA: 0x1A9B610 Offset: 0x1A9B711 VA: 0x1A9B610
	internal static string TrimString(string value) { }

	// RVA: 0x1AA5400 Offset: 0x1AA5501 VA: 0x1AA5400
	internal static string[] SplitString(string value) { }

	// RVA: 0x1AA2720 Offset: 0x1AA2821 VA: 0x1AA2720
	internal static bool IsNegativeZero(double value) { }

	// RVA: 0x1AA5480 Offset: 0x1AA5581 VA: 0x1AA5480
	private static long DoubleToInt64Bits(double value) { }

	// RVA: 0x1AA5490 Offset: 0x1AA5591 VA: 0x1AA5490
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x1AA1A50 Offset: 0x1AA1B51 VA: 0x1AA1A50
	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	// RVA: 0x1AA5570 Offset: 0x1AA5671 VA: 0x1AA5570
	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	// RVA: 0x1AA5650 Offset: 0x1AA5751 VA: 0x1AA5650
	private static void .cctor() { }
}

