// Namespace: System.Threading
[Serializable]
public sealed class ExecutionContext : IDisposable, ISerializable // TypeDefIndex: 763
{
	// Fields
	private SynchronizationContext _syncContext; // 0x10
	private SynchronizationContext _syncContextNoFlow; // 0x18
	private LogicalCallContext _logicalCallContext; // 0x20
	private IllogicalCallContext _illogicalCallContext; // 0x28
	private ExecutionContext.Flags _flags; // 0x30
	private Dictionary<IAsyncLocal, object> _localValues; // 0x38
	private List<IAsyncLocal> _localChangeNotifications; // 0x40
	private static readonly ExecutionContext s_dummyDefaultEC; // 0x0

	// Properties
	internal bool isNewCapture { get; set; }
	internal bool isFlowSuppressed { get; set; }
	internal static ExecutionContext PreAllocatedDefault { get; }
	internal bool IsPreAllocatedDefault { get; }
	internal LogicalCallContext LogicalCallContext { get; set; }
	internal IllogicalCallContext IllogicalCallContext { get; set; }
	internal SynchronizationContext SynchronizationContext { get; set; }
	internal SynchronizationContext SynchronizationContextNoFlow { get; set; }

	// Methods

	// RVA: 0x3B63520 Offset: 0x3B63621 VA: 0x3B63520
	internal bool get_isNewCapture() { }

	// RVA: 0x3B63540 Offset: 0x3B63641 VA: 0x3B63540
	internal void set_isNewCapture(bool value) { }

	// RVA: 0x3B63560 Offset: 0x3B63661 VA: 0x3B63560
	internal bool get_isFlowSuppressed() { }

	// RVA: 0x3B63570 Offset: 0x3B63671 VA: 0x3B63570
	internal void set_isFlowSuppressed(bool value) { }

	// RVA: 0x3B63590 Offset: 0x3B63691 VA: 0x3B63590
	internal static ExecutionContext get_PreAllocatedDefault() { }

	// RVA: 0x3B63600 Offset: 0x3B63701 VA: 0x3B63600
	internal bool get_IsPreAllocatedDefault() { }

	[ReliabilityContractAttribute] // RVA: 0x47C660 Offset: 0x47C761 VA: 0x47C660
	// RVA: 0x3B63610 Offset: 0x3B63711 VA: 0x3B63610
	internal void .ctor() { }

	[ReliabilityContractAttribute] // RVA: 0x47C680 Offset: 0x47C781 VA: 0x47C680
	// RVA: 0x3B63620 Offset: 0x3B63721 VA: 0x3B63620
	internal void .ctor(bool isPreAllocatedDefault) { }

	// RVA: 0x3B63660 Offset: 0x3B63761 VA: 0x3B63660
	internal static void SetLocalValue(IAsyncLocal local, object newValue, bool needChangeNotifications) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0x47C6A0 Offset: 0x47C7A1 VA: 0x47C6A0
	// RVA: 0x3B63900 Offset: 0x3B63A01 VA: 0x3B63900
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	// RVA: 0x3B63E90 Offset: 0x3B63F91 VA: 0x3B63E90
	internal LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x3B63F20 Offset: 0x3B64021 VA: 0x3B63F20
	internal void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x3B63F30 Offset: 0x3B64031 VA: 0x3B63F30
	internal IllogicalCallContext get_IllogicalCallContext() { }

	// RVA: 0x3B63FC0 Offset: 0x3B640C1 VA: 0x3B63FC0
	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	[ReliabilityContractAttribute] // RVA: 0x47C6B0 Offset: 0x47C7B1 VA: 0x47C6B0
	// RVA: 0x3B63FD0 Offset: 0x3B640D1 VA: 0x3B63FD0
	internal SynchronizationContext get_SynchronizationContext() { }

	[ReliabilityContractAttribute] // RVA: 0x47C6D0 Offset: 0x47C7D1 VA: 0x47C6D0
	// RVA: 0x3B63FE0 Offset: 0x3B640E1 VA: 0x3B63FE0
	internal void set_SynchronizationContext(SynchronizationContext value) { }

	[ReliabilityContractAttribute] // RVA: 0x47C6F0 Offset: 0x47C7F1 VA: 0x47C6F0
	// RVA: 0x3B63FF0 Offset: 0x3B640F1 VA: 0x3B63FF0
	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	[ReliabilityContractAttribute] // RVA: 0x47C710 Offset: 0x47C811 VA: 0x47C710
	// RVA: 0x3B64000 Offset: 0x3B64101 VA: 0x3B64000
	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	// RVA: 0x3B64010 Offset: 0x3B64111 VA: 0x3B64010 Slot: 4
	public void Dispose() { }

	// RVA: 0x3B64020 Offset: 0x3B64121 VA: 0x3B64020
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[FriendAccessAllowedAttribute] // RVA: 0x47C730 Offset: 0x47C831 VA: 0x47C730
	// RVA: 0x3B64160 Offset: 0x3B64261 VA: 0x3B64160
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0x47C740 Offset: 0x47C841 VA: 0x47C740
	// RVA: 0x3B641F0 Offset: 0x3B642F1 VA: 0x3B641F0
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	// RVA: 0x3B647F0 Offset: 0x3B648F1 VA: 0x3B647F0
	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	// RVA: 0x3B644D0 Offset: 0x3B645D1 VA: 0x3B644D0
	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	[HandleProcessCorruptedStateExceptionsAttribute] // RVA: 0x47C750 Offset: 0x47C851 VA: 0x47C750
	// RVA: 0x3B64540 Offset: 0x3B64641 VA: 0x3B64540
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

	// RVA: 0x3B64950 Offset: 0x3B64A51 VA: 0x3B64950
	public ExecutionContext CreateCopy() { }

	// RVA: 0x3B64B20 Offset: 0x3B64C21 VA: 0x3B64B20
	internal ExecutionContext CreateMutableCopy() { }

	// RVA: 0x3B64D20 Offset: 0x3B64E21 VA: 0x3B64D20
	public static AsyncFlowControl SuppressFlow() { }

	// RVA: 0x3B64E90 Offset: 0x3B64F91 VA: 0x3B64E90
	public static void RestoreFlow() { }

	// RVA: 0x3B64E30 Offset: 0x3B64F31 VA: 0x3B64E30
	public static bool IsFlowSuppressed() { }

	// RVA: 0x3B64F10 Offset: 0x3B65011 VA: 0x3B64F10
	public static ExecutionContext Capture() { }

	[FriendAccessAllowedAttribute] // RVA: 0x47C760 Offset: 0x47C861 VA: 0x47C760
	// RVA: 0x3B651C0 Offset: 0x3B652C1 VA: 0x3B651C0
	internal static ExecutionContext FastCapture() { }

	// RVA: 0x3B64F80 Offset: 0x3B65081 VA: 0x3B64F80
	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options) { }

	// RVA: 0x3B65230 Offset: 0x3B65331 VA: 0x3B65230 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3B65350 Offset: 0x3B65451 VA: 0x3B65350
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3B64440 Offset: 0x3B64541 VA: 0x3B64440
	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x3B65450 Offset: 0x3B65551 VA: 0x3B65450
	private static void .cctor() { }
}

