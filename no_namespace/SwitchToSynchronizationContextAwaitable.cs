// Namespace: 
public struct SwitchToSynchronizationContextAwaitable.Awaiter : ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5094
{
	// Fields
	private static readonly SendOrPostCallback switchToCallback; // 0x0
	private readonly SynchronizationContext synchronizationContext; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x2E901D0 Offset: 0x2E902D1 VA: 0x2E901D0
	public void .ctor(SynchronizationContext synchronizationContext) { }

	// RVA: 0x2E901E0 Offset: 0x2E902E1 VA: 0x2E901E0
	public bool get_IsCompleted() { }

	// RVA: 0x2E901F0 Offset: 0x2E902F1 VA: 0x2E901F0
	public void GetResult() { }

	// RVA: 0x2E90200 Offset: 0x2E90301 VA: 0x2E90200 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x2E90290 Offset: 0x2E90391 VA: 0x2E90290 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x2E90320 Offset: 0x2E90421 VA: 0x2E90320
	private static void Callback(object state) { }

	// RVA: 0x2E90390 Offset: 0x2E90491 VA: 0x2E90390
	private static void .cctor() { }
}

