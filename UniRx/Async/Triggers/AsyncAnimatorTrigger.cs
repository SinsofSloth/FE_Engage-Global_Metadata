// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28240 Offset: 0x28341 VA: 0x28240
public class AsyncAnimatorTrigger : AsyncTriggerBase // TypeDefIndex: 5153
{
	// Fields
	private AsyncTriggerPromise<int> onAnimatorIK; // 0x30
	private AsyncTriggerPromiseDictionary<int> onAnimatorIKs; // 0x38
	private AsyncTriggerPromise<AsyncUnit> onAnimatorMove; // 0x40
	private AsyncTriggerPromiseDictionary<AsyncUnit> onAnimatorMoves; // 0x48

	// Methods

	// RVA: 0x2E72130 Offset: 0x2E72231 VA: 0x2E72130 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E72290 Offset: 0x2E72391 VA: 0x2E72290
	private void OnAnimatorIK(int layerIndex) { }

	// RVA: 0x2E722F0 Offset: 0x2E723F1 VA: 0x2E722F0
	public UniTask OnAnimatorIKAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E72380 Offset: 0x2E72481 VA: 0x2E72380
	private void OnAnimatorMove() { }

	// RVA: 0x2E72420 Offset: 0x2E72521 VA: 0x2E72420
	public UniTask OnAnimatorMoveAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E724B0 Offset: 0x2E725B1 VA: 0x2E724B0
	public void .ctor() { }
}

