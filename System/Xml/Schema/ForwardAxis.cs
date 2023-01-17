// Namespace: System.Xml.Schema
internal class ForwardAxis // TypeDefIndex: 1793
{
	// Fields
	private DoubleLinkAxis topNode; // 0x10
	private DoubleLinkAxis rootNode; // 0x18
	private bool isAttribute; // 0x20
	private bool isDss; // 0x21
	private bool isSelfAxis; // 0x22

	// Properties
	internal DoubleLinkAxis RootNode { get; }
	internal DoubleLinkAxis TopNode { get; }
	internal bool IsAttribute { get; }
	internal bool IsDss { get; }
	internal bool IsSelfAxis { get; }

	// Methods

	// RVA: 0x323E6A0 Offset: 0x323E7A1 VA: 0x323E6A0
	internal DoubleLinkAxis get_RootNode() { }

	// RVA: 0x323E6B0 Offset: 0x323E7B1 VA: 0x323E6B0
	internal DoubleLinkAxis get_TopNode() { }

	// RVA: 0x323E6C0 Offset: 0x323E7C1 VA: 0x323E6C0
	internal bool get_IsAttribute() { }

	// RVA: 0x323E6D0 Offset: 0x323E7D1 VA: 0x323E6D0
	internal bool get_IsDss() { }

	// RVA: 0x323E6E0 Offset: 0x323E7E1 VA: 0x323E6E0
	internal bool get_IsSelfAxis() { }

	// RVA: 0x323E6F0 Offset: 0x323E7F1 VA: 0x323E6F0
	public void .ctor(DoubleLinkAxis axis, bool isdesorself) { }
}

