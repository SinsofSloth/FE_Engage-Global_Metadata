// Namespace: System.Xml
public class XmlParserContext // TypeDefIndex: 1656
{
	// Fields
	private XmlNameTable _nt; // 0x10
	private XmlNamespaceManager _nsMgr; // 0x18
	private string _docTypeName; // 0x20
	private string _pubId; // 0x28
	private string _sysId; // 0x30
	private string _internalSubset; // 0x38
	private string _xmlLang; // 0x40
	private XmlSpace _xmlSpace; // 0x48
	private string _baseURI; // 0x50
	private Encoding _encoding; // 0x58

	// Properties
	public XmlNameTable NameTable { get; }
	public XmlNamespaceManager NamespaceManager { get; }
	public string DocTypeName { get; }
	public string PublicId { get; }
	public string SystemId { get; }
	public string BaseURI { get; }
	public string InternalSubset { get; }
	public string XmlLang { get; }
	public XmlSpace XmlSpace { get; }
	public Encoding Encoding { get; }
	internal bool HasDtdInfo { get; }

	// Methods

	// RVA: 0x32F3110 Offset: 0x32F3211 VA: 0x32F3110
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x3300350 Offset: 0x3300451 VA: 0x3300350
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	// RVA: 0x3300630 Offset: 0x3300731 VA: 0x3300630
	public XmlNameTable get_NameTable() { }

	// RVA: 0x3300640 Offset: 0x3300741 VA: 0x3300640
	public XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x3300650 Offset: 0x3300751 VA: 0x3300650
	public string get_DocTypeName() { }

	// RVA: 0x3300660 Offset: 0x3300761 VA: 0x3300660
	public string get_PublicId() { }

	// RVA: 0x3300670 Offset: 0x3300771 VA: 0x3300670
	public string get_SystemId() { }

	// RVA: 0x3300680 Offset: 0x3300781 VA: 0x3300680
	public string get_BaseURI() { }

	// RVA: 0x3300690 Offset: 0x3300791 VA: 0x3300690
	public string get_InternalSubset() { }

	// RVA: 0x33006A0 Offset: 0x33007A1 VA: 0x33006A0
	public string get_XmlLang() { }

	// RVA: 0x33006B0 Offset: 0x33007B1 VA: 0x33006B0
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x33006C0 Offset: 0x33007C1 VA: 0x33006C0
	public Encoding get_Encoding() { }

	// RVA: 0x33006D0 Offset: 0x33007D1 VA: 0x33006D0
	internal bool get_HasDtdInfo() { }
}

