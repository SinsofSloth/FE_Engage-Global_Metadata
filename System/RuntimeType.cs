// Namespace: System
[Serializable]
internal class RuntimeType : TypeInfo, ISerializable, ICloneable // TypeDefIndex: 297
{
	// Fields
	internal static readonly RuntimeType ValueType; // 0x0
	internal static readonly RuntimeType EnumType; // 0x8
	private static readonly RuntimeType ObjectType; // 0x10
	private static readonly RuntimeType StringType; // 0x18
	private static readonly RuntimeType DelegateType; // 0x20
	private static Type[] s_SICtorParamTypes; // 0x28
	private const BindingFlags MemberBindingMask = 255;
	private const BindingFlags InvocationMask = 65280;
	private const BindingFlags BinderNonCreateInstance = 15616;
	private const BindingFlags BinderGetSetProperty = 12288;
	private const BindingFlags BinderSetInvokeProperty = 8448;
	private const BindingFlags BinderGetSetField = 3072;
	private const BindingFlags BinderSetInvokeField = 2304;
	private const BindingFlags BinderNonFieldGetSet = 16773888;
	private const BindingFlags ClassicBindingMask = 61696;
	private static RuntimeType s_typedRef; // 0x30
	private MonoTypeInfo type_info; // 0x18
	internal object GenericCache; // 0x20
	private RuntimeConstructorInfo m_serializationCtor; // 0x28

