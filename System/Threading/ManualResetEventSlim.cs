// Namespace: System.Threading
[DebuggerDisplayAttribute] // RVA: 0x473150 Offset: 0x473251 VA: 0x473150
[ComVisibleAttribute] // RVA: 0x473150 Offset: 0x473251 VA: 0x473150
public class ManualResetEventSlim : IDisposable // TypeDefIndex: 741
{
	// Fields
	private object m_lock; // 0x10
	private ManualResetEvent m_eventObj; // 0x18
	private int m_combinedState; // 0x20
	private static Action<object> s_cancellationTokenCallback; // 0x0

	// Properties
	public WaitHandle WaitHandle { get; }
	public bool IsSet { get; set; }
	public int SpinCount { get; set; }
	private int Waiters { get; set; }

	// Methods

	// RVA: 0x34E33C0 Offset: 0x34E34C1 VA: 0x34E33C0
	public WaitHandle get_WaitHandle() { }

	// RVA: 0x34E3680 Offset: 0x34E3781 VA: 0x34E3680
	public bool get_IsSet() { }

	// RVA: 0x34E3700 Offset: 0x34E3801 VA: 0x34E3700
	private void set_IsSet(bool value) { }

	// RVA: 0x34E37D0 Offset: 0x34E38D1 VA: 0x34E37D0
	public int get_SpinCount() { }

	// RVA: 0x34E3850 Offset: 0x34E3951 VA: 0x34E3850
	private void set_SpinCount(int value) { }

	// RVA: 0x34E3890 Offset: 0x34E3991 VA: 0x34E3890
	private int get_Waiters() { }

	// RVA: 0x34E3900 Offset: 0x34E3A01 VA: 0x34E3900
	private void set_Waiters(int value) { }

	// RVA: 0x34E39B0 Offset: 0x34E3AB1 VA: 0x34E39B0
	public void .ctor(bool initialState) { }

	// RVA: 0x34E3AA0 Offset: 0x34E3BA1 VA: 0x34E3AA0
	public void .ctor(bool initialState, int spinCount) { }

	// RVA: 0x34E3A30 Offset: 0x34E3B31 VA: 0x34E3A30
	private void Initialize(bool initialState, int spinCount) { }

	// RVA: 0x34E3C10 Offset: 0x34E3D11 VA: 0x34E3C10
	private void EnsureLockObjectCreated() { }

	// RVA: 0x34E3480 Offset: 0x34E3581 VA: 0x34E3480
	private bool LazyInitializeEvent() { }

	// RVA: 0x34E3D30 Offset: 0x34E3E31 VA: 0x34E3D30
	public void Set() { }

	// RVA: 0x34E3D40 Offset: 0x34E3E41 VA: 0x34E3D40
	private void Set(bool duringCancellation) { }

	// RVA: 0x34E4010 Offset: 0x34E4111 VA: 0x34E4010
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x34E4840 Offset: 0x34E4941 VA: 0x34E4840 Slot: 4
	public void Dispose() { }

	// RVA: 0x34E48C0 Offset: 0x34E49C1 VA: 0x34E48C0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x34E3400 Offset: 0x34E3501 VA: 0x34E3400
	private void ThrowIfDisposed() { }

	// RVA: 0x34E49E0 Offset: 0x34E4AE1 VA: 0x34E49E0
	private static void CancellationTokenCallback(object obj) { }

	// RVA: 0x34E3720 Offset: 0x34E3821 VA: 0x34E3720
	private void UpdateStateAtomically(int newBits, int updateBitsMask) { }

	// RVA: 0x34E3840 Offset: 0x34E3941 VA: 0x34E3840
	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount) { }

	// RVA: 0x34E36F0 Offset: 0x34E37F1 VA: 0x34E36F0
	private static int ExtractStatePortion(int state, int mask) { }

	// RVA: 0x34E4B70 Offset: 0x34E4C71 VA: 0x34E4B70
	private static void .cctor() { }
}

