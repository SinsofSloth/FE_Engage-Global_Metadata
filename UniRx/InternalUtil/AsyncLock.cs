// Namespace: UniRx.InternalUtil
internal sealed class AsyncLock : IDisposable // TypeDefIndex: 7233
{
	// Fields
	private readonly Queue<Action> queue; // 0x10
	private bool isAcquired; // 0x18
	private bool hasFaulted; // 0x19

	// Methods

	// RVA: 0x19CC520 Offset: 0x19CC621 VA: 0x19CC520
	public void Wait(Action action) { }

	// RVA: 0x19CC940 Offset: 0x19CCA41 VA: 0x19CC940 Slot: 4
	public void Dispose() { }

	// RVA: 0x19CCA40 Offset: 0x19CCB41 VA: 0x19CCA40
	public void .ctor() { }
}

