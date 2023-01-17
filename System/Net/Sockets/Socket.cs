// Namespace: System.Net.Sockets
public class Socket : IDisposable // TypeDefIndex: 2628
{
	// Fields
	private static object s_InternalSyncObject; // 0x0
	internal static bool s_SupportsIPv4; // 0x8
	internal static bool s_SupportsIPv6; // 0x9
	internal static bool s_OSSupportsIPv6; // 0xA
	internal static bool s_Initialized; // 0xB
	private static bool s_LoggingEnabled; // 0xC
	private bool is_closed; // 0x10
	private bool is_listening; // 0x11
	private bool useOverlappedIO; // 0x12
	private int linger_timeout; // 0x14
	private AddressFamily addressFamily; // 0x18
	private SocketType socketType; // 0x1C
	private ProtocolType protocolType; // 0x20
	internal SafeSocketHandle m_Handle; // 0x28
	internal EndPoint seed_endpoint; // 0x30
	internal SemaphoreSlim ReadSem; // 0x38
	internal SemaphoreSlim WriteSem; // 0x40
	internal bool is_blocking; // 0x48
	internal bool is_bound; // 0x49
	internal bool is_connected; // 0x4A
	private int m_IntCleanedUp; // 0x4C
	internal bool connect_in_progress; // 0x50
	internal readonly int ID; // 0x54
	private static AsyncCallback AcceptAsyncCallback; // 0x10
	private static IOAsyncCallback BeginAcceptCallback; // 0x18
	private static IOAsyncCallback BeginAcceptReceiveCallback; // 0x20
	private static AsyncCallback ConnectAsyncCallback; // 0x28
	private static IOAsyncCallback BeginConnectCallback; // 0x30
	private static AsyncCallback DisconnectAsyncCallback; // 0x38
	private static IOAsyncCallback BeginDisconnectCallback; // 0x40
	private static AsyncCallback ReceiveAsyncCallback; // 0x48
	private static IOAsyncCallback BeginReceiveCallback; // 0x50
	private static IOAsyncCallback BeginReceiveGenericCallback; // 0x58
	private static AsyncCallback ReceiveFromAsyncCallback; // 0x60
	private static IOAsyncCallback BeginReceiveFromCallback; // 0x68
	private static AsyncCallback SendAsyncCallback; // 0x70
	private static IOAsyncCallback BeginSendGenericCallback; // 0x78
	private static AsyncCallback SendToAsyncCallback; // 0x80

	// Properties
	[ObsoleteAttribute] // RVA: 0x34370 Offset: 0x34471 VA: 0x34370
	public static bool SupportsIPv4 { get; }
	public static bool OSSupportsIPv4 { get; }
	[ObsoleteAttribute] // RVA: 0x343B0 Offset: 0x344B1 VA: 0x343B0
	public static bool SupportsIPv6 { get; }
	public static bool OSSupportsIPv6 { get; }
	public IntPtr Handle { get; }
	public AddressFamily AddressFamily { get; }
	public SocketType SocketType { get; }
	public ProtocolType ProtocolType { get; }
	public bool ExclusiveAddressUse { set; }
	public bool DontFragment { set; }
	public bool DualMode { get; set; }
	private bool IsDualMode { get; }
	private static object InternalSyncObject { get; }
	internal bool CleanedUp { get; }
	public bool IsBound { get; }
	public EndPoint LocalEndPoint { get; }
	public bool Blocking { get; set; }
	public bool Connected { get; }
	public bool NoDelay { set; }
	public EndPoint RemoteEndPoint { get; }
	internal static int FamilyHint { get; }

	// Methods

	// RVA: 0x2D08770 Offset: 0x2D08871 VA: 0x2D08770
	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x2D08FC0 Offset: 0x2D090C1 VA: 0x2D08FC0
	public static bool get_SupportsIPv4() { }

	// RVA: 0x2D09030 Offset: 0x2D09131 VA: 0x2D09030
	public static bool get_OSSupportsIPv4() { }

	// RVA: 0x2D090A0 Offset: 0x2D091A1 VA: 0x2D090A0
	public static bool get_SupportsIPv6() { }

	// RVA: 0x2D09110 Offset: 0x2D09211 VA: 0x2D09110
	public static bool get_OSSupportsIPv6() { }

	// RVA: 0x2D09180 Offset: 0x2D09281 VA: 0x2D09180
	public IntPtr get_Handle() { }

	// RVA: 0x2D09190 Offset: 0x2D09291 VA: 0x2D09190
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x2D091A0 Offset: 0x2D092A1 VA: 0x2D091A0
	public SocketType get_SocketType() { }

