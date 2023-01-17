// Namespace: UnityEngine
public interface ILogger : ILogHandler // TypeDefIndex: 3532
{
	// Properties
	public abstract ILogHandler logHandler { get; }
	public abstract bool logEnabled { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ILogHandler get_logHandler();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_logEnabled();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_logEnabled(bool value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Log(LogType logType, object message);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Log(LogType logType, object message, Object context);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void LogError(string tag, object message);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void LogFormat(LogType logType, string format, object[] args);
}

