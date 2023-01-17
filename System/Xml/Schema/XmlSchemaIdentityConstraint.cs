// Namespace: System.Xml.Schema
public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated // TypeDefIndex: 2008
{
	// Fields
	private string name; // 0x50
	private XmlSchemaXPath selector; // 0x58
	private XmlSchemaObjectCollection fields; // 0x60
	private XmlQualifiedName qualifiedName; // 0x68
	private CompiledIdentityConstraint compiledConstraint; // 0x70

	// Properties
	[XmlAttributeAttribute] // RVA: 0x4A540 Offset: 0x4A641 VA: 0x4A540
	public string Name { get; set; }
	[XmlElementAttribute] // RVA: 0x4A580 Offset: 0x4A681 VA: 0x4A580
	public XmlSchemaXPath Selector { get; set; }
	[XmlElementAttribute] // RVA: 0x4A600 Offset: 0x4A701 VA: 0x4A600
	public XmlSchemaObjectCollection Fields { get; }
	[XmlIgnoreAttribute] // RVA: 0x4A680 Offset: 0x4A781 VA: 0x4A680
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnoreAttribute] // RVA: 0x4A690 Offset: 0x4A791 VA: 0x4A690
	internal CompiledIdentityConstraint CompiledConstraint { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A6A0 Offset: 0x4A7A1 VA: 0x4A6A0
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x1966D80 Offset: 0x1966E81 VA: 0x1966D80
	public string get_Name() { }

	// RVA: 0x1966D90 Offset: 0x1966E91 VA: 0x1966D90
	public void set_Name(string value) { }

	// RVA: 0x1966DA0 Offset: 0x1966EA1 VA: 0x1966DA0
	public XmlSchemaXPath get_Selector() { }

	// RVA: 0x1966DB0 Offset: 0x1966EB1 VA: 0x1966DB0
	public void set_Selector(XmlSchemaXPath value) { }

	// RVA: 0x1966DC0 Offset: 0x1966EC1 VA: 0x1966DC0
	public XmlSchemaObjectCollection get_Fields() { }

	// RVA: 0x1966DD0 Offset: 0x1966ED1 VA: 0x1966DD0
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1966DE0 Offset: 0x1966EE1 VA: 0x1966DE0
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1966DF0 Offset: 0x1966EF1 VA: 0x1966DF0
	internal CompiledIdentityConstraint get_CompiledConstraint() { }

	// RVA: 0x1966E00 Offset: 0x1966F01 VA: 0x1966E00
	internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

	// RVA: 0x1966E10 Offset: 0x1966F11 VA: 0x1966E10 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x1966E20 Offset: 0x1966F21 VA: 0x1966E20 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1966E30 Offset: 0x1966F31 VA: 0x1966E30
	public void .ctor() { }
}

