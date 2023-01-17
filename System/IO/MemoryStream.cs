// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472AE0 Offset: 0x472BE1 VA: 0x472AE0
[Serializable]
public class MemoryStream : Stream // TypeDefIndex: 633
{
	// Fields
	private byte[] _buffer; // 0x28
	private int _origin; // 0x30
	private int _position; // 0x34
	private int _length; // 0x38
	private int _capacity; // 0x3C
	private bool _expandable; // 0x40
	private bool _writable; // 0x41
	private bool _exposable; // 0x42
	private bool _isOpen; // 0x43
	private Task<int> _lastReadTask; // 0x48

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public virtual int Capacity { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x34E90E0 Offset: 0x34E91E1 VA: 0x34E90E0
	public void .ctor() { }

	// RVA: 0x34E90F0 Offset: 0x34E91F1 VA: 0x34E90F0
	public void .ctor(int capacity) { }

	// RVA: 0x34E9210 Offset: 0x34E9311 VA: 0x34E9210
	public void .ctor(byte[] buffer) { }

	// RVA: 0x34E9220 Offset: 0x34E9321 VA: 0x34E9220
	public void .ctor(byte[] buffer, bool writable) { }

	// RVA: 0x34E9340 Offset: 0x34E9441 VA: 0x34E9340
	public void .ctor(byte[] buffer, int index, int count) { }

	// RVA: 0x34E9350 Offset: 0x34E9451 VA: 0x34E9350
	public void .ctor(byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }

	// RVA: 0x34E9560 Offset: 0x34E9661 VA: 0x34E9560 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x34E9570 Offset: 0x34E9671 VA: 0x34E9570 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x34E9580 Offset: 0x34E9681 VA: 0x34E9580 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x34E9590 Offset: 0x34E9691 VA: 0x34E9590
	private void EnsureWriteable() { }

	// RVA: 0x34E95C0 Offset: 0x34E96C1 VA: 0x34E95C0 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x34E9650 Offset: 0x34E9751 VA: 0x34E9650
	private bool EnsureCapacity(int value) { }

	// RVA: 0x34E9720 Offset: 0x34E9821 VA: 0x34E9720 Slot: 20
	public override void Flush() { }

	// RVA: 0x34E9730 Offset: 0x34E9831 VA: 0x34E9730 Slot: 33
	public virtual byte[] GetBuffer() { }

	// RVA: 0x34E97B0 Offset: 0x34E98B1 VA: 0x34E97B0
	internal byte[] InternalGetBuffer() { }

	// RVA: 0x34E97C0 Offset: 0x34E98C1 VA: 0x34E97C0
	internal int InternalGetPosition() { }

	// RVA: 0x34E9800 Offset: 0x34E9901 VA: 0x34E9800
	internal int InternalReadInt32() { }

	// RVA: 0x34E98C0 Offset: 0x34E99C1 VA: 0x34E98C0
	internal int InternalEmulateRead(int count) { }

	// RVA: 0x34E9910 Offset: 0x34E9A11 VA: 0x34E9910 Slot: 34
	public virtual int get_Capacity() { }

	// RVA: 0x34E9950 Offset: 0x34E9A51 VA: 0x34E9950 Slot: 35
	public virtual void set_Capacity(int value) { }

	// RVA: 0x34E9AE0 Offset: 0x34E9BE1 VA: 0x34E9AE0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x34E9B20 Offset: 0x34E9C21 VA: 0x34E9B20 Slot: 12
	public override long get_Position() { }

	// RVA: 0x34E9B60 Offset: 0x34E9C61 VA: 0x34E9B60 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x34E9C20 Offset: 0x34E9D21 VA: 0x34E9C20 Slot: 29
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x47C240 Offset: 0x47C341 VA: 0x47C240
	// RVA: 0x34E9E60 Offset: 0x34E9F61 VA: 0x34E9E60 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x34EA260 Offset: 0x34EA361 VA: 0x34EA260 Slot: 30
	public override int ReadByte() { }

	// RVA: 0x34EA2F0 Offset: 0x34EA3F1 VA: 0x34EA2F0 Slot: 27
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x34EA480 Offset: 0x34EA581 VA: 0x34EA480 Slot: 28
	public override void SetLength(long value) { }

	// RVA: 0x34EA580 Offset: 0x34EA681 VA: 0x34EA580 Slot: 36
	public virtual byte[] ToArray() { }

	// RVA: 0x34EA650 Offset: 0x34EA751 VA: 0x34EA650 Slot: 31
	public override void Write(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x47C260 Offset: 0x47C361 VA: 0x47C260
	// RVA: 0x34EA950 Offset: 0x34EAA51 VA: 0x34EA950 Slot: 26
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x34EACB0 Offset: 0x34EADB1 VA: 0x34EACB0 Slot: 32
	public override void WriteByte(byte value) { }
}

