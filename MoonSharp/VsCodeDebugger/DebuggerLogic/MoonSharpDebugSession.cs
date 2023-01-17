// Namespace: MoonSharp.VsCodeDebugger.DebuggerLogic
internal class MoonSharpDebugSession : DebugSession, IAsyncDebuggerClient // TypeDefIndex: 6310
{
	// Fields
	private AsyncDebugger m_Debug; // 0x38
	private MoonSharpVsCodeDebugServer m_Server; // 0x40
	private List<DynValue> m_Variables; // 0x48
	private bool m_NotifyExecutionEnd; // 0x50
	private const int SCOPE_LOCALS = 65536;
	private const int SCOPE_SELF = 65537;
	private readonly SourceRef DefaultSourceRef; // 0x58

	// Methods

	// RVA: 0x2BBA270 Offset: 0x2BBA371 VA: 0x2BBA270
	internal void .ctor(MoonSharpVsCodeDebugServer server, AsyncDebugger debugger) { }

	// RVA: 0x2BBA390 Offset: 0x2BBA491 VA: 0x2BBA390 Slot: 5
	public override void Initialize(Response response, Table args) { }

	// RVA: 0x2BBA9A0 Offset: 0x2BBAAA1 VA: 0x2BBA9A0 Slot: 7
	public override void Attach(Response response, Table arguments) { }

	// RVA: 0x2BBA9B0 Offset: 0x2BBAAB1 VA: 0x2BBA9B0 Slot: 12
	public override void Continue(Response response, Table arguments) { }

	// RVA: 0x2BBAA40 Offset: 0x2BBAB41 VA: 0x2BBAA40 Slot: 8
	public override void Disconnect(Response response, Table arguments) { }

	// RVA: 0x2BBAA80 Offset: 0x2BBAB81 VA: 0x2BBAA80
	private static string getString(Table args, string property, string dflt) { }

	// RVA: 0x2BBAB30 Offset: 0x2BBAC31 VA: 0x2BBAB30 Slot: 22
	public override void Evaluate(Response response, Table args) { }

	// RVA: 0x2BBB0B0 Offset: 0x2BBB1B1 VA: 0x2BBB0B0
	private void ExecuteRepl(string cmd) { }

	// RVA: 0x2BBCB70 Offset: 0x2BBCC71 VA: 0x2BBCB70 Slot: 6
	public override void Launch(Response response, Table arguments) { }

	// RVA: 0x2BBCB80 Offset: 0x2BBCC81 VA: 0x2BBCB80 Slot: 13
	public override void Next(Response response, Table arguments) { }

	// RVA: 0x2BBCC10 Offset: 0x2BBCD11 VA: 0x2BBCC10
	private StoppedEvent CreateStoppedEvent(string reason, string text) { }

	// RVA: 0x2BBCC90 Offset: 0x2BBCD91 VA: 0x2BBCC90 Slot: 16
	public override void Pause(Response response, Table arguments) { }

	// RVA: 0x2BBCDA0 Offset: 0x2BBCEA1 VA: 0x2BBCDA0 Slot: 18
	public override void Scopes(Response response, Table arguments) { }

	// RVA: 0x2BBCF20 Offset: 0x2BBD021 VA: 0x2BBCF20 Slot: 11
	public override void SetBreakpoints(Response response, Table args) { }

	// RVA: 0x2BBD3E0 Offset: 0x2BBD4E1 VA: 0x2BBD3E0 Slot: 17
	public override void StackTrace(Response response, Table args) { }

	// RVA: 0x2BBB020 Offset: 0x2BBB121 VA: 0x2BBB020
	private int getInt(Table args, string propName, int defaultValue) { }

	// RVA: 0x2BBD960 Offset: 0x2BBDA61 VA: 0x2BBD960 Slot: 14
	public override void StepIn(Response response, Table arguments) { }

	// RVA: 0x2BBD9F0 Offset: 0x2BBDAF1 VA: 0x2BBD9F0 Slot: 15
	public override void StepOut(Response response, Table arguments) { }

	// RVA: 0x2BBDA80 Offset: 0x2BBDB81 VA: 0x2BBDA80 Slot: 21
	public override void Threads(Response response, Table arguments) { }

	// RVA: 0x2BBDBC0 Offset: 0x2BBDCC1 VA: 0x2BBDBC0 Slot: 19
	public override void Variables(Response response, Table arguments) { }

	// RVA: 0x2BBE000 Offset: 0x2BBE101 VA: 0x2BBE000 Slot: 23
	private void MoonSharp.VsCodeDebugger.DebuggerLogic.IAsyncDebuggerClient.SendStopEvent() { }

	// RVA: 0x2BBE0B0 Offset: 0x2BBE1B1 VA: 0x2BBE0B0 Slot: 24
	private void MoonSharp.VsCodeDebugger.DebuggerLogic.IAsyncDebuggerClient.OnWatchesUpdated(WatchType watchType) { }

	// RVA: 0x2BBE120 Offset: 0x2BBE221 VA: 0x2BBE120 Slot: 25
	private void MoonSharp.VsCodeDebugger.DebuggerLogic.IAsyncDebuggerClient.OnSourceCodeChanged(int sourceID) { }

	// RVA: 0x2BBE2C0 Offset: 0x2BBE3C1 VA: 0x2BBE2C0 Slot: 26
	public void OnExecutionEnded() { }

	// RVA: 0x2BBA850 Offset: 0x2BBA951 VA: 0x2BBA850
	private void SendText(string msg, object[] args) { }

	// RVA: 0x2BBE490 Offset: 0x2BBE591 VA: 0x2BBE490 Slot: 27
	public void OnException(ScriptRuntimeException ex) { }

	// RVA: 0x2BBC9A0 Offset: 0x2BBCAA1 VA: 0x2BBC9A0 Slot: 28
	public void Unbind() { }

	[CompilerGeneratedAttribute] // RVA: 0x12560 Offset: 0x12661 VA: 0x12560
	// RVA: 0x2BBE560 Offset: 0x2BBE661 VA: 0x2BBE560
	private int <SetBreakpoints>b__19_0(DynValue jt) { }
}

