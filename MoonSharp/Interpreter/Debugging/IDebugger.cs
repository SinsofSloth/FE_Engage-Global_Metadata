// Namespace: MoonSharp.Interpreter.Debugging
public interface IDebugger // TypeDefIndex: 6214
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract DebuggerCaps GetDebuggerCaps();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetDebugService(DebugService debugService);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetSourceCode(SourceCode sourceCode);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetByteCode(string[] byteCode);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsPauseRequested();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool SignalRuntimeException(ScriptRuntimeException ex);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract DebuggerAction GetAction(int ip, SourceRef sourceref);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SignalExecutionEnded();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Update(WatchType watchType, IEnumerable<WatchItem> items);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract List<DynamicExpression> GetWatchItems();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void RefreshBreakpoints(IEnumerable<SourceRef> refs);
}

