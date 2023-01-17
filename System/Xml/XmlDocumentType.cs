// Namespace: System.Xml
public class XmlDocumentType : XmlLinkedNode // TypeDefIndex: 1696
{
	// Fields
	private string name; // 0x20
	private string publicId; // 0x28
	private string systemId; // 0x30
	private string internalSubset; // 0x38
	private bool namespaces; // 0x40
	private XmlNamedNodeMap entities; // 0x48
	private XmlNamedNodeMap notations; // 0x50
	private SchemaInfo schemaInfo; // 0x58

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	public XmlNamedNodeMap Entities { get; }
	public XmlNamedNodeMap Notations { get; }
	public string PublicId { get; }
	public string SystemId { get; }
	public string InternalSubset { get; }
	internal bool ParseWithNamespaces { get; }
	internal SchemaInfo DtdSchemaInfo { get; set; }

	// Methods

	// RVA: 0x32E8900 Offset: 0x32E8A01 VA: 0x32E8900
	protected internal void .ctor(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	// RVA: 0x32E8AE0 Offset: 0x32E8BE1 VA: 0x32E8AE0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x32E8AF0 Offset: 0x32E8BF1 VA: 0x32E8AF0 Slot: 31
	public override string get_LocalName() { }

	// RVA: 0x32E8B00 Offset: 0x32E8C01 VA: 0x32E8B00 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x32E8B10 Offset: 0x32E8C11 VA: 0x32E8B10 Slot: 27
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x32E8B50 Offset: 0x32E8C51 VA: 0x32E8B50 Slot: 32
	public override bool get_IsReadOnly() { }

	// RVA: 0x32E8B60 Offset: 0x32E8C61 VA: 0x32E8B60
	public XmlNamedNodeMap get_Entities() { }

	// RVA: 0x32E8C50 Offset: 0x32E8D51 VA: 0x32E8C50
	public XmlNamedNodeMap get_Notations() { }

	// RVA: 0x32E8D00 Offset: 0x32E8E01 VA: 0x32E8D00
	public string get_PublicId() { }

	// RVA: 0x32E8D10 Offset: 0x32E8E11 VA: 0x32E8D10
	public string get_SystemId() { }

	// RVA: 0x32E8D20 Offset: 0x32E8E21 VA: 0x32E8D20
	public string get_InternalSubset() { }

	// RVA: 0x32E8D30 Offset: 0x32E8E31 VA: 0x32E8D30
	internal bool get_ParseWithNamespaces() { }

	// RVA: 0x32E8D40 Offset: 0x32E8E41 VA: 0x32E8D40
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x32E8D50 Offset: 0x32E8E51 VA: 0x32E8D50
	internal void set_DtdSchemaInfo(SchemaInfo value) { }
}

