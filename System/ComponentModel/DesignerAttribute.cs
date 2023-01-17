// Namespace: System.ComponentModel
[AttributeUsageAttribute] // RVA: 0x30060 Offset: 0x30161 VA: 0x30060
public sealed class DesignerAttribute : Attribute // TypeDefIndex: 2302
{
	// Fields
	private readonly string designerTypeName; // 0x10
	private readonly string designerBaseTypeName; // 0x18

	// Methods

	// RVA: 0x1B56770 Offset: 0x1B56871 VA: 0x1B56770
	public void .ctor(string designerTypeName) { }

	// RVA: 0x1B56880 Offset: 0x1B56981 VA: 0x1B56880
	public void .ctor(string designerTypeName, Type designerBaseType) { }

	// RVA: 0x1B56950 Offset: 0x1B56A51 VA: 0x1B56950 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B56A10 Offset: 0x1B56B11 VA: 0x1B56A10 Slot: 2
	public override int GetHashCode() { }
}

