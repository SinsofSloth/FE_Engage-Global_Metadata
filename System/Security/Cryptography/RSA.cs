// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474160 Offset: 0x474261 VA: 0x474160
public abstract class RSA : AsymmetricAlgorithm // TypeDefIndex: 945
{
	// Methods

	// RVA: 0x3B6BE00 Offset: 0x3B6BF01 VA: 0x3B6BE00
	protected void .ctor() { }

	// RVA: 0x3B6BE10 Offset: 0x3B6BF11 VA: 0x3B6BE10
	public static RSA Create() { }

	// RVA: 0x3B6BEC0 Offset: 0x3B6BFC1 VA: 0x3B6BEC0 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x3B6C4B0 Offset: 0x3B6C5B1 VA: 0x3B6C4B0 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract RSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void ImportParameters(RSAParameters parameters);
}

