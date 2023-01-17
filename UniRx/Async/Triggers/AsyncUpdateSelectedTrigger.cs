// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x284C0 Offset: 0x285C1 VA: 0x284C0
public class AsyncUpdateSelectedTrigger : AsyncTriggerBase // TypeDefIndex: 5201
{
	// Fields
	private AsyncTriggerPromise<BaseEventData> onUpdateSelected; // 0x30
	private AsyncTriggerPromiseDictionary<BaseEventData> onUpdateSelecteds; // 0x38

	// Methods

	// RVA: 0x2E7E190 Offset: 0x2E7E291 VA: 0x2E7E190 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E7E270 Offset: 0x2E7E371 VA: 0x2E7E270
	private void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x2E7E2D0 Offset: 0x2E7E3D1 VA: 0x2E7E2D0
	public UniTask OnUpdateSelectedAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E7E360 Offset: 0x2E7E461 VA: 0x2E7E360
	public void .ctor() { }
}

