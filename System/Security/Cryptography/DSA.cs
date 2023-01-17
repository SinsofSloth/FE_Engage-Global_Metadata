// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x473E60 Offset: 0x473F61 VA: 0x473E60
public abstract class DSA : AsymmetricAlgorithm // TypeDefIndex: 919
{
	// Methods

	// RVA: 0x35AD550 Offset: 0x35AD651 VA: 0x35AD550
	protected void .ctor() { }

	// RVA: 0x35AD560 Offset: 0x35AD661 VA: 0x35AD560
	public static DSA Create() { }

	// RVA: 0x35AD610 Offset: 0x35AD711 VA: 0x35AD610 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x35ADD40 Offset: 0x35ADE41 VA: 0x35ADD40 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void ImportParameters(DSAParameters parameters);
}

