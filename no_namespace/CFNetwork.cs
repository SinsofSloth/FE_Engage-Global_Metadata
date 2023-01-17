// Namespace: 
private class CFNetwork.CFWebProxy : IWebProxy // TypeDefIndex: 2175
{
	// Fields
	private ICredentials credentials; // 0x10
	private bool userSpecified; // 0x18

	// Properties
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0x19165D0 Offset: 0x19166D1 VA: 0x19165D0
	public void .ctor() { }

	// RVA: 0x19165E0 Offset: 0x19166E1 VA: 0x19165E0 Slot: 6
	public ICredentials get_Credentials() { }

	// RVA: 0x19165F0 Offset: 0x19166F1 VA: 0x19165F0
	private static Uri GetProxyUri(CFProxy proxy, out NetworkCredential credentials) { }

	// RVA: 0x19167F0 Offset: 0x19168F1 VA: 0x19167F0
	private static Uri GetProxyUriFromScript(IntPtr script, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x1916970 Offset: 0x1916A71 VA: 0x1916970
	private static Uri ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x1916880 Offset: 0x1916981 VA: 0x1916880
	private static Uri SelectProxy(CFProxy[] proxies, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x1916A00 Offset: 0x1916B01 VA: 0x1916A00 Slot: 4
	public Uri GetProxy(Uri targetUri) { }

	// RVA: 0x1916E10 Offset: 0x1916F11 VA: 0x1916E10 Slot: 5
	public bool IsBypassed(Uri targetUri) { }
}

