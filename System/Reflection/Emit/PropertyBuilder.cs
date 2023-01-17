// Namespace: System.Reflection.Emit
public abstract class PropertyBuilder : PropertyInfo // TypeDefIndex: 609
{
	// Properties
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x3823680 Offset: 0x3823781 VA: 0x3823680 Slot: 16
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x38236C0 Offset: 0x38237C1 VA: 0x38236C0 Slot: 17
	public override bool get_CanRead() { }

	// RVA: 0x3823700 Offset: 0x3823801 VA: 0x3823700 Slot: 18
	public override bool get_CanWrite() { }

	// RVA: 0x3823740 Offset: 0x3823841 VA: 0x3823740 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x3823780 Offset: 0x3823881 VA: 0x3823780 Slot: 7
	public override string get_Name() { }

	// RVA: 0x38237C0 Offset: 0x38238C1 VA: 0x38237C0 Slot: 20
	public override Type get_PropertyType() { }

	// RVA: 0x3823800 Offset: 0x3823901 VA: 0x3823800 Slot: 23
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x3823840 Offset: 0x3823941 VA: 0x3823840 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x3823880 Offset: 0x3823981 VA: 0x3823880 Slot: 21
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x38238C0 Offset: 0x38239C1 VA: 0x38238C0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x3823900 Offset: 0x3823A01 VA: 0x3823900 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x3823940 Offset: 0x3823A41 VA: 0x3823940 Slot: 22
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x3823980 Offset: 0x3823A81 VA: 0x3823980 Slot: 25
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x38239C0 Offset: 0x3823AC1 VA: 0x38239C0 Slot: 27
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x3823A00 Offset: 0x3823B01 VA: 0x3823A00 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x3823A40 Offset: 0x3823B41 VA: 0x3823A40 Slot: 29
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }
}

