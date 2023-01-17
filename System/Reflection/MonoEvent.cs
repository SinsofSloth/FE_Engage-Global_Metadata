// Namespace: System.Reflection
[Serializable]
internal sealed class MonoEvent : RuntimeEventInfo // TypeDefIndex: 574
{
	// Fields
	private IntPtr klass; // 0x18
	private IntPtr handle; // 0x20

	// Properties
	public override EventAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x34F6CC0 Offset: 0x34F6DC1 VA: 0x34F6CC0 Slot: 16
	public override EventAttributes get_Attributes() { }

	// RVA: 0x34F6D60 Offset: 0x34F6E61 VA: 0x34F6D60 Slot: 19
	public override MethodInfo GetAddMethod(bool nonPublic) { }

	// RVA: 0x34F6DF0 Offset: 0x34F6EF1 VA: 0x34F6DF0 Slot: 20
	public override MethodInfo GetRaiseMethod(bool nonPublic) { }

	// RVA: 0x34F6E80 Offset: 0x34F6F81 VA: 0x34F6E80 Slot: 21
	public override MethodInfo GetRemoveMethod(bool nonPublic) { }

	// RVA: 0x34F6F10 Offset: 0x34F7011 VA: 0x34F6F10 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x34F6F50 Offset: 0x34F7051 VA: 0x34F6F50 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x34F6F90 Offset: 0x34F7091 VA: 0x34F6F90 Slot: 7
	public override string get_Name() { }

	// RVA: 0x34F6FD0 Offset: 0x34F70D1 VA: 0x34F6FD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x34F7060 Offset: 0x34F7161 VA: 0x34F7060 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x34F70E0 Offset: 0x34F71E1 VA: 0x34F70E0 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x34F7150 Offset: 0x34F7251 VA: 0x34F7150 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x34F71D0 Offset: 0x34F72D1 VA: 0x34F71D0 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x34F71E0 Offset: 0x34F72E1 VA: 0x34F71E0
	public void .ctor() { }
}

