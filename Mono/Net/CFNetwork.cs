// Namespace: Mono.Net
internal static class CFNetwork // TypeDefIndex: 2177
{
	// Fields
	private static object lock_obj; // 0x0
	private static Queue<CFNetwork.GetProxyData> get_proxy_queue; // 0x8
	private static AutoResetEvent proxy_event; // 0x10

	// Methods

	// RVA: 0x1B43730 Offset: 0x1B43831 VA: 0x1B43730
	private static extern IntPtr CFNetworkCopyProxiesForAutoConfigurationScriptSequential(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x1B437D0 Offset: 0x1B438D1 VA: 0x1B437D0
	private static extern IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, IntPtr targetURL, CFNetwork.CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext) { }

	// RVA: 0x1B43880 Offset: 0x1B43981 VA: 0x1B43880
	private static void CFNetworkCopyProxiesForAutoConfigurationScriptThread() { }

	// RVA: 0x1B43B60 Offset: 0x1B43C61 VA: 0x1B43B60
	private static IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x1B43FE0 Offset: 0x1B440E1 VA: 0x1B43FE0
	private static CFArray CopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x1B440C0 Offset: 0x1B441C1 VA: 0x1B440C0
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x1B445E0 Offset: 0x1B446E1 VA: 0x1B445E0
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, Uri targetUri) { }

	// RVA: 0x1B44920 Offset: 0x1B44A21 VA: 0x1B44920
	public static CFProxy[] ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetURL) { }

	// RVA: 0x1B45080 Offset: 0x1B45181 VA: 0x1B45080
	private static extern IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings) { }

	// RVA: 0x1B45110 Offset: 0x1B45211 VA: 0x1B45110
	private static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings) { }

	// RVA: 0x1B45250 Offset: 0x1B45351 VA: 0x1B45250
	public static CFProxy[] GetProxiesForURL(CFUrl url, CFProxySettings proxySettings) { }

	// RVA: 0x1B45830 Offset: 0x1B45931 VA: 0x1B45830
	public static CFProxy[] GetProxiesForUri(Uri uri, CFProxySettings proxySettings) { }

	// RVA: 0x1B459C0 Offset: 0x1B45AC1 VA: 0x1B459C0
	private static extern IntPtr CFNetworkCopySystemProxySettings() { }

	// RVA: 0x1B456D0 Offset: 0x1B457D1 VA: 0x1B456D0
	public static CFProxySettings GetSystemProxySettings() { }

	// RVA: 0x1B45A70 Offset: 0x1B45B71 VA: 0x1B45A70
	public static IWebProxy GetDefaultProxy() { }

	// RVA: 0x1B45AD0 Offset: 0x1B45BD1 VA: 0x1B45AD0
	private static void .cctor() { }
}

