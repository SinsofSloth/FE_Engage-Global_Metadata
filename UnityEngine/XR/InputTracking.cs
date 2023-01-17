// Namespace: UnityEngine.XR
[NativeHeaderAttribute] // RVA: 0x587F0 Offset: 0x588F1 VA: 0x587F0
[RequiredByNativeCodeAttribute] // RVA: 0x587F0 Offset: 0x588F1 VA: 0x587F0
[NativeConditionalAttribute] // RVA: 0x587F0 Offset: 0x588F1 VA: 0x587F0
[StaticAccessorAttribute] // RVA: 0x587F0 Offset: 0x588F1 VA: 0x587F0
public static class InputTracking // TypeDefIndex: 4859
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x592C0 Offset: 0x593C1 VA: 0x592C0
	[CompilerGeneratedAttribute] // RVA: 0x592C0 Offset: 0x593C1 VA: 0x592C0
	private static Action<XRNodeState> trackingAcquired; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x59300 Offset: 0x59401 VA: 0x59300
	[CompilerGeneratedAttribute] // RVA: 0x59300 Offset: 0x59401 VA: 0x59300
	private static Action<XRNodeState> trackingLost; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x59340 Offset: 0x59441 VA: 0x59340
	[DebuggerBrowsableAttribute] // RVA: 0x59340 Offset: 0x59441 VA: 0x59340
	private static Action<XRNodeState> nodeAdded; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x59380 Offset: 0x59481 VA: 0x59380
	[CompilerGeneratedAttribute] // RVA: 0x59380 Offset: 0x59481 VA: 0x59380
	private static Action<XRNodeState> nodeRemoved; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x596C0 Offset: 0x597C1 VA: 0x596C0
	// RVA: 0x1C4ECC0 Offset: 0x1C4EDC1 VA: 0x1C4ECC0
	private static void InvokeTrackingEvent(InputTracking.TrackingStateEventType eventType, XRNode nodeType, long uniqueID, bool tracked) { }

	// RVA: 0x1C4EF70 Offset: 0x1C4F071 VA: 0x1C4EF70
	private static void .cctor() { }
}

