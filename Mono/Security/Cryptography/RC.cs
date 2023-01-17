// Namespace: Mono.Security.Cryptography
internal abstract class RC4 : SymmetricAlgorithm // TypeDefIndex: 70
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] IV { get; set; }

	// Methods

	// RVA: 0x3B69940 Offset: 0x3B69A41 VA: 0x3B69940
	public void .ctor() { }

	// RVA: 0x3B699F0 Offset: 0x3B69AF1 VA: 0x3B699F0 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x3B69A40 Offset: 0x3B69B41 VA: 0x3B69A40 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x3B69A50 Offset: 0x3B69B51 VA: 0x3B69A50
	public static RC4 Create() { }

	// RVA: 0x3B69AB0 Offset: 0x3B69BB1 VA: 0x3B69AB0
	private static void .cctor() { }
}

