// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28360 Offset: 0x28461 VA: 0x28360
public class AsyncMouseTrigger : AsyncTriggerBase // TypeDefIndex: 5172
{
	// Fields
	private AsyncTriggerPromise<AsyncUnit> onMouseDown; // 0x30
	private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseDowns; // 0x38
	private AsyncTriggerPromise<AsyncUnit> onMouseDrag; // 0x40
	private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseDrags; // 0x48
	private AsyncTriggerPromise<AsyncUnit> onMouseEnter; // 0x50
	private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseEnters; // 0x58
	private AsyncTriggerPromise<AsyncUnit> onMouseExit; // 0x60
	private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseExits; // 0x68
	private AsyncTriggerPromise<AsyncUnit> onMouseOver; // 0x70
	private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseOvers; // 0x78
	private AsyncTriggerPromise<AsyncUnit> onMouseUp; // 0x80
	private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseUps; // 0x88
	private AsyncTriggerPromise<AsyncUnit> onMouseUpAsButton; // 0x90
	private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseUpAsButtons; // 0x98

	// Methods

	// RVA: 0x2E77010 Offset: 0x2E77111 VA: 0x2E77010 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E77430 Offset: 0x2E77531 VA: 0x2E77430
	private void OnMouseDown() { }

	// RVA: 0x2E774D0 Offset: 0x2E775D1 VA: 0x2E774D0
	public UniTask OnMouseDownAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E77560 Offset: 0x2E77661 VA: 0x2E77560
	private void OnMouseDrag() { }

	// RVA: 0x2E77600 Offset: 0x2E77701 VA: 0x2E77600
	public UniTask OnMouseDragAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E77690 Offset: 0x2E77791 VA: 0x2E77690
	private void OnMouseEnter() { }

	// RVA: 0x2E77730 Offset: 0x2E77831 VA: 0x2E77730
	public UniTask OnMouseEnterAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E777C0 Offset: 0x2E778C1 VA: 0x2E777C0
	private void OnMouseExit() { }

	// RVA: 0x2E77860 Offset: 0x2E77961 VA: 0x2E77860
	public UniTask OnMouseExitAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E778F0 Offset: 0x2E779F1 VA: 0x2E778F0
	private void OnMouseOver() { }

	// RVA: 0x2E77990 Offset: 0x2E77A91 VA: 0x2E77990
	public UniTask OnMouseOverAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E77A20 Offset: 0x2E77B21 VA: 0x2E77A20
	private void OnMouseUp() { }

	// RVA: 0x2E77AC0 Offset: 0x2E77BC1 VA: 0x2E77AC0
	public UniTask OnMouseUpAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E77B50 Offset: 0x2E77C51 VA: 0x2E77B50
	private void OnMouseUpAsButton() { }

	// RVA: 0x2E77BF0 Offset: 0x2E77CF1 VA: 0x2E77BF0
	public UniTask OnMouseUpAsButtonAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E77C80 Offset: 0x2E77D81 VA: 0x2E77C80
	public void .ctor() { }
}

