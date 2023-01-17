// Namespace: 
public struct SwitchToThreadPoolAwaitable.Awaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5090
{
	// Fields
	private static readonly WaitCallback switchToCallback; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x2E90960 Offset: 0x2E90A61 VA: 0x2E90960
	public bool get_IsCompleted() { }

	// RVA: 0x2E90970 Offset: 0x2E90A71 VA: 0x2E90970
	public void GetResult() { }

	// RVA: 0x2E90980 Offset: 0x2E90A81 VA: 0x2E90980 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x2E90A00 Offset: 0x2E90B01 VA: 0x2E90A00 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x2E90A80 Offset: 0x2E90B81 VA: 0x2E90A80
	private static void Callback(object state) { }

	// RVA: 0x2E90AF0 Offset: 0x2E90BF1 VA: 0x2E90AF0
	private static void .cctor() { }
}

