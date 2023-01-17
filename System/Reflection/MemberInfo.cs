// Namespace: System.Reflection
[ComDefaultInterfaceAttribute] // RVA: 0x471D40 Offset: 0x471E41 VA: 0x471D40
[ComVisibleAttribute] // RVA: 0x471D40 Offset: 0x471E41 VA: 0x471D40
[ClassInterfaceAttribute] // RVA: 0x471D40 Offset: 0x471E41 VA: 0x471D40
[Serializable]
public abstract class MemberInfo : ICustomAttributeProvider, _MemberInfo // TypeDefIndex: 533
{
	// Properties
	public abstract MemberTypes MemberType { get; }
	public abstract string Name { get; }
	public abstract Type DeclaringType { get; }
	public abstract Type ReflectedType { get; }
	public virtual int MetadataToken { get; }
	public virtual Module Module { get; }

	// Methods

	// RVA: 0x34E7650 Offset: 0x34E7751 VA: 0x34E7650
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract MemberTypes get_MemberType();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Type get_DeclaringType();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_ReflectedType();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract object[] GetCustomAttributes(bool inherit);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsDefined(Type attributeType, bool inherit);

	// RVA: 0x34E7660 Offset: 0x34E7761 VA: 0x34E7660 Slot: 13
	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x34E76A0 Offset: 0x34E77A1 VA: 0x34E76A0 Slot: 14
	public virtual int get_MetadataToken() { }

	// RVA: 0x34E76B0 Offset: 0x34E77B1 VA: 0x34E76B0 Slot: 15
	public virtual Module get_Module() { }

	// RVA: 0x34E7770 Offset: 0x34E7871 VA: 0x34E7770
	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	// RVA: 0x34E7EC0 Offset: 0x34E7FC1 VA: 0x34E7EC0
	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }

	// RVA: 0x34E7EE0 Offset: 0x34E7FE1 VA: 0x34E7EE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x34E7EF0 Offset: 0x34E7FF1 VA: 0x34E7EF0 Slot: 2
	public override int GetHashCode() { }
}

