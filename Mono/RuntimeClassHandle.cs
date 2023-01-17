// Namespace: Mono
internal struct RuntimeClassHandle // TypeDefIndex: 4
{
	// Fields
	private RuntimeStructs.MonoClass* value; // 0x0

	// Properties
	internal RuntimeStructs.MonoClass* Value { get; }

	// Methods

	// RVA: 0x322B7E0 Offset: 0x322B8E1 VA: 0x322B7E0
	internal void .ctor(RuntimeStructs.MonoClass* value) { }

	// RVA: 0x322B7F0 Offset: 0x322B8F1 VA: 0x322B7F0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x322B820 Offset: 0x322B921 VA: 0x322B820
	internal RuntimeStructs.MonoClass* get_Value() { }

	// RVA: 0x322B830 Offset: 0x322B931 VA: 0x322B830 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x322B950 Offset: 0x322BA51 VA: 0x322B950 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x322B990 Offset: 0x322BA91 VA: 0x322B990
	internal static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass) { }

	// RVA: 0x322B9A0 Offset: 0x322BAA1 VA: 0x322B9A0
	internal RuntimeTypeHandle GetTypeHandle() { }
}

