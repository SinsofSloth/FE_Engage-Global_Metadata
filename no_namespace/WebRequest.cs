// Namespace: 
internal class WebRequest.DesignerWebRequestCreate : IWebRequestCreate // TypeDefIndex: 2482
{
	// Methods

	// RVA: 0x19297D0 Offset: 0x19298D1 VA: 0x19297D0 Slot: 4
	public WebRequest Create(Uri uri) { }

	// RVA: 0x1929840 Offset: 0x1929941 VA: 0x1929840
	public void .ctor() { }
}

// Namespace: 
internal class WebRequest.WebProxyWrapperOpaque : IWebProxy // TypeDefIndex: 2483
{
	// Fields
	protected readonly WebProxy webProxy; // 0x10

	// Properties
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0x1929860 Offset: 0x1929961 VA: 0x1929860 Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x1929870 Offset: 0x1929971 VA: 0x1929870 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x1929880 Offset: 0x1929981 VA: 0x1929880 Slot: 6
	public ICredentials get_Credentials() { }
}

// Namespace: 
internal class WebRequest.WebProxyWrapper : WebRequest.WebProxyWrapperOpaque // TypeDefIndex: 2484
{
	// Properties
	internal WebProxy WebProxy { get; }

	// Methods

	// RVA: 0x1929850 Offset: 0x1929951 VA: 0x1929850
	internal WebProxy get_WebProxy() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x30EF0 Offset: 0x30FF1 VA: 0x30EF0
private sealed class WebRequest.<>c__DisplayClass79_0 // TypeDefIndex: 2485
{
	// Fields
	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x19294A0 Offset: 0x19295A1 VA: 0x19294A0
	public void .ctor() { }

	// RVA: 0x19294B0 Offset: 0x19295B1 VA: 0x19294B0
	internal Task<WebResponse> <GetResponseAsync>b__1() { }
}

