// Namespace: App
public class SaveData // TypeDefIndex: 9160
{
	// Fields
	public const string MountName = "save";
	public const string MountNameWithColon = "save:";
	private static bool s_IsMounted; // 0x0

	// Properties
	public static bool IsMounted { get; }

	// Methods

	// RVA: 0x205FCE0 Offset: 0x205FDE1 VA: 0x205FCE0
	public static void Setup() { }

	// RVA: 0x205FDA0 Offset: 0x205FEA1 VA: 0x205FDA0
	public static void Setup(Uid userId) { }

	// RVA: 0x205FF50 Offset: 0x2060051 VA: 0x205FF50
	public static void Cleanup() { }

	// RVA: 0x20600D0 Offset: 0x20601D1 VA: 0x20600D0
	public static void PauseExitApp() { }

	// RVA: 0x20600E0 Offset: 0x20601E1 VA: 0x20600E0
	public static void ResumeExitApp() { }

	// RVA: 0x20600F0 Offset: 0x20601F1 VA: 0x20600F0
	public static Result Read(ref long readSize, string path, long offset, byte[] data, long size) { }

	// RVA: 0x20601B0 Offset: 0x20602B1 VA: 0x20601B0
	public static SaveDataReadHandle ReadAsync(string path, long offset, byte[] data, long size) { }

	// RVA: 0x2060300 Offset: 0x2060401 VA: 0x2060300
	public static Result Write(string path, long offset, byte[] data, long size, bool isEnableResize = True) { }

	// RVA: 0x20603C0 Offset: 0x20604C1 VA: 0x20603C0
	public static SaveDataHandle WriteAsync(string path, long offset, byte[] data, long size, bool isEnableResize = True) { }

	// RVA: 0x2060520 Offset: 0x2060621 VA: 0x2060520
	public static Result Delete(string path) { }

	// RVA: 0x20605B0 Offset: 0x20606B1 VA: 0x20605B0
	public static SaveDataHandle DeleteAsync(string path) { }

	// RVA: 0x20606C0 Offset: 0x20607C1 VA: 0x20606C0
	public static void Commit(string mountName) { }

	// RVA: 0x2060750 Offset: 0x2060851 VA: 0x2060750
	public static SaveDataHandle CommitAsync(string mountName) { }

	// RVA: 0x2060860 Offset: 0x2060961 VA: 0x2060860
	public static bool IsExist(string path) { }

	// RVA: 0x20608F0 Offset: 0x20609F1 VA: 0x20608F0
	public static long GetFileSize(string path) { }

	// RVA: 0x2060980 Offset: 0x2060A81 VA: 0x2060980
	public static void Dump(string rootPath) { }

	// RVA: 0x2060A10 Offset: 0x2060B11 VA: 0x2060A10
	public static bool get_IsMounted() { }

	// RVA: 0x2060A80 Offset: 0x2060B81 VA: 0x2060A80
	public void .ctor() { }

	// RVA: 0x2060A90 Offset: 0x2060B91 VA: 0x2060A90
	private static void .cctor() { }
}

