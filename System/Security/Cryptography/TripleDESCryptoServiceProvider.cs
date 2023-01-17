// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474300 Offset: 0x474401 VA: 0x474300
public sealed class TripleDESCryptoServiceProvider : TripleDES // TypeDefIndex: 964
{
	// Methods

	// RVA: 0x363C4C0 Offset: 0x363C5C1 VA: 0x363C4C0
	public void .ctor() { }

	// RVA: 0x363C8F0 Offset: 0x363C9F1 VA: 0x363C8F0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x363CD60 Offset: 0x363CE61 VA: 0x363CD60 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x363CE80 Offset: 0x363CF81 VA: 0x363CE80 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x363CF60 Offset: 0x363D061 VA: 0x363CF60 Slot: 25
	public override void GenerateIV() { }
}

