// Namespace: System.Xml
[DefaultMemberAttribute] // RVA: 0x46DF0 Offset: 0x46EF1 VA: 0x46DF0
[DebuggerDisplayAttribute] // RVA: 0x46DF0 Offset: 0x46EF1 VA: 0x46DF0
public abstract class XmlNode : ICloneable, IEnumerable // TypeDefIndex: 1709
{
	// Fields
	internal XmlNode parentNode; // 0x10

	// Properties
	public abstract string Name { get; }
	public virtual string Value { get; set; }
	public abstract XmlNodeType NodeType { get; }
	public virtual XmlNode ParentNode { get; }
	public virtual XmlNodeList ChildNodes { get; }
	public virtual XmlNode PreviousSibling { get; }
	public virtual XmlNode NextSibling { get; }
	public virtual XmlAttributeCollection Attributes { get; }
	public virtual XmlDocument OwnerDocument { get; }
	public virtual XmlNode FirstChild { get; }
	public virtual XmlNode LastChild { get; }
	internal virtual bool IsContainer { get; }
	internal virtual XmlLinkedNode LastNode { get; set; }
	public virtual bool HasChildNodes { get; }
	public virtual string NamespaceURI { get; }
	public virtual string Prefix { get; }
	public abstract string LocalName { get; }
	public virtual bool IsReadOnly { get; }
	public virtual string InnerText { get; set; }
	public virtual string InnerXml { set; }
	public virtual string BaseURI { get; }
	internal virtual bool IsText { get; }

	// Methods

	// RVA: 0x32E83C0 Offset: 0x32E84C1 VA: 0x32E83C0
	internal void .ctor() { }

	// RVA: 0x32EAED0 Offset: 0x32EAFD1 VA: 0x32EAED0
	internal void .ctor(XmlDocument doc) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_Name();

	// RVA: 0x32F8110 Offset: 0x32F8211 VA: 0x32F8110 Slot: 7
	public virtual string get_Value() { }

