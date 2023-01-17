// Namespace: System
public static class BitConverter // TypeDefIndex: 177
{
	// Fields
	public static readonly bool IsLittleEndian; // 0x0

	// Methods

	// RVA: 0x3509790 Offset: 0x3509891 VA: 0x3509790
	private static bool AmILittleEndian() { }

	// RVA: 0x35097A0 Offset: 0x35098A1 VA: 0x35097A0
	public static byte[] GetBytes(bool value) { }

	// RVA: 0x3509820 Offset: 0x3509921 VA: 0x3509820
	public static byte[] GetBytes(char value) { }

	// RVA: 0x35098D0 Offset: 0x35099D1 VA: 0x35098D0
	public static byte[] GetBytes(short value) { }

	// RVA: 0x3509940 Offset: 0x3509A41 VA: 0x3509940
	public static byte[] GetBytes(int value) { }

	// RVA: 0x35099B0 Offset: 0x3509AB1 VA: 0x35099B0
	public static byte[] GetBytes(long value) { }

	[CLSCompliantAttribute] // RVA: 0x4795F0 Offset: 0x4796F1 VA: 0x4795F0
	// RVA: 0x3509A20 Offset: 0x3509B21 VA: 0x3509A20
	public static byte[] GetBytes(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x479610 Offset: 0x479711 VA: 0x479610
	// RVA: 0x3509AD0 Offset: 0x3509BD1 VA: 0x3509AD0
	public static byte[] GetBytes(uint value) { }

	// RVA: 0x3509B80 Offset: 0x3509C81 VA: 0x3509B80
	public static byte[] GetBytes(float value) { }

	// RVA: 0x3509C30 Offset: 0x3509D31 VA: 0x3509C30
	public static char ToChar(byte[] value, int startIndex) { }

	// RVA: 0x3509D10 Offset: 0x3509E11 VA: 0x3509D10
	public static short ToInt16(byte[] value, int startIndex) { }

	// RVA: 0x3509E60 Offset: 0x3509F61 VA: 0x3509E60
	public static int ToInt32(byte[] value, int startIndex) { }

	// RVA: 0x3509FD0 Offset: 0x350A0D1 VA: 0x3509FD0
	public static long ToInt64(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] // RVA: 0x479630 Offset: 0x479731 VA: 0x479630
	// RVA: 0x350A180 Offset: 0x350A281 VA: 0x350A180
	public static ushort ToUInt16(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] // RVA: 0x479650 Offset: 0x479751 VA: 0x479650
	// RVA: 0x350A260 Offset: 0x350A361 VA: 0x350A260
	public static uint ToUInt32(byte[] value, int startIndex) { }

	[CLSCompliantAttribute] // RVA: 0x479670 Offset: 0x479771 VA: 0x479670
	// RVA: 0x350A340 Offset: 0x350A441 VA: 0x350A340
	public static ulong ToUInt64(byte[] value, int startIndex) { }

	// RVA: 0x350A420 Offset: 0x350A521 VA: 0x350A420
	public static float ToSingle(byte[] value, int startIndex) { }

	// RVA: 0x350A500 Offset: 0x350A601 VA: 0x350A500
	public static double ToDouble(byte[] value, int startIndex) { }

	// RVA: 0x350A5E0 Offset: 0x350A6E1 VA: 0x350A5E0
	private static char GetHexValue(int i) { }

	// RVA: 0x350A600 Offset: 0x350A701 VA: 0x350A600
	public static string ToString(byte[] value, int startIndex, int length) { }

	// RVA: 0x350A980 Offset: 0x350AA81 VA: 0x350A980
	public static string ToString(byte[] value) { }

	// RVA: 0x350AA40 Offset: 0x350AB41 VA: 0x350AA40
	public static bool ToBoolean(byte[] value, int startIndex) { }

	// RVA: 0x350AB50 Offset: 0x350AC51 VA: 0x350AB50
	public static long DoubleToInt64Bits(double value) { }

	// RVA: 0x350AB60 Offset: 0x350AC61 VA: 0x350AB60
	public static double Int64BitsToDouble(long value) { }

	// RVA: 0x350AB70 Offset: 0x350AC71 VA: 0x350AB70
	private static void .cctor() { }
}

