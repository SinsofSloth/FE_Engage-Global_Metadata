// Namespace: System.Xml.Schema
public abstract class XmlSchemaExternal : XmlSchemaObject // TypeDefIndex: 1988
{
	// Fields
	private string location; // 0x38
	private Uri baseUri; // 0x40
	private XmlSchema schema; // 0x48
	private string id; // 0x50
	private XmlAttribute[] moreAttributes; // 0x58
	private Compositor compositor; // 0x60

	// Properties
	[XmlAttributeAttribute] // RVA: 0x4A1B0 Offset: 0x4A2B1 VA: 0x4A1B0
	public string SchemaLocation { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A210 Offset: 0x4A311 VA: 0x4A210
	public XmlSchema Schema { get; set; }
	[XmlAttributeAttribute] // RVA: 0x4A220 Offset: 0x4A321 VA: 0x4A220
	public string Id { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A280 Offset: 0x4A381 VA: 0x4A280
	internal Uri BaseUri { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A290 Offset: 0x4A391 VA: 0x4A290
	internal override string IdAttribute { get; set; }
	internal Compositor Compositor { get; set; }

	// Methods

	// RVA: 0x19666C0 Offset: 0x19667C1 VA: 0x19666C0
	public string get_SchemaLocation() { }

	// RVA: 0x19666D0 Offset: 0x19667D1 VA: 0x19666D0
	public void set_SchemaLocation(string value) { }

	// RVA: 0x19666E0 Offset: 0x19667E1 VA: 0x19666E0
	public XmlSchema get_Schema() { }

	// RVA: 0x19666F0 Offset: 0x19667F1 VA: 0x19666F0
	public void set_Schema(XmlSchema value) { }

	// RVA: 0x1966700 Offset: 0x1966801 VA: 0x1966700
	public string get_Id() { }

	// RVA: 0x1966710 Offset: 0x1966811 VA: 0x1966710
	public void set_Id(string value) { }

	// RVA: 0x1966720 Offset: 0x1966821 VA: 0x1966720
	internal Uri get_BaseUri() { }

	// RVA: 0x1966730 Offset: 0x1966831 VA: 0x1966730
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x1966740 Offset: 0x1966841 VA: 0x1966740 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x1966750 Offset: 0x1966851 VA: 0x1966750 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x1966760 Offset: 0x1966861 VA: 0x1966760 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1966770 Offset: 0x1966871 VA: 0x1966770
	internal Compositor get_Compositor() { }

	// RVA: 0x1966780 Offset: 0x1966881 VA: 0x1966780
	internal void set_Compositor(Compositor value) { }

	// RVA: 0x1966790 Offset: 0x1966891 VA: 0x1966790
	protected void .ctor() { }
}

