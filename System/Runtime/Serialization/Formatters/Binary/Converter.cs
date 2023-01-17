// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class Converter // TypeDefIndex: 1052
{
	// Fields
	private static int primitiveTypeEnumLength; // 0x0
	private static Type[] typeA; // 0x8
	private static Type[] arrayTypeA; // 0x10
	private static string[] valueA; // 0x18
	private static TypeCode[] typeCodeA; // 0x20
	private static InternalPrimitiveTypeE[] codeA; // 0x28
	internal static Type typeofISerializable; // 0x30
	internal static Type typeofString; // 0x38
	internal static Type typeofConverter; // 0x40
	internal static Type typeofBoolean; // 0x48
	internal static Type typeofByte; // 0x50
	internal static Type typeofChar; // 0x58
	internal static Type typeofDecimal; // 0x60
	internal static Type typeofDouble; // 0x68
	internal static Type typeofInt16; // 0x70
	internal static Type typeofInt32; // 0x78
	internal static Type typeofInt64; // 0x80
	internal static Type typeofSByte; // 0x88
	internal static Type typeofSingle; // 0x90
	internal static Type typeofTimeSpan; // 0x98
	internal static Type typeofDateTime; // 0xA0
	internal static Type typeofUInt16; // 0xA8
	internal static Type typeofUInt32; // 0xB0
	internal static Type typeofUInt64; // 0xB8
	internal static Type typeofObject; // 0xC0
	internal static Type typeofSystemVoid; // 0xC8
	internal static Assembly urtAssembly; // 0xD0
	internal static string urtAssemblyString; // 0xD8
	internal static Type typeofTypeArray; // 0xE0
	internal static Type typeofObjectArray; // 0xE8
	internal static Type typeofStringArray; // 0xF0
	internal static Type typeofBooleanArray; // 0xF8
	internal static Type typeofByteArray; // 0x100
	internal static Type typeofCharArray; // 0x108
	internal static Type typeofDecimalArray; // 0x110
	internal static Type typeofDoubleArray; // 0x118
	internal static Type typeofInt16Array; // 0x120
	internal static Type typeofInt32Array; // 0x128
	internal static Type typeofInt64Array; // 0x130
	internal static Type typeofSByteArray; // 0x138
	internal static Type typeofSingleArray; // 0x140
	internal static Type typeofTimeSpanArray; // 0x148
	internal static Type typeofDateTimeArray; // 0x150
	internal static Type typeofUInt16Array; // 0x158
	internal static Type typeofUInt32Array; // 0x160
	internal static Type typeofUInt64Array; // 0x168
	internal static Type typeofMarshalByRefObject; // 0x170

	// Methods

	// RVA: 0x37D31D0 Offset: 0x37D32D1 VA: 0x37D31D0
	internal static InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x37D3450 Offset: 0x37D3551 VA: 0x37D3450
	internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code) { }

	// RVA: 0x37D3480 Offset: 0x37D3581 VA: 0x37D3480
	internal static int TypeLength(InternalPrimitiveTypeE code) { }

	// RVA: 0x37D34B0 Offset: 0x37D35B1 VA: 0x37D34B0
	internal static Type ToArrayType(InternalPrimitiveTypeE code) { }

	// RVA: 0x37D3A40 Offset: 0x37D3B41 VA: 0x37D3A40
	private static void InitTypeA() { }

	// RVA: 0x37D35B0 Offset: 0x37D36B1 VA: 0x37D35B0
	private static void InitArrayTypeA() { }

	// RVA: 0x37D3ED0 Offset: 0x37D3FD1 VA: 0x37D3ED0
	internal static Type ToType(InternalPrimitiveTypeE code) { }

	// RVA: 0x37D3FD0 Offset: 0x37D40D1 VA: 0x37D3FD0
	internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length) { }

	// RVA: 0x37D4100 Offset: 0x37D4201 VA: 0x37D4100
	internal static bool IsPrimitiveArray(Type type, out object typeInformation) { }

	// RVA: 0x37D4440 Offset: 0x37D4541 VA: 0x37D4440
	private static void InitValueA() { }

	// RVA: 0x37D4A70 Offset: 0x37D4B71 VA: 0x37D4A70
	internal static string ToComType(InternalPrimitiveTypeE code) { }

	// RVA: 0x37D4B70 Offset: 0x37D4C71 VA: 0x37D4B70
	private static void InitTypeCodeA() { }

	// RVA: 0x37D4D20 Offset: 0x37D4E21 VA: 0x37D4D20
	internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code) { }

	// RVA: 0x37D4E20 Offset: 0x37D4F21 VA: 0x37D4E20
	private static void InitCodeA() { }

	// RVA: 0x37D3350 Offset: 0x37D3451 VA: 0x37D3350
	internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode) { }

	// RVA: 0x37D4FE0 Offset: 0x37D50E1 VA: 0x37D4FE0
	internal static object FromString(string value, InternalPrimitiveTypeE code) { }

	// RVA: 0x37D51A0 Offset: 0x37D52A1 VA: 0x37D51A0
	private static void .cctor() { }
}

