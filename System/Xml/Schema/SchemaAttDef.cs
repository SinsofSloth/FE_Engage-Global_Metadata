// Namespace: System.Xml.Schema
internal sealed class SchemaAttDef : SchemaDeclBase, IDtdDefaultAttributeInfo, IDtdAttributeInfo // TypeDefIndex: 1924
{
	// Fields
	private string defExpanded; // 0x60
	private int lineNum; // 0x68
	private int linePos; // 0x6C
	private int valueLineNum; // 0x70
	private int valueLinePos; // 0x74
	private SchemaAttDef.Reserve reserved; // 0x78
	private bool defaultValueChecked; // 0x7C
	private XmlSchemaAttribute schemaAttribute; // 0x80
	public static readonly SchemaAttDef Empty; // 0x0

	// Properties
	private string System.Xml.IDtdAttributeInfo.Prefix { get; }
	private string System.Xml.IDtdAttributeInfo.LocalName { get; }
	private int System.Xml.IDtdAttributeInfo.LineNumber { get; }
	private int System.Xml.IDtdAttributeInfo.LinePosition { get; }
	private bool System.Xml.IDtdAttributeInfo.IsNonCDataType { get; }
	private bool System.Xml.IDtdAttributeInfo.IsDeclaredInExternal { get; }
	private bool System.Xml.IDtdAttributeInfo.IsXmlAttribute { get; }
	private string System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded { get; }
	private object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped { get; }
	private int System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber { get; }
	private int System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition { get; }
	internal int LinePosition { get; set; }
	internal int LineNumber { get; set; }
	internal int ValueLinePosition { get; set; }
	internal int ValueLineNumber { get; set; }
	internal string DefaultValueExpanded { get; set; }
	internal XmlTokenizedType TokenizedType { get; set; }
	internal SchemaAttDef.Reserve Reserved { get; set; }
	internal bool DefaultValueChecked { get; }
	internal XmlSchemaAttribute SchemaAttribute { get; set; }

	// Methods

	// RVA: 0x1A593A0 Offset: 0x1A594A1 VA: 0x1A593A0
	public void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x1A593B0 Offset: 0x1A594B1 VA: 0x1A593B0
	public void .ctor(XmlQualifiedName name) { }

	// RVA: 0x1A593C0 Offset: 0x1A594C1 VA: 0x1A593C0
	private void .ctor() { }

	// RVA: 0x1A593D0 Offset: 0x1A594D1 VA: 0x1A593D0 Slot: 8
	private string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	// RVA: 0x1A593E0 Offset: 0x1A594E1 VA: 0x1A593E0 Slot: 9
	private string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	// RVA: 0x1A593F0 Offset: 0x1A594F1 VA: 0x1A593F0 Slot: 10
	private int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	// RVA: 0x1A59400 Offset: 0x1A59501 VA: 0x1A59400 Slot: 11
	private int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	// RVA: 0x1A59410 Offset: 0x1A59511 VA: 0x1A59410 Slot: 12
	private bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	// RVA: 0x1A59450 Offset: 0x1A59551 VA: 0x1A59450 Slot: 13
	private bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x1A59460 Offset: 0x1A59561 VA: 0x1A59460 Slot: 14
	private bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	// RVA: 0x1A59470 Offset: 0x1A59571 VA: 0x1A59470 Slot: 4
	private string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	// RVA: 0x1A59550 Offset: 0x1A59651 VA: 0x1A59550 Slot: 5
	private object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	// RVA: 0x1A59560 Offset: 0x1A59661 VA: 0x1A59560 Slot: 6
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	// RVA: 0x1A59570 Offset: 0x1A59671 VA: 0x1A59570 Slot: 7
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	// RVA: 0x1A59580 Offset: 0x1A59681 VA: 0x1A59580
	internal int get_LinePosition() { }

	// RVA: 0x1A59590 Offset: 0x1A59691 VA: 0x1A59590
	internal void set_LinePosition(int value) { }

	// RVA: 0x1A595A0 Offset: 0x1A596A1 VA: 0x1A595A0
	internal int get_LineNumber() { }

	// RVA: 0x1A595B0 Offset: 0x1A596B1 VA: 0x1A595B0
	internal void set_LineNumber(int value) { }

	// RVA: 0x1A595C0 Offset: 0x1A596C1 VA: 0x1A595C0
	internal int get_ValueLinePosition() { }

	// RVA: 0x1A595D0 Offset: 0x1A596D1 VA: 0x1A595D0
	internal void set_ValueLinePosition(int value) { }

	// RVA: 0x1A595E0 Offset: 0x1A596E1 VA: 0x1A595E0
	internal int get_ValueLineNumber() { }

	// RVA: 0x1A595F0 Offset: 0x1A596F1 VA: 0x1A595F0
	internal void set_ValueLineNumber(int value) { }

	// RVA: 0x1A594E0 Offset: 0x1A595E1 VA: 0x1A594E0
	internal string get_DefaultValueExpanded() { }

	// RVA: 0x1A59600 Offset: 0x1A59701 VA: 0x1A59600
	internal void set_DefaultValueExpanded(string value) { }

	// RVA: 0x1A59440 Offset: 0x1A59541 VA: 0x1A59440
	internal XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1A59610 Offset: 0x1A59711 VA: 0x1A59610
	internal void set_TokenizedType(XmlTokenizedType value) { }

	// RVA: 0x1A59650 Offset: 0x1A59751 VA: 0x1A59650
	internal SchemaAttDef.Reserve get_Reserved() { }

	// RVA: 0x1A59660 Offset: 0x1A59761 VA: 0x1A59660
	internal void set_Reserved(SchemaAttDef.Reserve value) { }

	// RVA: 0x1A59670 Offset: 0x1A59771 VA: 0x1A59670
	internal bool get_DefaultValueChecked() { }

	// RVA: 0x1A59680 Offset: 0x1A59781 VA: 0x1A59680
	internal XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x1A59690 Offset: 0x1A59791 VA: 0x1A59690
	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x1A596A0 Offset: 0x1A597A1 VA: 0x1A596A0
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	// RVA: 0x1A59910 Offset: 0x1A59A11 VA: 0x1A59910
	internal SchemaAttDef Clone() { }

	// RVA: 0x1A59980 Offset: 0x1A59A81 VA: 0x1A59980
	private static void .cctor() { }
}

