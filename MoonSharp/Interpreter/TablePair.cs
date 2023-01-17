// Namespace: MoonSharp.Interpreter
public struct TablePair // TypeDefIndex: 5949
{
	// Fields
	private static TablePair s_NilNode; // 0x0
	private DynValue key; // 0x0
	private DynValue value; // 0x8

	// Properties
	public DynValue Key { get; set; }
	public DynValue Value { get; set; }
	public static TablePair Nil { get; }

	// Methods

	// RVA: 0x3348950 Offset: 0x3348A51 VA: 0x3348950
	public DynValue get_Key() { }

	// RVA: 0x3348960 Offset: 0x3348A61 VA: 0x3348960
	private void set_Key(DynValue value) { }

	// RVA: 0x3348970 Offset: 0x3348A71 VA: 0x3348970
	public DynValue get_Value() { }

	// RVA: 0x3348980 Offset: 0x3348A81 VA: 0x3348980
	public void set_Value(DynValue value) { }

	// RVA: 0x33489B0 Offset: 0x3348AB1 VA: 0x33489B0
	public void .ctor(DynValue key, DynValue val) { }

	// RVA: 0x33489F0 Offset: 0x3348AF1 VA: 0x33489F0
	public static TablePair get_Nil() { }

	// RVA: 0x3348A60 Offset: 0x3348B61 VA: 0x3348A60
	private static void .cctor() { }
}

