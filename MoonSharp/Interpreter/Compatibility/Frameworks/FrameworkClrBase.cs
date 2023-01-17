// Namespace: MoonSharp.Interpreter.Compatibility.Frameworks
internal abstract class FrameworkClrBase : FrameworkReflectionBase // TypeDefIndex: 6262
{
	// Fields
	private BindingFlags BINDINGFLAGS_MEMBER; // 0x10
	private BindingFlags BINDINGFLAGS_INNERCLASS; // 0x14

	// Methods

	// RVA: 0x3312430 Offset: 0x3312531 VA: 0x3312430 Slot: 36
	public override Type GetTypeInfoFromType(Type t) { }

	// RVA: 0x3312440 Offset: 0x3312541 VA: 0x3312440 Slot: 18
	public override MethodInfo GetAddMethod(EventInfo ei) { }

	// RVA: 0x3312460 Offset: 0x3312561 VA: 0x3312460 Slot: 27
	public override ConstructorInfo[] GetConstructors(Type type) { }

	// RVA: 0x3312480 Offset: 0x3312581 VA: 0x3312480 Slot: 26
	public override EventInfo[] GetEvents(Type type) { }

	// RVA: 0x33124A0 Offset: 0x33125A1 VA: 0x33124A0 Slot: 30
	public override FieldInfo[] GetFields(Type type) { }

	// RVA: 0x33124C0 Offset: 0x33125C1 VA: 0x33124C0 Slot: 32
	public override Type[] GetGenericArguments(Type type) { }

	// RVA: 0x33124E0 Offset: 0x33125E1 VA: 0x33124E0 Slot: 20
	public override MethodInfo GetGetMethod(PropertyInfo pi) { }

	// RVA: 0x3312500 Offset: 0x3312601 VA: 0x3312500 Slot: 16
	public override Type[] GetInterfaces(Type t) { }

	// RVA: 0x3312520 Offset: 0x3312621 VA: 0x3312520 Slot: 31
	public override MethodInfo GetMethod(Type type, string name) { }

	// RVA: 0x3312530 Offset: 0x3312631 VA: 0x3312530 Slot: 29
	public override MethodInfo[] GetMethods(Type type) { }

	// RVA: 0x3312550 Offset: 0x3312651 VA: 0x3312550 Slot: 25
	public override Type[] GetNestedTypes(Type type) { }

	// RVA: 0x3312570 Offset: 0x3312671 VA: 0x3312570 Slot: 23
	public override PropertyInfo[] GetProperties(Type type) { }

	// RVA: 0x3312590 Offset: 0x3312691 VA: 0x3312590 Slot: 24
	public override PropertyInfo GetProperty(Type type, string name) { }

	// RVA: 0x33125A0 Offset: 0x33126A1 VA: 0x33125A0 Slot: 19
	public override MethodInfo GetRemoveMethod(EventInfo ei) { }

	// RVA: 0x33125C0 Offset: 0x33126C1 VA: 0x33125C0 Slot: 21
	public override MethodInfo GetSetMethod(PropertyInfo pi) { }

	// RVA: 0x33125E0 Offset: 0x33126E1 VA: 0x33125E0 Slot: 33
	public override bool IsAssignableFrom(Type current, Type toCompare) { }

	// RVA: 0x3312600 Offset: 0x3312701 VA: 0x3312600 Slot: 17
	public override bool IsInstanceOfType(Type t, object o) { }

	// RVA: 0x3312620 Offset: 0x3312721 VA: 0x3312620 Slot: 35
	public override MethodInfo GetMethod(Type resourcesType, string name, Type[] types) { }

	// RVA: 0x3312640 Offset: 0x3312741 VA: 0x3312640 Slot: 28
	public override Type[] GetAssemblyTypes(Assembly asm) { }

	// RVA: 0x3312660 Offset: 0x3312761 VA: 0x3312660
	protected void .ctor() { }
}

