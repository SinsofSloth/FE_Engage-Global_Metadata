// Namespace: System.Reflection.Emit
public abstract class MethodBuilder : MethodInfo // TypeDefIndex: 606
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x34ED840 Offset: 0x34ED941 VA: 0x34ED840 Slot: 20
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x34ED880 Offset: 0x34ED981 VA: 0x34ED880 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x34ED8C0 Offset: 0x34ED9C1 VA: 0x34ED8C0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x34ED900 Offset: 0x34EDA01 VA: 0x34ED900 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x34ED940 Offset: 0x34EDA41 VA: 0x34ED940 Slot: 19
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x34ED980 Offset: 0x34EDA81 VA: 0x34ED980 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x34ED9C0 Offset: 0x34EDAC1 VA: 0x34ED9C0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x34EDA00 Offset: 0x34EDB01 VA: 0x34EDA00 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x34EDA40 Offset: 0x34EDB41 VA: 0x34EDA40 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x34EDA80 Offset: 0x34EDB81 VA: 0x34EDA80 Slot: 21
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x34EDAC0 Offset: 0x34EDBC1 VA: 0x34EDAC0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}