	// Properties
	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override Type BaseType { get; }
	public override Type UnderlyingSystemType { get; }
	public override bool IsEnum { get; }
	public override GenericParameterAttributes GenericParameterAttributes { get; }
	internal override bool IsSzArray { get; }
	public override bool IsGenericTypeDefinition { get; }
	public override bool IsGenericParameter { get; }
	public override int GenericParameterPosition { get; }
	public override bool IsGenericType { get; }
	public override bool IsConstructedGenericType { get; }
	public override MemberTypes MemberType { get; }
	public override Type ReflectedType { get; }
	public override int MetadataToken { get; }
	public override bool ContainsGenericParameters { get; }
	public override Guid GUID { get; }
	public override MethodBase DeclaringMethod { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override string FullName { get; }
	public override bool IsSZArray { get; }

	// Methods

	// RVA: 0x322FA50 Offset: 0x322FB51 VA: 0x322FA50
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	// RVA: 0x322FBA0 Offset: 0x322FCA1 VA: 0x322FBA0
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	// RVA: 0x322FDC0 Offset: 0x322FEC1 VA: 0x322FDC0
	private static void SplitName(string fullname, out string name, out string ns) { }

	// RVA: 0x322FF00 Offset: 0x3230001 VA: 0x322FF00
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x3230050 Offset: 0x3230151 VA: 0x3230050
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x32300F0 Offset: 0x32301F1 VA: 0x32300F0
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	// RVA: 0x3230160 Offset: 0x3230261 VA: 0x3230160
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	// RVA: 0x3230370 Offset: 0x3230471 VA: 0x3230370
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	// RVA: 0x3230490 Offset: 0x3230591 VA: 0x3230490
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x3230790 Offset: 0x3230891 VA: 0x3230790
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x3230520 Offset: 0x3230621 VA: 0x3230520
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x3230820 Offset: 0x3230921 VA: 0x3230820
	internal void .ctor() { }

	// RVA: 0x3230870 Offset: 0x3230971 VA: 0x3230870
	internal bool IsSpecialSerializableType() { }

	// RVA: 0x3230B70 Offset: 0x3230C71 VA: 0x3230B70
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x3231170 Offset: 0x3231271 VA: 0x3231170
	private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x3231750 Offset: 0x3231851 VA: 0x3231750
	private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x3231CC0 Offset: 0x3231DC1 VA: 0x3231CC0
	private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x3232220 Offset: 0x3232321 VA: 0x3232220
	private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x3232780 Offset: 0x3232881 VA: 0x3232780
	private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x3232CE0 Offset: 0x3232DE1 VA: 0x3232CE0 Slot: 43
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[ComVisibleAttribute] // RVA: 0x47A920 Offset: 0x47AA21 VA: 0x47A920
	// RVA: 0x3232D70 Offset: 0x3232E71 VA: 0x3232D70 Slot: 36
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x3232E10 Offset: 0x3232F11 VA: 0x3232E10 Slot: 56
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x3232EA0 Offset: 0x3232FA1 VA: 0x3232EA0 Slot: 50
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x3232F30 Offset: 0x3233031 VA: 0x3232F30 Slot: 45
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x3232FC0 Offset: 0x32330C1 VA: 0x3232FC0 Slot: 58
	public override Type[] GetNestedTypes(BindingFlags bindingAttr) { }

	// RVA: 0x3233050 Offset: 0x3233151 VA: 0x3233050 Slot: 41
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x32332C0 Offset: 0x32333C1 VA: 0x32332C0 Slot: 35
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x32334B0 Offset: 0x32335B1 VA: 0x32334B0 Slot: 55
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x3233710 Offset: 0x3233811 VA: 0x3233710 Slot: 49
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x3233900 Offset: 0x3233A01 VA: 0x3233900 Slot: 44
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x3233C00 Offset: 0x3233D01 VA: 0x3233C00 Slot: 47
	public override Type GetInterface(string fullname, bool ignoreCase) { }

	// RVA: 0x3233FA0 Offset: 0x32340A1 VA: 0x3233FA0 Slot: 59
	public override Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	// RVA: 0x3234200 Offset: 0x3234301 VA: 0x3234200 Slot: 62
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x32346F0 Offset: 0x32347F1 VA: 0x32346F0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x322C250 Offset: 0x322C351 VA: 0x322C250
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x3234700 Offset: 0x3234801 VA: 0x3234700 Slot: 25
	public override Assembly get_Assembly() { }

	// RVA: 0x3234710 Offset: 0x3234811 VA: 0x3234710
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x3234720 Offset: 0x3234821 VA: 0x3234720 Slot: 26
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x3234750 Offset: 0x3234851 VA: 0x3234750 Slot: 118
	public override bool IsInstanceOfType(object o) { }

	[ComVisibleAttribute] // RVA: 0x47A940 Offset: 0x47AA41 VA: 0x47A940
	// RVA: 0x3234760 Offset: 0x3234861 VA: 0x3234760 Slot: 117
	public override bool IsSubclassOf(Type type) { }

	// RVA: 0x3234930 Offset: 0x3234A31 VA: 0x3234930 Slot: 119
	public override bool IsAssignableFrom(Type c) { }

	// RVA: 0x3234A40 Offset: 0x3234B41 VA: 0x3234A40 Slot: 120
	public override bool IsEquivalentTo(Type other) { }

	// RVA: 0x3234B20 Offset: 0x3234C21 VA: 0x3234B20 Slot: 31
	public override Type get_BaseType() { }

	// RVA: 0x3230950 Offset: 0x3230A51 VA: 0x3230950
	private RuntimeType GetBaseType() { }

	// RVA: 0x3234B30 Offset: 0x3234C31 VA: 0x3234B30 Slot: 116
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x3234B40 Offset: 0x3234C41 VA: 0x3234B40 Slot: 98
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x3234B50 Offset: 0x3234C51 VA: 0x3234B50 Slot: 105
	protected override bool IsContextfulImpl() { }

	// RVA: 0x3234B60 Offset: 0x3234C61 VA: 0x3234B60 Slot: 100
	protected override bool IsByRefImpl() { }

	// RVA: 0x3234B70 Offset: 0x3234C71 VA: 0x3234B70 Slot: 102
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x3234B80 Offset: 0x3234C81 VA: 0x3234B80 Slot: 101
	protected override bool IsPointerImpl() { }

	// RVA: 0x3234B90 Offset: 0x3234C91 VA: 0x3234B90 Slot: 103
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x3234BA0 Offset: 0x3234CA1 VA: 0x3234BA0 Slot: 97
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x3234CE0 Offset: 0x3234DE1 VA: 0x3234CE0 Slot: 79
	public override bool get_IsEnum() { }

	// RVA: 0x3234D70 Offset: 0x3234E71 VA: 0x3234D70 Slot: 110
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x3234D80 Offset: 0x3234E81 VA: 0x3234D80 Slot: 64
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x3234E50 Offset: 0x3234F51 VA: 0x3234E50 Slot: 82
	internal override bool get_IsSzArray() { }

	// RVA: 0x3234E60 Offset: 0x3234F61 VA: 0x3234E60 Slot: 99
	protected override bool IsArrayImpl() { }

	// RVA: 0x3234E70 Offset: 0x3234F71 VA: 0x3234E70 Slot: 30
	public override int GetArrayRank() { }

	// RVA: 0x3234F00 Offset: 0x3235001 VA: 0x3234F00 Slot: 107
	public override Type GetElementType() { }

	// RVA: 0x3234F10 Offset: 0x3235011 VA: 0x3234F10 Slot: 111
	public override string[] GetEnumNames() { }

	// RVA: 0x3235040 Offset: 0x3235141 VA: 0x3235040 Slot: 112
	public override Array GetEnumValues() { }

	// RVA: 0x3235210 Offset: 0x3235311 VA: 0x3235210 Slot: 113
	public override Type GetEnumUnderlyingType() { }

	// RVA: 0x32352F0 Offset: 0x32353F1 VA: 0x32352F0 Slot: 114
	public override bool IsEnumDefined(object value) { }

	// RVA: 0x3235800 Offset: 0x3235901 VA: 0x3235800 Slot: 115
	public override string GetEnumName(object value) { }

	// RVA: 0x3235A20 Offset: 0x3235B21 VA: 0x3235A20
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	// RVA: 0x3235AB0 Offset: 0x3235BB1 VA: 0x3235AB0 Slot: 108
	public override Type[] GetGenericArguments() { }

	// RVA: 0x3235B50 Offset: 0x3235C51 VA: 0x3235B50 Slot: 104
	public override Type MakeGenericType(Type[] instantiation) { }

	// RVA: 0x3236040 Offset: 0x3236141 VA: 0x3236040 Slot: 84
	public override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x3236050 Offset: 0x3236151 VA: 0x3236050 Slot: 86
	public override bool get_IsGenericParameter() { }

	// RVA: 0x3236060 Offset: 0x3236161 VA: 0x3236060 Slot: 87
	public override int get_GenericParameterPosition() { }

	// RVA: 0x3236100 Offset: 0x3236201 VA: 0x3236100 Slot: 109
	public override Type GetGenericTypeDefinition() { }

	// RVA: 0x3236190 Offset: 0x3236291 VA: 0x3236190 Slot: 83
	public override bool get_IsGenericType() { }

	// RVA: 0x32361A0 Offset: 0x32362A1 VA: 0x32361A0 Slot: 85
	public override bool get_IsConstructedGenericType() { }

	[DebuggerStepThroughAttribute] // RVA: 0x47A960 Offset: 0x47AA61 VA: 0x47A960
	[DebuggerHiddenAttribute] // RVA: 0x47A960 Offset: 0x47AA61 VA: 0x47A960
	// RVA: 0x3236200 Offset: 0x3236301 VA: 0x3236200 Slot: 23
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) { }

