// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474080 Offset: 0x474181 VA: 0x474080
public sealed class RC2CryptoServiceProvider : RC2 // TypeDefIndex: 937
{
	// Fields
	private bool m_use40bitSalt; // 0x48
	private static KeySizes[] s_legalKeySizes; // 0x0

	// Properties
	public override int EffectiveKeySize { get; }

	// Methods

	// RVA: 0x3B67FC0 Offset: 0x3B680C1 VA: 0x3B67FC0
	public void .ctor() { }

	// RVA: 0x3B682B0 Offset: 0x3B683B1 VA: 0x3B682B0 Slot: 26
	public override int get_EffectiveKeySize() { }

	// RVA: 0x3B682C0 Offset: 0x3B683C1 VA: 0x3B682C0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x3B68910 Offset: 0x3B68A11 VA: 0x3B68910 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x3B689E0 Offset: 0x3B68AE1 VA: 0x3B689E0 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x3B68A70 Offset: 0x3B68B71 VA: 0x3B68A70 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x3B68AF0 Offset: 0x3B68BF1 VA: 0x3B68AF0
	private static void .cctor() { }
}

