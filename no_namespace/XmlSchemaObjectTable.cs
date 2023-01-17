// Namespace: 
internal enum XmlSchemaObjectTable.EnumeratorType // TypeDefIndex: 2019
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaObjectTable.EnumeratorType Keys = 0;
	public const XmlSchemaObjectTable.EnumeratorType Values = 1;
	public const XmlSchemaObjectTable.EnumeratorType DictionaryEntry = 2;
}

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
internal class XmlSchemaObjectTable.ValuesCollection : ICollection, IEnumerable // TypeDefIndex: 2021
{
	// Fields
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private int size; // 0x18

	// Properties
	public int Count { get; }
	public object SyncRoot { get; }
	public bool IsSynchronized { get; }

	// Methods

	// RVA: 0x19A8530 Offset: 0x19A8631 VA: 0x19A8530
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size) { }

	// RVA: 0x19A8580 Offset: 0x19A8681 VA: 0x19A8580 Slot: 5
	public int get_Count() { }

	// RVA: 0x19A8590 Offset: 0x19A8691 VA: 0x19A8590 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x19A8640 Offset: 0x19A8741 VA: 0x19A8640 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x19A86F0 Offset: 0x19A87F1 VA: 0x19A86F0 Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x19A8840 Offset: 0x19A8941 VA: 0x19A8840 Slot: 8
	public IEnumerator GetEnumerator() { }
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

// Namespace: 
internal class XmlSchemaObjectTable.XSODictionaryEnumerator : XmlSchemaObjectTable.XSOEnumerator, IDictionaryEnumerator, IEnumerator // TypeDefIndex: 2023
{
	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x19A8930 Offset: 0x19A8A31 VA: 0x19A8930
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

	// RVA: 0x19A8990 Offset: 0x19A8A91 VA: 0x19A8990 Slot: 9
	public DictionaryEntry get_Entry() { }

	// RVA: 0x19A8AD0 Offset: 0x19A8BD1 VA: 0x19A8AD0 Slot: 7
	public object get_Key() { }

	// RVA: 0x19A8C00 Offset: 0x19A8D01 VA: 0x19A8C00 Slot: 8
	public object get_Value() { }
}

