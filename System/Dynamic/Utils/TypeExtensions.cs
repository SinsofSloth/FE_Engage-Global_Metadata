// Namespace: System.Dynamic.Utils
[ExtensionAttribute] // RVA: 0x406C0 Offset: 0x407C1 VA: 0x406C0
internal static class TypeExtensions // TypeDefIndex: 3279
{
	// Fields
	private static readonly CacheDict<MethodBase, ParameterInfo[]> s_paramInfoCache; // 0x0

	// Methods

	[ExtensionAttribute] // RVA: 0x422E0 Offset: 0x423E1 VA: 0x422E0
	// RVA: 0x33346A0 Offset: 0x33347A1 VA: 0x33346A0
	public static MethodInfo GetAnyStaticMethodValidated(Type type, string name, Type[] types) { }

	[ExtensionAttribute] // RVA: 0x422F0 Offset: 0x423F1 VA: 0x422F0
	// RVA: 0x3334750 Offset: 0x3334851 VA: 0x3334750
	private static bool MatchesArgumentTypes(MethodInfo mi, Type[] argTypes) { }

	[ExtensionAttribute] // RVA: 0x42300 Offset: 0x42401 VA: 0x42300
	// RVA: 0x33285A0 Offset: 0x33286A1 VA: 0x33285A0
	public static TypeCode GetTypeCode(Type type) { }

	[ExtensionAttribute] // RVA: 0x42310 Offset: 0x42411 VA: 0x42310
	// RVA: 0x3323540 Offset: 0x3323641 VA: 0x3323540
	internal static ParameterInfo[] GetParametersCached(MethodBase method) { }

	// RVA: 0x3334A40 Offset: 0x3334B41 VA: 0x3334A40
	private static void .cctor() { }
}

