// Namespace: UTJ
public class FileUtil // TypeDefIndex: 6410
{
	// Methods

	// RVA: 0x3108CD0 Offset: 0x3108DD1 VA: 0x3108CD0
	public static string ReadAllText(string inFilePath, Encoding inDefaultEncoding) { }

	// RVA: 0x3109260 Offset: 0x3109361 VA: 0x3109260
	public static string ReadAllText(string inFilePath) { }

	// RVA: 0x31092A0 Offset: 0x31093A1 VA: 0x31092A0
	public static string[] ReadAllLines(string inFilePath, Encoding inDefaultEncoding) { }

	// RVA: 0x3109440 Offset: 0x3109541 VA: 0x3109440
	public static string[] ReadAllLines(string inFilePath) { }

	// RVA: 0x3109480 Offset: 0x3109581 VA: 0x3109480
	public static bool WriteAllText(string filePath, string text, Encoding encoding) { }

	// RVA: 0x3108E50 Offset: 0x3108F51 VA: 0x3108E50
	public static Encoding TryToDetectEncoding(string inFilePath, Encoding inDefaultEncoding) { }

	// RVA: 0x3109830 Offset: 0x3109931 VA: 0x3109830
	public static Encoding TryToDetectEncoding(string inFilePath) { }

	// RVA: 0x3109860 Offset: 0x3109961 VA: 0x3109860
	public static void ExploreToDirectory(string directory) { }

	// RVA: 0x3109620 Offset: 0x3109721 VA: 0x3109620
	private static byte[] ReadFirstBytesOfFile(string inFilePath, int inNumBytesToRead) { }

	// RVA: 0x31097B0 Offset: 0x31098B1 VA: 0x31097B0
	private static bool CheckIfBufferStartsWithHeader(byte[] inBuffer, byte[] inHeader) { }

	// RVA: 0x3109870 Offset: 0x3109971 VA: 0x3109870
	public void .ctor() { }
}

