// Namespace: System.Reflection
[Serializable]
internal class MonoProperty : RuntimePropertyInfo // TypeDefIndex: 593
{
	// Fields
	internal IntPtr klass; // 0x10
	internal IntPtr prop; // 0x18
	private MonoPropertyInfo info; // 0x20
	private PInfo cached; // 0x50
	private MonoProperty.GetterAdapter cached_getter; // 0x58

	// Properties
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x34FB880 Offset: 0x34FB981 VA: 0x34FB880
	private void CachePropertyInfo(PInfo flags) { }

	// RVA: 0x34FB8E0 Offset: 0x34FB9E1 VA: 0x34FB8E0 Slot: 16
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x34FB930 Offset: 0x34FBA31 VA: 0x34FB930 Slot: 17
	public override bool get_CanRead() { }

	// RVA: 0x34FB9A0 Offset: 0x34FBAA1 VA: 0x34FB9A0 Slot: 18
	public override bool get_CanWrite() { }

	// RVA: 0x34FBA10 Offset: 0x34FBB11 VA: 0x34FBA10 Slot: 20
	public override Type get_PropertyType() { }

	// RVA: 0x34FBB00 Offset: 0x34FBC01 VA: 0x34FBB00 Slot: 9
	public override Type get_ReflectedType() { }

	// RVA: 0x34FBB50 Offset: 0x34FBC51 VA: 0x34FBB50 Slot: 8
	public override Type get_DeclaringType() { }

	// RVA: 0x34FBBA0 Offset: 0x34FBCA1 VA: 0x34FBBA0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x34FBBF0 Offset: 0x34FBCF1 VA: 0x34FBBF0 Slot: 21
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x34FBE10 Offset: 0x34FBF11 VA: 0x34FBE10 Slot: 22
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x34FBEE0 Offset: 0x34FBFE1 VA: 0x34FBEE0 Slot: 23
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x34FC0F0 Offset: 0x34FC1F1 VA: 0x34FC0F0 Slot: 25
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x34FC1C0 Offset: 0x34FC2C1 VA: 0x34FC1C0 Slot: 32
	public override object GetConstantValue() { }

	// RVA: 0x34FC1E0 Offset: 0x34FC2E1 VA: 0x34FC1E0 Slot: 33
	public override object GetRawConstantValue() { }

	// RVA: 0x34FC1F0 Offset: 0x34FC2F1 VA: 0x34FC1F0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x34FC270 Offset: 0x34FC371 VA: 0x34FC270 Slot: 10
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x34FC2E0 Offset: 0x34FC3E1 VA: 0x34FC2E0 Slot: 11
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	private static object GetterAdapterFrame<T, R>(MonoProperty.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2966EC0 Offset: 0x2966FC1 VA: 0x2966EC0
	|-MonoProperty.GetterAdapterFrame<object, object>
	*/

	// RVA: -1 Offset: -1
	private static object StaticGetterAdapterFrame<R>(MonoProperty.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2966F50 Offset: 0x2967051 VA: 0x2966F50
	|-MonoProperty.StaticGetterAdapterFrame<object>
	*/

	// RVA: 0x34FC360 Offset: 0x34FC461 VA: 0x34FC360
	private static MonoProperty.GetterAdapter CreateGetterDelegate(MethodInfo method) { }

	// RVA: 0x34FC6B0 Offset: 0x34FC7B1 VA: 0x34FC6B0 Slot: 26
	public override object GetValue(object obj, object[] index) { }

	// RVA: 0x34FC6D0 Offset: 0x34FC7D1 VA: 0x34FC6D0 Slot: 27
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x34FC8E0 Offset: 0x34FC9E1 VA: 0x34FC8E0 Slot: 29
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x34FCB00 Offset: 0x34FCC01 VA: 0x34FCB00 Slot: 30
	public override Type[] GetOptionalCustomModifiers() { }

	// RVA: 0x34FCBB0 Offset: 0x34FCCB1 VA: 0x34FCBB0 Slot: 31
	public override Type[] GetRequiredCustomModifiers() { }

	// RVA: 0x34FCC50 Offset: 0x34FCD51 VA: 0x34FCC50 Slot: 13
	public override IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x34FCC60 Offset: 0x34FCD61 VA: 0x34FCC60
	public void .ctor() { }
}

