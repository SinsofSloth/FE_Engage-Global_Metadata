// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x4742E0 Offset: 0x4743E1 VA: 0x4742E0
public abstract class TripleDES : SymmetricAlgorithm // TypeDefIndex: 963
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x363BF70 Offset: 0x363C071 VA: 0x363BF70
	protected void .ctor() { }

	// RVA: 0x363C020 Offset: 0x363C121 VA: 0x363C020 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x363C280 Offset: 0x363C381 VA: 0x363C280 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x363C460 Offset: 0x363C561 VA: 0x363C460
	public static TripleDES Create() { }

	// RVA: 0x363C120 Offset: 0x363C221 VA: 0x363C120
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x363C5D0 Offset: 0x363C6D1 VA: 0x363C5D0
	private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count) { }

	// RVA: 0x363C5A0 Offset: 0x363C6A1 VA: 0x363C5A0
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x363C770 Offset: 0x363C871 VA: 0x363C770
	private static void .cctor() { }
}

