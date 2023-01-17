// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x282C0 Offset: 0x283C1 VA: 0x282C0
public class AsyncDestroyTrigger : MonoBehaviour // TypeDefIndex: 5162
{
	// Fields
	private bool called; // 0x18
	private UniTaskCompletionSource promise; // 0x20
	private CancellationTokenSource cancellationTokenSource; // 0x28
	private object canellationTokenSourceOrQueue; // 0x30

	// Properties
	public CancellationToken CancellationToken { get; }

	// Methods

	// RVA: 0x2E73B90 Offset: 0x2E73C91 VA: 0x2E73B90
	public CancellationToken get_CancellationToken() { }

	// RVA: 0x2E73C20 Offset: 0x2E73D21 VA: 0x2E73C20
	private void OnDestroy() { }

	// RVA: 0x2E73E20 Offset: 0x2E73F21 VA: 0x2E73E20
	public UniTask OnDestroyAsync() { }

	// RVA: 0x2E73F00 Offset: 0x2E74001 VA: 0x2E73F00
	public void AddCancellationTriggerOnDestory(CancellationTokenSource cts) { }

	// RVA: 0x2E741F0 Offset: 0x2E742F1 VA: 0x2E741F0
	public void .ctor() { }
}

