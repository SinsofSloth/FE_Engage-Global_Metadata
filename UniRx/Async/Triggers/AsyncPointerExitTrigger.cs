// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x283C0 Offset: 0x284C1 VA: 0x283C0
public class AsyncPointerExitTrigger : AsyncTriggerBase // TypeDefIndex: 5178
{
	// Fields
	private AsyncTriggerPromise<PointerEventData> onPointerExit; // 0x30
	private AsyncTriggerPromiseDictionary<PointerEventData> onPointerExits; // 0x38

	// Methods

	// RVA: 0x2E78830 Offset: 0x2E78931 VA: 0x2E78830 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E78910 Offset: 0x2E78A11 VA: 0x2E78910
	private void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x2E78970 Offset: 0x2E78A71 VA: 0x2E78970
	public UniTask OnPointerExitAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E78A00 Offset: 0x2E78B01 VA: 0x2E78A00
	public void .ctor() { }
}

