// Namespace: MoonSharp.Interpreter.Interop
[ExtensionAttribute] // RVA: 0xD7D0 Offset: 0xD8D1 VA: 0xD7D0
public static class DescriptorHelpers // TypeDefIndex: 6065
{
	// Methods

	[ExtensionAttribute] // RVA: 0x103F0 Offset: 0x104F1 VA: 0x103F0
	// RVA: 0x30FEE20 Offset: 0x30FEF21 VA: 0x30FEE20
	public static Nullable<bool> GetVisibilityFromAttributes(MemberInfo mi) { }

	[ExtensionAttribute] // RVA: 0x10400 Offset: 0x10501 VA: 0x10400
	// RVA: 0x30FEFE0 Offset: 0x30FF0E1 VA: 0x30FEFE0
	public static bool IsDelegateType(Type t) { }

	[ExtensionAttribute] // RVA: 0x10410 Offset: 0x10511 VA: 0x10410
	// RVA: 0x30FF110 Offset: 0x30FF211 VA: 0x30FF110
	public static string GetClrVisibility(Type type) { }

	[ExtensionAttribute] // RVA: 0x10420 Offset: 0x10521 VA: 0x10420
	// RVA: 0x30FF290 Offset: 0x30FF391 VA: 0x30FF290
	public static string GetClrVisibility(FieldInfo info) { }

	[ExtensionAttribute] // RVA: 0x10430 Offset: 0x10531 VA: 0x10430
	// RVA: 0x30FF3E0 Offset: 0x30FF4E1 VA: 0x30FF3E0
	public static string GetClrVisibility(PropertyInfo info) { }

	[ExtensionAttribute] // RVA: 0x10440 Offset: 0x10541 VA: 0x10440
	// RVA: 0x30FF620 Offset: 0x30FF721 VA: 0x30FF620
	public static string GetClrVisibility(MethodBase info) { }

	[ExtensionAttribute] // RVA: 0x10450 Offset: 0x10551 VA: 0x10450
	// RVA: 0x30FF770 Offset: 0x30FF871 VA: 0x30FF770
	public static bool IsPropertyInfoPublic(PropertyInfo pi) { }

	[ExtensionAttribute] // RVA: 0x10460 Offset: 0x10561 VA: 0x10460
	// RVA: 0x30FF930 Offset: 0x30FFA31 VA: 0x30FF930
	public static List<string> GetMetaNamesFromAttributes(MethodInfo mi) { }

	[ExtensionAttribute] // RVA: 0x10470 Offset: 0x10571 VA: 0x10470
	// RVA: 0x30FFB00 Offset: 0x30FFC01 VA: 0x30FFB00
	public static Type[] SafeGetTypes(Assembly asm) { }

	[ExtensionAttribute] // RVA: 0x10480 Offset: 0x10581 VA: 0x10480
	// RVA: 0x30FFC70 Offset: 0x30FFD71 VA: 0x30FFC70
	public static string GetConversionMethodName(Type type) { }

	[ExtensionAttribute] // RVA: 0x10490 Offset: 0x10591 VA: 0x10490
	[IteratorStateMachineAttribute] // RVA: 0x10490 Offset: 0x10591 VA: 0x10490
	// RVA: 0x30FFDE0 Offset: 0x30FFEE1 VA: 0x30FFDE0
	public static IEnumerable<Type> GetAllImplementedTypes(Type t) { }

	// RVA: 0x30FFE60 Offset: 0x30FFF61 VA: 0x30FFE60
	public static bool IsValidSimpleIdentifier(string str) { }

	// RVA: 0x30FFFD0 Offset: 0x31000D1 VA: 0x30FFFD0
	public static string ToValidSimpleIdentifier(string str) { }

	// RVA: 0x31001D0 Offset: 0x31002D1 VA: 0x31001D0
	public static string Camelify(string name) { }

	// RVA: 0x3100320 Offset: 0x3100421 VA: 0x3100320
	public static string UpperFirstLetter(string name) { }
}

