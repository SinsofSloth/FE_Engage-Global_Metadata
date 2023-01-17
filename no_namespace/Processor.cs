// Namespace: 
private class Processor.DebugContext // TypeDefIndex: 6194
{
	// Fields
	public bool DebuggerEnabled; // 0x10
	public IDebugger DebuggerAttached; // 0x18
	public DebuggerAction.ActionType DebuggerCurrentAction; // 0x20
	public int DebuggerCurrentActionTarget; // 0x24
	public SourceRef LastHlRef; // 0x28
	public int ExStackDepthAtStep; // 0x30
	public List<SourceRef> BreakPoints; // 0x38
	public bool LineBasedBreakPoints; // 0x40

	// Methods

	// RVA: 0x335E920 Offset: 0x335EA21 VA: 0x335E920
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0xDA00 Offset: 0xDB01 VA: 0xDA00
[Serializable]
private sealed class Processor.<>c // TypeDefIndex: 6195
{
	// Fields
	public static readonly Processor.<>c <>9; // 0x0
	public static Func<Processor, WatchItem> <>9__46_0; // 0x8

	// Methods

	// RVA: 0x335E7A0 Offset: 0x335E8A1 VA: 0x335E7A0
	private static void .cctor() { }

	// RVA: 0x335E810 Offset: 0x335E911 VA: 0x335E810
	public void .ctor() { }

	// RVA: 0x335E820 Offset: 0x335E921 VA: 0x335E820
	internal WatchItem <Debugger_RefreshThreads>b__46_0(Processor c) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0xDA10 Offset: 0xDB11 VA: 0xDA10
private sealed class Processor.<>c__DisplayClass48_0 // TypeDefIndex: 6196
{
	// Fields
	public Processor <>4__this; // 0x10
	public ScriptExecutionContext context; // 0x18

	// Methods

	// RVA: 0x335E8F0 Offset: 0x335E9F1 VA: 0x335E8F0
	public void .ctor() { }

	// RVA: 0x335E900 Offset: 0x335EA01 VA: 0x335E900
	internal WatchItem <Debugger_RefreshWatches>b__0(DynamicExpression w) { }
}

