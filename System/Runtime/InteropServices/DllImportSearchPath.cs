// Namespace: System.Runtime.InteropServices
[FlagsAttribute] // RVA: 0x475F10 Offset: 0x476011 VA: 0x475F10
public enum DllImportSearchPath // TypeDefIndex: 1299
{
	// Fields
	public int value__; // 0x0
	public const DllImportSearchPath UseDllDirectoryForDependencies = 256;
	public const DllImportSearchPath ApplicationDirectory = 512;
	public const DllImportSearchPath UserDirectories = 1024;
	public const DllImportSearchPath System32 = 2048;
	public const DllImportSearchPath SafeDirectories = 4096;
	public const DllImportSearchPath AssemblyDirectory = 2;
	public const DllImportSearchPath LegacyBehavior = 0;
}

