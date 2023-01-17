// Namespace: System
[ComVisibleAttribute] // RVA: 0x471200 Offset: 0x471301 VA: 0x471200
[Serializable]
public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 393
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x3607270 Offset: 0x3607371 VA: 0x3607270
	internal void .ctor(IntPtr val) { }

	// RVA: 0x3607280 Offset: 0x3607381 VA: 0x3607280
	internal void .ctor(RuntimeType type) { }

	// RVA: 0x3607290 Offset: 0x3607391 VA: 0x3607290
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x36076B0 Offset: 0x36077B1 VA: 0x36076B0
	public IntPtr get_Value() { }

	// RVA: 0x36076C0 Offset: 0x36077C1 VA: 0x36076C0 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x47B280 Offset: 0x47B381 VA: 0x47B280
	// RVA: 0x3607900 Offset: 0x3607A01 VA: 0x3607900 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0x47B2A0 Offset: 0x47B3A1 VA: 0x47B2A0
	// RVA: 0x3607A20 Offset: 0x3607B21 VA: 0x3607A20
	public bool Equals(RuntimeTypeHandle handle) { }

	// RVA: 0x3607A30 Offset: 0x3607B31 VA: 0x3607A30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3607A40 Offset: 0x3607B41 VA: 0x3607A40
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	// RVA: 0x3607A50 Offset: 0x3607B51 VA: 0x3607A50
	private static int GetMetadataToken(RuntimeType type) { }

	// RVA: 0x3607A60 Offset: 0x3607B61 VA: 0x3607A60
	internal static int GetToken(RuntimeType type) { }

	// RVA: 0x3607A70 Offset: 0x3607B71 VA: 0x3607A70
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	// RVA: 0x3607A80 Offset: 0x3607B81 VA: 0x3607A80
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x3607A90 Offset: 0x3607B91 VA: 0x3607A90
	internal static bool HasElementType(RuntimeType type) { }

	// RVA: 0x3607B10 Offset: 0x3607C11 VA: 0x3607B10
	internal static bool HasInstantiation(RuntimeType type) { }

	// RVA: 0x3607AE0 Offset: 0x3607BE1 VA: 0x3607AE0
	internal static bool IsArray(RuntimeType type) { }

	// RVA: 0x3607AF0 Offset: 0x3607BF1 VA: 0x3607AF0
	internal static bool IsByRef(RuntimeType type) { }

	// RVA: 0x3607B20 Offset: 0x3607C21 VA: 0x3607B20
	internal static bool IsComObject(RuntimeType type) { }

	// RVA: 0x3607B30 Offset: 0x3607C31 VA: 0x3607B30
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	// RVA: 0x3607B00 Offset: 0x3607C01 VA: 0x3607B00
	internal static bool IsPointer(RuntimeType type) { }

	// RVA: 0x3607B40 Offset: 0x3607C41 VA: 0x3607B40
	internal static bool IsPrimitive(RuntimeType type) { }

	// RVA: 0x3607B50 Offset: 0x3607C51 VA: 0x3607B50
	internal static bool HasReferences(RuntimeType type) { }

	// RVA: 0x3607B60 Offset: 0x3607C61 VA: 0x3607B60
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	// RVA: 0x3607B70 Offset: 0x3607C71 VA: 0x3607B70
	internal static bool IsContextful(RuntimeType type) { }

	// RVA: 0x3607C10 Offset: 0x3607D11 VA: 0x3607C10
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	// RVA: 0x3607C20 Offset: 0x3607D21 VA: 0x3607C20
	internal static bool IsSzArray(RuntimeType type) { }

	// RVA: 0x3607C70 Offset: 0x3607D71 VA: 0x3607C70
	internal static bool IsInterface(RuntimeType type) { }

	// RVA: 0x3607C90 Offset: 0x3607D91 VA: 0x3607C90
	internal static int GetArrayRank(RuntimeType type) { }

	// RVA: 0x3607CA0 Offset: 0x3607DA1 VA: 0x3607CA0
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	// RVA: 0x3607CB0 Offset: 0x3607DB1 VA: 0x3607CB0
	internal static RuntimeType GetElementType(RuntimeType type) { }

	// RVA: 0x3607CC0 Offset: 0x3607DC1 VA: 0x3607CC0
	internal static RuntimeModule GetModule(RuntimeType type) { }

	// RVA: 0x3607CD0 Offset: 0x3607DD1 VA: 0x3607CD0
	internal static bool IsGenericVariable(RuntimeType type) { }

	// RVA: 0x3607CE0 Offset: 0x3607DE1 VA: 0x3607CE0
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	// RVA: 0x3607CF0 Offset: 0x3607DF1 VA: 0x3607CF0
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	// RVA: 0x3607D00 Offset: 0x3607E01 VA: 0x3607D00
	private static bool type_is_assignable_from(Type a, Type b) { }

	// RVA: 0x3607D10 Offset: 0x3607E11 VA: 0x3607D10
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x3607D20 Offset: 0x3607E21 VA: 0x3607D20
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }
}