	// RVA: 0x32F8120 Offset: 0x32F8221 VA: 0x32F8120 Slot: 8
	public virtual void set_Value(string value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x32F8240 Offset: 0x32F8341 VA: 0x32F8240 Slot: 10
	public virtual XmlNode get_ParentNode() { }

	// RVA: 0x32F8340 Offset: 0x32F8441 VA: 0x32F8340 Slot: 11
	public virtual XmlNodeList get_ChildNodes() { }

	// RVA: 0x32F83B0 Offset: 0x32F84B1 VA: 0x32F83B0 Slot: 12
	public virtual XmlNode get_PreviousSibling() { }

	// RVA: 0x32F83C0 Offset: 0x32F84C1 VA: 0x32F83C0 Slot: 13
	public virtual XmlNode get_NextSibling() { }

	// RVA: 0x32F83D0 Offset: 0x32F84D1 VA: 0x32F83D0 Slot: 14
	public virtual XmlAttributeCollection get_Attributes() { }

	// RVA: 0x32F83E0 Offset: 0x32F84E1 VA: 0x32F83E0 Slot: 15
	public virtual XmlDocument get_OwnerDocument() { }

	// RVA: 0x32F8490 Offset: 0x32F8591 VA: 0x32F8490 Slot: 16
	public virtual XmlNode get_FirstChild() { }

	// RVA: 0x32F84C0 Offset: 0x32F85C1 VA: 0x32F84C0 Slot: 17
	public virtual XmlNode get_LastChild() { }

	// RVA: 0x32F84D0 Offset: 0x32F85D1 VA: 0x32F84D0 Slot: 18
	internal virtual bool get_IsContainer() { }

	// RVA: 0x32F84E0 Offset: 0x32F85E1 VA: 0x32F84E0 Slot: 19
	internal virtual XmlLinkedNode get_LastNode() { }

	// RVA: 0x32F84F0 Offset: 0x32F85F1 VA: 0x32F84F0 Slot: 20
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x32F8500 Offset: 0x32F8601 VA: 0x32F8500
	internal bool AncestorNode(XmlNode node) { }

	// RVA: 0x32F8560 Offset: 0x32F8661 VA: 0x32F8560 Slot: 21
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x32F8980 Offset: 0x32F8A81 VA: 0x32F8980 Slot: 22
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x32F8E80 Offset: 0x32F8F81 VA: 0x32F8E80 Slot: 23
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x32F9050 Offset: 0x32F9151 VA: 0x32F9050 Slot: 24
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x32F9060 Offset: 0x32F9161 VA: 0x32F9060 Slot: 25
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x32F9070 Offset: 0x32F9171 VA: 0x32F9070 Slot: 26
	public virtual bool get_HasChildNodes() { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract XmlNode CloneNode(bool deep);

	// RVA: 0x32F90A0 Offset: 0x32F91A1 VA: 0x32F90A0 Slot: 28
	internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	// RVA: 0x32F9140 Offset: 0x32F9241 VA: 0x32F9140 Slot: 29
	public virtual string get_NamespaceURI() { }

	// RVA: 0x32F9190 Offset: 0x32F9291 VA: 0x32F9190 Slot: 30
	public virtual string get_Prefix() { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract string get_LocalName();

	// RVA: 0x32F91E0 Offset: 0x32F92E1 VA: 0x32F91E0 Slot: 32
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x32F92E0 Offset: 0x32F93E1 VA: 0x32F92E0
	internal static bool HasReadOnlyParent(XmlNode n) { }

	// RVA: 0x32F93D0 Offset: 0x32F94D1 VA: 0x32F93D0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x32F93F0 Offset: 0x32F94F1 VA: 0x32F93F0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x32F9460 Offset: 0x32F9561 VA: 0x32F9460
	private void AppendChildText(StringBuilder builder) { }

	// RVA: 0x32EAAE0 Offset: 0x32EABE1 VA: 0x32EAAE0 Slot: 33
	public virtual string get_InnerText() { }

	// RVA: 0x32F9560 Offset: 0x32F9661 VA: 0x32F9560 Slot: 34
	public virtual void set_InnerText(string value) { }

	// RVA: 0x32F9640 Offset: 0x32F9741 VA: 0x32F9640 Slot: 35
	public virtual void set_InnerXml(string value) { }

	// RVA: 0x32F96A0 Offset: 0x32F97A1 VA: 0x32F96A0 Slot: 36
	public virtual string get_BaseURI() { }

	// RVA: 0x32EA8B0 Offset: 0x32EA9B1 VA: 0x32EA8B0 Slot: 37
	public virtual void RemoveAll() { }

	// RVA: 0x32EB610 Offset: 0x32EB711 VA: 0x32EB610 Slot: 38
	internal virtual void SetParent(XmlNode node) { }

	// RVA: 0x32F97D0 Offset: 0x32F98D1 VA: 0x32F97D0 Slot: 39
	internal virtual void SetParentForLoad(XmlNode node) { }

	// RVA: 0x32F97E0 Offset: 0x32F98E1 VA: 0x32F97E0 Slot: 40
	internal virtual XmlNode FindChild(XmlNodeType type) { }

	// RVA: 0x32F9850 Offset: 0x32F9951 VA: 0x32F9850 Slot: 41
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x32F9980 Offset: 0x32F9A81 VA: 0x32F9980 Slot: 42
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x32F99D0 Offset: 0x32F9AD1 VA: 0x32F99D0 Slot: 43
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x32F9A20 Offset: 0x32F9B21 VA: 0x32F9A20 Slot: 44
	internal virtual bool get_IsText() { }

	// RVA: 0x32EA450 Offset: 0x32EA551 VA: 0x32EA450
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	// RVA: 0x32F8940 Offset: 0x32F8A41 VA: 0x32F8940
	internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode) { }
}

