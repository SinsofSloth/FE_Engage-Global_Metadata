// Namespace: System.Xml.Schema
public abstract class XmlSchemaFacet : XmlSchemaAnnotated // TypeDefIndex: 1990
{
	// Fields
	private string value; // 0x50
	private bool isFixed; // 0x58
	private FacetType facetType; // 0x5C

	// Properties
	[XmlAttributeAttribute] // RVA: 0x4A2A0 Offset: 0x4A3A1 VA: 0x4A2A0
	public string Value { get; set; }
	[XmlAttributeAttribute] // RVA: 0x4A2E0 Offset: 0x4A3E1 VA: 0x4A2E0
	[DefaultValueAttribute] // RVA: 0x4A2E0 Offset: 0x4A3E1 VA: 0x4A2E0
	public virtual bool IsFixed { get; set; }
	internal FacetType FacetType { get; set; }

	// Methods

	// RVA: 0x19667A0 Offset: 0x19668A1 VA: 0x19667A0
	public string get_Value() { }

	// RVA: 0x19667B0 Offset: 0x19668B1 VA: 0x19667B0
	public void set_Value(string value) { }

	// RVA: 0x19667C0 Offset: 0x19668C1 VA: 0x19667C0 Slot: 14
	public virtual bool get_IsFixed() { }

	// RVA: 0x19667D0 Offset: 0x19668D1 VA: 0x19667D0 Slot: 15
	public virtual void set_IsFixed(bool value) { }

	// RVA: 0x1966890 Offset: 0x1966991 VA: 0x1966890
	internal FacetType get_FacetType() { }

	// RVA: 0x19668A0 Offset: 0x19669A1 VA: 0x19668A0
	internal void set_FacetType(FacetType value) { }

	// RVA: 0x1965600 Offset: 0x1965701 VA: 0x1965600
	protected void .ctor() { }
}

