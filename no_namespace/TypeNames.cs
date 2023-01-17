// Namespace: 
internal abstract class TypeNames.ATypeName : TypeName, IEquatable<TypeName> // TypeDefIndex: 409
{
	// Properties
	public abstract string DisplayName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_DisplayName();

	// RVA: 0x1C0D020 Offset: 0x1C0D121 VA: 0x1C0D020 Slot: 5
	public bool Equals(TypeName other) { }

	// RVA: 0x1C0D100 Offset: 0x1C0D201 VA: 0x1C0D100 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C0D130 Offset: 0x1C0D231 VA: 0x1C0D130 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1C0CF90 Offset: 0x1C0D091 VA: 0x1C0CF90
	protected void .ctor() { }
}

