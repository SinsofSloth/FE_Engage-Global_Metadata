// Namespace: nn.fs
public static class Rom // TypeDefIndex: 14746
{
	// Properties
	public static ErrorRange ResultRomHostFileSystemCorrupted { get; }
	public static ErrorRange ResultRomHostEntryCorrupted { get; }
	public static ErrorRange ResultRomHostFileDataCorrupted { get; }
	public static ErrorRange ResultRomHostFileCorrupted { get; }
	public static ErrorRange ResultInvalidRomHostHandle { get; }

	// Methods

	// RVA: 0x205B8F0 Offset: 0x205B9F1 VA: 0x205B8F0
	public static ErrorRange get_ResultRomHostFileSystemCorrupted() { }

	// RVA: 0x205B930 Offset: 0x205BA31 VA: 0x205B930
	public static ErrorRange get_ResultRomHostEntryCorrupted() { }

	// RVA: 0x205B970 Offset: 0x205BA71 VA: 0x205B970
	public static ErrorRange get_ResultRomHostFileDataCorrupted() { }

	// RVA: 0x205B9B0 Offset: 0x205BAB1 VA: 0x205B9B0
	public static ErrorRange get_ResultRomHostFileCorrupted() { }

	// RVA: 0x205B9F0 Offset: 0x205BAF1 VA: 0x205B9F0
	public static ErrorRange get_ResultInvalidRomHostHandle() { }

	// RVA: 0x205BA30 Offset: 0x205BB31 VA: 0x205BA30
	public static extern Result QueryMountRomCacheSize(ref long pOutValue) { }

	// RVA: 0x205BA50 Offset: 0x205BB51 VA: 0x205BA50
	public static extern Result MountRom(string name, byte[] pFileSystemCacheBuffer, long fileSystemCacheBufferSize) { }

	// RVA: 0x205BAB0 Offset: 0x205BBB1 VA: 0x205BAB0
	public static bool CanMountRomForDebug() { }
}

