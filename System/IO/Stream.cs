// Namespace: System.IO
[ComVisibleAttribute] // RVA: 0x472B20 Offset: 0x472C21 VA: 0x472B20
[Serializable]
public abstract class Stream : MarshalByRefObject, IDisposable // TypeDefIndex: 642
{
	// Fields
	public static readonly Stream Null; // 0x0
	private Stream.ReadWriteTask _activeReadWriteTask; // 0x18
	private SemaphoreSlim _asyncActiveSemaphore; // 0x20

	// Properties
	public abstract bool CanRead { get; }
	public abstract bool CanSeek { get; }
	[ComVisibleAttribute] // RVA: 0x47DE20 Offset: 0x47DF21 VA: 0x47DE20
	public virtual bool CanTimeout { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; set; }
	[ComVisibleAttribute] // RVA: 0x47DE40 Offset: 0x47DF41 VA: 0x47DE40
	public virtual int ReadTimeout { get; set; }
	[ComVisibleAttribute] // RVA: 0x47DE60 Offset: 0x47DF61 VA: 0x47DE60
	public virtual int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x3831AF0 Offset: 0x3831BF1 VA: 0x3831AF0
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_CanSeek();

	// RVA: 0x3831C20 Offset: 0x3831D21 VA: 0x3831C20 Slot: 9
	public virtual bool get_CanTimeout() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_CanWrite();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_Length();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_Position();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_Position(long value);

	// RVA: 0x3831C30 Offset: 0x3831D31 VA: 0x3831C30 Slot: 14
	public virtual int get_ReadTimeout() { }

	// RVA: 0x3831C90 Offset: 0x3831D91 VA: 0x3831C90 Slot: 15
	public virtual void set_ReadTimeout(int value) { }

	// RVA: 0x3831CF0 Offset: 0x3831DF1 VA: 0x3831CF0 Slot: 16
	public virtual int get_WriteTimeout() { }

	// RVA: 0x3831D50 Offset: 0x3831E51 VA: 0x3831D50 Slot: 17
	public virtual void set_WriteTimeout(int value) { }

	// RVA: 0x3831DB0 Offset: 0x3831EB1 VA: 0x3831DB0 Slot: 18
	public virtual void Close() { }

	// RVA: 0x3831E40 Offset: 0x3831F41 VA: 0x3831E40 Slot: 6
	public void Dispose() { }

	// RVA: 0x3831E50 Offset: 0x3831F51 VA: 0x3831E50 Slot: 19
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void Flush();

	// RVA: 0x3831E60 Offset: 0x3831F61 VA: 0x3831E60 Slot: 21
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x3831E70 Offset: 0x3831F71 VA: 0x3831E70
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x3832540 Offset: 0x3832641 VA: 0x3832540 Slot: 22
	public virtual int EndRead(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0x47C280 Offset: 0x47C381 VA: 0x47C280
	// RVA: 0x38327D0 Offset: 0x38328D1 VA: 0x38327D0 Slot: 23
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x38328A0 Offset: 0x38329A1 VA: 0x38328A0
	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x3832AE0 Offset: 0x3832BE1 VA: 0x3832AE0 Slot: 24
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x3832AF0 Offset: 0x3832BF1 VA: 0x3832AF0
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously) { }

	// RVA: 0x3832220 Offset: 0x3832321 VA: 0x3832220
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x3832440 Offset: 0x3832541 VA: 0x3832440
	private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x3832EA0 Offset: 0x3832FA1 VA: 0x3832EA0 Slot: 25
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	[ComVisibleAttribute] // RVA: 0x47C2A0 Offset: 0x47C3A1 VA: 0x47C2A0
	// RVA: 0x3833110 Offset: 0x3833211 VA: 0x3833110
	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	[ComVisibleAttribute] // RVA: 0x47C2C0 Offset: 0x47C3C1 VA: 0x47C2C0
	// RVA: 0x38331B0 Offset: 0x38332B1 VA: 0x38331B0 Slot: 26
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x3833270 Offset: 0x3833371 VA: 0x3833270
	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract long Seek(long offset, SeekOrigin origin);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void SetLength(long value);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract int Read([In] [Out] byte[] buffer, int offset, int count);

	// RVA: 0x38334B0 Offset: 0x38335B1 VA: 0x38334B0 Slot: 30
	public virtual int ReadByte() { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void Write(byte[] buffer, int offset, int count);

	// RVA: 0x3833560 Offset: 0x3833661 VA: 0x3833560 Slot: 32
	public virtual void WriteByte(byte value) { }

	// RVA: 0x38320B0 Offset: 0x38321B1 VA: 0x38320B0
	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x38327C0 Offset: 0x38328C1 VA: 0x38327C0
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	// RVA: 0x3832D30 Offset: 0x3832E31 VA: 0x3832D30
	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x3833100 Offset: 0x3833201 VA: 0x3833100
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x38335F0 Offset: 0x38336F1 VA: 0x38335F0
	protected void .ctor() { }

	// RVA: 0x3833600 Offset: 0x3833701 VA: 0x3833600
	private static void .cctor() { }
}

