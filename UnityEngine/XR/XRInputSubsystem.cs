// Namespace: UnityEngine.XR
[NativeConditionalAttribute] // RVA: 0x58F30 Offset: 0x59031 VA: 0x58F30
[NativeTypeAttribute] // RVA: 0x58F30 Offset: 0x59031 VA: 0x58F30
[UsedByNativeCodeAttribute] // RVA: 0x58F30 Offset: 0x59031 VA: 0x58F30
public class XRInputSubsystem : IntegratedSubsystem<XRInputSubsystemDescriptor> // TypeDefIndex: 4878
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x59500 Offset: 0x59601 VA: 0x59500
	[CompilerGeneratedAttribute] // RVA: 0x59500 Offset: 0x59601 VA: 0x59500
	private Action<XRInputSubsystem> trackingOriginUpdated; // 0x20
	[DebuggerBrowsableAttribute] // RVA: 0x59540 Offset: 0x59641 VA: 0x59540
	[CompilerGeneratedAttribute] // RVA: 0x59540 Offset: 0x59641 VA: 0x59540
	private Action<XRInputSubsystem> boundaryChanged; // 0x28

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x59AA0 Offset: 0x59BA1 VA: 0x59AA0
	// RVA: 0x1C4FD00 Offset: 0x1C4FE01 VA: 0x1C4FD00
	private static void InvokeTrackingOriginUpdatedEvent(IntPtr internalPtr) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x59AE0 Offset: 0x59BE1 VA: 0x59AE0
	// RVA: 0x1C4FE00 Offset: 0x1C4FF01 VA: 0x1C4FE00
	private static void InvokeBoundaryChangedEvent(IntPtr internalPtr) { }

	// RVA: 0x1C4FF00 Offset: 0x1C50001 VA: 0x1C4FF00
	public void .ctor() { }
}

