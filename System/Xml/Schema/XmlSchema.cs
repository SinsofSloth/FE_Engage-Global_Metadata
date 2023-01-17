// Namespace: System.Xml.Schema
[XmlRootAttribute] // RVA: 0x471B0 Offset: 0x472B1 VA: 0x471B0
public class XmlSchema : XmlSchemaObject // TypeDefIndex: 1960
{
	// Fields
	private XmlSchemaForm attributeFormDefault; // 0x34
	private XmlSchemaForm elementFormDefault; // 0x38
	private XmlSchemaDerivationMethod blockDefault; // 0x3C
	private XmlSchemaDerivationMethod finalDefault; // 0x40
	private string targetNs; // 0x48
	private string version; // 0x50
	private XmlSchemaObjectCollection includes; // 0x58
	private XmlSchemaObjectCollection items; // 0x60
	private string id; // 0x68
	private XmlAttribute[] moreAttributes; // 0x70
	private bool isCompiled; // 0x78
	private bool isCompiledBySet; // 0x79
	private bool isPreprocessed; // 0x7A
	private bool isRedefined; // 0x7B
	private int errorCount; // 0x7C
	private XmlSchemaObjectTable attributes; // 0x80
	private XmlSchemaObjectTable attributeGroups; // 0x88
	private XmlSchemaObjectTable elements; // 0x90
	private XmlSchemaObjectTable types; // 0x98
	private XmlSchemaObjectTable groups; // 0xA0
	private XmlSchemaObjectTable notations; // 0xA8
	private XmlSchemaObjectTable identityConstraints; // 0xB0
	private static int globalIdCounter; // 0x0
	private ArrayList importedSchemas; // 0xB8
	private ArrayList importedNamespaces; // 0xC0
	private int schemaId; // 0xC8
	private Uri baseUri; // 0xD0
	private bool isChameleon; // 0xD8
	private Hashtable ids; // 0xE0
	private XmlDocument document; // 0xE8

