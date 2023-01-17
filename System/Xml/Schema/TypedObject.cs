// Namespace: System.Xml.Schema
internal class TypedObject // TypeDefIndex: 1807
{
	// Fields
	private TypedObject.DecimalStruct dstruct; // 0x10
	private object ovalue; // 0x18
	private string svalue; // 0x20
	private XmlSchemaDatatype xsdtype; // 0x28
	private int dim; // 0x30
	private bool isList; // 0x34

	// Properties
	public int Dim { get; }
	public bool IsList { get; }
	public bool IsDecimal { get; }
	public Decimal[] Dvalue { get; }
	public object Value { get; }
	public XmlSchemaDatatype Type { get; }

	// Methods

	// RVA: 0x19B8660 Offset: 0x19B8761 VA: 0x19B8660
	public int get_Dim() { }

	// RVA: 0x19B8670 Offset: 0x19B8771 VA: 0x19B8670
	public bool get_IsList() { }

	// RVA: 0x19B8680 Offset: 0x19B8781 VA: 0x19B8680
	public bool get_IsDecimal() { }

	// RVA: 0x19B8690 Offset: 0x19B8791 VA: 0x19B8690
	public Decimal[] get_Dvalue() { }

	// RVA: 0x19B86A0 Offset: 0x19B87A1 VA: 0x19B86A0
	public object get_Value() { }

	// RVA: 0x19B86B0 Offset: 0x19B87B1 VA: 0x19B86B0
	public XmlSchemaDatatype get_Type() { }

	// RVA: 0x19B86C0 Offset: 0x19B87C1 VA: 0x19B86C0
	public void .ctor(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	// RVA: 0x19B8850 Offset: 0x19B8951 VA: 0x19B8850 Slot: 3
	public override string ToString() { }

	// RVA: 0x19B8860 Offset: 0x19B8961 VA: 0x19B8860
	public void SetDecimal() { }

	// RVA: 0x19B8B20 Offset: 0x19B8C21 VA: 0x19B8B20
	private bool ListDValueEquals(TypedObject other) { }

	// RVA: 0x19B8C40 Offset: 0x19B8D41 VA: 0x19B8C40
	public bool Equals(TypedObject other) { }
}