	// RVA: 0x2D091B0 Offset: 0x2D092B1 VA: 0x2D091B0
	public ProtocolType get_ProtocolType() { }

	// RVA: 0x2D091C0 Offset: 0x2D092C1 VA: 0x2D091C0
	public void set_ExclusiveAddressUse(bool value) { }

	// RVA: 0x2D09370 Offset: 0x2D09471 VA: 0x2D09370
	public void set_DontFragment(bool value) { }

	// RVA: 0x2D093F0 Offset: 0x2D094F1 VA: 0x2D093F0
	public bool get_DualMode() { }

	// RVA: 0x2D09680 Offset: 0x2D09781 VA: 0x2D09680
	public void set_DualMode(bool value) { }

	// RVA: 0x2D09700 Offset: 0x2D09801 VA: 0x2D09700
	private bool get_IsDualMode() { }

	// RVA: 0x2D09720 Offset: 0x2D09821 VA: 0x2D09720
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x2D09DE0 Offset: 0x2D09EE1 VA: 0x2D09DE0
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x2D09FE0 Offset: 0x2D0A0E1 VA: 0x2D09FE0
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x2D0A1B0 Offset: 0x2D0A2B1 VA: 0x2D0A1B0
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x2D05B10 Offset: 0x2D05C11 VA: 0x2D05B10
	public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x2D08DF0 Offset: 0x2D08EF1 VA: 0x2D08DF0
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0x2D0A940 Offset: 0x2D0AA41 VA: 0x2D0A940
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x2D0AC60 Offset: 0x2D0AD61 VA: 0x2D0AC60
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x2D0AE30 Offset: 0x2D0AF31 VA: 0x2D0AE30
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x2D0B0B0 Offset: 0x2D0B1B1 VA: 0x2D0B0B0
	public int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x2D0B280 Offset: 0x2D0B381 VA: 0x2D0B280
	private static object get_InternalSyncObject() { }

	// RVA: 0x2D0B380 Offset: 0x2D0B481 VA: 0x2D0B380
	internal bool get_CleanedUp() { }

	// RVA: 0x2D08A30 Offset: 0x2D08B31 VA: 0x2D08A30
	internal static void InitializeSockets() { }

	// RVA: 0x2D0B400 Offset: 0x2D0B501 VA: 0x2D0B400 Slot: 4
	public void Dispose() { }

