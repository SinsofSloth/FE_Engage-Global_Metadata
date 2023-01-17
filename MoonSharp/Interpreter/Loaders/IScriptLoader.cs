// Namespace: MoonSharp.Interpreter.Loaders
public interface IScriptLoader // TypeDefIndex: 6052
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object LoadFile(string file, Table globalContext);

	[ObsoleteAttribute] // RVA: 0x102D0 Offset: 0x103D1 VA: 0x102D0
	// RVA: -1 Offset: -1 Slot: 1
	public abstract string ResolveFileName(string filename, Table globalContext);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string ResolveModuleName(string modname, Table globalContext);
}

