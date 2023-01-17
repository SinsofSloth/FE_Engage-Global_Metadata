// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x78E10 Offset: 0x78F11 VA: 0x78E10
[NativeHeaderAttribute] // RVA: 0x78E10 Offset: 0x78F11 VA: 0x78E10
public class IntegratedSubsystem : ISubsystem // TypeDefIndex: 4748
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal ISubsystemDescriptor m_SubsystemDescriptor; // 0x18

	// Properties
	public bool running { get; }
	internal bool valid { get; }

	// Methods

	// RVA: 0x1C63CB0 Offset: 0x1C63DB1 VA: 0x1C63CB0
	internal void SetHandle(IntegratedSubsystem subsystem) { }

	// RVA: 0x1C63D00 Offset: 0x1C63E01 VA: 0x1C63D00 Slot: 4
	public bool get_running() { }

	// RVA: 0x1C63DA0 Offset: 0x1C63EA1 VA: 0x1C63DA0
	internal bool get_valid() { }

	// RVA: 0x1C63DF0 Offset: 0x1C63EF1 VA: 0x1C63DF0
	internal bool IsRunning() { }

	// RVA: 0x1C63E40 Offset: 0x1C63F41 VA: 0x1C63E40
	public void .ctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x78E60 Offset: 0x78F61 VA: 0x78E60
public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem // TypeDefIndex: 4749
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB3780 Offset: 0x1EB3881 VA: 0x1EB3780
	|-IntegratedSubsystem<object>..ctor
	|-IntegratedSubsystem<XRDisplaySubsystemDescriptor>..ctor
	|-IntegratedSubsystem<XRInputSubsystemDescriptor>..ctor
	|-IntegratedSubsystem<XRMeshSubsystemDescriptor>..ctor
	*/
}

