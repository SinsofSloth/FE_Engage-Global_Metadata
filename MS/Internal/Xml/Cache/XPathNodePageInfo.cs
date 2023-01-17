// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathNodePageInfo // TypeDefIndex: 1622
{
	// Fields
	private int pageNum; // 0x10
	private int nodeCount; // 0x14
	private XPathNode[] pageNext; // 0x18

	// Properties
	public int PageNumber { get; }
	public int NodeCount { get; }
	public XPathNode[] NextPage { get; }

	// Methods

	// RVA: 0x19C0A10 Offset: 0x19C0B11 VA: 0x19C0A10
	public int get_PageNumber() { }

	// RVA: 0x19C0A20 Offset: 0x19C0B21 VA: 0x19C0A20
	public int get_NodeCount() { }

	// RVA: 0x19C0A30 Offset: 0x19C0B31 VA: 0x19C0A30
	public XPathNode[] get_NextPage() { }
}

