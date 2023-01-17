// Namespace: 
private struct UnitySynchronizationContext.WorkRequest // TypeDefIndex: 3616
{
	// Fields
	private readonly SendOrPostCallback m_DelagateCallback; // 0x0
	private readonly object m_DelagateState; // 0x8
	private readonly ManualResetEvent m_WaitHandle; // 0x10

	// Methods

	// RVA: 0x384C920 Offset: 0x384CA21 VA: 0x384C920
	public void .ctor(SendOrPostCallback callback, object state, ManualResetEvent waitHandle) { }

	// RVA: 0x384CC90 Offset: 0x384CD91 VA: 0x384CC90
	public void Invoke() { }
}

