// Namespace: System.Xml.Schema
internal sealed class XdrBuilder : SchemaBuilder // TypeDefIndex: 1955
{
	// Fields
	private static readonly int[] S_XDR_Root_Element; // 0x0
	private static readonly int[] S_XDR_Root_SubElements; // 0x8
	private static readonly int[] S_XDR_ElementType_SubElements; // 0x10
	private static readonly int[] S_XDR_AttributeType_SubElements; // 0x18
	private static readonly int[] S_XDR_Group_SubElements; // 0x20
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Root_Attributes; // 0x28
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementType_Attributes; // 0x30
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeType_Attributes; // 0x38
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Element_Attributes; // 0x40
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Attribute_Attributes; // 0x48
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Group_Attributes; // 0x50
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementDataType_Attributes; // 0x58
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes; // 0x60
	private static readonly XdrBuilder.XdrEntry[] S_SchemaEntries; // 0x68
	private SchemaInfo _SchemaInfo; // 0x10
	private string _TargetNamespace; // 0x18
	private XmlReader _reader; // 0x20
	private PositionInfo positionInfo; // 0x28
	private ParticleContentValidator _contentValidator; // 0x30
	private XdrBuilder.XdrEntry _CurState; // 0x38
	private XdrBuilder.XdrEntry _NextState; // 0x40
	private HWStack _StateHistory; // 0x48
	private HWStack _GroupStack; // 0x50
	private string _XdrName; // 0x58
	private string _XdrPrefix; // 0x60
	private XdrBuilder.ElementContent _ElementDef; // 0x68
	private XdrBuilder.GroupContent _GroupDef; // 0x70
	private XdrBuilder.AttributeContent _AttributeDef; // 0x78
	private XdrBuilder.DeclBaseInfo _UndefinedAttributeTypes; // 0x80
	private XdrBuilder.DeclBaseInfo _BaseDecl; // 0x88
	private XmlNameTable _NameTable; // 0x90
	private SchemaNames _SchemaNames; // 0x98
	private XmlNamespaceManager _CurNsMgr; // 0xA0
	private string _Text; // 0xA8
	private ValidationEventHandler validationEventHandler; // 0xB0
	private Hashtable _UndeclaredElements; // 0xB8
	private XmlResolver xmlResolver; // 0xC0

	// Properties
	internal XmlResolver XmlResolver { set; }

	// Methods

	// RVA: 0x19C4BE0 Offset: 0x19C4CE1 VA: 0x19C4BE0
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x19C4EA0 Offset: 0x19C4FA1 VA: 0x19C4EA0 Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x19C5370 Offset: 0x19C5471 VA: 0x19C5370 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x19C5E10 Offset: 0x19C5F11 VA: 0x19C5E10
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x19C5820 Offset: 0x19C5921 VA: 0x19C5820
	private bool LoadSchema(string uri) { }

	// RVA: 0x19C5760 Offset: 0x19C5861 VA: 0x19C5760
	internal static bool IsXdrSchema(string uri) { }

	// RVA: 0x19C5F00 Offset: 0x19C6001 VA: 0x19C5F00 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0x19C5F10 Offset: 0x19C6011 VA: 0x19C5F10 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x19C5F70 Offset: 0x19C6071 VA: 0x19C5F70 Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0x19C6000 Offset: 0x19C6101 VA: 0x19C6000 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0x19C6020 Offset: 0x19C6121 VA: 0x19C6020 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0x19C5190 Offset: 0x19C5291 VA: 0x19C5190
	private void Push() { }

	// RVA: 0x19C60C0 Offset: 0x19C61C1 VA: 0x19C60C0
	private void Pop() { }

	// RVA: 0x19C6140 Offset: 0x19C6241 VA: 0x19C6140
	private void PushGroupInfo() { }

	// RVA: 0x19C61A0 Offset: 0x19C62A1 VA: 0x19C61A0
	private void PopGroupInfo() { }

	// RVA: 0x19C6220 Offset: 0x19C6321 VA: 0x19C6220
	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

	// RVA: 0x19C6280 Offset: 0x19C6381 VA: 0x19C6280
	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C6310 Offset: 0x19C6411 VA: 0x19C6310
	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C6320 Offset: 0x19C6421 VA: 0x19C6320
	private static void XDR_BeginRoot(XdrBuilder builder) { }

	// RVA: 0x19C6400 Offset: 0x19C6501 VA: 0x19C6400
	private static void XDR_EndRoot(XdrBuilder builder) { }

	// RVA: 0x19C6980 Offset: 0x19C6A81 VA: 0x19C6980
	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	// RVA: 0x19C6AD0 Offset: 0x19C6BD1 VA: 0x19C6AD0
	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C6C80 Offset: 0x19C6D81 VA: 0x19C6C80
	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C6EB0 Offset: 0x19C6FB1 VA: 0x19C6EB0
	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C7030 Offset: 0x19C7131 VA: 0x19C7030
	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C7200 Offset: 0x19C7301 VA: 0x19C7200
	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C73A0 Offset: 0x19C74A1 VA: 0x19C73A0
	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C7480 Offset: 0x19C7581 VA: 0x19C7480
	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C7680 Offset: 0x19C7781 VA: 0x19C7680
	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C7880 Offset: 0x19C7981 VA: 0x19C7880
	private static void XDR_BeginElementType(XdrBuilder builder) { }

	// RVA: 0x19C7B80 Offset: 0x19C7C81 VA: 0x19C7B80
	private static void XDR_EndElementType(XdrBuilder builder) { }

