// Namespace: MoonSharp.Interpreter.Loaders
public abstract class ScriptLoaderBase : IScriptLoader // TypeDefIndex: 6055
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE6A0 Offset: 0xE7A1 VA: 0xE6A0
	private string[] <ModulePaths>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xE6B0 Offset: 0xE7B1 VA: 0xE6B0
	private bool <IgnoreLuaPathGlobal>k__BackingField; // 0x18

	// Properties
	public string[] ModulePaths { get; set; }
	public bool IgnoreLuaPathGlobal { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ScriptFileExists(string name);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object LoadFile(string file, Table globalContext);

	// RVA: 0x301ACC0 Offset: 0x301ADC1 VA: 0x301ACC0 Slot: 9
	protected virtual string ResolveModuleName(string modname, string[] paths) { }

	// RVA: 0x30154F0 Offset: 0x30155F1 VA: 0x30154F0 Slot: 10
	public virtual string ResolveModuleName(string modname, Table globalContext) { }

	[CompilerGeneratedAttribute] // RVA: 0x10310 Offset: 0x10411 VA: 0x10310
	// RVA: 0x301ADC0 Offset: 0x301AEC1 VA: 0x301ADC0
	public string[] get_ModulePaths() { }

	[CompilerGeneratedAttribute] // RVA: 0x10320 Offset: 0x10421 VA: 0x10320
	// RVA: 0x301ADD0 Offset: 0x301AED1 VA: 0x301ADD0
	public void set_ModulePaths(string[] value) { }

	// RVA: 0x30150B0 Offset: 0x30151B1 VA: 0x30150B0
	public static string[] UnpackStringPaths(string str) { }

	// RVA: 0x301ADE0 Offset: 0x301AEE1 VA: 0x301ADE0
	public static string[] GetDefaultEnvironmentPaths() { }

	// RVA: 0x301B080 Offset: 0x301B181 VA: 0x301B080 Slot: 11
	public virtual string ResolveFileName(string filename, Table globalContext) { }

	[CompilerGeneratedAttribute] // RVA: 0x10330 Offset: 0x10431 VA: 0x10330
	// RVA: 0x301B090 Offset: 0x301B191 VA: 0x301B090
	public bool get_IgnoreLuaPathGlobal() { }

	[CompilerGeneratedAttribute] // RVA: 0x10340 Offset: 0x10441 VA: 0x10340
	// RVA: 0x301B0A0 Offset: 0x301B1A1 VA: 0x301B0A0
	public void set_IgnoreLuaPathGlobal(bool value) { }

	// RVA: 0x301B0B0 Offset: 0x301B1B1 VA: 0x301B0B0
	protected void .ctor() { }
}

