// Namespace: System.Xml
public class XmlUrlResolver : XmlResolver // TypeDefIndex: 1769
{
	// Fields
	private static object s_DownloadManager; // 0x0
	private ICredentials _credentials; // 0x10
	private IWebProxy _proxy; // 0x18
	private RequestCachePolicy _cachePolicy; // 0x20

	// Properties
	private static XmlDownloadManager DownloadManager { get; }

	// Methods

	// RVA: 0x19F51D0 Offset: 0x19F52D1 VA: 0x19F51D0
	private static XmlDownloadManager get_DownloadManager() { }

	// RVA: 0x19F52B0 Offset: 0x19F53B1 VA: 0x19F52B0
	public void .ctor() { }

	// RVA: 0x19F52C0 Offset: 0x19F53C1 VA: 0x19F52C0 Slot: 4
	public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x19F5460 Offset: 0x19F5561 VA: 0x19F5460 Slot: 5
	public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	[AsyncStateMachineAttribute] // RVA: 0x47920 Offset: 0x47A21 VA: 0x47920
	// RVA: 0x19F5470 Offset: 0x19F5571 VA: 0x19F5470 Slot: 7
	public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }
}

