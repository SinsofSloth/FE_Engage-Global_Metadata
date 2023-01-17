// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x473460 Offset: 0x473561 VA: 0x473460
[ClassInterfaceAttribute] // RVA: 0x473460 Offset: 0x473561 VA: 0x473460
[ComDefaultInterfaceAttribute] // RVA: 0x473460 Offset: 0x473561 VA: 0x473460
public sealed class Thread : CriticalFinalizerObject, _Thread // TypeDefIndex: 779
{
	// Fields
	private static LocalDataStoreMgr s_LocalDataStoreMgr; // 0x0
	[ThreadStaticAttribute] // RVA: 0x4790B0 Offset: 0x4791B1 VA: 0x4790B0
	private static LocalDataStoreHolder s_LocalDataStore; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x4790C0 Offset: 0x4791C1 VA: 0x4790C0
	internal static CultureInfo m_CurrentCulture; // 0x80000008
	[ThreadStaticAttribute] // RVA: 0x4790D0 Offset: 0x4791D1 VA: 0x4790D0
	internal static CultureInfo m_CurrentUICulture; // 0x80000010
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture; // 0x8
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture; // 0x10
	private InternalThread internal_thread; // 0x10
	private object m_ThreadStartArg; // 0x18
	private object pending_exception; // 0x20
	private IPrincipal principal; // 0x28
	private int principal_version; // 0x30
	[ThreadStaticAttribute] // RVA: 0x4790E0 Offset: 0x4791E1 VA: 0x4790E0
	private static Thread current_thread; // 0x80000018
	private MulticastDelegate m_Delegate; // 0x38
	private ExecutionContext m_ExecutionContext; // 0x40
	private bool m_ExecutionContextBelongsToOuterScope; // 0x48

	// Properties
	internal bool ExecutionContextBelongsToCurrentScope { get; set; }
	public ThreadPriority Priority { set; }
	public CultureInfo CurrentUICulture { get; }
	public CultureInfo CurrentCulture { get; set; }
	private InternalThread Internal { get; }
	public static Context CurrentContext { get; }
	public static Thread CurrentThread { get; }
	internal static int CurrentThreadId { get; }
	public bool IsThreadPoolThread { get; }
	internal bool IsThreadPoolThreadInternal { get; }
	public bool IsAlive { get; }
	public bool IsBackground { set; }
	public string Name { set; }
	public ThreadState ThreadState { get; }
	public int ManagedThreadId { get; }

	// Methods

