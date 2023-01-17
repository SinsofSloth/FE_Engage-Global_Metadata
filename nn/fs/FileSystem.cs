// Namespace: nn.fs
public static class FileSystem // TypeDefIndex: 14739
{
	// Fields
	public const int MountNameLengthMax = 15;

	// Properties
	public static ErrorRange ResultPathNotFound { get; }
	public static ErrorRange ResultPathAlreadyExists { get; }
	public static ErrorRange ResultTargetLocked { get; }
	public static ErrorRange ResultDirectoryNotEmpty { get; }
	public static ErrorRange ResultDirectoryStatusChanged { get; }
	public static ErrorRange ResultUsableSpaceNotEnough { get; }
	public static ErrorRange ResultUnsupportedSdkVersion { get; }
	public static ErrorRange ResultMountNameAlreadyExists { get; }
	public static ErrorRange ResultTargetNotFound { get; }

	// Methods

	// RVA: 0x2A21570 Offset: 0x2A21671 VA: 0x2A21570
	public static extern Result GetEntryType(ref EntryType outValue, string path) { }

	// RVA: 0x2A215C0 Offset: 0x2A216C1 VA: 0x2A215C0
	public static extern Result GetFreeSpaceSize(ref long outValue, string path) { }

	// RVA: 0x2A21610 Offset: 0x2A21711 VA: 0x2A21610
	public static extern void Unmount(string name) { }

	// RVA: 0x2A21640 Offset: 0x2A21741 VA: 0x2A21640
	public static ErrorRange get_ResultPathNotFound() { }

	// RVA: 0x2A21680 Offset: 0x2A21781 VA: 0x2A21680
	public static ErrorRange get_ResultPathAlreadyExists() { }

	// RVA: 0x2A216C0 Offset: 0x2A217C1 VA: 0x2A216C0
	public static ErrorRange get_ResultTargetLocked() { }

	// RVA: 0x2A21700 Offset: 0x2A21801 VA: 0x2A21700
	public static ErrorRange get_ResultDirectoryNotEmpty() { }

	// RVA: 0x2A21740 Offset: 0x2A21841 VA: 0x2A21740
	public static ErrorRange get_ResultDirectoryStatusChanged() { }

	// RVA: 0x2A21780 Offset: 0x2A21881 VA: 0x2A21780
	public static ErrorRange get_ResultUsableSpaceNotEnough() { }

	// RVA: 0x2A217C0 Offset: 0x2A218C1 VA: 0x2A217C0
	public static ErrorRange get_ResultUnsupportedSdkVersion() { }

	// RVA: 0x2A21800 Offset: 0x2A21901 VA: 0x2A21800
	public static ErrorRange get_ResultMountNameAlreadyExists() { }

	// RVA: 0x2A21840 Offset: 0x2A21941 VA: 0x2A21840
	public static ErrorRange get_ResultTargetNotFound() { }

	// RVA: 0x2A21880 Offset: 0x2A21981 VA: 0x2A21880
	public static extern Result Commit(string name) { }

	// RVA: 0x2A218C0 Offset: 0x2A219C1 VA: 0x2A218C0
	private static extern Result Commit(string[] name, int nameCount) { }

	// RVA: 0x2A219A0 Offset: 0x2A21AA1 VA: 0x2A219A0
	public static Result Commit(string[] name) { }
}

