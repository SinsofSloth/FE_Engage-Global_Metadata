// Namespace: UniRx.Diagnostics
public class Logger // TypeDefIndex: 6849
{
	// Fields
	private static bool isInitialized; // 0x0
	private static bool isDebugBuild; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x13EA0 Offset: 0x13FA1 VA: 0x13EA0
	private string <Name>k__BackingField; // 0x10
	protected readonly Action<LogEntry> logPublisher; // 0x18

	// Properties
	public string Name { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x18260 Offset: 0x18361 VA: 0x18260
	// RVA: 0x19D1AD0 Offset: 0x19D1BD1 VA: 0x19D1AD0
	public string get_Name() { }

	[CompilerGeneratedAttribute] // RVA: 0x18270 Offset: 0x18371 VA: 0x18270
	// RVA: 0x19D1AE0 Offset: 0x19D1BE1 VA: 0x19D1AE0
	private void set_Name(string value) { }

	// RVA: 0x19D1AF0 Offset: 0x19D1BF1 VA: 0x19D1AF0
	public void .ctor(string loggerName) { }

	// RVA: 0x19D1CA0 Offset: 0x19D1DA1 VA: 0x19D1CA0 Slot: 4
	public virtual void Debug(object message, Object context) { }

	// RVA: 0x19D1F00 Offset: 0x19D2001 VA: 0x19D1F00 Slot: 5
	public virtual void DebugFormat(string format, object[] args) { }

	// RVA: 0x19D2160 Offset: 0x19D2261 VA: 0x19D2160 Slot: 6
	public virtual void Log(object message, Object context) { }

	// RVA: 0x19D22E0 Offset: 0x19D23E1 VA: 0x19D22E0 Slot: 7
	public virtual void LogFormat(string format, object[] args) { }

	// RVA: 0x19D2460 Offset: 0x19D2561 VA: 0x19D2460 Slot: 8
	public virtual void Warning(object message, Object context) { }

	// RVA: 0x19D25E0 Offset: 0x19D26E1 VA: 0x19D25E0 Slot: 9
	public virtual void WarningFormat(string format, object[] args) { }

	// RVA: 0x19D2760 Offset: 0x19D2861 VA: 0x19D2760 Slot: 10
	public virtual void Error(object message, Object context) { }

	// RVA: 0x19D28E0 Offset: 0x19D29E1 VA: 0x19D28E0 Slot: 11
	public virtual void ErrorFormat(string format, object[] args) { }

	// RVA: 0x19D2A60 Offset: 0x19D2B61 VA: 0x19D2A60 Slot: 12
	public virtual void Exception(Exception exception, Object context) { }

	// RVA: 0x19D2BF0 Offset: 0x19D2CF1 VA: 0x19D2BF0 Slot: 13
	public virtual void Raw(LogEntry logEntry) { }

	// RVA: 0x19D2CA0 Offset: 0x19D2DA1 VA: 0x19D2CA0
	private static void .cctor() { }
}

