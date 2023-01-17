// Namespace: System.Net
[Serializable]
public class CookieContainer // TypeDefIndex: 2517
{
	// Fields
	private static readonly HeaderVariantInfo[] HeaderInfo; // 0x0
	private Hashtable m_domainTable; // 0x10
	private int m_maxCookieSize; // 0x18
	private int m_maxCookies; // 0x1C
	private int m_maxCookiesPerDomain; // 0x20
	private int m_count; // 0x24
	private string m_fqdnMyDomain; // 0x28

	// Methods

	// RVA: 0x1B4E2F0 Offset: 0x1B4E3F1 VA: 0x1B4E2F0
	public void .ctor() { }

	// RVA: 0x1B4E420 Offset: 0x1B4E521 VA: 0x1B4E420
	private void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x1B4E540 Offset: 0x1B4E641 VA: 0x1B4E540
	internal void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x1B4ECF0 Offset: 0x1B4EDF1 VA: 0x1B4ECF0
	private bool AgeCookies(string domain) { }

	// RVA: 0x1B4FEE0 Offset: 0x1B4FFE1 VA: 0x1B4FEE0
	private int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x1B50030 Offset: 0x1B50131 VA: 0x1B50030
	internal bool IsLocalDomain(string host) { }

	// RVA: 0x1B50500 Offset: 0x1B50601 VA: 0x1B50500
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x1B51780 Offset: 0x1B51881 VA: 0x1B51780
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x1B51AA0 Offset: 0x1B51BA1 VA: 0x1B51AA0
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x1B522E0 Offset: 0x1B523E1 VA: 0x1B522E0
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x1B52670 Offset: 0x1B52771 VA: 0x1B52670
	public string GetCookieHeader(Uri uri) { }

	// RVA: 0x1B52750 Offset: 0x1B52851 VA: 0x1B52750
	internal string GetCookieHeader(Uri uri, out string optCookie2) { }

	// RVA: 0x1B52AE0 Offset: 0x1B52BE1 VA: 0x1B52AE0
	private static void .cctor() { }
}

