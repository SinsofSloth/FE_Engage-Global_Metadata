// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474040 Offset: 0x474141 VA: 0x474040
public abstract class RandomNumberGenerator : IDisposable // TypeDefIndex: 935
{
	// Methods

	// RVA: 0x3B6BA20 Offset: 0x3B6BB21 VA: 0x3B6BA20
	protected void .ctor() { }

	// RVA: 0x3B6FDA0 Offset: 0x3B6FEA1 VA: 0x3B6FDA0
	public static RandomNumberGenerator Create() { }

	// RVA: 0x3B6FE50 Offset: 0x3B6FF51 VA: 0x3B6FE50 Slot: 4
	public void Dispose() { }

	// RVA: 0x3B6BDF0 Offset: 0x3B6BEF1 VA: 0x3B6BDF0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void GetBytes(byte[] data);
}