	// RVA: 0x1B130D0 Offset: 0x1B131D1 VA: 0x1B130D0
	private static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<CultureInfo> args) { }

	// RVA: 0x1B13140 Offset: 0x1B13241 VA: 0x1B13140
	public void .ctor(ThreadStart start) { }

	// RVA: 0x1B133C0 Offset: 0x1B134C1 VA: 0x1B133C0
	public void .ctor(ParameterizedThreadStart start) { }

	// RVA: 0x1B13440 Offset: 0x1B13541 VA: 0x1B13440
	public void Start() { }

	// RVA: 0x1B13560 Offset: 0x1B13661 VA: 0x1B13560
	public void Start(object parameter) { }

	// RVA: 0x1B13470 Offset: 0x1B13571 VA: 0x1B13470
	private void Start(ref StackCrawlMark stackMark) { }

	[ReliabilityContractAttribute] // RVA: 0x47C810 Offset: 0x47C911 VA: 0x47C810
	// RVA: 0x1B136F0 Offset: 0x1B137F1 VA: 0x1B136F0
	internal ExecutionContext.Reader GetExecutionContextReader() { }

	// RVA: 0x1B13720 Offset: 0x1B13821 VA: 0x1B13720
	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	// RVA: 0x1B13730 Offset: 0x1B13831 VA: 0x1B13730
	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	[ReliabilityContractAttribute] // RVA: 0x47C830 Offset: 0x47C931 VA: 0x47C830
	// RVA: 0x1B13740 Offset: 0x1B13841 VA: 0x1B13740
	internal ExecutionContext GetMutableExecutionContext() { }

	[ReliabilityContractAttribute] // RVA: 0x47C850 Offset: 0x47C951 VA: 0x47C850
	// RVA: 0x1B137F0 Offset: 0x1B138F1 VA: 0x1B137F0
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[ReliabilityContractAttribute] // RVA: 0x47C870 Offset: 0x47C971 VA: 0x47C870
	// RVA: 0x1B13830 Offset: 0x1B13931 VA: 0x1B13830
	internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope) { }

	// RVA: 0x1B13870 Offset: 0x1B13971 VA: 0x1B13870
	public void set_Priority(ThreadPriority value) { }

	// RVA: 0x1B13880 Offset: 0x1B13981 VA: 0x1B13880
	private void SetPriorityNative(int priority) { }

	// RVA: 0x1B13890 Offset: 0x1B13991 VA: 0x1B13890
	private bool JoinInternal(int millisecondsTimeout) { }

	// RVA: 0x1B138A0 Offset: 0x1B139A1 VA: 0x1B138A0
	public void Join() { }

	// RVA: 0x1B138B0 Offset: 0x1B139B1 VA: 0x1B138B0
	public bool Join(int millisecondsTimeout) { }

	// RVA: 0x1B13930 Offset: 0x1B13A31 VA: 0x1B13930
	private static void SleepInternal(int millisecondsTimeout) { }

	// RVA: 0x1B13940 Offset: 0x1B13A41 VA: 0x1B13940
	public static void Sleep(int millisecondsTimeout) { }

	// RVA: 0x1B139C0 Offset: 0x1B13AC1 VA: 0x1B139C0
	public static void Sleep(TimeSpan timeout) { }

	[ReliabilityContractAttribute] // RVA: 0x47C890 Offset: 0x47C991 VA: 0x47C890
	// RVA: 0x1B13B20 Offset: 0x1B13C21 VA: 0x1B13B20
	private static bool YieldInternal() { }

	[ReliabilityContractAttribute] // RVA: 0x47C8B0 Offset: 0x47C9B1 VA: 0x47C8B0
	// RVA: 0x1B13B30 Offset: 0x1B13C31 VA: 0x1B13B30
	public static bool Yield() { }

	// RVA: 0x1B131C0 Offset: 0x1B132C1 VA: 0x1B131C0
	private void SetStartHelper(Delegate start, int maxStackSize) { }

	// RVA: 0x1B13CB0 Offset: 0x1B13DB1 VA: 0x1B13CB0
	public CultureInfo get_CurrentUICulture() { }

	// RVA: 0x1B13CC0 Offset: 0x1B13DC1 VA: 0x1B13CC0
	internal CultureInfo GetCurrentUICultureNoAppX() { }

	// RVA: 0x1B12650 Offset: 0x1B12751 VA: 0x1B12650
	public CultureInfo get_CurrentCulture() { }

	// RVA: 0x1B13E60 Offset: 0x1B13F61 VA: 0x1B13E60
	public void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x1B13D90 Offset: 0x1B13E91 VA: 0x1B13D90
	private CultureInfo GetCurrentCultureNoAppX() { }

	// RVA: 0x1B14050 Offset: 0x1B14151 VA: 0x1B14050
	private static void nativeInitCultureAccessors() { }

	// RVA: 0x1B14100 Offset: 0x1B14201 VA: 0x1B14100
	public static void MemoryBarrier() { }

	// RVA: 0x1B14110 Offset: 0x1B14211 VA: 0x1B14110
	private void ConstructInternalThread() { }

	// RVA: 0x1B14120 Offset: 0x1B14221 VA: 0x1B14120
	private InternalThread get_Internal() { }

	// RVA: 0x1B14160 Offset: 0x1B14261 VA: 0x1B14160
	public static Context get_CurrentContext() { }

	// RVA: 0x1B14170 Offset: 0x1B14271 VA: 0x1B14170
	private static Thread GetCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0x47C8D0 Offset: 0x47C9D1 VA: 0x47C8D0
	// RVA: 0x1B125F0 Offset: 0x1B126F1 VA: 0x1B125F0
	public static Thread get_CurrentThread() { }

	// RVA: 0x1B14180 Offset: 0x1B14281 VA: 0x1B14180
	internal static int get_CurrentThreadId() { }

	// RVA: 0x1B141E0 Offset: 0x1B142E1 VA: 0x1B141E0
	public static int GetDomainID() { }

	// RVA: 0x1B141F0 Offset: 0x1B142F1 VA: 0x1B141F0
	private IntPtr Thread_internal(MulticastDelegate start) { }

	[ReliabilityContractAttribute] // RVA: 0x47C8F0 Offset: 0x47C9F1 VA: 0x47C8F0
	// RVA: 0x1B14200 Offset: 0x1B14301 VA: 0x1B14200 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1B14210 Offset: 0x1B14311 VA: 0x1B14210
	public bool get_IsThreadPoolThread() { }

	// RVA: 0x1B14250 Offset: 0x1B14351 VA: 0x1B14250
	internal bool get_IsThreadPoolThreadInternal() { }

	// RVA: 0x1B14290 Offset: 0x1B14391 VA: 0x1B14290
	public bool get_IsAlive() { }

	// RVA: 0x1B14310 Offset: 0x1B14411 VA: 0x1B14310
	public void set_IsBackground(bool value) { }

	// RVA: 0x1B14410 Offset: 0x1B14511 VA: 0x1B14410
	private static void SetName_internal(InternalThread thread, string name) { }

	// RVA: 0x1B14420 Offset: 0x1B14521 VA: 0x1B14420
	public void set_Name(string value) { }

	// RVA: 0x1B14470 Offset: 0x1B14571 VA: 0x1B14470
	public ThreadState get_ThreadState() { }

	// RVA: 0x1B144B0 Offset: 0x1B145B1 VA: 0x1B144B0
	private static void SpinWait_nop() { }

	[ReliabilityContractAttribute] // RVA: 0x47C910 Offset: 0x47CA11 VA: 0x47C910
	// RVA: 0x1B144C0 Offset: 0x1B145C1 VA: 0x1B144C0
	public static void SpinWait(int iterations) { }

	// RVA: 0x1B13640 Offset: 0x1B13741 VA: 0x1B13640
	private void StartInternal(IPrincipal principal, ref StackCrawlMark stackMark) { }

	// RVA: 0x1B143F0 Offset: 0x1B144F1 VA: 0x1B143F0
	private static void SetState(InternalThread thread, ThreadState set) { }

	// RVA: 0x1B14400 Offset: 0x1B14501 VA: 0x1B14400
	private static void ClrState(InternalThread thread, ThreadState clr) { }

	// RVA: 0x1B14300 Offset: 0x1B14401 VA: 0x1B14300
	private static ThreadState GetState(InternalThread thread) { }

	// RVA: 0x1B14500 Offset: 0x1B14601 VA: 0x1B14500
	private static int SystemMaxStackStize() { }

	// RVA: 0x1B13B40 Offset: 0x1B13C41 VA: 0x1B13B40
	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	// RVA: 0x1B13C60 Offset: 0x1B13D61 VA: 0x1B13C60
	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	[ReliabilityContractAttribute] // RVA: 0x47C930 Offset: 0x47CA31 VA: 0x47C930
	// RVA: 0x1B14510 Offset: 0x1B14611 VA: 0x1B14510
	public int get_ManagedThreadId() { }

	[ReliabilityContractAttribute] // RVA: 0x47C950 Offset: 0x47CA51 VA: 0x47C950
	// RVA: 0x1B14550 Offset: 0x1B14651 VA: 0x1B14550
	public static void BeginCriticalRegion() { }

	[ReliabilityContractAttribute] // RVA: 0x47C970 Offset: 0x47CA71 VA: 0x47C970
	// RVA: 0x1B145F0 Offset: 0x1B146F1 VA: 0x1B145F0
	public static void EndCriticalRegion() { }

	[ComVisibleAttribute] // RVA: 0x47C990 Offset: 0x47CA91 VA: 0x47C990
	// RVA: 0x1B14690 Offset: 0x1B14791 VA: 0x1B14690 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B14370 Offset: 0x1B14471 VA: 0x1B14370
	private ThreadState ValidateThreadState() { }
}

