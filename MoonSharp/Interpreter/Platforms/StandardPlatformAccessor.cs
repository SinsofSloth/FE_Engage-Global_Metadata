// Namespace: MoonSharp.Interpreter.Platforms
public class StandardPlatformAccessor : PlatformAccessorBase // TypeDefIndex: 6049
{
	// Methods

	// RVA: 0x3024790 Offset: 0x3024891 VA: 0x3024790
	public static FileAccess ParseFileAccess(string mode) { }

	// RVA: 0x30248C0 Offset: 0x30249C1 VA: 0x30248C0
	public static FileMode ParseFileMode(string mode) { }

	// RVA: 0x3024A00 Offset: 0x3024B01 VA: 0x3024A00 Slot: 22
	public override Stream IO_OpenFile(Script script, string filename, Encoding encoding, string mode) { }

	// RVA: 0x3024A90 Offset: 0x3024B91 VA: 0x3024A90 Slot: 31
	public override string GetEnvironmentVariable(string envvarname) { }

	// RVA: 0x3024AA0 Offset: 0x3024BA1 VA: 0x3024AA0 Slot: 23
	public override Stream IO_GetStandardStream(StandardFileType type) { }

	// RVA: 0x3024BF0 Offset: 0x3024CF1 VA: 0x3024BF0 Slot: 19
	public override void DefaultPrint(string content) { }

	// RVA: 0x3024C60 Offset: 0x3024D61 VA: 0x3024C60 Slot: 24
	public override string IO_OS_GetTempFilename() { }

	// RVA: 0x3024CD0 Offset: 0x3024DD1 VA: 0x3024CD0 Slot: 25
	public override void OS_ExitFast(int exitCode) { }

	// RVA: 0x3024CE0 Offset: 0x3024DE1 VA: 0x3024CE0 Slot: 26
	public override bool OS_FileExists(string file) { }

	// RVA: 0x3024CF0 Offset: 0x3024DF1 VA: 0x3024CF0 Slot: 27
	public override void OS_FileDelete(string file) { }

	// RVA: 0x3024D00 Offset: 0x3024E01 VA: 0x3024D00 Slot: 28
	public override void OS_FileMove(string src, string dst) { }

	// RVA: 0x3024D10 Offset: 0x3024E11 VA: 0x3024D10 Slot: 29
	public override int OS_Execute(string cmdline) { }

	// RVA: 0x3024DE0 Offset: 0x3024EE1 VA: 0x3024DE0 Slot: 30
	public override CoreModules FilterSupportedCoreModules(CoreModules module) { }

	// RVA: 0x3024DF0 Offset: 0x3024EF1 VA: 0x3024DF0 Slot: 18
	public override string GetPlatformNamePrefix() { }

	// RVA: 0x3024E40 Offset: 0x3024F41 VA: 0x3024E40
	public void .ctor() { }
}

