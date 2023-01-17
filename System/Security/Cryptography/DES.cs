// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x473E00 Offset: 0x473F01 VA: 0x473E00
public abstract class DES : SymmetricAlgorithm // TypeDefIndex: 916
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x37E59D0 Offset: 0x37E5AD1 VA: 0x37E59D0
	protected void .ctor() { }

	// RVA: 0x37E5A80 Offset: 0x37E5B81 VA: 0x37E5A80 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x37E5F50 Offset: 0x37E6051 VA: 0x37E5F50 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x37E6160 Offset: 0x37E6261 VA: 0x37E6160
	public static DES Create() { }

	// RVA: 0x37E5BB0 Offset: 0x37E5CB1 VA: 0x37E5BB0
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x37E5D00 Offset: 0x37E5E01 VA: 0x37E5D00
	public static bool IsSemiWeakKey(byte[] rgbKey) { }

	// RVA: 0x37E61C0 Offset: 0x37E62C1 VA: 0x37E61C0
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x37E61E0 Offset: 0x37E62E1 VA: 0x37E61E0
	private static ulong QuadWordFromBigEndian(byte[] block) { }

	// RVA: 0x37E6280 Offset: 0x37E6381 VA: 0x37E6280
	private static void .cctor() { }
}

