// Namespace: System.ComponentModel
[AttributeUsageAttribute] // RVA: 0x30410 Offset: 0x30511 VA: 0x30410
public sealed class NotifyParentPropertyAttribute : Attribute // TypeDefIndex: 2332
{
	// Fields
	public static readonly NotifyParentPropertyAttribute Yes; // 0x0
	public static readonly NotifyParentPropertyAttribute No; // 0x8
	public static readonly NotifyParentPropertyAttribute Default; // 0x10
	private bool notifyParent; // 0x10

	// Properties
	public bool NotifyParent { get; }

	// Methods

	// RVA: 0x1AD1320 Offset: 0x1AD1421 VA: 0x1AD1320
	public void .ctor(bool notifyParent) { }

	// RVA: 0x1AD1350 Offset: 0x1AD1451 VA: 0x1AD1350
	public bool get_NotifyParent() { }

	// RVA: 0x1AD1360 Offset: 0x1AD1461 VA: 0x1AD1360 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1AD1410 Offset: 0x1AD1511 VA: 0x1AD1410 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AD1420 Offset: 0x1AD1521 VA: 0x1AD1420
	private static void .cctor() { }
}

