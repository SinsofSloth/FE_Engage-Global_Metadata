// Namespace: nn.account
public static class NetworkServiceAccount // TypeDefIndex: 14780
{
	// Fields
	public const int IdTokenLengthMax = 3072;

	// Properties
	public static ErrorRange ResultNetworkServiceAccountUnavailable { get; }
	public static ErrorRange ResultTokenCacheUnavailable { get; }
	public static ErrorRange ResultNetworkCommunicationError { get; }
	public static ErrorRange ResultSslService { get; }

	// Methods

	// RVA: 0x2354C60 Offset: 0x2354D61 VA: 0x2354C60
	public static extern Result EnsureAvailable(UserHandle handle) { }

	// RVA: 0x2354CA0 Offset: 0x2354DA1 VA: 0x2354CA0
	public static extern Result IsAvailable(ref bool pOut, UserHandle handle) { }

	// RVA: 0x2354CE0 Offset: 0x2354DE1 VA: 0x2354CE0
	public static extern Result GetId(ref NetworkServiceAccountId pOutId, UserHandle handle) { }

	// RVA: 0x2354D20 Offset: 0x2354E21 VA: 0x2354D20
	public static Result EnsurIdTokenCacheAsync(AsyncContext pOutContext, UserHandle handle) { }

	// RVA: 0x2354D60 Offset: 0x2354E61 VA: 0x2354D60
	public static extern Result EnsurIdTokenCacheAsync(IntPtr pOutContext, UserHandle handle) { }

	// RVA: 0x2354DA0 Offset: 0x2354EA1 VA: 0x2354DA0
	public static Result LoadIdTokenCache(ref ulong pOutActualSize, byte[] buffer, UserHandle handle) { }

	// RVA: 0x2354DF0 Offset: 0x2354EF1 VA: 0x2354DF0
	private static extern Result LoadIdTokenCache(ref ulong pOutActualSize, byte[] buffer, int bufferSize, UserHandle handle) { }

	// RVA: 0x2354E30 Offset: 0x2354F31 VA: 0x2354E30
	public static ErrorRange get_ResultNetworkServiceAccountUnavailable() { }

	// RVA: 0x2354E70 Offset: 0x2354F71 VA: 0x2354E70
	public static ErrorRange get_ResultTokenCacheUnavailable() { }

	// RVA: 0x2354EB0 Offset: 0x2354FB1 VA: 0x2354EB0
	public static ErrorRange get_ResultNetworkCommunicationError() { }

	// RVA: 0x2354EF0 Offset: 0x2354FF1 VA: 0x2354EF0
	public static ErrorRange get_ResultSslService() { }
}

