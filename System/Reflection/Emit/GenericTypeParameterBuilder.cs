// Namespace: System.Reflection.Emit
public abstract class GenericTypeParameterBuilder : TypeInfo // TypeDefIndex: 603
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

	// RVA: 0x38B7260 Offset: 0x38B7361 VA: 0x38B7260 Slot: 25
	public override Assembly get_Assembly() { }

	// RVA: 0x38B72A0 Offset: 0x38B73A1 VA: 0x38B72A0 Slot: 29
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x38B72E0 Offset: 0x38B73E1 VA: 0x38B72E0 Slot: 31
	public override Type get_BaseType() { }

	// RVA: 0x38B7320 Offset: 0x38B7421 VA: 0x38B7320 Slot: 27
	public override string get_FullName() { }

	// RVA: 0x38B7360 Offset: 0x38B7461 VA: 0x38B7360 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x38B73A0 Offset: 0x38B74A1 VA: 0x38B73A0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x38B73E0 Offset: 0x38B74E1 VA: 0x38B73E0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x38B7420 Offset: 0x38B7521 VA: 0x38B7420 Slot: 28
	public override string get_Namespace() { }

	// RVA: 0x38B7460 Offset: 0x38B7561 VA: 0x38B7460 Slot: 107
	public override Type GetElementType() { }

	// RVA: 0x38B74A0 Offset: 0x38B75A1 VA: 0x38B74A0 Slot: 116
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x38B74E0 Offset: 0x38B75E1 VA: 0x38B74E0 Slot: 98
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x38B7520 Offset: 0x38B7621 VA: 0x38B7520 Slot: 35
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x47C0E0 Offset: 0x47C1E1 VA: 0x47C0E0
	// RVA: 0x38B7560 Offset: 0x38B7661 VA: 0x38B7560 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x38B75A0 Offset: 0x38B76A1 VA: 0x38B75A0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x38B75E0 Offset: 0x38B76E1 VA: 0x38B75E0 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x38B7620 Offset: 0x38B7721 VA: 0x38B7620 Slot: 49
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x38B7660 Offset: 0x38B7761 VA: 0x38B7660 Slot: 50
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x38B76A0 Offset: 0x38B77A1 VA: 0x38B76A0 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x38B76E0 Offset: 0x38B77E1 VA: 0x38B76E0 Slot: 45
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x38B7720 Offset: 0x38B7821 VA: 0x38B7720 Slot: 47
	public override Type GetInterface(string name, bool ignoreCase) { }

	// RVA: 0x38B7760 Offset: 0x38B7861 VA: 0x38B7760 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x38B77A0 Offset: 0x38B78A1 VA: 0x38B77A0 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x38B77E0 Offset: 0x38B78E1 VA: 0x38B77E0 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x38B7820 Offset: 0x38B7921 VA: 0x38B7820 Slot: 59
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x38B7860 Offset: 0x38B7961 VA: 0x38B7860 Slot: 58
	public override Type[] GetNestedTypes(BindingFlags bindingAttr) { }

	// RVA: 0x38B78A0 Offset: 0x38B79A1 VA: 0x38B78A0 Slot: 56
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x38B78E0 Offset: 0x38B79E1 VA: 0x38B78E0 Slot: 55
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x38B7920 Offset: 0x38B7A21 VA: 0x38B7920 Slot: 110
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x38B7960 Offset: 0x38B7A61 VA: 0x38B7960 Slot: 23
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x38B79A0 Offset: 0x38B7AA1 VA: 0x38B79A0 Slot: 99
	protected override bool IsArrayImpl() { }

	// RVA: 0x38B79E0 Offset: 0x38B7AE1 VA: 0x38B79E0 Slot: 100
	protected override bool IsByRefImpl() { }

	// RVA: 0x38B7A20 Offset: 0x38B7B21 VA: 0x38B7A20 Slot: 103
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x38B7A60 Offset: 0x38B7B61 VA: 0x38B7A60 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x38B7AA0 Offset: 0x38B7BA1 VA: 0x38B7AA0 Slot: 101
	protected override bool IsPointerImpl() { }

	// RVA: 0x38B7AE0 Offset: 0x38B7BE1 VA: 0x38B7AE0 Slot: 102
	protected override bool IsPrimitiveImpl() { }
}

