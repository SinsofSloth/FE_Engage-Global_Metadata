// Namespace: System.Reflection.Emit
public abstract class FieldBuilder : FieldInfo // TypeDefIndex: 602
{
	// Properties
	public override FieldAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override Type FieldType { get; }
	public override string Name { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x3B66170 Offset: 0x3B66271 VA: 0x3B66170 Slot: 16
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x3B661B0 Offset: 0x3B662B1 VA: 0x3B661B0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x3B661F0 Offset: 0x3B662F1 VA: 0x3B661F0 Slot: 18
	public override Type get_FieldType() { }

	// RVA: 0x3B66230 Offset: 0x3B66331 VA: 0x3B66230 Slot: 7
	public override string get_Name() { }

	// RVA: 0x3B66270 Offset: 0x3B66371 VA: 0x3B66270 Slot: 19
	public override object GetValue(object obj) { }

	// RVA: 0x3B662B0 Offset: 0x3B663B1 VA: 0x3B662B0 Slot: 17
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x3B662F0 Offset: 0x3B663F1 VA: 0x3B662F0 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x3B66330 Offset: 0x3B66431 VA: 0x3B66330 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x3B66370 Offset: 0x3B66471 VA: 0x3B66370 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x3B663B0 Offset: 0x3B664B1 VA: 0x3B663B0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x3B663F0 Offset: 0x3B664F1 VA: 0x3B663F0 Slot: 31
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }
}

