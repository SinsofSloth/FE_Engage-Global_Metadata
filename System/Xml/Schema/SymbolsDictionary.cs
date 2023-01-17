// Namespace: System.Xml.Schema
[DefaultMemberAttribute] // RVA: 0x47120 Offset: 0x47221 VA: 0x47120
internal class SymbolsDictionary // TypeDefIndex: 1810
{
	// Fields
	private int last; // 0x10
	private Hashtable names; // 0x18
	private Hashtable wildcards; // 0x20
	private ArrayList particles; // 0x28
	private object particleLast; // 0x30
	private bool isUpaEnforced; // 0x38

	// Properties
	public int Count { get; }
	public bool IsUpaEnforced { get; set; }
	public int Item { get; }

	// Methods

	// RVA: 0x19B7190 Offset: 0x19B7291 VA: 0x19B7190
	public void .ctor() { }

	// RVA: 0x19B7250 Offset: 0x19B7351 VA: 0x19B7250
	public int get_Count() { }

	// RVA: 0x19B7260 Offset: 0x19B7361 VA: 0x19B7260
	public bool get_IsUpaEnforced() { }

	// RVA: 0x19B7270 Offset: 0x19B7371 VA: 0x19B7270
	public void set_IsUpaEnforced(bool value) { }

	// RVA: 0x19B7280 Offset: 0x19B7381 VA: 0x19B7280
	public int AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x19B73A0 Offset: 0x19B74A1 VA: 0x19B73A0
	public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal) { }

	// RVA: 0x19B76E0 Offset: 0x19B77E1 VA: 0x19B76E0
	private void AddWildcard(string wildcard, object particle) { }

	// RVA: 0x19B7850 Offset: 0x19B7951 VA: 0x19B7850
	public ICollection GetNamespaceListSymbols(NamespaceList list) { }

	// RVA: 0x19B7EF0 Offset: 0x19B7FF1 VA: 0x19B7EF0
	public int get_Item(XmlQualifiedName name) { }

	// RVA: 0x19B7FB0 Offset: 0x19B80B1 VA: 0x19B7FB0
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x19B7FE0 Offset: 0x19B80E1 VA: 0x19B7FE0
	public object GetParticle(int symbol) { }

	// RVA: 0x19B8010 Offset: 0x19B8111 VA: 0x19B8010
	public string NameOf(int symbol) { }
}

