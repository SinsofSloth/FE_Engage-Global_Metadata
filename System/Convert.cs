// Namespace: System
public static class Convert // TypeDefIndex: 195
{
	// Fields
	internal static readonly RuntimeType[] ConvertTypes; // 0x0
	private static readonly RuntimeType EnumType; // 0x8
	internal static readonly char[] base64Table; // 0x10
	public static readonly object DBNull; // 0x18

	// Methods

	// RVA: 0x33B48F0 Offset: 0x33B49F1 VA: 0x33B48F0
	public static TypeCode GetTypeCode(object value) { }

	// RVA: 0x33B49C0 Offset: 0x33B4AC1 VA: 0x33B49C0
	public static bool IsDBNull(object value) { }

	// RVA: 0x33B4AF0 Offset: 0x33B4BF1 VA: 0x33B4AF0
	public static object ChangeType(object value, TypeCode typeCode, IFormatProvider provider) { }

	// RVA: 0x339F670 Offset: 0x339F771 VA: 0x339F670
	internal static object DefaultToType(IConvertible value, Type targetType, IFormatProvider provider) { }

	// RVA: 0x33B53B0 Offset: 0x33B54B1 VA: 0x33B53B0
	public static object ChangeType(object value, Type conversionType) { }

	// RVA: 0x33B5440 Offset: 0x33B5541 VA: 0x33B5440
	public static object ChangeType(object value, Type conversionType, IFormatProvider provider) { }

