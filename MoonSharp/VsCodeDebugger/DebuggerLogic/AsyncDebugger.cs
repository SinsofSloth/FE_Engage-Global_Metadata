// Namespace: MoonSharp.VsCodeDebugger.DebuggerLogic
internal class AsyncDebugger : IDebugger // TypeDefIndex: 6307
{
	// Fields
	private static object s_AsyncDebuggerIdLock; // 0x0
	private static int s_AsyncDebuggerIdCounter; // 0x8
	private object m_Lock; // 0x10
	private IAsyncDebuggerClient m_Client__; // 0x18
	private DebuggerAction m_PendingAction; // 0x20
	private List<WatchItem>[] m_WatchItems; // 0x28
	private Dictionary<int, SourceCode> m_SourcesMap; // 0x30
	private Dictionary<int, string> m_SourcesOverride; // 0x38
	private Func<SourceCode, string> m_SourceFinder; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0xF0D0 Offset: 0xF1D1 VA: 0xF0D0
	private DebugService <DebugService>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0xF0E0 Offset: 0xF1E1 VA: 0xF0E0
	private Regex <ErrorRegex>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0xF0F0 Offset: 0xF1F1 VA: 0xF0F0
	private Script <Script>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0xF100 Offset: 0xF201 VA: 0xF100
	private bool <PauseRequested>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0xF110 Offset: 0xF211 VA: 0xF110
	private string <Name>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0xF120 Offset: 0xF221 VA: 0xF120
	private int <Id>k__BackingField; // 0x70

