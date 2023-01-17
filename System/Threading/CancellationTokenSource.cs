// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x4730F0 Offset: 0x4731F1 VA: 0x4730F0
public class CancellationTokenSource : IDisposable // TypeDefIndex: 733
{
	// Fields
	private static readonly CancellationTokenSource _staticSource_Set; // 0x0
	private static readonly CancellationTokenSource _staticSource_NotCancelable; // 0x8
	private static readonly int s_nLists; // 0x10
	private ManualResetEvent m_kernelEvent; // 0x10
	private SparselyPopulatedArray<CancellationCallbackInfo>[] m_registeredCallbacksLists; // 0x18
	private const int CANNOT_BE_CANCELED = 0;
	private const int NOT_CANCELED = 1;
	private const int NOTIFYING = 2;
	private const int NOTIFYINGCOMPLETE = 3;
	private int m_state; // 0x20
	private int m_threadIDExecutingCallbacks; // 0x24
	private bool m_disposed; // 0x28
	private CancellationTokenRegistration[] m_linkingRegistrations; // 0x30
	private static readonly Action<object> s_LinkedTokenCancelDelegate; // 0x18
	private CancellationCallbackInfo m_executingCallback; // 0x38
	private Timer m_timer; // 0x40
	private static readonly TimerCallback s_timerCallback; // 0x20

	// Properties
	public bool IsCancellationRequested { get; }
	internal bool IsCancellationCompleted { get; }
	internal bool IsDisposed { get; }
	internal int ThreadIDExecutingCallbacks { get; set; }
	public CancellationToken Token { get; }
	internal bool CanBeCanceled { get; }
	internal CancellationCallbackInfo ExecutingCallback { get; }

	// Methods

	// RVA: 0x35177B0 Offset: 0x35178B1 VA: 0x35177B0
	private static void LinkedTokenCancelDelegate(object source) { }

	// RVA: 0x35163C0 Offset: 0x35164C1 VA: 0x35163C0
	public bool get_IsCancellationRequested() { }

	// RVA: 0x35174C0 Offset: 0x35175C1 VA: 0x35174C0
	internal bool get_IsCancellationCompleted() { }

	// RVA: 0x3517900 Offset: 0x3517A01 VA: 0x3517900
	internal bool get_IsDisposed() { }

	// RVA: 0x3517910 Offset: 0x3517A11 VA: 0x3517910
	internal void set_ThreadIDExecutingCallbacks(int value) { }

	// RVA: 0x35174F0 Offset: 0x35175F1 VA: 0x35174F0
	internal int get_ThreadIDExecutingCallbacks() { }

	// RVA: 0x3517940 Offset: 0x3517A41 VA: 0x3517940
	public CancellationToken get_Token() { }

	// RVA: 0x3516430 Offset: 0x3516531 VA: 0x3516430
	internal bool get_CanBeCanceled() { }

	// RVA: 0x3517A40 Offset: 0x3517B41 VA: 0x3517A40
	internal CancellationCallbackInfo get_ExecutingCallback() { }

	// RVA: 0x3517A70 Offset: 0x3517B71 VA: 0x3517A70
	public void .ctor() { }

	// RVA: 0x3517AB0 Offset: 0x3517BB1 VA: 0x3517AB0
	private void .ctor(bool set) { }

	// RVA: 0x3517890 Offset: 0x3517991 VA: 0x3517890
	public void Cancel() { }

	// RVA: 0x3517B00 Offset: 0x3517C01 VA: 0x3517B00
	public void Cancel(bool throwOnFirstException) { }

	// RVA: 0x3517CE0 Offset: 0x3517DE1 VA: 0x3517CE0
	public void CancelAfter(int millisecondsDelay) { }

	// RVA: 0x3517F30 Offset: 0x3518031 VA: 0x3517F30
	private static void TimerCallbackLogic(object obj) { }

	// RVA: 0x35180A0 Offset: 0x35181A1 VA: 0x35180A0 Slot: 4
	public void Dispose() { }

	// RVA: 0x3518120 Offset: 0x3518221 VA: 0x3518120 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x35179D0 Offset: 0x3517AD1 VA: 0x35179D0
	internal void ThrowIfDisposed() { }

	// RVA: 0x3518240 Offset: 0x3518341 VA: 0x3518240
	private static void ThrowObjectDisposedException() { }

	// RVA: 0x3516E40 Offset: 0x3516F41 VA: 0x3516E40
	internal static CancellationTokenSource InternalGetStaticSource(bool set) { }

	// RVA: 0x3516910 Offset: 0x3516A11 VA: 0x3516910
	internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	// RVA: 0x3517B80 Offset: 0x3517C81 VA: 0x3517B80
	private void NotifyCancellation(bool throwOnFirstException) { }

	// RVA: 0x35182A0 Offset: 0x35183A1 VA: 0x35182A0
	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	// RVA: 0x3518860 Offset: 0x3518961 VA: 0x3518860
	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	// RVA: 0x3518790 Offset: 0x3518891 VA: 0x3518790
	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	// RVA: 0x35188F0 Offset: 0x35189F1 VA: 0x35188F0
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	// RVA: 0x3518B20 Offset: 0x3518C21 VA: 0x3518B20
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken[] tokens) { }

	// RVA: 0x3517520 Offset: 0x3517621 VA: 0x3517520
	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

	// RVA: 0x3518D70 Offset: 0x3518E71 VA: 0x3518D70
	private static void .cctor() { }
}

