// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x4736D0 Offset: 0x4737D1 VA: 0x4736D0
public sealed class RegisteredWaitHandle : MarshalByRefObject // TypeDefIndex: 808
{
	// Fields
	private WaitHandle _waitObject; // 0x18
	private WaitOrTimerCallback _callback; // 0x20
	private object _state; // 0x28
	private WaitHandle _finalEvent; // 0x30
	private ManualResetEvent _cancelEvent; // 0x38
	private TimeSpan _timeout; // 0x40
	private int _callsInProcess; // 0x48
	private bool _executeOnlyOnce; // 0x4C
	private bool _unregistered; // 0x4D

	// Methods

	// RVA: 0x3B744F0 Offset: 0x3B745F1 VA: 0x3B744F0
	internal void .ctor(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x3B745F0 Offset: 0x3B746F1 VA: 0x3B745F0
	internal void Wait(object state) { }

	// RVA: 0x3B74BD0 Offset: 0x3B74CD1 VA: 0x3B74BD0
	private void DoCallBack(object timedOut) { }

	[ComVisibleAttribute] // RVA: 0x47CC90 Offset: 0x47CD91 VA: 0x47CC90
	// RVA: 0x3B74DA0 Offset: 0x3B74EA1 VA: 0x3B74DA0
	public bool Unregister(WaitHandle waitObject) { }
}

