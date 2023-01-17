// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader, IXmlNamespaceResolver // TypeDefIndex: 1652
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x20

	// Methods

	// RVA: 0x1A93930 Offset: 0x1A93A31 VA: 0x1A93930
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1A94A10 Offset: 0x1A94B11 VA: 0x1A94A10 Slot: 37
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1A94AC0 Offset: 0x1A94BC1 VA: 0x1A94AC0 Slot: 38
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1A94B70 Offset: 0x1A94C71 VA: 0x1A94B70 Slot: 39
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }
}

