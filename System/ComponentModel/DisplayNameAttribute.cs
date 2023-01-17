// Namespace: System.ComponentModel
[AttributeUsageAttribute] // RVA: 0x30120 Offset: 0x30221 VA: 0x30120
public class DisplayNameAttribute : Attribute // TypeDefIndex: 2306
{
	// Fields
	public static readonly DisplayNameAttribute Default; // 0x0
	private string _displayName; // 0x10

	// Properties
	public virtual string DisplayName { get; }
	protected string DisplayNameValue { get; }

	// Methods

	// RVA: 0x1AD93C0 Offset: 0x1AD94C1 VA: 0x1AD93C0
	public void .ctor() { }

	// RVA: 0x1AD9430 Offset: 0x1AD9531 VA: 0x1AD9430
	public void .ctor(string displayName) { }

	// RVA: 0x1AD9470 Offset: 0x1AD9571 VA: 0x1AD9470 Slot: 4
	public virtual string get_DisplayName() { }

	// RVA: 0x1AD9480 Offset: 0x1AD9581 VA: 0x1AD9480
	protected string get_DisplayNameValue() { }

	// RVA: 0x1AD9490 Offset: 0x1AD9591 VA: 0x1AD9490 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1AD9570 Offset: 0x1AD9671 VA: 0x1AD9570 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AD95A0 Offset: 0x1AD96A1 VA: 0x1AD95A0
	private static void .cctor() { }
}