	// RVA: 0x19C80D0 Offset: 0x19C81D1 VA: 0x19C80D0
	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	// RVA: 0x19C81D0 Offset: 0x19C82D1 VA: 0x19C81D0
	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C83F0 Offset: 0x19C84F1 VA: 0x19C83F0
	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C85C0 Offset: 0x19C86C1 VA: 0x19C85C0
	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C85D0 Offset: 0x19C86D1 VA: 0x19C85D0
	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C8800 Offset: 0x19C8901 VA: 0x19C8800
	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C88E0 Offset: 0x19C89E1 VA: 0x19C88E0
	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C8960 Offset: 0x19C8A61 VA: 0x19C8960
	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C89E0 Offset: 0x19C8AE1 VA: 0x19C89E0
	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	// RVA: 0x19C8A90 Offset: 0x19C8B91 VA: 0x19C8A90
	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	// RVA: 0x19C8EE0 Offset: 0x19C8FE1 VA: 0x19C8EE0
	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	// RVA: 0x19C8FB0 Offset: 0x19C90B1 VA: 0x19C8FB0
	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C91D0 Offset: 0x19C92D1 VA: 0x19C91D0
	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C9390 Offset: 0x19C9491 VA: 0x19C9390
	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C9580 Offset: 0x19C9681 VA: 0x19C9580
	private static void XDR_EndElement(XdrBuilder builder) { }

	// RVA: 0x19C96F0 Offset: 0x19C97F1 VA: 0x19C96F0
	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	// RVA: 0x19C9780 Offset: 0x19C9881 VA: 0x19C9780
	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C9830 Offset: 0x19C9931 VA: 0x19C9830
	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C98D0 Offset: 0x19C99D1 VA: 0x19C98D0
	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C98E0 Offset: 0x19C99E1 VA: 0x19C98E0
	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	// RVA: 0x19C9BE0 Offset: 0x19C9CE1 VA: 0x19C9BE0
	private static void XDR_EndAttribute(XdrBuilder builder) { }

	// RVA: 0x19C9BF0 Offset: 0x19C9CF1 VA: 0x19C9BF0
	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	// RVA: 0x19C9D10 Offset: 0x19C9E11 VA: 0x19C9D10
	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C9E30 Offset: 0x19C9F31 VA: 0x19C9E30
	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C9EC0 Offset: 0x19C9FC1 VA: 0x19C9EC0
	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x19C9F50 Offset: 0x19CA051 VA: 0x19C9F50
	private static void XDR_EndGroup(XdrBuilder builder) { }

	// RVA: 0x19CA190 Offset: 0x19CA291 VA: 0x19CA190
	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x19CA2A0 Offset: 0x19CA3A1 VA: 0x19CA2A0
	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	// RVA: 0x19CA3D0 Offset: 0x19CA4D1 VA: 0x19CA3D0
	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x19CA480 Offset: 0x19CA581 VA: 0x19CA480
	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	// RVA: 0x19C5000 Offset: 0x19C5101 VA: 0x19C5000
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x19C51E0 Offset: 0x19C52E1 VA: 0x19C51E0
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x19C5CF0 Offset: 0x19C5DF1 VA: 0x19C5CF0
	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	// RVA: 0x19C70D0 Offset: 0x19C71D1 VA: 0x19C70D0
	private int GetOrder(XmlQualifiedName qname) { }

	// RVA: 0x19C9120 Offset: 0x19C9221 VA: 0x19C9120
	private void AddOrder() { }

	// RVA: 0x19C8470 Offset: 0x19C8571 VA: 0x19C8470
	private static bool IsYes(object obj, XdrBuilder builder) { }

	// RVA: 0x19C9250 Offset: 0x19C9351 VA: 0x19C9250
	private static uint ParseMinOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x19C9410 Offset: 0x19C9511 VA: 0x19C9410
	private static uint ParseMaxOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x19C96C0 Offset: 0x19C97C1 VA: 0x19C96C0
	private static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax) { }

	// RVA: 0x19C7500 Offset: 0x19C7601 VA: 0x19C7500
	private static void ParseDtMaxLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x19C7700 Offset: 0x19C7801 VA: 0x19C7700
	private static void ParseDtMinLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x19C8010 Offset: 0x19C8111 VA: 0x19C8010
	private static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder) { }

	// RVA: 0x19CA5A0 Offset: 0x19CA6A1 VA: 0x19CA5A0
	private static bool ParseInteger(string str, ref uint n) { }

	// RVA: 0x19C68A0 Offset: 0x19C69A1 VA: 0x19C68A0
	private void XDR_CheckAttributeDefault(XdrBuilder.DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	// RVA: 0x19C8EA0 Offset: 0x19C8FA1 VA: 0x19C8EA0
	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	// RVA: 0x19C6D20 Offset: 0x19C6E21 VA: 0x19C6D20
	private int GetContent(XmlQualifiedName qname) { }

	// RVA: 0x19C6F50 Offset: 0x19C7051 VA: 0x19C6F50
	private bool GetModel(XmlQualifiedName qname) { }

	// RVA: 0x19C8690 Offset: 0x19C8791 VA: 0x19C8690
	private XmlSchemaDatatype CheckDatatype(string str) { }

	// RVA: 0x19C8D90 Offset: 0x19C8E91 VA: 0x19C8D90
	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	// RVA: 0x19C5750 Offset: 0x19C5851 VA: 0x19C5750
	private bool IsGlobal(int flags) { }

	// RVA: 0x19C5E20 Offset: 0x19C5F21 VA: 0x19C5E20
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x19C7330 Offset: 0x19C7431 VA: 0x19C7330
	private void SendValidationEvent(string code) { }

	// RVA: 0x19C5290 Offset: 0x19C5391 VA: 0x19C5290
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x19CA5E0 Offset: 0x19CA6E1 VA: 0x19CA5E0
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x19CA710 Offset: 0x19CA811 VA: 0x19CA710
	private static void .cctor() { }
}

