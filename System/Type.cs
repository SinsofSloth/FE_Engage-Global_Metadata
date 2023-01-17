// Namespace: System
[ComDefaultInterfaceAttribute] // RVA: 0x470CB0 Offset: 0x470DB1 VA: 0x470CB0
[ComVisibleAttribute] // RVA: 0x470CB0 Offset: 0x470DB1 VA: 0x470CB0
[ClassInterfaceAttribute] // RVA: 0x470CB0 Offset: 0x470DB1 VA: 0x470CB0
[Serializable]
public abstract class Type : MemberInfo, _Type // TypeDefIndex: 325
{
	// Fields
	public static readonly MemberFilter FilterAttribute; // 0x0
	public static readonly MemberFilter FilterName; // 0x8
	public static readonly MemberFilter FilterNameIgnoreCase; // 0x10
	public static readonly object Missing; // 0x18
	public static readonly char Delimiter; // 0x20
	public static readonly Type[] EmptyTypes; // 0x28
	private static Binder defaultBinder; // 0x30
	private const BindingFlags DefaultLookup = 28;
	internal const BindingFlags DeclaredOnlyLookup = 62;
	internal RuntimeTypeHandle _impl; // 0x10

	// Properties
	public override MemberTypes MemberType { get; }
	public override Type DeclaringType { get; }
	public virtual MethodBase DeclaringMethod { get; }
	public override Type ReflectedType { get; }
	public abstract Guid GUID { get; }
	public static Binder DefaultBinder { get; }
	public abstract override Module Module { get; }
	public abstract Assembly Assembly { get; }
	public virtual RuntimeTypeHandle TypeHandle { get; }
	public abstract string FullName { get; }
	public abstract string Namespace { get; }
	public abstract string AssemblyQualifiedName { get; }
	public abstract Type BaseType { get; }
	public bool IsNested { get; }
	public TypeAttributes Attributes { get; }
	public virtual GenericParameterAttributes GenericParameterAttributes { get; }
	public bool IsNotPublic { get; }
	public bool IsPublic { get; }
	public bool IsNestedPublic { get; }
	public bool IsNestedPrivate { get; }
	public bool IsNestedFamily { get; }
	public bool IsNestedAssembly { get; }
	public bool IsNestedFamANDAssem { get; }
	public bool IsNestedFamORAssem { get; }
	public bool IsExplicitLayout { get; }
	public bool IsClass { get; }
	public bool IsInterface { get; }
	public bool IsValueType { get; }
	public bool IsAbstract { get; }
	public bool IsSealed { get; }
	public virtual bool IsEnum { get; }
	public virtual bool IsSerializable { get; }
	public bool IsArray { get; }
	internal virtual bool IsSzArray { get; }
	public virtual bool IsGenericType { get; }
	public virtual bool IsGenericTypeDefinition { get; }
	public virtual bool IsConstructedGenericType { get; }
	public virtual bool IsGenericParameter { get; }
	public virtual int GenericParameterPosition { get; }
	public virtual bool ContainsGenericParameters { get; }
	public bool IsByRef { get; }
	public bool IsPointer { get; }
	public bool IsPrimitive { get; }
	public bool IsCOMObject { get; }
	public bool HasElementType { get; }
	public bool IsContextful { get; }
	public bool IsMarshalByRef { get; }
	public abstract Type UnderlyingSystemType { get; }
	public virtual bool IsSZArray { get; }

	// Methods

	// RVA: 0x363D2C0 Offset: 0x363D3C1 VA: 0x363D2C0
	protected void .ctor() { }

	// RVA: 0x363D2D0 Offset: 0x363D3D1 VA: 0x363D2D0 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: 0x363D2E0 Offset: 0x363D3E1 VA: 0x363D2E0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x363D2F0 Offset: 0x363D3F1 VA: 0x363D2F0 Slot: 16
	public virtual MethodBase get_DeclaringMethod() { }

