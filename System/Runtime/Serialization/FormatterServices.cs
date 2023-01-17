// Namespace: System.Runtime.Serialization
[ComVisibleAttribute] // RVA: 0x474460 Offset: 0x474561 VA: 0x474460
public static class FormatterServices // TypeDefIndex: 989
{
	// Fields
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; // 0x0
	private static bool unsafeTypeForwardersIsEnabled; // 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
	private static readonly Type[] advancedTypes; // 0x10
	private static Binder s_binder; // 0x18

	// Methods

	// RVA: 0x38B4290 Offset: 0x38B4391 VA: 0x38B4290
	private static void .cctor() { }

	// RVA: 0x38B4440 Offset: 0x38B4541 VA: 0x38B4440
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	// RVA: 0x38B45F0 Offset: 0x38B46F1 VA: 0x38B45F0
	private static bool CheckSerializable(RuntimeType type) { }

	// RVA: 0x38B4600 Offset: 0x38B4701 VA: 0x38B4600
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	// RVA: 0x38B4DE0 Offset: 0x38B4EE1 VA: 0x38B4DE0
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	// RVA: 0x38B5150 Offset: 0x38B5251 VA: 0x38B5150
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	// RVA: 0x38B5400 Offset: 0x38B5501 VA: 0x38B5400
	public static object GetUninitializedObject(Type type) { }

	// RVA: 0x38B55C0 Offset: 0x38B56C1 VA: 0x38B55C0
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	// RVA: 0x38B55D0 Offset: 0x38B56D1 VA: 0x38B55D0
	private static bool GetEnableUnsafeTypeForwarders() { }

	// RVA: 0x38B55E0 Offset: 0x38B56E1 VA: 0x38B55E0
	internal static bool UnsafeTypeForwardersIsEnabled() { }

	// RVA: 0x38B56B0 Offset: 0x38B57B1 VA: 0x38B56B0
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	// RVA: 0x38B58A0 Offset: 0x38B59A1 VA: 0x38B58A0
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	// RVA: 0x38B5BB0 Offset: 0x38B5CB1 VA: 0x38B5BB0
	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	// RVA: 0x38B5F50 Offset: 0x38B6051 VA: 0x38B5F50
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	// RVA: 0x38B5FF0 Offset: 0x38B60F1 VA: 0x38B5FF0
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	// RVA: 0x38B6000 Offset: 0x38B6101 VA: 0x38B6000
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	// RVA: 0x38B6100 Offset: 0x38B6201 VA: 0x38B6100
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	// RVA: 0x38B6280 Offset: 0x38B6381 VA: 0x38B6280
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x38B6320 Offset: 0x38B6421 VA: 0x38B6320
	private static string GetClrTypeFullNameForArray(Type type) { }

	// RVA: 0x38B6550 Offset: 0x38B6651 VA: 0x38B6550
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }
}

