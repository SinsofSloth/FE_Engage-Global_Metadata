// Namespace: MoonSharp.VsCodeDebugger
public class MoonSharpVsCodeDebugServer : IDisposable // TypeDefIndex: 6274
{
	// Fields
	private object m_Lock; // 0x10
	private List<AsyncDebugger> m_DebuggerList; // 0x18
	private AsyncDebugger m_Current; // 0x20
	private ManualResetEvent m_StopEvent; // 0x28
	private bool m_Started; // 0x30
	private int m_Port; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0xEE20 Offset: 0xEF21 VA: 0xEE20
	private Action<string> <Logger>k__BackingField; // 0x38

	// Properties
	public Nullable<int> CurrentId { get; set; }
	public Script Current { get; set; }
	public Action<string> Logger { get; set; }

	// Methods

	// RVA: 0x2BBE840 Offset: 0x2BBE941 VA: 0x2BBE840
	public void .ctor(int port = 41912) { }

	[ObsoleteAttribute] // RVA: 0x11EC0 Offset: 0x11FC1 VA: 0x11EC0
	// RVA: 0x2BBE960 Offset: 0x2BBEA61 VA: 0x2BBE960
	public void .ctor(Script script, int port, Func<SourceCode, string> sourceFinder) { }

	// RVA: 0x2BBEBD0 Offset: 0x2BBECD1 VA: 0x2BBEBD0
	public void AttachToScript(Script script, string name, Func<SourceCode, string> sourceFinder) { }

	// RVA: 0x2BBC450 Offset: 0x2BBC551 VA: 0x2BBC450
	public IEnumerable<KeyValuePair<int, string>> GetAttachedDebuggersByIdAndName() { }

	// RVA: 0x2BBC330 Offset: 0x2BBC431 VA: 0x2BBC330
	public Nullable<int> get_CurrentId() { }

	// RVA: 0x2BBC770 Offset: 0x2BBC871 VA: 0x2BBC770
	public void set_CurrentId(Nullable<int> value) { }

	// RVA: 0x2BBEF60 Offset: 0x2BBF061 VA: 0x2BBEF60
	public Script get_Current() { }

	// RVA: 0x2BBF040 Offset: 0x2BBF141 VA: 0x2BBF040
	public void set_Current(Script value) { }

	// RVA: 0x2BBF270 Offset: 0x2BBF371 VA: 0x2BBF270
	public void Detach(Script script) { }

	[CompilerGeneratedAttribute] // RVA: 0x11F00 Offset: 0x12001 VA: 0x11F00
	// RVA: 0x2BBF510 Offset: 0x2BBF611 VA: 0x2BBF510
	public Action<string> get_Logger() { }

	[CompilerGeneratedAttribute] // RVA: 0x11F10 Offset: 0x12011 VA: 0x11F10
	// RVA: 0x2BBF520 Offset: 0x2BBF621 VA: 0x2BBF520
	public void set_Logger(Action<string> value) { }

	[ObsoleteAttribute] // RVA: 0x11F20 Offset: 0x12021 VA: 0x11F20
	// RVA: 0x2BBF530 Offset: 0x2BBF631 VA: 0x2BBF530
	public IDebugger GetDebugger() { }

	// RVA: 0x2BBF600 Offset: 0x2BBF701 VA: 0x2BBF600 Slot: 4
	public void Dispose() { }

	// RVA: 0x2BBF610 Offset: 0x2BBF711 VA: 0x2BBF610
	public MoonSharpVsCodeDebugServer Start() { }

	// RVA: 0x2BBFA20 Offset: 0x2BBFB21 VA: 0x2BBFA20
	private void ListenThread(TcpListener serverSocket) { }

	// RVA: 0x2BBFFC0 Offset: 0x2BC00C1 VA: 0x2BBFFC0
	private void RunSession(string sessionId, NetworkStream stream) { }

	// RVA: 0x2BBFF30 Offset: 0x2BC0031 VA: 0x2BBFF30
	private void Log(string format, object[] args) { }

	// RVA: 0x2BBF900 Offset: 0x2BBFA01 VA: 0x2BBF900
	private static void SpawnThread(string name, Action threadProc) { }
}

