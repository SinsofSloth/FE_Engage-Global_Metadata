// Namespace: System.Net.Sockets
public class NetworkStream : Stream // TypeDefIndex: 2621
{
	// Fields
	private Socket m_StreamSocket; // 0x28
	private bool m_Readable; // 0x30
	private bool m_Writeable; // 0x31
	private bool m_OwnsSocket; // 0x32
	private int m_CloseTimeout; // 0x34
	private bool m_CleanedUp; // 0x38
	private int m_CurrentReadTimeout; // 0x3C
	private int m_CurrentWriteTimeout; // 0x40

	// Properties
	internal Socket InternalSocket { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1ACF200 Offset: 0x1ACF301 VA: 0x1ACF200
	public void .ctor(Socket socket) { }

	// RVA: 0x1ACF3D0 Offset: 0x1ACF4D1 VA: 0x1ACF3D0
	public void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x1ACF4D0 Offset: 0x1ACF5D1 VA: 0x1ACF4D0
	internal Socket get_InternalSocket() { }

	// RVA: 0x1ACF570 Offset: 0x1ACF671 VA: 0x1ACF570 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1ACF580 Offset: 0x1ACF681 VA: 0x1ACF580 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1ACF590 Offset: 0x1ACF691 VA: 0x1ACF590 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1ACF5A0 Offset: 0x1ACF6A1 VA: 0x1ACF5A0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1ACF5B0 Offset: 0x1ACF6B1 VA: 0x1ACF5B0 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1ACF640 Offset: 0x1ACF741 VA: 0x1ACF640 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1ACF7D0 Offset: 0x1ACF8D1 VA: 0x1ACF7D0 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1ACF860 Offset: 0x1ACF961 VA: 0x1ACF860 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1ACF930 Offset: 0x1ACFA31 VA: 0x1ACF930 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1ACF990 Offset: 0x1ACFA91 VA: 0x1ACF990 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1ACF9F0 Offset: 0x1ACFAF1 VA: 0x1ACF9F0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1ACFA50 Offset: 0x1ACFB51 VA: 0x1ACFA50 Slot: 27
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1ACF2E0 Offset: 0x1ACF3E1 VA: 0x1ACF2E0
	internal void InitNetworkStream(Socket socket, FileAccess Access) { }

	// RVA: 0x1ACFAB0 Offset: 0x1ACFBB1 VA: 0x1ACFAB0 Slot: 29
	public override int Read([In] [Out] byte[] buffer, int offset, int size) { }

	// RVA: 0x1ACFEA0 Offset: 0x1ACFFA1 VA: 0x1ACFEA0 Slot: 31
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1AD0290 Offset: 0x1AD0391 VA: 0x1AD0290 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1AD0320 Offset: 0x1AD0421 VA: 0x1AD0320 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1AD03A0 Offset: 0x1AD04A1 VA: 0x1AD03A0 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1AD07B0 Offset: 0x1AD08B1 VA: 0x1AD07B0 Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1AD0AC0 Offset: 0x1AD0BC1 VA: 0x1AD0AC0 Slot: 24
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1AD0ED0 Offset: 0x1AD0FD1 VA: 0x1AD0ED0 Slot: 25
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1AD11E0 Offset: 0x1AD12E1 VA: 0x1AD11E0 Slot: 20
	public override void Flush() { }

	// RVA: 0x1AD11F0 Offset: 0x1AD12F1 VA: 0x1AD11F0 Slot: 28
	public override void SetLength(long value) { }

	// RVA: 0x1ACF710 Offset: 0x1ACF811 VA: 0x1ACF710
	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent) { }
}

