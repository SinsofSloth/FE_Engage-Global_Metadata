// Namespace: 
internal struct ExecutionContext.Reader // TypeDefIndex: 761
{
	// Fields
	private ExecutionContext m_ec; // 0x0

	// Properties
	public bool IsNull { get; }
	public bool IsFlowSuppressed { get; }
	public SynchronizationContext SynchronizationContext { get; }
	public SynchronizationContext SynchronizationContextNoFlow { get; }
	public LogicalCallContext.Reader LogicalCallContext { get; }

	// Methods

	// RVA: 0x35EB230 Offset: 0x35EB331 VA: 0x35EB230
	public void .ctor(ExecutionContext ec) { }

	// RVA: 0x35EB240 Offset: 0x35EB341 VA: 0x35EB240
	public ExecutionContext DangerousGetRawExecutionContext() { }

	// RVA: 0x35EB250 Offset: 0x35EB351 VA: 0x35EB250
	public bool get_IsNull() { }

	// RVA: 0x35EB260 Offset: 0x35EB361 VA: 0x35EB260
	public bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x35EB270 Offset: 0x35EB371 VA: 0x35EB270
	public bool get_IsFlowSuppressed() { }

	// RVA: 0x35EB290 Offset: 0x35EB391 VA: 0x35EB290
	public SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x35EB2B0 Offset: 0x35EB3B1 VA: 0x35EB2B0
	public SynchronizationContext get_SynchronizationContextNoFlow() { }

	// RVA: 0x35EB2D0 Offset: 0x35EB3D1 VA: 0x35EB2D0
	public LogicalCallContext.Reader get_LogicalCallContext() { }

	// RVA: 0x35EB320 Offset: 0x35EB421 VA: 0x35EB320
	public bool HasSameLocalValues(ExecutionContext other) { }
}

