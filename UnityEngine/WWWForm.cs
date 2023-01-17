// Namespace: UnityEngine
public class WWWForm // TypeDefIndex: 4438
{
	// Fields
	private List<byte[]> formData; // 0x10
	private List<string> fieldNames; // 0x18
	private List<string> fileNames; // 0x20
	private List<string> types; // 0x28
	private byte[] boundary; // 0x30
	private bool containsFiles; // 0x38

	// Properties
	internal static Encoding DefaultEncoding { get; }
	public Dictionary<string, string> headers { get; }
	public byte[] data { get; }

	// Methods

	// RVA: 0x1C4D060 Offset: 0x1C4D161 VA: 0x1C4D060
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x1C4CCC0 Offset: 0x1C4CDC1 VA: 0x1C4CCC0
	public Dictionary<string, string> get_headers() { }

	// RVA: 0x1C4BA20 Offset: 0x1C4BB21 VA: 0x1C4BA20
	public byte[] get_data() { }
}

