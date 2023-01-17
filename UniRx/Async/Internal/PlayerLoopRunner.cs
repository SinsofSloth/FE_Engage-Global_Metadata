// Namespace: UniRx.Async.Internal
internal sealed class PlayerLoopRunner // TypeDefIndex: 5216
{
	// Fields
	private const int InitialSize = 16;
	private readonly object runningAndQueueLock; // 0x10
	private readonly object arrayLock; // 0x18
	private readonly Action<Exception> unhandledExceptionCallback; // 0x20
	private int tail; // 0x28
	private bool running; // 0x2C
	private IPlayerLoopItem[] loopItems; // 0x30
	private MinimumQueue<IPlayerLoopItem> waitQueue; // 0x38

	// Methods

	// RVA: 0x2E840B0 Offset: 0x2E841B1 VA: 0x2E840B0
	public void .ctor() { }

	// RVA: 0x2E842D0 Offset: 0x2E843D1 VA: 0x2E842D0
	public void AddAction(IPlayerLoopItem item) { }

	// RVA: 0x2E847E0 Offset: 0x2E848E1 VA: 0x2E847E0
	public void Run() { }
}

