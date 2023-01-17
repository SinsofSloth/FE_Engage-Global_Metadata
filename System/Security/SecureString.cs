// Namespace: System.Security
[MonoTODOAttribute] // RVA: 0x473A00 Offset: 0x473B01 VA: 0x473A00
public sealed class SecureString : IDisposable // TypeDefIndex: 873
{
	// Fields
	private int length; // 0x10
	private bool disposed; // 0x14
	private byte[] data; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x3611DF0 Offset: 0x3611EF1 VA: 0x3611DF0
	public void .ctor() { }

	[CLSCompliantAttribute] // RVA: 0x47CDE0 Offset: 0x47CEE1 VA: 0x47CDE0
	// RVA: 0x3612010 Offset: 0x3612111 VA: 0x3612010
	public void .ctor(char* value, int length) { }

	// RVA: 0x3612170 Offset: 0x3612271 VA: 0x3612170
	public int get_Length() { }

	// RVA: 0x36121E0 Offset: 0x36122E1 VA: 0x36121E0 Slot: 4
	public void Dispose() { }

	// RVA: 0x3612160 Offset: 0x3612261 VA: 0x3612160
	private void Encrypt() { }

	// RVA: 0x3612240 Offset: 0x3612341 VA: 0x3612240
	private void Decrypt() { }

	// RVA: 0x3611E70 Offset: 0x3611F71 VA: 0x3611E70
	private void Alloc(int length, bool realloc) { }

	// RVA: 0x3612250 Offset: 0x3612351 VA: 0x3612250
	internal byte[] GetBuffer() { }
}

