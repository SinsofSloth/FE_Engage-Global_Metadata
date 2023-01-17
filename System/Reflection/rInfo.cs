// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x472320 Offset: 0x472421 VA: 0x472320
[ComDefaultInterfaceAttribute] // RVA: 0x472320 Offset: 0x472421 VA: 0x472320
[ClassInterfaceAttribute] // RVA: 0x472320 Offset: 0x472421 VA: 0x472320
[Serializable]
public abstract class ConstructorInfo : MethodBase, _ConstructorInfo // TypeDefIndex: 557
{
	// Fields
	[ComVisibleAttribute] // RVA: 0x478470 Offset: 0x478571 VA: 0x478470
	public static readonly string ConstructorName; // 0x0
	[ComVisibleAttribute] // RVA: 0x478490 Offset: 0x478591 VA: 0x478490
	public static readonly string TypeConstructorName; // 0x8

	// Properties
	[ComVisibleAttribute] // RVA: 0x47DDC0 Offset: 0x47DEC1 VA: 0x47DDC0
	public override MemberTypes MemberType { get; }

	// Methods

	// RVA: 0x33B1DF0 Offset: 0x33B1EF1 VA: 0x33B1DF0
	protected void .ctor() { }

	// RVA: 0x33B1E00 Offset: 0x33B1F01 VA: 0x33B1E00 Slot: 6
	public override MemberTypes get_MemberType() { }

	[DebuggerHiddenAttribute] // RVA: 0x47BDC0 Offset: 0x47BEC1 VA: 0x47BDC0
	[DebuggerStepThroughAttribute] // RVA: 0x47BDC0 Offset: 0x47BEC1 VA: 0x47BDC0
	// RVA: 0x339CE40 Offset: 0x339CF41 VA: 0x339CE40
	public object Invoke(object[] parameters) { }

	// RVA: -1 Offset: -1 Slot: 44
	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: 0x33B1E10 Offset: 0x33B1F11 VA: 0x33B1E10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x33B1E20 Offset: 0x33B1F21 VA: 0x33B1E20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x339CE00 Offset: 0x339CF01 VA: 0x339CE00
	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x33B1E30 Offset: 0x33B1F31 VA: 0x33B1E30
	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x33B1E90 Offset: 0x33B1F91 VA: 0x33B1E90
	private static void .cctor() { }
}

// Namespace: System.Reflection
internal abstract class RuntimeConstructorInfo : ConstructorInfo, ISerializable // TypeDefIndex: 581
{
	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }

	// Methods

	// RVA: 0x322B9D0 Offset: 0x322BAD1 VA: 0x322B9D0 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x322BA60 Offset: 0x322BB61 VA: 0x322BA60
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x322BAF0 Offset: 0x322BBF1 VA: 0x322BAF0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x322BB00 Offset: 0x322BC01 VA: 0x322BB00
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x322BB90 Offset: 0x322BC91 VA: 0x322BB90 Slot: 45
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x322BCE0 Offset: 0x322BDE1 VA: 0x322BCE0
	internal string SerializationToString() { }

	// RVA: 0x322BD00 Offset: 0x322BE01 VA: 0x322BD00
	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x322BE40 Offset: 0x322BF41 VA: 0x322BE40
	protected void .ctor() { }
}

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

