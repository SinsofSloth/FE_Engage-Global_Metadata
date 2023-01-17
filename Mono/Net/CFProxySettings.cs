// Namespace: Mono.Net
internal class CFProxySettings // TypeDefIndex: 2172
{
	// Fields
	private static IntPtr kCFNetworkProxiesHTTPEnable; // 0x0
	private static IntPtr kCFNetworkProxiesHTTPPort; // 0x8
	private static IntPtr kCFNetworkProxiesHTTPProxy; // 0x10
	private static IntPtr kCFNetworkProxiesProxyAutoConfigEnable; // 0x18
	private static IntPtr kCFNetworkProxiesProxyAutoConfigJavaScript; // 0x20
	private static IntPtr kCFNetworkProxiesProxyAutoConfigURLString; // 0x28
	private CFDictionary settings; // 0x10

	// Properties
	public CFDictionary Dictionary { get; }

	// Methods

	// RVA: 0x1B47550 Offset: 0x1B47651 VA: 0x1B47550
	private static void .cctor() { }

	// RVA: 0x1B45A30 Offset: 0x1B45B31 VA: 0x1B45A30
	public void .ctor(CFDictionary settings) { }

	// RVA: 0x1B477B0 Offset: 0x1B478B1 VA: 0x1B477B0
	public CFDictionary get_Dictionary() { }
}

