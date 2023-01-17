// Namespace: nn.fs
public static class Host // TypeDefIndex: 14744
{
	// Properties
	public static ErrorRange ResultSaveDataHostFileSystemCorrupted { get; }
	public static ErrorRange ResultSaveDataHostEntryCorrupted { get; }
	public static ErrorRange ResultSaveDataHostFileDataCorrupted { get; }
	public static ErrorRange ResultSaveDataHostFileCorrupted { get; }
	public static ErrorRange ResultInvalidSaveDataHostHandle { get; }
	public static ErrorRange ResultHostFileSystemCorrupted { get; }
	public static ErrorRange ResultHostEntryCorrupted { get; }
	public static ErrorRange ResultHostFileDataCorrupted { get; }
	public static ErrorRange ResultHostFileCorrupted { get; }
	public static ErrorRange ResultInvalidHostHandle { get; }

	// Methods

	// RVA: 0x2667BF0 Offset: 0x2667CF1 VA: 0x2667BF0
	public static Result MountHost(string name, string rootPath) { }

	// RVA: 0x2667C40 Offset: 0x2667D41 VA: 0x2667C40
	public static Result MountHost(string name, string rootPath, Host.MountHostOption option) { }

	// RVA: 0x2667C90 Offset: 0x2667D91 VA: 0x2667C90
	public static Result MountHostRoot() { }

	// RVA: 0x2667CE0 Offset: 0x2667DE1 VA: 0x2667CE0
	public static Result MountHostRoot(Host.MountHostOption option) { }

	// RVA: 0x2667D30 Offset: 0x2667E31 VA: 0x2667D30
	public static void UnMountHostRoot() { }

	// RVA: 0x2667D80 Offset: 0x2667E81 VA: 0x2667D80
	public static ErrorRange get_ResultSaveDataHostFileSystemCorrupted() { }

	// RVA: 0x2667DC0 Offset: 0x2667EC1 VA: 0x2667DC0
	public static ErrorRange get_ResultSaveDataHostEntryCorrupted() { }

	// RVA: 0x2667E00 Offset: 0x2667F01 VA: 0x2667E00
	public static ErrorRange get_ResultSaveDataHostFileDataCorrupted() { }

	// RVA: 0x2667E40 Offset: 0x2667F41 VA: 0x2667E40
	public static ErrorRange get_ResultSaveDataHostFileCorrupted() { }

	// RVA: 0x2667E80 Offset: 0x2667F81 VA: 0x2667E80
	public static ErrorRange get_ResultInvalidSaveDataHostHandle() { }

	// RVA: 0x2667EC0 Offset: 0x2667FC1 VA: 0x2667EC0
	public static ErrorRange get_ResultHostFileSystemCorrupted() { }

	// RVA: 0x2667F00 Offset: 0x2668001 VA: 0x2667F00
	public static ErrorRange get_ResultHostEntryCorrupted() { }

	// RVA: 0x2667F40 Offset: 0x2668041 VA: 0x2667F40
	public static ErrorRange get_ResultHostFileDataCorrupted() { }

	// RVA: 0x2667F80 Offset: 0x2668081 VA: 0x2667F80
	public static ErrorRange get_ResultHostFileCorrupted() { }

	// RVA: 0x2667FC0 Offset: 0x26680C1 VA: 0x2667FC0
	public static ErrorRange get_ResultInvalidHostHandle() { }
}

