// Namespace: Mono.Net.Security
internal abstract class MobileAuthenticatedStream : AuthenticatedStream, IMonoSslStream, IDisposable // TypeDefIndex: 2198
{
	// Fields
	private MobileTlsContext xobileTlsContext; // 0x38
	private ExceptionDispatchInfo lastException; // 0x40
	private AsyncProtocolRequest asyncHandshakeRequest; // 0x48
	private AsyncProtocolRequest asyncReadRequest; // 0x50
	private AsyncProtocolRequest asyncWriteRequest; // 0x58
	private BufferOffsetSize2 readBuffer; // 0x60
	private BufferOffsetSize2 writeBuffer; // 0x68
	private object ioLock; // 0x70
	private int closeRequested; // 0x78
	private bool shutdown; // 0x7C
	private static int uniqueNameInteger; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x31500 Offset: 0x31601 VA: 0x31500
	private readonly SslStream <SslStream>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x31510 Offset: 0x31611 VA: 0x31510
	private readonly MonoTlsSettings <Settings>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x31520 Offset: 0x31621 VA: 0x31520
	private readonly MonoTlsProvider <Provider>k__BackingField; // 0x90
	private static int nextId; // 0x4
	internal readonly int ID; // 0x98

	// Properties
	public MonoTlsSettings Settings { get; }
	public MonoTlsProvider Provider { get; }
	public AuthenticatedStream AuthenticatedStream { get; }
	public override bool IsAuthenticated { get; }
	public X509Certificate InternalLocalCertificate { get; }
	public override bool CanRead { get; }
	public override bool CanTimeout { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x1AC64D0 Offset: 0x1AC65D1 VA: 0x1AC64D0
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider) { }

	[CompilerGeneratedAttribute] // RVA: 0x31F00 Offset: 0x32001 VA: 0x31F00
	// RVA: 0x1AC6660 Offset: 0x1AC6761 VA: 0x1AC6660
	public MonoTlsSettings get_Settings() { }

	[CompilerGeneratedAttribute] // RVA: 0x31F10 Offset: 0x32011 VA: 0x31F10
	// RVA: 0x1AC6670 Offset: 0x1AC6771 VA: 0x1AC6670 Slot: 55
	public MonoTlsProvider get_Provider() { }

