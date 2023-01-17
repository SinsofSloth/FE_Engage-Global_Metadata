// Namespace: System.ComponentModel
[AttributeUsageAttribute] // RVA: 0x30020 Offset: 0x30121 VA: 0x30020
public class DefaultValueAttribute : Attribute // TypeDefIndex: 2300
{
	// Fields
	private object value; // 0x10

	// Properties
	public virtual object Value { get; }

	// Methods

	// RVA: 0x1B544B0 Offset: 0x1B545B1 VA: 0x1B544B0
	public void .ctor(bool value) { }

	// RVA: 0x1B54540 Offset: 0x1B54641 VA: 0x1B54540
	public void .ctor(string value) { }

	// RVA: 0x1B54580 Offset: 0x1B54681 VA: 0x1B54580
	public void .ctor(object value) { }

	// RVA: 0x1B545C0 Offset: 0x1B546C1 VA: 0x1B545C0 Slot: 4
	public virtual object get_Value() { }

	// RVA: 0x1B545D0 Offset: 0x1B546D1 VA: 0x1B545D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B54700 Offset: 0x1B54801 VA: 0x1B54700 Slot: 2
	public override int GetHashCode() { }
}

