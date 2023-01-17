// Namespace: MoonSharp.Interpreter
public class Script : IScriptPrivateResource // TypeDefIndex: 5986
{
	// Fields
	public const string VERSION = "2.0.0.0";
	public const string LUA_VERSION = "5.2";
	private Processor m_MainProcessor; // 0x10
	private ByteCode m_ByteCode; // 0x18
	private List<SourceCode> m_Sources; // 0x20
	private Table m_GlobalTable; // 0x28
	private IDebugger m_Debugger; // 0x30
	private Table[] m_TypeMetatables; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0xE410 Offset: 0xE511 VA: 0xE410
	private static ScriptOptions <DefaultOptions>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0xE420 Offset: 0xE521 VA: 0xE420
	private ScriptOptions <Options>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0xE430 Offset: 0xE531 VA: 0xE430
	private static ScriptGlobalOptions <GlobalOptions>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0xE440 Offset: 0xE541 VA: 0xE440
	private PerformanceStatistics <PerformanceStats>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0xE450 Offset: 0xE551 VA: 0xE450
	private Table <Registry>k__BackingField; // 0x50

	// Properties
	public static ScriptOptions DefaultOptions { get; set; }
	public ScriptOptions Options { get; set; }
	public static ScriptGlobalOptions GlobalOptions { get; set; }
	public PerformanceStatistics PerformanceStats { get; set; }
	public Table Globals { get; }
	public bool DebuggerEnabled { get; set; }
	public int SourceCodeCount { get; }
	public Table Registry { get; set; }
	private Script MoonSharp.Interpreter.IScriptPrivateResource.OwnerScript { get; }

	// Methods

	// RVA: 0x3016360 Offset: 0x3016461 VA: 0x3016360
	private static void .cctor() { }

	// RVA: 0x30166F0 Offset: 0x30167F1 VA: 0x30166F0
	public void .ctor() { }

	// RVA: 0x3016700 Offset: 0x3016801 VA: 0x3016700
	public void .ctor(CoreModules coreModules) { }

