// Namespace: System.ComponentModel
[AttributeUsageAttribute] // RVA: 0x30040 Offset: 0x30141 VA: 0x30040
public class DescriptionAttribute : Attribute // TypeDefIndex: 2301
{
	// Fields
	public static readonly DescriptionAttribute Default; // 0x0
	private string description; // 0x10

	// Properties
	public virtual string Description { get; }
	protected string DescriptionValue { get; }

	// Methods

	// RVA: 0x1B564D0 Offset: 0x1B565D1 VA: 0x1B564D0
	public void .ctor() { }

	// RVA: 0x1B56540 Offset: 0x1B56641 VA: 0x1B56540
	public void .ctor(string description) { }

	// RVA: 0x1B56580 Offset: 0x1B56681 VA: 0x1B56580 Slot: 4
	public virtual string get_Description() { }

	// RVA: 0x1B56590 Offset: 0x1B56691 VA: 0x1B56590
	protected string get_DescriptionValue() { }

	// RVA: 0x1B565A0 Offset: 0x1B566A1 VA: 0x1B565A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B56680 Offset: 0x1B56781 VA: 0x1B56680 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B566B0 Offset: 0x1B567B1 VA: 0x1B566B0
	private static void .cctor() { }
}

