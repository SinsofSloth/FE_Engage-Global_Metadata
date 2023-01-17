// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x283F0 Offset: 0x284F1 VA: 0x283F0
public class AsyncScrollTrigger : AsyncTriggerBase // TypeDefIndex: 5181
{
	// Fields
	private AsyncTriggerPromise<PointerEventData> onScroll; // 0x30
	private AsyncTriggerPromiseDictionary<PointerEventData> onScrolls; // 0x38

	// Methods

	// RVA: 0x2E79010 Offset: 0x2E79111 VA: 0x2E79010 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E790F0 Offset: 0x2E791F1 VA: 0x2E790F0
	private void OnScroll(PointerEventData eventData) { }

	// RVA: 0x2E79150 Offset: 0x2E79251 VA: 0x2E79150
	public UniTask OnScrollAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E791E0 Offset: 0x2E792E1 VA: 0x2E791E0
	public void .ctor() { }
}

