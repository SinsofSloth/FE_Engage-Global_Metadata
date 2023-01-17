// Namespace: Cinemachine
[SaveDuringPlayAttribute] // RVA: 0x1B650 Offset: 0x1B751 VA: 0x1B650
[AddComponentMenu] // RVA: 0x1B650 Offset: 0x1B751 VA: 0x1B650
[DocumentationSortingAttribute] // RVA: 0x1B650 Offset: 0x1B751 VA: 0x1B650
public class CinemachineSameAsFollowTarget : CinemachineComponentBase // TypeDefIndex: 5801
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x206D0 Offset: 0x207D1 VA: 0x206D0
	[TooltipAttribute] // RVA: 0x206D0 Offset: 0x207D1 VA: 0x206D0
	public float m_Damping; // 0x50
	private Quaternion m_PreviousReferenceOrientation; // 0x54

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }

	// Methods

	// RVA: 0x1BA7080 Offset: 0x1BA7181 VA: 0x1BA7080 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1BA7120 Offset: 0x1BA7221 VA: 0x1BA7120 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1BA7130 Offset: 0x1BA7231 VA: 0x1BA7130 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1BA7140 Offset: 0x1BA7241 VA: 0x1BA7140 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1BA7230 Offset: 0x1BA7331 VA: 0x1BA7230
	public void .ctor() { }
}

