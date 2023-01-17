// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryAssembly // TypeDefIndex: 1034
{
	// Fields
	internal int assemId; // 0x10
	internal string assemblyString; // 0x18

	// Methods

	// RVA: 0x3503D60 Offset: 0x3503E61 VA: 0x3503D60
	internal void .ctor() { }

	// RVA: 0x3503D70 Offset: 0x3503E71 VA: 0x3503D70
	internal void Set(int assemId, string assemblyString) { }

	// RVA: 0x3503D80 Offset: 0x3503E81 VA: 0x3503D80 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x3503DD0 Offset: 0x3503ED1 VA: 0x3503DD0 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3503E20 Offset: 0x3503F21 VA: 0x3503E20
	public void Dump() { }
}

