// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x282E0 Offset: 0x283E1 VA: 0x282E0
public class AsyncDropTrigger : AsyncTriggerBase // TypeDefIndex: 5164
{
	// Fields
	private AsyncTriggerPromise<PointerEventData> onDrop; // 0x30
	private AsyncTriggerPromiseDictionary<PointerEventData> onDrops; // 0x38

	// Methods

	// RVA: 0x2E74440 Offset: 0x2E74541 VA: 0x2E74440 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E74520 Offset: 0x2E74621 VA: 0x2E74520
	private void OnDrop(PointerEventData eventData) { }

	// RVA: 0x2E74580 Offset: 0x2E74681 VA: 0x2E74580
	public UniTask OnDropAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E74610 Offset: 0x2E74711 VA: 0x2E74610
	public void .ctor() { }
}

