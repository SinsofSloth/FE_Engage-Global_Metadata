// Namespace: System.Xml
public class XmlDocument : XmlNode // TypeDefIndex: 1694
{
	// Fields
	private XmlImplementation implementation; // 0x18
	private DomNameTable domNameTable; // 0x20
	private XmlLinkedNode lastChild; // 0x28
	private XmlNamedNodeMap entities; // 0x30
	private Hashtable htElementIdMap; // 0x38
	private Hashtable htElementIDAttrDecl; // 0x40
	private SchemaInfo schemaInfo; // 0x48
	private XmlSchemaSet schemas; // 0x50
	private bool reportValidity; // 0x58
	private bool actualLoadingStatus; // 0x59
	private XmlNodeChangedEventHandler onNodeInsertingDelegate; // 0x60
	private XmlNodeChangedEventHandler onNodeInsertedDelegate; // 0x68
	private XmlNodeChangedEventHandler onNodeRemovingDelegate; // 0x70
	private XmlNodeChangedEventHandler onNodeRemovedDelegate; // 0x78
	private XmlNodeChangedEventHandler onNodeChangingDelegate; // 0x80
	private XmlNodeChangedEventHandler onNodeChangedDelegate; // 0x88
	internal bool fEntRefNodesPresent; // 0x90
	internal bool fCDataNodesPresent; // 0x91
	private bool preserveWhitespace; // 0x92
	private bool isLoading; // 0x93
	internal string strDocumentName; // 0x98
	internal string strDocumentFragmentName; // 0xA0
	internal string strCommentName; // 0xA8
	internal string strTextName; // 0xB0
	internal string strCDataSectionName; // 0xB8
	internal string strEntityName; // 0xC0
	internal string strID; // 0xC8
	internal string strXmlns; // 0xD0
	internal string strXml; // 0xD8
	internal string strSpace; // 0xE0
	internal string strLang; // 0xE8
	internal string strEmpty; // 0xF0
	internal string strNonSignificantWhitespaceName; // 0xF8
	internal string strSignificantWhitespaceName; // 0x100
	internal string strReservedXmlns; // 0x108
	internal string strReservedXml; // 0x110
	internal string baseURI; // 0x118
	private XmlResolver resolver; // 0x120
	internal bool bSetResolver; // 0x128
	internal object objLock; // 0x130
	internal static EmptyEnumerator EmptyEnumerator; // 0x0
	internal static IXmlSchemaInfo NotKnownSchemaInfo; // 0x8
	internal static IXmlSchemaInfo ValidSchemaInfo; // 0x10
	internal static IXmlSchemaInfo InvalidSchemaInfo; // 0x18

