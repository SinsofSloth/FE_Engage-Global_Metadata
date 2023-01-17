// Namespace: System.Xml.Schema
public class XmlSchemaNotation : XmlSchemaAnnotated // TypeDefIndex: 2016
{
	// Fields
	private string name; // 0x50
	private string publicId; // 0x58
	private string systemId; // 0x60
	private XmlQualifiedName qname; // 0x68

	// Properties
	[XmlAttributeAttribute] // RVA: 0x4A7B0 Offset: 0x4A8B1 VA: 0x4A7B0
	public string Name { get; set; }
	[XmlAttributeAttribute] // RVA: 0x4A7F0 Offset: 0x4A8F1 VA: 0x4A7F0
	public string Public { get; set; }
	[XmlAttributeAttribute] // RVA: 0x4A830 Offset: 0x4A931 VA: 0x4A830
	public string System { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A870 Offset: 0x4A971 VA: 0x4A870
	internal XmlQualifiedName QualifiedName { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A880 Offset: 0x4A981 VA: 0x4A880
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x19675C0 Offset: 0x19676C1 VA: 0x19675C0
	public string get_Name() { }

	// RVA: 0x19675D0 Offset: 0x19676D1 VA: 0x19675D0
	public void set_Name(string value) { }

	// RVA: 0x19675E0 Offset: 0x19676E1 VA: 0x19675E0
	public string get_Public() { }

	// RVA: 0x19675F0 Offset: 0x19676F1 VA: 0x19675F0
	public void set_Public(string value) { }

	// RVA: 0x1967600 Offset: 0x1967701 VA: 0x1967600
	public string get_System() { }

	// RVA: 0x1967610 Offset: 0x1967711 VA: 0x1967610
	public void set_System(string value) { }

	// RVA: 0x1967620 Offset: 0x1967721 VA: 0x1967620
	internal XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1967630 Offset: 0x1967731 VA: 0x1967630
	internal void set_QualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1967640 Offset: 0x1967741 VA: 0x1967640 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x1967650 Offset: 0x1967751 VA: 0x1967650 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1967660 Offset: 0x1967761 VA: 0x1967660
	public void .ctor() { }
}

