// Namespace: UniRx.Async.Internal
public abstract class PlayerLoopReusablePromiseBase : ReusablePromise, IPlayerLoopItem // TypeDefIndex: 5220
{
	// Fields
	private readonly PlayerLoopTiming timing; // 0x24
	protected readonly CancellationToken cancellationToken; // 0x28
	private bool isRunning; // 0x30

	// Properties
	public override bool IsCompleted { get; }

	// Methods

	// RVA: 0x2E84670 Offset: 0x2E84771 VA: 0x2E84670
	public void .ctor(PlayerLoopTiming timing, CancellationToken cancellationToken, int skipTrackFrameCountAdditive) { }

	// RVA: 0x2E846D0 Offset: 0x2E847D1 VA: 0x2E846D0 Slot: 9
	public override bool get_IsCompleted() { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void OnRunningStart();

	// RVA: 0x2E847D0 Offset: 0x2E848D1 VA: 0x2E847D0
	protected void Complete() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract bool MoveNext();
}

// Namespace: UniRx.Async.Internal
public abstract class PlayerLoopReusablePromiseBase<T> : ReusablePromise<T>, IPlayerLoopItem // TypeDefIndex: 5221
{
	// Fields
	private readonly PlayerLoopTiming timing; // 0x0
	protected readonly CancellationToken cancellationToken; // 0x0
	private bool isRunning; // 0x0

	// Properties
	public override bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(PlayerLoopTiming timing, CancellationToken cancellationToken, int skipTrackFrameCountAdditive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A614D0 Offset: 0x2A615D1 VA: 0x2A614D0
	|-PlayerLoopReusablePromiseBase<int>..ctor
	|
	|-RVA: 0x2A61610 Offset: 0x2A61711 VA: 0x2A61610
	|-PlayerLoopReusablePromiseBase<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A61520 Offset: 0x2A61621 VA: 0x2A61520
	|-PlayerLoopReusablePromiseBase<int>.get_IsCompleted
	|
	|-RVA: 0x2A61660 Offset: 0x2A61761 VA: 0x2A61660
	|-PlayerLoopReusablePromiseBase<object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void OnRunningStart();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-PlayerLoopReusablePromiseBase<object>.OnRunningStart
	*/

	// RVA: -1 Offset: -1
	protected void Complete() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2A61600 Offset: 0x2A61701 VA: 0x2A61600
	|-PlayerLoopReusablePromiseBase<int>.Complete
	|
	|-RVA: 0x2A61740 Offset: 0x2A61841 VA: 0x2A61740
	|-PlayerLoopReusablePromiseBase<object>.Complete
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool MoveNext();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-PlayerLoopReusablePromiseBase<object>.MoveNext
	*/
}

