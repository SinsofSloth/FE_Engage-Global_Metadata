// Namespace: System.Security.Cryptography
internal class TripleDESTransform : SymmetricTransform // TypeDefIndex: 976
{
	// Fields
	private DESTransform E1; // 0x58
	private DESTransform D2; // 0x60
	private DESTransform E3; // 0x68
	private DESTransform D1; // 0x70
	private DESTransform E2; // 0x78
	private DESTransform D3; // 0x80

	// Methods

	// RVA: 0x363CA10 Offset: 0x363CB11 VA: 0x363CA10
	public void .ctor(TripleDES algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x363D0B0 Offset: 0x363D1B1 VA: 0x363D0B0 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x363CFE0 Offset: 0x363D0E1 VA: 0x363CFE0
	internal static byte[] GetStrongKey() { }
}

