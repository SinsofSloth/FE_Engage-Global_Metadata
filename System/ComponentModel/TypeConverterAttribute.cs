// Namespace: System.ComponentModel
[AttributeUsageAttribute] // RVA: 0x303F0 Offset: 0x304F1 VA: 0x303F0
public sealed class TypeConverterAttribute : Attribute // TypeDefIndex: 2329
{
	// Fields
	private string typeName; // 0x10
	public static readonly TypeConverterAttribute Default; // 0x0

	// Properties
	public string ConverterTypeName { get; }

	// Methods

	// RVA: 0x2D145F0 Offset: 0x2D146F1 VA: 0x2D145F0
	public void .ctor() { }

	// RVA: 0x2D14660 Offset: 0x2D14761 VA: 0x2D14660
	public void .ctor(Type type) { }

	// RVA: 0x2D146B0 Offset: 0x2D147B1 VA: 0x2D146B0
	public void .ctor(string typeName) { }

	// RVA: 0x2D14750 Offset: 0x2D14851 VA: 0x2D14750
	public string get_ConverterTypeName() { }

	// RVA: 0x2D14760 Offset: 0x2D14861 VA: 0x2D14760 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2D147F0 Offset: 0x2D148F1 VA: 0x2D147F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2D14800 Offset: 0x2D14901 VA: 0x2D14800
	private static void .cctor() { }
}

