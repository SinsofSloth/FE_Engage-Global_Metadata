// Namespace: MoonSharp.Interpreter.Interop
public class ValueTypeDefaultCtorMemberDescriptor : IOverloadableMemberDescriptor, IMemberDescriptor, IWireableDescriptor // TypeDefIndex: 6120
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE8C0 Offset: 0xE9C1 VA: 0xE8C0
	private string <Name>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xE8D0 Offset: 0xE9D1 VA: 0xE8D0
	private Type <ValueTypeDefaultCtor>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE8E0 Offset: 0xE9E1 VA: 0xE8E0
	private ParameterDescriptor[] <Parameters>k__BackingField; // 0x20

	// Properties
	public bool IsStatic { get; }
	public string Name { get; set; }
	public Type ValueTypeDefaultCtor { get; set; }
	public ParameterDescriptor[] Parameters { get; set; }
	public Type ExtensionMethodType { get; }
	public Type VarArgsArrayType { get; }
	public Type VarArgsElementType { get; }
	public string SortDiscriminant { get; }
	public MemberDescriptorAccess MemberAccess { get; }

	// Methods

	// RVA: 0x33538F0 Offset: 0x33539F1 VA: 0x33538F0 Slot: 10
	public bool get_IsStatic() { }

	[CompilerGeneratedAttribute] // RVA: 0x109E0 Offset: 0x10AE1 VA: 0x109E0
	// RVA: 0x3353900 Offset: 0x3353A01 VA: 0x3353900 Slot: 11
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x109F0 Offset: 0x10AF1 VA: 0x109F0
	// RVA: 0x3353910 Offset: 0x3353A11 VA: 0x3353910
	private void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10A00 Offset: 0x10B01 VA: 0x10A00
	// RVA: 0x3353920 Offset: 0x3353A21 VA: 0x3353920
	public Type get_ValueTypeDefaultCtor() { }

	[CompilerGeneratedAttribute] // RVA: 0x10A10 Offset: 0x10B11 VA: 0x10A10
	// RVA: 0x3353930 Offset: 0x3353A31 VA: 0x3353930
	private void set_ValueTypeDefaultCtor(Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x10A20 Offset: 0x10B21 VA: 0x10A20
	// RVA: 0x3353940 Offset: 0x3353A41 VA: 0x3353940 Slot: 6
	public ParameterDescriptor[] get_Parameters() { }

	[CompilerGeneratedAttribute] // RVA: 0x10A30 Offset: 0x10B31 VA: 0x10A30
	// RVA: 0x3353950 Offset: 0x3353A51 VA: 0x3353950
	private void set_Parameters(ParameterDescriptor[] value) { }

	// RVA: 0x3353960 Offset: 0x3353A61 VA: 0x3353960 Slot: 5
	public Type get_ExtensionMethodType() { }

	// RVA: 0x3353970 Offset: 0x3353A71 VA: 0x3353970 Slot: 7
	public Type get_VarArgsArrayType() { }

	// RVA: 0x3353980 Offset: 0x3353A81 VA: 0x3353980 Slot: 8
	public Type get_VarArgsElementType() { }

	// RVA: 0x3353990 Offset: 0x3353A91 VA: 0x3353990
	public void .ctor(Type valueType) { }

	// RVA: 0x3353B30 Offset: 0x3353C31 VA: 0x3353B30 Slot: 4
	public DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args) { }

	// RVA: 0x3353B80 Offset: 0x3353C81 VA: 0x3353B80 Slot: 9
	public string get_SortDiscriminant() { }

	// RVA: 0x3353BD0 Offset: 0x3353CD1 VA: 0x3353BD0 Slot: 12
	public MemberDescriptorAccess get_MemberAccess() { }

	// RVA: 0x3353BE0 Offset: 0x3353CE1 VA: 0x3353BE0 Slot: 13
	public DynValue GetValue(Script script, object obj) { }

	// RVA: 0x3353C30 Offset: 0x3353D31 VA: 0x3353C30 Slot: 14
	public void SetValue(Script script, object obj, DynValue value) { }

	// RVA: 0x3353C40 Offset: 0x3353D41 VA: 0x3353C40 Slot: 15
	public void PrepareForWiring(Table t) { }
}