	// Properties
	internal SchemaInfo DtdSchemaInfo { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public virtual XmlDocumentType DocumentType { get; }
	internal virtual XmlDeclaration Declaration { get; }
	public XmlImplementation Implementation { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public XmlElement DocumentElement { get; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlDocument OwnerDocument { get; }
	public XmlSchemaSet Schemas { set; }
	internal bool CanReportValidity { get; }
	internal bool HasSetResolver { get; }
	public XmlNameTable NameTable { get; }
	public override bool IsReadOnly { get; }
	internal XmlNamedNodeMap Entities { get; set; }
	internal bool IsLoading { get; set; }
	internal bool ActualLoadingStatus { get; }
	public override string InnerText { set; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }

	// Methods

	// RVA: 0x1AA89C0 Offset: 0x1AA8AC1 VA: 0x1AA89C0
	public void .ctor() { }

	// RVA: 0x1AA8A30 Offset: 0x1AA8B31 VA: 0x1AA8A30
	protected internal void .ctor(XmlImplementation imp) { }

	// RVA: 0x1AA8EF0 Offset: 0x1AA8FF1 VA: 0x1AA8EF0
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x1AA8F00 Offset: 0x1AA9001 VA: 0x1AA8F00
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	// RVA: 0x1A959F0 Offset: 0x1A95AF1 VA: 0x1A959F0
	internal static void CheckName(string name) { }

	// RVA: 0x1AA8F10 Offset: 0x1AA9011 VA: 0x1AA8F10
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1AA8F20 Offset: 0x1AA9021 VA: 0x1AA8F20
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1A95B10 Offset: 0x1A95C11 VA: 0x1A95B10
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1AA8F30 Offset: 0x1AA9031 VA: 0x1AA8F30
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	// RVA: 0x1AA9010 Offset: 0x1AA9111 VA: 0x1AA9010
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	// RVA: 0x1A97CA0 Offset: 0x1A97DA1 VA: 0x1A97CA0
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	// RVA: 0x1AA90F0 Offset: 0x1AA91F1 VA: 0x1AA90F0
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	// RVA: 0x1A97CC0 Offset: 0x1A97DC1 VA: 0x1A97CC0
	internal void AddElementWithId(string id, XmlElement elem) { }

	// RVA: 0x1A97EB0 Offset: 0x1A97FB1 VA: 0x1A97EB0
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	// RVA: 0x1AA9690 Offset: 0x1AA9791 VA: 0x1AA9690 Slot: 27
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1AA97F0 Offset: 0x1AA98F1 VA: 0x1AA97F0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1AA9800 Offset: 0x1AA9901 VA: 0x1AA9800 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1AA9810 Offset: 0x1AA9911 VA: 0x1AA9810 Slot: 45
	public virtual XmlDocumentType get_DocumentType() { }

	// RVA: 0x1AA98A0 Offset: 0x1AA99A1 VA: 0x1AA98A0 Slot: 46
	internal virtual XmlDeclaration get_Declaration() { }

	// RVA: 0x1AA9960 Offset: 0x1AA9A61 VA: 0x1AA9960
	public XmlImplementation get_Implementation() { }

	// RVA: 0x1AA9970 Offset: 0x1AA9A71 VA: 0x1AA9970 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1AA9980 Offset: 0x1AA9A81 VA: 0x1AA9980 Slot: 31
	public override string get_LocalName() { }

	// RVA: 0x1AA9990 Offset: 0x1AA9A91 VA: 0x1AA9990
	public XmlElement get_DocumentElement() { }

	// RVA: 0x1AA9A20 Offset: 0x1AA9B21 VA: 0x1AA9A20 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x1AA9A30 Offset: 0x1AA9B31 VA: 0x1AA9A30 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x1AA9A40 Offset: 0x1AA9B41 VA: 0x1AA9A40 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1AA9A50 Offset: 0x1AA9B51 VA: 0x1AA9A50 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1AA9A60 Offset: 0x1AA9B61 VA: 0x1AA9A60
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x1AA9A70 Offset: 0x1AA9B71 VA: 0x1AA9A70
	internal bool get_CanReportValidity() { }

	// RVA: 0x1AA9A80 Offset: 0x1AA9B81 VA: 0x1AA9A80
	internal bool get_HasSetResolver() { }

	// RVA: 0x1AA9A90 Offset: 0x1AA9B91 VA: 0x1AA9A90
	internal XmlResolver GetResolver() { }

	// RVA: 0x1AA9AA0 Offset: 0x1AA9BA1 VA: 0x1AA9AA0 Slot: 24
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1AA9C00 Offset: 0x1AA9D01 VA: 0x1AA9C00
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x1AA9CD0 Offset: 0x1AA9DD1 VA: 0x1AA9CD0
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x1AA9D50 Offset: 0x1AA9E51 VA: 0x1AA9D50 Slot: 25
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1AA9EC0 Offset: 0x1AA9FC1 VA: 0x1AA9EC0
	internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI) { }

	// RVA: 0x1AA9F60 Offset: 0x1AAA061 VA: 0x1AA9F60 Slot: 47
	public virtual XmlCDataSection CreateCDataSection(string data) { }

	// RVA: 0x1AA9FF0 Offset: 0x1AAA0F1 VA: 0x1AA9FF0 Slot: 48
	public virtual XmlComment CreateComment(string data) { }

	// RVA: 0x1AAA070 Offset: 0x1AAA171 VA: 0x1AAA070 Slot: 49
	public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x1AAA110 Offset: 0x1AAA211 VA: 0x1AAA110 Slot: 50
	public virtual XmlDocumentFragment CreateDocumentFragment() { }

	// RVA: 0x1AAA180 Offset: 0x1AAA281 VA: 0x1AAA180
	internal void AddDefaultAttributes(XmlElement elem) { }

	// RVA: 0x1AAA410 Offset: 0x1AAA511 VA: 0x1AAA410
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	// RVA: 0x1AAA520 Offset: 0x1AAA621 VA: 0x1AAA520
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x1AAA660 Offset: 0x1AAA761 VA: 0x1AAA660 Slot: 51
	public virtual XmlEntityReference CreateEntityReference(string name) { }

	// RVA: 0x1AAA6D0 Offset: 0x1AAA7D1 VA: 0x1AAA6D0 Slot: 52
	public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x1AAA750 Offset: 0x1AAA851 VA: 0x1AAA750 Slot: 53
	public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0x1AAA7E0 Offset: 0x1AAA8E1 VA: 0x1AAA7E0 Slot: 54
	public virtual XmlText CreateTextNode(string text) { }

	// RVA: 0x1AAA850 Offset: 0x1AAA951 VA: 0x1AAA850 Slot: 55
	public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	// RVA: 0x1AAA8C0 Offset: 0x1AAA9C1 VA: 0x1AAA8C0 Slot: 56
	public virtual XmlWhitespace CreateWhitespace(string text) { }

	// RVA: 0x1AAA930 Offset: 0x1AAAA31 VA: 0x1AAA930
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	// RVA: 0x1AAAF00 Offset: 0x1AAB001 VA: 0x1AAAF00
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	// RVA: 0x1AA9750 Offset: 0x1AA9851 VA: 0x1AA9750
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	// RVA: 0x1AA8EE0 Offset: 0x1AA8FE1 VA: 0x1AA8EE0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1AAB000 Offset: 0x1AAB101 VA: 0x1AAB000 Slot: 57
	public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x1AAB0A0 Offset: 0x1AAB1A1 VA: 0x1AAB0A0 Slot: 58
	protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x1AAB130 Offset: 0x1AAB231 VA: 0x1AAB130 Slot: 59
	public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x1AAB1F0 Offset: 0x1AAB2F1 VA: 0x1AAB1F0 Slot: 32
	public override bool get_IsReadOnly() { }

	// RVA: 0x1AAB200 Offset: 0x1AAB301 VA: 0x1AAB200
	internal XmlNamedNodeMap get_Entities() { }

	// RVA: 0x1AAB2A0 Offset: 0x1AAB3A1 VA: 0x1AAB2A0
	internal void set_Entities(XmlNamedNodeMap value) { }

	// RVA: 0x1AAB2B0 Offset: 0x1AAB3B1 VA: 0x1AAB2B0
	internal bool get_IsLoading() { }

	// RVA: 0x1AAB2C0 Offset: 0x1AAB3C1 VA: 0x1AAB2C0
	internal void set_IsLoading(bool value) { }

	// RVA: 0x1AAB2D0 Offset: 0x1AAB3D1 VA: 0x1AAB2D0
	internal bool get_ActualLoadingStatus() { }

	// RVA: 0x1AAB2E0 Offset: 0x1AAB3E1 VA: 0x1AAB2E0
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	// RVA: 0x1AAB340 Offset: 0x1AAB441 VA: 0x1AAB340 Slot: 60
	public virtual void Load(XmlReader reader) { }

	// RVA: 0x1AAB430 Offset: 0x1AAB531 VA: 0x1AAB430 Slot: 61
	public virtual void LoadXml(string xml) { }

	// RVA: 0x1AAB5A0 Offset: 0x1AAB6A1 VA: 0x1AAB5A0 Slot: 34
	public override void set_InnerText(string value) { }

	// RVA: 0x1AAB600 Offset: 0x1AAB701 VA: 0x1AAB600 Slot: 35
	public override void set_InnerXml(string value) { }

	// RVA: 0x1AAB610 Offset: 0x1AAB711 VA: 0x1AAB610 Slot: 41
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x1A96440 Offset: 0x1A96541 VA: 0x1A96440
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	// RVA: 0x1AAB710 Offset: 0x1AAB811 VA: 0x1AAB710 Slot: 42
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x1AAB770 Offset: 0x1AAB871 VA: 0x1AAB770 Slot: 43
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x1A97A00 Offset: 0x1A97B01 VA: 0x1A97A00
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x1AAB7D0 Offset: 0x1AAB8D1 VA: 0x1AAB7D0
	internal XmlEntity GetEntityNode(string name) { }

	// RVA: 0x1AAB8A0 Offset: 0x1AAB9A1 VA: 0x1AAB8A0 Slot: 36
	public override string get_BaseURI() { }

	// RVA: 0x1AAB8B0 Offset: 0x1AAB9B1 VA: 0x1AAB8B0
	internal void SetBaseURI(string inBaseURI) { }

	// RVA: 0x1AAB8C0 Offset: 0x1AAB9C1 VA: 0x1AAB8C0 Slot: 23
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x1AABB30 Offset: 0x1AABC31 VA: 0x1AABB30
	private static void .cctor() { }
}

