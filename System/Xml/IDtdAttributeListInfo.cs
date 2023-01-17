// Namespace: System.Xml
internal interface IDtdAttributeListInfo // TypeDefIndex: 1634
{
	// Properties
	public abstract bool HasNonCDataAttributes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_HasNonCDataAttributes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDtdAttributeInfo LookupAttribute(string prefix, string localName);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes();
}

