// Namespace: System.Xml.Schema
internal class NamespaceList // TypeDefIndex: 1917
{
	// Fields
	private NamespaceList.ListType type; // 0x10
	private Hashtable set; // 0x18
	private string targetNamespace; // 0x20

	// Properties
	public NamespaceList.ListType Type { get; }
	public string Excluded { get; }
	public ICollection Enumerate { get; }

	// Methods

	// RVA: 0x3240930 Offset: 0x3240A31 VA: 0x3240930
	public void .ctor() { }

	// RVA: 0x3240940 Offset: 0x3240A41 VA: 0x3240940
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x3240BE0 Offset: 0x3240CE1 VA: 0x3240BE0
	public NamespaceList Clone() { }

	// RVA: 0x3240CF0 Offset: 0x3240DF1 VA: 0x3240CF0
	public NamespaceList.ListType get_Type() { }

	// RVA: 0x3240D00 Offset: 0x3240E01 VA: 0x3240D00
	public string get_Excluded() { }

	// RVA: 0x3240D10 Offset: 0x3240E11 VA: 0x3240D10
	public ICollection get_Enumerate() { }

	// RVA: 0x3240D80 Offset: 0x3240E81 VA: 0x3240D80 Slot: 4
	public virtual bool Allows(string ns) { }

	// RVA: 0x3240E30 Offset: 0x3240F31 VA: 0x3240E30
	public bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x3240E40 Offset: 0x3240F41 VA: 0x3240E40 Slot: 3
	public override string ToString() { }

	// RVA: 0x3241270 Offset: 0x3241371 VA: 0x3241270
	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	// RVA: 0x32415E0 Offset: 0x32416E1 VA: 0x32415E0
	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x3241AC0 Offset: 0x3241BC1 VA: 0x3241AC0
	private NamespaceList CompareSetToOther(NamespaceList other) { }

	// RVA: 0x3241C00 Offset: 0x3241D01 VA: 0x3241C00
	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x3242100 Offset: 0x3242201 VA: 0x3242100
	private void RemoveNamespace(string tns) { }
}

