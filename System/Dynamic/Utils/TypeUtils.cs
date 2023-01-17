// Namespace: System.Dynamic.Utils
[ExtensionAttribute] // RVA: 0x406D0 Offset: 0x407D1 VA: 0x406D0
internal static class TypeUtils // TypeDefIndex: 3280
{
	// Fields
	private static Assembly s_mscorlib; // 0x0

	// Properties
	private static Assembly MsCorLib { get; }

	// Methods

	[ExtensionAttribute] // RVA: 0x42320 Offset: 0x42421 VA: 0x42320
	// RVA: 0x3328540 Offset: 0x3328641 VA: 0x3328540
	public static Type GetNonNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0x42330 Offset: 0x42431 VA: 0x42330
	// RVA: 0x3334D30 Offset: 0x3334E31 VA: 0x3334D30
	public static Type GetNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0x42340 Offset: 0x42441 VA: 0x42340
	// RVA: 0x3334C60 Offset: 0x3334D61 VA: 0x3334C60
	public static bool IsNullableType(Type type) { }

	[ExtensionAttribute] // RVA: 0x42350 Offset: 0x42451 VA: 0x42350
	// RVA: 0x3334E70 Offset: 0x3334F71 VA: 0x3334E70
	public static bool IsNullableOrReferenceType(Type type) { }

	[ExtensionAttribute] // RVA: 0x42360 Offset: 0x42461 VA: 0x42360
	// RVA: 0x3334EB0 Offset: 0x3334FB1 VA: 0x3334EB0
	public static bool IsBool(Type type) { }

	[ExtensionAttribute] // RVA: 0x42370 Offset: 0x42471 VA: 0x42370
	// RVA: 0x3334F80 Offset: 0x3335081 VA: 0x3334F80
	public static bool IsNumeric(Type type) { }

	[ExtensionAttribute] // RVA: 0x42380 Offset: 0x42481 VA: 0x42380
	// RVA: 0x33350B0 Offset: 0x33351B1 VA: 0x33350B0
	public static bool IsInteger(Type type) { }

	[ExtensionAttribute] // RVA: 0x42390 Offset: 0x42491 VA: 0x42390
	// RVA: 0x33351E0 Offset: 0x33352E1 VA: 0x33351E0
	public static bool IsArithmetic(Type type) { }

	[ExtensionAttribute] // RVA: 0x423A0 Offset: 0x424A1 VA: 0x423A0
	// RVA: 0x3335310 Offset: 0x3335411 VA: 0x3335310
	public static bool IsUnsignedInt(Type type) { }

	[ExtensionAttribute] // RVA: 0x423B0 Offset: 0x424B1 VA: 0x423B0
	// RVA: 0x3335440 Offset: 0x3335541 VA: 0x3335440
	public static bool IsIntegerOrBool(Type type) { }

	[ExtensionAttribute] // RVA: 0x423C0 Offset: 0x424C1 VA: 0x423C0
	// RVA: 0x3335570 Offset: 0x3335671 VA: 0x3335570
	public static bool IsNumericOrBool(Type type) { }

	// RVA: 0x33355B0 Offset: 0x33356B1 VA: 0x33355B0
	public static bool IsValidInstanceType(MemberInfo member, Type instanceType) { }

	[ExtensionAttribute] // RVA: 0x423D0 Offset: 0x424D1 VA: 0x423D0
	// RVA: 0x3335A20 Offset: 0x3335B21 VA: 0x3335A20
	public static bool HasIdentityPrimitiveOrNullableConversionTo(Type source, Type dest) { }

	[ExtensionAttribute] // RVA: 0x423E0 Offset: 0x424E1 VA: 0x423E0
	// RVA: 0x3335F20 Offset: 0x3336021 VA: 0x3335F20
	public static bool HasReferenceConversionTo(Type source, Type dest) { }

	// RVA: 0x3336520 Offset: 0x3336621 VA: 0x3336520
	private static bool IsCovariant(Type t) { }

	// RVA: 0x3336550 Offset: 0x3336651 VA: 0x3336550
	private static bool IsContravariant(Type t) { }

	// RVA: 0x3336580 Offset: 0x3336681 VA: 0x3336580
	private static bool IsInvariant(Type t) { }

	// RVA: 0x33365B0 Offset: 0x33366B1 VA: 0x33365B0
	private static bool IsDelegate(Type t) { }

