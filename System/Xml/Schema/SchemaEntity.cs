// Namespace: System.Xml.Schema
internal sealed class SchemaEntity : IDtdEntityInfo // TypeDefIndex: 1932
{
	// Fields
	private XmlQualifiedName qname; // 0x10
	private string url; // 0x18
	private string pubid; // 0x20
	private string text; // 0x28
	private XmlQualifiedName ndata; // 0x30
	private int lineNumber; // 0x38
	private int linePosition; // 0x3C
	private bool isParameter; // 0x40
	private bool isExternal; // 0x41
	private bool parsingInProgress; // 0x42
	private bool isDeclaredInExternal; // 0x43
	private string baseURI; // 0x48
	private string declaredURI; // 0x50

	// Properties
	private string System.Xml.IDtdEntityInfo.Name { get; }
	private bool System.Xml.IDtdEntityInfo.IsExternal { get; }
	private bool System.Xml.IDtdEntityInfo.IsDeclaredInExternal { get; }
	private bool System.Xml.IDtdEntityInfo.IsUnparsedEntity { get; }
	private bool System.Xml.IDtdEntityInfo.IsParameterEntity { get; }
	private string System.Xml.IDtdEntityInfo.BaseUriString { get; }
	private string System.Xml.IDtdEntityInfo.DeclaredUriString { get; }
	private string System.Xml.IDtdEntityInfo.SystemId { get; }
	private string System.Xml.IDtdEntityInfo.PublicId { get; }
	private string System.Xml.IDtdEntityInfo.Text { get; }
	private int System.Xml.IDtdEntityInfo.LineNumber { get; }
	private int System.Xml.IDtdEntityInfo.LinePosition { get; }
	internal XmlQualifiedName Name { get; }
	internal string Url { get; set; }
	internal string Pubid { get; set; }
	internal bool IsExternal { get; set; }
	internal bool DeclaredInExternal { get; set; }
	internal XmlQualifiedName NData { get; set; }
	internal string Text { get; set; }
	internal int Line { get; set; }
	internal int Pos { get; set; }
	internal string BaseURI { get; set; }
	internal bool ParsingInProgress { get; set; }
	internal string DeclaredURI { get; set; }

	// Methods

	// RVA: 0x19AE7C0 Offset: 0x19AE8C1 VA: 0x19AE7C0
	internal void .ctor(XmlQualifiedName qname, bool isParameter) { }

	// RVA: 0x19AE870 Offset: 0x19AE971 VA: 0x19AE870 Slot: 4
	private string System.Xml.IDtdEntityInfo.get_Name() { }

	// RVA: 0x19AE880 Offset: 0x19AE981 VA: 0x19AE880 Slot: 5
	private bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	// RVA: 0x19AE890 Offset: 0x19AE991 VA: 0x19AE890 Slot: 6
	private bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x19AE8A0 Offset: 0x19AE9A1 VA: 0x19AE8A0 Slot: 7
	private bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	// RVA: 0x19AE8D0 Offset: 0x19AE9D1 VA: 0x19AE8D0 Slot: 8
	private bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	// RVA: 0x19AE8E0 Offset: 0x19AE9E1 VA: 0x19AE8E0 Slot: 9
	private string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	// RVA: 0x19AE9C0 Offset: 0x19AEAC1 VA: 0x19AE9C0 Slot: 10
	private string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	// RVA: 0x19AEAA0 Offset: 0x19AEBA1 VA: 0x19AEAA0 Slot: 11
	private string System.Xml.IDtdEntityInfo.get_SystemId() { }

	// RVA: 0x19AEAB0 Offset: 0x19AEBB1 VA: 0x19AEAB0 Slot: 12
	private string System.Xml.IDtdEntityInfo.get_PublicId() { }

	// RVA: 0x19AEAC0 Offset: 0x19AEBC1 VA: 0x19AEAC0 Slot: 13
	private string System.Xml.IDtdEntityInfo.get_Text() { }

	// RVA: 0x19AEAD0 Offset: 0x19AEBD1 VA: 0x19AEAD0 Slot: 14
	private int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	// RVA: 0x19AEAE0 Offset: 0x19AEBE1 VA: 0x19AEAE0 Slot: 15
	private int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	// RVA: 0x19AEAF0 Offset: 0x19AEBF1 VA: 0x19AEAF0
	internal static bool IsPredefinedEntity(string n) { }

	// RVA: 0x19AEC00 Offset: 0x19AED01 VA: 0x19AEC00
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x19AEC10 Offset: 0x19AED11 VA: 0x19AEC10
	internal string get_Url() { }

	// RVA: 0x19AEC20 Offset: 0x19AED21 VA: 0x19AEC20
	internal void set_Url(string value) { }

	// RVA: 0x19AEC50 Offset: 0x19AED51 VA: 0x19AEC50
	internal string get_Pubid() { }

	// RVA: 0x19AEC60 Offset: 0x19AED61 VA: 0x19AEC60
	internal void set_Pubid(string value) { }

	// RVA: 0x19AEC70 Offset: 0x19AED71 VA: 0x19AEC70
	internal bool get_IsExternal() { }

	// RVA: 0x19AEC80 Offset: 0x19AED81 VA: 0x19AEC80
	internal void set_IsExternal(bool value) { }

	// RVA: 0x19AEC90 Offset: 0x19AED91 VA: 0x19AEC90
	internal bool get_DeclaredInExternal() { }

	// RVA: 0x19AECA0 Offset: 0x19AEDA1 VA: 0x19AECA0
	internal void set_DeclaredInExternal(bool value) { }

	// RVA: 0x19AECB0 Offset: 0x19AEDB1 VA: 0x19AECB0
	internal XmlQualifiedName get_NData() { }

	// RVA: 0x19AECC0 Offset: 0x19AEDC1 VA: 0x19AECC0
	internal void set_NData(XmlQualifiedName value) { }

	// RVA: 0x19AECD0 Offset: 0x19AEDD1 VA: 0x19AECD0
	internal string get_Text() { }

	// RVA: 0x19AECE0 Offset: 0x19AEDE1 VA: 0x19AECE0
	internal void set_Text(string value) { }

	// RVA: 0x19AED10 Offset: 0x19AEE11 VA: 0x19AED10
	internal int get_Line() { }

	// RVA: 0x19AED20 Offset: 0x19AEE21 VA: 0x19AED20
	internal void set_Line(int value) { }

	// RVA: 0x19AED30 Offset: 0x19AEE31 VA: 0x19AED30
	internal int get_Pos() { }

	// RVA: 0x19AED40 Offset: 0x19AEE41 VA: 0x19AED40
	internal void set_Pos(int value) { }

	// RVA: 0x19AE950 Offset: 0x19AEA51 VA: 0x19AE950
	internal string get_BaseURI() { }

	// RVA: 0x19AED50 Offset: 0x19AEE51 VA: 0x19AED50
	internal void set_BaseURI(string value) { }

	// RVA: 0x19AED60 Offset: 0x19AEE61 VA: 0x19AED60
	internal bool get_ParsingInProgress() { }

	// RVA: 0x19AED70 Offset: 0x19AEE71 VA: 0x19AED70
	internal void set_ParsingInProgress(bool value) { }

	// RVA: 0x19AEA30 Offset: 0x19AEB31 VA: 0x19AEA30
	internal string get_DeclaredURI() { }

	// RVA: 0x19AED80 Offset: 0x19AEE81 VA: 0x19AED80
	internal void set_DeclaredURI(string value) { }
}