	// Properties
	public DebugService DebugService { get; set; }
	public Regex ErrorRegex { get; set; }
	public Script Script { get; set; }
	public bool PauseRequested { get; set; }
	public string Name { get; set; }
	public int Id { get; set; }
	public IAsyncDebuggerClient Client { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x124A0 Offset: 0x125A1 VA: 0x124A0
	// RVA: 0x30E79D0 Offset: 0x30E7AD1 VA: 0x30E79D0
	public DebugService get_DebugService() { }

	[CompilerGeneratedAttribute] // RVA: 0x124B0 Offset: 0x125B1 VA: 0x124B0
	// RVA: 0x30E79E0 Offset: 0x30E7AE1 VA: 0x30E79E0
	private void set_DebugService(DebugService value) { }

	[CompilerGeneratedAttribute] // RVA: 0x124C0 Offset: 0x125C1 VA: 0x124C0
	// RVA: 0x30E79F0 Offset: 0x30E7AF1 VA: 0x30E79F0
	public Regex get_ErrorRegex() { }

	[CompilerGeneratedAttribute] // RVA: 0x124D0 Offset: 0x125D1 VA: 0x124D0
	// RVA: 0x30E7A00 Offset: 0x30E7B01 VA: 0x30E7A00
	public void set_ErrorRegex(Regex value) { }

	[CompilerGeneratedAttribute] // RVA: 0x124E0 Offset: 0x125E1 VA: 0x124E0
	// RVA: 0x30E7A10 Offset: 0x30E7B11 VA: 0x30E7A10
	public Script get_Script() { }

	[CompilerGeneratedAttribute] // RVA: 0x124F0 Offset: 0x125F1 VA: 0x124F0
	// RVA: 0x30E7A20 Offset: 0x30E7B21 VA: 0x30E7A20
	private void set_Script(Script value) { }

	[CompilerGeneratedAttribute] // RVA: 0x12500 Offset: 0x12601 VA: 0x12500
	// RVA: 0x30E7A30 Offset: 0x30E7B31 VA: 0x30E7A30
	public bool get_PauseRequested() { }

	[CompilerGeneratedAttribute] // RVA: 0x12510 Offset: 0x12611 VA: 0x12510
	// RVA: 0x30E7A40 Offset: 0x30E7B41 VA: 0x30E7A40
	public void set_PauseRequested(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x12520 Offset: 0x12621 VA: 0x12520
	// RVA: 0x30E7A50 Offset: 0x30E7B51 VA: 0x30E7A50
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x12530 Offset: 0x12631 VA: 0x12530
	// RVA: 0x30E7A60 Offset: 0x30E7B61 VA: 0x30E7A60
	public void set_Name(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x12540 Offset: 0x12641 VA: 0x12540
	// RVA: 0x30E7A70 Offset: 0x30E7B71 VA: 0x30E7A70
	public int get_Id() { }

	[CompilerGeneratedAttribute] // RVA: 0x12550 Offset: 0x12651 VA: 0x12550
	// RVA: 0x30E7A80 Offset: 0x30E7B81 VA: 0x30E7A80
	private void set_Id(int value) { }

	// RVA: 0x30E7A90 Offset: 0x30E7B91 VA: 0x30E7A90
	public void .ctor(Script script, Func<SourceCode, string> sourceFinder, string name) { }

	// RVA: 0x30E7E50 Offset: 0x30E7F51 VA: 0x30E7E50
	public IAsyncDebuggerClient get_Client() { }

	// RVA: 0x30E7E60 Offset: 0x30E7F61 VA: 0x30E7E60
	public void set_Client(IAsyncDebuggerClient value) { }

	// RVA: 0x30E80B0 Offset: 0x30E81B1 VA: 0x30E80B0 Slot: 10
	private DebuggerAction MoonSharp.Interpreter.Debugging.IDebugger.GetAction(int ip, SourceRef sourceref) { }

	// RVA: 0x30E8460 Offset: 0x30E8561 VA: 0x30E8460
	public void QueueAction(DebuggerAction action) { }

	// RVA: 0x30E8450 Offset: 0x30E8551 VA: 0x30E8450
	private void Sleep(int v) { }

	// RVA: 0x30E85A0 Offset: 0x30E86A1 VA: 0x30E85A0
	private DynamicExpression CreateDynExpr(string code) { }

	// RVA: 0x30E86C0 Offset: 0x30E87C1 VA: 0x30E86C0 Slot: 13
	private List<DynamicExpression> MoonSharp.Interpreter.Debugging.IDebugger.GetWatchItems() { }

	// RVA: 0x30E8740 Offset: 0x30E8841 VA: 0x30E8740 Slot: 8
	private bool MoonSharp.Interpreter.Debugging.IDebugger.IsPauseRequested() { }

	// RVA: 0x30E8750 Offset: 0x30E8851 VA: 0x30E8750 Slot: 14
	private void MoonSharp.Interpreter.Debugging.IDebugger.RefreshBreakpoints(IEnumerable<SourceRef> refs) { }

	// RVA: 0x30E8760 Offset: 0x30E8861 VA: 0x30E8760 Slot: 7
	private void MoonSharp.Interpreter.Debugging.IDebugger.SetByteCode(string[] byteCode) { }

	// RVA: 0x30E8770 Offset: 0x30E8871 VA: 0x30E8770 Slot: 6
	private void MoonSharp.Interpreter.Debugging.IDebugger.SetSourceCode(SourceCode sourceCode) { }

	// RVA: 0x30E8B20 Offset: 0x30E8C21 VA: 0x30E8B20
	private string GetFooterForTempFile() { }

	// RVA: 0x30E8B70 Offset: 0x30E8C71 VA: 0x30E8B70
	public string GetSourceFile(int sourceId) { }

	// RVA: 0x30E8C70 Offset: 0x30E8D71 VA: 0x30E8C70
	public bool IsSourceOverride(int sourceId) { }

	// RVA: 0x30E8CD0 Offset: 0x30E8DD1 VA: 0x30E8CD0 Slot: 11
	private void MoonSharp.Interpreter.Debugging.IDebugger.SignalExecutionEnded() { }

	// RVA: 0x30E8E30 Offset: 0x30E8F31 VA: 0x30E8E30 Slot: 9
	private bool MoonSharp.Interpreter.Debugging.IDebugger.SignalRuntimeException(ScriptRuntimeException ex) { }

	// RVA: 0x30E8FF0 Offset: 0x30E90F1 VA: 0x30E8FF0 Slot: 12
	private void MoonSharp.Interpreter.Debugging.IDebugger.Update(WatchType watchType, IEnumerable<WatchItem> items) { }

	// RVA: 0x30E91D0 Offset: 0x30E92D1 VA: 0x30E91D0
	public List<WatchItem> GetWatches(WatchType watchType) { }

	// RVA: 0x30E9210 Offset: 0x30E9311 VA: 0x30E9210
	public SourceCode GetSource(int id) { }

	// RVA: 0x30E92B0 Offset: 0x30E93B1 VA: 0x30E92B0
	public SourceCode FindSourceByName(string path) { }

	// RVA: 0x30E95A0 Offset: 0x30E96A1 VA: 0x30E95A0 Slot: 5
	private void MoonSharp.Interpreter.Debugging.IDebugger.SetDebugService(DebugService debugService) { }

	// RVA: 0x30E95B0 Offset: 0x30E96B1 VA: 0x30E95B0
	public DynValue Evaluate(string expression) { }

	// RVA: 0x30E95D0 Offset: 0x30E96D1 VA: 0x30E95D0 Slot: 4
	private DebuggerCaps MoonSharp.Interpreter.Debugging.IDebugger.GetDebuggerCaps() { }

	// RVA: 0x30E95E0 Offset: 0x30E96E1 VA: 0x30E95E0
	private static void .cctor() { }
}

