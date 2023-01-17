// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x473FE0 Offset: 0x4740E1 VA: 0x473FE0
public abstract class KeyedHashAlgorithm : HashAlgorithm // TypeDefIndex: 931
{
	// Fields
	protected byte[] KeyValue; // 0x28

	// Properties
	public virtual byte[] Key { get; set; }

	// Methods

	// RVA: 0x341B670 Offset: 0x341B771 VA: 0x341B670
	protected void .ctor() { }

	// RVA: 0x341B680 Offset: 0x341B781 VA: 0x341B680 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x341B6F0 Offset: 0x341B7F1 VA: 0x341B6F0 Slot: 19
	public virtual byte[] get_Key() { }

	// RVA: 0x341B770 Offset: 0x341B871 VA: 0x341B770 Slot: 20
	public virtual void set_Key(byte[] value) { }
}

