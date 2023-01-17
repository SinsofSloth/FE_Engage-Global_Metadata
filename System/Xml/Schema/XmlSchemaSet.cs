// Namespace: System.Xml.Schema
public class XmlSchemaSet // TypeDefIndex: 2030
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private SortedList schemas; // 0x20
	private ValidationEventHandler internalEventHandler; // 0x28
	private ValidationEventHandler eventHandler; // 0x30
	private bool isCompiled; // 0x38
	private Hashtable schemaLocations; // 0x40
	private Hashtable chameleonSchemas; // 0x48
	private Hashtable targetNamespaces; // 0x50
	private bool compileAll; // 0x58
	private SchemaInfo cachedCompiledInfo; // 0x60
	private XmlReaderSettings readerSettings; // 0x68
	private XmlSchema schemaForSchema; // 0x70
	private XmlSchemaCompilationSettings compilationSettings; // 0x78
	internal XmlSchemaObjectTable elements; // 0x80
	internal XmlSchemaObjectTable attributes; // 0x88
	internal XmlSchemaObjectTable schemaTypes; // 0x90
	internal XmlSchemaObjectTable substitutionGroups; // 0x98
	private XmlSchemaObjectTable typeExtensions; // 0xA0
	private object internalSyncObject; // 0xA8

	// Properties
	internal object InternalSyncObject { get; }
	public bool IsCompiled { get; }
	public XmlResolver XmlResolver { set; }
	public XmlSchemaCompilationSettings CompilationSettings { get; set; }
	public XmlSchemaObjectTable GlobalElements { get; }
	public XmlSchemaObjectTable GlobalAttributes { get; }
	public XmlSchemaObjectTable GlobalTypes { get; }
	internal XmlSchemaObjectTable SubstitutionGroups { get; }
	internal Hashtable SchemaLocations { get; }
	internal XmlSchemaObjectTable TypeExtensions { get; }
	internal SchemaInfo CompiledInfo { get; }
	internal XmlReaderSettings ReaderSettings { get; }
	internal SortedList SortedSchemas { get; }

	// Methods

	// RVA: 0x19690A0 Offset: 0x19691A1 VA: 0x19690A0
	internal object get_InternalSyncObject() { }

	// RVA: 0x1969130 Offset: 0x1969231 VA: 0x1969130
	public void .ctor() { }

	// RVA: 0x19691A0 Offset: 0x19692A1 VA: 0x19691A0
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x19694B0 Offset: 0x19695B1 VA: 0x19694B0
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x19695A0 Offset: 0x19696A1 VA: 0x19695A0
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1969660 Offset: 0x1969761 VA: 0x1969660
	public bool get_IsCompiled() { }

	// RVA: 0x1969670 Offset: 0x1969771 VA: 0x1969670
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1969680 Offset: 0x1969781 VA: 0x1969680
	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x1969690 Offset: 0x1969791 VA: 0x1969690
	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	// RVA: 0x19696A0 Offset: 0x19697A1 VA: 0x19696A0
	public XmlSchemaObjectTable get_GlobalElements() { }

	// RVA: 0x1969730 Offset: 0x1969831 VA: 0x1969730
	public XmlSchemaObjectTable get_GlobalAttributes() { }

	// RVA: 0x19697C0 Offset: 0x19698C1 VA: 0x19697C0
	public XmlSchemaObjectTable get_GlobalTypes() { }

	// RVA: 0x1969850 Offset: 0x1969951 VA: 0x1969850
	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	// RVA: 0x19698E0 Offset: 0x19699E1 VA: 0x19698E0
	internal Hashtable get_SchemaLocations() { }

	// RVA: 0x19698F0 Offset: 0x19699F1 VA: 0x19698F0
	internal XmlSchemaObjectTable get_TypeExtensions() { }

	// RVA: 0x1969980 Offset: 0x1969A81 VA: 0x1969980
	public void Add(XmlSchemaSet schemas) { }

	// RVA: 0x196C350 Offset: 0x196C451 VA: 0x196C350
	public XmlSchema Add(XmlSchema schema) { }

	// RVA: 0x196C580 Offset: 0x196C681 VA: 0x196C580
	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	// RVA: 0x196D570 Offset: 0x196D671 VA: 0x196D570
	public void Compile() { }

	// RVA: 0x196DF20 Offset: 0x196E021 VA: 0x196DF20
	public ICollection Schemas(string targetNamespace) { }

	// RVA: 0x196C2E0 Offset: 0x196C3E1 VA: 0x196C2E0
	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x196E6C0 Offset: 0x196E7C1 VA: 0x196E6C0
	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	// RVA: 0x196C060 Offset: 0x196C161 VA: 0x196C060
	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	// RVA: 0x196E210 Offset: 0x196E311 VA: 0x196E210
	private void AddSchemaToSet(XmlSchema schema) { }

	// RVA: 0x196F030 Offset: 0x196F131 VA: 0x196F030
	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	// RVA: 0x196F510 Offset: 0x196F611 VA: 0x196F510
	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	// RVA: 0x196D190 Offset: 0x196D291 VA: 0x196D190
	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	// RVA: 0x196DB90 Offset: 0x196DC91 VA: 0x196DB90
	private void ClearTables() { }

	// RVA: 0x196E0F0 Offset: 0x196E1F1 VA: 0x196E0F0
	internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace) { }

	// RVA: 0x196EE50 Offset: 0x196EF51 VA: 0x196EE50
	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	// RVA: 0x196A3A0 Offset: 0x196A4A1 VA: 0x196A3A0
	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	// RVA: 0x1971010 Offset: 0x1971111 VA: 0x1971010
	internal SchemaInfo get_CompiledInfo() { }

	// RVA: 0x1971020 Offset: 0x1971121 VA: 0x1971020
	internal XmlReaderSettings get_ReaderSettings() { }

	// RVA: 0x1971030 Offset: 0x1971131 VA: 0x1971030
	internal XmlResolver GetResolver() { }

	// RVA: 0x1971040 Offset: 0x1971141 VA: 0x1971040
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x1970E00 Offset: 0x1970F01 VA: 0x1970E00
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x196EA70 Offset: 0x196EB71 VA: 0x196EA70
	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema) { }

	// RVA: 0x1971050 Offset: 0x1971151 VA: 0x1971050
	internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema) { }

	// RVA: 0x196D070 Offset: 0x196D171 VA: 0x196D070
	internal string GetTargetNamespace(XmlSchema schema) { }

	// RVA: 0x19711C0 Offset: 0x19712C1 VA: 0x19711C0
	internal SortedList get_SortedSchemas() { }

	// RVA: 0x1970860 Offset: 0x1970961 VA: 0x1970860
	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	// RVA: 0x196FD30 Offset: 0x196FE31 VA: 0x196FD30
	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	// RVA: 0x196F910 Offset: 0x196FA11 VA: 0x196F910
	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x1970EC0 Offset: 0x1970FC1 VA: 0x1970EC0
	private void VerifyTables() { }

	// RVA: 0x19711D0 Offset: 0x19712D1 VA: 0x19711D0
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	// RVA: 0x196D0E0 Offset: 0x196D1E1 VA: 0x196D0E0
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }
}

