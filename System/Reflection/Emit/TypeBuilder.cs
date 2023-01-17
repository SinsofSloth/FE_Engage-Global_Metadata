// Namespace: System.Reflection.Emit
public abstract class TypeBuilder : TypeInfo // TypeDefIndex: 611
{
	// Fields
	public const int UnspecifiedTypeSize = 0;

	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Guid GUID { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x36416D0 Offset: 0x36417D1 VA: 0x36416D0 Slot: 25
	public override Assembly get_Assembly() { }

	// RVA: 0x3641710 Offset: 0x3641811 VA: 0x3641710 Slot: 29
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x3641750 Offset: 0x3641851 VA: 0x3641750 Slot: 31
	public override Type get_BaseType() { }

	// RVA: 0x3641790 Offset: 0x3641891 VA: 0x3641790 Slot: 27
	public override string get_FullName() { }

	// RVA: 0x36417D0 Offset: 0x36418D1 VA: 0x36417D0 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x3641810 Offset: 0x3641911 VA: 0x3641810 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x3641850 Offset: 0x3641951 VA: 0x3641850 Slot: 7
	public override string get_Name() { }

	// RVA: 0x3641890 Offset: 0x3641991 VA: 0x3641890 Slot: 28
	public override string get_Namespace() { }

	// RVA: 0x36418D0 Offset: 0x36419D1 VA: 0x36418D0 Slot: 107
	public override Type GetElementType() { }

	// RVA: 0x3641910 Offset: 0x3641A11 VA: 0x3641910 Slot: 116
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x3641950 Offset: 0x3641A51 VA: 0x3641950 Slot: 98
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x3641990 Offset: 0x3641A91 VA: 0x3641990 Slot: 35
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x47C100 Offset: 0x47C201 VA: 0x47C100
	// RVA: 0x36419D0 Offset: 0x3641AD1 VA: 0x36419D0 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x3641A10 Offset: 0x3641B11 VA: 0x3641A10 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x3641A50 Offset: 0x3641B51 VA: 0x3641A50 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x3641A90 Offset: 0x3641B91 VA: 0x3641A90 Slot: 49
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x3641AD0 Offset: 0x3641BD1 VA: 0x3641AD0 Slot: 50
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x3641B10 Offset: 0x3641C11 VA: 0x3641B10 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x3641B50 Offset: 0x3641C51 VA: 0x3641B50 Slot: 45
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x3641B90 Offset: 0x3641C91 VA: 0x3641B90 Slot: 47
	public override Type GetInterface(string name, bool ignoreCase) { }

	// RVA: 0x3641BD0 Offset: 0x3641CD1 VA: 0x3641BD0 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x3641C10 Offset: 0x3641D11 VA: 0x3641C10 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x3641C50 Offset: 0x3641D51 VA: 0x3641C50 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x3641C90 Offset: 0x3641D91 VA: 0x3641C90 Slot: 59
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x3641CD0 Offset: 0x3641DD1 VA: 0x3641CD0 Slot: 58
	public override Type[] GetNestedTypes(BindingFlags bindingAttr) { }

	// RVA: 0x3641D10 Offset: 0x3641E11 VA: 0x3641D10 Slot: 56
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x3641D50 Offset: 0x3641E51 VA: 0x3641D50 Slot: 55
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x3641D90 Offset: 0x3641E91 VA: 0x3641D90 Slot: 110
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x3641DD0 Offset: 0x3641ED1 VA: 0x3641DD0 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x3641E10 Offset: 0x3641F11 VA: 0x3641E10 Slot: 99
	protected override bool IsArrayImpl() { }

	// RVA: 0x3641E50 Offset: 0x3641F51 VA: 0x3641E50 Slot: 100
	protected override bool IsByRefImpl() { }

	// RVA: 0x3641E90 Offset: 0x3641F91 VA: 0x3641E90 Slot: 103
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x3641ED0 Offset: 0x3641FD1 VA: 0x3641ED0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x3641F10 Offset: 0x3642011 VA: 0x3641F10 Slot: 101
	protected override bool IsPointerImpl() { }

	// RVA: 0x3641F50 Offset: 0x3642051 VA: 0x3641F50 Slot: 102
	protected override bool IsPrimitiveImpl() { }
}

