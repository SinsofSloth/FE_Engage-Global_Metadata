// Namespace: System.Xml.Schema
public abstract class XmlSchemaParticle : XmlSchemaAnnotated // TypeDefIndex: 2027
{
	// Fields
	private Decimal minOccurs; // 0x50
	private Decimal maxOccurs; // 0x60
	private XmlSchemaParticle.Occurs flags; // 0x70
	internal static readonly XmlSchemaParticle Empty; // 0x0

	// Properties
	[XmlAttributeAttribute] // RVA: 0x4A910 Offset: 0x4AA11 VA: 0x4A910
	public string MinOccursString { get; set; }
	[XmlAttributeAttribute] // RVA: 0x4A950 Offset: 0x4AA51 VA: 0x4A950
	public string MaxOccursString { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A990 Offset: 0x4AA91 VA: 0x4A990
	public Decimal MinOccurs { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A9A0 Offset: 0x4AAA1 VA: 0x4A9A0
	public Decimal MaxOccurs { get; set; }
	internal virtual bool IsEmpty { get; }
	internal virtual string NameString { get; }

	// Methods

	// RVA: 0x19685D0 Offset: 0x19686D1 VA: 0x19685D0
	public string get_MinOccursString() { }

	// RVA: 0x1968660 Offset: 0x1968761 VA: 0x1968660
	public void set_MinOccursString(string value) { }

	// RVA: 0x19687D0 Offset: 0x19688D1 VA: 0x19687D0
	public string get_MaxOccursString() { }

	// RVA: 0x19688F0 Offset: 0x19689F1 VA: 0x19688F0
	public void set_MaxOccursString(string value) { }

	// RVA: 0x1968B10 Offset: 0x1968C11 VA: 0x1968B10
	public Decimal get_MinOccurs() { }

	// RVA: 0x19618D0 Offset: 0x19619D1 VA: 0x19618D0
	public void set_MinOccurs(Decimal value) { }

	// RVA: 0x1968B20 Offset: 0x1968C21 VA: 0x1968B20
	public Decimal get_MaxOccurs() { }

	// RVA: 0x1961A20 Offset: 0x1961B21 VA: 0x1961A20
	public void set_MaxOccurs(Decimal value) { }

	// RVA: 0x195DE20 Offset: 0x195DF21 VA: 0x195DE20 Slot: 14
	internal virtual bool get_IsEmpty() { }

	// RVA: 0x1968B30 Offset: 0x1968C31 VA: 0x1968B30 Slot: 15
	internal virtual string get_NameString() { }

	// RVA: 0x1968B80 Offset: 0x1968C81 VA: 0x1968B80
	internal XmlQualifiedName GetQualifiedName() { }

	// RVA: 0x195E900 Offset: 0x195EA01 VA: 0x195E900
	protected void .ctor() { }

	// RVA: 0x1968D20 Offset: 0x1968E21 VA: 0x1968D20
	private static void .cctor() { }
}

