// Namespace: MoonSharp.Interpreter.Execution.VM
internal class Instruction // TypeDefIndex: 6191
{
	// Fields
	internal OpCode OpCode; // 0x10
	internal SymbolRef Symbol; // 0x18
	internal SymbolRef[] SymbolList; // 0x20
	internal string Name; // 0x28
	internal DynValue Value; // 0x30
	internal int NumVal; // 0x38
	internal int NumVal2; // 0x3C
	internal SourceRef SourceCodeRef; // 0x40

	// Methods

	// RVA: 0x3317930 Offset: 0x3317A31 VA: 0x3317930
	internal void .ctor(SourceRef sourceref) { }

	// RVA: 0x3317970 Offset: 0x3317A71 VA: 0x3317970 Slot: 3
	public override string ToString() { }

	// RVA: 0x3317F00 Offset: 0x3318001 VA: 0x3317F00
	private string PurifyFromNewLines(DynValue Value) { }

	// RVA: 0x3317E60 Offset: 0x3317F61 VA: 0x3317E60
	private string GenSpaces() { }

	// RVA: 0x3317F90 Offset: 0x3318091 VA: 0x3317F90
	internal void WriteBinary(BinaryWriter wr, int baseAddress, Dictionary<SymbolRef, int> symbolMap) { }

	// RVA: 0x3318370 Offset: 0x3318471 VA: 0x3318370
	private static void WriteSymbol(BinaryWriter wr, SymbolRef symbolRef, Dictionary<SymbolRef, int> symbolMap) { }

	// RVA: 0x3318400 Offset: 0x3318501 VA: 0x3318400
	private static SymbolRef ReadSymbol(BinaryReader rd, SymbolRef[] deserializedSymbols) { }

	// RVA: 0x3318460 Offset: 0x3318561 VA: 0x3318460
	internal static Instruction ReadBinary(SourceRef chunkRef, BinaryReader rd, int baseAddress, Table envTable, SymbolRef[] deserializedSymbols) { }

	// RVA: 0x3318740 Offset: 0x3318841 VA: 0x3318740
	private static DynValue ReadValue(BinaryReader rd, Table envTable) { }

	// RVA: 0x33181F0 Offset: 0x33182F1 VA: 0x33181F0
	private void DumpValue(BinaryWriter wr, DynValue value) { }

	// RVA: 0x3318A50 Offset: 0x3318B51 VA: 0x3318A50
	internal void GetSymbolReferences(out SymbolRef[] symbolList, out SymbolRef symbol) { }
}

