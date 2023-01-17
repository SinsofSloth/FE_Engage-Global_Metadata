// Namespace: 
private struct ContentCatalogData.Bucket // TypeDefIndex: 7309
{
	// Fields
	public int dataOffset; // 0x0
	public int[] entries; // 0x8
}

// Namespace: 
private class ContentCatalogData.CompactLocation : IResourceLocation // TypeDefIndex: 7310
{
	// Fields
	private ResourceLocationMap m_Locator; // 0x10
	private string m_InternalId; // 0x18
	private string m_ProviderId; // 0x20
	private object m_Dependency; // 0x28
	private object m_Data; // 0x30
	private int m_HashCode; // 0x38
	private int m_DependencyHashCode; // 0x3C
	private string m_PrimaryKey; // 0x40
	private Type m_Type; // 0x48

	// Properties
	public string InternalId { get; }
	public string ProviderId { get; }
	public IList<IResourceLocation> Dependencies { get; }
	public bool HasDependencies { get; }
	public int DependencyHashCode { get; }
	public object Data { get; }
	public string PrimaryKey { get; set; }
	public Type ResourceType { get; }

	// Methods

	// RVA: 0x30A1790 Offset: 0x30A1891 VA: 0x30A1790 Slot: 4
	public string get_InternalId() { }

	// RVA: 0x30A17A0 Offset: 0x30A18A1 VA: 0x30A17A0 Slot: 5
	public string get_ProviderId() { }

	// RVA: 0x30A17B0 Offset: 0x30A18B1 VA: 0x30A17B0 Slot: 6
	public IList<IResourceLocation> get_Dependencies() { }

	// RVA: 0x30A1880 Offset: 0x30A1981 VA: 0x30A1880 Slot: 9
	public bool get_HasDependencies() { }

	// RVA: 0x30A1890 Offset: 0x30A1991 VA: 0x30A1890 Slot: 8
	public int get_DependencyHashCode() { }

	// RVA: 0x30A18A0 Offset: 0x30A19A1 VA: 0x30A18A0 Slot: 10
	public object get_Data() { }

	// RVA: 0x30A18B0 Offset: 0x30A19B1 VA: 0x30A18B0 Slot: 11
	public string get_PrimaryKey() { }

	// RVA: 0x30A18C0 Offset: 0x30A19C1 VA: 0x30A18C0
	public void set_PrimaryKey(string value) { }

	// RVA: 0x30A18D0 Offset: 0x30A19D1 VA: 0x30A18D0 Slot: 12
	public Type get_ResourceType() { }

	// RVA: 0x30A18E0 Offset: 0x30A19E1 VA: 0x30A18E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x30A18F0 Offset: 0x30A19F1 VA: 0x30A18F0 Slot: 7
	public int Hash(Type t) { }

	// RVA: 0x3097B50 Offset: 0x3097C51 VA: 0x3097B50
	public void .ctor(ResourceLocationMap locator, string internalId, string providerId, object dependencyKey, object data, int depHash, string primaryKey, Type type) { }
}

