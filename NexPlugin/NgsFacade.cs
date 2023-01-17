// Namespace: NexPlugin
public static class NgsFacade // TypeDefIndex: 14983
{
	// Methods

	// RVA: 0x2359C50 Offset: 0x2359D51 VA: 0x2359C50
	public static bool RegisterNotificationEventHandler(NotificationEventCB callback) { }

	// RVA: 0x2359CC0 Offset: 0x2359DC1 VA: 0x2359CC0
	public static bool UnregisterNotificationEventHandler(NotificationEventCB callback) { }

	// RVA: 0x2359D30 Offset: 0x2359E31 VA: 0x2359D30
	public static extern Result IsConnected(IntPtr pNgsFacade) { }

	// RVA: 0x2359D50 Offset: 0x2359E51 VA: 0x2359D50
	public static extern ulong GetPrincipalID(IntPtr pNgsFacade) { }

	// RVA: 0x2359D60 Offset: 0x2359E61 VA: 0x2359D60
	public static bool LoginAsync(out uint asyncId, uint gameServerId, string accessKey, NetworkServiceAccountId nsaId, byte[] nsaIdToken, int timeOut = 30000, NgsFacade.LoginCB callback) { }

	// RVA: 0x2359D70 Offset: 0x2359E71 VA: 0x2359D70
	public static bool LogoutAsync(out uint asyncId, IntPtr pNgsFacade, AsyncResultCB callback) { }

	// RVA: 0x2359D80 Offset: 0x2359E81 VA: 0x2359D80
	public static bool TestConnectivityAsync(out uint asyncId, IntPtr pNgsFacade, NgsFacade.TestConnectivityCB callback) { }
}

