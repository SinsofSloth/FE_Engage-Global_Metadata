// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28440 Offset: 0x28541 VA: 0x28440
public class AsyncTrigger2DTrigger : AsyncTriggerBase // TypeDefIndex: 5187
{
	// Fields
	private AsyncTriggerPromise<Collider2D> onTriggerEnter2D; // 0x30
	private AsyncTriggerPromiseDictionary<Collider2D> onTriggerEnter2Ds; // 0x38
	private AsyncTriggerPromise<Collider2D> onTriggerExit2D; // 0x40
	private AsyncTriggerPromiseDictionary<Collider2D> onTriggerExit2Ds; // 0x48
	private AsyncTriggerPromise<Collider2D> onTriggerStay2D; // 0x50
	private AsyncTriggerPromiseDictionary<Collider2D> onTriggerStay2Ds; // 0x58

	// Methods

	// RVA: 0x2E79DF0 Offset: 0x2E79EF1 VA: 0x2E79DF0 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E79E90 Offset: 0x2E79F91 VA: 0x2E79E90
	private void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x2E79EF0 Offset: 0x2E79FF1 VA: 0x2E79EF0
	public UniTask OnTriggerEnter2DAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E79F80 Offset: 0x2E7A081 VA: 0x2E79F80
	private void OnTriggerExit2D(Collider2D other) { }

	// RVA: 0x2E79FE0 Offset: 0x2E7A0E1 VA: 0x2E79FE0
	public UniTask OnTriggerExit2DAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E7A070 Offset: 0x2E7A171 VA: 0x2E7A070
	private void OnTriggerStay2D(Collider2D other) { }

	// RVA: 0x2E7A0D0 Offset: 0x2E7A1D1 VA: 0x2E7A0D0
	public UniTask OnTriggerStay2DAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E7A160 Offset: 0x2E7A261 VA: 0x2E7A160
	public void .ctor() { }
}

