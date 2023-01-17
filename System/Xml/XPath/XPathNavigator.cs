// Namespace: System.Xml.XPath
[DebuggerDisplayAttribute] // RVA: 0x46F00 Offset: 0x47001 VA: 0x46F00
public abstract class XPathNavigator : XPathItem, ICloneable, IXmlNamespaceResolver // TypeDefIndex: 1776
{
	// Fields
	internal static readonly XPathNavigatorKeyComparer comparer; // 0x0
	internal static readonly char[] NodeTypeLetter; // 0x8
	internal static readonly char[] UniqueIdTbl; // 0x10
	internal static readonly int[] ContentKindMasks; // 0x18

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override object TypedValue { get; }
	public override Type ValueType { get; }
	public override bool ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override double ValueAsDouble { get; }
	public override int ValueAsInt { get; }
	public override long ValueAsLong { get; }
	public abstract XmlNameTable NameTable { get; }
	public abstract XPathNodeType NodeType { get; }
	public abstract string LocalName { get; }
	public abstract string NamespaceURI { get; }
	public abstract string Prefix { get; }
	public virtual object UnderlyingObject { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }

	// Methods

	// RVA: 0x19BE380 Offset: 0x19BE481 VA: 0x19BE380 Slot: 3
	public override string ToString() { }

	// RVA: 0x19BE390 Offset: 0x19BE491 VA: 0x19BE390 Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x19BE530 Offset: 0x19BE631 VA: 0x19BE530 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0x19BE830 Offset: 0x19BE931 VA: 0x19BE830 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x19BEA70 Offset: 0x19BEB71 VA: 0x19BEA70 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x19BED60 Offset: 0x19BEE61 VA: 0x19BED60 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x19BF060 Offset: 0x19BF161 VA: 0x19BF060 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0x19BF360 Offset: 0x19BF461 VA: 0x19BF360 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0x19BF660 Offset: 0x19BF761 VA: 0x19BF660 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0x19BF960 Offset: 0x19BFA61 VA: 0x19BF960 Slot: 14
	public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x19BFC70 Offset: 0x19BFD71 VA: 0x19BFC70 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract XmlNameTable get_NameTable();

	// RVA: 0x19BFC80 Offset: 0x19BFD81 VA: 0x19BFC80 Slot: 20
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x19BFE50 Offset: 0x19BFF51 VA: 0x19BFE50 Slot: 21
	public virtual string LookupPrefix(string namespaceURI) { }

	// RVA: 0x19C0080 Offset: 0x19C0181 VA: 0x19C0080 Slot: 22
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract XPathNavigator Clone();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract XPathNodeType get_NodeType();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_NamespaceURI();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_Prefix();

	// RVA: 0x19C0300 Offset: 0x19C0401 VA: 0x19C0300 Slot: 28
	public virtual object get_UnderlyingObject() { }

	// RVA: 0x19C0310 Offset: 0x19C0411 VA: 0x19C0310 Slot: 29
	public virtual bool MoveToNamespace(string name) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool MoveToParent();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract bool IsSamePosition(XPathNavigator other);

	// RVA: 0x19C03C0 Offset: 0x19C04C1 VA: 0x19C03C0 Slot: 34
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x19C0420 Offset: 0x19C0521 VA: 0x19C0420
	internal static bool IsText(XPathNodeType type) { }

	// RVA: 0x19BC7A0 Offset: 0x19BC8A1 VA: 0x19BC7A0
	protected void .ctor() { }

	// RVA: 0x19C0430 Offset: 0x19C0531 VA: 0x19C0430
	private static void .cctor() { }
}

