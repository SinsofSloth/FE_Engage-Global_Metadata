// Namespace: System.Xml
[DebuggerDisplayAttribute] // RVA: 0x46C80 Offset: 0x46D81 VA: 0x46C80
[DefaultMemberAttribute] // RVA: 0x46C80 Offset: 0x46D81 VA: 0x46C80
[DebuggerDisplayAttribute] // RVA: 0x46C80 Offset: 0x46D81 VA: 0x46C80
public abstract class XmlReader : IDisposable // TypeDefIndex: 1657
{
	// Fields
	private static uint IsTextualNodeBitmap; // 0x0
	private static uint CanReadContentAsBitmap; // 0x4
	private static uint HasValueBitmap; // 0x8

	// Properties
	public virtual XmlReaderSettings Settings { get; }
	public abstract XmlNodeType NodeType { get; }
	public virtual string Name { get; }
	public abstract string LocalName { get; }
	public abstract string NamespaceURI { get; }
	public abstract string Prefix { get; }
	public abstract string Value { get; }
	public abstract int Depth { get; }
	public abstract string BaseURI { get; }
	public abstract bool IsEmptyElement { get; }
	public virtual bool IsDefault { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public abstract int AttributeCount { get; }
	public abstract bool EOF { get; }
	public abstract ReadState ReadState { get; }
	public abstract XmlNameTable NameTable { get; }
	public virtual bool CanResolveEntity { get; }
	internal virtual XmlNamespaceManager NamespaceManager { get; }
	internal virtual IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x3301860 Offset: 0x3301961 VA: 0x3301860 Slot: 5
	public virtual XmlReaderSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x3301870 Offset: 0x3301971 VA: 0x3301870 Slot: 7
	public virtual string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_NamespaceURI();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_Prefix();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int get_Depth();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract string get_BaseURI();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_IsEmptyElement();

	// RVA: 0x3301950 Offset: 0x3301A51 VA: 0x3301950 Slot: 15
	public virtual bool get_IsDefault() { }

	// RVA: 0x3301960 Offset: 0x3301A61 VA: 0x3301960 Slot: 16
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int get_AttributeCount();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract string GetAttribute(string name);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract string GetAttribute(int i);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool MoveToAttribute(string name);

	// RVA: 0x33019C0 Offset: 0x3301AC1 VA: 0x33019C0 Slot: 21
	public virtual void MoveToAttribute(int i) { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract bool MoveToFirstAttribute();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract bool MoveToNextAttribute();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract bool MoveToElement();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract bool ReadAttributeValue();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract bool Read();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool get_EOF();

	// RVA: 0x3301A90 Offset: 0x3301B91 VA: 0x3301A90 Slot: 28
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract ReadState get_ReadState();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract XmlNameTable get_NameTable();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract string LookupNamespace(string prefix);

	// RVA: 0x3301AA0 Offset: 0x3301BA1 VA: 0x3301AA0 Slot: 32
	public virtual bool get_CanResolveEntity() { }

	// RVA: -1 Offset: -1 Slot: 33
	public abstract void ResolveEntity();

	// RVA: 0x3301AB0 Offset: 0x3301BB1 VA: 0x3301AB0 Slot: 4
	public void Dispose() { }

	// RVA: 0x3301AD0 Offset: 0x3301BD1 VA: 0x3301AD0 Slot: 34
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x3301B30 Offset: 0x3301C31 VA: 0x3301B30 Slot: 35
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x3301B40 Offset: 0x3301C41 VA: 0x3301B40 Slot: 36
	internal virtual IDtdInfo get_DtdInfo() { }

	// RVA: 0x3301B50 Offset: 0x3301C51 VA: 0x3301B50
	public static XmlReader Create(Stream input) { }

	// RVA: 0x3301C30 Offset: 0x3301D31 VA: 0x3301C30
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x3301EB0 Offset: 0x3301FB1 VA: 0x3301EB0
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x3302080 Offset: 0x3302181 VA: 0x3302080
	internal static int CalcBufferSize(Stream input) { }

	// RVA: 0x3302110 Offset: 0x3302211 VA: 0x3302110
	protected void .ctor() { }

	// RVA: 0x3302120 Offset: 0x3302221 VA: 0x3302120
	private static void .cctor() { }
}

