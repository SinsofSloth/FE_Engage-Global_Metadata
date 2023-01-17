// Namespace: System.Xml
internal class ValidatingReaderNodeData // TypeDefIndex: 1648
{
	// Fields
	private string localName; // 0x10
	private string namespaceUri; // 0x18
	private string prefix; // 0x20
	private string nameWPrefix; // 0x28
	private string rawValue; // 0x30
	private string originalStringValue; // 0x38
	private int depth; // 0x40
	private AttributePSVIInfo attributePSVIInfo; // 0x48
	private XmlNodeType nodeType; // 0x50
	private int lineNo; // 0x54
	private int linePos; // 0x58

	// Properties
	public string LocalName { get; set; }
	public string Namespace { get; set; }
	public string Prefix { get; set; }
	public int Depth { get; set; }
	public string RawValue { get; set; }
	public string OriginalStringValue { get; }
	public XmlNodeType NodeType { get; set; }
	public AttributePSVIInfo AttInfo { get; set; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x19BBE10 Offset: 0x19BBF11 VA: 0x19BBE10
	public void .ctor() { }

	// RVA: 0x19BBF20 Offset: 0x19BC021 VA: 0x19BBF20
	public void .ctor(XmlNodeType nodeType) { }

	// RVA: 0x19BBF50 Offset: 0x19BC051 VA: 0x19BBF50
	public string get_LocalName() { }

	// RVA: 0x19BBF60 Offset: 0x19BC061 VA: 0x19BBF60
	public void set_LocalName(string value) { }

	// RVA: 0x19BBF70 Offset: 0x19BC071 VA: 0x19BBF70
	public string get_Namespace() { }

	// RVA: 0x19BBF80 Offset: 0x19BC081 VA: 0x19BBF80
	public void set_Namespace(string value) { }

	// RVA: 0x19BBF90 Offset: 0x19BC091 VA: 0x19BBF90
	public string get_Prefix() { }

	// RVA: 0x19BBFA0 Offset: 0x19BC0A1 VA: 0x19BBFA0
	public void set_Prefix(string value) { }

	// RVA: 0x19BBFB0 Offset: 0x19BC0B1 VA: 0x19BBFB0
	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	// RVA: 0x19BC060 Offset: 0x19BC161 VA: 0x19BC060
	public int get_Depth() { }

	// RVA: 0x19BC070 Offset: 0x19BC171 VA: 0x19BC070
	public void set_Depth(int value) { }

	// RVA: 0x19BC080 Offset: 0x19BC181 VA: 0x19BC080
	public string get_RawValue() { }

	// RVA: 0x19BC090 Offset: 0x19BC191 VA: 0x19BC090
	public void set_RawValue(string value) { }

	// RVA: 0x19BC0A0 Offset: 0x19BC1A1 VA: 0x19BC0A0
	public string get_OriginalStringValue() { }

	// RVA: 0x19BC0B0 Offset: 0x19BC1B1 VA: 0x19BC0B0
	public XmlNodeType get_NodeType() { }

	// RVA: 0x19BC0C0 Offset: 0x19BC1C1 VA: 0x19BC0C0
	public void set_NodeType(XmlNodeType value) { }

	// RVA: 0x19BC0D0 Offset: 0x19BC1D1 VA: 0x19BC0D0
	public AttributePSVIInfo get_AttInfo() { }

	// RVA: 0x19BC0E0 Offset: 0x19BC1E1 VA: 0x19BC0E0
	public void set_AttInfo(AttributePSVIInfo value) { }

	// RVA: 0x19BC0F0 Offset: 0x19BC1F1 VA: 0x19BC0F0
	public int get_LineNumber() { }

	// RVA: 0x19BC100 Offset: 0x19BC201 VA: 0x19BC100
	public int get_LinePosition() { }

	// RVA: 0x19BBE40 Offset: 0x19BBF41 VA: 0x19BBE40
	internal void Clear(XmlNodeType nodeType) { }

	// RVA: 0x19BC110 Offset: 0x19BC211 VA: 0x19BC110
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x19BC120 Offset: 0x19BC221 VA: 0x19BC120
	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

	// RVA: 0x19BC230 Offset: 0x19BC331 VA: 0x19BC230
	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	// RVA: 0x19BC2F0 Offset: 0x19BC3F1 VA: 0x19BC2F0
	internal void SetItemData(string value) { }

	// RVA: 0x19BC330 Offset: 0x19BC431 VA: 0x19BC330
	internal void SetItemData(string value, string originalStringValue) { }
}

