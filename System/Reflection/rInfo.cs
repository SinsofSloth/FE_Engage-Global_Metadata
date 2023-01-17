// Namespace: System.Reflection
[Serializable]
internal class MonoCMethod : RuntimeConstructorInfo // TypeDefIndex: 582
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override bool ContainsGenericParameters { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x34F37C0 Offset: 0x34F38C1 VA: 0x34F37C0 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x34F3820 Offset: 0x34F3921 VA: 0x34F3820 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x34F3840 Offset: 0x34F3941 VA: 0x34F3840 Slot: 42
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x34F3850 Offset: 0x34F3951 VA: 0x34F3850 Slot: 43
	internal override int GetParametersCount() { }

	// RVA: 0x34F3880 Offset: 0x34F3981 VA: 0x34F3880
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHiddenAttribute] // RVA: 0x47BF40 Offset: 0x47C041 VA: 0x47BF40
	[DebuggerStepThroughAttribute] // RVA: 0x47BF40 Offset: 0x47C041 VA: 0x47BF40
	// RVA: 0x34F3890 Offset: 0x34F3991 VA: 0x34F3890 Slot: 21
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x34F3990 Offset: 0x34F3A91 VA: 0x34F3990
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x34F3E30 Offset: 0x34F3F31 VA: 0x34F3E30
	public object InternalInvoke(object obj, object[] parameters) { }

	[DebuggerHiddenAttribute] // RVA: 0x47BF80 Offset: 0x47C081 VA: 0x47BF80
	[DebuggerStepThroughAttribute] // RVA: 0x47BF80 Offset: 0x47C081 VA: 0x47BF80
	// RVA: 0x34F3F70 Offset: 0x34F4071 VA: 0x34F3F70 Slot: 44
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x34F3F90 Offset: 0x34F4091 VA: 0x34F3F90 Slot: 19
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x34F3FA0 Offset: 0x34F40A1 VA: 0x34F3FA0 Slot: 20
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x34F3FC0 Offset: 0x34F40C1 VA: 0x34F3FC0 Slot: 22
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x34F4020 Offset: 0x34F4121 VA: 0x34F4020 Slot: 25
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x34F4050 Offset: 0x34F4151 VA: 0x34F4050 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x34F4060 Offset: 0x34F4161 VA: 0x34F4060 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x34F40C0 Offset: 0x34F41C1 VA: 0x34F40C0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x34F40F0 Offset: 0x34F41F1 VA: 0x34F40F0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x34F4450 Offset: 0x34F4551 VA: 0x34F4450 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x34F4660 Offset: 0x34F4761 VA: 0x34F4660 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x34F51B0 Offset: 0x34F52B1 VA: 0x34F51B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x34F53A0 Offset: 0x34F54A1 VA: 0x34F53A0 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x34F53B0 Offset: 0x34F54B1 VA: 0x34F53B0
	private static int get_core_clr_security_level() { }

	// RVA: 0x34F53C0 Offset: 0x34F54C1 VA: 0x34F53C0 Slot: 27
	public override bool get_IsSecurityCritical() { }

	// RVA: 0x34F53D0 Offset: 0x34F54D1 VA: 0x34F53D0
	public void .ctor() { }
}

