// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x4723B0 Offset: 0x4724B1 VA: 0x4723B0
[Serializable]
public class CustomAttributeData // TypeDefIndex: 559
{
	// Fields
	private ConstructorInfo ctorInfo; // 0x10
	private IList<CustomAttributeTypedArgument> ctorArgs; // 0x18
	private IList<CustomAttributeNamedArgument> namedArgs; // 0x20
	private CustomAttributeData.LazyCAttrData lazyData; // 0x28

	// Properties
	[ComVisibleAttribute] // RVA: 0x47DDE0 Offset: 0x47DEE1 VA: 0x47DDE0
	public virtual ConstructorInfo Constructor { get; }
	[ComVisibleAttribute] // RVA: 0x47DE00 Offset: 0x47DF01 VA: 0x47DE00
	public virtual IList<CustomAttributeTypedArgument> ConstructorArguments { get; }
	public virtual IList<CustomAttributeNamedArgument> NamedArguments { get; }
	public Type AttributeType { get; }

	// Methods

	// RVA: 0x37E3480 Offset: 0x37E3581 VA: 0x37E3480
	protected void .ctor() { }

	// RVA: 0x37E3490 Offset: 0x37E3591 VA: 0x37E3490
	internal void .ctor(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	// RVA: 0x37E3560 Offset: 0x37E3661 VA: 0x37E3560
	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs) { }

	// RVA: 0x37E3570 Offset: 0x37E3671 VA: 0x37E3570
	private void ResolveArguments() { }

	// RVA: 0x37E3700 Offset: 0x37E3801 VA: 0x37E3700 Slot: 4
	public virtual ConstructorInfo get_Constructor() { }

	// RVA: 0x37E3710 Offset: 0x37E3811 VA: 0x37E3710 Slot: 5
	public virtual IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	// RVA: 0x37E3740 Offset: 0x37E3841 VA: 0x37E3740 Slot: 6
	public virtual IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	// RVA: 0x37E3770 Offset: 0x37E3871 VA: 0x37E3770
	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	// RVA: 0x37E37E0 Offset: 0x37E38E1 VA: 0x37E37E0
	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	// RVA: 0x37E3850 Offset: 0x37E3951 VA: 0x37E3850
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	// RVA: 0x37E38C0 Offset: 0x37E39C1 VA: 0x37E38C0
	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	// RVA: 0x37E3930 Offset: 0x37E3A31 VA: 0x37E3930
	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	// RVA: 0x37E39A0 Offset: 0x37E3AA1 VA: 0x37E39A0
	public Type get_AttributeType() { }

	// RVA: 0x37E39B0 Offset: 0x37E3AB1 VA: 0x37E39B0 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static T[] UnboxValues<T>(object[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229D850 Offset: 0x229D951 VA: 0x229D850
	|-CustomAttributeData.UnboxValues<CustomAttributeNamedArgument>
	|
	|-RVA: 0x229D980 Offset: 0x229DA81 VA: 0x229D980
	|-CustomAttributeData.UnboxValues<CustomAttributeTypedArgument>
	|
	|-RVA: 0x229DA90 Offset: 0x229DB91 VA: 0x229DA90
	|-CustomAttributeData.UnboxValues<object>
	*/

	// RVA: 0x37E4230 Offset: 0x37E4331 VA: 0x37E4230 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x37E4A50 Offset: 0x37E4B51 VA: 0x37E4A50 Slot: 2
	public override int GetHashCode() { }
}

