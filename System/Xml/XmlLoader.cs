// Namespace: System.Xml
internal class XmlLoader // TypeDefIndex: 1703
{
	// Fields
	private XmlDocument doc; // 0x10
	private XmlReader reader; // 0x18
	private bool preserveWhitespace; // 0x20

	// Methods

	// RVA: 0x32E8560 Offset: 0x32E8661 VA: 0x32E8560
	public void .ctor() { }

	// RVA: 0x32EFD30 Offset: 0x32EFE31 VA: 0x32EFD30
	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	// RVA: 0x32F00A0 Offset: 0x32F01A1 VA: 0x32F00A0
	private void LoadDocSequence(XmlDocument parentDoc) { }

	// RVA: 0x32F0110 Offset: 0x32F0211 VA: 0x32F0110
	private XmlNode LoadNode(bool skipOverWhitespace) { }

	// RVA: 0x32F0730 Offset: 0x32F0831 VA: 0x32F0730
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x32F1140 Offset: 0x32F1241 VA: 0x32F1140
	private XmlAttribute LoadDefaultAttribute() { }

	// RVA: 0x32F12D0 Offset: 0x32F13D1 VA: 0x32F12D0
	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	// RVA: 0x32F0A50 Offset: 0x32F0B51 VA: 0x32F0A50
	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	// RVA: 0x32F0C90 Offset: 0x32F0D91 VA: 0x32F0C90
	private XmlDeclaration LoadDeclarationNode() { }

	// RVA: 0x32F0E50 Offset: 0x32F0F51 VA: 0x32F0E50
	private XmlDocumentType LoadDocumentTypeNode() { }

	// RVA: 0x32F15B0 Offset: 0x32F16B1 VA: 0x32F15B0
	private XmlNode LoadNodeDirect() { }

	// RVA: 0x32F2A60 Offset: 0x32F2B61 VA: 0x32F2A60
	private XmlAttribute LoadAttributeNodeDirect() { }

	// RVA: 0x32E8A70 Offset: 0x32E8B71 VA: 0x32E8A70
	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	// RVA: 0x32F2C10 Offset: 0x32F2D11 VA: 0x32F2C10
	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	// RVA: 0x32F1D20 Offset: 0x32F1E21 VA: 0x32F1D20
	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	// RVA: 0x32F3200 Offset: 0x32F3301 VA: 0x32F3200
	private XmlParserContext GetContext(XmlNode node) { }

	// RVA: 0x32E8570 Offset: 0x32E8671 VA: 0x32E8570
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	// RVA: 0x32EAA50 Offset: 0x32EAB51 VA: 0x32EAA50
	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	// RVA: 0x32F3F80 Offset: 0x32F4081 VA: 0x32F3F80
	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	// RVA: 0x32F3CF0 Offset: 0x32F3DF1 VA: 0x32F3CF0
	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	// RVA: 0x32F3F90 Offset: 0x32F4091 VA: 0x32F3F90
	private string EntitizeName(string name) { }

	// RVA: 0x32EB180 Offset: 0x32EB281 VA: 0x32EB180
	internal void ExpandEntity(XmlEntity ent) { }

	// RVA: 0x32EB670 Offset: 0x32EB771 VA: 0x32EB670
	internal void ExpandEntityReference(XmlEntityReference eref) { }

	// RVA: 0x32F3A70 Offset: 0x32F3B71 VA: 0x32F3A70
	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	// RVA: 0x32F1AD0 Offset: 0x32F1BD1 VA: 0x32F1AD0
	internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone) { }

	// RVA: 0x32F1010 Offset: 0x32F1111 VA: 0x32F1010
	internal static Exception UnexpectedNodeType(XmlNodeType nodetype) { }
}

