// Namespace: nn.fs
public static class Directory // TypeDefIndex: 14733
{
	// Fields
	public const int EntryNameLengthMax = 768;

	// Methods

	// RVA: 0x2373E50 Offset: 0x2373F51 VA: 0x2373E50
	public static extern Result Read(ref long outValue, [Out] DirectoryEntry[] entryBuffer, DirectoryHandle handle, long entryBufferCount) { }

	// RVA: 0x2373FA0 Offset: 0x23740A1 VA: 0x2373FA0
	public static extern Result GetEntryCount(ref long outValue, DirectoryHandle handle) { }

	// RVA: 0x2373FC0 Offset: 0x23740C1 VA: 0x2373FC0
	public static extern void Close(DirectoryHandle handle) { }

	// RVA: 0x2373FD0 Offset: 0x23740D1 VA: 0x2373FD0
	public static extern Result Create(string path) { }

	// RVA: 0x2374010 Offset: 0x2374111 VA: 0x2374010
	public static extern Result Delete(string path) { }

	// RVA: 0x2374050 Offset: 0x2374151 VA: 0x2374050
	public static extern Result DeleteRecursively(string path) { }

	// RVA: 0x2374090 Offset: 0x2374191 VA: 0x2374090
	public static extern Result CleanRecursively(string path) { }

	// RVA: 0x23740D0 Offset: 0x23741D1 VA: 0x23740D0
	public static extern Result Rename(string currentPath, string newPath) { }

	// RVA: 0x2374130 Offset: 0x2374231 VA: 0x2374130
	public static extern Result Open(ref DirectoryHandle outValue, string path, OpenDirectoryMode mode) { }
}

