// Namespace: UnityEngine
public class Logger : ILogger, ILogHandler // TypeDefIndex: 3534
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x443210 Offset: 0x443311 VA: 0x443210
	[DebuggerBrowsableAttribute] // RVA: 0x443210 Offset: 0x443311 VA: 0x443210
	private ILogHandler <logHandler>k__BackingField; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x443250 Offset: 0x443351 VA: 0x443250
	[CompilerGeneratedAttribute] // RVA: 0x443250 Offset: 0x443351 VA: 0x443250
	private bool <logEnabled>k__BackingField; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x443290 Offset: 0x443391 VA: 0x443290
	[CompilerGeneratedAttribute] // RVA: 0x443290 Offset: 0x443391 VA: 0x443290
	private LogType <filterLogType>k__BackingField; // 0x1C

	// Properties
	public ILogHandler logHandler { get; set; }
	public bool logEnabled { get; set; }
	public LogType filterLogType { get; set; }

	// Methods

	// RVA: 0x34766C0 Offset: 0x34767C1 VA: 0x34766C0
	public void .ctor(ILogHandler logHandler) { }

	[CompilerGeneratedAttribute] // RVA: 0x44E030 Offset: 0x44E131 VA: 0x44E030
	// RVA: 0x3476710 Offset: 0x3476811 VA: 0x3476710 Slot: 4
	public ILogHandler get_logHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x44E040 Offset: 0x44E141 VA: 0x44E040
	// RVA: 0x3476720 Offset: 0x3476821 VA: 0x3476720 Slot: 13
	public void set_logHandler(ILogHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x44E050 Offset: 0x44E151 VA: 0x44E050
	// RVA: 0x3476730 Offset: 0x3476831 VA: 0x3476730 Slot: 5
	public bool get_logEnabled() { }

	[CompilerGeneratedAttribute] // RVA: 0x44E060 Offset: 0x44E161 VA: 0x44E060
	// RVA: 0x3476740 Offset: 0x3476841 VA: 0x3476740 Slot: 6
	public void set_logEnabled(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x44E070 Offset: 0x44E171 VA: 0x44E070
	// RVA: 0x3476750 Offset: 0x3476851 VA: 0x3476750 Slot: 14
	public LogType get_filterLogType() { }

	[CompilerGeneratedAttribute] // RVA: 0x44E080 Offset: 0x44E181 VA: 0x44E080
	// RVA: 0x3476760 Offset: 0x3476861 VA: 0x3476760 Slot: 15
	public void set_filterLogType(LogType value) { }

	// RVA: 0x3476770 Offset: 0x3476871 VA: 0x3476770 Slot: 16
	public bool IsLogTypeAllowed(LogType logType) { }

	// RVA: 0x34767B0 Offset: 0x34768B1 VA: 0x34767B0
	private static string GetString(object message) { }

	// RVA: 0x34768F0 Offset: 0x34769F1 VA: 0x34768F0 Slot: 7
	public void Log(LogType logType, object message) { }

	// RVA: 0x3476A70 Offset: 0x3476B71 VA: 0x3476A70 Slot: 8
	public void Log(LogType logType, object message, Object context) { }

	// RVA: 0x3476C00 Offset: 0x3476D01 VA: 0x3476C00 Slot: 9
	public void LogError(string tag, object message) { }

	// RVA: 0x3476DB0 Offset: 0x3476EB1 VA: 0x3476DB0 Slot: 12
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x3476E80 Offset: 0x3476F81 VA: 0x3476E80 Slot: 10
	public void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: 0x3476F80 Offset: 0x3477081 VA: 0x3476F80 Slot: 11
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }
}

