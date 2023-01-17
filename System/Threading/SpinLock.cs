// Namespace: System.Threading
[DebuggerTypeProxyAttribute] // RVA: 0x473200 Offset: 0x473301 VA: 0x473200
[DebuggerDisplayAttribute] // RVA: 0x473200 Offset: 0x473301 VA: 0x473200
[ComVisibleAttribute] // RVA: 0x473200 Offset: 0x473301 VA: 0x473200
public struct SpinLock // TypeDefIndex: 746
{
	// Fields
	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	// Properties
	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }

	// Methods

	// RVA: 0x382E100 Offset: 0x382E201 VA: 0x382E100
	public void .ctor(bool enableThreadOwnerTracking) { }

	// RVA: 0x382E140 Offset: 0x382E241 VA: 0x382E140
	public void Enter(ref bool lockTaken) { }

	// RVA: 0x382E700 Offset: 0x382E801 VA: 0x382E700
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x382E1D0 Offset: 0x382E2D1 VA: 0x382E1D0
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x382EA50 Offset: 0x382EB51 VA: 0x382EA50
	private void DecrementWaiters() { }

	// RVA: 0x382E7D0 Offset: 0x382E8D1 VA: 0x382E7D0
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContractAttribute] // RVA: 0x47C560 Offset: 0x47C661 VA: 0x47C560
	// RVA: 0x382EC60 Offset: 0x382ED61 VA: 0x382EC60
	public void Exit(bool useMemoryBarrier) { }

	// RVA: 0x382ECC0 Offset: 0x382EDC1 VA: 0x382ECC0
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContractAttribute] // RVA: 0x47C580 Offset: 0x47C681 VA: 0x47C580
	// RVA: 0x382EDC0 Offset: 0x382EEC1 VA: 0x382EDC0
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContractAttribute] // RVA: 0x47C5A0 Offset: 0x47C6A1 VA: 0x47C5A0
	// RVA: 0x382E7A0 Offset: 0x382E8A1 VA: 0x382E7A0
	public bool get_IsThreadOwnerTrackingEnabled() { }

	// RVA: 0x382EE60 Offset: 0x382EF61 VA: 0x382EE60
	private static void .cctor() { }
}

