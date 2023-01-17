// Namespace: MoonSharp.VsCodeDebugger.DebuggerLogic
internal interface IAsyncDebuggerClient // TypeDefIndex: 6309
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SendStopEvent();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnWatchesUpdated(WatchType watchType);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnSourceCodeChanged(int sourceID);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnExecutionEnded();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnException(ScriptRuntimeException ex);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Unbind();
}

