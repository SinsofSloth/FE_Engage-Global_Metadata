// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x4740C0 Offset: 0x4741C1 VA: 0x4740C0
public sealed class RijndaelManaged : Rijndael // TypeDefIndex: 939
{
	// Methods

	// RVA: 0x3227AB0 Offset: 0x3227BB1 VA: 0x3227AB0
	public void .ctor() { }

	// RVA: 0x3227B80 Offset: 0x3227C81 VA: 0x3227B80 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x3227DA0 Offset: 0x3227EA1 VA: 0x3227DA0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x3227EB0 Offset: 0x3227FB1 VA: 0x3227EB0 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x3227F00 Offset: 0x3228001 VA: 0x3227F00 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x3227C90 Offset: 0x3227D91 VA: 0x3227C90
	private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode) { }
}

