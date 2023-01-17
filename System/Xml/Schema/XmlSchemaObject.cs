// Namespace: System.Xml.Schema
public abstract class XmlSchemaObject // TypeDefIndex: 2017
{
	// Fields
	private int lineNum; // 0x10
	private int linePos; // 0x14
	private string sourceUri; // 0x18
	private XmlSerializerNamespaces namespaces; // 0x20
	private XmlSchemaObject parent; // 0x28
	private bool isProcessing; // 0x30

	// Properties
	[XmlIgnoreAttribute] // RVA: 0x4A890 Offset: 0x4A991 VA: 0x4A890
	public int LineNumber { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A8A0 Offset: 0x4A9A1 VA: 0x4A8A0
	public int LinePosition { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A8B0 Offset: 0x4A9B1 VA: 0x4A8B0
	public string SourceUri { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A8C0 Offset: 0x4A9C1 VA: 0x4A8C0
	public XmlSchemaObject Parent { get; set; }
	[XmlNamespaceDeclarationsAttribute] // RVA: 0x4A8D0 Offset: 0x4A9D1 VA: 0x4A8D0
	public XmlSerializerNamespaces Namespaces { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A8E0 Offset: 0x4A9E1 VA: 0x4A8E0
	internal virtual string IdAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A8F0 Offset: 0x4A9F1 VA: 0x4A8F0
	internal virtual string NameAttribute { get; set; }
	[XmlIgnoreAttribute] // RVA: 0x4A900 Offset: 0x4AA01 VA: 0x4A900
	internal bool IsProcessing { get; set; }

	// Methods

	// RVA: 0x19676F0 Offset: 0x19677F1 VA: 0x19676F0
	public int get_LineNumber() { }

	// RVA: 0x1967700 Offset: 0x1967801 VA: 0x1967700
	public void set_LineNumber(int value) { }

	// RVA: 0x1967710 Offset: 0x1967811 VA: 0x1967710
	public int get_LinePosition() { }

	// RVA: 0x1967720 Offset: 0x1967821 VA: 0x1967720
	public void set_LinePosition(int value) { }

	// RVA: 0x1967730 Offset: 0x1967831 VA: 0x1967730
	public string get_SourceUri() { }

	// RVA: 0x1967740 Offset: 0x1967841 VA: 0x1967740
	public void set_SourceUri(string value) { }

	// RVA: 0x1967750 Offset: 0x1967851 VA: 0x1967750
	public XmlSchemaObject get_Parent() { }

	// RVA: 0x1967760 Offset: 0x1967861 VA: 0x1967760
	public void set_Parent(XmlSchemaObject value) { }

	// RVA: 0x1967770 Offset: 0x1967871 VA: 0x1967770
	public XmlSerializerNamespaces get_Namespaces() { }

	// RVA: 0x1967800 Offset: 0x1967901 VA: 0x1967800
	public void set_Namespaces(XmlSerializerNamespaces value) { }

	// RVA: 0x1967810 Offset: 0x1967911 VA: 0x1967810 Slot: 4
	internal virtual void OnAdd(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x1967820 Offset: 0x1967921 VA: 0x1967820 Slot: 5
	internal virtual void OnRemove(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x1967830 Offset: 0x1967931 VA: 0x1967830 Slot: 6
	internal virtual void OnClear(XmlSchemaObjectCollection container) { }

	// RVA: 0x1967840 Offset: 0x1967941 VA: 0x1967840 Slot: 7
	internal virtual string get_IdAttribute() { }

	// RVA: 0x1967850 Offset: 0x1967951 VA: 0x1967850 Slot: 8
	internal virtual void set_IdAttribute(string value) { }

	// RVA: 0x1967860 Offset: 0x1967961 VA: 0x1967860 Slot: 9
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1967870 Offset: 0x1967971 VA: 0x1967870 Slot: 10
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x1967880 Offset: 0x1967981 VA: 0x1967880 Slot: 11
	internal virtual string get_NameAttribute() { }

	// RVA: 0x1967890 Offset: 0x1967991 VA: 0x1967890 Slot: 12
	internal virtual void set_NameAttribute(string value) { }

	// RVA: 0x19678A0 Offset: 0x19679A1 VA: 0x19678A0
	internal bool get_IsProcessing() { }

	// RVA: 0x19678B0 Offset: 0x19679B1 VA: 0x19678B0
	internal void set_IsProcessing(bool value) { }

	// RVA: 0x19678C0 Offset: 0x19679C1 VA: 0x19678C0 Slot: 13
	internal virtual XmlSchemaObject Clone() { }

	// RVA: 0x195E0B0 Offset: 0x195E1B1 VA: 0x195E0B0
	protected void .ctor() { }
}

