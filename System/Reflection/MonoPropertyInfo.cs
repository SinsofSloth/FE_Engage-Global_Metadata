// Namespace: System.Reflection
internal struct MonoPropertyInfo // TypeDefIndex: 587
{
	// Fields
	public Type parent; // 0x0
	public Type declaring_type; // 0x8
	public string name; // 0x10
	public MethodInfo get_method; // 0x18
	public MethodInfo set_method; // 0x20
	public PropertyAttributes attrs; // 0x28

	// Methods

	// RVA: 0x34FB8D0 Offset: 0x34FB9D1 VA: 0x34FB8D0
	internal static void get_property_info(MonoProperty prop, ref MonoPropertyInfo info, PInfo req_info) { }

	// RVA: 0x34FCBA0 Offset: 0x34FCCA1 VA: 0x34FCBA0
	internal static Type[] GetTypeModifiers(MonoProperty prop, bool optional) { }

	// RVA: 0x34FC1D0 Offset: 0x34FC2D1 VA: 0x34FC1D0
	internal static object get_default_value(MonoProperty prop) { }
}

