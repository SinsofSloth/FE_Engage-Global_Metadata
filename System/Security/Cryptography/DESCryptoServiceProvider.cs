// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x473E20 Offset: 0x473F21 VA: 0x473E20
public sealed class DESCryptoServiceProvider : DES // TypeDefIndex: 917
{
	// Methods

	// RVA: 0x37D9800 Offset: 0x37D9901 VA: 0x37D9800
	public void .ctor() { }

	// RVA: 0x37E6400 Offset: 0x37E6501 VA: 0x37E6400 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x37E67C0 Offset: 0x37E68C1 VA: 0x37E67C0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x37E6910 Offset: 0x37E6A11 VA: 0x37E6910 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x37E6A10 Offset: 0x37E6B11 VA: 0x37E6A10 Slot: 25
	public override void GenerateIV() { }
}

