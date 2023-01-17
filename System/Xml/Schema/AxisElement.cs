// Namespace: System.Xml.Schema
internal class AxisElement // TypeDefIndex: 1789
{
	// Fields
	internal DoubleLinkAxis curNode; // 0x10
	internal int rootDepth; // 0x18
	internal int curDepth; // 0x1C
	internal bool isMatch; // 0x20

	// Properties
	internal DoubleLinkAxis CurNode { get; }

	// Methods

	// RVA: 0x1A23610 Offset: 0x1A23711 VA: 0x1A23610
	internal DoubleLinkAxis get_CurNode() { }

	// RVA: 0x1A23620 Offset: 0x1A23721 VA: 0x1A23620
	internal void .ctor(DoubleLinkAxis node, int depth) { }

	// RVA: 0x1A23670 Offset: 0x1A23771 VA: 0x1A23670
	internal void SetDepth(int depth) { }

	// RVA: 0x1A23680 Offset: 0x1A23781 VA: 0x1A23680
	internal void MoveToParent(int depth, ForwardAxis parent) { }

	// RVA: 0x1A237A0 Offset: 0x1A238A1 VA: 0x1A237A0
	internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent) { }
}

