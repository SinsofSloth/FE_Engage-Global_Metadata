// Namespace: MoonSharp.Interpreter
[FlagsAttribute] // RVA: 0xD5D0 Offset: 0xD6D1 VA: 0xD5D0
public enum CoreModules // TypeDefIndex: 5976
{
	// Fields
	public int value__; // 0x0
	public const CoreModules None = 0;
	public const CoreModules Basic = 64;
	public const CoreModules GlobalConsts = 1;
	public const CoreModules TableIterators = 2;
	public const CoreModules Metatables = 4;
	public const CoreModules String = 8;
	public const CoreModules LoadMethods = 16;
	public const CoreModules Table = 32;
	public const CoreModules ErrorHandling = 128;
	public const CoreModules Math = 256;
	public const CoreModules Coroutine = 512;
	public const CoreModules Bit32 = 1024;
	public const CoreModules OS_Time = 2048;
	public const CoreModules OS_System = 4096;
	public const CoreModules IO = 8192;
	public const CoreModules Debug = 16384;
	public const CoreModules Dynamic = 32768;
	public const CoreModules Json = 65536;
	public const CoreModules Preset_HardSandbox = 1387;
	public const CoreModules Preset_SoftSandbox = 102383;
	public const CoreModules Preset_Default = 114687;
	public const CoreModules Preset_Complete = 131071;
}

// Namespace: MoonSharp.Interpreter
[ExtensionAttribute] // RVA: 0xD5E0 Offset: 0xD6E1 VA: 0xD5E0
internal static class CoreModules_ExtensionMethods // TypeDefIndex: 5977
{
	// Methods

	[ExtensionAttribute] // RVA: 0xFC70 Offset: 0xFD71 VA: 0xFC70
	// RVA: 0x30F99E0 Offset: 0x30F9AE1 VA: 0x30F99E0
	public static bool Has(CoreModules val, CoreModules flag) { }
}

