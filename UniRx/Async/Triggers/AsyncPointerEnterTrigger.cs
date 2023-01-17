// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x283B0 Offset: 0x284B1 VA: 0x283B0
public class AsyncPointerEnterTrigger : AsyncTriggerBase // TypeDefIndex: 5177
{
	// Fields
	private AsyncTriggerPromise<PointerEventData> onPointerEnter; // 0x30
	private AsyncTriggerPromiseDictionary<PointerEventData> onPointerEnters; // 0x38

	// Methods

	// RVA: 0x2E785F0 Offset: 0x2E786F1 VA: 0x2E785F0 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E786D0 Offset: 0x2E787D1 VA: 0x2E786D0
	private void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x2E78730 Offset: 0x2E78831 VA: 0x2E78730
	public UniTask OnPointerEnterAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E787C0 Offset: 0x2E788C1 VA: 0x2E787C0
	public void .ctor() { }
}

