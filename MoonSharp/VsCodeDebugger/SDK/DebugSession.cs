// Namespace: MoonSharp.VsCodeDebugger.SDK
public abstract class DebugSession : ProtocolServer // TypeDefIndex: 6296
{
	// Fields
	private bool _debuggerLinesStartAt1; // 0x2D
	private bool _debuggerPathsAreURI; // 0x2E
	private bool _clientLinesStartAt1; // 0x2F
	private bool _clientPathsAreURI; // 0x30

	// Methods

	// RVA: 0x30FD8D0 Offset: 0x30FD9D1 VA: 0x30FD8D0
	public void .ctor(bool debuggerLinesStartAt1, bool debuggerPathsAreURI = False) { }

	// RVA: 0x30FD970 Offset: 0x30FDA71 VA: 0x30FD970
	public void SendResponse(Response response, ResponseBody body) { }

	// RVA: 0x30FD9B0 Offset: 0x30FDAB1 VA: 0x30FD9B0
	public void SendErrorResponse(Response response, int id, string format, object arguments, bool user = True, bool telemetry = False) { }

	// RVA: 0x30FDAF0 Offset: 0x30FDBF1 VA: 0x30FDAF0 Slot: 4
	protected override void DispatchRequest(string command, Table args, Response response) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Initialize(Response response, Table args);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Launch(Response response, Table arguments);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Attach(Response response, Table arguments);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Disconnect(Response response, Table arguments);

	// RVA: 0x30FE5F0 Offset: 0x30FE6F1 VA: 0x30FE5F0 Slot: 9
	public virtual void SetFunctionBreakpoints(Response response, Table arguments) { }

	// RVA: 0x30FE600 Offset: 0x30FE701 VA: 0x30FE600 Slot: 10
	public virtual void SetExceptionBreakpoints(Response response, Table arguments) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void SetBreakpoints(Response response, Table arguments);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Continue(Response response, Table arguments);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Next(Response response, Table arguments);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void StepIn(Response response, Table arguments);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void StepOut(Response response, Table arguments);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Pause(Response response, Table arguments);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void StackTrace(Response response, Table arguments);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void Scopes(Response response, Table arguments);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void Variables(Response response, Table arguments);

	// RVA: 0x30FE610 Offset: 0x30FE711 VA: 0x30FE610 Slot: 20
	public virtual void Source(Response response, Table arguments) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void Threads(Response response, Table arguments);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void Evaluate(Response response, Table arguments);

	// RVA: 0x30FE680 Offset: 0x30FE781 VA: 0x30FE680
	protected int ConvertDebuggerLineToClient(int line) { }

	// RVA: 0x30FE6B0 Offset: 0x30FE7B1 VA: 0x30FE6B0
	protected int ConvertClientLineToDebugger(int line) { }

	// RVA: 0x30FE6E0 Offset: 0x30FE7E1 VA: 0x30FE6E0
	protected string ConvertDebuggerPathToClient(string path) { }

	// RVA: 0x30FE820 Offset: 0x30FE921 VA: 0x30FE820
	protected string ConvertClientPathToDebugger(string clientPath) { }
}

