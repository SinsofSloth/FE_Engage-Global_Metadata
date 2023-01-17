// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28290 Offset: 0x28391 VA: 0x28290
public class AsyncCollision2DTrigger : AsyncTriggerBase // TypeDefIndex: 5159
{
	// Fields
	private AsyncTriggerPromise<Collision2D> onCollisionEnter2D; // 0x30
	private AsyncTriggerPromiseDictionary<Collision2D> onCollisionEnter2Ds; // 0x38
	private AsyncTriggerPromise<Collision2D> onCollisionExit2D; // 0x40
	private AsyncTriggerPromiseDictionary<Collision2D> onCollisionExit2Ds; // 0x48
	private AsyncTriggerPromise<Collision2D> onCollisionStay2D; // 0x50
	private AsyncTriggerPromiseDictionary<Collision2D> onCollisionStay2Ds; // 0x58

	// Methods

	// RVA: 0x2E73090 Offset: 0x2E73191 VA: 0x2E73090 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E73230 Offset: 0x2E73331 VA: 0x2E73230
	private void OnCollisionEnter2D(Collision2D coll) { }

	// RVA: 0x2E73290 Offset: 0x2E73391 VA: 0x2E73290
	public UniTask OnCollisionEnter2DAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E73320 Offset: 0x2E73421 VA: 0x2E73320
	private void OnCollisionExit2D(Collision2D coll) { }

	// RVA: 0x2E73380 Offset: 0x2E73481 VA: 0x2E73380
	public UniTask OnCollisionExit2DAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E73410 Offset: 0x2E73511 VA: 0x2E73410
	private void OnCollisionStay2D(Collision2D coll) { }

	// RVA: 0x2E73470 Offset: 0x2E73571 VA: 0x2E73470
	public UniTask OnCollisionStay2DAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E73500 Offset: 0x2E73601 VA: 0x2E73500
	public void .ctor() { }
}

