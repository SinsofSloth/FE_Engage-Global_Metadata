// Namespace: MoonSharp.Interpreter.Interop.UserDataRegistries
internal class ExtensionMethodsRegistry // TypeDefIndex: 6133
{
	// Fields
	private static object s_Lock; // 0x0
	private static MultiDictionary<string, IOverloadableMemberDescriptor> s_Registry; // 0x8
	private static MultiDictionary<string, ExtensionMethodsRegistry.UnresolvedGenericMethod> s_UnresolvedGenericsRegistry; // 0x10
	private static int s_ExtensionMethodChangeVersion; // 0x18

	// Methods

	// RVA: 0x330D470 Offset: 0x330D571 VA: 0x330D470
	public static void RegisterExtensionType(Type type, InteropAccessMode mode = 7) { }

	// RVA: 0x330DC20 Offset: 0x330DD21 VA: 0x330DC20
	private static object FrameworkGetMethods() { }

	// RVA: 0x330DC60 Offset: 0x330DD61 VA: 0x330DC60
	public static IEnumerable<IOverloadableMemberDescriptor> GetExtensionMethodsByName(string name) { }

	// RVA: 0x330DE10 Offset: 0x330DF11 VA: 0x330DE10
	public static int GetExtensionMethodsChangeVersion() { }

	// RVA: 0x330DE80 Offset: 0x330DF81 VA: 0x330DE80
	public static List<IOverloadableMemberDescriptor> GetExtensionMethodsByNameAndType(string name, Type extendedType) { }

	// RVA: 0x330E880 Offset: 0x330E981 VA: 0x330E880
	private static MethodInfo InstantiateMethodInfo(MethodInfo mi, Type extensionType, Type genericType, Type extendedType) { }

	// RVA: 0x330E470 Offset: 0x330E571 VA: 0x330E470
	private static Type GetGenericMatch(Type extensionType, Type extendedType) { }

	// RVA: 0x330E9C0 Offset: 0x330EAC1 VA: 0x330E9C0
	public void .ctor() { }

	// RVA: 0x330E9D0 Offset: 0x330EAD1 VA: 0x330E9D0
	private static void .cctor() { }
}

