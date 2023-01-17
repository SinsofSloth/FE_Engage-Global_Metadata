// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x282A0 Offset: 0x283A1 VA: 0x282A0
public class AsyncCollisionTrigger : AsyncTriggerBase // TypeDefIndex: 5160
{
	// Fields
	private AsyncTriggerPromise<Collision> onCollisionEnter; // 0x30
	private AsyncTriggerPromiseDictionary<Collision> onCollisionEnters; // 0x38
	private AsyncTriggerPromise<Collision> onCollisionExit; // 0x40
	private AsyncTriggerPromiseDictionary<Collision> onCollisionExits; // 0x48
	private AsyncTriggerPromise<Collision> onCollisionStay; // 0x50
	private AsyncTriggerPromiseDictionary<Collision> onCollisionStays; // 0x58

	// Methods

	// RVA: 0x2E73570 Offset: 0x2E73671 VA: 0x2E73570 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E73610 Offset: 0x2E73711 VA: 0x2E73610
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x2E73670 Offset: 0x2E73771 VA: 0x2E73670
	public UniTask OnCollisionEnterAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E73700 Offset: 0x2E73801 VA: 0x2E73700
	private void OnCollisionExit(Collision collisionInfo) { }

	// RVA: 0x2E73760 Offset: 0x2E73861 VA: 0x2E73760
	public UniTask OnCollisionExitAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E737F0 Offset: 0x2E738F1 VA: 0x2E737F0
	private void OnCollisionStay(Collision collisionInfo) { }

	// RVA: 0x2E73850 Offset: 0x2E73951 VA: 0x2E73850
	public UniTask OnCollisionStayAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E738E0 Offset: 0x2E739E1 VA: 0x2E738E0
	public void .ctor() { }
}

