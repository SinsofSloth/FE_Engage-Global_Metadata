// Namespace: MoonSharp.Interpreter.Interop.BasicDescriptors
public sealed class ParameterDescriptor : IWireableDescriptor // TypeDefIndex: 6169
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xEA20 Offset: 0xEB21 VA: 0xEA20
	private string <Name>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xEA30 Offset: 0xEB31 VA: 0xEA30
	private Type <Type>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xEA40 Offset: 0xEB41 VA: 0xEA40
	private bool <HasDefaultValue>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xEA50 Offset: 0xEB51 VA: 0xEA50
	private object <DefaultValue>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xEA60 Offset: 0xEB61 VA: 0xEA60
	private bool <IsOut>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0xEA70 Offset: 0xEB71 VA: 0xEA70
	private bool <IsRef>k__BackingField; // 0x31
	[CompilerGeneratedAttribute] // RVA: 0xEA80 Offset: 0xEB81 VA: 0xEA80
	private bool <IsVarArgs>k__BackingField; // 0x32
	private Type m_OriginalType; // 0x38

	// Properties
	public string Name { get; set; }
	public Type Type { get; set; }
	public bool HasDefaultValue { get; set; }
	public object DefaultValue { get; set; }
	public bool IsOut { get; set; }
	public bool IsRef { get; set; }
	public bool IsVarArgs { get; set; }
	public bool HasBeenRestricted { get; }
	public Type OriginalType { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x10D30 Offset: 0x10E31 VA: 0x10D30
	// RVA: 0x2BC7A20 Offset: 0x2BC7B21 VA: 0x2BC7A20
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x10D40 Offset: 0x10E41 VA: 0x10D40
	// RVA: 0x2BC7A30 Offset: 0x2BC7B31 VA: 0x2BC7A30
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10D50 Offset: 0x10E51 VA: 0x10D50
	// RVA: 0x2BC7A40 Offset: 0x2BC7B41 VA: 0x2BC7A40
	public Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x10D60 Offset: 0x10E61 VA: 0x10D60
	// RVA: 0x2BC7A50 Offset: 0x2BC7B51 VA: 0x2BC7A50
	private void set_Type(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10D70 Offset: 0x10E71 VA: 0x10D70
	// RVA: 0x2BC7A60 Offset: 0x2BC7B61 VA: 0x2BC7A60
	public bool get_HasDefaultValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x10D80 Offset: 0x10E81 VA: 0x10D80
	// RVA: 0x2BC7A70 Offset: 0x2BC7B71 VA: 0x2BC7A70
	private void set_HasDefaultValue(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10D90 Offset: 0x10E91 VA: 0x10D90
	// RVA: 0x2BC7A80 Offset: 0x2BC7B81 VA: 0x2BC7A80
	public object get_DefaultValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x10DA0 Offset: 0x10EA1 VA: 0x10DA0
	// RVA: 0x2BC7A90 Offset: 0x2BC7B91 VA: 0x2BC7A90
	private void set_DefaultValue(object value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10DB0 Offset: 0x10EB1 VA: 0x10DB0
	// RVA: 0x2BC7AA0 Offset: 0x2BC7BA1 VA: 0x2BC7AA0
	public bool get_IsOut() { }

	[CompilerGeneratedAttribute] // RVA: 0x10DC0 Offset: 0x10EC1 VA: 0x10DC0
	// RVA: 0x2BC7AB0 Offset: 0x2BC7BB1 VA: 0x2BC7AB0
	private void set_IsOut(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10DD0 Offset: 0x10ED1 VA: 0x10DD0
	// RVA: 0x2BC7AC0 Offset: 0x2BC7BC1 VA: 0x2BC7AC0
	public bool get_IsRef() { }

	[CompilerGeneratedAttribute] // RVA: 0x10DE0 Offset: 0x10EE1 VA: 0x10DE0
	// RVA: 0x2BC7AD0 Offset: 0x2BC7BD1 VA: 0x2BC7AD0
	private void set_IsRef(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10DF0 Offset: 0x10EF1 VA: 0x10DF0
	// RVA: 0x2BC7AE0 Offset: 0x2BC7BE1 VA: 0x2BC7AE0
	public bool get_IsVarArgs() { }

	[CompilerGeneratedAttribute] // RVA: 0x10E00 Offset: 0x10F01 VA: 0x10E00
	// RVA: 0x2BC7AF0 Offset: 0x2BC7BF1 VA: 0x2BC7AF0
	private void set_IsVarArgs(bool value) { }

	// RVA: 0x2BC7B00 Offset: 0x2BC7C01 VA: 0x2BC7B00
	public bool get_HasBeenRestricted() { }

	// RVA: 0x2BB7460 Offset: 0x2BB7561 VA: 0x2BB7460
	public Type get_OriginalType() { }

	// RVA: 0x2BB66F0 Offset: 0x2BB67F1 VA: 0x2BB66F0
	public void .ctor(string name, Type type, bool hasDefaultValue = False, object defaultValue, bool isOut = False, bool isRef = False, bool isVarArgs = False) { }

	// RVA: 0x2BC7B80 Offset: 0x2BC7C81 VA: 0x2BC7B80
	public void .ctor(string name, Type type, bool hasDefaultValue, object defaultValue, bool isOut, bool isRef, bool isVarArgs, Type typeRestriction) { }

	// RVA: 0x2BC7E50 Offset: 0x2BC7F51 VA: 0x2BC7E50
	public void .ctor(ParameterInfo pi) { }

	// RVA: 0x2BC80B0 Offset: 0x2BC81B1 VA: 0x2BC80B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2BC7CC0 Offset: 0x2BC7DC1 VA: 0x2BC7CC0
	public void RestrictType(Type type) { }

	// RVA: 0x2BB79C0 Offset: 0x2BB7AC1 VA: 0x2BB79C0 Slot: 4
	public void PrepareForWiring(Table table) { }
}

