// Namespace: UnityEngine.Bindings
[VisibleToOtherModulesAttribute] // RVA: 0x5F2E0 Offset: 0x5F3E1 VA: 0x5F2E0
[AttributeUsageAttribute] // RVA: 0x5F2E0 Offset: 0x5F3E1 VA: 0x5F2E0
internal class NativeTypeAttribute : Attribute // TypeDefIndex: 3311
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x5F9E0 Offset: 0x5FAE1 VA: 0x5F9E0
	[CompilerGeneratedAttribute] // RVA: 0x5F9E0 Offset: 0x5FAE1 VA: 0x5F9E0
	private string <Header>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x5FA20 Offset: 0x5FB21 VA: 0x5FA20
	[DebuggerBrowsableAttribute] // RVA: 0x5FA20 Offset: 0x5FB21 VA: 0x5FA20
	private string <IntermediateScriptingStructName>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x5FA60 Offset: 0x5FB61 VA: 0x5FA60
	[DebuggerBrowsableAttribute] // RVA: 0x5FA60 Offset: 0x5FB61 VA: 0x5FA60
	private CodegenOptions <CodegenOptions>k__BackingField; // 0x20

	// Properties
	public string Header { set; }
	public string IntermediateScriptingStructName { set; }
	public CodegenOptions CodegenOptions { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x5FDC0 Offset: 0x5FEC1 VA: 0x5FDC0
	// RVA: 0x1C61890 Offset: 0x1C61991 VA: 0x1C61890 Slot: 4
	public void set_Header(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x5FDD0 Offset: 0x5FED1 VA: 0x5FDD0
	// RVA: 0x1C618A0 Offset: 0x1C619A1 VA: 0x1C618A0
	public void set_IntermediateScriptingStructName(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x5FDE0 Offset: 0x5FEE1 VA: 0x5FDE0
	// RVA: 0x1C618B0 Offset: 0x1C619B1 VA: 0x1C618B0 Slot: 5
	public void set_CodegenOptions(CodegenOptions value) { }

	// RVA: 0x1C618C0 Offset: 0x1C619C1 VA: 0x1C618C0
	public void .ctor() { }

	// RVA: 0x1C618F0 Offset: 0x1C619F1 VA: 0x1C618F0
	public void .ctor(CodegenOptions codegenOptions) { }

	// RVA: 0x1C61920 Offset: 0x1C61A21 VA: 0x1C61920
	public void .ctor(string header) { }

	// RVA: 0x1C61A40 Offset: 0x1C61B41 VA: 0x1C61A40
	public void .ctor(CodegenOptions codegenOptions, string intermediateStructName) { }
}

