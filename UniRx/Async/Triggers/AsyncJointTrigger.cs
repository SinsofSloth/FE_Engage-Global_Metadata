// Namespace: UniRx.Async.Triggers
[DisallowMultipleComponent] // RVA: 0x28340 Offset: 0x28441 VA: 0x28340
public class AsyncJointTrigger : AsyncTriggerBase // TypeDefIndex: 5170
{
	// Fields
	private AsyncTriggerPromise<float> onJointBreak; // 0x30
	private AsyncTriggerPromiseDictionary<float> onJointBreaks; // 0x38
	private AsyncTriggerPromise<Joint2D> onJointBreak2D; // 0x40
	private AsyncTriggerPromiseDictionary<Joint2D> onJointBreak2Ds; // 0x48

	// Methods

	// RVA: 0x2E76A50 Offset: 0x2E76B51 VA: 0x2E76A50 Slot: 4
	protected override IEnumerable<ICancelablePromise> GetPromises() { }

	// RVA: 0x2E76AE0 Offset: 0x2E76BE1 VA: 0x2E76AE0
	private void OnJointBreak(float breakForce) { }

	// RVA: 0x2E76B50 Offset: 0x2E76C51 VA: 0x2E76B50
	public UniTask OnJointBreakAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E76BE0 Offset: 0x2E76CE1 VA: 0x2E76BE0
	private void OnJointBreak2D(Joint2D brokenJoint) { }

	// RVA: 0x2E76C40 Offset: 0x2E76D41 VA: 0x2E76C40
	public UniTask OnJointBreak2DAsync(CancellationToken cancellationToken) { }

	// RVA: 0x2E76CD0 Offset: 0x2E76DD1 VA: 0x2E76CD0
	public void .ctor() { }
}

