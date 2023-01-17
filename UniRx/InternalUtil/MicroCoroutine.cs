// Namespace: UniRx.InternalUtil
public class MicroCoroutine // TypeDefIndex: 7240
{
	// Fields
	private const int InitialSize = 16;
	private readonly object runningAndQueueLock; // 0x10
	private readonly object arrayLock; // 0x18
	private readonly Action<Exception> unhandledExceptionCallback; // 0x20
	private int tail; // 0x28
	private bool running; // 0x2C
	private IEnumerator[] coroutines; // 0x30
	private Queue<IEnumerator> waitQueue; // 0x38

	// Methods

	// RVA: 0x19D4870 Offset: 0x19D4971 VA: 0x19D4870
	public void .ctor(Action<Exception> unhandledExceptionCallback) { }

	// RVA: 0x19D3730 Offset: 0x19D3831 VA: 0x19D3730
	public void AddCoroutine(IEnumerator enumerator) { }

	// RVA: 0x19D6060 Offset: 0x19D6161 VA: 0x19D6060
	public void Run() { }
}

