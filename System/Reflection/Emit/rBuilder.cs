// Namespace: System.Reflection.Emit
public abstract class ConstructorBuilder : ConstructorInfo // TypeDefIndex: 598
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x33B1AF0 Offset: 0x33B1BF1 VA: 0x33B1AF0 Slot: 20
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x33B1B30 Offset: 0x33B1C31 VA: 0x33B1B30 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x33B1B70 Offset: 0x33B1C71 VA: 0x33B1B70 Slot: 7
	public override string get_Name() { }

	// RVA: 0x33B1BB0 Offset: 0x33B1CB1 VA: 0x33B1BB0 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x33B1BF0 Offset: 0x33B1CF1 VA: 0x33B1BF0 Slot: 19
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x33B1C30 Offset: 0x33B1D31 VA: 0x33B1C30 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x33B1C70 Offset: 0x33B1D71 VA: 0x33B1C70 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x33B1CB0 Offset: 0x33B1DB1 VA: 0x33B1CB0 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x33B1CF0 Offset: 0x33B1DF1 VA: 0x33B1CF0 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x33B1D30 Offset: 0x33B1E31 VA: 0x33B1D30 Slot: 21
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x33B1D70 Offset: 0x33B1E71 VA: 0x33B1D70 Slot: 44
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x33B1DB0 Offset: 0x33B1EB1 VA: 0x33B1DB0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}