	// Properties
	[XmlAttributeAttribute] // RVA: 0x479D0 Offset: 0x47AD1 VA: 0x479D0
	[DefaultValueAttribute] // RVA: 0x479D0 Offset: 0x47AD1 VA: 0x479D0
	public XmlSchemaForm AttributeFormDefault { get; set; }
	[DefaultValueAttribute] // RVA: 0x47A70 Offset: 0x47B71 VA: 0x47A70
	[XmlAttributeAttribute] // RVA: 0x47A70 Offset: 0x47B71 VA: 0x47A70
	public XmlSchemaDerivationMethod BlockDefault { get; set; }
	[DefaultValueAttribute] // RVA: 0x47B10 Offset: 0x47C11 VA: 0x47B10
	[XmlAttributeAttribute] // RVA: 0x47B10 Offset: 0x47C11 VA: 0x47B10
	public XmlSchemaDerivationMethod FinalDefault { get; set; }
	[DefaultValueAttribute] // RVA: 0x47BB0 Offset: 0x47CB1 VA: 0x47BB0
	[XmlAttributeAttribute] // RVA: 0x47BB0 Offset: 0x47CB1 VA: 0x47BB0
	public XmlSchemaForm ElementFormDefault { get; set; }
	[XmlAttributeAttribute] // RVA: 0x47C50 Offset: 0x47D51 VA: 0x47C50
	public string TargetNamespace { get; set; }
	[XmlAttributeAttribute] // RVA: 0x47CB0 Offset: 0x47DB1 VA: 0x47CB0
	public string Version { get; set; }
	[XmlElementAttribute] // RVA: 0x47D10 Offset: 0x47E11 VA: 0x47D10
	[XmlElementAttribute] // RVA: 0x47D10 Offset: 0x47E11 VA: 0x47D10
	[XmlElementAttribute] // RVA: 0x47D10 Offset: 0x47E11 VA: 0x47D10
	public XmlSchemaObjectCollection Includes { get; }
	[XmlElementAttribute] // RVA: 0x47E30 Offset: 0x47F31 VA: 0x47E30
	[XmlElementAttribute] // RVA: 0x47E30 Offset: 0x47F31 VA: 0x47E30
	[XmlElementAttribute] // RVA: 0x47E30 Offset: 0x47F31 VA: 0x47E30
	[XmlElementAttribute] // RVA: 0x47E30 Offset: 0x47F31 VA: 0x47E30
	[XmlElementAttribute] // RVA: 0x47E30 Offset: 0x47F31 VA: 0x47E30
	[XmlElementAttribute] // RVA: 0x47E30 Offset: 0x47F31 VA: 0x47E30
	[XmlElementAttribute] // RVA: 0x47E30 Offset: 0x47F31 VA: 0x47E30
	[XmlElementAttribute] // RVA: 0x47E30 Offset: 0x47F31 VA: 0x47E30
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnoreAttribute] // RVA: 0x480C0 Offset: 0x481C1 VA: 0x480C0
	internal bool IsCompiledBySet { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x480D0 Offset: 0x481D1 VA: 0x480D0
	internal bool IsPreprocessed { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x480E0 Offset: 0x481E1 VA: 0x480E0
	internal bool IsRedefined { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x480F0 Offset: 0x481F1 VA: 0x480F0
	public XmlSchemaObjectTable Attributes { get; }
	[XmlIgnoreAttribute] // RVA: 0x48100 Offset: 0x48201 VA: 0x48100
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnoreAttribute] // RVA: 0x48110 Offset: 0x48211 VA: 0x48110
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnoreAttribute] // RVA: 0x48120 Offset: 0x48221 VA: 0x48120
	public XmlSchemaObjectTable Elements { get; }
	[XmlAttributeAttribute] // RVA: 0x48130 Offset: 0x48231 VA: 0x48130
	public string Id { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x48190 Offset: 0x48291 VA: 0x48190
	public XmlSchemaObjectTable Groups { get; }
	[XmlIgnoreAttribute] // RVA: 0x481A0 Offset: 0x482A1 VA: 0x481A0
	public XmlSchemaObjectTable Notations { get; }
	[XmlIgnoreAttribute] // RVA: 0x481B0 Offset: 0x482B1 VA: 0x481B0
	internal XmlSchemaObjectTable IdentityConstraints { get; }
	[XmlIgnoreAttribute] // RVA: 0x481C0 Offset: 0x482C1 VA: 0x481C0
	internal Uri BaseUri { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x481D0 Offset: 0x482D1 VA: 0x481D0
	internal int SchemaId { get; }
	[XmlIgnoreAttribute] // RVA: 0x481E0 Offset: 0x482E1 VA: 0x481E0
	internal bool IsChameleon { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x481F0 Offset: 0x482F1 VA: 0x481F0
	internal Hashtable Ids { get; }
	[XmlIgnoreAttribute] // RVA: 0x48200 Offset: 0x48301 VA: 0x48200
	internal XmlDocument Document { get; }
	[XmlIgnoreAttribute] // RVA: 0x48210 Offset: 0x48311 VA: 0x48210
	internal int ErrorCount { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x48220 Offset: 0x48321 VA: 0x48220
	internal override string IdAttribute { get; set; }
	internal ArrayList ImportedSchemas { get; }
	internal ArrayList ImportedNamespaces { get; }

	// Methods

	// RVA: 0x33039A0 Offset: 0x3303AA1 VA: 0x33039A0
	public void .ctor() { }

	// RVA: 0x3303B80 Offset: 0x3303C81 VA: 0x3303B80
	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	// RVA: 0x3303D70 Offset: 0x3303E71 VA: 0x3303D70
	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x3303E20 Offset: 0x3303F21 VA: 0x3303E20
	public XmlSchemaForm get_AttributeFormDefault() { }

	// RVA: 0x3303E30 Offset: 0x3303F31 VA: 0x3303E30
	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	// RVA: 0x3303E40 Offset: 0x3303F41 VA: 0x3303E40
	public XmlSchemaDerivationMethod get_BlockDefault() { }

	// RVA: 0x3303E50 Offset: 0x3303F51 VA: 0x3303E50
	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x3303E60 Offset: 0x3303F61 VA: 0x3303E60
	public XmlSchemaDerivationMethod get_FinalDefault() { }

	// RVA: 0x3303E70 Offset: 0x3303F71 VA: 0x3303E70
	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x3303E80 Offset: 0x3303F81 VA: 0x3303E80
	public XmlSchemaForm get_ElementFormDefault() { }

	// RVA: 0x3303E90 Offset: 0x3303F91 VA: 0x3303E90
	public void set_ElementFormDefault(XmlSchemaForm value) { }

	// RVA: 0x3303EA0 Offset: 0x3303FA1 VA: 0x3303EA0
	public string get_TargetNamespace() { }

	// RVA: 0x3303EB0 Offset: 0x3303FB1 VA: 0x3303EB0
	public void set_TargetNamespace(string value) { }

	// RVA: 0x3303EC0 Offset: 0x3303FC1 VA: 0x3303EC0
	public string get_Version() { }

	// RVA: 0x3303ED0 Offset: 0x3303FD1 VA: 0x3303ED0
	public void set_Version(string value) { }

	// RVA: 0x3303EE0 Offset: 0x3303FE1 VA: 0x3303EE0
	public XmlSchemaObjectCollection get_Includes() { }

	// RVA: 0x3303EF0 Offset: 0x3303FF1 VA: 0x3303EF0
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x3303F00 Offset: 0x3304001 VA: 0x3303F00
	internal bool get_IsCompiledBySet() { }

	// RVA: 0x3303F10 Offset: 0x3304011 VA: 0x3303F10
	internal void set_IsCompiledBySet(bool value) { }

	// RVA: 0x3303F20 Offset: 0x3304021 VA: 0x3303F20
	internal bool get_IsPreprocessed() { }

	// RVA: 0x3303F30 Offset: 0x3304031 VA: 0x3303F30
	internal void set_IsPreprocessed(bool value) { }

	// RVA: 0x3303F40 Offset: 0x3304041 VA: 0x3303F40
	internal bool get_IsRedefined() { }

	// RVA: 0x3303F50 Offset: 0x3304051 VA: 0x3303F50
	internal void set_IsRedefined(bool value) { }

	// RVA: 0x3303F60 Offset: 0x3304061 VA: 0x3303F60
	public XmlSchemaObjectTable get_Attributes() { }

	// RVA: 0x3303FF0 Offset: 0x33040F1 VA: 0x3303FF0
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x3304080 Offset: 0x3304181 VA: 0x3304080
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x3304110 Offset: 0x3304211 VA: 0x3304110
	public XmlSchemaObjectTable get_Elements() { }

	// RVA: 0x33041A0 Offset: 0x33042A1 VA: 0x33041A0
	public string get_Id() { }

	// RVA: 0x33041B0 Offset: 0x33042B1 VA: 0x33041B0
	public void set_Id(string value) { }

	// RVA: 0x33041C0 Offset: 0x33042C1 VA: 0x33041C0
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x33041D0 Offset: 0x33042D1 VA: 0x33041D0
	public XmlSchemaObjectTable get_Notations() { }

	// RVA: 0x33041E0 Offset: 0x33042E1 VA: 0x33041E0
	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	// RVA: 0x33041F0 Offset: 0x33042F1 VA: 0x33041F0
	internal Uri get_BaseUri() { }

	// RVA: 0x3304200 Offset: 0x3304301 VA: 0x3304200
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x3304210 Offset: 0x3304311 VA: 0x3304210
	internal int get_SchemaId() { }

	// RVA: 0x33042B0 Offset: 0x33043B1 VA: 0x33042B0
	internal bool get_IsChameleon() { }

	// RVA: 0x33042C0 Offset: 0x33043C1 VA: 0x33042C0
	internal void set_IsChameleon(bool value) { }

	// RVA: 0x33042D0 Offset: 0x33043D1 VA: 0x33042D0
	internal Hashtable get_Ids() { }

	// RVA: 0x33042E0 Offset: 0x33043E1 VA: 0x33042E0
	internal XmlDocument get_Document() { }

	// RVA: 0x3304370 Offset: 0x3304471 VA: 0x3304370
	internal int get_ErrorCount() { }

	// RVA: 0x3304380 Offset: 0x3304481 VA: 0x3304380
	internal void set_ErrorCount(int value) { }

	// RVA: 0x3304390 Offset: 0x3304491 VA: 0x3304390
	internal XmlSchema Clone() { }

	// RVA: 0x3304490 Offset: 0x3304591 VA: 0x3304490
	internal XmlSchema DeepClone() { }

	// RVA: 0x33047E0 Offset: 0x33048E1 VA: 0x33047E0 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x33047F0 Offset: 0x33048F1 VA: 0x33047F0 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x3304800 Offset: 0x3304901 VA: 0x3304800
	internal void SetIsCompiled(bool isCompiled) { }

	// RVA: 0x3304810 Offset: 0x3304911 VA: 0x3304810 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x3304820 Offset: 0x3304921 VA: 0x3304820 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x3304830 Offset: 0x3304931 VA: 0x3304830
	internal ArrayList get_ImportedSchemas() { }

	// RVA: 0x33048C0 Offset: 0x33049C1 VA: 0x33048C0
	internal ArrayList get_ImportedNamespaces() { }

	// RVA: 0x3304950 Offset: 0x3304A51 VA: 0x3304950
	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	// RVA: 0x3304B20 Offset: 0x3304C21 VA: 0x3304B20
	private static void .cctor() { }
}

