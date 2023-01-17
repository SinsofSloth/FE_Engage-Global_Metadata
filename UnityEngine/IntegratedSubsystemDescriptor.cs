// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x78EA0 Offset: 0x78FA1 VA: 0x78EA0
public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor // TypeDefIndex: 4750
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string id { get; }

	// Methods

	// RVA: 0x1C63E50 Offset: 0x1C63F51 VA: 0x1C63E50 Slot: 4
	public string get_id() { }

	// RVA: 0x1C63EF0 Offset: 0x1C63FF1 VA: 0x1C63EF0
	protected void .ctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x78EE0 Offset: 0x78FE1 VA: 0x78EE0
[NativeHeaderAttribute] // RVA: 0x78EE0 Offset: 0x78FE1 VA: 0x78EE0
public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor // TypeDefIndex: 4751
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1EB3770 Offset: 0x1EB3871 VA: 0x1EB3770
	|-IntegratedSubsystemDescriptor<object>..ctor
	|-IntegratedSubsystemDescriptor<XRDisplaySubsystem>..ctor
	|-IntegratedSubsystemDescriptor<XRInputSubsystem>..ctor
	|-IntegratedSubsystemDescriptor<XRMeshSubsystem>..ctor
	*/
}

