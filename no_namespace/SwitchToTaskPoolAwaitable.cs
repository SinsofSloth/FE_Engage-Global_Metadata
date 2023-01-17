// Namespace: 
public struct SwitchToTaskPoolAwaitable.Awaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5092
{
	// Fields
	private static readonly Action<object> switchToCallback; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x2E90430 Offset: 0x2E90531 VA: 0x2E90430
	public bool get_IsCompleted() { }

	// RVA: 0x2E90440 Offset: 0x2E90541 VA: 0x2E90440
	public void GetResult() { }

	// RVA: 0x2E90450 Offset: 0x2E90551 VA: 0x2E90450 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x2E90640 Offset: 0x2E90741 VA: 0x2E90640 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x2E90830 Offset: 0x2E90931 VA: 0x2E90830
	private static void Callback(object state) { }

	// RVA: 0x2E908A0 Offset: 0x2E909A1 VA: 0x2E908A0
	private static void .cctor() { }
}

