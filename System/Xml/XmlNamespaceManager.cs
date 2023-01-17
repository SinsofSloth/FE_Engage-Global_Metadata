// Namespace: System.Xml
public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable // TypeDefIndex: 1763
{
	// Fields
	private XmlNamespaceManager.NamespaceDeclaration[] nsdecls; // 0x10
	private int lastDecl; // 0x18
	private XmlNameTable nameTable; // 0x20
	private int scopeId; // 0x28
	private Dictionary<string, int> hashTable; // 0x30
	private bool useHashtable; // 0x38
	private string xml; // 0x40
	private string xmlNs; // 0x48

	// Properties
	public virtual XmlNameTable NameTable { get; }
	public virtual string DefaultNamespace { get; }

	// Methods

	// RVA: 0x32F7530 Offset: 0x32F7631 VA: 0x32F7530
	internal void .ctor() { }

	// RVA: 0x32F2ED0 Offset: 0x32F2FD1 VA: 0x32F2ED0
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x32F7540 Offset: 0x32F7641 VA: 0x32F7540 Slot: 8
	public virtual XmlNameTable get_NameTable() { }

	// RVA: 0x32F7550 Offset: 0x32F7651 VA: 0x32F7550 Slot: 9
	public virtual string get_DefaultNamespace() { }

	// RVA: 0x32F75E0 Offset: 0x32F76E1 VA: 0x32F75E0 Slot: 10
	public virtual void PushScope() { }

	// RVA: 0x32F75F0 Offset: 0x32F76F1 VA: 0x32F75F0 Slot: 11
	public virtual bool PopScope() { }

	// RVA: 0x32F76F0 Offset: 0x32F77F1 VA: 0x32F76F0 Slot: 12
	public virtual void AddNamespace(string prefix, string uri) { }

	// RVA: 0x32F7C40 Offset: 0x32F7D41 VA: 0x32F7C40 Slot: 13
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x32F7DC0 Offset: 0x32F7EC1 VA: 0x32F7DC0 Slot: 14
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x32F7FD0 Offset: 0x32F80D1 VA: 0x32F7FD0 Slot: 15
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x32F7AA0 Offset: 0x32F7BA1 VA: 0x32F7AA0
	private int LookupNamespaceDecl(string prefix) { }

	// RVA: 0x32F8030 Offset: 0x32F8131 VA: 0x32F8030 Slot: 16
	public virtual string LookupPrefix(string uri) { }
}

