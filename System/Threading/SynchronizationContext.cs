// Namespace: System.Threading
public class SynchronizationContext // TypeDefIndex: 771
{
	// Fields
	private SynchronizationContextProperties _props; // 0x10
	private static Type s_cachedPreparedType1; // 0x0
	private static Type s_cachedPreparedType2; // 0x8
	private static Type s_cachedPreparedType3; // 0x10
	private static Type s_cachedPreparedType4; // 0x18
	private static Type s_cachedPreparedType5; // 0x20

	// Properties
	public static SynchronizationContext Current { get; }
	internal static SynchronizationContext CurrentNoFlow { get; }

	// Methods

	// RVA: 0x365D1F0 Offset: 0x365D2F1 VA: 0x365D1F0
	public void .ctor() { }

	// RVA: 0x365D200 Offset: 0x365D301 VA: 0x365D200 Slot: 4
	public virtual void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x365D210 Offset: 0x365D311 VA: 0x365D210 Slot: 5
	public virtual void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x365D2B0 Offset: 0x365D3B1 VA: 0x365D2B0 Slot: 6
	public virtual void OperationStarted() { }

	// RVA: 0x365D2C0 Offset: 0x365D3C1 VA: 0x365D2C0 Slot: 7
	public virtual void OperationCompleted() { }

	// RVA: 0x365D2D0 Offset: 0x365D3D1 VA: 0x365D2D0
	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

	// RVA: 0x365D320 Offset: 0x365D421 VA: 0x365D320
	public static SynchronizationContext get_Current() { }

	[FriendAccessAllowedAttribute] // RVA: 0x47C790 Offset: 0x47C891 VA: 0x47C790
	// RVA: 0x365D430 Offset: 0x365D531 VA: 0x365D430
	internal static SynchronizationContext get_CurrentNoFlow() { }

	// RVA: 0x365D3C0 Offset: 0x365D4C1 VA: 0x365D3C0
	private static SynchronizationContext GetThreadLocalContext() { }

	// RVA: 0x365D4D0 Offset: 0x365D5D1 VA: 0x365D4D0 Slot: 8
	public virtual SynchronizationContext CreateCopy() { }
}

