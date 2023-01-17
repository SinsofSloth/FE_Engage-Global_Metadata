// Namespace: System.Reflection.Emit
public abstract class EnumBuilder : TypeInfo // TypeDefIndex: 600
{
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

	// RVA: 0x3B5D780 Offset: 0x3B5D881 VA: 0x3B5D780 Slot: 25
	public override Assembly get_Assembly() { }

	// RVA: 0x3B5D7C0 Offset: 0x3B5D8C1 VA: 0x3B5D7C0 Slot: 29
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x3B5D800 Offset: 0x3B5D901 VA: 0x3B5D800 Slot: 31
	public override Type get_BaseType() { }

	// RVA: 0x3B5D840 Offset: 0x3B5D941 VA: 0x3B5D840 Slot: 27
	public override string get_FullName() { }

	// RVA: 0x3B5D880 Offset: 0x3B5D981 VA: 0x3B5D880 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x3B5D8C0 Offset: 0x3B5D9C1 VA: 0x3B5D8C0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x3B5D900 Offset: 0x3B5DA01 VA: 0x3B5D900 Slot: 7
	public override string get_Name() { }

	// RVA: 0x3B5D940 Offset: 0x3B5DA41 VA: 0x3B5D940 Slot: 28
	public override string get_Namespace() { }

	// RVA: 0x3B5D980 Offset: 0x3B5DA81 VA: 0x3B5D980 Slot: 107
	public override Type GetElementType() { }

	// RVA: 0x3B5D9C0 Offset: 0x3B5DAC1 VA: 0x3B5D9C0 Slot: 116
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x3B5DA00 Offset: 0x3B5DB01 VA: 0x3B5DA00 Slot: 98
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x3B5DA40 Offset: 0x3B5DB41 VA: 0x3B5DA40 Slot: 35
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x47C0C0 Offset: 0x47C1C1 VA: 0x47C0C0
	// RVA: 0x3B5DA80 Offset: 0x3B5DB81 VA: 0x3B5DA80 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x3B5DAC0 Offset: 0x3B5DBC1 VA: 0x3B5DAC0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x3B5DB00 Offset: 0x3B5DC01 VA: 0x3B5DB00 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x3B5DB40 Offset: 0x3B5DC41 VA: 0x3B5DB40 Slot: 49
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x3B5DB80 Offset: 0x3B5DC81 VA: 0x3B5DB80 Slot: 50
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x3B5DBC0 Offset: 0x3B5DCC1 VA: 0x3B5DBC0 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x3B5DC00 Offset: 0x3B5DD01 VA: 0x3B5DC00 Slot: 45
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x3B5DC40 Offset: 0x3B5DD41 VA: 0x3B5DC40 Slot: 47
	public override Type GetInterface(string name, bool ignoreCase) { }

	// RVA: 0x3B5DC80 Offset: 0x3B5DD81 VA: 0x3B5DC80 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x3B5DCC0 Offset: 0x3B5DDC1 VA: 0x3B5DCC0 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x3B5DD00 Offset: 0x3B5DE01 VA: 0x3B5DD00 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x3B5DD40 Offset: 0x3B5DE41 VA: 0x3B5DD40 Slot: 59
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x3B5DD80 Offset: 0x3B5DE81 VA: 0x3B5DD80 Slot: 58
	public override Type[] GetNestedTypes(BindingFlags bindingAttr) { }

	// RVA: 0x3B5DDC0 Offset: 0x3B5DEC1 VA: 0x3B5DDC0 Slot: 56
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x3B5DE00 Offset: 0x3B5DF01 VA: 0x3B5DE00 Slot: 55
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x3B5DE40 Offset: 0x3B5DF41 VA: 0x3B5DE40 Slot: 110
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x3B5DE80 Offset: 0x3B5DF81 VA: 0x3B5DE80 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x3B5DEC0 Offset: 0x3B5DFC1 VA: 0x3B5DEC0 Slot: 99
	protected override bool IsArrayImpl() { }

	// RVA: 0x3B5DF00 Offset: 0x3B5E001 VA: 0x3B5DF00 Slot: 100
	protected override bool IsByRefImpl() { }

	// RVA: 0x3B5DF40 Offset: 0x3B5E041 VA: 0x3B5DF40 Slot: 103
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x3B5DF80 Offset: 0x3B5E081 VA: 0x3B5DF80 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x3B5DFC0 Offset: 0x3B5E0C1 VA: 0x3B5DFC0 Slot: 101
	protected override bool IsPointerImpl() { }

	// RVA: 0x3B5E000 Offset: 0x3B5E101 VA: 0x3B5E000 Slot: 102
	protected override bool IsPrimitiveImpl() { }
}

