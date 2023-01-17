// Namespace: System.Net.Security
public class SslStream : AuthenticatedStream // TypeDefIndex: 2648
{
	// Fields
	private MonoTlsProvider provider; // 0x38
	private IMonoSslStream impl; // 0x40

	// Properties
	internal IMonoSslStream Impl { get; }
	public override bool IsAuthenticated { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanTimeout { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x2D11460 Offset: 0x2D11561 VA: 0x2D11460
	internal IMonoSslStream get_Impl() { }

	// RVA: 0x2D11540 Offset: 0x2D11641 VA: 0x2D11540
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x2D115D0 Offset: 0x2D116D1 VA: 0x2D115D0
	internal static IMonoSslStream CreateMonoSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x2D116E0 Offset: 0x2D117E1 VA: 0x2D116E0 Slot: 33
	public override bool get_IsAuthenticated() { }

	// RVA: 0x2D117D0 Offset: 0x2D118D1 VA: 0x2D117D0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x2D117E0 Offset: 0x2D118E1 VA: 0x2D117E0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x2D118A0 Offset: 0x2D119A1 VA: 0x2D118A0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x2D118B0 Offset: 0x2D119B1 VA: 0x2D118B0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x2D11970 Offset: 0x2D11A71 VA: 0x2D11970 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x2D11A60 Offset: 0x2D11B61 VA: 0x2D11A60 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x2D11B60 Offset: 0x2D11C61 VA: 0x2D11B60 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x2D11C50 Offset: 0x2D11D51 VA: 0x2D11C50 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x2D11D50 Offset: 0x2D11E51 VA: 0x2D11D50 Slot: 11
	public override long get_Length() { }

	// RVA: 0x2D11E40 Offset: 0x2D11F41 VA: 0x2D11E40 Slot: 12
	public override long get_Position() { }

	// RVA: 0x2D11F30 Offset: 0x2D12031 VA: 0x2D11F30 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x2D11F90 Offset: 0x2D12091 VA: 0x2D11F90 Slot: 28
	public override void SetLength(long value) { }

	// RVA: 0x2D12090 Offset: 0x2D12191 VA: 0x2D12090 Slot: 27
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x2D120F0 Offset: 0x2D121F1 VA: 0x2D120F0 Slot: 20
	public override void Flush() { }

	// RVA: 0x2D114D0 Offset: 0x2D115D1 VA: 0x2D114D0
	private void CheckDisposed() { }

	// RVA: 0x2D12110 Offset: 0x2D12211 VA: 0x2D12110 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2D12230 Offset: 0x2D12331 VA: 0x2D12230 Slot: 29
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x2D12350 Offset: 0x2D12451 VA: 0x2D12350 Slot: 31
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x2D12470 Offset: 0x2D12571 VA: 0x2D12470 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x2D125A0 Offset: 0x2D126A1 VA: 0x2D125A0 Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x2D126A0 Offset: 0x2D127A1 VA: 0x2D126A0 Slot: 24
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x2D127D0 Offset: 0x2D128D1 VA: 0x2D127D0 Slot: 25
	public override void EndWrite(IAsyncResult asyncResult) { }
}

