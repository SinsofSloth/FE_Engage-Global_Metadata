// Namespace: 
public struct UnityAsyncExtensions.UnityWebRequestAsyncOperationAwaiter : IAwaiter<UnityWebRequest>, IAwaiter, ICriticalNotifyCompletion, INotifyCompletion // TypeDefIndex: 5145
{
	// Fields
	private UnityWebRequestAsyncOperation asyncOperation; // 0x0
	private Action<AsyncOperation> continuationAction; // 0x8
	private AwaiterStatus status; // 0x10
	private UnityWebRequest result; // 0x18

	// Properties
	public bool IsCompleted { get; }
	public AwaiterStatus Status { get; }

	// Methods

	// RVA: 0x1C2CF30 Offset: 0x1C2D031 VA: 0x1C2CF30
	public void .ctor(UnityWebRequestAsyncOperation asyncOperation) { }

	// RVA: 0x1C2CFB0 Offset: 0x1C2D0B1 VA: 0x1C2CFB0 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x1C2CFC0 Offset: 0x1C2D0C1 VA: 0x1C2CFC0 Slot: 5
	public AwaiterStatus get_Status() { }

	// RVA: 0x1C2CFD0 Offset: 0x1C2D0D1 VA: 0x1C2CFD0 Slot: 4
	public UnityWebRequest GetResult() { }

	// RVA: 0x1C2D090 Offset: 0x1C2D191 VA: 0x1C2D090 Slot: 7
	private void UniRx.Async.IAwaiter.GetResult() { }

	// RVA: 0x1C2D0A0 Offset: 0x1C2D1A1 VA: 0x1C2D0A0 Slot: 9
	public void OnCompleted(Action continuation) { }

	// RVA: 0x1C2D0B0 Offset: 0x1C2D1B1 VA: 0x1C2D0B0 Slot: 8
	public void UnsafeOnCompleted(Action continuation) { }
}

