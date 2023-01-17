// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472D80 Offset: 0x472E81 VA: 0x472D80
public class FileStream : Stream // TypeDefIndex: 666
{
	// Fields
	private static byte[] buf_recycle; // 0x0
	private static readonly object buf_recycle_lock; // 0x8
	private byte[] buf; // 0x28
	private string name; // 0x30
	private SafeFileHandle safeHandle; // 0x38
	private bool isExposed; // 0x40
	private long append_startpos; // 0x48
	private FileAccess access; // 0x50
	private bool owner; // 0x54
	private bool async; // 0x55
	private bool canseek; // 0x56
	private bool anonymous; // 0x57
	private bool buf_dirty; // 0x58
	private int buf_size; // 0x5C
	private int buf_length; // 0x60
	private int buf_offset; // 0x64
	private long buf_start; // 0x68

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public virtual SafeFileHandle SafeFileHandle { get; }

	// Methods

	[ObsoleteAttribute] // RVA: 0x47C390 Offset: 0x47C491 VA: 0x47C390
	// RVA: 0x38AF3C0 Offset: 0x38AF4C1 VA: 0x38AF3C0
	public void .ctor(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize) { }

	// RVA: 0x38AF3D0 Offset: 0x38AF4D1 VA: 0x38AF3D0
	internal void .ctor(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x38AF940 Offset: 0x38AFA41 VA: 0x38AF940
	public void .ctor(string path, FileMode mode, FileAccess access) { }

	// RVA: 0x38ACED0 Offset: 0x38ACFD1 VA: 0x38ACED0
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share) { }

	// RVA: 0x38AC310 Offset: 0x38AC411 VA: 0x38AC310
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) { }

	// RVA: 0x38B01E0 Offset: 0x38B02E1 VA: 0x38B01E0
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) { }

	// RVA: 0x38B0210 Offset: 0x38B0311 VA: 0x38B0210
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) { }

	// RVA: 0x38B0240 Offset: 0x38B0341 VA: 0x38B0240
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options, string msgPath, bool bFromProxy, bool useLongPath = False, bool checkHost = False) { }

	// RVA: 0x38AF980 Offset: 0x38AFA81 VA: 0x38AF980
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous) { }

	// RVA: 0x38AF9A0 Offset: 0x38AFAA1 VA: 0x38AF9A0
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options) { }

	// RVA: 0x38AF590 Offset: 0x38AF691 VA: 0x38AF590
	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x38B0730 Offset: 0x38B0831 VA: 0x38B0730 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x38B0750 Offset: 0x38B0851 VA: 0x38B0750 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x38B0770 Offset: 0x38B0871 VA: 0x38B0770 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x38B0780 Offset: 0x38B0881 VA: 0x38B0780 Slot: 11
	public override long get_Length() { }

	// RVA: 0x38B09A0 Offset: 0x38B0AA1 VA: 0x38B09A0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x38B0BC0 Offset: 0x38B0CC1 VA: 0x38B0BC0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x38B0C50 Offset: 0x38B0D51 VA: 0x38B0C50 Slot: 33
	public virtual SafeFileHandle get_SafeFileHandle() { }

	// RVA: 0x38B06A0 Offset: 0x38B07A1 VA: 0x38B06A0
	private void ExposeHandle() { }

	// RVA: 0x38B0F60 Offset: 0x38B1061 VA: 0x38B0F60 Slot: 30
	public override int ReadByte() { }

	// RVA: 0x38B12E0 Offset: 0x38B13E1 VA: 0x38B12E0 Slot: 32
	public override void WriteByte(byte value) { }

	// RVA: 0x38B1430 Offset: 0x38B1531 VA: 0x38B1430 Slot: 29
	public override int Read([In] [Out] byte[] array, int offset, int count) { }

	// RVA: 0x38B1680 Offset: 0x38B1781 VA: 0x38B1680
	private int ReadInternal(byte[] dest, int offset, int count) { }

	// RVA: 0x38B1910 Offset: 0x38B1A11 VA: 0x38B1910 Slot: 21
	public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x38B1BA0 Offset: 0x38B1CA1 VA: 0x38B1BA0 Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x38B1D20 Offset: 0x38B1E21 VA: 0x38B1D20 Slot: 31
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x38B1F40 Offset: 0x38B2041 VA: 0x38B1F40
	private void WriteInternal(byte[] src, int offset, int count) { }

	// RVA: 0x38B22B0 Offset: 0x38B23B1 VA: 0x38B22B0 Slot: 24
	public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x38B2690 Offset: 0x38B2791 VA: 0x38B2690 Slot: 25
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x38B2810 Offset: 0x38B2911 VA: 0x38B2810 Slot: 27
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x38B2B10 Offset: 0x38B2C11 VA: 0x38B2B10 Slot: 28
	public override void SetLength(long value) { }

	// RVA: 0x38B2DC0 Offset: 0x38B2EC1 VA: 0x38B2DC0 Slot: 20
	public override void Flush() { }

	// RVA: 0x38B2E40 Offset: 0x38B2F41 VA: 0x38B2E40 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x38B2EC0 Offset: 0x38B2FC1 VA: 0x38B2EC0 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x38B33A0 Offset: 0x38B34A1 VA: 0x38B33A0 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x38B33B0 Offset: 0x38B34B1 VA: 0x38B33B0 Slot: 26
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x38B1840 Offset: 0x38B1941 VA: 0x38B1840
	private int ReadSegment(byte[] dest, int dest_offset, int count) { }

	// RVA: 0x38B2230 Offset: 0x38B2331 VA: 0x38B2230
	private int WriteSegment(byte[] src, int src_offset, int count) { }

	// RVA: 0x38B0CF0 Offset: 0x38B0DF1 VA: 0x38B0CF0
	private void FlushBuffer() { }

	// RVA: 0x38B0990 Offset: 0x38B0A91 VA: 0x38B0990
	private void FlushBufferIfDirty() { }

	// RVA: 0x38B12A0 Offset: 0x38B13A1 VA: 0x38B12A0
	private void RefillBuffer() { }

	// RVA: 0x38B10D0 Offset: 0x38B11D1 VA: 0x38B10D0
	private int ReadData(SafeHandle safeHandle, byte[] buf, int offset, int count) { }

	// RVA: 0x38B03C0 Offset: 0x38B04C1 VA: 0x38B03C0
	private void InitBuffer(int size, bool isZeroSize) { }

	// RVA: 0x38B0320 Offset: 0x38B0421 VA: 0x38B0320
	private string GetSecureFileName(string filename) { }

	// RVA: 0x38B0250 Offset: 0x38B0351 VA: 0x38B0250
	private string GetSecureFileName(string filename, bool full) { }

	// RVA: 0x38B33C0 Offset: 0x38B34C1 VA: 0x38B33C0
	private static void .cctor() { }
}

