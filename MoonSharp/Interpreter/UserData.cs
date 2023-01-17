// Namespace: MoonSharp.Interpreter
public class UserData : RefIdObject // TypeDefIndex: 5953
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE2D0 Offset: 0xE3D1 VA: 0xE2D0
	private DynValue <UserValue>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE2E0 Offset: 0xE3E1 VA: 0xE2E0
	private object <Object>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xE2F0 Offset: 0xE3F1 VA: 0xE2F0
	private IUserDataDescriptor <Descriptor>k__BackingField; // 0x28

	// Properties
	public DynValue UserValue { get; set; }
	public object Object { get; set; }
	public IUserDataDescriptor Descriptor { get; set; }
	public static IRegistrationPolicy RegistrationPolicy { get; set; }
	public static InteropAccessMode DefaultAccessMode { get; set; }

	// Methods

	// RVA: 0x33520F0 Offset: 0x33521F1 VA: 0x33520F0
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0xFA10 Offset: 0xFB11 VA: 0xFA10
	// RVA: 0x3352160 Offset: 0x3352261 VA: 0x3352160
	public DynValue get_UserValue() { }

	[CompilerGeneratedAttribute] // RVA: 0xFA20 Offset: 0xFB21 VA: 0xFA20
	// RVA: 0x3352170 Offset: 0x3352271 VA: 0x3352170
	public void set_UserValue(DynValue value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFA30 Offset: 0xFB31 VA: 0xFA30
	// RVA: 0x3352180 Offset: 0x3352281 VA: 0x3352180
	public object get_Object() { }

	[CompilerGeneratedAttribute] // RVA: 0xFA40 Offset: 0xFB41 VA: 0xFA40
	// RVA: 0x3352190 Offset: 0x3352291 VA: 0x3352190
	private void set_Object(object value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFA50 Offset: 0xFB51 VA: 0xFA50
	// RVA: 0x33521A0 Offset: 0x33522A1 VA: 0x33521A0
	public IUserDataDescriptor get_Descriptor() { }

	[CompilerGeneratedAttribute] // RVA: 0xFA60 Offset: 0xFB61 VA: 0xFA60
	// RVA: 0x33521B0 Offset: 0x33522B1 VA: 0x33521B0
	private void set_Descriptor(IUserDataDescriptor value) { }

	// RVA: 0x33521C0 Offset: 0x33522C1 VA: 0x33521C0
	private static void .cctor() { }

	// RVA: -1 Offset: -1
	public static IUserDataDescriptor RegisterType<T>(InteropAccessMode accessMode = 7, string friendlyName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2031D10 Offset: 0x2031E11 VA: 0x2031D10
	|-UserData.RegisterType<AnonWrapper>
	|-UserData.RegisterType<EnumerableWrapper>
	|-UserData.RegisterType<EventFacade>
	|-UserData.RegisterType<FileUserDataBase>
	|-UserData.RegisterType<JsonNull>
	|-UserData.RegisterType<object>
	|-UserData.RegisterType<DynamicModule.DynamicExprWrapper>
	|-UserData.RegisterType<ScriptMenu.EventMenu>
	|-UserData.RegisterType<ScriptMenu.EventMenuItem>
	*/

	// RVA: 0x334E970 Offset: 0x334EA71 VA: 0x334E970
	public static IUserDataDescriptor RegisterType(Type type, InteropAccessMode accessMode = 7, string friendlyName) { }

	// RVA: 0x3352470 Offset: 0x3352571 VA: 0x3352470
	public static IUserDataDescriptor RegisterProxyType(IProxyFactory proxyFactory, InteropAccessMode accessMode = 7, string friendlyName) { }

	// RVA: -1 Offset: -1
	public static IUserDataDescriptor RegisterProxyType<TProxy, TTarget>(Func<TTarget, TProxy> wrapDelegate, InteropAccessMode accessMode = 7, string friendlyName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2031B90 Offset: 0x2031C91 VA: 0x2031B90
	|-UserData.RegisterProxyType<object, object>
	*/

	// RVA: -1 Offset: -1
	public static IUserDataDescriptor RegisterType<T>(IUserDataDescriptor customDescriptor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2031C50 Offset: 0x2031D51 VA: 0x2031C50
	|-UserData.RegisterType<object>
	*/

	// RVA: 0x33524F0 Offset: 0x33525F1 VA: 0x33524F0
	public static IUserDataDescriptor RegisterType(Type type, IUserDataDescriptor customDescriptor) { }

	// RVA: 0x3352570 Offset: 0x3352671 VA: 0x3352570
	public static IUserDataDescriptor RegisterType(IUserDataDescriptor customDescriptor) { }

	// RVA: 0x3352660 Offset: 0x3352761 VA: 0x3352660
	public static void RegisterAssembly(Assembly asm, bool includeExtensionTypes = False) { }

	// RVA: 0x33526F0 Offset: 0x33527F1 VA: 0x33526F0
	public static bool IsTypeRegistered(Type t) { }

	// RVA: -1 Offset: -1
	public static bool IsTypeRegistered<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2031AE0 Offset: 0x2031BE1 VA: 0x2031AE0
	|-UserData.IsTypeRegistered<object>
	*/

	// RVA: -1 Offset: -1
	public static void UnregisterType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2031DE0 Offset: 0x2031EE1 VA: 0x2031DE0
	|-UserData.UnregisterType<object>
	*/

	// RVA: 0x3352760 Offset: 0x3352861 VA: 0x3352760
	public static void UnregisterType(Type t) { }

	// RVA: 0x33527D0 Offset: 0x33528D1 VA: 0x33527D0
	public static DynValue Create(object o, IUserDataDescriptor descr) { }

	// RVA: 0x33528E0 Offset: 0x33529E1 VA: 0x33528E0
	public static DynValue Create(object o) { }

	// RVA: 0x3352BC0 Offset: 0x3352CC1 VA: 0x3352BC0
	public static DynValue CreateStatic(IUserDataDescriptor descr) { }

	// RVA: 0x3352B10 Offset: 0x3352C11 VA: 0x3352B10
	public static DynValue CreateStatic(Type t) { }

	// RVA: -1 Offset: -1
	public static DynValue CreateStatic<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2031960 Offset: 0x2031A61 VA: 0x2031960
	|-UserData.CreateStatic<JsonNull>
	|-UserData.CreateStatic<object>
	*/

	// RVA: 0x3352D40 Offset: 0x3352E41 VA: 0x3352D40
	public static IRegistrationPolicy get_RegistrationPolicy() { }

	// RVA: 0x3352330 Offset: 0x3352431 VA: 0x3352330
	public static void set_RegistrationPolicy(IRegistrationPolicy value) { }

	// RVA: 0x3352E00 Offset: 0x3352F01 VA: 0x3352E00
	public static InteropAccessMode get_DefaultAccessMode() { }

	// RVA: 0x3352400 Offset: 0x3352501 VA: 0x3352400
	public static void set_DefaultAccessMode(InteropAccessMode value) { }

	// RVA: 0x334E8F0 Offset: 0x334E9F1 VA: 0x334E8F0
	public static void RegisterExtensionType(Type type, InteropAccessMode mode = 7) { }

	// RVA: 0x3352EC0 Offset: 0x3352FC1 VA: 0x3352EC0
	public static List<IOverloadableMemberDescriptor> GetExtensionMethodsByNameAndType(string name, Type extendedType) { }

	// RVA: 0x3352F40 Offset: 0x3353041 VA: 0x3352F40
	public static int GetExtensionMethodsChangeVersion() { }

	// RVA: -1 Offset: -1
	public static IUserDataDescriptor GetDescriptorForType<T>(bool searchInterfaces) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2031A20 Offset: 0x2031B21 VA: 0x2031A20
	|-UserData.GetDescriptorForType<object>
	*/

	// RVA: 0x3352CD0 Offset: 0x3352DD1 VA: 0x3352CD0
	public static IUserDataDescriptor GetDescriptorForType(Type type, bool searchInterfaces) { }

	// RVA: 0x3352A90 Offset: 0x3352B91 VA: 0x3352A90
	public static IUserDataDescriptor GetDescriptorForObject(object o) { }

	// RVA: 0x3353000 Offset: 0x3353101 VA: 0x3353000
	public static Table GetDescriptionOfRegisteredTypes(bool useHistoricalData = False) { }

	// RVA: 0x3353450 Offset: 0x3353551 VA: 0x3353450
	public static IEnumerable<Type> GetRegisteredTypes(bool useHistoricalData = False) { }
}

