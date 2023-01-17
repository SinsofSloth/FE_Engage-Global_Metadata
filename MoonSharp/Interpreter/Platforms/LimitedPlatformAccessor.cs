// Namespace: MoonSharp.Interpreter.Platforms
public class LimitedPlatformAccessor : PlatformAccessorBase // TypeDefIndex: 6044
{
	// Methods

	// RVA: 0x2BAC7E0 Offset: 0x2BAC8E1 VA: 0x2BAC7E0 Slot: 31
	public override string GetEnvironmentVariable(string envvarname) { }

	// RVA: 0x2BAC7F0 Offset: 0x2BAC8F1 VA: 0x2BAC7F0 Slot: 30
	public override CoreModules FilterSupportedCoreModules(CoreModules module) { }

	// RVA: 0x2BAC800 Offset: 0x2BAC901 VA: 0x2BAC800 Slot: 22
	public override Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode) { }

	// RVA: 0x2BAC860 Offset: 0x2BAC961 VA: 0x2BAC860 Slot: 23
	public override Stream IO_GetStandardStream(StandardFileType type) { }

	// RVA: 0x2BAC8C0 Offset: 0x2BAC9C1 VA: 0x2BAC8C0 Slot: 24
	public override string IO_OS_GetTempFilename() { }

	// RVA: 0x2BAC920 Offset: 0x2BACA21 VA: 0x2BAC920 Slot: 25
	public override void OS_ExitFast(int exitCode) { }

	// RVA: 0x2BAC980 Offset: 0x2BACA81 VA: 0x2BAC980 Slot: 26
	public override bool OS_FileExists(string file) { }

	// RVA: 0x2BAC9E0 Offset: 0x2BACAE1 VA: 0x2BAC9E0 Slot: 27
	public override void OS_FileDelete(string file) { }

	// RVA: 0x2BACA40 Offset: 0x2BACB41 VA: 0x2BACA40 Slot: 28
	public override void OS_FileMove(string src, string dst) { }

	// RVA: 0x2BACAA0 Offset: 0x2BACBA1 VA: 0x2BACAA0 Slot: 29
	public override int OS_Execute(string cmdline) { }

	// RVA: 0x2BACB00 Offset: 0x2BACC01 VA: 0x2BACB00 Slot: 18
	public override string GetPlatformNamePrefix() { }

	// RVA: 0x2BACB50 Offset: 0x2BACC51 VA: 0x2BACB50 Slot: 19
	public override void DefaultPrint(string content) { }

	// RVA: 0x2BACB60 Offset: 0x2BACC61 VA: 0x2BACB60
	public void .ctor() { }
}

