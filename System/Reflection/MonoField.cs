// Namespace: System.Reflection
[Serializable]
internal class MonoField : RtFieldInfo // TypeDefIndex: 577
{
	// Fields
	internal IntPtr klass; // 0x10
	internal RuntimeFieldHandle fhandle; // 0x18
	private string name; // 0x20
	private Type type; // 0x28
	private FieldAttributes attrs; // 0x30

	// Properties
	public override FieldAttributes Attributes { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type FieldType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x34F7200 Offset: 0x34F7301 VA: 0x34F7200 Slot: 16
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x34F7210 Offset: 0x34F7311 VA: 0x34F7210 Slot: 17
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x34F7220 Offset: 0x34F7321 VA: 0x34F7220
	private Type ResolveType() { }

	// RVA: 0x34F7230 Offset: 0x34F7331 VA: 0x34F7230 Slot: 18
	public override Type get_FieldType() { }

	// RVA: 0x34F72D0 Offset: 0x34F73D1 VA: 0x34F72D0
	private Type GetParentType(bool declaring) { }

	// RVA: 0x34F72E0 Offset: 0x34F73E1 VA: 0x34F72E0 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x34F72F0 Offset: 0x34F73F1 VA: 0x34F72F0 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x34F7300 Offset: 0x34F7401 VA: 0x34F7300 Slot: 7
	public override string get_Name() { }

	// RVA: 0x34F7310 Offset: 0x34F7411 VA: 0x34F7310 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x34F7390 Offset: 0x34F7491 VA: 0x34F7390 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x34F7400 Offset: 0x34F7501 VA: 0x34F7400 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x34F7480 Offset: 0x34F7581 VA: 0x34F7480 Slot: 33
	internal override int GetFieldOffset() { }

	// RVA: 0x34F7490 Offset: 0x34F7591 VA: 0x34F7490
	private object GetValueInternal(object obj) { }

	// RVA: 0x34F74A0 Offset: 0x34F75A1 VA: 0x34F74A0 Slot: 19
	public override object GetValue(object obj) { }

	// RVA: 0x34F76B0 Offset: 0x34F77B1 VA: 0x34F76B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x34F7720 Offset: 0x34F7821 VA: 0x34F7720
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x34F7730 Offset: 0x34F7831 VA: 0x34F7730 Slot: 31
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x34F79F0 Offset: 0x34F7AF1 VA: 0x34F79F0 Slot: 35
	public override object GetRawConstantValue() { }

	// RVA: 0x34F7A00 Offset: 0x34F7B01 VA: 0x34F7A00 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x34F7630 Offset: 0x34F7731 VA: 0x34F7630
	private void CheckGeneric() { }

	// RVA: 0x34F7A10 Offset: 0x34F7B11 VA: 0x34F7A10
	public void .ctor() { }
}

