// Namespace: 
public struct UniTaskVoid.Awaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5137
{
	// Properties
	[DebuggerHiddenAttribute] // RVA: 0x2F310 Offset: 0x2F411 VA: 0x2F310
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x1C2BBF0 Offset: 0x1C2BCF1 VA: 0x1C2BBF0
	public bool get_IsCompleted() { }

	[DebuggerHiddenAttribute] // RVA: 0x2DDD0 Offset: 0x2DED1 VA: 0x2DDD0
	// RVA: 0x1C2BC00 Offset: 0x1C2BD01 VA: 0x1C2BC00
	public void GetResult() { }

	[DebuggerHiddenAttribute] // RVA: 0x2DDE0 Offset: 0x2DEE1 VA: 0x2DDE0
	// RVA: 0x1C2BC80 Offset: 0x1C2BD81 VA: 0x1C2BC80 Slot: 5
	public void OnCompleted(Action continuation) { }

	[DebuggerHiddenAttribute] // RVA: 0x2DDF0 Offset: 0x2DEF1 VA: 0x2DDF0
	// RVA: 0x1C2BC90 Offset: 0x1C2BD91 VA: 0x1C2BC90 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
}

