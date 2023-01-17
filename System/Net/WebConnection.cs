// Namespace: System.Net
internal class WebConnection : IDisposable // TypeDefIndex: 2587
{
	// Fields
	private NetworkCredential ntlm_credentials; // 0x10
	private bool ntlm_authenticated; // 0x18
	private bool unsafe_sharing; // 0x19
	private Stream networkStream; // 0x20
	private Socket socket; // 0x28
	private MonoTlsStream monoTlsStream; // 0x30
	private WebConnectionTunnel tunnel; // 0x38
	private int disposed; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x318F0 Offset: 0x319F1 VA: 0x318F0
	private readonly ServicePoint <ServicePoint>k__BackingField; // 0x48
	private DateTime idleSince; // 0x50
	private WebOperation currentOperation; // 0x58

	// Properties
	public ServicePoint ServicePoint { get; }
	public bool Closed { get; }
	public DateTime IdleSince { get; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x32A40 Offset: 0x32B41 VA: 0x32A40
	// RVA: 0x1946480 Offset: 0x1946581 VA: 0x1946480
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1946490 Offset: 0x1946591 VA: 0x1946490
	public void .ctor(ServicePoint sPoint) { }

	// RVA: 0x19464D0 Offset: 0x19465D1 VA: 0x19464D0
	private bool CanReuse() { }

	// RVA: 0x1946500 Offset: 0x1946601 VA: 0x1946500
	private bool CheckReusable() { }

	[AsyncStateMachineAttribute] // RVA: 0x32A50 Offset: 0x32B51 VA: 0x32A50
	// RVA: 0x19465D0 Offset: 0x19466D1 VA: 0x19465D0
	private Task Connect(WebOperation operation, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x32AC0 Offset: 0x32BC1 VA: 0x32AC0
	// RVA: 0x1946770 Offset: 0x1946871 VA: 0x1946770
	private Task<bool> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken) { }

	[AsyncStateMachineAttribute] // RVA: 0x32B30 Offset: 0x32C31 VA: 0x32B30
	// RVA: 0x1946950 Offset: 0x1946A51 VA: 0x1946950
	internal Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x1946B10 Offset: 0x1946C11 VA: 0x1946B10
	internal static WebException GetException(WebExceptionStatus status, Exception error) { }

	// RVA: 0x1946EF0 Offset: 0x1946FF1 VA: 0x1946EF0
	internal static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x1947110 Offset: 0x1947211 VA: 0x1947110
	internal bool CanReuseConnection(WebOperation operation) { }

	// RVA: 0x1947550 Offset: 0x1947651 VA: 0x1947550
	private bool PrepareSharingNtlm(WebOperation operation) { }

	// RVA: 0x1947870 Offset: 0x1947971 VA: 0x1947870
	private void Reset() { }

	// RVA: 0x19479A0 Offset: 0x1947AA1 VA: 0x19479A0
	private void Close(bool reset) { }

	// RVA: 0x1947A80 Offset: 0x1947B81 VA: 0x1947A80
	private void CloseSocket() { }

	// RVA: 0x1947540 Offset: 0x1947641 VA: 0x1947540
	public bool get_Closed() { }

	// RVA: 0x1947CD0 Offset: 0x1947DD1 VA: 0x1947CD0
	public DateTime get_IdleSince() { }

	// RVA: 0x1947CE0 Offset: 0x1947DE1 VA: 0x1947CE0
	public bool StartOperation(WebOperation operation, bool reused) { }

	// RVA: 0x1948340 Offset: 0x1948441 VA: 0x1948340
	public bool Continue(WebOperation next) { }

	// RVA: 0x19485C0 Offset: 0x19486C1 VA: 0x19485C0
	private void Dispose(bool disposing) { }

	// RVA: 0x1948610 Offset: 0x1948711 VA: 0x1948610 Slot: 4
	public void Dispose() { }

	// RVA: 0x1947960 Offset: 0x1947A61 VA: 0x1947960
	private void ResetNtlm() { }

	// RVA: 0x1948660 Offset: 0x1948761 VA: 0x1948660
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x1948670 Offset: 0x1948771 VA: 0x1948670
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x1948680 Offset: 0x1948781 VA: 0x1948680
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x1948690 Offset: 0x1948791 VA: 0x1948690
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x19486A0 Offset: 0x19487A1 VA: 0x19486A0
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x19486B0 Offset: 0x19487B1 VA: 0x19486B0
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }
}

