// Namespace: 
internal struct XmlSchemaObjectTable.XmlSchemaObjectEntry // TypeDefIndex: 2020
{
	// Fields
	internal XmlQualifiedName qname; // 0x0
	internal XmlSchemaObject xso; // 0x8

	// Methods

	// RVA: 0x19A9040 Offset: 0x19A9141 VA: 0x19A9040
	public void .ctor(XmlQualifiedName name, XmlSchemaObject value) { }
}

// Namespace: 
internal class XmlSchemaObjectTable.XSOEnumerator : IEnumerator // TypeDefIndex: 2022
{
	// Fields
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private XmlSchemaObjectTable.EnumeratorType enumType; // 0x18
	protected int currentIndex; // 0x1C
	protected int size; // 0x20
	protected XmlQualifiedName currentKey; // 0x28
	protected XmlSchemaObject currentValue; // 0x30

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x19A88D0 Offset: 0x19A89D1 VA: 0x19A88D0
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

	// RVA: 0x19A8D30 Offset: 0x19A8E31 VA: 0x19A8D30 Slot: 5
	public object get_Current() { }

	// RVA: 0x19A8F00 Offset: 0x19A9001 VA: 0x19A8F00 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x19A9000 Offset: 0x19A9101 VA: 0x19A9000 Slot: 6
	public void Reset() { }
}

