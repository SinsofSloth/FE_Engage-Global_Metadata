// Namespace: UniRx.Async.Triggers
public abstract class AsyncTriggerBase : MonoBehaviour // TypeDefIndex: 5198
{
	// Fields
	private static readonly Action<object> Callback; // 0x0
	private bool calledAwake; // 0x18
	private bool destroyCalled; // 0x19
	private CancellationTokenRegistration[] registeredCancellations; // 0x20
	private int registeredCancellationsCount; // 0x28

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract IEnumerable<ICancelablePromise> GetPromises();

	[IteratorStateMachineAttribute] // RVA: 0x2E0F0 Offset: 0x2E1F1 VA: 0x2E0F0
	// RVA: 0x2E729D0 Offset: 0x2E72AD1 VA: 0x2E729D0
	protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s) { }

	[IteratorStateMachineAttribute] // RVA: 0x2E160 Offset: 0x2E261 VA: 0x2E160
	// RVA: 0x2E721C0 Offset: 0x2E722C1 VA: 0x2E721C0
	protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s, ICancelablePromise p2, IEnumerable<ICancelablePromise> p2s) { }

	[IteratorStateMachineAttribute] // RVA: 0x2E1D0 Offset: 0x2E2D1 VA: 0x2E1D0
	// RVA: 0x2E73130 Offset: 0x2E73231 VA: 0x2E73130
	protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s, ICancelablePromise p2, IEnumerable<ICancelablePromise> p2s, ICancelablePromise p3, IEnumerable<ICancelablePromise> p3s) { }

	[IteratorStateMachineAttribute] // RVA: 0x2E240 Offset: 0x2E341 VA: 0x2E240
	// RVA: 0x2E7A290 Offset: 0x2E7A391 VA: 0x2E7A290
	protected static IEnumerable<ICancelablePromise> Concat(ICancelablePromise p1, IEnumerable<ICancelablePromise> p1s, ICancelablePromise p2, IEnumerable<ICancelablePromise> p2s, ICancelablePromise p3, IEnumerable<ICancelablePromise> p3s, ICancelablePromise p4, IEnumerable<ICancelablePromise> p4s) { }

	[IteratorStateMachineAttribute] // RVA: 0x2E2B0 Offset: 0x2E3B1 VA: 0x2E2B0
	// RVA: 0x2E754A0 Offset: 0x2E755A1 VA: 0x2E754A0
	protected static IEnumerable<ICancelablePromise> Concat(object[] promises) { }

	// RVA: -1 Offset: -1
	protected UniTask<T> GetOrAddPromise<T>(ref AsyncTriggerPromise<T> promise, ref AsyncTriggerPromiseDictionary<T> promises, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2737270 Offset: 0x2737371 VA: 0x2737270
	|-AsyncTriggerBase.GetOrAddPromise<AsyncUnit>
	|
	|-RVA: 0x2737B10 Offset: 0x2737C11 VA: 0x2737B10
	|-AsyncTriggerBase.GetOrAddPromise<AxisEventData>
	|-AsyncTriggerBase.GetOrAddPromise<BaseEventData>
	|-AsyncTriggerBase.GetOrAddPromise<Collider>
	|-AsyncTriggerBase.GetOrAddPromise<Collider2D>
	|-AsyncTriggerBase.GetOrAddPromise<Collision>
	|-AsyncTriggerBase.GetOrAddPromise<Collision2D>
	|-AsyncTriggerBase.GetOrAddPromise<GameObject>
	|-AsyncTriggerBase.GetOrAddPromise<Joint2D>
	|-AsyncTriggerBase.GetOrAddPromise<object>
	|-AsyncTriggerBase.GetOrAddPromise<PointerEventData>
	|
	|-RVA: 0x27376C0 Offset: 0x27377C1 VA: 0x27376C0
	|-AsyncTriggerBase.GetOrAddPromise<int>
	|
	|-RVA: 0x2737F60 Offset: 0x2738061 VA: 0x2737F60
	|-AsyncTriggerBase.GetOrAddPromise<float>
	*/

	// RVA: 0x2E7A440 Offset: 0x2E7A541 VA: 0x2E7A440
	private static void CancelCallback(object state) { }

	// RVA: -1 Offset: -1
	protected void TrySetResult<T>(ReusablePromise<T> promise, AsyncTriggerPromiseDictionary<T> promises, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27383B0 Offset: 0x27384B1 VA: 0x27383B0
	|-AsyncTriggerBase.TrySetResult<AsyncUnit>
	|
	|-RVA: 0x27384C0 Offset: 0x27385C1 VA: 0x27384C0
	|-AsyncTriggerBase.TrySetResult<AxisEventData>
	|-AsyncTriggerBase.TrySetResult<BaseEventData>
	|-AsyncTriggerBase.TrySetResult<Collider>
	|-AsyncTriggerBase.TrySetResult<Collider2D>
	|-AsyncTriggerBase.TrySetResult<Collision>
	|-AsyncTriggerBase.TrySetResult<Collision2D>
	|-AsyncTriggerBase.TrySetResult<GameObject>
	|-AsyncTriggerBase.TrySetResult<Joint2D>
	|-AsyncTriggerBase.TrySetResult<object>
	|-AsyncTriggerBase.TrySetResult<PointerEventData>
	|
	|-RVA: 0x2738440 Offset: 0x2738541 VA: 0x2738440
	|-AsyncTriggerBase.TrySetResult<int>
	|
	|-RVA: 0x2738540 Offset: 0x2738641 VA: 0x2738540
	|-AsyncTriggerBase.TrySetResult<float>
	*/

	// RVA: 0x2E7A620 Offset: 0x2E7A721 VA: 0x2E7A620
	private void Awake() { }

	// RVA: 0x2E7A630 Offset: 0x2E7A731 VA: 0x2E7A630
	private void OnDestroy() { }

	// RVA: 0x2E72520 Offset: 0x2E72621 VA: 0x2E72520
	protected void .ctor() { }

	// RVA: 0x2E7AA20 Offset: 0x2E7AB21 VA: 0x2E7AA20
	private static void .cctor() { }
}

