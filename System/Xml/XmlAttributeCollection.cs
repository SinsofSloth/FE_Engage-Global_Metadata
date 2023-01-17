// Namespace: System.Xml
[DefaultMemberAttribute] // RVA: 0x46D70 Offset: 0x46E71 VA: 0x46D70
public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable // TypeDefIndex: 1687
{
	// Properties
	public XmlAttribute ItemOf { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }

	// Methods

	// RVA: 0x1A96990 Offset: 0x1A96A91 VA: 0x1A96990
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x1A969A0 Offset: 0x1A96AA1 VA: 0x1A969A0
	public XmlAttribute get_ItemOf(int i) { }

	// RVA: 0x1A96AF0 Offset: 0x1A96BF1 VA: 0x1A96AF0 Slot: 6
	public override XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x1A96DB0 Offset: 0x1A96EB1 VA: 0x1A96DB0
	public XmlAttribute Append(XmlAttribute node) { }

	// RVA: 0x1A97150 Offset: 0x1A97251 VA: 0x1A97150
	public XmlAttribute Remove(XmlAttribute node) { }

	// RVA: 0x1A971F0 Offset: 0x1A972F1 VA: 0x1A971F0
	public XmlAttribute RemoveAt(int i) { }

	// RVA: 0x1A972C0 Offset: 0x1A973C1 VA: 0x1A972C0
	public void RemoveAll() { }

	// RVA: 0x1A973A0 Offset: 0x1A974A1 VA: 0x1A973A0 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1A97430 Offset: 0x1A97531 VA: 0x1A97430 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1A97440 Offset: 0x1A97541 VA: 0x1A97440 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1A97450 Offset: 0x1A97551 VA: 0x1A97450 Slot: 14
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1A97460 Offset: 0x1A97561 VA: 0x1A97460 Slot: 9
	internal override XmlNode AddNode(XmlNode node) { }

	// RVA: 0x1A97660 Offset: 0x1A97761 VA: 0x1A97660 Slot: 12
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	// RVA: 0x1A97720 Offset: 0x1A97821 VA: 0x1A97720 Slot: 11
	internal override XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x1A96F50 Offset: 0x1A97051 VA: 0x1A96F50
	internal void Detach(XmlAttribute attr) { }

	// RVA: 0x1A97010 Offset: 0x1A97111 VA: 0x1A97010
	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x1A978C0 Offset: 0x1A979C1 VA: 0x1A978C0
	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x1A97550 Offset: 0x1A97651 VA: 0x1A97550
	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	// RVA: 0x1A96040 Offset: 0x1A96141 VA: 0x1A96040
	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	// RVA: 0x1A96130 Offset: 0x1A96231 VA: 0x1A96130
	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	// RVA: 0x1A96D00 Offset: 0x1A96E01 VA: 0x1A96D00
	internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }
}

