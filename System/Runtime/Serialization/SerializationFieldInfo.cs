// Namespace: System.Runtime.Serialization
internal sealed class SerializationFieldInfo : FieldInfo // TypeDefIndex: 1019
{
	// Fields
	private RuntimeFieldInfo m_field; // 0x10
	private string m_serializationName; // 0x18

	// Properties
	public override Module Module { get; }
	public override int MetadataToken { get; }
	public override string Name { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override Type FieldType { get; }
	internal RuntimeFieldInfo FieldInfo { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override FieldAttributes Attributes { get; }

	// Methods

	// RVA: 0x3619420 Offset: 0x3619521 VA: 0x3619420 Slot: 15
	public override Module get_Module() { }

	// RVA: 0x3619440 Offset: 0x3619541 VA: 0x3619440 Slot: 14
	public override int get_MetadataToken() { }

	// RVA: 0x3619460 Offset: 0x3619561 VA: 0x3619460
	internal void .ctor(RuntimeFieldInfo field, string namePrefix) { }

	// RVA: 0x3619510 Offset: 0x3619611 VA: 0x3619510 Slot: 7
	public override string get_Name() { }

	// RVA: 0x3619520 Offset: 0x3619621 VA: 0x3619520 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x3619530 Offset: 0x3619631 VA: 0x3619530 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x3619540 Offset: 0x3619641 VA: 0x3619540 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x3619560 Offset: 0x3619661 VA: 0x3619560 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x3619580 Offset: 0x3619681 VA: 0x3619580 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x36195A0 Offset: 0x36196A1 VA: 0x36195A0 Slot: 18
	public override Type get_FieldType() { }

	// RVA: 0x36195C0 Offset: 0x36196C1 VA: 0x36195C0 Slot: 19
	public override object GetValue(object obj) { }

	// RVA: 0x36195E0 Offset: 0x36196E1 VA: 0x36195E0
	internal object InternalGetValue(object obj) { }

	// RVA: 0x36196C0 Offset: 0x36197C1 VA: 0x36196C0 Slot: 31
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x36196E0 Offset: 0x36197E1 VA: 0x36196E0
	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x3619810 Offset: 0x3619911 VA: 0x3619810
	internal RuntimeFieldInfo get_FieldInfo() { }

	// RVA: 0x3619820 Offset: 0x3619921 VA: 0x3619820 Slot: 17
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x3619840 Offset: 0x3619941 VA: 0x3619840 Slot: 16
	public override FieldAttributes get_Attributes() { }
}

