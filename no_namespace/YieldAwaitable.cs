// Namespace: 
public struct YieldAwaitable.Awaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5085
{
	// Fields
	private readonly PlayerLoopTiming timing; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x1C2EC80 Offset: 0x1C2ED81 VA: 0x1C2EC80
	public void .ctor(PlayerLoopTiming timing) { }

	// RVA: 0x1C2A9A0 Offset: 0x1C2AAA1 VA: 0x1C2A9A0
	public bool get_IsCompleted() { }

	// RVA: 0x1C2A9B0 Offset: 0x1C2AAB1 VA: 0x1C2A9B0
	public void GetResult() { }

	// RVA: 0x1C2EC90 Offset: 0x1C2ED91 VA: 0x1C2EC90 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x1C2ECA0 Offset: 0x1C2EDA1 VA: 0x1C2ECA0 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
}

