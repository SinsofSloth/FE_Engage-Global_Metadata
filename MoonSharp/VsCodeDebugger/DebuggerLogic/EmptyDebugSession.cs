// Namespace: MoonSharp.VsCodeDebugger.DebuggerLogic
internal class EmptyDebugSession : DebugSession // TypeDefIndex: 6308
{
	// Fields
	private MoonSharpVsCodeDebugServer m_Server; // 0x38

	// Methods

	// RVA: 0x3305FB0 Offset: 0x33060B1 VA: 0x3305FB0
	internal void .ctor(MoonSharpVsCodeDebugServer server) { }

	// RVA: 0x3305FF0 Offset: 0x33060F1 VA: 0x3305FF0 Slot: 5
	public override void Initialize(Response response, Table args) { }

	// RVA: 0x3306590 Offset: 0x3306691 VA: 0x3306590
	private void SendList() { }

	// RVA: 0x3306D00 Offset: 0x3306E01 VA: 0x3306D00 Slot: 7
	public override void Attach(Response response, Table arguments) { }

	// RVA: 0x3306D10 Offset: 0x3306E11 VA: 0x3306D10 Slot: 12
	public override void Continue(Response response, Table arguments) { }

	// RVA: 0x3306D50 Offset: 0x3306E51 VA: 0x3306D50 Slot: 8
	public override void Disconnect(Response response, Table arguments) { }

	// RVA: 0x3306D60 Offset: 0x3306E61 VA: 0x3306D60
	private static string getString(Table args, string property, string dflt) { }

	// RVA: 0x3306E10 Offset: 0x3306F11 VA: 0x3306E10 Slot: 22
	public override void Evaluate(Response response, Table args) { }

	// RVA: 0x3306FC0 Offset: 0x33070C1 VA: 0x3306FC0
	private void ExecuteRepl(string cmd) { }

	// RVA: 0x3307260 Offset: 0x3307361 VA: 0x3307260 Slot: 6
	public override void Launch(Response response, Table arguments) { }

	// RVA: 0x3307270 Offset: 0x3307371 VA: 0x3307270 Slot: 13
	public override void Next(Response response, Table arguments) { }

	// RVA: 0x33072B0 Offset: 0x33073B1 VA: 0x33072B0 Slot: 16
	public override void Pause(Response response, Table arguments) { }

	// RVA: 0x33072F0 Offset: 0x33073F1 VA: 0x33072F0 Slot: 18
	public override void Scopes(Response response, Table arguments) { }

	// RVA: 0x3307300 Offset: 0x3307401 VA: 0x3307300 Slot: 11
	public override void SetBreakpoints(Response response, Table args) { }

	// RVA: 0x3307310 Offset: 0x3307411 VA: 0x3307310 Slot: 17
	public override void StackTrace(Response response, Table args) { }

	// RVA: 0x3307320 Offset: 0x3307421 VA: 0x3307320 Slot: 14
	public override void StepIn(Response response, Table arguments) { }

	// RVA: 0x3307360 Offset: 0x3307461 VA: 0x3307360 Slot: 15
	public override void StepOut(Response response, Table arguments) { }

	// RVA: 0x33073A0 Offset: 0x33074A1 VA: 0x33073A0 Slot: 21
	public override void Threads(Response response, Table arguments) { }

	// RVA: 0x33074E0 Offset: 0x33075E1 VA: 0x33074E0 Slot: 19
	public override void Variables(Response response, Table arguments) { }

	// RVA: 0x33064B0 Offset: 0x33065B1 VA: 0x33064B0
	private void SendText(string msg, object[] args) { }

	// RVA: 0x3307130 Offset: 0x3307231 VA: 0x3307130
	public void Unbind() { }
}

