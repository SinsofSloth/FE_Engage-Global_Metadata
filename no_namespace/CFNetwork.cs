// Namespace: 
private class CFNetwork.GetProxyData : IDisposable // TypeDefIndex: 2173
{
	// Fields
	public IntPtr script; // 0x10
	public IntPtr targetUri; // 0x18
	public IntPtr error; // 0x20
	public IntPtr result; // 0x28
	public ManualResetEvent evt; // 0x30

	// Methods

	// RVA: 0x1916F10 Offset: 0x1917011 VA: 0x1916F10 Slot: 4
	public void Dispose() { }

	// RVA: 0x1916F30 Offset: 0x1917031 VA: 0x1916F30
	public void .ctor() { }
}

// Namespace: 
private sealed class CFNetwork.CFProxyAutoConfigurationResultCallback : MulticastDelegate // TypeDefIndex: 2174
{
	// Methods

	// RVA: 0x1916280 Offset: 0x1916381 VA: 0x1916280
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19162A0 Offset: 0x19163A1 VA: 0x19162A0 Slot: 13
	public virtual void Invoke(IntPtr client, IntPtr proxyList, IntPtr error) { }

	// RVA: 0x1916500 Offset: 0x1916601 VA: 0x1916500 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr client, IntPtr proxyList, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x19165C0 Offset: 0x19166C1 VA: 0x19165C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

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

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2FAF0 Offset: 0x2FBF1 VA: 0x2FAF0
private sealed class CFNetwork.<>c__DisplayClass13_0 // TypeDefIndex: 2176
{
	// Fields
	public CFProxy[] proxies; // 0x10
	public CFRunLoop runLoop; // 0x18

	// Methods

	// RVA: 0x1916080 Offset: 0x1916181 VA: 0x1916080
	public void .ctor() { }

	// RVA: 0x1916090 Offset: 0x1916191 VA: 0x1916090
	internal void <ExecuteProxyAutoConfigurationURL>b__0(IntPtr client, IntPtr proxyList, IntPtr error) { }
}

