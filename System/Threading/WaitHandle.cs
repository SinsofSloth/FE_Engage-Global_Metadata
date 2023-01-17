// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x473630 Offset: 0x473731 VA: 0x473630
public abstract class WaitHandle : MarshalByRefObject, IDisposable // TypeDefIndex: 800
{
	// Fields
	public const int WaitTimeout = 258;
	private const int MAX_WAITHANDLES = 64;
	private IntPtr waitHandle; // 0x18
	internal SafeWaitHandle safeWaitHandle; // 0x20
	internal bool hasThreadAffinity; // 0x28
	private const int WAIT_OBJECT_0 = 0;
	private const int WAIT_ABANDONED = 128;
	private const int WAIT_FAILED = 2147483647;
	private const int ERROR_TOO_MANY_POSTS = 298;
	protected static readonly IntPtr InvalidHandle; // 0x0
	internal const int MaxWaitHandles = 64;

	// Properties
	[ObsoleteAttribute] // RVA: 0x47E0C0 Offset: 0x47E1C1 VA: 0x47E0C0
	public virtual IntPtr Handle { set; }
	public SafeWaitHandle SafeWaitHandle { get; set; }

	// Methods

	// RVA: 0x34CF330 Offset: 0x34CF431 VA: 0x34CF330
	protected void .ctor() { }

	// RVA: 0x34CF3D0 Offset: 0x34CF4D1 VA: 0x34CF3D0
	private void Init() { }

	// RVA: 0x34CF460 Offset: 0x34CF561 VA: 0x34CF460 Slot: 7
	public virtual void set_Handle(IntPtr value) { }

	[ReliabilityContractAttribute] // RVA: 0x47C9D0 Offset: 0x47CAD1 VA: 0x47C9D0
	// RVA: 0x34CF570 Offset: 0x34CF671 VA: 0x34CF570
	public SafeWaitHandle get_SafeWaitHandle() { }

	[ReliabilityContractAttribute] // RVA: 0x47C9F0 Offset: 0x47CAF1 VA: 0x47C9F0
	// RVA: 0x34CF640 Offset: 0x34CF741 VA: 0x34CF640
	public void set_SafeWaitHandle(SafeWaitHandle value) { }

	// RVA: 0x34CF700 Offset: 0x34CF801 VA: 0x34CF700
	internal void SetHandleInternal(SafeWaitHandle handle) { }

	// RVA: 0x34CF740 Offset: 0x34CF841 VA: 0x34CF740 Slot: 8
	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x34CF8E0 Offset: 0x34CF9E1 VA: 0x34CF8E0 Slot: 9
	public virtual bool WaitOne(TimeSpan timeout, bool exitContext) { }

	// RVA: 0x34CFA20 Offset: 0x34CFB21 VA: 0x34CFA20 Slot: 10
	public virtual bool WaitOne() { }

	// RVA: 0x34CFA40 Offset: 0x34CFB41 VA: 0x34CFA40 Slot: 11
	public virtual bool WaitOne(int millisecondsTimeout) { }

	// RVA: 0x34CFA50 Offset: 0x34CFB51 VA: 0x34CFA50 Slot: 12
	public virtual bool WaitOne(TimeSpan timeout) { }

	// RVA: 0x34CF840 Offset: 0x34CF941 VA: 0x34CF840
	private bool WaitOne(long timeout, bool exitContext) { }

	// RVA: 0x34CFA60 Offset: 0x34CFB61 VA: 0x34CFA60
	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	[ReliabilityContractAttribute] // RVA: 0x47CA10 Offset: 0x47CB11 VA: 0x47CA10
	// RVA: 0x34CFCF0 Offset: 0x34CFDF1 VA: 0x34CFCF0
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	[ReliabilityContractAttribute] // RVA: 0x47CA30 Offset: 0x47CB31 VA: 0x47CA30
	// RVA: 0x34D0340 Offset: 0x34D0441 VA: 0x34D0340
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext) { }

	[ReliabilityContractAttribute] // RVA: 0x47CA50 Offset: 0x47CB51 VA: 0x47CA50
	// RVA: 0x34D0460 Offset: 0x34D0561 VA: 0x34D0460
	public static int WaitAny(WaitHandle[] waitHandles) { }

	// RVA: 0x34CFCB0 Offset: 0x34CFDB1 VA: 0x34CFCB0
	private static void ThrowAbandonedMutexException() { }

	// RVA: 0x34D02E0 Offset: 0x34D03E1 VA: 0x34D02E0
	private static void ThrowAbandonedMutexException(int location, WaitHandle handle) { }

	// RVA: 0x34D04D0 Offset: 0x34D05D1 VA: 0x34D04D0 Slot: 13
	public virtual void Close() { }

	// RVA: 0x34D0560 Offset: 0x34D0661 VA: 0x34D0560 Slot: 14
	protected virtual void Dispose(bool explicitDisposing) { }

	// RVA: 0x34D05B0 Offset: 0x34D06B1 VA: 0x34D05B0 Slot: 6
	public void Dispose() { }

	// RVA: 0x34D0010 Offset: 0x34D0111 VA: 0x34D0010
	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll) { }

	// RVA: 0x34CFB70 Offset: 0x34CFC71 VA: 0x34CFB70
	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	// RVA: 0x34D0640 Offset: 0x34D0741 VA: 0x34D0640
	private static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms) { }

	// RVA: 0x34D0650 Offset: 0x34D0751 VA: 0x34D0650
	private static void .cctor() { }
}

