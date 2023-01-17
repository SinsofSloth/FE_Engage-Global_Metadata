// Namespace: System.ComponentModel
[AttributeUsageAttribute] // RVA: 0x30100 Offset: 0x30201 VA: 0x30100
public sealed class DesignerSerializationVisibilityAttribute : Attribute // TypeDefIndex: 2305
{
	// Fields
	public static readonly DesignerSerializationVisibilityAttribute Content; // 0x0
	public static readonly DesignerSerializationVisibilityAttribute Hidden; // 0x8
	public static readonly DesignerSerializationVisibilityAttribute Visible; // 0x10
	public static readonly DesignerSerializationVisibilityAttribute Default; // 0x18
	private DesignerSerializationVisibility visibility; // 0x10

	// Properties
	public DesignerSerializationVisibility Visibility { get; }

	// Methods

	// RVA: 0x1B56D70 Offset: 0x1B56E71 VA: 0x1B56D70
	public void .ctor(DesignerSerializationVisibility visibility) { }

	// RVA: 0x1B56DA0 Offset: 0x1B56EA1 VA: 0x1B56DA0
	public DesignerSerializationVisibility get_Visibility() { }

	// RVA: 0x1B56DB0 Offset: 0x1B56EB1 VA: 0x1B56DB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B56E60 Offset: 0x1B56F61 VA: 0x1B56E60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B56E70 Offset: 0x1B56F71 VA: 0x1B56E70
	private static void .cctor() { }
}

