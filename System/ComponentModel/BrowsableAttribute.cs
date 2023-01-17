// Namespace: System.ComponentModel
[AttributeUsageAttribute] // RVA: 0x2FF50 Offset: 0x30051 VA: 0x2FF50
public sealed class BrowsableAttribute : Attribute // TypeDefIndex: 2293
{
	// Fields
	public static readonly BrowsableAttribute Yes; // 0x0
	public static readonly BrowsableAttribute No; // 0x8
	public static readonly BrowsableAttribute Default; // 0x10
	private bool browsable; // 0x10

	// Properties
	public bool Browsable { get; }

	// Methods

	// RVA: 0x1B40C10 Offset: 0x1B40D11 VA: 0x1B40C10
	public void .ctor(bool browsable) { }

	// RVA: 0x1B40C50 Offset: 0x1B40D51 VA: 0x1B40C50
	public bool get_Browsable() { }

	// RVA: 0x1B40C60 Offset: 0x1B40D61 VA: 0x1B40C60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B40D10 Offset: 0x1B40E11 VA: 0x1B40D10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B40D20 Offset: 0x1B40E21 VA: 0x1B40D20
	private static void .cctor() { }
}