	// RVA: 0x32373C0 Offset: 0x32374C1 VA: 0x32373C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x32268D0 Offset: 0x32269D1 VA: 0x32268D0
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x3230B60 Offset: 0x3230C61 VA: 0x3230B60
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	// RVA: 0x32373D0 Offset: 0x32374D1 VA: 0x32373D0 Slot: 128
	public object Clone() { }

	// RVA: 0x32373E0 Offset: 0x32374E1 VA: 0x32373E0 Slot: 127
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3237450 Offset: 0x3237551 VA: 0x3237450 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x3237500 Offset: 0x3237601 VA: 0x3237500 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x32376B0 Offset: 0x32377B1 VA: 0x32376B0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x3237860 Offset: 0x3237961 VA: 0x3237860 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x3237870 Offset: 0x3237971 VA: 0x3237870 Slot: 121
	internal override string FormatTypeName(bool serialization) { }

	// RVA: 0x3237A60 Offset: 0x3237B61 VA: 0x3237A60 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: 0x3237AC0 Offset: 0x3237BC1 VA: 0x3237AC0 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x3237AD0 Offset: 0x3237BD1 VA: 0x3237AD0 Slot: 14
	public override int get_MetadataToken() { }

	// RVA: 0x3237AE0 Offset: 0x3237BE1 VA: 0x3237AE0
	private void CreateInstanceCheckThis() { }

