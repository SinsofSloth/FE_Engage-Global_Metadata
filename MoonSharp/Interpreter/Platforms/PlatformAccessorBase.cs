// Namespace: MoonSharp.Interpreter.Platforms
public abstract class PlatformAccessorBase : IPlatformAccessor // TypeDefIndex: 6045
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 18
	public abstract string GetPlatformNamePrefix();

	// RVA: 0x2BC8FF0 Offset: 0x2BC90F1 VA: 0x2BC8FF0 Slot: 7
	public string GetPlatformName() { }

	// RVA: 0x2BC95C0 Offset: 0x2BC96C1 VA: 0x2BC95C0
	private string GetUnityRuntimeName() { }

	// RVA: 0x2BC9570 Offset: 0x2BC9671 VA: 0x2BC9570
	private string GetUnityPlatformName() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void DefaultPrint(string content);

	[ObsoleteAttribute] // RVA: 0x101D0 Offset: 0x102D1 VA: 0x101D0
	// RVA: 0x2BC9620 Offset: 0x2BC9721 VA: 0x2BC9620 Slot: 20
	public virtual string DefaultInput() { }

	// RVA: 0x2BC9630 Offset: 0x2BC9731 VA: 0x2BC9630 Slot: 21
	public virtual string DefaultInput(string prompt) { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract Stream IO_GetStandardStream(StandardFileType type);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract string IO_OS_GetTempFilename();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void OS_ExitFast(int exitCode);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract bool OS_FileExists(string file);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void OS_FileDelete(string file);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void OS_FileMove(string src, string dst);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int OS_Execute(string cmdline);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract CoreModules FilterSupportedCoreModules(CoreModules module);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract string GetEnvironmentVariable(string envvarname);

	// RVA: 0x2BC9640 Offset: 0x2BC9741 VA: 0x2BC9640 Slot: 32
	public virtual bool IsRunningOnAOT() { }

	// RVA: 0x2BACB70 Offset: 0x2BACC71 VA: 0x2BACB70
	protected void .ctor() { }
}

