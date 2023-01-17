// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x4729A0 Offset: 0x472AA1 VA: 0x4729A0
[Serializable]
public class BinaryWriter : IDisposable // TypeDefIndex: 615
{
	// Fields
	public static readonly BinaryWriter Null; // 0x0
	protected Stream OutStream; // 0x10
	private byte[] _buffer; // 0x18
	private Encoding _encoding; // 0x20
	private Encoder _encoder; // 0x28
	[OptionalFieldAttribute] // RVA: 0x4784B0 Offset: 0x4785B1 VA: 0x4784B0
	private bool _leaveOpen; // 0x30
	private byte[] _largeByteBuffer; // 0x38
	private int _maxChars; // 0x40

	// Methods

	// RVA: 0x3507D60 Offset: 0x3507E61 VA: 0x3507D60
	protected void .ctor() { }

	// RVA: 0x3507E80 Offset: 0x3507F81 VA: 0x3507E80
	public void .ctor(Stream output) { }

	// RVA: 0x35080B0 Offset: 0x35081B1 VA: 0x35080B0
	public void .ctor(Stream output, Encoding encoding) { }

	// RVA: 0x3507F00 Offset: 0x3508001 VA: 0x3507F00
	public void .ctor(Stream output, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x35080C0 Offset: 0x35081C1 VA: 0x35080C0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x35080F0 Offset: 0x35081F1 VA: 0x35080F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x3508100 Offset: 0x3508201 VA: 0x3508100 Slot: 6
	public virtual void Flush() { }

	// RVA: 0x3508120 Offset: 0x3508221 VA: 0x3508120 Slot: 7
	public virtual void Write(bool value) { }

	// RVA: 0x3508170 Offset: 0x3508271 VA: 0x3508170 Slot: 8
	public virtual void Write(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x47C1A0 Offset: 0x47C2A1 VA: 0x47C1A0
	// RVA: 0x3508190 Offset: 0x3508291 VA: 0x3508190 Slot: 9
	public virtual void Write(sbyte value) { }

	// RVA: 0x35081B0 Offset: 0x35082B1 VA: 0x35081B0 Slot: 10
	public virtual void Write(byte[] buffer) { }

	// RVA: 0x3508230 Offset: 0x3508331 VA: 0x3508230 Slot: 11
	public virtual void Write(byte[] buffer, int index, int count) { }

	// RVA: 0x3508250 Offset: 0x3508351 VA: 0x3508250 Slot: 12
	public virtual void Write(char ch) { }

	// RVA: 0x3508390 Offset: 0x3508491 VA: 0x3508390 Slot: 13
	public virtual void Write(char[] chars) { }

	// RVA: 0x3508430 Offset: 0x3508531 VA: 0x3508430 Slot: 14
	public virtual void Write(double value) { }

	// RVA: 0x35084B0 Offset: 0x35085B1 VA: 0x35084B0 Slot: 15
	public virtual void Write(short value) { }

	[CLSCompliantAttribute] // RVA: 0x47C1C0 Offset: 0x47C2C1 VA: 0x47C1C0
	// RVA: 0x3508510 Offset: 0x3508611 VA: 0x3508510 Slot: 16
	public virtual void Write(ushort value) { }

	// RVA: 0x3508570 Offset: 0x3508671 VA: 0x3508570 Slot: 17
	public virtual void Write(int value) { }

	[CLSCompliantAttribute] // RVA: 0x47C1E0 Offset: 0x47C2E1 VA: 0x47C1E0
	// RVA: 0x3508600 Offset: 0x3508701 VA: 0x3508600 Slot: 18
	public virtual void Write(uint value) { }

	// RVA: 0x3508690 Offset: 0x3508791 VA: 0x3508690 Slot: 19
	public virtual void Write(long value) { }

	[CLSCompliantAttribute] // RVA: 0x47C200 Offset: 0x47C301 VA: 0x47C200
	// RVA: 0x3508780 Offset: 0x3508881 VA: 0x3508780 Slot: 20
	public virtual void Write(ulong value) { }

	// RVA: 0x3508870 Offset: 0x3508971 VA: 0x3508870 Slot: 21
	public virtual void Write(float value) { }

	// RVA: 0x35088F0 Offset: 0x35089F1 VA: 0x35088F0 Slot: 22
	public virtual void Write(string value) { }

	// RVA: 0x3508BF0 Offset: 0x3508CF1 VA: 0x3508BF0
	protected void Write7BitEncodedInt(int value) { }

	// RVA: 0x3508C60 Offset: 0x3508D61 VA: 0x3508C60
	private static void .cctor() { }
}

