// Namespace: System.Net
internal class WebRequestStream : WebConnectionStream // TypeDefIndex: 2605
{
	// Fields
	private static byte[] crlf; // 0x0
	private MemoryStream writeBuffer; // 0x68
	private bool requestWritten; // 0x70
	private bool allowBuffering; // 0x71
	private bool sendChunked; // 0x72
	private WebCompletionSource pendingWrite; // 0x78
	private long totalWritten; // 0x80
	private byte[] headers; // 0x88
	private bool headersSent; // 0x90
	private int completeRequestWritten; // 0x94
	private int chunkTrailerWritten; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x31A30 Offset: 0x31B31 VA: 0x31A30
	private readonly bool <KeepAlive>k__BackingField; // 0x9C

	// Properties
	public bool KeepAlive { get; }
	public override long Length { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	internal bool HasWriteBuffer { get; }
	internal int WriteBufferLength { get; }

	// Methods

	// RVA: 0x1951680 Offset: 0x1951781 VA: 0x1951680
	public void .ctor(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) { }

	[CompilerGeneratedAttribute] // RVA: 0x33020 Offset: 0x33121 VA: 0x33020
	// RVA: 0x1951850 Offset: 0x1951951 VA: 0x1951850
	public bool get_KeepAlive() { }

	// RVA: 0x1951860 Offset: 0x1951961 VA: 0x1951860 Slot: 11
	public override long get_Length() { }

	// RVA: 0x19518A0 Offset: 0x19519A1 VA: 0x19518A0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x19518B0 Offset: 0x19519B1 VA: 0x19518B0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x19518C0 Offset: 0x19519C1 VA: 0x19518C0
	internal bool get_HasWriteBuffer() { }

	// RVA: 0x19518F0 Offset: 0x19519F1 VA: 0x19518F0
	internal int get_WriteBufferLength() { }

	// RVA: 0x1951940 Offset: 0x1951A41 VA: 0x1951940
	internal BufferOffsetSize GetWriteBuffer() { }

	[AsyncStateMachineAttribute] // RVA: 0x33030 Offset: 0x33131 VA: 0x33030
	// RVA: 0x1951A20 Offset: 0x1951B21 VA: 0x1951A20
	private Task FinishWriting(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x330A0 Offset: 0x331A1 VA: 0x330A0
	// RVA: 0x1951B80 Offset: 0x1951C81 VA: 0x1951B80 Slot: 26
	public override Task WriteAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x33110 Offset: 0x33211 VA: 0x33110
	// RVA: 0x1951D30 Offset: 0x1951E31 VA: 0x1951D30
	private Task ProcessWrite(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1951EE0 Offset: 0x1951FE1 VA: 0x1951EE0
	private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

	[AsyncStateMachineAttribute] // RVA: 0x33180 Offset: 0x33281 VA: 0x33180
	// RVA: 0x1951F80 Offset: 0x1952081 VA: 0x1951F80
	internal Task Initialize(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x331F0 Offset: 0x332F1 VA: 0x331F0
	// RVA: 0x19520E0 Offset: 0x19521E1 VA: 0x19520E0
	private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x33260 Offset: 0x33361 VA: 0x33260
	// RVA: 0x1952250 Offset: 0x1952351 VA: 0x1952250
	internal Task WriteRequestAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x332D0 Offset: 0x333D1 VA: 0x332D0
	// RVA: 0x19523C0 Offset: 0x19524C1 VA: 0x19523C0
	private Task WriteChunkTrailer_inner(CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x33340 Offset: 0x33441 VA: 0x33340
	// RVA: 0x1952520 Offset: 0x1952621 VA: 0x1952520
	private Task WriteChunkTrailer() { }

	// RVA: 0x1951F70 Offset: 0x1952071 VA: 0x1951F70
	internal void KillBuffer() { }

	// RVA: 0x1952680 Offset: 0x1952781 VA: 0x1952680 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1952740 Offset: 0x1952841 VA: 0x1952740 Slot: 33
	protected override void Close_internal(ref bool disposed) { }

	// RVA: 0x1952920 Offset: 0x1952A21 VA: 0x1952920
	private static void .cctor() { }
}