	// RVA: 0x1AC6680 Offset: 0x1AC6781 VA: 0x1AC6680
	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = False) { }

	// RVA: 0x1AC6750 Offset: 0x1AC6851 VA: 0x1AC6750
	internal static Exception GetSSPIException(Exception e) { }

	// RVA: 0x1AC68C0 Offset: 0x1AC69C1 VA: 0x1AC68C0
	internal static Exception GetIOException(Exception e, string message) { }

	// RVA: 0x1AC6A10 Offset: 0x1AC6B11 VA: 0x1AC6A10
	internal ExceptionDispatchInfo SetException(Exception e) { }

	// RVA: 0x1AC6A60 Offset: 0x1AC6B61 VA: 0x1AC6A60 Slot: 34
	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x1AC6C90 Offset: 0x1AC6D91 VA: 0x1AC6C90 Slot: 35
	public Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x1AC6CD0 Offset: 0x1AC6DD1 VA: 0x1AC6CD0 Slot: 49
	public AuthenticatedStream get_AuthenticatedStream() { }

	[AsyncStateMachineAttribute] // RVA: 0x31F20 Offset: 0x32021 VA: 0x31F20
	// RVA: 0x1AC6AA0 Offset: 0x1AC6BA1 VA: 0x1AC6AA0
	private Task ProcessAuthentication(bool runSynchronously, bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool clientCertRequired) { }

	// RVA: -1 Offset: -1 Slot: 56
	protected abstract MobileTlsContext CreateContext(bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert);

	// RVA: 0x1AC6CE0 Offset: 0x1AC6DE1 VA: 0x1AC6CE0 Slot: 21
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1AC6FA0 Offset: 0x1AC70A1 VA: 0x1AC6FA0 Slot: 22
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1AC7000 Offset: 0x1AC7101 VA: 0x1AC7000 Slot: 24
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1AC7100 Offset: 0x1AC7201 VA: 0x1AC7100 Slot: 25
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1AC7110 Offset: 0x1AC7211 VA: 0x1AC7110 Slot: 29
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1AC7200 Offset: 0x1AC7301 VA: 0x1AC7200 Slot: 31
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1AC72E0 Offset: 0x1AC73E1 VA: 0x1AC72E0 Slot: 23
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1AC7390 Offset: 0x1AC7491 VA: 0x1AC7390 Slot: 26
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x31F90 Offset: 0x32091 VA: 0x31F90
	// RVA: 0x1AC6DE0 Offset: 0x1AC6EE1 VA: 0x1AC6DE0
	private Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	// RVA: 0x1AC7440 Offset: 0x1AC7541 VA: 0x1AC7440
	internal int InternalRead(byte[] buffer, int offset, int size, out bool outWantMore) { }

	// RVA: 0x1AC7580 Offset: 0x1AC7681 VA: 0x1AC7580
	private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size) { }

	// RVA: 0x1AC7700 Offset: 0x1AC7801 VA: 0x1AC7700
	internal bool InternalWrite(byte[] buffer, int offset, int size) { }

	// RVA: 0x1AC7830 Offset: 0x1AC7931 VA: 0x1AC7830
	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size) { }

	[AsyncStateMachineAttribute] // RVA: 0x32000 Offset: 0x32101 VA: 0x32000
	// RVA: 0x1AC7930 Offset: 0x1AC7A31 VA: 0x1AC7930
	internal Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x32070 Offset: 0x32171 VA: 0x32070
	// RVA: 0x1AC7AE0 Offset: 0x1AC7BE1 VA: 0x1AC7AE0
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	// RVA: 0x1AC7C50 Offset: 0x1AC7D51 VA: 0x1AC7C50
	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status) { }

	// RVA: 0x1AC7E50 Offset: 0x1AC7F51 VA: 0x1AC7E50
	internal ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer) { }

	// RVA: 0x1AC7F60 Offset: 0x1AC8061 VA: 0x1AC7F60
	internal ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer) { }

	// RVA: 0x1AC8070 Offset: 0x1AC8171 VA: 0x1AC8070 Slot: 33
	public override bool get_IsAuthenticated() { }

	// RVA: 0x1AC8170 Offset: 0x1AC8271 VA: 0x1AC8170 Slot: 19
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1AC8420 Offset: 0x1AC8521 VA: 0x1AC8420 Slot: 20
	public override void Flush() { }

	// RVA: 0x1AC8440 Offset: 0x1AC8541 VA: 0x1AC8440 Slot: 54
	public X509Certificate get_InternalLocalCertificate() { }

	// RVA: 0x1AC8560 Offset: 0x1AC8661 VA: 0x1AC8560 Slot: 27
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1AC85A0 Offset: 0x1AC86A1 VA: 0x1AC85A0 Slot: 28
	public override void SetLength(long value) { }

	// RVA: 0x1AC85C0 Offset: 0x1AC86C1 VA: 0x1AC85C0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1AC8610 Offset: 0x1AC8711 VA: 0x1AC8610 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1AC8620 Offset: 0x1AC8721 VA: 0x1AC8620 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1AC8680 Offset: 0x1AC8781 VA: 0x1AC8680 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1AC8690 Offset: 0x1AC8791 VA: 0x1AC8690 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1AC86A0 Offset: 0x1AC87A1 VA: 0x1AC86A0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1AC86B0 Offset: 0x1AC87B1 VA: 0x1AC86B0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1AC86F0 Offset: 0x1AC87F1 VA: 0x1AC86F0 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1AC8710 Offset: 0x1AC8811 VA: 0x1AC8710 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1AC8730 Offset: 0x1AC8831 VA: 0x1AC8730 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1AC8750 Offset: 0x1AC8851 VA: 0x1AC8750 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1AC8770 Offset: 0x1AC8871 VA: 0x1AC8770
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x320E0 Offset: 0x321E1 VA: 0x320E0
	// RVA: 0x1AC87C0 Offset: 0x1AC88C1 VA: 0x1AC87C0
	private void <InnerWrite>b__67_0() { }
}

