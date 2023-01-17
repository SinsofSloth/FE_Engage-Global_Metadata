// Namespace: MoonSharp.Interpreter.Debugging
public sealed class DebugService : IScriptPrivateResource // TypeDefIndex: 6210
{
	// Fields
	private Processor m_Processor; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0xEC00 Offset: 0xED01 VA: 0xEC00
	private Script <OwnerScript>k__BackingField; // 0x18

	// Properties
	public Script OwnerScript { get; set; }

	// Methods

	// RVA: 0x30FD850 Offset: 0x30FD951 VA: 0x30FD850
	internal void .ctor(Script script, Processor processor) { }

	[CompilerGeneratedAttribute] // RVA: 0x11150 Offset: 0x11251 VA: 0x11150
	// RVA: 0x30FD8A0 Offset: 0x30FD9A1 VA: 0x30FD8A0 Slot: 4
	public Script get_OwnerScript() { }

	[CompilerGeneratedAttribute] // RVA: 0x11160 Offset: 0x11261 VA: 0x11160
	// RVA: 0x30FD8B0 Offset: 0x30FD9B1 VA: 0x30FD8B0
	private void set_OwnerScript(Script value) { }

	// RVA: 0x30FD8C0 Offset: 0x30FD9C1 VA: 0x30FD8C0
	public HashSet<int> ResetBreakPoints(SourceCode src, HashSet<int> lines) { }
}

