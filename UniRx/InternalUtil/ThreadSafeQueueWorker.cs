// Namespace: UniRx.InternalUtil
public class ThreadSafeQueueWorker // TypeDefIndex: 7245
{
	// Fields
	private const int MaxArrayLength = 2146435071;
	private const int InitialSize = 16;
	private object gate; // 0x10
	private bool dequing; // 0x18
	private int actionListCount; // 0x1C
	private Action<object>[] actionList; // 0x20
	private object[] actionStates; // 0x28
	private int waitingListCount; // 0x30
	private Action<object>[] waitingList; // 0x38
	private object[] waitingStates; // 0x40

	// Methods

	// RVA: 0x1AF8C60 Offset: 0x1AF8D61 VA: 0x1AF8C60
	public void Enqueue(Action<object> action, object state) { }

	// RVA: 0x1AF9070 Offset: 0x1AF9171 VA: 0x1AF9070
	public void ExecuteAll(Action<Exception> unhandledExceptionCallback) { }

	// RVA: 0x1AF9500 Offset: 0x1AF9601 VA: 0x1AF9500
	public void .ctor() { }
}