	// RVA: 0x33B6440 Offset: 0x33B6541 VA: 0x33B6440
	public static bool ToBoolean(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x4796D0 Offset: 0x4797D1 VA: 0x4796D0
	// RVA: 0x33B6530 Offset: 0x33B6631 VA: 0x33B6530
	public static bool ToBoolean(sbyte value) { }

	// RVA: 0x33B6540 Offset: 0x33B6641 VA: 0x33B6540
	public static bool ToBoolean(byte value) { }

	// RVA: 0x33B6550 Offset: 0x33B6651 VA: 0x33B6550
	public static bool ToBoolean(short value) { }

	[CLSCompliantAttribute] // RVA: 0x4796F0 Offset: 0x4797F1 VA: 0x4796F0
	// RVA: 0x33B6560 Offset: 0x33B6661 VA: 0x33B6560
	public static bool ToBoolean(ushort value) { }

	// RVA: 0x33B6570 Offset: 0x33B6671 VA: 0x33B6570
	public static bool ToBoolean(int value) { }

	[CLSCompliantAttribute] // RVA: 0x479710 Offset: 0x479811 VA: 0x479710
	// RVA: 0x33B6580 Offset: 0x33B6681 VA: 0x33B6580
	public static bool ToBoolean(uint value) { }

	// RVA: 0x33B6590 Offset: 0x33B6691 VA: 0x33B6590
	public static bool ToBoolean(long value) { }

	[CLSCompliantAttribute] // RVA: 0x479730 Offset: 0x479831 VA: 0x479730
	// RVA: 0x33B65A0 Offset: 0x33B66A1 VA: 0x33B65A0
	public static bool ToBoolean(ulong value) { }

	// RVA: 0x33B65B0 Offset: 0x33B66B1 VA: 0x33B65B0
	public static bool ToBoolean(string value, IFormatProvider provider) { }

	// RVA: 0x33B6630 Offset: 0x33B6731 VA: 0x33B6630
	public static bool ToBoolean(float value) { }

	// RVA: 0x33B6640 Offset: 0x33B6741 VA: 0x33B6640
	public static bool ToBoolean(double value) { }

	// RVA: 0x33B6650 Offset: 0x33B6751 VA: 0x33B6650
	public static bool ToBoolean(Decimal value) { }

	// RVA: 0x33B66D0 Offset: 0x33B67D1 VA: 0x33B66D0
	public static char ToChar(object value) { }

	// RVA: 0x33B67C0 Offset: 0x33B68C1 VA: 0x33B67C0
	public static char ToChar(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x479750 Offset: 0x479851 VA: 0x479750
	// RVA: 0x33B68B0 Offset: 0x33B69B1 VA: 0x33B68B0
	public static char ToChar(sbyte value) { }

	// RVA: 0x33B6920 Offset: 0x33B6A21 VA: 0x33B6920
	public static char ToChar(byte value) { }

	// RVA: 0x33B6930 Offset: 0x33B6A31 VA: 0x33B6930
	public static char ToChar(short value) { }

	[CLSCompliantAttribute] // RVA: 0x479770 Offset: 0x479871 VA: 0x479770
	// RVA: 0x33B69A0 Offset: 0x33B6AA1 VA: 0x33B69A0
	public static char ToChar(ushort value) { }

	// RVA: 0x33B69B0 Offset: 0x33B6AB1 VA: 0x33B69B0
	public static char ToChar(int value) { }

	[CLSCompliantAttribute] // RVA: 0x479790 Offset: 0x479891 VA: 0x479790
	// RVA: 0x33B6A20 Offset: 0x33B6B21 VA: 0x33B6A20
	public static char ToChar(uint value) { }

	// RVA: 0x33B6A90 Offset: 0x33B6B91 VA: 0x33B6A90
	public static char ToChar(long value) { }

	[CLSCompliantAttribute] // RVA: 0x4797B0 Offset: 0x4798B1 VA: 0x4797B0
	// RVA: 0x33B6B00 Offset: 0x33B6C01 VA: 0x33B6B00
	public static char ToChar(ulong value) { }

	// RVA: 0x33B6B70 Offset: 0x33B6C71 VA: 0x33B6B70
	public static char ToChar(string value) { }

	// RVA: 0x33B6BE0 Offset: 0x33B6CE1 VA: 0x33B6BE0
	public static char ToChar(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x4797D0 Offset: 0x4798D1 VA: 0x4797D0
	// RVA: 0x33B6CB0 Offset: 0x33B6DB1 VA: 0x33B6CB0
	public static sbyte ToSByte(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x4797F0 Offset: 0x4798F1 VA: 0x4797F0
	// RVA: 0x33B6DA0 Offset: 0x33B6EA1 VA: 0x33B6DA0
	public static sbyte ToSByte(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x479810 Offset: 0x479911 VA: 0x479810
	// RVA: 0x339ECD0 Offset: 0x339EDD1 VA: 0x339ECD0
	public static sbyte ToSByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0x479830 Offset: 0x479931 VA: 0x479830
	// RVA: 0x33B6DB0 Offset: 0x33B6EB1 VA: 0x33B6DB0
	public static sbyte ToSByte(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x479850 Offset: 0x479951 VA: 0x479850
	// RVA: 0x33B6E20 Offset: 0x33B6F21 VA: 0x33B6E20
	public static sbyte ToSByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0x479870 Offset: 0x479971 VA: 0x479870
	// RVA: 0x33B6E90 Offset: 0x33B6F91 VA: 0x33B6E90
	public static sbyte ToSByte(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x479890 Offset: 0x479991 VA: 0x479890
	// RVA: 0x33B6F00 Offset: 0x33B7001 VA: 0x33B6F00
	public static sbyte ToSByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0x4798B0 Offset: 0x4799B1 VA: 0x4798B0
	// RVA: 0x33B6F70 Offset: 0x33B7071 VA: 0x33B6F70
	public static sbyte ToSByte(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x4798D0 Offset: 0x4799D1 VA: 0x4798D0
	// RVA: 0x33B6FE0 Offset: 0x33B70E1 VA: 0x33B6FE0
	public static sbyte ToSByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0x4798F0 Offset: 0x4799F1 VA: 0x4798F0
	// RVA: 0x33B7050 Offset: 0x33B7151 VA: 0x33B7050
	public static sbyte ToSByte(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x479910 Offset: 0x479A11 VA: 0x479910
	// RVA: 0x33B70C0 Offset: 0x33B71C1 VA: 0x33B70C0
	public static sbyte ToSByte(float value) { }

	[CLSCompliantAttribute] // RVA: 0x479930 Offset: 0x479A31 VA: 0x479930
	// RVA: 0x33B7130 Offset: 0x33B7231 VA: 0x33B7130
	public static sbyte ToSByte(double value) { }

	[CLSCompliantAttribute] // RVA: 0x479950 Offset: 0x479A51 VA: 0x479950
	// RVA: 0x33B7310 Offset: 0x33B7411 VA: 0x33B7310
	public static sbyte ToSByte(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x479970 Offset: 0x479A71 VA: 0x479970
	// RVA: 0x33B7390 Offset: 0x33B7491 VA: 0x33B7390
	public static sbyte ToSByte(string value, IFormatProvider provider) { }

	// RVA: 0x33B73A0 Offset: 0x33B74A1 VA: 0x33B73A0
	public static byte ToByte(object value, IFormatProvider provider) { }

	// RVA: 0x33B7490 Offset: 0x33B7591 VA: 0x33B7490
	public static byte ToByte(bool value) { }

	// RVA: 0x339EE10 Offset: 0x339EF11 VA: 0x339EE10
	public static byte ToByte(char value) { }

	[CLSCompliantAttribute] // RVA: 0x479990 Offset: 0x479A91 VA: 0x479990
	// RVA: 0x33B74A0 Offset: 0x33B75A1 VA: 0x33B74A0
	public static byte ToByte(sbyte value) { }

	// RVA: 0x33B7510 Offset: 0x33B7611 VA: 0x33B7510
	public static byte ToByte(short value) { }

	[CLSCompliantAttribute] // RVA: 0x4799B0 Offset: 0x479AB1 VA: 0x4799B0
	// RVA: 0x33B7580 Offset: 0x33B7681 VA: 0x33B7580
	public static byte ToByte(ushort value) { }

	// RVA: 0x33B75F0 Offset: 0x33B76F1 VA: 0x33B75F0
	public static byte ToByte(int value) { }

	[CLSCompliantAttribute] // RVA: 0x4799D0 Offset: 0x479AD1 VA: 0x4799D0
	// RVA: 0x33B7660 Offset: 0x33B7761 VA: 0x33B7660
	public static byte ToByte(uint value) { }

	// RVA: 0x33B76D0 Offset: 0x33B77D1 VA: 0x33B76D0
	public static byte ToByte(long value) { }

	[CLSCompliantAttribute] // RVA: 0x4799F0 Offset: 0x479AF1 VA: 0x4799F0
	// RVA: 0x33B7740 Offset: 0x33B7841 VA: 0x33B7740
	public static byte ToByte(ulong value) { }

	// RVA: 0x33B77B0 Offset: 0x33B78B1 VA: 0x33B77B0
	public static byte ToByte(float value) { }

	// RVA: 0x33B7820 Offset: 0x33B7921 VA: 0x33B7820
	public static byte ToByte(double value) { }

	// RVA: 0x33B78F0 Offset: 0x33B79F1 VA: 0x33B78F0
	public static byte ToByte(Decimal value) { }

	// RVA: 0x33B7970 Offset: 0x33B7A71 VA: 0x33B7970
	public static byte ToByte(string value) { }

	// RVA: 0x33B7A00 Offset: 0x33B7B01 VA: 0x33B7A00
	public static byte ToByte(string value, IFormatProvider provider) { }

	// RVA: 0x33B7A20 Offset: 0x33B7B21 VA: 0x33B7A20
	public static short ToInt16(object value, IFormatProvider provider) { }

	// RVA: 0x33B7B10 Offset: 0x33B7C11 VA: 0x33B7B10
	public static short ToInt16(bool value) { }

	// RVA: 0x339EF40 Offset: 0x339F041 VA: 0x339EF40
	public static short ToInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0x479A10 Offset: 0x479B11 VA: 0x479A10
	// RVA: 0x33B7B20 Offset: 0x33B7C21 VA: 0x33B7B20
	public static short ToInt16(sbyte value) { }

	// RVA: 0x33B7B30 Offset: 0x33B7C31 VA: 0x33B7B30
	public static short ToInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x479A30 Offset: 0x479B31 VA: 0x479A30
	// RVA: 0x33B7B40 Offset: 0x33B7C41 VA: 0x33B7B40
	public static short ToInt16(ushort value) { }

	// RVA: 0x33B7BB0 Offset: 0x33B7CB1 VA: 0x33B7BB0
	public static short ToInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0x479A50 Offset: 0x479B51 VA: 0x479A50
	// RVA: 0x33B7C20 Offset: 0x33B7D21 VA: 0x33B7C20
	public static short ToInt16(uint value) { }

	// RVA: 0x33B7C90 Offset: 0x33B7D91 VA: 0x33B7C90
	public static short ToInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0x479A70 Offset: 0x479B71 VA: 0x479A70
	// RVA: 0x33B7D00 Offset: 0x33B7E01 VA: 0x33B7D00
	public static short ToInt16(ulong value) { }

	// RVA: 0x33B7D70 Offset: 0x33B7E71 VA: 0x33B7D70
	public static short ToInt16(float value) { }

	// RVA: 0x33B7DE0 Offset: 0x33B7EE1 VA: 0x33B7DE0
	public static short ToInt16(double value) { }

	// RVA: 0x33B7EB0 Offset: 0x33B7FB1 VA: 0x33B7EB0
	public static short ToInt16(Decimal value) { }

	// RVA: 0x33B7F30 Offset: 0x33B8031 VA: 0x33B7F30
	public static short ToInt16(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x479A90 Offset: 0x479B91 VA: 0x479A90
	// RVA: 0x33B7F50 Offset: 0x33B8051 VA: 0x33B7F50
	public static ushort ToUInt16(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x479AB0 Offset: 0x479BB1 VA: 0x479AB0
	// RVA: 0x33B8040 Offset: 0x33B8141 VA: 0x33B8040
	public static ushort ToUInt16(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x479AD0 Offset: 0x479BD1 VA: 0x479AD0
	// RVA: 0x339F020 Offset: 0x339F121 VA: 0x339F020
	public static ushort ToUInt16(char value) { }

	[CLSCompliantAttribute] // RVA: 0x479AF0 Offset: 0x479BF1 VA: 0x479AF0
	// RVA: 0x33B8050 Offset: 0x33B8151 VA: 0x33B8050
	public static ushort ToUInt16(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0x479B10 Offset: 0x479C11 VA: 0x479B10
	// RVA: 0x33B80C0 Offset: 0x33B81C1 VA: 0x33B80C0
	public static ushort ToUInt16(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x479B30 Offset: 0x479C31 VA: 0x479B30
	// RVA: 0x33B80D0 Offset: 0x33B81D1 VA: 0x33B80D0
	public static ushort ToUInt16(short value) { }

	[CLSCompliantAttribute] // RVA: 0x479B50 Offset: 0x479C51 VA: 0x479B50
	// RVA: 0x33B8140 Offset: 0x33B8241 VA: 0x33B8140
	public static ushort ToUInt16(int value) { }

	[CLSCompliantAttribute] // RVA: 0x479B70 Offset: 0x479C71 VA: 0x479B70
	// RVA: 0x33B81B0 Offset: 0x33B82B1 VA: 0x33B81B0
	public static ushort ToUInt16(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x479B90 Offset: 0x479C91 VA: 0x479B90
	// RVA: 0x33B8220 Offset: 0x33B8321 VA: 0x33B8220
	public static ushort ToUInt16(long value) { }

	[CLSCompliantAttribute] // RVA: 0x479BB0 Offset: 0x479CB1 VA: 0x479BB0
	// RVA: 0x33B8290 Offset: 0x33B8391 VA: 0x33B8290
	public static ushort ToUInt16(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x479BD0 Offset: 0x479CD1 VA: 0x479BD0
	// RVA: 0x33B8300 Offset: 0x33B8401 VA: 0x33B8300
	public static ushort ToUInt16(float value) { }

	[CLSCompliantAttribute] // RVA: 0x479BF0 Offset: 0x479CF1 VA: 0x479BF0
	// RVA: 0x33B8370 Offset: 0x33B8471 VA: 0x33B8370
	public static ushort ToUInt16(double value) { }

	[CLSCompliantAttribute] // RVA: 0x479C10 Offset: 0x479D11 VA: 0x479C10
	// RVA: 0x33B8440 Offset: 0x33B8541 VA: 0x33B8440
	public static ushort ToUInt16(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x479C30 Offset: 0x479D31 VA: 0x479C30
	// RVA: 0x33B84C0 Offset: 0x33B85C1 VA: 0x33B84C0
	public static ushort ToUInt16(string value, IFormatProvider provider) { }

	// RVA: 0x33B84E0 Offset: 0x33B85E1 VA: 0x33B84E0
	public static int ToInt32(object value) { }

	// RVA: 0x33B85D0 Offset: 0x33B86D1 VA: 0x33B85D0
	public static int ToInt32(object value, IFormatProvider provider) { }

	// RVA: 0x33B86C0 Offset: 0x33B87C1 VA: 0x33B86C0
	public static int ToInt32(bool value) { }

	// RVA: 0x339F0A0 Offset: 0x339F1A1 VA: 0x339F0A0
	public static int ToInt32(char value) { }

	// RVA: 0x33B86D0 Offset: 0x33B87D1 VA: 0x33B86D0
	public static int ToInt32(byte value) { }

	// RVA: 0x33B86E0 Offset: 0x33B87E1 VA: 0x33B86E0
	public static int ToInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0x479C50 Offset: 0x479D51 VA: 0x479C50
	// RVA: 0x33B86F0 Offset: 0x33B87F1 VA: 0x33B86F0
	public static int ToInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x479C70 Offset: 0x479D71 VA: 0x479C70
	// RVA: 0x33B8700 Offset: 0x33B8801 VA: 0x33B8700
	public static int ToInt32(uint value) { }

	// RVA: 0x33B8770 Offset: 0x33B8871 VA: 0x33B8770
	public static int ToInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0x479C90 Offset: 0x479D91 VA: 0x479C90
	// RVA: 0x33B87E0 Offset: 0x33B88E1 VA: 0x33B87E0
	public static int ToInt32(ulong value) { }

	// RVA: 0x33B8850 Offset: 0x33B8951 VA: 0x33B8850
	public static int ToInt32(float value) { }

	// RVA: 0x33B7200 Offset: 0x33B7301 VA: 0x33B7200
	public static int ToInt32(double value) { }

	// RVA: 0x33B88C0 Offset: 0x33B89C1 VA: 0x33B88C0
	public static int ToInt32(Decimal value) { }

	// RVA: 0x33B8940 Offset: 0x33B8A41 VA: 0x33B8940
	public static int ToInt32(string value) { }

	// RVA: 0x33B89D0 Offset: 0x33B8AD1 VA: 0x33B89D0
	public static int ToInt32(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x479CB0 Offset: 0x479DB1 VA: 0x479CB0
	// RVA: 0x33B89F0 Offset: 0x33B8AF1 VA: 0x33B89F0
	public static uint ToUInt32(object value) { }

	[CLSCompliantAttribute] // RVA: 0x479CD0 Offset: 0x479DD1 VA: 0x479CD0
	// RVA: 0x33B8AE0 Offset: 0x33B8BE1 VA: 0x33B8AE0
	public static uint ToUInt32(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x479CF0 Offset: 0x479DF1 VA: 0x479CF0
	// RVA: 0x33B8BD0 Offset: 0x33B8CD1 VA: 0x33B8BD0
	public static uint ToUInt32(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x479D10 Offset: 0x479E11 VA: 0x479D10
	// RVA: 0x339F120 Offset: 0x339F221 VA: 0x339F120
	public static uint ToUInt32(char value) { }

	[CLSCompliantAttribute] // RVA: 0x479D30 Offset: 0x479E31 VA: 0x479D30
	// RVA: 0x33B8BE0 Offset: 0x33B8CE1 VA: 0x33B8BE0
	public static uint ToUInt32(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0x479D50 Offset: 0x479E51 VA: 0x479D50
	// RVA: 0x33B8C50 Offset: 0x33B8D51 VA: 0x33B8C50
	public static uint ToUInt32(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x479D70 Offset: 0x479E71 VA: 0x479D70
	// RVA: 0x33B8C60 Offset: 0x33B8D61 VA: 0x33B8C60
	public static uint ToUInt32(short value) { }

	[CLSCompliantAttribute] // RVA: 0x479D90 Offset: 0x479E91 VA: 0x479D90
	// RVA: 0x33B8CD0 Offset: 0x33B8DD1 VA: 0x33B8CD0
	public static uint ToUInt32(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x479DB0 Offset: 0x479EB1 VA: 0x479DB0
	// RVA: 0x33B8CE0 Offset: 0x33B8DE1 VA: 0x33B8CE0
	public static uint ToUInt32(int value) { }

	[CLSCompliantAttribute] // RVA: 0x479DD0 Offset: 0x479ED1 VA: 0x479DD0
	// RVA: 0x33B8D50 Offset: 0x33B8E51 VA: 0x33B8D50
	public static uint ToUInt32(long value) { }

	[CLSCompliantAttribute] // RVA: 0x479DF0 Offset: 0x479EF1 VA: 0x479DF0
	// RVA: 0x33B8DC0 Offset: 0x33B8EC1 VA: 0x33B8DC0
	public static uint ToUInt32(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x479E10 Offset: 0x479F11 VA: 0x479E10
	// RVA: 0x33B8E30 Offset: 0x33B8F31 VA: 0x33B8E30
	public static uint ToUInt32(float value) { }

	[CLSCompliantAttribute] // RVA: 0x479E30 Offset: 0x479F31 VA: 0x479E30
	// RVA: 0x33B8EA0 Offset: 0x33B8FA1 VA: 0x33B8EA0
	public static uint ToUInt32(double value) { }

	[CLSCompliantAttribute] // RVA: 0x479E50 Offset: 0x479F51 VA: 0x479E50
	// RVA: 0x33B8F50 Offset: 0x33B9051 VA: 0x33B8F50
	public static uint ToUInt32(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x479E70 Offset: 0x479F71 VA: 0x479E70
	// RVA: 0x33B8FD0 Offset: 0x33B90D1 VA: 0x33B8FD0
	public static uint ToUInt32(string value, IFormatProvider provider) { }

	// RVA: 0x33B8FF0 Offset: 0x33B90F1 VA: 0x33B8FF0
	public static long ToInt64(object value) { }

	// RVA: 0x33B90E0 Offset: 0x33B91E1 VA: 0x33B90E0
	public static long ToInt64(object value, IFormatProvider provider) { }

	// RVA: 0x33B91D0 Offset: 0x33B92D1 VA: 0x33B91D0
	public static long ToInt64(bool value) { }

	// RVA: 0x339F1A0 Offset: 0x339F2A1 VA: 0x339F1A0
	public static long ToInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0x479E90 Offset: 0x479F91 VA: 0x479E90
	// RVA: 0x33B91E0 Offset: 0x33B92E1 VA: 0x33B91E0
	public static long ToInt64(sbyte value) { }

	// RVA: 0x33B91F0 Offset: 0x33B92F1 VA: 0x33B91F0
	public static long ToInt64(byte value) { }

	// RVA: 0x33B9200 Offset: 0x33B9301 VA: 0x33B9200
	public static long ToInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0x479EB0 Offset: 0x479FB1 VA: 0x479EB0
	// RVA: 0x33B9210 Offset: 0x33B9311 VA: 0x33B9210
	public static long ToInt64(ushort value) { }

	// RVA: 0x33B9220 Offset: 0x33B9321 VA: 0x33B9220
	public static long ToInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0x479ED0 Offset: 0x479FD1 VA: 0x479ED0
	// RVA: 0x33B9230 Offset: 0x33B9331 VA: 0x33B9230
	public static long ToInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x479EF0 Offset: 0x479FF1 VA: 0x479EF0
	// RVA: 0x33B9240 Offset: 0x33B9341 VA: 0x33B9240
	public static long ToInt64(ulong value) { }

	// RVA: 0x33B92B0 Offset: 0x33B93B1 VA: 0x33B92B0
	public static long ToInt64(float value) { }

	// RVA: 0x33B9320 Offset: 0x33B9421 VA: 0x33B9320
	public static long ToInt64(double value) { }

	// RVA: 0x33B9440 Offset: 0x33B9541 VA: 0x33B9440
	public static long ToInt64(Decimal value) { }

	// RVA: 0x33B94C0 Offset: 0x33B95C1 VA: 0x33B94C0
	public static long ToInt64(string value) { }

	// RVA: 0x33B9550 Offset: 0x33B9651 VA: 0x33B9550
	public static long ToInt64(string value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x479F10 Offset: 0x47A011 VA: 0x479F10
	// RVA: 0x33B9570 Offset: 0x33B9671 VA: 0x33B9570
	public static ulong ToUInt64(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x479F30 Offset: 0x47A031 VA: 0x479F30
	// RVA: 0x33B9660 Offset: 0x33B9761 VA: 0x33B9660
	public static ulong ToUInt64(bool value) { }

	[CLSCompliantAttribute] // RVA: 0x479F50 Offset: 0x47A051 VA: 0x479F50
	// RVA: 0x339F220 Offset: 0x339F321 VA: 0x339F220
	public static ulong ToUInt64(char value) { }

	[CLSCompliantAttribute] // RVA: 0x479F70 Offset: 0x47A071 VA: 0x479F70
	// RVA: 0x33B9670 Offset: 0x33B9771 VA: 0x33B9670
	public static ulong ToUInt64(sbyte value) { }

	[CLSCompliantAttribute] // RVA: 0x479F90 Offset: 0x47A091 VA: 0x479F90
	// RVA: 0x33B96E0 Offset: 0x33B97E1 VA: 0x33B96E0
	public static ulong ToUInt64(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x479FB0 Offset: 0x47A0B1 VA: 0x479FB0
	// RVA: 0x33B96F0 Offset: 0x33B97F1 VA: 0x33B96F0
	public static ulong ToUInt64(short value) { }

	[CLSCompliantAttribute] // RVA: 0x479FD0 Offset: 0x47A0D1 VA: 0x479FD0
	// RVA: 0x33B9760 Offset: 0x33B9861 VA: 0x33B9760
	public static ulong ToUInt64(ushort value) { }

	[CLSCompliantAttribute] // RVA: 0x479FF0 Offset: 0x47A0F1 VA: 0x479FF0
	// RVA: 0x33B9770 Offset: 0x33B9871 VA: 0x33B9770
	public static ulong ToUInt64(int value) { }

	[CLSCompliantAttribute] // RVA: 0x47A010 Offset: 0x47A111 VA: 0x47A010
	// RVA: 0x33B97E0 Offset: 0x33B98E1 VA: 0x33B97E0
	public static ulong ToUInt64(uint value) { }

	[CLSCompliantAttribute] // RVA: 0x47A030 Offset: 0x47A131 VA: 0x47A030
	// RVA: 0x33B97F0 Offset: 0x33B98F1 VA: 0x33B97F0
	public static ulong ToUInt64(long value) { }

	[CLSCompliantAttribute] // RVA: 0x47A050 Offset: 0x47A151 VA: 0x47A050
	// RVA: 0x33B9860 Offset: 0x33B9961 VA: 0x33B9860
	public static ulong ToUInt64(float value) { }

	[CLSCompliantAttribute] // RVA: 0x47A070 Offset: 0x47A171 VA: 0x47A070
	// RVA: 0x33B98D0 Offset: 0x33B99D1 VA: 0x33B98D0
	public static ulong ToUInt64(double value) { }

	[CLSCompliantAttribute] // RVA: 0x47A090 Offset: 0x47A191 VA: 0x47A090
	// RVA: 0x33B99D0 Offset: 0x33B9AD1 VA: 0x33B99D0
	public static ulong ToUInt64(Decimal value) { }

	[CLSCompliantAttribute] // RVA: 0x47A0B0 Offset: 0x47A1B1 VA: 0x47A0B0
	// RVA: 0x33B9A50 Offset: 0x33B9B51 VA: 0x33B9A50
	public static ulong ToUInt64(string value, IFormatProvider provider) { }

	// RVA: 0x33B9A70 Offset: 0x33B9B71 VA: 0x33B9A70
	public static float ToSingle(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x47A0D0 Offset: 0x47A1D1 VA: 0x47A0D0
	// RVA: 0x33B9B60 Offset: 0x33B9C61 VA: 0x33B9B60
	public static float ToSingle(sbyte value) { }

	// RVA: 0x33B9B70 Offset: 0x33B9C71 VA: 0x33B9B70
	public static float ToSingle(byte value) { }

	// RVA: 0x33B9B80 Offset: 0x33B9C81 VA: 0x33B9B80
	public static float ToSingle(short value) { }

	[CLSCompliantAttribute] // RVA: 0x47A0F0 Offset: 0x47A1F1 VA: 0x47A0F0
	// RVA: 0x33B9B90 Offset: 0x33B9C91 VA: 0x33B9B90
	public static float ToSingle(ushort value) { }

	// RVA: 0x33B9BA0 Offset: 0x33B9CA1 VA: 0x33B9BA0
	public static float ToSingle(int value) { }

	[CLSCompliantAttribute] // RVA: 0x47A110 Offset: 0x47A211 VA: 0x47A110
	// RVA: 0x33B9BB0 Offset: 0x33B9CB1 VA: 0x33B9BB0
	public static float ToSingle(uint value) { }

	// RVA: 0x33B9BC0 Offset: 0x33B9CC1 VA: 0x33B9BC0
	public static float ToSingle(long value) { }

	[CLSCompliantAttribute] // RVA: 0x47A130 Offset: 0x47A231 VA: 0x47A130
	// RVA: 0x33B9BD0 Offset: 0x33B9CD1 VA: 0x33B9BD0
	public static float ToSingle(ulong value) { }

	// RVA: 0x33B9BE0 Offset: 0x33B9CE1 VA: 0x33B9BE0
	public static float ToSingle(double value) { }

	// RVA: 0x33B9BF0 Offset: 0x33B9CF1 VA: 0x33B9BF0
	public static float ToSingle(Decimal value) { }

	// RVA: 0x33B9C70 Offset: 0x33B9D71 VA: 0x33B9C70
	public static float ToSingle(string value, IFormatProvider provider) { }

	// RVA: 0x33B9C90 Offset: 0x33B9D91 VA: 0x33B9C90
	public static float ToSingle(bool value) { }

	// RVA: 0x33B9CB0 Offset: 0x33B9DB1 VA: 0x33B9CB0
	public static double ToDouble(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x47A150 Offset: 0x47A251 VA: 0x47A150
	// RVA: 0x33B9DA0 Offset: 0x33B9EA1 VA: 0x33B9DA0
	public static double ToDouble(sbyte value) { }

	// RVA: 0x33B9DB0 Offset: 0x33B9EB1 VA: 0x33B9DB0
	public static double ToDouble(byte value) { }

	// RVA: 0x33B9DC0 Offset: 0x33B9EC1 VA: 0x33B9DC0
	public static double ToDouble(short value) { }

	[CLSCompliantAttribute] // RVA: 0x47A170 Offset: 0x47A271 VA: 0x47A170
	// RVA: 0x33B9DD0 Offset: 0x33B9ED1 VA: 0x33B9DD0
	public static double ToDouble(ushort value) { }

	// RVA: 0x33B9DE0 Offset: 0x33B9EE1 VA: 0x33B9DE0
	public static double ToDouble(int value) { }

	[CLSCompliantAttribute] // RVA: 0x47A190 Offset: 0x47A291 VA: 0x47A190
	// RVA: 0x33B9DF0 Offset: 0x33B9EF1 VA: 0x33B9DF0
	public static double ToDouble(uint value) { }

	// RVA: 0x33B9E00 Offset: 0x33B9F01 VA: 0x33B9E00
	public static double ToDouble(long value) { }

	[CLSCompliantAttribute] // RVA: 0x47A1B0 Offset: 0x47A2B1 VA: 0x47A1B0
	// RVA: 0x33B9E10 Offset: 0x33B9F11 VA: 0x33B9E10
	public static double ToDouble(ulong value) { }

	// RVA: 0x33B9E20 Offset: 0x33B9F21 VA: 0x33B9E20
	public static double ToDouble(float value) { }

	// RVA: 0x33B9E30 Offset: 0x33B9F31 VA: 0x33B9E30
	public static double ToDouble(Decimal value) { }

	// RVA: 0x33B9EB0 Offset: 0x33B9FB1 VA: 0x33B9EB0
	public static double ToDouble(string value, IFormatProvider provider) { }

	// RVA: 0x33B9F40 Offset: 0x33BA041 VA: 0x33B9F40
	public static double ToDouble(bool value) { }

	// RVA: 0x33B9F60 Offset: 0x33BA061 VA: 0x33B9F60
	public static Decimal ToDecimal(object value, IFormatProvider provider) { }

	[CLSCompliantAttribute] // RVA: 0x47A1D0 Offset: 0x47A2D1 VA: 0x47A1D0
	// RVA: 0x33BA080 Offset: 0x33BA181 VA: 0x33BA080
	public static Decimal ToDecimal(sbyte value) { }

	// RVA: 0x33BA0F0 Offset: 0x33BA1F1 VA: 0x33BA0F0
	public static Decimal ToDecimal(byte value) { }

	// RVA: 0x33BA160 Offset: 0x33BA261 VA: 0x33BA160
	public static Decimal ToDecimal(short value) { }

	[CLSCompliantAttribute] // RVA: 0x47A1F0 Offset: 0x47A2F1 VA: 0x47A1F0
	// RVA: 0x33BA1D0 Offset: 0x33BA2D1 VA: 0x33BA1D0
	public static Decimal ToDecimal(ushort value) { }

	// RVA: 0x33BA240 Offset: 0x33BA341 VA: 0x33BA240
	public static Decimal ToDecimal(int value) { }

	[CLSCompliantAttribute] // RVA: 0x47A210 Offset: 0x47A311 VA: 0x47A210
	// RVA: 0x33BA2B0 Offset: 0x33BA3B1 VA: 0x33BA2B0
	public static Decimal ToDecimal(uint value) { }

	// RVA: 0x33BA320 Offset: 0x33BA421 VA: 0x33BA320
	public static Decimal ToDecimal(long value) { }

	[CLSCompliantAttribute] // RVA: 0x47A230 Offset: 0x47A331 VA: 0x47A230
	// RVA: 0x33BA390 Offset: 0x33BA491 VA: 0x33BA390
	public static Decimal ToDecimal(ulong value) { }

	// RVA: 0x33BA400 Offset: 0x33BA501 VA: 0x33BA400
	public static Decimal ToDecimal(float value) { }

	// RVA: 0x33BA470 Offset: 0x33BA571 VA: 0x33BA470
	public static Decimal ToDecimal(double value) { }

	// RVA: 0x33BA4E0 Offset: 0x33BA5E1 VA: 0x33BA4E0
	public static Decimal ToDecimal(string value, IFormatProvider provider) { }

	// RVA: 0x33BA590 Offset: 0x33BA691 VA: 0x33BA590
	public static Decimal ToDecimal(bool value) { }

	// RVA: 0x33BA600 Offset: 0x33BA701 VA: 0x33BA600
	public static DateTime ToDateTime(string value, IFormatProvider provider) { }

	// RVA: 0x33BA6B0 Offset: 0x33BA7B1 VA: 0x33BA6B0
	public static string ToString(object value, IFormatProvider provider) { }

	// RVA: 0x33BA860 Offset: 0x33BA961 VA: 0x33BA860
	public static string ToString(char value, IFormatProvider provider) { }

	// RVA: 0x33BA8E0 Offset: 0x33BA9E1 VA: 0x33BA8E0
	public static string ToString(int value, IFormatProvider provider) { }

	// RVA: 0x33BA910 Offset: 0x33BAA11 VA: 0x33BA910
	public static byte ToByte(string value, int fromBase) { }

	// RVA: 0x33BA9F0 Offset: 0x33BAAF1 VA: 0x33BA9F0
	public static int ToInt32(string value, int fromBase) { }

	[CLSCompliantAttribute] // RVA: 0x47A250 Offset: 0x47A351 VA: 0x47A250
	// RVA: 0x33BAA80 Offset: 0x33BAB81 VA: 0x33BAA80
	public static uint ToUInt32(string value, int fromBase) { }

	// RVA: 0x33BAB10 Offset: 0x33BAC11 VA: 0x33BAB10
	public static string ToString(byte value, int toBase) { }

	// RVA: 0x33BABB0 Offset: 0x33BACB1 VA: 0x33BABB0
	public static string ToString(int value, int toBase) { }

	// RVA: 0x33BAC50 Offset: 0x33BAD51 VA: 0x33BAC50
	public static string ToString(long value, int toBase) { }

	// RVA: 0x33BACF0 Offset: 0x33BADF1 VA: 0x33BACF0
	public static string ToBase64String(byte[] inArray) { }

	// RVA: 0x33A5550 Offset: 0x33A5651 VA: 0x33A5550
	public static string ToBase64String(byte[] inArray, int offset, int length) { }

	[ComVisibleAttribute] // RVA: 0x47A270 Offset: 0x47A371 VA: 0x47A270
	// RVA: 0x33BADB0 Offset: 0x33BAEB1 VA: 0x33BADB0
	public static string ToBase64String(byte[] inArray, int offset, int length, Base64FormattingOptions options) { }

	// RVA: 0x33BB1C0 Offset: 0x33BB2C1 VA: 0x33BB1C0
	private static int ConvertToBase64Array(char* outChars, byte* inData, int offset, int length, bool insertLineBreaks) { }

	// RVA: 0x33BB100 Offset: 0x33BB201 VA: 0x33BB100
	private static int ToBase64_CalculateAndValidateOutputLength(int inputLength, bool insertLineBreaks) { }

	// RVA: 0x33A55E0 Offset: 0x33A56E1 VA: 0x33A55E0
	public static byte[] FromBase64String(string s) { }

	// RVA: 0x33BB4E0 Offset: 0x33BB5E1 VA: 0x33BB4E0
	private static byte[] FromBase64CharPtr(char* inputPtr, int inputLength) { }

	// RVA: 0x33BB710 Offset: 0x33BB811 VA: 0x33BB710
	private static int FromBase64_Decode(char* startInputPtr, int inputLength, byte* startDestPtr, int destLength) { }

	// RVA: 0x33BB640 Offset: 0x33BB741 VA: 0x33BB640
	private static int FromBase64_ComputeResultLength(char* inputPtr, int inputLength) { }

	// RVA: 0x33BB940 Offset: 0x33BBA41 VA: 0x33BB940
	private static void .cctor() { }
}

