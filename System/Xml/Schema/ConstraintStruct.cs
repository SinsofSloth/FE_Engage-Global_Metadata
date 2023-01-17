// Namespace: System.Xml.Schema
internal sealed class ConstraintStruct // TypeDefIndex: 1802
{
	// Fields
	internal CompiledIdentityConstraint constraint; // 0x10
	internal SelectorActiveAxis axisSelector; // 0x18
	internal ArrayList axisFields; // 0x20
	internal Hashtable qualifiedTable; // 0x28
	internal Hashtable keyrefTable; // 0x30
	private int tableDim; // 0x38

	// Properties
	internal int TableDim { get; }

	// Methods

	// RVA: 0x358BC50 Offset: 0x358BD51 VA: 0x358BC50
	internal int get_TableDim() { }

	// RVA: 0x358BC60 Offset: 0x358BD61 VA: 0x358BC60
	internal void .ctor(CompiledIdentityConstraint constraint) { }
}

