// Namespace: System.ComponentModel
[AttributeUsageAttribute] // RVA: 0x30370 Offset: 0x30471 VA: 0x30370
public sealed class SettingsBindableAttribute : Attribute // TypeDefIndex: 2323
{
	// Fields
	public static readonly SettingsBindableAttribute Yes; // 0x0
	public static readonly SettingsBindableAttribute No; // 0x8
	private bool _bindable; // 0x10

	// Properties
	public bool Bindable { get; }

	// Methods

	// RVA: 0x2D082E0 Offset: 0x2D083E1 VA: 0x2D082E0
	public void .ctor(bool bindable) { }

	// RVA: 0x2D08310 Offset: 0x2D08411 VA: 0x2D08310
	public bool get_Bindable() { }

	// RVA: 0x2D08320 Offset: 0x2D08421 VA: 0x2D08320 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2D083D0 Offset: 0x2D084D1 VA: 0x2D083D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2D083E0 Offset: 0x2D084E1 VA: 0x2D083E0
	private static void .cctor() { }
}

