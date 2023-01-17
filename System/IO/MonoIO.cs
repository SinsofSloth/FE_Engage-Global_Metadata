// Namespace: System.IO
internal static class MonoIO // TypeDefIndex: 669
{
	// Fields
	public static readonly IntPtr InvalidHandle; // 0x0
	private static bool dump_handles; // 0x8

	// Properties
	public static IntPtr ConsoleOutput { get; }
	public static IntPtr ConsoleInput { get; }
	public static IntPtr ConsoleError { get; }
	public static char VolumeSeparatorChar { get; }
	public static char DirectorySeparatorChar { get; }
	public static char AltDirectorySeparatorChar { get; }
	public static char PathSeparator { get; }

	// Methods

	// RVA: 0x34F7A20 Offset: 0x34F7B21 VA: 0x34F7A20
	public static Exception GetException(MonoIOError error) { }

	// RVA: 0x34F7B60 Offset: 0x34F7C61 VA: 0x34F7B60
	public static Exception GetException(string path, MonoIOError error) { }

	// RVA: 0x34F82C0 Offset: 0x34F83C1 VA: 0x34F82C0
	private static bool CreateDirectory(char* path, out MonoIOError error) { }

	// RVA: 0x34F82D0 Offset: 0x34F83D1 VA: 0x34F82D0
	public static bool CreateDirectory(string path, out MonoIOError error) { }

	// RVA: 0x34F8350 Offset: 0x34F8451 VA: 0x34F8350
	private static bool RemoveDirectory(char* path, out MonoIOError error) { }

	// RVA: 0x34F8360 Offset: 0x34F8461 VA: 0x34F8360
	public static bool RemoveDirectory(string path, out MonoIOError error) { }

	// RVA: 0x34F83E0 Offset: 0x34F84E1 VA: 0x34F83E0
	public static string GetCurrentDirectory(out MonoIOError error) { }

	// RVA: 0x34F83F0 Offset: 0x34F84F1 VA: 0x34F83F0
	private static bool MoveFile(char* path, char* dest, out MonoIOError error) { }

	// RVA: 0x34F8400 Offset: 0x34F8501 VA: 0x34F8400
	public static bool MoveFile(string path, string dest, out MonoIOError error) { }

	// RVA: 0x34F84A0 Offset: 0x34F85A1 VA: 0x34F84A0
	private static bool DeleteFile(char* path, out MonoIOError error) { }

	// RVA: 0x34F84B0 Offset: 0x34F85B1 VA: 0x34F84B0
	public static bool DeleteFile(string path, out MonoIOError error) { }

	// RVA: 0x34F8530 Offset: 0x34F8631 VA: 0x34F8530
	private static FileAttributes GetFileAttributes(char* path, out MonoIOError error) { }

	// RVA: 0x34F8540 Offset: 0x34F8641 VA: 0x34F8540
	public static FileAttributes GetFileAttributes(string path, out MonoIOError error) { }

