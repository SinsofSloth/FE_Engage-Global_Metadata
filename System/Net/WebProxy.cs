// Namespace: System.Net
[Serializable]
public class WebProxy : IWebProxy, ISerializable // TypeDefIndex: 2526
{
	// Fields
	private bool _UseRegistry; // 0x10
	private bool _BypassOnLocal; // 0x11
	private bool m_EnableAutoproxy; // 0x12
	private Uri _ProxyAddress; // 0x18
	private ArrayList _BypassList; // 0x20
	private ICredentials _Credentials; // 0x28
	private Regex[] _RegExBypassList; // 0x30
	private Hashtable _ProxyHostAddresses; // 0x38
	private AutoWebProxyScriptEngine m_ScriptEngine; // 0x40

	// Properties
	public ICredentials Credentials { get; }
	public bool UseDefaultCredentials { get; set; }
	internal AutoWebProxyScriptEngine ScriptEngine { get; }

	// Methods

	// RVA: 0x194E170 Offset: 0x194E271 VA: 0x194E170
	public void .ctor() { }

	// RVA: 0x194E1F0 Offset: 0x194E2F1 VA: 0x194E1F0
	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x194E570 Offset: 0x194E671 VA: 0x194E570 Slot: 6
	public ICredentials get_Credentials() { }

	// RVA: 0x194E580 Offset: 0x194E681 VA: 0x194E580
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x194E610 Offset: 0x194E711 VA: 0x194E610
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x194E690 Offset: 0x194E791 VA: 0x194E690 Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x194E2D0 Offset: 0x194E3D1 VA: 0x194E2D0
	private void UpdateRegExList(bool canThrow) { }

	// RVA: 0x194EB40 Offset: 0x194EC41 VA: 0x194EB40
	private bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x194ECF0 Offset: 0x194EDF1 VA: 0x194ECF0
	private bool IsLocal(Uri host) { }

	// RVA: 0x194EE60 Offset: 0x194EF61 VA: 0x194EE60
	private bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x194EF70 Offset: 0x194F071 VA: 0x194EF70 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x194EA60 Offset: 0x194EB61 VA: 0x194EA60
	private bool IsBypassedManual(Uri host) { }

	// RVA: 0x194F1A0 Offset: 0x194F2A1 VA: 0x194F1A0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x194F550 Offset: 0x194F651 VA: 0x194F550 Slot: 7
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x194F560 Offset: 0x194F661 VA: 0x194F560 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x194F6F0 Offset: 0x194F7F1 VA: 0x194F6F0
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x194F700 Offset: 0x194F801 VA: 0x194F700
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0x194F770 Offset: 0x194F871 VA: 0x194F770
	internal void .ctor(bool enableAutoproxy) { }

	// RVA: 0x194F540 Offset: 0x194F641 VA: 0x194F540
	internal void UnsafeUpdateFromRegistry() { }

	// RVA: 0x194E840 Offset: 0x194E941 VA: 0x194E840
	private bool GetProxyAuto(Uri destination, out Uri proxyUri) { }

	// RVA: 0x194F080 Offset: 0x194F181 VA: 0x194F080
	private bool IsBypassedAuto(Uri destination, out bool isBypassed) { }

	// RVA: 0x194F7B0 Offset: 0x194F8B1 VA: 0x194F7B0
	private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly) { }

	// RVA: 0x194FB30 Offset: 0x194FC31 VA: 0x194FB30
	private static Uri ProxyUri(string proxyName) { }
}

