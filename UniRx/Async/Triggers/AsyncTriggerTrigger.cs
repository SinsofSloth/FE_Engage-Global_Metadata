// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x284B0 Offset: 0x285B1 VA: 0x284B0
public class AsyncTriggerTrigger : AsyncTriggerBase // TypeDefIndex: 5200
{
	// Fields
	private AsyncTriggerPromise<Collider> onTriggerEnter; // 0x30
	private AsyncTriggerPromiseDictionary<Collider> onTriggerEnters; // 0x38
	private AsyncTriggerPromise<Collider> onTriggerExit; // 0x40
	private AsyncTriggerPromiseDictionary<Collider> onTriggerExits; // 0x48
	private AsyncTriggerPromise<Collider> onTriggerStay; // 0x50
	private AsyncTriggerPromiseDictionary<Collider> onTriggerStays; // 0x58

	// Methods

	// RVA: 0x2E7C9A0 Offset: 0x2E7CAA1 VA: 0x2E7C9A0 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E7CA40 Offset: 0x2E7CB41 VA: 0x2E7CA40
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x2E7CAA0 Offset: 0x2E7CBA1 VA: 0x2E7CAA0
	public UniTask OnTriggerEnterAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E7CB30 Offset: 0x2E7CC31 VA: 0x2E7CB30
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x2E7CB90 Offset: 0x2E7CC91 VA: 0x2E7CB90
	public UniTask OnTriggerExitAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E7CC20 Offset: 0x2E7CD21 VA: 0x2E7CC20
	private void OnTriggerStay(Collider other) { }

	// RVA: 0x2E7CC80 Offset: 0x2E7CD81 VA: 0x2E7CC80
	public UniTask OnTriggerStayAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E7CD10 Offset: 0x2E7CE11 VA: 0x2E7CD10
	public void .ctor() { }
}

