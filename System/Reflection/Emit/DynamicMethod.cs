// Namespace: System.Reflection.Emit
[ComVisibleAttribute] // RVA: 0x477E10 Offset: 0x477F11 VA: 0x477E10
public sealed class DynamicMethod : MethodInfo // TypeDefIndex: 1510
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override string Name { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x372BB30 Offset: 0x372BC31 VA: 0x372BB30 Slot: 20
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x372BB70 Offset: 0x372BC71 VA: 0x372BB70 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x372BBB0 Offset: 0x372BCB1 VA: 0x372BBB0 Slot: 19
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x372BBF0 Offset: 0x372BCF1 VA: 0x372BBF0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x372BC30 Offset: 0x372BD31 VA: 0x372BC30 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x372BC70 Offset: 0x372BD71 VA: 0x372BC70 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x372BCB0 Offset: 0x372BDB1 VA: 0x372BCB0 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x372BCF0 Offset: 0x372BDF1 VA: 0x372BCF0 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x372BD30 Offset: 0x372BE31 VA: 0x372BD30 Slot: 17
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x372BD70 Offset: 0x372BE71 VA: 0x372BD70 Slot: 21
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x372BDB0 Offset: 0x372BEB1 VA: 0x372BDB0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}

