// Namespace: App
public class StructProperty // TypeDefIndex: 13970
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29CCF0 Offset: 0x29CDF1 VA: 0x29CCF0
	private StructProperty.Kind <kind>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29CD00 Offset: 0x29CE01 VA: 0x29CD00
	private PropertyInfo <property>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x29CD10 Offset: 0x29CE11 VA: 0x29CD10
	private PropertyInfo <objProperty>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x29CD20 Offset: 0x29CE21 VA: 0x29CD20
	private bool <isStruct>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x29CD30 Offset: 0x29CE31 VA: 0x29CD30
	private bool <isSetter>k__BackingField; // 0x29
	[CompilerGeneratedAttribute] // RVA: 0x29CD40 Offset: 0x29CE41 VA: 0x29CD40
	private object <setter>k__BackingField; // 0x30

	// Properties
	public StructProperty.Kind kind { get; set; }
	public PropertyInfo property { get; set; }
	public PropertyInfo objProperty { get; set; }
	public bool isStruct { get; set; }
	public bool isSetter { get; set; }
	public object setter { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CDB00 Offset: 0x2CDC01 VA: 0x2CDB00
	// RVA: 0x2925C10 Offset: 0x2925D11 VA: 0x2925C10
	public StructProperty.Kind get_kind() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDB10 Offset: 0x2CDC11 VA: 0x2CDB10
	// RVA: 0x2925C20 Offset: 0x2925D21 VA: 0x2925C20
	private void set_kind(StructProperty.Kind value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDB20 Offset: 0x2CDC21 VA: 0x2CDB20
	// RVA: 0x2925C30 Offset: 0x2925D31 VA: 0x2925C30
	public PropertyInfo get_property() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDB30 Offset: 0x2CDC31 VA: 0x2CDB30
	// RVA: 0x2925C40 Offset: 0x2925D41 VA: 0x2925C40
	private void set_property(PropertyInfo value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDB40 Offset: 0x2CDC41 VA: 0x2CDB40
	// RVA: 0x2925C50 Offset: 0x2925D51 VA: 0x2925C50
	public PropertyInfo get_objProperty() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDB50 Offset: 0x2CDC51 VA: 0x2CDB50
	// RVA: 0x2925C60 Offset: 0x2925D61 VA: 0x2925C60
	private void set_objProperty(PropertyInfo value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDB60 Offset: 0x2CDC61 VA: 0x2CDB60
	// RVA: 0x2925C70 Offset: 0x2925D71 VA: 0x2925C70
	public bool get_isStruct() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDB70 Offset: 0x2CDC71 VA: 0x2CDB70
	// RVA: 0x2925C80 Offset: 0x2925D81 VA: 0x2925C80
	private void set_isStruct(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDB80 Offset: 0x2CDC81 VA: 0x2CDB80
	// RVA: 0x2925C90 Offset: 0x2925D91 VA: 0x2925C90
	public bool get_isSetter() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDB90 Offset: 0x2CDC91 VA: 0x2CDB90
	// RVA: 0x2925CA0 Offset: 0x2925DA1 VA: 0x2925CA0
	private void set_isSetter(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDBA0 Offset: 0x2CDCA1 VA: 0x2CDBA0
	// RVA: 0x2925CB0 Offset: 0x2925DB1 VA: 0x2925CB0
	public object get_setter() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CDBB0 Offset: 0x2CDCB1 VA: 0x2CDBB0
	// RVA: 0x2925CC0 Offset: 0x2925DC1 VA: 0x2925CC0
	private void set_setter(object value) { }

	// RVA: 0x2925CD0 Offset: 0x2925DD1 VA: 0x2925CD0
	public bool SetObjProperty(PropertyInfo info) { }

	// RVA: 0x2925D30 Offset: 0x2925E31 VA: 0x2925D30
	public bool SetProperty(PropertyInfo info) { }

	// RVA: -1 Offset: -1
	public bool SetKind<T>(StructProperty.Kind kind) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2021350 Offset: 0x2021451 VA: 0x2021350
	|-StructProperty.SetKind<object>
	*/

	// RVA: -1 Offset: -1
	public void SetValue<T, TProp>(object obj, TProp value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2021360 Offset: 0x2021461 VA: 0x2021360
	|-StructProperty.SetValue<object, bool>
	|
	|-RVA: 0x2021640 Offset: 0x2021741 VA: 0x2021640
	|-StructProperty.SetValue<object, byte>
	|
	|-RVA: 0x2021910 Offset: 0x2021A11 VA: 0x2021910
	|-StructProperty.SetValue<object, short>
	|
	|-RVA: 0x2021BE0 Offset: 0x2021CE1 VA: 0x2021BE0
	|-StructProperty.SetValue<object, int>
	|
	|-RVA: 0x2021EB0 Offset: 0x2021FB1 VA: 0x2021EB0
	|-StructProperty.SetValue<object, long>
	|
	|-RVA: 0x2022180 Offset: 0x2022281 VA: 0x2022180
	|-StructProperty.SetValue<object, object>
	|
	|-RVA: 0x2022420 Offset: 0x2022521 VA: 0x2022420
	|-StructProperty.SetValue<object, sbyte>
	|
	|-RVA: 0x20226F0 Offset: 0x20227F1 VA: 0x20226F0
	|-StructProperty.SetValue<object, float>
	|
	|-RVA: 0x20229C0 Offset: 0x2022AC1 VA: 0x20229C0
	|-StructProperty.SetValue<object, ushort>
	|
	|-RVA: 0x2022C90 Offset: 0x2022D91 VA: 0x2022C90
	|-StructProperty.SetValue<object, uint>
	|
	|-RVA: 0x2022F60 Offset: 0x2023061 VA: 0x2022F60
	|-StructProperty.SetValue<object, ulong>
	*/

	// RVA: 0x2925D60 Offset: 0x2925E61 VA: 0x2925D60
	public void SetValue(object obj, object value) { }

	// RVA: 0x2925D80 Offset: 0x2925E81 VA: 0x2925D80
	public static StructProperty.Kind GetKind(string name) { }

	// RVA: 0x2926630 Offset: 0x2926731 VA: 0x2926630
	public static bool CheckFlagKind(string kind) { }

	// RVA: 0x2926650 Offset: 0x2926751 VA: 0x2926650
	public static bool CheckReplaceKind(string kind) { }

	// RVA: 0x2926730 Offset: 0x2926831 VA: 0x2926730
	public static string ReplaceKind(string kind) { }

	// RVA: 0x2926850 Offset: 0x2926951 VA: 0x2926850
	public static bool CheckIntFloatKind(string kind) { }

	// RVA: 0x29268A0 Offset: 0x29269A1 VA: 0x29268A0
	public static bool CheckArrayKind(string kind) { }

	// RVA: 0x29268F0 Offset: 0x29269F1 VA: 0x29268F0
	public void .ctor() { }
}

