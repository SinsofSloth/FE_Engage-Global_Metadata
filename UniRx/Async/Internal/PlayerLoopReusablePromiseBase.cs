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

