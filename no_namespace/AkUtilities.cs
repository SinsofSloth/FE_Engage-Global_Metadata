// Namespace: 
public class AkUtilities.ShortIDGenerator // TypeDefIndex: 7953
{
	// Fields
	private const uint s_prime32 = 16777619;
	private const uint s_offsetBasis32 = 2166136261;
	private static byte s_hashSize; // 0x0
	private static uint s_mask; // 0x4

	// Properties
	public static byte HashSize { get; set; }

	// Methods

	// RVA: 0x1F5BB80 Offset: 0x1F5BC81 VA: 0x1F5BB80
	private static void .cctor() { }

	// RVA: 0x1F5BCA0 Offset: 0x1F5BDA1 VA: 0x1F5BCA0
	public static byte get_HashSize() { }

	// RVA: 0x1F5BC10 Offset: 0x1F5BD11 VA: 0x1F5BC10
	public static void set_HashSize(byte value) { }

	// RVA: 0x1F5BD10 Offset: 0x1F5BE11 VA: 0x1F5BD10
	public static uint Compute(string in_name) { }

	// RVA: 0x1F5BE60 Offset: 0x1F5BF61 VA: 0x1F5BE60
	public void .ctor() { }
}

// Namespace: 
public class AkUtilities // TypeDefIndex: 7954
{
	// Methods

	// RVA: 0x20DFFF0 Offset: 0x20E00F1 VA: 0x20DFFF0
	public static void FixSlashes(ref string path, char separatorChar, char badChar, bool addTrailingSlash) { }

	// RVA: 0x20E0130 Offset: 0x20E0231 VA: 0x20E0130
	public static void FixSlashes(ref string path) { }

	// RVA: 0x20E01C0 Offset: 0x20E02C1 VA: 0x20E01C0
	public void .ctor() { }
}

