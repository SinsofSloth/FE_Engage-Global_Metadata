// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectMapInfo // TypeDefIndex: 1068
{
	// Fields
	internal int objectId; // 0x10
	private int numMembers; // 0x14
	private string[] memberNames; // 0x18
	private Type[] memberTypes; // 0x20

	// Methods

	// RVA: 0x38694D0 Offset: 0x38695D1 VA: 0x38694D0
	internal void .ctor(int objectId, int numMembers, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x3869510 Offset: 0x3869611 VA: 0x3869510
	internal bool isCompatible(int numMembers, string[] memberNames, Type[] memberTypes) { }
}

