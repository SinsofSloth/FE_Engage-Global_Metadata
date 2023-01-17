// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28380 Offset: 0x28481 VA: 0x28380
public class AsyncParticleTrigger : AsyncTriggerBase // TypeDefIndex: 5174
{
	// Fields
	private AsyncTriggerPromise<GameObject> onParticleCollision; // 0x30
	private AsyncTriggerPromiseDictionary<GameObject> onParticleCollisions; // 0x38

	// Methods

	// RVA: 0x2E77F30 Offset: 0x2E78031 VA: 0x2E77F30 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E78010 Offset: 0x2E78111 VA: 0x2E78010
	private void OnParticleCollision(GameObject other) { }

	// RVA: 0x2E78070 Offset: 0x2E78171 VA: 0x2E78070
	public UniTask OnParticleCollisionAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E78100 Offset: 0x2E78201 VA: 0x2E78100
	public void .ctor() { }
}

