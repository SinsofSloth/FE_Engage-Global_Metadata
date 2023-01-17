// Namespace: 
private class TypeIdentifiers.Display : TypeNames.ATypeName, TypeIdentifier, TypeName, IEquatable<TypeName> // TypeDefIndex: 411
{
	// Fields
	private string displayName; // 0x10
	private string internal_name; // 0x18

	// Properties
	public override string DisplayName { get; }
	public string InternalName { get; }

	// Methods

	// RVA: 0x1C0CF40 Offset: 0x1C0D041 VA: 0x1C0CF40
	internal void .ctor(string displayName) { }

	// RVA: 0x1C0CFA0 Offset: 0x1C0D0A1 VA: 0x1C0CFA0 Slot: 6
	public override string get_DisplayName() { }

	// RVA: 0x1C0CFB0 Offset: 0x1C0D0B1 VA: 0x1C0CFB0 Slot: 7
	public string get_InternalName() { }

	// RVA: 0x1C0D010 Offset: 0x1C0D111 VA: 0x1C0D010
	private string GetInternalName() { }
}

