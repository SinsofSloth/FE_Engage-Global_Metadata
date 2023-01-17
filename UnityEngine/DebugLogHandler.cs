// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x43BEE0 Offset: 0x43BFE1 VA: 0x43BEE0
internal sealed class DebugLogHandler : ILogHandler // TypeDefIndex: 3422
{
	// Methods

	[ThreadAndSerializationSafeAttribute] // RVA: 0x447240 Offset: 0x447341 VA: 0x447240
	// RVA: 0x2F201B0 Offset: 0x2F202B1 VA: 0x2F201B0
	internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj) { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x447250 Offset: 0x447351 VA: 0x447250
	// RVA: 0x2F20220 Offset: 0x2F20321 VA: 0x2F20220
	internal static void Internal_LogException(Exception ex, Object obj) { }

	// RVA: 0x2F20270 Offset: 0x2F20371 VA: 0x2F20270 Slot: 4
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x2F202E0 Offset: 0x2F203E1 VA: 0x2F202E0 Slot: 5
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x2F201A0 Offset: 0x2F202A1 VA: 0x2F201A0
	public void .ctor() { }
}

