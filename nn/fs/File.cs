// Namespace: nn.fs
public static class File // TypeDefIndex: 14737
{
	// Fields
	public const int EntryNameLengthMax = 768;

	// Methods

	// RVA: 0x2A1F7F0 Offset: 0x2A1F8F1 VA: 0x2A1F7F0
	public static extern Result Read(FileHandle handle, long offset, byte[] buffer, long size, ReadOption option) { }

	// RVA: 0x2A1F820 Offset: 0x2A1F921 VA: 0x2A1F820
	public static extern Result Read(FileHandle handle, long offset, byte[] buffer, long size) { }

	// RVA: 0x2A1F850 Offset: 0x2A1F951 VA: 0x2A1F850
	public static extern Result Read(ref long outValue, FileHandle handle, long offset, byte[] buffer, long size, ReadOption option) { }

	// RVA: 0x2A1F880 Offset: 0x2A1F981 VA: 0x2A1F880
	public static extern Result Read(ref long outValue, FileHandle handle, long offset, byte[] buffer, long size) { }

	// RVA: 0x2A1F8B0 Offset: 0x2A1F9B1 VA: 0x2A1F8B0
	public static extern Result Write(FileHandle handle, long offset, byte[] buffer, long size, WriteOption option) { }

	// RVA: 0x2A1F8E0 Offset: 0x2A1F9E1 VA: 0x2A1F8E0
	public static extern Result Flush(FileHandle handle) { }

	// RVA: 0x2A1F900 Offset: 0x2A1FA01 VA: 0x2A1F900
	public static extern Result SetSize(FileHandle handle, long size) { }

	// RVA: 0x2A1F920 Offset: 0x2A1FA21 VA: 0x2A1F920
	public static extern Result GetSize(ref long outValue, FileHandle handle) { }

	// RVA: 0x2A1F940 Offset: 0x2A1FA41 VA: 0x2A1F940
	public static extern OpenFileMode GetOpenMode(FileHandle handle) { }

	// RVA: 0x2A1F950 Offset: 0x2A1FA51 VA: 0x2A1F950
	public static extern void Close(FileHandle handle) { }

	// RVA: 0x2A1F960 Offset: 0x2A1FA61 VA: 0x2A1F960
	public static extern Result Create(string path, long size) { }

	// RVA: 0x2A1F9A0 Offset: 0x2A1FAA1 VA: 0x2A1F9A0
	public static extern Result Delete(string path) { }

	// RVA: 0x2A1F9E0 Offset: 0x2A1FAE1 VA: 0x2A1F9E0
	public static extern Result Rename(string currentPath, string newPath) { }

	// RVA: 0x2A1FA40 Offset: 0x2A1FB41 VA: 0x2A1FA40
	public static extern Result Open(ref FileHandle outValue, string path, OpenFileMode mode) { }
}

