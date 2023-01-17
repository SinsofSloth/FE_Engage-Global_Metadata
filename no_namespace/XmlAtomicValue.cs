// Namespace: 
private struct XmlAtomicValue.Union // TypeDefIndex: 1957
{
	// Fields
	public bool boolVal; // 0x0
	public double dblVal; // 0x0
	public long i64Val; // 0x0
	public int i32Val; // 0x0
	public DateTime dtVal; // 0x0
}

// Namespace: 
private class XmlAtomicValue.NamespacePrefixForQName : IXmlNamespaceResolver // TypeDefIndex: 1958
{
	// Fields
	public string prefix; // 0x10
	public string ns; // 0x18

	// Methods

	// RVA: 0x19A6FA0 Offset: 0x19A70A1 VA: 0x19A6FA0
	public void .ctor(string prefix, string ns) { }

	// RVA: 0x19A6FF0 Offset: 0x19A70F1 VA: 0x19A6FF0 Slot: 5
	public string LookupNamespace(string prefix) { }

	// RVA: 0x19A7030 Offset: 0x19A7131 VA: 0x19A7030 Slot: 6
	public string LookupPrefix(string namespaceName) { }

	// RVA: 0x19A7070 Offset: 0x19A7171 VA: 0x19A7070 Slot: 4
	public IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }
}

