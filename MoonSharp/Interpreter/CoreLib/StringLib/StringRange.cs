// Namespace: MoonSharp.Interpreter.CoreLib.StringLib
internal class StringRange // TypeDefIndex: 6252
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xEE00 Offset: 0xEF01 VA: 0xEE00
	private int <Start>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xEE10 Offset: 0xEF11 VA: 0xEE10
	private int <End>k__BackingField; // 0x14

	// Properties
	public int Start { get; set; }
	public int End { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x11E80 Offset: 0x11F81 VA: 0x11E80
	// RVA: 0x3029410 Offset: 0x3029511 VA: 0x3029410
	public int get_Start() { }

	[CompilerGeneratedAttribute] // RVA: 0x11E90 Offset: 0x11F91 VA: 0x11E90
	// RVA: 0x3029420 Offset: 0x3029521 VA: 0x3029420
	public void set_Start(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x11EA0 Offset: 0x11FA1 VA: 0x11EA0
	// RVA: 0x3029430 Offset: 0x3029531 VA: 0x3029430
	public int get_End() { }

	[CompilerGeneratedAttribute] // RVA: 0x11EB0 Offset: 0x11FB1 VA: 0x11EB0
	// RVA: 0x3029440 Offset: 0x3029541 VA: 0x3029440
	public void set_End(int value) { }

	// RVA: 0x3029450 Offset: 0x3029551 VA: 0x3029450
	public void .ctor() { }

	// RVA: 0x3029480 Offset: 0x3029581 VA: 0x3029480
	public void .ctor(int start, int end) { }

	// RVA: 0x30284E0 Offset: 0x30285E1 VA: 0x30284E0
	public static StringRange FromLuaRange(DynValue start, DynValue end, Nullable<int> defaultEnd) { }

	// RVA: 0x30285E0 Offset: 0x30286E1 VA: 0x30285E0
	public string ApplyToString(string value) { }

	// RVA: 0x30294C0 Offset: 0x30295C1 VA: 0x30294C0
	public int Length() { }
}