	// RVA: 0x34F85C0 Offset: 0x34F86C1 VA: 0x34F85C0
	private static MonoFileType GetFileType(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x34F85D0 Offset: 0x34F86D1 VA: 0x34F85D0
	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x34F8700 Offset: 0x34F8801 VA: 0x34F8700
	private static IntPtr FindFirstFile(char* pathWithPattern, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x34F8710 Offset: 0x34F8811 VA: 0x34F8710
	public static IntPtr FindFirstFile(string pathWithPattern, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x34F87B0 Offset: 0x34F88B1 VA: 0x34F87B0
	public static bool FindNextFile(IntPtr hnd, out string fileName, out int fileAttr, out int error) { }

	// RVA: 0x34F87C0 Offset: 0x34F88C1 VA: 0x34F87C0
	public static bool FindCloseFile(IntPtr hnd) { }

	// RVA: 0x34F87D0 Offset: 0x34F88D1 VA: 0x34F87D0
	public static bool Exists(string path, out MonoIOError error) { }

	// RVA: 0x34F88B0 Offset: 0x34F89B1 VA: 0x34F88B0
	public static bool ExistsFile(string path, out MonoIOError error) { }

	// RVA: 0x34F89A0 Offset: 0x34F8AA1 VA: 0x34F89A0
	public static bool ExistsDirectory(string path, out MonoIOError error) { }

	// RVA: 0x34F8AA0 Offset: 0x34F8BA1 VA: 0x34F8AA0
	public static bool ExistsSymlink(string path, out MonoIOError error) { }

	// RVA: 0x34F8B90 Offset: 0x34F8C91 VA: 0x34F8B90
	private static bool GetFileStat(char* path, out MonoIOStat stat, out MonoIOError error) { }

	// RVA: 0x34F8BA0 Offset: 0x34F8CA1 VA: 0x34F8BA0
	public static bool GetFileStat(string path, out MonoIOStat stat, out MonoIOError error) { }

	// RVA: 0x34F8C30 Offset: 0x34F8D31 VA: 0x34F8C30
	private static IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x34F8C40 Offset: 0x34F8D41 VA: 0x34F8C40
	public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x34F8CF0 Offset: 0x34F8DF1 VA: 0x34F8CF0
	public static bool Close(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x34F8D00 Offset: 0x34F8E01 VA: 0x34F8D00
	private static int Read(IntPtr handle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x34F8D10 Offset: 0x34F8E11 VA: 0x34F8D10
	public static int Read(SafeHandle safeHandle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x34F8E60 Offset: 0x34F8F61 VA: 0x34F8E60
	private static int Write(IntPtr handle, [In] byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x34F8E70 Offset: 0x34F8F71 VA: 0x34F8E70
	public static int Write(SafeHandle safeHandle, byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x34F8FC0 Offset: 0x34F90C1 VA: 0x34F8FC0
	private static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x34F8FD0 Offset: 0x34F90D1 VA: 0x34F8FD0
	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x34F9110 Offset: 0x34F9211 VA: 0x34F9110
	private static long GetLength(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x34F9120 Offset: 0x34F9221 VA: 0x34F9120
	public static long GetLength(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x34F9250 Offset: 0x34F9351 VA: 0x34F9250
	private static bool SetLength(IntPtr handle, long length, out MonoIOError error) { }

	// RVA: 0x34F9260 Offset: 0x34F9361 VA: 0x34F9260
	public static bool SetLength(SafeHandle safeHandle, long length, out MonoIOError error) { }

	// RVA: 0x34F9390 Offset: 0x34F9491 VA: 0x34F9390
	public static IntPtr get_ConsoleOutput() { }

	// RVA: 0x34F93A0 Offset: 0x34F94A1 VA: 0x34F93A0
	public static IntPtr get_ConsoleInput() { }

	// RVA: 0x34F93B0 Offset: 0x34F94B1 VA: 0x34F93B0
	public static IntPtr get_ConsoleError() { }

	// RVA: 0x34F93C0 Offset: 0x34F94C1 VA: 0x34F93C0
	public static bool CreatePipe(out IntPtr read_handle, out IntPtr write_handle, out MonoIOError error) { }

	// RVA: 0x34F93D0 Offset: 0x34F94D1 VA: 0x34F93D0
	public static bool DuplicateHandle(IntPtr source_process_handle, IntPtr source_handle, IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options, out MonoIOError error) { }

	// RVA: 0x34F93E0 Offset: 0x34F94E1 VA: 0x34F93E0
	public static char get_VolumeSeparatorChar() { }

	// RVA: 0x34F93F0 Offset: 0x34F94F1 VA: 0x34F93F0
	public static char get_DirectorySeparatorChar() { }

	// RVA: 0x34F9400 Offset: 0x34F9501 VA: 0x34F9400
	public static char get_AltDirectorySeparatorChar() { }

	// RVA: 0x34F9410 Offset: 0x34F9511 VA: 0x34F9410
	public static char get_PathSeparator() { }

	// RVA: 0x34F82B0 Offset: 0x34F83B1 VA: 0x34F82B0
	private static void DumpHandles() { }

	// RVA: 0x34F9420 Offset: 0x34F9521 VA: 0x34F9420
	public static bool RemapPath(string path, out string newPath) { }

	// RVA: 0x34F9430 Offset: 0x34F9531 VA: 0x34F9430
	private static void .cctor() { }
}

