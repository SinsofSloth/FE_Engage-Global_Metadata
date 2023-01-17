// Namespace: System.Xml
[DefaultMemberAttribute] // RVA: 0x46C40 Offset: 0x46D41 VA: 0x46C40
internal class XmlAsyncCheckReader : XmlReader // TypeDefIndex: 1651
{
	// Fields
	private readonly XmlReader coreReader; // 0x10
	private Task lastTask; // 0x18

	// Properties
	internal XmlReader CoreReader { get; }
	public override XmlReaderSettings Settings { get; }
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
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x1A93490 Offset: 0x1A93591 VA: 0x1A93490
	internal XmlReader get_CoreReader() { }

	// RVA: 0x1A934A0 Offset: 0x1A935A1 VA: 0x1A934A0
	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	// RVA: 0x1A939C0 Offset: 0x1A93AC1 VA: 0x1A939C0
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1A93A90 Offset: 0x1A93B91 VA: 0x1A93A90
	private void CheckAsync() { }

	// RVA: 0x1A93B10 Offset: 0x1A93C11 VA: 0x1A93B10 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1A93BB0 Offset: 0x1A93CB1 VA: 0x1A93BB0 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1A93BE0 Offset: 0x1A93CE1 VA: 0x1A93BE0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1A93C10 Offset: 0x1A93D11 VA: 0x1A93C10 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1A93C40 Offset: 0x1A93D41 VA: 0x1A93C40 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1A93C70 Offset: 0x1A93D71 VA: 0x1A93C70 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1A93CA0 Offset: 0x1A93DA1 VA: 0x1A93CA0 Slot: 11
	public override string get_Value() { }

	// RVA: 0x1A93CD0 Offset: 0x1A93DD1 VA: 0x1A93CD0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x1A93D00 Offset: 0x1A93E01 VA: 0x1A93D00 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x1A93D30 Offset: 0x1A93E31 VA: 0x1A93D30 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1A93D60 Offset: 0x1A93E61 VA: 0x1A93D60 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x1A93D90 Offset: 0x1A93E91 VA: 0x1A93D90 Slot: 16
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1A93DC0 Offset: 0x1A93EC1 VA: 0x1A93DC0 Slot: 17
	public override int get_AttributeCount() { }

	// RVA: 0x1A93DF0 Offset: 0x1A93EF1 VA: 0x1A93DF0 Slot: 18
	public override string GetAttribute(string name) { }

	// RVA: 0x1A93E30 Offset: 0x1A93F31 VA: 0x1A93E30 Slot: 19
	public override string GetAttribute(int i) { }

	// RVA: 0x1A93E70 Offset: 0x1A93F71 VA: 0x1A93E70 Slot: 20
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1A93EB0 Offset: 0x1A93FB1 VA: 0x1A93EB0 Slot: 21
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1A93EF0 Offset: 0x1A93FF1 VA: 0x1A93EF0 Slot: 22
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1A93F20 Offset: 0x1A94021 VA: 0x1A93F20 Slot: 23
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1A93F50 Offset: 0x1A94051 VA: 0x1A93F50 Slot: 24
	public override bool MoveToElement() { }

	// RVA: 0x1A93F80 Offset: 0x1A94081 VA: 0x1A93F80 Slot: 25
	public override bool ReadAttributeValue() { }

	// RVA: 0x1A93FB0 Offset: 0x1A940B1 VA: 0x1A93FB0 Slot: 26
	public override bool Read() { }

	// RVA: 0x1A93FE0 Offset: 0x1A940E1 VA: 0x1A93FE0 Slot: 27
	public override bool get_EOF() { }

	// RVA: 0x1A94010 Offset: 0x1A94111 VA: 0x1A94010 Slot: 28
	public override void Close() { }

	// RVA: 0x1A94040 Offset: 0x1A94141 VA: 0x1A94040 Slot: 29
	public override ReadState get_ReadState() { }

	// RVA: 0x1A94070 Offset: 0x1A94171 VA: 0x1A94070 Slot: 30
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1A940A0 Offset: 0x1A941A1 VA: 0x1A940A0 Slot: 31
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1A940E0 Offset: 0x1A941E1 VA: 0x1A940E0 Slot: 32
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1A94110 Offset: 0x1A94211 VA: 0x1A94110 Slot: 33
	public override void ResolveEntity() { }

	// RVA: 0x1A94140 Offset: 0x1A94241 VA: 0x1A94140 Slot: 34
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1A94170 Offset: 0x1A94271 VA: 0x1A94170 Slot: 35
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1A941A0 Offset: 0x1A942A1 VA: 0x1A941A0 Slot: 36
	internal override IDtdInfo get_DtdInfo() { }
}

