// Namespace: System.Xml.Schema
[DefaultMemberAttribute] // RVA: 0x472C0 Offset: 0x473C1 VA: 0x472C0
public class XmlSchemaObjectTable // TypeDefIndex: 2024
{
	// Fields
	private Dictionary<XmlQualifiedName, XmlSchemaObject> table; // 0x10
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x18

	// Properties
	public int Count { get; }
	public XmlSchemaObject Item { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x195F2A0 Offset: 0x195F3A1 VA: 0x195F2A0
	internal void .ctor() { }

	// RVA: 0x1967CF0 Offset: 0x1967DF1 VA: 0x1967CF0
	internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x1967DB0 Offset: 0x1967EB1 VA: 0x1967DB0
	internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x1968080 Offset: 0x1968181 VA: 0x1968080
	internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x1968210 Offset: 0x1968311 VA: 0x1968210
	internal void Clear() { }

	// RVA: 0x1968290 Offset: 0x1968391 VA: 0x1968290
	internal void Remove(XmlQualifiedName name) { }

	// RVA: 0x1967FC0 Offset: 0x19680C1 VA: 0x1967FC0
	private int FindIndexByValue(XmlSchemaObject xso) { }

	// RVA: 0x19683F0 Offset: 0x19684F1 VA: 0x19683F0
	public int get_Count() { }

	// RVA: 0x1968450 Offset: 0x1968551 VA: 0x1968450
	public bool Contains(XmlQualifiedName name) { }

	// RVA: 0x19684B0 Offset: 0x19685B1 VA: 0x19684B0
	public XmlSchemaObject get_Item(XmlQualifiedName name) { }

	// RVA: 0x19626F0 Offset: 0x19627F1 VA: 0x19626F0
	public ICollection get_Values() { }

	// RVA: 0x1968530 Offset: 0x1968631 VA: 0x1968530
	public IDictionaryEnumerator GetEnumerator() { }
}

