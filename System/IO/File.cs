// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472C40 Offset: 0x472D41 VA: 0x472C40
public static class File // TypeDefIndex: 658
{
	// Fields
	private static Nullable<DateTime> defaultLocalFileTime; // 0x0

	// Properties
	private static DateTime DefaultLocalFileTime { get; }

	// Methods

	// RVA: 0x38AC1F0 Offset: 0x38AC2F1 VA: 0x38AC1F0
	public static FileStream Create(string path) { }

	// RVA: 0x38AC280 Offset: 0x38AC381 VA: 0x38AC280
	public static FileStream Create(string path, int bufferSize) { }

	// RVA: 0x38AC340 Offset: 0x38AC441 VA: 0x38AC340
	public static void Delete(string path) { }

	// RVA: 0x38AC5E0 Offset: 0x38AC6E1 VA: 0x38AC5E0
	public static bool Exists(string path) { }

	// RVA: 0x38AC6D0 Offset: 0x38AC7D1 VA: 0x38AC6D0
	public static DateTime GetLastWriteTime(string path) { }

	// RVA: 0x38AC930 Offset: 0x38ACA31 VA: 0x38AC930
	public static void Move(string sourceFileName, string destFileName) { }

	// RVA: 0x38ACE30 Offset: 0x38ACF31 VA: 0x38ACE30
	public static FileStream Open(string path, FileMode mode) { }

	// RVA: 0x38ACF00 Offset: 0x38AD001 VA: 0x38ACF00
	public static FileStream OpenRead(string path) { }

	// RVA: 0x38ACF90 Offset: 0x38AD091 VA: 0x38ACF90
	public static StreamReader OpenText(string path) { }

	// RVA: 0x38AD000 Offset: 0x38AD101 VA: 0x38AD000
	public static byte[] ReadAllBytes(string path) { }

	// RVA: 0x38AD2B0 Offset: 0x38AD3B1 VA: 0x38AD2B0
	public static string[] ReadAllLines(string path, Encoding encoding) { }

	// RVA: 0x38AD410 Offset: 0x38AD511 VA: 0x38AD410
	private static string[] ReadAllLines(StreamReader reader) { }

	// RVA: 0x38AD500 Offset: 0x38AD601 VA: 0x38AD500
	public static string ReadAllText(string path) { }

	// RVA: 0x38AD660 Offset: 0x38AD761 VA: 0x38AD660
	public static string ReadAllText(string path, Encoding encoding) { }

	// RVA: 0x38AD7D0 Offset: 0x38AD8D1 VA: 0x38AD7D0
	public static void WriteAllText(string path, string contents) { }

	// RVA: 0x38AD850 Offset: 0x38AD951 VA: 0x38AD850
	public static void WriteAllText(string path, string contents, Encoding encoding) { }

	// RVA: 0x38AC830 Offset: 0x38AC931 VA: 0x38AC830
	private static DateTime get_DefaultLocalFileTime() { }

	// RVA: 0x38AD9C0 Offset: 0x38ADAC1 VA: 0x38AD9C0
	internal static int FillAttributeInfo(string path, ref MonoIOStat data, bool tryagain, bool returnErrorOnNotFound) { }
}