	[CompilerGeneratedAttribute] // RVA: 0xFD20 Offset: 0xFE21 VA: 0xFD20
	// RVA: 0x3016D30 Offset: 0x3016E31 VA: 0x3016D30
	public static ScriptOptions get_DefaultOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0xFD30 Offset: 0xFE31 VA: 0xFD30
	// RVA: 0x3016DA0 Offset: 0x3016EA1 VA: 0x3016DA0
	private static void set_DefaultOptions(ScriptOptions value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFD40 Offset: 0xFE41 VA: 0xFD40
	// RVA: 0x3016E20 Offset: 0x3016F21 VA: 0x3016E20
	public ScriptOptions get_Options() { }

	[CompilerGeneratedAttribute] // RVA: 0xFD50 Offset: 0xFE51 VA: 0xFD50
	// RVA: 0x3016E30 Offset: 0x3016F31 VA: 0x3016E30
	private void set_Options(ScriptOptions value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFD60 Offset: 0xFE61 VA: 0xFD60
	// RVA: 0x3016E40 Offset: 0x3016F41 VA: 0x3016E40
	public static ScriptGlobalOptions get_GlobalOptions() { }

	[CompilerGeneratedAttribute] // RVA: 0xFD70 Offset: 0xFE71 VA: 0xFD70
	// RVA: 0x3016EB0 Offset: 0x3016FB1 VA: 0x3016EB0
	private static void set_GlobalOptions(ScriptGlobalOptions value) { }

	[CompilerGeneratedAttribute] // RVA: 0xFD80 Offset: 0xFE81 VA: 0xFD80
	// RVA: 0x3016F30 Offset: 0x3017031 VA: 0x3016F30
	public PerformanceStatistics get_PerformanceStats() { }

	[CompilerGeneratedAttribute] // RVA: 0xFD90 Offset: 0xFE91 VA: 0xFD90
	// RVA: 0x3016F40 Offset: 0x3017041 VA: 0x3016F40
	private void set_PerformanceStats(PerformanceStatistics value) { }

	// RVA: 0x3016F50 Offset: 0x3017051 VA: 0x3016F50
	public Table get_Globals() { }

	// RVA: 0x3016F60 Offset: 0x3017061 VA: 0x3016F60
	public DynValue LoadFunction(string code, Table globalTable, string funcFriendlyName) { }

	// RVA: 0x3017780 Offset: 0x3017881 VA: 0x3017780
	private void SignalByteCodeChange() { }

	// RVA: 0x30176B0 Offset: 0x30177B1 VA: 0x30176B0
	private void SignalSourceCodeChange(SourceCode source) { }

	// RVA: 0x3014B10 Offset: 0x3014C11 VA: 0x3014B10
	public DynValue LoadString(string code, Table globalTable, string codeFriendlyName) { }

	// RVA: 0x3017D20 Offset: 0x3017E21 VA: 0x3017D20
	public DynValue LoadStream(Stream stream, Table globalTable, string codeFriendlyName) { }

	// RVA: 0x3018140 Offset: 0x3018241 VA: 0x3018140
	public void Dump(DynValue function, Stream stream) { }

	// RVA: 0x3018320 Offset: 0x3018421 VA: 0x3018320
	public DynValue LoadFile(string filename, Table globalContext, string friendlyFilename) { }

	// RVA: 0x3018840 Offset: 0x3018941 VA: 0x3018840
	public DynValue DoString(string code, Table globalContext, string codeFriendlyName) { }

	// RVA: 0x30188B0 Offset: 0x30189B1 VA: 0x30188B0
	public DynValue DoStream(Stream stream, Table globalContext, string codeFriendlyName) { }

	// RVA: 0x3018920 Offset: 0x3018A21 VA: 0x3018920
	public DynValue DoFile(string filename, Table globalContext, string codeFriendlyName) { }

	// RVA: 0x3018990 Offset: 0x3018A91 VA: 0x3018990
	public static DynValue RunFile(string filename) { }

	// RVA: 0x3018A50 Offset: 0x3018B51 VA: 0x3018A50
	public static DynValue RunString(string code) { }

	// RVA: 0x3017970 Offset: 0x3017A71 VA: 0x3017970
	private DynValue MakeClosure(int address, Table envTable) { }

	// RVA: 0x3014ED0 Offset: 0x3014FD1 VA: 0x3014ED0
	public DynValue Call(DynValue function) { }

	// RVA: 0x3018BB0 Offset: 0x3018CB1 VA: 0x3018BB0
	public DynValue Call(DynValue function, DynValue[] args) { }

	// RVA: 0x3019050 Offset: 0x3019151 VA: 0x3019050
	public DynValue Call(DynValue function, object[] args) { }

	// RVA: 0x30191B0 Offset: 0x30192B1 VA: 0x30191B0
	public DynValue Call(object function) { }

	// RVA: 0x3019270 Offset: 0x3019371 VA: 0x3019270
	public DynValue Call(object function, object[] args) { }

	// RVA: 0x3019300 Offset: 0x3019401 VA: 0x3019300
	public DynValue CreateCoroutine(DynValue function) { }

	// RVA: 0x3019460 Offset: 0x3019561 VA: 0x3019460
	public DynValue CreateCoroutine(object function) { }

	// RVA: 0x30194E0 Offset: 0x30195E1 VA: 0x30194E0
	public bool get_DebuggerEnabled() { }

	// RVA: 0x30194F0 Offset: 0x30195F1 VA: 0x30194F0
	public void set_DebuggerEnabled(bool value) { }

	// RVA: 0x3019500 Offset: 0x3019601 VA: 0x3019500
	public void AttachDebugger(IDebugger debugger) { }

	// RVA: 0x30196F0 Offset: 0x30197F1 VA: 0x30196F0
	public SourceCode GetSourceCode(int sourceCodeID) { }

	// RVA: 0x3019760 Offset: 0x3019861 VA: 0x3019760
	public int get_SourceCodeCount() { }

	// RVA: 0x30197B0 Offset: 0x30198B1 VA: 0x30197B0
	public DynValue RequireModule(string modname, Table globalContext) { }

	// RVA: 0x3019920 Offset: 0x3019A21 VA: 0x3019920
	public Table GetTypeMetatable(DataType type) { }

	// RVA: 0x3019970 Offset: 0x3019A71 VA: 0x3019970
	public void SetTypeMetatable(DataType type, Table metatable) { }

	// RVA: 0x3019A90 Offset: 0x3019B91 VA: 0x3019A90
	public static void WarmUp() { }

	// RVA: 0x3014A30 Offset: 0x3014B31 VA: 0x3014A30
	public DynamicExpression CreateDynamicExpression(string code) { }

	// RVA: 0x3019B10 Offset: 0x3019C11 VA: 0x3019B10
	public DynamicExpression CreateConstantDynamicExpression(string code, DynValue constant) { }

	// RVA: 0x3018FA0 Offset: 0x30190A1 VA: 0x3018FA0
	internal ScriptExecutionContext CreateDynamicExecutionContext(CallbackFunction func) { }

	[CompilerGeneratedAttribute] // RVA: 0xFDA0 Offset: 0xFEA1 VA: 0xFDA0
	// RVA: 0x3019C30 Offset: 0x3019D31 VA: 0x3019C30
	public Table get_Registry() { }

	[CompilerGeneratedAttribute] // RVA: 0xFDB0 Offset: 0xFEB1 VA: 0xFDB0
	// RVA: 0x3019C40 Offset: 0x3019D41 VA: 0x3019C40
	private void set_Registry(Table value) { }

	// RVA: 0x3019C50 Offset: 0x3019D51 VA: 0x3019C50
	public static string GetBanner(string subproduct) { }

	// RVA: 0x3019EB0 Offset: 0x3019FB1 VA: 0x3019EB0 Slot: 4
	private Script MoonSharp.Interpreter.IScriptPrivateResource.get_OwnerScript() { }

	// RVA: 0x3019EC0 Offset: 0x3019FC1 VA: 0x3019EC0
	public int GetLine(int iAddress) { }

	// RVA: 0x3019F00 Offset: 0x301A001 VA: 0x3019F00
	public int GetLine(WatchItem item) { }

	// RVA: 0x3019F60 Offset: 0x301A061 VA: 0x3019F60
	public SourceRef GetSourceRef(int iAddress) { }
}