	// RVA: 0x363D300 Offset: 0x363D401 VA: 0x363D300 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x363D310 Offset: 0x363D411 VA: 0x363D310
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError) { }

	// RVA: 0x363D3A0 Offset: 0x363D4A1 VA: 0x363D3A0 Slot: 17
	public virtual Type MakePointerType() { }

	// RVA: 0x363D3E0 Offset: 0x363D4E1 VA: 0x363D3E0 Slot: 18
	public virtual Type MakeByRefType() { }

	// RVA: 0x363D420 Offset: 0x363D521 VA: 0x363D420 Slot: 19
	public virtual Type MakeArrayType() { }

	// RVA: 0x363D460 Offset: 0x363D561 VA: 0x363D460 Slot: 20
	public virtual Type MakeArrayType(int rank) { }

	// RVA: 0x363D4A0 Offset: 0x363D5A1 VA: 0x363D4A0
	public static Type GetTypeFromCLSID(Guid clsid) { }

	// RVA: 0x363D520 Offset: 0x363D621 VA: 0x363D520
	public static TypeCode GetTypeCode(Type type) { }

	// RVA: 0x363D5C0 Offset: 0x363D6C1 VA: 0x363D5C0 Slot: 21
	protected virtual TypeCode GetTypeCodeImpl() { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract Guid get_GUID();

	// RVA: 0x363D740 Offset: 0x363D841 VA: 0x363D740
	public static Binder get_DefaultBinder() { }

	// RVA: 0x363D800 Offset: 0x363D901 VA: 0x363D800
	private static void CreateBinder() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

	[DebuggerStepThroughAttribute] // RVA: 0x47AC40 Offset: 0x47AD41 VA: 0x47AC40
	[DebuggerHiddenAttribute] // RVA: 0x47AC40 Offset: 0x47AD41 VA: 0x47AC40
	// RVA: 0x363D8E0 Offset: 0x363D9E1 VA: 0x363D8E0 Slot: 24
	public object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract override Module get_Module();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract Assembly get_Assembly();

	// RVA: 0x363D920 Offset: 0x363DA21 VA: 0x363D920 Slot: 26
	public virtual RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x363D960 Offset: 0x363DA61 VA: 0x363D960
	public static RuntimeTypeHandle GetTypeHandle(object o) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_FullName();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract string get_Namespace();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract string get_AssemblyQualifiedName();

	// RVA: 0x363DA70 Offset: 0x363DB71 VA: 0x363DA70 Slot: 30
	public virtual int GetArrayRank() { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract Type get_BaseType();

	[ComVisibleAttribute] // RVA: 0x47AC80 Offset: 0x47AD81 VA: 0x47AC80
	// RVA: 0x363DAD0 Offset: 0x363DBD1 VA: 0x363DAD0 Slot: 32
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x47ACA0 Offset: 0x47ADA1 VA: 0x47ACA0
	// RVA: 0x363DC10 Offset: 0x363DD11 VA: 0x363DC10 Slot: 33
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisibleAttribute] // RVA: 0x47ACC0 Offset: 0x47ADC1 VA: 0x47ACC0
	// RVA: 0x363DD50 Offset: 0x363DE51 VA: 0x363DD50 Slot: 34
	public ConstructorInfo GetConstructor(Type[] types) { }

	// RVA: -1 Offset: -1 Slot: 35
	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	[ComVisibleAttribute] // RVA: 0x47ACE0 Offset: 0x47ADE1 VA: 0x47ACE0
	// RVA: -1 Offset: -1 Slot: 36
	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

	// RVA: 0x363DD70 Offset: 0x363DE71 VA: 0x363DD70 Slot: 37
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x363DEE0 Offset: 0x363DFE1 VA: 0x363DEE0 Slot: 38
	public MethodInfo GetMethod(string name, Type[] types) { }

	// RVA: 0x363E040 Offset: 0x363E141 VA: 0x363E040 Slot: 39
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr) { }

	// RVA: 0x363E0C0 Offset: 0x363E1C1 VA: 0x363E0C0 Slot: 40
	public MethodInfo GetMethod(string name) { }

	// RVA: -1 Offset: -1 Slot: 41
	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	// RVA: 0x363E150 Offset: 0x363E251 VA: 0x363E150 Slot: 42
	public MethodInfo[] GetMethods() { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 45
	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);

	// RVA: 0x363E170 Offset: 0x363E271 VA: 0x363E170 Slot: 46
	public Type GetInterface(string name) { }

	// RVA: -1 Offset: -1 Slot: 47
	public abstract Type GetInterface(string name, bool ignoreCase);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract Type[] GetInterfaces();

	// RVA: -1 Offset: -1 Slot: 49
	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 50
	public abstract EventInfo[] GetEvents(BindingFlags bindingAttr);

	// RVA: 0x363E190 Offset: 0x363E291 VA: 0x363E190 Slot: 51
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr) { }

	// RVA: 0x363E210 Offset: 0x363E311 VA: 0x363E210 Slot: 52
	public PropertyInfo GetProperty(string name, Type returnType, Type[] types) { }

	// RVA: 0x363E2C0 Offset: 0x363E3C1 VA: 0x363E2C0 Slot: 53
	public PropertyInfo GetProperty(string name, Type returnType) { }

	// RVA: 0x363E3D0 Offset: 0x363E4D1 VA: 0x363E3D0 Slot: 54
	public PropertyInfo GetProperty(string name) { }

	// RVA: -1 Offset: -1 Slot: 55
	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

	// RVA: -1 Offset: -1 Slot: 56
	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);

	// RVA: 0x363E460 Offset: 0x363E561 VA: 0x363E460 Slot: 57
	public PropertyInfo[] GetProperties() { }

	// RVA: -1 Offset: -1 Slot: 58
	public abstract Type[] GetNestedTypes(BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 59
	public abstract Type GetNestedType(string name, BindingFlags bindingAttr);

	// RVA: 0x363E480 Offset: 0x363E581 VA: 0x363E480 Slot: 60
	public MemberInfo[] GetMember(string name) { }

	// RVA: 0x363E4A0 Offset: 0x363E5A1 VA: 0x363E4A0 Slot: 61
	public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	// RVA: 0x363E4C0 Offset: 0x363E5C1 VA: 0x363E4C0 Slot: 62
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x363E520 Offset: 0x363E621 VA: 0x363E520
	public bool get_IsNested() { }

	// RVA: 0x363E5A0 Offset: 0x363E6A1 VA: 0x363E5A0 Slot: 63
	public TypeAttributes get_Attributes() { }

	// RVA: 0x363E5B0 Offset: 0x363E6B1 VA: 0x363E5B0 Slot: 64
	public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x363E5F0 Offset: 0x363E6F1 VA: 0x363E5F0 Slot: 65
	public bool get_IsNotPublic() { }

	// RVA: 0x363E620 Offset: 0x363E721 VA: 0x363E620 Slot: 66
	public bool get_IsPublic() { }

	// RVA: 0x363E650 Offset: 0x363E751 VA: 0x363E650 Slot: 67
	public bool get_IsNestedPublic() { }

	// RVA: 0x363E680 Offset: 0x363E781 VA: 0x363E680 Slot: 68
	public bool get_IsNestedPrivate() { }

	// RVA: 0x363E6B0 Offset: 0x363E7B1 VA: 0x363E6B0 Slot: 69
	public bool get_IsNestedFamily() { }

	// RVA: 0x363E6E0 Offset: 0x363E7E1 VA: 0x363E6E0 Slot: 70
	public bool get_IsNestedAssembly() { }

	// RVA: 0x363E710 Offset: 0x363E811 VA: 0x363E710 Slot: 71
	public bool get_IsNestedFamANDAssem() { }

	// RVA: 0x363E740 Offset: 0x363E841 VA: 0x363E740 Slot: 72
	public bool get_IsNestedFamORAssem() { }

	// RVA: 0x363E770 Offset: 0x363E871 VA: 0x363E770 Slot: 73
	public bool get_IsExplicitLayout() { }

	// RVA: 0x363E7A0 Offset: 0x363E8A1 VA: 0x363E7A0 Slot: 74
	public bool get_IsClass() { }

	// RVA: 0x363E810 Offset: 0x363E911 VA: 0x363E810 Slot: 75
	public bool get_IsInterface() { }

	// RVA: 0x363E800 Offset: 0x363E901 VA: 0x363E800 Slot: 76
	public bool get_IsValueType() { }

	// RVA: 0x363E900 Offset: 0x363EA01 VA: 0x363E900 Slot: 77
	public bool get_IsAbstract() { }

	// RVA: 0x363E930 Offset: 0x363EA31 VA: 0x363E930 Slot: 78
	public bool get_IsSealed() { }

	// RVA: 0x363E960 Offset: 0x363EA61 VA: 0x363E960 Slot: 79
	public virtual bool get_IsEnum() { }

	// RVA: 0x363E9E0 Offset: 0x363EAE1 VA: 0x363E9E0 Slot: 80
	public virtual bool get_IsSerializable() { }

	// RVA: 0x363EAF0 Offset: 0x363EBF1 VA: 0x363EAF0 Slot: 81
	public bool get_IsArray() { }

	// RVA: 0x363EB00 Offset: 0x363EC01 VA: 0x363EB00 Slot: 82
	internal virtual bool get_IsSzArray() { }

	// RVA: 0x363EB10 Offset: 0x363EC11 VA: 0x363EB10 Slot: 83
	public virtual bool get_IsGenericType() { }

	// RVA: 0x363EB20 Offset: 0x363EC21 VA: 0x363EB20 Slot: 84
	public virtual bool get_IsGenericTypeDefinition() { }

	// RVA: 0x363EB30 Offset: 0x363EC31 VA: 0x363EB30 Slot: 85
	public virtual bool get_IsConstructedGenericType() { }

	// RVA: 0x363EB70 Offset: 0x363EC71 VA: 0x363EB70 Slot: 86
	public virtual bool get_IsGenericParameter() { }

	// RVA: 0x363EB80 Offset: 0x363EC81 VA: 0x363EB80 Slot: 87
	public virtual int get_GenericParameterPosition() { }

	// RVA: 0x363EBE0 Offset: 0x363ECE1 VA: 0x363EBE0 Slot: 88
	public virtual bool get_ContainsGenericParameters() { }

	// RVA: 0x363ED90 Offset: 0x363EE91 VA: 0x363ED90 Slot: 89
	public virtual Type[] GetGenericParameterConstraints() { }

	// RVA: 0x363EE40 Offset: 0x363EF41 VA: 0x363EE40 Slot: 90
	public bool get_IsByRef() { }

	// RVA: 0x363EE50 Offset: 0x363EF51 VA: 0x363EE50 Slot: 91
	public bool get_IsPointer() { }

	// RVA: 0x363EE60 Offset: 0x363EF61 VA: 0x363EE60 Slot: 92
	public bool get_IsPrimitive() { }

	// RVA: 0x363EE70 Offset: 0x363EF71 VA: 0x363EE70 Slot: 93
	public bool get_IsCOMObject() { }

	// RVA: 0x363ED30 Offset: 0x363EE31 VA: 0x363ED30 Slot: 94
	public bool get_HasElementType() { }

	// RVA: 0x363EE80 Offset: 0x363EF81 VA: 0x363EE80 Slot: 95
	public bool get_IsContextful() { }

	// RVA: 0x363EE90 Offset: 0x363EF91 VA: 0x363EE90 Slot: 96
	public bool get_IsMarshalByRef() { }

	// RVA: 0x363EEA0 Offset: 0x363EFA1 VA: 0x363EEA0 Slot: 97
	protected virtual bool IsValueTypeImpl() { }

	// RVA: -1 Offset: -1 Slot: 98
	protected abstract TypeAttributes GetAttributeFlagsImpl();

	// RVA: -1 Offset: -1 Slot: 99
	protected abstract bool IsArrayImpl();

	// RVA: -1 Offset: -1 Slot: 100
	protected abstract bool IsByRefImpl();

	// RVA: -1 Offset: -1 Slot: 101
	protected abstract bool IsPointerImpl();

	// RVA: -1 Offset: -1 Slot: 102
	protected abstract bool IsPrimitiveImpl();

	// RVA: -1 Offset: -1 Slot: 103
	protected abstract bool IsCOMObjectImpl();

	// RVA: 0x363EF20 Offset: 0x363F021 VA: 0x363EF20 Slot: 104
	public virtual Type MakeGenericType(Type[] typeArguments) { }

	// RVA: 0x363EF80 Offset: 0x363F081 VA: 0x363EF80 Slot: 105
	protected virtual bool IsContextfulImpl() { }

	// RVA: 0x363F130 Offset: 0x363F231 VA: 0x363F130 Slot: 106
	protected virtual bool IsMarshalByRefImpl() { }

	// RVA: -1 Offset: -1 Slot: 107
	public abstract Type GetElementType();

	// RVA: 0x363F240 Offset: 0x363F341 VA: 0x363F240 Slot: 108
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x363F2A0 Offset: 0x363F3A1 VA: 0x363F2A0 Slot: 109
	public virtual Type GetGenericTypeDefinition() { }

	// RVA: -1 Offset: -1 Slot: 110
	protected abstract bool HasElementTypeImpl();

	// RVA: 0x363ED40 Offset: 0x363EE41 VA: 0x363ED40
	internal Type GetRootElementType() { }

	// RVA: 0x363F300 Offset: 0x363F401 VA: 0x363F300 Slot: 111
	public virtual string[] GetEnumNames() { }

	// RVA: 0x363F810 Offset: 0x363F911 VA: 0x363F810 Slot: 112
	public virtual Array GetEnumValues() { }

	// RVA: 0x363F8D0 Offset: 0x363F9D1 VA: 0x363F8D0
	private Array GetEnumRawConstantValues() { }

	// RVA: 0x363F3C0 Offset: 0x363F4C1 VA: 0x363F3C0
	private void GetEnumData(out string[] enumNames, out Array enumValues) { }

	// RVA: 0x363F900 Offset: 0x363FA01 VA: 0x363F900 Slot: 113
	public virtual Type GetEnumUnderlyingType() { }

	// RVA: 0x363F9E0 Offset: 0x363FAE1 VA: 0x363F9E0 Slot: 114
	public virtual bool IsEnumDefined(object value) { }

	// RVA: 0x3640710 Offset: 0x3640811 VA: 0x3640710 Slot: 115
	public virtual string GetEnumName(object value) { }

	// RVA: 0x36405B0 Offset: 0x36406B1 VA: 0x36405B0
	private static int BinarySearch(Array array, object value) { }

	// RVA: 0x363FF20 Offset: 0x3640021 VA: 0x363FF20
	internal static bool IsIntegerType(Type t) { }

	// RVA: -1 Offset: -1 Slot: 116
	public abstract Type get_UnderlyingSystemType();

	[ComVisibleAttribute] // RVA: 0x47AD00 Offset: 0x47AE01 VA: 0x47AD00
	// RVA: 0x3640940 Offset: 0x3640A41 VA: 0x3640940 Slot: 117
	public virtual bool IsSubclassOf(Type c) { }

	// RVA: 0x3640A40 Offset: 0x3640B41 VA: 0x3640A40 Slot: 118
	public virtual bool IsInstanceOfType(object o) { }

	// RVA: 0x3640A90 Offset: 0x3640B91 VA: 0x3640A90 Slot: 119
	public virtual bool IsAssignableFrom(Type c) { }

	// RVA: 0x3640E60 Offset: 0x3640F61 VA: 0x3640E60 Slot: 120
	public virtual bool IsEquivalentTo(Type other) { }

	// RVA: 0x3640CE0 Offset: 0x3640DE1 VA: 0x3640CE0
	internal bool ImplementInterface(Type ifaceType) { }

	// RVA: 0x3640ED0 Offset: 0x3640FD1 VA: 0x3640ED0
	internal string FormatTypeName() { }

	// RVA: 0x3640EF0 Offset: 0x3640FF1 VA: 0x3640EF0 Slot: 121
	internal virtual string FormatTypeName(bool serialization) { }

	// RVA: 0x3640F30 Offset: 0x3641031 VA: 0x3640F30 Slot: 3
	public override string ToString() { }

	// RVA: 0x3640FA0 Offset: 0x36410A1 VA: 0x3640FA0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x3641050 Offset: 0x3641151 VA: 0x3641050 Slot: 122
	public virtual bool Equals(Type o) { }

	// RVA: 0x363D5B0 Offset: 0x363D6B1 VA: 0x363D5B0
	public static bool op_Equality(Type left, Type right) { }

	// RVA: 0x363D730 Offset: 0x363D831 VA: 0x363D730
	public static bool op_Inequality(Type left, Type right) { }

	// RVA: 0x36410B0 Offset: 0x36411B1 VA: 0x36410B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3641100 Offset: 0x3641201 VA: 0x3641100 Slot: 123
	public Type GetType() { }

	// RVA: 0x3641110 Offset: 0x3641211 VA: 0x3641110 Slot: 124
	public virtual bool get_IsSZArray() { }

	// RVA: 0x3641150 Offset: 0x3641251 VA: 0x3641150
	private static Type internal_from_name(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x3641160 Offset: 0x3641261 VA: 0x3641160
	public static Type GetType(string typeName) { }

	// RVA: 0x3641200 Offset: 0x3641301 VA: 0x3641200
	public static Type GetType(string typeName, bool throwOnError) { }

	// RVA: 0x36412B0 Offset: 0x36413B1 VA: 0x36412B0
	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x363F090 Offset: 0x363F191 VA: 0x363F090
	public static Type GetTypeFromHandle(RuntimeTypeHandle handle) { }

	// RVA: 0x36414C0 Offset: 0x36415C1 VA: 0x36414C0
	private static Type internal_from_handle(IntPtr handle) { }

	// RVA: 0x36414D0 Offset: 0x36415D1 VA: 0x36414D0
	private static void .cctor() { }
}

