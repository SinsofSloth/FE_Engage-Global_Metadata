// Namespace: MoonSharp.Interpreter.REPL
public class ReplInterpreter // TypeDefIndex: 6040
{
	// Fields
	private Script m_Script; // 0x10
	private string m_CurrentCommand; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0xE620 Offset: 0xE721 VA: 0xE620
	private bool <HandleDynamicExprs>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0xE630 Offset: 0xE731 VA: 0xE630
	private bool <HandleClassicExprsSyntax>k__BackingField; // 0x21

	// Properties
	public bool HandleDynamicExprs { get; set; }
	public bool HandleClassicExprsSyntax { get; set; }
	public virtual bool HasPendingCommand { get; }
	public virtual string CurrentPendingCommand { get; }
	public virtual string ClassicPrompt { get; }

	// Methods

	// RVA: 0x30142C0 Offset: 0x30143C1 VA: 0x30142C0
	public void .ctor(Script script) { }

	[CompilerGeneratedAttribute] // RVA: 0x10190 Offset: 0x10291 VA: 0x10190
	// RVA: 0x3014940 Offset: 0x3014A41 VA: 0x3014940
	public bool get_HandleDynamicExprs() { }

	[CompilerGeneratedAttribute] // RVA: 0x101A0 Offset: 0x102A1 VA: 0x101A0
	// RVA: 0x3014950 Offset: 0x3014A51 VA: 0x3014950
	public void set_HandleDynamicExprs(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x101B0 Offset: 0x102B1 VA: 0x101B0
	// RVA: 0x3014960 Offset: 0x3014A61 VA: 0x3014960
	public bool get_HandleClassicExprsSyntax() { }

	[CompilerGeneratedAttribute] // RVA: 0x101C0 Offset: 0x102C1 VA: 0x101C0
	// RVA: 0x3014970 Offset: 0x3014A71 VA: 0x3014970
	public void set_HandleClassicExprsSyntax(bool value) { }

	// RVA: 0x3014980 Offset: 0x3014A81 VA: 0x3014980 Slot: 4
	public virtual bool get_HasPendingCommand() { }

	// RVA: 0x30149A0 Offset: 0x3014AA1 VA: 0x30149A0 Slot: 5
	public virtual string get_CurrentPendingCommand() { }

	// RVA: 0x30149B0 Offset: 0x3014AB1 VA: 0x30149B0 Slot: 6
	public virtual string get_ClassicPrompt() { }

	// RVA: 0x30143E0 Offset: 0x30144E1 VA: 0x30143E0 Slot: 7
	public virtual DynValue Evaluate(string input) { }
}

