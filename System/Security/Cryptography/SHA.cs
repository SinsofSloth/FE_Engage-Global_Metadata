// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x4743C0 Offset: 0x4744C1 VA: 0x4743C0
public sealed class SHA1CryptoServiceProvider : SHA1 // TypeDefIndex: 975
{
	// Fields
	private SHA1Internal sha; // 0x28

	// Methods

	// RVA: 0x3608F20 Offset: 0x3609021 VA: 0x3608F20
	public void .ctor() { }

	// RVA: 0x3609070 Offset: 0x3609171 VA: 0x3609070 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x36090F0 Offset: 0x36091F1 VA: 0x36090F0 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3609100 Offset: 0x3609201 VA: 0x3609100 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x3609220 Offset: 0x3609321 VA: 0x3609220 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x3609540 Offset: 0x3609641 VA: 0x3609540 Slot: 16
	public override void Initialize() { }
}

