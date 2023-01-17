// Namespace: System.Xml
[EditorBrowsableAttribute] // RVA: 0x46D10 Offset: 0x46E11 VA: 0x46D10
public class XmlTextReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 1660
{
	// Fields
	private XmlTextReaderImpl impl; // 0x10

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public EntityHandling EntityHandling { set; }
	public XmlResolver XmlResolver { set; }
	internal XmlTextReaderImpl Impl { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool XmlValidatingReaderCompatibilityMode { set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x1BABA40 Offset: 0x1BABB41 VA: 0x1BABA40
	public void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x1BABC40 Offset: 0x1BABD41 VA: 0x1BABC40
	public void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x1BABDD0 Offset: 0x1BABED1 VA: 0x1BABDD0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1BABDE0 Offset: 0x1BABEE1 VA: 0x1BABDE0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1BABDF0 Offset: 0x1BABEF1 VA: 0x1BABDF0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1BABE00 Offset: 0x1BABF01 VA: 0x1BABE00 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1BABE10 Offset: 0x1BABF11 VA: 0x1BABE10 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1BABE20 Offset: 0x1BABF21 VA: 0x1BABE20 Slot: 11
	public override string get_Value() { }

	// RVA: 0x1BABE30 Offset: 0x1BABF31 VA: 0x1BABE30 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x1BABE40 Offset: 0x1BABF41 VA: 0x1BABE40 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x1BABE60 Offset: 0x1BABF61 VA: 0x1BABE60 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1BABE80 Offset: 0x1BABF81 VA: 0x1BABE80 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x1BABEA0 Offset: 0x1BABFA1 VA: 0x1BABEA0 Slot: 17
	public override int get_AttributeCount() { }

	// RVA: 0x1BABEC0 Offset: 0x1BABFC1 VA: 0x1BABEC0 Slot: 18
	public override string GetAttribute(string name) { }

	// RVA: 0x1BABEE0 Offset: 0x1BABFE1 VA: 0x1BABEE0 Slot: 19
	public override string GetAttribute(int i) { }

	// RVA: 0x1BABF00 Offset: 0x1BAC001 VA: 0x1BABF00 Slot: 20
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1BABF20 Offset: 0x1BAC021 VA: 0x1BABF20 Slot: 21
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1BABF40 Offset: 0x1BAC041 VA: 0x1BABF40 Slot: 22
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1BABF60 Offset: 0x1BAC061 VA: 0x1BABF60 Slot: 23
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1BABF80 Offset: 0x1BAC081 VA: 0x1BABF80 Slot: 24
	public override bool MoveToElement() { }

	// RVA: 0x1BABFA0 Offset: 0x1BAC0A1 VA: 0x1BABFA0 Slot: 25
	public override bool ReadAttributeValue() { }

	// RVA: 0x1BABFC0 Offset: 0x1BAC0C1 VA: 0x1BABFC0 Slot: 26
	public override bool Read() { }

	// RVA: 0x1BABFE0 Offset: 0x1BAC0E1 VA: 0x1BABFE0 Slot: 27
	public override bool get_EOF() { }

	// RVA: 0x1BAC000 Offset: 0x1BAC101 VA: 0x1BAC000 Slot: 28
	public override void Close() { }

	// RVA: 0x1BAC020 Offset: 0x1BAC121 VA: 0x1BAC020 Slot: 29
	public override ReadState get_ReadState() { }

	// RVA: 0x1BAC040 Offset: 0x1BAC141 VA: 0x1BAC040 Slot: 30
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1BAC060 Offset: 0x1BAC161 VA: 0x1BAC060 Slot: 31
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1BAC0A0 Offset: 0x1BAC1A1 VA: 0x1BAC0A0 Slot: 32
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1BAC0B0 Offset: 0x1BAC1B1 VA: 0x1BAC0B0 Slot: 33
	public override void ResolveEntity() { }

	// RVA: 0x1BAC0D0 Offset: 0x1BAC1D1 VA: 0x1BAC0D0 Slot: 37
	public int get_LineNumber() { }

	// RVA: 0x1BAC0F0 Offset: 0x1BAC1F1 VA: 0x1BAC0F0 Slot: 38
	public int get_LinePosition() { }

	// RVA: 0x1BAC110 Offset: 0x1BAC211 VA: 0x1BAC110 Slot: 39
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1BAC150 Offset: 0x1BAC251 VA: 0x1BAC150 Slot: 40
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1BAC170 Offset: 0x1BAC271 VA: 0x1BAC170 Slot: 41
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1BAC1B0 Offset: 0x1BAC2B1 VA: 0x1BAC1B0
	public void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x1BAC250 Offset: 0x1BAC351 VA: 0x1BAC250
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1BAC390 Offset: 0x1BAC491 VA: 0x1BAC390
	internal XmlTextReaderImpl get_Impl() { }

	// RVA: 0x1BAC3A0 Offset: 0x1BAC4A1 VA: 0x1BAC3A0 Slot: 35
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1BAC3C0 Offset: 0x1BAC4C1 VA: 0x1BAC3C0
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x1BAC560 Offset: 0x1BAC661 VA: 0x1BAC560 Slot: 36
	internal override IDtdInfo get_DtdInfo() { }
}

