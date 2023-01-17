// Namespace: System.Reflection
[Serializable]
internal class MonoMethod : RuntimeMethodInfo // TypeDefIndex: 580
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override Type ReturnType { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsGenericMethodDefinition { get; }
	public override bool IsGenericMethod { get; }
	public override bool ContainsGenericParameters { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x34F9560 Offset: 0x34F9661 VA: 0x34F9560
	internal void .ctor() { }

	// RVA: 0x34F40E0 Offset: 0x34F41E1 VA: 0x34F40E0
	internal static string get_name(MethodBase method) { }

	// RVA: 0x34F9570 Offset: 0x34F9671 VA: 0x34F9570
	internal static MonoMethod get_base_method(MonoMethod method, bool definition) { }

	// RVA: 0x34F9580 Offset: 0x34F9681 VA: 0x34F9580 Slot: 49
	internal override MethodInfo GetBaseMethod() { }

	// RVA: 0x34F9590 Offset: 0x34F9691 VA: 0x34F9590 Slot: 44
	public override Type get_ReturnType() { }

	// RVA: 0x34F95F0 Offset: 0x34F96F1 VA: 0x34F95F0 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x34F9620 Offset: 0x34F9721 VA: 0x34F9620 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x34F96B0 Offset: 0x34F97B1 VA: 0x34F96B0 Slot: 42
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x34F96C0 Offset: 0x34F97C1 VA: 0x34F96C0 Slot: 43
	internal override int GetParametersCount() { }

	// RVA: 0x34F96E0 Offset: 0x34F97E1 VA: 0x34F96E0
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerStepThroughAttribute] // RVA: 0x47BF00 Offset: 0x47C001 VA: 0x47BF00
	[DebuggerHiddenAttribute] // RVA: 0x47BF00 Offset: 0x47C001 VA: 0x47BF00
	// RVA: 0x34F96F0 Offset: 0x34F97F1 VA: 0x34F96F0 Slot: 21
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x34F3B50 Offset: 0x34F3C51 VA: 0x34F3B50
	internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x34F9920 Offset: 0x34F9A21 VA: 0x34F9920 Slot: 19
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x34F9930 Offset: 0x34F9A31 VA: 0x34F9930 Slot: 20
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x34F9940 Offset: 0x34F9A41 VA: 0x34F9940 Slot: 22
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x34F9970 Offset: 0x34F9A71 VA: 0x34F9970 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x34F9980 Offset: 0x34F9A81 VA: 0x34F9980 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x34F99B0 Offset: 0x34F9AB1 VA: 0x34F99B0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x34F99D0 Offset: 0x34F9AD1 VA: 0x34F99D0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x34F9A50 Offset: 0x34F9B51 VA: 0x34F9A50 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x34F9AC0 Offset: 0x34F9BC1 VA: 0x34F9AC0 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x34F9B40 Offset: 0x34F9C41 VA: 0x34F9B40
	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName) { }

	// RVA: 0x34F5950 Offset: 0x34F5A51 VA: 0x34F5950
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x34F9BA0 Offset: 0x34F9CA1 VA: 0x34F9BA0 Slot: 46
	public override MethodInfo MakeGenericMethod(Type[] methodInstantiation) { }

	// RVA: 0x34F9F00 Offset: 0x34FA001 VA: 0x34F9F00
	private MethodInfo MakeGenericMethod_impl(Type[] types) { }

	// RVA: 0x34F9F10 Offset: 0x34FA011 VA: 0x34F9F10 Slot: 23
	public override Type[] GetGenericArguments() { }

	// RVA: 0x34F9F20 Offset: 0x34FA021 VA: 0x34F9F20
	private MethodInfo GetGenericMethodDefinition_impl() { }

	// RVA: 0x34F9F30 Offset: 0x34FA031 VA: 0x34F9F30 Slot: 45
	public override MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x34F9FB0 Offset: 0x34FA0B1 VA: 0x34F9FB0 Slot: 24
	public override bool get_IsGenericMethodDefinition() { }

	// RVA: 0x34F9FC0 Offset: 0x34FA0C1 VA: 0x34F9FC0 Slot: 26
	public override bool get_IsGenericMethod() { }

	// RVA: 0x34F9FD0 Offset: 0x34FA0D1 VA: 0x34F9FD0 Slot: 25
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x34FA0B0 Offset: 0x34FA1B1 VA: 0x34FA0B0 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x34FA0C0 Offset: 0x34FA1C1 VA: 0x34FA0C0
	private static int get_core_clr_security_level() { }

	// RVA: 0x34FA0D0 Offset: 0x34FA1D1 VA: 0x34FA0D0 Slot: 27
	public override bool get_IsSecurityCritical() { }
}

