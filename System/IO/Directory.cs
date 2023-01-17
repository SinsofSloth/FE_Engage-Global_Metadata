// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x4729C0 Offset: 0x472AC1 VA: 0x4729C0
public static class Directory // TypeDefIndex: 617
{
	// Methods

	// RVA: 0x3728290 Offset: 0x3728391 VA: 0x3728290
	public static string[] GetFiles(string path) { }

	// RVA: 0x3728360 Offset: 0x3728461 VA: 0x3728360
	public static string[] GetFiles(string path, string searchPattern) { }

	// RVA: 0x3728340 Offset: 0x3728441 VA: 0x3728340
	private static string[] InternalGetFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x37284F0 Offset: 0x37285F1 VA: 0x37284F0
	public static string[] GetDirectories(string path) { }

	// RVA: 0x37285C0 Offset: 0x37286C1 VA: 0x37285C0
	public static string[] GetDirectories(string path, string searchPattern) { }

	// RVA: 0x37285A0 Offset: 0x37286A1 VA: 0x37285A0
	private static string[] InternalGetDirectories(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x3728400 Offset: 0x3728501 VA: 0x3728400
	internal static string[] InternalGetFileDirectoryNames(string path, string userPathOriginal, string searchPattern, bool includeFiles, bool includeDirs, SearchOption searchOption, bool checkHost) { }

	// RVA: 0x3728660 Offset: 0x3728761 VA: 0x3728660
	public static IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x3728770 Offset: 0x3728871 VA: 0x3728770
	private static IEnumerable<string> InternalEnumerateFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x3728790 Offset: 0x3728891 VA: 0x3728790
	private static IEnumerable<string> EnumerateFileSystemNames(string path, string searchPattern, SearchOption searchOption, bool includeFiles, bool includeDirs) { }

	// RVA: 0x37287B0 Offset: 0x37288B1 VA: 0x37287B0
	public static DirectoryInfo CreateDirectory(string path) { }

	// RVA: 0x37289F0 Offset: 0x3728AF1 VA: 0x37289F0
	private static DirectoryInfo CreateDirectoriesInternal(string path) { }

	// RVA: 0x3728DC0 Offset: 0x3728EC1 VA: 0x3728DC0
	public static void Delete(string path) { }

	// RVA: 0x3729060 Offset: 0x3729161 VA: 0x3729060
	private static void RecursiveDelete(string path) { }

	// RVA: 0x37291D0 Offset: 0x37292D1 VA: 0x37291D0
	public static void Delete(string path, bool recursive) { }

	// RVA: 0x3729270 Offset: 0x3729371 VA: 0x3729270
	public static bool Exists(string path) { }

	// RVA: 0x37293B0 Offset: 0x37294B1 VA: 0x37293B0
	public static string GetCurrentDirectory() { }

	// RVA: 0x37293D0 Offset: 0x37294D1 VA: 0x37293D0
	internal static string InsecureGetCurrentDirectory() { }

	// RVA: 0x37294B0 Offset: 0x37295B1 VA: 0x37294B0
	internal static string GetDemandDir(string fullPath, bool thisDirOnly) { }
}

