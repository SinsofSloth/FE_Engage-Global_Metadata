// Namespace: MoonSharp.Interpreter.Platforms
public interface IPlatformAccessor // TypeDefIndex: 6043
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract CoreModules FilterSupportedCoreModules(CoreModules module);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetEnvironmentVariable(string envvarname);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsRunningOnAOT();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string GetPlatformName();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void DefaultPrint(string content);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string DefaultInput(string prompt);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Stream IO_GetStandardStream(StandardFileType type);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string IO_OS_GetTempFilename();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void OS_ExitFast(int exitCode);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool OS_FileExists(string file);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void OS_FileDelete(string file);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void OS_FileMove(string src, string dst);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int OS_Execute(string cmdline);
}

