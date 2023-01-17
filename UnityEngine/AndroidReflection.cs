// Namespace: UnityEngine
internal class AndroidReflection // TypeDefIndex: 7515
{
	// Fields
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x0
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x8
	private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
	private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
	private static readonly IntPtr s_ReflectionHelperSetNativeExceptionOnProxy; // 0x30
	private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38

	// Methods

	// RVA: 0x3F01540 Offset: 0x3F01641 VA: 0x3F01540
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x3F01550 Offset: 0x3F01651 VA: 0x3F01550
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x3F01560 Offset: 0x3F01661 VA: 0x3F01560
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x3F01680 Offset: 0x3F01781 VA: 0x3F01680
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x3F017A0 Offset: 0x3F018A1 VA: 0x3F017A0
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x3F01980 Offset: 0x3F01A81 VA: 0x3F01980
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x3F01C30 Offset: 0x3F01D31 VA: 0x3F01C30
	public static IntPtr NewProxyInstance(IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x3F004D0 Offset: 0x3F005D1 VA: 0x3F004D0
	public static void SetNativeExceptionOnProxy(IntPtr proxy, Exception e, bool methodNotFound) { }

	// RVA: 0x3F01D10 Offset: 0x3F01E11 VA: 0x3F01D10
	private static void .cctor() { }
}

