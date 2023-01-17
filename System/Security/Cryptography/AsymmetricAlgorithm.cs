// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x473C40 Offset: 0x473D41 VA: 0x473C40
public abstract class AsymmetricAlgorithm : IDisposable // TypeDefIndex: 901
{
	// Fields
	protected int KeySizeValue; // 0x10
	protected KeySizes[] LegalKeySizesValue; // 0x18

	// Properties
	public virtual int KeySize { get; set; }

	// Methods

	// RVA: 0x3568FD0 Offset: 0x35690D1 VA: 0x3568FD0
	protected void .ctor() { }

	// RVA: 0x3568FE0 Offset: 0x35690E1 VA: 0x3568FE0 Slot: 4
	public void Dispose() { }

	// RVA: 0x3569060 Offset: 0x3569161 VA: 0x3569060
	public void Clear() { }

	// RVA: 0x35690E0 Offset: 0x35691E1 VA: 0x35690E0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x35690F0 Offset: 0x35691F1 VA: 0x35690F0 Slot: 6
	public virtual int get_KeySize() { }

	// RVA: 0x3569100 Offset: 0x3569201 VA: 0x3569100 Slot: 7
	public virtual void set_KeySize(int value) { }

	// RVA: 0x35691F0 Offset: 0x35692F1 VA: 0x35691F0 Slot: 8
	public virtual void FromXmlString(string xmlString) { }

	// RVA: 0x3569230 Offset: 0x3569331 VA: 0x3569230 Slot: 9
	public virtual string ToXmlString(bool includePrivateParameters) { }
}

