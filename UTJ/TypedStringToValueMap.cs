// Namespace: UTJ
[DefaultMemberAttribute] // RVA: 0x5B390 Offset: 0x5B491 VA: 0x5B390
public class TypedStringToValueMap // TypeDefIndex: 6416
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x5BB70 Offset: 0x5BC71 VA: 0x5BB70
	private Type <Type>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x5BB80 Offset: 0x5BC81 VA: 0x5BB80
	private object <DefaultValue>k__BackingField; // 0x18
	private Dictionary<string, object> map; // 0x20

	// Properties
	public Type Type { get; set; }
	public object DefaultValue { get; set; }
	public object Item { get; }

	// Methods

	// RVA: 0x3A78040 Offset: 0x3A78141 VA: 0x3A78040
	public void .ctor(Type inputType, Dictionary<string, object> inputMap, object inputDefaultValue) { }

	// RVA: -1 Offset: -1
	public static TypedStringToValueMap Create<T>(Dictionary<string, T> inputMap, T inputDefaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2028BC0 Offset: 0x2028CC1 VA: 0x2028BC0
	|-TypedStringToValueMap.Create<object>
	*/

	// RVA: -1 Offset: -1
	public static TypedStringToValueMap Create<T>(Dictionary<string, T> inputMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20287B0 Offset: 0x20288B1 VA: 0x20287B0
	|-TypedStringToValueMap.Create<object>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x5C310 Offset: 0x5C411 VA: 0x5C310
	// RVA: 0x3A780B0 Offset: 0x3A781B1 VA: 0x3A780B0
	public Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C320 Offset: 0x5C421 VA: 0x5C320
	// RVA: 0x3A780C0 Offset: 0x3A781C1 VA: 0x3A780C0
	private void set_Type(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x5C330 Offset: 0x5C431 VA: 0x5C330
	// RVA: 0x3A780D0 Offset: 0x3A781D1 VA: 0x3A780D0
	public object get_DefaultValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x5C340 Offset: 0x5C441 VA: 0x5C340
	// RVA: 0x3A780E0 Offset: 0x3A781E1 VA: 0x3A780E0
	private void set_DefaultValue(object value) { }

	// RVA: 0x3A780F0 Offset: 0x3A781F1 VA: 0x3A780F0
	public object get_Item(string key) { }

	// RVA: 0x3A781D0 Offset: 0x3A782D1 VA: 0x3A781D0
	public string GetKey(object value) { }
}

