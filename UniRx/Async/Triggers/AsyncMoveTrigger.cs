// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28370 Offset: 0x28471 VA: 0x28370
public class AsyncMoveTrigger : AsyncTriggerBase // TypeDefIndex: 5173
{
	// Fields
	private AsyncTriggerPromise<AxisEventData> onMove; // 0x30
	private AsyncTriggerPromiseDictionary<AxisEventData> onMoves; // 0x38

	// Methods

	// RVA: 0x2E77CF0 Offset: 0x2E77DF1 VA: 0x2E77CF0 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E77DD0 Offset: 0x2E77ED1 VA: 0x2E77DD0
	private void OnMove(AxisEventData eventData) { }

	// RVA: 0x2E77E30 Offset: 0x2E77F31 VA: 0x2E77E30
	public UniTask OnMoveAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E77EC0 Offset: 0x2E77FC1 VA: 0x2E77EC0
	public void .ctor() { }
}

