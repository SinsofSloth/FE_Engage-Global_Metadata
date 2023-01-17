// Namespace: System.Xml
internal class XmlDownloadManager // TypeDefIndex: 1743
{
	// Fields
	private Hashtable connections; // 0x10

	// Methods

	// RVA: 0x32E8D60 Offset: 0x32E8E61 VA: 0x32E8D60
	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x32E8E70 Offset: 0x32E8F71 VA: 0x32E8E70
	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x32E93B0 Offset: 0x32E94B1 VA: 0x32E93B0
	internal void Remove(string host) { }

	// RVA: 0x32E9520 Offset: 0x32E9621 VA: 0x32E9520
	internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	[AsyncStateMachineAttribute] // RVA: 0x478A0 Offset: 0x479A1 VA: 0x478A0
	// RVA: 0x32E96B0 Offset: 0x32E97B1 VA: 0x32E96B0
	private Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x32E98A0 Offset: 0x32E99A1 VA: 0x32E98A0
	public void .ctor() { }
}