	// RVA: 0x2D0B480 Offset: 0x2D0B581 VA: 0x2D0B480 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2D0B500 Offset: 0x2D0B601 VA: 0x2D0B500
	internal void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x2D0B6C0 Offset: 0x2D0B7C1 VA: 0x2D0B6C0
	internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent) { }

	// RVA: 0x2D0B960 Offset: 0x2D0BA61 VA: 0x2D0B960
	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x2D08EE0 Offset: 0x2D08FE1 VA: 0x2D08EE0
	private void SocketDefaults() { }

	// RVA: 0x2D08D60 Offset: 0x2D08E61 VA: 0x2D08D60
	private IntPtr Socket_internal(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	// RVA: 0x2D0BB10 Offset: 0x2D0BC11 VA: 0x2D0BB10
	public bool get_IsBound() { }

	// RVA: 0x2D0BB20 Offset: 0x2D0BC21 VA: 0x2D0BB20
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x2D0BCA0 Offset: 0x2D0BDA1 VA: 0x2D0BCA0
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x2D0BDD0 Offset: 0x2D0BED1 VA: 0x2D0BDD0
	private static SocketAddress LocalEndPoint_internal(IntPtr socket, int family, out int error) { }

	// RVA: 0x2D0BDE0 Offset: 0x2D0BEE1 VA: 0x2D0BDE0
	public bool get_Blocking() { }

	// RVA: 0x2D0BDF0 Offset: 0x2D0BEF1 VA: 0x2D0BDF0
	public void set_Blocking(bool value) { }

	// RVA: 0x2D0BED0 Offset: 0x2D0BFD1 VA: 0x2D0BED0
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	// RVA: 0x2D045B0 Offset: 0x2D046B1 VA: 0x2D045B0
	internal static void Blocking_internal(IntPtr socket, bool block, out int error) { }

	// RVA: 0x2D0BFF0 Offset: 0x2D0C0F1 VA: 0x2D0BFF0
	public bool get_Connected() { }

	// RVA: 0x2D0BA90 Offset: 0x2D0BB91 VA: 0x2D0BA90
	public void set_NoDelay(bool value) { }

	// RVA: 0x2D0C060 Offset: 0x2D0C161 VA: 0x2D0C060
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x2D0C160 Offset: 0x2D0C261 VA: 0x2D0C160
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x2D0C290 Offset: 0x2D0C391 VA: 0x2D0C290
	private static SocketAddress RemoteEndPoint_internal(IntPtr socket, int family, out int error) { }

	// RVA: 0x2D0C2A0 Offset: 0x2D0C3A1 VA: 0x2D0C2A0
	public bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x2D0C430 Offset: 0x2D0C531 VA: 0x2D0C430
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x2D0C570 Offset: 0x2D0C671 VA: 0x2D0C570
	private static bool Poll_internal(IntPtr socket, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x2D0C580 Offset: 0x2D0C681 VA: 0x2D0C580
	public Socket Accept() { }

	// RVA: 0x2D0C7C0 Offset: 0x2D0C8C1 VA: 0x2D0C7C0
	internal void Accept(Socket acceptSocket) { }

	// RVA: 0x2D0C900 Offset: 0x2D0CA01 VA: 0x2D0C900
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0x2D0C930 Offset: 0x2D0CA31 VA: 0x2D0C930
	public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0x2D0C6C0 Offset: 0x2D0C7C1 VA: 0x2D0C6C0
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	// RVA: 0x2D0CBE0 Offset: 0x2D0CCE1 VA: 0x2D0CBE0
	private static IntPtr Accept_internal(IntPtr sock, out int error, bool blocking) { }

	// RVA: 0x2D066C0 Offset: 0x2D067C1 VA: 0x2D066C0
	public void Bind(EndPoint localEP) { }

	// RVA: 0x2D0CCC0 Offset: 0x2D0CDC1 VA: 0x2D0CCC0
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) { }

	// RVA: 0x2D0CDE0 Offset: 0x2D0CEE1 VA: 0x2D0CDE0
	private static void Bind_internal(IntPtr sock, SocketAddress sa, out int error) { }

	// RVA: 0x2D0CDF0 Offset: 0x2D0CEF1 VA: 0x2D0CDF0
	public void Listen(int backlog) { }

	// RVA: 0x2D0CEE0 Offset: 0x2D0CFE1 VA: 0x2D0CEE0
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) { }

	// RVA: 0x2D0D000 Offset: 0x2D0D101 VA: 0x2D0D000
	private static void Listen_internal(IntPtr sock, int backlog, out int error) { }

	// RVA: 0x2D0D010 Offset: 0x2D0D111 VA: 0x2D0D010
	public void Connect(EndPoint remoteEP) { }

	// RVA: 0x2D0D4F0 Offset: 0x2D0D5F1 VA: 0x2D0D4F0
	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x2D0DBB0 Offset: 0x2D0DCB1 VA: 0x2D0DBB0
	private static void BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0x2D0D6A0 Offset: 0x2D0D7A1 VA: 0x2D0D6A0
	private static void BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0x2D0DE60 Offset: 0x2D0DF61 VA: 0x2D0DE60
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x2D0D400 Offset: 0x2D0D501 VA: 0x2D0D400
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x2D0DF10 Offset: 0x2D0E011 VA: 0x2D0DF10
	private static void Connect_internal(IntPtr sock, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x2D0DF20 Offset: 0x2D0E021 VA: 0x2D0DF20
	public void Disconnect(bool reuseSocket) { }

	// RVA: 0x2D0E140 Offset: 0x2D0E241 VA: 0x2D0E140
	public void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0x2D0E020 Offset: 0x2D0E121 VA: 0x2D0E020
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	// RVA: 0x2D0E1F0 Offset: 0x2D0E2F1 VA: 0x2D0E1F0
	private static void Disconnect_internal(IntPtr sock, bool reuse, out int error) { }

	// RVA: 0x2D0A050 Offset: 0x2D0A151 VA: 0x2D0A050
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliantAttribute] // RVA: 0x338A0 Offset: 0x339A1 VA: 0x338A0
	// RVA: 0x2D0A220 Offset: 0x2D0A321 VA: 0x2D0A220
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x2D0AEB0 Offset: 0x2D0AFB1 VA: 0x2D0AEB0
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x2D0B120 Offset: 0x2D0B221 VA: 0x2D0B120
	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x2D0E480 Offset: 0x2D0E581 VA: 0x2D0E480
	private static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x2D0E770 Offset: 0x2D0E871 VA: 0x2D0E770
	private static int Receive_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x2D0E380 Offset: 0x2D0E481 VA: 0x2D0E380
	private static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x2D0E780 Offset: 0x2D0E881 VA: 0x2D0E780
	private static int Receive_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x2D0E790 Offset: 0x2D0E891 VA: 0x2D0E790
	internal int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	// RVA: 0x2D0EA30 Offset: 0x2D0EB31 VA: 0x2D0EA30
	public int EndReceiveFrom(IAsyncResult asyncResult, ref EndPoint endPoint) { }

	// RVA: 0x2D0E930 Offset: 0x2D0EA31 VA: 0x2D0E930
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x2D0EB40 Offset: 0x2D0EC41 VA: 0x2D0EB40
	private static int ReceiveFrom_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x2D09E50 Offset: 0x2D09F51 VA: 0x2D09E50
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliantAttribute] // RVA: 0x338C0 Offset: 0x339C1 VA: 0x338C0
	// RVA: 0x2D09790 Offset: 0x2D09891 VA: 0x2D09790
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x2D0A9C0 Offset: 0x2D0AAC1 VA: 0x2D0A9C0
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x2D0ED50 Offset: 0x2D0EE51 VA: 0x2D0ED50
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x2D0ACD0 Offset: 0x2D0ADD1 VA: 0x2D0ACD0
	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x2D0EC50 Offset: 0x2D0ED51 VA: 0x2D0EC50
	private static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x2D0F090 Offset: 0x2D0F191 VA: 0x2D0F090
	private static int Send_internal(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x2D0EB50 Offset: 0x2D0EC51 VA: 0x2D0EB50
	private static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x2D0F0A0 Offset: 0x2D0F1A1 VA: 0x2D0F0A0
	private static int Send_internal(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x2D0F0B0 Offset: 0x2D0F1B1 VA: 0x2D0F0B0
	public int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x2D094D0 Offset: 0x2D095D1 VA: 0x2D094D0
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0x2D0F170 Offset: 0x2D0F271 VA: 0x2D0F170
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x2D0F2B0 Offset: 0x2D0F3B1 VA: 0x2D0F2B0
	private static void GetSocketOption_obj_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x2D09240 Offset: 0x2D09341 VA: 0x2D09240
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x2D0B810 Offset: 0x2D0B911 VA: 0x2D0B810
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x2D0F2C0 Offset: 0x2D0F3C1 VA: 0x2D0F2C0
	private static void SetSocketOption_internal(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x2D0A7C0 Offset: 0x2D0A8C1 VA: 0x2D0A7C0
	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x2D0F2D0 Offset: 0x2D0F3D1 VA: 0x2D0F2D0
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x2D0F420 Offset: 0x2D0F521 VA: 0x2D0F420
	private static int IOControl_internal(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x2D0F430 Offset: 0x2D0F531 VA: 0x2D0F430
	public void Close() { }

	// RVA: 0x2D0F4C0 Offset: 0x2D0F5C1 VA: 0x2D0F4C0
	public void Close(int timeout) { }

	// RVA: 0x2D045E0 Offset: 0x2D046E1 VA: 0x2D045E0
	internal static void Close_internal(IntPtr socket, out int error) { }

	// RVA: 0x2D0B5A0 Offset: 0x2D0B6A1 VA: 0x2D0B5A0
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	// RVA: 0x2D045C0 Offset: 0x2D046C1 VA: 0x2D045C0
	internal static void Shutdown_internal(IntPtr socket, SocketShutdown how, out int error) { }

	// RVA: 0x2D0F550 Offset: 0x2D0F651 VA: 0x2D0F550 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2D0F5C0 Offset: 0x2D0F6C1 VA: 0x2D0F5C0
	private void Linger(IntPtr handle) { }

	// RVA: 0x2D0BC20 Offset: 0x2D0BD21 VA: 0x2D0BC20
	private void ThrowIfDisposedAndClosed() { }

	// RVA: 0x2D0E200 Offset: 0x2D0E301 VA: 0x2D0E200
	private void ThrowIfBufferNull(byte[] buffer) { }

	// RVA: 0x2D0E260 Offset: 0x2D0E361 VA: 0x2D0E260
	private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size) { }

	// RVA: 0x2D0C000 Offset: 0x2D0C101 VA: 0x2D0C000
	private void ThrowIfUdp() { }

	// RVA: 0x2D0CA10 Offset: 0x2D0CB11 VA: 0x2D0CA10
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x2D0E580 Offset: 0x2D0E681 VA: 0x2D0E580
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x2D0CBF0 Offset: 0x2D0CCF1 VA: 0x2D0CBF0
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x2D045D0 Offset: 0x2D046D1 VA: 0x2D045D0
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x2D0F750 Offset: 0x2D0F851 VA: 0x2D0F750
	internal static int get_FamilyHint() { }

	// RVA: 0x2D0F8B0 Offset: 0x2D0F9B1 VA: 0x2D0F8B0
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x2D0B390 Offset: 0x2D0B491 VA: 0x2D0B390
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x2D0F8C0 Offset: 0x2D0F9C1 VA: 0x2D0F8C0
	private static void .cctor() { }
}

