// Namespace: System.Threading.Tasks
internal class TaskExceptionHolder // TypeDefIndex: 860
{
	// Fields
	private static readonly bool s_failFastOnUnobservedException; // 0x0
	private static bool s_domainUnloadStarted; // 0x1
	private static EventHandler s_adUnloadEventHandler; // 0x8
	private readonly Task m_task; // 0x10
	private List<ExceptionDispatchInfo> m_faultExceptions; // 0x18
	private ExceptionDispatchInfo m_cancellationException; // 0x20
	private bool m_isHandled; // 0x28

	// Properties
	internal bool ContainsFaultList { get; }

	// Methods

	// RVA: 0x36632C0 Offset: 0x36633C1 VA: 0x36632C0
	internal void .ctor(Task task) { }

	// RVA: 0x3669110 Offset: 0x3669211 VA: 0x3669110
	private static bool ShouldFailFastOnUnobservedException() { }

	// RVA: 0x3668FD0 Offset: 0x36690D1 VA: 0x3668FD0
	private static void EnsureADUnloadCallbackRegistered() { }

	// RVA: 0x3669120 Offset: 0x3669221 VA: 0x3669120
	private static void AppDomainUnloadCallback(object sender, EventArgs e) { }

	// RVA: 0x3669190 Offset: 0x3669291 VA: 0x3669190 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x36626E0 Offset: 0x36627E1 VA: 0x36626E0
	internal bool get_ContainsFaultList() { }

	// RVA: 0x3663360 Offset: 0x3663461 VA: 0x3663360
	internal void Add(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x3669960 Offset: 0x3669A61 VA: 0x3669960
	private void SetCancellationException(object exceptionObject) { }

	// RVA: 0x3669AB0 Offset: 0x3669BB1 VA: 0x3669AB0
	private void AddFaultException(object exceptionObject) { }

	// RVA: 0x366A130 Offset: 0x366A231 VA: 0x366A130
	private void MarkAsUnhandled() { }

	// RVA: 0x3662F40 Offset: 0x3663041 VA: 0x3662F40
	internal void MarkAsHandled(bool calledFromFinalizer) { }

	// RVA: 0x3663410 Offset: 0x3663511 VA: 0x3663410
	internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException) { }

	// RVA: 0x3663750 Offset: 0x3663851 VA: 0x3663750
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x366A1B0 Offset: 0x366A2B1 VA: 0x366A1B0
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x366A1C0 Offset: 0x366A2C1 VA: 0x366A1C0
	private static void .cctor() { }
}

