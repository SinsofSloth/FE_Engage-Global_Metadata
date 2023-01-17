// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x282F0 Offset: 0x283F1 VA: 0x282F0
public class AsyncEnableDisableTrigger : AsyncTriggerBase // TypeDefIndex: 5165
{
	// Fields
	private AsyncTriggerPromise<AsyncUnit> onEnable; // 0x30
	private AsyncTriggerPromiseDictionary<AsyncUnit> onEnables; // 0x38
	private AsyncTriggerPromise<AsyncUnit> onDisable; // 0x40
	private AsyncTriggerPromiseDictionary<AsyncUnit> onDisables; // 0x48

	// Methods

	// RVA: 0x2E74680 Offset: 0x2E74781 VA: 0x2E74680 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E74710 Offset: 0x2E74811 VA: 0x2E74710
	private void OnEnable() { }

	// RVA: 0x2E747B0 Offset: 0x2E748B1 VA: 0x2E747B0
	public UniTask OnEnableAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E74840 Offset: 0x2E74941 VA: 0x2E74840
	private void OnDisable() { }

	// RVA: 0x2E748E0 Offset: 0x2E749E1 VA: 0x2E748E0
	public UniTask OnDisableAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E74970 Offset: 0x2E74A71 VA: 0x2E74970
	public void .ctor() { }
}

