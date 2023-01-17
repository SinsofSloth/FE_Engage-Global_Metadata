// Namespace: MoonSharp.Interpreter.Loaders
internal class InvalidScriptLoader : IScriptLoader // TypeDefIndex: 6053
{
	// Fields
	private string m_Error; // 0x10

	// Methods

	// RVA: 0x33190D0 Offset: 0x33191D1 VA: 0x33190D0
	internal void .ctor(string frameworkname) { }

	// RVA: 0x3319150 Offset: 0x3319251 VA: 0x3319150 Slot: 4
	public object LoadFile(string file, Table globalContext) { }

	// RVA: 0x33191A0 Offset: 0x33192A1 VA: 0x33191A0 Slot: 5
	public string ResolveFileName(string filename, Table globalContext) { }

	// RVA: 0x33191B0 Offset: 0x33192B1 VA: 0x33191B0 Slot: 6
	public string ResolveModuleName(string modname, Table globalContext) { }
}

