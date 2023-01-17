// Namespace: App
public static class DebugFs // TypeDefIndex: 9098
{
	// Methods

	// RVA: 0x2E9D480 Offset: 0x2E9D581 VA: 0x2E9D480
	public static bool IsExists(string path) { }

	// RVA: 0x2E9D490 Offset: 0x2E9D591 VA: 0x2E9D490
	public static bool IsFileExists(string path) { }

	// RVA: 0x2E9D4A0 Offset: 0x2E9D5A1 VA: 0x2E9D4A0
	public static bool IsDirectoryExists(string path) { }

	// RVA: 0x2E9D4B0 Offset: 0x2E9D5B1 VA: 0x2E9D4B0
	public static string[] GetFsEntries(string path, string pattern, bool isRecursive = False) { }

	// RVA: 0x2E9D4C0 Offset: 0x2E9D5C1 VA: 0x2E9D4C0
	public static string[] GetFiles(string path, string pattern, bool isRecursive = False) { }

	// RVA: 0x2E9D4D0 Offset: 0x2E9D5D1 VA: 0x2E9D4D0
	public static string[] GetDirectories(string path, string pattern, bool isRecursive = False) { }

	// RVA: 0x2E9D4E0 Offset: 0x2E9D5E1 VA: 0x2E9D4E0
	public static byte[] ReadFile(string path) { }

	// RVA: 0x2E9D4F0 Offset: 0x2E9D5F1 VA: 0x2E9D4F0
	public static bool WriteFile(string path, byte[] bin, int size = 0) { }

	// RVA: 0x2E9D500 Offset: 0x2E9D601 VA: 0x2E9D500
	public static bool DeleteFile(string path) { }

	// RVA: 0x2E9D510 Offset: 0x2E9D611 VA: 0x2E9D510
	public static bool CreateDirectory(string path) { }

	// RVA: 0x2E9D520 Offset: 0x2E9D621 VA: 0x2E9D520
	public static bool DeleteDirectory(string path) { }
}

