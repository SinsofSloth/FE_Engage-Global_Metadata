// Namespace: System.Xml.Schema
internal class AxisStack // TypeDefIndex: 1790
{
	// Fields
	private ArrayList stack; // 0x10
	private ForwardAxis subtree; // 0x18
	private ActiveAxis parent; // 0x20

	// Properties
	internal ForwardAxis Subtree { get; }
	internal int Length { get; }

	// Methods

	// RVA: 0x1A239F0 Offset: 0x1A23AF1 VA: 0x1A239F0
	internal ForwardAxis get_Subtree() { }

	// RVA: 0x1A23A00 Offset: 0x1A23B01 VA: 0x1A23A00
	internal int get_Length() { }

	// RVA: 0x1A20560 Offset: 0x1A20661 VA: 0x1A20560
	public void .ctor(ForwardAxis faxis, ActiveAxis parent) { }

	// RVA: 0x1A23A20 Offset: 0x1A23B21 VA: 0x1A23A20
	internal void Push(int depth) { }

	// RVA: 0x1A23AC0 Offset: 0x1A23BC1 VA: 0x1A23AC0
	internal void Pop() { }

	// RVA: 0x1A23950 Offset: 0x1A23A51 VA: 0x1A23950
	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	// RVA: 0x1A20B20 Offset: 0x1A20C21 VA: 0x1A20B20
	internal void MoveToParent(string name, string URN, int depth) { }

	// RVA: 0x1A20800 Offset: 0x1A20901 VA: 0x1A20800
	internal bool MoveToChild(string name, string URN, int depth) { }

	// RVA: 0x1A20DF0 Offset: 0x1A20EF1 VA: 0x1A20DF0
	internal bool MoveToAttribute(string name, string URN, int depth) { }
}

