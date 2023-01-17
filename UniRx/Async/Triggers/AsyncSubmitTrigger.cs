// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28420 Offset: 0x28521 VA: 0x28420
public class AsyncSubmitTrigger : AsyncTriggerBase // TypeDefIndex: 5185
{
	// Fields
	private AsyncTriggerPromise<BaseEventData> onSubmit; // 0x30
	private AsyncTriggerPromiseDictionary<BaseEventData> onSubmits; // 0x38

	// Methods

	// RVA: 0x2E79710 Offset: 0x2E79811 VA: 0x2E79710 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E797F0 Offset: 0x2E798F1 VA: 0x2E797F0
	private void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x2E79850 Offset: 0x2E79951 VA: 0x2E79850
	public UniTask OnSubmitAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E798E0 Offset: 0x2E799E1 VA: 0x2E798E0
	public void .ctor() { }
}

