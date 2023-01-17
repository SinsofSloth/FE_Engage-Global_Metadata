// Namespace: MoonSharp.Interpreter.Interop.UserDataRegistries
internal static class TypeDescriptorRegistry // TypeDefIndex: 6136
{
	// Fields
	private static object s_Lock; // 0x0
	private static Dictionary<Type, IUserDataDescriptor> s_TypeRegistry; // 0x8
	private static Dictionary<Type, IUserDataDescriptor> s_TypeRegistryHistory; // 0x10
	private static InteropAccessMode s_DefaultAccessMode; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE960 Offset: 0xEA61 VA: 0xE960
	private static IRegistrationPolicy <RegistrationPolicy>k__BackingField; // 0x20

	// Properties
	internal static InteropAccessMode DefaultAccessMode { get; set; }
	public static IEnumerable<KeyValuePair<Type, IUserDataDescriptor>> RegisteredTypes { get; }
	public static IEnumerable<KeyValuePair<Type, IUserDataDescriptor>> RegisteredTypesHistory { get; }
	internal static IRegistrationPolicy RegistrationPolicy { get; set; }

	// Methods

	// RVA: 0x334DD80 Offset: 0x334DE81 VA: 0x334DD80
	internal static void RegisterAssembly(Assembly asm, bool includeExtensionTypes = False) { }

	// RVA: 0x334EA00 Offset: 0x334EB01 VA: 0x334EA00
	internal static bool IsTypeRegistered(Type type) { }

	// RVA: 0x334EB70 Offset: 0x334EC71 VA: 0x334EB70
	internal static void UnregisterType(Type t) { }

	// RVA: 0x334EF30 Offset: 0x334F031 VA: 0x334EF30
	internal static InteropAccessMode get_DefaultAccessMode() { }

	// RVA: 0x334EFA0 Offset: 0x334F0A1 VA: 0x334EFA0
	internal static void set_DefaultAccessMode(InteropAccessMode value) { }

	// RVA: 0x334F060 Offset: 0x334F161 VA: 0x334F060
	internal static IUserDataDescriptor RegisterProxyType_Impl(IProxyFactory proxyFactory, InteropAccessMode accessMode, string friendlyName) { }

	// RVA: 0x334F210 Offset: 0x334F311 VA: 0x334F210
	internal static IUserDataDescriptor RegisterType_Impl(Type type, InteropAccessMode accessMode, string friendlyName, IUserDataDescriptor descriptor) { }

	// RVA: 0x334ED30 Offset: 0x334EE31 VA: 0x334ED30
	private static IUserDataDescriptor PerformRegistration(Type type, IUserDataDescriptor newDescriptor, IUserDataDescriptor oldDescriptor) { }

	// RVA: 0x334F930 Offset: 0x334FA31 VA: 0x334F930
	internal static InteropAccessMode ResolveDefaultAccessModeForType(InteropAccessMode accessMode, Type type) { }

	// RVA: 0x334FCB0 Offset: 0x334FDB1 VA: 0x334FCB0
	internal static IUserDataDescriptor GetDescriptorForType(Type type, bool searchInterfaces) { }

	// RVA: 0x33508C0 Offset: 0x33509C1 VA: 0x33508C0
	private static bool FrameworkIsAssignableFrom(Type type) { }

	// RVA: 0x334FAA0 Offset: 0x334FBA1 VA: 0x334FAA0
	public static bool IsTypeBlacklisted(Type t) { }

	// RVA: 0x3350900 Offset: 0x3350A01 VA: 0x3350900
	public static IEnumerable<KeyValuePair<Type, IUserDataDescriptor>> get_RegisteredTypes() { }

	// RVA: 0x3350A60 Offset: 0x3350B61 VA: 0x3350A60
	public static IEnumerable<KeyValuePair<Type, IUserDataDescriptor>> get_RegisteredTypesHistory() { }

	[CompilerGeneratedAttribute] // RVA: 0x10B20 Offset: 0x10C21 VA: 0x10B20
	// RVA: 0x3350BC0 Offset: 0x3350CC1 VA: 0x3350BC0
	internal static IRegistrationPolicy get_RegistrationPolicy() { }

	[CompilerGeneratedAttribute] // RVA: 0x10B30 Offset: 0x10C31 VA: 0x10B30
	// RVA: 0x3350C30 Offset: 0x3350D31 VA: 0x3350C30
	internal static void set_RegistrationPolicy(IRegistrationPolicy value) { }

	// RVA: 0x3350CB0 Offset: 0x3350DB1 VA: 0x3350CB0
	private static void .cctor() { }
}

