// Namespace: MoonSharp.Interpreter
public class SymbolRef // TypeDefIndex: 5945
{
	// Fields
	private static SymbolRef s_DefaultEnv; // 0x0
	internal SymbolRefType i_Type; // 0x10
	internal SymbolRef i_Env; // 0x18
	internal int i_Index; // 0x20
	internal string i_Name; // 0x28

	// Properties
	public SymbolRefType Type { get; }
	public int Index { get; }
	public string Name { get; }
	public SymbolRef Environment { get; }
	public static SymbolRef DefaultEnv { get; }

	// Methods

	// RVA: 0x30294D0 Offset: 0x30295D1 VA: 0x30294D0
	public SymbolRefType get_Type() { }

	// RVA: 0x30294E0 Offset: 0x30295E1 VA: 0x30294E0
	public int get_Index() { }

	// RVA: 0x30294F0 Offset: 0x30295F1 VA: 0x30294F0
	public string get_Name() { }

	// RVA: 0x3029500 Offset: 0x3029601 VA: 0x3029500
	public SymbolRef get_Environment() { }

	// RVA: 0x3029510 Offset: 0x3029611 VA: 0x3029510
	public static SymbolRef get_DefaultEnv() { }

	// RVA: 0x3029580 Offset: 0x3029681 VA: 0x3029580
	public static SymbolRef Global(string name, SymbolRef envSymbol) { }

	// RVA: 0x3029620 Offset: 0x3029721 VA: 0x3029620
	internal static SymbolRef Local(string name, int index) { }

	// RVA: 0x3018B10 Offset: 0x3018C11 VA: 0x3018B10
	internal static SymbolRef Upvalue(string name, int index) { }

	// RVA: 0x30296A0 Offset: 0x30297A1 VA: 0x30296A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x30297D0 Offset: 0x30298D1 VA: 0x30297D0
	internal void WriteBinary(BinaryWriter bw) { }

	// RVA: 0x3029830 Offset: 0x3029931 VA: 0x3029830
	internal static SymbolRef ReadBinary(BinaryReader br) { }

	// RVA: 0x30298F0 Offset: 0x30299F1 VA: 0x30298F0
	internal void WriteBinaryEnv(BinaryWriter bw, Dictionary<SymbolRef, int> symbolMap) { }

	// RVA: 0x3029980 Offset: 0x3029A81 VA: 0x3029980
	internal void ReadBinaryEnv(BinaryReader br, SymbolRef[] symbolRefs) { }

	// RVA: 0x3018BA0 Offset: 0x3018CA1 VA: 0x3018BA0
	public void .ctor() { }

	// RVA: 0x30299F0 Offset: 0x3029AF1 VA: 0x30299F0
	private static void .cctor() { }
}

