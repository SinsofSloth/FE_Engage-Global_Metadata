// Namespace: MoonSharp.Interpreter
public class ScriptOptions // TypeDefIndex: 5988
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0xE490 Offset: 0xE591 VA: 0xE490
	private IScriptLoader <ScriptLoader>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xE4A0 Offset: 0xE5A1 VA: 0xE4A0
	private Action<string> <DebugPrint>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE4B0 Offset: 0xE5B1 VA: 0xE4B0
	private Func<string, string> <DebugInput>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xE4C0 Offset: 0xE5C1 VA: 0xE4C0
	private bool <UseLuaErrorLocations>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0xE4D0 Offset: 0xE5D1 VA: 0xE4D0
	private ColonOperatorBehaviour <ColonOperatorClrCallbackBehaviour>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0xE4E0 Offset: 0xE5E1 VA: 0xE4E0
	private Stream <Stdin>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0xE4F0 Offset: 0xE5F1 VA: 0xE4F0
	private Stream <Stdout>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xE500 Offset: 0xE601 VA: 0xE500
	private Stream <Stderr>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0xE510 Offset: 0xE611 VA: 0xE510
	private int <TailCallOptimizationThreshold>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0xE520 Offset: 0xE621 VA: 0xE520
	private bool <CheckThreadAccess>k__BackingField; // 0x4C

	// Properties
	public IScriptLoader ScriptLoader { get; set; }
	public Action<string> DebugPrint { get; set; }
	public Func<string, string> DebugInput { get; set; }
	public bool UseLuaErrorLocations { get; set; }
	public ColonOperatorBehaviour ColonOperatorClrCallbackBehaviour { get; set; }
	public Stream Stdin { get; set; }
	public Stream Stdout { get; set; }
	public Stream Stderr { get; set; }
	public int TailCallOptimizationThreshold { get; set; }
	public bool CheckThreadAccess { get; set; }

	// Methods

	// RVA: 0x30166E0 Offset: 0x30167E1 VA: 0x30166E0
	internal void .ctor() { }

	// RVA: 0x3016A40 Offset: 0x3016B41 VA: 0x3016A40
	internal void .ctor(ScriptOptions defaults) { }

	[CompilerGeneratedAttribute] // RVA: 0xFE20 Offset: 0xFF21 VA: 0xFE20
	// RVA: 0x301B1C0 Offset: 0x301B2C1 VA: 0x301B1C0
	public IScriptLoader get_ScriptLoader() { }

	[CompilerGeneratedAttribute] // RVA: 0xFE30 Offset: 0xFF31 VA: 0xFE30
	// RVA: 0x301B1D0 Offset: 0x301B2D1 VA: 0x301B1D0
	public void set_ScriptLoader(IScriptLoader value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFE40 Offset: 0xFF41 VA: 0xFE40
	// RVA: 0x301B1E0 Offset: 0x301B2E1 VA: 0x301B1E0
	public Action<string> get_DebugPrint() { }

	[CompilerGeneratedAttribute] // RVA: 0xFE50 Offset: 0xFF51 VA: 0xFE50
	// RVA: 0x301B1F0 Offset: 0x301B2F1 VA: 0x301B1F0
	public void set_DebugPrint(Action<string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFE60 Offset: 0xFF61 VA: 0xFE60
	// RVA: 0x301B200 Offset: 0x301B301 VA: 0x301B200
	public Func<string, string> get_DebugInput() { }

	[CompilerGeneratedAttribute] // RVA: 0xFE70 Offset: 0xFF71 VA: 0xFE70
	// RVA: 0x301B210 Offset: 0x301B311 VA: 0x301B210
	public void set_DebugInput(Func<string, string> value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFE80 Offset: 0xFF81 VA: 0xFE80
	// RVA: 0x301B220 Offset: 0x301B321 VA: 0x301B220
	public bool get_UseLuaErrorLocations() { }

	[CompilerGeneratedAttribute] // RVA: 0xFE90 Offset: 0xFF91 VA: 0xFE90
	// RVA: 0x301B230 Offset: 0x301B331 VA: 0x301B230
	public void set_UseLuaErrorLocations(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFEA0 Offset: 0xFFA1 VA: 0xFEA0
	// RVA: 0x301B240 Offset: 0x301B341 VA: 0x301B240
	public ColonOperatorBehaviour get_ColonOperatorClrCallbackBehaviour() { }

	[CompilerGeneratedAttribute] // RVA: 0xFEB0 Offset: 0xFFB1 VA: 0xFEB0
	// RVA: 0x301B250 Offset: 0x301B351 VA: 0x301B250
	public void set_ColonOperatorClrCallbackBehaviour(ColonOperatorBehaviour value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFEC0 Offset: 0xFFC1 VA: 0xFEC0
	// RVA: 0x301B260 Offset: 0x301B361 VA: 0x301B260
	public Stream get_Stdin() { }

	[CompilerGeneratedAttribute] // RVA: 0xFED0 Offset: 0xFFD1 VA: 0xFED0
	// RVA: 0x301B270 Offset: 0x301B371 VA: 0x301B270
	public void set_Stdin(Stream value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFEE0 Offset: 0xFFE1 VA: 0xFEE0
	// RVA: 0x301B280 Offset: 0x301B381 VA: 0x301B280
	public Stream get_Stdout() { }

	[CompilerGeneratedAttribute] // RVA: 0xFEF0 Offset: 0xFFF1 VA: 0xFEF0
	// RVA: 0x301B290 Offset: 0x301B391 VA: 0x301B290
	public void set_Stdout(Stream value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFF00 Offset: 0x10001 VA: 0xFF00
	// RVA: 0x301B2A0 Offset: 0x301B3A1 VA: 0x301B2A0
	public Stream get_Stderr() { }

	[CompilerGeneratedAttribute] // RVA: 0xFF10 Offset: 0x10011 VA: 0xFF10
	// RVA: 0x301B2B0 Offset: 0x301B3B1 VA: 0x301B2B0
	public void set_Stderr(Stream value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFF20 Offset: 0x10021 VA: 0xFF20
	// RVA: 0x301B2C0 Offset: 0x301B3C1 VA: 0x301B2C0
	public int get_TailCallOptimizationThreshold() { }

	[CompilerGeneratedAttribute] // RVA: 0xFF30 Offset: 0x10031 VA: 0xFF30
	// RVA: 0x301B2D0 Offset: 0x301B3D1 VA: 0x301B2D0
	public void set_TailCallOptimizationThreshold(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFF40 Offset: 0x10041 VA: 0xFF40
	// RVA: 0x301B2E0 Offset: 0x301B3E1 VA: 0x301B2E0
	public bool get_CheckThreadAccess() { }

	[CompilerGeneratedAttribute] // RVA: 0xFF50 Offset: 0x10051 VA: 0xFF50
	// RVA: 0x301B2F0 Offset: 0x301B3F1 VA: 0x301B2F0
	public void set_CheckThreadAccess(bool value) { }
}

