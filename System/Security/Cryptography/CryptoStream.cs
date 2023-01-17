// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x473DC0 Offset: 0x473EC1 VA: 0x473DC0
public class CryptoStream : Stream, IDisposable // TypeDefIndex: 915
{
	// Fields
	private Stream _stream; // 0x28
	private ICryptoTransform _Transform; // 0x30
	private byte[] _InputBuffer; // 0x38
	private int _InputBufferIndex; // 0x40
	private int _InputBlockSize; // 0x44
	private byte[] _OutputBuffer; // 0x48
	private int _OutputBufferIndex; // 0x50
	private int _OutputBlockSize; // 0x54
	private CryptoStreamMode _transformMode; // 0x58
	private bool _canRead; // 0x5C
	private bool _canWrite; // 0x5D
	private bool _finalBlockTransformed; // 0x5E

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public bool HasFlushedFinalBlock { get; }

	// Methods

	// RVA: 0x37DA0B0 Offset: 0x37DA1B1 VA: 0x37DA0B0
	public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

	// RVA: 0x37DA410 Offset: 0x37DA511 VA: 0x37DA410 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x37DA420 Offset: 0x37DA521 VA: 0x37DA420 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x37DA430 Offset: 0x37DA531 VA: 0x37DA430 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x37DA440 Offset: 0x37DA541 VA: 0x37DA440 Slot: 11
	public override long get_Length() { }

	// RVA: 0x37DA4A0 Offset: 0x37DA5A1 VA: 0x37DA4A0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x37DA500 Offset: 0x37DA601 VA: 0x37DA500 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x37DA560 Offset: 0x37DA661 VA: 0x37DA560
	public bool get_HasFlushedFinalBlock() { }

	// RVA: 0x37DA570 Offset: 0x37DA671 VA: 0x37DA570
	public void FlushFinalBlock() { }

	// RVA: 0x37DA7A0 Offset: 0x37DA8A1 VA: 0x37DA7A0 Slot: 20
	public override void Flush() { }

	// RVA: 0x37DA7B0 Offset: 0x37DA8B1 VA: 0x37DA7B0 Slot: 27
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x37DA810 Offset: 0x37DA911 VA: 0x37DA810 Slot: 28
	public override void SetLength(long value) { }

	// RVA: 0x37DA870 Offset: 0x37DA971 VA: 0x37DA870 Slot: 29
	public override int Read([In] [Out] byte[] buffer, int offset, int count) { }

	// RVA: 0x37DAF30 Offset: 0x37DB031 VA: 0x37DAF30 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x47CF80 Offset: 0x47D081 VA: 0x47CF80
	// RVA: 0x37DB200 Offset: 0x37DB301 VA: 0x37DB200
	private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x37DB3C0 Offset: 0x37DB4C1 VA: 0x37DB3C0 Slot: 31
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x37DB8E0 Offset: 0x37DB9E1 VA: 0x37DB8E0 Slot: 26
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x47CFF0 Offset: 0x47D0F1 VA: 0x47CFF0
	// RVA: 0x37DBBA0 Offset: 0x37DBCA1 VA: 0x37DBBA0
	private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x37DBD60 Offset: 0x37DBE61 VA: 0x37DBD60
	public void Clear() { }

	// RVA: 0x37DBD70 Offset: 0x37DBE71 VA: 0x37DBD70 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x37DA2A0 Offset: 0x37DA3A1 VA: 0x37DA2A0
	private void InitializeBuffer() { }
}