	// RVA: 0x3237D00 Offset: 0x3237E01 VA: 0x3237D00
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[DebuggerStepThroughAttribute] // RVA: 0x47A9A0 Offset: 0x47AAA1 VA: 0x47A9A0
	[DebuggerHiddenAttribute] // RVA: 0x47A9A0 Offset: 0x47AAA1 VA: 0x47A9A0
	// RVA: 0x3238710 Offset: 0x3238811 VA: 0x3238710
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x3238880 Offset: 0x3238981 VA: 0x3238880
	internal MonoCMethod GetDefaultConstructor() { }

	// RVA: 0x32372C0 Offset: 0x32373C1 VA: 0x32372C0
	private string GetDefaultMemberName() { }

	// RVA: 0x3238A50 Offset: 0x3238B51 VA: 0x3238A50
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	// RVA: 0x3238840 Offset: 0x3238941 VA: 0x3238840
	internal object CreateInstanceSlow(bool publicOnly, bool skipCheckThis, bool fillCache, ref StackCrawlMark stackMark) { }

	// RVA: 0x3238C70 Offset: 0x3238D71 VA: 0x3238C70
	private object CreateInstanceMono(bool nonPublic) { }

	// RVA: 0x3238F80 Offset: 0x3239081 VA: 0x3238F80
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x3239110 Offset: 0x3239211 VA: 0x3239110
	private object TryConvertToType(object value, ref bool failed) { }

	// RVA: 0x32393A0 Offset: 0x32394A1 VA: 0x32393A0
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	// RVA: 0x3237A00 Offset: 0x3237B01 VA: 0x3237A00
	private string GetCachedName(TypeNameKind kind) { }

	// RVA: 0x3239EE0 Offset: 0x3239FE1 VA: 0x3239EE0
	private Type make_array_type(int rank) { }

	// RVA: 0x3239EF0 Offset: 0x3239FF1 VA: 0x3239EF0 Slot: 19
	public override Type MakeArrayType() { }

	// RVA: 0x3239F00 Offset: 0x323A001 VA: 0x3239F00 Slot: 20
	public override Type MakeArrayType(int rank) { }

	// RVA: 0x3239F50 Offset: 0x323A051 VA: 0x3239F50
	private Type make_byref_type() { }

	// RVA: 0x3239F60 Offset: 0x323A061 VA: 0x3239F60 Slot: 18
	public override Type MakeByRefType() { }

	// RVA: 0x3239FE0 Offset: 0x323A0E1 VA: 0x3239FE0
	private static Type MakePointerType(Type type) { }

	// RVA: 0x3239FF0 Offset: 0x323A0F1 VA: 0x3239FF0 Slot: 17
	public override Type MakePointerType() { }

	// RVA: 0x323A060 Offset: 0x323A161 VA: 0x323A060 Slot: 88
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x323A180 Offset: 0x323A281 VA: 0x323A180 Slot: 89
	public override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x323A290 Offset: 0x323A391 VA: 0x323A290
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	// RVA: 0x3236030 Offset: 0x3236131 VA: 0x3236030
	private static Type MakeGenericType(Type gt, Type[] types) { }

