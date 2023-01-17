// Namespace: System.Reflection
[ComVisibleAttribute] // RVA: 0x472890 Offset: 0x472991 VA: 0x472890
[ClassInterfaceAttribute] // RVA: 0x472890 Offset: 0x472991 VA: 0x472890
[ComDefaultInterfaceAttribute] // RVA: 0x472890 Offset: 0x472991 VA: 0x472890
[Serializable]
public abstract class PropertyInfo : MemberInfo, _PropertyInfo // TypeDefIndex: 595
{
	// Properties
	public abstract PropertyAttributes Attributes { get; }
	public abstract bool CanRead { get; }
	public abstract bool CanWrite { get; }
	public bool IsSpecialName { get; }
	public override MemberTypes MemberType { get; }
	public abstract Type PropertyType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	public abstract PropertyAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool get_CanWrite();

	// RVA: 0x3823A80 Offset: 0x3823B81 VA: 0x3823A80 Slot: 19
	public bool get_IsSpecialName() { }

	// RVA: 0x3823AB0 Offset: 0x3823BB1 VA: 0x3823AB0 Slot: 6
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract Type get_PropertyType();

	// RVA: 0x3823AC0 Offset: 0x3823BC1 VA: 0x3823AC0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract MethodInfo[] GetAccessors(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract MethodInfo GetGetMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ParameterInfo[] GetIndexParameters();

	// RVA: 0x3823AD0 Offset: 0x3823BD1 VA: 0x3823AD0 Slot: 24
	public MethodInfo GetSetMethod() { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract MethodInfo GetSetMethod(bool nonPublic);

	[DebuggerStepThroughAttribute] // RVA: 0x47BFC0 Offset: 0x47C0C1 VA: 0x47BFC0
	[DebuggerHiddenAttribute] // RVA: 0x47BFC0 Offset: 0x47C0C1 VA: 0x47BFC0
	// RVA: 0x3823AF0 Offset: 0x3823BF1 VA: 0x3823AF0 Slot: 26
	public virtual object GetValue(object obj, object[] index) { }

	[DebuggerStepThroughAttribute] // RVA: 0x47C000 Offset: 0x47C101 VA: 0x47C000
	[DebuggerHiddenAttribute] // RVA: 0x47C000 Offset: 0x47C101 VA: 0x47C000
	// RVA: 0x3823B10 Offset: 0x3823C11 VA: 0x3823B10
	public object GetValue(object obj) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	[DebuggerStepThroughAttribute] // RVA: 0x47C040 Offset: 0x47C141 VA: 0x47C040
	[DebuggerHiddenAttribute] // RVA: 0x47C040 Offset: 0x47C141 VA: 0x47C040
	// RVA: 0x3823B30 Offset: 0x3823C31 VA: 0x3823B30 Slot: 28
	public virtual void SetValue(object obj, object value, object[] index) { }

	[DebuggerStepThroughAttribute] // RVA: 0x47C080 Offset: 0x47C181 VA: 0x47C080
	[DebuggerHiddenAttribute] // RVA: 0x47C080 Offset: 0x47C181 VA: 0x47C080
	// RVA: 0x3823B50 Offset: 0x3823C51 VA: 0x3823B50
	public void SetValue(object obj, object value) { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	// RVA: 0x3823B70 Offset: 0x3823C71 VA: 0x3823B70 Slot: 30
	public virtual Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x3823BE0 Offset: 0x3823CE1 VA: 0x3823BE0 Slot: 31
	public virtual Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x3823C50 Offset: 0x3823D51 VA: 0x3823C50
	private static NotImplementedException CreateNIE() { }

	// RVA: 0x3823CB0 Offset: 0x3823DB1 VA: 0x3823CB0 Slot: 32
	public virtual object GetConstantValue() { }

	// RVA: 0x3823CE0 Offset: 0x3823DE1 VA: 0x3823CE0 Slot: 33
	public virtual object GetRawConstantValue() { }

	// RVA: 0x3823D10 Offset: 0x3823E11 VA: 0x3823D10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3823D20 Offset: 0x3823E21 VA: 0x3823D20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3823D30 Offset: 0x3823E31 VA: 0x3823D30
	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x3823D70 Offset: 0x3823E71 VA: 0x3823D70
	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x3823DD0 Offset: 0x3823ED1 VA: 0x3823DD0
	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x3823DE0 Offset: 0x3823EE1 VA: 0x3823DE0
	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }
}

