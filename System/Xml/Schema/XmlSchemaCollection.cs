// Namespace: System.Xml.Schema
[DefaultMemberAttribute] // RVA: 0x47210 Offset: 0x47311 VA: 0x47210
[ObsoleteAttribute] // RVA: 0x47210 Offset: 0x47311 VA: 0x47210
public sealed class XmlSchemaCollection : ICollection, IEnumerable // TypeDefIndex: 1971
{
	// Fields
	private Hashtable collection; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ReaderWriterLock wLock; // 0x28
	private int timeout; // 0x30
	private bool isThreadSafe; // 0x34
	private ValidationEventHandler validationEventHandler; // 0x38
	private XmlResolver xmlResolver; // 0x40

	// Properties
	public int Count { get; }
	public XmlNameTable NameTable { get; }
	internal XmlResolver XmlResolver { set; }
	public XmlSchema Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	internal ValidationEventHandler EventHandler { get; set; }

	// Methods

	// RVA: 0x195FC70 Offset: 0x195FD71 VA: 0x195FC70
	public void .ctor(XmlNameTable nametable) { }

	// RVA: 0x195FDC0 Offset: 0x195FEC1 VA: 0x195FDC0
	public int get_Count() { }

	// RVA: 0x195FDE0 Offset: 0x195FEE1 VA: 0x195FDE0
	public XmlNameTable get_NameTable() { }

	// RVA: 0x195FDF0 Offset: 0x195FEF1 VA: 0x195FDF0
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x195FE00 Offset: 0x195FF01 VA: 0x195FE00
	public XmlSchema get_Item(string ns) { }

	// RVA: 0x195FEB0 Offset: 0x195FFB1 VA: 0x195FEB0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x195FF90 Offset: 0x1960091 VA: 0x195FF90
	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	// RVA: 0x1960020 Offset: 0x1960121 VA: 0x1960020 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x19603E0 Offset: 0x19604E1 VA: 0x19603E0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x19603F0 Offset: 0x19604F1 VA: 0x19603F0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1960400 Offset: 0x1960501 VA: 0x1960400 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1960420 Offset: 0x1960521 VA: 0x1960420
	internal SchemaInfo GetSchemaInfo(string ns) { }

	// RVA: 0x19604D0 Offset: 0x19605D1 VA: 0x19604D0
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x1960590 Offset: 0x1960691 VA: 0x1960590
	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	// RVA: 0x19605A0 Offset: 0x19606A1 VA: 0x19605A0
	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	// RVA: 0x1960720 Offset: 0x1960821 VA: 0x1960720
	private void Add(string ns, XmlSchemaCollectionNode node) { }

	// RVA: 0x1960840 Offset: 0x1960941 VA: 0x1960840
	internal ValidationEventHandler get_EventHandler() { }

	// RVA: 0x1960850 Offset: 0x1960951 VA: 0x1960850
	internal void set_EventHandler(ValidationEventHandler value) { }
}

