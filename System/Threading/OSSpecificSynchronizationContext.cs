// Namespace: System.Threading
internal class OSSpecificSynchronizationContext : SynchronizationContext // TypeDefIndex: 776
{
	// Fields
	private object m_OSSynchronizationContext; // 0x18
	private static readonly ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache; // 0x0

	// Methods

	// RVA: 0x3861CB0 Offset: 0x3861DB1 VA: 0x3861CB0
	private void .ctor(object osContext) { }

	// RVA: 0x3861CF0 Offset: 0x3861DF1 VA: 0x3861CF0
	public static OSSpecificSynchronizationContext Get() { }

	// RVA: 0x3861EA0 Offset: 0x3861FA1 VA: 0x3861EA0 Slot: 8
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x3861F20 Offset: 0x3862021 VA: 0x3861F20 Slot: 4
	public override void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x3861F60 Offset: 0x3862061 VA: 0x3861F60 Slot: 5
	public override void Post(SendOrPostCallback d, object state) { }

	[OSSpecificSynchronizationContext.MonoPInvokeCallbackAttribute] // RVA: 0x47C7A0 Offset: 0x47C8A1 VA: 0x47C7A0
	// RVA: 0x3861B20 Offset: 0x3861C21 VA: 0x3861B20
	private static void InvocationEntry(IntPtr arg) { }

	// RVA: 0x3861E90 Offset: 0x3861F91 VA: 0x3861E90
	private static object GetOSContext() { }

	// RVA: 0x38620E0 Offset: 0x38621E1 VA: 0x38620E0
	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg) { }

	// RVA: 0x38620F0 Offset: 0x38621F1 VA: 0x38620F0
	private static void .cctor() { }
}