	// RVA: 0x3336180 Offset: 0x3336281 VA: 0x3336180
	public static bool IsLegalExplicitVariantDelegateConversion(Type source, Type dest) { }

	[ExtensionAttribute] // RVA: 0x423F0 Offset: 0x424F1 VA: 0x423F0
	// RVA: 0x3335E00 Offset: 0x3335F01 VA: 0x3335E00
	public static bool IsConvertible(Type type) { }

	// RVA: 0x3336650 Offset: 0x3336751 VA: 0x3336650
	public static bool HasReferenceEquality(Type left, Type right) { }

	// RVA: 0x3336700 Offset: 0x3336801 VA: 0x3336700
	public static bool HasBuiltInEqualityOperator(Type left, Type right) { }

	[ExtensionAttribute] // RVA: 0x42400 Offset: 0x42501 VA: 0x42400
	// RVA: 0x3336910 Offset: 0x3336A11 VA: 0x3336910
	public static bool IsImplicitlyConvertibleTo(Type source, Type destination) { }

	// RVA: 0x3336E50 Offset: 0x3336F51 VA: 0x3336E50
	public static MethodInfo GetUserDefinedCoercionMethod(Type convertFrom, Type convertToType) { }

	// RVA: 0x33370C0 Offset: 0x33371C1 VA: 0x33370C0
	private static MethodInfo FindConversionOperator(MethodInfo[] methods, Type typeFrom, Type typeTo) { }

	// RVA: 0x3336A00 Offset: 0x3336B01 VA: 0x3336A00
	private static bool IsImplicitNumericConversion(Type source, Type destination) { }

	// RVA: 0x3336BF0 Offset: 0x3336CF1 VA: 0x3336BF0
	private static bool IsImplicitReferenceConversion(Type source, Type destination) { }

	// RVA: 0x3336C10 Offset: 0x3336D11 VA: 0x3336C10
	private static bool IsImplicitBoxingConversion(Type source, Type destination) { }

	// RVA: 0x3336DA0 Offset: 0x3336EA1 VA: 0x3336DA0
	private static bool IsImplicitNullableConversion(Type source, Type destination) { }

	// RVA: 0x3337310 Offset: 0x3337411 VA: 0x3337310
	public static Type FindGenericType(Type definition, Type type) { }

	// RVA: 0x33377D0 Offset: 0x33378D1 VA: 0x33377D0
	public static MethodInfo GetBooleanOperator(Type type, string name) { }

	[ExtensionAttribute] // RVA: 0x42410 Offset: 0x42511 VA: 0x42410
	// RVA: 0x33379E0 Offset: 0x3337AE1 VA: 0x33379E0
	public static Type GetNonRefType(Type type) { }

	// RVA: 0x3335D50 Offset: 0x3335E51 VA: 0x3335D50
	public static bool AreEquivalent(Type t1, Type t2) { }

	// RVA: 0x3334860 Offset: 0x3334961 VA: 0x3334860
	public static bool AreReferenceAssignable(Type dest, Type src) { }

	// RVA: 0x3337A30 Offset: 0x3337B31 VA: 0x3337A30
	public static bool IsSameOrSubclass(Type type, Type subType) { }

	// RVA: 0x3337AF0 Offset: 0x3337BF1 VA: 0x3337AF0
	public static void ValidateType(Type type, string paramName) { }

	// RVA: 0x3337B00 Offset: 0x3337C01 VA: 0x3337B00
	public static void ValidateType(Type type, string paramName, bool allowByRef, bool allowPointer) { }

	// RVA: 0x3337BA0 Offset: 0x3337CA1 VA: 0x3337BA0
	public static bool ValidateType(Type type, string paramName, int index) { }

	// RVA: 0x3337CD0 Offset: 0x3337DD1 VA: 0x3337CD0
	private static Assembly get_MsCorLib() { }

	[ExtensionAttribute] // RVA: 0x42420 Offset: 0x42521 VA: 0x42420
	// RVA: 0x3334960 Offset: 0x3334A61 VA: 0x3334960
	public static bool CanCache(Type t) { }

	[ExtensionAttribute] // RVA: 0x42430 Offset: 0x42531 VA: 0x42430
	// RVA: 0x33234E0 Offset: 0x33235E1 VA: 0x33234E0
	public static MethodInfo GetInvokeMethod(Type delegateType) { }
}

