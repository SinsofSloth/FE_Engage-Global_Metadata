// Namespace: UniRx.Async.Internal
internal class ContinuationQueue // TypeDefIndex: 5209
{
	// Fields
	private const int MaxArrayLength = 2146435071;
	private const int InitialSize = 16;
	private SpinLock gate; // 0x10
	private bool dequing; // 0x14
	private int actionListCount; // 0x18
	private Action[] actionList; // 0x20
	private int waitingListCount; // 0x28
	private Action[] waitingList; // 0x30

	// Methods

	// RVA: 0x2E7FB00 Offset: 0x2E7FC01 VA: 0x2E7FB00
	public void Enqueue(Action continuation) { }

	// RVA: 0x2E7FDB0 Offset: 0x2E7FEB1 VA: 0x2E7FDB0
	public void Run() { }

	// RVA: 0x2E80030 Offset: 0x2E80131 VA: 0x2E80030
	public void .ctor() { }
}

