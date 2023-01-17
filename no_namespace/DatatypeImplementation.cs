// Namespace: 
private class DatatypeImplementation.SchemaDatatypeMap : IComparable // TypeDefIndex: 1836
{
	// Fields
	private string name; // 0x10
	private DatatypeImplementation type; // 0x18
	private int parentIndex; // 0x20

	// Properties
	public string Name { get; }
	public int ParentIndex { get; }

	// Methods

	// RVA: 0x19A1DC0 Offset: 0x19A1EC1 VA: 0x19A1DC0
	internal void .ctor(string name, DatatypeImplementation type) { }

	// RVA: 0x19A1E10 Offset: 0x19A1F11 VA: 0x19A1E10
	internal void .ctor(string name, DatatypeImplementation type, int parentIndex) { }

	// RVA: 0x19A1E70 Offset: 0x19A1F71 VA: 0x19A1E70
	public static DatatypeImplementation op_Explicit(DatatypeImplementation.SchemaDatatypeMap sdm) { }

	// RVA: 0x19A1E80 Offset: 0x19A1F81 VA: 0x19A1E80
	public string get_Name() { }

	// RVA: 0x19A1E90 Offset: 0x19A1F91 VA: 0x19A1E90
	public int get_ParentIndex() { }

	// RVA: 0x19A1EA0 Offset: 0x19A1FA1 VA: 0x19A1EA0 Slot: 4
	public int CompareTo(object obj) { }
}

