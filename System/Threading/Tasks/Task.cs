// Namespace: System.Threading.Tasks
[DebuggerTypeProxyAttribute] // RVA: 0x473840 Offset: 0x473941 VA: 0x473840
[DebuggerDisplayAttribute] // RVA: 0x473840 Offset: 0x473941 VA: 0x473840
public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 836
{
	// Fields
	[ThreadStaticAttribute] // RVA: 0x479120 Offset: 0x479221 VA: 0x479120
	internal static Task t_currentTask; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x479130 Offset: 0x479231 VA: 0x479130
	private static StackGuard t_stackGuard; // 0x80000008
	internal static int s_taskIdCounter; // 0x0
	private static readonly TaskFactory s_factory; // 0x8
	private int m_taskId; // 0x10
	internal object m_action; // 0x18
	internal object m_stateObject; // 0x20
	internal TaskScheduler m_taskScheduler; // 0x28
	internal readonly Task m_parent; // 0x30
	internal int m_stateFlags; // 0x38
	private object m_continuationObject; // 0x40
	private static readonly object s_taskCompletionSentinel; // 0x10
	[FriendAccessAllowedAttribute] // RVA: 0x479140 Offset: 0x479241 VA: 0x479140
	internal static bool s_asyncDebuggingEnabled; // 0x18
	private static readonly Dictionary<int, Task> s_currentActiveTasks; // 0x20
	private static readonly object s_activeTasksLock; // 0x28
	internal Task.ContingentProperties m_contingentProperties; // 0x48
	private static readonly Action<object> s_taskCancelCallback; // 0x30
	private static readonly Func<Task.ContingentProperties> s_createContingentProperties; // 0x38
	private static Task s_completedTask; // 0x40
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; // 0x48
	private static ContextCallback s_ecCallback; // 0x50
	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate; // 0x58

	// Properties
	internal TaskCreationOptions Options { get; }
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion { get; }
	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion { get; }
	internal bool IsWaitNotificationEnabled { get; }
	public int Id { get; }
	internal static Task InternalCurrent { get; }
	internal static StackGuard CurrentStackGuard { get; }
	public AggregateException Exception { get; }
	public TaskStatus Status { get; }
	public bool IsCanceled { get; }
	internal bool IsCancellationRequested { get; }
	internal CancellationToken CancellationToken { get; }
	internal bool IsCancellationAcknowledged { get; }
	public bool IsCompleted { get; }
	internal bool IsRanToCompletion { get; }
	public TaskCreationOptions CreationOptions { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }
	public object AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	internal TaskScheduler ExecutingTaskScheduler { get; }
	public static TaskFactory Factory { get; }
	public static Task CompletedTask { get; }
	internal ManualResetEventSlim CompletedEvent { get; }
	internal bool IsSelfReplicatingRoot { get; }
	internal bool IsChildReplica { get; }
	internal bool ExceptionRecorded { get; }
	public bool IsFaulted { get; }
	internal ExecutionContext CapturedContext { get; set; }
	internal bool IsExceptionObservedByParent { get; }
	internal bool IsDelegateInvoked { get; }
	internal virtual object SavedStateForNextReplica { get; }
	internal virtual object SavedStateFromPreviousReplica { set; }
	internal virtual Task HandedOverChildReplica { get; set; }

	// Methods

	[FriendAccessAllowedAttribute] // RVA: 0x47CDA0 Offset: 0x47CEA1 VA: 0x47CDA0
	// RVA: 0x365F5C0 Offset: 0x365F6C1 VA: 0x365F5C0
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowedAttribute] // RVA: 0x47CDB0 Offset: 0x47CEB1 VA: 0x47CDB0
	// RVA: 0x365F830 Offset: 0x365F931 VA: 0x365F830
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x365F990 Offset: 0x365FA91 VA: 0x365F990
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x365FA60 Offset: 0x365FB61 VA: 0x365FA60
	internal void .ctor() { }

	// RVA: 0x365FAA0 Offset: 0x365FBA1 VA: 0x365FAA0
	internal void .ctor(object state, TaskCreationOptions creationOptions, bool promiseStyle) { }

	// RVA: 0x365FDD0 Offset: 0x365FED1 VA: 0x365FDD0
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x365FC10 Offset: 0x365FD11 VA: 0x365FC10
	internal void TaskConstructorCore(object action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x3660090 Offset: 0x3660191 VA: 0x3660090
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x36609D0 Offset: 0x3660AD1 VA: 0x36609D0
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x3660D60 Offset: 0x3660E61 VA: 0x3660D60
	internal void PossiblyCaptureContext(ref StackCrawlMark stackMark) { }

	// RVA: 0x3660500 Offset: 0x3660601 VA: 0x3660500
	internal TaskCreationOptions get_Options() { }

	// RVA: 0x3660EC0 Offset: 0x3660FC1 VA: 0x3660EC0
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x3660ED0 Offset: 0x3660FD1 VA: 0x3660ED0
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x3660F70 Offset: 0x3661071 VA: 0x3660F70
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x3661020 Offset: 0x3661121 VA: 0x3661020
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x36610F0 Offset: 0x36611F1 VA: 0x36610F0
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x36611B0 Offset: 0x36612B1 VA: 0x36611B0
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x36611F0 Offset: 0x36612F1 VA: 0x36611F0 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x3661150 Offset: 0x3661251 VA: 0x3661150
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x3661180 Offset: 0x3661281 VA: 0x3661180
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x3661220 Offset: 0x3661321 VA: 0x3661220
	internal bool MarkStarted() { }

	// RVA: 0x36612D0 Offset: 0x36613D1 VA: 0x36612D0
	internal bool FireTaskScheduledIfNeeded(TaskScheduler ts) { }

	// RVA: 0x365FF20 Offset: 0x3660021 VA: 0x365FF20
	internal void AddNewChild() { }

	// RVA: 0x3660910 Offset: 0x3660A11 VA: 0x3660910
	internal void DisregardChild() { }

	// RVA: 0x3661360 Offset: 0x3661461 VA: 0x3661360
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x3661950 Offset: 0x3661A51 VA: 0x3661950
	internal static int NewId() { }

	// RVA: 0x365F730 Offset: 0x365F831 VA: 0x365F730
	public int get_Id() { }

	// RVA: 0x36619D0 Offset: 0x3661AD1 VA: 0x36619D0
	internal static Task get_InternalCurrent() { }

	// RVA: 0x3661A40 Offset: 0x3661B41 VA: 0x3661A40
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x3661B20 Offset: 0x3661C21 VA: 0x3661B20
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x3661C00 Offset: 0x3661D01 VA: 0x3661C00
	public AggregateException get_Exception() { }

	// RVA: 0x3661E70 Offset: 0x3661F71 VA: 0x3661E70
	public TaskStatus get_Status() { }

	// RVA: 0x3661F10 Offset: 0x3662011 VA: 0x3661F10
	public bool get_IsCanceled() { }

	// RVA: 0x3661F40 Offset: 0x3662041 VA: 0x3661F40
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x36604B0 Offset: 0x36605B1 VA: 0x36604B0
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x3661FA0 Offset: 0x36620A1 VA: 0x3661FA0
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x3662090 Offset: 0x3662191 VA: 0x3662090
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x36620D0 Offset: 0x36621D1 VA: 0x36620D0
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x3662100 Offset: 0x3662201 VA: 0x3662100 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x3662180 Offset: 0x3662281 VA: 0x3662180
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x3662190 Offset: 0x3662291 VA: 0x3662190
	internal bool get_IsRanToCompletion() { }

	// RVA: 0x365FEB0 Offset: 0x365FFB1 VA: 0x365FEB0
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x36621D0 Offset: 0x36622D1 VA: 0x36621D0 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x3662470 Offset: 0x3662571 VA: 0x3662470 Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x3662480 Offset: 0x3662581 VA: 0x3662480 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x3662490 Offset: 0x3662591 VA: 0x3662490
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	// RVA: 0x36624A0 Offset: 0x36625A1 VA: 0x36624A0
	public static TaskFactory get_Factory() { }

	// RVA: 0x3662510 Offset: 0x3662611 VA: 0x3662510
	public static Task get_CompletedTask() { }

	// RVA: 0x3662260 Offset: 0x3662361 VA: 0x3662260
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x36612E0 Offset: 0x36613E1 VA: 0x36612E0
	internal bool get_IsSelfReplicatingRoot() { }

	// RVA: 0x3662610 Offset: 0x3662711 VA: 0x3662610
	internal bool get_IsChildReplica() { }

	// RVA: 0x3662680 Offset: 0x3662781 VA: 0x3662680
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x3661C40 Offset: 0x3661D41 VA: 0x3661C40
	public bool get_IsFaulted() { }

	// RVA: 0x3662710 Offset: 0x3662811 VA: 0x3662710
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x3660DE0 Offset: 0x3660EE1 VA: 0x3660DE0
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x3662810 Offset: 0x3662911 VA: 0x3662810
	private static ExecutionContext CopyExecutionContext(ExecutionContext capturedContext) { }

	// RVA: 0x3662910 Offset: 0x3662A11 VA: 0x3662910 Slot: 10
	public void Dispose() { }

	// RVA: 0x3662990 Offset: 0x3662A91 VA: 0x3662990 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x36614D0 Offset: 0x36615D1 VA: 0x36614D0
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x3662B20 Offset: 0x3662C21 VA: 0x3662B20
	internal void AddException(object exceptionObject) { }

	// RVA: 0x3662FF0 Offset: 0x36630F1 VA: 0x3662FF0
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x3661C70 Offset: 0x3661D71 VA: 0x3661C70
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x3663650 Offset: 0x3663751 VA: 0x3663650
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x3663840 Offset: 0x3663941 VA: 0x3663840
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x3663890 Offset: 0x3663991 VA: 0x3663890
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x36638E0 Offset: 0x36639E1 VA: 0x36638E0
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x3663A60 Offset: 0x3663B61 VA: 0x3663A60
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x3663A90 Offset: 0x3663B91 VA: 0x3663A90
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x3662CF0 Offset: 0x3662DF1 VA: 0x3662CF0
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x3663AC0 Offset: 0x3663BC1 VA: 0x3663AC0
	internal void FinishStageTwo() { }

	// RVA: 0x3663FD0 Offset: 0x36640D1 VA: 0x3663FD0
	internal void FinishStageThree() { }

	// RVA: 0x3664080 Offset: 0x3664181 VA: 0x3664080
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x3663D60 Offset: 0x3663E61 VA: 0x3663D60
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x3662B30 Offset: 0x3662C31 VA: 0x3662B30
	internal void FinishThreadAbortedTask(bool bTAEAddedToExceptionHolder, bool delegateRan) { }

	// RVA: 0x36648C0 Offset: 0x36649C1 VA: 0x36648C0
	private void Execute() { }

	// RVA: 0x3664D80 Offset: 0x3664E81 VA: 0x3664D80 Slot: 13
	internal virtual bool ShouldReplicate() { }

	// RVA: 0x3664D90 Offset: 0x3664E91 VA: 0x3664D90 Slot: 14
	internal virtual Task CreateReplicaTask(Action<object> taskReplicaDelegate, object stateObject, Task parentTask, TaskScheduler taskScheduler, TaskCreationOptions creationOptionsForReplica, InternalTaskOptions internalOptionsForReplica) { }

	// RVA: 0x3664E40 Offset: 0x3664F41 VA: 0x3664E40 Slot: 15
	internal virtual object get_SavedStateForNextReplica() { }

	// RVA: 0x3664E50 Offset: 0x3664F51 VA: 0x3664E50 Slot: 16
	internal virtual void set_SavedStateFromPreviousReplica(object value) { }

	// RVA: 0x3664E60 Offset: 0x3664F61 VA: 0x3664E60 Slot: 17
	internal virtual Task get_HandedOverChildReplica() { }

	// RVA: 0x3664E70 Offset: 0x3664F71 VA: 0x3664E70 Slot: 18
	internal virtual void set_HandedOverChildReplica(Task value) { }

	// RVA: 0x3664AC0 Offset: 0x3664BC1 VA: 0x3664AC0
	private static void ExecuteSelfReplicating(Task root) { }

	// RVA: 0x3664E80 Offset: 0x3664F81 VA: 0x3664E80 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x3664E90 Offset: 0x3664F91 VA: 0x3664E90 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x365DE60 Offset: 0x365DF61 VA: 0x365DE60
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x3664F40 Offset: 0x3665041 VA: 0x3664F40
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x3665340 Offset: 0x3665441 VA: 0x3665340
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x36653D0 Offset: 0x36654D1 VA: 0x36653D0 Slot: 19
	internal virtual void InnerInvoke() { }

	// RVA: 0x3665490 Offset: 0x3665591 VA: 0x3665490
	internal void InnerInvokeWithArg(Task childTask) { }

	// RVA: 0x3664C40 Offset: 0x3664D41 VA: 0x3664C40
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x36654F0 Offset: 0x36655F1 VA: 0x36654F0
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x3665520 Offset: 0x3665621 VA: 0x3665520
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x3665560 Offset: 0x3665661 VA: 0x3665560
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext, ref StackCrawlMark stackMark) { }

	// RVA: 0x3665AB0 Offset: 0x3665BB1 VA: 0x3665AB0
	public void Wait() { }

	// RVA: 0x3665AC0 Offset: 0x3665BC1 VA: 0x3665AC0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x3665ED0 Offset: 0x3665FD1 VA: 0x3665ED0
	private bool WrappedTryRunInline() { }

	// RVA: 0x3665C30 Offset: 0x3665D31 VA: 0x3665C30
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x36661B0 Offset: 0x36662B1 VA: 0x36661B0
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x3666450 Offset: 0x3666551 VA: 0x3666450
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x3660570 Offset: 0x3660671 VA: 0x3660570
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x3666690 Offset: 0x3666791 VA: 0x3666690
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x3666750 Offset: 0x3666851 VA: 0x3666750
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x3666800 Offset: 0x3666901 VA: 0x3666800
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x3665230 Offset: 0x3665331 VA: 0x3665230
	internal void CancellationCleanupLogic() { }

	// RVA: 0x36654C0 Offset: 0x36655C1 VA: 0x36654C0
	private void SetCancellationAcknowledged() { }

	// RVA: 0x3664250 Offset: 0x3664351 VA: 0x3664250
	internal void FinishContinuations() { }

	// RVA: 0x3666840 Offset: 0x3666941 VA: 0x3666840
	private void LogFinishCompletionNotification() { }

	// RVA: 0x3666870 Offset: 0x3666971 VA: 0x3666870
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x3666B90 Offset: 0x3666C91 VA: 0x3666B90
	public Task ContinueWith(Action<Task> continuationAction, TaskContinuationOptions continuationOptions) { }

	// RVA: 0x3666A10 Offset: 0x3666B11 VA: 0x3666A10
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x3666F10 Offset: 0x3667011 VA: 0x3666F10
	public Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler) { }

	// RVA: 0x36670D0 Offset: 0x36671D1 VA: 0x36670D0
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x3666F40 Offset: 0x3667041 VA: 0x3666F40
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x3666C30 Offset: 0x3666D31 VA: 0x3666C30
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x3666D50 Offset: 0x3666E51 VA: 0x3666D50
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x3667110 Offset: 0x3667211 VA: 0x3667110
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x36665C0 Offset: 0x36666C1 VA: 0x36665C0
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x36671E0 Offset: 0x36672E1 VA: 0x36671E0
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x36659C0 Offset: 0x3665AC1 VA: 0x36659C0
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x3660AC0 Offset: 0x3660BC1 VA: 0x3660AC0
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20251F0 Offset: 0x20252F1 VA: 0x20251F0
	|-Task.FromResult<Tuple<int, int, int, bool>>
	|-Task.FromResult<BufferOffsetSize>
	|-Task.FromResult<object>
	|
	|-RVA: 0x2025110 Offset: 0x2025211 VA: 0x2025110
	|-Task.FromResult<bool>
	|
	|-RVA: 0x2025180 Offset: 0x2025281 VA: 0x2025180
	|-Task.FromResult<int>
	*/

	// RVA: 0x3667550 Offset: 0x3667651 VA: 0x3667550
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2024EA0 Offset: 0x2024FA1 VA: 0x2024EA0
	|-Task.FromException<int>
	|
	|-RVA: 0x2024F70 Offset: 0x2025071 VA: 0x2024F70
	|-Task.FromException<object>
	|
	|-RVA: 0x2025040 Offset: 0x2025141 VA: 0x2025040
	|-Task.FromException<VoidTaskResult>
	*/

	[FriendAccessAllowedAttribute] // RVA: 0x47CDC0 Offset: 0x47CEC1 VA: 0x47CDC0
	// RVA: 0x36675D0 Offset: 0x36676D1 VA: 0x36675D0
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	[FriendAccessAllowedAttribute] // RVA: 0x47CDD0 Offset: 0x47CED1 VA: 0x47CDD0
	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20249C0 Offset: 0x2024AC1 VA: 0x20249C0
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0x2024B60 Offset: 0x2024C61 VA: 0x2024B60
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x2024D00 Offset: 0x2024E01 VA: 0x2024D00
	|-Task.FromCancellation<object>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2024A90 Offset: 0x2024B91 VA: 0x2024A90
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x2024C30 Offset: 0x2024D31 VA: 0x2024C30
	|-Task.FromCancellation<object>
	|
	|-RVA: 0x2024DD0 Offset: 0x2024ED1 VA: 0x2024DD0
	|-Task.FromCancellation<VoidTaskResult>
	*/

	// RVA: 0x36676A0 Offset: 0x36677A1 VA: 0x36676A0
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2025260 Offset: 0x2025361 VA: 0x2025260
	|-Task.Run<int>
	|
	|-RVA: 0x2025450 Offset: 0x2025551 VA: 0x2025450
	|-Task.Run<object>
	|-Task.Run<Stream>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20253D0 Offset: 0x20254D1 VA: 0x20253D0
	|-Task.Run<object>
	|-Task.Run<WebResponse>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20255C0 Offset: 0x20256C1 VA: 0x20255C0
	|-Task.Run<object>
	*/

	// RVA: 0x36677C0 Offset: 0x36678C1 VA: 0x36677C0
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x3667830 Offset: 0x3667931 VA: 0x3667830
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: 0x3667BC0 Offset: 0x3667CC1 VA: 0x3667BC0
	public static Task<Task> WhenAny(Task[] tasks) { }

	// RVA: 0x3668120 Offset: 0x3668221 VA: 0x3668120
	public static Task<Task> WhenAny(IEnumerable<Task> tasks) { }

	// RVA: 0x3668540 Offset: 0x3668641 VA: 0x3668540
	private static void .cctor() { }
}

