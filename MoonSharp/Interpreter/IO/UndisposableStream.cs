// Namespace: MoonSharp.Interpreter.IO
public class UndisposableStream : Stream // TypeDefIndex: 6173
{
	// Fields
	private Stream m_Stream; // 0x28

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x33511F0 Offset: 0x33512F1 VA: 0x33511F0
	public void .ctor(Stream stream) { }

	// RVA: 0x3351270 Offset: 0x3351371 VA: 0x3351270 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3351280 Offset: 0x3351381 VA: 0x3351280 Slot: 18
	public override void Close() { }

	// RVA: 0x3351290 Offset: 0x3351391 VA: 0x3351290 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x33512A0 Offset: 0x33513A1 VA: 0x33512A0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x33512B0 Offset: 0x33513B1 VA: 0x33512B0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x33512C0 Offset: 0x33513C1 VA: 0x33512C0 Slot: 20
	public override void Flush() { }

	// RVA: 0x33512E0 Offset: 0x33513E1 VA: 0x33512E0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x33512F0 Offset: 0x33513F1 VA: 0x33512F0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x3351300 Offset: 0x3351401 VA: 0x3351300 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x3351320 Offset: 0x3351421 VA: 0x3351320 Slot: 29
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x3351340 Offset: 0x3351441 VA: 0x3351340 Slot: 27
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x3351360 Offset: 0x3351461 VA: 0x3351360 Slot: 28
	public override void SetLength(long value) { }

	// RVA: 0x3351380 Offset: 0x3351481 VA: 0x3351380 Slot: 31
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x33513A0 Offset: 0x33514A1 VA: 0x33513A0 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x33513C0 Offset: 0x33514C1 VA: 0x33513C0 Slot: 24
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x33513E0 Offset: 0x33514E1 VA: 0x33513E0 Slot: 25
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x3351400 Offset: 0x3351501 VA: 0x3351400 Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x3351420 Offset: 0x3351521 VA: 0x3351420 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x3351430 Offset: 0x3351531 VA: 0x3351430 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x3351440 Offset: 0x3351541 VA: 0x3351440 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3351450 Offset: 0x3351551 VA: 0x3351450 Slot: 30
	public override int ReadByte() { }

	// RVA: 0x3351470 Offset: 0x3351571 VA: 0x3351470 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x3351490 Offset: 0x3351591 VA: 0x3351490 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x33514B0 Offset: 0x33515B1 VA: 0x33514B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x33514C0 Offset: 0x33515C1 VA: 0x33514C0 Slot: 32
	public override void WriteByte(byte value) { }

	// RVA: 0x33514E0 Offset: 0x33515E1 VA: 0x33514E0 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x3351500 Offset: 0x3351601 VA: 0x3351500 Slot: 17
	public override void set_WriteTimeout(int value) { }
}