	// RVA: 0x323A3D0 Offset: 0x323A4D1 VA: 0x323A3D0
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, bool ignoreCase) { }

	// RVA: 0x3230E90 Offset: 0x3230F91 VA: 0x3230E90
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, bool ignoreCase, RuntimeType reflectedType) { }

	// RVA: 0x323A3E0 Offset: 0x323A4E1 VA: 0x323A3E0
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, bool icase) { }

	// RVA: 0x323A3F0 Offset: 0x323A4F1 VA: 0x323A3F0
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	// RVA: 0x3231530 Offset: 0x3231631 VA: 0x3231530
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x32319E0 Offset: 0x3231AE1 VA: 0x32319E0
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, bool icase, RuntimeType reflectedType) { }

	// RVA: 0x323A400 Offset: 0x323A501 VA: 0x323A400 Slot: 22
	public override Guid get_GUID() { }

	// RVA: 0x323A550 Offset: 0x323A651 VA: 0x323A550
	internal static Type GetTypeFromCLSIDImpl(Guid clsid, string server, bool throwOnError) { }

	// RVA: 0x323A5B0 Offset: 0x323A6B1 VA: 0x323A5B0 Slot: 21
	protected override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x323A620 Offset: 0x323A721 VA: 0x323A620
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	// RVA: 0x323A630 Offset: 0x323A731 VA: 0x323A630 Slot: 3
	public override string ToString() { }

	// RVA: 0x3238700 Offset: 0x3238801 VA: 0x3238700
	private bool IsGenericCOMObjectImpl() { }

	// RVA: 0x3238F70 Offset: 0x3239071 VA: 0x3238F70
	private static object CreateInstanceInternal(Type type) { }

	// RVA: 0x323A650 Offset: 0x323A751 VA: 0x323A650 Slot: 16
	public override MethodBase get_DeclaringMethod() { }

	// RVA: 0x323A640 Offset: 0x323A741 VA: 0x323A640
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	// RVA: 0x3235AA0 Offset: 0x3235BA1 VA: 0x3235AA0
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	// RVA: 0x3234E20 Offset: 0x3234F21 VA: 0x3234E20
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	// RVA: 0x32360F0 Offset: 0x32361F1 VA: 0x32360F0
	private int GetGenericParameterPosition() { }

	// RVA: 0x323A660 Offset: 0x323A761 VA: 0x323A660
	private IntPtr GetEvents_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x323A670 Offset: 0x323A771 VA: 0x323A670
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x32324B0 Offset: 0x32325B1 VA: 0x32324B0
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x3231F50 Offset: 0x3232051 VA: 0x3231F50
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x323A680 Offset: 0x323A781 VA: 0x323A680 Slot: 48
	public override Type[] GetInterfaces() { }

	// RVA: 0x323A690 Offset: 0x323A791 VA: 0x323A690
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr) { }

	// RVA: 0x3232960 Offset: 0x3232A61 VA: 0x3232960
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr) { }

	// RVA: 0x323A6A0 Offset: 0x323A7A1 VA: 0x323A6A0 Slot: 29
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x323A6B0 Offset: 0x323A7B1 VA: 0x323A6B0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x323A6C0 Offset: 0x323A7C1 VA: 0x323A6C0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x323A6D0 Offset: 0x323A7D1 VA: 0x323A6D0 Slot: 28
	public override string get_Namespace() { }

	// RVA: 0x323A6E0 Offset: 0x323A7E1 VA: 0x323A6E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x323A7C0 Offset: 0x323A8C1 VA: 0x323A7C0 Slot: 27
	public override string get_FullName() { }

	// RVA: 0x323A8D0 Offset: 0x323A9D1 VA: 0x323A8D0 Slot: 124
	public override bool get_IsSZArray() { }

	// RVA: 0x323A940 Offset: 0x323AA41 VA: 0x323A940
	private static void .cctor() { }
}

