// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathNodeHelper // TypeDefIndex: 1621
{
	// Methods

	// RVA: 0x19BD070 Offset: 0x19BD171 VA: 0x19BD070
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x19BD0E0 Offset: 0x19BD1E1 VA: 0x19BD0E0
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x19BD5B0 Offset: 0x19BD6B1 VA: 0x19BD5B0
	public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x19C0940 Offset: 0x19C0A41 VA: 0x19C0940
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x19BCA60 Offset: 0x19BCB61 VA: 0x19BCA60
	public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

	// RVA: 0x19BC980 Offset: 0x19BCA81 VA: 0x19BC980
	public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode) { }
}

