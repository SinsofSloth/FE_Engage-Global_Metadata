// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28280 Offset: 0x28381 VA: 0x28280
public class AsyncCanvasGroupChangedTrigger : AsyncTriggerBase // TypeDefIndex: 5158
{
	// Fields
	private AsyncTriggerPromise<AsyncUnit> onCanvasGroupChanged; // 0x30
	private AsyncTriggerPromiseDictionary<AsyncUnit> onCanvasGroupChangeds; // 0x38

	// Methods

	// RVA: 0x2E72E10 Offset: 0x2E72F11 VA: 0x2E72E10 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E72EF0 Offset: 0x2E72FF1 VA: 0x2E72EF0
	private void OnCanvasGroupChanged() { }

	// RVA: 0x2E72F90 Offset: 0x2E73091 VA: 0x2E72F90
	public UniTask OnCanvasGroupChangedAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E73020 Offset: 0x2E73121 VA: 0x2E73020
	public void .ctor() { }
}

