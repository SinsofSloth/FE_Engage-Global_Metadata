// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28330 Offset: 0x28431 VA: 0x28330
public class AsyncInitializePotentialDragTrigger : AsyncTriggerBase // TypeDefIndex: 5169
{
	// Fields
	private AsyncTriggerPromise<PointerEventData> onInitializePotentialDrag; // 0x30
	private AsyncTriggerPromiseDictionary<PointerEventData> onInitializePotentialDrags; // 0x38

	// Methods

	// RVA: 0x2E76810 Offset: 0x2E76911 VA: 0x2E76810 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E768F0 Offset: 0x2E769F1 VA: 0x2E768F0
	private void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x2E76950 Offset: 0x2E76A51 VA: 0x2E76950
	public UniTask OnInitializePotentialDragAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E769E0 Offset: 0x2E76AE1 VA: 0x2E769E0
	public void .ctor() { }
}

