// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x4724E0 Offset: 0x4725E1 VA: 0x4724E0
[ComDefaultInterfaceAttribute] // RVA: 0x4724E0 Offset: 0x4725E1 VA: 0x4724E0
[ClassInterfaceAttribute] // RVA: 0x4724E0 Offset: 0x4725E1 VA: 0x4724E0
[Serializable]
public abstract class FieldInfo : MemberInfo, _FieldInfo // TypeDefIndex: 566
{
	// Properties
	public abstract FieldAttributes Attributes { get; }
	public abstract RuntimeFieldHandle FieldHandle { get; }
	public abstract Type FieldType { get; }
	public override MemberTypes MemberType { get; }
	public bool IsLiteral { get; }
	public bool IsStatic { get; }
	public bool IsInitOnly { get; }
	public bool IsPublic { get; }
	public bool IsPrivate { get; }
	public bool IsFamily { get; }
	public bool IsAssembly { get; }
	public bool IsFamilyAndAssembly { get; }
	public bool IsFamilyOrAssembly { get; }
	public bool IsSpecialName { get; }
	public bool IsNotSerialized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	public abstract FieldAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract RuntimeFieldHandle get_FieldHandle();

	// RVA: 0x3B66430 Offset: 0x3B66531 VA: 0x3B66430
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Type get_FieldType();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract object GetValue(object obj);

	// RVA: 0x3B66440 Offset: 0x3B66541 VA: 0x3B66440 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: 0x3B66450 Offset: 0x3B66551 VA: 0x3B66450 Slot: 20
	public bool get_IsLiteral() { }

	// RVA: 0x3B66480 Offset: 0x3B66581 VA: 0x3B66480 Slot: 21
	public bool get_IsStatic() { }

	// RVA: 0x3B664B0 Offset: 0x3B665B1 VA: 0x3B664B0 Slot: 22
	public bool get_IsInitOnly() { }

	// RVA: 0x3B664E0 Offset: 0x3B665E1 VA: 0x3B664E0 Slot: 23
	public bool get_IsPublic() { }

	// RVA: 0x3B66510 Offset: 0x3B66611 VA: 0x3B66510 Slot: 24
	public bool get_IsPrivate() { }

	// RVA: 0x3B66540 Offset: 0x3B66641 VA: 0x3B66540 Slot: 25
	public bool get_IsFamily() { }

	// RVA: 0x3B66570 Offset: 0x3B66671 VA: 0x3B66570 Slot: 26
	public bool get_IsAssembly() { }

	// RVA: 0x3B665A0 Offset: 0x3B666A1 VA: 0x3B665A0 Slot: 27
	public bool get_IsFamilyAndAssembly() { }

	// RVA: 0x3B665D0 Offset: 0x3B666D1 VA: 0x3B665D0 Slot: 28
	public bool get_IsFamilyOrAssembly() { }

	// RVA: 0x3B66600 Offset: 0x3B66701 VA: 0x3B66600 Slot: 29
	public bool get_IsSpecialName() { }

	// RVA: 0x3B66630 Offset: 0x3B66731 VA: 0x3B66630 Slot: 30
	public bool get_IsNotSerialized() { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	[DebuggerStepThroughAttribute] // RVA: 0x47BE00 Offset: 0x47BF01 VA: 0x47BE00
	[DebuggerHiddenAttribute] // RVA: 0x47BE00 Offset: 0x47BF01 VA: 0x47BE00
	// RVA: 0x3B66660 Offset: 0x3B66761 VA: 0x3B66660 Slot: 32
	public void SetValue(object obj, object value) { }

	// RVA: 0x3B66680 Offset: 0x3B66781 VA: 0x3B66680
	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	// RVA: 0x3B66690 Offset: 0x3B66791 VA: 0x3B66690
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	[ComVisibleAttribute] // RVA: 0x47BE40 Offset: 0x47BF41 VA: 0x47BE40
	// RVA: 0x3B66730 Offset: 0x3B66831 VA: 0x3B66730
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	// RVA: 0x3B66850 Offset: 0x3B66951 VA: 0x3B66850 Slot: 33
	internal virtual int GetFieldOffset() { }

	[CLSCompliantAttribute] // RVA: 0x47BE60 Offset: 0x47BF61 VA: 0x47BE60
	// RVA: 0x3B668B0 Offset: 0x3B669B1 VA: 0x3B668B0 Slot: 34
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x3B66910 Offset: 0x3B66A11 VA: 0x3B66910
	private MarshalAsAttribute get_marshal_info() { }

	// RVA: 0x3B66920 Offset: 0x3B66A21 VA: 0x3B66920
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x3B66B50 Offset: 0x3B66C51 VA: 0x3B66B50 Slot: 35
	public virtual object GetRawConstantValue() { }

	// RVA: 0x3B66BB0 Offset: 0x3B66CB1 VA: 0x3B66BB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3B66BC0 Offset: 0x3B66CC1 VA: 0x3B66BC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3B66810 Offset: 0x3B66911 VA: 0x3B66810
	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	// RVA: 0x3B66BD0 Offset: 0x3B66CD1 VA: 0x3B66BD0
	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }
}

